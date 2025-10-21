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


Public Class F1_MontosPedido
    Public pedido As String
    Public cliente As String
    Public total As Double
    Public contado As Double
    Public credito As Double
    Public transferencia As Double
    Public bandera As Boolean
    Public Nuevo As Boolean = False


    Private Sub F_Cantidad_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lbCliente.Text = cliente.ToString
        lbPedido.Text = pedido.ToString
        lbTotal.Text = total.ToString
        tbContado.Value = contado
        tbCredito.Value = credito
        tbTransferencia.Value = transferencia
    End Sub

    Private Sub ButtonX1_Click(sender As Object, e As EventArgs) Handles ButtonX1.Click
        bandera = False
        Me.Close()
    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        'Cantidad = tbNit.Value
        'Impresora = CbTipoDoc.Value
        'Dim dt As DataTable = VerificarNit(tbNit.Text)
        'If dt.Rows.Count > 0 Then
        '    Nuevo = False
        'Else
        '    Nuevo = True
        'End If
        'If Nuevo = True Then
        '    Dim token As String = F01_Producto.ObtToken()
        '    'crearCliente(token)
        '    'RegistrarNit(tbNit.Text, tbRazonSocial.Text, tbEmail.Text, CbTipoDoc.Value)
        'End If

        contado = tbContado.Value
        credito = tbCredito.Value
        transferencia = tbTransferencia.Value

        bandera = True
        Me.Close()
    End Sub

    Private Sub tbTransferencia_ValueChanged(sender As Object, e As EventArgs) Handles tbTransferencia.ValueChanged
        Dim Totalsuma As Double = (tbContado.Value + tbCredito.Value + tbTransferencia.Value)
        Dim total2 As Double = total
        If Totalsuma > total2 Then
            tbTransferencia.Value = transferencia


            Dim message As String = "La suma de montoa no puede superar el monto total: " + total.ToString
            ToastNotification.Show(Me,
                               message.ToUpper,
                               My.Resources.WARNING,
                               2000,
                               eToastGlowColor.Red,
                               eToastPosition.TopCenter)
        End If
    End Sub

    Private Sub tbCredito_ValueChanged(sender As Object, e As EventArgs) Handles tbCredito.ValueChanged
        If (tbContado.Value + tbCredito.Value + tbTransferencia.Value) > total Then
            tbCredito.Value = credito
            Dim message As String = "La suma de montoa no puede superar el monto total: " + total.ToString
            ToastNotification.Show(Me,
                               message.ToUpper,
                               My.Resources.WARNING,
                               2000,
                               eToastGlowColor.Red,
                               eToastPosition.TopCenter)
        End If
    End Sub

    Private Sub tbContado_ValueChanged(sender As Object, e As EventArgs) Handles tbContado.ValueChanged
        If (tbContado.Value + tbCredito.Value + tbTransferencia.Value) > total Then
            tbContado.Value = contado
            Dim message As String = "La suma de montoa no puede superar el monto total: " + total.ToString
            ToastNotification.Show(Me,
                               message.ToUpper,
                               My.Resources.WARNING,
                               2000,
                               eToastGlowColor.Red,
                               eToastPosition.TopCenter)
        End If
    End Sub
End Class