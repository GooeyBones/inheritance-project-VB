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
        Me.cmboCategory = New System.Windows.Forms.ComboBox()
        Me.lstDetailBox = New System.Windows.Forms.ListBox()
        Me.btnGetInfo = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'cmboCategory
        '
        Me.cmboCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmboCategory.FormattingEnabled = True
        Me.cmboCategory.Location = New System.Drawing.Point(13, 25)
        Me.cmboCategory.Name = "cmboCategory"
        Me.cmboCategory.Size = New System.Drawing.Size(121, 21)
        Me.cmboCategory.TabIndex = 0
        '
        'lstDetailBox
        '
        Me.lstDetailBox.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstDetailBox.FormattingEnabled = True
        Me.lstDetailBox.ItemHeight = 16
        Me.lstDetailBox.Location = New System.Drawing.Point(12, 54)
        Me.lstDetailBox.Name = "lstDetailBox"
        Me.lstDetailBox.Size = New System.Drawing.Size(570, 148)
        Me.lstDetailBox.TabIndex = 1
        '
        'btnGetInfo
        '
        Me.btnGetInfo.Location = New System.Drawing.Point(140, 25)
        Me.btnGetInfo.Name = "btnGetInfo"
        Me.btnGetInfo.Size = New System.Drawing.Size(75, 23)
        Me.btnGetInfo.TabIndex = 2
        Me.btnGetInfo.Text = "Get Info"
        Me.btnGetInfo.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(10, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(117, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Choose a Vehicle Type"
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(506, 25)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 4
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(594, 209)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnGetInfo)
        Me.Controls.Add(Me.lstDetailBox)
        Me.Controls.Add(Me.cmboCategory)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cmboCategory As ComboBox
    Friend WithEvents lstDetailBox As ListBox
    Friend WithEvents btnGetInfo As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents btnExit As Button
End Class
