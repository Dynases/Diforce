Public Class AeconomicaResp
    Public Class Meta
        Public Property status As Boolean
        Public Property code As Integer
        Public Property message As String
    End Class

    Public Class RespuestaListaActividades
        Public Property transaccion As Boolean
        Public Property listaActividades As List(Of listaActividades)

    End Class
    Public Class listaActividades


        Public Property codigoCaeb As String
        Public Property descripcion As String
        'Public Property tipoActividad As String
    End Class

    Public Class Data

        Public Property RespuestaListaActividades As RespuestaListaActividades
        'Public Property codigoActividad As String
        'Public Property descripcion As String
        'Public Property tipoActividad As String
    End Class

    Public Class Aecono
        'Public Property meta As Meta
        Public Property data As Data
    End Class
End Class
