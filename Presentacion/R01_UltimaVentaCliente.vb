Imports Logica.AccesoLogica
Imports DevComponents.DotNetBar
Imports DevComponents.DotNetBar.Controls

Public Class R01_UltimaVentaCliente
    Dim _Inter As Integer = 0
#Region "Atributos generales"

    Public _nameButton As String
    Public _tab As SuperTabItem
    Public _modulo As SideNavItem

#End Region

#Region "Variables Globales"

    Dim InDuracion As Byte = 5

    Dim UserSpecial As Boolean = False

#End Region

#Region "Eventos"

    Private Sub My_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        P_prInicio()
    End Sub


    Private Sub TbCodigoCliente_KeyDown(sender As Object, e As KeyEventArgs) Handles TbCodigo.KeyDown
        If (e.KeyData = Keys.Control + Keys.Enter) Then
            P_prCargarAyudaCliente()
        End If
    End Sub

    Private Sub BtBuscarCliente_Click_1(sender As Object, e As EventArgs) Handles BtBuscarCliente.Click
        P_prCargarAyudaCliente()
    End Sub

    Private Sub MBtGenerar_Click(sender As Object, e As EventArgs) Handles MBtGenerar.Click
        ' P_prCargarReporte()
        If swZonas.Value = True Then
            P_prCargarReporte()
        Else
            If TbCodigo.Text = String.Empty Then
                ToastNotification.Show(Me, "Debe Seleccionar una Zona...!!!".ToUpper,
                                           My.Resources.INFORMATION, 2000,
                                           eToastGlowColor.Blue,
                                           eToastPosition.TopCenter)
            Else
                P_prCargarReporte()
            End If
        End If
    End Sub

    Private Sub MBtSalir_Click(sender As Object, e As EventArgs) Handles MBtSalir.Click
        Me.Close()
        Me._modulo.Select()
        'Me._tab.Close()
    End Sub

#End Region

