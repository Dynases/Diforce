Imports Logica.AccesoLogica
Imports DevComponents.DotNetBar
Imports DevComponents.DotNetBar.Controls
Imports Janus.Windows.GridEX
Imports System.IO

Public Class R01_CoberturaVendedor2
    Dim _Inter As Integer = 0
#Region "VARIABLES GLOBALES"
    Public _nameButton As String
    Public _tab As SuperTabItem
    Dim titulo As String = ""
    Public _modulo As SideNavItem

    Dim RutaGlobal As String = gs_CarpetaRaiz

#End Region
#Region "METODOS PRIVADOS"
    Public Sub _prIniciarTodo()
        tbFechaI.Value = Now.Date
        tbFechaF.Value = Now.Date
        If (Not gb_ConexionAbierta) Then
            L_prAbrirConexion()
        End If

        Me.Text = "REPORTE VENTAS VENDEDOR"
        MCrReporte.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
        _IniciarComponentes()
    End Sub

    Public Sub _IniciarComponentes()
        tbVendedor.ReadOnly = True
        tbVendedor.Enabled = False
        checkUnaVendedor.CheckValue = True
        P_prArmarComboZona()
        P_prArmarComboProveedor()
    End Sub

    Private Sub P_prArmarComboProveedor()
        Dim DtP As DataTable
        DtP = L_fnObtenerProveedor()
        DtP.Rows.Add(0, "TODOS")

        g_prArmarCombo(cbProveedor, DtP, 60, 200, "COD", "PROVEEDOR")
        cbProveedor.SelectedIndex = Convert.ToInt32(DtP.Rows.Count - 1)

    End Sub


    Private Sub P_prArmarComboZona()
        Dim Dt As New DataTable
        Dt = L_prGeneralZonas() 'L_GetZonasCPZ().Tables(0)

        With cbZona.DropDownList
            .Columns.Add(Dt.Columns("lanumi").ToString).Width = 50
            .Columns(0).Caption = "Código"

            .Columns.Add(Dt.Columns("Zona").ToString).Width = 150
            .Columns(1).Caption = "Zona"
        End With

        cbZona.ValueMember = Dt.Columns("lanumi").ToString
        cbZona.DisplayMember = Dt.Columns("zona").ToString
        cbZona.DataSource = Dt
        cbZona.Refresh()
    End Sub

    Public Sub _prInterpretarDatos(ByRef _dt As DataTable)

        titulo = "VENDEDOR:"
        If (CheckTodosVendedor.Checked) Then
            _dt = L_prListarCoberturaVentas2(tbFechaI.Value.ToString("dd/MM/yyyy"), tbFechaF.Value.ToString("dd/MM/yyyy"), cbZona.Value, CInt(tbCodigoVendedor.Text), cbProveedor.Value)
            Return
        End If
        If (checkUnaVendedor.Checked) Then
            _dt = L_prListarCoberturaVentas2(tbFechaI.Value.ToString("dd/MM/yyyy"), tbFechaF.Value.ToString("dd/MM/yyyy"), cbZona.Value, CInt(tbCodigoVendedor.Text), cbProveedor.Value)
            Return
        End If

    End Sub
    Private Sub _prCargarReporte()
        Dim _dt As New DataTable
        _prInterpretarDatos(_dt)
        If (_dt.Rows.Count > 0) Then

            Dim objrep As New R_CoberturaProductos
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
        JGrM_Buscador.DataSource = _dt
        JGrM_Buscador.RetrieveStructure()
        JGrM_Buscador.AlternatingColors = True


    End Sub

    Private Sub MBtGenerar_Click(sender As Object, e As EventArgs) Handles MBtGenerar.Click
        If tbVendedor.Text = "" Then
            ToastNotification.Show(Me, "SELECCIONE UN CLIENTE..!!!",
                                       My.Resources.INFORMATION, 2000,
                                       eToastGlowColor.Blue,
                                       eToastPosition.BottomLeft)
            Exit Sub
        End If
        If cbZona.SelectedIndex < 0 Then
            ToastNotification.Show(Me, "SELECCIONE UNA ZONA..!!!",
                                       My.Resources.INFORMATION, 2000,
                                       eToastGlowColor.Blue,
                                       eToastPosition.BottomLeft)
            Exit Sub
        End If
        _prCargarReporte()
    End Sub

    Private Sub R01_VentasAtendidas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        _prIniciarTodo()
    End Sub
