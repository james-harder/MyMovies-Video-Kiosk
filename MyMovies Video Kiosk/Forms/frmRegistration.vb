Public Class frmRegistration

    '? does this give us a link to the frmStart that sent us here?
    Private Overloads Property ParentForm() As Form

    'Handles btnSubmit Click
    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        'Validate inputs and add new user to DB

        PlaceOrder.Show()
        Hide()

    End Sub

    'Handles btnCancel Click
    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        'Return to frmStart if that was previous form, otherwise
        'display frmPlaceOrder

        If (ParentForm.Name = "frmStart") Then
            Start.Show()
        Else
            PlaceOrder.Show()
        End If

        Hide()

    End Sub

    '?Overload Show() method to include parent argument?
    Public Overloads Sub Show(parent As Form)

        ParentForm = parent
        MyBase.Show()

    End Sub

    Private Sub frmRegistration_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        'If F11 is pressed, resize all forms

        If (e.KeyCode = Keys.F11) Then
            ResizeAllForms()
        End If

    End Sub

End Class