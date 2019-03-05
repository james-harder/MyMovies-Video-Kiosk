Public Class frmSearch
#Region "Methods"

#End Region
#Region "Event Handlers"
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Application.Exit()
    End Sub
    Private Sub btnPlaceOrder_Click(sender As Object, e As EventArgs) Handles btnPlaceOrder.Click
        frmPlaceOrder.Show()
    End Sub
    Private Sub frmSearch_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Dim result As DialogResult = DialogResult.None
        result = MessageBox.Show("Are you sure you want to exit?", "Confirm Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
        If (result = DialogResult.No) Then
            e.Cancel = True
        End If
    End Sub

#End Region
End Class