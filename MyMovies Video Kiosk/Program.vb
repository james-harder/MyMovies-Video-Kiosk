Public Module Program
    Public Property UserID() As Integer
    Public ReadOnly Property Start() As frmStart
        Get
            If (_Start Is Nothing OrElse _Start.IsDisposed) Then
                _Start = New frmStart()
            End If
            Return _Start
        End Get
    End Property
    Public ReadOnly Property Search() As frmSearch
        Get
            If (_Search Is Nothing OrElse _Search.IsDisposed) Then
                _Search = New frmSearch()
            End If
            Return _Search
        End Get
    End Property
    Public ReadOnly Property Registration() As frmRegistration
        Get
            If (_Registration Is Nothing Or _Registration.IsDisposed) Then
                _Registration = New frmRegistration()
            End If
            Return _Registration
        End Get
    End Property
    Public ReadOnly Property PlaceOrder() As frmPlaceOrder
        Get
            If (_PlaceOrder Is Nothing Or _PlaceOrder.IsDisposed) Then
                _PlaceOrder = New frmPlaceOrder()
            End If
            Return _PlaceOrder
        End Get
    End Property

    Private _Start As frmStart
    Private _Search As frmSearch
    Private _Registration As frmRegistration
    Private _PlaceOrder As frmPlaceOrder
End Module
