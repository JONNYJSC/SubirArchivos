Imports System.Data.SqlClient
Imports System.IO
Imports DevExpress.XtraEditors

Public Class FrmMenu
    Dim cnn As New SqlConnection
    ' Me trae la fecha actual
    Dim saveUcnow As DateTime = DateTime.Now

    ' Metodo para separa fecha
    Function SystemDateTime() As String
        Dim timeprint As String = Date.Now.ToLocalTime.ToString
        Dim separar As String() = timeprint.Split("/")
        Dim separar2 As String() = separar(2).Split(" ")
        Dim separar3 As String() = separar2(1).Split(":")
        Dim fechaSeparar As String = String.Format("{0}_{1}_{2}_{3}-{4}-{5}-{6}", separar(0), separar(1), separar2(0), separar3(0), separar3(1), separar3(2), separar2(2))
        Return fechaSeparar
    End Function
    Dim FechaUsar As String = SystemDateTime()

    Private Sub FrmMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Load_gridCat()
        Load_gridOrdenCat()
        Load_Registro()
        'lbFecha.Text = saveUcnow.ToString("dd/MM/yyyy")
        lbFecha.Text = SystemDateTime()
        CbxCategoriaOrden.Properties.DataSource = Logica.listadoCategoria
        CbxCategoriaOrden.Properties.DisplayMember = "Nombre_Categoria"
        CbxCategoriaOrden.Properties.ValueMember = "Id_Categoria"
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
        If Trim(txtOrden.Text) = "" Then
            MsgBox("Llenar Campo Orden Porfavor", MsgBoxStyle.Critical, "Operacion no valida")
        Else
            guardarOrdenCategoria()
            txtOrden.Text = ""
        End If
    End Sub

    'metodo para pasar parametros guardar archivo
    Sub guardarOrdenCategoria()
        Dim obj As New Entidades.EntUpload()

        obj.Orden = txtOrden.Text
        'Revisar IdCategoriaOrden
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
        If Trim(txtRegistro.Text) = "" Then
            MsgBox("Llenar Campo Nombre Porfavor", MsgBoxStyle.Critical, "Operacion no valida")
        Else
            guardarRegistro()
            Load_gridOrdenCat()
            Load_Registro()
            Load_gridCat()
        End If
    End Sub

    Sub guardarRegistro()
        Dim obj As New Entidades.EntUpload()

        obj.nombre = txtRegistro.Text
        obj.fecha = saveUcnow
        obj.ruta = txtExaminar.Text
        'Guarda la orden con el registro 072821-01
        obj.IdOrdenRegistro = 1
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

    'metodo para pasar parametros Orden Id
    Sub LoadRegistroOrden()
        Dim obj As New Entidades.EntUpload()

        Dim row As DataRow
        row = GridViewListadoOrdenCat.GetDataRow(GridViewListadoOrdenCat.FocusedRowHandle)
        Dim id As Integer
        id = row("IdCategoria")

        'Elimina la fila seleccionada
        'GridViewListadoOrdenCat.DeleteRow(GridViewListadoOrdenCat.FocusedRowHandle)

        obj.IdOrdenRegistro = id

        GridControlRegistro.DataSource = Logica.listadoRegistroOrden(obj)
    End Sub

    Private Sub GridControlListadoOrden_DoubleClick(sender As Object, e As EventArgs) Handles GridControlListadoOrden.DoubleClick
        LoadRegistroOrden()
    End Sub

    Private Sub GridControlRegistro_DoubleClick(sender As Object, e As EventArgs) Handles GridControlRegistro.DoubleClick
        'Evento dobloe click del GridControl para mostrar pdf
        EventoGrid()
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

            Dim str_cadena As String
            str_cadena = "select Archivo_Registro from tb_Registro2 where Id_Registro = " & id

            If conectar() = False Then
                Exit Sub
            End If

            dr = fun_ExecuteReader(str_cadena)
            If dr.HasRows Then
                While dr.Read
                    If dr("Archivo_Registro") IsNot DBNull.Value Then
                        Dim bytes() As Byte
                        bytes = dr("Archivo_Registro")

                        Try
                            Dim sFile As String = String.Format("{0}{1}.pdf", "PO_", "CertificateLots")
                            Dim fs As New FileStream(sFile, FileMode.Create)
                            fs.Write(bytes, 0, Convert.ToInt32(bytes.Length))
                            fs.Close()
                            Dim obja As New System.Diagnostics.Process()
                            obja.StartInfo.FileName = sFile
                            obja.Start()
                        Catch generatedExceptionName As Exception
                            XtraMessageBox.Show(Me, "There was an error getting the lot from its path. Please check if exist.", "Demetech Manufacturing", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        End Try
                    End If
                End While
            End If
        Catch ex As Exception
            XtraMessageBox.Show(Me, "There was an error getting the lot from its path. Please check if exist.", "Demetech Manufacturing", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return
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

    '----------------------Metodo para abrir directamente el documento-----------------------------------------------------
    Private Sub AbrirDocumento(ByVal vFilename As String)
        Dim pr As System.Diagnostics.Process
        pr = New System.Diagnostics.Process
        Try
            pr.StartInfo.FileName = vFilename
            pr.StartInfo.WindowStyle = ProcessWindowStyle.Normal
            pr.Start()
            'Espera el proceso para que lo termine y continuar
            pr.WaitForExit()
            'Liberar
            pr.Close()
            'My.Computer.FileSystem.DeleteFile(vFilename)
        Catch ex As Exception
            MessageBox.Show(ex.Message + " No se puede abrir el documento " & vFilename, "Error")
        End Try
    End Sub
    '--------------------------------------------------------------------------------------------
    Public Function ObtenCampoPorNombre(ByVal aNombreCampo As String, sqlDataRow As DataRow) As Object
        Try
            ObtenCampoPorNombre = Nothing
            If sqlDataRow Is Nothing Then
                Exit Function
            End If
            If IsDBNull(sqlDataRow.Item(aNombreCampo)) Then
                Exit Function
            End If
            ObtenCampoPorNombre = sqlDataRow.Item(aNombreCampo)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Return ObtenCampoPorNombre(aNombreCampo, sqlDataRow)
    End Function

End Class