Public Class frmSearch
#Region "Properties"
    '_SearchResults is a datatable of... search results
    Private _SearchResults As MyMoviesDBDataSet.SearchResultsDataTable
    Public Property SearchResults() As MyMoviesDBDataSet.SearchResultsDataTable
        Get
            Return _SearchResults
        End Get
        Set(ByVal value As MyMoviesDBDataSet.SearchResultsDataTable)
            _SearchResults = value
        End Set
    End Property

    ' Do we need this? Why did I put this here... 
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

    Private Function SearchDataBase(ByVal searchTerms As String) As DataTable

        Dim resultsAdapter As New MyMoviesDBDataSetTableAdapters.SearchResultsTableAdapter()
        Dim results As New MyMoviesDBDataSet.SearchResultsDataTable()

        results.Clear()
        resultsAdapter.Fill(results, searchTerms)

        Return results

    End Function

    Private Sub UpdateListResults()

        lstResults.Items.Clear()

        Dim results As MyMoviesDBDataSet.SearchResultsDataTable = SearchResults()

        If results IsNot Nothing Then

            For Each movie As MyMoviesDBDataSet.SearchResultsRow In results

                Dim listItem As String = movie.Item(1).ToString + " (" + movie.Item(3).ToString + ")"

                lstResults.Items.Add(listItem)
            Next

        Else

            lstResults.Items.Add("No results were found for your search...")

        End If

    End Sub

#End Region

#Region "Event Handlers"

    'handles btnSearch click
    'just for testing...
    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click

        SearchResults = SearchDataBase(txtSearch.Text)

        UpdateListResults()

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
        'find datarow in sear


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