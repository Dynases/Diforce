Public Class NitValida
    Public Class Meta
        Public Property status As Boolean
        Public Property code As Integer
        Public Property message As String
    End Class

    Public Class listaCodigos
        Public Property codigoClasificador As Integer
        Public Property descripcion As String
    End Class

    Public Class RespuestaListaParametricas
        Public Property transaccion As Boolean
        Public Property listaCodigos As List(Of listaCodigos)
        Public Property message As String
    End Class

    Public Class Data

        Public Property RespuestaListaParametricas As RespuestaListaParametricas
        'Public Property codigoClasificador As String
        'Public Property descripcion As String
    End Class

    Public Class Validar
        'Public Property meta As Meta
        Public Property code As Integer
        Public Property response As String
        Public Property data As Data
        Public Property message As String
    End Class
End Class
