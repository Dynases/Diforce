Public Class VPedido_BillingDispatch
    Inherits VPedido

    Private _estaFacturado As Boolean
    Public Property EstaFacturado() As Boolean
        Get
            Return _estaFacturado
        End Get
        Set(ByVal value As Boolean)
            _estaFacturado = value
        End Set
    End Property

    Private _nroFactura As String
    Public Property NroFactura() As String
        Get
            Return _nroFactura
        End Get
        Set(ByVal value As String)
            _nroFactura = value
        End Set
    End Property
    Private _idZona As Integer
    Public Property idZona() As Integer
        Get
            Return _idZona
        End Get
        Set(ByVal value As Integer)
            _idZona = value
        End Set
    End Property
    Private _nombreZona As String
    Public Property nombreZona() As String
        Get
            Return _nombreZona
        End Get
        Set(ByVal value As String)
            _nombreZona = value
        End Set
    End Property
    Private _observacion As String
    Public Property observacion() As String
        Get
            Return _observacion
        End Get
        Set(ByVal value As String)
            _observacion = value
        End Set
    End Property

    Private _Subtotal As Decimal
    Public Property Subtotal() As Decimal
        Get
            Return _Subtotal
        End Get
        Set(ByVal value As Decimal)
            _Subtotal = value
        End Set
    End Property
    Private _descuento As Decimal
    Public Property Descuento() As Decimal
        Get
            Return _descuento
        End Get
        Set(ByVal value As Decimal)
            _descuento = value
        End Set
    End Property
    Private _Total As Decimal
    Public Property Total() As Decimal
        Get
            Return _Total
        End Get
        Set(ByVal value As Decimal)
            _Total = value
        End Set
    End Property

    Private _Factura As String
    Public Property Factura() As String
        Get
            Return _Factura
        End Get
        Set(ByVal value As String)
            _Factura = value
        End Set
    End Property
End Class
