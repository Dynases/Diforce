<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDispatch
    Inherits System.Windows.Forms.Form

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
        Dim cbChoferes_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDispatch))
        Me.PanelBase = New System.Windows.Forms.Panel()
        Me.PanelSubBase = New System.Windows.Forms.Panel()
        Me.PanelPedido = New System.Windows.Forms.Panel()
        Me.GroupPanelGeoreferencia = New DevComponents.DotNetBar.Controls.GroupPanel()
        Me.PanelEx6 = New DevComponents.DotNetBar.PanelEx()
        Me.Btn_ZoomMenos = New DevComponents.DotNetBar.ButtonX()
        Me.Btn_ZoomMas = New DevComponents.DotNetBar.ButtonX()
        Me.GM_Mapa = New GMap.NET.WindowsForms.GMapControl()
        Me.dgjPedido = New Janus.Windows.GridEX.GridEX()
        Me.PanelProducto = New System.Windows.Forms.Panel()
        Me.dgjProducto = New Janus.Windows.GridEX.GridEX()
        Me.PanelAccion = New System.Windows.Forms.Panel()
        Me.btGrabar = New DevComponents.DotNetBar.ButtonX()
        Me.btActualizar = New DevComponents.DotNetBar.ButtonX()
        Me.LabelX2 = New DevComponents.DotNetBar.LabelX()
        Me.cbChoferes = New Janus.Windows.GridEX.EditControls.MultiColumnCombo()
        Me.PanelZona = New System.Windows.Forms.Panel()
        Me.PanelZonaGrilla = New System.Windows.Forms.Panel()
        Me.dgjZona = New Janus.Windows.GridEX.GridEX()
        Me.btConsultar = New DevComponents.DotNetBar.ButtonX()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.PanelBase.SuspendLayout()
        Me.PanelSubBase.SuspendLayout()
        Me.PanelPedido.SuspendLayout()
        Me.GroupPanelGeoreferencia.SuspendLayout()
        Me.PanelEx6.SuspendLayout()
        CType(Me.dgjPedido, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelProducto.SuspendLayout()
        CType(Me.dgjProducto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelAccion.SuspendLayout()
        CType(Me.cbChoferes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelZona.SuspendLayout()
        Me.PanelZonaGrilla.SuspendLayout()
        CType(Me.dgjZona, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelBase
        '
        Me.PanelBase.Controls.Add(Me.PanelSubBase)
        Me.PanelBase.Controls.Add(Me.PanelZona)
        Me.PanelBase.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelBase.Location = New System.Drawing.Point(0, 0)
        Me.PanelBase.Name = "PanelBase"
        Me.PanelBase.Size = New System.Drawing.Size(1362, 701)
        Me.PanelBase.TabIndex = 0
        '
        'PanelSubBase
        '
        Me.PanelSubBase.Controls.Add(Me.PanelPedido)
        Me.PanelSubBase.Controls.Add(Me.PanelProducto)
        Me.PanelSubBase.Controls.Add(Me.PanelAccion)
        Me.PanelSubBase.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelSubBase.Location = New System.Drawing.Point(165, 0)
        Me.PanelSubBase.Name = "PanelSubBase"
        Me.PanelSubBase.Size = New System.Drawing.Size(1197, 701)
        Me.PanelSubBase.TabIndex = 1
        '
        'PanelPedido
        '
        Me.PanelPedido.Controls.Add(Me.GroupPanelGeoreferencia)
        Me.PanelPedido.Controls.Add(Me.dgjPedido)
        Me.PanelPedido.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelPedido.Location = New System.Drawing.Point(0, 60)
        Me.PanelPedido.Name = "PanelPedido"
        Me.PanelPedido.Size = New System.Drawing.Size(1197, 526)
        Me.PanelPedido.TabIndex = 2
        '
        'GroupPanelGeoreferencia
        '
        Me.GroupPanelGeoreferencia.CanvasColor = System.Drawing.SystemColors.Control
        Me.GroupPanelGeoreferencia.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.GroupPanelGeoreferencia.Controls.Add(Me.PanelEx6)
        Me.GroupPanelGeoreferencia.Controls.Add(Me.GM_Mapa)
        Me.GroupPanelGeoreferencia.DisabledBackColor = System.Drawing.Color.Empty
        Me.GroupPanelGeoreferencia.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupPanelGeoreferencia.Location = New System.Drawing.Point(1187, 0)
        Me.GroupPanelGeoreferencia.Name = "GroupPanelGeoreferencia"
        Me.GroupPanelGeoreferencia.Size = New System.Drawing.Size(10, 526)
        '
        '
        '
        Me.GroupPanelGeoreferencia.Style.BackColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(127, Byte), Integer))
        Me.GroupPanelGeoreferencia.Style.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(127, Byte), Integer))
        Me.GroupPanelGeoreferencia.Style.BackColorGradientAngle = 90
        Me.GroupPanelGeoreferencia.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanelGeoreferencia.Style.BorderBottomWidth = 1
        Me.GroupPanelGeoreferencia.Style.BorderColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(127, Byte), Integer))
        Me.GroupPanelGeoreferencia.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanelGeoreferencia.Style.BorderLeftWidth = 1
        Me.GroupPanelGeoreferencia.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanelGeoreferencia.Style.BorderRightWidth = 1
        Me.GroupPanelGeoreferencia.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanelGeoreferencia.Style.BorderTopWidth = 1
        Me.GroupPanelGeoreferencia.Style.CornerDiameter = 4
        Me.GroupPanelGeoreferencia.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded
        Me.GroupPanelGeoreferencia.Style.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupPanelGeoreferencia.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center
        Me.GroupPanelGeoreferencia.Style.TextColor = System.Drawing.Color.AliceBlue
        Me.GroupPanelGeoreferencia.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near
        '
        '
        '
        Me.GroupPanelGeoreferencia.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.GroupPanelGeoreferencia.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.GroupPanelGeoreferencia.TabIndex = 3
        Me.GroupPanelGeoreferencia.Text = "UBICACIÓN"
        Me.GroupPanelGeoreferencia.Visible = False
        '
        'PanelEx6
        '
        Me.PanelEx6.CanvasColor = System.Drawing.SystemColors.Control
        Me.PanelEx6.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.PanelEx6.Controls.Add(Me.Btn_ZoomMenos)
        Me.PanelEx6.Controls.Add(Me.Btn_ZoomMas)
        Me.PanelEx6.DisabledBackColor = System.Drawing.Color.Empty
        Me.PanelEx6.Location = New System.Drawing.Point(3, 5)
        Me.PanelEx6.Name = "PanelEx6"
        Me.PanelEx6.Size = New System.Drawing.Size(46, 87)
        Me.PanelEx6.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.PanelEx6.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.PanelEx6.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.PanelEx6.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.PanelEx6.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.PanelEx6.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.PanelEx6.Style.GradientAngle = 90
        Me.PanelEx6.TabIndex = 5
        '
        'Btn_ZoomMenos
        '
        Me.Btn_ZoomMenos.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.Btn_ZoomMenos.BackgroundImage = Global.Presentacion.My.Resources.Resources.ZOOM_MENOS_ORI
        Me.Btn_ZoomMenos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Btn_ZoomMenos.ColorTable = DevComponents.DotNetBar.eButtonColor.Flat
        Me.Btn_ZoomMenos.Image = Global.Presentacion.My.Resources.Resources.ZOOM_MENOS_ORI
        Me.Btn_ZoomMenos.ImageFixedSize = New System.Drawing.Size(40, 40)
        Me.Btn_ZoomMenos.Location = New System.Drawing.Point(3, 45)
        Me.Btn_ZoomMenos.Name = "Btn_ZoomMenos"
        Me.Btn_ZoomMenos.Size = New System.Drawing.Size(40, 40)
        Me.Btn_ZoomMenos.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.Btn_ZoomMenos.TabIndex = 1
        '
        'Btn_ZoomMas
        '
        Me.Btn_ZoomMas.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.Btn_ZoomMas.BackgroundImage = Global.Presentacion.My.Resources.Resources.ZOOM_MAS_ORI
        Me.Btn_ZoomMas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Btn_ZoomMas.ColorTable = DevComponents.DotNetBar.eButtonColor.Flat
        Me.Btn_ZoomMas.Image = Global.Presentacion.My.Resources.Resources.ZOOM_MAS_ORI
        Me.Btn_ZoomMas.ImageFixedSize = New System.Drawing.Size(40, 40)
        Me.Btn_ZoomMas.Location = New System.Drawing.Point(3, 3)
        Me.Btn_ZoomMas.Name = "Btn_ZoomMas"
        Me.Btn_ZoomMas.Size = New System.Drawing.Size(40, 40)
        Me.Btn_ZoomMas.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.Btn_ZoomMas.TabIndex = 0
        '
        'GM_Mapa
        '
        Me.GM_Mapa.Bearing = 0!
        Me.GM_Mapa.CanDragMap = True
        Me.GM_Mapa.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GM_Mapa.EmptyTileColor = System.Drawing.Color.Navy
        Me.GM_Mapa.GrayScaleMode = False
        Me.GM_Mapa.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow
        Me.GM_Mapa.LevelsKeepInMemmory = 5
        Me.GM_Mapa.Location = New System.Drawing.Point(0, 0)
        Me.GM_Mapa.MarkersEnabled = True
        Me.GM_Mapa.MaxZoom = 2
        Me.GM_Mapa.MinZoom = 2
        Me.GM_Mapa.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter
        Me.GM_Mapa.Name = "GM_Mapa"
        Me.GM_Mapa.NegativeMode = False
        Me.GM_Mapa.PolygonsEnabled = True
        Me.GM_Mapa.RetryLoadTile = 0
        Me.GM_Mapa.RoutesEnabled = True
        Me.GM_Mapa.ScaleMode = GMap.NET.WindowsForms.ScaleModes.[Integer]
        Me.GM_Mapa.SelectedAreaFillColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(225, Byte), Integer))
        Me.GM_Mapa.ShowTileGridLines = False
        Me.GM_Mapa.Size = New System.Drawing.Size(4, 502)
        Me.GM_Mapa.TabIndex = 1
        Me.GM_Mapa.Zoom = 0R
        '
        'dgjPedido
        '
        Me.dgjPedido.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgjPedido.Location = New System.Drawing.Point(0, 0)
        Me.dgjPedido.Name = "dgjPedido"
        Me.dgjPedido.Size = New System.Drawing.Size(1194, 526)
        Me.dgjPedido.TabIndex = 1
        '
        'PanelProducto
        '
        Me.PanelProducto.Controls.Add(Me.dgjProducto)
        Me.PanelProducto.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PanelProducto.Location = New System.Drawing.Point(0, 586)
        Me.PanelProducto.Name = "PanelProducto"
        Me.PanelProducto.Size = New System.Drawing.Size(1197, 115)
        Me.PanelProducto.TabIndex = 1
        '
        'dgjProducto
        '
        Me.dgjProducto.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgjProducto.Location = New System.Drawing.Point(0, 0)
        Me.dgjProducto.Name = "dgjProducto"
        Me.dgjProducto.Size = New System.Drawing.Size(1197, 115)
        Me.dgjProducto.TabIndex = 2
        '
        'PanelAccion
        '
        Me.PanelAccion.Controls.Add(Me.btGrabar)
        Me.PanelAccion.Controls.Add(Me.btActualizar)
        Me.PanelAccion.Controls.Add(Me.LabelX2)
        Me.PanelAccion.Controls.Add(Me.cbChoferes)
        Me.PanelAccion.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelAccion.Location = New System.Drawing.Point(0, 0)
        Me.PanelAccion.Name = "PanelAccion"
        Me.PanelAccion.Size = New System.Drawing.Size(1197, 60)
        Me.PanelAccion.TabIndex = 0
        '
        'btGrabar
        '
        Me.btGrabar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btGrabar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btGrabar.Dock = System.Windows.Forms.DockStyle.Right
        Me.btGrabar.Image = Global.Presentacion.My.Resources.Resources.GRABAR
        Me.btGrabar.ImageFixedSize = New System.Drawing.Size(30, 30)
        Me.btGrabar.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.btGrabar.Location = New System.Drawing.Point(1047, 0)
        Me.btGrabar.Name = "btGrabar"
        Me.btGrabar.Size = New System.Drawing.Size(75, 60)
        Me.btGrabar.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btGrabar.TabIndex = 2
        Me.btGrabar.Text = "Grabar"
        '
        'btActualizar
        '
        Me.btActualizar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btActualizar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btActualizar.Dock = System.Windows.Forms.DockStyle.Right
        Me.btActualizar.Image = Global.Presentacion.My.Resources.Resources.ACTUALIZAR
        Me.btActualizar.ImageFixedSize = New System.Drawing.Size(30, 30)
        Me.btActualizar.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.btActualizar.Location = New System.Drawing.Point(1122, 0)
        Me.btActualizar.Name = "btActualizar"
        Me.btActualizar.Size = New System.Drawing.Size(75, 60)
        Me.btActualizar.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btActualizar.TabIndex = 3
        Me.btActualizar.Text = "Actualizar"
        '
        'LabelX2
        '
        '
        '
        '
        Me.LabelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX2.Location = New System.Drawing.Point(6, 12)
        Me.LabelX2.Name = "LabelX2"
        Me.LabelX2.Size = New System.Drawing.Size(55, 23)
        Me.LabelX2.TabIndex = 1
        Me.LabelX2.Text = "Choferes:"
        '
        'cbChoferes
        '
        cbChoferes_DesignTimeLayout.LayoutString = resources.GetString("cbChoferes_DesignTimeLayout.LayoutString")
        Me.cbChoferes.DesignTimeLayout = cbChoferes_DesignTimeLayout
        Me.cbChoferes.Location = New System.Drawing.Point(67, 14)
        Me.cbChoferes.Name = "cbChoferes"
        Me.cbChoferes.SelectedIndex = -1
        Me.cbChoferes.SelectedItem = Nothing
        Me.cbChoferes.Size = New System.Drawing.Size(200, 20)
        Me.cbChoferes.TabIndex = 0
        '
        'PanelZona
        '
        Me.PanelZona.Controls.Add(Me.PanelZonaGrilla)
        Me.PanelZona.Dock = System.Windows.Forms.DockStyle.Left
        Me.PanelZona.Location = New System.Drawing.Point(0, 0)
        Me.PanelZona.Name = "PanelZona"
        Me.PanelZona.Size = New System.Drawing.Size(165, 701)
        Me.PanelZona.TabIndex = 0
        '
        'PanelZonaGrilla
        '
        Me.PanelZonaGrilla.Controls.Add(Me.dgjZona)
        Me.PanelZonaGrilla.Controls.Add(Me.btConsultar)
        Me.PanelZonaGrilla.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelZonaGrilla.Location = New System.Drawing.Point(0, 0)
        Me.PanelZonaGrilla.Name = "PanelZonaGrilla"
        Me.PanelZonaGrilla.Size = New System.Drawing.Size(165, 701)
        Me.PanelZonaGrilla.TabIndex = 1
        '
        'dgjZona
        '
        Me.dgjZona.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgjZona.Location = New System.Drawing.Point(0, 0)
        Me.dgjZona.Name = "dgjZona"
        Me.dgjZona.Size = New System.Drawing.Size(165, 651)
        Me.dgjZona.TabIndex = 0
        '
        'btConsultar
        '
        Me.btConsultar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btConsultar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btConsultar.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.btConsultar.Image = Global.Presentacion.My.Resources.Resources.buscar
        Me.btConsultar.ImageFixedSize = New System.Drawing.Size(30, 30)
        Me.btConsultar.Location = New System.Drawing.Point(0, 651)
        Me.btConsultar.Name = "btConsultar"
        Me.btConsultar.Size = New System.Drawing.Size(165, 50)
        Me.btConsultar.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btConsultar.TabIndex = 1
        Me.btConsultar.Text = "CONSULTAR"
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 1000
        '
        'frmDispatch
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1362, 701)
        Me.Controls.Add(Me.PanelBase)
        Me.Name = "frmDispatch"
        Me.Opacity = 0.05R
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmDispatch"
        Me.PanelBase.ResumeLayout(False)
        Me.PanelSubBase.ResumeLayout(False)
        Me.PanelPedido.ResumeLayout(False)
        Me.GroupPanelGeoreferencia.ResumeLayout(False)
        Me.PanelEx6.ResumeLayout(False)
        CType(Me.dgjPedido, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelProducto.ResumeLayout(False)
        CType(Me.dgjProducto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelAccion.ResumeLayout(False)
        Me.PanelAccion.PerformLayout()
        CType(Me.cbChoferes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelZona.ResumeLayout(False)
        Me.PanelZonaGrilla.ResumeLayout(False)
        CType(Me.dgjZona, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PanelBase As Panel
    Friend WithEvents PanelSubBase As Panel
    Friend WithEvents PanelPedido As Panel
    Friend WithEvents PanelProducto As Panel
    Friend WithEvents PanelAccion As Panel
    Friend WithEvents PanelZona As Panel
    Friend WithEvents PanelZonaGrilla As Panel
    Friend WithEvents dgjPedido As Janus.Windows.GridEX.GridEX
    Friend WithEvents dgjProducto As Janus.Windows.GridEX.GridEX
    Friend WithEvents btActualizar As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btGrabar As DevComponents.DotNetBar.ButtonX
    Friend WithEvents LabelX2 As DevComponents.DotNetBar.LabelX
    Friend WithEvents cbChoferes As Janus.Windows.GridEX.EditControls.MultiColumnCombo
    Friend WithEvents btConsultar As DevComponents.DotNetBar.ButtonX
    Friend WithEvents dgjZona As Janus.Windows.GridEX.GridEX
    Friend WithEvents Timer1 As Timer
    Friend WithEvents GroupPanelGeoreferencia As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents PanelEx6 As DevComponents.DotNetBar.PanelEx
    Friend WithEvents Btn_ZoomMenos As DevComponents.DotNetBar.ButtonX
    Friend WithEvents Btn_ZoomMas As DevComponents.DotNetBar.ButtonX
    Friend WithEvents GM_Mapa As GMap.NET.WindowsForms.GMapControl
End Class
