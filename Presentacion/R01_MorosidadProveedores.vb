Imports Logica.AccesoLogica
Imports DevComponents.DotNetBar
Imports DevComponents.DotNetBar.Controls
Public Class R01_MorosidadProveedores

#Region "METODOS PRIVADOS"
    Dim Proveedor As String = ""
    Public Sub _prIniciarTodo()
        'Me.WindowState = FormWindowState.Maximized
        Me.Text = "REPORTE MOROSIDAD A PROVEEDORES"
        MCrReporte.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
        _IniciarComponentes()
    End Sub
    Public Sub _IniciarComponentes()
        tbProveedor.ReadOnly = True
        tbProveedor.Enabled = False
        CheckTodosProveedor.CheckValue = True
    End Sub
    Public Sub _prInterpretarDatos(ByRef _dt As DataTable)
        If (CheckTodosProveedor.Checked) Then
            _dt = L_fnReporteMorosidadTodosProveedores()

            Proveedor = "TODOS LOS PROVEEDORES"
        Else
            If (checkUnProveedor.Checked And tbCodigoProveedor.Text.Length > 0) Then
                _dt = L_fnReporteMorosidadUnProveedor(tbCodigoProveedor.Text)
                Proveedor = "" + tbProveedor.Text
            End If
        End If
    End Sub

    Private Sub _prCargarReporte()
        Dim _dt As New DataTable
        _prInterpretarDatos(_dt)
        If (_dt.Rows.Count > 0) Then

            Dim objrep As New R_MorosidadProveedor
            objrep.SetDataSource(_dt)
            objrep.SetParameterValue("usuario", L_Usuario)
            objrep.SetParameterValue("proveedor", Proveedor)
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
#End Region
    Private Sub tbProveedor_KeyDown(sender As Object, e As KeyEventArgs) Handles tbProveedor.KeyDown
        If (checkUnProveedor.Checked) Then
            If e.KeyData = Keys.Control + Keys.Enter Then
                Dim frmAyuda As Modelo.ModeloAyuda
                Dim dt As DataTable = L_fnObtenerTabla("cmnumi, cmdesc, cmnit", "TC010", "cmest=1")
                Dim listEstCeldas As New List(Of Modelo.MCelda)
                listEstCeldas.Add(New Modelo.MCelda("cmnumi", True, "Código", 70))
                listEstCeldas.Add(New Modelo.MCelda("cmdesc", True, "Proveedor", 280))
                listEstCeldas.Add(New Modelo.MCelda("cmnit", False, "Proveedor", 100))

                frmAyuda = New Modelo.ModeloAyuda(100, 200, dt, "Seleccionar proveedor".ToUpper, listEstCeldas)
                'frmAyuda.StartPosition = FormStartPosition.CenterScreen
                frmAyuda.ShowDialog()

                If frmAyuda.seleccionado = True Then
                    Dim id As String = frmAyuda.filaSelect.Cells("cmnumi").Value
                    Dim desc As String = frmAyuda.filaSelect.Cells("cmdesc").Value
                    Dim nit As String = frmAyuda.filaSelect.Cells("cmnit").Value
                    tbCodigoProveedor.Text = id
                    tbProveedor.Text = desc

                End If

            End If

        End If
    End Sub

    Private Sub checkUnProveedor_CheckValueChanged(sender As Object, e As EventArgs) Handles checkUnProveedor.CheckValueChanged
        If (checkUnProveedor.Checked) Then
            CheckTodosProveedor.CheckValue = False
            tbProveedor.Enabled = True
            tbProveedor.BackColor = Color.White
            tbProveedor.Focus()
        End If
    End Sub

    Private Sub CheckTodosProveedor_CheckValueChanged(sender As Object, e As EventArgs) Handles CheckTodosProveedor.CheckValueChanged
        If (CheckTodosProveedor.Checked) Then
            checkUnProveedor.CheckValue = False
            tbProveedor.Enabled = True
            tbProveedor.BackColor = Color.Gainsboro
            tbProveedor.Clear()
            tbCodigoProveedor.Clear()

        End If
    End Sub

    Private Sub MBtGenerar_Click(sender As Object, e As EventArgs) Handles MBtGenerar.Click
        If checkUnProveedor.Checked And tbProveedor.Text = String.Empty Then
            ToastNotification.Show(Me, "DEBE SELECCIONAR UN PROVEEDOR ...!!!",
                           My.Resources.INFORMATION, 2000,
                           eToastGlowColor.Blue,
                           eToastPosition.BottomLeft)
        Else
            _prCargarReporte()
        End If

    End Sub


    Private Sub R01_MorosidadProveedores_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        _prIniciarTodo()
    End Sub

    Private Sub MBtSalir_Click(sender As Object, e As EventArgs) Handles MBtSalir.Click
        Me.Close()
    End Sub
End Class