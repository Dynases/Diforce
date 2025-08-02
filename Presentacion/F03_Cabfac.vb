Imports Logica.AccesoLogica
Imports DevComponents.Editors
Imports DevComponents.DotNetBar.SuperGrid
Imports System.IO
Imports System.Drawing.Printing
Imports DevComponents.DotNetBar
Imports DevComponents.DotNetBar.Controls
Imports Google.Apis.Auth.OAuth2


Public Class F03_Cabfac
#Region "Variables Globales"
    Dim _inter As Integer = 0
    Dim DtCabfac As DataTable
    Dim DtDetfac As DataTable
    Public _modulo As SideNavItem
    Public _nameButton As String
    Public _tab As SuperTabItem

#End Region
#Region "METODOS PRIVADOS"
    Private Sub _PIniciarTodo()
        Me.Text = "G E N E R A R    A R C H I V O S   C S V"
        tbFecha.Value = Now.Date
        CheckTodosVendedor.CheckValue = True
    End Sub

    Public Sub _prListarPrevendedores()

        Dim dt As DataTable
        dt = L_prListarPrevendedor()
        'a.cbnumi , a.cbdesc As nombre, a.cbdirec, a.cbtelef, a.cbfnac 
        Dim listEstCeldas As New List(Of Modelo.MCelda)
        listEstCeldas.Add(New Modelo.MCelda("cbnumi", True, "ID", 50))
        listEstCeldas.Add(New Modelo.MCelda("nombre", True, "NOMBRE", 280))
        listEstCeldas.Add(New Modelo.MCelda("cbdirec", False, "DIRECCION", 220))
        listEstCeldas.Add(New Modelo.MCelda("cbtelef", False, "Telefono".ToUpper, 200))
        listEstCeldas.Add(New Modelo.MCelda("cbfnac", False, "F.Nacimiento".ToUpper, 150, "MM/dd,yyyy"))
        Dim ef = New Efecto
        ef.tipo = 3
        ef.dt = dt
        ef.SeleclCol = 1
        ef.listEstCeldas = listEstCeldas
        ef.alto = 50
        ef.ancho = 250
        ef.Context = "Seleccione Vendedor".ToUpper
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
        End If
    End Sub

    Private Function DataTableCSVFile(ByVal dt As DataTable, ByVal sfilename As String, ByVal strFilePath As String) As Boolean
        Try
            Dim _stream As Stream
            Dim _archivo As String = strFilePath & sfilename
            File.Delete(_archivo)
            _stream = File.OpenWrite(_archivo)
            Dim sw As StreamWriter = New StreamWriter(_stream, System.Text.Encoding.UTF8)
            Dim iColCount As Integer = dt.Columns.Count

            'For i As Integer = 0 To iColCount - 1
            '    sw.Write(dt.Columns(i))

            '    If i < iColCount - 1 Then
            '        sw.Write(",")
            '    End If
            'Next

            'sw.Write(sw.NewLine)

            For Each dr As DataRow In dt.Rows

                For i As Integer = 0 To iColCount - 1

                    If Not Convert.IsDBNull(dr(i)) Then
                        sw.Write(dr(i).ToString())
                    End If

                    If i < iColCount - 1 Then
                        sw.Write(",")
                    End If
                Next

                sw.Write(sw.NewLine)
            Next

            sw.Close()

            'Try
            '    If (MessageBox.Show("DESEA ABRIR EL ARCHIVO?", "PREGUNTA", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes) Then
            '        Process.Start(_archivo)
            '    End If
            '    Return True
            'Catch ex As Exception
            '    MsgBox(ex.Message)
            '    Return False
            'End Try
            Return True
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        End Try
        Return False
    End Function

#End Region
#Region "EVENTOS"
    Private Sub BtnGenerar_Click(sender As Object, e As EventArgs) Handles BtnGenerar.Click
        Dim _ubicacion As String
        If (CheckTodosVendedor.Checked) Then
            DtCabfac = L_prGenerarCabfac(tbFecha.Value)
            DtDetfac = L_prGenerarDetfac(tbFecha.Value)

        End If
        If (checkUnaVendedor.Checked) Then
            DtCabfac = L_prGenerarCabfacUnVendedor(tbFecha.Value, tbCodigoVendedor.Text)
            DtDetfac = L_prGenerarDetfacUnVendedor(tbFecha.Value, tbCodigoVendedor.Text)

        End If

        'DtCabfac = L_prGenerarCabfac(tbFecha.Value)
        'DtDetfac = L_prGenerarDetfac(tbFecha.Value)

        If DtCabfac.Rows.Count > 0 Then
            If (Not Directory.Exists(gs_CarpetaRaiz + "\CSV")) Then
                Directory.CreateDirectory(gs_CarpetaRaiz + "\CSV")
            End If

            _ubicacion = gs_CarpetaRaiz + "\CSV\"
            If (DataTableCSVFile(DtCabfac, "cabfac.csv", _ubicacion)) Then
                If (DataTableCSVFile(DtDetfac, "detfac.csv", _ubicacion)) Then
                    ToastNotification.Show(Me, "EXPORTACIÓN DE LOS ARCHIVOS EXITOSO EN LA UBICACION: " + _ubicacion,
                                           My.Resources.OK, 5000,
                                           eToastGlowColor.Green,
                                           eToastPosition.BottomCenter)
                End If

            Else
                ToastNotification.Show(Me, "FALLÓ LA EXPORTACIÓN DE LOS ARCHIVOS..!!!",
                                           My.Resources.WARNING, 4000,
                                           eToastGlowColor.Red,
                                           eToastPosition.BottomCenter)
            End If
        Else
            ToastNotification.Show(Me, "NO HAY REGISTROS PARA GENERAR...!!!",
                                           My.Resources.WARNING, 4000,
                                           eToastGlowColor.Red,
                                           eToastPosition.BottomCenter)
        End If

    End Sub


    Private Sub F03_Cabfac_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        _PIniciarTodo()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        _inter = _inter + 1
        If _inter = 1 Then
            Me.WindowState = FormWindowState.Normal
        Else
            Me.Opacity = 100
            Timer1.Enabled = False
        End If
    End Sub

    Private Sub BtnSalir1_Click(sender As Object, e As EventArgs) Handles BtnSalir1.Click
        Me.Close()
    End Sub

    Private Sub tbVendedor_KeyDown(sender As Object, e As KeyEventArgs) Handles tbVendedor.KeyDown
        If (checkUnaVendedor.Checked) Then
            If e.KeyData = Keys.Control + Keys.Enter Then
                _prListarPrevendedores()
            End If
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

    Private Sub CheckTodosVendedor_CheckValueChanged(sender As Object, e As EventArgs) Handles CheckTodosVendedor.CheckValueChanged
        If (CheckTodosVendedor.Checked) Then
            checkUnaVendedor.CheckValue = False
            tbVendedor.Enabled = True
            tbVendedor.BackColor = Color.Gainsboro
            tbVendedor.Clear()
            tbCodigoVendedor.Clear()

        End If
    End Sub
#End Region
End Class