Public Class frmSearch
#Region "Properties"

    Private _currentOrderID As String
    Public Property currentOrderID() As String

        Get
            If String.IsNullOrEmpty(_currentOrderID) Then
                ' make new orderID
                ' make sure to add try catch before submiting project

                Return UserID.ToString
            Else
                Return _currentOrderID
            End If
        End Get

        Set(ByVal value As String)
            _currentOrderID = value
        End Set

    End Property

#End Region

#Region "Methods"

    Private Function getSearchResults(ByVal searchTerms As String) As DataTable
        'WHERE Title LIKE *'@searchTerm'*
        Dim resultsAdapter As New MyMoviesDBDataSetTableAdapters.SearchResultsTableAdapter()
        Dim results As New MyMoviesDBDataSet.SearchResultsDataTable()

        results.Clear()
        resultsAdapter.Fill(results, searchTerms)

        If results IsNot Nothing Then
            For Each row As DataRow In results
                lstResults.Items.Add(row.Item(4))
            Next
        End If

    End Function

#End Region

#Region "Event Handlers"

    'handles btnSearch click
    'just for testing...
    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click

        'call function that returns dataTable
        'add each row of data table to lstIResults

    End Sub

    'Handles btnReturn click
    Private Sub btnReturn_Click(sender As Object, e As EventArgs) Handles btnReturn.Click
        'Returns to frmStart
        Start.Show()

        'Hides this form
        Hide()

    End Sub

    'Handles btnPlaceOrder Click
    Private Sub btnPlaceOrder_Click(sender As Object, e As EventArgs) Handles btnPlaceOrder.Click
        'Add movie to Program._MoviesOrdered
        AddToOrder = lstResults.SelectedItem

        'show frmPlaceOrder
        PlaceOrder.Show()

        'Hides this form
        Hide()

    End Sub

    Private Sub frmSearch_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        'Toggles all forms to / from fullscreen when F11 is pressed

        If (e.KeyCode = Keys.F11) Then
            ResizeAllForms()
        End If

    End Sub

    Private Sub btnAddToCart_click(sender As Object, e As EventArgs) Handles btnAddToCart.Click
        ' find MovieID from MovieTitle
        ' add movieID to Movies ordered
        ' Display confirmation messagebox with movie title and ID, and number of Items in cart
    End Sub

    Private Sub frmSearch_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
#End Region

End Class