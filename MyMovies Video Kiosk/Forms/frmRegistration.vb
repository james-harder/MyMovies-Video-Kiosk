Public Class frmRegistration
    Private Overloads Property ParentForm() As Form
    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        'Add info to database
        frmPlaceOrder.Show()
        Close()
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        ParentForm.Show()
        Close()
    End Sub

    Public Overloads Sub Show(parent As Form)
        ParentForm = parent
    End Sub
End Class