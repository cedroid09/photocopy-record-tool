<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Main
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
        Me.btnSave = New System.Windows.Forms.GroupBox()
        Me.comOperator = New System.Windows.Forms.ComboBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lblPrice = New System.Windows.Forms.Label()
        Me.chkUnpaid = New System.Windows.Forms.CheckBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btnViewRecords = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.rtbNotes = New System.Windows.Forms.RichTextBox()
        Me.txtPages = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.chkCredited = New System.Windows.Forms.CheckBox()
        Me.chkPaid = New System.Windows.Forms.CheckBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtCounter = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtRefNumber = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtNumberofC = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.comPurpose = New System.Windows.Forms.ComboBox()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.comDate = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnSave.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnSave
        '
        Me.btnSave.Controls.Add(Me.comOperator)
        Me.btnSave.Controls.Add(Me.GroupBox1)
        Me.btnSave.Controls.Add(Me.chkUnpaid)
        Me.btnSave.Controls.Add(Me.GroupBox2)
        Me.btnSave.Controls.Add(Me.Label9)
        Me.btnSave.Controls.Add(Me.rtbNotes)
        Me.btnSave.Controls.Add(Me.txtPages)
        Me.btnSave.Controls.Add(Me.Label8)
        Me.btnSave.Controls.Add(Me.chkCredited)
        Me.btnSave.Controls.Add(Me.chkPaid)
        Me.btnSave.Controls.Add(Me.Label7)
        Me.btnSave.Controls.Add(Me.txtCounter)
        Me.btnSave.Controls.Add(Me.Label6)
        Me.btnSave.Controls.Add(Me.txtRefNumber)
        Me.btnSave.Controls.Add(Me.Label5)
        Me.btnSave.Controls.Add(Me.txtNumberofC)
        Me.btnSave.Controls.Add(Me.Label4)
        Me.btnSave.Controls.Add(Me.Label3)
        Me.btnSave.Controls.Add(Me.comPurpose)
        Me.btnSave.Controls.Add(Me.txtName)
        Me.btnSave.Controls.Add(Me.Label2)
        Me.btnSave.Controls.Add(Me.comDate)
        Me.btnSave.Controls.Add(Me.Label1)
        Me.btnSave.Location = New System.Drawing.Point(12, 12)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(620, 458)
        Me.btnSave.TabIndex = 0
        Me.btnSave.TabStop = False
        Me.btnSave.Text = "Records"
        '
        'comOperator
        '
        Me.comOperator.FormattingEnabled = True
        Me.comOperator.Location = New System.Drawing.Point(260, 135)
        Me.comOperator.Name = "comOperator"
        Me.comOperator.Size = New System.Drawing.Size(200, 21)
        Me.comOperator.TabIndex = 25
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lblPrice)
        Me.GroupBox1.Location = New System.Drawing.Point(469, 19)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(140, 151)
        Me.GroupBox1.TabIndex = 24
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Price (Rs):"
        '
        'lblPrice
        '
        Me.lblPrice.AutoSize = True
        Me.lblPrice.Font = New System.Drawing.Font("Modern No. 20", 48.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPrice.Location = New System.Drawing.Point(14, 42)
        Me.lblPrice.MaximumSize = New System.Drawing.Size(118, 65)
        Me.lblPrice.MinimumSize = New System.Drawing.Size(118, 65)
        Me.lblPrice.Name = "lblPrice"
        Me.lblPrice.Size = New System.Drawing.Size(118, 65)
        Me.lblPrice.TabIndex = 23
        Me.lblPrice.Text = "0"
        Me.lblPrice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'chkUnpaid
        '
        Me.chkUnpaid.AutoSize = True
        Me.chkUnpaid.Location = New System.Drawing.Point(314, 171)
        Me.chkUnpaid.Name = "chkUnpaid"
        Me.chkUnpaid.Size = New System.Drawing.Size(60, 17)
        Me.chkUnpaid.TabIndex = 21
        Me.chkUnpaid.Text = "Unpaid"
        Me.chkUnpaid.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btnViewRecords)
        Me.GroupBox2.Controls.Add(Me.Button1)
        Me.GroupBox2.Location = New System.Drawing.Point(314, 195)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(293, 86)
        Me.GroupBox2.TabIndex = 20
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Actions"
        '
        'btnViewRecords
        '
        Me.btnViewRecords.Location = New System.Drawing.Point(155, 13)
        Me.btnViewRecords.Name = "btnViewRecords"
        Me.btnViewRecords.Size = New System.Drawing.Size(132, 67)
        Me.btnViewRecords.TabIndex = 1
        Me.btnViewRecords.Text = "&View Records"
        Me.btnViewRecords.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(17, 13)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(132, 67)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "&Save"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(10, 271)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(85, 13)
        Me.Label9.TabIndex = 19
        Me.Label9.Text = "Additonal Notes:"
        '
        'rtbNotes
        '
        Me.rtbNotes.Location = New System.Drawing.Point(13, 287)
        Me.rtbNotes.Name = "rtbNotes"
        Me.rtbNotes.Size = New System.Drawing.Size(594, 157)
        Me.rtbNotes.TabIndex = 18
        Me.rtbNotes.Text = ""
        '
        'txtPages
        '
        Me.txtPages.Location = New System.Drawing.Point(13, 188)
        Me.txtPages.Name = "txtPages"
        Me.txtPages.Size = New System.Drawing.Size(199, 20)
        Me.txtPages.TabIndex = 17
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(10, 171)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(128, 13)
        Me.Label8.TabIndex = 16
        Me.Label8.Text = "Number of Printed Pages:"
        '
        'chkCredited
        '
        Me.chkCredited.AutoSize = True
        Me.chkCredited.Location = New System.Drawing.Point(380, 171)
        Me.chkCredited.Name = "chkCredited"
        Me.chkCredited.Size = New System.Drawing.Size(65, 17)
        Me.chkCredited.TabIndex = 15
        Me.chkCredited.Text = "Credited"
        Me.chkCredited.UseVisualStyleBackColor = True
        '
        'chkPaid
        '
        Me.chkPaid.AutoSize = True
        Me.chkPaid.Checked = True
        Me.chkPaid.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkPaid.Location = New System.Drawing.Point(260, 171)
        Me.chkPaid.Name = "chkPaid"
        Me.chkPaid.Size = New System.Drawing.Size(47, 17)
        Me.chkPaid.TabIndex = 14
        Me.chkPaid.Text = "Paid"
        Me.chkPaid.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(257, 120)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(107, 13)
        Me.Label7.TabIndex = 1
        Me.Label7.Text = "Printed by (Operator):"
        '
        'txtCounter
        '
        Me.txtCounter.BackColor = System.Drawing.SystemColors.Window
        Me.txtCounter.Enabled = False
        Me.txtCounter.Location = New System.Drawing.Point(260, 87)
        Me.txtCounter.Name = "txtCounter"
        Me.txtCounter.Size = New System.Drawing.Size(200, 20)
        Me.txtCounter.TabIndex = 11
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(257, 71)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(87, 13)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Counter Number:"
        '
        'txtRefNumber
        '
        Me.txtRefNumber.Location = New System.Drawing.Point(260, 35)
        Me.txtRefNumber.Name = "txtRefNumber"
        Me.txtRefNumber.Size = New System.Drawing.Size(200, 20)
        Me.txtRefNumber.TabIndex = 9
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(257, 19)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(67, 13)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Ref. Number"
        '
        'txtNumberofC
        '
        Me.txtNumberofC.Enabled = False
        Me.txtNumberofC.Location = New System.Drawing.Point(12, 238)
        Me.txtNumberofC.Name = "txtNumberofC"
        Me.txtNumberofC.Size = New System.Drawing.Size(200, 20)
        Me.txtNumberofC.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(10, 222)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(94, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Number of Copies:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(9, 120)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(49, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Purpose:"
        '
        'comPurpose
        '
        Me.comPurpose.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.comPurpose.FormattingEnabled = True
        Me.comPurpose.Location = New System.Drawing.Point(13, 136)
        Me.comPurpose.Name = "comPurpose"
        Me.comPurpose.Size = New System.Drawing.Size(200, 21)
        Me.comPurpose.TabIndex = 4
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(13, 87)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(200, 20)
        Me.txtName.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(9, 71)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(38, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Name:"
        '
        'comDate
        '
        Me.comDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.comDate.Location = New System.Drawing.Point(13, 35)
        Me.comDate.Name = "comDate"
        Me.comDate.Size = New System.Drawing.Size(200, 20)
        Me.comDate.TabIndex = 1
        Me.comDate.Value = New Date(2016, 6, 7, 12, 7, 21, 0)
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(10, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(33, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Date:"
        '
        'Main
        '
        Me.AcceptButton = Me.Button1
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(642, 479)
        Me.Controls.Add(Me.btnSave)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Main"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Photocopy Stock Control Tool"
        Me.btnSave.ResumeLayout(False)
        Me.btnSave.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnSave As GroupBox
    Friend WithEvents txtRefNumber As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtNumberofC As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents comPurpose As ComboBox
    Friend WithEvents txtName As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents comDate As DateTimePicker
    Friend WithEvents Label1 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents txtCounter As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents rtbNotes As RichTextBox
    Friend WithEvents txtPages As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents chkCredited As CheckBox
    Friend WithEvents chkPaid As CheckBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Button1 As Button
    Friend WithEvents chkUnpaid As CheckBox
    Friend WithEvents btnViewRecords As Button
    Friend WithEvents lblPrice As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents comOperator As ComboBox
End Class
