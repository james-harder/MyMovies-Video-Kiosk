Public Class frmRegistration
    Overloads Property ParentForm As Form
    Public Sub New(parent As Form)
        InitializeComponent()
        ParentForm = parent
    End Sub


    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        'Add info to database
        frmPlaceOrder.Show()
        Close()
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        ParentForm.Show()
        Close()
    End Sub


End Class