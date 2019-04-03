Public Module Program
    Public Property UserID() As Integer
    Public Property WindowState() As FormWindowState
    Public ReadOnly Property Start() As frmStart
        Get
            If (_Start Is Nothing OrElse _Start.IsDisposed) Then
                _Start = New frmStart()
                _Start.WindowState = WindowState
            End If
            Return _Start
        End Get
    End Property
    Public ReadOnly Property Search() As frmSearch
        Get
            If (_Search Is Nothing OrElse _Search.IsDisposed) Then
                _Search = New frmSearch()
                _Search.WindowState = WindowState
            End If
            Return _Search
        End Get
    End Property
    Public ReadOnly Property Registration() As frmRegistration
        Get
            If (_Registration Is Nothing OrElse _Registration.IsDisposed) Then
                _Registration = New frmRegistration()
                _Registration.WindowState = WindowState
            End If
            Return _Registration
        End Get
    End Property
    Public ReadOnly Property PlaceOrder() As frmPlaceOrder
        Get
            If (_PlaceOrder Is Nothing OrElse _PlaceOrder.IsDisposed) Then
                _PlaceOrder = New frmPlaceOrder()
                _PlaceOrder.WindowState = WindowState
            End If
            Return _PlaceOrder
        End Get
    End Property

    Private _Start As frmStart = New frmStart
    Private _Search As frmSearch = New frmSearch
    Private _Registration As frmRegistration = New frmRegistration
    Private _PlaceOrder As frmPlaceOrder = New frmPlaceOrder

    Public Sub ResizeAllForms()
        If WindowState = FormWindowState.Maximized Then
            WindowState = FormWindowState.Normal
            _Start.WindowState = FormWindowState.Normal
            _Search.WindowState = FormWindowState.Normal
            _Registration.WindowState = FormWindowState.Normal
            _PlaceOrder.WindowState = FormWindowState.Normal
        Else
            WindowState = FormWindowState.Maximized
            _Start.WindowState = FormWindowState.Maximized
            _Search.WindowState = FormWindowState.Maximized
            _Registration.WindowState = FormWindowState.Maximized
            _PlaceOrder.WindowState = FormWindowState.Maximized
        End If
    End Sub
End Module
