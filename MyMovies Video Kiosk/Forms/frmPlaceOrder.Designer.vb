﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPlaceOrder
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPlaceOrder))
        Me.lstItems = New System.Windows.Forms.ListBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btnPlaceOrder = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtExpiry = New System.Windows.Forms.MaskedTextBox()
        Me.CustomerBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MyMoviesDBDataSet = New MyMovies_Video_Kiosk.MyMoviesDBDataSet()
        Me.txtCreditCard = New System.Windows.Forms.TextBox()
        Me.txtSecurityCode = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.cboCardCarrier = New System.Windows.Forms.ComboBox()
        Me.CustomerTableAdapter = New MyMovies_Video_Kiosk.MyMoviesDBDataSetTableAdapters.CustomerTableAdapter()
        Me.TableAdapterManager = New MyMovies_Video_Kiosk.MyMoviesDBDataSetTableAdapters.TableAdapterManager()
        CType(Me.CustomerBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MyMoviesDBDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lstItems
        '
        Me.lstItems.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lstItems.Font = New System.Drawing.Font("Nirmala UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstItems.FormattingEnabled = True
        Me.lstItems.Location = New System.Drawing.Point(48, 167)
        Me.lstItems.Name = "lstItems"
        Me.lstItems.Size = New System.Drawing.Size(339, 160)
        Me.lstItems.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Nirmala UI", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(263, 99)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(194, 45)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Place Order"
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Nirmala UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(45, 147)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(95, 17)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Selected Items:"
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Nirmala UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(600, 172)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(39, 17)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Total:"
        '
        'lblTotal
        '
        Me.lblTotal.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblTotal.Font = New System.Drawing.Font("Nirmala UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotal.Location = New System.Drawing.Point(645, 173)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(78, 20)
        Me.lblTotal.TabIndex = 4
        '
        'Label5
        '
        Me.Label5.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label5.Font = New System.Drawing.Font("Nirmala UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(393, 209)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(91, 18)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Credit Card:"
        '
        'Label6
        '
        Me.Label6.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Nirmala UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(393, 249)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(78, 17)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "Expiry Date:"
        '
        'btnPlaceOrder
        '
        Me.btnPlaceOrder.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnPlaceOrder.Font = New System.Drawing.Font("Nirmala UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPlaceOrder.Location = New System.Drawing.Point(627, 313)
        Me.btnPlaceOrder.Name = "btnPlaceOrder"
        Me.btnPlaceOrder.Size = New System.Drawing.Size(96, 27)
        Me.btnPlaceOrder.TabIndex = 5
        Me.btnPlaceOrder.Text = "Place Order"
        Me.btnPlaceOrder.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnCancel.Font = New System.Drawing.Font("Nirmala UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.Location = New System.Drawing.Point(525, 313)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(96, 27)
        Me.btnCancel.TabIndex = 8
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Nirmala UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(548, 249)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(91, 17)
        Me.Label7.TabIndex = 11
        Me.Label7.Text = "Security Code:"
        '
        'txtExpiry
        '
        Me.txtExpiry.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtExpiry.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomerBindingSource, "Expiration", True))
        Me.txtExpiry.Font = New System.Drawing.Font("Nirmala UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtExpiry.Location = New System.Drawing.Point(475, 246)
        Me.txtExpiry.Name = "txtExpiry"
        Me.txtExpiry.Size = New System.Drawing.Size(55, 22)
        Me.txtExpiry.TabIndex = 3
        Me.txtExpiry.ValidatingType = GetType(Date)
        '
        'CustomerBindingSource
        '
        Me.CustomerBindingSource.DataMember = "Customer"
        Me.CustomerBindingSource.DataSource = Me.MyMoviesDBDataSet
        '
        'MyMoviesDBDataSet
        '
        Me.MyMoviesDBDataSet.DataSetName = "MyMoviesDBDataSet"
        Me.MyMoviesDBDataSet.EnforceConstraints = False
        Me.MyMoviesDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'txtCreditCard
        '
        Me.txtCreditCard.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtCreditCard.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomerBindingSource, "CreditCard", True))
        Me.txtCreditCard.Font = New System.Drawing.Font("Nirmala UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCreditCard.Location = New System.Drawing.Point(475, 207)
        Me.txtCreditCard.MaxLength = 16
        Me.txtCreditCard.Name = "txtCreditCard"
        Me.txtCreditCard.Size = New System.Drawing.Size(248, 22)
        Me.txtCreditCard.TabIndex = 2
        '
        'txtSecurityCode
        '
        Me.txtSecurityCode.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtSecurityCode.Font = New System.Drawing.Font("Nirmala UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSecurityCode.Location = New System.Drawing.Point(645, 246)
        Me.txtSecurityCode.MaxLength = 4
        Me.txtSecurityCode.Name = "txtSecurityCode"
        Me.txtSecurityCode.Size = New System.Drawing.Size(78, 22)
        Me.txtSecurityCode.TabIndex = 4
        '
        'Label8
        '
        Me.Label8.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label8.Font = New System.Drawing.Font("Nirmala UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(393, 171)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(91, 18)
        Me.Label8.TabIndex = 18
        Me.Label8.Text = "Card Type:"
        '
        'cboCardCarrier
        '
        Me.cboCardCarrier.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.cboCardCarrier.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboCardCarrier.Font = New System.Drawing.Font("Nirmala UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboCardCarrier.FormattingEnabled = True
        Me.cboCardCarrier.Items.AddRange(New Object() {"Visa", "Mastercard", "American Express"})
        Me.cboCardCarrier.Location = New System.Drawing.Point(475, 170)
        Me.cboCardCarrier.Name = "cboCardCarrier"
        Me.cboCardCarrier.Size = New System.Drawing.Size(115, 21)
        Me.cboCardCarrier.TabIndex = 1
        '
        'CustomerTableAdapter
        '
        Me.CustomerTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.ActorMovieTableAdapter = Nothing
        Me.TableAdapterManager.ActorTableAdapter = Nothing
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.CustomerTableAdapter = Me.CustomerTableAdapter
        Me.TableAdapterManager.DirectorTableAdapter = Nothing
        Me.TableAdapterManager.MovieTableAdapter = Nothing
        Me.TableAdapterManager.OrderDetailTableAdapter = Nothing
        Me.TableAdapterManager.OrderTableAdapter = Nothing
        Me.TableAdapterManager.StateTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = MyMovies_Video_Kiosk.MyMoviesDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.UserTableAdapter = Nothing
        '
        'frmPlaceOrder
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(197, Byte), Integer))
        Me.BackgroundImage = Global.MyMovies_Video_Kiosk.My.Resources.Resources.Film_Reel_Red
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(750, 470)
        Me.Controls.Add(Me.cboCardCarrier)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txtSecurityCode)
        Me.Controls.Add(Me.txtCreditCard)
        Me.Controls.Add(Me.txtExpiry)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnPlaceOrder)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.lblTotal)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lstItems)
        Me.DoubleBuffered = True
        Me.ForeColor = System.Drawing.SystemColors.ControlText
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Name = "frmPlaceOrder"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmPlaceOrder"
        CType(Me.CustomerBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MyMoviesDBDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lstItems As ListBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents lblTotal As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents btnPlaceOrder As Button
    Friend WithEvents btnCancel As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents txtExpiry As MaskedTextBox
    Friend WithEvents txtCreditCard As TextBox
    Friend WithEvents txtSecurityCode As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents cboCardCarrier As ComboBox
    Friend WithEvents MyMoviesDBDataSet As MyMoviesDBDataSet
    Friend WithEvents CustomerBindingSource As BindingSource
    Friend WithEvents CustomerTableAdapter As MyMoviesDBDataSetTableAdapters.CustomerTableAdapter
    Friend WithEvents TableAdapterManager As MyMoviesDBDataSetTableAdapters.TableAdapterManager
End Class
