Public Class frmSearch
#Region "Methods"
#End Region
#Region "Event Handlers"
    Private Sub btnReturn_Click(sender As Object, e As EventArgs) Handles btnReturn.Click
        Start.Show()
        Close()
    End Sub
    Private Sub btnPlaceOrder_Click(sender As Object, e As EventArgs) Handles btnPlaceOrder.Click
        frmPlaceOrder.Show()
    End Sub
#End Region
End Class