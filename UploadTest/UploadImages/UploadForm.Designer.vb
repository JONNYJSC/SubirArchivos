<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class UploadForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim GridLevelNode1 As DevExpress.XtraGrid.GridLevelNode = New DevExpress.XtraGrid.GridLevelNode()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lbFecha = New System.Windows.Forms.Label()
        Me.txtId = New DevExpress.XtraEditors.TextEdit()
        Me.txtPl_name = New DevExpress.XtraEditors.TextEdit()
        Me.txtRuta = New DevExpress.XtraEditors.TextEdit()
        Me.btnExaminar = New DevExpress.XtraEditors.SimpleButton()
        Me.btnEliminar = New DevExpress.XtraEditors.SimpleButton()
        Me.btnActualizar = New DevExpress.XtraEditors.SimpleButton()
        Me.btnGuardar = New DevExpress.XtraEditors.SimpleButton()
        Me.GridControlListar = New DevExpress.XtraGrid.GridControl()
        Me.TbArchivoBindingSource = New System.Windows.Forms.BindingSource()
        Me.DataSet1 = New UploadTest.DataSet1()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.col_Id = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.txt_Id = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.col_nombre = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.txt_name = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.col_Fecha = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.DateEdit = New DevExpress.XtraEditors.Repository.RepositoryItemDateEdit()
        Me.txt_archivo = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.SPListarArchivosBindingSource = New System.Windows.Forms.BindingSource()
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.Tb_ArchivoTableAdapter = New UploadTest.DataSet1TableAdapters.tb_ArchivoTableAdapter()
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl()
        Me.GridView2 = New DevExpress.XtraGrid.Views.Grid.GridView()
        CType(Me.txtId.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPl_name.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtRuta.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridControlListar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TbArchivoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_Id, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_name, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DateEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DateEdit.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_archivo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SPListarArchivosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(19, 40)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(67, 16)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Nombre:"
        '
        'lbFecha
        '
        Me.lbFecha.AutoSize = True
        Me.lbFecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbFecha.Location = New System.Drawing.Point(411, 37)
        Me.lbFecha.Name = "lbFecha"
        Me.lbFecha.Size = New System.Drawing.Size(98, 16)
        Me.lbFecha.TabIndex = 6
        Me.lbFecha.Text = "Fecha Actual"
        '
        'txtId
        '
        Me.txtId.Location = New System.Drawing.Point(113, 12)
        Me.txtId.Name = "txtId"
        Me.txtId.Size = New System.Drawing.Size(44, 20)
        Me.txtId.TabIndex = 10
        Me.txtId.Visible = False
        '
        'txtPl_name
        '
        Me.txtPl_name.Location = New System.Drawing.Point(113, 36)
        Me.txtPl_name.Name = "txtPl_name"
        Me.txtPl_name.Size = New System.Drawing.Size(196, 20)
        Me.txtPl_name.TabIndex = 11
        '
        'txtRuta
        '
        Me.txtRuta.Location = New System.Drawing.Point(113, 62)
        Me.txtRuta.Name = "txtRuta"
        Me.txtRuta.Size = New System.Drawing.Size(339, 20)
        Me.txtRuta.TabIndex = 12
        '
        'btnExaminar
        '
        Me.btnExaminar.Location = New System.Drawing.Point(15, 65)
        Me.btnExaminar.Name = "btnExaminar"
        Me.btnExaminar.Size = New System.Drawing.Size(75, 23)
        Me.btnExaminar.TabIndex = 13
        Me.btnExaminar.Text = "Examinar"
        '
        'btnEliminar
        '
        Me.btnEliminar.Location = New System.Drawing.Point(546, 59)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(75, 23)
        Me.btnEliminar.TabIndex = 14
        Me.btnEliminar.Text = "Eliminar"
        '
        'btnActualizar
        '
        Me.btnActualizar.Location = New System.Drawing.Point(646, 59)
        Me.btnActualizar.Name = "btnActualizar"
        Me.btnActualizar.Size = New System.Drawing.Size(75, 23)
        Me.btnActualizar.TabIndex = 15
        Me.btnActualizar.Text = "Actualizar"
        '
        'btnGuardar
        '
        Me.btnGuardar.Location = New System.Drawing.Point(743, 59)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(75, 23)
        Me.btnGuardar.TabIndex = 16
        Me.btnGuardar.Text = "Guardar"
        '
        'GridControlListar
        '
        Me.GridControlListar.DataSource = Me.TbArchivoBindingSource
        Me.GridControlListar.Dock = System.Windows.Forms.DockStyle.Left
        GridLevelNode1.RelationName = "Level1"
        Me.GridControlListar.LevelTree.Nodes.AddRange(New DevExpress.XtraGrid.GridLevelNode() {GridLevelNode1})
        Me.GridControlListar.Location = New System.Drawing.Point(0, 100)
        Me.GridControlListar.MainView = Me.GridView1
        Me.GridControlListar.Name = "GridControlListar"
        Me.GridControlListar.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.txt_name, Me.DateEdit, Me.txt_archivo, Me.txt_Id})
        Me.GridControlListar.Size = New System.Drawing.Size(463, 550)
        Me.GridControlListar.TabIndex = 17
        Me.GridControlListar.UseEmbeddedNavigator = True
        Me.GridControlListar.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'TbArchivoBindingSource
        '
        Me.TbArchivoBindingSource.DataMember = "tb_Archivo"
        Me.TbArchivoBindingSource.DataSource = Me.DataSet1
        '
        'DataSet1
        '
        Me.DataSet1.DataSetName = "DataSet1"
        Me.DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GridView1
        '
        Me.GridView1.ColumnPanelRowHeight = 40
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.col_Id, Me.col_nombre, Me.col_Fecha})
        Me.GridView1.GridControl = Me.GridControlListar
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsBehavior.EditingMode = DevExpress.XtraGrid.Views.Grid.GridEditingMode.EditFormInplaceHideCurrentRow
        Me.GridView1.OptionsEditForm.BindingMode = DevExpress.XtraGrid.Views.Grid.EditFormBindingMode.Direct
        Me.GridView1.OptionsFind.AlwaysVisible = True
        Me.GridView1.OptionsView.ColumnAutoWidth = False
        Me.GridView1.OptionsView.RowAutoHeight = True
        Me.GridView1.OptionsView.ShowFooter = True
        '
        'col_Id
        '
        Me.col_Id.AppearanceHeader.Options.UseFont = True
        Me.col_Id.AppearanceHeader.Options.UseTextOptions = True
        Me.col_Id.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.col_Id.Caption = "Id"
        Me.col_Id.ColumnEdit = Me.txt_Id
        Me.col_Id.FieldName = "id"
        Me.col_Id.Name = "col_Id"
        Me.col_Id.OptionsEditForm.Visible = DevExpress.Utils.DefaultBoolean.[False]
        '
        'txt_Id
        '
        Me.txt_Id.Appearance.Options.UseTextOptions = True
        Me.txt_Id.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.txt_Id.AutoHeight = False
        Me.txt_Id.Name = "txt_Id"
        '
        'col_nombre
        '
        Me.col_nombre.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.col_nombre.AppearanceHeader.Options.UseFont = True
        Me.col_nombre.AppearanceHeader.Options.UseTextOptions = True
        Me.col_nombre.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.col_nombre.Caption = "Nombre"
        Me.col_nombre.ColumnEdit = Me.txt_name
        Me.col_nombre.FieldName = "nombre"
        Me.col_nombre.Name = "col_nombre"
        Me.col_nombre.Visible = True
        Me.col_nombre.VisibleIndex = 0
        Me.col_nombre.Width = 163
        '
        'txt_name
        '
        Me.txt_name.AutoHeight = False
        Me.txt_name.Name = "txt_name"
        '
        'col_Fecha
        '
        Me.col_Fecha.AppearanceHeader.Options.UseFont = True
        Me.col_Fecha.AppearanceHeader.Options.UseTextOptions = True
        Me.col_Fecha.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.col_Fecha.Caption = "Fecha"
        Me.col_Fecha.ColumnEdit = Me.DateEdit
        Me.col_Fecha.FieldName = "fecha"
        Me.col_Fecha.Name = "col_Fecha"
        Me.col_Fecha.Visible = True
        Me.col_Fecha.VisibleIndex = 1
        '
        'DateEdit
        '
        Me.DateEdit.AutoHeight = False
        Me.DateEdit.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.DateEdit.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.DateEdit.Name = "DateEdit"
        '
        'txt_archivo
        '
        Me.txt_archivo.AutoHeight = False
        Me.txt_archivo.Name = "txt_archivo"
        '
        'SPListarArchivosBindingSource
        '
        Me.SPListarArchivosBindingSource.DataMember = "SP_ListarArchivos"
        '
        'PanelControl1
        '
        Me.PanelControl1.Controls.Add(Me.txtRuta)
        Me.PanelControl1.Controls.Add(Me.Label1)
        Me.PanelControl1.Controls.Add(Me.btnGuardar)
        Me.PanelControl1.Controls.Add(Me.btnActualizar)
        Me.PanelControl1.Controls.Add(Me.lbFecha)
        Me.PanelControl1.Controls.Add(Me.btnEliminar)
        Me.PanelControl1.Controls.Add(Me.txtId)
        Me.PanelControl1.Controls.Add(Me.txtPl_name)
        Me.PanelControl1.Controls.Add(Me.btnExaminar)
        Me.PanelControl1.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelControl1.Location = New System.Drawing.Point(0, 0)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(862, 100)
        Me.PanelControl1.TabIndex = 18
        '
        'Tb_ArchivoTableAdapter
        '
        Me.Tb_ArchivoTableAdapter.ClearBeforeFill = True
        '
        'GridControl1
        '
        Me.GridControl1.Dock = System.Windows.Forms.DockStyle.Right
        Me.GridControl1.Location = New System.Drawing.Point(462, 100)
        Me.GridControl1.MainView = Me.GridView2
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.Size = New System.Drawing.Size(400, 550)
        Me.GridControl1.TabIndex = 19
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView2})
        '
        'GridView2
        '
        Me.GridView2.GridControl = Me.GridControl1
        Me.GridView2.Name = "GridView2"
        '
        'UploadForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(862, 650)
        Me.Controls.Add(Me.GridControlListar)
        Me.Controls.Add(Me.GridControl1)
        Me.Controls.Add(Me.PanelControl1)
        Me.Name = "UploadForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Formulario"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.txtId.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPl_name.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtRuta.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridControlListar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TbArchivoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_Id, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_name, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DateEdit.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DateEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_archivo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SPListarArchivosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        Me.PanelControl1.PerformLayout()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents lbFecha As Label
    Friend WithEvents txtId As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtPl_name As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtRuta As DevExpress.XtraEditors.TextEdit
    Friend WithEvents btnExaminar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnEliminar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnActualizar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnGuardar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents GridControlListar As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents col_nombre As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents txt_name As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents col_Fecha As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_Id As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents DateEdit As DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
    Friend WithEvents txt_archivo As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents txt_Id As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents DataSet1 As DataSet1
    Friend WithEvents TbArchivoBindingSource As BindingSource
    Friend WithEvents Tb_ArchivoTableAdapter As DataSet1TableAdapters.tb_ArchivoTableAdapter
    Friend WithEvents SPListarArchivosBindingSource As BindingSource
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView2 As DevExpress.XtraGrid.Views.Grid.GridView
End Class
