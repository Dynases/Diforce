Public Class EmisorEnvio
    Public Class Detalle
        Public Property cantidad As Integer
        Public Property afecta_stock As String
        Public Property actualiza_precio As String
        Public Property bonificacion_porcentaje As Integer
        Public Property producto As producto

    End Class

    Public Class cliente
        Public Property documento_tipo As String
        Public Property condicion_iva As String
        Public Property domicilio As String
        Public Property condicion_pago As Integer
        Public Property documento_nro As Long
        Public Property razon_social As String
        Public Property provincia As String
        Public Property email As String
        Public Property envia_por_mail As String
        Public Property rg5329 As String
    End Class

    Public Class producto
        Public Property descripcion As String
        Public Property codigo As String
        Public Property lista_precios As String
        Public Property leyenda As String
        Public Property documento_nro As Integer
        Public Property unidad_bulto As Integer
        Public Property alicuota As Integer
        Public Property actualiza_precio As String
        Public Property rg5329 As String
        Public Property precio_unitario_sin_iva As Decimal
    End Class

    Public Class comprobante
        Public Property rubro As String
        Public Property percepciones_iva As Integer
        Public Property tipo As String
        Public Property numero As Integer
        Public Property bonificacion As Integer
        Public Property operacion As String
        Public Property detalle As Detalle()
        Public Property fecha As String
        Public Property vencimiento As String
        Public Property rubro_grupo_contable As String
        Public Property total As Decimal
        Public Property cotizacion As Integer
        Public Property moneda As String
        Public Property punto_venta As Integer
        Public Property tributos As tributos()

    End Class



    Public Class tributos

    End Class


    Public Class Emisor
        Public Property apitoken As String
        Public Property cliente As cliente
        Public Property apikey As Integer
        Public Property usertoken As String
        Public Property comprobante As comprobante
    End Class

    Public Class VerificarNit
        Public Property nit As String
        Public Property codigoSucursal As Integer

        Public Property codigoPuntoVenta As Integer

        Public Property nitVerificar As String

    End Class

    Public Class consultarEstadoEmision
        Public Property nit As String
        Public Property AnioEmision As Integer
        Public Property codigoDocumentoSector As Integer
        Public Property codigoSucursal As Integer
        Public Property codigoPuntoVenta As Integer


        Public Property numeroDocumento As String







        Public Property actividadEconomica As Integer

    End Class
End Class

