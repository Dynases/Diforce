<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class R01_SugerenciaPedidos
    Inherits Modelo.ModeloR01
    'Inherits System.Windows.Forms.Form

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
        Dim cbAlmacen_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Dim cbProveedor_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(R01_SugerenciaPedidos))
        Me.cbAlmacen = New Janus.Windows.GridEX.EditControls.MultiColumnCombo()
        Me.lbDepositoOrigen = New DevComponents.DotNetBar.LabelX()
        Me.LabelX1 = New DevComponents.DotNetBar.LabelX()
        Me.cbProveedor = New Janus.Windows.GridEX.EditControls.MultiColumnCombo()
        Me.tbAnio = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.LabelX2 = New DevComponents.DotNetBar.LabelX()
        Me.MPnSuperior.SuspendLayout()
        Me.MPnInferior.SuspendLayout()
        Me.MPanelToolBarUsuario.SuspendLayout()
        Me.MPanelToolBarAccion.SuspendLayout()
        CType(Me.MBubbleBarUsuario, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MPnUsuario.SuspendLayout()
        CType(Me.MEP, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MGpFiltro.SuspendLayout()
        CType(Me.cbAlmacen, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbProveedor, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        Me.MPnInferior.Location = New System.Drawing.Point(300, 414)
        Me.MPnInferior.Size = New System.Drawing.Size(500, 36)
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
        Me.MPanelToolBarUsuario.Location = New System.Drawing.Point(300, 0)
        '
        'MTbUsuario
        '
        Me.MTbUsuario.ReadOnly = True
        Me.MTbUsuario.Text = "DEFAULT"
        '
        'MBtSalir
        '
        '
        'MBtGenerar
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
        'MGpFiltro
        '
        Me.MGpFiltro.Controls.Add(Me.LabelX2)
        Me.MGpFiltro.Controls.Add(Me.tbAnio)
        Me.MGpFiltro.Controls.Add(Me.cbProveedor)
        Me.MGpFiltro.Controls.Add(Me.LabelX1)
        Me.MGpFiltro.Controls.Add(Me.cbAlmacen)
        Me.MGpFiltro.Controls.Add(Me.lbDepositoOrigen)
        Me.MGpFiltro.Size = New System.Drawing.Size(300, 380)
        '
        '
        '
        Me.MGpFiltro.Style.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.MGpFiltro.Style.BackColor2 = System.Drawing.Color.WhiteSmoke
        Me.MGpFiltro.Style.BackColorGradientAngle = 90
        Me.MGpFiltro.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.MGpFiltro.Style.BorderBottomWidth = 1
        Me.MGpFiltro.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.MGpFiltro.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.MGpFiltro.Style.BorderLeftWidth = 1
        Me.MGpFiltro.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.MGpFiltro.Style.BorderRightWidth = 1
        Me.MGpFiltro.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.MGpFiltro.Style.BorderTopWidth = 1
        Me.MGpFiltro.Style.CornerDiameter = 4
        Me.MGpFiltro.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded
        Me.MGpFiltro.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center
        Me.MGpFiltro.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.MGpFiltro.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near
        '
        '
        '
        Me.MGpFiltro.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.MGpFiltro.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.MGpFiltro.Controls.SetChildIndex(Me.lbDepositoOrigen, 0)
        Me.MGpFiltro.Controls.SetChildIndex(Me.cbAlmacen, 0)
        Me.MGpFiltro.Controls.SetChildIndex(Me.LabelX1, 0)
        Me.MGpFiltro.Controls.SetChildIndex(Me.cbProveedor, 0)
        Me.MGpFiltro.Controls.SetChildIndex(Me.tbAnio, 0)
        Me.MGpFiltro.Controls.SetChildIndex(Me.LabelX2, 0)
        '
        'MCrReporte
        '
        Me.MCrReporte.Size = New System.Drawing.Size(500, 450)
        '
        'cbAlmacen
        '
        Me.cbAlmacen.ComboStyle = Janus.Windows.GridEX.ComboStyle.DropDownList
        cbAlmacen_DesignTimeLayout.LayoutString = resources.GetString("cbAlmacen_DesignTimeLayout.LayoutString")
        Me.cbAlmacen.DesignTimeLayout = cbAlmacen_DesignTimeLayout
        Me.cbAlmacen.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbAlmacen.Location = New System.Drawing.Point(104, 27)
        Me.cbAlmacen.Name = "cbAlmacen"
        Me.cbAlmacen.Office2007ColorScheme = Janus.Windows.GridEX.Office2007ColorScheme.Custom
        Me.cbAlmacen.Office2007CustomColor = System.Drawing.Color.DodgerBlue
        Me.cbAlmacen.SelectedIndex = -1
        Me.cbAlmacen.SelectedItem = Nothing
        Me.cbAlmacen.Size = New System.Drawing.Size(176, 22)
        Me.cbAlmacen.TabIndex = 385
        Me.cbAlmacen.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
        '
        'lbDepositoOrigen
        '
        Me.lbDepositoOrigen.AutoSize = True
        Me.lbDepositoOrigen.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.lbDepositoOrigen.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.lbDepositoOrigen.Font = New System.Drawing.Font("Georgia", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbDepositoOrigen.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.lbDepositoOrigen.Location = New System.Drawing.Point(58, 33)
        Me.lbDepositoOrigen.Name = "lbDepositoOrigen"
        Me.lbDepositoOrigen.SingleLineColor = System.Drawing.SystemColors.Control
        Me.lbDepositoOrigen.Size = New System.Drawing.Size(36, 16)
        Me.lbDepositoOrigen.TabIndex = 386
        Me.lbDepositoOrigen.Text = "MES:"
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
        Me.LabelX1.Location = New System.Drawing.Point(3, 106)
        Me.LabelX1.Name = "LabelX1"
        Me.LabelX1.SingleLineColor = System.Drawing.SystemColors.Control
        Me.LabelX1.Size = New System.Drawing.Size(91, 16)
        Me.LabelX1.TabIndex = 387
        Me.LabelX1.Text = "PROVEEDOR:"
        '
        'cbProveedor
        '
        Me.cbProveedor.ComboStyle = Janus.Windows.GridEX.ComboStyle.DropDownList
        cbProveedor_DesignTimeLayout.LayoutString = resources.GetString("cbProveedor_DesignTimeLayout.LayoutString")
        Me.cbProveedor.DesignTimeLayout = cbProveedor_DesignTimeLayout
        Me.cbProveedor.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbProveedor.Location = New System.Drawing.Point(104, 101)
        Me.cbProveedor.Name = "cbProveedor"
        Me.cbProveedor.Office2007ColorScheme = Janus.Windows.GridEX.Office2007ColorScheme.Custom
        Me.cbProveedor.Office2007CustomColor = System.Drawing.Color.DodgerBlue
        Me.cbProveedor.SelectedIndex = -1
        Me.cbProveedor.SelectedItem = Nothing
        Me.cbProveedor.Size = New System.Drawing.Size(176, 22)
        Me.cbProveedor.TabIndex = 388
        Me.cbProveedor.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
        '
        'tbAnio
        '
        '
        '
        '
        Me.tbAnio.Border.Class = "TextBoxBorder"
        Me.tbAnio.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.tbAnio.Location = New System.Drawing.Point(104, 64)
        Me.tbAnio.Name = "tbAnio"
        Me.tbAnio.PreventEnterBeep = True
        Me.tbAnio.Size = New System.Drawing.Size(176, 21)
        Me.tbAnio.TabIndex = 389
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
        Me.LabelX2.Location = New System.Drawing.Point(58, 66)
        Me.LabelX2.Name = "LabelX2"
        Me.LabelX2.SingleLineColor = System.Drawing.SystemColors.Control
        Me.LabelX2.Size = New System.Drawing.Size(36, 16)
        Me.LabelX2.TabIndex = 390
        Me.LabelX2.Text = "AÑO:"
        '
        'R01_SugerenciaPedidos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Name = "R01_SugerenciaPedidos"
        Me.Text = "R01_SugerenciaPedidos"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Controls.SetChildIndex(Me.MPnInferior, 0)
        Me.Controls.SetChildIndex(Me.MPnUsuario, 0)
        Me.MPnSuperior.ResumeLayout(False)
        Me.MPnInferior.ResumeLayout(False)
        Me.MPanelToolBarUsuario.ResumeLayout(False)
        Me.MPanelToolBarUsuario.PerformLayout()
        Me.MPanelToolBarAccion.ResumeLayout(False)
        CType(Me.MBubbleBarUsuario, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MPnUsuario.ResumeLayout(False)
        Me.MPnUsuario.PerformLayout()
        CType(Me.MEP, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MGpFiltro.ResumeLayout(False)
        Me.MGpFiltro.PerformLayout()
        CType(Me.cbAlmacen, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbProveedor, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents cbAlmacen As Janus.Windows.GridEX.EditControls.MultiColumnCombo
    Friend WithEvents lbDepositoOrigen As DevComponents.DotNetBar.LabelX
    Friend WithEvents cbProveedor As Janus.Windows.GridEX.EditControls.MultiColumnCombo
    Friend WithEvents LabelX1 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX2 As DevComponents.DotNetBar.LabelX
    Friend WithEvents tbAnio As DevComponents.DotNetBar.Controls.TextBoxX
End Class
