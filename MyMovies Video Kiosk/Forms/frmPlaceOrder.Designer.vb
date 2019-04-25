<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPlaceOrder))
        Me.lstItems = New System.Windows.Forms.ListBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btnPlaceOrder = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtExpiry = New System.Windows.Forms.MaskedTextBox()
        Me.txtCreditCard = New System.Windows.Forms.TextBox()
        Me.txtSecurityCode = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.cboCardCarrier = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'lstItems
        '
        Me.lstItems.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lstItems.Font = New System.Drawing.Font("Nirmala UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstItems.FormattingEnabled = True
        Me.lstItems.ItemHeight = 30
        Me.lstItems.Location = New System.Drawing.Point(96, 321)
        Me.lstItems.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.lstItems.Name = "lstItems"
        Me.lstItems.Size = New System.Drawing.Size(674, 304)
        Me.lstItems.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Nirmala UI", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(526, 190)
        Me.Label1.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(385, 86)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Place Order"
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Nirmala UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(90, 283)
        Me.Label2.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(189, 36)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Selected Items:"
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Nirmala UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(1200, 331)
        Me.Label3.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(75, 36)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Total:"
        '
        'Label4
        '
        Me.Label4.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label4.Font = New System.Drawing.Font("Nirmala UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(1290, 333)
        Me.Label4.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(154, 37)
        Me.Label4.TabIndex = 4
        '
        'Label5
        '
        Me.Label5.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label5.Font = New System.Drawing.Font("Nirmala UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(786, 402)
        Me.Label5.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(182, 35)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Credit Card:"
        '
        'Label6
        '
        Me.Label6.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Nirmala UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(786, 479)
        Me.Label6.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(151, 36)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "Expiry Date:"
        '
        'btnPlaceOrder
        '
        Me.btnPlaceOrder.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnPlaceOrder.Font = New System.Drawing.Font("Nirmala UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPlaceOrder.Location = New System.Drawing.Point(1254, 602)
        Me.btnPlaceOrder.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.btnPlaceOrder.Name = "btnPlaceOrder"
        Me.btnPlaceOrder.Size = New System.Drawing.Size(192, 52)
        Me.btnPlaceOrder.TabIndex = 7
        Me.btnPlaceOrder.Text = "Place Order"
        Me.btnPlaceOrder.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnCancel.Font = New System.Drawing.Font("Nirmala UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.Location = New System.Drawing.Point(1050, 602)
        Me.btnCancel.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(192, 52)
        Me.btnCancel.TabIndex = 8
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Nirmala UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(1096, 479)
        Me.Label7.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(180, 36)
        Me.Label7.TabIndex = 11
        Me.Label7.Text = "Security Code:"
        '
        'txtExpiry
        '
        Me.txtExpiry.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtExpiry.Font = New System.Drawing.Font("Nirmala UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtExpiry.Location = New System.Drawing.Point(950, 473)
        Me.txtExpiry.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.txtExpiry.Mask = "00/00"
        Me.txtExpiry.Name = "txtExpiry"
        Me.txtExpiry.Size = New System.Drawing.Size(72, 37)
        Me.txtExpiry.TabIndex = 15
        Me.txtExpiry.ValidatingType = GetType(Date)
        '
        'txtCreditCard
        '
        Me.txtCreditCard.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtCreditCard.Font = New System.Drawing.Font("Nirmala UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCreditCard.Location = New System.Drawing.Point(950, 398)
        Me.txtCreditCard.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.txtCreditCard.MaxLength = 16
        Me.txtCreditCard.Name = "txtCreditCard"
        Me.txtCreditCard.Size = New System.Drawing.Size(492, 37)
        Me.txtCreditCard.TabIndex = 16
        '
        'txtSecurityCode
        '
        Me.txtSecurityCode.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtSecurityCode.Font = New System.Drawing.Font("Nirmala UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSecurityCode.Location = New System.Drawing.Point(1290, 473)
        Me.txtSecurityCode.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.txtSecurityCode.MaxLength = 4
        Me.txtSecurityCode.Name = "txtSecurityCode"
        Me.txtSecurityCode.Size = New System.Drawing.Size(152, 37)
        Me.txtSecurityCode.TabIndex = 17
        '
        'Label8
        '
        Me.Label8.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label8.Font = New System.Drawing.Font("Nirmala UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(786, 329)
        Me.Label8.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(182, 35)
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
        Me.cboCardCarrier.Location = New System.Drawing.Point(950, 327)
        Me.cboCardCarrier.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.cboCardCarrier.Name = "cboCardCarrier"
        Me.cboCardCarrier.Size = New System.Drawing.Size(226, 38)
        Me.cboCardCarrier.TabIndex = 19
        '
        'frmPlaceOrder
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(197, Byte), Integer))
        Me.BackgroundImage = Global.MyMovies_Video_Kiosk.My.Resources.Resources.Film_Reel_Red
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1500, 904)
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
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lstItems)
        Me.DoubleBuffered = True
        Me.ForeColor = System.Drawing.SystemColors.ControlText
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.Name = "frmPlaceOrder"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmPlaceOrder"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lstItems As ListBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
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
End Class
