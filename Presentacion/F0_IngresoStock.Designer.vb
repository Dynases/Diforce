<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class F0_IngresoStock
    Inherits Modelo.ModeloF01_ca

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
        Dim cbConcepto_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(F0_IngresoStock))
        Dim cbAlmacen_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Me.PanelDatos = New System.Windows.Forms.Panel()
        Me.PanelPrecios = New System.Windows.Forms.Panel()
        Me.GroupPanel4 = New DevComponents.DotNetBar.Controls.GroupPanel()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.grprecio = New Janus.Windows.GridEX.GridEX()
        Me.GroupPanel3 = New DevComponents.DotNetBar.Controls.GroupPanel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.cbConcepto = New Janus.Windows.GridEX.EditControls.MultiColumnCombo()
        Me.LabelX2 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX1 = New DevComponents.DotNetBar.LabelX()
        Me.tbObs = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.cbAlmacen = New Janus.Windows.GridEX.EditControls.MultiColumnCombo()
        Me.lbgrupo2 = New DevComponents.DotNetBar.LabelX()
        Me.msModulos = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.SELECCIONARTODOSDELToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
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
        Me.PanelDatos.SuspendLayout()
        Me.PanelPrecios.SuspendLayout()
        Me.GroupPanel4.SuspendLayout()
        Me.Panel5.SuspendLayout()
        CType(Me.grprecio, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupPanel3.SuspendLayout()
        Me.Panel4.SuspendLayout()
        CType(Me.cbConcepto, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbAlmacen, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.msModulos.SuspendLayout()
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
        Me.MSuperTabControlPrincipal.Margin = New System.Windows.Forms.Padding(2)
        Me.MSuperTabControlPrincipal.Size = New System.Drawing.Size(803, 348)
        Me.MSuperTabControlPrincipal.Controls.SetChildIndex(Me.MSuperTabControlPanelRegistro, 0)
        '
        'MSuperTabControlPanelRegistro
        '
        Me.MSuperTabControlPanelRegistro.Controls.Add(Me.PanelDatos)
        Me.MSuperTabControlPanelRegistro.Margin = New System.Windows.Forms.Padding(2)
        Me.MSuperTabControlPanelRegistro.Size = New System.Drawing.Size(761, 348)
        Me.MSuperTabControlPanelRegistro.Controls.SetChildIndex(Me.MPnUsuario, 0)
        Me.MSuperTabControlPanelRegistro.Controls.SetChildIndex(Me.PanelDatos, 0)
        '
        'MPnSuperior
        '
        Me.MPnSuperior.Margin = New System.Windows.Forms.Padding(2)
        Me.MPnSuperior.Size = New System.Drawing.Size(803, 70)
        Me.MPnSuperior.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.MPnSuperior.Style.BackColor1.Color = System.Drawing.Color.Gray
        Me.MPnSuperior.Style.BackColor2.Color = System.Drawing.SystemColors.ActiveCaption
        Me.MPnSuperior.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.MPnSuperior.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.MPnSuperior.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.MPnSuperior.Style.GradientAngle = 90
        '
        'MPnInferior
        '
        Me.MPnInferior.Location = New System.Drawing.Point(0, 418)
        Me.MPnInferior.Margin = New System.Windows.Forms.Padding(2)
        Me.MPnInferior.Size = New System.Drawing.Size(803, 36)
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
        Me.MPanelToolBarUsuario.Location = New System.Drawing.Point(603, 0)
        Me.MPanelToolBarUsuario.Margin = New System.Windows.Forms.Padding(2)
        '
        'MTbUsuario
        '
        Me.MTbUsuario.Margin = New System.Windows.Forms.Padding(2)
        Me.MTbUsuario.ReadOnly = True
        Me.MTbUsuario.Size = New System.Drawing.Size(135, 23)
        Me.MTbUsuario.Text = "DEFAULT"
        '
        'MPanelToolBarNavegacion
        '
        Me.MPanelToolBarNavegacion.Visible = False
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
        Me.MPanelToolBarImprimir.Location = New System.Drawing.Point(588, 0)
        Me.MPanelToolBarImprimir.Margin = New System.Windows.Forms.Padding(2)
        Me.MPanelToolBarImprimir.Size = New System.Drawing.Size(215, 70)
        '
        'MBtImprimir
        '
        Me.MBtImprimir.Location = New System.Drawing.Point(143, 0)
        Me.MBtImprimir.Margin = New System.Windows.Forms.Padding(2)
        Me.MBtImprimir.Text = "Excel"
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
        'MLbPaginacion
        '
        '
        '
        '
        Me.MLbPaginacion.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.MLbPaginacion.Text = ""
        '
        'MRlAccion
        '
        '
        '
        '
        Me.MRlAccion.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        'PanelDatos
        '
        Me.PanelDatos.BackColor = System.Drawing.Color.White
        Me.PanelDatos.Controls.Add(Me.PanelPrecios)
        Me.PanelDatos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelDatos.Location = New System.Drawing.Point(0, 0)
        Me.PanelDatos.Margin = New System.Windows.Forms.Padding(2)
        Me.PanelDatos.Name = "PanelDatos"
        Me.PanelDatos.Size = New System.Drawing.Size(761, 348)
        Me.PanelDatos.TabIndex = 29
        '
        'PanelPrecios
        '
        Me.PanelPrecios.AutoScroll = True
        Me.PanelPrecios.BackColor = System.Drawing.Color.White
        Me.PanelPrecios.Controls.Add(Me.GroupPanel4)
        Me.PanelPrecios.Controls.Add(Me.GroupPanel3)
        Me.PanelPrecios.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelPrecios.Location = New System.Drawing.Point(0, 0)
        Me.PanelPrecios.Name = "PanelPrecios"
        Me.PanelPrecios.Size = New System.Drawing.Size(761, 348)
        Me.PanelPrecios.TabIndex = 2
        '
        'GroupPanel4
        '
        Me.GroupPanel4.CanvasColor = System.Drawing.SystemColors.Control
        Me.GroupPanel4.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.GroupPanel4.Controls.Add(Me.Panel5)
        Me.GroupPanel4.DisabledBackColor = System.Drawing.Color.Empty
        Me.GroupPanel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupPanel4.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupPanel4.Location = New System.Drawing.Point(0, 116)
        Me.GroupPanel4.Name = "GroupPanel4"
        Me.GroupPanel4.Size = New System.Drawing.Size(761, 232)
        '
        '
        '
        Me.GroupPanel4.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.GroupPanel4.Style.BackColorGradientAngle = 90
        Me.GroupPanel4.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.GroupPanel4.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel4.Style.BorderBottomWidth = 1
        Me.GroupPanel4.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.GroupPanel4.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel4.Style.BorderLeftWidth = 1
        Me.GroupPanel4.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel4.Style.BorderRightWidth = 1
        Me.GroupPanel4.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel4.Style.BorderTopWidth = 1
        Me.GroupPanel4.Style.CornerDiameter = 4
        Me.GroupPanel4.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded
        Me.GroupPanel4.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center
        Me.GroupPanel4.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.GroupPanel4.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near
        '
        '
        '
        Me.GroupPanel4.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.GroupPanel4.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.GroupPanel4.TabIndex = 1
        Me.GroupPanel4.Text = "PRODUCTOS"
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.White
        Me.Panel5.Controls.Add(Me.grprecio)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel5.Location = New System.Drawing.Point(0, 0)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(755, 209)
        Me.Panel5.TabIndex = 0
        '
        'grprecio
        '
        Me.grprecio.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grprecio.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grprecio.HeaderFormatStyle.Font = New System.Drawing.Font("Georgia", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grprecio.Location = New System.Drawing.Point(0, 0)
        Me.grprecio.Name = "grprecio"
        Me.grprecio.Office2007ColorScheme = Janus.Windows.GridEX.Office2007ColorScheme.Custom
        Me.grprecio.Office2007CustomColor = System.Drawing.Color.DodgerBlue
        Me.grprecio.Size = New System.Drawing.Size(755, 209)
        Me.grprecio.TabIndex = 0
        Me.grprecio.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
        '
        'GroupPanel3
        '
        Me.GroupPanel3.CanvasColor = System.Drawing.SystemColors.Control
        Me.GroupPanel3.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.GroupPanel3.Controls.Add(Me.Panel4)
        Me.GroupPanel3.DisabledBackColor = System.Drawing.Color.Empty
        Me.GroupPanel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupPanel3.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupPanel3.Location = New System.Drawing.Point(0, 0)
        Me.GroupPanel3.Name = "GroupPanel3"
        Me.GroupPanel3.Size = New System.Drawing.Size(761, 116)
        '
        '
        '
        Me.GroupPanel3.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.GroupPanel3.Style.BackColorGradientAngle = 90
        Me.GroupPanel3.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.GroupPanel3.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel3.Style.BorderBottomWidth = 1
        Me.GroupPanel3.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.GroupPanel3.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel3.Style.BorderLeftWidth = 1
        Me.GroupPanel3.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel3.Style.BorderRightWidth = 1
        Me.GroupPanel3.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
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
        Me.GroupPanel3.TabIndex = 0
        Me.GroupPanel3.Text = "Categoria Producto"
        '
        'Panel4
        '
        Me.Panel4.AutoScroll = True
        Me.Panel4.BackColor = System.Drawing.Color.White
        Me.Panel4.Controls.Add(Me.cbConcepto)
        Me.Panel4.Controls.Add(Me.LabelX2)
        Me.Panel4.Controls.Add(Me.LabelX1)
        Me.Panel4.Controls.Add(Me.tbObs)
        Me.Panel4.Controls.Add(Me.cbAlmacen)
        Me.Panel4.Controls.Add(Me.lbgrupo2)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel4.Location = New System.Drawing.Point(0, 0)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(755, 93)
        Me.Panel4.TabIndex = 0
        '
        'cbConcepto
        '
        Me.cbConcepto.ComboStyle = Janus.Windows.GridEX.ComboStyle.DropDownList
        Me.cbConcepto.ControlThemedAreas = Janus.Windows.GridEX.ControlThemedAreas.Button
        cbConcepto_DesignTimeLayout.LayoutString = resources.GetString("cbConcepto_DesignTimeLayout.LayoutString")
        Me.cbConcepto.DesignTimeLayout = cbConcepto_DesignTimeLayout
        Me.cbConcepto.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbConcepto.Location = New System.Drawing.Point(100, 8)
        Me.cbConcepto.Name = "cbConcepto"
        Me.cbConcepto.Office2007ColorScheme = Janus.Windows.GridEX.Office2007ColorScheme.Custom
        Me.cbConcepto.Office2007CustomColor = System.Drawing.Color.DodgerBlue
        Me.cbConcepto.ReadOnly = True
        Me.cbConcepto.SelectedIndex = -1
        Me.cbConcepto.SelectedItem = Nothing
        Me.cbConcepto.Size = New System.Drawing.Size(230, 21)
        Me.cbConcepto.TabIndex = 35
        Me.cbConcepto.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
        '
        'LabelX2
        '
        Me.LabelX2.AutoSize = True
        Me.LabelX2.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.LabelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX2.Font = New System.Drawing.Font("Georgia", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.LabelX2.Location = New System.Drawing.Point(9, 10)
        Me.LabelX2.Name = "LabelX2"
        Me.LabelX2.PaddingTop = 4
        Me.LabelX2.SingleLineColor = System.Drawing.SystemColors.Control
        Me.LabelX2.Size = New System.Drawing.Size(65, 20)
        Me.LabelX2.TabIndex = 36
        Me.LabelX2.Text = "Concepto:"
        '
        'LabelX1
        '
        Me.LabelX1.AutoSize = True
        Me.LabelX1.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.LabelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX1.Font = New System.Drawing.Font("Georgia", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.LabelX1.Location = New System.Drawing.Point(10, 36)
        Me.LabelX1.Name = "LabelX1"
        Me.LabelX1.PaddingTop = 4
        Me.LabelX1.SingleLineColor = System.Drawing.SystemColors.Control
        Me.LabelX1.Size = New System.Drawing.Size(84, 20)
        Me.LabelX1.TabIndex = 34
        Me.LabelX1.Text = "Observación:"
        '
        'tbObs
        '
        '
        '
        '
        Me.tbObs.Border.Class = "TextBoxBorder"
        Me.tbObs.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.tbObs.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.tbObs.Location = New System.Drawing.Point(100, 36)
        Me.tbObs.Name = "tbObs"
        Me.tbObs.PreventEnterBeep = True
        Me.tbObs.Size = New System.Drawing.Size(231, 21)
        Me.tbObs.TabIndex = 33
        '
        'cbAlmacen
        '
        Me.cbAlmacen.ComboStyle = Janus.Windows.GridEX.ComboStyle.DropDownList
        Me.cbAlmacen.ControlThemedAreas = Janus.Windows.GridEX.ControlThemedAreas.Button
        cbAlmacen_DesignTimeLayout.LayoutString = resources.GetString("cbAlmacen_DesignTimeLayout.LayoutString")
        Me.cbAlmacen.DesignTimeLayout = cbAlmacen_DesignTimeLayout
        Me.cbAlmacen.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbAlmacen.Location = New System.Drawing.Point(100, 64)
        Me.cbAlmacen.Name = "cbAlmacen"
        Me.cbAlmacen.Office2007ColorScheme = Janus.Windows.GridEX.Office2007ColorScheme.Custom
        Me.cbAlmacen.Office2007CustomColor = System.Drawing.Color.DodgerBlue
        Me.cbAlmacen.SelectedIndex = -1
        Me.cbAlmacen.SelectedItem = Nothing
        Me.cbAlmacen.Size = New System.Drawing.Size(230, 21)
        Me.cbAlmacen.TabIndex = 31
        Me.cbAlmacen.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
        '
        'lbgrupo2
        '
        Me.lbgrupo2.AutoSize = True
        Me.lbgrupo2.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.lbgrupo2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.lbgrupo2.Font = New System.Drawing.Font("Georgia", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbgrupo2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.lbgrupo2.Location = New System.Drawing.Point(9, 66)
        Me.lbgrupo2.Name = "lbgrupo2"
        Me.lbgrupo2.PaddingTop = 4
        Me.lbgrupo2.SingleLineColor = System.Drawing.SystemColors.Control
        Me.lbgrupo2.Size = New System.Drawing.Size(66, 20)
        Me.lbgrupo2.TabIndex = 32
        Me.lbgrupo2.Text = "Categoria:"
        '
        'msModulos
        '
        Me.msModulos.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.msModulos.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SELECCIONARTODOSDELToolStripMenuItem})
        Me.msModulos.Name = "msModulos"
        Me.msModulos.Size = New System.Drawing.Size(193, 26)
        '
        'SELECCIONARTODOSDELToolStripMenuItem
        '
        Me.SELECCIONARTODOSDELToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.SELECCIONARTODOSDELToolStripMenuItem.Name = "SELECCIONARTODOSDELToolStripMenuItem"
        Me.SELECCIONARTODOSDELToolStripMenuItem.Size = New System.Drawing.Size(192, 22)
        Me.SELECCIONARTODOSDELToolStripMenuItem.Text = "ELIMINAR CATEGORIA"
        '
        'F0_IngresoStock
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(803, 454)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "F0_IngresoStock"
        Me.Text = "INGRESO POR CATEGORIA"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
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
        Me.PanelDatos.ResumeLayout(False)
        Me.PanelPrecios.ResumeLayout(False)
        Me.GroupPanel4.ResumeLayout(False)
        Me.Panel5.ResumeLayout(False)
        CType(Me.grprecio, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupPanel3.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        CType(Me.cbConcepto, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbAlmacen, System.ComponentModel.ISupportInitialize).EndInit()
        Me.msModulos.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PanelDatos As Panel
    Friend WithEvents PanelPrecios As Panel
    Friend WithEvents GroupPanel4 As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents Panel5 As Panel
    Friend WithEvents grprecio As Janus.Windows.GridEX.GridEX
    Friend WithEvents GroupPanel3 As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents cbAlmacen As Janus.Windows.GridEX.EditControls.MultiColumnCombo
    Friend WithEvents lbgrupo2 As DevComponents.DotNetBar.LabelX
    Friend WithEvents msModulos As ContextMenuStrip
    Friend WithEvents SELECCIONARTODOSDELToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents cbConcepto As Janus.Windows.GridEX.EditControls.MultiColumnCombo
    Friend WithEvents LabelX2 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX1 As DevComponents.DotNetBar.LabelX
    Friend WithEvents tbObs As DevComponents.DotNetBar.Controls.TextBoxX
End Class
