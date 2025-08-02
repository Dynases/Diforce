<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class F01_Presupuesto
    'Inherits System.Windows.Forms.Form
    Inherits Modelo.ModeloF02_cd

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
        Dim cbMes_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(F01_Presupuesto))
        Me.GroupPanelDatosGenerales = New DevComponents.DotNetBar.Controls.GroupPanel()
        Me.PanelExDatosGenerales = New DevComponents.DotNetBar.PanelEx()
        Me.LabelX1 = New DevComponents.DotNetBar.LabelX()
        Me.tbId = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.tbAño = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cbMes = New Janus.Windows.GridEX.EditControls.MultiColumnCombo()
        Me.GroupPanelPersonal = New DevComponents.DotNetBar.Controls.GroupPanel()
        Me.grVendedor = New Janus.Windows.GridEX.GridEX()
        Me.PanelEx1 = New DevComponents.DotNetBar.PanelEx()
        Me.PanelEx2 = New DevComponents.DotNetBar.PanelEx()
        Me.grdetalle = New Janus.Windows.GridEX.GridEX()
        Me.grPresupuesto = New Janus.Windows.GridEX.GridEX()
        CType(Me.MSuperTabControlPrincipal, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MSuperTabControlPrincipal.SuspendLayout()
        Me.MSuperTabControlPanelBusqueda.SuspendLayout()
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
        Me.GroupPanelDatosGenerales.SuspendLayout()
        Me.PanelExDatosGenerales.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.cbMes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupPanelPersonal.SuspendLayout()
        CType(Me.grVendedor, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelEx1.SuspendLayout()
        Me.PanelEx2.SuspendLayout()
        CType(Me.grdetalle, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grPresupuesto, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.MSuperTabControlPrincipal.SelectedTabIndex = 1
        Me.MSuperTabControlPrincipal.Size = New System.Drawing.Size(1166, 531)
        Me.MSuperTabControlPrincipal.Controls.SetChildIndex(Me.MSuperTabControlPanelBusqueda, 0)
        Me.MSuperTabControlPrincipal.Controls.SetChildIndex(Me.MSuperTabControlPanelRegistro, 0)
        '
        'MSuperTabControlPanelBusqueda
        '
        Me.MSuperTabControlPanelBusqueda.Controls.Add(Me.grPresupuesto)
        Me.MSuperTabControlPanelBusqueda.Size = New System.Drawing.Size(1124, 531)
        '
        'MSuperTabControlPanelRegistro
        '
        Me.MSuperTabControlPanelRegistro.Controls.Add(Me.PanelEx2)
        Me.MSuperTabControlPanelRegistro.Controls.Add(Me.PanelEx1)
        Me.MSuperTabControlPanelRegistro.Size = New System.Drawing.Size(1124, 531)
        Me.MSuperTabControlPanelRegistro.Controls.SetChildIndex(Me.MPnUsuario, 0)
        Me.MSuperTabControlPanelRegistro.Controls.SetChildIndex(Me.PanelEx1, 0)
        Me.MSuperTabControlPanelRegistro.Controls.SetChildIndex(Me.PanelEx2, 0)
        '
        'MPnSuperior
        '
        Me.MPnSuperior.Size = New System.Drawing.Size(1166, 70)
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
        Me.MPnInferior.Location = New System.Drawing.Point(0, 601)
        Me.MPnInferior.Size = New System.Drawing.Size(1166, 36)
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
        Me.MPanelToolBarUsuario.Location = New System.Drawing.Point(966, 0)
        '
        'MTbUsuario
        '
        Me.MTbUsuario.ReadOnly = True
        Me.MTbUsuario.Text = "DEFAULT"
        '
        'MBtUltimo
        '
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
        '
        'MPanelToolBarImprimir
        '
        Me.MPanelToolBarImprimir.Location = New System.Drawing.Point(1086, 0)
        '
        'MBtImprimir
        '
        Me.MBtImprimir.Image = Global.Presentacion.My.Resources.Resources.NUEVO
        Me.MBtImprimir.Text = "COPIAR"
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
        '
        'MRlAccion
        '
        '
        '
        '
        Me.MRlAccion.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        'GroupPanelDatosGenerales
        '
        Me.GroupPanelDatosGenerales.CanvasColor = System.Drawing.SystemColors.Control
        Me.GroupPanelDatosGenerales.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.GroupPanelDatosGenerales.Controls.Add(Me.PanelExDatosGenerales)
        Me.GroupPanelDatosGenerales.DisabledBackColor = System.Drawing.Color.Empty
        Me.GroupPanelDatosGenerales.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupPanelDatosGenerales.Location = New System.Drawing.Point(0, 0)
        Me.GroupPanelDatosGenerales.Name = "GroupPanelDatosGenerales"
        Me.GroupPanelDatosGenerales.Size = New System.Drawing.Size(300, 154)
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
        Me.GroupPanelDatosGenerales.TabIndex = 29
        Me.GroupPanelDatosGenerales.Text = "DATOS GENERALES"
        '
        'PanelExDatosGenerales
        '
        Me.PanelExDatosGenerales.AutoScroll = True
        Me.PanelExDatosGenerales.CanvasColor = System.Drawing.SystemColors.Control
        Me.PanelExDatosGenerales.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.PanelExDatosGenerales.Controls.Add(Me.LabelX1)
        Me.PanelExDatosGenerales.Controls.Add(Me.tbId)
        Me.PanelExDatosGenerales.Controls.Add(Me.GroupBox1)
        Me.PanelExDatosGenerales.DisabledBackColor = System.Drawing.Color.Empty
        Me.PanelExDatosGenerales.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelExDatosGenerales.Location = New System.Drawing.Point(0, 0)
        Me.PanelExDatosGenerales.Name = "PanelExDatosGenerales"
        Me.PanelExDatosGenerales.Size = New System.Drawing.Size(294, 133)
        Me.PanelExDatosGenerales.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.PanelExDatosGenerales.Style.BackColor1.Color = System.Drawing.SystemColors.Control
        Me.PanelExDatosGenerales.Style.BackColor2.Color = System.Drawing.SystemColors.Control
        Me.PanelExDatosGenerales.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.PanelExDatosGenerales.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.PanelExDatosGenerales.Style.GradientAngle = 90
        Me.PanelExDatosGenerales.TabIndex = 0
        '
        'LabelX1
        '
        '
        '
        '
        Me.LabelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.LabelX1.ForeColor = System.Drawing.Color.Black
        Me.LabelX1.Location = New System.Drawing.Point(31, 12)
        Me.LabelX1.Name = "LabelX1"
        Me.LabelX1.Size = New System.Drawing.Size(50, 23)
        Me.LabelX1.TabIndex = 115
        Me.LabelX1.Text = "Codigo:"
        '
        'tbId
        '
        '
        '
        '
        Me.tbId.Border.Class = "TextBoxBorder"
        Me.tbId.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.tbId.Location = New System.Drawing.Point(87, 15)
        Me.tbId.Name = "tbId"
        Me.tbId.PreventEnterBeep = True
        Me.tbId.ReadOnly = True
        Me.tbId.Size = New System.Drawing.Size(60, 20)
        Me.tbId.TabIndex = 114
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.tbAño)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.cbMes)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(5, 41)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(280, 80)
        Me.GroupBox1.TabIndex = 113
        Me.GroupBox1.TabStop = False
        '
        'tbAño
        '
        '
        '
        '
        Me.tbAño.Border.Class = "TextBoxBorder"
        Me.tbAño.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.tbAño.Location = New System.Drawing.Point(83, 50)
        Me.tbAño.Name = "tbAño"
        Me.tbAño.PreventEnterBeep = True
        Me.tbAño.Size = New System.Drawing.Size(150, 23)
        Me.tbAño.TabIndex = 6
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(26, 52)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(37, 17)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Año:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(26, 19)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(38, 17)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Mes:"
        '
        'cbMes
        '
        cbMes_DesignTimeLayout.LayoutString = resources.GetString("cbMes_DesignTimeLayout.LayoutString")
        Me.cbMes.DesignTimeLayout = cbMes_DesignTimeLayout
        Me.cbMes.Location = New System.Drawing.Point(82, 14)
        Me.cbMes.Name = "cbMes"
        Me.cbMes.SelectedIndex = -1
        Me.cbMes.SelectedItem = Nothing
        Me.cbMes.Size = New System.Drawing.Size(150, 23)
        Me.cbMes.TabIndex = 0
        '
        'GroupPanelPersonal
        '
        Me.GroupPanelPersonal.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.GroupPanelPersonal.CanvasColor = System.Drawing.SystemColors.Control
        Me.GroupPanelPersonal.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.GroupPanelPersonal.Controls.Add(Me.grVendedor)
        Me.GroupPanelPersonal.DisabledBackColor = System.Drawing.Color.Empty
        Me.GroupPanelPersonal.Location = New System.Drawing.Point(0, 157)
        Me.GroupPanelPersonal.Name = "GroupPanelPersonal"
        Me.GroupPanelPersonal.Size = New System.Drawing.Size(300, 374)
        '
        '
        '
        Me.GroupPanelPersonal.Style.BackColor = System.Drawing.SystemColors.Control
        Me.GroupPanelPersonal.Style.BackColor2 = System.Drawing.SystemColors.Control
        Me.GroupPanelPersonal.Style.BackColorGradientAngle = 90
        Me.GroupPanelPersonal.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanelPersonal.Style.BorderBottomWidth = 1
        Me.GroupPanelPersonal.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.GroupPanelPersonal.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanelPersonal.Style.BorderLeftWidth = 1
        Me.GroupPanelPersonal.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanelPersonal.Style.BorderRightWidth = 1
        Me.GroupPanelPersonal.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanelPersonal.Style.BorderTopWidth = 1
        Me.GroupPanelPersonal.Style.CornerDiameter = 4
        Me.GroupPanelPersonal.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded
        Me.GroupPanelPersonal.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center
        Me.GroupPanelPersonal.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.GroupPanelPersonal.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near
        '
        '
        '
        Me.GroupPanelPersonal.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.GroupPanelPersonal.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.GroupPanelPersonal.TabIndex = 30
        Me.GroupPanelPersonal.Text = "VENDEDOR"
        '
        'grVendedor
        '
        Me.grVendedor.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grVendedor.Location = New System.Drawing.Point(0, 0)
        Me.grVendedor.Name = "grVendedor"
        Me.grVendedor.RowFormatStyle.BackColor = System.Drawing.Color.White
        Me.grVendedor.RowHeaderFormatStyle.BackColor = System.Drawing.Color.White
        Me.grVendedor.SelectedFormatStyle.BackColor = System.Drawing.Color.White
        Me.grVendedor.Size = New System.Drawing.Size(294, 353)
        Me.grVendedor.TabIndex = 1
        '
        'PanelEx1
        '
        Me.PanelEx1.CanvasColor = System.Drawing.SystemColors.Control
        Me.PanelEx1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.PanelEx1.Controls.Add(Me.GroupPanelDatosGenerales)
        Me.PanelEx1.Controls.Add(Me.GroupPanelPersonal)
        Me.PanelEx1.DisabledBackColor = System.Drawing.Color.Empty
        Me.PanelEx1.Dock = System.Windows.Forms.DockStyle.Left
        Me.PanelEx1.Location = New System.Drawing.Point(0, 0)
        Me.PanelEx1.Name = "PanelEx1"
        Me.PanelEx1.Size = New System.Drawing.Size(300, 531)
        Me.PanelEx1.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.PanelEx1.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.PanelEx1.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.PanelEx1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.PanelEx1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.PanelEx1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.PanelEx1.Style.GradientAngle = 90
        Me.PanelEx1.TabIndex = 114
        '
        'PanelEx2
        '
        Me.PanelEx2.CanvasColor = System.Drawing.SystemColors.Control
        Me.PanelEx2.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.PanelEx2.Controls.Add(Me.grdetalle)
        Me.PanelEx2.DisabledBackColor = System.Drawing.Color.Empty
        Me.PanelEx2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelEx2.Location = New System.Drawing.Point(300, 0)
        Me.PanelEx2.Name = "PanelEx2"
        Me.PanelEx2.Size = New System.Drawing.Size(824, 531)
        Me.PanelEx2.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.PanelEx2.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.PanelEx2.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.PanelEx2.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.PanelEx2.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.PanelEx2.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.PanelEx2.Style.GradientAngle = 90
        Me.PanelEx2.TabIndex = 118
        Me.PanelEx2.Text = "PanelEx2"
        '
        'grdetalle
        '
        Me.grdetalle.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grdetalle.Font = New System.Drawing.Font("Microsoft Sans Serif", 17.0!)
        Me.grdetalle.Location = New System.Drawing.Point(0, 0)
        Me.grdetalle.Name = "grdetalle"
        Me.grdetalle.Size = New System.Drawing.Size(824, 531)
        Me.grdetalle.TabIndex = 0
        '
        'grPresupuesto
        '
        Me.grPresupuesto.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grPresupuesto.Location = New System.Drawing.Point(0, 0)
        Me.grPresupuesto.Name = "grPresupuesto"
        Me.grPresupuesto.Size = New System.Drawing.Size(1124, 531)
        Me.grPresupuesto.TabIndex = 0
        '
        'F01_Presupuesto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1166, 637)
        Me.Location = New System.Drawing.Point(0, 0)
        Me.Name = "F01_Presupuesto"
        Me.Opacity = 0.99R
        Me.Text = "F01_Presupuesto"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Controls.SetChildIndex(Me.MPnSuperior, 0)
        Me.Controls.SetChildIndex(Me.MPnInferior, 0)
        Me.Controls.SetChildIndex(Me.MSuperTabControlPrincipal, 0)
        CType(Me.MSuperTabControlPrincipal, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MSuperTabControlPrincipal.ResumeLayout(False)
        Me.MSuperTabControlPanelBusqueda.ResumeLayout(False)
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
        Me.GroupPanelDatosGenerales.ResumeLayout(False)
        Me.PanelExDatosGenerales.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.cbMes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupPanelPersonal.ResumeLayout(False)
        CType(Me.grVendedor, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelEx1.ResumeLayout(False)
        Me.PanelEx2.ResumeLayout(False)
        CType(Me.grdetalle, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grPresupuesto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupPanelDatosGenerales As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents PanelExDatosGenerales As DevComponents.DotNetBar.PanelEx
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label3 As Label
    Friend WithEvents cbMes As Janus.Windows.GridEX.EditControls.MultiColumnCombo
    Friend WithEvents PanelEx1 As DevComponents.DotNetBar.PanelEx
    Friend WithEvents GroupPanelPersonal As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents PanelEx2 As DevComponents.DotNetBar.PanelEx
    Friend WithEvents grdetalle As Janus.Windows.GridEX.GridEX
    Friend WithEvents Label1 As Label
    Friend WithEvents grVendedor As Janus.Windows.GridEX.GridEX
    Friend WithEvents tbAño As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents grPresupuesto As Janus.Windows.GridEX.GridEX
    Friend WithEvents LabelX1 As DevComponents.DotNetBar.LabelX
    Friend WithEvents tbId As DevComponents.DotNetBar.Controls.TextBoxX
End Class
