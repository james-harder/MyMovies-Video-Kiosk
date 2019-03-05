Public Class frmStart
#Region "Event Handlers"
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Application.Exit()
    End Sub
    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        SubmitUser()
    End Sub
    Private Sub btnRegister_Click(sender As Object, e As EventArgs) Handles btnRegister.Click
        Dim registration As New frmRegistration(Me) 'Pass parent (frmStart) to frmRegistration
        registration.Show()
        Hide()
    End Sub
    Private Sub txtUsername_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtUsername.KeyPress
        If (e.KeyChar = ChrW(Keys.Enter)) Then
            SubmitUser()
        End If
    End Sub
#End Region
#Region "Methods"
    Private Sub SubmitUser()
        Dim p As Integer
        If (Integer.TryParse(txtUsername.Text, p)) Then
            UserID = p
        Else
            MessageBox.Show("User ID incorrectly formatted.", "Lookup Failed", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtUsername.Text = String.Empty
        End If
        frmSearch.Show()
        Hide()
    End Sub
#End Region
End Class
