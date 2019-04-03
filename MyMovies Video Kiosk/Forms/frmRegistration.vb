Public Class frmRegistration
    Private Overloads Property ParentForm() As Form
    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        'Add info to database
        PlaceOrder.Show()
        Hide()
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        If (ParentForm.Name = "frmStart") Then
            Start.Show()
        Else
            PlaceOrder.Show()
        End If
        Hide()
    End Sub

    Public Overloads Sub Show(parent As Form)
        ParentForm = parent
        MyBase.Show()
    End Sub

    Private Sub frmRegistration_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If (e.KeyCode = Keys.F11) Then
            ResizeAllForms()
        End If
    End Sub
End Class