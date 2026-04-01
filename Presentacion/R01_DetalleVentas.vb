
Imports DevComponents.DotNetBar
Imports DevComponents.DotNetBar.Controls
Imports GMap.NET
Imports GMap.NET.MapProviders
Imports GMap.NET.WindowsForms
Imports GMap.NET.WindowsForms.Markers
Imports GMap.NET.WindowsForms.ToolTips
Imports Logica.AccesoLogica




Imports System.IO
Imports Janus.Data
Imports Janus.Windows.GridEX


Public Class R01_DetalleVentas
    Dim dt As DataTable

    Dim _Inter As Integer = 0
    Dim RutaGlobal As String = gs_CarpetaRaiz
    Dim _Punto As Integer
    Dim _ListPuntos As List(Of PointLatLng)
    Dim _Overlay As GMapOverlay
    Dim _latitud As Double = 0
    Dim _longitud As Double = 0
    Dim TableCliente As DataTable
    Dim TablaClienteZona As DataTable
    Dim Markers As GMapMarker
    Dim cont As Integer = 0

    Public _nameButton As String
    Public _tab As SuperTabItem
    Public _modulo As SideNavItem

    Private Sub Gmc_Cliente_Load(sender As Object, e As EventArgs)

    End Sub

    Private Sub MoitoreoVisita_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Iniciar()
    End Sub


    Private Sub Iniciar()
        IniciarComponentes()

    End Sub

    Private Sub IniciarComponentes()
        Tb_Fecha.Value = Date.Now

        CargarChoferes()

    End Sub



    Public Function GetResourceMapa(color As Integer) As Bitmap
        Select Case color
            Case 1
                Return New Bitmap(My.Resources.mapa_1)
            Case 2
                Return New Bitmap(My.Resources.mapa_2)
            Case 3
                Return New Bitmap(My.Resources.mapa_3)
            Case 4
                Return New Bitmap(My.Resources.mapa_4)
            Case 5
                Return New Bitmap(My.Resources.mapa_5)
            Case 6
                Return New Bitmap(My.Resources.mapa_6)
            Case 7
                Return New Bitmap(My.Resources.mapa_7)
            Case 8
                Return New Bitmap(My.Resources.mapa_8)
            Case 9
                Return New Bitmap(My.Resources.mapa_9)
            Case 10
                Return New Bitmap(My.Resources.mapa_10)
            Case 11
                Return New Bitmap(My.Resources.mapa_11)
            Case 12
                Return New Bitmap(My.Resources.mapa_12)
            Case 13
                Return New Bitmap(My.Resources.mapa_13)
            Case 14
                Return New Bitmap(My.Resources.mapa_14)
            Case 15
                Return New Bitmap(My.Resources.mapa_15)
            Case 16
                Return New Bitmap(My.Resources.mapa_16)
            Case 17
                Return New Bitmap(My.Resources.mapa_17)
            Case 18
                Return New Bitmap(My.Resources.mapa_18)
            Case 19
                Return New Bitmap(My.Resources.mapa_19)
            Case 20
                Return New Bitmap(My.Resources.mapa_20)
            Case 21
                Return New Bitmap(My.Resources.mapa_21)
            Case 22
                Return New Bitmap(My.Resources.mapa_22)
        End Select
    End Function

    Private Sub P_AgregarPunto(pointLatLng As PointLatLng, _nombre As String, _ci As String, data As System.Data.DataRow, _Flag As Integer, tipo As Integer)
        If tipo = 1 Then
            If (Not IsNothing(_Overlay)) Then
                'añadir puntos
                'Dim markersOverlay As New GMapOverlay("markers")
                Dim marker As New GMarkerGoogle(pointLatLng, My.Resources.mark)

                Dim _imagen As New Bitmap(GetResourceMapa(21 + 1), 20, 30)
                marker = New GMarkerGoogle(pointLatLng, _imagen)
                'añadir tooltip
                Dim mode As MarkerTooltipMode = MarkerTooltipMode.OnMouseOver
                marker.ToolTip = New GMapBaloonToolTip(marker)
                marker.ToolTipMode = mode
                Dim ToolTipBackColor As SolidBrush
                If _Flag = 1 Then
                    ToolTipBackColor = New SolidBrush(Color.Green)
                    marker.ToolTip.Fill = ToolTipBackColor

                    marker.ToolTip.Foreground = Brushes.White
                    marker.Tag = data
                    _Overlay.Markers.Add(marker)
                    'mapa.Overlays.Add(markersOverlay)
                Else
                    ToolTipBackColor = New SolidBrush(Color.Red)
                    marker.ToolTip.Fill = ToolTipBackColor
                    marker.ToolTip.Foreground = Brushes.Red
                    marker.Tag = data
                    _Overlay.Markers.Add(marker)
                    'mapa.Overlays.Add(markersOverlay)
                End If

                'mapa.Overlays.Add(markersOverlay)
            End If

        ElseIf tipo = 0 Then

            If (Not IsNothing(_Overlay)) Then
                'añadir puntos
                'Dim markersOverlay As New GMapOverlay("markers")
                Dim marker As New GMarkerGoogle(pointLatLng, My.Resources.mark)

                Dim _imagen As New Bitmap(GetResourceMapa(2 + 1), 20, 30)
                marker = New GMarkerGoogle(pointLatLng, _imagen)
                'añadir tooltip
                Dim mode As MarkerTooltipMode = MarkerTooltipMode.OnMouseOver
                marker.ToolTip = New GMapBaloonToolTip(marker)
                marker.ToolTipMode = mode
                Dim ToolTipBackColor As SolidBrush
                If _Flag = 1 Then
                    ToolTipBackColor = New SolidBrush(Color.Green)
                    marker.ToolTip.Fill = ToolTipBackColor

                    marker.ToolTip.Foreground = Brushes.White
                    marker.Tag = data
                    _Overlay.Markers.Add(marker)
                    'mapa.Overlays.Add(markersOverlay)
                Else
                    ToolTipBackColor = New SolidBrush(Color.Red)
                    marker.ToolTip.Fill = ToolTipBackColor
                    marker.ToolTip.Foreground = Brushes.Red
                    marker.Tag = data
                    _Overlay.Markers.Add(marker)
                    'mapa.Overlays.Add(markersOverlay)
                End If

                'mapa.Overlays.Add(markersOverlay)
            End If

        ElseIf tipo = 2 Then

            If (Not IsNothing(_Overlay)) Then
                'añadir puntos
                'Dim markersOverlay As New GMapOverlay("markers")
                Dim marker As New GMarkerGoogle(pointLatLng, My.Resources.mark)

                Dim _imagen As New Bitmap(GetResourceMapa(18 + 1), 20, 30)
                marker = New GMarkerGoogle(pointLatLng, _imagen)
                'añadir tooltip
                Dim mode As MarkerTooltipMode = MarkerTooltipMode.OnMouseOver
                marker.ToolTip = New GMapBaloonToolTip(marker)
                marker.ToolTipMode = mode
                Dim ToolTipBackColor As SolidBrush
                If _Flag = 1 Then
                    ToolTipBackColor = New SolidBrush(Color.Green)
                    marker.ToolTip.Fill = ToolTipBackColor

                    marker.ToolTip.Foreground = Brushes.White
                    marker.Tag = data
                    _Overlay.Markers.Add(marker)
                    'mapa.Overlays.Add(markersOverlay)
                Else
                    ToolTipBackColor = New SolidBrush(Color.Red)
                    marker.ToolTip.Fill = ToolTipBackColor
                    marker.ToolTip.Foreground = Brushes.Red
                    marker.Tag = data
                    _Overlay.Markers.Add(marker)
                    'mapa.Overlays.Add(markersOverlay)
                End If

                'mapa.Overlays.Add(markersOverlay)

            End If
        End If


    End Sub

    Private Sub P_AgregarPuntoFuera(pointLatLng As PointLatLng, _nombre As String, _ci As String, data As System.Data.DataRow, _Flag As Integer, tipo As Integer)
        If tipo = 1 Then
            If (Not IsNothing(_Overlay)) Then
                'añadir puntos
                'Dim markersOverlay As New GMapOverlay("markers")
                Dim marker As New GMarkerGoogle(pointLatLng, My.Resources.mark)

                Dim _imagen As New Bitmap(GetResourceMapa(23 + 1), 20, 30)
                marker = New GMarkerGoogle(pointLatLng, _imagen)
                'añadir tooltip
                Dim mode As MarkerTooltipMode = MarkerTooltipMode.OnMouseOver
                marker.ToolTip = New GMapBaloonToolTip(marker)
                marker.ToolTipMode = mode
                Dim ToolTipBackColor As SolidBrush
                If _Flag = 1 Then
                    ToolTipBackColor = New SolidBrush(Color.Green)
                    marker.ToolTip.Fill = ToolTipBackColor

                    marker.ToolTip.Foreground = Brushes.White
                    marker.Tag = data
                    _Overlay.Markers.Add(marker)
                    'mapa.Overlays.Add(markersOverlay)
                Else
                    ToolTipBackColor = New SolidBrush(Color.Red)
                    marker.ToolTip.Fill = ToolTipBackColor
                    marker.ToolTip.Foreground = Brushes.Red
                    marker.Tag = data
                    _Overlay.Markers.Add(marker)
                    'mapa.Overlays.Add(markersOverlay)
                End If

                'mapa.Overlays.Add(markersOverlay)
            End If

        ElseIf tipo = 0 Then

            If (Not IsNothing(_Overlay)) Then
                'añadir puntos
                'Dim markersOverlay As New GMapOverlay("markers")
                Dim marker As New GMarkerGoogle(pointLatLng, My.Resources.mark)

                Dim _imagen As New Bitmap(GetResourceMapa(2 + 1), 20, 30)
                marker = New GMarkerGoogle(pointLatLng, _imagen)
                'añadir tooltip
                Dim mode As MarkerTooltipMode = MarkerTooltipMode.OnMouseOver
                marker.ToolTip = New GMapBaloonToolTip(marker)
                marker.ToolTipMode = mode
                Dim ToolTipBackColor As SolidBrush
                If _Flag = 1 Then
                    ToolTipBackColor = New SolidBrush(Color.Green)
                    marker.ToolTip.Fill = ToolTipBackColor

                    marker.ToolTip.Foreground = Brushes.White
                    marker.Tag = data
                    _Overlay.Markers.Add(marker)
                    'mapa.Overlays.Add(markersOverlay)
                Else
                    ToolTipBackColor = New SolidBrush(Color.Red)
                    marker.ToolTip.Fill = ToolTipBackColor
                    marker.ToolTip.Foreground = Brushes.Red
                    marker.Tag = data
                    _Overlay.Markers.Add(marker)
                    'mapa.Overlays.Add(markersOverlay)
                End If

                'mapa.Overlays.Add(markersOverlay)
            End If

        ElseIf tipo = 2 Then

            If (Not IsNothing(_Overlay)) Then
                'añadir puntos
                'Dim markersOverlay As New GMapOverlay("markers")
                Dim marker As New GMarkerGoogle(pointLatLng, My.Resources.mark)

                Dim _imagen As New Bitmap(GetResourceMapa(18 + 1), 20, 30)
                marker = New GMarkerGoogle(pointLatLng, _imagen)
                'añadir tooltip
                Dim mode As MarkerTooltipMode = MarkerTooltipMode.OnMouseOver
                marker.ToolTip = New GMapBaloonToolTip(marker)
                marker.ToolTipMode = mode
                Dim ToolTipBackColor As SolidBrush
                If _Flag = 1 Then
                    ToolTipBackColor = New SolidBrush(Color.Green)
                    marker.ToolTip.Fill = ToolTipBackColor

                    marker.ToolTip.Foreground = Brushes.White
                    marker.Tag = data
                    _Overlay.Markers.Add(marker)
                    'mapa.Overlays.Add(markersOverlay)
                Else
                    ToolTipBackColor = New SolidBrush(Color.Red)
                    marker.ToolTip.Fill = ToolTipBackColor
                    marker.ToolTip.Foreground = Brushes.Red
                    marker.Tag = data
                    _Overlay.Markers.Add(marker)
                    'mapa.Overlays.Add(markersOverlay)
                End If

                'mapa.Overlays.Add(markersOverlay)

            End If
        End If
    End Sub

    Public Sub _prDibujarMarketCliente(n As Integer, Cliente As DataTable, tipo As Integer)
        If (n < 0) Then
            Return

        Else
            Dim lat As Double = Cliente.Rows(n).Item("Latitud")
            Dim longitud As Double = Cliente.Rows(n).Item("Longitud")

            If (lat <> 0 And longitud <> 0) Then
                Dim plg As PointLatLng = New PointLatLng(lat, longitud)

                _latitud = plg.Lat
                _longitud = plg.Lng

                cont += 1
                If tipo = 1 Then
                    If Cliente.Rows(n).Item("PedidoId") = 0 Then
                        Dim punto As New Tuple(Of Double, Double)(_latitud, _longitud)


                        Dim poligono1 As New List(Of Tuple(Of Double, Double))
                        For i = 0 To _ListPuntos.Count - 1 Step 1
                            Dim latlong As New Tuple(Of Double, Double)(_ListPuntos(i).Lat, _ListPuntos(i).Lng)
                            poligono1.Add(latlong)
                        Next
                        If PuntoEnPoligono(punto, poligono1) Then
                            P_AgregarPunto(plg, "", "", Cliente.Rows(n), 1, 2)
                        Else

                        End If

                    Else
                        P_AgregarPunto(plg, "", "", Cliente.Rows(n), 1, tipo)
                    End If

                Else
                    P_AgregarPunto(plg, "", "", Cliente.Rows(n), 1, tipo)
                End If

            End If
            _prDibujarMarketCliente(n - 1, Cliente, tipo)



        End If



    End Sub



    Private Sub CargarChoferes()
        Try
            'Dim listResult As List(Of VCombo) = New LPersonal().ListarRepatidorCombo()
            Dim listResult As DataTable = ListarUsuariosDespacho(gi_userSuc)
            With cbRepartidor.DropDownList
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
            'cbRepartidor.VisualStyle = VisualStyles.Office2007

            cbRepartidor.SelectedIndex = 0
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Sub



    Private Sub ButtonX1_Click(sender As Object, e As EventArgs) Handles ButtonX1.Click
        Me.Close()
    End Sub

    Private Sub btGenerar_Click(sender As Object, e As EventArgs) Handles btGenerar.Click
        GenerarReporte()
    End Sub

    Function PuntoEnPoligono(punto As Tuple(Of Double, Double), poligono As List(Of Tuple(Of Double, Double))) As Boolean
        ' punto: Tupla con la latitud y longitud del punto a verificar
        ' poligono: Lista de tuplas de latitud y longitud que definen el polígono

        Dim x As Double = punto.Item1
        Dim y As Double = punto.Item2
        Dim n As Integer = poligono.Count
        Dim dentro As Boolean = False

        For i As Integer = 0 To n - 1
            ' Definir el punto actual y el siguiente en el polígono
            Dim lat1 As Double = poligono(i).Item1
            Dim lon1 As Double = poligono(i).Item2
            Dim lat2 As Double = poligono((i + 1) Mod n).Item1
            Dim lon2 As Double = poligono((i + 1) Mod n).Item2

            ' Verificar si el rayo horizontal cruza el segmento del polígono
            If y > Math.Min(lon1, lon2) AndAlso y <= Math.Max(lon1, lon2) Then
                If x <= Math.Max(lat1, lat2) Then
                    If lon1 <> lon2 Then
                        ' Calcular la intersección
                        Dim interseccion As Double = (y - lon1) * (lat2 - lat1) / (lon2 - lon1) + lat1
                        If lat1 = lat2 OrElse x <= interseccion Then
                            dentro = Not dentro
                        End If
                    End If
                End If
            End If
        Next

        Return dentro
    End Function





    Private Function _prInterpretarDatos() As DataTable
        Dim dt As DataTable

        dt = L_prListarDetalleVentas(cbRepartidor.Value, Tb_Fecha.Value.ToString("dd/MM/yyyy"))
        Return dt


    End Function

    Private Sub GenerarReporte()

        dt = _prInterpretarDatos()
        If dt.Rows.Count > 0 Then

            Dim objrep As New R_DetalleVentas()

            objrep.SetDataSource(dt)
            objrep.SetParameterValue("fechaI", Tb_Fecha.Value.ToString("dd/MM/yyyy"))
            objrep.SetParameterValue("repartidor", cbRepartidor.Text)
            CrystalReportViewer1.ReportSource = objrep

        Else

        End If
    End Sub

End Class