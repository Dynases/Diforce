<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class F01_Personal
    Inherits Modelo.ModeloF01_ca

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
        Me.components = New System.ComponentModel.Container()
        Dim cbSucursal_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(F01_Personal))
        Dim CbAlmacen_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Dim cbTipo_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Me.TableLayoutPanelPrincipal = New System.Windows.Forms.TableLayoutPanel()
        Me.Gp3Proveedores = New DevComponents.DotNetBar.Controls.GroupPanel()
        Me.Dgj1Busqueda = New Janus.Windows.GridEX.GridEX()
        Me.PanelEx1 = New DevComponents.DotNetBar.PanelEx()
        Me.GroupPanelDatosGenerales = New DevComponents.DotNetBar.Controls.GroupPanel()
        Me.PanelExDatosGenerales = New DevComponents.DotNetBar.PanelEx()
        Me.lbAlmacen = New DevComponents.DotNetBar.LabelX()
        Me.cbSucursal = New Janus.Windows.GridEX.EditControls.MultiColumnCombo()
        Me.LabelX6 = New DevComponents.DotNetBar.LabelX()
        Me.CbAlmacen = New Janus.Windows.GridEX.EditControls.MultiColumnCombo()
        Me.LabelX5 = New DevComponents.DotNetBar.LabelX()
        Me.cbTipo = New Janus.Windows.GridEX.EditControls.MultiColumnCombo()
        Me.LabelX1 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX2 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX3 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX4 = New DevComponents.DotNetBar.LabelX()
        Me.TbCodigo = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.TbNombre = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.SbEstado = New DevComponents.DotNetBar.Controls.SwitchButton()
        Me.TbPassMovil = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.GroupPanelPreferencias = New DevComponents.DotNetBar.Controls.GroupPanel()
        Me.PanelEx2 = New DevComponents.DotNetBar.PanelEx()
        Me.swZona = New DevComponents.DotNetBar.Controls.SwitchButton()
        Me.swPrecio = New DevComponents.DotNetBar.Controls.SwitchButton()
        Me.LabelX8 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX7 = New DevComponents.DotNetBar.LabelX()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.swModificarPedido = New DevComponents.DotNetBar.Controls.SwitchButton()
        Me.LabelX9 = New DevComponents.DotNetBar.LabelX()
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
        Me.TableLayoutPanelPrincipal.SuspendLayout()
        Me.Gp3Proveedores.SuspendLayout()
        CType(Me.Dgj1Busqueda, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelEx1.SuspendLayout()
        Me.GroupPanelDatosGenerales.SuspendLayout()
        Me.PanelExDatosGenerales.SuspendLayout()
        CType(Me.cbSucursal, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CbAlmacen, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbTipo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupPanelPreferencias.SuspendLayout()
        Me.PanelEx2.SuspendLayout()
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
        Me.MSuperTabControlPrincipal.Controls.SetChildIndex(Me.MSuperTabControlPanelRegistro, 0)
        '
        'MSuperTabControlPanelRegistro
        '
        Me.MSuperTabControlPanelRegistro.Controls.Add(Me.TableLayoutPanelPrincipal)
        Me.MSuperTabControlPanelRegistro.Margin = New System.Windows.Forms.Padding(4, 2, 4, 2)
        Me.MSuperTabControlPanelRegistro.Size = New System.Drawing.Size(942, 455)
        Me.MSuperTabControlPanelRegistro.Controls.SetChildIndex(Me.MPnUsuario, 0)
        Me.MSuperTabControlPanelRegistro.Controls.SetChildIndex(Me.TableLayoutPanelPrincipal, 0)
        '
        'MPnSuperior
        '
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
        Me.MPnInferior.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.MPnInferior.Style.BackColor1.Color = System.Drawing.Color.Gray
        Me.MPnInferior.Style.BackColor2.Color = System.Drawing.SystemColors.ActiveCaption
        Me.MPnInferior.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.MPnInferior.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.MPnInferior.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.MPnInferior.Style.GradientAngle = 90
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
        '
        'MBtModificar
        '
        '
        'MBtNuevo
        '
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
        'TableLayoutPanelPrincipal
        '
        Me.TableLayoutPanelPrincipal.ColumnCount = 1
        Me.TableLayoutPanelPrincipal.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanelPrincipal.Controls.Add(Me.Gp3Proveedores, 0, 1)
        Me.TableLayoutPanelPrincipal.Controls.Add(Me.PanelEx1, 0, 0)
        Me.TableLayoutPanelPrincipal.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanelPrincipal.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanelPrincipal.Name = "TableLayoutPanelPrincipal"
        Me.TableLayoutPanelPrincipal.RowCount = 4
        Me.TableLayoutPanelPrincipal.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 200.0!))
        Me.TableLayoutPanelPrincipal.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanelPrincipal.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanelPrincipal.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanelPrincipal.Size = New System.Drawing.Size(942, 455)
        Me.TableLayoutPanelPrincipal.TabIndex = 29
        '
        'Gp3Proveedores
        '
        Me.Gp3Proveedores.CanvasColor = System.Drawing.SystemColors.Control
        Me.Gp3Proveedores.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.Gp3Proveedores.Controls.Add(Me.Dgj1Busqueda)
        Me.Gp3Proveedores.DisabledBackColor = System.Drawing.Color.Empty
        Me.Gp3Proveedores.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Gp3Proveedores.Location = New System.Drawing.Point(3, 203)
        Me.Gp3Proveedores.Name = "Gp3Proveedores"
        Me.Gp3Proveedores.Padding = New System.Windows.Forms.Padding(5)
        Me.Gp3Proveedores.Size = New System.Drawing.Size(936, 209)
        '
        '
        '
        Me.Gp3Proveedores.Style.BackColor = System.Drawing.SystemColors.Control
        Me.Gp3Proveedores.Style.BackColor2 = System.Drawing.SystemColors.Control
        Me.Gp3Proveedores.Style.BackColorGradientAngle = 90
        Me.Gp3Proveedores.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.Gp3Proveedores.Style.BorderBottomWidth = 1
        Me.Gp3Proveedores.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.Gp3Proveedores.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.Gp3Proveedores.Style.BorderLeftWidth = 1
        Me.Gp3Proveedores.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.Gp3Proveedores.Style.BorderRightWidth = 1
        Me.Gp3Proveedores.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.Gp3Proveedores.Style.BorderTopWidth = 1
        Me.Gp3Proveedores.Style.CornerDiameter = 4
        Me.Gp3Proveedores.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded
        Me.Gp3Proveedores.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center
        Me.Gp3Proveedores.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.Gp3Proveedores.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near
        '
        '
        '
        Me.Gp3Proveedores.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.Gp3Proveedores.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.Gp3Proveedores.TabIndex = 4
        Me.Gp3Proveedores.Text = "BUSQUEDA GENERAL"
        '
        'Dgj1Busqueda
        '
        Me.Dgj1Busqueda.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Dgj1Busqueda.Location = New System.Drawing.Point(5, 5)
        Me.Dgj1Busqueda.Name = "Dgj1Busqueda"
        Me.Dgj1Busqueda.Size = New System.Drawing.Size(920, 178)
        Me.Dgj1Busqueda.TabIndex = 0
        '
        'PanelEx1
        '
        Me.PanelEx1.AutoScroll = True
        Me.PanelEx1.CanvasColor = System.Drawing.SystemColors.Control
        Me.PanelEx1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.PanelEx1.Controls.Add(Me.GroupPanelDatosGenerales)
        Me.PanelEx1.Controls.Add(Me.GroupPanelPreferencias)
        Me.PanelEx1.DisabledBackColor = System.Drawing.Color.Empty
        Me.PanelEx1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelEx1.Location = New System.Drawing.Point(3, 3)
        Me.PanelEx1.Name = "PanelEx1"
        Me.PanelEx1.Size = New System.Drawing.Size(936, 194)
        Me.PanelEx1.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.PanelEx1.Style.BackColor1.Color = System.Drawing.SystemColors.Control
        Me.PanelEx1.Style.BackColor2.Color = System.Drawing.SystemColors.Control
        Me.PanelEx1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.PanelEx1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.PanelEx1.Style.GradientAngle = 90
        Me.PanelEx1.TabIndex = 16
        '
        'GroupPanelDatosGenerales
        '
        Me.GroupPanelDatosGenerales.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupPanelDatosGenerales.CanvasColor = System.Drawing.SystemColors.Control
        Me.GroupPanelDatosGenerales.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.GroupPanelDatosGenerales.Controls.Add(Me.PanelExDatosGenerales)
        Me.GroupPanelDatosGenerales.DisabledBackColor = System.Drawing.Color.Empty
        Me.GroupPanelDatosGenerales.Location = New System.Drawing.Point(0, 0)
        Me.GroupPanelDatosGenerales.Name = "GroupPanelDatosGenerales"
        Me.GroupPanelDatosGenerales.Size = New System.Drawing.Size(601, 191)
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
        Me.GroupPanelDatosGenerales.TabIndex = 3
        Me.GroupPanelDatosGenerales.Text = "DATOS GENERALES"
        '
        'PanelExDatosGenerales
        '
        Me.PanelExDatosGenerales.AutoScroll = True
        Me.PanelExDatosGenerales.CanvasColor = System.Drawing.SystemColors.Control
        Me.PanelExDatosGenerales.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.PanelExDatosGenerales.Controls.Add(Me.lbAlmacen)
        Me.PanelExDatosGenerales.Controls.Add(Me.cbSucursal)
        Me.PanelExDatosGenerales.Controls.Add(Me.LabelX6)
        Me.PanelExDatosGenerales.Controls.Add(Me.CbAlmacen)
        Me.PanelExDatosGenerales.Controls.Add(Me.LabelX5)
        Me.PanelExDatosGenerales.Controls.Add(Me.cbTipo)
        Me.PanelExDatosGenerales.Controls.Add(Me.LabelX1)
        Me.PanelExDatosGenerales.Controls.Add(Me.LabelX2)
        Me.PanelExDatosGenerales.Controls.Add(Me.LabelX3)
        Me.PanelExDatosGenerales.Controls.Add(Me.LabelX4)
        Me.PanelExDatosGenerales.Controls.Add(Me.TbCodigo)
        Me.PanelExDatosGenerales.Controls.Add(Me.TbNombre)
        Me.PanelExDatosGenerales.Controls.Add(Me.SbEstado)
        Me.PanelExDatosGenerales.Controls.Add(Me.TbPassMovil)
        Me.PanelExDatosGenerales.DisabledBackColor = System.Drawing.Color.Empty
        Me.PanelExDatosGenerales.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelExDatosGenerales.Location = New System.Drawing.Point(0, 0)
        Me.PanelExDatosGenerales.Name = "PanelExDatosGenerales"
        Me.PanelExDatosGenerales.Size = New System.Drawing.Size(595, 170)
        Me.PanelExDatosGenerales.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.PanelExDatosGenerales.Style.BackColor1.Color = System.Drawing.SystemColors.Control
        Me.PanelExDatosGenerales.Style.BackColor2.Color = System.Drawing.SystemColors.Control
        Me.PanelExDatosGenerales.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.PanelExDatosGenerales.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.PanelExDatosGenerales.Style.GradientAngle = 90
        Me.PanelExDatosGenerales.TabIndex = 16
        '
        'lbAlmacen
        '
        Me.lbAlmacen.AutoSize = True
        '
        '
        '
        Me.lbAlmacen.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.lbAlmacen.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbAlmacen.Location = New System.Drawing.Point(260, 66)
        Me.lbAlmacen.Name = "lbAlmacen"
        Me.lbAlmacen.Size = New System.Drawing.Size(65, 18)
        Me.lbAlmacen.TabIndex = 12
        Me.lbAlmacen.Text = "Almacen: "
        '
        'cbSucursal
        '
        Me.cbSucursal.ComboStyle = Janus.Windows.GridEX.ComboStyle.DropDownList
        cbSucursal_DesignTimeLayout.LayoutString = resources.GetString("cbSucursal_DesignTimeLayout.LayoutString")
        Me.cbSucursal.DesignTimeLayout = cbSucursal_DesignTimeLayout
        Me.cbSucursal.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbSucursal.Location = New System.Drawing.Point(325, 61)
        Me.cbSucursal.Name = "cbSucursal"
        Me.cbSucursal.SelectedIndex = -1
        Me.cbSucursal.SelectedItem = Nothing
        Me.cbSucursal.Size = New System.Drawing.Size(189, 23)
        Me.cbSucursal.TabIndex = 11
        '
        'LabelX6
        '
        '
        '
        '
        Me.LabelX6.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX6.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX6.Location = New System.Drawing.Point(260, 118)
        Me.LabelX6.Name = "LabelX6"
        Me.LabelX6.Size = New System.Drawing.Size(65, 23)
        Me.LabelX6.TabIndex = 10
        Me.LabelX6.Text = "Almacen:"
        Me.LabelX6.Visible = False
        '
        'CbAlmacen
        '
        CbAlmacen_DesignTimeLayout.LayoutString = resources.GetString("CbAlmacen_DesignTimeLayout.LayoutString")
        Me.CbAlmacen.DesignTimeLayout = CbAlmacen_DesignTimeLayout
        Me.CbAlmacen.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CbAlmacen.Location = New System.Drawing.Point(325, 119)
        Me.CbAlmacen.Name = "CbAlmacen"
        Me.CbAlmacen.SelectedIndex = -1
        Me.CbAlmacen.SelectedItem = Nothing
        Me.CbAlmacen.Size = New System.Drawing.Size(189, 23)
        Me.CbAlmacen.TabIndex = 9
        Me.CbAlmacen.Visible = False
        '
        'LabelX5
        '
        '
        '
        '
        Me.LabelX5.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX5.Location = New System.Drawing.Point(3, 92)
        Me.LabelX5.Name = "LabelX5"
        Me.LabelX5.Size = New System.Drawing.Size(94, 23)
        Me.LabelX5.TabIndex = 8
        Me.LabelX5.Text = "Tipo:"
        '
        'cbTipo
        '
        cbTipo_DesignTimeLayout.LayoutString = resources.GetString("cbTipo_DesignTimeLayout.LayoutString")
        Me.cbTipo.DesignTimeLayout = cbTipo_DesignTimeLayout
        Me.cbTipo.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbTipo.Location = New System.Drawing.Point(103, 90)
        Me.cbTipo.Name = "cbTipo"
        Me.cbTipo.SelectedIndex = -1
        Me.cbTipo.SelectedItem = Nothing
        Me.cbTipo.Size = New System.Drawing.Size(150, 23)
        Me.cbTipo.TabIndex = 7
        '
        'LabelX1
        '
        '
        '
        '
        Me.LabelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX1.Location = New System.Drawing.Point(3, 3)
        Me.LabelX1.Name = "LabelX1"
        Me.LabelX1.Size = New System.Drawing.Size(94, 23)
        Me.LabelX1.TabIndex = 0
        Me.LabelX1.Text = "Código:"
        '
        'LabelX2
        '
        '
        '
        '
        Me.LabelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX2.Location = New System.Drawing.Point(3, 32)
        Me.LabelX2.Name = "LabelX2"
        Me.LabelX2.Size = New System.Drawing.Size(94, 23)
        Me.LabelX2.TabIndex = 1
        Me.LabelX2.Text = "*Nombre:"
        '
        'LabelX3
        '
        '
        '
        '
        Me.LabelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX3.Location = New System.Drawing.Point(3, 118)
        Me.LabelX3.Name = "LabelX3"
        Me.LabelX3.Size = New System.Drawing.Size(94, 23)
        Me.LabelX3.TabIndex = 2
        Me.LabelX3.Text = "Estado:"
        '
        'LabelX4
        '
        '
        '
        '
        Me.LabelX4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX4.Location = New System.Drawing.Point(1, 63)
        Me.LabelX4.Name = "LabelX4"
        Me.LabelX4.Size = New System.Drawing.Size(94, 23)
        Me.LabelX4.TabIndex = 3
        Me.LabelX4.Text = "*Pass Movil:"
        '
        'TbCodigo
        '
        '
        '
        '
        Me.TbCodigo.Border.Class = "TextBoxBorder"
        Me.TbCodigo.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.TbCodigo.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TbCodigo.Location = New System.Drawing.Point(103, 3)
        Me.TbCodigo.Name = "TbCodigo"
        Me.TbCodigo.PreventEnterBeep = True
        Me.TbCodigo.Size = New System.Drawing.Size(80, 23)
        Me.TbCodigo.TabIndex = 0
        '
        'TbNombre
        '
        '
        '
        '
        Me.TbNombre.Border.Class = "TextBoxBorder"
        Me.TbNombre.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.TbNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TbNombre.Location = New System.Drawing.Point(103, 32)
        Me.TbNombre.MaxLength = 50
        Me.TbNombre.Name = "TbNombre"
        Me.TbNombre.PreventEnterBeep = True
        Me.TbNombre.Size = New System.Drawing.Size(350, 23)
        Me.TbNombre.TabIndex = 1
        '
        'SbEstado
        '
        '
        '
        '
        Me.SbEstado.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.SbEstado.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SbEstado.Location = New System.Drawing.Point(103, 119)
        Me.SbEstado.Name = "SbEstado"
        Me.SbEstado.OffBackColor = System.Drawing.Color.Firebrick
        Me.SbEstado.OffText = "Inactivo"
        Me.SbEstado.OnBackColor = System.Drawing.Color.Green
        Me.SbEstado.OnText = "Activo"
        Me.SbEstado.Size = New System.Drawing.Size(100, 22)
        Me.SbEstado.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.SbEstado.TabIndex = 6
        Me.SbEstado.Value = True
        Me.SbEstado.ValueObject = "Y"
        '
        'TbPassMovil
        '
        '
        '
        '
        Me.TbPassMovil.Border.Class = "TextBoxBorder"
        Me.TbPassMovil.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.TbPassMovil.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TbPassMovil.Location = New System.Drawing.Point(103, 61)
        Me.TbPassMovil.MaxLength = 20
        Me.TbPassMovil.Name = "TbPassMovil"
        Me.TbPassMovil.PreventEnterBeep = True
        Me.TbPassMovil.Size = New System.Drawing.Size(150, 23)
        Me.TbPassMovil.TabIndex = 2
        '
        'GroupPanelPreferencias
        '
        Me.GroupPanelPreferencias.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupPanelPreferencias.CanvasColor = System.Drawing.SystemColors.Control
        Me.GroupPanelPreferencias.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.GroupPanelPreferencias.Controls.Add(Me.PanelEx2)
        Me.GroupPanelPreferencias.DisabledBackColor = System.Drawing.Color.Empty
        Me.GroupPanelPreferencias.Location = New System.Drawing.Point(607, 0)
        Me.GroupPanelPreferencias.Name = "GroupPanelPreferencias"
        Me.GroupPanelPreferencias.Size = New System.Drawing.Size(329, 194)
        '
        '
        '
        Me.GroupPanelPreferencias.Style.BackColor = System.Drawing.SystemColors.Control
        Me.GroupPanelPreferencias.Style.BackColor2 = System.Drawing.SystemColors.Control
        Me.GroupPanelPreferencias.Style.BackColorGradientAngle = 90
        Me.GroupPanelPreferencias.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanelPreferencias.Style.BorderBottomWidth = 1
        Me.GroupPanelPreferencias.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.GroupPanelPreferencias.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanelPreferencias.Style.BorderLeftWidth = 1
        Me.GroupPanelPreferencias.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanelPreferencias.Style.BorderRightWidth = 1
        Me.GroupPanelPreferencias.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanelPreferencias.Style.BorderTopWidth = 1
        Me.GroupPanelPreferencias.Style.CornerDiameter = 4
        Me.GroupPanelPreferencias.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded
        Me.GroupPanelPreferencias.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center
        Me.GroupPanelPreferencias.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.GroupPanelPreferencias.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near
        '
        '
        '
        Me.GroupPanelPreferencias.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.GroupPanelPreferencias.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.GroupPanelPreferencias.TabIndex = 5
        Me.GroupPanelPreferencias.Text = "PREFERENCIAS"
        '
        'PanelEx2
        '
        Me.PanelEx2.AutoScroll = True
        Me.PanelEx2.CanvasColor = System.Drawing.SystemColors.Control
        Me.PanelEx2.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.PanelEx2.Controls.Add(Me.swModificarPedido)
        Me.PanelEx2.Controls.Add(Me.LabelX9)
        Me.PanelEx2.Controls.Add(Me.swZona)
        Me.PanelEx2.Controls.Add(Me.swPrecio)
        Me.PanelEx2.Controls.Add(Me.LabelX8)
        Me.PanelEx2.Controls.Add(Me.LabelX7)
        Me.PanelEx2.DisabledBackColor = System.Drawing.Color.Empty
        Me.PanelEx2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelEx2.Location = New System.Drawing.Point(0, 0)
        Me.PanelEx2.Name = "PanelEx2"
        Me.PanelEx2.Size = New System.Drawing.Size(323, 173)
        Me.PanelEx2.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.PanelEx2.Style.BackColor1.Color = System.Drawing.SystemColors.Control
        Me.PanelEx2.Style.BackColor2.Color = System.Drawing.SystemColors.Control
        Me.PanelEx2.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.PanelEx2.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.PanelEx2.Style.GradientAngle = 90
        Me.PanelEx2.TabIndex = 20
        '
        'swZona
        '
        '
        '
        '
        Me.swZona.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.swZona.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.swZona.Location = New System.Drawing.Point(133, 60)
        Me.swZona.Name = "swZona"
        Me.swZona.OffBackColor = System.Drawing.Color.Gold
        Me.swZona.OffText = "NO"
        Me.swZona.OnBackColor = System.Drawing.Color.LawnGreen
        Me.swZona.OnText = "SI"
        Me.swZona.Size = New System.Drawing.Size(136, 22)
        Me.swZona.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.swZona.TabIndex = 373
        Me.swZona.Value = True
        Me.swZona.ValueObject = "Y"
        '
        'swPrecio
        '
        '
        '
        '
        Me.swPrecio.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.swPrecio.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.swPrecio.Location = New System.Drawing.Point(133, 25)
        Me.swPrecio.Name = "swPrecio"
        Me.swPrecio.OffBackColor = System.Drawing.Color.Gold
        Me.swPrecio.OffText = "NO"
        Me.swPrecio.OnBackColor = System.Drawing.Color.LawnGreen
        Me.swPrecio.OnText = "SI"
        Me.swPrecio.Size = New System.Drawing.Size(136, 22)
        Me.swPrecio.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.swPrecio.TabIndex = 372
        Me.swPrecio.Value = True
        Me.swPrecio.ValueObject = "Y"
        '
        'LabelX8
        '
        '
        '
        '
        Me.LabelX8.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX8.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.LabelX8.Location = New System.Drawing.Point(22, 51)
        Me.LabelX8.Name = "LabelX8"
        Me.LabelX8.Size = New System.Drawing.Size(117, 23)
        Me.LabelX8.TabIndex = 1
        Me.LabelX8.Text = "Fijar Zona:"
        '
        'LabelX7
        '
        '
        '
        '
        Me.LabelX7.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX7.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.LabelX7.Location = New System.Drawing.Point(22, 22)
        Me.LabelX7.Name = "LabelX7"
        Me.LabelX7.Size = New System.Drawing.Size(117, 23)
        Me.LabelX7.TabIndex = 0
        Me.LabelX7.Text = "Modificar Precio:"
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 500
        '
        'swModificarPedido
        '
        '
        '
        '
        Me.swModificarPedido.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.swModificarPedido.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.swModificarPedido.Location = New System.Drawing.Point(133, 93)
        Me.swModificarPedido.Name = "swModificarPedido"
        Me.swModificarPedido.OffBackColor = System.Drawing.Color.Gold
        Me.swModificarPedido.OffText = "NO"
        Me.swModificarPedido.OnBackColor = System.Drawing.Color.LawnGreen
        Me.swModificarPedido.OnText = "SI"
        Me.swModificarPedido.Size = New System.Drawing.Size(136, 22)
        Me.swModificarPedido.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.swModificarPedido.TabIndex = 375
        Me.swModificarPedido.Value = True
        Me.swModificarPedido.ValueObject = "Y"
        '
        'LabelX9
        '
        '
        '
        '
        Me.LabelX9.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX9.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.LabelX9.Location = New System.Drawing.Point(22, 90)
        Me.LabelX9.Name = "LabelX9"
        Me.LabelX9.Size = New System.Drawing.Size(117, 23)
        Me.LabelX9.TabIndex = 374
        Me.LabelX9.Text = "Modificar Pedido:"
        '
        'F01_Personal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(984, 561)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "F01_Personal"
        Me.Opacity = 0.05R
        Me.Text = "F01_Proveedor"
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
        Me.TableLayoutPanelPrincipal.ResumeLayout(False)
        Me.Gp3Proveedores.ResumeLayout(False)
        CType(Me.Dgj1Busqueda, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelEx1.ResumeLayout(False)
        Me.GroupPanelDatosGenerales.ResumeLayout(False)
        Me.PanelExDatosGenerales.ResumeLayout(False)
        Me.PanelExDatosGenerales.PerformLayout()
        CType(Me.cbSucursal, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CbAlmacen, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbTipo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupPanelPreferencias.ResumeLayout(False)
        Me.PanelEx2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TableLayoutPanelPrincipal As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Gp3Proveedores As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents Dgj1Busqueda As Janus.Windows.GridEX.GridEX
    Friend WithEvents PanelEx1 As DevComponents.DotNetBar.PanelEx
    Friend WithEvents GroupPanelDatosGenerales As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents PanelExDatosGenerales As DevComponents.DotNetBar.PanelEx
    Friend WithEvents lbAlmacen As DevComponents.DotNetBar.LabelX
    Friend WithEvents cbSucursal As Janus.Windows.GridEX.EditControls.MultiColumnCombo
    Friend WithEvents LabelX6 As DevComponents.DotNetBar.LabelX
    Friend WithEvents CbAlmacen As Janus.Windows.GridEX.EditControls.MultiColumnCombo
    Friend WithEvents LabelX5 As DevComponents.DotNetBar.LabelX
    Friend WithEvents cbTipo As Janus.Windows.GridEX.EditControls.MultiColumnCombo
    Friend WithEvents LabelX1 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX2 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX3 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX4 As DevComponents.DotNetBar.LabelX
    Friend WithEvents TbCodigo As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents TbNombre As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents SbEstado As DevComponents.DotNetBar.Controls.SwitchButton
    Friend WithEvents TbPassMovil As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents GroupPanelPreferencias As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents PanelEx2 As DevComponents.DotNetBar.PanelEx
    Friend WithEvents LabelX8 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX7 As DevComponents.DotNetBar.LabelX
    Friend WithEvents swZona As DevComponents.DotNetBar.Controls.SwitchButton
    Friend WithEvents swPrecio As DevComponents.DotNetBar.Controls.SwitchButton
    Friend WithEvents swModificarPedido As DevComponents.DotNetBar.Controls.SwitchButton
    Friend WithEvents LabelX9 As DevComponents.DotNetBar.LabelX
End Class
