<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmOrden
    Inherits DevExpress.XtraEditors.XtraForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.ComboboxCategoria = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.GridLookUpEdit1View = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.txtNombreCategoria = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl()
        Me.GridComboboxCategoria = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.btnGuardarOrden = New DevExpress.XtraEditors.SimpleButton()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        CType(Me.ComboboxCategoria.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridLookUpEdit1View, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNombreCategoria.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridComboboxCategoria, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelControl1
        '
        Me.PanelControl1.Appearance.BackColor = System.Drawing.Color.Gray
        Me.PanelControl1.Appearance.Options.UseBackColor = True
        Me.PanelControl1.Controls.Add(Me.btnGuardarOrden)
        Me.PanelControl1.Controls.Add(Me.LabelControl2)
        Me.PanelControl1.Controls.Add(Me.ComboboxCategoria)
        Me.PanelControl1.Controls.Add(Me.txtNombreCategoria)
        Me.PanelControl1.Controls.Add(Me.LabelControl1)
        Me.PanelControl1.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelControl1.Location = New System.Drawing.Point(0, 0)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(754, 100)
        Me.PanelControl1.TabIndex = 0
        '
        'LabelControl2
        '
        Me.LabelControl2.Appearance.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl2.Location = New System.Drawing.Point(347, 34)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(86, 19)
        Me.LabelControl2.TabIndex = 3
        Me.LabelControl2.Text = "Categoria:"
        '
        'ComboboxCategoria
        '
        Me.ComboboxCategoria.EditValue = "kjkjk"
        Me.ComboboxCategoria.Location = New System.Drawing.Point(452, 36)
        Me.ComboboxCategoria.Name = "ComboboxCategoria"
        Me.ComboboxCategoria.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.ComboboxCategoria.Properties.View = Me.GridLookUpEdit1View
        Me.ComboboxCategoria.Size = New System.Drawing.Size(162, 20)
        Me.ComboboxCategoria.TabIndex = 2
        '
        'GridLookUpEdit1View
        '
        Me.GridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridLookUpEdit1View.Name = "GridLookUpEdit1View"
        Me.GridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridLookUpEdit1View.OptionsView.ShowGroupPanel = False
        '
        'txtNombreCategoria
        '
        Me.txtNombreCategoria.Location = New System.Drawing.Point(96, 36)
        Me.txtNombreCategoria.Name = "txtNombreCategoria"
        Me.txtNombreCategoria.Size = New System.Drawing.Size(180, 20)
        Me.txtNombreCategoria.TabIndex = 1
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl1.Location = New System.Drawing.Point(26, 34)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(55, 19)
        Me.LabelControl1.TabIndex = 0
        Me.LabelControl1.Text = "Orden:"
        '
        'GridControl1
        '
        Me.GridControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridControl1.Location = New System.Drawing.Point(0, 100)
        Me.GridControl1.MainView = Me.GridComboboxCategoria
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.Size = New System.Drawing.Size(754, 343)
        Me.GridControl1.TabIndex = 1
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridComboboxCategoria})
        '
        'GridComboboxCategoria
        '
        Me.GridComboboxCategoria.GridControl = Me.GridControl1
        Me.GridComboboxCategoria.Name = "GridComboboxCategoria"
        '
        'btnGuardarOrden
        '
        Me.btnGuardarOrden.Location = New System.Drawing.Point(96, 62)
        Me.btnGuardarOrden.Name = "btnGuardarOrden"
        Me.btnGuardarOrden.Size = New System.Drawing.Size(75, 23)
        Me.btnGuardarOrden.TabIndex = 4
        Me.btnGuardarOrden.Text = "Guardar"
        '
        'FrmOrden
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(754, 443)
        Me.Controls.Add(Me.GridControl1)
        Me.Controls.Add(Me.PanelControl1)
        Me.Name = "FrmOrden"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FrmOrden"
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        Me.PanelControl1.PerformLayout()
        CType(Me.ComboboxCategoria.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridLookUpEdit1View, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNombreCategoria.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridComboboxCategoria, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridComboboxCategoria As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtNombreCategoria As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents ComboboxCategoria As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents GridLookUpEdit1View As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents btnGuardarOrden As DevExpress.XtraEditors.SimpleButton
End Class
