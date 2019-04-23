Public Class frmAdminFunctions
    Private Sub MovieBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles MovieBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.MovieBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.MyMoviesDBDataSet)

    End Sub

    Private Sub frmAdminFunctions_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'MyMoviesDBDataSet.Actor' table. You can move, or remove it, as needed.
        Me.ActorTableAdapter.Fill(Me.MyMoviesDBDataSet.Actor)
        'TODO: This line of code loads data into the 'MyMoviesDBDataSet.Director' table. You can move, or remove it, as needed.
        Me.DirectorTableAdapter.Fill(Me.MyMoviesDBDataSet.Director)
        'TODO: This line of code loads data into the 'MyMoviesDBDataSet.Customer' table. You can move, or remove it, as needed.
        Me.CustomerTableAdapter.Fill(Me.MyMoviesDBDataSet.Customer)
        'TODO: This line of code loads data into the 'MyMoviesDBDataSet.Movie' table. You can move, or remove it, as needed.
        Me.MovieTableAdapter.Fill(Me.MyMoviesDBDataSet.Movie)

    End Sub
End Class