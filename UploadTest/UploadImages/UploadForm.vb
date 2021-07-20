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
        dtUpload.Columns(0).Visible = False
        GridView1.Columns(0).Visible = False

        'para mostrar la fecha en el formulario
        lbFecha.Text = saveUcnow.ToString("dd/MM/yyyy")

        'inserta un check en el grid
        Me.dataGrid()
    End Sub

    Public Sub Load_grid()
        dtUpload.DataSource = Logica.listadoImagenes
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

        'Dim Eli As Integer
        'txtId.Text = GridView1.GetSelectedRows(Eli)
        obj.id = txtId.Text
        Logica.eliminarImagenes(obj)
        Me.Load_grid()
        Me.Limpiar()
    End Sub

    'Agrega una columna de check al dataGrid
    Public Sub dataGrid()
        Dim checkBoxColumn As DataGridViewCheckBoxColumn = New DataGridViewCheckBoxColumn()
        checkBoxColumn.HeaderText = "Check" 'nombre
        checkBoxColumn.Width = 50 'tamaño
        checkBoxColumn.Name = "checkBoxColumn"
        dtUpload.Columns.Insert(0, checkBoxColumn)
        AddHandler dtUpload.CellContentClick, AddressOf dtUpload_CellContentClick
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

    Private Sub dtUpload_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dtUpload.CellContentClick
        If e.RowIndex >= 0 AndAlso e.ColumnIndex = 0 Then
            For Each row As DataGridViewRow In dtUpload.Rows
                If row.Index = e.RowIndex Then
                    row.Cells("checkBoxColumn").Value = Not Convert.ToBoolean(row.Cells("checkBoxColumn").EditedFormattedValue)
                    txtId.Text = row.Cells(1).Value.ToString()
                    txtPl_name.Text = row.Cells(2).Value.ToString()
                Else
                    row.Cells("checkBoxColumn").Value = False
                End If
            Next
        End If
    End Sub

End Class
