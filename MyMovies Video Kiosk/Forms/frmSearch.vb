Public Class frmSearch
#Region "Properties"



#End Region

#Region "Methods"

    Private Sub testMovies()
        lstResults.Items.Add("The Angry Inch")
        lstResults.Items.Add("The Room")
        lstResults.Items.Add("39 Steps")
        lstResults.Items.Add("The Fifth Element")
    End Sub

#End Region

#Region "Event Handlers"

    'handles btnSearch click
    'just for testing...
    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click

        testMovies()

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
        'send movie name to frmPlaceOrder
        PlaceOrder.orderList = lstResults.SelectedItem

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
#End Region

End Class