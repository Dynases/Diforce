Imports DevComponents.DotNetBar
Imports DevComponents.DotNetBar.Controls
Imports ENTITY
Imports GMap.NET
Imports GMap.NET.MapProviders
Imports GMap.NET.WindowsForms
Imports GMap.NET.WindowsForms.Markers
Imports GMap.NET.WindowsForms.ToolTips
Imports Janus.Windows.GridEX
Imports Logica.AccesoLogica
Imports LOGIC
Imports UTILITIES

Public Class frmDispatch
    Dim _Inter As Integer = 0
    Public _nameButton As String
    Public _tab As SuperTabItem
    Public _modulo As SideNavItem


#Region "Eventos"
    Private Sub frmDispatch_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Init()
    End Sub

    Private Sub btConsultar_Click(sender As Object, e As EventArgs) Handles btConsultar.Click
        Try
            CargarPedidos()
        Catch ex As Exception
            MostrarMensajeError(ex.Message)
        End Try
    End Sub

    Private Sub btGrabar_Click(sender As Object, e As EventArgs) Handles btGrabar.Click
        Try
            GuardarPedidoChofer()
        Catch ex As Exception
            MostrarMensajeError(ex.Message)
        End Try
    End Sub

    Private Sub btActualizar_Click(sender As Object, e As EventArgs) Handles btActualizar.Click
        Try
            CargarPedidos()
        Catch ex As Exception
            MostrarMensajeError(ex.Message)
        End Try
    End Sub

    Private Sub dgjPedido_SelectionChanged(sender As Object, e As EventArgs) Handles dgjPedido.SelectionChanged
        Try
            Dim idPedido = 0
            If (dgjPedido.GetRows().Count > 0) Then
                idPedido = Convert.ToInt32(dgjPedido.CurrentRow.Cells("Id").Value)
            End If

            CargarProductos(idPedido)
        Catch ex As Exception
            MostrarMensajeError(ex.Message)
        End Try
    End Sub

    Private Sub dgjZona_RowCheckStateChanged(sender As Object, e As EventArgs) Handles dgjZona.RowCheckStateChanged
        Dim checks = Me.dgjZona.GetCheckedRows()
        Dim listIdZona = checks.Select(Function(a) Convert.ToInt32(a.Cells("Id").Value)).ToList()
        'MessageBox.Show(listIdZona.Count)
        Dim i As Integer
        Dim objMapa As New GMapControl
        Dim _overlay As New GMapOverlay
        _LimpiarMapa(GM_Mapa, _overlay)
        For Each item As String In listIdZona

            Dim dtZonas As DataTable
            'DIBUJAR ZONAS
            dtZonas = L_ZonaCabecera_GeneralCompletoDistribucion(0, item).Tables(0)
            Dim colorZona As String
            Dim idRegZona As Integer

            For i = 0 To dtZonas.Rows.Count - 1

                _PCargarMapa(GM_Mapa, _overlay)

                idRegZona = dtZonas.Rows(i).Item("lanumi")
                colorZona = dtZonas.Rows(i).Item("lacolor")

                'dibujar zona
                _PDibujarZona(idRegZona, _overlay, colorZona)
            Next
        Next
    End Sub
#End Region

