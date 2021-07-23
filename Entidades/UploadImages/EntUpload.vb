Public Class EntUpload
    Private _id As Integer
    Private _nombre As String
    Private _fecha As Date
    Private _ruta As String
    Private _Categoria As String

    Public Property id As Integer
        Get
            Return _id
        End Get
        Set(value As Integer)
            _id = value
        End Set
    End Property

    Public Property nombre As String
        Get
            Return _nombre
        End Get
        Set(value As String)
            _nombre = value
        End Set
    End Property

    Public Property fecha As Date
        Get
            Return _fecha
        End Get
        Set(value As Date)
            _fecha = value
        End Set
    End Property

    Public Property ruta As String
        Get
            Return _ruta
        End Get
        Set(value As String)
            _ruta = value
        End Set
    End Property

    Public result As Integer

    Public Property Categoria As String
        Get
            Return _Categoria
        End Get
        Set(value As String)
            _Categoria = value
        End Set
    End Property

End Class
