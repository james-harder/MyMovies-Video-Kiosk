<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAdminFunctions
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAdminFunctions))
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.TabPage5 = New System.Windows.Forms.TabPage()
        Me.TabPage4 = New System.Windows.Forms.TabPage()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.MyMoviesDBDataSet = New Administrator_Module.MyMoviesDBDataSet()
        Me.MovieBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MovieTableAdapter = New Administrator_Module.MyMoviesDBDataSetTableAdapters.MovieTableAdapter()
        Me.TableAdapterManager = New Administrator_Module.MyMoviesDBDataSetTableAdapters.TableAdapterManager()
        Me.MovieBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.MovieBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.MovieDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CustomerBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CustomerTableAdapter = New Administrator_Module.MyMoviesDBDataSetTableAdapters.CustomerTableAdapter()
        Me.CustomerDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn12 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn13 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn14 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn15 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn16 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DirectorBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DirectorTableAdapter = New Administrator_Module.MyMoviesDBDataSetTableAdapters.DirectorTableAdapter()
        Me.DirectorDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn17 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn18 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn19 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn20 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn21 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ActorBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ActorTableAdapter = New Administrator_Module.MyMoviesDBDataSetTableAdapters.ActorTableAdapter()
        Me.ActorDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn22 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn23 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn24 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn25 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn26 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TabPage5.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        CType(Me.MyMoviesDBDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MovieBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MovieBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MovieBindingNavigator.SuspendLayout()
        CType(Me.MovieDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CustomerBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CustomerDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DirectorBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DirectorDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ActorBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ActorDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(29, 26)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(103, 35)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Insert Movie Info"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(29, 67)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(103, 38)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "Insert Customer Info"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(29, 111)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(103, 37)
        Me.Button3.TabIndex = 2
        Me.Button3.Text = "Insert Director Info"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(29, 154)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(103, 37)
        Me.Button4.TabIndex = 3
        Me.Button4.Text = "Insert Producer Info"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(29, 197)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(103, 37)
        Me.Button5.TabIndex = 4
        Me.Button5.Text = "Insert Actor Info"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'TabPage5
        '
        Me.TabPage5.AutoScroll = True
        Me.TabPage5.Controls.Add(Me.ActorDataGridView)
        Me.TabPage5.Location = New System.Drawing.Point(4, 22)
        Me.TabPage5.Name = "TabPage5"
        Me.TabPage5.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage5.Size = New System.Drawing.Size(633, 364)
        Me.TabPage5.TabIndex = 4
        Me.TabPage5.Text = "Actors"
        Me.TabPage5.UseVisualStyleBackColor = True
        '
        'TabPage4
        '
        Me.TabPage4.Location = New System.Drawing.Point(4, 22)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage4.Size = New System.Drawing.Size(633, 364)
        Me.TabPage4.TabIndex = 3
        Me.TabPage4.Text = "Producers"
        Me.TabPage4.UseVisualStyleBackColor = True
        '
        'TabPage3
        '
        Me.TabPage3.AutoScroll = True
        Me.TabPage3.Controls.Add(Me.DirectorDataGridView)
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(633, 364)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Directors"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'TabPage2
        '
        Me.TabPage2.AutoScroll = True
        Me.TabPage2.Controls.Add(Me.CustomerDataGridView)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(633, 364)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Customers"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'TabPage1
        '
        Me.TabPage1.AutoScroll = True
        Me.TabPage1.Controls.Add(Me.MovieDataGridView)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(403, 364)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Movies"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Controls.Add(Me.TabPage4)
        Me.TabControl1.Controls.Add(Me.TabPage5)
        Me.TabControl1.Location = New System.Drawing.Point(147, 26)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(641, 390)
        Me.TabControl1.TabIndex = 5
        '
        'MyMoviesDBDataSet
        '
        Me.MyMoviesDBDataSet.DataSetName = "MyMoviesDBDataSet"
        Me.MyMoviesDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'MovieBindingSource
        '
        Me.MovieBindingSource.DataMember = "Movie"
        Me.MovieBindingSource.DataSource = Me.MyMoviesDBDataSet
        '
        'MovieTableAdapter
        '
        Me.MovieTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.ActorMovieTableAdapter = Nothing
        Me.TableAdapterManager.ActorTableAdapter = Me.ActorTableAdapter
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.CustomerTableAdapter = Me.CustomerTableAdapter
        Me.TableAdapterManager.DirectorTableAdapter = Me.DirectorTableAdapter
        Me.TableAdapterManager.MovieTableAdapter = Me.MovieTableAdapter
        Me.TableAdapterManager.OrderDetailTableAdapter = Nothing
        Me.TableAdapterManager.OrderTableAdapter = Nothing
        Me.TableAdapterManager.StateTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = Administrator_Module.MyMoviesDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.UserTableAdapter = Nothing
        '
        'MovieBindingNavigator
        '
        Me.MovieBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.MovieBindingNavigator.BindingSource = Me.MovieBindingSource
        Me.MovieBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.MovieBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.MovieBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.MovieBindingNavigatorSaveItem})
        Me.MovieBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.MovieBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.MovieBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.MovieBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.MovieBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.MovieBindingNavigator.Name = "MovieBindingNavigator"
        Me.MovieBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.MovieBindingNavigator.Size = New System.Drawing.Size(800, 25)
        Me.MovieBindingNavigator.TabIndex = 6
        Me.MovieBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveFirstItem.Text = "Move first"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMovePreviousItem.Text = "Move previous"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Position"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 23)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Current position"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(35, 15)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 6)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 20)
        Me.BindingNavigatorMoveNextItem.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 20)
        Me.BindingNavigatorMoveLastItem.Text = "Move last"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 6)
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorAddNewItem.Text = "Add new"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 20)
        Me.BindingNavigatorDeleteItem.Text = "Delete"
        '
        'MovieBindingNavigatorSaveItem
        '
        Me.MovieBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.MovieBindingNavigatorSaveItem.Image = CType(resources.GetObject("MovieBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.MovieBindingNavigatorSaveItem.Name = "MovieBindingNavigatorSaveItem"
        Me.MovieBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 23)
        Me.MovieBindingNavigatorSaveItem.Text = "Save Data"
        '
        'MovieDataGridView
        '
        Me.MovieDataGridView.AutoGenerateColumns = False
        Me.MovieDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.MovieDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.MovieDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4})
        Me.MovieDataGridView.DataSource = Me.MovieBindingSource
        Me.MovieDataGridView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MovieDataGridView.Location = New System.Drawing.Point(3, 3)
        Me.MovieDataGridView.Name = "MovieDataGridView"
        Me.MovieDataGridView.Size = New System.Drawing.Size(397, 358)
        Me.MovieDataGridView.TabIndex = 0
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "MovieID"
        Me.DataGridViewTextBoxColumn1.HeaderText = "MovieID"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "DirectorID"
        Me.DataGridViewTextBoxColumn2.HeaderText = "DirectorID"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Genre"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Genre"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Price"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Price"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'CustomerBindingSource
        '
        Me.CustomerBindingSource.DataMember = "Customer"
        Me.CustomerBindingSource.DataSource = Me.MyMoviesDBDataSet
        '
        'CustomerTableAdapter
        '
        Me.CustomerTableAdapter.ClearBeforeFill = True
        '
        'CustomerDataGridView
        '
        Me.CustomerDataGridView.AutoGenerateColumns = False
        Me.CustomerDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.CustomerDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.CustomerDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn9, Me.DataGridViewTextBoxColumn10, Me.DataGridViewTextBoxColumn11, Me.DataGridViewTextBoxColumn12, Me.DataGridViewTextBoxColumn13, Me.DataGridViewTextBoxColumn14, Me.DataGridViewTextBoxColumn15, Me.DataGridViewTextBoxColumn16})
        Me.CustomerDataGridView.DataSource = Me.CustomerBindingSource
        Me.CustomerDataGridView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CustomerDataGridView.Location = New System.Drawing.Point(3, 3)
        Me.CustomerDataGridView.Name = "CustomerDataGridView"
        Me.CustomerDataGridView.Size = New System.Drawing.Size(627, 358)
        Me.CustomerDataGridView.TabIndex = 0
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "CustomerID"
        Me.DataGridViewTextBoxColumn5.HeaderText = "CustomerID"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "FirstName"
        Me.DataGridViewTextBoxColumn6.HeaderText = "FirstName"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "LastName"
        Me.DataGridViewTextBoxColumn7.HeaderText = "LastName"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "DOB"
        Me.DataGridViewTextBoxColumn8.HeaderText = "DOB"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "Phone"
        Me.DataGridViewTextBoxColumn9.HeaderText = "Phone"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "Email"
        Me.DataGridViewTextBoxColumn10.HeaderText = "Email"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        '
        'DataGridViewTextBoxColumn11
        '
        Me.DataGridViewTextBoxColumn11.DataPropertyName = "Address"
        Me.DataGridViewTextBoxColumn11.HeaderText = "Address"
        Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
        '
        'DataGridViewTextBoxColumn12
        '
        Me.DataGridViewTextBoxColumn12.DataPropertyName = "City"
        Me.DataGridViewTextBoxColumn12.HeaderText = "City"
        Me.DataGridViewTextBoxColumn12.Name = "DataGridViewTextBoxColumn12"
        '
        'DataGridViewTextBoxColumn13
        '
        Me.DataGridViewTextBoxColumn13.DataPropertyName = "State"
        Me.DataGridViewTextBoxColumn13.HeaderText = "State"
        Me.DataGridViewTextBoxColumn13.Name = "DataGridViewTextBoxColumn13"
        '
        'DataGridViewTextBoxColumn14
        '
        Me.DataGridViewTextBoxColumn14.DataPropertyName = "ZipCode"
        Me.DataGridViewTextBoxColumn14.HeaderText = "ZipCode"
        Me.DataGridViewTextBoxColumn14.Name = "DataGridViewTextBoxColumn14"
        '
        'DataGridViewTextBoxColumn15
        '
        Me.DataGridViewTextBoxColumn15.DataPropertyName = "CreditCard"
        Me.DataGridViewTextBoxColumn15.HeaderText = "CreditCard"
        Me.DataGridViewTextBoxColumn15.Name = "DataGridViewTextBoxColumn15"
        '
        'DataGridViewTextBoxColumn16
        '
        Me.DataGridViewTextBoxColumn16.DataPropertyName = "Expiration"
        Me.DataGridViewTextBoxColumn16.HeaderText = "Expiration"
        Me.DataGridViewTextBoxColumn16.Name = "DataGridViewTextBoxColumn16"
        '
        'DirectorBindingSource
        '
        Me.DirectorBindingSource.DataMember = "Director"
        Me.DirectorBindingSource.DataSource = Me.MyMoviesDBDataSet
        '
        'DirectorTableAdapter
        '
        Me.DirectorTableAdapter.ClearBeforeFill = True
        '
        'DirectorDataGridView
        '
        Me.DirectorDataGridView.AutoGenerateColumns = False
        Me.DirectorDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DirectorDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DirectorDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn17, Me.DataGridViewTextBoxColumn18, Me.DataGridViewTextBoxColumn19, Me.DataGridViewTextBoxColumn20, Me.DataGridViewTextBoxColumn21})
        Me.DirectorDataGridView.DataSource = Me.DirectorBindingSource
        Me.DirectorDataGridView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DirectorDataGridView.Location = New System.Drawing.Point(3, 3)
        Me.DirectorDataGridView.Name = "DirectorDataGridView"
        Me.DirectorDataGridView.Size = New System.Drawing.Size(627, 358)
        Me.DirectorDataGridView.TabIndex = 0
        '
        'DataGridViewTextBoxColumn17
        '
        Me.DataGridViewTextBoxColumn17.DataPropertyName = "DirectorID"
        Me.DataGridViewTextBoxColumn17.HeaderText = "DirectorID"
        Me.DataGridViewTextBoxColumn17.Name = "DataGridViewTextBoxColumn17"
        '
        'DataGridViewTextBoxColumn18
        '
        Me.DataGridViewTextBoxColumn18.DataPropertyName = "FirstName"
        Me.DataGridViewTextBoxColumn18.HeaderText = "FirstName"
        Me.DataGridViewTextBoxColumn18.Name = "DataGridViewTextBoxColumn18"
        '
        'DataGridViewTextBoxColumn19
        '
        Me.DataGridViewTextBoxColumn19.DataPropertyName = "LastName"
        Me.DataGridViewTextBoxColumn19.HeaderText = "LastName"
        Me.DataGridViewTextBoxColumn19.Name = "DataGridViewTextBoxColumn19"
        '
        'DataGridViewTextBoxColumn20
        '
        Me.DataGridViewTextBoxColumn20.DataPropertyName = "DOB"
        Me.DataGridViewTextBoxColumn20.HeaderText = "DOB"
        Me.DataGridViewTextBoxColumn20.Name = "DataGridViewTextBoxColumn20"
        '
        'DataGridViewTextBoxColumn21
        '
        Me.DataGridViewTextBoxColumn21.DataPropertyName = "Background"
        Me.DataGridViewTextBoxColumn21.HeaderText = "Background"
        Me.DataGridViewTextBoxColumn21.Name = "DataGridViewTextBoxColumn21"
        '
        'ActorBindingSource
        '
        Me.ActorBindingSource.DataMember = "Actor"
        Me.ActorBindingSource.DataSource = Me.MyMoviesDBDataSet
        '
        'ActorTableAdapter
        '
        Me.ActorTableAdapter.ClearBeforeFill = True
        '
        'ActorDataGridView
        '
        Me.ActorDataGridView.AutoGenerateColumns = False
        Me.ActorDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.ActorDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ActorDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn22, Me.DataGridViewTextBoxColumn23, Me.DataGridViewTextBoxColumn24, Me.DataGridViewTextBoxColumn25, Me.DataGridViewTextBoxColumn26})
        Me.ActorDataGridView.DataSource = Me.ActorBindingSource
        Me.ActorDataGridView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ActorDataGridView.Location = New System.Drawing.Point(3, 3)
        Me.ActorDataGridView.Name = "ActorDataGridView"
        Me.ActorDataGridView.Size = New System.Drawing.Size(627, 358)
        Me.ActorDataGridView.TabIndex = 0
        '
        'DataGridViewTextBoxColumn22
        '
        Me.DataGridViewTextBoxColumn22.DataPropertyName = "ActorID"
        Me.DataGridViewTextBoxColumn22.HeaderText = "ActorID"
        Me.DataGridViewTextBoxColumn22.Name = "DataGridViewTextBoxColumn22"
        '
        'DataGridViewTextBoxColumn23
        '
        Me.DataGridViewTextBoxColumn23.DataPropertyName = "FirstName"
        Me.DataGridViewTextBoxColumn23.HeaderText = "FirstName"
        Me.DataGridViewTextBoxColumn23.Name = "DataGridViewTextBoxColumn23"
        '
        'DataGridViewTextBoxColumn24
        '
        Me.DataGridViewTextBoxColumn24.DataPropertyName = "LastName"
        Me.DataGridViewTextBoxColumn24.HeaderText = "LastName"
        Me.DataGridViewTextBoxColumn24.Name = "DataGridViewTextBoxColumn24"
        '
        'DataGridViewTextBoxColumn25
        '
        Me.DataGridViewTextBoxColumn25.DataPropertyName = "DOB"
        Me.DataGridViewTextBoxColumn25.HeaderText = "DOB"
        Me.DataGridViewTextBoxColumn25.Name = "DataGridViewTextBoxColumn25"
        '
        'DataGridViewTextBoxColumn26
        '
        Me.DataGridViewTextBoxColumn26.DataPropertyName = "Background"
        Me.DataGridViewTextBoxColumn26.HeaderText = "Background"
        Me.DataGridViewTextBoxColumn26.Name = "DataGridViewTextBoxColumn26"
        '
        'frmAdminFunctions
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.MovieBindingNavigator)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Name = "frmAdminFunctions"
        Me.Text = "frmAdminFunctions"
        Me.TabPage5.ResumeLayout(False)
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabControl1.ResumeLayout(False)
        CType(Me.MyMoviesDBDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MovieBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MovieBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MovieBindingNavigator.ResumeLayout(False)
        Me.MovieBindingNavigator.PerformLayout()
        CType(Me.MovieDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CustomerBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CustomerDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DirectorBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DirectorDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ActorBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ActorDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents TabPage5 As TabPage
    Friend WithEvents TabPage4 As TabPage
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents MyMoviesDBDataSet As MyMoviesDBDataSet
    Friend WithEvents MovieBindingSource As BindingSource
    Friend WithEvents MovieTableAdapter As MyMoviesDBDataSetTableAdapters.MovieTableAdapter
    Friend WithEvents TableAdapterManager As MyMoviesDBDataSetTableAdapters.TableAdapterManager
    Friend WithEvents MovieBindingNavigator As BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As ToolStripSeparator
    Friend WithEvents MovieBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents MovieDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents CustomerTableAdapter As MyMoviesDBDataSetTableAdapters.CustomerTableAdapter
    Friend WithEvents CustomerBindingSource As BindingSource
    Friend WithEvents CustomerDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn11 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn12 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn13 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn14 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn15 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn16 As DataGridViewTextBoxColumn
    Friend WithEvents DirectorTableAdapter As MyMoviesDBDataSetTableAdapters.DirectorTableAdapter
    Friend WithEvents DirectorBindingSource As BindingSource
    Friend WithEvents DirectorDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn17 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn18 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn19 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn20 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn21 As DataGridViewTextBoxColumn
    Friend WithEvents ActorTableAdapter As MyMoviesDBDataSetTableAdapters.ActorTableAdapter
    Friend WithEvents ActorBindingSource As BindingSource
    Friend WithEvents ActorDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn22 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn23 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn24 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn25 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn26 As DataGridViewTextBoxColumn
End Class
