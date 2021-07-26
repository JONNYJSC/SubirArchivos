Imports System.Data.SqlClient

Public Class FrmMenu

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
        guardarCategoria()
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
        guardarOrdenCategoria()
    End Sub

    'metodo para pasar parametros guardar archivo
    Sub guardarOrdenCategoria()
        Dim obj As New Entidades.EntUpload()

        obj.Orden = txtOrden.Text
        obj.IdCategoriaOrden = 1
        Logica.guardadoOrden(obj)
        If obj.result > 0 Then
            Me.Load_gridOrdenCat()
            Me.LimpiarCar()
        Else
            MsgBox("Ocurrio un error")
        End If
    End Sub

    Private Sub btnAgregarRegistro_Click(sender As Object, e As EventArgs) Handles btnAgregarRegistro.Click
        guardarRegistro()
    End Sub

    Sub guardarRegistro()
        Dim obj As New Entidades.EntUpload()

        obj.nombre = txtRegistro.Text
        obj.fecha = saveUcnow
        obj.ruta = txtExaminar.Text
        obj.IdOrdenRegistro = 2
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
        examinarArchivo()
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
End Class