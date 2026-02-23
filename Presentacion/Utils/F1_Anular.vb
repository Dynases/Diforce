Imports DevComponents.DotNetBar.Controls
Imports DevComponents.DotNetBar
Imports Logica.AccesoLogica
Imports Janus.Windows.GridEX
Imports Newtonsoft.Json
Imports Presentacion.UmedidaResp
Imports Presentacion.NitValida
Imports Presentacion.TopeCF
Imports System.IO
Imports System.Net
Imports Presentacion.F02_Cliente
Imports Newtonsoft.Json.Linq
Imports Presentacion.verificarNit

Public Class F1_Anular
    Public nit As String
    Public razonsocial As String
    Public email As String
    Public tipoDoc As Integer
    Public Cantidad As Decimal
    Public cliente As Integer
    Public bandera As Boolean
    Public Nuevo As Boolean = False


    Private Sub F_Cantidad_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim tokenSifac As String
        tokenSifac = F01_Producto.ObtToken()
        ListarDocumentosIdentidad(tokenSifac)
        CbTipoDoc.SelectedIndex = 0
    End Sub
    Public Function ListarDocumentosIdentidad(tokenObtenido As String, Optional ae As Integer = 5)

        Dim link As String = TraerLinkFacturacion(3).Rows(0).Item("descr")

        Dim request = TryCast(System.Net.WebRequest.Create(link + "api/invoices/siat/v2/sync-motivos-anulacion"), System.Net.HttpWebRequest)

        request.Method = "GET"

        request.ContentType = "application/json"
        Dim bearer As String = "Bearer " + tokenObtenido
        request.Headers.Add("authorization", bearer)

        request.ContentLength = 0
        Dim responseContent As String
        Using response = TryCast(request.GetResponse(), System.Net.HttpWebResponse)
            Using reader = New System.IO.StreamReader(response.GetResponseStream())
                responseContent = reader.ReadToEnd()
                Dim result = JsonConvert.DeserializeObject(Of listaTipoDocumento)(responseContent)

                Dim arr As JToken = JObject.Parse(responseContent) _
    .SelectToken("data.RespuestaListaParametricas.listaCodigos")

                Dim lista As List(Of TipoDocumentoItem) =
    arr.ToObject(Of List(Of TipoDocumentoItem))()

                With CbTipoDoc
                    .DropDownList.Columns.Clear()

                    With .DropDownList.Columns.Add("codigoClasificador")
                        .Caption = "COD"
                        .Width = 80
                    End With
                    With .DropDownList.Columns.Add("descripcion")
                        .Caption = "DESCRIPCION"
                        .Width = 400   ' ajusta a gusto
                    End With

                    .ValueMember = "codigoClasificador"
                    .DisplayMember = "descripcion"
                    .DataSource = lista
                    .Refresh()
                End With
            End Using
        End Using

        Return ""
    End Function




    Private Sub ButtonX1_Click(sender As Object, e As EventArgs) Handles ButtonX1.Click
        bandera = False
        Me.Close()
    End Sub

    Private Sub ReflectionLabel1_Click(sender As Object, e As EventArgs) Handles ReflectionLabel1.Click

    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        
        tipoDoc = CbTipoDoc.Value
        bandera = True
        Me.Close()
    End Sub


    Private Function ValidarNit(token As String, nit As String) As Boolean
        Try
            Dim request = TryCast(System.Net.WebRequest.Create("https://contadores.sige.company/api/invoices/siat/v2/validate-nit?nit=" + nit), System.Net.HttpWebRequest)

            request.Method = "GET"

            request.ContentType = "application/json"
            request.Headers.Add("authorization", "Bearer " + token)

            'request.ContentLength = 0
            Dim responseContent As String
            Using response = TryCast(request.GetResponse(), System.Net.HttpWebResponse)
                Using reader = New System.IO.StreamReader(response.GetResponseStream())
                    responseContent = reader.ReadToEnd()
                    Return True
                End Using
            End Using
        Catch ex As WebException
            If Not ex.Response Is Nothing Then
                Dim data As StreamReader = New StreamReader(ex.Response.GetResponseStream)
                'Al asignar el data.ReadToEnd al string se puede apreciar la respuesta del WebService en la variable str
                Dim str As String = data.ReadToEnd
                str = str.Replace("error", "message")
                Dim result = JsonConvert.DeserializeObject(Of Validar)(str)
                Dim message As String = result.message
                ToastNotification.Show(Me,
                                   message.ToUpper,
                                   My.Resources.WARNING,
                                   2000,
                                   eToastGlowColor.Red,
                                   eToastPosition.TopCenter)
                Return False
            End If


        End Try
    End Function

    Private Sub ButtonX2_Click(sender As Object, e As EventArgs)
        'tbRazonSocial.Clear()
        tbNit.Clear()
        'tbEmail.Clear()
        CbTipoDoc.SelectedIndex = 0
    End Sub

    Private Sub CbTipoDoc_ValueChanged(sender As Object, e As EventArgs) Handles CbTipoDoc.ValueChanged
        'If CbTipoDoc.Value = 3 Then
        '    tbNit.Visible = True
        '    Label1.Visible = True
        'ElseIf CbTipoDoc.Value = 2 Then
        '    If ValidarTopeCF() Then
        '        tbNit.Visible = False
        '        Label1.Visible = False
        '    Else
        '        tbNit.Visible = True
        '        Label1.Visible = True
        '    End If
        'Else

        '    tbNit.Visible = False
        '    Label1.Visible = False
        'End If
    End Sub

    Private Function ValidarTopeCF() As Boolean

        Dim api = New DBApi()
        Dim Emenvio = New EnvioTopeCF


        'Dim EnvioComprobante = New Numeracion.comprobante

        'EnvioComprobante.tipo = "FACTURA C"
        'EnvioComprobante.operacion = "V"
        'EnvioComprobante.punto_venta = 1




        Emenvio.apitoken = "0c1669b2ee1a34bbbd4114d70ee071ec"

        Emenvio.apikey = "64207"
        Emenvio.usertoken = "c84d30fcd9d5cc4870bb6beac3d2c0e97dca090172cb755fd8af1a6702de373d"



        ServicePointManager.Expect100Continue = True
        ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12
        Dim json = JsonConvert.SerializeObject(Emenvio)
        Dim url = "https://www.tusfacturas.app/app/api/v2/facturacion/topecf"

        Dim headers = New List(Of Parametro) From {
                New Parametro("Content-Type", "application/json")
                }

        'Dim parametros = New List(Of Parametro)

        Dim response = api.Post(url, headers, Emenvio)

        Dim result = JsonConvert.DeserializeObject(Of Resp)(response)
        Dim res As Boolean
        If result.monto > 0 Then
            res = True
        Else
            res = False
        End If
        Return res

    End Function
End Class