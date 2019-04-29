Public Module Program
#Region "Properties"
    'UserID tracks the current user
    Public Property UserID() As Integer

    'System.Windows.Forms.FormWindowState is an enum to track maximized/minimized/normal window state
    Public Property WindowState() As FormWindowState

    '_MoviesInOrder is like a shopping cart...
    Private _MoviesInOrder As List(Of Integer)
    Public Property MoviesInOrder() As List(Of Integer)
        Get
            If _MoviesInOrder IsNot Nothing Then
                Return _MoviesInOrder
            Else
                _MoviesInOrder = New List(Of Integer)
                Return _MoviesInOrder
            End If

        End Get
        Set(ByVal value As List(Of Integer))
            _MoviesInOrder = value
        End Set
    End Property

    'adds a single movie to Movies in order
    Public WriteOnly Property AddMovieToOrder() As Integer
        Set(ByVal Value As Integer)
            If _MoviesInOrder Is Nothing Then
                Dim movies As List(Of Integer) = New List(Of Integer)
                movies.Add(Value)
                _MoviesInOrder = movies
            Else
                _MoviesInOrder.Add(Value)
            End If
        End Set
    End Property

    Public ReadOnly Property SizeOfOrder() As Integer
        Get
            Return _MoviesInOrder.Count()
        End Get
    End Property


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

#End Region

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
