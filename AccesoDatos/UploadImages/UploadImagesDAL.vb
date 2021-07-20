﻿Imports System.Configuration
Imports System.Data.SqlClient
Imports System.IO

Public Module UploadImagesDAL
    ' Dim devServerConnectionStr As ConfigurationManager.
    Dim devServerConnectionStr As String = ConfigurationManager.ConnectionStrings("devServer").ConnectionString

    Public Function cargarArchivos() As DataTable
        Dim datosTablaArchivos As DataTable
        Try
            Dim sqlda As SqlDataAdapter
            Dim cnn = New SqlConnection(devServerConnectionStr)
            Dim cmm As New SqlCommand("SP_ListarArchivos", cnn)
            cmm.CommandType = CommandType.StoredProcedure
            sqlda = New SqlDataAdapter(cmm)
            datosTablaArchivos = New DataTable("tb_Archivo")
            sqlda.Fill(datosTablaArchivos)
            cmm.Parameters.Clear()
        Catch ex As Exception
            Throw ex
        End Try
        Return datosTablaArchivos
    End Function

    ' procedimiento para almacenar los archivos
    Public Function guardarArchivos(obj As Entidades.EntUpload) As Entidades.EntUpload
        Try
            Dim ruta As New FileStream(obj.ruta, FileMode.Open, FileAccess.Read)
            Dim binario(ruta.Length) As Byte
            ruta.Read(binario, 0, ruta.Length) 'Leo el archivo y lo convierto a binario 
            ruta.Close() 'Cierro el FileStream 

            Using cnn As New SqlConnection(devServerConnectionStr)
                Dim cmm As New SqlCommand("SP_nuevoArchivo", cnn)
                cmm.CommandType = CommandType.StoredProcedure
                cmm.Parameters.AddWithValue("fecha", obj.fecha)
                cmm.Parameters.AddWithValue("@nombre", obj.nombre)
                cmm.Parameters.AddWithValue("@archivo", binario)
                cnn.Open()
                obj.result = cmm.ExecuteNonQuery()
            End Using

        Catch ex As Exception
            Throw ex
        End Try

        Return obj
    End Function

    ' procedimiento para editar los archivos
    Public Function editarArchivos(obj As Entidades.EntUpload) As Entidades.EntUpload
        Try
            Using cnn As New SqlConnection(devServerConnectionStr)
                Dim cmm As New SqlCommand("SP_editarArchivo", cnn)
                cmm.CommandType = CommandType.StoredProcedure
                cmm.Parameters.AddWithValue("@id", obj.id)
                cmm.Parameters.AddWithValue("@fecha", obj.fecha)
                cmm.Parameters.AddWithValue("@nombre", obj.nombre)
                cnn.Open()
                obj.result = cmm.ExecuteNonQuery()
            End Using
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        Return obj
    End Function

    ' procedimiento para eliminar los archivos
    Public Function eliminarArchivos(obj As Entidades.EntUpload) As Entidades.EntUpload
        Try
            Using cnn As New SqlConnection(devServerConnectionStr)
                Dim cmm As New SqlCommand("SP_eliminarArchivo", cnn)
                cmm.CommandType = CommandType.StoredProcedure
                cmm.Parameters.AddWithValue("@id", obj.id)
                cnn.Open()
                obj.result = cmm.ExecuteNonQuery()
            End Using
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        Return obj
    End Function
End Module
