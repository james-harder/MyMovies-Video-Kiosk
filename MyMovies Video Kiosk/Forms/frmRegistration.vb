Public Class frmRegistration
#Region "Properties"

    'Allows this form to reference and return to parent form
    Private Overloads Property ParentForm() As Form

#End Region

#Region "Methods"
    '?Overload Show() method to include parent argument?
    Public Overloads Sub Show(parent As Form)

        ParentForm = parent
        MyBase.Show()

    End Sub

#End Region

#Region "Event Handlers"

    'Handles btnSubmit Click
    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        'Validate inputs and add new user to DB
        Dim users As New MyMoviesDBDataSetTableAdapters.UserTableAdapter()
        Dim tblUser As New MyMoviesDBDataSet.UserDataTable()
        users.Fill(tblUser)

        Dim user As String = If(CheckForSQL(txtUsername.Text), "ERROR USER ATTEMPTED SQL INJECTION", txtUsername.Text)
        Dim pwd As String = txtPassword.Text
        If user.Equals("ERROR USER ATTEMPTED SQL INJECTION") Then
            MessageBox.Show("SQL Injection Attempt Detected.", "Error: Closing Application", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error)
            Application.Exit()
        End If
        Dim checkUser As DataRow
        checkUser = tblUser.Select(String.Format("Username = '{0}'", user.ToUpper)).FirstOrDefault()
        If checkUser Is Nothing Then
            'This block can be used to selectively validate inserted fields
            Dim customer As New MyMoviesDBDataSetTableAdapters.CustomerTableAdapter()
            Dim firstName As String = txtFirstName.Text
            Dim lastName As String = txtLastName.Text
            Dim phone As String = txtPhone.Text
            Dim email As String = txtEmail.Text
            Dim address As String = txtAddress.Text
            Dim city As String = txtCity.Text
            Dim zip As String = txtZip.Text
            Dim DOB As Date
            Date.TryParse(txtDOB.Text, DOB)
            Dim expiration As Date
            Date.TryParse(txtExpiration.Text, expiration)
            Dim CC As String = txtCreditCard.Text
            Dim state As String = cboState.Text

            Dim CreateTime As Date = DateTime.Now
            customer.Insert(firstName, lastName, DOB, phone, email, address, city, state, zip, CC, expiration, CreateTime)
            Dim tblCustomer As New MyMoviesDBDataSet.CustomerDataTable()
            customer.Fill(tblCustomer)

            Dim row As DataRow = (From r As DataRow In tblCustomer.Rows Where r(12).ToString().Equals(CreateTime.ToString()) Select r).Single()
            users.Insert(txtUsername.Text.ToUpper, txtPassword.Text, CType(row, MyMoviesDBDataSet.CustomerRow).CustomerID)

            UserID = CType(row, MyMoviesDBDataSet.CustomerRow).CustomerID
            MessageBox.Show("User Added!")

            'shows parent
            If (ParentForm.Name = "frmStart") Then
                Start.Show()
            Else
                PlaceOrder.Show()
            End If

            'closes this form
            Close()
        Else
            MessageBox.Show("Username already taken.")
        End If



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

        'Hides this form
        Hide()

    End Sub

    Private Sub frmRegistration_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        'Toggles all forms to / from fullscreen when F11 is pressed

        If (e.KeyCode = Keys.F11) Then
            ResizeAllForms()
        End If

    End Sub

    Private Sub frmRegistration_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'MyMoviesDBDataSet.State' table. You can move, or remove it, as needed.
        Me.StateTableAdapter.Fill(Me.MyMoviesDBDataSet.State)
        txtPassword.UseSystemPasswordChar = True
    End Sub
#End Region
End Class