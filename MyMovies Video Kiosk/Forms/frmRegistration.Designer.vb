<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmRegistration
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmRegistration))
        Me.btnSubmit = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txtFirstName = New System.Windows.Forms.TextBox()
        Me.txtLastName = New System.Windows.Forms.TextBox()
        Me.txtAddress = New System.Windows.Forms.TextBox()
        Me.txtCity = New System.Windows.Forms.TextBox()
        Me.txtZip = New System.Windows.Forms.TextBox()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.txtPhone = New System.Windows.Forms.TextBox()
        Me.txtExpiration = New System.Windows.Forms.MaskedTextBox()
        Me.txtDOB = New System.Windows.Forms.MaskedTextBox()
        Me.txtCreditCard = New System.Windows.Forms.MaskedTextBox()
        Me.cboState = New System.Windows.Forms.ComboBox()
        Me.StateBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MyMoviesDBDataSet = New MyMovies_Video_Kiosk.MyMoviesDBDataSet()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.txtUsername = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.StateTableAdapter = New MyMovies_Video_Kiosk.MyMoviesDBDataSetTableAdapters.StateTableAdapter()
        Me.TableAdapterManager = New MyMovies_Video_Kiosk.MyMoviesDBDataSetTableAdapters.TableAdapterManager()
        CType(Me.StateBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MyMoviesDBDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnSubmit
        '
        Me.btnSubmit.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnSubmit.Font = New System.Drawing.Font("Nirmala UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSubmit.Location = New System.Drawing.Point(644, 335)
        Me.btnSubmit.Name = "btnSubmit"
        Me.btnSubmit.Size = New System.Drawing.Size(83, 28)
        Me.btnSubmit.TabIndex = 13
        Me.btnSubmit.Text = "Submit"
        Me.btnSubmit.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnClear.Font = New System.Drawing.Font("Nirmala UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.Location = New System.Drawing.Point(555, 335)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(83, 28)
        Me.btnClear.TabIndex = 14
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnCancel.Font = New System.Drawing.Font("Nirmala UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.Location = New System.Drawing.Point(466, 335)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(83, 28)
        Me.btnCancel.TabIndex = 15
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Nirmala UI", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(263, 100)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(202, 45)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Registration"
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Nirmala UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(35, 167)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(74, 17)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "First Name:"
        '
        'Label6
        '
        Me.Label6.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Nirmala UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(35, 200)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(73, 17)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "Last Name:"
        '
        'Label7
        '
        Me.Label7.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Nirmala UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(305, 200)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(32, 17)
        Me.Label7.TabIndex = 9
        Me.Label7.Text = "City:"
        '
        'Label8
        '
        Me.Label8.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Nirmala UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(305, 232)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(29, 17)
        Me.Label8.TabIndex = 10
        Me.Label8.Text = "Zip:"
        '
        'Label9
        '
        Me.Label9.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Nirmala UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(35, 299)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(42, 17)
        Me.Label9.TabIndex = 11
        Me.Label9.Text = "Email:"
        '
        'Label10
        '
        Me.Label10.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Nirmala UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(305, 299)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(69, 17)
        Me.Label10.TabIndex = 12
        Me.Label10.Text = "Expiration:"
        '
        'Label11
        '
        Me.Label11.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Nirmala UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(35, 233)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(37, 17)
        Me.Label11.TabIndex = 13
        Me.Label11.Text = "DOB:"
        '
        'Label12
        '
        Me.Label12.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Nirmala UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(516, 200)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(40, 17)
        Me.Label12.TabIndex = 14
        Me.Label12.Text = "State:"
        '
        'Label13
        '
        Me.Label13.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Nirmala UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(305, 167)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(59, 17)
        Me.Label13.TabIndex = 15
        Me.Label13.Text = "Address:"
        '
        'Label14
        '
        Me.Label14.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Nirmala UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(35, 267)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(47, 17)
        Me.Label14.TabIndex = 16
        Me.Label14.Text = "Phone:"
        '
        'Label15
        '
        Me.Label15.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Nirmala UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(305, 267)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(78, 17)
        Me.Label15.TabIndex = 17
        Me.Label15.Text = "Credit Card:"
        '
        'txtFirstName
        '
        Me.txtFirstName.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtFirstName.Font = New System.Drawing.Font("Nirmala UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFirstName.Location = New System.Drawing.Point(115, 167)
        Me.txtFirstName.Name = "txtFirstName"
        Me.txtFirstName.Size = New System.Drawing.Size(153, 22)
        Me.txtFirstName.TabIndex = 0
        '
        'txtLastName
        '
        Me.txtLastName.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtLastName.Font = New System.Drawing.Font("Nirmala UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLastName.Location = New System.Drawing.Point(115, 200)
        Me.txtLastName.Name = "txtLastName"
        Me.txtLastName.Size = New System.Drawing.Size(153, 22)
        Me.txtLastName.TabIndex = 1
        '
        'txtAddress
        '
        Me.txtAddress.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtAddress.Font = New System.Drawing.Font("Nirmala UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAddress.Location = New System.Drawing.Point(384, 167)
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.Size = New System.Drawing.Size(220, 22)
        Me.txtAddress.TabIndex = 5
        '
        'txtCity
        '
        Me.txtCity.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtCity.Font = New System.Drawing.Font("Nirmala UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCity.Location = New System.Drawing.Point(384, 200)
        Me.txtCity.Name = "txtCity"
        Me.txtCity.Size = New System.Drawing.Size(118, 22)
        Me.txtCity.TabIndex = 6
        '
        'txtZip
        '
        Me.txtZip.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtZip.Font = New System.Drawing.Font("Nirmala UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtZip.Location = New System.Drawing.Point(384, 233)
        Me.txtZip.Name = "txtZip"
        Me.txtZip.Size = New System.Drawing.Size(72, 22)
        Me.txtZip.TabIndex = 8
        '
        'txtEmail
        '
        Me.txtEmail.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtEmail.Font = New System.Drawing.Font("Nirmala UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEmail.Location = New System.Drawing.Point(115, 299)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(153, 22)
        Me.txtEmail.TabIndex = 4
        '
        'txtPhone
        '
        Me.txtPhone.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtPhone.Font = New System.Drawing.Font("Nirmala UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPhone.Location = New System.Drawing.Point(115, 265)
        Me.txtPhone.Name = "txtPhone"
        Me.txtPhone.Size = New System.Drawing.Size(153, 22)
        Me.txtPhone.TabIndex = 3
        '
        'txtExpiration
        '
        Me.txtExpiration.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtExpiration.Font = New System.Drawing.Font("Nirmala UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtExpiration.Location = New System.Drawing.Point(384, 299)
        Me.txtExpiration.Mask = "00/0000"
        Me.txtExpiration.Name = "txtExpiration"
        Me.txtExpiration.Size = New System.Drawing.Size(48, 22)
        Me.txtExpiration.TabIndex = 10
        Me.txtExpiration.ValidatingType = GetType(Date)
        '
        'txtDOB
        '
        Me.txtDOB.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtDOB.Font = New System.Drawing.Font("Nirmala UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDOB.Location = New System.Drawing.Point(115, 233)
        Me.txtDOB.Mask = "00/00/0000"
        Me.txtDOB.Name = "txtDOB"
        Me.txtDOB.Size = New System.Drawing.Size(61, 22)
        Me.txtDOB.TabIndex = 2
        Me.txtDOB.ValidatingType = GetType(Date)
        '
        'txtCreditCard
        '
        Me.txtCreditCard.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtCreditCard.Font = New System.Drawing.Font("Nirmala UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCreditCard.Location = New System.Drawing.Point(384, 265)
        Me.txtCreditCard.Mask = "0000 0000 0000 0000"
        Me.txtCreditCard.Name = "txtCreditCard"
        Me.txtCreditCard.Size = New System.Drawing.Size(109, 22)
        Me.txtCreditCard.TabIndex = 9
        Me.txtCreditCard.ValidatingType = GetType(Date)
        '
        'cboState
        '
        Me.cboState.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.cboState.DataSource = Me.StateBindingSource
        Me.cboState.DisplayMember = "Abbreviation"
        Me.cboState.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboState.Font = New System.Drawing.Font("Nirmala UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboState.FormattingEnabled = True
        Me.cboState.Location = New System.Drawing.Point(562, 200)
        Me.cboState.Name = "cboState"
        Me.cboState.Size = New System.Drawing.Size(42, 21)
        Me.cboState.TabIndex = 7
        Me.cboState.ValueMember = "Abbreviation"
        '
        'StateBindingSource
        '
        Me.StateBindingSource.DataMember = "State"
        Me.StateBindingSource.DataSource = Me.MyMoviesDBDataSet
        '
        'MyMoviesDBDataSet
        '
        Me.MyMoviesDBDataSet.DataSetName = "MyMoviesDBDataSet"
        Me.MyMoviesDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'txtPassword
        '
        Me.txtPassword.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtPassword.Font = New System.Drawing.Font("Nirmala UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPassword.Location = New System.Drawing.Point(621, 299)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.Size = New System.Drawing.Size(106, 22)
        Me.txtPassword.TabIndex = 12
        '
        'txtUsername
        '
        Me.txtUsername.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtUsername.Font = New System.Drawing.Font("Nirmala UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUsername.Location = New System.Drawing.Point(621, 265)
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.Size = New System.Drawing.Size(106, 22)
        Me.txtUsername.TabIndex = 11
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Nirmala UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(541, 300)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(67, 17)
        Me.Label3.TabIndex = 33
        Me.Label3.Text = "Password:"
        '
        'Label4
        '
        Me.Label4.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Nirmala UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(541, 267)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(70, 17)
        Me.Label4.TabIndex = 32
        Me.Label4.Text = "Username:"
        '
        'StateTableAdapter
        '
        Me.StateTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.ActorMovieTableAdapter = Nothing
        Me.TableAdapterManager.ActorTableAdapter = Nothing
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.CustomerTableAdapter = Nothing
        Me.TableAdapterManager.DirectorTableAdapter = Nothing
        Me.TableAdapterManager.MovieTableAdapter = Nothing
        Me.TableAdapterManager.OrderDetailTableAdapter = Nothing
        Me.TableAdapterManager.OrderTableAdapter = Nothing
        Me.TableAdapterManager.StateTableAdapter = Me.StateTableAdapter
        Me.TableAdapterManager.UpdateOrder = MyMovies_Video_Kiosk.MyMoviesDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.UserTableAdapter = Nothing
        '
        'frmRegistration
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(130, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(181, Byte), Integer))
        Me.BackgroundImage = Global.MyMovies_Video_Kiosk.My.Resources.Resources.Film_Reel_Green
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(750, 470)
        Me.Controls.Add(Me.txtPassword)
        Me.Controls.Add(Me.txtUsername)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.cboState)
        Me.Controls.Add(Me.txtCreditCard)
        Me.Controls.Add(Me.txtDOB)
        Me.Controls.Add(Me.txtExpiration)
        Me.Controls.Add(Me.txtPhone)
        Me.Controls.Add(Me.txtEmail)
        Me.Controls.Add(Me.txtZip)
        Me.Controls.Add(Me.txtCity)
        Me.Controls.Add(Me.txtAddress)
        Me.Controls.Add(Me.txtLastName)
        Me.Controls.Add(Me.txtFirstName)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnSubmit)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Name = "frmRegistration"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmRegistration"
        CType(Me.StateBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MyMoviesDBDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnSubmit As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btnCancel As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents txtFirstName As TextBox
    Friend WithEvents txtLastName As TextBox
    Friend WithEvents txtAddress As TextBox
    Friend WithEvents txtCity As TextBox
    Friend WithEvents txtZip As TextBox
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents txtPhone As TextBox
    Friend WithEvents txtExpiration As MaskedTextBox
    Friend WithEvents txtDOB As MaskedTextBox
    Friend WithEvents txtCreditCard As MaskedTextBox
    Friend WithEvents cboState As ComboBox
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents txtUsername As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents MyMoviesDBDataSet As MyMoviesDBDataSet
    Friend WithEvents StateBindingSource As BindingSource
    Friend WithEvents StateTableAdapter As MyMoviesDBDataSetTableAdapters.StateTableAdapter
    Friend WithEvents TableAdapterManager As MyMoviesDBDataSetTableAdapters.TableAdapterManager
End Class
