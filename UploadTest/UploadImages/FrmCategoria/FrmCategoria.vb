Imports DevExpress.XtraBars.Docking

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

    'Agrega un panel al lado izquierdo
    Private Sub btnPanel_Click(sender As Object, e As EventArgs) Handles btnPanel.Click
        ' Create a dock manager
        Dim dm As DockManager = New DockManager
        ' Specify the form to which the dock panels will be added
        dm.Form = Me
        ' Create a new panel and dock it to the left edge of the form
        Dim dp1 As DockPanel = dm.AddPanel(DockingStyle.Left)
        dp1.Text = "Panel 1"
    End Sub
End Class