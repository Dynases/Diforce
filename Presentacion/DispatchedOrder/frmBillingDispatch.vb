Imports DevComponents.DotNetBar
Imports DevComponents.DotNetBar.Controls
Imports ENTITY
Imports Janus.Windows.GridEX
Imports LOGIC
Imports UTILITIES
Imports Facturacion
Imports Logica.AccesoLogica
Imports System.Drawing.Printing
Imports System.IO
Imports CrystalDecisions.Shared
Imports System.Net
Imports System.ComponentModel
Imports Newtonsoft.Json
Imports Presentacion.RespPDF
Imports Presentacion.RespFactura
Imports Presentacion.EmisorResp
Imports Presentacion.Numeracion
Imports Presentacion.ResNumeracion
Imports iTextSharp.text
Imports PdfiumViewer

Imports Newtonsoft.Json.Linq
Imports System.Net.Http
Imports System.Text
Imports System.Web.Script.Serialization

Public Class frmBillingDispatch
    Dim _inter As Integer = 0
    Public _nameButton As String
    Public _tab As SuperTabItem
    Public _modulo As SideNavItem

    Private _cargaCompleta = False
    Private _TipoCarga = False
    Public nit As String
    Public razonsocial As String
    Public email As String
    Public tipoDoc As Integer

    Public fact As Integer = 0

    Private WithEvents pdfViewer As AxAcroPDFLib.AxAcroPDF

    Dim tokenSifac As String
