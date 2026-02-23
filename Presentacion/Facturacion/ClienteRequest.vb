Imports Newtonsoft.Json

Public Class ClienteRequest
    Public Property customer_id As String
    Public Property code As String
    Public Property group_id As Integer
    Public Property store_id As Integer
    Public Property first_name As String
    Public Property last_name As String
    Public Property identity_document As Long
    Public Property company As String
    Public Property date_of_birth As Object   ' Nothing para null
    Public Property gender As String
    Public Property phone As String
    Public Property mobile As String
    Public Property fax As String
    Public Property email As String
    Public Property website As String
    Public Property address_1 As String
    Public Property address_2 As String
    Public Property zip_code As String
    Public Property city As String
    Public Property country As String
    Public Property country_code As String
    Public Property meta As MetaCliente

    Public Class MetaCliente
        <JsonProperty("_nit_ruc_nif")>
        Public Property nit_ruc_nif As String

        <JsonProperty("_billing_name")>
        Public Property billing_name As String   ' Nothing para null
    End Class
End Class

