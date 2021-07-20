Imports AccesoDatos
Public Module UploadImagesBIL
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

End Module
