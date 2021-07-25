<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmMenu
    Inherits DevExpress.XtraEditors.XtraForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmMenu))
        Dim SuperToolTip1 As DevExpress.Utils.SuperToolTip = New DevExpress.Utils.SuperToolTip()
        Dim ToolTipTitleItem1 As DevExpress.Utils.ToolTipTitleItem = New DevExpress.Utils.ToolTipTitleItem()
        Dim PushTransition1 As DevExpress.Utils.Animation.PushTransition = New DevExpress.Utils.Animation.PushTransition()
        Me.BarManager1 = New DevExpress.XtraBars.BarManager(Me.components)
        Me.Bar2 = New DevExpress.XtraBars.Bar()
        Me.BarSubItem1 = New DevExpress.XtraBars.BarSubItem()
        Me.BarSubItem2 = New DevExpress.XtraBars.BarSubItem()
        Me.Bar3 = New DevExpress.XtraBars.Bar()
        Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
        Me.DockManager1 = New DevExpress.XtraBars.Docking.DockManager(Me.components)
        Me.BarDockingMenuItem1 = New DevExpress.XtraBars.BarDockingMenuItem()
        Me.BarSubItem3 = New DevExpress.XtraBars.BarSubItem()
        Me.SkinBarSubItem1 = New DevExpress.XtraBars.SkinBarSubItem()
        Me.BarButtonItem1 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarLinkContainerItem1 = New DevExpress.XtraBars.BarLinkContainerItem()
        Me.BarWorkspaceMenuItem1 = New DevExpress.XtraBars.BarWorkspaceMenuItem()
        Me.SkinBarSubItem2 = New DevExpress.XtraBars.SkinBarSubItem()
        Me.SplitContainerControl1 = New DevExpress.XtraEditors.SplitContainerControl()
        Me.XtraTabListadoCategoria = New DevExpress.XtraTab.XtraTabControl()
        Me.XtraTabAgregarCategoria = New DevExpress.XtraTab.XtraTabPage()
        Me.GridControlListadoCat = New DevExpress.XtraGrid.GridControl()
        Me.GridViewCategoria = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridColumntb_Categoria = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.PanelControlCat = New DevExpress.XtraEditors.PanelControl()
        Me.btnAgregarCateg = New DevExpress.XtraEditors.SimpleButton()
        Me.txtNombreCat = New DevExpress.XtraEditors.TextEdit()
        Me.LabelCat = New System.Windows.Forms.Label()
        Me.XtraTabAgregarOrden = New DevExpress.XtraTab.XtraTabPage()
        Me.GridControlListadoOrden = New DevExpress.XtraGrid.GridControl()
        Me.GridViewListadoOrdenCat = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.NombreOrden = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridCategoria = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.PanelControlOrden = New DevExpress.XtraEditors.PanelControl()
        Me.CbxCategoriaOrden = New DevExpress.XtraEditors.LookUpEdit()
        Me.LabelCateg = New System.Windows.Forms.Label()
        Me.btnAgregarOrden = New DevExpress.XtraEditors.SimpleButton()
        Me.txtOrden = New DevExpress.XtraEditors.TextEdit()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.WorkspaceManager1 = New DevExpress.Utils.WorkspaceManager()
        Me.GridControlRegistro = New DevExpress.XtraGrid.GridControl()
        Me.GridViewRegistro = New DevExpress.XtraGrid.Views.Grid.GridView()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DockManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SplitContainerControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainerControl1.SuspendLayout()
        CType(Me.XtraTabListadoCategoria, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabListadoCategoria.SuspendLayout()
        Me.XtraTabAgregarCategoria.SuspendLayout()
        CType(Me.GridControlListadoCat, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridViewCategoria, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControlCat, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControlCat.SuspendLayout()
        CType(Me.txtNombreCat.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabAgregarOrden.SuspendLayout()
        CType(Me.GridControlListadoOrden, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridViewListadoOrdenCat, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControlOrden, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControlOrden.SuspendLayout()
        CType(Me.CbxCategoriaOrden.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtOrden.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridControlRegistro, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridViewRegistro, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BarManager1
        '
        Me.BarManager1.Bars.AddRange(New DevExpress.XtraBars.Bar() {Me.Bar2, Me.Bar3})
        Me.BarManager1.DockControls.Add(Me.barDockControlTop)
        Me.BarManager1.DockControls.Add(Me.barDockControlBottom)
        Me.BarManager1.DockControls.Add(Me.barDockControlLeft)
        Me.BarManager1.DockControls.Add(Me.barDockControlRight)
        Me.BarManager1.DockManager = Me.DockManager1
        Me.BarManager1.Form = Me
        Me.BarManager1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.BarSubItem1, Me.BarSubItem2, Me.BarDockingMenuItem1, Me.BarSubItem3, Me.SkinBarSubItem1, Me.BarButtonItem1, Me.BarLinkContainerItem1, Me.BarWorkspaceMenuItem1, Me.SkinBarSubItem2})
        Me.BarManager1.MainMenu = Me.Bar2
        Me.BarManager1.MaxItemId = 9
        Me.BarManager1.StatusBar = Me.Bar3
        '
        'Bar2
        '
        Me.Bar2.BarName = "Menú principal"
        Me.Bar2.DockCol = 0
        Me.Bar2.DockRow = 0
        Me.Bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
        Me.Bar2.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.BarSubItem1, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.BarSubItem2, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)})
        Me.Bar2.OptionsBar.MultiLine = True
        Me.Bar2.OptionsBar.UseWholeRow = True
        Me.Bar2.Text = "Menú principal"
        '
        'BarSubItem1
        '
        Me.BarSubItem1.Caption = "Categoria"
        Me.BarSubItem1.Glyph = CType(resources.GetObject("BarSubItem1.Glyph"), System.Drawing.Image)
        Me.BarSubItem1.Id = 0
        Me.BarSubItem1.LargeGlyph = CType(resources.GetObject("BarSubItem1.LargeGlyph"), System.Drawing.Image)
        Me.BarSubItem1.Name = "BarSubItem1"
        ToolTipTitleItem1.Appearance.Image = CType(resources.GetObject("resource.Image"), System.Drawing.Image)
        ToolTipTitleItem1.Appearance.Options.UseImage = True
        ToolTipTitleItem1.Image = CType(resources.GetObject("ToolTipTitleItem1.Image"), System.Drawing.Image)
        SuperToolTip1.Items.Add(ToolTipTitleItem1)
        Me.BarSubItem1.SuperTip = SuperToolTip1
        '
        'BarSubItem2
        '
        Me.BarSubItem2.Caption = "Orden"
        Me.BarSubItem2.Glyph = CType(resources.GetObject("BarSubItem2.Glyph"), System.Drawing.Image)
        Me.BarSubItem2.Id = 1
        Me.BarSubItem2.LargeGlyph = CType(resources.GetObject("BarSubItem2.LargeGlyph"), System.Drawing.Image)
        Me.BarSubItem2.Name = "BarSubItem2"
        '
        'Bar3
        '
        Me.Bar3.BarName = "Barra de estado"
        Me.Bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom
        Me.Bar3.DockCol = 0
        Me.Bar3.DockRow = 0
        Me.Bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom
        Me.Bar3.OptionsBar.AllowQuickCustomization = False
        Me.Bar3.OptionsBar.DrawDragBorder = False
        Me.Bar3.OptionsBar.UseWholeRow = True
        Me.Bar3.Text = "Barra de estado"
        '
        'barDockControlTop
        '
        Me.barDockControlTop.CausesValidation = False
        Me.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.barDockControlTop.Location = New System.Drawing.Point(0, 0)
        Me.barDockControlTop.Size = New System.Drawing.Size(1030, 24)
        '
        'barDockControlBottom
        '
        Me.barDockControlBottom.CausesValidation = False
        Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.barDockControlBottom.Location = New System.Drawing.Point(0, 535)
        Me.barDockControlBottom.Size = New System.Drawing.Size(1030, 23)
        '
        'barDockControlLeft
        '
        Me.barDockControlLeft.CausesValidation = False
        Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.barDockControlLeft.Location = New System.Drawing.Point(0, 24)
        Me.barDockControlLeft.Size = New System.Drawing.Size(0, 511)
        '
        'barDockControlRight
        '
        Me.barDockControlRight.CausesValidation = False
        Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
        Me.barDockControlRight.Location = New System.Drawing.Point(1030, 24)
        Me.barDockControlRight.Size = New System.Drawing.Size(0, 511)
        '
        'DockManager1
        '
        Me.DockManager1.Form = Me
        Me.DockManager1.MenuManager = Me.BarManager1
        Me.DockManager1.TopZIndexControls.AddRange(New String() {"DevExpress.XtraBars.BarDockControl", "DevExpress.XtraBars.StandaloneBarDockControl", "System.Windows.Forms.StatusBar", "System.Windows.Forms.MenuStrip", "System.Windows.Forms.StatusStrip", "DevExpress.XtraBars.Ribbon.RibbonStatusBar", "DevExpress.XtraBars.Ribbon.RibbonControl", "DevExpress.XtraBars.Navigation.OfficeNavigationBar", "DevExpress.XtraBars.Navigation.TileNavPane"})
        '
        'BarDockingMenuItem1
        '
        Me.BarDockingMenuItem1.Caption = "BarDockingMenuItem1"
        Me.BarDockingMenuItem1.Id = 2
        Me.BarDockingMenuItem1.Name = "BarDockingMenuItem1"
        '
        'BarSubItem3
        '
        Me.BarSubItem3.Caption = "BarSubItem3"
        Me.BarSubItem3.Id = 3
        Me.BarSubItem3.Name = "BarSubItem3"
        '
        'SkinBarSubItem1
        '
        Me.SkinBarSubItem1.Caption = "SkinBarSubItem1"
        Me.SkinBarSubItem1.Id = 4
        Me.SkinBarSubItem1.Name = "SkinBarSubItem1"
        '
        'BarButtonItem1
        '
        Me.BarButtonItem1.Caption = "BarButtonItem1"
        Me.BarButtonItem1.Id = 5
        Me.BarButtonItem1.Name = "BarButtonItem1"
        '
        'BarLinkContainerItem1
        '
        Me.BarLinkContainerItem1.Caption = "BarLinkContainerItem1"
        Me.BarLinkContainerItem1.Id = 6
        Me.BarLinkContainerItem1.Name = "BarLinkContainerItem1"
        '
        'BarWorkspaceMenuItem1
        '
        Me.BarWorkspaceMenuItem1.Caption = "BarWorkspaceMenuItem1"
        Me.BarWorkspaceMenuItem1.Id = 7
        Me.BarWorkspaceMenuItem1.Name = "BarWorkspaceMenuItem1"
        '
        'SkinBarSubItem2
        '
        Me.SkinBarSubItem2.Caption = "SkinBarSubItem2"
        Me.SkinBarSubItem2.Id = 8
        Me.SkinBarSubItem2.Name = "SkinBarSubItem2"
        '
        'SplitContainerControl1
        '
        Me.SplitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainerControl1.Location = New System.Drawing.Point(0, 24)
        Me.SplitContainerControl1.Name = "SplitContainerControl1"
        Me.SplitContainerControl1.Panel1.Controls.Add(Me.XtraTabListadoCategoria)
        Me.SplitContainerControl1.Panel1.Text = "Panel1"
        Me.SplitContainerControl1.Panel2.Controls.Add(Me.GridControlRegistro)
        Me.SplitContainerControl1.Panel2.Text = "Panel2"
        Me.SplitContainerControl1.Size = New System.Drawing.Size(1030, 511)
        Me.SplitContainerControl1.SplitterPosition = 465
        Me.SplitContainerControl1.TabIndex = 4
        Me.SplitContainerControl1.Text = "SplitContainerControl1"
        '
        'XtraTabListadoCategoria
        '
        Me.XtraTabListadoCategoria.Dock = System.Windows.Forms.DockStyle.Fill
        Me.XtraTabListadoCategoria.Location = New System.Drawing.Point(0, 0)
        Me.XtraTabListadoCategoria.Name = "XtraTabListadoCategoria"
        Me.XtraTabListadoCategoria.SelectedTabPage = Me.XtraTabAgregarCategoria
        Me.XtraTabListadoCategoria.Size = New System.Drawing.Size(465, 511)
        Me.XtraTabListadoCategoria.TabIndex = 0
        Me.XtraTabListadoCategoria.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.XtraTabAgregarCategoria, Me.XtraTabAgregarOrden})
        '
        'XtraTabAgregarCategoria
        '
        Me.XtraTabAgregarCategoria.Controls.Add(Me.GridControlListadoCat)
        Me.XtraTabAgregarCategoria.Controls.Add(Me.PanelControlCat)
        Me.XtraTabAgregarCategoria.Name = "XtraTabAgregarCategoria"
        Me.XtraTabAgregarCategoria.Size = New System.Drawing.Size(459, 483)
        Me.XtraTabAgregarCategoria.Text = "Agregar Categoria"
        '
        'GridControlListadoCat
        '
        Me.GridControlListadoCat.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridControlListadoCat.Location = New System.Drawing.Point(0, 100)
        Me.GridControlListadoCat.MainView = Me.GridViewCategoria
        Me.GridControlListadoCat.MenuManager = Me.BarManager1
        Me.GridControlListadoCat.Name = "GridControlListadoCat"
        Me.GridControlListadoCat.Size = New System.Drawing.Size(459, 383)
        Me.GridControlListadoCat.TabIndex = 1
        Me.GridControlListadoCat.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridViewCategoria})
        '
        'GridViewCategoria
        '
        Me.GridViewCategoria.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumntb_Categoria})
        Me.GridViewCategoria.GridControl = Me.GridControlListadoCat
        Me.GridViewCategoria.Name = "GridViewCategoria"
        '
        'GridColumntb_Categoria
        '
        Me.GridColumntb_Categoria.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.GridColumntb_Categoria.AppearanceHeader.Options.UseFont = True
        Me.GridColumntb_Categoria.Caption = "Nombre Categoria"
        Me.GridColumntb_Categoria.FieldName = "Nombre_Categoria"
        Me.GridColumntb_Categoria.Name = "GridColumntb_Categoria"
        Me.GridColumntb_Categoria.Visible = True
        Me.GridColumntb_Categoria.VisibleIndex = 0
        '
        'PanelControlCat
        '
        Me.PanelControlCat.Controls.Add(Me.btnAgregarCateg)
        Me.PanelControlCat.Controls.Add(Me.txtNombreCat)
        Me.PanelControlCat.Controls.Add(Me.LabelCat)
        Me.PanelControlCat.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelControlCat.Location = New System.Drawing.Point(0, 0)
        Me.PanelControlCat.Name = "PanelControlCat"
        Me.PanelControlCat.Size = New System.Drawing.Size(459, 100)
        Me.PanelControlCat.TabIndex = 0
        '
        'btnAgregarCateg
        '
        Me.btnAgregarCateg.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAgregarCateg.Appearance.Options.UseFont = True
        Me.btnAgregarCateg.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnAgregarCateg.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.btnAgregarCateg.Image = CType(resources.GetObject("btnAgregarCateg.Image"), System.Drawing.Image)
        Me.btnAgregarCateg.ImageLocation = DevExpress.XtraEditors.ImageLocation.TopCenter
        Me.btnAgregarCateg.Location = New System.Drawing.Point(271, 20)
        Me.btnAgregarCateg.Name = "btnAgregarCateg"
        Me.btnAgregarCateg.Size = New System.Drawing.Size(75, 65)
        Me.btnAgregarCateg.TabIndex = 2
        Me.btnAgregarCateg.Text = "Agregar"
        '
        'txtNombreCat
        '
        Me.txtNombreCat.Location = New System.Drawing.Point(31, 61)
        Me.txtNombreCat.MenuManager = Me.BarManager1
        Me.txtNombreCat.Name = "txtNombreCat"
        Me.txtNombreCat.Size = New System.Drawing.Size(185, 20)
        Me.txtNombreCat.TabIndex = 1
        '
        'LabelCat
        '
        Me.LabelCat.AutoSize = True
        Me.LabelCat.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelCat.Location = New System.Drawing.Point(27, 25)
        Me.LabelCat.Name = "LabelCat"
        Me.LabelCat.Size = New System.Drawing.Size(133, 19)
        Me.LabelCat.TabIndex = 0
        Me.LabelCat.Text = "Nombre Categoria"
        '
        'XtraTabAgregarOrden
        '
        Me.XtraTabAgregarOrden.Controls.Add(Me.GridControlListadoOrden)
        Me.XtraTabAgregarOrden.Controls.Add(Me.PanelControlOrden)
        Me.XtraTabAgregarOrden.Name = "XtraTabAgregarOrden"
        Me.XtraTabAgregarOrden.Size = New System.Drawing.Size(459, 483)
        Me.XtraTabAgregarOrden.Text = "Agregar Orden"
        '
        'GridControlListadoOrden
        '
        Me.GridControlListadoOrden.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridControlListadoOrden.Location = New System.Drawing.Point(0, 100)
        Me.GridControlListadoOrden.MainView = Me.GridViewListadoOrdenCat
        Me.GridControlListadoOrden.MenuManager = Me.BarManager1
        Me.GridControlListadoOrden.Name = "GridControlListadoOrden"
        Me.GridControlListadoOrden.Size = New System.Drawing.Size(459, 383)
        Me.GridControlListadoOrden.TabIndex = 2
        Me.GridControlListadoOrden.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridViewListadoOrdenCat})
        '
        'GridViewListadoOrdenCat
        '
        Me.GridViewListadoOrdenCat.Appearance.EvenRow.Options.UseTextOptions = True
        Me.GridViewListadoOrdenCat.Appearance.EvenRow.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridViewListadoOrdenCat.Appearance.FocusedRow.Options.UseTextOptions = True
        Me.GridViewListadoOrdenCat.Appearance.FocusedRow.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridViewListadoOrdenCat.Appearance.HeaderPanel.Options.UseTextOptions = True
        Me.GridViewListadoOrdenCat.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridViewListadoOrdenCat.Appearance.Row.Options.UseTextOptions = True
        Me.GridViewListadoOrdenCat.Appearance.Row.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridViewListadoOrdenCat.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.NombreOrden, Me.GridCategoria})
        Me.GridViewListadoOrdenCat.GridControl = Me.GridControlListadoOrden
        Me.GridViewListadoOrdenCat.Name = "GridViewListadoOrdenCat"
        '
        'NombreOrden
        '
        Me.NombreOrden.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.NombreOrden.AppearanceHeader.Options.UseFont = True
        Me.NombreOrden.Caption = "Cantidad de Orden"
        Me.NombreOrden.FieldName = "Total"
        Me.NombreOrden.Name = "NombreOrden"
        Me.NombreOrden.Visible = True
        Me.NombreOrden.VisibleIndex = 1
        '
        'GridCategoria
        '
        Me.GridCategoria.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.GridCategoria.AppearanceHeader.Options.UseFont = True
        Me.GridCategoria.Caption = "Nombre Categoria"
        Me.GridCategoria.FieldName = "Nombre_Categoria"
        Me.GridCategoria.Name = "GridCategoria"
        Me.GridCategoria.Visible = True
        Me.GridCategoria.VisibleIndex = 0
        '
        'PanelControlOrden
        '
        Me.PanelControlOrden.Controls.Add(Me.CbxCategoriaOrden)
        Me.PanelControlOrden.Controls.Add(Me.LabelCateg)
        Me.PanelControlOrden.Controls.Add(Me.btnAgregarOrden)
        Me.PanelControlOrden.Controls.Add(Me.txtOrden)
        Me.PanelControlOrden.Controls.Add(Me.Label1)
        Me.PanelControlOrden.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelControlOrden.Location = New System.Drawing.Point(0, 0)
        Me.PanelControlOrden.Name = "PanelControlOrden"
        Me.PanelControlOrden.Size = New System.Drawing.Size(459, 100)
        Me.PanelControlOrden.TabIndex = 1
        '
        'CbxCategoriaOrden
        '
        Me.CbxCategoriaOrden.Location = New System.Drawing.Point(31, 73)
        Me.CbxCategoriaOrden.MenuManager = Me.BarManager1
        Me.CbxCategoriaOrden.Name = "CbxCategoriaOrden"
        Me.CbxCategoriaOrden.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.CbxCategoriaOrden.Size = New System.Drawing.Size(185, 20)
        Me.CbxCategoriaOrden.TabIndex = 6
        '
        'LabelCateg
        '
        Me.LabelCateg.AutoSize = True
        Me.LabelCateg.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelCateg.Location = New System.Drawing.Point(27, 51)
        Me.LabelCateg.Name = "LabelCateg"
        Me.LabelCateg.Size = New System.Drawing.Size(75, 19)
        Me.LabelCateg.TabIndex = 4
        Me.LabelCateg.Text = "Categoria"
        '
        'btnAgregarOrden
        '
        Me.btnAgregarOrden.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAgregarOrden.Appearance.Options.UseFont = True
        Me.btnAgregarOrden.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnAgregarOrden.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.btnAgregarOrden.Image = CType(resources.GetObject("btnAgregarOrden.Image"), System.Drawing.Image)
        Me.btnAgregarOrden.ImageLocation = DevExpress.XtraEditors.ImageLocation.TopCenter
        Me.btnAgregarOrden.Location = New System.Drawing.Point(271, 20)
        Me.btnAgregarOrden.Name = "btnAgregarOrden"
        Me.btnAgregarOrden.Size = New System.Drawing.Size(75, 65)
        Me.btnAgregarOrden.TabIndex = 2
        Me.btnAgregarOrden.Text = "Agregar"
        '
        'txtOrden
        '
        Me.txtOrden.Location = New System.Drawing.Point(31, 31)
        Me.txtOrden.MenuManager = Me.BarManager1
        Me.txtOrden.Name = "txtOrden"
        Me.txtOrden.Size = New System.Drawing.Size(185, 20)
        Me.txtOrden.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(27, 7)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(109, 19)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nombre Orden"
        '
        'WorkspaceManager1
        '
        Me.WorkspaceManager1.TargetControl = Me
        Me.WorkspaceManager1.TransitionType = PushTransition1
        '
        'GridControlRegistro
        '
        Me.GridControlRegistro.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridControlRegistro.Location = New System.Drawing.Point(0, 0)
        Me.GridControlRegistro.MainView = Me.GridViewRegistro
        Me.GridControlRegistro.MenuManager = Me.BarManager1
        Me.GridControlRegistro.Name = "GridControlRegistro"
        Me.GridControlRegistro.Size = New System.Drawing.Size(560, 511)
        Me.GridControlRegistro.TabIndex = 0
        Me.GridControlRegistro.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridViewRegistro})
        '
        'GridViewRegistro
        '
        Me.GridViewRegistro.GridControl = Me.GridControlRegistro
        Me.GridViewRegistro.Name = "GridViewRegistro"
        '
        'FrmMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1030, 558)
        Me.Controls.Add(Me.SplitContainerControl1)
        Me.Controls.Add(Me.barDockControlLeft)
        Me.Controls.Add(Me.barDockControlRight)
        Me.Controls.Add(Me.barDockControlBottom)
        Me.Controls.Add(Me.barDockControlTop)
        Me.Name = "FrmMenu"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FrmMenu"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DockManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SplitContainerControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainerControl1.ResumeLayout(False)
        CType(Me.XtraTabListadoCategoria, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabListadoCategoria.ResumeLayout(False)
        Me.XtraTabAgregarCategoria.ResumeLayout(False)
        CType(Me.GridControlListadoCat, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridViewCategoria, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControlCat, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControlCat.ResumeLayout(False)
        Me.PanelControlCat.PerformLayout()
        CType(Me.txtNombreCat.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabAgregarOrden.ResumeLayout(False)
        CType(Me.GridControlListadoOrden, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridViewListadoOrdenCat, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControlOrden, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControlOrden.ResumeLayout(False)
        Me.PanelControlOrden.PerformLayout()
        CType(Me.CbxCategoriaOrden.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtOrden.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridControlRegistro, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridViewRegistro, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BarManager1 As DevExpress.XtraBars.BarManager
    Friend WithEvents Bar2 As DevExpress.XtraBars.Bar
    Friend WithEvents Bar3 As DevExpress.XtraBars.Bar
    Friend WithEvents barDockControlTop As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlBottom As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlLeft As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlRight As DevExpress.XtraBars.BarDockControl
    Friend WithEvents BarSubItem1 As DevExpress.XtraBars.BarSubItem
    Friend WithEvents BarSubItem2 As DevExpress.XtraBars.BarSubItem
    Friend WithEvents BarDockingMenuItem1 As DevExpress.XtraBars.BarDockingMenuItem
    Friend WithEvents BarSubItem3 As DevExpress.XtraBars.BarSubItem
    Friend WithEvents SkinBarSubItem1 As DevExpress.XtraBars.SkinBarSubItem
    Friend WithEvents BarButtonItem1 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents DockManager1 As DevExpress.XtraBars.Docking.DockManager
    Friend WithEvents SplitContainerControl1 As DevExpress.XtraEditors.SplitContainerControl
    Friend WithEvents XtraTabListadoCategoria As DevExpress.XtraTab.XtraTabControl
    Friend WithEvents XtraTabAgregarCategoria As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents PanelControlCat As DevExpress.XtraEditors.PanelControl
    Friend WithEvents btnAgregarCateg As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txtNombreCat As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelCat As Label
    Friend WithEvents XtraTabAgregarOrden As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents BarLinkContainerItem1 As DevExpress.XtraBars.BarLinkContainerItem
    Friend WithEvents BarWorkspaceMenuItem1 As DevExpress.XtraBars.BarWorkspaceMenuItem
    Friend WithEvents WorkspaceManager1 As DevExpress.Utils.WorkspaceManager
    Friend WithEvents GridControlListadoOrden As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridViewListadoOrdenCat As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents NombreOrden As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridCategoria As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents PanelControlOrden As DevExpress.XtraEditors.PanelControl
    Friend WithEvents btnAgregarOrden As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txtOrden As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label1 As Label
    Friend WithEvents SkinBarSubItem2 As DevExpress.XtraBars.SkinBarSubItem
    Friend WithEvents LabelCateg As Label
    Friend WithEvents CbxCategoriaOrden As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents GridControlListadoCat As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridViewCategoria As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumntb_Categoria As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridControlRegistro As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridViewRegistro As DevExpress.XtraGrid.Views.Grid.GridView
End Class
