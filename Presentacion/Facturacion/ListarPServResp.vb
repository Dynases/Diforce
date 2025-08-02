Public Class ListarPServResp
    Public Class Meta
        Public Property status As Boolean
        Public Property code As Integer
        Public Property message As String
        Public Property page As Integer
        Public Property pageSize As Integer
        Public Property registered As Integer
    End Class

    Public Class Data
        Public Property RespuestaListaProductos As RespuestaListaProductos
    End Class

    Public Class ProServ
        Public Property code As Integer
        Public Property response As String
        Public Property data As Data
    End Class

    Public Class RespuestaListaProductos
        Public Property transaccion As Boolean
        Public Property listaCodigos As List(Of listaCodigos)
    End Class

    Public Class Errors
        Public Property details As Object()
        Public Property siat As Object()
    End Class

    Public Class listaCodigos
        Public Property codigoActividad As Integer
        Public Property codigoProducto As Integer
        Public Property descripcionProducto As String
    End Class
End Class
