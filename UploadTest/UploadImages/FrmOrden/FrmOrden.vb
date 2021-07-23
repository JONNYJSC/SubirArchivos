
Public Class FrmOrden
    Private Sub FrmOrden_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ComboboxCategoria.Properties.DataSource = Logica.listadoCategoriaCombo
        ComboboxCategoria.Properties.DisplayMember = "Nombre_Categoria"
        ComboboxCategoria.Properties.ValueMember = "Id_Categoria"


    End Sub
    'metodo seleccion del combobox
    Sub seleccion()
        'Dim pos, pos2 As Integer
        'pos = ComboboxCategoria.TabIndex
        Dim name As String
        name = ComboboxCategoria.Text
        'pos2 = ComboboxCategoria.GetSelectedDataRow()
    End Sub

    Private Sub btnGuardarOrden_Click(sender As Object, e As EventArgs) Handles btnGuardarOrden.Click
        seleccion()
    End Sub

End Class