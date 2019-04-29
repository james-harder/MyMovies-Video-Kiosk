Public Class frmPlaceOrder

#Region "Properties"

    Private _orderNumber As Integer
    Private _TotalPrice As Integer
    Public ReadOnly Property OrderNumber() As Integer
        Get
            Return _orderNumber
        End Get
    End Property


#End Region

#Region "Methods"

    Private Function getMoviesInOrder() As List(Of String)

        Dim lstMovieList As New List(Of String)

        'make a data adapter
        Dim movieDataAdapter As New MyMoviesDBDataSetTableAdapters.MovieTableAdapter

        'get the list of movieID's from the program.MoviesInOrder List
        For Each movieId As Integer In Program.MoviesInOrder()
            Dim movieDataRow As MyMoviesDBDataSet.MovieDataTable = movieDataAdapter.GetMovieByID(movieId)
            Dim strMovieId As String = movieDataRow.Item(0).MovieID.ToString
            Dim strMovieTitle As String = movieDataRow.Item(0).Title.ToString
            Dim dblMoviePrice As Double = movieDataRow.Item(0).Price
            _TotalPrice += movieDataRow.Item(0).Price
            Dim strItemRow As String = "[" + strMovieId + "]" + " " + strMovieTitle + " (" + dblMoviePrice.ToString("C2") + ")"
            lstMovieList.Add(strItemRow)
        Next

        lblTotal.Text = _TotalPrice.ToString("C2")
        Return lstMovieList
    End Function

    Private Sub makeOrderItems(ByVal movieIds As List(Of Integer))
        Dim movieAdapter As New MyMoviesDBDataSetTableAdapters.MovieTableAdapter
        Dim orderDetailAdapter As New MyMoviesDBDataSetTableAdapters.OrderDetailTableAdapter

        Dim intOrder As Integer = OrderNumber()
        Dim dblPrice As Double
        Dim intQuantity As Integer = 1

        For Each movieId As Integer In movieIds
            dblPrice = movieAdapter.GetPriceById(movieId)
            orderDetailAdapter.AddOrderLine(intOrder, movieId, intQuantity, dblPrice * intQuantity)
        Next

    End Sub

#End Region

#Region "Event Handlers"

    'Handles Load() of this form
    Private Sub frmPlaceOrder_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'make a table adapter to use with ordertable
        Dim orderTableAdapter As New MyMoviesDBDataSetTableAdapters.OrderTableAdapter
        Dim orderTable As New MyMoviesDBDataSet.OrderDataTable

        'if _orderNumber is not set, create a new row in dbo.Orders and set_orderNumber to that
        If OrderNumber = Nothing Then
            'create a new blank order
            Dim createDate = DateTime.Now
            orderTableAdapter.AddOrderRow(UserID(), createDate, 0.0)
            orderTableAdapter.Fill(orderTable)
            _orderNumber = orderTable.Count
        End If

        ' get customer info based on Program.UserID, fill Customer table
        Me.CustomerTableAdapter.FillByID(Me.MyMoviesDBDataSet.Customer, Program.UserID)

        'Set Card Carrier check box index to 0
        cboCardCarrier.SelectedIndex = 0

        'Set dataSource for lstItems
        lstItems.DataSource = getMoviesInOrder()

    End Sub

    'Handles btnCancel Click
    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click

        'show frmSearch
        Search.Show()

        'Hides this form
        Close()

    End Sub

    'Handles btnPlaceOrder Click
    Private Sub btnPlaceOrder_Click(sender As Object, e As EventArgs) Handles btnPlaceOrder.Click
        Dim userAdapter As New MyMoviesDBDataSetTableAdapters.UserTableAdapter
        Dim orderDetailAdapter As New MyMoviesDBDataSetTableAdapters.OrderDetailTableAdapter
        Dim orderAdapter As New MyMoviesDBDataSetTableAdapters.OrderTableAdapter

        Dim users As New MyMoviesDBDataSet.UserDataTable

        Dim dateCheck As DateTime
        If DateTime.TryParse(txtExpiry.Text, dateCheck) AndAlso txtSecurityCode.Text.Length >= 3 AndAlso txtCreditCard.Text.Length >= 15 Then

            userAdapter.FillByID(users, UserID)
            If users.Count = 1 Then
                'add each item in lstItems to an orderDetail row
                makeOrderItems(MoviesInOrder())

                'display confirmation message box
                Dim drConfimation As DialogResult = MessageBox.Show("Your Total is " + _TotalPrice.ToString("C2"), "Confirm Order", MessageBoxButtons.OKCancel)

                'if confirmed, write order to database and clear page properties so a new order can be made.
                If drConfimation = 1 Then
                    orderAdapter.CompleteOrder(Date.Now, _TotalPrice, OrderNumber)
                    UserID = Nothing
                    MoviesInOrder = New List(Of Integer)
                    Start.Show()
                    Close()
                ElseIf drConfimation = 3 Then
                    'do nothing
                End If
                'if cancelled, go back to form place order

            Else
                'Passes this form to frmRegistration
                Registration.Show(Me)

                'Hides this form
                Close()
            End If
            'If (Customer.Exists)
            '   Place Order
            'Else



            'End If
        Else
            MessageBox.Show("User input cannot be accepted.")
        End If
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