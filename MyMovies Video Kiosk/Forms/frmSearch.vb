Public Class frmSearch
#Region "Methods"
#End Region
#Region "Event Handlers"
    Private Sub btnReturn_Click(sender As Object, e As EventArgs) Handles btnReturn.Click
        Start.Show()
        Hide()
    End Sub
    Private Sub btnPlaceOrder_Click(sender As Object, e As EventArgs) Handles btnPlaceOrder.Click
        PlaceOrder.Show()
        Hide()
    End Sub

    Private Sub frmSearch_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If (e.KeyCode = Keys.F11) Then
            ResizeAllForms()
        End If
    End Sub
#End Region
End Class