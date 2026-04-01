
Imports DevComponents.DotNetBar
Imports DevComponents.DotNetBar.Controls
Imports GMap.NET
Imports GMap.NET.MapProviders
Imports GMap.NET.WindowsForms
Imports GMap.NET.WindowsForms.Markers
Imports GMap.NET.WindowsForms.ToolTips
Imports Logica.AccesoLogica
Imports UTILITIES




Imports System.IO
Imports Janus.Data
Imports Janus.Windows.GridEX


Public Class R01_ReporteFacturas
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
        tbFechaI.Value = Date.Now
        tbFechaF.Value = Date.Now

    End Sub



    Private Sub ButtonX1_Click(sender As Object, e As EventArgs) Handles ButtonX1.Click
        Me.Close()
    End Sub

    Private Sub btGenerar_Click(sender As Object, e As EventArgs) Handles btGenerar.Click
        GenerarReporte()
    End Sub





    Private Function _prInterpretarDatos() As DataTable
        Dim dt As DataTable

        dt = ObtenerFacturas(tbFechaI.Value.ToString("dd/MM/yyyy"), tbFechaF.Value.ToString("dd/MM/yyyy"), gi_userSuc)
        Return dt


    End Function

    Private Sub GenerarReporte()
        Dim dt As DataTable
        dt = _prInterpretarDatos()
        If dt.Rows.Count > 0 Then

            Dim objrep As New R_Facturas()



            objrep.SetDataSource(dt)

            objrep.SetParameterValue("FechaI", tbFechaI.Value.ToString("dd/MM/yyyy"))
            objrep.SetParameterValue("FechaF", tbFechaF.Value.ToString("dd/MM/yyyy"))
                'objrep.SetParameterValue("repartidor", cbRepartidor.Text)

                CrystalReportViewer1.ReportSource = objrep

            Else
            MostrarMensajeError("No existen datos para llenar el reporte")
        End If
    End Sub


    Private Sub MostrarMensajeError(mensaje As String)
        ToastNotification.Show(Me,
                               mensaje.ToUpper,
                               My.Resources.WARNING,
                               ENMensaje.MEDIANO,
                               eToastGlowColor.Red,
                               eToastPosition.BottomLeft)
    End Sub
End Class