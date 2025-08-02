<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class F03_ImportarInventario
    Inherits Modelo.ModeloF03
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
        Me.MPanelSup = New System.Windows.Forms.Panel()
        Me.GroupPanel1 = New DevComponents.DotNetBar.Controls.GroupPanel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.MPanelToolBarAccion = New System.Windows.Forms.Panel()
        Me.btnImportar = New DevComponents.DotNetBar.ButtonX()
        Me.BtnSalir1 = New DevComponents.DotNetBar.ButtonX()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.PanelSuperior.SuspendLayout()
        Me.PanelInferior.SuspendLayout()
        CType(Me.BubbleBarUsuario, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelToolBar1.SuspendLayout()
        Me.PanelToolBar2.SuspendLayout()
        Me.PanelPrincipal.SuspendLayout()
        Me.PanelUsuario.SuspendLayout()
        Me.PanelNavegacion.SuspendLayout()
        Me.MPanelUserAct.SuspendLayout()
        CType(Me.MEP, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelContent.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.MSuperTabControlPanel1.SuspendLayout()
        CType(Me.MSuperTabControl, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MSuperTabControl.SuspendLayout()
        Me.MPanelSup.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.MPanelToolBarAccion.SuspendLayout()
        Me.SuspendLayout()
        '
        'PanelSuperior
        '
        Me.PanelSuperior.Controls.Add(Me.MPanelToolBarAccion)
        Me.PanelSuperior.Size = New System.Drawing.Size(891, 72)
        Me.PanelSuperior.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.PanelSuperior.Style.BackColor1.Color = System.Drawing.Color.Gray
        Me.PanelSuperior.Style.BackColor2.Color = System.Drawing.SystemColors.ActiveCaption
        Me.PanelSuperior.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.PanelSuperior.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.PanelSuperior.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.PanelSuperior.Style.GradientAngle = 90
        Me.PanelSuperior.Controls.SetChildIndex(Me.PanelToolBar2, 0)
        Me.PanelSuperior.Controls.SetChildIndex(Me.PanelToolBar1, 0)
        Me.PanelSuperior.Controls.SetChildIndex(Me.MPanelToolBarAccion, 0)
        '
        'PanelInferior
        '
        Me.PanelInferior.Location = New System.Drawing.Point(0, 177)
        Me.PanelInferior.Size = New System.Drawing.Size(891, 39)
        Me.PanelInferior.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.PanelInferior.Style.BackColor1.Color = System.Drawing.Color.Gray
        Me.PanelInferior.Style.BackColor2.Color = System.Drawing.SystemColors.ActiveCaption
        Me.PanelInferior.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.PanelInferior.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.PanelInferior.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.PanelInferior.Style.GradientAngle = 90
        Me.PanelInferior.Visible = False
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
        'TxtNombreUsu
        '
        Me.TxtNombreUsu.ReadOnly = True
        Me.TxtNombreUsu.Text = "DEFAULT"
        '
        'PanelToolBar1
        '
        Me.PanelToolBar1.Visible = False
        '
        'PanelToolBar2
        '
        Me.PanelToolBar2.Location = New System.Drawing.Point(811, 0)
        Me.PanelToolBar2.Visible = False
        '
        'PanelPrincipal
        '
        Me.PanelPrincipal.Size = New System.Drawing.Size(891, 216)
        Me.PanelPrincipal.Controls.SetChildIndex(Me.PanelInferior, 0)
        Me.PanelPrincipal.Controls.SetChildIndex(Me.PanelUsuario, 0)
        Me.PanelPrincipal.Controls.SetChildIndex(Me.PanelSuperior, 0)
        Me.PanelPrincipal.Controls.SetChildIndex(Me.Panel1, 0)
        '
        'MPanelUserAct
        '
        Me.MPanelUserAct.Location = New System.Drawing.Point(691, 0)
        '
        'PanelContent
        '
        Me.PanelContent.Controls.Add(Me.MPanelSup)
        Me.PanelContent.Size = New System.Drawing.Size(858, 105)
        '
        'Panel1
        '
        Me.Panel1.Size = New System.Drawing.Size(891, 105)
        '
        'MSuperTabControlPanel1
        '
        Me.MSuperTabControlPanel1.Size = New System.Drawing.Size(858, 105)
        '
        'MSuperTabControl
        '
        '
        '
        '
        '
        '
        '
        Me.MSuperTabControl.ControlBox.CloseBox.Name = ""
        '
        '
        '
        Me.MSuperTabControl.ControlBox.MenuBox.Name = ""
        Me.MSuperTabControl.ControlBox.Name = ""
        Me.MSuperTabControl.ControlBox.SubItems.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.MSuperTabControl.ControlBox.MenuBox, Me.MSuperTabControl.ControlBox.CloseBox})
        Me.MSuperTabControl.Size = New System.Drawing.Size(891, 105)
        Me.MSuperTabControl.Controls.SetChildIndex(Me.MSuperTabControlPanel1, 0)
        '
        'MPanelSup
        '
        Me.MPanelSup.BackColor = System.Drawing.Color.White
        Me.MPanelSup.Controls.Add(Me.GroupPanel1)
        Me.MPanelSup.Controls.Add(Me.Panel2)
        Me.MPanelSup.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MPanelSup.Location = New System.Drawing.Point(0, 0)
        Me.MPanelSup.Name = "MPanelSup"
        Me.MPanelSup.Size = New System.Drawing.Size(858, 105)
        Me.MPanelSup.TabIndex = 2
        '
        'GroupPanel1
        '
        Me.GroupPanel1.CanvasColor = System.Drawing.SystemColors.Control
        Me.GroupPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.GroupPanel1.DisabledBackColor = System.Drawing.Color.Empty
        Me.GroupPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupPanel1.Location = New System.Drawing.Point(0, 0)
        Me.GroupPanel1.Name = "GroupPanel1"
        Me.GroupPanel1.Size = New System.Drawing.Size(858, 105)
        '
        '
        '
        Me.GroupPanel1.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.GroupPanel1.Style.BackColorGradientAngle = 90
        Me.GroupPanel1.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
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
        Me.GroupPanel1.TabIndex = 236
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Controls.Add(Me.Label6)
        Me.Panel2.Location = New System.Drawing.Point(652, 29)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(220, 100)
        Me.Panel2.TabIndex = 19
        Me.Panel2.TabStop = True
        Me.Panel2.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(115, 65)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(79, 18)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "USUARIO:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(115, 42)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(79, 18)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "USUARIO:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(115, 19)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(79, 18)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "USUARIO:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(31, 65)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(60, 18)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "HORA:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(31, 43)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(68, 18)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "FECHA:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(31, 19)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(87, 18)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "USUARIO:"
        '
        'MPanelToolBarAccion
        '
        Me.MPanelToolBarAccion.Controls.Add(Me.btnImportar)
        Me.MPanelToolBarAccion.Controls.Add(Me.BtnSalir1)
        Me.MPanelToolBarAccion.Location = New System.Drawing.Point(2, 1)
        Me.MPanelToolBarAccion.Name = "MPanelToolBarAccion"
        Me.MPanelToolBarAccion.Size = New System.Drawing.Size(280, 70)
        Me.MPanelToolBarAccion.TabIndex = 8
        '
        'btnImportar
        '
        Me.btnImportar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnImportar.ColorTable = DevComponents.DotNetBar.eButtonColor.Orange
        Me.btnImportar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnImportar.Image = Global.Presentacion.My.Resources.Resources.GEN_PEDIDOS_AUTOMATICAMENTE_ORI
        Me.btnImportar.ImageFixedSize = New System.Drawing.Size(48, 48)
        Me.btnImportar.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.btnImportar.Location = New System.Drawing.Point(6, 0)
        Me.btnImportar.Name = "btnImportar"
        Me.btnImportar.Size = New System.Drawing.Size(72, 70)
        Me.btnImportar.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnImportar.TabIndex = 11
        Me.btnImportar.Text = "IMPORTAR INVENTARIO"
        Me.btnImportar.TextColor = System.Drawing.Color.Black
        '
        'BtnSalir1
        '
        Me.BtnSalir1.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.BtnSalir1.ColorTable = DevComponents.DotNetBar.eButtonColor.Blue
        Me.BtnSalir1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSalir1.Image = Global.Presentacion.My.Resources.Resources.atras
        Me.BtnSalir1.ImageFixedSize = New System.Drawing.Size(48, 48)
        Me.BtnSalir1.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.BtnSalir1.Location = New System.Drawing.Point(96, 0)
        Me.BtnSalir1.Name = "BtnSalir1"
        Me.BtnSalir1.Size = New System.Drawing.Size(72, 70)
        Me.BtnSalir1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.BtnSalir1.TabIndex = 10
        Me.BtnSalir1.Text = "SALIR"
        Me.BtnSalir1.TextColor = System.Drawing.Color.Black
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 1000
        '
        'F03_ImportarInventario
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(891, 216)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Sizable
        Me.Location = New System.Drawing.Point(0, 0)
        Me.Name = "F03_ImportarInventario"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultLocation
        Me.Text = "F03_ImportarInv"
        Me.Controls.SetChildIndex(Me.PanelPrincipal, 0)
        Me.PanelSuperior.ResumeLayout(False)
        Me.PanelInferior.ResumeLayout(False)
        CType(Me.BubbleBarUsuario, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelToolBar1.ResumeLayout(False)
        Me.PanelToolBar2.ResumeLayout(False)
        Me.PanelPrincipal.ResumeLayout(False)
        Me.PanelUsuario.ResumeLayout(False)
        Me.PanelUsuario.PerformLayout()
        Me.PanelNavegacion.ResumeLayout(False)
        Me.MPanelUserAct.ResumeLayout(False)
        Me.MPanelUserAct.PerformLayout()
        CType(Me.MEP, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelContent.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.MSuperTabControlPanel1.ResumeLayout(False)
        CType(Me.MSuperTabControl, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MSuperTabControl.ResumeLayout(False)
        Me.MPanelSup.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.MPanelToolBarAccion.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Protected WithEvents MPanelSup As Panel
    Protected WithEvents Panel2 As Panel
    Protected WithEvents Label1 As Label
    Protected WithEvents Label2 As Label
    Protected WithEvents Label3 As Label
    Protected WithEvents Label4 As Label
    Protected WithEvents Label5 As Label
    Protected WithEvents Label6 As Label
    Protected WithEvents MPanelToolBarAccion As Panel
    Protected WithEvents BtnSalir1 As DevComponents.DotNetBar.ButtonX
    Friend WithEvents GroupPanel1 As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents Timer1 As Timer
    Protected WithEvents btnImportar As DevComponents.DotNetBar.ButtonX
End Class
