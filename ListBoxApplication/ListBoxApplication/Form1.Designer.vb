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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.myList = New System.Windows.Forms.ListBox()
        Me.txtItem = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnADD = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnretrieve = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(59, 42)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(111, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "List Items:"
        '
        'myList
        '
        Me.myList.FormattingEnabled = True
        Me.myList.ItemHeight = 16
        Me.myList.Location = New System.Drawing.Point(64, 97)
        Me.myList.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.myList.Name = "myList"
        Me.myList.Size = New System.Drawing.Size(220, 292)
        Me.myList.TabIndex = 1
        '
        'txtItem
        '
        Me.txtItem.Location = New System.Drawing.Point(431, 100)
        Me.txtItem.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtItem.Name = "txtItem"
        Me.txtItem.Size = New System.Drawing.Size(164, 22)
        Me.txtItem.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(340, 97)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(60, 25)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Item:"
        '
        'btnADD
        '
        Me.btnADD.Location = New System.Drawing.Point(631, 95)
        Me.btnADD.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnADD.Name = "btnADD"
        Me.btnADD.Size = New System.Drawing.Size(100, 28)
        Me.btnADD.TabIndex = 4
        Me.btnADD.Text = "ADD"
        Me.btnADD.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(631, 166)
        Me.Button2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(100, 28)
        Me.Button2.TabIndex = 5
        Me.Button2.Text = "Remove"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(631, 249)
        Me.btnSave.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(100, 28)
        Me.btnSave.TabIndex = 6
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'btnretrieve
        '
        Me.btnretrieve.Location = New System.Drawing.Point(631, 341)
        Me.btnretrieve.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnretrieve.Name = "btnretrieve"
        Me.btnretrieve.Size = New System.Drawing.Size(100, 28)
        Me.btnretrieve.TabIndex = 7
        Me.btnretrieve.Text = "Retrieve"
        Me.btnretrieve.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(631, 418)
        Me.btnClear.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(100, 28)
        Me.btnClear.TabIndex = 8
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(756, 585)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnretrieve)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.btnADD)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtItem)
        Me.Controls.Add(Me.myList)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "Form1"
        Me.Text = "ListBoxApplication"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents myList As ListBox
    Friend WithEvents txtItem As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents btnADD As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents btnSave As Button
    Friend WithEvents btnretrieve As Button
    Friend WithEvents btnClear As Button
End Class
