Public Class RespFactura

    Public Class Data
        Public Property invoice_id As Integer
        Public Property customer_id As Integer
        Public Property customer As String
        Public Property user_id As Integer
        Public Property store_id As Integer
        Public Property nit_ruc_nif As String
        Public Property tax_id As String
        Public Property tax_rate As Integer
        Public Property subtotal As Double
        Public Property total_tax As Double
        Public Property discount As Double
        Public Property monto_giftcard As Double
        Public Property total As Double
        Public Property cash As Double
        Public Property invoice_number As Integer
        Public Property control_code As String
        Public Property authorization As String
        Public Property invoice_date_time As String
        Public Property invoice_limite_date As String
        Public Property currency_code As String
        Public Property status As String
        Public Property codigo_sucursal As Integer
        Public Property punto_venta As Integer
        Public Property actividad_economica As String
        Public Property codigo_documento_sector As Integer
        Public Property tipo_documento_identidad As Integer
        Public Property codigo_metodo_pago As Integer
        Public Property codigo_moneda As Integer
        Public Property cufd As String
        Public Property cuf As String
        Public Property cafc As String
        Public Property complemento As String
        Public Property numero_tarjeta As String
        Public Property tipo_cambio As Integer
        Public Property evento_id As String
        Public Property siat_id As String
        Public Property tipo_emision As Integer
        Public Property tipo_factura_documento As Integer
        Public Property nit_emisor As Int64
        Public Property ambiente As Integer
        Public Property data As String
        Public Property last_modification_date As String
        Public Property creation_date As String
        Public Property items As List(Of items)
        Public Property siat_url As String
        Public Property print_url As String
        Public Property sector As String
        Public Property leyenda As String
    End Class

    Public Class FactResp
        Public Property code As Integer
        Public Property response As String
        Public Property data As Data
    End Class

    Public Class items
        Public Property item_id As Integer
        Public Property invoice_id As Integer
        Public Property store_id As Integer
        Public Property product_id As Integer
        Public Property product_code As String
        Public Property product_name As String
        Public Property price As Double
        Public Property quantity As Double
        Public Property total As Double
        Public Property discount As Double
        Public Property codigo_actividad As Integer
        Public Property codigo_producto_sin As Integer
        Public Property unidad_medida As Integer
        Public Property numero_serie As String
        Public Property numero_imei As String
        Public Property user_id As Integer
        Public Property data As String
        Public Property last_modification_date As String
        Public Property creation_date As String

    End Class

End Class