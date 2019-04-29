Public Class frmStart

#Region "Properties"



#End Region

#Region "Methods"
    Private Sub SubmitUser()
        Dim users As New MyMoviesDBDataSetTableAdapters.UserTableAdapter
        Dim tblUsers As New MyMoviesDBDataSet.UserDataTable
        users.Fill(tblUsers)

        Dim user As String = If(CheckForSQL(txtUsername.Text), "ERROR USER ATTEMPTED SQL INJECTION", txtUsername.Text)
        Dim pwd As String = If(CheckForSQL(txtPassword.Text), "ERROR USER ATTEMPTED SQL INJECTION", txtPassword.Text)
        Dim checkUser As DataRow
        checkUser = tblUsers.Select(String.Format("Username = '{0}'", user.ToUpper)).FirstOrDefault()
        If checkUser IsNot Nothing Then
            If pwd.Equals(checkUser(1).ToString()) Then
                Search.Show()
                UserID = checkUser(2)
                txtPassword.Text = String.Empty
                txtUsername.Text = String.Empty
                Hide()
            Else
                MessageBox.Show("User/Password is incorrect.", "Lookup Failed", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtUsername.Text = String.Empty
                txtPassword.Text = String.Empty
            End If
        Else
            MessageBox.Show("User is not registered in database.")
        End If
    End Sub
#End Region

#Region "Event Handlers"

    'Handles btnExit.Click
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click

        Application.Exit()

    End Sub

    'Handles btnSubmit.click - calls SubmitUser()
    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click

        SubmitUser()

    End Sub

    'Handles btnRegister.Click
    Private Sub btnRegister_Click(sender As Object, e As EventArgs) Handles btnRegister.Click

        'Shows form, sets its parent to this form
        Registration.Show(Me)
        txtPassword.Text = String.Empty
        txtUsername.Text = String.Empty
        Hide()

    End Sub

    'Handles txtUsername.KeyPress
    Private Sub txtUsername_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtUsername.KeyPress
        'if enter is pressed, call SubmitUser()

        If (e.KeyChar = ChrW(Keys.Enter)) Then
            SubmitUser()
        End If

    End Sub

    'Handles FormClosing event for this form, called by Application.Exit()
    Private Sub frmStart_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        'Confirm User wants to exit the program

        'Create confirmation MessageBox
        Dim result As DialogResult = DialogResult.None
        result = MessageBox.Show("Are you sure you want to exit?", "Confirm Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)

        'Process user input
        If (result = DialogResult.No) Then
            e.Cancel = True
        Else
            RemoveHandler Me.FormClosing, AddressOf frmStart_FormClosing
            Application.Exit()
        End If

    End Sub

    'Handles btnSearch.Click
    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click

        'note to self - is this where the flicker occurs?
        'show frmSearch
        Search.Show()

        txtPassword.Text = String.Empty
        txtUsername.Text = String.Empty
        'Hides this form
        Hide()

    End Sub

    'Handles KeyDown event for this form
    Private Sub frmStart_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        'Toggles all forms to / from fullscreen when F11 is pressed

        If (e.KeyCode = Keys.F11) Then
            ResizeAllForms()
        End If

    End Sub

    'Handles Load event for this form
    Private Sub frmStart_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'Close startup form, replace with frmStart tracked by Program.vb
        If Not Equals(Start) Then
            RemoveHandler FormClosing, AddressOf frmStart_FormClosing
            Start.Show()
            Close()
        End If

        'sets txtPassword to hide characters input by user
        txtPassword.UseSystemPasswordChar = True

    End Sub
#End Region

End Class
