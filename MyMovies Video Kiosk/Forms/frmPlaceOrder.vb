Public Class frmPlaceOrder

#Region "Properties"
    'call this from frmSearch btnPlaceOrder
    Private _movies As List(Of String) = New List(Of String)

    Public WriteOnly Property orderList As String

        Set(value As String)
            _movies.Add(value)
        End Set

    End Property


#End Region

#Region "Methods"



#End Region

#Region "Event Handlers"

    'Handles Load() of this form
    Private Sub frmPlaceOrder_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'Set Card Carrier check box index to 0
        cboCardCarrier.SelectedIndex = 0

        'display movies in cart
        If _movies Is Nothing Then
            lstItems.Items.Clear()
            lstItems.Items.Add("No movies in your order...")
        Else
            lstItems.Items.Clear()

            For Each movieID As String In _movies
                lstItems.Items.Add(movieID)
            Next
        End If
    End Sub

    'Handles btnCancel Click
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