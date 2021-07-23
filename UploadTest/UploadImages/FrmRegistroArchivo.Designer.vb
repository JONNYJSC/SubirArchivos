<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmRegistroArchivo
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl()
        Me.SPListarArchivosRegistroBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colNombre_Orden = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colNombre_Categoria = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colNombre_Registro = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colFecha_Registro = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colArchivo_Registro = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colId_Orden = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.CompaniaDataSet1BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SPListarArchivosRegistroBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SPListarArchivosRegistroBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CompaniaDataSet1BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SPListarArchivosRegistroBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelControl1
        '
        Me.PanelControl1.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelControl1.Location = New System.Drawing.Point(0, 0)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(854, 100)
        Me.PanelControl1.TabIndex = 0
        '
        'GridControl1
        '
        Me.GridControl1.DataSource = Me.SPListarArchivosRegistroBindingSource1
        Me.GridControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridControl1.Location = New System.Drawing.Point(0, 100)
        Me.GridControl1.MainView = Me.GridView1
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.Size = New System.Drawing.Size(854, 372)
        Me.GridControl1.TabIndex = 1
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'SPListarArchivosRegistroBindingSource
        '
        Me.SPListarArchivosRegistroBindingSource.DataMember = "SP_ListarArchivosRegistro"
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colNombre_Orden, Me.colNombre_Categoria, Me.colNombre_Registro, Me.colFecha_Registro, Me.colArchivo_Registro, Me.colId_Orden})
        Me.GridView1.GridControl = Me.GridControl1
        Me.GridView1.Name = "GridView1"
        '
        'colNombre_Orden
        '
        Me.colNombre_Orden.FieldName = "Nombre_Orden"
        Me.colNombre_Orden.Name = "colNombre_Orden"
        Me.colNombre_Orden.Visible = True
        Me.colNombre_Orden.VisibleIndex = 0
        '
        'colNombre_Categoria
        '
        Me.colNombre_Categoria.FieldName = "Nombre_Categoria"
        Me.colNombre_Categoria.Name = "colNombre_Categoria"
        Me.colNombre_Categoria.Visible = True
        Me.colNombre_Categoria.VisibleIndex = 1
        '
        'colNombre_Registro
        '
        Me.colNombre_Registro.FieldName = "Nombre_Registro"
        Me.colNombre_Registro.Name = "colNombre_Registro"
        Me.colNombre_Registro.Visible = True
        Me.colNombre_Registro.VisibleIndex = 2
        '
        'colFecha_Registro
        '
        Me.colFecha_Registro.FieldName = "Fecha_Registro"
        Me.colFecha_Registro.Name = "colFecha_Registro"
        Me.colFecha_Registro.Visible = True
        Me.colFecha_Registro.VisibleIndex = 3
        '
        'colArchivo_Registro
        '
        Me.colArchivo_Registro.FieldName = "Archivo_Registro"
        Me.colArchivo_Registro.Name = "colArchivo_Registro"
        Me.colArchivo_Registro.Visible = True
        Me.colArchivo_Registro.VisibleIndex = 4
        '
        'colId_Orden
        '
        Me.colId_Orden.FieldName = "Id_Orden"
        Me.colId_Orden.Name = "colId_Orden"
        Me.colId_Orden.Visible = True
        Me.colId_Orden.VisibleIndex = 5
        '
        'CompaniaDataSet1BindingSource
        '
        Me.CompaniaDataSet1BindingSource.Position = 0
        '
        'CompaniaDataSet1
        '
        '
        'DataSet2
        '
        '
        'SPListarArchivosRegistroBindingSource1
        '
        Me.SPListarArchivosRegistroBindingSource1.DataMember = "SP_ListarArchivosRegistro"
        '
        'SP_ListarArchivosRegistroTableAdapter
        '
        '
        'FrmRegistroArchivo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(854, 472)
        Me.Controls.Add(Me.GridControl1)
        Me.Controls.Add(Me.PanelControl1)
        Me.Name = "FrmRegistroArchivo"
        Me.Text = "FrmRegistroArchivo"
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SPListarArchivosRegistroBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CompaniaDataSet1BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SPListarArchivosRegistroBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents CompaniaDataSet1BindingSource As BindingSource
    Friend WithEvents SPListarArchivosRegistroBindingSource As BindingSource
    'Friend WithEvents SP_ListarArchivosRegistroTableAdapter As DataSet2TableAdapters.SP_ListarArchivosRegistroTableAdapter
    Friend WithEvents colNombre_Orden As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNombre_Categoria As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNombre_Registro As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFecha_Registro As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colArchivo_Registro As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colId_Orden As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents SPListarArchivosRegistroBindingSource1 As BindingSource
End Class
