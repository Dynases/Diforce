Public Class Numeracion
    Public Class comprobante
        Public Property tipo As String
        Public Property operacion As String
        Public Property punto_venta As Integer

    End Class

    Public Class Envio
        Public Property apitoken As String
        Public Property apikey As Integer
        Public Property usertoken As String
        Public Property comprobante As comprobante
    End Class


End Class

