<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Dashboard
    Inherits Modelo.ModeloHor

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
        Dim cbMes_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Dashboard))
        Me.ConMenu_Opciones2 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.AñadirObsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GRABARRECLAMOToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.GRABARRECLAMOREPARTIDORToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.VERHISTORIALToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ANULARPEDIDOToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.IMPRIMIRPEDIDOToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SuperTabItem3 = New DevComponents.DotNetBar.SuperTabItem()
        Me.SuperTabControlPanel3 = New DevComponents.DotNetBar.SuperTabControlPanel()
        Me.PanelEx12 = New DevComponents.DotNetBar.PanelEx()
        Me.PanelEx14 = New DevComponents.DotNetBar.PanelEx()
        Me.grKPI2 = New DevComponents.DotNetBar.SuperGrid.SuperGridControl()
        Me.PanelEx7 = New DevComponents.DotNetBar.PanelEx()
        Me.GroupPanel1 = New DevComponents.DotNetBar.Controls.GroupPanel()
        Me.PanelEx8 = New DevComponents.DotNetBar.PanelEx()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.cbFecha = New DevComponents.DotNetBar.Controls.CheckBoxX()
        Me.cbConci = New DevComponents.DotNetBar.Controls.CheckBoxX()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.tbFechaF = New DevComponents.Editors.DateTimeAdv.DateTimeInput()
        Me.tbFechaI = New DevComponents.Editors.DateTimeAdv.DateTimeInput()
        Me.btGenerar2 = New DevComponents.DotNetBar.ButtonX()
        Me.ConMenu_Imprimir = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ToolStripMenuItem_ImprimirFiltrado = New System.Windows.Forms.ToolStripMenuItem()
        Me.SuperTabItem4 = New DevComponents.DotNetBar.SuperTabItem()
        Me.SuperTabControlPanel4 = New DevComponents.DotNetBar.SuperTabControlPanel()
        Me.PanelEx18 = New DevComponents.DotNetBar.PanelEx()
        Me.GroupPanel5 = New DevComponents.DotNetBar.Controls.GroupPanel()
        Me.ButtonX3 = New DevComponents.DotNetBar.ButtonX()
        Me.tbtop = New DevComponents.Editors.IntegerInput()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.tbFechaFin = New DevComponents.Editors.DateTimeAdv.DateTimeInput()
        Me.tbFechaIni = New DevComponents.Editors.DateTimeAdv.DateTimeInput()
        Me.cbProducto3 = New DevComponents.DotNetBar.Controls.CheckBoxX()
        Me.cbProducto2 = New DevComponents.DotNetBar.Controls.CheckBoxX()
        Me.cbProducto1 = New DevComponents.DotNetBar.Controls.CheckBoxX()
        Me.ButtonX1 = New DevComponents.DotNetBar.ButtonX()
        Me.PanelEx20 = New DevComponents.DotNetBar.PanelEx()
        Me.ProductosMas = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.SuperGridControl2 = New DevComponents.DotNetBar.SuperGrid.SuperGridControl()
        Me.ConMenu_Opciones3 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.RETORNARPEDIDOACONFIRMACIONDEENTREGAToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GRABARRECLAMOToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GRABARRECLAMOREPARTIDORToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.VERHISTORIALToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConMenu_Opciones1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.GRABARRECLAMOREPARTIDORToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VERHISTORIALToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ANULARPEDIDOToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PrintDialog1 = New System.Windows.Forms.PrintDialog()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.ConMenu_Rechazado = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.SuperGridControl1 = New DevComponents.DotNetBar.SuperGrid.SuperGridControl()
        Me.PanelEx6 = New DevComponents.DotNetBar.PanelEx()
        Me.GroupPanelDatosGenerales = New DevComponents.DotNetBar.Controls.GroupPanel()
        Me.PanelExDatosGenerales = New DevComponents.DotNetBar.PanelEx()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnGenerar = New DevComponents.DotNetBar.ButtonX()
        Me.tbAño = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cbMes = New Janus.Windows.GridEX.EditControls.MultiColumnCombo()
        Me.grPresupuesto = New DevComponents.DotNetBar.SuperGrid.SuperGridControl()
        Me.SuperTabItem5 = New DevComponents.DotNetBar.SuperTabItem()
        Me.SuperTabControlPanel5 = New DevComponents.DotNetBar.SuperTabControlPanel()
        Me.PanelEx9 = New DevComponents.DotNetBar.PanelEx()
        Me.GroupPanel2 = New DevComponents.DotNetBar.Controls.GroupPanel()
        Me.tbtop2 = New DevComponents.Editors.IntegerInput()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.tbFechaF2 = New DevComponents.Editors.DateTimeAdv.DateTimeInput()
        Me.tbFechaI2 = New DevComponents.Editors.DateTimeAdv.DateTimeInput()
        Me.CheckBoxX1 = New DevComponents.DotNetBar.Controls.CheckBoxX()
        Me.CheckBoxX2 = New DevComponents.DotNetBar.Controls.CheckBoxX()
        Me.CheckBoxX3 = New DevComponents.DotNetBar.Controls.CheckBoxX()
        Me.ButtonX2 = New DevComponents.DotNetBar.ButtonX()
        Me.PanelEx10 = New DevComponents.DotNetBar.PanelEx()
        Me.RClientes = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.SuperGridControl3 = New DevComponents.DotNetBar.SuperGrid.SuperGridControl()
        Me.SuperTabItem6 = New DevComponents.DotNetBar.SuperTabItem()
        Me.SuperTabControlPanel6 = New DevComponents.DotNetBar.SuperTabControlPanel()
        Me.PanelEx11 = New DevComponents.DotNetBar.PanelEx()
        Me.GroupPanel3 = New DevComponents.DotNetBar.Controls.GroupPanel()
        Me.ButtonX4 = New DevComponents.DotNetBar.ButtonX()
        Me.tbTop3 = New DevComponents.Editors.IntegerInput()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.tbFechaF3 = New DevComponents.Editors.DateTimeAdv.DateTimeInput()
        Me.tbFechaI3 = New DevComponents.Editors.DateTimeAdv.DateTimeInput()
        Me.cbVendedorUtilidad = New DevComponents.DotNetBar.Controls.CheckBoxX()
        Me.cbVendedorMas = New DevComponents.DotNetBar.Controls.CheckBoxX()
        Me.PanelEx13 = New DevComponents.DotNetBar.PanelEx()
        Me.CRVendedores = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.SuperGridControl4 = New DevComponents.DotNetBar.SuperGrid.SuperGridControl()
        Me.DsReportesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsReportes = New Presentacion.dsReportes()
        CType(Me.SuperTabControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuperTabControl1.SuspendLayout()
        Me.SuperTabControlPanel2.SuspendLayout()
        Me.SuperTabControlPanel1.SuspendLayout()
        Me.PanelEx1.SuspendLayout()
        CType(Me.BubbleBar1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BubbleBar2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelEx2.SuspendLayout()
        CType(Me.BubbleBar4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BubbleBar3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BubbleBar5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelEx5.SuspendLayout()
        Me.ConMenu_Opciones2.SuspendLayout()
        Me.SuperTabControlPanel3.SuspendLayout()
        Me.PanelEx12.SuspendLayout()
        Me.PanelEx14.SuspendLayout()
        Me.PanelEx7.SuspendLayout()
        Me.GroupPanel1.SuspendLayout()
        Me.PanelEx8.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.tbFechaF, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tbFechaI, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ConMenu_Imprimir.SuspendLayout()
        Me.SuperTabControlPanel4.SuspendLayout()
        Me.PanelEx18.SuspendLayout()
        Me.GroupPanel5.SuspendLayout()
        CType(Me.tbtop, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tbFechaFin, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tbFechaIni, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelEx20.SuspendLayout()
        Me.ConMenu_Opciones3.SuspendLayout()
        Me.ConMenu_Opciones1.SuspendLayout()
        Me.ConMenu_Rechazado.SuspendLayout()
        Me.PanelEx6.SuspendLayout()
        Me.GroupPanelDatosGenerales.SuspendLayout()
        Me.PanelExDatosGenerales.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.cbMes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuperTabControlPanel5.SuspendLayout()
        Me.PanelEx9.SuspendLayout()
        Me.GroupPanel2.SuspendLayout()
        CType(Me.tbtop2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tbFechaF2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tbFechaI2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelEx10.SuspendLayout()
        Me.SuperTabControlPanel6.SuspendLayout()
        Me.PanelEx11.SuspendLayout()
        Me.GroupPanel3.SuspendLayout()
        CType(Me.tbTop3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tbFechaF3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tbFechaI3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelEx13.SuspendLayout()
        CType(Me.DsReportesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsReportes, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.SuperTabControl1.Controls.Add(Me.SuperTabControlPanel4)
        Me.SuperTabControl1.Controls.Add(Me.SuperTabControlPanel3)
        Me.SuperTabControl1.Controls.Add(Me.SuperTabControlPanel6)
        Me.SuperTabControl1.Controls.Add(Me.SuperTabControlPanel5)
        Me.SuperTabControl1.Margin = New System.Windows.Forms.Padding(4)
        Me.SuperTabControl1.SelectedTabIndex = 1
        Me.SuperTabControl1.Size = New System.Drawing.Size(1284, 661)
        Me.SuperTabControl1.Tabs.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.SuperTabItem3, Me.SuperTabItem4, Me.SuperTabItem5, Me.SuperTabItem6})
        Me.SuperTabControl1.Text = "PEDIDOS ENTREGADOS"
        Me.SuperTabControl1.Controls.SetChildIndex(Me.SuperTabControlPanel1, 0)
        Me.SuperTabControl1.Controls.SetChildIndex(Me.SuperTabControlPanel5, 0)
        Me.SuperTabControl1.Controls.SetChildIndex(Me.SuperTabControlPanel6, 0)
        Me.SuperTabControl1.Controls.SetChildIndex(Me.SuperTabControlPanel2, 0)
        Me.SuperTabControl1.Controls.SetChildIndex(Me.SuperTabControlPanel3, 0)
        Me.SuperTabControl1.Controls.SetChildIndex(Me.SuperTabControlPanel4, 0)
        '
        'SuperTabControlPanel2
        '
        Me.SuperTabControlPanel2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SuperTabControlPanel2.Controls.Add(Me.grPresupuesto)
        Me.SuperTabControlPanel2.Controls.Add(Me.PanelEx6)
        Me.SuperTabControlPanel2.Controls.Add(Me.SuperGridControl1)
        Me.SuperTabControlPanel2.Dock = System.Windows.Forms.DockStyle.None
        Me.SuperTabControlPanel2.Margin = New System.Windows.Forms.Padding(4)
        Me.SuperTabControlPanel2.Size = New System.Drawing.Size(42884, 11036)
        Me.SuperTabControlPanel2.Visible = True
        '
        'SuperTabItem2
        '
        Me.SuperTabItem2.Text = "META ECONOMICA"
        '
        'SuperTabControlPanel1
        '
        Me.SuperTabControlPanel1.Margin = New System.Windows.Forms.Padding(4)
        Me.SuperTabControlPanel1.Size = New System.Drawing.Size(1284, 636)
        Me.SuperTabControlPanel1.Controls.SetChildIndex(Me.PanelEx1, 0)
        Me.SuperTabControlPanel1.Controls.SetChildIndex(Me.PanelEx2, 0)
        Me.SuperTabControlPanel1.Controls.SetChildIndex(Me.PanelEx3, 0)
        Me.SuperTabControlPanel1.Controls.SetChildIndex(Me.PanelEx4, 0)
        '
        'SuperTabItem1
        '
        Me.SuperTabItem1.Visible = False
        '
        'PanelEx1
        '
        Me.PanelEx1.Margin = New System.Windows.Forms.Padding(4)
        Me.PanelEx1.Size = New System.Drawing.Size(1284, 64)
        Me.PanelEx1.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.PanelEx1.Style.BackColor1.Color = System.Drawing.Color.Blue
        Me.PanelEx1.Style.BackColor2.Color = System.Drawing.Color.Blue
        Me.PanelEx1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.PanelEx1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.PanelEx1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.PanelEx1.Style.GradientAngle = 90
        '
        'BubbleBar1
        '
        '
        '
        '
        Me.BubbleBar1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.BubbleBar1.ButtonBackAreaStyle.BackColor = System.Drawing.Color.Transparent
        Me.BubbleBar1.ButtonBackAreaStyle.BorderBottomWidth = 1
        Me.BubbleBar1.ButtonBackAreaStyle.BorderColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.BubbleBar1.ButtonBackAreaStyle.BorderLeftWidth = 1
        Me.BubbleBar1.ButtonBackAreaStyle.BorderRightWidth = 1
        Me.BubbleBar1.ButtonBackAreaStyle.BorderTopWidth = 1
        Me.BubbleBar1.ButtonBackAreaStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.BubbleBar1.ButtonBackAreaStyle.PaddingBottom = 3
        Me.BubbleBar1.ButtonBackAreaStyle.PaddingLeft = 3
        Me.BubbleBar1.ButtonBackAreaStyle.PaddingRight = 3
        Me.BubbleBar1.ButtonBackAreaStyle.PaddingTop = 3
        Me.BubbleBar1.MouseOverTabColors.BorderColor = System.Drawing.SystemColors.Highlight
        Me.BubbleBar1.SelectedTabColors.BorderColor = System.Drawing.Color.Black
        '
        'BBtn_Grabar
        '
        Me.BBtn_Grabar.Enabled = False
        '
        'BBtn_Cancelar
        '
        Me.BBtn_Cancelar.TooltipText = "SALIR"
        '
        'BubbleBar2
        '
        '
        '
        '
        Me.BubbleBar2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.BubbleBar2.ButtonBackAreaStyle.BackColor = System.Drawing.Color.Transparent
        Me.BubbleBar2.ButtonBackAreaStyle.BorderBottomWidth = 1
        Me.BubbleBar2.ButtonBackAreaStyle.BorderColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.BubbleBar2.ButtonBackAreaStyle.BorderLeftWidth = 1
        Me.BubbleBar2.ButtonBackAreaStyle.BorderRightWidth = 1
        Me.BubbleBar2.ButtonBackAreaStyle.BorderTopWidth = 1
        Me.BubbleBar2.ButtonBackAreaStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.BubbleBar2.ButtonBackAreaStyle.PaddingBottom = 3
        Me.BubbleBar2.ButtonBackAreaStyle.PaddingLeft = 3
        Me.BubbleBar2.ButtonBackAreaStyle.PaddingRight = 3
        Me.BubbleBar2.ButtonBackAreaStyle.PaddingTop = 3
        Me.BubbleBar2.Location = New System.Drawing.Point(1220, 0)
        Me.BubbleBar2.Margin = New System.Windows.Forms.Padding(4)
        Me.BubbleBar2.MouseOverTabColors.BorderColor = System.Drawing.SystemColors.Highlight
        Me.BubbleBar2.SelectedTabColors.BorderColor = System.Drawing.Color.Black
        '
        'PanelEx2
        '
        Me.PanelEx2.Location = New System.Drawing.Point(0, 600)
        Me.PanelEx2.Margin = New System.Windows.Forms.Padding(4)
        Me.PanelEx2.Size = New System.Drawing.Size(1284, 36)
        Me.PanelEx2.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.PanelEx2.Style.BackColor1.Color = System.Drawing.Color.Blue
        Me.PanelEx2.Style.BackColor2.Color = System.Drawing.Color.Blue
        Me.PanelEx2.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.PanelEx2.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.PanelEx2.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.PanelEx2.Style.GradientAngle = 90
        Me.PanelEx2.Controls.SetChildIndex(Me.BubbleBar3, 0)
        Me.PanelEx2.Controls.SetChildIndex(Me.PanelEx5, 0)
        Me.PanelEx2.Controls.SetChildIndex(Me.BubbleBar4, 0)
        Me.PanelEx2.Controls.SetChildIndex(Me.Txt_Paginacion, 0)
        '
        'PanelEx3
        '
        Me.PanelEx3.Margin = New System.Windows.Forms.Padding(4)
        Me.PanelEx3.Size = New System.Drawing.Size(1284, 200)
        Me.PanelEx3.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.PanelEx3.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.PanelEx3.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.PanelEx3.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.PanelEx3.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.PanelEx3.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.PanelEx3.Style.GradientAngle = 90
        '
        'PanelEx4
        '
        Me.PanelEx4.Margin = New System.Windows.Forms.Padding(4)
        Me.PanelEx4.Size = New System.Drawing.Size(1284, 336)
        Me.PanelEx4.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.PanelEx4.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.PanelEx4.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.PanelEx4.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.PanelEx4.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.PanelEx4.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.PanelEx4.Style.GradientAngle = 90
        '
        'BubbleBar4
        '
        '
        '
        '
        Me.BubbleBar4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.BubbleBar4.ButtonBackAreaStyle.BackColor = System.Drawing.Color.Transparent
        Me.BubbleBar4.ButtonBackAreaStyle.BorderBottomWidth = 1
        Me.BubbleBar4.ButtonBackAreaStyle.BorderColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.BubbleBar4.ButtonBackAreaStyle.BorderLeftWidth = 1
        Me.BubbleBar4.ButtonBackAreaStyle.BorderRightWidth = 1
        Me.BubbleBar4.ButtonBackAreaStyle.BorderTopWidth = 1
        Me.BubbleBar4.ButtonBackAreaStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.BubbleBar4.ButtonBackAreaStyle.PaddingBottom = 3
        Me.BubbleBar4.ButtonBackAreaStyle.PaddingLeft = 3
        Me.BubbleBar4.ButtonBackAreaStyle.PaddingRight = 3
        Me.BubbleBar4.ButtonBackAreaStyle.PaddingTop = 3
        Me.BubbleBar4.MouseOverTabColors.BorderColor = System.Drawing.SystemColors.Highlight
        Me.BubbleBar4.SelectedTabColors.BorderColor = System.Drawing.Color.Black
        '
        'BubbleBar3
        '
        '
        '
        '
        Me.BubbleBar3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.BubbleBar3.ButtonBackAreaStyle.BackColor = System.Drawing.Color.Transparent
        Me.BubbleBar3.ButtonBackAreaStyle.BorderBottomWidth = 1
        Me.BubbleBar3.ButtonBackAreaStyle.BorderColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.BubbleBar3.ButtonBackAreaStyle.BorderLeftWidth = 1
        Me.BubbleBar3.ButtonBackAreaStyle.BorderRightWidth = 1
        Me.BubbleBar3.ButtonBackAreaStyle.BorderTopWidth = 1
        Me.BubbleBar3.ButtonBackAreaStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.BubbleBar3.ButtonBackAreaStyle.PaddingBottom = 3
        Me.BubbleBar3.ButtonBackAreaStyle.PaddingLeft = 3
        Me.BubbleBar3.ButtonBackAreaStyle.PaddingRight = 3
        Me.BubbleBar3.ButtonBackAreaStyle.PaddingTop = 3
        Me.BubbleBar3.MouseOverTabColors.BorderColor = System.Drawing.SystemColors.Highlight
        Me.BubbleBar3.SelectedTabColors.BorderColor = System.Drawing.Color.Black
        '
        'BubbleBar5
        '
        '
        '
        '
        Me.BubbleBar5.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.BubbleBar5.ButtonBackAreaStyle.BackColor = System.Drawing.Color.Transparent
        Me.BubbleBar5.ButtonBackAreaStyle.BorderBottomWidth = 1
        Me.BubbleBar5.ButtonBackAreaStyle.BorderColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.BubbleBar5.ButtonBackAreaStyle.BorderLeftWidth = 1
        Me.BubbleBar5.ButtonBackAreaStyle.BorderRightWidth = 1
        Me.BubbleBar5.ButtonBackAreaStyle.BorderTopWidth = 1
        Me.BubbleBar5.ButtonBackAreaStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.BubbleBar5.ButtonBackAreaStyle.PaddingBottom = 3
        Me.BubbleBar5.ButtonBackAreaStyle.PaddingLeft = 3
        Me.BubbleBar5.ButtonBackAreaStyle.PaddingRight = 3
        Me.BubbleBar5.ButtonBackAreaStyle.PaddingTop = 3
        Me.BubbleBar5.MouseOverTabColors.BorderColor = System.Drawing.SystemColors.Highlight
        Me.BubbleBar5.SelectedTabColors.BorderColor = System.Drawing.Color.Black
        '
        'PanelEx5
        '
        Me.PanelEx5.Location = New System.Drawing.Point(1084, 0)
        Me.PanelEx5.Margin = New System.Windows.Forms.Padding(4)
        Me.PanelEx5.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.PanelEx5.Style.BackColor1.Color = System.Drawing.Color.Blue
        Me.PanelEx5.Style.BackColor2.Color = System.Drawing.Color.Blue
        Me.PanelEx5.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.PanelEx5.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.PanelEx5.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.PanelEx5.Style.GradientAngle = 90
        '
        'Txt_NombreUsu
        '
        Me.Txt_NombreUsu.Text = "DEFAULT"
        '
        'ConMenu_Opciones2
        '
        Me.ConMenu_Opciones2.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ConMenu_Opciones2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AñadirObsToolStripMenuItem, Me.GRABARRECLAMOToolStripMenuItem1, Me.GRABARRECLAMOREPARTIDORToolStripMenuItem1, Me.VERHISTORIALToolStripMenuItem1, Me.ANULARPEDIDOToolStripMenuItem1, Me.IMPRIMIRPEDIDOToolStripMenuItem})
        Me.ConMenu_Opciones2.Name = "ConMenu_Opciones"
        Me.ConMenu_Opciones2.Size = New System.Drawing.Size(267, 160)
        '
        'AñadirObsToolStripMenuItem
        '
        Me.AñadirObsToolStripMenuItem.Image = Global.Presentacion.My.Resources.Resources.ANTERIOR
        Me.AñadirObsToolStripMenuItem.Name = "AñadirObsToolStripMenuItem"
        Me.AñadirObsToolStripMenuItem.Size = New System.Drawing.Size(266, 26)
        Me.AñadirObsToolStripMenuItem.Text = "RETORNAR PEDIDO A ASIGNACION"
        '
        'GRABARRECLAMOToolStripMenuItem1
        '
        Me.GRABARRECLAMOToolStripMenuItem1.Image = Global.Presentacion.My.Resources.Resources.ADICIONAR
        Me.GRABARRECLAMOToolStripMenuItem1.Name = "GRABARRECLAMOToolStripMenuItem1"
        Me.GRABARRECLAMOToolStripMenuItem1.Size = New System.Drawing.Size(266, 26)
        Me.GRABARRECLAMOToolStripMenuItem1.Text = "GRABAR RECLAMO CLIENTE"
        '
        'GRABARRECLAMOREPARTIDORToolStripMenuItem1
        '
        Me.GRABARRECLAMOREPARTIDORToolStripMenuItem1.Image = Global.Presentacion.My.Resources.Resources.ADICIONAR
        Me.GRABARRECLAMOREPARTIDORToolStripMenuItem1.Name = "GRABARRECLAMOREPARTIDORToolStripMenuItem1"
        Me.GRABARRECLAMOREPARTIDORToolStripMenuItem1.Size = New System.Drawing.Size(266, 26)
        Me.GRABARRECLAMOREPARTIDORToolStripMenuItem1.Text = "GRABAR RECLAMO REPARTIDOR"
        '
        'VERHISTORIALToolStripMenuItem1
        '
        Me.VERHISTORIALToolStripMenuItem1.Name = "VERHISTORIALToolStripMenuItem1"
        Me.VERHISTORIALToolStripMenuItem1.Size = New System.Drawing.Size(266, 26)
        Me.VERHISTORIALToolStripMenuItem1.Text = "VER ESTADOS"
        '
        'ANULARPEDIDOToolStripMenuItem1
        '
        Me.ANULARPEDIDOToolStripMenuItem1.Image = Global.Presentacion.My.Resources.Resources.I64x64_error
        Me.ANULARPEDIDOToolStripMenuItem1.Name = "ANULARPEDIDOToolStripMenuItem1"
        Me.ANULARPEDIDOToolStripMenuItem1.Size = New System.Drawing.Size(266, 26)
        Me.ANULARPEDIDOToolStripMenuItem1.Text = "ANULAR PEDIDO"
        '
        'IMPRIMIRPEDIDOToolStripMenuItem
        '
        Me.IMPRIMIRPEDIDOToolStripMenuItem.Image = Global.Presentacion.My.Resources.Resources.I32x32_printer
        Me.IMPRIMIRPEDIDOToolStripMenuItem.Name = "IMPRIMIRPEDIDOToolStripMenuItem"
        Me.IMPRIMIRPEDIDOToolStripMenuItem.Size = New System.Drawing.Size(266, 26)
        Me.IMPRIMIRPEDIDOToolStripMenuItem.Text = "IMPRIMIR PEDIDO"
        '
        'SuperTabItem3
        '
        Me.SuperTabItem3.AttachedControl = Me.SuperTabControlPanel3
        Me.SuperTabItem3.GlobalItem = False
        Me.SuperTabItem3.Name = "SuperTabItem3"
        Me.SuperTabItem3.Text = "EFICIENCIA DE ENTREGA"
        '
        'SuperTabControlPanel3
        '
        Me.SuperTabControlPanel3.Controls.Add(Me.PanelEx12)
        Me.SuperTabControlPanel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SuperTabControlPanel3.Location = New System.Drawing.Point(0, 25)
        Me.SuperTabControlPanel3.Name = "SuperTabControlPanel3"
        Me.SuperTabControlPanel3.Size = New System.Drawing.Size(1284, 636)
        Me.SuperTabControlPanel3.TabIndex = 0
        Me.SuperTabControlPanel3.TabItem = Me.SuperTabItem3
        '
        'PanelEx12
        '
        Me.PanelEx12.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PanelEx12.CanvasColor = System.Drawing.SystemColors.Control
        Me.PanelEx12.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.PanelEx12.Controls.Add(Me.PanelEx14)
        Me.PanelEx12.DisabledBackColor = System.Drawing.Color.Empty
        Me.PanelEx12.Location = New System.Drawing.Point(3, 2)
        Me.PanelEx12.Name = "PanelEx12"
        Me.PanelEx12.Size = New System.Drawing.Size(1278, 633)
        Me.PanelEx12.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.PanelEx12.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.PanelEx12.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.PanelEx12.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.PanelEx12.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.PanelEx12.Style.GradientAngle = 90
        Me.PanelEx12.TabIndex = 4
        '
        'PanelEx14
        '
        Me.PanelEx14.CanvasColor = System.Drawing.SystemColors.Control
        Me.PanelEx14.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.PanelEx14.Controls.Add(Me.grKPI2)
        Me.PanelEx14.Controls.Add(Me.PanelEx7)
        Me.PanelEx14.DisabledBackColor = System.Drawing.Color.Empty
        Me.PanelEx14.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelEx14.Location = New System.Drawing.Point(0, 0)
        Me.PanelEx14.Name = "PanelEx14"
        Me.PanelEx14.Size = New System.Drawing.Size(1278, 633)
        Me.PanelEx14.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.PanelEx14.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.PanelEx14.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.PanelEx14.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.PanelEx14.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.PanelEx14.Style.GradientAngle = 90
        Me.PanelEx14.TabIndex = 19
        Me.PanelEx14.Text = "PanelEx14"
        Me.PanelEx14.TextDockConstrained = False
        '
        'grKPI2
        '
        Me.grKPI2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grKPI2.FilterExprColors.SysFunction = System.Drawing.Color.DarkRed
        Me.grKPI2.Location = New System.Drawing.Point(324, 0)
        Me.grKPI2.Name = "grKPI2"
        Me.grKPI2.Size = New System.Drawing.Size(954, 633)
        Me.grKPI2.TabIndex = 121
        Me.grKPI2.Text = "SuperGridControl2"
        '
        'PanelEx7
        '
        Me.PanelEx7.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.PanelEx7.CanvasColor = System.Drawing.SystemColors.Control
        Me.PanelEx7.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.PanelEx7.Controls.Add(Me.GroupPanel1)
        Me.PanelEx7.DisabledBackColor = System.Drawing.Color.Empty
        Me.PanelEx7.Location = New System.Drawing.Point(0, 1)
        Me.PanelEx7.Name = "PanelEx7"
        Me.PanelEx7.Size = New System.Drawing.Size(324, 636)
        Me.PanelEx7.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.PanelEx7.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.PanelEx7.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.PanelEx7.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.PanelEx7.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.PanelEx7.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.PanelEx7.Style.GradientAngle = 90
        Me.PanelEx7.TabIndex = 120
        '
        'GroupPanel1
        '
        Me.GroupPanel1.CanvasColor = System.Drawing.SystemColors.Control
        Me.GroupPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.GroupPanel1.Controls.Add(Me.PanelEx8)
        Me.GroupPanel1.DisabledBackColor = System.Drawing.Color.Empty
        Me.GroupPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupPanel1.Location = New System.Drawing.Point(0, 0)
        Me.GroupPanel1.Name = "GroupPanel1"
        Me.GroupPanel1.Size = New System.Drawing.Size(324, 636)
        '
        '
        '
        Me.GroupPanel1.Style.BackColor = System.Drawing.SystemColors.Control
        Me.GroupPanel1.Style.BackColor2 = System.Drawing.SystemColors.Control
        Me.GroupPanel1.Style.BackColorGradientAngle = 90
        Me.GroupPanel1.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel1.Style.BorderBottomWidth = 1
        Me.GroupPanel1.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.GroupPanel1.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel1.Style.BorderLeftWidth = 1
        Me.GroupPanel1.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel1.Style.BorderRightWidth = 1
        Me.GroupPanel1.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel1.Style.BorderTopWidth = 1
        Me.GroupPanel1.Style.CornerDiameter = 4
        Me.GroupPanel1.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded
        Me.GroupPanel1.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center
        Me.GroupPanel1.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.GroupPanel1.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near
        '
        '
        '
        Me.GroupPanel1.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.GroupPanel1.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.GroupPanel1.TabIndex = 30
        Me.GroupPanel1.Text = "DATOS GENERALES"
        '
        'PanelEx8
        '
        Me.PanelEx8.AutoScroll = True
        Me.PanelEx8.CanvasColor = System.Drawing.SystemColors.Control
        Me.PanelEx8.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.PanelEx8.Controls.Add(Me.GroupBox2)
        Me.PanelEx8.DisabledBackColor = System.Drawing.Color.Empty
        Me.PanelEx8.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelEx8.Location = New System.Drawing.Point(0, 0)
        Me.PanelEx8.Name = "PanelEx8"
        Me.PanelEx8.Size = New System.Drawing.Size(318, 615)
        Me.PanelEx8.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.PanelEx8.Style.BackColor1.Color = System.Drawing.SystemColors.Control
        Me.PanelEx8.Style.BackColor2.Color = System.Drawing.SystemColors.Control
        Me.PanelEx8.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.PanelEx8.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.PanelEx8.Style.GradientAngle = 90
        Me.PanelEx8.TabIndex = 0
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.cbFecha)
        Me.GroupBox2.Controls.Add(Me.cbConci)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.tbFechaF)
        Me.GroupBox2.Controls.Add(Me.tbFechaI)
        Me.GroupBox2.Controls.Add(Me.btGenerar2)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(5, 3)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(310, 306)
        Me.GroupBox2.TabIndex = 113
        Me.GroupBox2.TabStop = False
        '
        'cbFecha
        '
        '
        '
        '
        Me.cbFecha.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.cbFecha.CheckBoxStyle = DevComponents.DotNetBar.eCheckBoxStyle.RadioButton
        Me.cbFecha.Location = New System.Drawing.Point(18, 81)
        Me.cbFecha.Name = "cbFecha"
        Me.cbFecha.Size = New System.Drawing.Size(100, 23)
        Me.cbFecha.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.cbFecha.TabIndex = 120
        Me.cbFecha.Text = "Por Fecha"
        '
        'cbConci
        '
        '
        '
        '
        Me.cbConci.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.cbConci.CheckBoxStyle = DevComponents.DotNetBar.eCheckBoxStyle.RadioButton
        Me.cbConci.Location = New System.Drawing.Point(18, 39)
        Me.cbConci.Name = "cbConci"
        Me.cbConci.Size = New System.Drawing.Size(147, 23)
        Me.cbConci.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.cbConci.TabIndex = 119
        Me.cbConci.Text = "Por Conciliación"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(15, 210)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(24, 17)
        Me.Label2.TabIndex = 118
        Me.Label2.Text = "Al:"
        Me.Label2.Visible = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(15, 148)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(33, 17)
        Me.Label4.TabIndex = 117
        Me.Label4.Text = "Del:"
        Me.Label4.Visible = False
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
        Me.tbFechaF.IsPopupCalendarOpen = False
        Me.tbFechaF.Location = New System.Drawing.Point(92, 210)
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
        Me.tbFechaF.MonthCalendar.DisplayMonth = New Date(2024, 1, 1, 0, 0, 0, 0)
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
        Me.tbFechaF.Size = New System.Drawing.Size(200, 23)
        Me.tbFechaF.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.tbFechaF.TabIndex = 116
        Me.tbFechaF.Visible = False
        '
        'tbFechaI
        '
        '
        '
        '
        Me.tbFechaI.BackgroundStyle.Class = "DateTimeInputBackground"
        Me.tbFechaI.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.tbFechaI.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown
        Me.tbFechaI.ButtonDropDown.Visible = True
        Me.tbFechaI.IsPopupCalendarOpen = False
        Me.tbFechaI.Location = New System.Drawing.Point(92, 148)
        '
        '
        '
        '
        '
        '
        Me.tbFechaI.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.tbFechaI.MonthCalendar.CalendarDimensions = New System.Drawing.Size(1, 1)
        Me.tbFechaI.MonthCalendar.ClearButtonVisible = True
        '
        '
        '
        Me.tbFechaI.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2
        Me.tbFechaI.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90
        Me.tbFechaI.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground
        Me.tbFechaI.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.tbFechaI.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder
        Me.tbFechaI.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1
        Me.tbFechaI.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.tbFechaI.MonthCalendar.DisplayMonth = New Date(2024, 1, 1, 0, 0, 0, 0)
        Me.tbFechaI.MonthCalendar.FirstDayOfWeek = System.DayOfWeek.Monday
        '
        '
        '
        Me.tbFechaI.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.tbFechaI.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90
        Me.tbFechaI.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.tbFechaI.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.tbFechaI.MonthCalendar.TodayButtonVisible = True
        Me.tbFechaI.Name = "tbFechaI"
        Me.tbFechaI.Size = New System.Drawing.Size(200, 23)
        Me.tbFechaI.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.tbFechaI.TabIndex = 115
        Me.tbFechaI.Visible = False
        '
        'btGenerar2
        '
        Me.btGenerar2.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btGenerar2.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btGenerar2.Location = New System.Drawing.Point(119, 259)
        Me.btGenerar2.Name = "btGenerar2"
        Me.btGenerar2.Size = New System.Drawing.Size(75, 23)
        Me.btGenerar2.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btGenerar2.TabIndex = 114
        Me.btGenerar2.Text = "GENERAR"
        '
        'ConMenu_Imprimir
        '
        Me.ConMenu_Imprimir.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ConMenu_Imprimir.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem_ImprimirFiltrado})
        Me.ConMenu_Imprimir.Name = "ConMenu_Opciones3"
        Me.ConMenu_Imprimir.Size = New System.Drawing.Size(192, 42)
        '
        'ToolStripMenuItem_ImprimirFiltrado
        '
        Me.ToolStripMenuItem_ImprimirFiltrado.Image = Global.Presentacion.My.Resources.Resources.I32x32_printer
        Me.ToolStripMenuItem_ImprimirFiltrado.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ToolStripMenuItem_ImprimirFiltrado.Name = "ToolStripMenuItem_ImprimirFiltrado"
        Me.ToolStripMenuItem_ImprimirFiltrado.Size = New System.Drawing.Size(191, 38)
        Me.ToolStripMenuItem_ImprimirFiltrado.Text = "IMPRIMIR RECIBOS"
        '
        'SuperTabItem4
        '
        Me.SuperTabItem4.AttachedControl = Me.SuperTabControlPanel4
        Me.SuperTabItem4.GlobalItem = False
        Me.SuperTabItem4.Name = "SuperTabItem4"
        Me.SuperTabItem4.Text = "PRODUCTOS"
        '
        'SuperTabControlPanel4
        '
        Me.SuperTabControlPanel4.Controls.Add(Me.PanelEx18)
        Me.SuperTabControlPanel4.Controls.Add(Me.PanelEx20)
        Me.SuperTabControlPanel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SuperTabControlPanel4.Location = New System.Drawing.Point(0, 25)
        Me.SuperTabControlPanel4.Name = "SuperTabControlPanel4"
        Me.SuperTabControlPanel4.Size = New System.Drawing.Size(1284, 636)
        Me.SuperTabControlPanel4.TabIndex = 0
        Me.SuperTabControlPanel4.TabItem = Me.SuperTabItem4
        '
        'PanelEx18
        '
        Me.PanelEx18.CanvasColor = System.Drawing.SystemColors.Control
        Me.PanelEx18.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.PanelEx18.Controls.Add(Me.GroupPanel5)
        Me.PanelEx18.DisabledBackColor = System.Drawing.Color.Empty
        Me.PanelEx18.Dock = System.Windows.Forms.DockStyle.Left
        Me.PanelEx18.Location = New System.Drawing.Point(0, 0)
        Me.PanelEx18.Name = "PanelEx18"
        Me.PanelEx18.Size = New System.Drawing.Size(320, 636)
        Me.PanelEx18.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.PanelEx18.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.PanelEx18.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.PanelEx18.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.PanelEx18.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.PanelEx18.Style.GradientAngle = 90
        Me.PanelEx18.TabIndex = 12
        '
        'GroupPanel5
        '
        Me.GroupPanel5.BackColor = System.Drawing.Color.Transparent
        Me.GroupPanel5.CanvasColor = System.Drawing.SystemColors.Control
        Me.GroupPanel5.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.GroupPanel5.Controls.Add(Me.ButtonX3)
        Me.GroupPanel5.Controls.Add(Me.tbtop)
        Me.GroupPanel5.Controls.Add(Me.Label7)
        Me.GroupPanel5.Controls.Add(Me.Label6)
        Me.GroupPanel5.Controls.Add(Me.Label5)
        Me.GroupPanel5.Controls.Add(Me.tbFechaFin)
        Me.GroupPanel5.Controls.Add(Me.tbFechaIni)
        Me.GroupPanel5.Controls.Add(Me.cbProducto3)
        Me.GroupPanel5.Controls.Add(Me.cbProducto2)
        Me.GroupPanel5.Controls.Add(Me.cbProducto1)
        Me.GroupPanel5.Controls.Add(Me.ButtonX1)
        Me.GroupPanel5.DisabledBackColor = System.Drawing.Color.Empty
        Me.GroupPanel5.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupPanel5.Location = New System.Drawing.Point(0, 0)
        Me.GroupPanel5.Name = "GroupPanel5"
        Me.GroupPanel5.Size = New System.Drawing.Size(320, 636)
        '
        '
        '
        Me.GroupPanel5.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.GroupPanel5.Style.BackColorGradientAngle = 90
        Me.GroupPanel5.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.GroupPanel5.Style.BorderBottomWidth = 1
        Me.GroupPanel5.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.GroupPanel5.Style.BorderLeftWidth = 1
        Me.GroupPanel5.Style.BorderRightWidth = 1
        Me.GroupPanel5.Style.BorderTopWidth = 1
        Me.GroupPanel5.Style.CornerDiameter = 4
        Me.GroupPanel5.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded
        Me.GroupPanel5.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center
        Me.GroupPanel5.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.GroupPanel5.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near
        '
        '
        '
        Me.GroupPanel5.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.GroupPanel5.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.GroupPanel5.TabIndex = 110
        Me.GroupPanel5.Text = "DATOS"
        '
        'ButtonX3
        '
        Me.ButtonX3.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.ButtonX3.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.ButtonX3.Image = Global.Presentacion.My.Resources.Resources.down1
        Me.ButtonX3.ImageFixedSize = New System.Drawing.Size(40, 40)
        Me.ButtonX3.Location = New System.Drawing.Point(199, 326)
        Me.ButtonX3.Name = "ButtonX3"
        Me.ButtonX3.Size = New System.Drawing.Size(46, 40)
        Me.ButtonX3.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.ButtonX3.TabIndex = 125
        '
        'tbtop
        '
        '
        '
        '
        Me.tbtop.BackgroundStyle.Class = "DateTimeInputBackground"
        Me.tbtop.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.tbtop.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2
        Me.tbtop.Location = New System.Drawing.Point(119, 279)
        Me.tbtop.MaxValue = 40
        Me.tbtop.Name = "tbtop"
        Me.tbtop.ShowUpDown = True
        Me.tbtop.Size = New System.Drawing.Size(144, 20)
        Me.tbtop.TabIndex = 124
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label7.ForeColor = System.Drawing.Color.DarkBlue
        Me.Label7.Location = New System.Drawing.Point(37, 286)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(36, 13)
        Me.Label7.TabIndex = 123
        Me.Label7.Text = "TOP:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label6.ForeColor = System.Drawing.Color.DarkBlue
        Me.Label6.Location = New System.Drawing.Point(37, 231)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(26, 13)
        Me.Label6.TabIndex = 122
        Me.Label6.Text = "AL:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label5.ForeColor = System.Drawing.Color.DarkBlue
        Me.Label5.Location = New System.Drawing.Point(37, 194)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(35, 13)
        Me.Label5.TabIndex = 121
        Me.Label5.Text = "DEL:"
        '
        'tbFechaFin
        '
        '
        '
        '
        Me.tbFechaFin.BackgroundStyle.Class = "DateTimeInputBackground"
        Me.tbFechaFin.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.tbFechaFin.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown
        Me.tbFechaFin.ButtonDropDown.Visible = True
        Me.tbFechaFin.IsPopupCalendarOpen = False
        Me.tbFechaFin.Location = New System.Drawing.Point(119, 224)
        '
        '
        '
        '
        '
        '
        Me.tbFechaFin.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.tbFechaFin.MonthCalendar.CalendarDimensions = New System.Drawing.Size(1, 1)
        Me.tbFechaFin.MonthCalendar.ClearButtonVisible = True
        '
        '
        '
        Me.tbFechaFin.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2
        Me.tbFechaFin.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90
        Me.tbFechaFin.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground
        Me.tbFechaFin.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.tbFechaFin.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder
        Me.tbFechaFin.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1
        Me.tbFechaFin.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.tbFechaFin.MonthCalendar.DisplayMonth = New Date(2024, 1, 1, 0, 0, 0, 0)
        Me.tbFechaFin.MonthCalendar.FirstDayOfWeek = System.DayOfWeek.Monday
        '
        '
        '
        Me.tbFechaFin.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.tbFechaFin.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90
        Me.tbFechaFin.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.tbFechaFin.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.tbFechaFin.MonthCalendar.TodayButtonVisible = True
        Me.tbFechaFin.Name = "tbFechaFin"
        Me.tbFechaFin.Size = New System.Drawing.Size(144, 20)
        Me.tbFechaFin.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.tbFechaFin.TabIndex = 120
        '
        'tbFechaIni
        '
        '
        '
        '
        Me.tbFechaIni.BackgroundStyle.Class = "DateTimeInputBackground"
        Me.tbFechaIni.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.tbFechaIni.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown
        Me.tbFechaIni.ButtonDropDown.Visible = True
        Me.tbFechaIni.IsPopupCalendarOpen = False
        Me.tbFechaIni.Location = New System.Drawing.Point(119, 188)
        '
        '
        '
        '
        '
        '
        Me.tbFechaIni.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.tbFechaIni.MonthCalendar.CalendarDimensions = New System.Drawing.Size(1, 1)
        Me.tbFechaIni.MonthCalendar.ClearButtonVisible = True
        '
        '
        '
        Me.tbFechaIni.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2
        Me.tbFechaIni.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90
        Me.tbFechaIni.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground
        Me.tbFechaIni.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.tbFechaIni.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder
        Me.tbFechaIni.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1
        Me.tbFechaIni.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.tbFechaIni.MonthCalendar.DisplayMonth = New Date(2024, 1, 1, 0, 0, 0, 0)
        Me.tbFechaIni.MonthCalendar.FirstDayOfWeek = System.DayOfWeek.Monday
        '
        '
        '
        Me.tbFechaIni.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.tbFechaIni.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90
        Me.tbFechaIni.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.tbFechaIni.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.tbFechaIni.MonthCalendar.TodayButtonVisible = True
        Me.tbFechaIni.Name = "tbFechaIni"
        Me.tbFechaIni.Size = New System.Drawing.Size(144, 20)
        Me.tbFechaIni.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.tbFechaIni.TabIndex = 119
        '
        'cbProducto3
        '
        '
        '
        '
        Me.cbProducto3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.cbProducto3.CheckBoxStyle = DevComponents.DotNetBar.eCheckBoxStyle.RadioButton
        Me.cbProducto3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbProducto3.Location = New System.Drawing.Point(27, 120)
        Me.cbProducto3.Name = "cbProducto3"
        Me.cbProducto3.Size = New System.Drawing.Size(236, 23)
        Me.cbProducto3.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.cbProducto3.TabIndex = 118
        Me.cbProducto3.Text = "PRODUCTO MAS VENDIDO (UNIDADES)"
        Me.cbProducto3.TextColor = System.Drawing.Color.DarkBlue
        '
        'cbProducto2
        '
        '
        '
        '
        Me.cbProducto2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.cbProducto2.CheckBoxStyle = DevComponents.DotNetBar.eCheckBoxStyle.RadioButton
        Me.cbProducto2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbProducto2.Location = New System.Drawing.Point(27, 79)
        Me.cbProducto2.Name = "cbProducto2"
        Me.cbProducto2.Size = New System.Drawing.Size(228, 23)
        Me.cbProducto2.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.cbProducto2.TabIndex = 117
        Me.cbProducto2.Text = "PRODUCTO CON MAYOR UTILIDAD"
        Me.cbProducto2.TextColor = System.Drawing.Color.DarkBlue
        '
        'cbProducto1
        '
        '
        '
        '
        Me.cbProducto1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.cbProducto1.CheckBoxStyle = DevComponents.DotNetBar.eCheckBoxStyle.RadioButton
        Me.cbProducto1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbProducto1.Location = New System.Drawing.Point(27, 40)
        Me.cbProducto1.Name = "cbProducto1"
        Me.cbProducto1.Size = New System.Drawing.Size(218, 23)
        Me.cbProducto1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.cbProducto1.TabIndex = 116
        Me.cbProducto1.Text = "PRODUCTO MAS VENDIDO (BS)"
        Me.cbProducto1.TextColor = System.Drawing.Color.DarkBlue
        '
        'ButtonX1
        '
        Me.ButtonX1.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.ButtonX1.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.ButtonX1.Image = Global.Presentacion.My.Resources.Resources.up1
        Me.ButtonX1.ImageFixedSize = New System.Drawing.Size(40, 40)
        Me.ButtonX1.ImagePosition = DevComponents.DotNetBar.eImagePosition.Bottom
        Me.ButtonX1.Location = New System.Drawing.Point(84, 323)
        Me.ButtonX1.Name = "ButtonX1"
        Me.ButtonX1.Size = New System.Drawing.Size(43, 43)
        Me.ButtonX1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.ButtonX1.TabIndex = 115
        '
        'PanelEx20
        '
        Me.PanelEx20.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PanelEx20.CanvasColor = System.Drawing.SystemColors.Control
        Me.PanelEx20.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.PanelEx20.Controls.Add(Me.ProductosMas)
        Me.PanelEx20.Controls.Add(Me.SuperGridControl2)
        Me.PanelEx20.DisabledBackColor = System.Drawing.Color.Empty
        Me.PanelEx20.Location = New System.Drawing.Point(323, 2)
        Me.PanelEx20.Name = "PanelEx20"
        Me.PanelEx20.Size = New System.Drawing.Size(958, 633)
        Me.PanelEx20.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.PanelEx20.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.PanelEx20.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.PanelEx20.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.PanelEx20.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.PanelEx20.Style.GradientAngle = 90
        Me.PanelEx20.TabIndex = 16
        '
        'ProductosMas
        '
        Me.ProductosMas.ActiveViewIndex = -1
        Me.ProductosMas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ProductosMas.Cursor = System.Windows.Forms.Cursors.Default
        Me.ProductosMas.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ProductosMas.Location = New System.Drawing.Point(0, 0)
        Me.ProductosMas.Name = "ProductosMas"
        Me.ProductosMas.Size = New System.Drawing.Size(958, 633)
        Me.ProductosMas.TabIndex = 1
        Me.ProductosMas.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
        '
        'SuperGridControl2
        '
        Me.SuperGridControl2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SuperGridControl2.FilterExprColors.SysFunction = System.Drawing.Color.DarkRed
        Me.SuperGridControl2.Location = New System.Drawing.Point(0, 0)
        Me.SuperGridControl2.Name = "SuperGridControl2"
        Me.SuperGridControl2.Size = New System.Drawing.Size(958, 633)
        Me.SuperGridControl2.TabIndex = 0
        Me.SuperGridControl2.Text = "SuperGridControl2"
        '
        'ConMenu_Opciones3
        '
        Me.ConMenu_Opciones3.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ConMenu_Opciones3.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RETORNARPEDIDOACONFIRMACIONDEENTREGAToolStripMenuItem, Me.GRABARRECLAMOToolStripMenuItem, Me.GRABARRECLAMOREPARTIDORToolStripMenuItem2, Me.VERHISTORIALToolStripMenuItem2})
        Me.ConMenu_Opciones3.Name = "ConMenu_Opciones3"
        Me.ConMenu_Opciones3.Size = New System.Drawing.Size(353, 92)
        '
        'RETORNARPEDIDOACONFIRMACIONDEENTREGAToolStripMenuItem
        '
        Me.RETORNARPEDIDOACONFIRMACIONDEENTREGAToolStripMenuItem.Name = "RETORNARPEDIDOACONFIRMACIONDEENTREGAToolStripMenuItem"
        Me.RETORNARPEDIDOACONFIRMACIONDEENTREGAToolStripMenuItem.Size = New System.Drawing.Size(352, 22)
        Me.RETORNARPEDIDOACONFIRMACIONDEENTREGAToolStripMenuItem.Text = "RETORNAR PEDIDO A CONFIRMACION DE ENTREGA"
        '
        'GRABARRECLAMOToolStripMenuItem
        '
        Me.GRABARRECLAMOToolStripMenuItem.Name = "GRABARRECLAMOToolStripMenuItem"
        Me.GRABARRECLAMOToolStripMenuItem.Size = New System.Drawing.Size(352, 22)
        Me.GRABARRECLAMOToolStripMenuItem.Text = "GRABAR RECLAMO CLIENTE"
        '
        'GRABARRECLAMOREPARTIDORToolStripMenuItem2
        '
        Me.GRABARRECLAMOREPARTIDORToolStripMenuItem2.Name = "GRABARRECLAMOREPARTIDORToolStripMenuItem2"
        Me.GRABARRECLAMOREPARTIDORToolStripMenuItem2.Size = New System.Drawing.Size(352, 22)
        Me.GRABARRECLAMOREPARTIDORToolStripMenuItem2.Text = "GRABAR RECLAMO REPARTIDOR"
        '
        'VERHISTORIALToolStripMenuItem2
        '
        Me.VERHISTORIALToolStripMenuItem2.Name = "VERHISTORIALToolStripMenuItem2"
        Me.VERHISTORIALToolStripMenuItem2.Size = New System.Drawing.Size(352, 22)
        Me.VERHISTORIALToolStripMenuItem2.Text = "VER ESTADOS"
        '
        'ConMenu_Opciones1
        '
        Me.ConMenu_Opciones1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ConMenu_Opciones1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem1, Me.GRABARRECLAMOREPARTIDORToolStripMenuItem, Me.VERHISTORIALToolStripMenuItem, Me.ANULARPEDIDOToolStripMenuItem})
        Me.ConMenu_Opciones1.Name = "ConMenu_Opciones"
        Me.ConMenu_Opciones1.Size = New System.Drawing.Size(252, 108)
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Image = Global.Presentacion.My.Resources.Resources.ADICIONAR
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(251, 26)
        Me.ToolStripMenuItem1.Text = "GRABAR RECLAMO CLIENTE"
        '
        'GRABARRECLAMOREPARTIDORToolStripMenuItem
        '
        Me.GRABARRECLAMOREPARTIDORToolStripMenuItem.Image = Global.Presentacion.My.Resources.Resources.ADICIONAR
        Me.GRABARRECLAMOREPARTIDORToolStripMenuItem.Name = "GRABARRECLAMOREPARTIDORToolStripMenuItem"
        Me.GRABARRECLAMOREPARTIDORToolStripMenuItem.Size = New System.Drawing.Size(251, 26)
        Me.GRABARRECLAMOREPARTIDORToolStripMenuItem.Text = "GRABAR RECLAMO REPARTIDOR"
        '
        'VERHISTORIALToolStripMenuItem
        '
        Me.VERHISTORIALToolStripMenuItem.Name = "VERHISTORIALToolStripMenuItem"
        Me.VERHISTORIALToolStripMenuItem.Size = New System.Drawing.Size(251, 26)
        Me.VERHISTORIALToolStripMenuItem.Text = "VER ESTADOS"
        '
        'ANULARPEDIDOToolStripMenuItem
        '
        Me.ANULARPEDIDOToolStripMenuItem.Image = Global.Presentacion.My.Resources.Resources.I64x64_error
        Me.ANULARPEDIDOToolStripMenuItem.Name = "ANULARPEDIDOToolStripMenuItem"
        Me.ANULARPEDIDOToolStripMenuItem.Size = New System.Drawing.Size(251, 26)
        Me.ANULARPEDIDOToolStripMenuItem.Text = "ANULAR PEDIDO"
        '
        'PrintDialog1
        '
        Me.PrintDialog1.UseEXDialog = True
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 1000
        '
        'ConMenu_Rechazado
        '
        Me.ConMenu_Rechazado.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ConMenu_Rechazado.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem2})
        Me.ConMenu_Rechazado.Name = "ConMenu_Opciones"
        Me.ConMenu_Rechazado.Size = New System.Drawing.Size(249, 30)
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.Image = Global.Presentacion.My.Resources.Resources.ANTERIOR
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(248, 26)
        Me.ToolStripMenuItem2.Text = "RETORNAR A PEDIDO DICTADO "
        '
        'SuperGridControl1
        '
        Me.SuperGridControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SuperGridControl1.FilterExprColors.SysFunction = System.Drawing.Color.DarkRed
        Me.SuperGridControl1.Location = New System.Drawing.Point(0, 0)
        Me.SuperGridControl1.Name = "SuperGridControl1"
        Me.SuperGridControl1.Size = New System.Drawing.Size(42884, 11036)
        Me.SuperGridControl1.TabIndex = 8
        Me.SuperGridControl1.Text = "Eficiencia"
        '
        'PanelEx6
        '
        Me.PanelEx6.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.PanelEx6.CanvasColor = System.Drawing.SystemColors.Control
        Me.PanelEx6.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.PanelEx6.Controls.Add(Me.GroupPanelDatosGenerales)
        Me.PanelEx6.DisabledBackColor = System.Drawing.Color.Empty
        Me.PanelEx6.Location = New System.Drawing.Point(0, 0)
        Me.PanelEx6.Name = "PanelEx6"
        Me.PanelEx6.Size = New System.Drawing.Size(324, 11036)
        Me.PanelEx6.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.PanelEx6.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.PanelEx6.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.PanelEx6.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.PanelEx6.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.PanelEx6.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.PanelEx6.Style.GradientAngle = 90
        Me.PanelEx6.TabIndex = 116
        '
        'GroupPanelDatosGenerales
        '
        Me.GroupPanelDatosGenerales.CanvasColor = System.Drawing.SystemColors.Control
        Me.GroupPanelDatosGenerales.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.GroupPanelDatosGenerales.Controls.Add(Me.PanelExDatosGenerales)
        Me.GroupPanelDatosGenerales.DisabledBackColor = System.Drawing.Color.Empty
        Me.GroupPanelDatosGenerales.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupPanelDatosGenerales.Location = New System.Drawing.Point(0, 0)
        Me.GroupPanelDatosGenerales.Name = "GroupPanelDatosGenerales"
        Me.GroupPanelDatosGenerales.Size = New System.Drawing.Size(324, 11036)
        '
        '
        '
        Me.GroupPanelDatosGenerales.Style.BackColor = System.Drawing.SystemColors.Control
        Me.GroupPanelDatosGenerales.Style.BackColor2 = System.Drawing.SystemColors.Control
        Me.GroupPanelDatosGenerales.Style.BackColorGradientAngle = 90
        Me.GroupPanelDatosGenerales.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanelDatosGenerales.Style.BorderBottomWidth = 1
        Me.GroupPanelDatosGenerales.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.GroupPanelDatosGenerales.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanelDatosGenerales.Style.BorderLeftWidth = 1
        Me.GroupPanelDatosGenerales.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanelDatosGenerales.Style.BorderRightWidth = 1
        Me.GroupPanelDatosGenerales.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanelDatosGenerales.Style.BorderTopWidth = 1
        Me.GroupPanelDatosGenerales.Style.CornerDiameter = 4
        Me.GroupPanelDatosGenerales.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded
        Me.GroupPanelDatosGenerales.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center
        Me.GroupPanelDatosGenerales.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.GroupPanelDatosGenerales.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near
        '
        '
        '
        Me.GroupPanelDatosGenerales.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.GroupPanelDatosGenerales.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.GroupPanelDatosGenerales.TabIndex = 30
        Me.GroupPanelDatosGenerales.Text = "DATOS GENERALES"
        '
        'PanelExDatosGenerales
        '
        Me.PanelExDatosGenerales.AutoScroll = True
        Me.PanelExDatosGenerales.CanvasColor = System.Drawing.SystemColors.Control
        Me.PanelExDatosGenerales.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.PanelExDatosGenerales.Controls.Add(Me.GroupBox1)
        Me.PanelExDatosGenerales.DisabledBackColor = System.Drawing.Color.Empty
        Me.PanelExDatosGenerales.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelExDatosGenerales.Location = New System.Drawing.Point(0, 0)
        Me.PanelExDatosGenerales.Name = "PanelExDatosGenerales"
        Me.PanelExDatosGenerales.Size = New System.Drawing.Size(318, 11015)
        Me.PanelExDatosGenerales.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.PanelExDatosGenerales.Style.BackColor1.Color = System.Drawing.SystemColors.Control
        Me.PanelExDatosGenerales.Style.BackColor2.Color = System.Drawing.SystemColors.Control
        Me.PanelExDatosGenerales.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.PanelExDatosGenerales.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.PanelExDatosGenerales.Style.GradientAngle = 90
        Me.PanelExDatosGenerales.TabIndex = 0
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnGenerar)
        Me.GroupBox1.Controls.Add(Me.tbAño)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.cbMes)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(5, 3)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(310, 161)
        Me.GroupBox1.TabIndex = 113
        Me.GroupBox1.TabStop = False
        '
        'btnGenerar
        '
        Me.btnGenerar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnGenerar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnGenerar.Location = New System.Drawing.Point(116, 110)
        Me.btnGenerar.Name = "btnGenerar"
        Me.btnGenerar.Size = New System.Drawing.Size(75, 23)
        Me.btnGenerar.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnGenerar.TabIndex = 114
        Me.btnGenerar.Text = "GENERAR"
        '
        'tbAño
        '
        '
        '
        '
        Me.tbAño.Border.Class = "TextBoxBorder"
        Me.tbAño.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.tbAño.DisabledBackColor = System.Drawing.Color.White
        Me.tbAño.Location = New System.Drawing.Point(83, 67)
        Me.tbAño.Name = "tbAño"
        Me.tbAño.PreventEnterBeep = True
        Me.tbAño.Size = New System.Drawing.Size(150, 23)
        Me.tbAño.TabIndex = 6
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(26, 69)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(37, 17)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Año:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(26, 36)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(38, 17)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Mes:"
        '
        'cbMes
        '
        cbMes_DesignTimeLayout.LayoutString = resources.GetString("cbMes_DesignTimeLayout.LayoutString")
        Me.cbMes.DesignTimeLayout = cbMes_DesignTimeLayout
        Me.cbMes.Location = New System.Drawing.Point(82, 31)
        Me.cbMes.Name = "cbMes"
        Me.cbMes.SelectedIndex = -1
        Me.cbMes.SelectedItem = Nothing
        Me.cbMes.Size = New System.Drawing.Size(150, 23)
        Me.cbMes.TabIndex = 0
        '
        'grPresupuesto
        '
        Me.grPresupuesto.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grPresupuesto.FilterExprColors.SysFunction = System.Drawing.Color.DarkRed
        Me.grPresupuesto.Location = New System.Drawing.Point(327, 0)
        Me.grPresupuesto.Name = "grPresupuesto"
        Me.grPresupuesto.Size = New System.Drawing.Size(42557, 11036)
        Me.grPresupuesto.TabIndex = 120
        Me.grPresupuesto.Text = "SuperGridControl2"
        '
        'SuperTabItem5
        '
        Me.SuperTabItem5.AttachedControl = Me.SuperTabControlPanel5
        Me.SuperTabItem5.GlobalItem = False
        Me.SuperTabItem5.Name = "SuperTabItem5"
        Me.SuperTabItem5.Text = "CLIENTES"
        '
        'SuperTabControlPanel5
        '
        Me.SuperTabControlPanel5.Controls.Add(Me.PanelEx9)
        Me.SuperTabControlPanel5.Controls.Add(Me.PanelEx10)
        Me.SuperTabControlPanel5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SuperTabControlPanel5.Location = New System.Drawing.Point(0, 25)
        Me.SuperTabControlPanel5.Name = "SuperTabControlPanel5"
        Me.SuperTabControlPanel5.Size = New System.Drawing.Size(1284, 636)
        Me.SuperTabControlPanel5.TabIndex = 2
        Me.SuperTabControlPanel5.TabItem = Me.SuperTabItem5
        '
        'PanelEx9
        '
        Me.PanelEx9.CanvasColor = System.Drawing.SystemColors.Control
        Me.PanelEx9.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.PanelEx9.Controls.Add(Me.GroupPanel2)
        Me.PanelEx9.DisabledBackColor = System.Drawing.Color.Empty
        Me.PanelEx9.Dock = System.Windows.Forms.DockStyle.Left
        Me.PanelEx9.Location = New System.Drawing.Point(0, 0)
        Me.PanelEx9.Name = "PanelEx9"
        Me.PanelEx9.Size = New System.Drawing.Size(320, 636)
        Me.PanelEx9.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.PanelEx9.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.PanelEx9.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.PanelEx9.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.PanelEx9.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.PanelEx9.Style.GradientAngle = 90
        Me.PanelEx9.TabIndex = 12
        '
        'GroupPanel2
        '
        Me.GroupPanel2.BackColor = System.Drawing.Color.Transparent
        Me.GroupPanel2.CanvasColor = System.Drawing.SystemColors.Control
        Me.GroupPanel2.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.GroupPanel2.Controls.Add(Me.tbtop2)
        Me.GroupPanel2.Controls.Add(Me.Label8)
        Me.GroupPanel2.Controls.Add(Me.Label9)
        Me.GroupPanel2.Controls.Add(Me.Label10)
        Me.GroupPanel2.Controls.Add(Me.tbFechaF2)
        Me.GroupPanel2.Controls.Add(Me.tbFechaI2)
        Me.GroupPanel2.Controls.Add(Me.CheckBoxX1)
        Me.GroupPanel2.Controls.Add(Me.CheckBoxX2)
        Me.GroupPanel2.Controls.Add(Me.CheckBoxX3)
        Me.GroupPanel2.Controls.Add(Me.ButtonX2)
        Me.GroupPanel2.DisabledBackColor = System.Drawing.Color.Empty
        Me.GroupPanel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupPanel2.Location = New System.Drawing.Point(0, 0)
        Me.GroupPanel2.Name = "GroupPanel2"
        Me.GroupPanel2.Size = New System.Drawing.Size(320, 636)
        '
        '
        '
        Me.GroupPanel2.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.GroupPanel2.Style.BackColorGradientAngle = 90
        Me.GroupPanel2.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.GroupPanel2.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel2.Style.BorderBottomWidth = 1
        Me.GroupPanel2.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.GroupPanel2.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel2.Style.BorderLeftWidth = 1
        Me.GroupPanel2.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel2.Style.BorderRightWidth = 1
        Me.GroupPanel2.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel2.Style.BorderTopWidth = 1
        Me.GroupPanel2.Style.CornerDiameter = 4
        Me.GroupPanel2.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded
        Me.GroupPanel2.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center
        Me.GroupPanel2.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.GroupPanel2.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near
        '
        '
        '
        Me.GroupPanel2.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.GroupPanel2.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.GroupPanel2.TabIndex = 110
        Me.GroupPanel2.Text = "DATOS"
        '
        'tbtop2
        '
        '
        '
        '
        Me.tbtop2.BackgroundStyle.Class = "DateTimeInputBackground"
        Me.tbtop2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.tbtop2.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2
        Me.tbtop2.Location = New System.Drawing.Point(119, 135)
        Me.tbtop2.MaxValue = 40
        Me.tbtop2.Name = "tbtop2"
        Me.tbtop2.ShowUpDown = True
        Me.tbtop2.Size = New System.Drawing.Size(144, 20)
        Me.tbtop2.TabIndex = 124
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label8.ForeColor = System.Drawing.Color.DarkBlue
        Me.Label8.Location = New System.Drawing.Point(37, 142)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(36, 13)
        Me.Label8.TabIndex = 123
        Me.Label8.Text = "TOP:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label9.ForeColor = System.Drawing.Color.DarkBlue
        Me.Label9.Location = New System.Drawing.Point(42, 87)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(26, 13)
        Me.Label9.TabIndex = 122
        Me.Label9.Text = "AL:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label10.ForeColor = System.Drawing.Color.DarkBlue
        Me.Label10.Location = New System.Drawing.Point(37, 50)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(35, 13)
        Me.Label10.TabIndex = 121
        Me.Label10.Text = "DEL:"
        '
        'tbFechaF2
        '
        '
        '
        '
        Me.tbFechaF2.BackgroundStyle.Class = "DateTimeInputBackground"
        Me.tbFechaF2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.tbFechaF2.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown
        Me.tbFechaF2.ButtonDropDown.Visible = True
        Me.tbFechaF2.IsPopupCalendarOpen = False
        Me.tbFechaF2.Location = New System.Drawing.Point(119, 80)
        '
        '
        '
        '
        '
        '
        Me.tbFechaF2.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.tbFechaF2.MonthCalendar.CalendarDimensions = New System.Drawing.Size(1, 1)
        Me.tbFechaF2.MonthCalendar.ClearButtonVisible = True
        '
        '
        '
        Me.tbFechaF2.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2
        Me.tbFechaF2.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90
        Me.tbFechaF2.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground
        Me.tbFechaF2.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.tbFechaF2.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder
        Me.tbFechaF2.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1
        Me.tbFechaF2.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.tbFechaF2.MonthCalendar.DisplayMonth = New Date(2024, 1, 1, 0, 0, 0, 0)
        Me.tbFechaF2.MonthCalendar.FirstDayOfWeek = System.DayOfWeek.Monday
        '
        '
        '
        Me.tbFechaF2.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.tbFechaF2.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90
        Me.tbFechaF2.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.tbFechaF2.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.tbFechaF2.MonthCalendar.TodayButtonVisible = True
        Me.tbFechaF2.Name = "tbFechaF2"
        Me.tbFechaF2.Size = New System.Drawing.Size(144, 20)
        Me.tbFechaF2.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.tbFechaF2.TabIndex = 120
        '
        'tbFechaI2
        '
        '
        '
        '
        Me.tbFechaI2.BackgroundStyle.Class = "DateTimeInputBackground"
        Me.tbFechaI2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.tbFechaI2.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown
        Me.tbFechaI2.ButtonDropDown.Visible = True
        Me.tbFechaI2.IsPopupCalendarOpen = False
        Me.tbFechaI2.Location = New System.Drawing.Point(119, 44)
        '
        '
        '
        '
        '
        '
        Me.tbFechaI2.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.tbFechaI2.MonthCalendar.CalendarDimensions = New System.Drawing.Size(1, 1)
        Me.tbFechaI2.MonthCalendar.ClearButtonVisible = True
        '
        '
        '
        Me.tbFechaI2.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2
        Me.tbFechaI2.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90
        Me.tbFechaI2.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground
        Me.tbFechaI2.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.tbFechaI2.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder
        Me.tbFechaI2.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1
        Me.tbFechaI2.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.tbFechaI2.MonthCalendar.DisplayMonth = New Date(2024, 1, 1, 0, 0, 0, 0)
        Me.tbFechaI2.MonthCalendar.FirstDayOfWeek = System.DayOfWeek.Monday
        '
        '
        '
        Me.tbFechaI2.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.tbFechaI2.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90
        Me.tbFechaI2.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.tbFechaI2.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.tbFechaI2.MonthCalendar.TodayButtonVisible = True
        Me.tbFechaI2.Name = "tbFechaI2"
        Me.tbFechaI2.Size = New System.Drawing.Size(144, 20)
        Me.tbFechaI2.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.tbFechaI2.TabIndex = 119
        '
        'CheckBoxX1
        '
        '
        '
        '
        Me.CheckBoxX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.CheckBoxX1.CheckBoxStyle = DevComponents.DotNetBar.eCheckBoxStyle.RadioButton
        Me.CheckBoxX1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBoxX1.Location = New System.Drawing.Point(45, 442)
        Me.CheckBoxX1.Name = "CheckBoxX1"
        Me.CheckBoxX1.Size = New System.Drawing.Size(236, 23)
        Me.CheckBoxX1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.CheckBoxX1.TabIndex = 118
        Me.CheckBoxX1.Text = "PRODUCTO MAS VENDIDO (UNIDADES)"
        Me.CheckBoxX1.TextColor = System.Drawing.Color.DarkBlue
        Me.CheckBoxX1.Visible = False
        '
        'CheckBoxX2
        '
        '
        '
        '
        Me.CheckBoxX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.CheckBoxX2.CheckBoxStyle = DevComponents.DotNetBar.eCheckBoxStyle.RadioButton
        Me.CheckBoxX2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBoxX2.Location = New System.Drawing.Point(45, 401)
        Me.CheckBoxX2.Name = "CheckBoxX2"
        Me.CheckBoxX2.Size = New System.Drawing.Size(228, 23)
        Me.CheckBoxX2.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.CheckBoxX2.TabIndex = 117
        Me.CheckBoxX2.Text = "PRODUCTO CON MAYOR UTILIDAD"
        Me.CheckBoxX2.TextColor = System.Drawing.Color.DarkBlue
        Me.CheckBoxX2.Visible = False
        '
        'CheckBoxX3
        '
        '
        '
        '
        Me.CheckBoxX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.CheckBoxX3.CheckBoxStyle = DevComponents.DotNetBar.eCheckBoxStyle.RadioButton
        Me.CheckBoxX3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBoxX3.Location = New System.Drawing.Point(45, 362)
        Me.CheckBoxX3.Name = "CheckBoxX3"
        Me.CheckBoxX3.Size = New System.Drawing.Size(218, 23)
        Me.CheckBoxX3.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.CheckBoxX3.TabIndex = 116
        Me.CheckBoxX3.Text = "PRODUCTO MAS VENDIDO (BS)"
        Me.CheckBoxX3.TextColor = System.Drawing.Color.DarkBlue
        Me.CheckBoxX3.Visible = False
        '
        'ButtonX2
        '
        Me.ButtonX2.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.ButtonX2.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.ButtonX2.Location = New System.Drawing.Point(106, 189)
        Me.ButtonX2.Name = "ButtonX2"
        Me.ButtonX2.Size = New System.Drawing.Size(75, 23)
        Me.ButtonX2.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.ButtonX2.TabIndex = 115
        Me.ButtonX2.Text = "GENERAR"
        '
        'PanelEx10
        '
        Me.PanelEx10.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PanelEx10.CanvasColor = System.Drawing.SystemColors.Control
        Me.PanelEx10.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.PanelEx10.Controls.Add(Me.RClientes)
        Me.PanelEx10.Controls.Add(Me.SuperGridControl3)
        Me.PanelEx10.DisabledBackColor = System.Drawing.Color.Empty
        Me.PanelEx10.Location = New System.Drawing.Point(323, 2)
        Me.PanelEx10.Name = "PanelEx10"
        Me.PanelEx10.Size = New System.Drawing.Size(958, 633)
        Me.PanelEx10.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.PanelEx10.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.PanelEx10.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.PanelEx10.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.PanelEx10.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.PanelEx10.Style.GradientAngle = 90
        Me.PanelEx10.TabIndex = 16
        '
        'RClientes
        '
        Me.RClientes.ActiveViewIndex = -1
        Me.RClientes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.RClientes.Cursor = System.Windows.Forms.Cursors.Default
        Me.RClientes.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RClientes.Location = New System.Drawing.Point(0, 0)
        Me.RClientes.Name = "RClientes"
        Me.RClientes.Size = New System.Drawing.Size(958, 633)
        Me.RClientes.TabIndex = 1
        Me.RClientes.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
        '
        'SuperGridControl3
        '
        Me.SuperGridControl3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SuperGridControl3.FilterExprColors.SysFunction = System.Drawing.Color.DarkRed
        Me.SuperGridControl3.Location = New System.Drawing.Point(0, 0)
        Me.SuperGridControl3.Name = "SuperGridControl3"
        Me.SuperGridControl3.Size = New System.Drawing.Size(958, 633)
        Me.SuperGridControl3.TabIndex = 0
        Me.SuperGridControl3.Text = "SuperGridControl3"
        '
        'SuperTabItem6
        '
        Me.SuperTabItem6.AttachedControl = Me.SuperTabControlPanel6
        Me.SuperTabItem6.GlobalItem = False
        Me.SuperTabItem6.Name = "SuperTabItem6"
        Me.SuperTabItem6.Text = "VENDEDORES"
        '
        'SuperTabControlPanel6
        '
        Me.SuperTabControlPanel6.Controls.Add(Me.PanelEx11)
        Me.SuperTabControlPanel6.Controls.Add(Me.PanelEx13)
        Me.SuperTabControlPanel6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SuperTabControlPanel6.Location = New System.Drawing.Point(0, 25)
        Me.SuperTabControlPanel6.Name = "SuperTabControlPanel6"
        Me.SuperTabControlPanel6.Size = New System.Drawing.Size(1284, 636)
        Me.SuperTabControlPanel6.TabIndex = 3
        Me.SuperTabControlPanel6.TabItem = Me.SuperTabItem6
        '
        'PanelEx11
        '
        Me.PanelEx11.CanvasColor = System.Drawing.SystemColors.Control
        Me.PanelEx11.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.PanelEx11.Controls.Add(Me.GroupPanel3)
        Me.PanelEx11.DisabledBackColor = System.Drawing.Color.Empty
        Me.PanelEx11.Dock = System.Windows.Forms.DockStyle.Left
        Me.PanelEx11.Location = New System.Drawing.Point(0, 0)
        Me.PanelEx11.Name = "PanelEx11"
        Me.PanelEx11.Size = New System.Drawing.Size(320, 636)
        Me.PanelEx11.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.PanelEx11.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.PanelEx11.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.PanelEx11.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.PanelEx11.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.PanelEx11.Style.GradientAngle = 90
        Me.PanelEx11.TabIndex = 12
        '
        'GroupPanel3
        '
        Me.GroupPanel3.BackColor = System.Drawing.Color.Transparent
        Me.GroupPanel3.CanvasColor = System.Drawing.SystemColors.Control
        Me.GroupPanel3.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.GroupPanel3.Controls.Add(Me.ButtonX4)
        Me.GroupPanel3.Controls.Add(Me.tbTop3)
        Me.GroupPanel3.Controls.Add(Me.Label11)
        Me.GroupPanel3.Controls.Add(Me.Label12)
        Me.GroupPanel3.Controls.Add(Me.Label13)
        Me.GroupPanel3.Controls.Add(Me.tbFechaF3)
        Me.GroupPanel3.Controls.Add(Me.tbFechaI3)
        Me.GroupPanel3.Controls.Add(Me.cbVendedorUtilidad)
        Me.GroupPanel3.Controls.Add(Me.cbVendedorMas)
        Me.GroupPanel3.DisabledBackColor = System.Drawing.Color.Empty
        Me.GroupPanel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupPanel3.Location = New System.Drawing.Point(0, 0)
        Me.GroupPanel3.Name = "GroupPanel3"
        Me.GroupPanel3.Size = New System.Drawing.Size(320, 636)
        '
        '
        '
        Me.GroupPanel3.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.GroupPanel3.Style.BackColorGradientAngle = 90
        Me.GroupPanel3.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.GroupPanel3.Style.BorderBottomWidth = 1
        Me.GroupPanel3.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.GroupPanel3.Style.BorderLeftWidth = 1
        Me.GroupPanel3.Style.BorderRightWidth = 1
        Me.GroupPanel3.Style.BorderTopWidth = 1
        Me.GroupPanel3.Style.CornerDiameter = 4
        Me.GroupPanel3.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded
        Me.GroupPanel3.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center
        Me.GroupPanel3.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.GroupPanel3.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near
        '
        '
        '
        Me.GroupPanel3.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.GroupPanel3.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.GroupPanel3.TabIndex = 110
        Me.GroupPanel3.Text = "DATOS"
        '
        'ButtonX4
        '
        Me.ButtonX4.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.ButtonX4.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.ButtonX4.Location = New System.Drawing.Point(117, 299)
        Me.ButtonX4.Name = "ButtonX4"
        Me.ButtonX4.Size = New System.Drawing.Size(75, 23)
        Me.ButtonX4.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.ButtonX4.TabIndex = 125
        Me.ButtonX4.Text = "GENERAR"
        '
        'tbTop3
        '
        '
        '
        '
        Me.tbTop3.BackgroundStyle.Class = "DateTimeInputBackground"
        Me.tbTop3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.tbTop3.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2
        Me.tbTop3.Location = New System.Drawing.Point(117, 236)
        Me.tbTop3.MaxValue = 40
        Me.tbTop3.Name = "tbTop3"
        Me.tbTop3.ShowUpDown = True
        Me.tbTop3.Size = New System.Drawing.Size(144, 20)
        Me.tbTop3.TabIndex = 124
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label11.ForeColor = System.Drawing.Color.DarkBlue
        Me.Label11.Location = New System.Drawing.Point(35, 243)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(36, 13)
        Me.Label11.TabIndex = 123
        Me.Label11.Text = "TOP:"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label12.ForeColor = System.Drawing.Color.DarkBlue
        Me.Label12.Location = New System.Drawing.Point(35, 188)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(26, 13)
        Me.Label12.TabIndex = 122
        Me.Label12.Text = "AL:"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label13.ForeColor = System.Drawing.Color.DarkBlue
        Me.Label13.Location = New System.Drawing.Point(35, 151)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(35, 13)
        Me.Label13.TabIndex = 121
        Me.Label13.Text = "DEL:"
        '
        'tbFechaF3
        '
        '
        '
        '
        Me.tbFechaF3.BackgroundStyle.Class = "DateTimeInputBackground"
        Me.tbFechaF3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.tbFechaF3.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown
        Me.tbFechaF3.ButtonDropDown.Visible = True
        Me.tbFechaF3.IsPopupCalendarOpen = False
        Me.tbFechaF3.Location = New System.Drawing.Point(117, 181)
        '
        '
        '
        '
        '
        '
        Me.tbFechaF3.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.tbFechaF3.MonthCalendar.CalendarDimensions = New System.Drawing.Size(1, 1)
        Me.tbFechaF3.MonthCalendar.ClearButtonVisible = True
        '
        '
        '
        Me.tbFechaF3.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2
        Me.tbFechaF3.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90
        Me.tbFechaF3.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground
        Me.tbFechaF3.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.tbFechaF3.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder
        Me.tbFechaF3.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1
        Me.tbFechaF3.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.tbFechaF3.MonthCalendar.DisplayMonth = New Date(2024, 1, 1, 0, 0, 0, 0)
        Me.tbFechaF3.MonthCalendar.FirstDayOfWeek = System.DayOfWeek.Monday
        '
        '
        '
        Me.tbFechaF3.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.tbFechaF3.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90
        Me.tbFechaF3.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.tbFechaF3.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.tbFechaF3.MonthCalendar.TodayButtonVisible = True
        Me.tbFechaF3.Name = "tbFechaF3"
        Me.tbFechaF3.Size = New System.Drawing.Size(144, 20)
        Me.tbFechaF3.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.tbFechaF3.TabIndex = 120
        '
        'tbFechaI3
        '
        '
        '
        '
        Me.tbFechaI3.BackgroundStyle.Class = "DateTimeInputBackground"
        Me.tbFechaI3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.tbFechaI3.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown
        Me.tbFechaI3.ButtonDropDown.Visible = True
        Me.tbFechaI3.IsPopupCalendarOpen = False
        Me.tbFechaI3.Location = New System.Drawing.Point(117, 145)
        '
        '
        '
        '
        '
        '
        Me.tbFechaI3.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.tbFechaI3.MonthCalendar.CalendarDimensions = New System.Drawing.Size(1, 1)
        Me.tbFechaI3.MonthCalendar.ClearButtonVisible = True
        '
        '
        '
        Me.tbFechaI3.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2
        Me.tbFechaI3.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90
        Me.tbFechaI3.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground
        Me.tbFechaI3.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.tbFechaI3.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder
        Me.tbFechaI3.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1
        Me.tbFechaI3.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.tbFechaI3.MonthCalendar.DisplayMonth = New Date(2024, 1, 1, 0, 0, 0, 0)
        Me.tbFechaI3.MonthCalendar.FirstDayOfWeek = System.DayOfWeek.Monday
        '
        '
        '
        Me.tbFechaI3.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.tbFechaI3.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90
        Me.tbFechaI3.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.tbFechaI3.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.tbFechaI3.MonthCalendar.TodayButtonVisible = True
        Me.tbFechaI3.Name = "tbFechaI3"
        Me.tbFechaI3.Size = New System.Drawing.Size(144, 20)
        Me.tbFechaI3.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.tbFechaI3.TabIndex = 119
        '
        'cbVendedorUtilidad
        '
        '
        '
        '
        Me.cbVendedorUtilidad.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.cbVendedorUtilidad.CheckBoxStyle = DevComponents.DotNetBar.eCheckBoxStyle.RadioButton
        Me.cbVendedorUtilidad.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbVendedorUtilidad.Location = New System.Drawing.Point(27, 79)
        Me.cbVendedorUtilidad.Name = "cbVendedorUtilidad"
        Me.cbVendedorUtilidad.Size = New System.Drawing.Size(274, 23)
        Me.cbVendedorUtilidad.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.cbVendedorUtilidad.TabIndex = 117
        Me.cbVendedorUtilidad.Text = "VENDEDOR QUE GENERA MAYOR UTILIDAD"
        Me.cbVendedorUtilidad.TextColor = System.Drawing.Color.DarkBlue
        '
        'cbVendedorMas
        '
        '
        '
        '
        Me.cbVendedorMas.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.cbVendedorMas.CheckBoxStyle = DevComponents.DotNetBar.eCheckBoxStyle.RadioButton
        Me.cbVendedorMas.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbVendedorMas.Location = New System.Drawing.Point(27, 40)
        Me.cbVendedorMas.Name = "cbVendedorMas"
        Me.cbVendedorMas.Size = New System.Drawing.Size(274, 23)
        Me.cbVendedorMas.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.cbVendedorMas.TabIndex = 116
        Me.cbVendedorMas.Text = "VENDEDOR QUE GENERA MAS VENTAS (BS)"
        Me.cbVendedorMas.TextColor = System.Drawing.Color.DarkBlue
        '
        'PanelEx13
        '
        Me.PanelEx13.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PanelEx13.CanvasColor = System.Drawing.SystemColors.Control
        Me.PanelEx13.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.PanelEx13.Controls.Add(Me.CRVendedores)
        Me.PanelEx13.Controls.Add(Me.SuperGridControl4)
        Me.PanelEx13.DisabledBackColor = System.Drawing.Color.Empty
        Me.PanelEx13.Location = New System.Drawing.Point(323, 2)
        Me.PanelEx13.Name = "PanelEx13"
        Me.PanelEx13.Size = New System.Drawing.Size(958, 633)
        Me.PanelEx13.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.PanelEx13.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.PanelEx13.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.PanelEx13.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.PanelEx13.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.PanelEx13.Style.GradientAngle = 90
        Me.PanelEx13.TabIndex = 16
        '
        'CRVendedores
        '
        Me.CRVendedores.ActiveViewIndex = -1
        Me.CRVendedores.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CRVendedores.Cursor = System.Windows.Forms.Cursors.Default
        Me.CRVendedores.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CRVendedores.Location = New System.Drawing.Point(0, 0)
        Me.CRVendedores.Name = "CRVendedores"
        Me.CRVendedores.Size = New System.Drawing.Size(958, 633)
        Me.CRVendedores.TabIndex = 1
        Me.CRVendedores.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
        '
        'SuperGridControl4
        '
        Me.SuperGridControl4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SuperGridControl4.FilterExprColors.SysFunction = System.Drawing.Color.DarkRed
        Me.SuperGridControl4.Location = New System.Drawing.Point(0, 0)
        Me.SuperGridControl4.Name = "SuperGridControl4"
        Me.SuperGridControl4.Size = New System.Drawing.Size(958, 633)
        Me.SuperGridControl4.TabIndex = 0
        Me.SuperGridControl4.Text = "SuperGridControl4"
        '
        'DsReportesBindingSource
        '
        Me.DsReportesBindingSource.DataSource = Me.DsReportes
        Me.DsReportesBindingSource.Position = 0
        '
        'DsReportes
        '
        Me.DsReportes.DataSetName = "dsReporteEquipoPrestadoVsVenta"
        Me.DsReportes.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Dashboard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(1284, 661)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Dashboard"
        Me.Opacity = 0.05R
        Me.WindowState = System.Windows.Forms.FormWindowState.Minimized
        Me.Controls.SetChildIndex(Me.SuperTabControl1, 0)
        CType(Me.SuperTabControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SuperTabControl1.ResumeLayout(False)
        Me.SuperTabControlPanel2.ResumeLayout(False)
        Me.SuperTabControlPanel1.ResumeLayout(False)
        Me.PanelEx1.ResumeLayout(False)
        CType(Me.BubbleBar1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BubbleBar2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelEx2.ResumeLayout(False)
        Me.PanelEx2.PerformLayout()
        CType(Me.BubbleBar4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BubbleBar3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BubbleBar5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelEx5.ResumeLayout(False)
        Me.PanelEx5.PerformLayout()
        Me.ConMenu_Opciones2.ResumeLayout(False)
        Me.SuperTabControlPanel3.ResumeLayout(False)
        Me.PanelEx12.ResumeLayout(False)
        Me.PanelEx14.ResumeLayout(False)
        Me.PanelEx7.ResumeLayout(False)
        Me.GroupPanel1.ResumeLayout(False)
        Me.PanelEx8.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.tbFechaF, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tbFechaI, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ConMenu_Imprimir.ResumeLayout(False)
        Me.SuperTabControlPanel4.ResumeLayout(False)
        Me.PanelEx18.ResumeLayout(False)
        Me.GroupPanel5.ResumeLayout(False)
        Me.GroupPanel5.PerformLayout()
        CType(Me.tbtop, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tbFechaFin, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tbFechaIni, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelEx20.ResumeLayout(False)
        Me.ConMenu_Opciones3.ResumeLayout(False)
        Me.ConMenu_Opciones1.ResumeLayout(False)
        Me.ConMenu_Rechazado.ResumeLayout(False)
        Me.PanelEx6.ResumeLayout(False)
        Me.GroupPanelDatosGenerales.ResumeLayout(False)
        Me.PanelExDatosGenerales.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.cbMes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SuperTabControlPanel5.ResumeLayout(False)
        Me.PanelEx9.ResumeLayout(False)
        Me.GroupPanel2.ResumeLayout(False)
        Me.GroupPanel2.PerformLayout()
        CType(Me.tbtop2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tbFechaF2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tbFechaI2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelEx10.ResumeLayout(False)
        Me.SuperTabControlPanel6.ResumeLayout(False)
        Me.PanelEx11.ResumeLayout(False)
        Me.GroupPanel3.ResumeLayout(False)
        Me.GroupPanel3.PerformLayout()
        CType(Me.tbTop3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tbFechaF3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tbFechaI3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelEx13.ResumeLayout(False)
        CType(Me.DsReportesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsReportes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ConMenu_Opciones2 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents AñadirObsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SuperTabControlPanel3 As DevComponents.DotNetBar.SuperTabControlPanel
    Friend WithEvents PanelEx12 As DevComponents.DotNetBar.PanelEx
    Friend WithEvents PanelEx14 As DevComponents.DotNetBar.PanelEx
    Friend WithEvents SuperTabItem3 As DevComponents.DotNetBar.SuperTabItem
    Friend WithEvents SuperTabControlPanel4 As DevComponents.DotNetBar.SuperTabControlPanel
    Friend WithEvents SuperTabItem4 As DevComponents.DotNetBar.SuperTabItem
    Friend WithEvents PanelEx18 As DevComponents.DotNetBar.PanelEx
    Friend WithEvents GroupPanel5 As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents ConMenu_Opciones3 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents RETORNARPEDIDOACONFIRMACIONDEENTREGAToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ConMenu_Opciones1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GRABARRECLAMOToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GRABARRECLAMOToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GRABARRECLAMOREPARTIDORToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GRABARRECLAMOREPARTIDORToolStripMenuItem2 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GRABARRECLAMOREPARTIDORToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ANULARPEDIDOToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ANULARPEDIDOToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents VERHISTORIALToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents VERHISTORIALToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents VERHISTORIALToolStripMenuItem2 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ConMenu_Imprimir As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents ToolStripMenuItem_ImprimirFiltrado As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents IMPRIMIRPEDIDOToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PrintDialog1 As System.Windows.Forms.PrintDialog
    Friend WithEvents Timer1 As Timer
    Friend WithEvents ConMenu_Rechazado As ContextMenuStrip
    Friend WithEvents ToolStripMenuItem2 As ToolStripMenuItem
    Friend WithEvents SuperGridControl1 As DevComponents.DotNetBar.SuperGrid.SuperGridControl
    Friend WithEvents grPresupuesto As DevComponents.DotNetBar.SuperGrid.SuperGridControl
    Friend WithEvents PanelEx6 As DevComponents.DotNetBar.PanelEx
    Friend WithEvents GroupPanelDatosGenerales As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents PanelExDatosGenerales As DevComponents.DotNetBar.PanelEx
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents tbAño As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents cbMes As Janus.Windows.GridEX.EditControls.MultiColumnCombo
    Friend WithEvents btnGenerar As DevComponents.DotNetBar.ButtonX
    Friend WithEvents PanelEx7 As DevComponents.DotNetBar.PanelEx
    Friend WithEvents GroupPanel1 As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents PanelEx8 As DevComponents.DotNetBar.PanelEx
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents btGenerar2 As DevComponents.DotNetBar.ButtonX
    Friend WithEvents grKPI2 As DevComponents.DotNetBar.SuperGrid.SuperGridControl
    Friend WithEvents tbFechaF As DevComponents.Editors.DateTimeAdv.DateTimeInput
    Friend WithEvents tbFechaI As DevComponents.Editors.DateTimeAdv.DateTimeInput
    Friend WithEvents Label2 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents PanelEx20 As DevComponents.DotNetBar.PanelEx
    Friend WithEvents DsReportesBindingSource As BindingSource
    Friend WithEvents DsReportes As dsReportes
    Friend WithEvents SuperGridControl2 As DevComponents.DotNetBar.SuperGrid.SuperGridControl
    Friend WithEvents ProductosMas As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents tbFechaFin As DevComponents.Editors.DateTimeAdv.DateTimeInput
    Friend WithEvents tbFechaIni As DevComponents.Editors.DateTimeAdv.DateTimeInput
    Friend WithEvents cbProducto3 As DevComponents.DotNetBar.Controls.CheckBoxX
    Friend WithEvents cbProducto2 As DevComponents.DotNetBar.Controls.CheckBoxX
    Friend WithEvents cbProducto1 As DevComponents.DotNetBar.Controls.CheckBoxX
    Friend WithEvents tbtop As DevComponents.Editors.IntegerInput
    Friend WithEvents SuperTabControlPanel5 As DevComponents.DotNetBar.SuperTabControlPanel
    Friend WithEvents PanelEx9 As DevComponents.DotNetBar.PanelEx
    Friend WithEvents GroupPanel2 As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents tbtop2 As DevComponents.Editors.IntegerInput
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents tbFechaF2 As DevComponents.Editors.DateTimeAdv.DateTimeInput
    Friend WithEvents tbFechaI2 As DevComponents.Editors.DateTimeAdv.DateTimeInput
    Friend WithEvents CheckBoxX1 As DevComponents.DotNetBar.Controls.CheckBoxX
    Friend WithEvents CheckBoxX2 As DevComponents.DotNetBar.Controls.CheckBoxX
    Friend WithEvents CheckBoxX3 As DevComponents.DotNetBar.Controls.CheckBoxX
    Friend WithEvents ButtonX2 As DevComponents.DotNetBar.ButtonX
    Friend WithEvents PanelEx10 As DevComponents.DotNetBar.PanelEx
    Friend WithEvents RClientes As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents SuperGridControl3 As DevComponents.DotNetBar.SuperGrid.SuperGridControl
    Friend WithEvents SuperTabItem5 As DevComponents.DotNetBar.SuperTabItem
    Friend WithEvents ButtonX3 As DevComponents.DotNetBar.ButtonX
    Friend WithEvents ButtonX1 As DevComponents.DotNetBar.ButtonX
    Friend WithEvents SuperTabControlPanel6 As DevComponents.DotNetBar.SuperTabControlPanel
    Friend WithEvents PanelEx11 As DevComponents.DotNetBar.PanelEx
    Friend WithEvents GroupPanel3 As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents ButtonX4 As DevComponents.DotNetBar.ButtonX
    Friend WithEvents tbTop3 As DevComponents.Editors.IntegerInput
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents tbFechaF3 As DevComponents.Editors.DateTimeAdv.DateTimeInput
    Friend WithEvents tbFechaI3 As DevComponents.Editors.DateTimeAdv.DateTimeInput
    Friend WithEvents cbVendedorUtilidad As DevComponents.DotNetBar.Controls.CheckBoxX
    Friend WithEvents cbVendedorMas As DevComponents.DotNetBar.Controls.CheckBoxX
    Friend WithEvents PanelEx13 As DevComponents.DotNetBar.PanelEx
    Friend WithEvents CRVendedores As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents SuperGridControl4 As DevComponents.DotNetBar.SuperGrid.SuperGridControl
    Friend WithEvents SuperTabItem6 As DevComponents.DotNetBar.SuperTabItem
    Friend WithEvents cbFecha As DevComponents.DotNetBar.Controls.CheckBoxX
    Friend WithEvents cbConci As DevComponents.DotNetBar.Controls.CheckBoxX
End Class
