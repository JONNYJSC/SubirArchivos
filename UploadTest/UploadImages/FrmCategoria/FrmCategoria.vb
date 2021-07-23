Public Class FrmCategoria
    Private Sub FrmCategoria_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Load_grid()
    End Sub

    'metodo para pasar parametros guardar archivo
    Sub guardarCategoria()
        Dim obj As New Entidades.EntUpload()

        obj.Categoria = txtCategoria.Text
        Logica.guardadoCategoria(obj)
        If obj.result > 0 Then
            Me.Load_grid()
            Me.Limpiar()
        Else
            MsgBox("Ocurrio un error")
        End If
    End Sub

    'Limpiar cajas de texto
    Public Sub Limpiar()
        txtCategoria.Text = ""
    End Sub

    Sub Load_grid()
        'TODO: This line of code loads data into the 'SP_ListarCategoria._SP_ListarCategoria' table. You can move, or remove it, as needed.
        Me.SP_ListarCategoriaTableAdapter.Fill(Me.SP_ListarCategoria._SP_ListarCategoria)
    End Sub

    Private Sub btnAgregarCategoria_Click(sender As Object, e As EventArgs) Handles btnAgregarCategoria.Click
        guardarCategoria()
    End Sub

End Class