#Region "Privado, metodos y funciones"
    Private Sub Init()
        Try
            L_prJobDuplicados()
            ConfigForm()
            CargarZonas()
            CargarChoferes()
        Catch ex As Exception
            MostrarMensajeError(ex.Message)
        End Try
    End Sub

    Private Sub _prDibujarPunto(ByRef objOverlay As GMapOverlay, pointLatLng As PointLatLng, Optional etiqueta As String = "")

        'añadir puntos
        ''Dim markersOverlay As New GMapOverlay("markers")
        Dim marker As New GMarkerGoogle(pointLatLng, GMarkerGoogleType.blue)
        'añadir tooltip
        If etiqueta <> "" Then
            Dim mode As MarkerTooltipMode = MarkerTooltipMode.OnMouseOver
            marker.ToolTip = New GMapBaloonToolTip(marker)
            marker.ToolTipMode = mode
            Dim ToolTipBackColor As New SolidBrush(Color.WhiteSmoke)
            marker.ToolTip.Fill = ToolTipBackColor
            marker.ToolTipText = etiqueta
        End If
        objOverlay.Markers.Clear()
        objOverlay.Markers.Add(marker)
        'mapa.Overlays.Add(markersOverlay)
    End Sub
    Private Sub ConfigForm()
        Try
            Me.Text = "DISTRIBUCIÓN"
            'Me.WindowState = FormWindowState.Maximized
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Sub
    Private Sub _LimpiarMapa(ByRef objMapa As GMapControl, ByRef objOverlay As GMapOverlay)
        objMapa.Overlays.Clear()
        objMapa.Overlays.Add(objOverlay)

    End Sub
    Private Sub _PCargarMapa(ByRef objMapa As GMapControl, ByRef objOverlay As GMapOverlay)
        'objMapa.Overlays.Clear()
        objOverlay = New GMapOverlay("polygons")

        objMapa.Overlays.Add(objOverlay)

        objMapa.DragButton = MouseButtons.Left
        objMapa.CanDragMap = True
        objMapa.MapProvider = GMapProviders.GoogleMap
        'objMapa.Position = New PointLatLng(-19.589143, -65.753427)
        objMapa.Position = New PointLatLng(-17.782814, -63.182386)
        objMapa.MinZoom = 0
        objMapa.MaxZoom = 24
        objMapa.Zoom = 13
        objMapa.AutoScroll = True
        GMapProvider.Language = LanguageType.Spanish
    End Sub

    Private Sub _PDibujarZona(idZona As Integer, ByRef objOverlay As GMapOverlay, colorZona As String)
        'cargar zona en mapa

        Dim tPuntos As DataTable = L_ZonaDetallePuntos_General(-1, idZona).Tables(0)
        Dim i As Integer
        Dim lati, longi As Double
        Dim listPuntos As New List(Of PointLatLng)

        For i = 0 To tPuntos.Rows.Count - 1
            lati = tPuntos.Rows(i).Item(1)
            longi = tPuntos.Rows(i).Item(2)
            Dim plg As PointLatLng = New PointLatLng(lati, longi)
            listPuntos.Add(plg)
        Next

        'Dim color1 As String = JGr_Zonas1.CurrentRow.Cells(7).Value
        Dim colorFinal As Color = ColorTranslator.FromHtml(colorZona)

        Dim polygon As New GMapPolygon(listPuntos, "mypolygon")
        'agregar color
        polygon.Fill = New SolidBrush(Color.FromArgb(50, colorFinal))
        polygon.Stroke = New Pen(Color.Red, 1)
        'objOverlay.Polygons.Clear()
        objOverlay.Polygons.Add(polygon)
    End Sub

    Public Sub CargarZonas()
        Try
            Dim listResult As List(Of VCombo) = New LZona().ListarCombo()

            dgjZona.BoundMode = Janus.Data.BoundMode.Bound
            dgjZona.DataSource = listResult
            dgjZona.RetrieveStructure()

            dgjZona.RootTable.Columns.Insert(0, New GridEXColumn("Check"))
            With dgjZona.RootTable.Columns("Check")
                .Width = 20
                .ShowRowSelector = True
                .UseHeaderSelector = True
                .FilterEditType = FilterEditType.NoEdit
            End With

            With dgjZona.RootTable.Columns("Id")
                .Visible = False
            End With

            With dgjZona.RootTable.Columns("Descripcion")
                .Caption = "Zonas"
                .Width = 220
                .CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
                .Visible = True
            End With

            With dgjZona
                .GroupByBoxVisible = False
                .DefaultFilterRowComparison = FilterConditionOperator.Contains
                .FilterMode = FilterMode.Automatic
                .FilterRowUpdateMode = FilterRowUpdateMode.WhenValueChanges
                .VisualStyle = VisualStyle.Office2007
                .SelectionMode = SelectionMode.MultipleSelection
                .AlternatingColors = True
                .AllowEdit = InheritableBoolean.False
                .AllowColumnDrag = False
                .AutomaticSort = False
                '.ColumnHeaders = InheritableBoolean.False
            End With
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Sub

    Private Sub CargarChoferes()
        Try
            Dim listResult As List(Of VCombo) = New LPersonal().ListarRepatidorCombo()

            With cbChoferes.DropDownList
                .Columns.Clear()

                .Columns.Add("Id").Width = 30
                .Columns("Id").Caption = "Id"
                .Columns("Id").Visible = True

                .Columns.Add("Descripcion").Width = 180
                .Columns("Descripcion").Caption = "Nombre repartidor"
                .Columns("Descripcion").Visible = True

                .ValueMember = "Id"
                .DisplayMember = "Descripcion"
                .DataSource = listResult

                .AlternatingColors = True
                .AllowColumnDrag = False
                .AutomaticSort = False
                .Refresh()
            End With
            cbChoferes.VisualStyle = VisualStyle.Office2007

            cbChoferes.SelectedIndex = 0
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Sub


    Private Sub CargarPedidos()
        Try
            Dim checks = Me.dgjZona.GetCheckedRows()
            Dim listIdZona = checks.Select(Function(a) Convert.ToInt32(a.Cells("Id").Value)).ToList()
            If (listIdZona.Count = 0) Then
                Throw New Exception("Debe seleccionar por lo menos una zona.")
            End If

            Dim listResult = New LPedido().ListarPedidoDistribucion(listIdZona)

            dgjPedido.BoundMode = Janus.Data.BoundMode.Bound
            dgjPedido.DataSource = listResult
            dgjPedido.RetrieveStructure()

            With dgjPedido.RootTable.Columns("Fecha")
                .Caption = "Fecha"
                .Width = 70
                .CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
                .Visible = True
                .Position = 0
            End With

            With dgjPedido.RootTable.Columns("NombreCliente")
                .Caption = "Cliente"
                .Width = 140
                .CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
                .Visible = True
                .Position = 1
            End With

            With dgjPedido.RootTable.Columns("Id")
                .Caption = "Pedido"
                .Width = 40
                .CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
                .Visible = True
                .Position = 2
            End With

            With dgjPedido.RootTable.Columns("NombreVendedor")
                .Caption = "Vendedor"
                .Width = 134
                .CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
                .Visible = True
                .Position = 3
            End With
            With dgjPedido.RootTable.Columns("idZona")
                .Caption = "Zona"
                .Width = 38
                .CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
                .Visible = True
                .Position = 4
            End With

            dgjPedido.RootTable.Columns.Add(New GridEXColumn("Check"))
            With dgjPedido.RootTable.Columns("Check")
                .Caption = "Despacho"
                .Width = 50
                .ShowRowSelector = True
                .UseHeaderSelector = True
                .FilterEditType = FilterEditType.NoEdit
                .Position = 5
            End With

            With dgjPedido
                .GroupByBoxVisible = False
                .DefaultFilterRowComparison = FilterConditionOperator.Contains
                .FilterMode = FilterMode.Automatic
                .FilterRowUpdateMode = FilterRowUpdateMode.WhenValueChanges
                .VisualStyle = VisualStyle.Office2007
                .SelectionMode = SelectionMode.MultipleSelection
                .AlternatingColors = True
                .AllowEdit = InheritableBoolean.False
                '.AllowColumnDrag = False
                '.AutomaticSort = False
                '.ColumnHeaders = InheritableBoolean.False

            End With
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Sub

    Private Sub CargarProductos(idPedido As Integer)
        Try
            Dim listResult = New LProducto().ListarProductoXPedido(idPedido)

            dgjProducto.BoundMode = Janus.Data.BoundMode.Bound
            dgjProducto.DataSource = listResult
            dgjProducto.RetrieveStructure()

            With dgjProducto.RootTable.Columns("Id")
                .Visible = False
            End With

            With dgjProducto.RootTable.Columns("NombreProducto")
                .Caption = "Producto"
                .Width = 250
                .CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
                .Visible = True
            End With

            With dgjProducto.RootTable.Columns("Cantidad")
                .Caption = "Cantidad"
                .Width = 80
                .CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
                .Visible = True
                .FormatString = "0.00"
            End With

            With dgjProducto.RootTable.Columns("Precio")
                .Caption = "Precio"
                .Width = 80
                .CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
                .Visible = True
                .FormatString = "0.00"
            End With
            With dgjProducto.RootTable.Columns("SubTotal")
                .Caption = "SubTotal"
                .Width = 120
                .CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
                .Visible = True
                .FormatString = "0.00"
                .AggregateFunction = AggregateFunction.Sum
            End With
            With dgjProducto.RootTable.Columns("Descuento")
                .Caption = "Descuento"
                .Width = 120
                .CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
                .Visible = True
                .FormatString = "0.00"
                .AggregateFunction = AggregateFunction.Sum
            End With
            With dgjProducto.RootTable.Columns("Total")
                .Caption = "Total"
                .Width = 120
                .CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
                .Visible = True
                .FormatString = "0.00"
                .AggregateFunction = AggregateFunction.Sum
            End With

            With dgjProducto
                .GroupByBoxVisible = False
                .DefaultFilterRowComparison = FilterConditionOperator.Contains
                '.FilterMode = FilterMode.Automatic
                .FilterRowUpdateMode = FilterRowUpdateMode.WhenValueChanges
                .VisualStyle = VisualStyle.Office2007
                .SelectionMode = SelectionMode.MultipleSelection
                .AlternatingColors = True
                .AllowEdit = InheritableBoolean.False
                .AllowColumnDrag = False
                .AutomaticSort = False
                '.ColumnHeaders = InheritableBoolean.False

                .TotalRow = InheritableBoolean.True
                .TotalRowFormatStyle.BackColor = Color.Gold
                .TotalRowPosition = TotalRowPosition.BottomFixed
            End With
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Sub

    Private Sub GuardarPedidoChofer()
        Try
            Dim checks = Me.dgjPedido.GetCheckedRows()
            Dim listIdPedido = checks.Select(Function(a) Convert.ToInt32(a.Cells("Id").Value)).ToList()
            If (listIdPedido.Count = 0) Then
                Throw New Exception("Debe seleccionar por lo menos un pedido.")
            End If
            Dim idChofer = Me.cbChoferes.Value
            If (Not IsNumeric(idChofer)) Then
                Throw New Exception("Debe seleccionar un chofer.")
            End If
            If (Convert.ToInt32(idChofer) = ENCombo.ID_SELECCIONAR) Then
                Throw New Exception("Debe seleccionar un chofer.")
            End If

            Dim result = New LPedido().GuardarPedidoDeChofer(listIdPedido, idChofer, gs_user)
            If (result) Then
                btActualizar.PerformClick()
                MostrarMensajeOk("Pedidos asignados correctamente")
            End If
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Sub

    Private Sub MostrarMensajeError(mensaje As String)
        ToastNotification.Show(Me,
                               mensaje.ToUpper,
                               My.Resources.WARNING,
                               ENMensaje.MEDIANO,
                               eToastGlowColor.Red,
                               eToastPosition.TopCenter)
    End Sub

    Private Sub MostrarMensajeOk(mensaje As String)
        ToastNotification.Show(Me,
                               mensaje.ToUpper,
                               My.Resources.OK,
                               ENMensaje.MEDIANO,
                               eToastGlowColor.Green,
                               eToastPosition.TopCenter)
    End Sub
#End Region
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        _Inter = _Inter + 1
        If _Inter = 1 Then
            Me.WindowState = FormWindowState.Normal

        Else
            Me.Opacity = 100
            Timer1.Enabled = False
        End If
        'Me.Opacity = 100
        'Timer1.Enabled = False
    End Sub
#Region "Publico, metodos y funciones"
    Public Sub New()
        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Private Sub Btn_ZoomMas_Click(sender As Object, e As EventArgs) Handles Btn_ZoomMas.Click
        If GM_Mapa.Zoom <> GM_Mapa.MaxZoom Then
            GM_Mapa.Zoom = GM_Mapa.Zoom + 1
        End If
    End Sub

    Private Sub Btn_ZoomMenos_Click(sender As Object, e As EventArgs) Handles Btn_ZoomMenos.Click
        If GM_Mapa.Zoom <> GM_Mapa.MinZoom Then
            GM_Mapa.Zoom = GM_Mapa.Zoom - 1
        End If
    End Sub
#End Region
End Class