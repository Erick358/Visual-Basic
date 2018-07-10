<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtNop = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.rbNonmember = New System.Windows.Forms.RadioButton()
        Me.rbMember = New System.Windows.Forms.RadioButton()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.txtsubtotal = New System.Windows.Forms.TextBox()
        Me.txttotal = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.rbWeekened = New System.Windows.Forms.RadioButton()
        Me.rbWeekday = New System.Windows.Forms.RadioButton()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtNop)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.rbNonmember)
        Me.GroupBox1.Controls.Add(Me.rbMember)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(37, 46)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox1.Size = New System.Drawing.Size(424, 123)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'txtNop
        '
        Me.txtNop.Location = New System.Drawing.Point(256, 23)
        Me.txtNop.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtNop.Name = "txtNop"
        Me.txtNop.Size = New System.Drawing.Size(132, 30)
        Me.txtNop.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(32, 27)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(191, 25)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Number of People:"
        '
        'rbNonmember
        '
        Me.rbNonmember.AutoSize = True
        Me.rbNonmember.Location = New System.Drawing.Point(232, 71)
        Me.rbNonmember.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.rbNonmember.Name = "rbNonmember"
        Me.rbNonmember.Size = New System.Drawing.Size(156, 29)
        Me.rbNonmember.TabIndex = 1
        Me.rbNonmember.TabStop = True
        Me.rbNonmember.Text = "Non Member"
        Me.rbNonmember.UseVisualStyleBackColor = True
        '
        'rbMember
        '
        Me.rbMember.AutoSize = True
        Me.rbMember.Location = New System.Drawing.Point(40, 71)
        Me.rbMember.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.rbMember.Name = "rbMember"
        Me.rbMember.Size = New System.Drawing.Size(111, 29)
        Me.rbMember.TabIndex = 0
        Me.rbMember.TabStop = True
        Me.rbMember.Text = "Member"
        Me.rbMember.UseVisualStyleBackColor = True
        '
        'btnCalculate
        '
        Me.btnCalculate.BackColor = System.Drawing.Color.MediumTurquoise
        Me.btnCalculate.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCalculate.Location = New System.Drawing.Point(37, 214)
        Me.btnCalculate.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(241, 73)
        Me.btnCalculate.TabIndex = 1
        Me.btnCalculate.Text = "Calculate"
        Me.btnCalculate.UseVisualStyleBackColor = False
        '
        'txtsubtotal
        '
        Me.txtsubtotal.Location = New System.Drawing.Point(479, 214)
        Me.txtsubtotal.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtsubtotal.Name = "txtsubtotal"
        Me.txtsubtotal.Size = New System.Drawing.Size(132, 22)
        Me.txtsubtotal.TabIndex = 2
        '
        'txttotal
        '
        Me.txttotal.Location = New System.Drawing.Point(479, 273)
        Me.txttotal.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txttotal.Name = "txttotal"
        Me.txttotal.Size = New System.Drawing.Size(132, 22)
        Me.txttotal.TabIndex = 3
        Me.txttotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(355, 271)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(68, 25)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Total:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(319, 214)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(113, 25)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Sub Total:"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.rbWeekened)
        Me.GroupBox2.Controls.Add(Me.rbWeekday)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(529, 46)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox2.Size = New System.Drawing.Size(267, 123)
        Me.GroupBox2.TabIndex = 6
        Me.GroupBox2.TabStop = False
        '
        'rbWeekened
        '
        Me.rbWeekened.AutoSize = True
        Me.rbWeekened.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbWeekened.Location = New System.Drawing.Point(52, 86)
        Me.rbWeekened.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.rbWeekened.Name = "rbWeekened"
        Me.rbWeekened.Size = New System.Drawing.Size(137, 29)
        Me.rbWeekened.TabIndex = 1
        Me.rbWeekened.TabStop = True
        Me.rbWeekened.Text = "Weekened"
        Me.rbWeekened.UseVisualStyleBackColor = True
        '
        'rbWeekday
        '
        Me.rbWeekday.AutoSize = True
        Me.rbWeekday.Location = New System.Drawing.Point(52, 31)
        Me.rbWeekday.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.rbWeekday.Name = "rbWeekday"
        Me.rbWeekday.Size = New System.Drawing.Size(124, 29)
        Me.rbWeekday.TabIndex = 0
        Me.rbWeekday.TabStop = True
        Me.rbWeekday.Text = "Weekday"
        Me.rbWeekday.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Snow
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType(((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic) _
                Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(319, 11)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(222, 25)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Golf Club Reservation"
        '
        'btnClear
        '
        Me.btnClear.BackColor = System.Drawing.Color.MediumTurquoise
        Me.btnClear.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.Location = New System.Drawing.Point(37, 314)
        Me.btnClear.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(241, 41)
        Me.btnClear.TabIndex = 8
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = False
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.Color.MediumTurquoise
        Me.btnExit.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.Location = New System.Drawing.Point(608, 315)
        Me.btnExit.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(188, 39)
        Me.btnExit.TabIndex = 9
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(819, 369)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txttotal)
        Me.Controls.Add(Me.txtsubtotal)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.GroupBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "Form1"
        Me.Text = "Golf Club Application"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents rbNonmember As RadioButton
    Friend WithEvents rbMember As RadioButton
    Friend WithEvents btnCalculate As Button
    Friend WithEvents txtsubtotal As TextBox
    Friend WithEvents txttotal As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents rbWeekened As RadioButton
    Friend WithEvents rbWeekday As RadioButton
    Friend WithEvents txtNop As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents btnClear As Button
    Friend WithEvents btnExit As Button
End Class
