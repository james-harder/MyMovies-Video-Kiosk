Public Class frmPlaceOrder
    Private Sub frmPlaceOrder_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cboCardCarrier.SelectedIndex = 0
    End Sub
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

    Private Sub txtSecurityCode_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCreditCard.KeyPress, txtSecurityCode.KeyPress
        If ((e.KeyChar < "0" Or e.KeyChar > "9") And Not Char.IsControl(e.KeyChar)) Then
            e.Handled = True
        End If
    End Sub

    Private Sub cboCardCarrier_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboCardCarrier.SelectedIndexChanged
        If (cboCardCarrier.SelectedIndex = 2) Then
            txtCreditCard.MaxLength = 15
            txtSecurityCode.MaxLength = 4
        Else
            txtCreditCard.MaxLength = 16
            txtSecurityCode.MaxLength = 3
        End If
    End Sub


End Class