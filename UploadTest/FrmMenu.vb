Imports System.Data.SqlClient

Public Class FrmMenu
    Private Sub FrmMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Load_gridCat()
        Load_gridOrdenCat()
    End Sub

    'Listado Categoria
    Sub Load_gridCat()
        GridControlListadoCat.DataSource = Logica.listadoCategoria
    End Sub

    Sub Load_gridOrdenCat()
        GridControlListadoOrden.DataSource = Logica.listadoOrdenCategoria
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

End Class