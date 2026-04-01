Imports Logica.AccesoLogica
Imports DevComponents.DotNetBar
Imports DevComponents.DotNetBar.Controls
Public Class R0_ReportePedidosCostoGastos

    Dim _Inter As Integer = 0
#Region "VARIABLES GLOBALES"
    Public _nameButton As String
    Public _tab As SuperTabItem
    Dim titulo As String = ""
    Public _modulo As SideNavItem

#End Region

    Public Sub _prIniciarTodo()

        If (Not gb_ConexionAbierta) Then
            L_prAbrirConexion()
        End If
        'Me.WindowState = FormWindowState.Maximized
        '' L_prAbrirConexion(gs_Ip, gs_UsuarioSql, gs_ClaveSql, gs_NombreBD)
        Me.Text = "REPORTE DE UTILIDADES"
        MCrReporte.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
        _IniciarComponentes()
        tbFechaI.Value = Now.Date
        tbFechaF.Value = Now.Date
    End Sub

    Public Sub _IniciarComponentes()
        tbVendedor.ReadOnly = True
        tbVendedor.Enabled = False
        CheckTodosVendedor.CheckValue = True
        tbFechaI.Value = Now.Date
        tbFechaF.Value = Now.Date
        CheckBoxX1.Checked = True
    End Sub

    Public Sub _prInterpretarDatos(ByRef _dt As DataTable)


        If (CheckTodosVendedor.Checked) Then
            _dt = L_prListarReportePEdidosVsCosto(tbFechaI.Value.ToString("yyyy/MM/dd"), tbFechaF.Value.ToString("yyyy/MM/dd"), IIf(CheckBoxX2.Checked, CInt(tbCodigoCliente.Text), -1))
            Return
        End If
        If (checkUnaVendedor.Checked) Then
            If (tbCodigoVendedor.Text <> String.Empty) Then
                _dt = L_prListarReportePEdidosVsCostoUnVendedor(tbFechaI.Value.ToString("yyyy/MM/dd"), tbFechaF.Value.ToString("yyyy/MM/dd"), tbCodigoVendedor.Text, IIf(CheckBoxX2.Checked, CInt(tbCodigoCliente.Text), -1))
                Return
            End If

        End If



    End Sub
    Private Sub _prCargarReporte()
        Dim _dt As New DataTable
        If ((tbFechaI.Value.ToString = String.Empty) Or (tbFechaF.Value.ToString = String.Empty)) Then
            ToastNotification.Show(Me, "Selecione fechas Validas!!!",
                                       My.Resources.INFORMATION, 2000,
                                       eToastGlowColor.Blue,
                                       eToastPosition.BottomLeft)
            MCrReporte.ReportSource = Nothing
            Return
        End If

        _prInterpretarDatos(_dt)

        Dim gastos As Double = TraerGastosEntreFechas(tbFechaI.Value.ToString("dd/MM/yyyy"), tbFechaF.Value.ToString("dd/MM/yyyy"))

        If (_dt.Rows.Count > 0) Then

            Dim objrep As New R_Pedido_PrecioCostoGastos
            objrep.SetDataSource(_dt)
            Dim fechaI As String = tbFechaI.Value.ToString("dd/MM/yyyy")
            Dim fechaF As String = tbFechaF.Value.ToString("dd/MM/yyyy")
            objrep.SetParameterValue("FechaIni", fechaI)
            objrep.SetParameterValue("FechaFin", fechaF)
            objrep.SetParameterValue("gastos", gastos)
            objrep.SetParameterValue("Usuario", L_Usuario)
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

    Private Sub MBtSalir_Click(sender As Object, e As EventArgs) Handles MBtSalir.Click
        '_tab.Close()
        _modulo.Select()
        Close()
    End Sub

    Private Sub checkUnaVendedor_CheckValueChanged(sender As Object, e As EventArgs) Handles checkUnaVendedor.CheckValueChanged
        If (checkUnaVendedor.Checked) Then
            CheckTodosVendedor.CheckValue = False
            tbVendedor.Enabled = True
            tbVendedor.BackColor = Color.White
            tbVendedor.Focus()

        End If
    End Sub

    Public Sub _prListarPrevendedores()

        Dim dt As DataTable
        dt = L_prListarPrevendedor(gi_userSuc)
        'a.cbnumi , a.cbdesc As nombre, a.cbdirec, a.cbtelef, a.cbfnac 
        Dim listEstCeldas As New List(Of Modelo.MCelda)
        listEstCeldas.Add(New Modelo.MCelda("cbnumi", True, "ID", 50))
        listEstCeldas.Add(New Modelo.MCelda("nombre", True, "NOMBRE", 280))
        listEstCeldas.Add(New Modelo.MCelda("cbdirec", True, "DIRECCION", 220))
        listEstCeldas.Add(New Modelo.MCelda("cbtelef", True, "Telefono".ToUpper, 200))
        listEstCeldas.Add(New Modelo.MCelda("cbfnac", True, "F.Nacimiento".ToUpper, 150, "MM/dd,yyyy"))
        Dim ef = New Efecto
        ef.tipo = 3
        ef.dt = dt
        ef.SeleclCol = 1
        ef.listEstCeldas = listEstCeldas
        ef.alto = 50
        ef.ancho = 350
        ef.Context = "Seleccione PREVENDEDOR".ToUpper
        ef.ShowDialog()
        Dim bandera As Boolean = False
        bandera = ef.band
        If (bandera = True) Then
            Dim Row As Janus.Windows.GridEX.GridEXRow = ef.Row
            If (IsNothing(Row)) Then
                tbVendedor.Focus()
                Return
            End If
            tbCodigoVendedor.Text = Row.Cells("cbnumi").Value
            tbVendedor.Text = Row.Cells("nombre").Value
            MBtGenerar.Select()

        End If


    End Sub

    Public Sub _prListarClientes()

        Dim dt As DataTable
        dt = L_prListarCliente(gi_userSuc)
        'a.cbnumi , a.cbdesc As nombre, a.cbdirec, a.cbtelef, a.cbfnac 
        Dim listEstCeldas As New List(Of Modelo.MCelda)
        listEstCeldas.Add(New Modelo.MCelda("ccnumi", True, "ID", 50))
        listEstCeldas.Add(New Modelo.MCelda("cccod", False))
        listEstCeldas.Add(New Modelo.MCelda("ccdesc", True, "NOMBRE", 280))
        listEstCeldas.Add(New Modelo.MCelda("cctelf2", True, "Telefono".ToUpper, 200))
        listEstCeldas.Add(New Modelo.MCelda("ccobs", False))
        Dim ef = New Efecto
        ef.tipo = 3
        ef.dt = dt
        ef.SeleclCol = 1
        ef.listEstCeldas = listEstCeldas
        ef.alto = 50
        ef.ancho = 350
        ef.Context = "Seleccione CLIENTE".ToUpper
        ef.ShowDialog()
        Dim bandera As Boolean = False
        bandera = ef.band
        If (bandera = True) Then
            Dim Row As Janus.Windows.GridEX.GridEXRow = ef.Row
            If (IsNothing(Row)) Then
                tbVendedor.Focus()
                Return
            End If
            tbCodigoCliente.Text = Row.Cells("ccnumi").Value
            tbCliente.Text = Row.Cells("ccdesc").Value
            MBtGenerar.Select()

        End If


    End Sub

    Private Sub CheckTodosVendedor_CheckValueChanged(sender As Object, e As EventArgs) Handles CheckTodosVendedor.CheckValueChanged
        If (CheckTodosVendedor.Checked) Then
            checkUnaVendedor.CheckValue = False
            tbVendedor.Enabled = True
            tbVendedor.BackColor = Color.Gainsboro
            tbVendedor.Clear()
            tbCodigoVendedor.Clear()

        End If
    End Sub

    Private Sub tbVendedor_KeyDown_1(sender As Object, e As KeyEventArgs) Handles tbVendedor.KeyDown
        If (checkUnaVendedor.Checked) Then
            If e.KeyData = Keys.Control + Keys.Enter Then
                _prListarPrevendedores()
            End If

        End If


    End Sub
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

    Private Sub CheckBoxX2_CheckValueChanged(sender As Object, e As EventArgs) Handles CheckBoxX2.CheckValueChanged
        If (CheckBoxX2.Checked) Then
            CheckBoxX1.CheckValue = False
            tbCliente.Enabled = True
            tbCliente.BackColor = Color.White
            tbCliente.Focus()

        End If
    End Sub

    Private Sub CheckBoxX1_CheckValueChanged(sender As Object, e As EventArgs) Handles CheckBoxX1.CheckValueChanged
        If (CheckBoxX1.Checked) Then
            CheckBoxX2.CheckValue = False
            tbCliente.Enabled = True
            tbCliente.BackColor = Color.Gainsboro
            tbCliente.Clear()
            tbCodigoCliente.Text = -1

        End If
    End Sub

    Private Sub tbCliente_KeyDown(sender As Object, e As KeyEventArgs) Handles tbCliente.KeyDown
        If (CheckBoxX2.Checked) Then
            If e.KeyData = Keys.Control + Keys.Enter Then
                _prListarClientes()

            End If

        End If
    End Sub
End Class