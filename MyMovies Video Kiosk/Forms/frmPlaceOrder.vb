Public Class frmPlaceOrder

#Region "Properties"

    Private _orderNUmber As Integer
    Public Property orderNumber() As Integer
        Get
            Return _orderNUmber
        End Get
        Set(ByVal value As Integer)
            _orderNUmber = value
        End Set
    End Property

#End Region

#Region "Methods"

    Private Sub setOrderNumber()

        'orderNumebr should be set. If it is not, then check for the highest orderID in the database and add 1
        If orderNumber() = Nothing Then

            'get highest order number from orders table and increment, then store that as the order number
            Dim orderTableAdapter As New MyMoviesDBDataSetTableAdapters.OrderTableAdapter()

            If orderTableAdapter.MaxOrderID Is Nothing Then

                ' add first row to table
                orderTableAdapter.AddOrderRow(UserID, Date.Today, 0.0)

                orderNumber = 1
            Else

                orderNumber = orderTableAdapter.MaxOrderID() + 1

            End If

        End If

    End Sub

    Private Function getMoviesInOrder() As List(Of Integer)

        'create a Table adapter and a data table
        Dim moviesInOrderTableAdapter As New MyMoviesDBDataSetTableAdapters.MoviesInOrder()
        Dim moviesInOrder As New MyMoviesDBDataSet.MoviesByOrderAndUserDataTable()

        'fill data table 
        moviesInOrderTableAdapter.Fill(moviesInOrder, UserID, orderNumber)

        'each row should be a movie ID (later a movie title)
        For Each row As DataRow In moviesInOrder

            'store each row in the lstItem
            lstItems.Items.Add(row)

        Next


    End Function

#End Region

#Region "Event Handlers"

    'Handles Load() of this form
    Private Sub frmPlaceOrder_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'Set Card Carrier check box index to 0
        cboCardCarrier.SelectedIndex = 0

        setOrderNumber()


    End Sub

    'Handles btnCancel Click
    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click

        'show frmSearch
        Search.Show()

        'Hides this form
        Hide()

    End Sub

    'Handles btnPlaceOrder Click
    Private Sub btnPlaceOrder_Click(sender As Object, e As EventArgs) Handles btnPlaceOrder.Click

        'If (Customer.Exists)
        '   Place Order
        'Else

        'Passes this form to frmRegistration
        Registration.Show(Me)

        'Hides this form
        Hide()

        'End If
    End Sub

    'Handles keypress event in txtCreditCard and txtSecurityCode
    Private Sub txtSecurityCode_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCreditCard.KeyPress, txtSecurityCode.KeyPress

        'Allow only numeric input
        If ((e.KeyChar < "0" Or e.KeyChar > "9") And Not Char.IsControl(e.KeyChar)) Then
            e.Handled = True
        End If

    End Sub

    'Handles cboCardCarrier SelecteIndexChanged
    Private Sub cboCardCarrier_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboCardCarrier.SelectedIndexChanged
        'Ensure that validation rules match selected card carrier

        If (cboCardCarrier.SelectedIndex = 2) Then
            txtCreditCard.MaxLength = 15
            txtSecurityCode.MaxLength = 4
        Else
            txtCreditCard.MaxLength = 16
            txtSecurityCode.MaxLength = 3
        End If

    End Sub

    Private Sub frmPlaceOrder_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        'Toggle all forms from / to full screen when F11 is pressed

        If (e.KeyCode = Keys.F11) Then
            ResizeAllForms()
        End If

    End Sub
#End Region

End Class