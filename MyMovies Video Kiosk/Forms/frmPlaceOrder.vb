Public Class frmPlaceOrder

#Region "Properties"



#End Region

#Region "Methods"



#End Region

#Region "Event Handlers"

    'Handles Load() of this form
    Private Sub frmPlaceOrder_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'Set Card Carrier check box index to 0
        cboCardCarrier.SelectedIndex = 0

    End Sub

    'Handles btnCancle Click
    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click

        'show frmSearch
        Search.Show()

        'Hides this form
        Hide()

    End Sub

    'Handles btnPlaceOrder Click
    Private Sub btnPlaceOrder_Click(sender As Object, e As EventArgs) Handles btnPlaceOrder.Click

        'If (Customer.Exists)
        '   Place Order
        'Else

        'Passes this form to frmRegistration
        Registration.Show(Me)

        'Hides this form
        Hide()

        'End If
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