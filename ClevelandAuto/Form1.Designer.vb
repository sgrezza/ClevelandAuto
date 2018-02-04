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
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.btnInformation = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.lstAverage = New System.Windows.Forms.ListBox()
        Me.lstStudents = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'ListBox1
        '
        Me.ListBox1.Font = New System.Drawing.Font("Inria Sans", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.ItemHeight = 24
        Me.ListBox1.Location = New System.Drawing.Point(72, 67)
        Me.ListBox1.MultiColumn = True
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(784, 340)
        Me.ListBox1.TabIndex = 0
        '
        'btnInformation
        '
        Me.btnInformation.Font = New System.Drawing.Font("Inria Sans", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnInformation.Location = New System.Drawing.Point(506, 635)
        Me.btnInformation.Name = "btnInformation"
        Me.btnInformation.Size = New System.Drawing.Size(172, 62)
        Me.btnInformation.TabIndex = 1
        Me.btnInformation.Text = "Enter Grades"
        Me.btnInformation.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Inria Sans", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(684, 635)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(172, 62)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "Close"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'lstAverage
        '
        Me.lstAverage.Font = New System.Drawing.Font("Inria Sans", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstAverage.FormattingEnabled = True
        Me.lstAverage.ItemHeight = 24
        Me.lstAverage.Location = New System.Drawing.Point(72, 471)
        Me.lstAverage.MultiColumn = True
        Me.lstAverage.Name = "lstAverage"
        Me.lstAverage.Size = New System.Drawing.Size(784, 100)
        Me.lstAverage.TabIndex = 3
        '
        'lstStudents
        '
        Me.lstStudents.AutoSize = True
        Me.lstStudents.Location = New System.Drawing.Point(72, 36)
        Me.lstStudents.Name = "lstStudents"
        Me.lstStudents.Size = New System.Drawing.Size(162, 25)
        Me.lstStudents.TabIndex = 4
        Me.lstStudents.Text = "Student Grades"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(72, 440)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(103, 25)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Averages"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(945, 738)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lstStudents)
        Me.Controls.Add(Me.lstAverage)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btnInformation)
        Me.Controls.Add(Me.ListBox1)
        Me.Name = "Form1"
        Me.Text = "Two Dimensional Array"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents btnInformation As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents lstAverage As ListBox
    Friend WithEvents lstStudents As Label
    Friend WithEvents Label1 As Label
End Class
