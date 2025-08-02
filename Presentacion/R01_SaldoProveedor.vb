Imports Logica.AccesoLogica
Public Class R01_SaldoProveedor
    Private Sub R01_SaldoProveedor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        P_prInicio()
        _prCargarComboLibreriaDeposito(cbAlmacen)
        _prCargarComboProveedor(cbProv)
        If gs_MostrarSucursal = 1 Then
            lbDepositoOrigen.Visible = True
            cbAlmacen.Visible = True
        Else
            lbDepositoOrigen.Visible = False
            cbAlmacen.Visible = False
        End If
    End Sub

    Private Sub P_prInicio()
        'Abrir conexion dsds
        If (Not gb_ConexionAbierta) Then
            L_prAbrirConexion()
        End If

        Me.Text = "S A L D O   D E   P R O D U C T O".ToUpper
        'Me.WindowState = FormWindowState.Maximized
        MCrReporte.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None

    End Sub

    Private Sub _prCargarComboLibreriaDeposito(mCombo As Janus.Windows.GridEX.EditControls.MultiColumnCombo)
        Dim dt As New DataTable
        dt = L_fnMovimientoListarSucursales()
        dt.Rows.Add(-1, "Todos")

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

        'mCombo.Value = -1
        If (dt.Rows.Count > 0) Then
            mCombo.SelectedIndex = -1
        End If
    End Sub

    Private Sub _prCargarComboProveedor(mCombo As Janus.Windows.GridEX.EditControls.MultiColumnCombo)
        Dim dt As New DataTable
        dt = L_fnObtenerTabla("cmnumi, cmdesc, cmnit", "TC010", "cmest=1")
        dt.Rows.Add(-1, "Todos")

        With mCombo
            .DropDownList.Columns.Clear()
            .DropDownList.Columns.Add("cmnumi").Width = 60
            .DropDownList.Columns("cmnumi").Caption = "COD"
            .DropDownList.Columns.Add("cmdesc").Width = 500
            .DropDownList.Columns("cmdesc").Caption = "PROVEEDOR"
            .ValueMember = "cmnumi"
            .DisplayMember = "cmdesc"
            .DataSource = dt
            .Refresh()
        End With

        'mCombo.Value = -1
        If (dt.Rows.Count > 0) Then
            mCombo.SelectedIndex = -1
        End If
    End Sub

    Public Function _prInterpretarDatos() As DataTable
        Dim dt As DataTable
        If chkSaldoMayorCero.Checked = True Then
            dt = cargarStockProveedorTodos(cbAlmacen.Value, cbProv.Value)
            Return dt
        End If
        If chkSaldoMayorCero.Checked = False Then
            dt = cargarStockProveedorFiltrado(cbAlmacen.Value, cbProv.Value)
            Return dt
        End If
    End Function
    Private Sub P_prCargarReporte()
        Dim _dt As New DataTable
        _dt = _prInterpretarDatos()

        If _dt.Rows.Count > 0 Then
            Dim provee As String = cbProv.Text
            Dim objrep As New R_SaldoActualFiltrado()

            objrep.SetDataSource(_dt)
            objrep.SetParameterValue("proveedor", provee)
            MCrReporte.ReportSource = objrep

        Else

        End If



        'Else
        '    Dim objrep As New R_StockActualSinAgrupacion()

        '    If (cbAlmacen.Value >= 0) Then
        '        _dt = L_VistaStockActual("cenum=0 and iaalm=" + Str(cbAlmacen.Value) + " " + condicionMayorCero)
        '        objrep.SetDataSource(_dt)
        '        MCrReporte.ReportSource = objrep
        '    Else
        '        _dt = L_VistaStockActual("cenum=0" + " " + condicionMayorCero)
        '        objrep.SetDataSource(_dt)
        '        MCrReporte.ReportSource = objrep
        '    End If

        'End If

    End Sub
    Private Sub swTipo_ValueChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub MBtGenerar_Click(sender As Object, e As EventArgs) Handles MBtGenerar.Click
        P_prCargarReporte()
    End Sub

    Private Sub MBtSalir_Click(sender As Object, e As EventArgs) Handles MBtSalir.Click
        Me.Close()
    End Sub
End Class