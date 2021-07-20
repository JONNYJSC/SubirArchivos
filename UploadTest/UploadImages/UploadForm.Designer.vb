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
        Me.components = New System.ComponentModel.Container()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lbFecha = New System.Windows.Forms.Label()
        Me.txtId = New DevExpress.XtraEditors.TextEdit()
        Me.txtPl_name = New DevExpress.XtraEditors.TextEdit()
        Me.txtRuta = New DevExpress.XtraEditors.TextEdit()
        Me.btnExaminar = New DevExpress.XtraEditors.SimpleButton()
        Me.btnEliminar = New DevExpress.XtraEditors.SimpleButton()
        Me.btnActualizar = New DevExpress.XtraEditors.SimpleButton()
        Me.btnGuardar = New DevExpress.XtraEditors.SimpleButton()
        Me.SqlDataSource1 = New DevExpress.DataAccess.Sql.SqlDataSource(Me.components)
        Me.GridControlListar = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        CType(Me.txtId.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPl_name.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtRuta.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridControlListar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(27, 41)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(67, 16)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Nombre:"
        '
        'lbFecha
        '
        Me.lbFecha.AutoSize = True
        Me.lbFecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbFecha.Location = New System.Drawing.Point(313, 40)
        Me.lbFecha.Name = "lbFecha"
        Me.lbFecha.Size = New System.Drawing.Size(98, 16)
        Me.lbFecha.TabIndex = 6
        Me.lbFecha.Text = "Fecha Actual"
        '
        'txtId
        '
        Me.txtId.Location = New System.Drawing.Point(99, 11)
        Me.txtId.Name = "txtId"
        Me.txtId.Size = New System.Drawing.Size(44, 20)
        Me.txtId.TabIndex = 10
        Me.txtId.Visible = False
        '
        'txtPl_name
        '
        Me.txtPl_name.Location = New System.Drawing.Point(99, 39)
        Me.txtPl_name.Name = "txtPl_name"
        Me.txtPl_name.Size = New System.Drawing.Size(196, 20)
        Me.txtPl_name.TabIndex = 11
        '
        'txtRuta
        '
        Me.txtRuta.Location = New System.Drawing.Point(99, 65)
        Me.txtRuta.Name = "txtRuta"
        Me.txtRuta.Size = New System.Drawing.Size(339, 20)
        Me.txtRuta.TabIndex = 12
        '
        'btnExaminar
        '
        Me.btnExaminar.Location = New System.Drawing.Point(13, 68)
        Me.btnExaminar.Name = "btnExaminar"
        Me.btnExaminar.Size = New System.Drawing.Size(75, 23)
        Me.btnExaminar.TabIndex = 13
        Me.btnExaminar.Text = "Examinar"
        '
        'btnEliminar
        '
        Me.btnEliminar.Location = New System.Drawing.Point(166, 280)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(75, 23)
        Me.btnEliminar.TabIndex = 14
        Me.btnEliminar.Text = "Eliminar"
        '
        'btnActualizar
        '
        Me.btnActualizar.Location = New System.Drawing.Point(266, 280)
        Me.btnActualizar.Name = "btnActualizar"
        Me.btnActualizar.Size = New System.Drawing.Size(75, 23)
        Me.btnActualizar.TabIndex = 15
        Me.btnActualizar.Text = "Actualizar"
        '
        'btnGuardar
        '
        Me.btnGuardar.Location = New System.Drawing.Point(363, 280)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(75, 23)
        Me.btnGuardar.TabIndex = 16
        Me.btnGuardar.Text = "Guardar"
        '
        'SqlDataSource1
        '
        Me.SqlDataSource1.Name = "SqlDataSource1"
        '
        'GridControlListar
        '
        Me.GridControlListar.Location = New System.Drawing.Point(13, 97)
        Me.GridControlListar.MainView = Me.GridView1
        Me.GridControlListar.Name = "GridControlListar"
        Me.GridControlListar.Size = New System.Drawing.Size(425, 177)
        Me.GridControlListar.TabIndex = 17
        Me.GridControlListar.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.GridControl = Me.GridControlListar
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsView.ShowGroupPanel = False
        '
        'UploadForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(450, 316)
        Me.Controls.Add(Me.GridControlListar)
        Me.Controls.Add(Me.btnGuardar)
        Me.Controls.Add(Me.btnActualizar)
        Me.Controls.Add(Me.btnEliminar)
        Me.Controls.Add(Me.btnExaminar)
        Me.Controls.Add(Me.txtRuta)
        Me.Controls.Add(Me.txtPl_name)
        Me.Controls.Add(Me.txtId)
        Me.Controls.Add(Me.lbFecha)
        Me.Controls.Add(Me.Label1)
        Me.Name = "UploadForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Formulario"
        CType(Me.txtId.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPl_name.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtRuta.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridControlListar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

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
    Friend WithEvents SqlDataSource1 As DevExpress.DataAccess.Sql.SqlDataSource
    Friend WithEvents GridControlListar As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
End Class
