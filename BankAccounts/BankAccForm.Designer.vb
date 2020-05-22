<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BankAccForm
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
        Me.btnCreate = New System.Windows.Forms.Button()
        Me.btnDeposit = New System.Windows.Forms.Button()
        Me.btnWithdraw = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.lblAccountName = New System.Windows.Forms.Label()
        Me.lblAccNum = New System.Windows.Forms.Label()
        Me.lblCountryO = New System.Windows.Forms.Label()
        Me.lblBalance = New System.Windows.Forms.Label()
        Me.lblIntRate = New System.Windows.Forms.Label()
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
        Me.TextBox6 = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'btnCreate
        '
        Me.btnCreate.Location = New System.Drawing.Point(201, 0)
        Me.btnCreate.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnCreate.Name = "btnCreate"
        Me.btnCreate.Size = New System.Drawing.Size(183, 32)
        Me.btnCreate.TabIndex = 0
        Me.btnCreate.Text = "Create Account"
        Me.btnCreate.UseVisualStyleBackColor = True
        '
        'btnDeposit
        '
        Me.btnDeposit.Location = New System.Drawing.Point(389, 0)
        Me.btnDeposit.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnDeposit.Name = "btnDeposit"
        Me.btnDeposit.Size = New System.Drawing.Size(207, 32)
        Me.btnDeposit.TabIndex = 2
        Me.btnDeposit.Text = "Deposit"
        Me.btnDeposit.UseVisualStyleBackColor = True
        '
        'btnWithdraw
        '
        Me.btnWithdraw.Location = New System.Drawing.Point(603, 0)
        Me.btnWithdraw.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnWithdraw.Name = "btnWithdraw"
        Me.btnWithdraw.Size = New System.Drawing.Size(197, 32)
        Me.btnWithdraw.TabIndex = 3
        Me.btnWithdraw.Text = "Withdraw"
        Me.btnWithdraw.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(3, 0)
        Me.btnExit.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(192, 32)
        Me.btnExit.TabIndex = 4
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(3, 171)
        Me.TextBox1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(192, 22)
        Me.TextBox1.TabIndex = 5
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(3, 284)
        Me.TextBox2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(192, 22)
        Me.TextBox2.TabIndex = 6
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(3, 59)
        Me.TextBox3.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(192, 22)
        Me.TextBox3.TabIndex = 7
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(3, 399)
        Me.TextBox4.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(192, 22)
        Me.TextBox4.TabIndex = 8
        '
        'TextBox5
        '
        Me.TextBox5.Location = New System.Drawing.Point(3, 518)
        Me.TextBox5.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(192, 22)
        Me.TextBox5.TabIndex = 9
        Me.TextBox5.Text = "z"
        '
        'lblAccountName
        '
        Me.lblAccountName.AutoSize = True
        Me.lblAccountName.Location = New System.Drawing.Point(21, 39)
        Me.lblAccountName.Name = "lblAccountName"
        Me.lblAccountName.Size = New System.Drawing.Size(160, 17)
        Me.lblAccountName.TabIndex = 10
        Me.lblAccountName.Text = "Account Holder's Name:"
        '
        'lblAccNum
        '
        Me.lblAccNum.AutoSize = True
        Me.lblAccNum.Location = New System.Drawing.Point(37, 151)
        Me.lblAccNum.Name = "lblAccNum"
        Me.lblAccNum.Size = New System.Drawing.Size(117, 17)
        Me.lblAccNum.TabIndex = 11
        Me.lblAccNum.Text = "Account Number:"
        '
        'lblCountryO
        '
        Me.lblCountryO.AutoSize = True
        Me.lblCountryO.Location = New System.Drawing.Point(39, 264)
        Me.lblCountryO.Name = "lblCountryO"
        Me.lblCountryO.Size = New System.Drawing.Size(119, 17)
        Me.lblCountryO.TabIndex = 12
        Me.lblCountryO.Text = "Country of Origin:"
        '
        'lblBalance
        '
        Me.lblBalance.AutoSize = True
        Me.lblBalance.Location = New System.Drawing.Point(69, 380)
        Me.lblBalance.Name = "lblBalance"
        Me.lblBalance.Size = New System.Drawing.Size(63, 17)
        Me.lblBalance.TabIndex = 13
        Me.lblBalance.Text = "Balance:"
        '
        'lblIntRate
        '
        Me.lblIntRate.AutoSize = True
        Me.lblIntRate.Location = New System.Drawing.Point(49, 498)
        Me.lblIntRate.Name = "lblIntRate"
        Me.lblIntRate.Size = New System.Drawing.Size(93, 17)
        Me.lblIntRate.TabIndex = 14
        Me.lblIntRate.Text = "Interest Rate:"
        '
        'RichTextBox1
        '
        Me.RichTextBox1.Location = New System.Drawing.Point(203, 59)
        Me.RichTextBox1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.Size = New System.Drawing.Size(0, 0)
        Me.RichTextBox1.TabIndex = 15
        Me.RichTextBox1.Text = ""
        '
        'TextBox6
        '
        Me.TextBox6.Location = New System.Drawing.Point(205, 59)
        Me.TextBox6.Multiline = True
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New System.Drawing.Size(594, 481)
        Me.TextBox6.TabIndex = 16
        '
        'BankAccForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(805, 576)
        Me.Controls.Add(Me.TextBox6)
        Me.Controls.Add(Me.RichTextBox1)
        Me.Controls.Add(Me.lblIntRate)
        Me.Controls.Add(Me.lblBalance)
        Me.Controls.Add(Me.lblCountryO)
        Me.Controls.Add(Me.lblAccNum)
        Me.Controls.Add(Me.lblAccountName)
        Me.Controls.Add(Me.TextBox5)
        Me.Controls.Add(Me.TextBox4)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnWithdraw)
        Me.Controls.Add(Me.btnDeposit)
        Me.Controls.Add(Me.btnCreate)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "BankAccForm"
        Me.Text = "BankAccForm"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnCreate As Windows.Forms.Button
    Friend WithEvents btnDeposit As Windows.Forms.Button
    Friend WithEvents btnWithdraw As Windows.Forms.Button
    Friend WithEvents btnExit As Windows.Forms.Button
    Friend WithEvents TextBox1 As Windows.Forms.TextBox
    Friend WithEvents TextBox2 As Windows.Forms.TextBox
    Friend WithEvents TextBox3 As Windows.Forms.TextBox
    Friend WithEvents TextBox4 As Windows.Forms.TextBox
    Friend WithEvents TextBox5 As Windows.Forms.TextBox
    Friend WithEvents lblAccountName As Windows.Forms.Label
    Friend WithEvents lblAccNum As Windows.Forms.Label
    Friend WithEvents lblCountryO As Windows.Forms.Label
    Friend WithEvents lblBalance As Windows.Forms.Label
    Friend WithEvents lblIntRate As Windows.Forms.Label
    Friend WithEvents RichTextBox1 As Windows.Forms.RichTextBox
    Friend WithEvents TextBox6 As Windows.Forms.TextBox
End Class
