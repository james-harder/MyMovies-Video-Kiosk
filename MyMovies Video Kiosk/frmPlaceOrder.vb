Public Class frmPlaceOrder
    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        frmSearch.Show()
        Close()
    End Sub

    Private Sub btnPlaceOrder_Click(sender As Object, e As EventArgs) Handles btnPlaceOrder.Click
        'If (Customer.Exists)
        '   Place Order
        'Else
        Dim registration As New frmRegistration(Me) 'Pass parent (frmPlaceOrder) to frmRegistration
        registration.Show()
        Hide()
        'End If
    End Sub
End Class