Public Class RespPDF

    Public Class Data
        Public Property buffer As String
        Public Property mime As String
    End Class

    Public Class PDFResp
        Public Property code As Integer
        Public Property response As String
        Public Property data As Data
    End Class



End Class
