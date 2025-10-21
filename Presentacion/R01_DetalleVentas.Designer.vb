<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class R01_DetalleVentas
    Inherits System.Windows.Forms.Form

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
        Dim cbRepartidor_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(R01_DetalleVentas))
        Me.SuperTabControl1 = New DevComponents.DotNetBar.SuperTabControl()
        Me.SuperTabControlPanel2 = New DevComponents.DotNetBar.SuperTabControlPanel()
        Me.CrystalReportViewer1 = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.SuperTabItem2 = New DevComponents.DotNetBar.SuperTabItem()
        Me.PanelEx1 = New DevComponents.DotNetBar.PanelEx()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.PanelEx3 = New DevComponents.DotNetBar.PanelEx()
        Me.ButtonX1 = New DevComponents.DotNetBar.ButtonX()
        Me.btGenerar = New DevComponents.DotNetBar.ButtonX()
        Me.PanelEx4 = New DevComponents.DotNetBar.PanelEx()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Tb_Fecha = New DevComponents.Editors.DateTimeAdv.DateTimeInput()
        Me.cbRepartidor = New Janus.Windows.GridEX.EditControls.MultiColumnCombo()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.ColorDialogZona = New System.Windows.Forms.ColorDialog()
        CType(Me.SuperTabControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuperTabControl1.SuspendLayout()
        Me.SuperTabControlPanel2.SuspendLayout()
        Me.PanelEx1.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.PanelEx3.SuspendLayout()
        Me.PanelEx4.SuspendLayout()
        CType(Me.Tb_Fecha, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbRepartidor, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel1.SuspendLayout()
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
        Me.SuperTabControl1.Tabs.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.SuperTabItem2})
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
        Me.TableLayoutPanel2.Controls.Add(Me.PanelEx3, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.PanelEx4, 0, 1)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 2
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 120.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 250.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(314, 647)
        Me.TableLayoutPanel2.TabIndex = 237
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
        Me.PanelEx4.Controls.Add(Me.Label2)
        Me.PanelEx4.Controls.Add(Me.Label1)
        Me.PanelEx4.Controls.Add(Me.Tb_Fecha)
        Me.PanelEx4.Controls.Add(Me.cbRepartidor)
        Me.PanelEx4.DisabledBackColor = System.Drawing.Color.Empty
        Me.PanelEx4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelEx4.Location = New System.Drawing.Point(3, 123)
        Me.PanelEx4.Name = "PanelEx4"
        Me.PanelEx4.Size = New System.Drawing.Size(308, 521)
        Me.PanelEx4.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.PanelEx4.Style.BackColor1.Color = System.Drawing.SystemColors.ActiveCaption
        Me.PanelEx4.Style.BackColor2.Color = System.Drawing.Color.WhiteSmoke
        Me.PanelEx4.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.PanelEx4.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.PanelEx4.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.PanelEx4.Style.GradientAngle = 90
        Me.PanelEx4.TabIndex = 14
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(49, Byte), Integer), CType(CType(59, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(16, 87)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(55, 18)
        Me.Label2.TabIndex = 234
        Me.Label2.Text = "Fecha:"
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
        Me.Tb_Fecha.Location = New System.Drawing.Point(54, 119)
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
        'R01_DetalleVentas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1063, 653)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Name = "R01_DetalleVentas"
        Me.Text = "DETALLE DE VENTAS"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.SuperTabControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SuperTabControl1.ResumeLayout(False)
        Me.SuperTabControlPanel2.ResumeLayout(False)
        Me.SuperTabControlPanel2.PerformLayout()
        Me.PanelEx1.ResumeLayout(False)
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.PanelEx3.ResumeLayout(False)
        Me.PanelEx4.ResumeLayout(False)
        Me.PanelEx4.PerformLayout()
        CType(Me.Tb_Fecha, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbRepartidor, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents SuperTabControl1 As DevComponents.DotNetBar.SuperTabControl
    Friend WithEvents PanelEx1 As DevComponents.DotNetBar.PanelEx
    Friend WithEvents Label1 As Label
    Friend WithEvents cbRepartidor As Janus.Windows.GridEX.EditControls.MultiColumnCombo
    Friend WithEvents Tb_Fecha As DevComponents.Editors.DateTimeAdv.DateTimeInput
    Friend WithEvents SuperTabControlPanel2 As DevComponents.DotNetBar.SuperTabControlPanel
    Friend WithEvents CrystalReportViewer1 As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents SuperTabItem2 As DevComponents.DotNetBar.SuperTabItem
    Friend WithEvents btGenerar As DevComponents.DotNetBar.ButtonX
    Friend WithEvents ButtonX1 As DevComponents.DotNetBar.ButtonX
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents PanelEx3 As DevComponents.DotNetBar.PanelEx
    Friend WithEvents PanelEx4 As DevComponents.DotNetBar.PanelEx
    Friend WithEvents ColorDialogZona As ColorDialog
    Friend WithEvents Label2 As Label
End Class