#Region "Metodos"

    Private Sub P_prInicio()
        'Abrir conexion
        If (Not gb_ConexionAbierta) Then
            L_prAbrirConexion()
        End If

        Me.Text = "U L T I M A S   V E N T A S   A   C L I E N T E S".ToUpper
        'Me.WindowState = FormWindowState.Maximized
        MCrReporte.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None

        TbCodigo.ReadOnly = True
        TbDescripcion.ReadOnly = True

        DtiDesde.Value = Now.Date
        DtiHasta.Value = Now.Date
        VerificarUsuario()

    End Sub
    Private Sub VerificarUsuario()
        Dim dt As DataTable = TraerUsuariosEspeciales()
        For i = 0 To dt.Rows.Count - 1 Step 1
            If gi_userNumi = dt.Rows(i).Item("especial") Then
                UserSpecial = True
            End If
        Next

    End Sub
    Private Sub P_prCargarReporte()
        If (P_fnValidar()) Then
            Dim dt As New DataTable
            _prInterpretarDatos(dt)
            'dt = L_VistaUltimaVentaCliente(DtiDesde.Value.ToString("yyyy/MM/dd"), DtiHasta.Value.ToString("yyyy/MM/dd"), TbCodigo.Text, TbCriterio.Text.Trim)

            If (dt.Rows.Count > 0) Then
                Dim objrep As New R_UltimaVentaCliente

                objrep.SetDataSource(dt)

                objrep.SetParameterValue("FechaIni", DtiDesde.Value.ToString("dd/MM/yyyy"))
                objrep.SetParameterValue("FechaFin", DtiHasta.Value.ToString("dd/MM/yyyy"))
                objrep.SetParameterValue("Zona", TbDescripcion.Text)

                MCrReporte.ReportSource = objrep
                MCrReporte.Show()
                MCrReporte.BringToFront()
            Else
                ToastNotification.Show(Me, "no hay datos para los parametros seleccionados.".ToUpper,
                                           My.Resources.INFORMATION, 2000,
                                           eToastGlowColor.Blue,
                                           eToastPosition.BottomLeft)
                MCrReporte.ReportSource = Nothing
            End If
        End If
    End Sub
    Public Sub _prInterpretarDatos(ByRef dt As DataTable)
        If (swZonas.Value = True) Then
            If UserSpecial = False Then
                dt = L_VistaUltimaVentaClientesTodos(DtiDesde.Value.ToString("yyyy/MM/dd"), DtiHasta.Value.ToString("yyyy/MM/dd"), TbCriterio.Text.Trim)
            Else
                'aqui poder codigo
            End If
        Else
            If (TbCodigo.Text.Length > 0) Then
                If UserSpecial = False Then
                    dt = L_VistaUltimaVentaCliente(DtiDesde.Value.ToString("yyyy/MM/dd"), DtiHasta.Value.ToString("yyyy/MM/dd"), TbCodigo.Text, TbCriterio.Text.Trim)
                Else
                    'aqui poner codigo
                End If

            End If
        End If
    End Sub
    Private Sub P_prCargarAyudaCliente()
        Dim frmAyuda As Modelo.ModeloAyuda
        Dim dt As DataTable = L_GetZonasCPZ().Tables(0)
        Dim listEstCeldas As New List(Of Modelo.MCelda)
        listEstCeldas.Add(New Modelo.MCelda("lanumi", True, "Codigo", 80))
        listEstCeldas.Add(New Modelo.MCelda("city", True, "Dpto", 150))
        listEstCeldas.Add(New Modelo.MCelda("prov", True, "Provincia", 150))
        listEstCeldas.Add(New Modelo.MCelda("zona", True, "Zona", 200))

        frmAyuda = New Modelo.ModeloAyuda(750, 400, dt, "Seleccione una zona".ToUpper, listEstCeldas)
        frmAyuda.StartPosition = FormStartPosition.CenterScreen
        frmAyuda.ShowDialog()

        If frmAyuda.seleccionado = True Then
            TbCodigo.Text = frmAyuda.filaSelect.Cells("lanumi").Value
            TbDescripcion.Text = "dpto: ".ToUpper + frmAyuda.filaSelect.Cells("city").Value.ToString + vbCrLf _
                                  + "provincia: ".ToUpper + frmAyuda.filaSelect.Cells("prov").Value.ToString + vbCrLf _
                                  + "zona: ".ToUpper + frmAyuda.filaSelect.Cells("zona").Value.ToString
        End If
    End Sub

    Private Function P_fnValidar() As Boolean
        Dim sms As String = ""

        'If (TbCodigo.Text.Trim = String.Empty) Then
        '    sms = "Para generar el reporte debe elegir una zona.".ToUpper
        'End If

        If (DtiHasta.Value > Now.Date) Then
            If (sms = String.Empty) Then
                sms = "La fecha hasta tiene que ser menor o igual a la fecha actual.".ToUpper
            Else
                sms = sms + vbCrLf + "La fecha hasta tiene que ser menor o igual a la fecha actual.".ToUpper
            End If
        End If

        If (DtiDesde.Value > DtiHasta.Value) Then
            If (sms = String.Empty) Then
                sms = "La fecha desde tiene que ser menor o igual a l afecha hasta.".ToUpper
            Else
                sms = sms + vbCrLf + "La fecha desde tiene que ser menor o igual a la fecha hasta.".ToUpper
            End If
        End If

        If (Not sms = String.Empty) Then
            ToastNotification.Show(Me,
                                   sms.ToUpper,
                                   My.Resources.WARNING,
                                   InDuracion * 1000,
                                   eToastGlowColor.Red,
                                   eToastPosition.TopCenter)
        End If

        Return (sms = String.Empty)
    End Function
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

    Private Sub swZonas_ValueChanged(sender As Object, e As EventArgs) Handles swZonas.ValueChanged
        If (swZonas.Value = True) Then
            TbCodigo.Visible = False
            TbDescripcion.Visible = False
            BtBuscarCliente.Visible = False

        Else
            TbCodigo.Visible = True
            TbDescripcion.Visible = True
            BtBuscarCliente.Visible = True

        End If
    End Sub
#End Region

End Class