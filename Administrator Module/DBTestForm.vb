Public Class DBTestForm
    'Used for testing methods and functionality against the DB

#Region "Properties"



#End Region

#Region "Methods"



#End Region

#Region "Event Handlers"

    Private Sub TableBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles TableBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.TableBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.MyMoviesDBDataSet)

    End Sub

    Private Sub DBTestForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'MyMoviesDBDataSet.Table' table. You can move, or remove it, as needed.
        Me.TableTableAdapter.Fill(Me.MyMoviesDBDataSet.Table)

    End Sub

#End Region

End Class