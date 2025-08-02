Imports Logica.AccesoLogica
Imports DevComponents.DotNetBar
Imports DevComponents.DotNetBar.Controls

Public Class R01_VentasProductosInv
    Dim _inter As Integer = 0
#Region "VARIABLES GLOBALES"
    Public _nameButton As String
    Public _tab As SuperTabItem
    Dim titulo As String = ""
    Public _modulo As SideNavItem
#End Region
#Region "METODOS PRIVADOS"
    Public Sub _prIniciarTodo()
        tbFechaI.Value = Now.Date
        tbFechaF.Value = Now.Date
        'If (Not gb_ConexionAbierta) Then
        '    L_prAbrirConexion()
        'End If
        'Me.WindowState = FormWindowState.Maximized
        L_prAbrirConexion(gs_Ip, gs_UsuarioSql, gs_ClaveSql, gs_NombreBD)
        Me.Text = "REPORTE PRODUCTOS INVENTARIO"
        MCrReporte.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
        checkNo.CheckValue = True

    End Sub


    Private Sub _prCargarReporte()
        Dim _dt As New DataTable
        If checkNo.Checked Then
            _dt = L_prReporteVentasProductosInventario(tbFechaI.Value.ToString("yyyy/MM/dd"), tbFechaF.Value.ToString("yyyy/MM/dd"))
        Else
            _dt = L_prReporteVentasProductosInventarioMin(tbFechaI.Value.ToString("yyyy/MM/dd"), tbFechaF.Value.ToString("yyyy/MM/dd"))
        End If

        If (_dt.Rows.Count > 0) Then

            Dim objrep As New R_VentasProductosInventario
            objrep.SetDataSource(_dt)
            Dim fechaI As String = tbFechaI.Value.ToString("dd/MM/yyyy")
            Dim fechaF As String = tbFechaF.Value.ToString("dd/MM/yyyy")
            objrep.SetParameterValue("usuario", L_Usuario)
            objrep.SetParameterValue("fechaI", fechaI)
            objrep.SetParameterValue("fechaF", fechaF)

            MCrReporte.ReportSource = objrep
            MCrReporte.Show()
            MCrReporte.BringToFront()
        Else
            ToastNotification.Show(Me, "NO HAY DATOS PARA LOS PARAMETROS SELECCIONADOS..!!!",
                                       My.Resources.INFORMATION, 2000,
                                       eToastGlowColor.Blue,
                                       eToastPosition.BottomLeft)
            MCrReporte.ReportSource = Nothing
        End If

    End Sub

    Private Sub MBtGenerar_Click(sender As Object, e As EventArgs) Handles MBtGenerar.Click
        _prCargarReporte()
    End Sub

    Private Sub R01_VentasAtendidas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        _prIniciarTodo()

    End Sub
#End Region



    Private Sub MBtSalir_Click(sender As Object, e As EventArgs) Handles MBtSalir.Click
        '_tab.Close()

        Me.Close()
    End Sub
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        _inter = _inter + 1
        If _inter = 1 Then
            Me.WindowState = FormWindowState.Normal

        Else
            Me.Opacity = 100
            Timer1.Enabled = False
        End If
        'Me.Opacity = 100
        'Timer1.Enabled = False
    End Sub


End Class