#Region "Eventos"
    Private Sub frmBillingDispatch_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'pdfViewer = New AxAcroPDFLib.AxAcroPDF()
        'Me.Controls.Add(PdfViewer)
        'PdfViewer.Dock = DockStyle.Fill
        Init()
    End Sub

    Private Sub cbChoferes_ValueChanged(sender As Object, e As EventArgs) Handles cbChoferes.ValueChanged
        Try
            If (_cargaCompleta) Then
                CargarPedidos()
                CargarFacturas()
                CargarFacturasAnuladas()
                _TipoCarga = False
                If SuperTabControl1.SelectedTab Is SuperTabItem1 Then
                    lblCantidadPedido.Text = dgjPedido.RowCount.ToString
                Else
                    lblCantidadPedido.Text = grFactura.RowCount.ToString
                End If

                btnNotaVenta.Enabled = True
                btnFactura.Enabled = True
            End If
        Catch ex As Exception
            MostrarMensajeError(ex.Message)
        End Try
    End Sub

    Private Sub btFacturar_Click(sender As Object, e As EventArgs) Handles btnNotaVenta.Click
        Try
            Dim idChofer = Me.cbChoferes.Value
            If (Convert.ToInt32(idChofer) = ENCombo.ID_SELECCIONAR) Then
                Throw New Exception("Debe seleccionar un chofer.")
            End If
            Dim listIdPedido As New List(Of Integer)()
            Dim listVendedores As New List(Of String)()
            'Dim checks = Me.dgjPedido.GetCheckedRows()
            'Dim listIdPedido = checks.Select(Function(a) Convert.ToInt32(a.Cells("Id").Value)).ToList()
            For i = 0 To CType(dgjPedido.DataSource, DataTable).Rows.Count - 1 Step 1
                If CType(dgjPedido.DataSource, DataTable).Rows(i).Item("checks") = True Then
                    listIdPedido.Add(CType(dgjPedido.DataSource, DataTable).Rows(i).Item("Id"))
                    listVendedores.Add(CType(dgjPedido.DataSource, DataTable).Rows(i).Item("NombreVendedor"))
                End If
            Next
            'If (listIdPedido.Count = 0) Then
            ' Throw New Exception("Debe seleccionar por lo menos un pedido.")
            ' End If

            'Dim list1 As List(Of VPedido_BillingDispatch) = CType(dgjPedido.DataSource, List(Of VPedido_BillingDispatch))
            'Dim list1 As List(Of VPedido_BillingDispatch) = New List(Of VPedido_BillingDispatch)

            'list1 = list1.Where(Function(a) listIdPedido.Contains(a.Id)).ToList()

            'For i As Integer = 0 To list2.Count - 1 Step 1
            '    'If (list2(i).NroFactura.Equals("") Or list2(i).NroFactura.Equals("0")) Then
            '    If (list2(i).NroFactura = Nothing) Then
            '        list1.Add(list2(i))
            '    Else
            '        If (list2(i).NroFactura.Equals("") Or list2(i).NroFactura.Equals("0")) Then
            '            list1.Add(list2(i))
            '        End If
            '    End If
            'Next

            If (listIdPedido.Count = 0) Then

                For i = 0 To CType(grFactura.DataSource, DataTable).Rows.Count - 1 Step 1
                    If CType(grFactura.DataSource, DataTable).Rows(i).Item("checks") = True Then
                        listIdPedido.Add(CType(grFactura.DataSource, DataTable).Rows(i).Item("Id"))
                        listVendedores.Add(CType(grFactura.DataSource, DataTable).Rows(i).Item("NombreVendedor"))
                    End If
                Next
                If (listIdPedido.Count = 0) Then
                    Throw New Exception("Debe seleccionar por lo menos un pedido.")
                    Return
                End If


            End If

            For i As Integer = 0 To listIdPedido.Count - 1 Step 1
                If L_YaSeGraboTV001(listIdPedido(i)) = False Then
                    GrabarTV001(Str(listIdPedido(i)))
                End If

                'Dim dtDetalle As DataTable = L_prObtenerDetallePedidoFactura(Str(list1(i).Id))

                'P_fnGenerarFactura(dtDetalle.Rows(0).Item("oanumi"), dtDetalle.Rows(0).Item("subtotal"), dtDetalle.Rows(0).Item("descuento"), dtDetalle.Rows(0).Item("total"), dtDetalle.Rows(0).Item("nit"), dtDetalle.Rows(0).Item("cliente"), dtDetalle.Rows(0).Item("codcli"))
                'P_prImprimirNotaVenta(dtDetalle.Rows(0).Item("oanumi"), True, True, idChofer)
                If _TipoCarga = True Then
                    P_prImprimirNotaVenta(Str(listIdPedido(i)), True, True, 4, listVendedores(i))
                Else
                    P_prImprimirNotaVenta(Str(listIdPedido(i)), True, True, idChofer, listVendedores(i))
                End If
                'P_prImprimirNotaVenta(Str(listIdPedido(i)), True, True, idChofer, listVendedores(i))

            Next

            Dim img As Bitmap = New Bitmap(My.Resources.checked, 50, 50)
            If _TipoCarga = True Then
                CargarPedidos2()
            Else
                CargarPedidos()
                CargarFacturas()
            End If

            ToastNotification.Show(Me, "Notas de Venta Generadas Correctamente".ToUpper,
                                      img, 2000,
                                      eToastGlowColor.Green,
                                      eToastPosition.TopCenter
                                      )



        Catch ex As Exception
            MostrarMensajeError(ex.Message)
        End Try
    End Sub
    Private Function P_fnValidarFactura() As Boolean
        Return True
    End Function

    Private Function P_fnGenerarFactura(numi As String, subtotal As Double, descuento As Double, total As Double, nit As String, Nombre As String, Codcli As String) As Boolean
        Dim res As Boolean = False
        res = P_fnGrabarFacturarTFV001(numi, subtotal, descuento, total, nit, Nombre, Codcli) ' Grabar en la TFV001

        If (res) Then
            'Grabar Estado 5 de Facturado en la TO001D
            L_GrabarTO001D(numi, "5", "Factura")

            If (P_fnValidarFactura()) Then
                'Validar para facturar
                P_prImprimirFacturar(numi, True, True, nit) '_Codigo de a tabla TV001
            Else
                'Volver todo al estada anterior
                ToastNotification.Show(Me, "No es posible facturar!!!".ToUpper,
                                       My.Resources.OK,
                                       5 * 1000,
                                       eToastGlowColor.Red,
                                       eToastPosition.MiddleCenter)
            End If

            If (Not nit.Equals("0")) Then
                L_Grabar_Nit(nit, Nombre, "")
            Else
                L_Grabar_Nit(nit, "S/N", "")
            End If
        End If
        Dim dtfv001 As DataTable = L_fnObtenerTabla("fvanitcli, fvadescli1, fvadescli2, fvaautoriz, fvanfac, fvaccont, fvafec,fvaest", "TFV001", "fvanumi=" + numi + " or fvanumi=" + "-" + numi)
        If dtfv001.Rows.Count = 2 Then
            L_ActualizaNegativosTFV001(numi, "0")
        End If

        Return res
    End Function


    Private Sub P_prImprimirFacturar(numi As String, impFactura As Boolean, grabarPDF As Boolean, nit As String)
        Dim _Fecha, _FechaAl As Date
        Dim _Ds, _Ds1, _Ds2, _Ds3 As New DataSet
        Dim _Autorizacion, _Nit, _Fechainv, _Total, _Key, _Cod_Control, _Hora,
            _Literal, _TotalDecimal, _TotalDecimal2 As String
        Dim I, _NumFac, _numidosif, _TotalCC As Integer
        Dim ice, _Desc, _TotalLi As Decimal
        Dim _VistaPrevia As Integer = 0
        Dim QrFactura1 As String

        _Desc = CDbl(0)
        If Not IsNothing(P_Global.Visualizador) Then
            P_Global.Visualizador.Close()
        End If

        _Fecha = Now.Date.ToString("dd/MM/yyyy")
        _Hora = Now.Hour.ToString + ":" + Now.Minute.ToString
        _Ds1 = L_Dosificacion("1", "1", _Fecha)

        _Ds = L_Reporte_Factura(numi, numi)
        _Autorizacion = _Ds1.Tables(0).Rows(0).Item("yeautoriz").ToString
        _NumFac = CInt(_Ds1.Tables(0).Rows(0).Item("yenunf")) + 1
        _Nit = _Ds.Tables(0).Rows(0).Item("fvanitcli").ToString
        _Fechainv = Microsoft.VisualBasic.Right(_Fecha.ToShortDateString, 4) +
                    Microsoft.VisualBasic.Right(Microsoft.VisualBasic.Left(_Fecha.ToShortDateString, 5), 2) +
                    Microsoft.VisualBasic.Left(_Fecha.ToShortDateString, 2)
        _Total = _Ds.Tables(0).Rows(0).Item("fvatotal").ToString
        ice = _Ds.Tables(0).Rows(0).Item("fvaimpsi")
        _numidosif = _Ds1.Tables(0).Rows(0).Item("yenumi").ToString
        _Key = _Ds1.Tables(0).Rows(0).Item("yekey")
        _FechaAl = _Ds1.Tables(0).Rows(0).Item("yefal")

        Dim maxNFac As Integer = L_fnObtenerMaxIdTabla("TFV001", "fvanfac", "fvaautoriz = " + _Autorizacion)
        _NumFac = maxNFac + 1

        _TotalCC = Math.Round(CDbl(_Total), MidpointRounding.AwayFromZero)
        _Cod_Control = ControlCode.generateControlCode(_Autorizacion, _NumFac, _Nit, _Fechainv, CStr(_TotalCC), _Key)

        'Literal 
        _TotalLi = _Ds.Tables(0).Rows(0).Item("fvasubtotal") - _Ds.Tables(0).Rows(0).Item("fvadesc")
        _TotalDecimal = _TotalLi - Math.Truncate(_TotalLi)
        _TotalDecimal2 = CDbl(_TotalDecimal) * 100

        'Dim li As String = Facturacion.ConvertirLiteral.A_fnConvertirLiteral(CDbl(_Total) - CDbl(_TotalDecimal)) + " con " + IIf(_TotalDecimal2.Equals("0"), "00", _TotalDecimal2) + "/100 Bolivianos"
        _Literal = Facturacion.ConvertirLiteral.A_fnConvertirLiteral(CDbl(_TotalLi) - CDbl(_TotalDecimal)) + " con " + IIf(_TotalDecimal2.Equals("0"), "00", _TotalDecimal2) + "/100 Bolivianos"
        _Ds2 = L_Reporte_Factura_Cia("1")
        QrFactura.Text = _Ds2.Tables(0).Rows(0).Item("scnit").ToString + "|" + Str(_NumFac).Trim + "|" + _Autorizacion + "|" + _Fecha + "|" + _Total + "|" + _TotalLi.ToString + "|" + _Cod_Control + "|" + nit + "|" + ice.ToString + "|0|0|" + Str(_Desc).Trim

        L_Modificar_Factura("fvanumi = " + CStr(numi),
                            "",
                            CStr(_NumFac),
                            CStr(_Autorizacion),
                            "",
                            "",
                            "",
                            "",
                            "",
                            "",
                            "",
                            "",
                            "",
                            "",
                            "",
                            "",
                            "",
                            _Cod_Control,
                            _FechaAl.ToString("yyyy/MM/dd"),
                            "",
                            "",
                            CStr(numi))


        updateTO001C(numi, Str(_NumFac))
        _Ds = L_Reporte_Factura(numi, numi)

        _Ds3 = L_ObtenerRutaImpresora("1") ' Datos de Impresion de Facturación

        For I = 0 To _Ds.Tables(0).Rows.Count - 1
            '_Ds.Tables(0).Rows(I).Item("fvaimgqr") = P_fnImageToByteArray(QrFactura.Image)
        Next
        P_Global.Visualizador = New Visualizador
        Dim objrep As New Factura
        Dim dia, mes, ano As Integer
        Dim Fecliteral, mesl As String
        Fecliteral = _Ds.Tables(0).Rows(0).Item("fvafec").ToString
        dia = Microsoft.VisualBasic.Left(Fecliteral, 2)
        mes = Microsoft.VisualBasic.Mid(Fecliteral, 4, 2)
        ano = Microsoft.VisualBasic.Mid(Fecliteral, 7, 4)
        If mes = 1 Then
            mesl = "Enero"
        End If
        If mes = 2 Then
            mesl = "Febrero"
        End If
        If mes = 3 Then
            mesl = "Marzo"
        End If
        If mes = 4 Then
            mesl = "Abril"
        End If
        If mes = 5 Then
            mesl = "Mayo"
        End If
        If mes = 6 Then
            mesl = "Junio"
        End If
        If mes = 7 Then
            mesl = "Julio"
        End If
        If mes = 8 Then
            mesl = "Agosto"
        End If
        If mes = 9 Then
            mesl = "Septiembre"
        End If
        If mes = 10 Then
            mesl = "Octubre"
        End If
        If mes = 11 Then
            mesl = "Noviembre"
        End If
        If mes = 12 Then
            mesl = "Diciembre"
        End If
        Dim tipoPago = ObtenerTipoDePagoPedido(numi)

        Dim cadena As String = _Ds2.Tables(0).Rows(0).Item("scciu").ToString
        Dim posicion As Integer = cadena.IndexOf("-")
        Dim ciudad As String = cadena.Substring(0, posicion)

        Fecliteral = ciudad + ",  " + dia.ToString + " de " + mesl + " del " + ano.ToString
        objrep.SetDataSource(_Ds.Tables(0))

        objrep.SetParameterValue("Fecliteral", Fecliteral)
        objrep.SetParameterValue("Nota2", _Ds1.Tables(0).Rows(0).Item("yenota2").ToString())
        'objrep.PrintOptions.PrinterName = "L4150 Series(Red) (Copiar 1)"

        objrep.SetParameterValue("Direccionpr", _Ds2.Tables(0).Rows(0).Item("scdir").ToString)
        objrep.SetParameterValue("Literal1", _Literal)
        objrep.SetParameterValue("NroFactura", _NumFac)
        objrep.SetParameterValue("NroAutoriz", _Autorizacion)
        objrep.SetParameterValue("ENombre", _Ds2.Tables(0).Rows(0).Item("scneg").ToString) '?
        objrep.SetParameterValue("ECasaMatriz", _Ds2.Tables(0).Rows(0).Item("scsuc").ToString)
        objrep.SetParameterValue("ECiudadPais", _Ds2.Tables(0).Rows(0).Item("scciu").ToString)
        objrep.SetParameterValue("ESFC", _Ds1.Tables(0).Rows(0).Item("yesfc").ToString)
        objrep.SetParameterValue("ENit", _Ds2.Tables(0).Rows(0).Item("scnit").ToString)
        objrep.SetParameterValue("EActividad", _Ds2.Tables(0).Rows(0).Item("scact").ToString)
        objrep.SetParameterValue("Tipo", "ORIGINAL")
        objrep.SetParameterValue("TipoPago", tipoPago)
        objrep.SetParameterValue("Logo", gb_ubilogo)
        'If imp = 1 Then
        '    objrep.SetParameterValue("Tipo", "ORIGINAL")
        'Else
        '    objrep.SetParameterValue("Tipo", "COPIA")
        'End If
        If (_Ds3.Tables(0).Rows(0).Item("cbvp")) Then 'Vista Previa de la Ventana de Vizualización 1 = True 0 = False
            P_Global.Visualizador.CRV1.ReportSource = objrep 'Comentar
            P_Global.Visualizador.ShowDialog() 'Comentar
            P_Global.Visualizador.BringToFront() 'Comentar
        Else
            Dim pd As New PrintDocument()
            pd.PrinterSettings.PrinterName = _Ds3.Tables(0).Rows(0).Item("cbrut").ToString
            If (Not pd.PrinterSettings.IsValid) Then
                ToastNotification.Show(Me, "La Impresora ".ToUpper + _Ds3.Tables(0).Rows(0).Item("cbrut").ToString + Chr(13) + "No Existe".ToUpper,
                                       My.Resources.WARNING, 5 * 1000,
                                       eToastGlowColor.Blue, eToastPosition.BottomRight)
            Else
                objrep.PrintOptions.PrinterName = _Ds3.Tables(0).Rows(0).Item("cbrut").ToString
                objrep.PrintToPrinter(1, False, 0, 0)
            End If
        End If

        L_Actualiza_Dosificacion(_numidosif, _NumFac, numi)

        If (grabarPDF) Then
            'Copia de Factura en PDF
            If (Not Directory.Exists(gs_CarpetaRaiz + "\Facturas")) Then
                Directory.CreateDirectory(gs_CarpetaRaiz + "\Facturas")
            End If
            objrep.ExportToDisk(ExportFormatType.PortableDocFormat, gs_CarpetaRaiz + "\Facturas\" + CStr(_NumFac) + "_" + CStr(_Autorizacion) + ".pdf")

        End If
        'Dim pd As New PrintDocument()
        'pd.PrinterSettings.PrinterName = _Ds3.Tables(0).Rows(0).Item("cbrut").ToString
        'If (Not pd.PrinterSettings.IsValid) Then
        '    ToastNotification.Show(Me, "La Impresora ".ToUpper + _Ds3.Tables(0).Rows(0).Item("cbrut").ToString + Chr(13) + "No Existe".ToUpper,
        '                           My.Resources.WARNING, 5 * 1000,
        '                           eToastGlowColor.Blue, eToastPosition.BottomRight)
        'Else
        '    objrep.PrintOptions.PrinterName = _Ds3.Tables(0).Rows(0).Item("cbrut").ToString
        '    objrep.PrintToPrinter(1, False, 1, 1)
        'End If
        'objrep.PrintOptions.PrinterName = _Ds3.Tables(0).Rows(0).Item("cbrut").ToString
        'objrep.PrintToPrinter(1, False, 1, 1)




        ''For I = 0 To _Ds.Tables(0).Rows.Count - 1
        ''    _Ds.Tables(0).Rows(I).Item("fvaimgqr") = P_fnImageToByteArray(QrFactura.Image)
        ''Next
        'If (impFactura) Then
        '    _Ds3 = L_ObtenerRutaImpresora("1") ' Datos de Impresion de Facturación
        '    If (_Ds3.Tables(0).Rows(0).Item("cbvp")) Then 'Vista Previa de la Ventana de Vizualización 1 = True 0 = False
        '        P_Global.Visualizador = New Visualizador 'Comentar
        '    End If


        '    Dim objrep As Object = Nothing
        '    objrep = New R_FacturaPreImpresa

        '    objrep.SetDataSource(_Ds.Tables(0))
        '    objrep.SetParameterValue("Hora", _Hora)
        '    objrep.SetParameterValue("Literal", _Literal)

        '    P_Global.Visualizador.CRV1.ReportSource = objrep
        '    P_Global.Visualizador.Show()
        '    P_Global.Visualizador.BringToFront()


        '    'If (_Ds3.Tables(0).Rows(0).Item("cbvp")) Then 'Vista Previa de la Ventana de Vizualización 1 = True 0 = False
        '    '    P_Global.Visualizador.CRV1.ReportSource = objrep 'Comentar
        '    '    P_Global.Visualizador.ShowDialog() 'Comentar
        '    '    P_Global.Visualizador.BringToFront() 'Comentar
        '    'End If

        '    'Dim pd As New PrintDocument()
        '    'pd.PrinterSettings.PrinterName = _Ds3.Tables(0).Rows(0).Item("cbrut").ToString
        '    'If (Not pd.PrinterSettings.IsValid) Then
        '    '    ToastNotification.Show(Me, "La Impresora ".ToUpper + _Ds3.Tables(0).Rows(0).Item("cbrut").ToString + Chr(13) + "No Existe".ToUpper,
        '    '                           My.Resources.WARNING, 5 * 1000,
        '    '                           eToastGlowColor.Blue, eToastPosition.BottomRight)
        '    'Else
        '    '    objrep.PrintOptions.PrinterName = _Ds3.Tables(0).Rows(0).Item("cbrut").ToString '"EPSON TM-T20II Receipt5 (1)"
        '    '    objrep.PrintToPrinter(1, False, 1, 1)
        '    'End If

        'If (grabarPDF) Then
        '    'Copia de Factura en PDF
        '    If (Not Directory.Exists(gs_CarpetaRaiz + "\Facturas")) Then
        '        Directory.CreateDirectory(gs_CarpetaRaiz + "\Facturas")
        '    End If
        '    objrep.ExportToDisk(ExportFormatType.PortableDocFormat, gs_CarpetaRaiz + "\Facturas\" + CStr(_NumFac) + "_" + CStr(_Autorizacion) + ".pdf")

        'End If
        'End If

    End Sub
    Private Sub P_ReImprImprimirFacturar(numi As String, impFactura As Boolean, grabarPDF As Boolean, nit As String)
        Dim _Fecha, _FechaAl As Date
        Dim _Ds, _Ds1, _Ds2, _Ds3 As New DataSet
        Dim _Autorizacion, _Nit, _Fechainv, _Total, _Key, _Cod_Control, _Hora,
            _Literal, _TotalDecimal, _TotalDecimal2 As String
        Dim I, _NumFac, _numidosif, _TotalCC As Integer
        Dim ice, _Desc, _TotalLi As Decimal
        Dim _VistaPrevia As Integer = 0
        Dim QrFactura1 As String

        _Desc = CDbl(0)
        If Not IsNothing(P_Global.Visualizador) Then
            P_Global.Visualizador.Close()
        End If

        _Fecha = Now.Date.ToString("dd/MM/yyyy")
        _Hora = Now.Hour.ToString + ":" + Now.Minute.ToString
        _Ds1 = L_Dosificacion("1", "1", _Fecha)

        _Ds = L_Reporte_Factura(numi, numi)
        _Autorizacion = _Ds1.Tables(0).Rows(0).Item("yeautoriz").ToString
        _NumFac = CInt(_Ds1.Tables(0).Rows(0).Item("yenunf")) + 1
        _Nit = _Ds.Tables(0).Rows(0).Item("fvanitcli").ToString
        _Fechainv = Microsoft.VisualBasic.Right(_Fecha.ToShortDateString, 4) +
                    Microsoft.VisualBasic.Right(Microsoft.VisualBasic.Left(_Fecha.ToShortDateString, 5), 2) +
                    Microsoft.VisualBasic.Left(_Fecha.ToShortDateString, 2)
        _Total = _Ds.Tables(0).Rows(0).Item("fvatotal").ToString
        ice = _Ds.Tables(0).Rows(0).Item("fvaimpsi")
        _numidosif = _Ds1.Tables(0).Rows(0).Item("yenumi").ToString
        _Key = _Ds1.Tables(0).Rows(0).Item("yekey")
        _FechaAl = _Ds1.Tables(0).Rows(0).Item("yefal")

        _NumFac = CInt(_Ds.Tables(0).Rows(0).Item("fvanfac").ToString)
        'Dim maxnfac As Integer = L_fnObtenerMaxIdTabla("tfv001", "fvanfac", "fvaautoriz = " + _Autorizacion)
        '_NumFac = maxnfac + 1

        _TotalCC = Math.Round(CDbl(_Total), MidpointRounding.AwayFromZero)
        _Cod_Control = ControlCode.generateControlCode(_Autorizacion, _NumFac, _Nit, _Fechainv, CStr(_TotalCC), _Key)

        'Literal 
        _TotalLi = _Ds.Tables(0).Rows(0).Item("fvasubtotal") - _Ds.Tables(0).Rows(0).Item("fvadesc")
        _TotalDecimal = _TotalLi - Math.Truncate(_TotalLi)
        _TotalDecimal2 = CDbl(_TotalDecimal) * 100

        'Dim li As String = Facturacion.ConvertirLiteral.A_fnConvertirLiteral(CDbl(_Total) - CDbl(_TotalDecimal)) + " con " + IIf(_TotalDecimal2.Equals("0"), "00", _TotalDecimal2) + "/100 Bolivianos"
        _Literal = Facturacion.ConvertirLiteral.A_fnConvertirLiteral(CDbl(_TotalLi) - CDbl(_TotalDecimal)) + " con " + IIf(_TotalDecimal2.Equals("0"), "00", _TotalDecimal2) + "/100 Bolivianos"
        _Ds2 = L_Reporte_Factura_Cia("1")
        QrFactura.Text = _Ds2.Tables(0).Rows(0).Item("scnit").ToString + "|" + Str(_NumFac).Trim + "|" + _Autorizacion + "|" + _Fecha + "|" + _Total + "|" + _TotalLi.ToString + "|" + _Cod_Control + "|" + nit + "|" + ice.ToString + "|0|0|" + Str(_Desc).Trim

        L_Modificar_Factura("fvanumi = " + CStr(numi),
                            "",
                            CStr(_NumFac),
                            CStr(_Autorizacion),
                            "",
                            "",
                            "",
                            "",
                            "",
                            "",
                            "",
                            "",
                            "",
                            "",
                            "",
                            "",
                            "",
                            _Cod_Control,
                            _FechaAl.ToString("yyyy/MM/dd"),
                            "",
                            "",
                            CStr(numi))


        updateTO001C(numi, Str(_NumFac))
        _Ds = L_Reporte_Factura(numi, numi)

        _Ds3 = L_ObtenerRutaImpresora("1") ' Datos de Impresion de Facturación

        For I = 0 To _Ds.Tables(0).Rows.Count - 1
            '_Ds.Tables(0).Rows(I).Item("fvaimgqr") = P_fnImageToByteArray(QrFactura.Image)
        Next
        P_Global.Visualizador = New Visualizador
        Dim objrep As New Factura
        Dim dia, mes, ano As Integer
        Dim Fecliteral, mesl As String
        Fecliteral = _Ds.Tables(0).Rows(0).Item("fvafec").ToString
        dia = Microsoft.VisualBasic.Left(Fecliteral, 2)
        mes = Microsoft.VisualBasic.Mid(Fecliteral, 4, 2)
        ano = Microsoft.VisualBasic.Mid(Fecliteral, 7, 4)
        mesl = ObtenerMesLiberal(mes)

        Dim tipoPago = ObtenerTipoDePagoPedido(numi)

        Dim cadena As String = _Ds2.Tables(0).Rows(0).Item("scciu").ToString
        Dim posicion As Integer = cadena.IndexOf("-")
        Dim ciudad As String = cadena.Substring(0, posicion)

        Fecliteral = ciudad + ",  " + dia.ToString + " de " + mesl + " del " + ano.ToString
        objrep.SetDataSource(_Ds.Tables(0))

        objrep.SetParameterValue("Fecliteral", Fecliteral)
        objrep.SetParameterValue("Nota2", _Ds1.Tables(0).Rows(0).Item("yenota2").ToString())
        'objrep.PrintOptions.PrinterName = "L4150 Series(Red) (Copiar 1)"

        objrep.SetParameterValue("Direccionpr", _Ds2.Tables(0).Rows(0).Item("scdir").ToString)
        objrep.SetParameterValue("Literal1", _Literal)
        objrep.SetParameterValue("NroFactura", _NumFac)
        objrep.SetParameterValue("NroAutoriz", _Autorizacion)
        objrep.SetParameterValue("ENombre", _Ds2.Tables(0).Rows(0).Item("scneg").ToString) '?
        objrep.SetParameterValue("ECasaMatriz", _Ds2.Tables(0).Rows(0).Item("scsuc").ToString)
        objrep.SetParameterValue("ECiudadPais", _Ds2.Tables(0).Rows(0).Item("scciu").ToString)
        objrep.SetParameterValue("ESFC", _Ds1.Tables(0).Rows(0).Item("yesfc").ToString)
        objrep.SetParameterValue("ENit", _Ds2.Tables(0).Rows(0).Item("scnit").ToString)
        objrep.SetParameterValue("EActividad", _Ds2.Tables(0).Rows(0).Item("scact").ToString)
        objrep.SetParameterValue("Tipo", "ORIGINAL")
        objrep.SetParameterValue("TipoPago", tipoPago)
        objrep.SetParameterValue("Logo", gb_ubilogo)
        'If imp = 1 Then
        '    objrep.SetParameterValue("Tipo", "ORIGINAL")
        'Else
        '    objrep.SetParameterValue("Tipo", "COPIA")
        'End If
        If (_Ds3.Tables(0).Rows(0).Item("cbvp")) Then 'Vista Previa de la Ventana de Vizualización 1 = True 0 = False
            P_Global.Visualizador.CRV1.ReportSource = objrep 'Comentar
            P_Global.Visualizador.ShowDialog() 'Comentar
            P_Global.Visualizador.BringToFront() 'Comentar
        Else
            Dim pd As New PrintDocument()
            pd.PrinterSettings.PrinterName = _Ds3.Tables(0).Rows(0).Item("cbrut").ToString
            If (Not pd.PrinterSettings.IsValid) Then
                ToastNotification.Show(Me, "La Impresora ".ToUpper + _Ds3.Tables(0).Rows(0).Item("cbrut").ToString + Chr(13) + "No Existe".ToUpper,
                                       My.Resources.WARNING, 5 * 1000,
                                       eToastGlowColor.Blue, eToastPosition.BottomRight)
            Else
                objrep.PrintOptions.PrinterName = _Ds3.Tables(0).Rows(0).Item("cbrut").ToString
                objrep.PrintToPrinter(1, False, 0, 0)
            End If
        End If
        'If (grabarPDF) Then
        '    'Copia de Factura en PDF
        '    If (Not Directory.Exists(gs_CarpetaRaiz + "\Facturas")) Then
        '        Directory.CreateDirectory(gs_CarpetaRaiz + "\Facturas")
        '    End If
        '    objrep.ExportToDisk(ExportFormatType.PortableDocFormat, gs_CarpetaRaiz + "\Facturas\" + CStr(_NumFac) + "_" + CStr(_Autorizacion) + ".pdf")

        'End If
        L_Actualiza_Dosificacion(_numidosif, _NumFac, numi)
    End Sub

    Public Sub P_prImprimirNotaVenta(idPedido As String, impFactura As Boolean, grabarPDF As Boolean, idChofer As String, nomVendedor As String)
        Dim _Fecha, _FechaAl As Date
        Dim _Ds, _Ds2, _Ds3 As New DataSet
        Dim _Hora, _Literal, _TotalDecimal, _TotalDecimal2 As String
        Dim _NumFac, _numidosif As Integer
        Dim _Desc, _TotalLi As Decimal
        Dim _VistaPrevia As Integer = 0

        _Desc = CDbl(0)
        Dim listaResultado As DataTable = ListaPedidosNotadeVenta(idPedido)
        'Dim listResult = New LPedido().ListarDespachoXNotaVentaDeChofer(idChofer, idPedido)
        If (listaResultado.Rows.Count = 0) Then
            Throw New Exception("No hay registros para generar el reporte.")
        End If
        If Not IsNothing(P_Global.Visualizador) Then
            P_Global.Visualizador.Close()
        End If

        _Fecha = Now.Date.ToString("dd/MM/yyyy")
        _Hora = Now.Hour.ToString + ":" + Now.Minute.ToString

        '_Ds = L_Reporte_Factura(numi, numi)


        'Literal 
        '_TotalLi = listResult.Item(0).Total
        _TotalLi = listaResultado.Rows(0).Item("Total")
        _TotalDecimal = _TotalLi - Math.Truncate(_TotalLi)
        _TotalDecimal2 = CDbl(_TotalDecimal) * 100

        _Literal = Facturacion.ConvertirLiteral.A_fnConvertirLiteral(CDbl(_TotalLi) - CDbl(_TotalDecimal)) + " con " + IIf(_TotalDecimal2.Equals("0"), "00", _TotalDecimal2) + "/100 Bolivianos"
        _Ds2 = L_Reporte_Factura_Cia("1")
        _Ds3 = L_ObtenerRutaImpresora("1") ' Datos de Impresion de Facturación
        Dim objrep As Object = Nothing
        Select Case _Ds3.Tables(0).Rows(0).Item("cbtimp").ToString
            Case "1"
                ReporteNotaVenta2(idPedido, _Ds2, _Ds3, _Literal, listaResultado)
            Case "2"
                ReporteNotaVenta(idPedido, _Ds2, _Ds3, _Literal, listaResultado)
            Case "3"
                ReporteNotaVenta3(idPedido, _Ds2, _Ds3, _Literal, listaResultado)
            Case "4"
                ReporteNotaVenta4(idPedido, _Ds2, _Ds3, _Literal, listaResultado)
            Case "5"
                ReporteNotaVenta5(idPedido, _Ds2, _Ds3, _Literal, listaResultado)
            Case "6"
                ReporteNotaVenta6(idPedido, _Ds2, _Ds3, _Literal, listaResultado)
            Case "7"
                ReporteNotaVenta7(idPedido, _Ds2, _Ds3, _Literal, listaResultado)
            Case "8"
                ReporteNotaVenta8(idPedido, _Ds2, _Ds3, _Literal, listaResultado)
            Case "9"
                ReporteNotaVenta9(idPedido, _Ds2, _Ds3, _Literal, listaResultado)
            Case "10"
                ReporteNotaVenta10(idPedido, _Ds2, _Ds3, _Literal, listaResultado, nomVendedor)
            Case "11"
                ReporteNotaVenta11(idPedido, _Ds2, _Ds3, _Literal, listaResultado, nomVendedor)
            Case "12"
                ReporteNotaVenta12(idPedido, _Ds2, _Ds3, _Literal, listaResultado, nomVendedor)
            Case "13"
                ReporteNotaVenta13(idPedido, _Ds2, _Ds3, _Literal, listaResultado, nomVendedor)
            Case "14"
                ReporteNotaVenta14(idPedido, _Ds2, _Ds3, _Literal, listaResultado, nomVendedor)
            Case "15"
                ReporteNotaVenta15(idPedido, _Ds2, _Ds3, _Literal, listaResultado, nomVendedor)
            Case "16"
                ReporteNotaVenta16(idPedido, _Ds2, _Ds3, _Literal, listaResultado, nomVendedor)
            Case "17"
                ReporteNotaVenta17(idPedido, _Ds2, _Ds3, _Literal, listaResultado, nomVendedor)
            Case "18"
                ReporteNotaVenta18(idPedido, _Ds2, _Ds3, _Literal, listaResultado, nomVendedor)
        End Select
    End Sub

    Private Sub ReporteNotaVenta(idPedido As String, _Ds2 As DataSet, _Ds3 As DataSet, _Literal As String, listResult As DataTable)
        P_Global.Visualizador = New Visualizador
        Dim objrep As New NotaVenta
        Dim dia, mes, ano As Integer
        Dim Fecliteral, mesl As String
        Dim ciudad As String = _Ds2.Tables(0).Rows(0).Item("scciu").ToString


        Fecliteral = listResult.Rows(0).Item("oafdoc") 'listResult.Item(0).oafdoc
        dia = Microsoft.VisualBasic.Left(Fecliteral, 2)
        mes = Microsoft.VisualBasic.Mid(Fecliteral, 4, 2)
        ano = Microsoft.VisualBasic.Mid(Fecliteral, 7, 4)

        mesl = ObtenerMesLiberal(mes)

        Fecliteral = ciudad + ", " + dia.ToString + " de " + mesl + " del " + ano.ToString
        objrep.SetDataSource(listResult)
        objrep.SetParameterValue("Literal", _Literal)
        objrep.SetParameterValue("Fechali", Fecliteral)
        objrep.SetParameterValue("nombreUsuario", P_Global.gs_user)
        objrep.SetParameterValue("Empresa", _Ds2.Tables(0).Rows(0).Item("scneg").ToString)
        objrep.SetParameterValue("Telefono", _Ds2.Tables(0).Rows(0).Item("sctelf").ToString)
        objrep.SetParameterValue("Logo", gb_ubilogo)

        If (_Ds3.Tables(0).Rows(0).Item("cbvp")) Then 'Vista Previa de la Ventana de Vizualización 1 = True 0 = False
            P_Global.Visualizador.CRV1.ReportSource = objrep 'Comentar
            P_Global.Visualizador.ShowDialog() 'Comentar
            P_Global.Visualizador.BringToFront() 'Comentar
        Else
            Dim pd As New PrintDocument()
            pd.PrinterSettings.PrinterName = _Ds3.Tables(0).Rows(0).Item("cbrut").ToString
            If (Not pd.PrinterSettings.IsValid) Then
                ToastNotification.Show(Me, "La Impresora ".ToUpper + _Ds3.Tables(0).Rows(0).Item("cbrut").ToString + Chr(13) + "No Existe".ToUpper,
                                       My.Resources.WARNING, 5 * 1000,
                                       eToastGlowColor.Blue, eToastPosition.BottomRight)
            Else
                objrep.PrintOptions.PrinterName = _Ds3.Tables(0).Rows(0).Item("cbrut").ToString
                objrep.PrintToPrinter(2, False, 1, 1)
            End If
        End If
    End Sub

    Private Shared Function ObtenerMesLiberal(mes As Integer) As String
        Dim mesl As String = ""
        If mes = 1 Then
            mesl = "Enero"
        End If
        If mes = 2 Then
            mesl = "Febrero"
        End If
        If mes = 3 Then
            mesl = "Marzo"
        End If
        If mes = 4 Then
            mesl = "Abril"
        End If
        If mes = 5 Then
            mesl = "Mayo"
        End If
        If mes = 6 Then
            mesl = "Junio"
        End If
        If mes = 7 Then
            mesl = "Julio"
        End If
        If mes = 8 Then
            mesl = "Agosto"
        End If
        If mes = 9 Then
            mesl = "Septiembre"
        End If
        If mes = 10 Then
            mesl = "Octubre"
        End If
        If mes = 11 Then
            mesl = "Noviembre"
        End If
        If mes = 12 Then
            mesl = "Diciembre"
        End If

        Return mesl
    End Function

    Private Sub ReporteNotaVenta2(idPedido As String, _Ds2 As DataSet, _Ds3 As DataSet, _Literal As String, listResult As DataTable)
        P_Global.Visualizador = New Visualizador
        Dim objrep As New NotaVenta2
        Dim dia, mes, ano As Integer
        Dim Fecliteral, mesl As String
        'Fecliteral = _Ds.Tables(0).Rows(0).Item("fvafec").ToString
        Fecliteral = listResult.Rows(0).Item("oafdoc") 'listResult.Item(0).oafdoc
        dia = Microsoft.VisualBasic.Left(Fecliteral, 2)
        mes = Microsoft.VisualBasic.Mid(Fecliteral, 4, 2)
        ano = Microsoft.VisualBasic.Mid(Fecliteral, 7, 4)
        mesl = ObtenerMesLiberal(mes)

        Fecliteral = _Ds2.Tables(0).Rows(0).Item("scciu").ToString + " " + dia.ToString + " de " + mesl + " del " + ano.ToString
        objrep.SetDataSource(listResult)
        objrep.SetParameterValue("Literal", _Literal)
        objrep.SetParameterValue("Fechali", Fecliteral)
        objrep.SetParameterValue("nombreUsuario", P_Global.gs_user)
        objrep.SetParameterValue("Empresa", _Ds2.Tables(0).Rows(0).Item("scneg").ToString)

        If (_Ds3.Tables(0).Rows(0).Item("cbvp")) Then 'Vista Previa de la Ventana de Vizualización 1 = True 0 = False
            P_Global.Visualizador.CRV1.ReportSource = objrep 'Comentar
            P_Global.Visualizador.ShowDialog() 'Comentar
            P_Global.Visualizador.BringToFront() 'Comentar
        Else
            Dim pd As New PrintDocument()
            pd.PrinterSettings.PrinterName = _Ds3.Tables(0).Rows(0).Item("cbrut").ToString
            If (Not pd.PrinterSettings.IsValid) Then
                ToastNotification.Show(Me, "La Impresora ".ToUpper + _Ds3.Tables(0).Rows(0).Item("cbrut").ToString + Chr(13) + "No Existe".ToUpper,
                                       My.Resources.WARNING, 5 * 1000,
                                       eToastGlowColor.Blue, eToastPosition.BottomRight)
            Else
                objrep.PrintOptions.PrinterName = _Ds3.Tables(0).Rows(0).Item("cbrut").ToString
                objrep.PrintToPrinter(1, False, 0, 0)
            End If
        End If
    End Sub

    Private Sub ReporteNotaVenta3(idPedido As String, _Ds2 As DataSet, _Ds3 As DataSet, _Literal As String, listResult As DataTable)
        P_Global.Visualizador = New Visualizador
        Dim objrep As New NotaVenta3
        Dim dia, mes, ano As Integer
        Dim Fecliteral, mesl As String
        'Fecliteral = _Ds.Tables(0).Rows(0).Item("fvafec").ToString
        Fecliteral = listResult.Rows(0).Item("oafdoc") 'listResult.Item(0).oafdoc
        dia = Microsoft.VisualBasic.Left(Fecliteral, 2)
        mes = Microsoft.VisualBasic.Mid(Fecliteral, 4, 2)
        ano = Microsoft.VisualBasic.Mid(Fecliteral, 7, 4)
        mesl = ObtenerMesLiberal(mes)

        Fecliteral = _Ds2.Tables(0).Rows(0).Item("scciu").ToString + " " + dia.ToString + " de " + mesl + " del " + ano.ToString
        Dim tipoZona As String = L_fnVerificarZona("oanumi =" + idPedido)
        Dim esZonaLaPaz = IIf(tipoZona = "ES LA PAZ", "*", "")
        Dim esZonaElAlto = IIf(tipoZona = "ES EL ALTO", "*", "")


        objrep.Subreports.Item("NotaVenta3.rpt").SetDataSource(listResult)
        objrep.SetDataSource(listResult)
        'objrep.SetParameterValue("Literal", _Literal)
        'objrep.SetParameterValue("Fechali", Fecliteral)

        objrep.SetParameterValue("tipoZonaLaPaz", esZonaLaPaz)
        objrep.SetParameterValue("tipoZonaElAlto", esZonaElAlto)
        objrep.SetParameterValue("Telefono", _Ds2.Tables(0).Rows(0).Item("sctelf").ToString)
        objrep.SetParameterValue("Empresa", _Ds2.Tables(0).Rows(0).Item("scneg").ToString)
        objrep.SetParameterValue("Logo", gb_ubilogo)

        objrep.SetParameterValue("tipoZonaLaPaz", esZonaLaPaz, "NotaVenta3.rpt")
        objrep.SetParameterValue("tipoZonaElAlto", esZonaElAlto, "NotaVenta3.rpt")
        objrep.SetParameterValue("Telefono", _Ds2.Tables(0).Rows(0).Item("sctelf").ToString, "NotaVenta3.rpt")
        objrep.SetParameterValue("Empresa", _Ds2.Tables(0).Rows(0).Item("scneg").ToString, "NotaVenta3.rpt")
        objrep.SetParameterValue("Logo", gb_ubilogo, "NotaVenta3.rpt")
        If (_Ds3.Tables(0).Rows(0).Item("cbvp")) Then 'Vista Previa de la Ventana de Vizualización 1 = True 0 = False
            P_Global.Visualizador.CRV1.ReportSource = objrep 'Comentar
            P_Global.Visualizador.ShowDialog() 'Comentar
            P_Global.Visualizador.BringToFront() 'Comentar
        Else
            Dim pd As New PrintDocument()
            pd.PrinterSettings.PrinterName = _Ds3.Tables(0).Rows(0).Item("cbrut").ToString
            If (Not pd.PrinterSettings.IsValid) Then
                ToastNotification.Show(Me, "La Impresora ".ToUpper + _Ds3.Tables(0).Rows(0).Item("cbrut").ToString + Chr(13) + "No Existe".ToUpper,
                                       My.Resources.WARNING, 5 * 1000,
                                       eToastGlowColor.Blue, eToastPosition.BottomRight)
            Else
                objrep.PrintOptions.PrinterName = _Ds3.Tables(0).Rows(0).Item("cbrut").ToString
                objrep.PrintToPrinter(1, False, 0, 0)
            End If
        End If

    End Sub

    Private Sub ReporteNotaVenta4(idPedido As String, _Ds2 As DataSet, _Ds3 As DataSet, _Literal As String, listResult As DataTable)
        P_Global.Visualizador = New Visualizador
        Dim objrep As New NotaVenta4
        Dim dia, mes, ano As Integer
        Dim Fecliteral, mesl As String
        'Fecliteral = _Ds.Tables(0).Rows(0).Item("fvafec").ToString
        Fecliteral = listResult.Rows(0).Item("oafdoc") 'listResult.Item(0).oafdoc
        dia = Microsoft.VisualBasic.Left(Fecliteral, 2)
        mes = Microsoft.VisualBasic.Mid(Fecliteral, 4, 2)
        ano = Microsoft.VisualBasic.Mid(Fecliteral, 7, 4)
        mesl = ObtenerMesLiberal(mes)

        Fecliteral = _Ds2.Tables(0).Rows(0).Item("scciu").ToString + " " + dia.ToString + " de " + mesl + " del " + ano.ToString
        ' objrep.Subreports.Item("NotaVenta4.rpt").SetDataSource(listResult)
        objrep.SetDataSource(listResult)
        objrep.SetParameterValue("Telefono", _Ds2.Tables(0).Rows(0).Item("sctelf").ToString)
        objrep.SetParameterValue("Empresa", _Ds2.Tables(0).Rows(0).Item("scneg").ToString)
        objrep.SetParameterValue("Logo", gb_ubilogo)

        'objrep.SetParameterValue("Telefono", _Ds2.Tables(0).Rows(0).Item("sctelf").ToString, "NotaVenta4.rpt")
        'objrep.SetParameterValue("Empresa", _Ds2.Tables(0).Rows(0).Item("scneg").ToString, "NotaVenta4.rpt")
        'objrep.SetParameterValue("Logo", gb_ubilogo, "NotaVenta4.rpt")

        If (_Ds3.Tables(0).Rows(0).Item("cbvp")) Then 'Vista Previa de la Ventana de Vizualización 1 = True 0 = False
            P_Global.Visualizador.CRV1.ReportSource = objrep 'Comentar
            P_Global.Visualizador.ShowDialog() 'Comentar
            P_Global.Visualizador.BringToFront() 'Comentar
        Else
            Dim pd As New PrintDocument()
            pd.PrinterSettings.PrinterName = _Ds3.Tables(0).Rows(0).Item("cbrut").ToString
            If (Not pd.PrinterSettings.IsValid) Then
                ToastNotification.Show(Me, "La Impresora ".ToUpper + _Ds3.Tables(0).Rows(0).Item("cbrut").ToString + Chr(13) + "No Existe".ToUpper,
                                       My.Resources.WARNING, 5 * 1000,
                                       eToastGlowColor.Blue, eToastPosition.BottomRight)
            Else
                objrep.PrintOptions.PrinterName = _Ds3.Tables(0).Rows(0).Item("cbrut").ToString
                objrep.PrintToPrinter(1, False, 0, 0)
            End If
        End If

    End Sub
    Private Sub ReporteNotaVenta5(idPedido As String, _Ds2 As DataSet, _Ds3 As DataSet, _Literal As String, listResult As DataTable)
        P_Global.Visualizador = New Visualizador
        Dim objrep As New NotaVenta5
        Dim dia, mes, ano As Integer
        Dim Fecliteral, mesl As String
        'Fecliteral = _Ds.Tables(0).Rows(0).Item("fvafec").ToString
        Fecliteral = listResult.Rows(0).Item("oafdoc") 'listResult.Item(0).oafdoc
        dia = Microsoft.VisualBasic.Left(Fecliteral, 2)
        mes = Microsoft.VisualBasic.Mid(Fecliteral, 4, 2)
        ano = Microsoft.VisualBasic.Mid(Fecliteral, 7, 4)

        mesl = ObtenerMesLiberal(mes)

        Fecliteral = _Ds2.Tables(0).Rows(0).Item("scciu").ToString + " " + dia.ToString + " de " + mesl + " del " + ano.ToString
        objrep.SetDataSource(listResult)
        objrep.SetParameterValue("Literal", _Literal)
        objrep.SetParameterValue("Fechali", Fecliteral)
        objrep.SetParameterValue("nombreUsuario", P_Global.gs_user)
        objrep.SetParameterValue("Empresa", _Ds2.Tables(0).Rows(0).Item("scneg").ToString)
        objrep.SetParameterValue("Telefono", _Ds2.Tables(0).Rows(0).Item("sctelf").ToString)
        objrep.SetParameterValue("Logo", gb_ubilogo)

        If (_Ds3.Tables(0).Rows(0).Item("cbvp")) Then 'Vista Previa de la Ventana de Vizualización 1 = True 0 = False
            P_Global.Visualizador.CRV1.ReportSource = objrep 'Comentar
            P_Global.Visualizador.ShowDialog() 'Comentar
            P_Global.Visualizador.BringToFront() 'Comentar
        Else
            Dim pd As New PrintDocument()
            pd.PrinterSettings.PrinterName = _Ds3.Tables(0).Rows(0).Item("cbrut").ToString
            If (Not pd.PrinterSettings.IsValid) Then
                ToastNotification.Show(Me, "La Impresora ".ToUpper + _Ds3.Tables(0).Rows(0).Item("cbrut").ToString + Chr(13) + "No Existe".ToUpper,
                                       My.Resources.WARNING, 5 * 1000,
                                       eToastGlowColor.Blue, eToastPosition.BottomRight)
            Else
                objrep.PrintOptions.PrinterName = _Ds3.Tables(0).Rows(0).Item("cbrut").ToString
                objrep.PrintToPrinter(2, False, 1, 1)
            End If
        End If

    End Sub
    Private Sub ReporteNotaVenta7(idPedido As String, _Ds2 As DataSet, _Ds3 As DataSet, _Literal As String, listResult As DataTable)
        P_Global.Visualizador = New Visualizador
        Dim objrep As New NotaVenta7
        Dim dia, mes, ano As Integer
        Dim Fecliteral, mesl As String

        Fecliteral = listResult.Rows(0).Item("oafdoc") 'listResult.Item(0).oafdoc
        dia = Microsoft.VisualBasic.Left(Fecliteral, 2)
        mes = Microsoft.VisualBasic.Mid(Fecliteral, 4, 2)
        ano = Microsoft.VisualBasic.Mid(Fecliteral, 7, 4)
        mesl = ObtenerMesLiberal(mes)
        Fecliteral = _Ds2.Tables(0).Rows(0).Item("scciu").ToString + " " + dia.ToString + " de " + mesl + " del " + ano.ToString

        objrep.SetDataSource(listResult)
        objrep.SetParameterValue("Literal", _Literal)
        objrep.SetParameterValue("Fechali", Fecliteral)
        objrep.SetParameterValue("nombreUsuario", P_Global.gs_user)
        objrep.SetParameterValue("Empresa", _Ds2.Tables(0).Rows(0).Item("scneg").ToString)

        If (_Ds3.Tables(0).Rows(0).Item("cbvp")) Then 'Vista Previa de la Ventana de Vizualización 1 = True 0 = False
            P_Global.Visualizador.CRV1.ReportSource = objrep 'Comentar
            P_Global.Visualizador.ShowDialog() 'Comentar
            P_Global.Visualizador.BringToFront() 'Comentar
        Else
            Dim pd As New PrintDocument()
            pd.PrinterSettings.PrinterName = _Ds3.Tables(0).Rows(0).Item("cbrut").ToString
            If (Not pd.PrinterSettings.IsValid) Then
                ToastNotification.Show(Me, "La Impresora ".ToUpper + _Ds3.Tables(0).Rows(0).Item("cbrut").ToString + Chr(13) + "No Existe".ToUpper,
                                       My.Resources.WARNING, 5 * 1000,
                                       eToastGlowColor.Blue, eToastPosition.BottomRight)
            Else
                objrep.PrintOptions.PrinterName = _Ds3.Tables(0).Rows(0).Item("cbrut").ToString
                objrep.PrintToPrinter(2, False, 1, 1)
            End If
        End If
    End Sub
    Private Sub ReporteNotaVenta6(idPedido As String, _Ds2 As DataSet, _Ds3 As DataSet, _Literal As String, listResult As DataTable)
        P_Global.Visualizador = New Visualizador
        Dim objrep As New NotaVenta_Ticket
        Dim zona, repartidor, vendedor As String

        Dim tZonaRepartidorVendedor As DataTable = L_fnObtenerZonaRepartidorDistribuidor("oanumi =" + idPedido)
        If tZonaRepartidorVendedor.Rows.Count() > 0 Then
            zona = tZonaRepartidorVendedor.Rows(0).Item("zona").ToString()
            repartidor = tZonaRepartidorVendedor.Rows(0).Item("repartidor").ToString()
            vendedor = tZonaRepartidorVendedor.Rows(0).Item("vendedor").ToString()
        Else
            zona = "--"
            repartidor = "--"
            vendedor = "--"
        End If
        objrep.SetDataSource(listResult)
        objrep.SetParameterValue("zona", zona)
        objrep.SetParameterValue("repartidor", repartidor)
        objrep.SetParameterValue("vendedor", vendedor)
        objrep.SetParameterValue("Logo", gb_ubilogo)

        If (_Ds3.Tables(0).Rows(0).Item("cbvp")) Then 'Vista Previa de la Ventana de Vizualización 1 = True 0 = False
            P_Global.Visualizador.CRV1.ReportSource = objrep 'Comentar
            P_Global.Visualizador.ShowDialog() 'Comentar
            P_Global.Visualizador.BringToFront() 'Comentar
        Else
            Dim pd As New PrintDocument()
            pd.PrinterSettings.PrinterName = _Ds3.Tables(0).Rows(0).Item("cbrut").ToString
            If (Not pd.PrinterSettings.IsValid) Then
                ToastNotification.Show(Me, "La Impresora ".ToUpper + _Ds3.Tables(0).Rows(0).Item("cbrut").ToString + Chr(13) + "No Existe".ToUpper,
                                       My.Resources.WARNING, 5 * 1000,
                                       eToastGlowColor.Blue, eToastPosition.BottomRight)
            Else
                objrep.PrintOptions.PrinterName = _Ds3.Tables(0).Rows(0).Item("cbrut").ToString
                Dim nrocopias As Integer = _Ds3.Tables(0).Rows(0).Item("cbnrocopias")
                objrep.PrintToPrinter(nrocopias, False, 1, 1)
            End If
        End If
    End Sub

    Private Sub ReporteNotaVenta8(idPedido As String, _Ds2 As DataSet, _Ds3 As DataSet, _Literal As String, listResult As DataTable)
        P_Global.Visualizador = New Visualizador
        Dim objrep As New NotaVenta8
        Dim dia, mes, ano As Integer
        Dim Fecliteral, mesl As String

        Fecliteral = listResult.Rows(0).Item("oafdoc") 'listResult.Item(0).oafdoc
        dia = Microsoft.VisualBasic.Left(Fecliteral, 2)
        mes = Microsoft.VisualBasic.Mid(Fecliteral, 4, 2)
        ano = Microsoft.VisualBasic.Mid(Fecliteral, 7, 4)
        mesl = ObtenerMesLiberal(mes)

        Fecliteral = _Ds2.Tables(0).Rows(0).Item("scciu").ToString + " " + dia.ToString + " de " + mesl + " del " + ano.ToString
        objrep.SetDataSource(listResult)
        objrep.SetParameterValue("Telefono", _Ds2.Tables(0).Rows(0).Item("sctelf").ToString)
        objrep.SetParameterValue("Empresa", _Ds2.Tables(0).Rows(0).Item("scneg").ToString)
        objrep.SetParameterValue("Logo", gb_ubilogo)

        If (_Ds3.Tables(0).Rows(0).Item("cbvp")) Then 'Vista Previa de la Ventana de Vizualización 1 = True 0 = False
            P_Global.Visualizador.CRV1.ReportSource = objrep 'Comentar
            P_Global.Visualizador.ShowDialog() 'Comentar
            P_Global.Visualizador.BringToFront() 'Comentar
        Else
            Dim pd As New PrintDocument()
            pd.PrinterSettings.PrinterName = _Ds3.Tables(0).Rows(0).Item("cbrut").ToString
            If (Not pd.PrinterSettings.IsValid) Then
                ToastNotification.Show(Me, "La Impresora ".ToUpper + _Ds3.Tables(0).Rows(0).Item("cbrut").ToString + Chr(13) + "No Existe".ToUpper,
                                       My.Resources.WARNING, 5 * 1000,
                                       eToastGlowColor.Blue, eToastPosition.BottomRight)
            Else
                objrep.PrintOptions.PrinterName = _Ds3.Tables(0).Rows(0).Item("cbrut").ToString
                objrep.PrintToPrinter(1, False, 0, 0)
            End If
        End If
    End Sub

    Private Sub ReporteNotaVenta9(idPedido As String, _Ds2 As DataSet, _Ds3 As DataSet, _Literal As String, listResult As DataTable)
        P_Global.Visualizador = New Visualizador
        Dim objrep As New NotaVenta9
        Dim dia, mes, ano As Integer
        Dim Fecliteral, mesl As String

        Fecliteral = listResult.Rows(0).Item("oafdoc") 'listResult.Item(0).oafdoc
        dia = Microsoft.VisualBasic.Left(Fecliteral, 2)
        mes = Microsoft.VisualBasic.Mid(Fecliteral, 4, 2)
        ano = Microsoft.VisualBasic.Mid(Fecliteral, 7, 4)
        mesl = ObtenerMesLiberal(mes)

        Fecliteral = _Ds2.Tables(0).Rows(0).Item("scciu").ToString + " " + dia.ToString + " de " + mesl + " del " + ano.ToString
        objrep.SetDataSource(listResult)
        objrep.SetParameterValue("Telefono", _Ds2.Tables(0).Rows(0).Item("sctelf").ToString)
        objrep.SetParameterValue("Empresa", _Ds2.Tables(0).Rows(0).Item("scneg").ToString)
        objrep.SetParameterValue("Logo", gb_ubilogo)

        If (_Ds3.Tables(0).Rows(0).Item("cbvp")) Then 'Vista Previa de la Ventana de Vizualización 1 = True 0 = False
            P_Global.Visualizador.CRV1.ReportSource = objrep 'Comentar
            P_Global.Visualizador.ShowDialog() 'Comentar
            P_Global.Visualizador.BringToFront() 'Comentar
        Else
            Dim pd As New PrintDocument()
            pd.PrinterSettings.PrinterName = _Ds3.Tables(0).Rows(0).Item("cbrut").ToString
            If (Not pd.PrinterSettings.IsValid) Then
                ToastNotification.Show(Me, "La Impresora ".ToUpper + _Ds3.Tables(0).Rows(0).Item("cbrut").ToString + Chr(13) + "No Existe".ToUpper,
                                       My.Resources.WARNING, 5 * 1000,
                                       eToastGlowColor.Blue, eToastPosition.BottomRight)
            Else
                objrep.PrintOptions.PrinterName = _Ds3.Tables(0).Rows(0).Item("cbrut").ToString
                objrep.PrintToPrinter(1, False, 0, 0)
            End If
        End If
    End Sub
    Private Sub ReporteNotaVenta10(idPedido As String, _Ds2 As DataSet, _Ds3 As DataSet, _Literal As String, listResult As DataTable, nomVendedor As String)
        P_Global.Visualizador = New Visualizador
        Dim objrep As New NotaVenta10
        Dim dia, mes, ano As Integer
        Dim Fecliteral, mesl As String

        Fecliteral = listResult.Rows(0).Item("oafdoc") 'listResult.Item(0).oafdoc
        dia = Microsoft.VisualBasic.Left(Fecliteral, 2)
        mes = Microsoft.VisualBasic.Mid(Fecliteral, 4, 2)
        ano = Microsoft.VisualBasic.Mid(Fecliteral, 7, 4)
        mesl = ObtenerMesLiberal(mes)
        Dim dt As DataTable = L_prObtenerGrupo(idPedido)
        Fecliteral = _Ds2.Tables(0).Rows(0).Item("scciu").ToString + " " + dia.ToString + " de " + mesl + " del " + ano.ToString
        objrep.SetDataSource(listResult)
        objrep.SetParameterValue("Telefono", _Ds2.Tables(0).Rows(0).Item("sctelf").ToString)
        objrep.SetParameterValue("Direccion", _Ds2.Tables(0).Rows(0).Item("scdir").ToString)
        objrep.SetParameterValue("Ciudad", _Ds2.Tables(0).Rows(0).Item("scciu").ToString)
        objrep.SetParameterValue("Empresa", gs_empresaDescSistema)
        objrep.SetParameterValue("idPedido", idPedido)
        objrep.SetParameterValue("tgrupo", dt.Rows(0).Item("cedesc"))
        objrep.SetParameterValue("Logo", gb_ubilogo)
        objrep.SetParameterValue("vendedor", nomVendedor)


        If (_Ds3.Tables(0).Rows(0).Item("cbvp")) Then 'Vista Previa de la Ventana de Vizualización 1 = True 0 = False
            P_Global.Visualizador.CRV1.ReportSource = objrep 'Comentar
            P_Global.Visualizador.ShowDialog() 'Comentar
            P_Global.Visualizador.BringToFront() 'Comentar
        Else
            Dim pd As New PrintDocument()
            pd.PrinterSettings.PrinterName = _Ds3.Tables(0).Rows(0).Item("cbrut").ToString
            If (Not pd.PrinterSettings.IsValid) Then
                ToastNotification.Show(Me, "La Impresora ".ToUpper + _Ds3.Tables(0).Rows(0).Item("cbrut").ToString + Chr(13) + "No Existe".ToUpper,
                                       My.Resources.WARNING, 5 * 1000,
                                       eToastGlowColor.Blue, eToastPosition.BottomRight)
            Else
                objrep.PrintOptions.PrinterName = _Ds3.Tables(0).Rows(0).Item("cbrut").ToString
                objrep.PrintToPrinter(1, False, 0, 0)
            End If
        End If
    End Sub
    Private Sub ReporteNotaVenta11(idPedido As String, _Ds2 As DataSet, _Ds3 As DataSet, _Literal As String, listResult As DataTable, nomVendedor As String)
        P_Global.Visualizador = New Visualizador
        Dim objrep As New NotaVenta11
        Dim dia, mes, ano As Integer
        Dim Fecliteral, mesl As String

        Fecliteral = listResult.Rows(0).Item("oafdoc") 'listResult.Item(0).oafdoc
        dia = Microsoft.VisualBasic.Left(Fecliteral, 2)
        mes = Microsoft.VisualBasic.Mid(Fecliteral, 4, 2)
        ano = Microsoft.VisualBasic.Mid(Fecliteral, 7, 4)
        mesl = ObtenerMesLiberal(mes)

        Fecliteral = _Ds2.Tables(0).Rows(0).Item("scciu").ToString + " " + dia.ToString + " de " + mesl + " del " + ano.ToString
        objrep.SetDataSource(listResult)
        objrep.SetParameterValue("Telefono", _Ds2.Tables(0).Rows(0).Item("sctelf").ToString)
        objrep.SetParameterValue("Direccion", _Ds2.Tables(0).Rows(0).Item("scdir").ToString)
        objrep.SetParameterValue("Ciudad", _Ds2.Tables(0).Rows(0).Item("scciu").ToString)
        objrep.SetParameterValue("Empresa", gs_empresaDescSistema)
        objrep.SetParameterValue("idPedido", idPedido)
        objrep.SetParameterValue("vendedor", nomVendedor)


        If (_Ds3.Tables(0).Rows(0).Item("cbvp")) Then 'Vista Previa de la Ventana de Vizualización 1 = True 0 = False
            P_Global.Visualizador.CRV1.ReportSource = objrep 'Comentar
            P_Global.Visualizador.ShowDialog() 'Comentar
            P_Global.Visualizador.BringToFront() 'Comentar
        Else
            Dim pd As New PrintDocument()
            pd.PrinterSettings.PrinterName = _Ds3.Tables(0).Rows(0).Item("cbrut").ToString
            If (Not pd.PrinterSettings.IsValid) Then
                ToastNotification.Show(Me, "La Impresora ".ToUpper + _Ds3.Tables(0).Rows(0).Item("cbrut").ToString + Chr(13) + "No Existe".ToUpper,
                                       My.Resources.WARNING, 5 * 1000,
                                       eToastGlowColor.Blue, eToastPosition.BottomRight)
            Else
                objrep.PrintOptions.PrinterName = _Ds3.Tables(0).Rows(0).Item("cbrut").ToString
                objrep.PrintToPrinter(1, False, 0, 0)
            End If
        End If
    End Sub

    Private Sub ReporteNotaVenta12(idPedido As String, _Ds2 As DataSet, _Ds3 As DataSet, _Literal As String, listResult As DataTable, nomVendedor As String)
        P_Global.Visualizador = New Visualizador
        Dim objrep As New NotaVenta12
        Dim dia, mes, ano As Integer
        Dim Fecliteral, mesl As String

        Fecliteral = listResult.Rows(0).Item("oafdoc") 'listResult.Item(0).oafdoc
        dia = Microsoft.VisualBasic.Left(Fecliteral, 2)
        mes = Microsoft.VisualBasic.Mid(Fecliteral, 4, 2)
        ano = Microsoft.VisualBasic.Mid(Fecliteral, 7, 4)
        mesl = ObtenerMesLiberal(mes)

        Fecliteral = _Ds2.Tables(0).Rows(0).Item("scciu").ToString + " " + dia.ToString + " de " + mesl + " del " + ano.ToString
        objrep.SetDataSource(listResult)
        objrep.SetParameterValue("Telefono", _Ds2.Tables(0).Rows(0).Item("sctelf").ToString)
        objrep.SetParameterValue("Direccion", _Ds2.Tables(0).Rows(0).Item("scdir").ToString)
        objrep.SetParameterValue("Ciudad", _Ds2.Tables(0).Rows(0).Item("scciu").ToString)
        objrep.SetParameterValue("Empresa", gs_empresaDescSistema)
        objrep.SetParameterValue("idPedido", idPedido)
        objrep.SetParameterValue("Logo", gb_ubilogo)
        objrep.SetParameterValue("vendedor", nomVendedor)


        If (_Ds3.Tables(0).Rows(0).Item("cbvp")) Then 'Vista Previa de la Ventana de Vizualización 1 = True 0 = False
            P_Global.Visualizador.CRV1.ReportSource = objrep 'Comentar
            P_Global.Visualizador.ShowDialog() 'Comentar
            P_Global.Visualizador.BringToFront() 'Comentar
        Else
            Dim pd As New PrintDocument()
            pd.PrinterSettings.PrinterName = _Ds3.Tables(0).Rows(0).Item("cbrut").ToString
            If (Not pd.PrinterSettings.IsValid) Then
                ToastNotification.Show(Me, "La Impresora ".ToUpper + _Ds3.Tables(0).Rows(0).Item("cbrut").ToString + Chr(13) + "No Existe".ToUpper,
                                       My.Resources.WARNING, 5 * 1000,
                                       eToastGlowColor.Blue, eToastPosition.BottomRight)
            Else
                objrep.PrintOptions.PrinterName = _Ds3.Tables(0).Rows(0).Item("cbrut").ToString
                objrep.PrintToPrinter(1, False, 0, 0)
            End If
        End If
    End Sub


    Private Sub ReporteNotaVenta13(idPedido As String, _Ds2 As DataSet, _Ds3 As DataSet, _Literal As String, listResult As DataTable, nomVendedor As String)
        P_Global.Visualizador = New Visualizador
        Dim objrep As New NotaVenta13
        Dim dia, mes, ano As Integer
        Dim Fecliteral, mesl As String

        Fecliteral = listResult.Rows(0).Item("oafdoc") 'listResult.Item(0).oafdoc
        dia = Microsoft.VisualBasic.Left(Fecliteral, 2)
        mes = Microsoft.VisualBasic.Mid(Fecliteral, 4, 2)
        ano = Microsoft.VisualBasic.Mid(Fecliteral, 7, 4)
        mesl = ObtenerMesLiberal(mes)

        Fecliteral = _Ds2.Tables(0).Rows(0).Item("scciu").ToString + " " + dia.ToString + " de " + mesl + " del " + ano.ToString
        objrep.SetDataSource(listResult)
        objrep.SetParameterValue("Telefono", _Ds2.Tables(0).Rows(0).Item("sctelf").ToString)
        objrep.SetParameterValue("Direccion", _Ds2.Tables(0).Rows(0).Item("scdir").ToString)
        objrep.SetParameterValue("Ciudad", _Ds2.Tables(0).Rows(0).Item("scciu").ToString)
        objrep.SetParameterValue("Empresa", gs_empresaDescSistema)
        objrep.SetParameterValue("idPedido", idPedido)
        objrep.SetParameterValue("Logo", gb_ubilogo)
        objrep.SetParameterValue("vendedor", nomVendedor)


        If (_Ds3.Tables(0).Rows(0).Item("cbvp")) Then 'Vista Previa de la Ventana de Vizualización 1 = True 0 = False
            P_Global.Visualizador.CRV1.ReportSource = objrep 'Comentar
            P_Global.Visualizador.ShowDialog() 'Comentar
            P_Global.Visualizador.BringToFront() 'Comentar
        Else
            Dim pd As New PrintDocument()
            pd.PrinterSettings.PrinterName = _Ds3.Tables(0).Rows(0).Item("cbrut").ToString
            If (Not pd.PrinterSettings.IsValid) Then
                ToastNotification.Show(Me, "La Impresora ".ToUpper + _Ds3.Tables(0).Rows(0).Item("cbrut").ToString + Chr(13) + "No Existe".ToUpper,
                                       My.Resources.WARNING, 5 * 1000,
                                       eToastGlowColor.Blue, eToastPosition.BottomRight)
            Else
                objrep.PrintOptions.PrinterName = _Ds3.Tables(0).Rows(0).Item("cbrut").ToString
                objrep.PrintToPrinter(1, False, 0, 0)
            End If
        End If
    End Sub

    Private Sub ReporteNotaVenta14(idPedido As String, _Ds2 As DataSet, _Ds3 As DataSet, _Literal As String, listResult As DataTable, nomVendedor As String)
        P_Global.Visualizador = New Visualizador
        Dim objrep As New NotaVenta15
        Dim dia, mes, ano As Integer
        Dim Fecliteral, mesl As String

        Dim dt As DataTable = L_prPedidoTipoVenta(CInt(idPedido))

        Fecliteral = Date.Now.ToString("dd/MM/yyyy") 'listResult.Item(0).oafdoc
        dia = Microsoft.VisualBasic.Left(Fecliteral, 2)
        mes = Microsoft.VisualBasic.Mid(Fecliteral, 4, 2)
        ano = Microsoft.VisualBasic.Mid(Fecliteral, 7, 4)
        mesl = ObtenerMesLiberal(mes)

        Fecliteral = _Ds2.Tables(0).Rows(0).Item("scciu").ToString + " " + dia.ToString + " de " + mesl + " del " + ano.ToString
        objrep.SetDataSource(listResult)
        objrep.SetParameterValue("Telefono", _Ds2.Tables(0).Rows(0).Item("sctelf").ToString)
        objrep.SetParameterValue("Direccion", _Ds2.Tables(0).Rows(0).Item("scdir").ToString)
        objrep.SetParameterValue("Ciudad", _Ds2.Tables(0).Rows(0).Item("scciu").ToString)
        objrep.SetParameterValue("Empresa", gs_empresaDescSistema)
        objrep.SetParameterValue("idPedido", idPedido)
        objrep.SetParameterValue("Logo", gb_ubilogo)
        objrep.SetParameterValue("vendedor", nomVendedor)
        objrep.SetParameterValue("Distribuidor", cbChoferes.Text)
        objrep.SetParameterValue("fechaL", Fecliteral)
        objrep.SetParameterValue("tipoventa", IIf(dt.Rows.Count > 0, dt.Rows(0).Item("oaobs"), ""))



        If (_Ds3.Tables(0).Rows(0).Item("cbvp")) Then 'Vista Previa de la Ventana de Vizualización 1 = True 0 = False
            P_Global.Visualizador.CRV1.ReportSource = objrep 'Comentar
            P_Global.Visualizador.ShowDialog() 'Comentar
            P_Global.Visualizador.BringToFront() 'Comentar
        Else
            Dim pd As New PrintDocument()
            pd.PrinterSettings.PrinterName = _Ds3.Tables(0).Rows(0).Item("cbrut").ToString
            If (Not pd.PrinterSettings.IsValid) Then
                ToastNotification.Show(Me, "La Impresora ".ToUpper + _Ds3.Tables(0).Rows(0).Item("cbrut").ToString + Chr(13) + "No Existe".ToUpper,
                                       My.Resources.WARNING, 5 * 1000,
                                       eToastGlowColor.Blue, eToastPosition.BottomRight)
            Else
                objrep.PrintOptions.PrinterName = _Ds3.Tables(0).Rows(0).Item("cbrut").ToString
                objrep.PrintToPrinter(1, False, 0, 0)
            End If
        End If
    End Sub

    Private Sub ReporteNotaVenta16(idPedido As String, _Ds2 As DataSet, _Ds3 As DataSet, _Literal As String, listResult As DataTable, nomVendedor As String)
        P_Global.Visualizador = New Visualizador
        Dim objrep As New NotaVenta16
        Dim dia, mes, ano As Integer
        Dim Fecliteral, mesl As String

        Dim dt As DataTable = L_prPedidoTipoVenta(CInt(idPedido))

        Fecliteral = Date.Now.ToString("dd/MM/yyyy") 'listResult.Item(0).oafdoc
        dia = Microsoft.VisualBasic.Left(Fecliteral, 2)
        mes = Microsoft.VisualBasic.Mid(Fecliteral, 4, 2)
        ano = Microsoft.VisualBasic.Mid(Fecliteral, 7, 4)
        mesl = ObtenerMesLiberal(mes)

        Fecliteral = _Ds2.Tables(0).Rows(0).Item("scciu").ToString + " " + dia.ToString + " de " + mesl + " del " + ano.ToString
        objrep.SetDataSource(listResult)
        objrep.SetParameterValue("Telefono", _Ds2.Tables(0).Rows(0).Item("sctelf").ToString)
        objrep.SetParameterValue("Direccion", _Ds2.Tables(0).Rows(0).Item("scdir").ToString)
        objrep.SetParameterValue("Ciudad", _Ds2.Tables(0).Rows(0).Item("scciu").ToString)
        objrep.SetParameterValue("Empresa", gs_empresaDescSistema)
        objrep.SetParameterValue("idPedido", idPedido)
        objrep.SetParameterValue("Logo", gb_ubilogo)
        objrep.SetParameterValue("vendedor", nomVendedor)
        objrep.SetParameterValue("Distribuidor", cbChoferes.Text)
        objrep.SetParameterValue("fechaL", Fecliteral)
        objrep.SetParameterValue("tipoventa", IIf(dt.Rows.Count > 0, dt.Rows(0).Item("oaobs"), ""))



        If (_Ds3.Tables(0).Rows(0).Item("cbvp")) Then 'Vista Previa de la Ventana de Vizualización 1 = True 0 = False
            P_Global.Visualizador.CRV1.ReportSource = objrep 'Comentar
            P_Global.Visualizador.ShowDialog() 'Comentar
            P_Global.Visualizador.BringToFront() 'Comentar
        Else
            Dim pd As New PrintDocument()
            pd.PrinterSettings.PrinterName = _Ds3.Tables(0).Rows(0).Item("cbrut").ToString
            If (Not pd.PrinterSettings.IsValid) Then
                ToastNotification.Show(Me, "La Impresora ".ToUpper + _Ds3.Tables(0).Rows(0).Item("cbrut").ToString + Chr(13) + "No Existe".ToUpper,
                                       My.Resources.WARNING, 5 * 1000,
                                       eToastGlowColor.Blue, eToastPosition.BottomRight)
            Else
                objrep.PrintOptions.PrinterName = _Ds3.Tables(0).Rows(0).Item("cbrut").ToString
                objrep.PrintToPrinter(1, False, 0, 0)
            End If
        End If
    End Sub

    Private Sub ReporteNotaVenta17(idPedido As String, _Ds2 As DataSet, _Ds3 As DataSet, _Literal As String, listResult As DataTable, nomVendedor As String)
        P_Global.Visualizador = New Visualizador
        Dim objrep As New NotaVenta17
        Dim dia, mes, ano As Integer
        Dim Fecliteral, mesl As String

        Dim dt As DataTable = L_prPedidoTipoVenta(CInt(idPedido))

        Fecliteral = Date.Now.ToString("dd/MM/yyyy") 'listResult.Item(0).oafdoc
        dia = Microsoft.VisualBasic.Left(Fecliteral, 2)
        mes = Microsoft.VisualBasic.Mid(Fecliteral, 4, 2)
        ano = Microsoft.VisualBasic.Mid(Fecliteral, 7, 4)
        mesl = ObtenerMesLiberal(mes)

        Fecliteral = _Ds2.Tables(0).Rows(0).Item("scciu").ToString + " " + dia.ToString + " de " + mesl + " del " + ano.ToString
        objrep.SetDataSource(listResult)
        objrep.SetParameterValue("Telefono", _Ds2.Tables(0).Rows(0).Item("sctelf").ToString)
        objrep.SetParameterValue("Direccion", _Ds2.Tables(0).Rows(0).Item("scdir").ToString)
        objrep.SetParameterValue("Ciudad", _Ds2.Tables(0).Rows(0).Item("scciu").ToString)
        objrep.SetParameterValue("Empresa", gs_empresaDescSistema)
        objrep.SetParameterValue("idPedido", idPedido)
        objrep.SetParameterValue("Logo", gb_ubilogo)
        objrep.SetParameterValue("vendedor", nomVendedor)
        objrep.SetParameterValue("Distribuidor", cbChoferes.Text)
        objrep.SetParameterValue("fechaL", Fecliteral)
        objrep.SetParameterValue("tipoventa", IIf(dt.Rows.Count > 0, dt.Rows(0).Item("oaobs"), ""))



        If (_Ds3.Tables(0).Rows(0).Item("cbvp")) Then 'Vista Previa de la Ventana de Vizualización 1 = True 0 = False
            P_Global.Visualizador.CRV1.ReportSource = objrep 'Comentar
            P_Global.Visualizador.ShowDialog() 'Comentar
            P_Global.Visualizador.BringToFront() 'Comentar
        Else
            Dim pd As New PrintDocument()
            pd.PrinterSettings.PrinterName = _Ds3.Tables(0).Rows(0).Item("cbrut").ToString
            If (Not pd.PrinterSettings.IsValid) Then
                ToastNotification.Show(Me, "La Impresora ".ToUpper + _Ds3.Tables(0).Rows(0).Item("cbrut").ToString + Chr(13) + "No Existe".ToUpper,
                                       My.Resources.WARNING, 5 * 1000,
                                       eToastGlowColor.Blue, eToastPosition.BottomRight)
            Else
                objrep.PrintOptions.PrinterName = _Ds3.Tables(0).Rows(0).Item("cbrut").ToString
                objrep.PrintToPrinter(1, False, 0, 0)
            End If
        End If
    End Sub

    Private Sub ReporteNotaVenta18(idPedido As String, _Ds2 As DataSet, _Ds3 As DataSet, _Literal As String, listResult As DataTable, nomVendedor As String)
        P_Global.Visualizador = New Visualizador
        Dim objrep As New NotaVenta18
        Dim dia, mes, ano As Integer
        Dim Fecliteral, mesl As String

        Dim dt As DataTable = L_prPedidoTipoVenta(CInt(idPedido))

        Fecliteral = Date.Now.ToString("dd/MM/yyyy") 'listResult.Item(0).oafdoc
        dia = Microsoft.VisualBasic.Left(Fecliteral, 2)
        mes = Microsoft.VisualBasic.Mid(Fecliteral, 4, 2)
        ano = Microsoft.VisualBasic.Mid(Fecliteral, 7, 4)
        mesl = ObtenerMesLiberal(mes)

        Fecliteral = _Ds2.Tables(0).Rows(0).Item("scciu").ToString + " " + dia.ToString + " de " + mesl + " del " + ano.ToString
        objrep.Subreports.Item("SubNotaVenta.rpt").SetDataSource(listResult)
        objrep.Subreports.Item("SubNotaVenta.rpt - 01").SetDataSource(listResult)
        objrep.SetDataSource(listResult)
        objrep.SetParameterValue("Telefono", _Ds2.Tables(0).Rows(0).Item("sctelf").ToString)
        objrep.SetParameterValue("Direccion", _Ds2.Tables(0).Rows(0).Item("scdir").ToString)
        objrep.SetParameterValue("Ciudad", _Ds2.Tables(0).Rows(0).Item("scciu").ToString)
        objrep.SetParameterValue("Empresa", gs_empresaDescSistema)
        objrep.SetParameterValue("idPedido", idPedido)
        objrep.SetParameterValue("Logo", gb_ubilogo)
        objrep.SetParameterValue("vendedor", nomVendedor)
        objrep.SetParameterValue("Distribuidor", cbChoferes.Text)
        objrep.SetParameterValue("fechaL", Fecliteral)
        objrep.SetParameterValue("tipoventa", IIf(dt.Rows.Count > 0, dt.Rows(0).Item("oaobs"), ""))



        If (_Ds3.Tables(0).Rows(0).Item("cbvp")) Then 'Vista Previa de la Ventana de Vizualización 1 = True 0 = False
            P_Global.Visualizador.CRV1.ReportSource = objrep 'Comentar
            P_Global.Visualizador.ShowDialog() 'Comentar
            P_Global.Visualizador.BringToFront() 'Comentar
        Else
            Dim pd As New PrintDocument()
            pd.PrinterSettings.PrinterName = _Ds3.Tables(0).Rows(0).Item("cbrut").ToString
            If (Not pd.PrinterSettings.IsValid) Then
                ToastNotification.Show(Me, "La Impresora ".ToUpper + _Ds3.Tables(0).Rows(0).Item("cbrut").ToString + Chr(13) + "No Existe".ToUpper,
                                       My.Resources.WARNING, 5 * 1000,
                                       eToastGlowColor.Blue, eToastPosition.BottomRight)
            Else
                objrep.PrintOptions.PrinterName = _Ds3.Tables(0).Rows(0).Item("cbrut").ToString
                objrep.PrintToPrinter(1, False, 0, 0)
            End If
        End If
    End Sub
    Private Sub ReporteNotaVenta15(idPedido As String, _Ds2 As DataSet, _Ds3 As DataSet, _Literal As String, listResult As DataTable, nomVendedor As String)
        P_Global.Visualizador = New Visualizador
        Dim objrep As New NotaVenta14
        Dim dia, mes, ano As Integer
        Dim Fecliteral, mesl As String

        Dim dt As DataTable = L_prPedidoTipoVenta(CInt(idPedido))

        Fecliteral = Date.Now.ToString("dd/MM/yyyy") 'listResult.Item(0).oafdoc
        dia = Microsoft.VisualBasic.Left(Fecliteral, 2)
        mes = Microsoft.VisualBasic.Mid(Fecliteral, 4, 2)
        ano = Microsoft.VisualBasic.Mid(Fecliteral, 7, 4)
        mesl = ObtenerMesLiberal(mes)

        Fecliteral = _Ds2.Tables(0).Rows(0).Item("scciu").ToString + " " + dia.ToString + " de " + mesl + " del " + ano.ToString
        objrep.SetDataSource(listResult)
        'objrep.SetParameterValue("Telefono", _Ds2.Tables(0).Rows(0).Item("sctelf").ToString)
        'objrep.SetParameterValue("Direccion", _Ds2.Tables(0).Rows(0).Item("scdir").ToString)
        'objrep.SetParameterValue("Ciudad", _Ds2.Tables(0).Rows(0).Item("scciu").ToString)
        'objrep.SetParameterValue("Empresa", gs_empresaDescSistema)
        'objrep.SetParameterValue("idPedido", idPedido)
        'objrep.SetParameterValue("Logo", gb_ubilogo)
        'objrep.SetParameterValue("vendedor", nomVendedor)
        'objrep.SetParameterValue("Distribuidor", cbChoferes.Text)
        'objrep.SetParameterValue("fechaL", Fecliteral)
        'objrep.SetParameterValue("tipoventa", IIf(dt.Rows.Count > 0, dt.Rows(0).Item("oaobs"), ""))



        If (_Ds3.Tables(0).Rows(0).Item("cbvp")) Then 'Vista Previa de la Ventana de Vizualización 1 = True 0 = False
            P_Global.Visualizador.CRV1.ReportSource = objrep 'Comentar
            P_Global.Visualizador.ShowDialog() 'Comentar
            P_Global.Visualizador.BringToFront() 'Comentar
        Else
            Dim pd As New PrintDocument()
            pd.PrinterSettings.PrinterName = _Ds3.Tables(0).Rows(0).Item("cbrut").ToString
            If (Not pd.PrinterSettings.IsValid) Then
                ToastNotification.Show(Me, "La Impresora ".ToUpper + _Ds3.Tables(0).Rows(0).Item("cbrut").ToString + Chr(13) + "No Existe".ToUpper,
                                       My.Resources.WARNING, 5 * 1000,
                                       eToastGlowColor.Blue, eToastPosition.BottomRight)
            Else
                objrep.PrintOptions.PrinterName = _Ds3.Tables(0).Rows(0).Item("cbrut").ToString
                objrep.PrintToPrinter(1, False, 0, 0)
            End If
        End If
    End Sub

    Public Function P_fnImageToByteArray(ByVal imageIn As Image) As Byte()
        Dim ms As New System.IO.MemoryStream()
        'imageIn.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg)
        Return ms.ToArray()
    End Function
    Private Function P_fnGrabarFacturarTFV001(numi As String, subtotal As Double, descuento As Double, total As Double, nit As String, nameCliente As String, Codcli As String) As Boolean
        Dim a As Double = subtotal
        Dim b As Double = CDbl(0) 'Ya esta calculado el 55% del ICE
        Dim c As Double = CDbl("0")
        Dim d As Double = CDbl("0")
        Dim e As Double = a - b - c - d
        Dim f As Double = descuento
        Dim g As Double = e - f
        Dim h As Double = g * (13 / 100)

        Dim res As Boolean = False
        'Grabado de Cabesera Factura
        L_Grabar_Factura(numi,
                        Now.Date.ToString("yyyy/MM/dd"), "0", "0",
                        "1",
                        nit,
                        Codcli,
                       nameCliente,
                        "",
                        CStr(Format(a, "####0.00")),
                        CStr(Format(b, "####0.00")),
                        CStr(Format(c, "####0.00")),
                        CStr(Format(d, "####0.00")),
                        CStr(Format(e, "####0.00")),
                        CStr(Format(f, "####0.00")),
                        CStr(Format(g, "####0.00")),
                        CStr(Format(h, "####0.00")),
                        "",
                        Now.Date.ToString("yyyy/MM/dd"),
                        "''",
                        "0",
                        numi)


        Dim dtDetalle As DataTable = L_prObtenerDetallePedido(numi)
        For i As Integer = 0 To dtDetalle.Rows.Count - 1 Step 1

            L_Grabar_Factura_Detalle(numi.ToString,
                                        dtDetalle.Rows(i).Item("obcprod").ToString,
                                         dtDetalle.Rows(i).Item("producto").ToString,
                                        dtDetalle.Rows(i).Item("obpcant").ToString,
                                        dtDetalle.Rows(i).Item("obpbase").ToString,
                                        numi)

        Next
        Return True
    End Function

    Private Sub btReporteDespachoCliente_Click(sender As Object, e As EventArgs) Handles btReporteDespachoCliente.Click
        Try
            Dim idChofer = Me.cbChoferes.Value
            If (Not IsNumeric(idChofer)) Then
                Throw New Exception("Debe seleccionar un chofer.")
            End If
            If (Convert.ToInt32(idChofer) = ENCombo.ID_SELECCIONAR) Then
                Throw New Exception("Debe seleccionar un chofer.")
            End If

            'Dim listResult = New LPedido().ListarDespachoXClienteDeChofer(idChofer, IIf(cbEstado.SelectedIndex = 0, ENEstadoPedido.DICTADO, ENEstadoPedido.ENTREGADO))
            'Dim lista = (From a In listResult
            '             Where a.oafdoc >= Tb_Fecha.Value And
            '                    a.oafdoc <= Tb_FechaHasta.Value
            '             Order By a.oanumi Ascending).ToList
            Dim dt As DataTable = ListarDespachoXcLIENTE(idChofer, cbEstados.Value, Tb_Fecha.Value.ToString("dd/MM/yyyy"), Tb_FechaHasta.Value.ToString("dd/MM/yyyy"))

            If (dt.Rows.Count = 0) Then
                Throw New Exception("No hay registros para generar el reporte.")
            End If

            If Not IsNothing(P_Global.Visualizador) Then
                P_Global.Visualizador.Close()
            End If

            P_Global.Visualizador = New Visualizador
            Dim objrep As New DespachoXCliente

            objrep.SetDataSource(dt)
            objrep.SetParameterValue("nroDespacho", String.Empty)
            objrep.SetParameterValue("nombreDistribuidor", cbChoferes.Text)
            objrep.SetParameterValue("FechaDocumento", Tb_Fecha.Value)
            objrep.SetParameterValue("nombreUsuario", P_Global.gs_user)
            objrep.SetParameterValue("moneda", gs_Mon)

            P_Global.Visualizador.CRV1.ReportSource = objrep
            P_Global.Visualizador.Show()
            P_Global.Visualizador.BringToFront()
        Catch ex As Exception
            MostrarMensajeError(ex.Message)
        End Try
    End Sub

    Private Sub btReporteDespachoLinea_Click(sender As Object, e As EventArgs) Handles btReporteDespachoLinea.Click
        Try
            Dim idChofer = Me.cbChoferes.Value
            If (Not IsNumeric(idChofer)) Then
                Throw New Exception("Debe seleccionar un chofer.")
            End If
            If (Convert.ToInt32(idChofer) = ENCombo.ID_SELECCIONAR) Then
                Throw New Exception("Debe seleccionar un chofer.")
            End If

            Dim listaResultado As DataTable = ReporteDespachoxProducto(idChofer, cbEstados.Value, Tb_Fecha.Value.ToString("dd/MM/yyyy"), Tb_FechaHasta.Value.ToString("dd/MM/yyyy"))

            'Dim listResult = New LPedido().ListarDespachoXProductoDeChofer(idChofer, cbEstados.Value, Tb_Fecha.Value, Tb_FechaHasta.Value)
            'Dim lista = (From a In listResult
            '             Group a By a.canumi, a.cadesc, a.categoria Into grupo = Group
            '             Select New RDespachoXProducto With {
            '              .canumi = grupo.FirstOrDefault().canumi,
            '              .cacod = grupo.FirstOrDefault().cacod,
            '              .cadesc = grupo.FirstOrDefault().cadesc,
            '              .categoria = grupo.FirstOrDefault().categoria,
            '              .obpcant = grupo.Sum(Function(item) item.obpcant),
            '              .Caja = grupo.Sum(Function(item) item.Caja),
            '              .Unidad = grupo.FirstOrDefault().Unidad,'grupo.Sum(Function(item) item.Unidad),
            '              .Total = grupo.Sum(Function(item) item.Total),
            '              .Conv = grupo.FirstOrDefault().Conv,
            '              .Pesokg = grupo.Sum(Function(item) item.Pesokg)
            '            }).ToList()
            If (listaResultado.Rows.Count = 0) Then
                Throw New Exception("No hay registros para generar el reporte.")
            End If
            Dim empresaId = ObtenerEmpresaHabilitada()
            Dim empresaHabilitada As DataTable = ObtenerEmpresaTipoReporte(empresaId, Convert.ToInt32(ENReporte.DESPACHOXPRODUCTO))
            For Each fila As DataRow In empresaHabilitada.Rows
                Select Case fila.Item("TipoReporte").ToString
                    Case ENReporteTipo.DESPACHOXPRODUCTO_AgrupadoXCategoria
                        Dim objrep As New DespachoXProducto
                        SerParametros(listaResultado, objrep)
                    Case ENReporteTipo.DESPACHOXPRODUCTO_SinAgrupacion
                        Dim objrep As New DespachoXProductoSinAgrupacion
                        SerParametros(listaResultado, objrep)
                End Select
            Next
        Catch ex As Exception
            MostrarMensajeError(ex.Message)
        End Try
    End Sub

    Private Sub SerParametros(listResult As DataTable, objrep As Object)
        If Not IsNothing(P_Global.Visualizador) Then
            P_Global.Visualizador.Close()
        End If
        P_Global.Visualizador = New Visualizador
        objrep.SetDataSource(listResult)
        objrep.SetParameterValue("nroDespacho", String.Empty)
        objrep.SetParameterValue("nombreDistribuidor", cbChoferes.Text)
        objrep.SetParameterValue("FechaDocumento", Tb_Fecha.Value)
        objrep.SetParameterValue("nombreUsuario", P_Global.gs_user)
        P_Global.Visualizador.CRV1.ReportSource = objrep
        P_Global.Visualizador.ShowDialog()
        P_Global.Visualizador.BringToFront()
    End Sub

    Private Sub dgjPedido_SelectionChanged(sender As Object, e As EventArgs) Handles dgjPedido.SelectionChanged
        Try
            Dim idPedido = 0
            If (dgjPedido.GetRows().Count > 0) Then
                idPedido = Convert.ToInt32(dgjPedido.CurrentRow.Cells("Id").Value)
            End If

            CargarProductos(idPedido)
        Catch ex As Exception
            MostrarMensajeError(ex.Message)
        End Try
    End Sub
    Private Sub Tb_Fecha_ValueChanged(sender As Object, e As EventArgs) Handles Tb_Fecha.ValueChanged
        Try
            If (_cargaCompleta) Then
                CargarPedidos()
                CargarFacturas()
                CargarFacturasAnuladas()
                If SuperTabControl1.SelectedTab Is SuperTabItem1 Then
                    lblCantidadPedido.Text = dgjPedido.RowCount.ToString
                Else
                    lblCantidadPedido.Text = grFactura.RowCount.ToString
                End If

                btnNotaVenta.Enabled = True
                btnFactura.Enabled = True
            End If
        Catch ex As Exception
            MostrarMensajeError(ex.Message)
        End Try
    End Sub
#End Region

#Region "Privado, metodos y funciones"
    Private Sub Init()
        Try
            'L_prJobDuplicados()
            ConfigForm()
            CargarEstados()
            CargarChoferes()
            CargarTipoPrecio()
            Tb_Fecha.Value = DateTime.Today
            Tb_FechaHasta.Value = DateTime.Today
            _cargaCompleta = True
            cbEstado.SelectedIndex = 0

            If gi_Facturacion = 0 Then
                SuperTabItem2.Visible = False
                SuperTabItem3.Visible = False
                If gs_Mon = "Ars" Then
                    SuperTabItem2.Visible = True
                End If
            Else
                If gs_Mon = "Ars" Then

                    SuperTabItem2.Visible = True
                    SuperTabItem3.Visible = False
                Else
                    If gs_PrecioFact > 0 Then
                        lbPrecioFactura.Visible = True
                        cbTIpoPrecio.Visible = True
                    Else
                        lbPrecioFactura.Visible = True
                        cbTIpoPrecio.Visible = True
                    End If

                    SuperTabItem2.Visible = True
                    SuperTabItem3.Visible = True
                End If
            End If
        Catch ex As Exception
            MostrarMensajeError(ex.Message)
        End Try
    End Sub

    Private Sub ConfigForm()
        Try
            Me.Text = "FACTURACIÓN/DESPACHO"
            ' Me.WindowState = FormWindowState.Maximized
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Sub

    Private Sub CargarTipoPrecio()
        Try
            'Dim listResult As List(Of VCombo) = New LPersonal().ListarRepatidorCombo()
            Dim listResult As New DataTable
            listResult.Columns.Add("Id")
            listResult.Columns.Add("Tipo")

            listResult.Rows.Add(2, "PRECIO VENTA")
            listResult.Rows.Add(gs_PrecioFact, "PRECIO FACTURA")
            With cbTIpoPrecio.DropDownList
                .Columns.Clear()

                .Columns.Add("Id").Width = 30
                .Columns("Id").Caption = "Id"
                .Columns("Id").Visible = True

                .Columns.Add("Tipo").Width = 180
                .Columns("Tipo").Caption = "Tipo"
                .Columns("Tipo").Visible = True

                .ValueMember = "Id"
                .DisplayMember = "Tipo"
                .DataSource = listResult

                .AlternatingColors = True
                .AllowColumnDrag = False
                .AutomaticSort = False
                .Refresh()
            End With
            cbTIpoPrecio.VisualStyle = VisualStyle.Office2007

            cbTIpoPrecio.SelectedIndex = 0
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Sub
    Private Sub CargarEstados()
        Try
            'Dim listResult As List(Of VCombo) = New LPersonal().ListarRepatidorCombo()
            Dim listResult As New DataTable
            listResult.Columns.Add("Id")
            listResult.Columns.Add("Estado")

            listResult.Rows.Add(2, "PENDIENTE")
            listResult.Rows.Add(3, "ENTREGADO")
            With cbEstados.DropDownList
                .Columns.Clear()

                .Columns.Add("Id").Width = 30
                .Columns("Id").Caption = "Id"
                .Columns("Id").Visible = True

                .Columns.Add("Estado").Width = 180
                .Columns("Estado").Caption = "Estadp"
                .Columns("Estado").Visible = True

                .ValueMember = "Id"
                .DisplayMember = "Estado"
                .DataSource = listResult

                .AlternatingColors = True
                .AllowColumnDrag = False
                .AutomaticSort = False
                .Refresh()
            End With
            cbEstados.VisualStyle = VisualStyle.Office2007

            cbEstados.SelectedIndex = 0
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Sub

    Private Sub CargarChoferes()
        Try
            'Dim listResult As List(Of VCombo) = New LPersonal().ListarRepatidorCombo()
            Dim listResult As DataTable = ListarChoferesDespacho(gi_userSuc)
            With cbChoferes.DropDownList
                .Columns.Clear()

                .Columns.Add("Id").Width = 30
                .Columns("Id").Caption = "Id"
                .Columns("Id").Visible = True

                .Columns.Add("Descripcion").Width = 180
                .Columns("Descripcion").Caption = "Nombre repartidor"
                .Columns("Descripcion").Visible = True

                .ValueMember = "Id"
                .DisplayMember = "Descripcion"
                .DataSource = listResult

                .AlternatingColors = True
                .AllowColumnDrag = False
                .AutomaticSort = False
                .Refresh()
            End With
            cbChoferes.VisualStyle = VisualStyle.Office2007

            cbChoferes.SelectedIndex = 0
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Sub

    Private Sub CargarPedidos()
        Try
            'Dim lista2 As List(Of VPedido_BillingDispatch) = ObtenerListaPedido()
            Dim lista As DataTable = ListaPedidosDespacho(cbEstados.Value, cbChoferes.Value, Tb_Fecha.Value.ToString("dd/MM/yyyy"), Tb_FechaHasta.Value.ToString("dd/MM/yyyy"))
            ArmarListaPedido(lista)
            '_prCargarIconPagar(lista)
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Sub

    Private Sub CargarFacturas()
        Try
            'Dim lista2 As List(Of VPedido_BillingDispatch) = ObtenerListaPedido()
            Dim lista As DataTable = ListaPedidosDespachoF(cbEstados.Value, cbChoferes.Value, Tb_Fecha.Value.ToString("dd/MM/yyyy"), Tb_FechaHasta.Value.ToString("dd/MM/yyyy"))
            ArmarListaPedido2(lista)
            '_prCargarIconPagar(lista)
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Sub

    Private Sub CargarFacturasAnuladas()
        Try
            'Dim lista2 As List(Of VPedido_BillingDispatch) = ObtenerListaPedido()
            Dim lista As DataTable = ListaPedidosDespachoFacturasA(cbEstados.Value, cbChoferes.Value, Tb_Fecha.Value.ToString("dd/MM/yyyy"), Tb_FechaHasta.Value.ToString("dd/MM/yyyy"))
            ArmarListaPedidoAnulados(lista)
            '_prCargarIconPagar(lista)
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Sub
    Private Sub CargarPedidos2()
        Try
            'Dim lista2 As List(Of VPedido_BillingDispatch) = ObtenerListaPedidoDirecto()
            Dim lista As DataTable = ListaPedidosDespachoDirecto(Tb_Fecha.Value.ToString("dd/MM/yyyy"), Tb_FechaHasta.Value.ToString("dd/MM/yyyy"))
            ArmarListaPedido(lista)
            '_prCargarIconPagar(lista)
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Sub

    Private Function ObtenerListaPedido() As List(Of VPedido_BillingDispatch)
        Dim idChofer = Me.cbChoferes.Value
        If (Not IsNumeric(idChofer)) Then
            Throw New Exception("Debe seleccionar un chofer.")
        End If
        If (Convert.ToInt32(idChofer) = ENCombo.ID_SELECCIONAR) Then
            Throw New Exception("Debe seleccionar un chofer.")
        End If

        Dim listResult = New LPedido().ListarPedidoAsignadoAChoferFechas(idChofer, IIf(cbEstado.SelectedIndex = 0, ENEstadoPedido.DICTADO, ENEstadoPedido.ENTREGADO), Tb_Fecha.Value, Tb_FechaHasta.Value)
        'Dim lista = (From a In listResult
        '             Where a.Fecha >= Tb_Fecha.Value And
        '                   a.Fecha <= Tb_FechaHasta.Value).ToList
        Return listResult
    End Function

    Private Sub ArmarListaPedido(lista As DataTable)

        dgjPedido.BoundMode = BoundMode.Bound
        dgjPedido.DataSource = lista
        dgjPedido.RetrieveStructure()


        With dgjPedido.RootTable.Columns("Fecha")
            .Caption = "Fecha Pedido"
            .Width = 80
            .CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
            .Visible = True
            .Position = 0
        End With

        With dgjPedido.RootTable.Columns("NombreCliente")
            .Caption = "Cliente"
            .Width = 400
            .CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
            .Visible = True
            .Position = 1
        End With

        With dgjPedido.RootTable.Columns("Id")
            .Caption = "Pedido"
            .Width = 60
            .CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
            .Visible = True
            .Position = 2
        End With

        With dgjPedido.RootTable.Columns("NombreVendedor")
            .Caption = "Vendedor"
            .Width = 250
            .CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
            .Visible = True
            .Position = 3
        End With

        With dgjPedido.RootTable.Columns("idZona")
            .Caption = "Zona"
            .Width = 120
            .CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
            .Visible = True
            .Position = 4
        End With
        With dgjPedido.RootTable.Columns("EstaFacturado")
            .Caption = "Facturado"
            .Width = 80
            .CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
            .Visible = False
            .Position = 5
        End With

        With dgjPedido.RootTable.Columns("NroFactura")
            .Caption = "Nro. Factura"
            .Width = 80
            .CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
            .Visible = True
            .Position = 6
        End With
        With dgjPedido.RootTable.Columns("nombreZona")
            .Caption = "Nombre Zona"
            .Width = 80
            .CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
            .Visible = False
            .Position = 7
        End With
        With dgjPedido.RootTable.Columns("observacion")
            .Caption = "observacion"
            .Width = 80
            .CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
            .Visible = False
            .Position = 8

        End With
        With dgjPedido.RootTable.Columns("Subtotal")
            .Caption = "Subtotal"
            .Width = 80
            .CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
            .Visible = False
            .FormatString = "0.00"
            .AggregateFunction = AggregateFunction.Sum
            .Position = 9
        End With
        With dgjPedido.RootTable.Columns("Descuento")
            .Caption = "Descuento"
            .Width = 80
            .CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
            .Visible = False
            .FormatString = "0.00"
            .AggregateFunction = AggregateFunction.Sum
            .Position = 10
        End With
        With dgjPedido.RootTable.Columns("Total")
            .Caption = "Total"
            .HeaderAlignment = Janus.Windows.GridEX.TextAlignment.Far
            .Width = 80
            .CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
            .Visible = True
            .FormatString = "0.00"
            .AggregateFunction = AggregateFunction.Sum
            .Position = 11
        End With
        'dgjPedido.RootTable.Columns.Add(New GridEXColumn("Check"))
        With dgjPedido.RootTable.Columns("Checks")
            .Caption = "Seleccionar"
            .Width = 100
            '.ShowRowSelector = True
            '.UseHeaderSelector = True
            '.FilterEditType = FilterEditType.NoEdit
            .Position = 12
        End With
        'dgjPedido.RootTable.Columns.Add(New GridEXColumn("Check2"))
        'With dgjPedido.RootTable.Columns("Check2")
        '    .Caption = "Facturar"
        '    .Width = 50
        '    .Visible = False
        '    '.ShowRowSelector = True
        '    '.UseHeaderSelector = True
        '    '.FilterEditType = FilterEditType.NoEdit
        '    '.Position = 12
        'End With
        With dgjPedido
            .DefaultFilterRowComparison = FilterConditionOperator.Contains
            .FilterMode = FilterMode.Automatic
            .FilterRowUpdateMode = FilterRowUpdateMode.WhenValueChanges
            .GroupByBoxVisible = False


            '.SelectionMode = SelectionMode.MultipleSelection
            '.AlternatingColors = True
            .AllowEdit = InheritableBoolean.False
            '.AllowColumnDrag = False
            '.AutomaticSort = False
            '.ColumnHeaders = InheritableBoolean.True

            .TotalRow = InheritableBoolean.True
            .TotalRowFormatStyle.BackColor = Color.Gold
            .TotalRowPosition = TotalRowPosition.BottomFixed
        End With
        dgjPedido.VisualStyle = VisualStyle.Office2007
    End Sub

    Private Sub ArmarListaPedido2(lista As DataTable)

        grFactura.BoundMode = BoundMode.Bound
        grFactura.DataSource = lista
        grFactura.RetrieveStructure()


        With grFactura.RootTable.Columns("Fecha")
            .Caption = "Fecha Pedido"
            .Width = 80
            .CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
            .Visible = True
            .Position = 0
        End With

        With grFactura.RootTable.Columns("NombreCliente")
            .Caption = "Cliente"
            .Width = 400
            .CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
            .Visible = True
            .Position = 1
        End With

        With grFactura.RootTable.Columns("Id")
            .Caption = "Pedido"
            .Width = 60
            .CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
            .Visible = True
            .Position = 2
        End With

        With grFactura.RootTable.Columns("NombreVendedor")
            .Caption = "Vendedor"
            .Width = 250
            .CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
            .Visible = True
            .Position = 3
        End With

        With grFactura.RootTable.Columns("idZona")
            .Caption = "Zona"
            .Width = 120
            .CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
            .Visible = True
            .Position = 4
        End With

        With grFactura.RootTable.Columns("EstaFacturado")
            .Caption = "Estado"
            .Width = 80
            .CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
            If gs_Mon = "Bs" Then
                .Visible = True

            Else
                .Visible = False
            End If
            .Visible = True
            .Position = 5
        End With

        With grFactura.RootTable.Columns("NroFactura")
            .Caption = "Nro. Factura"
            .Width = 80
            .CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
            .Visible = True
            .Position = 6
        End With
        With grFactura.RootTable.Columns("nombreZona")
            .Caption = "Nombre Zona"
            .Width = 80
            .CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
            .Visible = False
            .Position = 7
        End With
        With grFactura.RootTable.Columns("observacion")
            .Caption = "observacion"
            .Width = 80
            .CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
            .Visible = False
            .Position = 8

        End With
        With grFactura.RootTable.Columns("Subtotal")
            .Caption = "Subtotal"
            .Width = 80
            .CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
            .Visible = False
            .FormatString = "0.00"
            .AggregateFunction = AggregateFunction.Sum
            .Position = 9
        End With
        With grFactura.RootTable.Columns("Descuento")
            .Caption = "Descuento"
            .Width = 80
            .CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
            .Visible = False
            .FormatString = "0.00"
            .AggregateFunction = AggregateFunction.Sum
            .Position = 10
        End With
        With grFactura.RootTable.Columns("Total")
            .Caption = "Total"
            .HeaderAlignment = Janus.Windows.GridEX.TextAlignment.Far
            .Width = 80
            .CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
            .Visible = True
            .FormatString = "0.00"
            .AggregateFunction = AggregateFunction.Sum
            .Position = 11
        End With
        'dgjPedido.RootTable.Columns.Add(New GridEXColumn("Check"))
        With grFactura.RootTable.Columns("Checks")
            .Caption = "Seleccionar"
            .Width = 100
            '.ShowRowSelector = True
            '.UseHeaderSelector = True
            '.FilterEditType = FilterEditType.NoEdit
            '.Position = 12
        End With
        With grFactura.RootTable.Columns("tfactura")
            .Width = 100
            .Visible = False

        End With
        With grFactura.RootTable.Columns("tipoFactura")
            .Width = 100
            .Visible = True
            .Caption = "Tipo Factura"
        End With

        With grFactura.RootTable.Columns("docFact")
            .Width = 100
            .Visible = False
        End With
        With grFactura.RootTable.Columns("ccnit")
            .Width = 100
            .Visible = False
        End With
        With grFactura.RootTable.Columns("ccdctnum")
            .Width = 100
            .Visible = False
        End With
        With grFactura.RootTable.Columns("fvafactint")
            .Width = 100
            .Visible = False
        End With
        With grFactura.RootTable.Columns("customerid")
            .Width = 100
            .Visible = False
        End With
        With grFactura.RootTable.Columns("ccnomfac")
            .Width = 100
            .Visible = False
        End With
        With grFactura.RootTable.Columns("ccnumi")
            .Width = 100
            .Visible = False
        End With
        'dgjPedido.RootTable.Columns.Add(New GridEXColumn("Check2"))
        'With dgjPedido.RootTable.Columns("Check2")
        '    .Caption = "Facturar"
        '    .Width = 50
        '    .Visible = False
        '    '.ShowRowSelector = True
        '    '.UseHeaderSelector = True
        '    '.FilterEditType = FilterEditType.NoEdit
        '    '.Position = 12
        'End With
        With grFactura
            .DefaultFilterRowComparison = FilterConditionOperator.Contains
            .FilterMode = FilterMode.Automatic
            .FilterRowUpdateMode = FilterRowUpdateMode.WhenValueChanges
            .GroupByBoxVisible = False


            '.SelectionMode = SelectionMode.MultipleSelection
            '.AlternatingColors = True
            .AllowEdit = InheritableBoolean.False
            '.AllowColumnDrag = False
            '.AutomaticSort = False
            '.ColumnHeaders = InheritableBoolean.True

            .TotalRow = InheritableBoolean.True
            .TotalRowFormatStyle.BackColor = Color.Gold
            .TotalRowPosition = TotalRowPosition.BottomFixed
        End With
        grFactura.VisualStyle = VisualStyle.Office2007
    End Sub
    Private Sub ArmarListaPedidoAnulados(lista As DataTable)

        grFacturasAnuladas.BoundMode = BoundMode.Bound
        grFacturasAnuladas.DataSource = lista
        grFacturasAnuladas.RetrieveStructure()


        With grFacturasAnuladas.RootTable.Columns("Fecha")
            .Caption = "Fecha Pedido"
            .Width = 80
            .CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
            .Visible = True
            .Position = 0
        End With

        With grFacturasAnuladas.RootTable.Columns("NombreCliente")
            .Caption = "Cliente"
            .Width = 400
            .CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
            .Visible = True
            .Position = 1
        End With

        With grFacturasAnuladas.RootTable.Columns("Id")
            .Caption = "Pedido"
            .Width = 60
            .CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
            .Visible = True
            .Position = 2
        End With

        With grFacturasAnuladas.RootTable.Columns("NombreVendedor")
            .Caption = "Vendedor"
            .Width = 250
            .CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
            .Visible = True
            .Position = 3
        End With

        With grFacturasAnuladas.RootTable.Columns("idZona")
            .Caption = "Zona"
            .Width = 120
            .CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
            .Visible = True
            .Position = 4
        End With

        With grFacturasAnuladas.RootTable.Columns("EstaFacturado")
            .Caption = "Estado"
            .Width = 80
            .CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
            If gs_Mon = "Bs" Then
                .Visible = True

            Else
                .Visible = False
            End If
            .Visible = True
            .Position = 5
        End With

        With grFacturasAnuladas.RootTable.Columns("NroFactura")
            .Caption = "Nro. Factura"
            .Width = 80
            .CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
            .Visible = True
            .Position = 6
        End With
        With grFacturasAnuladas.RootTable.Columns("nombreZona")
            .Caption = "Nombre Zona"
            .Width = 80
            .CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
            .Visible = False
            .Position = 7
        End With
        With grFacturasAnuladas.RootTable.Columns("observacion")
            .Caption = "observacion"
            .Width = 80
            .CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
            .Visible = False
            .Position = 8

        End With
        With grFacturasAnuladas.RootTable.Columns("Subtotal")
            .Caption = "Subtotal"
            .Width = 80
            .CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
            .Visible = False
            .FormatString = "0.00"
            .AggregateFunction = AggregateFunction.Sum
            .Position = 9
        End With
        With grFacturasAnuladas.RootTable.Columns("Descuento")
            .Caption = "Descuento"
            .Width = 80
            .CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
            .Visible = False
            .FormatString = "0.00"
            .AggregateFunction = AggregateFunction.Sum
            .Position = 10
        End With
        With grFacturasAnuladas.RootTable.Columns("Total")
            .Caption = "Total"
            .HeaderAlignment = Janus.Windows.GridEX.TextAlignment.Far
            .Width = 80
            .CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
            .Visible = True
            .FormatString = "0.00"
            .AggregateFunction = AggregateFunction.Sum
            .Position = 11
        End With
        'dgjPedido.RootTable.Columns.Add(New GridEXColumn("Check"))
        With grFacturasAnuladas.RootTable.Columns("Checks")
            .Caption = "Seleccionar"
            .Width = 100
            '.ShowRowSelector = True
            '.UseHeaderSelector = True
            '.FilterEditType = FilterEditType.NoEdit
            '.Position = 12
        End With
        With grFacturasAnuladas.RootTable.Columns("tfactura")
            .Width = 100
            .Visible = False

        End With
        With grFacturasAnuladas.RootTable.Columns("tipoFactura")
            .Width = 100
            .Visible = True
            .Caption = "Tipo Factura"
        End With

        With grFacturasAnuladas.RootTable.Columns("docFact")
            .Width = 100
            .Visible = False
        End With
        With grFactura.RootTable.Columns("ccnit")
            .Width = 100
            .Visible = False
        End With
        With grFacturasAnuladas.RootTable.Columns("ccdctnum")
            .Width = 100
            .Visible = False
        End With
        With grFacturasAnuladas.RootTable.Columns("fvafactint")
            .Width = 100
            .Visible = False
        End With
        With grFacturasAnuladas.RootTable.Columns("customerid")
            .Width = 100
            .Visible = False
        End With
        With grFacturasAnuladas.RootTable.Columns("ccnomfac")
            .Width = 100
            .Visible = False
        End With
        With grFacturasAnuladas.RootTable.Columns("ccnumi")
            .Width = 100
            .Visible = False
        End With
        'dgjPedido.RootTable.Columns.Add(New GridEXColumn("Check2"))
        'With dgjPedido.RootTable.Columns("Check2")
        '    .Caption = "Facturar"
        '    .Width = 50
        '    .Visible = False
        '    '.ShowRowSelector = True
        '    '.UseHeaderSelector = True
        '    '.FilterEditType = FilterEditType.NoEdit
        '    '.Position = 12
        'End With
        With grFacturasAnuladas
            .DefaultFilterRowComparison = FilterConditionOperator.Contains
            .FilterMode = FilterMode.Automatic
            .FilterRowUpdateMode = FilterRowUpdateMode.WhenValueChanges
            .GroupByBoxVisible = False


            '.SelectionMode = SelectionMode.MultipleSelection
            '.AlternatingColors = True
            .AllowEdit = InheritableBoolean.False
            '.AllowColumnDrag = False
            '.AutomaticSort = False
            '.ColumnHeaders = InheritableBoolean.True

            .TotalRow = InheritableBoolean.True
            .TotalRowFormatStyle.BackColor = Color.Gold
            .TotalRowPosition = TotalRowPosition.BottomFixed
        End With
        grFacturasAnuladas.VisualStyle = VisualStyle.Office2007
    End Sub

    'Public Sub _prCargarIconPagar(lista As List(Of VPedido_BillingDispatch))
    '    Dim dt As DataTable = ConvertToDataTable(Of VPedido_BillingDispatch)(lista)
    '    Dim Bin As New MemoryStream
    '    Dim img As New Bitmap(My.Resources.cobro, 60, 28)
    '    img.Save(Bin, Imaging.ImageFormat.Png)
    '    'CType(dgjPedido.DataSource, DataTable).Rows(i).Item("check1") = Bin.GetBuffer

    '    For Each Row As GridEXRow In dgjPedido.GetRows
    '        Row.BeginEdit()
    '        Row.Cells("check1").Value = Bin.GetBuffer
    '        Row.EndEdit()
    '        'dgjPedido.RootTable.Columns("check1").Visible = True
    '        'dgjPedido.RootTable.Columns("check1").CellStyle.ImageHorizontalAlignment = ImageHorizontalAlignment.Center
    '    Next

    'End Sub

    Public Shared Function ConvertToDataTable(Of T)(ByVal list As IList(Of T)) As DataTable
        Dim td As New DataTable
        Dim entityType As Type = GetType(T)
        Dim properties As PropertyDescriptorCollection = TypeDescriptor.GetProperties(entityType)

        For Each prop As PropertyDescriptor In properties
            td.Columns.Add(prop.Name)
        Next

        For Each item As T In list
            Dim row As DataRow = td.NewRow()

            For Each prop As PropertyDescriptor In properties
                row(prop.Name) = prop.GetValue(item)
            Next

            td.Rows.Add(row)
        Next

        Return td
    End Function
    Private Sub CargarProductos(idPedido As Integer)
        Try
            'Dim listResult = New LProducto().ListarProductoXPedido(idPedido)
            Dim dt As DataTable

            If gs_PrecioFact > 0 And cbTIpoPrecio.Value <> 2 Then
                If SuperTabControl1.SelectedTab Is SuperTabItem2 Then
                    dt = ListarProductoxPedidoFactura(idPedido)
                Else
                    dt = ListarProductoxPedido(idPedido)
                End If
            Else
                dt = ListarProductoxPedido(idPedido)
            End If



            dgjProducto.BoundMode = Janus.Data.BoundMode.Bound
            dgjProducto.DataSource = dt
            dgjProducto.RetrieveStructure()

            With dgjProducto.RootTable.Columns("Id")
                .Visible = False
            End With

            With dgjProducto.RootTable.Columns("NombreProducto")
                .Caption = "Producto"
                .Width = 250
                .CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
                .Visible = True
            End With

            With dgjProducto.RootTable.Columns("Cantidad")
                .Caption = "Cantidad"
                .Width = 80
                .CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
                .Visible = True
                .FormatString = "0.00"
            End With

            With dgjProducto.RootTable.Columns("Precio")
                .Caption = "Precio"
                .Width = 80
                .CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
                .Visible = True
                .FormatString = "0.00"
            End With
            With dgjProducto.RootTable.Columns("SubTotal")
                .Caption = "SubTotal"
                .Width = 120
                .CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
                .Visible = True
                .FormatString = "0.00"
                .AggregateFunction = AggregateFunction.Sum
            End With
            With dgjProducto.RootTable.Columns("Descuento")
                .Caption = "Descuento"
                .Width = 120
                .CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
                .Visible = True
                .FormatString = "0.00"
                .AggregateFunction = AggregateFunction.Sum
            End With
            With dgjProducto.RootTable.Columns("Total")
                .Caption = "Total"
                .Width = 120
                .CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
                .Visible = True
                .FormatString = "0.00"
                .AggregateFunction = AggregateFunction.Sum
            End With
            With dgjProducto.RootTable.Columns("idFact")
                .Caption = "Total"
                .Width = 120
                .CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
                .Visible = False
                .FormatString = "0.00"
                .AggregateFunction = AggregateFunction.Sum
            End With
            With dgjProducto.RootTable.Columns("codAct")
                .Caption = "Total"
                .Width = 120
                .CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
                .Visible = False
                .FormatString = "0.00"
                .AggregateFunction = AggregateFunction.Sum
            End With
            With dgjProducto.RootTable.Columns("codSin")
                .Caption = "Total"
                .Width = 120
                .CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
                .Visible = False
                .FormatString = "0.00"
                .AggregateFunction = AggregateFunction.Sum
            End With
            With dgjProducto.RootTable.Columns("obporcdesc")
                .Caption = "Desc. %"
                .Width = 120
                .CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
                .Visible = True
                .FormatString = "0.00"

            End With
            With dgjProducto
                .GroupByBoxVisible = False
                .DefaultFilterRowComparison = FilterConditionOperator.Contains
                '.FilterMode = FilterMode.Automatic
                .FilterRowUpdateMode = FilterRowUpdateMode.WhenValueChanges
                .VisualStyle = VisualStyle.Office2007
                .SelectionMode = SelectionMode.MultipleSelection
                .AlternatingColors = True
                .AllowEdit = InheritableBoolean.False
                .AllowColumnDrag = False
                .AutomaticSort = False
                '.ColumnHeaders = InheritableBoolean.False

                .TotalRow = InheritableBoolean.True
                .TotalRowFormatStyle.BackColor = Color.Gold
                .TotalRowPosition = TotalRowPosition.BottomFixed
            End With
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Sub

    Private Sub MostrarMensajeError(mensaje As String)
        ToastNotification.Show(Me,
                               mensaje.ToUpper,
                               My.Resources.WARNING,
                               ENMensaje.MEDIANO,
                               eToastGlowColor.Red,
                               eToastPosition.TopCenter)
    End Sub
    Private Sub MostrarMensajeOk(mensaje As String)
        ToastNotification.Show(Me,
                               mensaje.ToUpper,
                               My.Resources.OK,
                               ENMensaje.MEDIANO,
                               eToastGlowColor.Green,
                               eToastPosition.TopCenter)
    End Sub
#End Region

#Region "Publico, metodos y funciones"
    Public Sub New()
        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Private Sub btVolverDist_Click(sender As Object, e As EventArgs) Handles btVolverDist.Click
        Try
            If SuperTabControl1.SelectedTab Is SuperTabItem1 Then

                VolverPedidoDistribucion()
            ElseIf SuperTabControl1.SelectedTab Is SuperTabItem2 Then

                VolverNotaVenta()

            End If

        Catch ex As Exception
            MostrarMensajeError(ex.Message)
        End Try
    End Sub

    Private Sub VolverNotaVenta()
        Dim listIdPedido As New List(Of Integer)()
        Dim TFactura As New List(Of Integer)()
        Dim fecha As New List(Of String)()
        Dim estado As New List(Of String)()
        'Dim checks = Me.dgjPedido.GetCheckedRows()
        'Dim listIdPedido = checks.Select(Function(a) Convert.ToInt32(a.Cells("Id").Value)).ToList()
        For i = 0 To CType(grFactura.DataSource, DataTable).Rows.Count - 1 Step 1
            If CType(grFactura.DataSource, DataTable).Rows(i).Item("checks") = True Then
                listIdPedido.Add(CType(grFactura.DataSource, DataTable).Rows(i).Item("Id"))
                fecha.Add(CType(grFactura.DataSource, DataTable).Rows(i).Item("Fecha"))
                TFactura.Add(CType(grFactura.DataSource, DataTable).Rows(i).Item("tfactura"))
                estado.Add((CType(grFactura.DataSource, DataTable).Rows(i).Item("EstaFacturado"))) '='IIf(IsDBNull(CType(grFactura.DataSource, DataTable).Rows(i).Item("NroFactura")), 0, CType(grFactura.DataSource, DataTable).Rows(i).Item("NroFactura"))
            End If
        Next

        'Dim checks = Me.dgjPedido.GetCheckedRows()
        'Dim listIdPedido = checks.Select(Function(a) Convert.ToInt32(a.Cells("Id").Value)).ToList()
        'Dim estado = checks.Select(Function(a) (a.Cells("Factura").Value)).ToList()
        'Dim cliente = checks.Select(Function(a) (a.Cells("Id").Value)).ToList()
        'Dim fecha = checks.Select(Function(a) (a.Cells("fecha").Value)).ToList()

        If (listIdPedido.Count = 0) Then
            ToastNotification.Show(Me, "Debe seleccionar un pedido para Volver a nota de venta.".ToUpper,
                                       My.Resources.WARNING, 5 * 1000,
                                       eToastGlowColor.Blue, eToastPosition.TopCenter)
            Exit Sub
            'ElseIf (listIdPedido.Count > 1) Then
            '    ToastNotification.Show(Me, "Debe seleccionar solo un pedido para facturar.".ToUpper,
            '                               My.Resources.WARNING, 5 * 1000,
            '                               eToastGlowColor.Blue, eToastPosition.TopCenter)
            '    Exit Sub
        End If

        For i = 0 To listIdPedido.Count - 1 Step 1
            If (estado(i) = "FACTURADO") Then
                ToastNotification.Show(Me, "El pedido ".ToUpper + listIdPedido(i).ToString + " no se puede volver a nota de venta porque ya esta facturado".ToUpper,
                                       My.Resources.WARNING, 7 * 1000,
                                       eToastGlowColor.Blue, eToastPosition.TopCenter)
            Else
                retornarEstadoFactura(listIdPedido(i))
            End If

        Next

        CargarPedidos()
        CargarFacturas()
        CargarFacturasAnuladas()
    End Sub
    Private Sub VolverPedidoDistribucion()
        Try
            Dim checks = Me.dgjPedido.GetCheckedRows()
            Dim listIdPedido As New List(Of Integer)() '= checks.Select(Function(a) Convert.ToInt32(a.Cells("Check1").Value)).ToList()
            Dim listFacPedido = checks.Select(Function(a) Convert.ToInt32(a.Cells("NroFactura").Value)).ToList()
            For i = 0 To CType(dgjPedido.DataSource, DataTable).Rows.Count - 1 Step 1
                If CType(dgjPedido.DataSource, DataTable).Rows(i).Item("checks") = True Then
                    listIdPedido.Add(CType(dgjPedido.DataSource, DataTable).Rows(i).Item("Id"))
                    'listVendedores.Add(CType(dgjPedido.DataSource, DataTable).Rows(i).Item("NombreVendedor"))
                End If
            Next

            If (listIdPedido.Count = 0) Then
                Throw New Exception("Debe seleccionar por lo menos un pedido.")
            End If
            Dim _Result As MsgBoxResult

            _Result = MsgBox("Esta seguro de volver a distribucion?", MsgBoxStyle.YesNo, "Advertencia")
            If _Result = MsgBoxResult.Yes Then
                For Each nfact As Integer In listFacPedido
                    Dim nro As Integer = nfact
                    If nro > 0 Then
                        MostrarMensajeError("Debe de seleccionar solo los pedidos que no hayan sido facturados")
                        Exit Sub
                    End If
                Next

                For Each idPedido As Integer In listIdPedido
                    Dim idP As Integer = idPedido
                    Dim dt As DataTable = L_EstadoTO001D(idP)
                    If dt.Rows.Count > 0 Then
                        If dt.Rows(0).Item("estadomax") > 4 Then
                            MostrarMensajeError("No puede volver a Distribucion porque el pedido ya se encuentra en:" + dt.Rows(0).Item("oaddescrip"))
                            Exit Sub
                        End If
                    Else
                        MostrarMensajeError("No puede volver a Distribucion ")
                        Exit Sub
                    End If
                Next

                Dim idChofer = Me.cbChoferes.Value
                Dim result = New LPedido().VolverPedidoDistribucion(listIdPedido, idChofer)
                If (result) Then
                    CargarPedidos()
                    MostrarMensajeOk("Pedidos volvieron a Distribución correctamente")
                End If


            End If
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
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

    Private Sub btReporteDespachoPedido_Click(sender As Object, e As EventArgs) Handles btReporteDespachoPedido.Click
        Try
            Dim idChofer = Me.cbChoferes.Value
            If (Not IsNumeric(idChofer)) Then
                Throw New Exception("Debe seleccionar un chofer.")
            End If
            If (Convert.ToInt32(idChofer) = ENCombo.ID_SELECCIONAR) Then
                Throw New Exception("Debe seleccionar un chofer.")
            End If

            'Dim listResult = New LPedido().ListarDespachoDetalleXChofer(idChofer, IIf(cbEstado.SelectedIndex = 0, ENEstadoPedido.DICTADO, ENEstadoPedido.ENTREGADO))
            'Dim lista = (From a In listResult
            '             Where a.oafdoc >= Tb_Fecha.Value And
            '                    a.oafdoc <= Tb_FechaHasta.Value).ToList
            Dim dt As DataTable = ListarDespachoXChofer(idChofer, cbEstados.Value, Tb_Fecha.Value.ToString("dd/MM/yyyy"), Tb_FechaHasta.Value.ToString("dd/MM/yyyy"))
            If (dt.Rows.Count = 0) Then
                Throw New Exception("No hay registros para generar el reporte.")
            End If

            If Not IsNothing(P_Global.Visualizador) Then
                P_Global.Visualizador.Close()
            End If

            P_Global.Visualizador = New Visualizador
            Dim objrep As New R_Ventasdespacho

            objrep.SetDataSource(dt)
            'objrep.SetParameterValue("nroDespacho", String.Empty)
            'objrep.SetParameterValue("nombreDistribuidor", cbChoferes.Text)
            'objrep.SetParameterValue("FechaDocumento", Tb_Fecha.Value)
            'objrep.SetParameterValue("nombreUsuario", P_Global.gs_user)

            P_Global.Visualizador.CRV1.ReportSource = objrep
            P_Global.Visualizador.Show()
            P_Global.Visualizador.BringToFront()
        Catch ex As Exception
            MostrarMensajeError(ex.Message)
        End Try
    End Sub

    Private Sub Tb_FechaHasta_ValueChanged(sender As Object, e As EventArgs) Handles Tb_FechaHasta.ValueChanged
        Try
            If (_cargaCompleta) Then
                CargarPedidos()
                CargarFacturas()
                CargarFacturasAnuladas()
                If SuperTabControl1.SelectedTab Is SuperTabItem1 Then
                    lblCantidadPedido.Text = dgjPedido.RowCount.ToString
                Else
                    lblCantidadPedido.Text = grFactura.RowCount.ToString
                End If

                btnNotaVenta.Enabled = True
                btnFactura.Enabled = True
            End If
        Catch ex As Exception
            MostrarMensajeError(ex.Message)
        End Try
    End Sub

    Private Function VerificarNitDni(pedido As Integer, tipo As Integer) As Boolean
        Dim resul As Boolean = True
        Dim dt As DataTable = L_fnTraerClientes(pedido)
        If tipo = 1 Or tipo = 2 Then
            If dt.Rows(0).Item("ccdctnum") = "" Or dt.Rows(0).Item("ccdctnum") = "0" Then
                resul = False
            End If
        ElseIf tipo = 3 Then
            If dt.Rows(0).Item("ccnit") = "" Then
                resul = False
            End If
        ElseIf tipo = 4 Then
        End If

        Return resul
    End Function
    Private Sub btnFactura_Click(sender As Object, e As EventArgs) Handles btnFactura.Click

        Dim listIdPedido As New List(Of Integer)()
        Dim TFactura As New List(Of Integer)()
        Dim fecha As New List(Of String)()
        Dim customer As New List(Of String)()
        Dim customerid As New List(Of String)()
        Dim nit2 As New List(Of String)()
        Dim subtotal As New List(Of String)()
        Dim docFact As New List(Of String)()
        Dim totalTax As New List(Of String)()
        Dim total1 As New List(Of String)()
        Dim descuento As New List(Of String)()
        Dim codClie As New List(Of String)()
        Dim estado As Integer
        'Dim checks = Me.dgjPedido.GetCheckedRows()
        'Dim listIdPedido = checks.Select(Function(a) Convert.ToInt32(a.Cells("Id").Value)).ToList()
        For i = 0 To CType(grFactura.DataSource, DataTable).Rows.Count - 1 Step 1
            If CType(grFactura.DataSource, DataTable).Rows(i).Item("checks") = True Then
                listIdPedido.Add(CType(grFactura.DataSource, DataTable).Rows(i).Item("Id"))
                fecha.Add(CType(grFactura.DataSource, DataTable).Rows(i).Item("Fecha"))
                TFactura.Add(CType(grFactura.DataSource, DataTable).Rows(i).Item("tfactura"))
                If gs_Mon = "Bs" Then
                    customerid.Add(CType(grFactura.DataSource, DataTable).Rows(i).Item("customerid"))
                    customer.Add(CType(grFactura.DataSource, DataTable).Rows(i).Item("NombreCliente"))
                    nit2.Add(IIf(CType(grFactura.DataSource, DataTable).Rows(i).Item("docFact") = "5", CType(grFactura.DataSource, DataTable).Rows(i).Item("ccnit"), CType(grFactura.DataSource, DataTable).Rows(i).Item("ccdctnum")))
                    subtotal.Add(CType(grFactura.DataSource, DataTable).Rows(i).Item("Subtotal").ToString)
                    docFact.Add(CType(grFactura.DataSource, DataTable).Rows(i).Item("docFact"))
                    totalTax.Add(Convert.ToDecimal(CType(grFactura.DataSource, DataTable).Rows(i).Item("SubTotal") * 0.13)) '- CType(grFactura.DataSource, DataTable).Rows(i).Item("descuento"))
                    total1.Add(Convert.ToDecimal(CType(grFactura.DataSource, DataTable).Rows(i).Item("Subtotal"))) ' - CType(grFactura.DataSource, DataTable).Rows(i).Item("descuento")))
                    descuento.Add(CType(grFactura.DataSource, DataTable).Rows(i).Item("descuento"))
                    codClie.Add(CType(grFactura.DataSource, DataTable).Rows(i).Item("ccnumi"))
                    If CType(grFactura.DataSource, DataTable).Rows(i).Item("docFact") = "5" Then
                        If F02_Cliente.verificarNit(tokenSifac, CType(grFactura.DataSource, DataTable).Rows(i).Item("ccnit")) = "400" Then
                            ToastNotification.Show(Me, "La nota ".ToString + CType(grFactura.DataSource, DataTable).Rows(i).Item("Id").ToString + " no tiene documentos validos del cliente".ToUpper,
                                               My.Resources.WARNING, 7 * 1000,
                                               eToastGlowColor.Blue, eToastPosition.TopCenter)
                            Exit Sub
                        End If
                    End If

                Else
                    If VerificarNitDni(CType(grFactura.DataSource, DataTable).Rows(i).Item("Id"), CType(grFactura.DataSource, DataTable).Rows(i).Item("tfactura")) = False Then
                        ToastNotification.Show(Me, "La nota ".ToString + CType(grFactura.DataSource, DataTable).Rows(i).Item("Id").ToString + " no tiene documentos validos del cliente".ToUpper,
                                       My.Resources.WARNING, 5 * 1000,
                                       eToastGlowColor.Blue, eToastPosition.TopCenter)
                        Exit Sub
                    End If
                End If
                estado = IIf(IsDBNull(CType(grFactura.DataSource, DataTable).Rows(i).Item("NroFactura")), 0, CType(grFactura.DataSource, DataTable).Rows(i).Item("NroFactura"))
                Dim est As String = CType(grFactura.DataSource, DataTable).Rows(i).Item("EstaFacturado")
                If estado > 0 Then
                    If est <> "ANULADO" Then
                        ToastNotification.Show(Me, "La nota ".ToString + CType(grFactura.DataSource, DataTable).Rows(i).Item("Id").ToString + " ya ha sido facturada".ToUpper,
                                       My.Resources.WARNING, 5 * 1000,
                                       eToastGlowColor.Blue, eToastPosition.TopCenter)
                        Exit Sub
                    End If
                End If
                End If
        Next
        If (listIdPedido.Count = 0) Then
            Throw New Exception("Debe seleccionar por lo menos un pedido.")
        End If
        'Dim checks = Me.dgjPedido.GetCheckedRows()
        'Dim listIdPedido = checks.Select(Function(a) Convert.ToInt32(a.Cells("Id").Value)).ToList()
        'Dim estado = checks.Select(Function(a) (a.Cells("Factura").Value)).ToList()
        'Dim cliente = checks.Select(Function(a) (a.Cells("Id").Value)).ToList()
        'Dim fecha = checks.Select(Function(a) (a.Cells("fecha").Value)).ToList()

        If (listIdPedido.Count = 0) Then
            ToastNotification.Show(Me, "Debe seleccionar un pedido para facturar.".ToUpper,
                                       My.Resources.WARNING, 5 * 1000,
                                       eToastGlowColor.Blue, eToastPosition.TopCenter)
            Exit Sub
            'ElseIf (listIdPedido.Count > 1) Then
            '    ToastNotification.Show(Me, "Debe seleccionar solo un pedido para facturar.".ToUpper,
            '                               My.Resources.WARNING, 5 * 1000,
            '                               eToastGlowColor.Blue, eToastPosition.TopCenter)
            '    Exit Sub
        End If
        'If (estado.ToString <> 0) Then
        '    ToastNotification.Show(Me, "La nota ya ha sido facturada.".ToUpper,
        '                                   My.Resources.WARNING, 5 * 1000,
        '                                   eToastGlowColor.Blue, eToastPosition.TopCenter)
        '    Exit Sub
        'End If
        'Dim ef = New Efecto
        'ef.tipo = 5
        'ef.ShowDialog()
        'Dim bandera As Boolean = False

        'bandera = ef.band
        'If (bandera = True) Then
        '    nit = ef.nit
        '    razonsocial = ef.razonsocial
        '    email = ef.email
        '    tipoDoc = ef.tipoDoc
        '    Dim parametro As Integer = 2
        '    If parametro = 1 Then
        '        Dim token As String = F01_Producto.ObtToken()
        '        crearFactura(token, listIdPedido(0))
        '        TraerPDF(token, fact)
        '    ElseIf parametro = 2 Then
        For i = 0 To listIdPedido.Count - 1 Step 1
            If gs_Mon = "Bs" Then
                tokenSifac = F01_Producto.ObtToken()
                crearFactura(tokenSifac, listIdPedido(i), customer(i), customerid(i), nit2(i), subtotal(i), docFact(i), totalTax(i), total1(i), descuento(i), codClie(i))
            Else
                crearFactura2("", listIdPedido(i), fecha(i), TFactura(i), nit)

            End If
            'ToastNotification.Show(Me, "No se pudo generar la factura.".ToUpper,
            '                           My.Resources.WARNING, 5 * 1000,
            '                           eToastGlowColor.Blue, eToastPosition.TopCenter)

        Next

        ' End If

        CargarPedidos()
        CargarFacturas()
        CargarFacturasAnuladas()
        'End If

    End Sub

    Private Sub cbEstado_SelectedValueChanged(sender As Object, e As EventArgs) Handles cbEstado.SelectedValueChanged
        Try
            If cbEstado.SelectedIndex = 1 Then
                btVolverDist.Enabled = False

            Else
                btVolverDist.Enabled = True

            End If

            If (_cargaCompleta) Then
                CargarPedidos()
                CargarFacturas()
                CargarFacturasAnuladas()
                If SuperTabControl1.SelectedTab Is SuperTabItem1 Then
                    lblCantidadPedido.Text = dgjPedido.RowCount.ToString
                Else
                    lblCantidadPedido.Text = grFactura.RowCount.ToString
                End If

                btnNotaVenta.Enabled = True
                btnFactura.Enabled = True
            End If
        Catch ex As Exception
            MostrarMensajeError(ex.Message)
        End Try
    End Sub

    Private Sub dgjPedido_KeyDown(sender As Object, e As KeyEventArgs) Handles dgjPedido.KeyDown
        'Dim listaPedido As List(Of VPedido_BillingDispatch) = ObtenerListaPedido()
        'If (e.KeyData = Keys.Control + Keys.F) Then
        '    listaPedido = listaPedido.Where(Function(a) a.observacion.Contains("F,") Or a.observacion.Contains("f,")).ToList()
        '    ArmarListaPedido(listaPedido)
        '    btnNotaVenta.Enabled = False
        '    btnFactura.Enabled = True
        '    lblCantidadPedido.Text = listaPedido.Count.ToString
        'End If
        'If (e.KeyData = Keys.Control + Keys.N) Then
        '    listaPedido = listaPedido.Where(Function(a) Not (a.observacion.Contains("F,") OrElse a.observacion.Contains("f,"))).ToList()
        '    ArmarListaPedido(listaPedido)
        '    btnFactura.Enabled = False
        '    btnNotaVenta.Enabled = True
        '    lblCantidadPedido.Text = listaPedido.Count.ToString
        'End If
    End Sub

    '------------------ FACTURACION-----------------------------------------------------
    Private Sub TraerPDF(token As String, fact1 As Integer)
        Try
            Dim request = TryCast(System.Net.WebRequest.Create("https://contadores.sige.company/api/invoices/" + fact1.ToString + "/pdf?tpl=rollo"), System.Net.HttpWebRequest)

            request.Method = "GET"

            request.ContentType = "application/json"
            request.Headers.Add("authorization", "Bearer " + token)

            request.ContentLength = 0
            Dim responseContent As String
            Using response = TryCast(request.GetResponse(), System.Net.HttpWebResponse)
                Using reader = New System.IO.StreamReader(response.GetResponseStream())
                    responseContent = reader.ReadToEnd()
                    Dim result = JsonConvert.DeserializeObject(Of PDFResp)(responseContent)
                    LeerPDF(result.data.buffer)
                End Using
            End Using
        Catch ex As WebException
            If Not ex.Response Is Nothing Then
                Dim data As StreamReader = New StreamReader(ex.Response.GetResponseStream)
                'Al asignar el data.ReadToEnd al string se puede apreciar la respuesta del WebService en la variable str
                Dim str As String = data.ReadToEnd

            End If

        End Try
    End Sub

    Private Sub LeerPDF(report As String)
        Dim bytes As Byte() = Convert.FromBase64String(report)



        'Dim ruta As String = "C:\Disoft_Doc\Reporte\Fact" + fact.ToString + ".pdf"
        'Dim Stream As System.IO.FileStream = New FileStream(ruta, FileMode.CreateNew)
        'Dim writer As System.IO.BinaryWriter = New BinaryWriter(Stream)
        'writer.Write(bytes, 0, bytes.Length)
        'writer.Close()


        P_Global.Visualizador2 = New Visualizador2

        Dim tempFile As String = Path.GetTempFileName()
        File.WriteAllBytes(tempFile, bytes)

        ' Cargar el archivo PDF en el control AxAcroPDF


        ' Dim pdfFilePath As String = ruta
        P_Global.Visualizador2.AxAcroPDF1.LoadFile(tempFile) '(pdfFilePath)
        P_Global.Visualizador2.AxAcroPDF1.setZoom(100)
        P_Global.Visualizador2.Show()
        P_Global.Visualizador2.BringToFront()

    End Sub


    Public Sub LoadPdf(pdfUrl As String)
        Try
            ' Descargar el archivo PDF temporalmente
            Dim tempFilePath As String = System.IO.Path.Combine(System.IO.Path.GetTempPath(), "temp.pdf")
            Dim client As New WebClient()
            client.DownloadFile(pdfUrl, tempFilePath)

            ' Cargar el PDF en el control AxAcroPDF
            pdfViewer.LoadFile(tempFilePath)
        Catch ex As Exception
            ' Manejar posibles excepciones
            MessageBox.Show("Error: " & ex.Message)
        End Try
    End Sub
    Private Sub LeerPDF2(enlace As String)
        Dim tempFilePath As String
        Try
            ServicePointManager.Expect100Continue = True
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12
            ' Descargar el archivo PDF temporalmente
            tempFilePath = System.IO.Path.Combine(System.IO.Path.GetTempPath(), "temp.pdf")
            Using client As New WebClient()
                client.DownloadFile(enlace, tempFilePath)
            End Using
            ' Cargar el PDF en el control AxAcroPDF
            '''''''''pdfViewer.LoadFile(tempFilePath)
        Catch ex As Exception
            ' Manejar posibles excepciones
            MessageBox.Show("Error: " & ex.Message)
        End Try
        Dim pdfUrl As String = enlace

        ' Crear una instancia del formulario que muestra el PDF

        ' Cargar el PDF en el control WebBrowser
        'viewer.LoadPdf(tempFilePath)
        P_Global.Visualizador2 = New Visualizador2
        ' Mostrar el formulario

        P_Global.Visualizador2.AxAcroPDF1.LoadFile(tempFilePath) '(pdfFilePath)
        P_Global.Visualizador2.AxAcroPDF1.setZoom(100)
        P_Global.Visualizador2.Show()
        P_Global.Visualizador2.BringToFront()

    End Sub
    Private Sub crearCliente(Token As String)
        Dim request = TryCast(System.Net.WebRequest.Create("https://contadores.sige.company/api/customers"), System.Net.HttpWebRequest)

        request.Method = "POST"

        request.ContentType = "application/json"
        request.Headers.Add("authorization", "Bearer " + Token)

        Using writer As BinaryWriter = New BinaryWriter(request.GetRequestStream())
            Dim byteArray As Byte() = System.Text.Encoding.UTF8.GetBytes("{
              ""code"": ""6"",
              ""group_id"": -1,
              ""store_id"": 0,
              ""first_name"": ""Jose"",
              ""last_name"": ""Callisaya"",
              ""identity_document"": 00000123,
              ""company"": """",
              ""date_of_birth"": null,
              ""gender"": """",
              ""phone"": """",
              ""mobile"": """",
              ""fax"": """",
              ""email"": ""jose@dynasys.com.bo"",
              ""website"": """",
              ""address_1"": ""Direccion 01"",
              ""address_2"": """",
              ""zip_code"": """",
              ""city"": """",
              ""country"": ""Bolivia"",
              ""country_code"": ""BO"",
              ""meta"": {
                ""_nit_ruc_nif"": ""123456789"",
                ""_billing_name"": null
              }
            }")
            'request.ContentLength = byteArray.Length
            writer.Write(byteArray)
            writer.Close()
        End Using
        Dim responseContent As String
        Using response = TryCast(request.GetResponse(), System.Net.HttpWebResponse)
            Using reader = New System.IO.StreamReader(response.GetResponseStream())
                responseContent = reader.ReadToEnd()
            End Using
        End Using
    End Sub

    Private Sub crearFactura2(token As String, pedido As Integer, fecha As Date, cod As Integer, nit As String)
        Try

            Dim tipo, doc1, cv As String

            If cod = 1 Then
                tipo = "FACTURA A"
                doc1 = "CUIT"
                cv = "RI"
            ElseIf cod = 2 Then
                tipo = "FACTURA B"
                doc1 = "DNI"
                If cod = 1 Then
                    cv = "E"
                Else
                    cv = "CF"
                End If
            ElseIf cod = 3 Then
                tipo = "FACTURA M"
                doc1 = "CUIT"
                cv = "RI"
            ElseIf cod = 4 Then
                tipo = "FACTURA B"
                doc1 = "OTRO"
                cv = "CF"
            End If
            Dim numi As Integer = ProximaNumeracion(cod)

            Dim res As Boolean = False
            ' L_BuscarCodCanero(_CodCliente)
            'Randomize()



            Dim api = New DBApi()
            Dim Emenvio = New EmisorEnvio.Emisor()

            'Dim TDoc = tipoDocumento 'obtiene el 'Codigo Tipo de documento' 

            CargarProductos(pedido)
            Dim array(CType(dgjProducto.DataSource, DataTable).Rows.Count - 1) As EmisorEnvio.Detalle
            Dim val = 0
            Dim PrecioTot = 0.00000
            For Each row In CType(dgjProducto.DataSource, DataTable).Rows

                Dim EmenvioProducto = New EmisorEnvio.producto
                EmenvioProducto.descripcion = row(1).ToString

                If row(0) = "" Then
                    ToastNotification.Show(Me, "El producto " + row(1) + " no contiene un codigo valido. no se pudo generar la factura".ToUpper,
                                      My.Resources.WARNING, 5 * 1000,
                                      eToastGlowColor.Blue, eToastPosition.TopCenter)
                    Exit Sub
                End If
                If Not IsNumeric(row(0)) Then
                    ToastNotification.Show(Me, "El producto " + row(1) + " no contiene un codigo valido. no se pudo generar la factura".ToUpper,
                                      My.Resources.WARNING, 5 * 1000,
                                      eToastGlowColor.Blue, eToastPosition.TopCenter)
                    Exit Sub
                End If
                EmenvioProducto.codigo = row(0)
                EmenvioProducto.lista_precios = "standard"
                EmenvioProducto.leyenda = ""
                EmenvioProducto.unidad_bulto = 1
                EmenvioProducto.alicuota = 21
                EmenvioProducto.actualiza_precio = "S"
                EmenvioProducto.rg5329 = "N"
                EmenvioProducto.precio_unitario_sin_iva = (Math.Round(row(3), 1) / 1.21)

                Dim EmenvioDetalle = New EmisorEnvio.Detalle()
                EmenvioDetalle.cantidad = row(2)
                EmenvioDetalle.afecta_stock = "S"
                EmenvioDetalle.actualiza_precio = "S"
                EmenvioDetalle.bonificacion_porcentaje = row(10)
                EmenvioDetalle.producto = EmenvioProducto

                PrecioTot = PrecioTot + (EmenvioDetalle.cantidad * Math.Round(row(3), 1)) - row(5) 'Format(PrecioTot + Format((Convert.ToDecimal(row("tbpbas")) * 6.96), "0.00000") * (row("tbcmin")), "0.00") 'total


                array(val) = EmenvioDetalle
                'vector = array
                val = val + 1

            Next

            Dim doc As Long = 0


            Dim dt As DataTable = L_fnTraerClientes(pedido)

            If cod <> 3 And cod <> 1 Then
                If cod = 4 Then
                    doc = 0
                Else
                    If dt.Rows(0).Item("ccdctnum") = "" Or dt.Rows(0).Item("ccdctnum") = "0" Then
                        doc = 123
                    Else
                        doc = CLng(dt.Rows(0).Item("ccdctnum"))
                    End If
                End If

            Else

                doc = dt.Rows(0).Item("ccnit")
            End If
            Dim EnvioCliente = New EmisorEnvio.cliente
            EnvioCliente.documento_tipo = doc1
            EnvioCliente.condicion_iva = cv

            EnvioCliente.condicion_pago = "201"

            If cod = 4 Then
                EnvioCliente.domicilio = "No especifica"
                EnvioCliente.razon_social = "Consumidor Final"
                EnvioCliente.documento_nro = 0
            Else
                EnvioCliente.razon_social = dt.Rows(0).Item("ccdesc")
                EnvioCliente.domicilio = dt.Rows(0).Item("ccdirec")
                EnvioCliente.documento_nro = doc
            End If

            EnvioCliente.provincia = 17
            EnvioCliente.email = "dinases16@gmail.com"
            EnvioCliente.envia_por_mail = "N"
            EnvioCliente.rg5329 = "N"

            Dim EnvioComprobante = New EmisorEnvio.comprobante
            EnvioComprobante.rubro = "Distribución de Alimentos"
            EnvioComprobante.percepciones_iva = 0
            EnvioComprobante.tipo = tipo
            EnvioComprobante.numero = numi
            EnvioComprobante.bonificacion = 0
            EnvioComprobante.operacion = "V"
            EnvioComprobante.detalle = array
            EnvioComprobante.fecha = Date.Now.ToString("dd/MM/yyyy") 'fecha.ToString("dd/MM/yyyy") 'tbFechaVenta.Value.ToString("dd/MM/yyyy")
            EnvioComprobante.vencimiento = "31/12/2026" 'tbFechaVenc.Value.ToString("dd/MM/yyyy")
            EnvioComprobante.rubro_grupo_contable = "Productos"
            EnvioComprobante.total = PrecioTot
            EnvioComprobante.cotizacion = 1
            EnvioComprobante.moneda = "PES"
            EnvioComprobante.punto_venta = 6




            Emenvio.apitoken = "0c1669b2ee1a34bbbd4114d70ee071ec"
            Emenvio.cliente = EnvioCliente
            Emenvio.apikey = 64207
            Emenvio.usertoken = "c84d30fcd9d5cc4870bb6beac3d2c0e97dca090172cb755fd8af1a6702de373d"
            Emenvio.comprobante = EnvioComprobante

            'Emenvio.comprobante = 

            '--------------------
            'Emenvio.codigoDocumentoSector = 1 '-------------------



            Dim jsonEnvio As String = JsonConvert.SerializeObject(Emenvio, Formatting.Indented)
            Debug.WriteLine(jsonEnvio)




            'Emenvio.actividadEconomica = 692000 'falta
            ServicePointManager.Expect100Continue = True
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12
            Dim json = JsonConvert.SerializeObject(Emenvio)
            Dim url = "https://www.tusfacturas.app/app/api/v2/facturacion/nuevo"

            Dim headers = New List(Of Parametro) From {
                New Parametro("Content-Type", "application/json")
            }

            'Dim parametros = New List(Of Parametro)

            Dim response = api.Post(url, headers, Emenvio)

            Dim cant As Integer = response.Length
            Dim result = JsonConvert.DeserializeObject(Of RespEmisor)(response)
            If result.error = "S" Then
                ToastNotification.Show(Me, result.errores(0).ToUpper,
                                      My.Resources.WARNING, 5 * 1000,
                                      eToastGlowColor.Blue, eToastPosition.TopCenter)
                Exit Sub
            End If
            'Dim resultError = JsonConvert.DeserializeObject(Of Resp400)(response)

            'codigoRecepcion = result.codigoRecepcion
            'estadoEmisionEdoc = result.estadoEmisionEDOC
            'fechaEmision1 = result.fechaEmision
            'cuf = result.cuf
            'cuis = result.cuis
            'cufd = result.cufd
            'codigoControl = result.codigoControl
            'linkCodigoQr = result.linkCodigoQR
            'codigoError = result.codigoError
            'mensajeRespuesta = result.mensajeRespuesta
            'If estadoEmisionEdoc = 2 Then
            '    mensajeRespuesta = "Factura validada correctamente por Impuestos."
            'End If


            Dim codigo = result.comprobante_pdf_url
            'Dim xml As String

            'If codigo <> "" Then
            '    res = True
            'End If
            Dim res1 As Boolean
            res1 = GrabarTFV001(pedido, fecha.ToString("dd/MM/yyyy"), result.comprobante_nro, cv, doc, dt.Rows(0).Item("ccdesc"), PrecioTot, PrecioTot, tipo, "", "", "", result.comprobante_pdf_url, "", "", numi)
            If res1 Then
                ToastNotification.Show(Me, "La factura fue generada correctamente.".ToUpper,
                                       My.Resources.checked, 5 * 1000,
                                       eToastGlowColor.Blue, eToastPosition.TopCenter)
                LeerPDF2(codigo)
            Else
                ToastNotification.Show(Me, "No se pudo generar la factura.".ToUpper,
                                       My.Resources.WARNING, 5 * 1000,
                                       eToastGlowColor.Blue, eToastPosition.TopCenter)
            End If


        Catch ex As WebException
            If Not ex.Response Is Nothing Then
                Dim data As StreamReader = New StreamReader(ex.Response.GetResponseStream)
                'Al asignar el data.ReadToEnd al string se puede apreciar la respuesta del WebService en la variable str
                Dim str As String = data.ReadToEnd

            End If

        End Try
    End Sub

    Public Function ProximaNumeracion(cod As Integer) As Integer
        Dim api = New DBApi()
        Dim Emenvio = New Envio
        Dim tipo As String
        If cod = 1 Then
            tipo = "FACTURA A"
        ElseIf cod = 2 Then
            tipo = "FACTURA B"
        ElseIf cod = 3 Then
            tipo = "FACTURA M"
        ElseIf cod = 4 Then
            tipo = "FACTURA B"
        End If
        Dim EnvioComprobante = New Numeracion.comprobante

        EnvioComprobante.tipo = tipo
        EnvioComprobante.operacion = "V"
        EnvioComprobante.punto_venta = 6




        Emenvio.apitoken = "0c1669b2ee1a34bbbd4114d70ee071ec"

        Emenvio.apikey = 64207
        Emenvio.usertoken = "c84d30fcd9d5cc4870bb6beac3d2c0e97dca090172cb755fd8af1a6702de373d"
        Emenvio.comprobante = EnvioComprobante

        ServicePointManager.Expect100Continue = True
        ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12
        Dim json = JsonConvert.SerializeObject(Emenvio)
        Dim url = "https://www.tusfacturas.app/app/api/v2/facturacion/numeracion"

        Dim headers = New List(Of Parametro) From {
            New Parametro("Content-Type", "application/json")
        }

        'Dim parametros = New List(Of Parametro)

        Dim response = api.Post(url, headers, Emenvio)

        Dim result = JsonConvert.DeserializeObject(Of Resp)(response)
        Return result.comprobante.numero
    End Function

    Private Sub crearFactura(token As String, pedido As Integer, customer As String, customerid As String, nit2 As String, subtotal1 As String, docfact As String, totalTax As String, total1 As String, descuento1 As String, codcli As String)

        Try
            CargarProductos(pedido)
            Dim Emenvio = New EmisorEnvio.Emisor()
            ServicePointManager.Expect100Continue = True
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12

            Dim link As String = TraerLinkFacturacion(3).Rows(0).Item("descr")
            Dim request = TryCast(System.Net.WebRequest.Create(link + "api/invoices"), System.Net.HttpWebRequest)
            Dim token2 As String = "Bearer " + F01_Producto.ObtToken()
            If TokenExpirado(token2) Then
                token2 = "Bearer " + F01_Producto.ObtToken()
                ''MessageBox.Show("El token ha expirado. Por favor, solicite uno nuevo.", "Token inválido", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If
            request.Method = "POST"
            request.ContentType = "Accept:application/json; charset=utf-8"
            request.Headers.Add("Authorization", token2)

            Using writer As BinaryWriter = New BinaryWriter(request.GetRequestStream())
                '+ descuento1 + "
                Dim cadena As String = "{
                  ""customer_id"": """ + customerid + """,
                  ""customer"": """ + customer + """,
                  ""nit_ruc_nif"": """ + nit2 + """,
                  ""subtotal"": " + subtotal1 + ",
                  ""total_tax"": " + totalTax + ",
                  ""discount"":  0,
                  ""monto_giftcard"": 0.00,
                  ""total"":" + total1 + ",
                  ""invoice_date_time"": """",
                  ""currency_code"": """",
                  ""codigo_sucursal"": 0,
                  ""punto_venta"": 0,
                  ""codigo_documento_sector"": 1,
                  ""tipo_documento_identidad"": " + docfact + ",
                  ""codigo_metodo_pago"": 1,
                  ""codigo_moneda"": 1,
                  ""complemento"": null,
                  ""numero_tarjeta"": null,
                  ""tipo_cambio"": 1,
                  ""tipo_factura_documento"": 1,
                  ""items"": [
                  "
                For i = 0 To CType(dgjProducto.DataSource, DataTable).Rows.Count - 1 Step 1
                    Dim id As Integer = 0 'CType(dgjProducto.DataSource, DataTable).Rows(i).Item("idFact")
                    Dim code As String = CType(dgjProducto.DataSource, DataTable).Rows(i).Item("ID").ToString
                    Dim nombre As String = CType(dgjProducto.DataSource, DataTable).Rows(i).Item("NombreProducto").ToString
                    Dim precio As Double = CType(dgjProducto.DataSource, DataTable).Rows(i).Item("Precio")
                    Dim cantidad As Integer = CType(dgjProducto.DataSource, DataTable).Rows(i).Item("Cantidad")
                    Dim Subtotal As Double = CType(dgjProducto.DataSource, DataTable).Rows(i).Item("Subtotal")
                    Dim descuento As Double = CType(dgjProducto.DataSource, DataTable).Rows(i).Item("Descuento")
                    Dim codAct As String = CType(dgjProducto.DataSource, DataTable).Rows(i).Item("codAct").ToString
                    Dim codSin As Integer = CType(dgjProducto.DataSource, DataTable).Rows(i).Item("codSin")
                    Dim codUniM As String = CType(dgjProducto.DataSource, DataTable).Rows(i).Item("codUniM")
                    cadena = cadena + "{
                      ""product_id"": " + id.ToString + ",
                      ""product_code"": """ + code.ToString + """,
                      ""product_name"": """ + nombre + """,
                      ""price"": " + precio.ToString + ",
                      ""quantity"": " + cantidad.ToString + ",
                      ""total"": " + Subtotal.ToString + ",
                      ""unidad_medida"": " + codUniM.ToString + ",
                      ""numero_serie"": """",
                      ""numero_imei"": """",
                      ""codigo_producto_sin"": " + codSin.ToString + ",
                      ""codigo_actividad"": """ + codAct + """,
                      ""discount"": " + descuento.ToString + "
                    }"
                    If i < CType(dgjProducto.DataSource, DataTable).Rows.Count - 1 Then
                        cadena = cadena + ","
                    End If
                Next
                cadena = cadena + "]}"
                Dim byteArray As Byte()
                byteArray = System.Text.Encoding.UTF8.GetBytes(cadena)
                'request.ContentLength = byteArray.Length
                Dim TxtEncodedValue As String = System.Text.Encoding.UTF8.GetString(byteArray)
                writer.Write(byteArray)
                writer.Close()
            End Using
            'request.d
            Dim responseContent As String
            Using response = TryCast(request.GetResponse(), System.Net.HttpWebResponse)
                Using reader = New System.IO.StreamReader(response.GetResponseStream())
                    responseContent = reader.ReadToEnd()
                    Dim jo As JObject = JObject.Parse(responseContent)
                    Dim customerid1 = jo("data")("customer_id")
                    Dim result = JsonConvert.DeserializeObject(Of FactResp)(responseContent)

                    If result.code = 200 Then
                        fact = result.data.invoice_id
                        With result.data
                            Dim fec As String = .invoice_date_time.Substring(0, 10)
                            GrabarTFV001(pedido, fec, .invoice_number, .cuf, .nit_ruc_nif, .customer, .subtotal, .total, .control_code, .cufd, .leyenda, .nit_emisor.ToString, .print_url, .siat_id, .siat_url, .invoice_id)
                            Dim dtDetalle As DataTable
                            If gs_PrecioFact > 0 Then
                                dtDetalle = L_prObtenerDetallePedido2(pedido)
                            Else
                                dtDetalle = L_prObtenerDetallePedido(pedido)
                            End If
                            For i As Integer = 0 To dtDetalle.Rows.Count - 1 Step 1

                                L_Grabar_Factura_Detalle(pedido.ToString,
                                        dtDetalle.Rows(i).Item("obcprod").ToString,
                                         dtDetalle.Rows(i).Item("producto").ToString,
                                        dtDetalle.Rows(i).Item("obpcant").ToString,
                                        dtDetalle.Rows(i).Item("obpbase").ToString,
                                         dtDetalle.Rows(i).Item("numi"))

                            Next
                            updateTO001C(pedido, Str(.invoice_number))

                            If customerid = "0" Then
                                updateCliente(codcli, customerid1)
                            End If
                            ticket(fact.ToString)
                        End With
                    Else
                        ToastNotification.Show(Me,
                               result.response.ToUpper,
                               My.Resources.OK,
                               ENMensaje.MEDIANO,
                               eToastGlowColor.Green,
                               eToastPosition.TopCenter)
                    End If
                End Using
            End Using
        Catch ex As WebException

            If Not ex.Response Is Nothing Then
                Dim data As StreamReader = New StreamReader(ex.Response.GetResponseStream)
                'Al asignar el data.ReadToEnd al string se puede apreciar la respuesta del WebService en la variable str
                Dim str As String = data.ReadToEnd
                ' Convertir el JSON a un objeto para extraer los valores
                Dim json = Newtonsoft.Json.Linq.JObject.Parse(str)

                Dim codigo As String = json("code").ToString()
                Dim mensajeOriginal As String = json("error").ToString()

                ' Traducir el mensaje
                Dim mensajeTraducido As String = TraducirMensajeError(mensajeOriginal)

                MessageBox.Show($"Error ({codigo}): {mensajeTraducido}", "Error en Facturación", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If

        End Try
    End Sub

    Public Function ticket(idFactura As String)
        Dim _Ds3 As New DataSet

        _Ds3 = L_ObtenerRutaImpresora("1") ' Datos de Impresion de Facturación
        Dim link As String = TraerLinkFacturacion(3).Rows(0).Item("descr")
        Dim url As String = link + $"api/invoices/{idFactura}/pdf?"


        Using client As New HttpClient()
            client.DefaultRequestHeaders.Clear()
            client.DefaultRequestHeaders.Add("Authorization", "Bearer " & F01_Producto.ObtToken())

            Dim resp = client.GetAsync(url).Result
            Dim result = resp.Content.ReadAsStringAsync().Result
            Dim jo As JObject = JObject.Parse(result)
            Dim code As String = jo("code")
            Dim error1 As String = jo("error")
            If code <> "200" Then
                ToastNotification.Show(Me, error1.ToUpper,
                                       My.Resources.WARNING, 5 * 1000,
                                       eToastGlowColor.Blue, eToastPosition.TopCenter)
            Else

                Dim bufferBase64 As String = jo("data")("buffer").ToString()
                Dim pdfBytes As Byte() = Convert.FromBase64String(bufferBase64)

                Using ms As New MemoryStream(pdfBytes)
                    Dim pdfDoc As PdfiumViewer.PdfDocument = PdfiumViewer.PdfDocument.Load(ms)
                    ' If (_Ds3.Tables(0).Rows(0).Item("cbvp")) Then 'Vista Previa de la Ventana de Vizualización 1 = True 0 = False
                    ' Crear un formulario temporal para visualizar
                    Dim frm As New Form()
                        frm.Text = $"Factura {idFactura}"
                        frm.WindowState = FormWindowState.Normal
                        frm.StartPosition = FormStartPosition.CenterScreen
                        frm.Width = 800
                        frm.Height = 600

                        Dim viewer As New PdfViewer()
                        viewer.Dock = DockStyle.Fill
                        viewer.Document = pdfDoc
                        frm.Controls.Add(viewer)
                    frm.ShowDialog()
                    'Else
                    'Using printDoc As PrintDocument = pdfDoc.CreatePrintDocument()
                    '    ' Opcional: seleccionar impresora (si dejas Nothing usará la predeterminada)
                    '    printDoc.PrinterSettings.PrinterName = _Ds3.Tables(0).Rows(0).Item("cbrut").ToString

                    '    ' Opcional: configurar copias, orientación, etc.
                    '    printDoc.PrinterSettings.Copies = 1
                    '    printDoc.DefaultPageSettings.Landscape = False

                    '    Try
                    '        printDoc.Print() ' sin diálogo, envía a impresora predeterminada (o la que configures)
                    '    Catch ex As Exception
                    '        MessageBox.Show("Error al imprimir: " & ex.Message, "Impresión", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    '    End Try
                    'End Using
                    ' End If





                End Using
            End If
            Return code
        End Using
    End Function

    Public Function anularFactura(tokenObtenido As String, idFactura As String, motivo As String)
        Dim anular As New AnularFactura With {
            .invoice_id = idFactura,
            .motivo_id = motivo
        }
        Dim link As String = TraerLinkFacturacion(3).Rows(0).Item("descr")
        Dim url As String = link + $"api/invoices/{idFactura}/void"

        Dim jsonBody = JsonConvert.SerializeObject(anular, Formatting.None,
            New JsonSerializerSettings With {.NullValueHandling = NullValueHandling.Include})

        Using client As New HttpClient()
            client.DefaultRequestHeaders.Clear()
            client.DefaultRequestHeaders.Add("Authorization", "Bearer " & F01_Producto.ObtToken())

            Dim content = New StringContent(jsonBody, Encoding.UTF8, "application/json")
            Dim resp = client.PostAsync(url, content).Result
            Dim result = resp.Content.ReadAsStringAsync().Result
            Dim jo As JObject = JObject.Parse(result)
            Dim code As String = jo("code")
            Dim error1 As String = jo("error")
            If code <> "200" Then
                ToastNotification.Show(Me, error1.ToUpper,
                                       My.Resources.WARNING, 5 * 1000,
                                       eToastGlowColor.Blue, eToastPosition.TopCenter)

            End If
            Return code
        End Using
    End Function

    Private Function TokenExpirado(token As String) As Boolean
        Try
            ' Elimina prefijo "Bearer " si existe
            token = token.Replace("Bearer ", "").Trim()

            ' Divide el token en sus 3 partes (header.payload.signature)
            Dim parts = token.Split("."c)
            If parts.Length <> 3 Then Return True ' token mal formado

            Dim payload = parts(1).Replace("-", "+").Replace("_", "/")
            Select Case payload.Length Mod 4
                Case 2 : payload &= "=="
                Case 3 : payload &= "="
            End Select
            Dim json = Encoding.UTF8.GetString(Convert.FromBase64String(payload))

            ' JSON para extraer "exp"
            Dim js As New JavaScriptSerializer()
            Dim dict = js.DeserializeObject(json)

            If dict.ContainsKey("exp") Then
                Dim exp As Long = dict("exp")
                Dim fechaExp = New DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc).AddSeconds(exp)
                ' Permitir 30 segundos de margen
                Return fechaExp < DateTime.UtcNow.AddSeconds(-30)
            Else
                ' Si no hay campo exp, asumimos que no expira
                Return False
            End If
        Catch
            ' Si falla el parseo, tratamos el token como inválido
            Return True
        End Try
    End Function
    Private Function TraducirMensajeError(mensaje As String) As String
        Select Case mensaje
            Case "Invalid invoice NIT/RUC/NIF"
                Return "El NIT o número de documento de la factura no es válido."
            Case "Invalid API session status, it is not ACTIVE"
                Return "La sesión de la API no está activa. Debes renovar el token."
            Case "El item de la factura no tiene actividad economica"
                Return "Uno de los ítems de la factura no tiene asignada una actividad económica."
            Case Else
                Return "Error desconocido: " & mensaje
        End Select
    End Function

    Private Sub PanelSuperior_Paint(sender As Object, e As PaintEventArgs) Handles PanelSuperior.Paint

    End Sub

    Private Sub ButtonX1_Click(sender As Object, e As EventArgs) Handles ButtonX1.Click
        'LeerPDF2("https://www.tusfacturas.app/app/descarga/pdf/4181392211516b0e08ed245f39010bea/pxgBIGv5JFeSmj36XCeLZw4178776y/64207-20371897152-20962008322-51-00006-00000001.pdf")
        Dim checks = Me.grFactura.GetCheckedRows()
        'Dim listIdPedido = checks.Select(Function(a) Convert.ToInt32(a.Cells("Id").Value)).ToList()
        'Dim estado = checks.Select(Function(a) (a.Cells("Factura").Value)).ToList()
        'Dim cliente = checks.Select(Function(a) (a.Cells("Id").Value)).ToList()
        Dim con As Integer = 0
        Dim pedido As Integer = 0
        Dim idFactura As Integer = 0
        Dim int As Integer
        If SuperTabControl1.SelectedTab Is SuperTabItem2 Then
            For i = 0 To CType(grFactura.DataSource, DataTable).Rows.Count - 1 Step 1
                If CType(grFactura.DataSource, DataTable).Rows(i).Item("checks") = True Then
                    con += 1
                    pedido = CType(grFactura.DataSource, DataTable).Rows(i).Item("Id")
                    idFactura = IIf(IsDBNull(CType(grFactura.DataSource, DataTable).Rows(i).Item("fvafactint")), 0, CType(grFactura.DataSource, DataTable).Rows(i).Item("fvafactint"))
                    int = i
                End If
            Next
            If (con = 0) Then
                ToastNotification.Show(Me, "Debe seleccionar un pedido facturado para imprimir.".ToUpper,
                                           My.Resources.WARNING, 5 * 1000,
                                           eToastGlowColor.Blue, eToastPosition.TopCenter)
                Exit Sub
            ElseIf (con > 1) Then
                ToastNotification.Show(Me, "Debe seleccionar solo un pedido para imprimir.".ToUpper,
                                           My.Resources.WARNING, 5 * 1000,
                                           eToastGlowColor.Blue, eToastPosition.TopCenter)
                Exit Sub
            End If
            If gs_Mon = "Bs" Then
                If (CType(grFactura.DataSource, DataTable).Rows(int).Item("NroFactura").ToString = "") Then
                    ToastNotification.Show(Me, "La nota no ha sido facturada.".ToUpper,
                                           My.Resources.WARNING, 5 * 1000,
                                           eToastGlowColor.Blue, eToastPosition.TopCenter)
                    Exit Sub
                End If
            End If
        ElseIf SuperTabControl1.SelectedTab Is SuperTabItem3 Then
                For i = 0 To CType(grFacturasAnuladas.DataSource, DataTable).Rows.Count - 1 Step 1
                If CType(grFacturasAnuladas.DataSource, DataTable).Rows(i).Item("checks") = True Then
                    con += 1
                    pedido = CType(grFacturasAnuladas.DataSource, DataTable).Rows(i).Item("Id")
                    idFactura = IIf(IsDBNull(CType(grFacturasAnuladas.DataSource, DataTable).Rows(i).Item("fvafactint")), 0, CType(grFacturasAnuladas.DataSource, DataTable).Rows(i).Item("fvafactint"))
                    int = i
                End If
            Next
            If (con = 0) Then
                ToastNotification.Show(Me, "Debe seleccionar un pedido facturado para imprimir.".ToUpper,
                                           My.Resources.WARNING, 5 * 1000,
                                           eToastGlowColor.Blue, eToastPosition.TopCenter)
                Exit Sub
            ElseIf (con > 1) Then
                ToastNotification.Show(Me, "Debe seleccionar solo un pedido para imprimir.".ToUpper,
                                           My.Resources.WARNING, 5 * 1000,
                                           eToastGlowColor.Blue, eToastPosition.TopCenter)
                Exit Sub
            End If
            If (CType(grFactura.DataSource, DataTable).Rows(int).Item("NroFactura").ToString = "") Then
                ToastNotification.Show(Me, "La nota no ha sido facturada.".ToUpper,
                                           My.Resources.WARNING, 5 * 1000,
                                           eToastGlowColor.Blue, eToastPosition.TopCenter)
                Exit Sub
            End If
        End If

        If gs_Mon = "Bs" Then
            ticket(idFactura)
        Else
            Dim dt As DataTable = TraerFacturaID2(pedido)
            'Dim token As String = F01_Producto.ObtToken()
            'TraerPDF(token, dt.Rows(0).Item("fvanumi2"))
            If dt.Rows.Count > 0 Then
                LeerPDF2(dt.Rows(0).Item("url"))
            Else
                ToastNotification.Show(Me, "No se encuentra la direccion, verifique la factura.".ToUpper,
                                       My.Resources.WARNING, 7 * 1000,
                                       eToastGlowColor.Blue, eToastPosition.TopCenter)
            End If

        End If

    End Sub

    Private Sub dgjPedido_CellEdited(sender As Object, e As ColumnActionEventArgs) Handles dgjPedido.CellEdited
        If dgjPedido.GetValue("checks") = False Then
            dgjPedido.SetValue("checks", True)
        Else
            dgjPedido.SetValue("checks", False)
        End If
    End Sub

    Private Sub dgjPedido_EditingCell(sender As Object, e As EditingCellEventArgs) Handles dgjPedido.EditingCell
        If (e.Column.Index = dgjPedido.RootTable.Columns("checks").Index) Then
            e.Cancel = False
        Else
            e.Cancel = True
        End If
    End Sub

    Private Sub dgjPedido_Click(sender As Object, e As EventArgs) Handles dgjPedido.Click
        If dgjPedido.CurrentColumn.Index = dgjPedido.RootTable.Columns("Checks").Index Then
            If dgjPedido.GetValue("checks") = False Then
                dgjPedido.SetValue("checks", True)
            Else
                dgjPedido.SetValue("checks", False)
            End If
        End If
    End Sub

    Private Sub cbEstados_ValueChanged(sender As Object, e As EventArgs) Handles cbEstados.ValueChanged
        Try
            If (_cargaCompleta) Then
                CargarPedidos()
                CargarFacturas()
                CargarFacturasAnuladas()
                If SuperTabControl1.SelectedTab Is SuperTabItem1 Then
                    lblCantidadPedido.Text = dgjPedido.RowCount.ToString
                Else
                    lblCantidadPedido.Text = grFactura.RowCount.ToString
                End If

                btnNotaVenta.Enabled = True
                btnFactura.Enabled = True
            End If
        Catch ex As Exception
            MostrarMensajeError(ex.Message)
        End Try
    End Sub

    Private Sub btVentasDirectas_Click(sender As Object, e As EventArgs) Handles btVentasDirectas.Click
        Try
            If (_cargaCompleta) Then
                CargarPedidos2()
                _TipoCarga = True
                lblCantidadPedido.Text = dgjPedido.RowCount.ToString
                btnNotaVenta.Enabled = True
                btnFactura.Enabled = True
            End If
        Catch ex As Exception
            MostrarMensajeError(ex.Message)
        End Try
    End Sub

    Private Sub dgjPedido_MouseClick(sender As Object, e As MouseEventArgs) Handles dgjPedido.MouseClick

    End Sub

    Private Sub ButtonX2_Click(sender As Object, e As EventArgs) Handles ButtonX2.Click
        Dim estado As Boolean = CType(dgjPedido.DataSource, DataTable).Rows(0).Item("Checks")
        If SuperTabControl1.SelectedTab Is SuperTabItem1 Then
            estado = CType(dgjPedido.DataSource, DataTable).Rows(0).Item("Checks")
            For i = 0 To CType(dgjPedido.DataSource, DataTable).Rows.Count - 1 Step 1
                CType(dgjPedido.DataSource, DataTable).Rows(i).Item("Checks") = Not estado
            Next
        Else
            estado = CType(grFactura.DataSource, DataTable).Rows(0).Item("Checks")
            For i = 0 To CType(grFactura.DataSource, DataTable).Rows.Count - 1 Step 1
                CType(grFactura.DataSource, DataTable).Rows(i).Item("Checks") = Not estado
            Next
        End If

    End Sub

    Private Sub SuperTabControl1_SelectedTabChanged(sender As Object, e As SuperTabStripSelectedTabChangedEventArgs) Handles SuperTabControl1.SelectedTabChanged
        If SuperTabControl1.SelectedTab Is SuperTabItem1 Then
            btnFactura.Visible = False
            ButtonX1.Visible = False
            btnNotaVenta.Visible = True
            btReporteDespachoCliente.Visible = True
            btReporteDespachoLinea.Visible = True
            btReporteDespachoPedido.Visible = True
            btVentasDirectas.Visible = True
            'btVolverDist.Visible = True
            btVolverDist.Text = "Volver a Distribución"

            lblCantidadPedido.Text = dgjPedido.RowCount.ToString
            btnAnularFactura.Visible = False



        ElseIf SuperTabControl1.SelectedTab Is SuperTabItem2 Then
            btnFactura.Visible = True
            ButtonX1.Visible = True
            btnNotaVenta.Visible = True
            btReporteDespachoCliente.Visible = False
            btReporteDespachoLinea.Visible = False
            btReporteDespachoPedido.Visible = False
            btVentasDirectas.Visible = False
            'btVolverDist.Visible = False
            btVolverDist.Text = "Volver a Nota de Venta"
            lblCantidadPedido.Text = grFactura.RowCount.ToString
            If gs_Mon = "Ars" Then
                btnAnularFactura.Visible = False
            Else
                btnAnularFactura.Visible = True
            End If

        Else
            btnFactura.Visible = False
            ButtonX1.Visible = True
            btnNotaVenta.Visible = False
            btReporteDespachoCliente.Visible = False
            btReporteDespachoLinea.Visible = False
            btReporteDespachoPedido.Visible = False
            btVentasDirectas.Visible = False
            'btVolverDist.Visible = True
            btVolverDist.Visible = False

            lblCantidadPedido.Text = grFacturasAnuladas.RowCount.ToString
            btnAnularFactura.Visible = False
        End If
    End Sub

    Private Sub grFactura_SelectionChanged(sender As Object, e As EventArgs) Handles grFactura.SelectionChanged
        Try
            Dim idPedido = 0
            If (grFactura.GetRows().Count > 0) Then
                idPedido = Convert.ToInt32(grFactura.CurrentRow.Cells("Id").Value)
            End If

            CargarProductos(idPedido)
        Catch ex As Exception
            MostrarMensajeError(ex.Message)
        End Try
    End Sub

    Private Sub Tb_Fecha_Click(sender As Object, e As EventArgs) Handles Tb_Fecha.Click

    End Sub

    Private Sub grFactura_Click(sender As Object, e As EventArgs) Handles grFactura.Click
        If grFactura.CurrentColumn.Index = grFactura.RootTable.Columns("Checks").Index Then
            If grFactura.GetValue("checks") = False Then
                grFactura.SetValue("checks", True)
            Else
                grFactura.SetValue("checks", False)
            End If
        End If
    End Sub

    Private Sub btnAnularFactura_Click(sender As Object, e As EventArgs) Handles btnAnularFactura.Click
        If gs_Mon = "Bs" Then
            ''MessageBox.Show(gs_Mon)
            Dim listIdPedido As New List(Of Integer)()
            Dim TFactura As New List(Of Integer)()
            Dim fecha As New List(Of String)()
            Dim customer As New List(Of String)()
            Dim customerid As New List(Of String)()
            Dim nit2 As New List(Of String)()
            Dim subtotal As New List(Of String)()
            Dim docFact As New List(Of String)()
            Dim totalTax As New List(Of String)()
            Dim total1 As New List(Of String)()
            Dim descuento As New List(Of String)()
            Dim codClie As New List(Of String)()
            Dim estado As Integer
            'Dim checks = Me.dgjPedido.GetCheckedRows()
            'Dim listIdPedido = checks.Select(Function(a) Convert.ToInt32(a.Cells("Id").Value)).ToList()
            Dim dt As DataTable = CType(grFactura.DataSource, DataTable)
            Dim filasMarcadas() As DataRow = dt.Select("checks = True")

            If filasMarcadas.Length > 1 Then
                ' Hay más de un check seleccionado
                ToastNotification.Show(Me, "Solo se debe seleccionar una factura.".ToUpper,
                   My.Resources.WARNING, 5 * 1000,
                   eToastGlowColor.Blue, eToastPosition.TopCenter)
            ElseIf filasMarcadas.Length = 0 Then

                ToastNotification.Show(Me, "debe seleccionar una factura para anular.".ToUpper,
                   My.Resources.WARNING, 5 * 1000,
                   eToastGlowColor.Blue, eToastPosition.TopCenter)
            ElseIf filasMarcadas.Length = 1 Then
                ''                MessageBox.Show("Fila seleccionada: " & filasMarcadas(0)("nombreCliente").ToString())

                estado = IIf(IsDBNull(filasMarcadas(0)("NroFactura")), 0, filasMarcadas(0)("NroFactura"))

                If estado = 0 Then

                    ToastNotification.Show(Me, "La nota ".ToString + filasMarcadas(0)("Id").ToString + " aún no ha sido facturada".ToUpper,
                                       My.Resources.WARNING, 5 * 1000,
                                       eToastGlowColor.Blue, eToastPosition.TopCenter)
                    Exit Sub
                ElseIf estado = -1 Then
                    ToastNotification.Show(Me, "La factura ".ToString + filasMarcadas(0)("Id").ToString + "ya se encuentra anulada".ToUpper,
                                       My.Resources.WARNING, 5 * 1000,
                                       eToastGlowColor.Blue, eToastPosition.TopCenter)
                ElseIf estado > 0 Then
                    Dim ef = New Efecto
                    ef.tipo = 7
                    ef.ShowDialog()
                    Dim bandera As Boolean = False
                    tipoDoc = ef.tipoDoc
                    bandera = ef.band

                    If anularFactura(tokenSifac, filasMarcadas(0)("fvafactint"), tipoDoc) = "200" Then
                        updateFactura(filasMarcadas(0)("Id").ToString, filasMarcadas(0)("fvafactint"))
                        ticket(filasMarcadas(0)("fvafactint"))
                        CargarPedidos()
                        CargarFacturas()
                        CargarFacturasAnuladas()

                    End If

                End If

            End If

            'End If
        End If
    End Sub

    Private Sub grFacturasAnuladas_Click(sender As Object, e As EventArgs) Handles grFacturasAnuladas.Click
        If grFacturasAnuladas.CurrentColumn.Index = grFacturasAnuladas.RootTable.Columns("Checks").Index Then
            If grFacturasAnuladas.GetValue("checks") = False Then
                grFacturasAnuladas.SetValue("checks", True)
            Else
                grFacturasAnuladas.SetValue("checks", False)
            End If
        End If
    End Sub
End Class