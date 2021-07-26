Imports System.Data.SqlClient
Imports System.IO

Public Class FrmMenu
    Dim cnn As New SqlConnection
    ' Me trae la fecha actual
    Dim saveUcnow As DateTime = DateTime.Now

    Private Sub FrmMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Load_gridCat()
        Load_gridOrdenCat()
        Load_Registro()
        lbFecha.Text = saveUcnow.ToString("dd/MM/yyyy")
    End Sub

    'Listado Categoria
    Sub Load_gridCat()
        GridControlListadoCat.DataSource = Logica.listadoCategoria
    End Sub

    Sub Load_gridOrdenCat()
        GridControlListadoOrden.DataSource = Logica.listadoOrdenCategoria
    End Sub

    Sub Load_Registro()
        GridControlListadoRegistro.DataSource = Logica.listadoRegistro
    End Sub

    Private Sub btnAgregarCateg_Click(sender As Object, e As EventArgs) Handles btnAgregarCateg.Click
        If Trim(txtNombreCat.Text) = "" Then
            MsgBox("Llenar Campo Nombre Porfavor", MsgBoxStyle.Critical, "Operacion no valida")
        Else
            guardarCategoria()
        End If
    End Sub

    'metodo para pasar parametros guardar archivo
    Sub guardarCategoria()
        Dim obj As New Entidades.EntUpload()

        obj.Categoria = txtNombreCat.Text
        Logica.guardadoCategoria(obj)
        If obj.result > 0 Then
            Me.Load_gridCat()
            Me.LimpiarCar()
        Else
            MsgBox("Ocurrio un error")
        End If
    End Sub

    'Limpiar textos Categoria
    Sub LimpiarCar()
        txtNombreCat.Text = ""
    End Sub

    Private Sub btnAgregarOrden_Click(sender As Object, e As EventArgs) Handles btnAgregarOrden.Click
        If Trim(txtNombreCat.Text) = "" Then
            MsgBox("Llenar Campo Nombre Porfavor", MsgBoxStyle.Critical, "Operacion no valida")
        Else
            guardarOrdenCategoria()
        End If
    End Sub

    'metodo para pasar parametros guardar archivo
    Sub guardarOrdenCategoria()
        Dim obj As New Entidades.EntUpload()

        obj.Orden = txtOrden.Text
        obj.IdCategoriaOrden = 3
        Logica.guardadoOrden(obj)
        If obj.result > 0 Then
            Me.Load_gridOrdenCat()
            Me.LimpiarCar()
        Else
            MsgBox("Ocurrio un error")
        End If
    End Sub

    Private Sub btnAgregarRegistro_Click(sender As Object, e As EventArgs) Handles btnAgregarRegistro.Click
        If Trim(txtNombreCat.Text) = "" Then
            MsgBox("Llenar Campo Nombre Porfavor", MsgBoxStyle.Critical, "Operacion no valida")
        Else
            guardarRegistro()
            Load_gridOrdenCat()
            Load_Registro()
        End If
    End Sub

    Sub guardarRegistro()
        Dim obj As New Entidades.EntUpload()

        obj.nombre = txtRegistro.Text
        obj.fecha = saveUcnow
        obj.ruta = txtExaminar.Text
        obj.IdOrdenRegistro = 3
        Logica.guardadoRegistro(obj)
        If obj.result > 0 Then
            Me.Load_Registro()
            Me.LimpiarRegistro()
        Else
            MsgBox("Ocurrio un error")
        End If
    End Sub

    Sub LimpiarRegistro()
        txtRegistro.Text = ""
        txtExaminar.Text = ""
    End Sub

    Private Sub btnExaminar_Click(sender As Object, e As EventArgs) Handles btnExaminar.Click
        If Trim(txtNombreCat.Text) = "" Then
            MsgBox("Llenar Campo Nombre Porfavor", MsgBoxStyle.Critical, "Operacion no valida")
        Else
            examinarArchivo()
        End If
    End Sub

    'abre los archivos del equipo
    Public Sub examinarArchivo()
        Try
            Dim archivo As New OpenFileDialog
            archivo.Filter = "Archivo PDF|*.pdf"
            If archivo.ShowDialog = DialogResult.OK Then
                txtExaminar.Text = archivo.FileName
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    'metodo para pasar parametros Orden Id
    Sub LoadRegistroOrden()
        Dim obj As New Entidades.EntUpload()

        Dim row As DataRow
        row = GridViewListadoOrdenCat.GetDataRow(GridViewListadoOrdenCat.FocusedRowHandle)
        Dim id As Integer
        id = row("IdCategoria")
        'GridViewListadoOrdenCat.DeleteRow(GridViewListadoOrdenCat.FocusedRowHandle)
        obj.IdOrdenRegistro = id

        GridControlRegistro.DataSource = Logica.listadoRegistroOrden(obj)
    End Sub

    Private Sub GridControlListadoOrden_DoubleClick(sender As Object, e As EventArgs) Handles GridControlListadoOrden.DoubleClick
        LoadRegistroOrden()
    End Sub

    Private Sub GridControlRegistro_DoubleClick(sender As Object, e As EventArgs) Handles GridControlRegistro.DoubleClick
        'Evento dobloe click del GridControl para mostrar pdf
    End Sub

    '-----------------Decodificar binario a pdf------ Verificar todo el codigo
    Sub EventoGrid()
        Try
            Dim obj As New Entidades.EntUpload
            Dim row As DataRow
            row = GridViewRegistro.GetDataRow(GridViewRegistro.FocusedRowHandle)
            Dim id As Integer
            id = row("Id_Registro")
            obj.IdRegistro = id

            Dim dr As SqlDataReader
            Dim directorioArchivo As String
            directorioArchivo = System.AppDomain.CurrentDomain.BaseDirectory() & "temp.pdf"

            Dim str_cadena As String
            str_cadena = "select * from tb_Registro2 where Id_Registro=" & id

            If conectar() = False Then
                Exit Sub
            End If

            dr = fun_ExecuteReader(str_cadena)
            If dr.HasRows Then
                While dr.Read
                    id = dr("Id_Registro")
                    If dr("Archivo_Registro") IsNot DBNull.Value Then
                        Dim bytes() As Byte
                        bytes = dr("Archivo_Registro")

                        BytesAArchivo(bytes, directorioArchivo)
                        ArcPDF.src = directorioArchivo

                        My.Computer.FileSystem.DeleteFile(directorioArchivo)
                    End If
                End While
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub BytesAArchivo(ByVal bytes() As Byte, ByVal Path As String)
        Dim K As Long
        If bytes Is Nothing Then Exit Sub
        Try
            K = UBound(bytes)
            Dim fs As New FileStream(Path, FileMode.OpenOrCreate, FileAccess.Write)
            fs.Write(bytes, 0, K)
            fs.Close()
        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

    Public Function fun_ExecuteReader(ByVal cadenasql As String, Optional i As Integer = 0) As SqlDataReader
        Try
            Dim cmd As SqlCommand

            cmd = New SqlCommand
            cmd.CommandText = cadenasql
            If i = 0 Then
                cmd.CommandType = CommandType.Text
            Else
                cmd.CommandType = CommandType.StoredProcedure
            End If
            cmd.Connection = cnn
            Return cmd.ExecuteReader()
        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        End Try
    End Function

    Public Function conectar() As Boolean
        Try
            conectar = False
            cnn = New SqlConnection
            cnn.ConnectionString = Logica.devServerConnectionStr
            If cnn.State = ConnectionState.Closed Then
                cnn.Open()
            End If
            conectar = True
        Catch ex As Exception
            conectar = False
        End Try
    End Function

End Class