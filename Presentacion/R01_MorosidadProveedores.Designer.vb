<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class R01_MorosidadProveedores
    Inherits Modelo.ModeloR01

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
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.tbProveedor = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.CheckTodosProveedor = New DevComponents.DotNetBar.Controls.CheckBoxX()
        Me.checkUnProveedor = New DevComponents.DotNetBar.Controls.CheckBoxX()
        Me.tbCodigoProveedor = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.LabelX2 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX1 = New DevComponents.DotNetBar.LabelX()
        Me.MPnSuperior.SuspendLayout()
        Me.MPnInferior.SuspendLayout()
        Me.MPanelToolBarUsuario.SuspendLayout()
        Me.MPanelToolBarAccion.SuspendLayout()
        CType(Me.MBubbleBarUsuario, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MPnUsuario.SuspendLayout()
        CType(Me.MEP, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MGpFiltro.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
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
        Me.MPnInferior.Location = New System.Drawing.Point(300, 665)
        Me.MPnInferior.Size = New System.Drawing.Size(934, 36)
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
        Me.MPanelToolBarUsuario.Location = New System.Drawing.Point(734, 0)
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
        Me.MGpFiltro.Controls.Add(Me.GroupBox2)
        Me.MGpFiltro.Size = New System.Drawing.Size(300, 631)
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
        Me.MGpFiltro.Controls.SetChildIndex(Me.GroupBox2, 0)
        '
        'MCrReporte
        '
        Me.MCrReporte.Size = New System.Drawing.Size(934, 701)
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.LabelX1)
        Me.GroupBox2.Controls.Add(Me.tbProveedor)
        Me.GroupBox2.Controls.Add(Me.CheckTodosProveedor)
        Me.GroupBox2.Controls.Add(Me.checkUnProveedor)
        Me.GroupBox2.Controls.Add(Me.tbCodigoProveedor)
        Me.GroupBox2.Controls.Add(Me.LabelX2)
        Me.GroupBox2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox2.Font = New System.Drawing.Font("Georgia", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(294, 539)
        Me.GroupBox2.TabIndex = 12
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Datos"
        '
        'tbProveedor
        '
        Me.tbProveedor.BackColor = System.Drawing.Color.Gainsboro
        '
        '
        '
        Me.tbProveedor.Border.Class = "TextBoxBorder"
        Me.tbProveedor.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.tbProveedor.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbProveedor.ForeColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(59, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.tbProveedor.Location = New System.Drawing.Point(9, 49)
        Me.tbProveedor.Name = "tbProveedor"
        Me.tbProveedor.PreventEnterBeep = True
        Me.tbProveedor.Size = New System.Drawing.Size(167, 22)
        Me.tbProveedor.TabIndex = 245
        '
        'CheckTodosProveedor
        '
        '
        '
        '
        Me.CheckTodosProveedor.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.CheckTodosProveedor.Location = New System.Drawing.Point(233, 48)
        Me.CheckTodosProveedor.Name = "CheckTodosProveedor"
        Me.CheckTodosProveedor.Size = New System.Drawing.Size(55, 23)
        Me.CheckTodosProveedor.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.CheckTodosProveedor.TabIndex = 239
        Me.CheckTodosProveedor.Text = "Todos"
        '
        'checkUnProveedor
        '
        '
        '
        '
        Me.checkUnProveedor.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.checkUnProveedor.Location = New System.Drawing.Point(185, 47)
        Me.checkUnProveedor.Name = "checkUnProveedor"
        Me.checkUnProveedor.Size = New System.Drawing.Size(44, 23)
        Me.checkUnProveedor.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.checkUnProveedor.TabIndex = 1
        Me.checkUnProveedor.Text = "Una"
        '
        'tbCodigoProveedor
        '
        '
        '
        '
        Me.tbCodigoProveedor.Border.Class = "TextBoxBorder"
        Me.tbCodigoProveedor.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.tbCodigoProveedor.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbCodigoProveedor.ForeColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(59, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.tbCodigoProveedor.Location = New System.Drawing.Point(89, 22)
        Me.tbCodigoProveedor.Name = "tbCodigoProveedor"
        Me.tbCodigoProveedor.PreventEnterBeep = True
        Me.tbCodigoProveedor.Size = New System.Drawing.Size(22, 22)
        Me.tbCodigoProveedor.TabIndex = 238
        Me.tbCodigoProveedor.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.tbCodigoProveedor.Visible = False
        '
        'LabelX2
        '
        Me.LabelX2.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.LabelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX2.Font = New System.Drawing.Font("Georgia", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.LabelX2.Location = New System.Drawing.Point(9, 21)
        Me.LabelX2.Name = "LabelX2"
        Me.LabelX2.SingleLineColor = System.Drawing.SystemColors.Control
        Me.LabelX2.Size = New System.Drawing.Size(74, 23)
        Me.LabelX2.TabIndex = 236
        Me.LabelX2.Text = "Proveedor:"
        '
        'LabelX1
        '
        Me.LabelX1.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.LabelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX1.Font = New System.Drawing.Font("Georgia", 7.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.LabelX1.Location = New System.Drawing.Point(123, 32)
        Me.LabelX1.Name = "LabelX1"
        Me.LabelX1.SingleLineColor = System.Drawing.SystemColors.Control
        Me.LabelX1.Size = New System.Drawing.Size(58, 15)
        Me.LabelX1.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2013
        Me.LabelX1.TabIndex = 246
        Me.LabelX1.Text = "Ctrl+Enter"
        '
        'R01_MorosidadProveedores
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1234, 701)
        Me.Name = "R01_MorosidadProveedores"
        Me.Text = "R01_MorosidadProveedores"
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
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents tbProveedor As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents CheckTodosProveedor As DevComponents.DotNetBar.Controls.CheckBoxX
    Friend WithEvents checkUnProveedor As DevComponents.DotNetBar.Controls.CheckBoxX
    Friend WithEvents tbCodigoProveedor As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LabelX2 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX1 As DevComponents.DotNetBar.LabelX
End Class
