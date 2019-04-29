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

    ' Matches a MovieId to the line number of lstResults.ItemSelected...
    'There HAS to be a better way to do this
    Private _MovieIdIndex() As Integer
    Public Property MovieIdIndex() As Integer()
        Get
            Return _MovieIdIndex
        End Get
        Set(ByVal value() As Integer)

            If value Is Nothing Then
                Throw New ArgumentNullException(NameOf(value))
            End If

            _MovieIdIndex = value
        End Set
    End Property
    'returns the MovieId at lineNumber
    Public ReadOnly Property IdOfLine(lineNumber As Integer) As Integer
        Get
            If _MovieIdIndex IsNot Nothing Then
                Return _MovieIdIndex(lineNumber)
            End If
        End Get
    End Property

    'End Property

#End Region

#Region "Methods"

    Private Function SearchDataBase(ByVal searchTerms As String) As DataTable

        Dim resultsAdapter As New MyMoviesDBDataSetTableAdapters.SearchResultsTableAdapter()
        Dim results As New MyMoviesDBDataSet.SearchResultsDataTable()

        results.Clear()
        resultsAdapter.Fill(results, searchTerms)

        ' find number of results
        Dim intNumberOfResults As Integer = results.Rows.Count()

        'set _MovieIdIndex
        Dim intMovieIds(intNumberOfResults) As Integer

        If intNumberOfResults > 0 Then

            For i As Integer = 0 To (intNumberOfResults - 1)
                intMovieIds(i) = results.Rows(i).Item(0)
            Next

            MovieIdIndex = intMovieIds
        End If

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

    Private Sub frmSearch_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnAddToCart_Click(sender As Object, e As EventArgs) Handles btnAddToCart.Click

        'find MovieID that matches title
        Dim intSelectedMovieId As Integer = IdOfLine(lstResults.SelectedIndex)

        ' add movie to order
        Program.AddMovieToOrder = intSelectedMovieId
        ' check to see what's in MoviesInOrder
        Dim number As List(Of Integer) = MoviesInOrder()

        'Display a confirmation that the movie was added to the cart
        MessageBox.Show("Movie added to cart. You have " + SizeOfOrder().ToString + " in your order.", "Information", MessageBoxButtons.OK)

    End Sub
#End Region

End Class