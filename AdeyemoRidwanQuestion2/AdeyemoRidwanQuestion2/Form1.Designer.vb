<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class GradeCalculator
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
        Me.grade = New System.Windows.Forms.TextBox()
        Me.captionGrade = New System.Windows.Forms.Label()
        Me.reset = New System.Windows.Forms.Button()
        Me.calculate = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'grade
        '
        Me.grade.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grade.Location = New System.Drawing.Point(456, 95)
        Me.grade.Name = "grade"
        Me.grade.Size = New System.Drawing.Size(100, 29)
        Me.grade.TabIndex = 13
        '
        'captionGrade
        '
        Me.captionGrade.AutoSize = True
        Me.captionGrade.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.captionGrade.Location = New System.Drawing.Point(273, 95)
        Me.captionGrade.Name = "captionGrade"
        Me.captionGrade.Size = New System.Drawing.Size(65, 24)
        Me.captionGrade.TabIndex = 10
        Me.captionGrade.Text = "Score:"
        '
        'reset
        '
        Me.reset.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.reset.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.reset.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.reset.Location = New System.Drawing.Point(289, 177)
        Me.reset.Name = "reset"
        Me.reset.Padding = New System.Windows.Forms.Padding(2)
        Me.reset.Size = New System.Drawing.Size(75, 35)
        Me.reset.TabIndex = 9
        Me.reset.Text = "Reset"
        Me.reset.UseVisualStyleBackColor = False
        '
        'calculate
        '
        Me.calculate.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.calculate.Location = New System.Drawing.Point(442, 177)
        Me.calculate.Name = "calculate"
        Me.calculate.Size = New System.Drawing.Size(99, 35)
        Me.calculate.TabIndex = 8
        Me.calculate.Text = "Calculate"
        Me.calculate.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Franklin Gothic Demi Cond", 25.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(282, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(235, 39)
        Me.Label1.TabIndex = 16
        Me.Label1.Text = "Grade Calculator"
        '
        'GradeCalculator
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(846, 326)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.grade)
        Me.Controls.Add(Me.captionGrade)
        Me.Controls.Add(Me.reset)
        Me.Controls.Add(Me.calculate)
        Me.Name = "GradeCalculator"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents grade As System.Windows.Forms.TextBox
    Friend WithEvents captionGrade As System.Windows.Forms.Label
    Friend WithEvents reset As System.Windows.Forms.Button
    Friend WithEvents calculate As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label

End Class
