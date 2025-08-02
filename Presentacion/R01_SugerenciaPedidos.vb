Imports Logica.AccesoLogica
Imports DevComponents.DotNetBar
Imports DevComponents.DotNetBar.Controls

Public Class R01_SugerenciaPedidos

    Private Sub cargarComboMeses(mCombo As Janus.Windows.GridEX.EditControls.MultiColumnCombo)
        Dim dt As New DataTable
        dt.Columns.Add("Codigo", GetType(Integer))
        dt.Columns.Add("Mes", GetType(String))
        'dt = L_fnMovimientoListarMeses()
        dt.Rows.Add(1, "ENERO")
        dt.Rows.Add(2, "FEBRERO")
        dt.Rows.Add(3, "MARZO")
        dt.Rows.Add(4, "ABRIL")
        dt.Rows.Add(5, "MAYO")
        dt.Rows.Add(6, "JUNIO")
        dt.Rows.Add(7, "JULIO")
        dt.Rows.Add(8, "AGOSTO")
        dt.Rows.Add(9, "SEPTIEMBRE")
        dt.Rows.Add(10, "OCTUBRE")
        dt.Rows.Add(11, "NOVIEMBRE")
        dt.Rows.Add(12, "DICIEMBRE")

        With mCombo
            .DropDownList.Columns.Clear()
            .DropDownList.Columns.Add("Codigo").Width = 60
            .DropDownList.Columns("Codigo").Caption = "COD"
            .DropDownList.Columns.Add("Mes").Width = 200
            .DropDownList.Columns("Mes").Caption = "MES"
            .ValueMember = "Codigo"
            .DisplayMember = "Mes"
            .DataSource = dt
            .Refresh()
        End With

        'mCombo.Value = -1
        If (dt.Rows.Count > 0) Then
            mCombo.SelectedIndex = -1
        End If
    End Sub

    Private Sub P_prArmarComboProveedor()
        Dim DtP As DataTable
        DtP = L_fnObtenerProveedor()
        DtP.Rows.Add(0, "TODOS")

        g_prArmarCombo(cbProveedor, DtP, 60, 200, "COD", "PROVEEDOR")
        cbProveedor.SelectedIndex = Convert.ToInt32(DtP.Rows.Count - 1)

    End Sub
    Private Sub R01_SugerenciaPedidos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        P_prArmarComboProveedor()
        cargarComboMeses(cbAlmacen)
    End Sub

    Private Sub CargarReporte()
        Dim _dt As New DataTable
        _dt = L_fnPedidoSugerencia(cbAlmacen.Value, cbProveedor.Value, CInt(tbAnio.Text))

        If _dt.Rows.Count > 0 Then
            'Dim provee As String = cbProv.Text
            Dim objrep As New R_SugerenciaPedido()

            objrep.SetDataSource(_dt)
            'objrep.SetParameterValue("proveedor", provee)
            MCrReporte.ReportSource = objrep

        Else
            ToastNotification.Show(Me, "No Existe ningun dato para los parametros seleccionados!!".ToUpper,
                                    My.Resources.OK,
                                    5 * 1000,
                                    eToastGlowColor.Red,
                                    eToastPosition.TopCenter)
            Return
        End If

    End Sub

    Private Sub MBtGenerar_Click(sender As Object, e As EventArgs) Handles MBtGenerar.Click
        CargarReporte()
    End Sub

    Private Sub MBtSalir_Click(sender As Object, e As EventArgs) Handles MBtSalir.Click
        Me.Close()
    End Sub
End Class