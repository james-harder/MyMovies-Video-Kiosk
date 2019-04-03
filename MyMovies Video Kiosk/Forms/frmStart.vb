Public Class frmStart
#Region "Methods"
    Private Sub SubmitUser()
        Dim p As Integer
        If (Integer.TryParse(txtUsername.Text, p)) Then
            UserID = p
            Search.Show()
            Hide()
        Else
            MessageBox.Show("User ID incorrectly formatted.", "Lookup Failed", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtUsername.Text = String.Empty
        End If
    End Sub
#End Region
#Region "Event Handlers"
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Application.Exit()
    End Sub
    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        SubmitUser()
    End Sub
    Private Sub btnRegister_Click(sender As Object, e As EventArgs) Handles btnRegister.Click
        Registration.Show(Me)   'Shows form, sets its parent to this form
        Hide()
    End Sub
    Private Sub txtUsername_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtUsername.KeyPress
        If (e.KeyChar = ChrW(Keys.Enter)) Then
            SubmitUser()
        End If
    End Sub
    Private Sub frmStart_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Dim result As DialogResult = DialogResult.None
        result = MessageBox.Show("Are you sure you want to exit?", "Confirm Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
        If (result = DialogResult.No) Then
            e.Cancel = True
        End If
    End Sub
    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        Search.Show()
        Hide()
    End Sub
    Private Sub frmStart_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If (e.KeyCode = Keys.F11) Then
            ResizeAllForms()
        End If
    End Sub
    Private Sub frmStart_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Not Equals(Start) Then
            RemoveHandler FormClosing, AddressOf frmStart_FormClosing
            Start.Show()
            Close()
        End If
    End Sub 'Close startup form, replace with frmStart tracked by Program.vb
#End Region
End Class
