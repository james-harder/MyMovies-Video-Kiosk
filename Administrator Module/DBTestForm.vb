Public Class DBTestForm
    Private Sub TableBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles TableBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.TableBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.MyMoviesDBDataSet)

    End Sub

    Private Sub DBTestForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'MyMoviesDBDataSet.Table' table. You can move, or remove it, as needed.
        Me.TableTableAdapter.Fill(Me.MyMoviesDBDataSet.Table)

    End Sub
End Class