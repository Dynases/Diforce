Public Class ResNumeracion
    Public Class comprobante
        Public Property tipo As String
        Public Property operacion As String
        Public Property punto_venta As Integer
        Public Property numero As Integer

    End Class

    Public Class errores

    End Class

    Public Class Resp
        Public Property error1 As String
        Public Property errores As errores()
        Public Property rta As String
        Public Property comprobante As comprobante
    End Class


End Class

