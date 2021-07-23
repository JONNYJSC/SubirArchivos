Public Class FrmPrincipal

    Private Sub FrmPrincipal_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnCategoria_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnCategoria.ItemClick
        FrmCategoria.ShowDialog()
    End Sub

    Private Sub btnOrden_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnOrden.ItemClick
        FrmOrden.ShowDialog()
    End Sub
End Class