<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class F02_ComisionesCategoria
    Inherits Modelo.ModeloF01_ca

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
        Dim JCb_CatProducto_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(F02_ComisionesCategoria))
        Me.GridEXPrintDocumentListaPrecios = New Janus.Windows.GridEX.GridEXPrintDocument()
        Me.JGr_Detalle = New Janus.Windows.GridEX.GridEX()
        Me.GridEXExporterListaPrecio = New Janus.Windows.GridEX.Export.GridEXExporter(Me.components)
        Me.btExportarExcel = New DevComponents.DotNetBar.ButtonX()
        Me.CmDetalle = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.QuitarProductoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.GpDatosGenerales = New DevComponents.DotNetBar.Controls.GroupPanel()
        Me.PnDatosGenerales = New DevComponents.DotNetBar.PanelEx()
        Me.LabelX1 = New DevComponents.DotNetBar.LabelX()
        Me.JCb_CatProducto = New Janus.Windows.GridEX.EditControls.MultiColumnCombo()
        Me.GpListaPrecio = New DevComponents.DotNetBar.Controls.GroupPanel()
        Me.PnListaPrecio = New DevComponents.DotNetBar.PanelEx()
        Me.TableLayoutPanelPrincipal = New System.Windows.Forms.TableLayoutPanel()
        CType(Me.MSuperTabControlPrincipal, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MSuperTabControlPrincipal.SuspendLayout()
        Me.MSuperTabControlPanelRegistro.SuspendLayout()
        Me.MPnSuperior.SuspendLayout()
        Me.MPnInferior.SuspendLayout()
        Me.MPanelToolBarUsuario.SuspendLayout()
        Me.MPanelToolBarNavegacion.SuspendLayout()
        Me.MPanelToolBarAccion.SuspendLayout()
        Me.MPanelToolBarImprimir.SuspendLayout()
        CType(Me.MBubbleBarUsuario, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MPnUsuario.SuspendLayout()
        CType(Me.MEP, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.JGr_Detalle, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.CmDetalle.SuspendLayout()
        Me.GpDatosGenerales.SuspendLayout()
        Me.PnDatosGenerales.SuspendLayout()
        CType(Me.JCb_CatProducto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GpListaPrecio.SuspendLayout()
        Me.PnListaPrecio.SuspendLayout()
        Me.SuspendLayout()
        '
        'MSuperTabControlPrincipal
        '
        '
        '
        '
        '
        '
        '
        Me.MSuperTabControlPrincipal.ControlBox.CloseBox.Name = ""
        '
        '
        '
        Me.MSuperTabControlPrincipal.ControlBox.MenuBox.Name = ""
        Me.MSuperTabControlPrincipal.ControlBox.Name = ""
        Me.MSuperTabControlPrincipal.ControlBox.SubItems.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.MSuperTabControlPrincipal.ControlBox.MenuBox, Me.MSuperTabControlPrincipal.ControlBox.CloseBox})
        Me.MSuperTabControlPrincipal.Margin = New System.Windows.Forms.Padding(4)
        Me.MSuperTabControlPrincipal.Size = New System.Drawing.Size(1284, 555)
        Me.MSuperTabControlPrincipal.Controls.SetChildIndex(Me.MSuperTabControlPanelRegistro, 0)
        '
        'MSuperTabControlPanelRegistro
        '
        Me.MSuperTabControlPanelRegistro.Controls.Add(Me.GpListaPrecio)
        Me.MSuperTabControlPanelRegistro.Controls.Add(Me.GpDatosGenerales)
        Me.MSuperTabControlPanelRegistro.Controls.Add(Me.TableLayoutPanelPrincipal)
        Me.MSuperTabControlPanelRegistro.Margin = New System.Windows.Forms.Padding(4)
        Me.MSuperTabControlPanelRegistro.Size = New System.Drawing.Size(1242, 555)
        Me.MSuperTabControlPanelRegistro.Controls.SetChildIndex(Me.TableLayoutPanelPrincipal, 0)
        Me.MSuperTabControlPanelRegistro.Controls.SetChildIndex(Me.MPnUsuario, 0)
        Me.MSuperTabControlPanelRegistro.Controls.SetChildIndex(Me.GpDatosGenerales, 0)
        Me.MSuperTabControlPanelRegistro.Controls.SetChildIndex(Me.GpListaPrecio, 0)
        '
        'MPnSuperior
        '
        Me.MPnSuperior.Controls.Add(Me.btExportarExcel)
        Me.MPnSuperior.Margin = New System.Windows.Forms.Padding(4)
        Me.MPnSuperior.Size = New System.Drawing.Size(1284, 70)
        Me.MPnSuperior.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.MPnSuperior.Style.BackColor1.Color = System.Drawing.Color.Gray
        Me.MPnSuperior.Style.BackColor2.Color = System.Drawing.SystemColors.ActiveCaption
        Me.MPnSuperior.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.MPnSuperior.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.MPnSuperior.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.MPnSuperior.Style.GradientAngle = 90
        Me.MPnSuperior.Controls.SetChildIndex(Me.MPanelToolBarAccion, 0)
        Me.MPnSuperior.Controls.SetChildIndex(Me.MPanelToolBarImprimir, 0)
        Me.MPnSuperior.Controls.SetChildIndex(Me.MRlAccion, 0)
        Me.MPnSuperior.Controls.SetChildIndex(Me.btExportarExcel, 0)
        '
        'MPnInferior
        '
        Me.MPnInferior.Location = New System.Drawing.Point(0, 625)
        Me.MPnInferior.Margin = New System.Windows.Forms.Padding(4)
        Me.MPnInferior.Size = New System.Drawing.Size(1284, 36)
        Me.MPnInferior.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.MPnInferior.Style.BackColor1.Color = System.Drawing.Color.Gray
        Me.MPnInferior.Style.BackColor2.Color = System.Drawing.SystemColors.ActiveCaption
        Me.MPnInferior.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.MPnInferior.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.MPnInferior.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.MPnInferior.Style.GradientAngle = 90
        '
        'MPanelToolBarUsuario
        '
        Me.MPanelToolBarUsuario.Location = New System.Drawing.Point(1084, 0)
        Me.MPanelToolBarUsuario.Margin = New System.Windows.Forms.Padding(4)
        '
        'MTbUsuario
        '
        Me.MTbUsuario.Margin = New System.Windows.Forms.Padding(4)
        Me.MTbUsuario.ReadOnly = True
        Me.MTbUsuario.Size = New System.Drawing.Size(135, 32)
        Me.MTbUsuario.Text = "DEFAULT"
        '
        'MBtUltimo
        '
        Me.MBtUltimo.Margin = New System.Windows.Forms.Padding(2)
        '
        'MBtSiguiente
        '
        '
        'MBtAnterior
        '
        '
        'MBtPrimero
        '
        '
        'MBtSalir
        '
        '
        'MBtGrabar
        '
        '
        'MBtEliminar
        '
        Me.MBtEliminar.Visible = False
        '
        'MBtModificar
        '
        '
        'MBtNuevo
        '
        Me.MBtNuevo.Visible = False
        '
        'MPanelToolBarImprimir
        '
        Me.MPanelToolBarImprimir.Location = New System.Drawing.Point(1204, 0)
        Me.MPanelToolBarImprimir.Margin = New System.Windows.Forms.Padding(4)
        '
        'MBtImprimir
        '
        Me.MBtImprimir.Visible = False
        '
        'MBubbleBarUsuario
        '
        '
        '
        '
        Me.MBubbleBarUsuario.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.MBubbleBarUsuario.ButtonBackAreaStyle.BackColor = System.Drawing.Color.Transparent
        Me.MBubbleBarUsuario.ButtonBackAreaStyle.BorderBottomWidth = 1
        Me.MBubbleBarUsuario.ButtonBackAreaStyle.BorderColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.MBubbleBarUsuario.ButtonBackAreaStyle.BorderLeftWidth = 1
        Me.MBubbleBarUsuario.ButtonBackAreaStyle.BorderRightWidth = 1
        Me.MBubbleBarUsuario.ButtonBackAreaStyle.BorderTopWidth = 1
        Me.MBubbleBarUsuario.ButtonBackAreaStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.MBubbleBarUsuario.ButtonBackAreaStyle.PaddingBottom = 3
        Me.MBubbleBarUsuario.ButtonBackAreaStyle.PaddingLeft = 3
        Me.MBubbleBarUsuario.ButtonBackAreaStyle.PaddingRight = 3
        Me.MBubbleBarUsuario.ButtonBackAreaStyle.PaddingTop = 3
        Me.MBubbleBarUsuario.MouseOverTabColors.BorderColor = System.Drawing.SystemColors.Highlight
        Me.MBubbleBarUsuario.SelectedTabColors.BorderColor = System.Drawing.Color.Black
        '
        'MLblUsuario
        '
        Me.MLblUsuario.Location = New System.Drawing.Point(31, 18)
        '
        'MLbPaginacion
        '
        '
        '
        '
        Me.MLbPaginacion.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        'MRlAccion
        '
        '
        '
        '
        Me.MRlAccion.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        'GridEXPrintDocumentListaPrecios
        '
        Me.GridEXPrintDocumentListaPrecios.DocumentName = "ListaPrecios"
        Me.GridEXPrintDocumentListaPrecios.FitColumns = Janus.Windows.GridEX.FitColumnsMode.Zooming
        Me.GridEXPrintDocumentListaPrecios.FooterDistance = 0
        Me.GridEXPrintDocumentListaPrecios.GridEX = Me.JGr_Detalle
        Me.GridEXPrintDocumentListaPrecios.HeaderDistance = 0
        Me.GridEXPrintDocumentListaPrecios.PageHeaderFormatStyle.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridEXPrintDocumentListaPrecios.PageHeaderFormatStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
        '
        'JGr_Detalle
        '
        Me.JGr_Detalle.Dock = System.Windows.Forms.DockStyle.Fill
        Me.JGr_Detalle.DynamicFiltering = True
        Me.JGr_Detalle.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.JGr_Detalle.Location = New System.Drawing.Point(0, 0)
        Me.JGr_Detalle.Name = "JGr_Detalle"
        Me.JGr_Detalle.Size = New System.Drawing.Size(1236, 534)
        Me.JGr_Detalle.TabIndex = 1
        '
        'GridEXExporterListaPrecio
        '
        Me.GridEXExporterListaPrecio.GridEX = Me.JGr_Detalle
        '
        'btExportarExcel
        '
        Me.btExportarExcel.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btExportarExcel.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btExportarExcel.Location = New System.Drawing.Point(684, 13)
        Me.btExportarExcel.Name = "btExportarExcel"
        Me.btExportarExcel.Size = New System.Drawing.Size(75, 51)
        Me.btExportarExcel.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btExportarExcel.TabIndex = 10
        Me.btExportarExcel.Text = "ButtonX1"
        Me.btExportarExcel.Visible = False
        '
        'CmDetalle
        '
        Me.CmDetalle.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.CmDetalle.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.QuitarProductoToolStripMenuItem})
        Me.CmDetalle.Name = "CmDetalle"
        Me.CmDetalle.Size = New System.Drawing.Size(138, 36)
        '
        'QuitarProductoToolStripMenuItem
        '
        Me.QuitarProductoToolStripMenuItem.Image = Global.Presentacion.My.Resources.Resources.eliminar
        Me.QuitarProductoToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.QuitarProductoToolStripMenuItem.Name = "QuitarProductoToolStripMenuItem"
        Me.QuitarProductoToolStripMenuItem.Size = New System.Drawing.Size(137, 32)
        Me.QuitarProductoToolStripMenuItem.Text = "Quitar Fila"
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 500
        '
        'GpDatosGenerales
        '
        Me.GpDatosGenerales.CanvasColor = System.Drawing.SystemColors.Control
        Me.GpDatosGenerales.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.GpDatosGenerales.Controls.Add(Me.PnDatosGenerales)
        Me.GpDatosGenerales.DisabledBackColor = System.Drawing.Color.Empty
        Me.GpDatosGenerales.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GpDatosGenerales.Location = New System.Drawing.Point(0, 0)
        Me.GpDatosGenerales.Name = "GpDatosGenerales"
        Me.GpDatosGenerales.Size = New System.Drawing.Size(1242, 555)
        '
        '
        '
        Me.GpDatosGenerales.Style.BackColor = System.Drawing.SystemColors.Control
        Me.GpDatosGenerales.Style.BackColor2 = System.Drawing.SystemColors.Control
        Me.GpDatosGenerales.Style.BackColorGradientAngle = 90
        Me.GpDatosGenerales.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GpDatosGenerales.Style.BorderBottomWidth = 1
        Me.GpDatosGenerales.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.GpDatosGenerales.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GpDatosGenerales.Style.BorderLeftWidth = 1
        Me.GpDatosGenerales.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GpDatosGenerales.Style.BorderRightWidth = 1
        Me.GpDatosGenerales.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GpDatosGenerales.Style.BorderTopWidth = 1
        Me.GpDatosGenerales.Style.CornerDiameter = 4
        Me.GpDatosGenerales.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded
        Me.GpDatosGenerales.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center
        Me.GpDatosGenerales.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.GpDatosGenerales.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near
        '
        '
        '
        Me.GpDatosGenerales.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.GpDatosGenerales.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.GpDatosGenerales.TabIndex = 0
        Me.GpDatosGenerales.Text = "DATOS GENERALES"
        Me.GpDatosGenerales.Visible = False
        '
        'PnDatosGenerales
        '
        Me.PnDatosGenerales.AutoScroll = True
        Me.PnDatosGenerales.CanvasColor = System.Drawing.SystemColors.Control
        Me.PnDatosGenerales.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.PnDatosGenerales.Controls.Add(Me.LabelX1)
        Me.PnDatosGenerales.Controls.Add(Me.JCb_CatProducto)
        Me.PnDatosGenerales.DisabledBackColor = System.Drawing.Color.Empty
        Me.PnDatosGenerales.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PnDatosGenerales.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PnDatosGenerales.Location = New System.Drawing.Point(0, 0)
        Me.PnDatosGenerales.Name = "PnDatosGenerales"
        Me.PnDatosGenerales.Size = New System.Drawing.Size(1236, 534)
        Me.PnDatosGenerales.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.PnDatosGenerales.Style.BackColor1.Color = System.Drawing.SystemColors.Control
        Me.PnDatosGenerales.Style.BackColor2.Color = System.Drawing.SystemColors.Control
        Me.PnDatosGenerales.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.PnDatosGenerales.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.PnDatosGenerales.Style.GradientAngle = 90
        Me.PnDatosGenerales.TabIndex = 4
        '
        'LabelX1
        '
        '
        '
        '
        Me.LabelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX1.Location = New System.Drawing.Point(3, 3)
        Me.LabelX1.Name = "LabelX1"
        Me.LabelX1.Size = New System.Drawing.Size(138, 23)
        Me.LabelX1.TabIndex = 2
        Me.LabelX1.Text = "Categoria de Producto:"
        '
        'JCb_CatProducto
        '
        JCb_CatProducto_DesignTimeLayout.LayoutString = resources.GetString("JCb_CatProducto_DesignTimeLayout.LayoutString")
        Me.JCb_CatProducto.DesignTimeLayout = JCb_CatProducto_DesignTimeLayout
        Me.JCb_CatProducto.Location = New System.Drawing.Point(147, 3)
        Me.JCb_CatProducto.Name = "JCb_CatProducto"
        Me.JCb_CatProducto.SelectedIndex = -1
        Me.JCb_CatProducto.SelectedItem = Nothing
        Me.JCb_CatProducto.Size = New System.Drawing.Size(250, 23)
        Me.JCb_CatProducto.TabIndex = 1
        '
        'GpListaPrecio
        '
        Me.GpListaPrecio.CanvasColor = System.Drawing.SystemColors.Control
        Me.GpListaPrecio.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.GpListaPrecio.Controls.Add(Me.PnListaPrecio)
        Me.GpListaPrecio.DisabledBackColor = System.Drawing.Color.Empty
        Me.GpListaPrecio.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GpListaPrecio.Location = New System.Drawing.Point(0, 0)
        Me.GpListaPrecio.Name = "GpListaPrecio"
        Me.GpListaPrecio.Size = New System.Drawing.Size(1242, 555)
        '
        '
        '
        Me.GpListaPrecio.Style.BackColor = System.Drawing.SystemColors.Control
        Me.GpListaPrecio.Style.BackColor2 = System.Drawing.SystemColors.Control
        Me.GpListaPrecio.Style.BackColorGradientAngle = 90
        Me.GpListaPrecio.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GpListaPrecio.Style.BorderBottomWidth = 1
        Me.GpListaPrecio.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.GpListaPrecio.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GpListaPrecio.Style.BorderLeftWidth = 1
        Me.GpListaPrecio.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GpListaPrecio.Style.BorderRightWidth = 1
        Me.GpListaPrecio.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GpListaPrecio.Style.BorderTopWidth = 1
        Me.GpListaPrecio.Style.CornerDiameter = 4
        Me.GpListaPrecio.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded
        Me.GpListaPrecio.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center
        Me.GpListaPrecio.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.GpListaPrecio.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near
        '
        '
        '
        Me.GpListaPrecio.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.GpListaPrecio.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.GpListaPrecio.TabIndex = 1
        Me.GpListaPrecio.Text = "CATEGORIA DE PRODUCTOS"
        '
        'PnListaPrecio
        '
        Me.PnListaPrecio.AutoScroll = True
        Me.PnListaPrecio.CanvasColor = System.Drawing.SystemColors.Control
        Me.PnListaPrecio.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.PnListaPrecio.Controls.Add(Me.JGr_Detalle)
        Me.PnListaPrecio.DisabledBackColor = System.Drawing.Color.Empty
        Me.PnListaPrecio.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PnListaPrecio.Location = New System.Drawing.Point(0, 0)
        Me.PnListaPrecio.Name = "PnListaPrecio"
        Me.PnListaPrecio.Size = New System.Drawing.Size(1236, 534)
        Me.PnListaPrecio.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.PnListaPrecio.Style.BackColor1.Color = System.Drawing.SystemColors.Control
        Me.PnListaPrecio.Style.BackColor2.Color = System.Drawing.SystemColors.Control
        Me.PnListaPrecio.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.PnListaPrecio.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.PnListaPrecio.Style.GradientAngle = 90
        Me.PnListaPrecio.TabIndex = 8
        '
        'TableLayoutPanelPrincipal
        '
        Me.TableLayoutPanelPrincipal.ColumnCount = 1
        Me.TableLayoutPanelPrincipal.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70.0!))
        Me.TableLayoutPanelPrincipal.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30.0!))
        Me.TableLayoutPanelPrincipal.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanelPrincipal.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanelPrincipal.Name = "TableLayoutPanelPrincipal"
        Me.TableLayoutPanelPrincipal.RowCount = 3
        Me.TableLayoutPanelPrincipal.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanelPrincipal.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanelPrincipal.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanelPrincipal.Size = New System.Drawing.Size(1242, 555)
        Me.TableLayoutPanelPrincipal.TabIndex = 29
        '
        'F02_ComisionesCategoria
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1284, 661)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "F02_ComisionesCategoria"
        Me.Opacity = 0.05R
        Me.Text = "F02_Comisiones"
        Me.WindowState = System.Windows.Forms.FormWindowState.Minimized
        Me.Controls.SetChildIndex(Me.MPnSuperior, 0)
        Me.Controls.SetChildIndex(Me.MPnInferior, 0)
        Me.Controls.SetChildIndex(Me.MSuperTabControlPrincipal, 0)
        CType(Me.MSuperTabControlPrincipal, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MSuperTabControlPrincipal.ResumeLayout(False)
        Me.MSuperTabControlPanelRegistro.ResumeLayout(False)
        Me.MPnSuperior.ResumeLayout(False)
        Me.MPnInferior.ResumeLayout(False)
        Me.MPanelToolBarUsuario.ResumeLayout(False)
        Me.MPanelToolBarUsuario.PerformLayout()
        Me.MPanelToolBarNavegacion.ResumeLayout(False)
        Me.MPanelToolBarAccion.ResumeLayout(False)
        Me.MPanelToolBarImprimir.ResumeLayout(False)
        CType(Me.MBubbleBarUsuario, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MPnUsuario.ResumeLayout(False)
        Me.MPnUsuario.PerformLayout()
        CType(Me.MEP, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.JGr_Detalle, System.ComponentModel.ISupportInitialize).EndInit()
        Me.CmDetalle.ResumeLayout(False)
        Me.GpDatosGenerales.ResumeLayout(False)
        Me.PnDatosGenerales.ResumeLayout(False)
        Me.PnDatosGenerales.PerformLayout()
        CType(Me.JCb_CatProducto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GpListaPrecio.ResumeLayout(False)
        Me.PnListaPrecio.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GridEXPrintDocumentListaPrecios As Janus.Windows.GridEX.GridEXPrintDocument
    Friend WithEvents btExportarExcel As DevComponents.DotNetBar.ButtonX
    Friend WithEvents GridEXExporterListaPrecio As Janus.Windows.GridEX.Export.GridEXExporter
    Friend WithEvents CmDetalle As ContextMenuStrip
    Friend WithEvents QuitarProductoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Timer1 As Timer
    Friend WithEvents TableLayoutPanelPrincipal As TableLayoutPanel
    Friend WithEvents GpDatosGenerales As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents PnDatosGenerales As DevComponents.DotNetBar.PanelEx
    Friend WithEvents LabelX1 As DevComponents.DotNetBar.LabelX
    Friend WithEvents JCb_CatProducto As Janus.Windows.GridEX.EditControls.MultiColumnCombo
    Friend WithEvents GpListaPrecio As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents PnListaPrecio As DevComponents.DotNetBar.PanelEx
    Friend WithEvents JGr_Detalle As Janus.Windows.GridEX.GridEX
End Class
