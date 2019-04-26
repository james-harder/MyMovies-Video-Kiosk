Public Module Program
    'UserID tracks the current user
    Public Property UserID() As Integer

    'MoviesOrdered tracks the movies added to the order, IE a shopping cart
    'MoviesOrdered() returns the list of movies ordered
    'AddToOrder() adds a movie title to _MoviesOrdered
    Private _MoviesInOrder As New MyMoviesDBDataSet.SearchResultsDataTable()
    Public Property MoviesInOrder() As MyMoviesDBDataSet.SearchResultsDataTable
        Get
            Return _MoviesInOrder
        End Get

        Set(ByVal value As MyMoviesDBDataSet.SearchResultsDataTable)
            _MoviesInOrder = value
        End Set
    End Property

    Private newPropertyValue As String
    Public Property NewProperty() As String
        Get
            Return newPropertyValue
        End Get
        Set(ByVal value As String)
            newPropertyValue = value
        End Set
    End Property

    'System.Windows.Forms.FormWindowState is an enum to track maximized/minimized/normal window state
    Public Property WindowState() As FormWindowState

    'Opens new frmStart window
    Public ReadOnly Property Start() As frmStart
        Get
            If (_Start Is Nothing OrElse _Start.IsDisposed) Then
                _Start = New frmStart()
                _Start.WindowState = WindowState
            End If
            Return _Start
        End Get
    End Property

    'Opens new frmSearch window
    Public ReadOnly Property Search() As frmSearch
        Get
            If (_Search Is Nothing OrElse _Search.IsDisposed) Then
                _Search = New frmSearch()
                _Search.WindowState = WindowState
            End If
            Return _Search
        End Get
    End Property

    'Opens new frmRegistration window
    Public ReadOnly Property Registration() As frmRegistration
        Get
            If (_Registration Is Nothing OrElse _Registration.IsDisposed) Then
                _Registration = New frmRegistration()
                _Registration.WindowState = WindowState
            End If
            Return _Registration
        End Get
    End Property

    'Opens new frmPlaceOrder window
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

    'Toggles FormWindowState of all forms between Maximized / Normal
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
    Public Function CheckForSQL(stringIn As String) As Boolean
        If stringIn.ToUpper().Contains("SELECT") Or stringIn.ToUpper.Contains("UPDATE") Or stringIn.ToUpper.Contains("DELETE") Or stringIn.ToUpper.Contains("DROP") Or stringIn.ToUpper.Contains("INSERT") Then
            Return True
        Else
            Return False
        End If
    End Function
End Module
