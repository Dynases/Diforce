<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class F1_IngresosEgresos
    Inherits Modelo.ModeloF1

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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(F1_IngresosEgresos))
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btConcepto = New DevComponents.DotNetBar.ButtonX()
        Me.cbConcepto = New Janus.Windows.GridEX.EditControls.MultiColumnCombo()
        Me.tbMonto = New DevComponents.Editors.DoubleInput()
        Me.dpFecha = New DevComponents.Editors.DateTimeAdv.DateTimeInput()
        Me.swTipo = New DevComponents.DotNetBar.Controls.SwitchButton()
        Me.tbDescripcion = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.tbcodigo = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.LabelX15 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX14 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX13 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX11 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX10 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX8 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX7 = New DevComponents.DotNetBar.LabelX()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.tbChofer = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.btBuscarChofer = New DevComponents.DotNetBar.ButtonX()
        CType(Me.SuperTabPrincipal, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuperTabPrincipal.SuspendLayout()
        Me.SuperTabControlPanelRegistro.SuspendLayout()
        Me.PanelSuperior.SuspendLayout()
        Me.PanelInferior.SuspendLayout()
        CType(Me.BubbleBarUsuario, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelToolBar1.SuspendLayout()
        Me.PanelToolBar2.SuspendLayout()
        Me.MPanelSup.SuspendLayout()
        Me.PanelPrincipal.SuspendLayout()
        Me.GroupPanelBuscador.SuspendLayout()
        CType(Me.JGrM_Buscador, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelUsuario.SuspendLayout()
        Me.PanelNavegacion.SuspendLayout()
        Me.MPanelUserAct.SuspendLayout()
        CType(Me.MEP, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.cbConcepto, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tbMonto, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dpFecha, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SuperTabPrincipal
        '
        '
        '
        '
        '
        '
        '
        Me.SuperTabPrincipal.ControlBox.CloseBox.Name = ""
        '
        '
        '
        Me.SuperTabPrincipal.ControlBox.MenuBox.Name = ""
        Me.SuperTabPrincipal.ControlBox.Name = ""
        Me.SuperTabPrincipal.ControlBox.SubItems.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.SuperTabPrincipal.ControlBox.MenuBox, Me.SuperTabPrincipal.ControlBox.CloseBox})
        Me.SuperTabPrincipal.Controls.SetChildIndex(Me.SuperTabControlPanelBuscador, 0)
        Me.SuperTabPrincipal.Controls.SetChildIndex(Me.SuperTabControlPanelRegistro, 0)
        '
        'SuperTabControlPanelBuscador
        '
        Me.SuperTabControlPanelBuscador.Location = New System.Drawing.Point(0, 0)
        Me.SuperTabControlPanelBuscador.Size = New System.Drawing.Size(821, 507)
        '
        'SuperTabControlPanelRegistro
        '
        Me.SuperTabControlPanelRegistro.Size = New System.Drawing.Size(821, 507)
        Me.SuperTabControlPanelRegistro.Controls.SetChildIndex(Me.PanelSuperior, 0)
        Me.SuperTabControlPanelRegistro.Controls.SetChildIndex(Me.PanelInferior, 0)
        Me.SuperTabControlPanelRegistro.Controls.SetChildIndex(Me.PanelPrincipal, 0)
        '
        'PanelSuperior
        '
        Me.PanelSuperior.Size = New System.Drawing.Size(821, 72)
        Me.PanelSuperior.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.PanelSuperior.Style.BackColor1.Color = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(127, Byte), Integer))
        Me.PanelSuperior.Style.BackColor2.Color = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(127, Byte), Integer))
        Me.PanelSuperior.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.PanelSuperior.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.PanelSuperior.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.PanelSuperior.Style.GradientAngle = 90
        '
        'PanelInferior
        '
        Me.PanelInferior.Size = New System.Drawing.Size(821, 36)
        Me.PanelInferior.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.PanelInferior.Style.BackColor1.Color = System.Drawing.Color.Gray
        Me.PanelInferior.Style.BackColor2.Color = System.Drawing.SystemColors.ActiveCaption
        Me.PanelInferior.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.PanelInferior.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.PanelInferior.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.PanelInferior.Style.GradientAngle = 90
        '
        'BubbleBarUsuario
        '
        '
        '
        '
        Me.BubbleBarUsuario.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.BubbleBarUsuario.ButtonBackAreaStyle.BackColor = System.Drawing.Color.Transparent
        Me.BubbleBarUsuario.ButtonBackAreaStyle.BorderBottomWidth = 1
        Me.BubbleBarUsuario.ButtonBackAreaStyle.BorderColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.BubbleBarUsuario.ButtonBackAreaStyle.BorderLeftWidth = 1
        Me.BubbleBarUsuario.ButtonBackAreaStyle.BorderRightWidth = 1
        Me.BubbleBarUsuario.ButtonBackAreaStyle.BorderTopWidth = 1
        Me.BubbleBarUsuario.ButtonBackAreaStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.BubbleBarUsuario.ButtonBackAreaStyle.PaddingBottom = 3
        Me.BubbleBarUsuario.ButtonBackAreaStyle.PaddingLeft = 3
        Me.BubbleBarUsuario.ButtonBackAreaStyle.PaddingRight = 3
        Me.BubbleBarUsuario.ButtonBackAreaStyle.PaddingTop = 3
        Me.BubbleBarUsuario.MouseOverTabColors.BorderColor = System.Drawing.SystemColors.Highlight
        Me.BubbleBarUsuario.SelectedTabColors.BorderColor = System.Drawing.Color.Black
        '
        'btnSalir
        '
        '
        'btnModificar
        '
        '
        'btnNuevo
        '
        '
        'PanelToolBar2
        '
        Me.PanelToolBar2.Location = New System.Drawing.Point(741, 0)
        '
        'MPanelSup
        '
        Me.MPanelSup.Controls.Add(Me.Panel2)
        Me.MPanelSup.Size = New System.Drawing.Size(821, 184)
        Me.MPanelSup.Controls.SetChildIndex(Me.PanelUsuario, 0)
        Me.MPanelSup.Controls.SetChildIndex(Me.Panel2, 0)
        '
        'PanelPrincipal
        '
        Me.PanelPrincipal.Size = New System.Drawing.Size(821, 399)
        '
        'GroupPanelBuscador
        '
        Me.GroupPanelBuscador.Size = New System.Drawing.Size(821, 215)
        '
        '
        '
        Me.GroupPanelBuscador.Style.BackColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(127, Byte), Integer))
        Me.GroupPanelBuscador.Style.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(127, Byte), Integer))
        Me.GroupPanelBuscador.Style.BackColorGradientAngle = 90
        Me.GroupPanelBuscador.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanelBuscador.Style.BorderBottomWidth = 1
        Me.GroupPanelBuscador.Style.BorderColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(127, Byte), Integer))
        Me.GroupPanelBuscador.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanelBuscador.Style.BorderLeftWidth = 1
        Me.GroupPanelBuscador.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanelBuscador.Style.BorderRightWidth = 1
        Me.GroupPanelBuscador.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanelBuscador.Style.BorderTopWidth = 1
        Me.GroupPanelBuscador.Style.CornerDiameter = 4
        Me.GroupPanelBuscador.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded
        Me.GroupPanelBuscador.Style.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupPanelBuscador.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center
        Me.GroupPanelBuscador.Style.TextColor = System.Drawing.Color.White
        Me.GroupPanelBuscador.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near
        '
        '
        '
        Me.GroupPanelBuscador.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.GroupPanelBuscador.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        'JGrM_Buscador
        '
        Me.JGrM_Buscador.HeaderFormatStyle.Font = New System.Drawing.Font("Georgia", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.JGrM_Buscador.HeaderFormatStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(127, Byte), Integer))
        Me.JGrM_Buscador.SelectedFormatStyle.BackColor = System.Drawing.Color.DodgerBlue
        Me.JGrM_Buscador.SelectedFormatStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.JGrM_Buscador.SelectedFormatStyle.ForeColor = System.Drawing.Color.White
        Me.JGrM_Buscador.Size = New System.Drawing.Size(815, 192)
        '
        'MPanelUserAct
        '
        Me.MPanelUserAct.Location = New System.Drawing.Point(621, 0)
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.btBuscarChofer)
        Me.Panel2.Controls.Add(Me.tbChofer)
        Me.Panel2.Controls.Add(Me.btConcepto)
        Me.Panel2.Controls.Add(Me.cbConcepto)
        Me.Panel2.Controls.Add(Me.tbMonto)
        Me.Panel2.Controls.Add(Me.dpFecha)
        Me.Panel2.Controls.Add(Me.swTipo)
        Me.Panel2.Controls.Add(Me.tbDescripcion)
        Me.Panel2.Controls.Add(Me.tbcodigo)
        Me.Panel2.Controls.Add(Me.LabelX15)
        Me.Panel2.Controls.Add(Me.LabelX14)
        Me.Panel2.Controls.Add(Me.LabelX13)
        Me.Panel2.Controls.Add(Me.LabelX11)
        Me.Panel2.Controls.Add(Me.LabelX10)
        Me.Panel2.Controls.Add(Me.LabelX8)
        Me.Panel2.Controls.Add(Me.LabelX7)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(821, 184)
        Me.Panel2.TabIndex = 20
        '
        'btConcepto
        '
        Me.btConcepto.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btConcepto.BackColor = System.Drawing.Color.Transparent
        Me.btConcepto.ColorTable = DevComponents.DotNetBar.eButtonColor.Flat
        Me.btConcepto.Image = Global.Presentacion.My.Resources.Resources.add
        Me.btConcepto.ImageFixedSize = New System.Drawing.Size(25, 23)
        Me.btConcepto.Location = New System.Drawing.Point(722, 14)
        Me.btConcepto.Name = "btConcepto"
        Me.btConcepto.Size = New System.Drawing.Size(39, 23)
        Me.btConcepto.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btConcepto.TabIndex = 17
        '
        'cbConcepto
        '
        Me.cbConcepto.DataSource = Me.btnImprimir.SubItems
        cbConcepto_DesignTimeLayout.LayoutString = resources.GetString("cbConcepto_DesignTimeLayout.LayoutString")
        Me.cbConcepto.DesignTimeLayout = cbConcepto_DesignTimeLayout
        Me.cbConcepto.Location = New System.Drawing.Point(534, 17)
        Me.cbConcepto.Name = "cbConcepto"
        Me.cbConcepto.SelectedIndex = -1
        Me.cbConcepto.SelectedItem = Nothing
        Me.cbConcepto.Size = New System.Drawing.Size(182, 20)
        Me.cbConcepto.TabIndex = 16
        Me.cbConcepto.UseCompatibleTextRendering = True
        Me.cbConcepto.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
        '
        'tbMonto
        '
        '
        '
        '
        Me.tbMonto.BackgroundStyle.Class = "DateTimeInputBackground"
        Me.tbMonto.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.tbMonto.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2
        Me.tbMonto.Increment = 1.0R
        Me.tbMonto.Location = New System.Drawing.Point(534, 54)
        Me.tbMonto.Name = "tbMonto"
        Me.tbMonto.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.tbMonto.Size = New System.Drawing.Size(182, 20)
        Me.tbMonto.TabIndex = 15
        '
        'dpFecha
        '
        '
        '
        '
        Me.dpFecha.BackgroundStyle.Class = "DateTimeInputBackground"
        Me.dpFecha.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.dpFecha.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown
        Me.dpFecha.ButtonDropDown.Visible = True
        Me.dpFecha.IsPopupCalendarOpen = False
        Me.dpFecha.Location = New System.Drawing.Point(144, 51)
        '
        '
        '
        '
        '
        '
        Me.dpFecha.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.dpFecha.MonthCalendar.CalendarDimensions = New System.Drawing.Size(1, 1)
        Me.dpFecha.MonthCalendar.ClearButtonVisible = True
        '
        '
        '
        Me.dpFecha.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2
        Me.dpFecha.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90
        Me.dpFecha.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground
        Me.dpFecha.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.dpFecha.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder
        Me.dpFecha.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1
        Me.dpFecha.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.dpFecha.MonthCalendar.DisplayMonth = New Date(2023, 12, 1, 0, 0, 0, 0)
        Me.dpFecha.MonthCalendar.FirstDayOfWeek = System.DayOfWeek.Monday
        '
        '
        '
        Me.dpFecha.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.dpFecha.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90
        Me.dpFecha.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.dpFecha.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.dpFecha.MonthCalendar.TodayButtonVisible = True
        Me.dpFecha.Name = "dpFecha"
        Me.dpFecha.Size = New System.Drawing.Size(100, 20)
        Me.dpFecha.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.dpFecha.TabIndex = 13
        '
        'swTipo
        '
        '
        '
        '
        Me.swTipo.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.swTipo.Location = New System.Drawing.Point(144, 92)
        Me.swTipo.Name = "swTipo"
        Me.swTipo.OffBackColor = System.Drawing.Color.MediumSeaGreen
        Me.swTipo.OffText = "EGRESOS"
        Me.swTipo.OnBackColor = System.Drawing.Color.DarkOrange
        Me.swTipo.OnText = "INGRESOS"
        Me.swTipo.Size = New System.Drawing.Size(169, 22)
        Me.swTipo.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.swTipo.TabIndex = 12
        '
        'tbDescripcion
        '
        '
        '
        '
        Me.tbDescripcion.Border.Class = "TextBoxBorder"
        Me.tbDescripcion.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.tbDescripcion.Location = New System.Drawing.Point(533, 92)
        Me.tbDescripcion.Multiline = True
        Me.tbDescripcion.Name = "tbDescripcion"
        Me.tbDescripcion.PreventEnterBeep = True
        Me.tbDescripcion.Size = New System.Drawing.Size(228, 55)
        Me.tbDescripcion.TabIndex = 11
        '
        'tbcodigo
        '
        '
        '
        '
        Me.tbcodigo.Border.Class = "TextBoxBorder"
        Me.tbcodigo.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.tbcodigo.Location = New System.Drawing.Point(144, 17)
        Me.tbcodigo.Name = "tbcodigo"
        Me.tbcodigo.PreventEnterBeep = True
        Me.tbcodigo.Size = New System.Drawing.Size(100, 20)
        Me.tbcodigo.TabIndex = 9
        '
        'LabelX15
        '
        '
        '
        '
        Me.LabelX15.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX15.Font = New System.Drawing.Font("Georgia", 9.0!, System.Drawing.FontStyle.Bold)
        Me.LabelX15.Location = New System.Drawing.Point(399, 51)
        Me.LabelX15.Name = "LabelX15"
        Me.LabelX15.Size = New System.Drawing.Size(75, 23)
        Me.LabelX15.TabIndex = 8
        Me.LabelX15.Text = "Monto Bs:"
        '
        'LabelX14
        '
        '
        '
        '
        Me.LabelX14.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX14.Font = New System.Drawing.Font("Georgia", 9.0!, System.Drawing.FontStyle.Bold)
        Me.LabelX14.Location = New System.Drawing.Point(398, 16)
        Me.LabelX14.Name = "LabelX14"
        Me.LabelX14.Size = New System.Drawing.Size(75, 23)
        Me.LabelX14.TabIndex = 7
        Me.LabelX14.Text = "Concepto:"
        '
        'LabelX13
        '
        '
        '
        '
        Me.LabelX13.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX13.Font = New System.Drawing.Font("Georgia", 9.0!, System.Drawing.FontStyle.Bold)
        Me.LabelX13.Location = New System.Drawing.Point(43, 14)
        Me.LabelX13.Name = "LabelX13"
        Me.LabelX13.Size = New System.Drawing.Size(75, 23)
        Me.LabelX13.TabIndex = 6
        Me.LabelX13.Text = "Código:"
        '
        'LabelX11
        '
        '
        '
        '
        Me.LabelX11.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX11.Font = New System.Drawing.Font("Georgia", 9.0!, System.Drawing.FontStyle.Bold)
        Me.LabelX11.Location = New System.Drawing.Point(43, 48)
        Me.LabelX11.Name = "LabelX11"
        Me.LabelX11.Size = New System.Drawing.Size(75, 23)
        Me.LabelX11.TabIndex = 4
        Me.LabelX11.Text = "Fecha:"
        '
        'LabelX10
        '
        '
        '
        '
        Me.LabelX10.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX10.Font = New System.Drawing.Font("Georgia", 9.0!, System.Drawing.FontStyle.Bold)
        Me.LabelX10.Location = New System.Drawing.Point(43, 89)
        Me.LabelX10.Name = "LabelX10"
        Me.LabelX10.Size = New System.Drawing.Size(75, 23)
        Me.LabelX10.TabIndex = 3
        Me.LabelX10.Text = "Tipo"
        '
        'LabelX8
        '
        '
        '
        '
        Me.LabelX8.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX8.Font = New System.Drawing.Font("Georgia", 9.0!, System.Drawing.FontStyle.Bold)
        Me.LabelX8.Location = New System.Drawing.Point(399, 89)
        Me.LabelX8.Name = "LabelX8"
        Me.LabelX8.Size = New System.Drawing.Size(95, 23)
        Me.LabelX8.TabIndex = 2
        Me.LabelX8.Text = "Descripción:"
        '
        'LabelX7
        '
        '
        '
        '
        Me.LabelX7.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX7.Font = New System.Drawing.Font("Georgia", 9.0!, System.Drawing.FontStyle.Bold)
        Me.LabelX7.Location = New System.Drawing.Point(43, 124)
        Me.LabelX7.Name = "LabelX7"
        Me.LabelX7.Size = New System.Drawing.Size(75, 23)
        Me.LabelX7.TabIndex = 0
        Me.LabelX7.Text = "Repartidor:"
        '
        'Timer1
        '
        '
        'tbChofer
        '
        '
        '
        '
        Me.tbChofer.Border.Class = "TextBoxBorder"
        Me.tbChofer.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.tbChofer.Location = New System.Drawing.Point(144, 127)
        Me.tbChofer.Name = "tbChofer"
        Me.tbChofer.PreventEnterBeep = True
        Me.tbChofer.Size = New System.Drawing.Size(169, 20)
        Me.tbChofer.TabIndex = 18
        '
        'btBuscarChofer
        '
        Me.btBuscarChofer.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btBuscarChofer.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btBuscarChofer.Image = Global.Presentacion.My.Resources.Resources.buscar
        Me.btBuscarChofer.ImageFixedSize = New System.Drawing.Size(23, 23)
        Me.btBuscarChofer.Location = New System.Drawing.Point(319, 123)
        Me.btBuscarChofer.Name = "btBuscarChofer"
        Me.btBuscarChofer.Size = New System.Drawing.Size(40, 24)
        Me.btBuscarChofer.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btBuscarChofer.TabIndex = 19
        '
        'F1_IngresosEgresos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(853, 507)
        Me.Name = "F1_IngresosEgresos"
        Me.Controls.SetChildIndex(Me.SuperTabPrincipal, 0)
        CType(Me.SuperTabPrincipal, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SuperTabPrincipal.ResumeLayout(False)
        Me.SuperTabControlPanelRegistro.ResumeLayout(False)
        Me.PanelSuperior.ResumeLayout(False)
        Me.PanelInferior.ResumeLayout(False)
        CType(Me.BubbleBarUsuario, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelToolBar1.ResumeLayout(False)
        Me.PanelToolBar2.ResumeLayout(False)
        Me.MPanelSup.ResumeLayout(False)
        Me.PanelPrincipal.ResumeLayout(False)
        Me.GroupPanelBuscador.ResumeLayout(False)
        CType(Me.JGrM_Buscador, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelUsuario.ResumeLayout(False)
        Me.PanelUsuario.PerformLayout()
        Me.PanelNavegacion.ResumeLayout(False)
        Me.MPanelUserAct.ResumeLayout(False)
        Me.MPanelUserAct.PerformLayout()
        CType(Me.MEP, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.cbConcepto, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tbMonto, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dpFecha, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents GroupPanel1 As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents LabelX5 As DevComponents.DotNetBar.LabelX
    Friend WithEvents tbObservacion As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LabelX1 As DevComponents.DotNetBar.LabelX
    ' Friend WithEvents tbcodigo As DevComponents.DotNetBar.Controls.TextBoxX
    'Friend WithEvents LabelX2 As DevComponents.DotNetBar.LabelX
    'Friend WithEvents tbDescripcion As DevComponents.DotNetBar.Controls.TextBoxX
    'Friend WithEvents LabelX3 As DevComponents.DotNetBar.LabelX
    'Friend WithEvents swTipo As DevComponents.DotNetBar.Controls.SwitchButton
    'Friend WithEvents LabelX9 As DevComponents.DotNetBar.LabelX
    'Friend WithEvents LabelX16 As DevComponents.DotNetBar.LabelX
    'Friend WithEvents dpFecha As DateTimePicker
    'Friend WithEvents lbgrupo1 As DevComponents.DotNetBar.LabelX
    'Friend WithEvents cbConcepto As Janus.Windows.GridEX.EditControls.MultiColumnCombo
    'Friend WithEvents tbMonto As DevComponents.Editors.DoubleInput
    'Friend WithEvents Timer1 As Timer
    'Friend WithEvents btConcepto As DevComponents.DotNetBar.ButtonX
    'Friend WithEvents LabelX4 As DevComponents.DotNetBar.LabelX
    'Friend WithEvents tbIdCaja As DevComponents.DotNetBar.Controls.TextBoxX
    'Friend WithEvents lbNroCaja As Label
    'Friend WithEvents LabelX6 As DevComponents.DotNetBar.LabelX
    'Friend WithEvents LabelX17 As DevComponents.DotNetBar.LabelX
    'Friend WithEvents cbSucursal As Janus.Windows.GridEX.EditControls.MultiColumnCombo
    'Friend WithEvents btnBuscarDevolución As DevComponents.DotNetBar.ButtonX
    'Friend WithEvents lbDevolucion As DevComponents.DotNetBar.LabelX
    'Friend WithEvents tbIdDevolucion As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents GroupPanel3 As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents Panel10 As Panel
    Friend WithEvents grDevolucion As Janus.Windows.GridEX.GridEX
    Friend WithEvents LabelX7 As DevComponents.DotNetBar.LabelX
    Public WithEvents Panel2 As Panel
    Friend WithEvents cbConcepto As Janus.Windows.GridEX.EditControls.MultiColumnCombo
    Friend WithEvents tbMonto As DevComponents.Editors.DoubleInput
    Friend WithEvents dpFecha As DevComponents.Editors.DateTimeAdv.DateTimeInput
    Friend WithEvents swTipo As DevComponents.DotNetBar.Controls.SwitchButton
    Public WithEvents tbDescripcion As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents tbcodigo As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LabelX15 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX14 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX13 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX11 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX10 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX8 As DevComponents.DotNetBar.LabelX
    Friend WithEvents Timer1 As Timer
    Friend WithEvents btConcepto As DevComponents.DotNetBar.ButtonX
    Friend WithEvents tbChofer As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents btBuscarChofer As DevComponents.DotNetBar.ButtonX
End Class
