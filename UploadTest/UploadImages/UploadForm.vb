Imports System.Data.SqlClient
Imports System.IO
Imports Logica
Imports Tulpep.NotificationWindow

Public Class UploadForm
    ' Me trae la fecha actual
    Dim saveUcnow As DateTime = DateTime.Now

    Private Sub FormUpload_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'desactiva la caja de texto de la ruta de los archivos
        txtRuta.Enabled = False

        'Carga el griedView
        Me.Load_grid()

        'oculta la primer cplumna de DataGriew
        GridView1.Columns(0).Visible = False

        'para mostrar la fecha en el formulario
        lbFecha.Text = saveUcnow.ToString("dd/MM/yyyy")
    End Sub

    Public Sub Load_grid()
        GridControlListar.DataSource = Logica.listadoImagenes
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        guardararchivo()
    End Sub

    'Evento boton Examinar
    Private Sub btnExaminar_Click(sender As Object, e As EventArgs) Handles btnExaminar.Click
        examinarArchivo()
    End Sub

    'Limpiar cajas de texto
    Public Sub Limpiar()
        txtPl_name.Text = ""
        txtRuta.Text = ""
    End Sub

    Private Sub txtPl_name_KeyPress(sender As Object, e As KeyPressEventArgs)
        validarLetrasyNumeros(e)
    End Sub

    'metodo para validar solo letras y numeros
    Private Sub validarLetrasyNumeros(e As KeyPressEventArgs)
        If Not Char.IsLetterOrDigit(e.KeyChar) _
                     AndAlso Not Char.IsControl(e.KeyChar) _
                     AndAlso Not Char.IsWhiteSpace(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    'Evento boton Actualizar
    Private Sub btnActualizar_Click(sender As Object, e As EventArgs) Handles btnActualizar.Click
        actualizararchivo()
    End Sub

    'Evento boton Eliminar
    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        eliminararchivo()
    End Sub

    'metodo para pasar parametros guardar archivo
    Sub guardararchivo()
        Dim obj As New Entidades.EntUpload()

        obj.nombre = txtPl_name.Text
        obj.fecha = saveUcnow
        obj.ruta = txtRuta.Text
        Logica.guardadoImagenes(obj)
        If obj.result > 0 Then
            Me.Load_grid()
            Me.Limpiar()
            notificacion()
        Else
            MsgBox("Ocurrio un error")
        End If

    End Sub

    'metodo para pasar parametros editar archivo
    Sub actualizararchivo()
        Dim obj As New Entidades.EntUpload()

        obj.id = txtId.Text
        obj.nombre = txtPl_name.Text
        obj.fecha = saveUcnow
        obj.ruta = txtRuta.Text
        Logica.editarImagenes(obj)
        Me.Load_grid()
        Me.Limpiar()
    End Sub

    'metodo para pasar parametros eliminar archivo
    Sub eliminararchivo()
        Dim obj As New Entidades.EntUpload()

        Dim row As DataRow
        row = GridView1.GetDataRow(GridView1.FocusedRowHandle)
        Dim id As Integer
        id = row("id")
        GridView1.DeleteRow(GridView1.FocusedRowHandle)
        obj.id = id
        Logica.eliminarImagenes(obj)
        Me.Load_grid()
        Me.Limpiar()
    End Sub

    'abre los archivos del equipo
    Public Sub examinarArchivo()
        Try
            Dim archivo As New OpenFileDialog
            archivo.Filter = "Archivo PDF|*.pdf"
            If archivo.ShowDialog = DialogResult.OK Then
                txtRuta.Text = archivo.FileName
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    'metodo para notificación
    Public Sub notificacion()
        Dim notificacion = New PopupNotifier
        notificacion.ContentText = "Datos guardados"
        notificacion.BodyColor = Color.Azure
        notificacion.ContentPadding = New Padding(12)
        notificacion.Delay = 2000
        notificacion.ButtonBorderColor = Color.Blue
        notificacion.Popup()
    End Sub

    'posicion de seleccion del datagrid para traer el nombre en la caja de texto
    Private Sub GridControlListar_MouseClick(sender As Object, e As MouseEventArgs) Handles GridControlListar.MouseClick
        Dim row As DataRow
        row = GridView1.GetDataRow(GridView1.FocusedRowHandle)
        Dim nombre As String
        nombre = row("nombre")
        txtPl_name.Text = nombre
    End Sub
End Class
