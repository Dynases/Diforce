Imports Logica.AccesoLogica
Imports DevComponents.DotNetBar
Imports DevComponents.DotNetBar.Controls

Public Class R01_VentaEfectivaProducto
    Dim _Inter As Integer = 0
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
        If (Not gb_ConexionAbierta) Then
            L_prAbrirConexion()
        End If

        Me.Text = "REPORTE EFECTIVIDAD POR PRODUCTO"
        MCrReporte.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
        _IniciarComponentes()
    End Sub

    Public Sub _IniciarComponentes()
        CheckTodosVendedor.Checked = True
        checkTododCliente.Checked = True
        checkTodosProducto.Checked = True

    End Sub


    Public Sub _prInterpretarDatos(ByRef _dt As DataTable)


        _dt = L_prReporteVentasEfectividadProducto(tbFechaI.Value.ToString("dd/MM/yyyy"), tbFechaF.Value.ToString("dd/MM/yyyy"), IIf(CheckTodosVendedor.Checked, -1, tbCodigoVendedor.Text), IIf(checkTododCliente.Checked, -1, tbCodigoCliente.Text), IIf(checkTodosProducto.Checked, -1, tbCodigoProducto.Text))
        Return


    End Sub
    Private Sub _prCargarReporte()
        Dim _dt As New DataTable
        _prInterpretarDatos(_dt)
        If (_dt.Rows.Count > 0) Then

            Dim objrep As New R_VentasEfectividadProducto
            objrep.SetDataSource(_dt)
            Dim fechaI As String = tbFechaI.Value.ToString("dd/MM/yyyy")
            Dim fechaF As String = tbFechaF.Value.ToString("dd/MM/yyyy")
            objrep.SetParameterValue("usuario", L_Usuario)
            objrep.SetParameterValue("fechaI", fechaI)
            objrep.SetParameterValue("fechaF", fechaF)
            objrep.SetParameterValue("vendedor", IIf(CheckTodosVendedor.Checked, "TODOS", tbVendedor.Text))
            objrep.SetParameterValue("cliente", IIf(checkTododCliente.Checked, "TODOS", tbCliente.Text))
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
        Me.Close()
        _modulo.Select()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        _Inter = _Inter + 1
        If _Inter = 1 Then
            Me.WindowState = FormWindowState.Normal

        Else
            Me.Opacity = 100
            Timer1.Enabled = False
        End If

    End Sub



    Private Sub tbVendedor_TextChanged(sender As Object, e As EventArgs)

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

    Private Sub checkUnaVendedor_CheckValueChanged(sender As Object, e As EventArgs) Handles checkUnaVendedor.CheckValueChanged
        If (checkUnaVendedor.Checked) Then
            CheckTodosVendedor.CheckValue = False
            tbVendedor.Enabled = True
            tbVendedor.BackColor = Color.White
            tbVendedor.Focus()

        End If
    End Sub

    Private Sub tbVendedor_KeyDown(sender As Object, e As KeyEventArgs) Handles tbVendedor.KeyDown
        If e.KeyData = Keys.Control + Keys.Enter Then
            _prListarPrevendedores()
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
        dt = L_prListarClientes()
        'a.cbnumi , a.cbdesc As nombre, a.cbdirec, a.cbtelef, a.cbfnac 
        Dim listEstCeldas As New List(Of Modelo.MCelda)
        listEstCeldas.Add(New Modelo.MCelda("ccnumi", True, "ID", 50))
        listEstCeldas.Add(New Modelo.MCelda("nombre", True, "NOMBRE", 280))
        listEstCeldas.Add(New Modelo.MCelda("ccdirec", True, "DIRECCION", 220))
        listEstCeldas.Add(New Modelo.MCelda("cctelf1", True, "Telefono".ToUpper, 200))
        Dim ef = New Efecto
        ef.tipo = 3
        ef.dt = dt
        ef.SeleclCol = 1
        ef.listEstCeldas = listEstCeldas
        ef.alto = 50
        ef.ancho = 350
        ef.Context = "Seleccione Cliente".ToUpper
        ef.ShowDialog()
        Dim bandera As Boolean = False
        bandera = ef.band
        If (bandera = True) Then
            Dim Row As Janus.Windows.GridEX.GridEXRow = ef.Row
            If (IsNothing(Row)) Then
                tbCliente.Focus()
                Return
            End If
            tbCodigoCliente.Text = Row.Cells("ccnumi").Value
            tbCliente.Text = Row.Cells("nombre").Value
            MBtGenerar.Select()

        End If


    End Sub


    Public Sub _prListarProductos()

        Dim dt As DataTable
        dt = L_prListarProductos()
        'a.cbnumi , a.cbdesc As nombre, a.cbdirec, a.cbtelef, a.cbfnac 
        Dim listEstCeldas As New List(Of Modelo.MCelda)
        listEstCeldas.Add(New Modelo.MCelda("canumi", True, "COD.", 50))
        listEstCeldas.Add(New Modelo.MCelda("cacod", True, "COD. PRODUCTO", 220))
        listEstCeldas.Add(New Modelo.MCelda("cadesc", True, "NOMBRE", 280))
        Dim ef = New Efecto
        ef.tipo = 3
        ef.dt = dt
        ef.SeleclCol = 1
        ef.listEstCeldas = listEstCeldas
        ef.alto = 50
        ef.ancho = 350
        ef.Context = "Seleccione Cliente".ToUpper
        ef.ShowDialog()
        Dim bandera As Boolean = False
        bandera = ef.band
        If (bandera = True) Then
            Dim Row As Janus.Windows.GridEX.GridEXRow = ef.Row
            If (IsNothing(Row)) Then
                tbProducto.Focus()
                Return
            End If
            tbCodigoProducto.Text = Row.Cells("canumi").Value
            tbProducto.Text = Row.Cells("cadesc").Value
            MBtGenerar.Select()

        End If


    End Sub
    Private Sub checkUnoCliente_CheckValueChanged(sender As Object, e As EventArgs) Handles checkUnoCliente.CheckValueChanged
        If (checkUnoCliente.Checked) Then
            checkTododCliente.CheckValue = False
            tbCliente.Enabled = True
            tbCliente.BackColor = Color.White
            tbCliente.Focus()

        End If
    End Sub

    Private Sub checkUnoProducto_CheckValueChanged(sender As Object, e As EventArgs) Handles checkUnoProducto.CheckValueChanged
        If (checkUnoProducto.Checked) Then
            checkTodosProducto.CheckValue = False
            tbProducto.Enabled = True
            tbProducto.BackColor = Color.White
            tbProducto.Focus()

        End If
    End Sub

    Private Sub checkTododCliente_CheckedChanged(sender As Object, e As EventArgs) Handles checkTododCliente.CheckedChanged

    End Sub

    Private Sub checkTododCliente_CheckValueChanged(sender As Object, e As EventArgs) Handles checkTododCliente.CheckValueChanged
        If (checkTododCliente.Checked) Then
            checkUnoCliente.CheckValue = False
            tbCliente.Enabled = True
            tbCliente.BackColor = Color.Gainsboro
            tbCliente.Clear()
            tbCodigoCliente.Clear()

        End If
    End Sub

    Private Sub checkTodosProducto_CheckValueChanged(sender As Object, e As EventArgs) Handles checkTodosProducto.CheckValueChanged
        If (checkTodosProducto.Checked) Then
            checkUnoProducto.CheckValue = False
            tbProducto.Enabled = True
            tbProducto.BackColor = Color.Gainsboro
            tbProducto.Clear()
            tbCodigoProducto.Clear()

        End If
    End Sub

    Private Sub tbCliente_KeyDown(sender As Object, e As KeyEventArgs) Handles tbCliente.KeyDown
        If e.KeyData = Keys.Control + Keys.Enter Then
            _prListarClientes()
        End If
    End Sub

    Private Sub tbProducto_KeyDown(sender As Object, e As KeyEventArgs) Handles tbProducto.KeyDown
        If e.KeyData = Keys.Control + Keys.Enter Then
            _prListarProductos()
        End If
    End Sub
End Class