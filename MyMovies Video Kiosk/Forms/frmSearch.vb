Public Class frmSearch
#Region "Methods"



#End Region

#Region "Event Handlers"

    'Handles btnReturn click
    Private Sub btnReturn_Click(sender As Object, e As EventArgs) Handles btnReturn.Click
        'Returns to frmStart
        Start.Show()

        'Hides this form
        Hide()

    End Sub

    'Handles btnPlaceOrder Click
    Private Sub btnPlaceOrder_Click(sender As Object, e As EventArgs) Handles btnPlaceOrder.Click
        'Should 'Video' information to frmPLaceOrder

        'show frmPlaceOrder
        PlaceOrder.Show()

        'Hides this form
        Hide()

    End Sub

    Private Sub frmSearch_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown

        'If F11 is pressed, resize all windows
        If (e.KeyCode = Keys.F11) Then
            ResizeAllForms()
        End If

    End Sub
#End Region

End Class