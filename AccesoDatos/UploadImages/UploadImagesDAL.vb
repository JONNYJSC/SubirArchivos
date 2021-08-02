Imports System.Configuration
Imports System.Data.SqlClient
Imports System.IO

Public Module UploadImagesDAL
    ' Dim devServerConnectionStr As ConfigurationManager.
    Dim devServerConnectionStr As String = ConfigurationManager.ConnectionStrings("devServer").ConnectionString

    Public Function cargarArchivos() As DataTable
        Dim datosTablaArchivos As DataTable
        Try
            Dim sqlda As SqlDataAdapter
            Using cnn = New SqlConnection(devServerConnectionStr)
                Dim cmm As New SqlCommand("SP_ListarArchivos", cnn)
                cmm.CommandType = CommandType.StoredProcedure
                sqlda = New SqlDataAdapter(cmm)
                datosTablaArchivos = New DataTable("tb_Archivo")
                sqlda.Fill(datosTablaArchivos)
                cmm.Parameters.Clear()
            End Using
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

    '-------------------------------------------------------------------------------
    Public Function guardarCategoria(obj As Entidades.EntUpload) As Entidades.EntUpload
        Try
            Using cnn As New SqlConnection(devServerConnectionStr)
                Dim cmm As New SqlCommand("SP_nuevaCategoria", cnn)
                cmm.CommandType = CommandType.StoredProcedure
                cmm.Parameters.AddWithValue("@Nombre_Categoria", obj.Categoria)
                cnn.Open()
                obj.result = cmm.ExecuteNonQuery()
            End Using

        Catch ex As Exception
            Throw ex
        End Try

        Return obj
    End Function

    Public Function cargarCategoria() As DataTable
        Dim datosTablaArchivos As DataTable
        Try
            Dim sqlda As SqlDataAdapter
            Using cnn = New SqlConnection(devServerConnectionStr)
                Dim cmm As New SqlCommand("SP_ListarCategorias", cnn)
                cmm.CommandType = CommandType.StoredProcedure
                sqlda = New SqlDataAdapter(cmm)
                datosTablaArchivos = New DataTable("tb_Categoria")
                sqlda.Fill(datosTablaArchivos)
                cmm.Parameters.Clear()
            End Using
        Catch ex As Exception
            Throw ex
        End Try
        Return datosTablaArchivos
    End Function

    Public Function guardarOrdenCat(obj As Entidades.EntUpload) As Entidades.EntUpload
        Try
            Using cnn As New SqlConnection(devServerConnectionStr)
                Dim cmm As New SqlCommand("SP_nuevaOrden", cnn)
                cmm.CommandType = CommandType.StoredProcedure
                cmm.Parameters.AddWithValue("@Nombre_Orden", obj.Orden)
                cmm.Parameters.AddWithValue("@Id_Categoria", obj.IdCategoriaOrden)
                cnn.Open()
                obj.result = cmm.ExecuteNonQuery()
            End Using

        Catch ex As Exception
            Throw ex
        End Try

        Return obj
    End Function

    Public Function cargarOrdenCategoria() As DataTable
        Dim datosTablaArchivos As DataTable
        Try
            Dim sqlda As SqlDataAdapter
            Using cnn = New SqlConnection(devServerConnectionStr)
                'Dim cmm As New SqlCommand("SP_ListarRegistro", cnn)
                Dim cmm As New SqlCommand("SP_ListarOrdenCategoria", cnn)
                cmm.CommandType = CommandType.StoredProcedure
                sqlda = New SqlDataAdapter(cmm)
                datosTablaArchivos = New DataTable("tb_Orden")
                sqlda.Fill(datosTablaArchivos)
                cmm.Parameters.Clear()
            End Using
        Catch ex As Exception
            Throw ex
        End Try
        Return datosTablaArchivos
    End Function

    Public Function cargarRegistro() As DataTable
        Dim datosTablaArchivos As DataTable
        Try
            Dim sqlda As SqlDataAdapter
            Using cnn = New SqlConnection(devServerConnectionStr)
                'Dim cmm As New SqlCommand("SP_ListarRegistro", cnn)
                Dim cmm As New SqlCommand("SP_ListarRegistro", cnn)
                cmm.CommandType = CommandType.StoredProcedure
                sqlda = New SqlDataAdapter(cmm)
                datosTablaArchivos = New DataTable("tb_Registro2")
                sqlda.Fill(datosTablaArchivos)
                cmm.Parameters.Clear()
            End Using
        Catch ex As Exception
            Throw ex
        End Try
        Return datosTablaArchivos
    End Function

    'Nota importante cambiar la tabla resgitro2 agregar idOrden y quitar idcategoria
    Public Function guardarRegistro(obj As Entidades.EntUpload) As Entidades.EntUpload
        Try
            Dim ruta As New FileStream(obj.ruta, FileMode.Open, FileAccess.Read)
            Dim binario(ruta.Length) As Byte
            ruta.Read(binario, 0, ruta.Length) 'Leo el archivo y lo convierto a binario 
            ruta.Close() 'Cierro el FileStream 

            Using cnn As New SqlConnection(devServerConnectionStr)
                Dim cmm As New SqlCommand("SP_nuevoRegistro2", cnn)
                cmm.CommandType = CommandType.StoredProcedure
                cmm.Parameters.AddWithValue("@Nombre_Registro", obj.nombre)
                cmm.Parameters.AddWithValue("@Fecha_Registro", obj.fecha)
                cmm.Parameters.AddWithValue("@Archivo_Registro", binario)

                cmm.Parameters.AddWithValue("@IdCategoria", obj.IdOrdenRegistro)
                cnn.Open()
                obj.result = cmm.ExecuteNonQuery()
            End Using

        Catch ex As Exception
            Throw ex
        End Try

        Return obj
    End Function

    Public Function cargarRegistroOrden(obj As Entidades.EntUpload) As DataTable
        Dim datosTablaArchivos As DataTable
        Try
            Dim sqlda As SqlDataAdapter
            Using cnn = New SqlConnection(devServerConnectionStr)
                Dim cmm As New SqlCommand("SP_ListarRegistroCategoria", cnn)
                cmm.CommandType = CommandType.StoredProcedure
                cmm.Parameters.AddWithValue("@BusqRegistCategoria", obj.IdOrdenRegistro)
                sqlda = New SqlDataAdapter(cmm)
                datosTablaArchivos = New DataTable("tb_Categoria")
                sqlda.Fill(datosTablaArchivos)
                cmm.Parameters.Clear()
            End Using
        Catch ex As Exception
            Throw ex
        End Try
        Return datosTablaArchivos
    End Function

    'Consulta para traer las categorias al comboboxEdit
    Public Function cargarCategoria2() As List(Of String)
        Dim list As New List(Of String)
        Try
            Using cnn = New SqlConnection(devServerConnectionStr)
                cnn.Open()
                Dim query As String = String.Format("select Nombre_Categoria from tb_Categoria")
                Dim cmd As New SqlCommand(query, cnn)
                Dim rd As SqlDataReader
                rd = cmd.ExecuteReader
                If rd.HasRows Then
                    While (rd.Read)
                        list.Add(rd("Nombre_Categoria"))
                    End While
                End If
                cnn.Close()
            End Using
        Catch ex As Exception

        End Try
        Return list
    End Function

    'Consulta para traer las orden al comboboxEdit
    Public Function cargarOrden2() As List(Of String)
        Dim list As New List(Of String)
        Try
            Using cnn = New SqlConnection(devServerConnectionStr)
                cnn.Open()
                Dim query As String = String.Format("select Nombre_Orden from tb_Orden")
                Dim cmd As New SqlCommand(query, cnn)
                Dim rd As SqlDataReader
                rd = cmd.ExecuteReader
                If rd.HasRows Then
                    While (rd.Read)
                        list.Add(rd("Nombre_Orden"))
                    End While
                End If
                cnn.Close()
            End Using
        Catch ex As Exception

        End Try
        Return list
    End Function

End Module
