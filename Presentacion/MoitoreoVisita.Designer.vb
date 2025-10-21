<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MoitoreoVisita
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim cbZona_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MoitoreoVisita))
        Dim cbRepartidor_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Me.SuperTabControl1 = New DevComponents.DotNetBar.SuperTabControl()
        Me.SuperTabControlPanel1 = New DevComponents.DotNetBar.SuperTabControlPanel()
        Me.btnz1 = New DevComponents.DotNetBar.ButtonX()
        Me.btnz2 = New DevComponents.DotNetBar.ButtonX()
        Me.Gmc_Cliente = New GMap.NET.WindowsForms.GMapControl()
        Me.SuperTabItem1 = New DevComponents.DotNetBar.SuperTabItem()
        Me.SuperTabControlPanel2 = New DevComponents.DotNetBar.SuperTabControlPanel()
        Me.CrystalReportViewer1 = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.SuperTabItem2 = New DevComponents.DotNetBar.SuperTabItem()
        Me.lbHora = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lbobs = New System.Windows.Forms.TextBox()
        Me.lbtel = New System.Windows.Forms.Label()
        Me.lb4 = New System.Windows.Forms.Label()
        Me.lb3 = New System.Windows.Forms.Label()
        Me.lbcliente = New System.Windows.Forms.Label()
        Me.lb1 = New System.Windows.Forms.Label()
        Me.PanelEx1 = New DevComponents.DotNetBar.PanelEx()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.PanelEx2 = New DevComponents.DotNetBar.PanelEx()
        Me.PanelEx3 = New DevComponents.DotNetBar.PanelEx()
        Me.ButtonX1 = New DevComponents.DotNetBar.ButtonX()
        Me.btGenerar = New DevComponents.DotNetBar.ButtonX()
        Me.PanelEx4 = New DevComponents.DotNetBar.PanelEx()
        Me.cbCheck = New DevComponents.DotNetBar.Controls.CheckBoxX()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cbZona = New Janus.Windows.GridEX.EditControls.MultiColumnCombo()
        Me.tbFechaF = New DevComponents.Editors.DateTimeAdv.DateTimeInput()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Tb_Fecha = New DevComponents.Editors.DateTimeAdv.DateTimeInput()
        Me.cbRepartidor = New Janus.Windows.GridEX.EditControls.MultiColumnCombo()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.ColorDialogZona = New System.Windows.Forms.ColorDialog()
        Me.PanelEx5 = New DevComponents.DotNetBar.PanelEx()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.LabelX1 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX2 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX3 = New DevComponents.DotNetBar.LabelX()
        CType(Me.SuperTabControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuperTabControl1.SuspendLayout()
        Me.SuperTabControlPanel1.SuspendLayout()
        Me.SuperTabControlPanel2.SuspendLayout()
        Me.PanelEx1.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.PanelEx2.SuspendLayout()
        Me.PanelEx3.SuspendLayout()
        Me.PanelEx4.SuspendLayout()
        CType(Me.cbZona, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tbFechaF, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tb_Fecha, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbRepartidor, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.PanelEx5.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SuperTabControl1
        '
        '
        '
        '
        '
        '
        '
        Me.SuperTabControl1.ControlBox.CloseBox.Name = ""
        '
        '
        '
        Me.SuperTabControl1.ControlBox.MenuBox.Name = ""
        Me.SuperTabControl1.ControlBox.Name = ""
        Me.SuperTabControl1.ControlBox.SubItems.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.SuperTabControl1.ControlBox.MenuBox, Me.SuperTabControl1.ControlBox.CloseBox})
        Me.SuperTabControl1.Controls.Add(Me.SuperTabControlPanel1)
        Me.SuperTabControl1.Controls.Add(Me.SuperTabControlPanel2)
        Me.SuperTabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SuperTabControl1.Location = New System.Drawing.Point(323, 3)
        Me.SuperTabControl1.Name = "SuperTabControl1"
        Me.SuperTabControl1.ReorderTabsEnabled = True
        Me.SuperTabControl1.SelectedTabFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.SuperTabControl1.SelectedTabIndex = 0
        Me.SuperTabControl1.Size = New System.Drawing.Size(737, 647)
        Me.SuperTabControl1.TabFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SuperTabControl1.TabIndex = 0
        Me.SuperTabControl1.Tabs.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.SuperTabItem2, Me.SuperTabItem1})
        '
        'SuperTabControlPanel1
        '
        Me.SuperTabControlPanel1.Controls.Add(Me.PanelEx5)
        Me.SuperTabControlPanel1.Controls.Add(Me.btnz1)
        Me.SuperTabControlPanel1.Controls.Add(Me.btnz2)
        Me.SuperTabControlPanel1.Controls.Add(Me.Gmc_Cliente)
        Me.SuperTabControlPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SuperTabControlPanel1.Location = New System.Drawing.Point(0, 25)
        Me.SuperTabControlPanel1.Name = "SuperTabControlPanel1"
        Me.SuperTabControlPanel1.Size = New System.Drawing.Size(737, 622)
        Me.SuperTabControlPanel1.TabIndex = 1
        Me.SuperTabControlPanel1.TabItem = Me.SuperTabItem1
        '
        'btnz1
        '
        Me.btnz1.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnz1.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnz1.Image = Global.Presentacion.My.Resources.Resources.iconacercar
        Me.btnz1.Location = New System.Drawing.Point(26, 23)
        Me.btnz1.Name = "btnz1"
        Me.btnz1.Size = New System.Drawing.Size(39, 39)
        Me.btnz1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnz1.TabIndex = 6
        '
        'btnz2
        '
        Me.btnz2.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnz2.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnz2.Image = Global.Presentacion.My.Resources.Resources.iconalejar
        Me.btnz2.Location = New System.Drawing.Point(86, 23)
        Me.btnz2.Name = "btnz2"
        Me.btnz2.Size = New System.Drawing.Size(39, 39)
        Me.btnz2.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnz2.TabIndex = 5
        '
        'Gmc_Cliente
        '
        Me.Gmc_Cliente.AccessibleRole = System.Windows.Forms.AccessibleRole.Animation
        Me.Gmc_Cliente.BackColor = System.Drawing.Color.Transparent
        Me.Gmc_Cliente.Bearing = 0!
        Me.Gmc_Cliente.CanDragMap = True
        Me.Gmc_Cliente.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Gmc_Cliente.EmptyTileColor = System.Drawing.Color.Transparent
        Me.Gmc_Cliente.GrayScaleMode = False
        Me.Gmc_Cliente.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow
        Me.Gmc_Cliente.LevelsKeepInMemmory = 5
        Me.Gmc_Cliente.Location = New System.Drawing.Point(0, 0)
        Me.Gmc_Cliente.MarkersEnabled = True
        Me.Gmc_Cliente.MaxZoom = 2
        Me.Gmc_Cliente.MinZoom = 2
        Me.Gmc_Cliente.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter
        Me.Gmc_Cliente.Name = "Gmc_Cliente"
        Me.Gmc_Cliente.NegativeMode = False
        Me.Gmc_Cliente.PolygonsEnabled = True
        Me.Gmc_Cliente.RetryLoadTile = 0
        Me.Gmc_Cliente.RoutesEnabled = True
        Me.Gmc_Cliente.ScaleMode = GMap.NET.WindowsForms.ScaleModes.[Integer]
        Me.Gmc_Cliente.SelectedAreaFillColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(225, Byte), Integer))
        Me.Gmc_Cliente.ShowTileGridLines = False
        Me.Gmc_Cliente.Size = New System.Drawing.Size(737, 622)
        Me.Gmc_Cliente.TabIndex = 1
        Me.Gmc_Cliente.Zoom = 0R
        '
        'SuperTabItem1
        '
        Me.SuperTabItem1.AttachedControl = Me.SuperTabControlPanel1
        Me.SuperTabItem1.GlobalItem = False
        Me.SuperTabItem1.Name = "SuperTabItem1"
        Me.SuperTabItem1.Text = "MAPA"
        '
        'SuperTabControlPanel2
        '
        Me.SuperTabControlPanel2.Controls.Add(Me.CrystalReportViewer1)
        Me.SuperTabControlPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SuperTabControlPanel2.Location = New System.Drawing.Point(0, 25)
        Me.SuperTabControlPanel2.Name = "SuperTabControlPanel2"
        Me.SuperTabControlPanel2.Size = New System.Drawing.Size(737, 622)
        Me.SuperTabControlPanel2.TabIndex = 0
        Me.SuperTabControlPanel2.TabItem = Me.SuperTabItem2
        '
        'CrystalReportViewer1
        '
        Me.CrystalReportViewer1.ActiveViewIndex = -1
        Me.CrystalReportViewer1.AutoScroll = True
        Me.CrystalReportViewer1.AutoSize = True
        Me.CrystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CrystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default
        Me.CrystalReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CrystalReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.CrystalReportViewer1.Name = "CrystalReportViewer1"
        Me.CrystalReportViewer1.Size = New System.Drawing.Size(737, 622)
        Me.CrystalReportViewer1.TabIndex = 0
        '
        'SuperTabItem2
        '
        Me.SuperTabItem2.AttachedControl = Me.SuperTabControlPanel2
        Me.SuperTabItem2.GlobalItem = False
        Me.SuperTabItem2.Name = "SuperTabItem2"
        Me.SuperTabItem2.Text = "REPORTE"
        '
        'lbHora
        '
        Me.lbHora.AutoSize = True
        Me.lbHora.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbHora.ForeColor = System.Drawing.Color.FromArgb(CType(CType(49, Byte), Integer), CType(CType(59, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.lbHora.Location = New System.Drawing.Point(20, 237)
        Me.lbHora.Name = "lbHora"
        Me.lbHora.Size = New System.Drawing.Size(44, 16)
        Me.lbHora.TabIndex = 9
        Me.lbHora.Text = "HORA"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(49, Byte), Integer), CType(CType(59, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(20, 207)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(55, 18)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "HORA:"
        '
        'lbobs
        '
        Me.lbobs.BackColor = System.Drawing.Color.WhiteSmoke
        Me.lbobs.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.lbobs.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbobs.Location = New System.Drawing.Point(19, 107)
        Me.lbobs.Multiline = True
        Me.lbobs.Name = "lbobs"
        Me.lbobs.Size = New System.Drawing.Size(288, 31)
        Me.lbobs.TabIndex = 7
        '
        'lbtel
        '
        Me.lbtel.AutoSize = True
        Me.lbtel.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbtel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(49, Byte), Integer), CType(CType(59, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.lbtel.Location = New System.Drawing.Point(20, 184)
        Me.lbtel.Name = "lbtel"
        Me.lbtel.Size = New System.Drawing.Size(51, 16)
        Me.lbtel.TabIndex = 5
        Me.lbtel.Text = "FECHA"
        '
        'lb4
        '
        Me.lb4.AutoSize = True
        Me.lb4.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(49, Byte), Integer), CType(CType(59, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.lb4.Location = New System.Drawing.Point(20, 157)
        Me.lb4.Name = "lb4"
        Me.lb4.Size = New System.Drawing.Size(62, 18)
        Me.lb4.TabIndex = 4
        Me.lb4.Text = "FECHA:"
        '
        'lb3
        '
        Me.lb3.AutoSize = True
        Me.lb3.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(49, Byte), Integer), CType(CType(59, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.lb3.Location = New System.Drawing.Point(17, 86)
        Me.lb3.Name = "lb3"
        Me.lb3.Size = New System.Drawing.Size(121, 18)
        Me.lb3.TabIndex = 2
        Me.lb3.Text = "OBSERVACION:"
        '
        'lbcliente
        '
        Me.lbcliente.AutoSize = True
        Me.lbcliente.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbcliente.ForeColor = System.Drawing.Color.FromArgb(CType(CType(49, Byte), Integer), CType(CType(59, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.lbcliente.Location = New System.Drawing.Point(17, 59)
        Me.lbcliente.Name = "lbcliente"
        Me.lbcliente.Size = New System.Drawing.Size(60, 16)
        Me.lbcliente.TabIndex = 1
        Me.lbcliente.Text = "CLIENTE"
        '
        'lb1
        '
        Me.lb1.AutoSize = True
        Me.lb1.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(49, Byte), Integer), CType(CType(59, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.lb1.Location = New System.Drawing.Point(16, 29)
        Me.lb1.Name = "lb1"
        Me.lb1.Size = New System.Drawing.Size(77, 18)
        Me.lb1.TabIndex = 0
        Me.lb1.Text = "CLIENTE:"
        '
        'PanelEx1
        '
        Me.PanelEx1.CanvasColor = System.Drawing.SystemColors.Control
        Me.PanelEx1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.PanelEx1.Controls.Add(Me.TableLayoutPanel2)
        Me.PanelEx1.DisabledBackColor = System.Drawing.Color.Empty
        Me.PanelEx1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelEx1.Location = New System.Drawing.Point(3, 3)
        Me.PanelEx1.Name = "PanelEx1"
        Me.PanelEx1.Size = New System.Drawing.Size(314, 647)
        Me.PanelEx1.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.PanelEx1.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.PanelEx1.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.PanelEx1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.PanelEx1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.PanelEx1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.PanelEx1.Style.GradientAngle = 90
        Me.PanelEx1.TabIndex = 7
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 1
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.PanelEx2, 0, 2)
        Me.TableLayoutPanel2.Controls.Add(Me.PanelEx3, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.PanelEx4, 0, 1)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 3
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 120.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 250.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(314, 647)
        Me.TableLayoutPanel2.TabIndex = 237
        '
        'PanelEx2
        '
        Me.PanelEx2.CanvasColor = System.Drawing.SystemColors.Control
        Me.PanelEx2.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.PanelEx2.Controls.Add(Me.lb1)
        Me.PanelEx2.Controls.Add(Me.lbcliente)
        Me.PanelEx2.Controls.Add(Me.lb3)
        Me.PanelEx2.Controls.Add(Me.lb4)
        Me.PanelEx2.Controls.Add(Me.lbtel)
        Me.PanelEx2.Controls.Add(Me.lbobs)
        Me.PanelEx2.Controls.Add(Me.Label5)
        Me.PanelEx2.Controls.Add(Me.lbHora)
        Me.PanelEx2.DisabledBackColor = System.Drawing.Color.Empty
        Me.PanelEx2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelEx2.Location = New System.Drawing.Point(3, 373)
        Me.PanelEx2.Name = "PanelEx2"
        Me.PanelEx2.Size = New System.Drawing.Size(308, 271)
        Me.PanelEx2.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.PanelEx2.Style.BackColor1.Color = System.Drawing.Color.WhiteSmoke
        Me.PanelEx2.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.PanelEx2.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.PanelEx2.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.PanelEx2.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.PanelEx2.Style.GradientAngle = 90
        Me.PanelEx2.TabIndex = 10
        '
        'PanelEx3
        '
        Me.PanelEx3.CanvasColor = System.Drawing.SystemColors.Control
        Me.PanelEx3.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.PanelEx3.Controls.Add(Me.ButtonX1)
        Me.PanelEx3.Controls.Add(Me.btGenerar)
        Me.PanelEx3.DisabledBackColor = System.Drawing.Color.Empty
        Me.PanelEx3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelEx3.Location = New System.Drawing.Point(3, 3)
        Me.PanelEx3.Name = "PanelEx3"
        Me.PanelEx3.Size = New System.Drawing.Size(308, 114)
        Me.PanelEx3.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.PanelEx3.Style.BackColor1.Color = System.Drawing.Color.Gray
        Me.PanelEx3.Style.BackColor2.Color = System.Drawing.SystemColors.ActiveCaption
        Me.PanelEx3.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.PanelEx3.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.PanelEx3.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.PanelEx3.Style.GradientAngle = 90
        Me.PanelEx3.TabIndex = 10
        '
        'ButtonX1
        '
        Me.ButtonX1.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.ButtonX1.ColorTable = DevComponents.DotNetBar.eButtonColor.Flat
        Me.ButtonX1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonX1.Image = Global.Presentacion.My.Resources.Resources.atras
        Me.ButtonX1.ImageFixedSize = New System.Drawing.Size(60, 60)
        Me.ButtonX1.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.ButtonX1.Location = New System.Drawing.Point(170, 6)
        Me.ButtonX1.Name = "ButtonX1"
        Me.ButtonX1.Size = New System.Drawing.Size(75, 84)
        Me.ButtonX1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.ButtonX1.TabIndex = 236
        Me.ButtonX1.Text = "SALIR"
        '
        'btGenerar
        '
        Me.btGenerar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btGenerar.ColorTable = DevComponents.DotNetBar.eButtonColor.Flat
        Me.btGenerar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btGenerar.Image = Global.Presentacion.My.Resources.Resources.REGISTRO
        Me.btGenerar.ImageFixedSize = New System.Drawing.Size(60, 60)
        Me.btGenerar.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.btGenerar.Location = New System.Drawing.Point(60, 6)
        Me.btGenerar.Name = "btGenerar"
        Me.btGenerar.Size = New System.Drawing.Size(75, 84)
        Me.btGenerar.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btGenerar.TabIndex = 235
        Me.btGenerar.Text = "GENERAR"
        '
        'PanelEx4
        '
        Me.PanelEx4.CanvasColor = System.Drawing.SystemColors.Control
        Me.PanelEx4.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.PanelEx4.Controls.Add(Me.cbCheck)
        Me.PanelEx4.Controls.Add(Me.Label4)
        Me.PanelEx4.Controls.Add(Me.cbZona)
        Me.PanelEx4.Controls.Add(Me.tbFechaF)
        Me.PanelEx4.Controls.Add(Me.Label1)
        Me.PanelEx4.Controls.Add(Me.Tb_Fecha)
        Me.PanelEx4.Controls.Add(Me.cbRepartidor)
        Me.PanelEx4.Controls.Add(Me.Label3)
        Me.PanelEx4.Controls.Add(Me.Label2)
        Me.PanelEx4.DisabledBackColor = System.Drawing.Color.Empty
        Me.PanelEx4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelEx4.Location = New System.Drawing.Point(3, 123)
        Me.PanelEx4.Name = "PanelEx4"
        Me.PanelEx4.Size = New System.Drawing.Size(308, 244)
        Me.PanelEx4.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.PanelEx4.Style.BackColor1.Color = System.Drawing.SystemColors.ActiveCaption
        Me.PanelEx4.Style.BackColor2.Color = System.Drawing.Color.WhiteSmoke
        Me.PanelEx4.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.PanelEx4.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.PanelEx4.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.PanelEx4.Style.GradientAngle = 90
        Me.PanelEx4.TabIndex = 14
        '
        'cbCheck
        '
        '
        '
        '
        Me.cbCheck.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.cbCheck.CheckBoxPosition = DevComponents.DotNetBar.eCheckBoxPosition.Right
        Me.cbCheck.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold)
        Me.cbCheck.Location = New System.Drawing.Point(6, 218)
        Me.cbCheck.Name = "cbCheck"
        Me.cbCheck.Size = New System.Drawing.Size(209, 23)
        Me.cbCheck.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.cbCheck.TabIndex = 237
        Me.cbCheck.Text = "Ver Clientes No Visitados"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(49, Byte), Integer), CType(CType(59, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(16, 80)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(46, 18)
        Me.Label4.TabIndex = 236
        Me.Label4.Text = "Zona:"
        '
        'cbZona
        '
        Me.cbZona.BorderStyle = Janus.Windows.GridEX.BorderStyle.Flat
        Me.cbZona.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        cbZona_DesignTimeLayout.LayoutString = resources.GetString("cbZona_DesignTimeLayout.LayoutString")
        Me.cbZona.DesignTimeLayout = cbZona_DesignTimeLayout
        Me.cbZona.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbZona.Location = New System.Drawing.Point(54, 110)
        Me.cbZona.Name = "cbZona"
        Me.cbZona.Office2007ColorScheme = Janus.Windows.GridEX.Office2007ColorScheme.Custom
        Me.cbZona.Office2007CustomColor = System.Drawing.Color.DodgerBlue
        Me.cbZona.SelectedIndex = -1
        Me.cbZona.SelectedItem = Nothing
        Me.cbZona.Size = New System.Drawing.Size(232, 22)
        Me.cbZona.TabIndex = 235
        Me.cbZona.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
        '
        'tbFechaF
        '
        '
        '
        '
        Me.tbFechaF.BackgroundStyle.Class = "DateTimeInputBackground"
        Me.tbFechaF.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.tbFechaF.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown
        Me.tbFechaF.ButtonDropDown.Visible = True
        Me.tbFechaF.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbFechaF.IsPopupCalendarOpen = False
        Me.tbFechaF.Location = New System.Drawing.Point(92, 178)
        '
        '
        '
        '
        '
        '
        Me.tbFechaF.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.tbFechaF.MonthCalendar.CalendarDimensions = New System.Drawing.Size(1, 1)
        Me.tbFechaF.MonthCalendar.ClearButtonVisible = True
        '
        '
        '
        Me.tbFechaF.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2
        Me.tbFechaF.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90
        Me.tbFechaF.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground
        Me.tbFechaF.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.tbFechaF.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder
        Me.tbFechaF.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1
        Me.tbFechaF.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.tbFechaF.MonthCalendar.DisplayMonth = New Date(2017, 2, 1, 0, 0, 0, 0)
        Me.tbFechaF.MonthCalendar.FirstDayOfWeek = System.DayOfWeek.Monday
        '
        '
        '
        Me.tbFechaF.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.tbFechaF.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90
        Me.tbFechaF.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.tbFechaF.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.tbFechaF.MonthCalendar.TodayButtonVisible = True
        Me.tbFechaF.Name = "tbFechaF"
        Me.tbFechaF.Size = New System.Drawing.Size(120, 22)
        Me.tbFechaF.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.tbFechaF.TabIndex = 234
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(49, Byte), Integer), CType(CType(59, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(16, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(88, 18)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Repartidor:"
        '
        'Tb_Fecha
        '
        '
        '
        '
        Me.Tb_Fecha.BackgroundStyle.Class = "DateTimeInputBackground"
        Me.Tb_Fecha.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.Tb_Fecha.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown
        Me.Tb_Fecha.ButtonDropDown.Visible = True
        Me.Tb_Fecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tb_Fecha.IsPopupCalendarOpen = False
        Me.Tb_Fecha.Location = New System.Drawing.Point(92, 139)
        '
        '
        '
        '
        '
        '
        Me.Tb_Fecha.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.Tb_Fecha.MonthCalendar.CalendarDimensions = New System.Drawing.Size(1, 1)
        Me.Tb_Fecha.MonthCalendar.ClearButtonVisible = True
        '
        '
        '
        Me.Tb_Fecha.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2
        Me.Tb_Fecha.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90
        Me.Tb_Fecha.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground
        Me.Tb_Fecha.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.Tb_Fecha.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder
        Me.Tb_Fecha.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1
        Me.Tb_Fecha.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.Tb_Fecha.MonthCalendar.DisplayMonth = New Date(2017, 2, 1, 0, 0, 0, 0)
        Me.Tb_Fecha.MonthCalendar.FirstDayOfWeek = System.DayOfWeek.Monday
        '
        '
        '
        Me.Tb_Fecha.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.Tb_Fecha.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90
        Me.Tb_Fecha.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.Tb_Fecha.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.Tb_Fecha.MonthCalendar.TodayButtonVisible = True
        Me.Tb_Fecha.Name = "Tb_Fecha"
        Me.Tb_Fecha.Size = New System.Drawing.Size(120, 22)
        Me.Tb_Fecha.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.Tb_Fecha.TabIndex = 233
        '
        'cbRepartidor
        '
        Me.cbRepartidor.BorderStyle = Janus.Windows.GridEX.BorderStyle.Flat
        Me.cbRepartidor.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        cbRepartidor_DesignTimeLayout.LayoutString = resources.GetString("cbRepartidor_DesignTimeLayout.LayoutString")
        Me.cbRepartidor.DesignTimeLayout = cbRepartidor_DesignTimeLayout
        Me.cbRepartidor.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbRepartidor.Location = New System.Drawing.Point(54, 43)
        Me.cbRepartidor.Name = "cbRepartidor"
        Me.cbRepartidor.Office2007ColorScheme = Janus.Windows.GridEX.Office2007ColorScheme.Custom
        Me.cbRepartidor.Office2007CustomColor = System.Drawing.Color.DodgerBlue
        Me.cbRepartidor.SelectedIndex = -1
        Me.cbRepartidor.SelectedItem = Nothing
        Me.cbRepartidor.Size = New System.Drawing.Size(232, 22)
        Me.cbRepartidor.TabIndex = 4
        Me.cbRepartidor.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(49, Byte), Integer), CType(CType(59, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(18, 181)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(25, 18)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Al:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(49, Byte), Integer), CType(CType(59, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(16, 143)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(36, 18)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Del:"
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 320.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.SuperTabControl1, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.PanelEx1, 0, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(1063, 653)
        Me.TableLayoutPanel1.TabIndex = 11
        '
        'PanelEx5
        '
        Me.PanelEx5.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.PanelEx5.CanvasColor = System.Drawing.Color.Transparent
        Me.PanelEx5.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.PanelEx5.Controls.Add(Me.LabelX3)
        Me.PanelEx5.Controls.Add(Me.LabelX2)
        Me.PanelEx5.Controls.Add(Me.LabelX1)
        Me.PanelEx5.Controls.Add(Me.PictureBox3)
        Me.PanelEx5.Controls.Add(Me.PictureBox2)
        Me.PanelEx5.Controls.Add(Me.PictureBox1)
        Me.PanelEx5.DisabledBackColor = System.Drawing.Color.Empty
        Me.PanelEx5.Location = New System.Drawing.Point(3, 455)
        Me.PanelEx5.Name = "PanelEx5"
        Me.PanelEx5.Size = New System.Drawing.Size(222, 158)
        Me.PanelEx5.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.PanelEx5.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.PanelEx5.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.PanelEx5.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.PanelEx5.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.PanelEx5.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.PanelEx5.Style.GradientAngle = 90
        Me.PanelEx5.TabIndex = 7
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Presentacion.My.Resources.Resources.mapa_19
        Me.PictureBox1.Location = New System.Drawing.Point(14, 63)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(37, 37)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.Presentacion.My.Resources.Resources.mapa_22
        Me.PictureBox2.Location = New System.Drawing.Point(13, 17)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(38, 37)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 1
        Me.PictureBox2.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = Global.Presentacion.My.Resources.Resources.mapa_3
        Me.PictureBox3.Location = New System.Drawing.Point(13, 110)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(37, 36)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox3.TabIndex = 2
        Me.PictureBox3.TabStop = False
        '
        'LabelX1
        '
        '
        '
        '
        Me.LabelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX1.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX1.Location = New System.Drawing.Point(57, 17)
        Me.LabelX1.Name = "LabelX1"
        Me.LabelX1.Size = New System.Drawing.Size(146, 23)
        Me.LabelX1.TabIndex = 3
        Me.LabelX1.Text = "Visitados Con Pedido"
        '
        'LabelX2
        '
        '
        '
        '
        Me.LabelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX2.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX2.Location = New System.Drawing.Point(56, 68)
        Me.LabelX2.Name = "LabelX2"
        Me.LabelX2.Size = New System.Drawing.Size(146, 23)
        Me.LabelX2.TabIndex = 4
        Me.LabelX2.Text = "Visitados Sin Pedido"
        '
        'LabelX3
        '
        '
        '
        '
        Me.LabelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX3.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX3.Location = New System.Drawing.Point(57, 110)
        Me.LabelX3.Name = "LabelX3"
        Me.LabelX3.Size = New System.Drawing.Size(146, 23)
        Me.LabelX3.TabIndex = 5
        Me.LabelX3.Text = "Clientes No Visitados"
        '
        'MoitoreoVisita
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1063, 653)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Name = "MoitoreoVisita"
        Me.Text = "MoitoreoVisita"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.SuperTabControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SuperTabControl1.ResumeLayout(False)
        Me.SuperTabControlPanel1.ResumeLayout(False)
        Me.SuperTabControlPanel2.ResumeLayout(False)
        Me.SuperTabControlPanel2.PerformLayout()
        Me.PanelEx1.ResumeLayout(False)
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.PanelEx2.ResumeLayout(False)
        Me.PanelEx2.PerformLayout()
        Me.PanelEx3.ResumeLayout(False)
        Me.PanelEx4.ResumeLayout(False)
        Me.PanelEx4.PerformLayout()
        CType(Me.cbZona, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tbFechaF, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tb_Fecha, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbRepartidor, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.PanelEx5.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents SuperTabControl1 As DevComponents.DotNetBar.SuperTabControl
    Friend WithEvents SuperTabControlPanel1 As DevComponents.DotNetBar.SuperTabControlPanel
    Friend WithEvents SuperTabItem1 As DevComponents.DotNetBar.SuperTabItem
    Friend WithEvents Gmc_Cliente As GMap.NET.WindowsForms.GMapControl
    Friend WithEvents lbobs As TextBox
    Friend WithEvents lbtel As Label
    Friend WithEvents lb4 As Label
    Friend WithEvents lb3 As Label
    Friend WithEvents lbcliente As Label
    Friend WithEvents lb1 As Label
    Friend WithEvents btnz2 As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btnz1 As DevComponents.DotNetBar.ButtonX
    Friend WithEvents PanelEx1 As DevComponents.DotNetBar.PanelEx
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents cbRepartidor As Janus.Windows.GridEX.EditControls.MultiColumnCombo
    Friend WithEvents tbFechaF As DevComponents.Editors.DateTimeAdv.DateTimeInput
    Friend WithEvents Tb_Fecha As DevComponents.Editors.DateTimeAdv.DateTimeInput
    Friend WithEvents SuperTabControlPanel2 As DevComponents.DotNetBar.SuperTabControlPanel
    Friend WithEvents CrystalReportViewer1 As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents SuperTabItem2 As DevComponents.DotNetBar.SuperTabItem
    Friend WithEvents btGenerar As DevComponents.DotNetBar.ButtonX
    Friend WithEvents ButtonX1 As DevComponents.DotNetBar.ButtonX
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents lbHora As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents PanelEx3 As DevComponents.DotNetBar.PanelEx
    Friend WithEvents PanelEx4 As DevComponents.DotNetBar.PanelEx
    Friend WithEvents PanelEx2 As DevComponents.DotNetBar.PanelEx
    Friend WithEvents Label4 As Label
    Friend WithEvents cbZona As Janus.Windows.GridEX.EditControls.MultiColumnCombo
    Friend WithEvents cbCheck As DevComponents.DotNetBar.Controls.CheckBoxX
    Friend WithEvents ColorDialogZona As ColorDialog
    Friend WithEvents PanelEx5 As DevComponents.DotNetBar.PanelEx
    Friend WithEvents LabelX3 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX2 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX1 As DevComponents.DotNetBar.LabelX
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
End Class
