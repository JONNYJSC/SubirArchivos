﻿Imports System.Configuration
Imports AccesoDatos

Public Module UploadImagesBIL
    Public devServerConnectionStr As String = ConfigurationManager.ConnectionStrings("devServer").ConnectionString

    Public Function listadoImagenes() As DataTable
        Return UploadImagesDAL.cargarArchivos
    End Function

    Public Function guardadoImagenes(obj As Entidades.EntUpload) As Entidades.EntUpload
        Return UploadImagesDAL.guardarArchivos(obj)
    End Function

    Public Function editarImagenes(obj As Entidades.EntUpload) As Entidades.EntUpload
        Return UploadImagesDAL.editarArchivos(obj)
    End Function

    Public Function eliminarImagenes(obj As Entidades.EntUpload) As Entidades.EntUpload
        Return UploadImagesDAL.eliminarArchivos(obj)
    End Function

    '--------------------------------------------------------------------
    Public Function guardadoCategoria(obj As Entidades.EntUpload) As Entidades.EntUpload
        Return UploadImagesDAL.guardarCategoria(obj)
    End Function

    Public Function listadoCategoria() As DataTable
        Return UploadImagesDAL.cargarCategoria
    End Function

    Public Function guardadoOrden(obj As Entidades.EntUpload) As Entidades.EntUpload
        Return UploadImagesDAL.guardarOrdenCat(obj)
    End Function

    Public Function listadoOrdenCategoria() As DataTable
        Return UploadImagesDAL.cargarOrdenCategoria
    End Function

    Public Function listadoRegistro() As DataTable
        Return UploadImagesDAL.cargarRegistro
    End Function

    Public Function guardadoRegistro(obj As Entidades.EntUpload) As Entidades.EntUpload
        Return UploadImagesDAL.guardarRegistro(obj)
    End Function

End Module
