<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UploadForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.txtPl_name = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnUpload = New System.Windows.Forms.Button()
        Me.dtUpload = New System.Windows.Forms.DataGridView()
        Me.txtRuta = New System.Windows.Forms.TextBox()
        Me.btnExaminar = New System.Windows.Forms.Button()
        Me.lbFecha = New System.Windows.Forms.Label()
        Me.txtid = New System.Windows.Forms.TextBox()
        Me.btnEditar = New System.Windows.Forms.Button()
        Me.btnEliminar = New System.Windows.Forms.Button()
        CType(Me.dtUpload, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtPl_name
        '
        Me.txtPl_name.Location = New System.Drawing.Point(99, 37)
        Me.txtPl_name.Name = "txtPl_name"
        Me.txtPl_name.Size = New System.Drawing.Size(174, 20)
        Me.txtPl_name.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(36, 41)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(47, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Nombre:"
        '
        'btnUpload
        '
        Me.btnUpload.Location = New System.Drawing.Point(363, 280)
        Me.btnUpload.Name = "btnUpload"
        Me.btnUpload.Size = New System.Drawing.Size(75, 23)
        Me.btnUpload.TabIndex = 2
        Me.btnUpload.Text = "Subir"
        Me.btnUpload.UseVisualStyleBackColor = True
        '
        'dtUpload
        '
        Me.dtUpload.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtUpload.Location = New System.Drawing.Point(12, 99)
        Me.dtUpload.Name = "dtUpload"
        Me.dtUpload.Size = New System.Drawing.Size(426, 164)
        Me.dtUpload.TabIndex = 3
        '
        'txtRuta
        '
        Me.txtRuta.Location = New System.Drawing.Point(98, 65)
        Me.txtRuta.Name = "txtRuta"
        Me.txtRuta.Size = New System.Drawing.Size(340, 20)
        Me.txtRuta.TabIndex = 4
        '
        'btnExaminar
        '
        Me.btnExaminar.Location = New System.Drawing.Point(13, 64)
        Me.btnExaminar.Name = "btnExaminar"
        Me.btnExaminar.Size = New System.Drawing.Size(75, 23)
        Me.btnExaminar.TabIndex = 5
        Me.btnExaminar.Text = "Examinar"
        Me.btnExaminar.UseVisualStyleBackColor = True
        '
        'lbFecha
        '
        Me.lbFecha.AutoSize = True
        Me.lbFecha.Location = New System.Drawing.Point(301, 40)
        Me.lbFecha.Name = "lbFecha"
        Me.lbFecha.Size = New System.Drawing.Size(70, 13)
        Me.lbFecha.TabIndex = 6
        Me.lbFecha.Text = "Fecha Actual"
        '
        'txtid
        '
        Me.txtid.Location = New System.Drawing.Point(99, 13)
        Me.txtid.Name = "txtid"
        Me.txtid.Size = New System.Drawing.Size(100, 20)
        Me.txtid.TabIndex = 7
        Me.txtid.Visible = False
        '
        'btnEditar
        '
        Me.btnEditar.Location = New System.Drawing.Point(264, 280)
        Me.btnEditar.Name = "btnEditar"
        Me.btnEditar.Size = New System.Drawing.Size(75, 23)
        Me.btnEditar.TabIndex = 8
        Me.btnEditar.Text = "Editar"
        Me.btnEditar.UseVisualStyleBackColor = True
        '
        'btnEliminar
        '
        Me.btnEliminar.Location = New System.Drawing.Point(166, 280)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(75, 23)
        Me.btnEliminar.TabIndex = 9
        Me.btnEliminar.Text = "Eliminar"
        Me.btnEliminar.UseVisualStyleBackColor = True
        '
        'UploadForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(450, 315)
        Me.Controls.Add(Me.btnEliminar)
        Me.Controls.Add(Me.btnEditar)
        Me.Controls.Add(Me.txtid)
        Me.Controls.Add(Me.lbFecha)
        Me.Controls.Add(Me.btnExaminar)
        Me.Controls.Add(Me.txtRuta)
        Me.Controls.Add(Me.dtUpload)
        Me.Controls.Add(Me.btnUpload)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtPl_name)
        Me.Name = "UploadForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Formulario"
        CType(Me.dtUpload, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtPl_name As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btnUpload As Button
    Friend WithEvents dtUpload As DataGridView
    Friend WithEvents txtRuta As TextBox
    Friend WithEvents btnExaminar As Button
    Friend WithEvents lbFecha As Label
    Friend WithEvents txtid As TextBox
    Friend WithEvents btnEditar As Button
    Friend WithEvents btnEliminar As Button
End Class
