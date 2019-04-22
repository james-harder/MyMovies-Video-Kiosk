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
        Dim checkUser As DataRow
        checkUser = tblUser.Select(String.Format("Username = '{0}'", txtUsername.Text)).FirstOrDefault()
        If checkUser Is Nothing Then
            Dim customer As New MyMoviesDBDataSetTableAdapters.CustomerTableAdapter()
            Dim cID As Integer = customer.Insert(txtFirstName.Text, txtLastName.Text, Date.Parse(txtDOB.Text), txtPhone.Text, txtEmail.Text, txtAddress.Text, txtCity.Text,
                            cboState.Text, txtZip.Text, txtCreditCard.Text, txtExpiration.Text)
            users.Insert(txtUsername.Text, txtPassword.Text, 1)
            MessageBox.Show("User Added!")
            'shows parent
            If (ParentForm.Name = "frmStart") Then
                Start.Show()
            Else
                PlaceOrder.Show()
            End If

            'Hides this form
            Hide()
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
    End Sub
#End Region
End Class