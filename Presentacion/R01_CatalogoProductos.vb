Imports Logica.AccesoLogica
Imports DevComponents.DotNetBar
Imports DevComponents.DotNetBar.Controls

Public Class R01_CatalogoProductos
    Dim _inter As Integer = 0
#Region "Variables Globales"

    Public _nameButton As String
    Public _tab As SuperTabItem
    Public _modulo As SideNavItem

#End Region

#Region "Eventos"

    Private Sub My_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        P_prInicio()
    End Sub

    Private Sub MBtGenerar_Click(sender As Object, e As EventArgs) Handles MBtGenerar.Click
        P_prCargarReporte()
    End Sub

    Private Sub MBtSalir_Click(sender As Object, e As EventArgs) Handles MBtSalir.Click
        Me.Close()
        _modulo.Select()
        '_tab.Close()
    End Sub

#End Region

#Region "Metodos"

    Private Sub P_prInicio()
        'Abrir conexion
        If (Not gb_ConexionAbierta) Then
            L_prAbrirConexion()
        End If

        Me.Text = "S T O C K   D I S P O N I B L E".ToUpper
        'Me.WindowState = FormWindowState.Maximized
        MCrReporte.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
        _prCargarComboLibreriaDeposito(cbAlmacen)
        P_prArmarComboProveedor()
        'If gs_MostrarSucursal = 1 Then
        '    lbDepositoOrigen.Visible = True
        '    cbAlmacen.Visible = True
        'Else
        '    lbDepositoOrigen.Visible = False
        '    cbAlmacen.Visible = False
        'End If
    End Sub

    Private Sub P_prArmarComboProveedor()
        Dim DtP As DataTable
        DtP = L_fnObtenerProveedor()
        DtP.Rows.Add(0, "TODOS")

        g_prArmarCombo(cbProveedor, DtP, 60, 200, "COD", "PROVEEDOR")
        cbProveedor.SelectedIndex = Convert.ToInt32(DtP.Rows.Count - 1)

    End Sub
    Private Sub _prCargarComboLibreriaDeposito(mCombo As Janus.Windows.GridEX.EditControls.MultiColumnCombo)
        Dim dt As New DataTable
        dt = L_fnMovimientoListarSucursales(gi_userSuc)
        'dt.Rows.Add(-1, "Todos")
        With mCombo
            .DropDownList.Columns.Clear()
            .DropDownList.Columns.Add("aanumi").Width = 60
            .DropDownList.Columns("aanumi").Caption = "COD"
            .DropDownList.Columns.Add("aabdes").Width = 500
            .DropDownList.Columns("aabdes").Caption = "SUCURSAL"
            .ValueMember = "aanumi"
            .DisplayMember = "aabdes"
            .DataSource = dt
            .Refresh()
        End With

        'mCombo.Value = 1
        If (dt.Rows.Count > 0) Then
            mCombo.SelectedIndex = 0
        End If
    End Sub

    Private Sub P_prCargarReporte()
        Dim _dt As New DataTable

        Dim precio As Integer = IIf(swTipo.Value = True, 1, 0)

        Dim objrep As New R_CatalogoProductos()
        '_dt = L_VistaStockDisponible()
        _dt = L_fnStockCatalogo()

        objrep.SetDataSource(_dt)
        objrep.SetParameterValue("precio", precio)

        MCrReporte.ReportSource = objrep

    End Sub

#End Region
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