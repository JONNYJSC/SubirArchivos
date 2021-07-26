Public Class EntUpload
    Private _id As Integer
    Private _nombre As String
    Private _fecha As Date
    Private _ruta As String

    Private _Categoria As String

    Private _Orden As String
    Private _IdCatOrden As Integer
    Private _IdOrdenRegistro As Integer
    Private _IdRegistro As Integer

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

    Public Property Orden As String
        Get
            Return _Orden
        End Get
        Set(value As String)
            _Orden = value
        End Set
    End Property

    Public Property IdCategoriaOrden As Integer
        Get
            Return _IdCatOrden
        End Get
        Set(value As Integer)
            _IdCatOrden = value
        End Set
    End Property

    Public Property IdOrdenRegistro As Integer
        Get
            Return _IdOrdenRegistro
        End Get
        Set(value As Integer)
            _IdOrdenRegistro = value
        End Set
    End Property

    Public Property IdRegistro As Integer
        Get
            Return _IdRegistro
        End Get
        Set(value As Integer)
            _IdRegistro = value
        End Set
    End Property

End Class