#End Region

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

    Private Sub swTipo_ValueChanged(sender As Object, e As EventArgs)
        tbVendedor.Clear()
        tbCodigoVendedor.Clear()
    End Sub

    Private Sub tbVendedor_TextChanged(sender As Object, e As EventArgs) Handles tbVendedor.TextChanged

    End Sub

    Private Sub btnExportar_Click(sender As Object, e As EventArgs) Handles btnExportar.Click
        _prCrearCarpetaReportes()
        Dim img As Bitmap = New Bitmap(My.Resources.checked, 50, 50)
        If (P_ExportarExcel(RutaGlobal + "\Reporte\Reporte Productos")) Then
            ToastNotification.Show(Me, "EXPORTACIÓN DE LISTA DE PRODUCTOS EXITOSA..!!!",
                                       img, 2000,
                                       eToastGlowColor.Green,
                                       eToastPosition.BottomCenter)
        Else
            ToastNotification.Show(Me, "FALLO AL EXPORTACIÓN DE LISTA DE PRODUCTOS..!!!",
                                       My.Resources.WARNING, 2000,
                                       eToastGlowColor.Red,
                                       eToastPosition.BottomLeft)
        End If
    End Sub
    Private Sub _prCrearCarpetaReportes()
        Dim rutaDestino As String = RutaGlobal + "\Reporte\Reporte Productos\"

        If System.IO.Directory.Exists(RutaGlobal + "\Reporte\Reporte Productos\") = False Then
            If System.IO.Directory.Exists(RutaGlobal + "\Reporte") = False Then
                System.IO.Directory.CreateDirectory(RutaGlobal + "\Reporte")
                If System.IO.Directory.Exists(RutaGlobal + "\Reporte\Reporte Productos") = False Then
                    System.IO.Directory.CreateDirectory(RutaGlobal + "\Reporte\Reporte Productos")
                End If
            Else
                If System.IO.Directory.Exists(RutaGlobal + "\Reporte\Reporte Productos") = False Then
                    System.IO.Directory.CreateDirectory(RutaGlobal + "\Reporte\Reporte Productos")

                End If
            End If
        End If
    End Sub

    Public Function P_ExportarExcel(_ruta As String) As Boolean
        Dim _ubicacion As String
        'Dim _directorio As New FolderBrowserDialog

        If (1 = 1) Then 'If(_directorio.ShowDialog = Windows.Forms.DialogResult.OK) Then
            '_ubicacion = _directorio.SelectedPath
            _ubicacion = _ruta
            Try
                Dim _stream As Stream
                Dim _escritor As StreamWriter
                Dim _fila As Integer = JGrM_Buscador.GetRows.Length
                Dim _columna As Integer = JGrM_Buscador.RootTable.Columns.Count
                Dim _archivo As String = _ubicacion & "\ReporteVentas_" & Now.Date.Day &
                    "." & Now.Date.Month & "." & Now.Date.Year & "_" & Now.Hour & "." & Now.Minute & "." & Now.Second & ".csv"
                Dim _linea As String = ""
                Dim _filadata = 0, columndata As Int32 = 0
                File.Delete(_archivo)
                _stream = File.OpenWrite(_archivo)
                _escritor = New StreamWriter(_stream, System.Text.Encoding.UTF8)

                For Each _col As GridEXColumn In JGrM_Buscador.RootTable.Columns
                    If (_col.Visible) Then
                        _linea = _linea & _col.Caption & ";"
                    End If
                Next
                _linea = Mid(CStr(_linea), 1, _linea.Length - 1)
                _escritor.WriteLine(_linea)
                _linea = Nothing

                'Pbx_Precios.Visible = True
                'Pbx_Precios.Minimum = 1
                'Pbx_Precios.Maximum = Dgv_Precios.RowCount
                'Pbx_Precios.Value = 1

                For Each _fil As GridEXRow In JGrM_Buscador.GetRows
                    For Each _col As GridEXColumn In JGrM_Buscador.RootTable.Columns
                        If (_col.Visible) Then
                            Dim data As String = CStr(_fil.Cells(_col.Key).Value)
                            data = data.Replace(";", ",")
                            _linea = _linea & data & ";"
                        End If
                    Next
                    _linea = Mid(CStr(_linea), 1, _linea.Length - 1)
                    _escritor.WriteLine(_linea)
                    _linea = Nothing
                    'Pbx_Precios.Value += 1
                Next
                _escritor.Close()
                'Pbx_Precios.Visible = False
                Try
                    Dim ef = New Efecto
                    ef._archivo = _archivo

                    ef.tipo = 1
                    ef.Context = "Su archivo ha sido Guardado en la ruta: " + _archivo + vbLf + "DESEA ABRIR EL ARCHIVO?"
                    ef.Header = "PREGUNTA"
                    ef.ShowDialog()
                    Dim bandera As Boolean = False
                    bandera = ef.band
                    If (bandera = True) Then
                        Process.Start(_archivo)
                    End If

                    'If (MessageBox.Show("Su archivo ha sido Guardado en la ruta: " + _archivo + vbLf + "DESEA ABRIR EL ARCHIVO?", "PREGUNTA", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes) Then
                    '    Process.Start(_archivo)
                    'End If
                    Return True
                Catch ex As Exception
                    MsgBox(ex.Message)
                    Return False
                End Try
            Catch ex As Exception
                MsgBox(ex.Message)
                Return False
            End Try
        End If
        Return False
    End Function
End Class