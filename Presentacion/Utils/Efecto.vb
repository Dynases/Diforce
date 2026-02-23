
Imports System.ComponentModel
Imports System.Text
Imports DevComponents.DotNetBar
Public Class Efecto
    Public _archivo As String
    Public band As Boolean = False
    Public Header As String = ""
    Public tipo As Integer = 0
    Public Context As String = ""
    Public listEstCeldas As List(Of Modelo.MCelda)
    Public dt As DataTable
    Public alto As Integer
    Public ancho As Integer
    Public Row As Janus.Windows.GridEX.GridEXRow
    Public SeleclCol As Integer = -1
    Public cliente As Integer = -1

    Public nit As String
    Public razonsocial As String
    Public email As String
    Public tipoDoc As Integer

    Public cliente2 As String
    Public pedido As Integer
    Public contado As Double
    Public credito As Double
    Public transferencia As Double
    Public total As Double


    Private Sub Efecto_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized

        Select Case tipo
            Case 1
                 _prMostrarMensaje()
            Case 2
                _prMostrarMensajeDelete()
            Case 3
                _prMostrarFormAyuda()
            Case 4
                _prLogin()
            Case 5
                _prDatosFactura()
            Case 6
                _prDatosMontosPedido()
            Case 7
                _prDatosAnularFactura()
        End Select
    End Sub
    Public Sub _prLogin()
        Dim Frm As New Login
        Frm.ShowDialog()
        Me.Close()
    End Sub

    Sub _prDatosAnularFactura()

        Dim frmAyuda As F1_Anular
        frmAyuda = New F1_Anular
        frmAyuda.cliente = cliente
        'frmAyuda.Cantidad = 1
        frmAyuda.ShowDialog()

        If frmAyuda.bandera = True Then

            nit = frmAyuda.nit
            razonsocial = frmAyuda.razonsocial
            email = frmAyuda.email
            tipoDoc = frmAyuda.tipoDoc
            band = True
            Me.Close()
        Else
            band = False
            Me.Close()
        End If
    End Sub
    Sub _prMostrarFormAyuda()

        Dim frmAyuda As Modelo.ModeloAyuda
        frmAyuda = New Modelo.ModeloAyuda(alto, ancho, dt, Context.ToUpper, listEstCeldas)
        If (SeleclCol >= 0) Then
            frmAyuda.Columna = SeleclCol
            frmAyuda._prSeleccionar()

        End If
        frmAyuda.ShowDialog()
        If frmAyuda.seleccionado = True Then
            Row = frmAyuda.filaSelect
            band = True
            Me.Close()
        Else
            band = False
            Me.Close()
        End If
       
    End Sub
    Sub _prMostrarMensaje()
        Dim blah As Bitmap = My.Resources.cuestion
        Dim ico As Icon = Icon.FromHandle(blah.GetHicon())

        If (MessageBox.Show(Context, Header, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes) Then
            'Process.Start(_archivo)
            band = True
            Me.Close()
        Else
            band = False
            Me.Close()


        End If
    End Sub
    Sub _prMostrarMensajeDelete()

        Dim info As New TaskDialogInfo(Context, eTaskDialogIcon.Delete, "advertencia".ToUpper, Header, eTaskDialogButton.Yes Or eTaskDialogButton.Cancel, eTaskDialogBackgroundColor.Default)
        Dim result As eTaskDialogResult = TaskDialog.Show(info)
        If result = eTaskDialogResult.Yes Then
            Dim mensajeError As String = ""
            band = True
            Me.Close()

        Else
            band = False
            Me.Close()

        End If
    End Sub

    Sub _prDatosFactura()

        Dim frmAyuda As F1_Cantidad
        frmAyuda = New F1_Cantidad
        frmAyuda.cliente = cliente
        'frmAyuda.Cantidad = 1
        frmAyuda.ShowDialog()

        If frmAyuda.bandera = True Then

            nit = frmAyuda.nit
            razonsocial = frmAyuda.razonsocial
            email = frmAyuda.email
            tipoDoc = frmAyuda.tipoDoc
            band = True
            Me.Close()
        Else
            band = False
            Me.Close()
        End If
    End Sub

    Sub _prDatosMontosPedido()

        Dim frmAyuda As F1_MontosPedido
        frmAyuda = New F1_MontosPedido
        frmAyuda.cliente = cliente2
        frmAyuda.pedido = pedido
        frmAyuda.contado = contado
        frmAyuda.credito = credito
        frmAyuda.transferencia = transferencia
        frmAyuda.total = total
        'frmAyuda.Cantidad = 1
        frmAyuda.ShowDialog()

        If frmAyuda.bandera = True Then

            pedido = frmAyuda.pedido
            contado = frmAyuda.contado
            credito = frmAyuda.credito
            transferencia = frmAyuda.transferencia
            band = True
            Me.Close()
        Else
            band = False
            Me.Close()
        End If
    End Sub
End Class