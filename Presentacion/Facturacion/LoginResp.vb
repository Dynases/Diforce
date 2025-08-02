Public Class LoginResp
    Public Class Meta

    End Class

    Public Class Data
        Public Property token As String
        Public Property token_type As String
        Public Property expires_at As String
    End Class

    Public Class RespuestLogin
        'Public Property meta As Meta
        Public Property response As String
        Public Property code As Integer
        Public Property data As Data
    End Class
End Class
