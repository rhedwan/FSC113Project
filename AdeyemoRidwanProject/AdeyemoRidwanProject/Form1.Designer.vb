<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class QuadraticEquation
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
        Me.calculate = New System.Windows.Forms.Button()
        Me.reset = New System.Windows.Forms.Button()
        Me.captionA = New System.Windows.Forms.Label()
        Me.captionC = New System.Windows.Forms.Label()
        Me.captionB = New System.Windows.Forms.Label()
        Me.valueA = New System.Windows.Forms.TextBox()
        Me.valueC = New System.Windows.Forms.TextBox()
        Me.valueB = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'calculate
        '
        Me.calculate.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.calculate.Location = New System.Drawing.Point(517, 367)
        Me.calculate.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.calculate.Name = "calculate"
        Me.calculate.Size = New System.Drawing.Size(138, 42)
        Me.calculate.TabIndex = 0
        Me.calculate.Text = "Calculate"
        Me.calculate.UseVisualStyleBackColor = True
        '
        'reset
        '
        Me.reset.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.reset.Location = New System.Drawing.Point(284, 367)
        Me.reset.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.reset.Name = "reset"
        Me.reset.Size = New System.Drawing.Size(138, 42)
        Me.reset.TabIndex = 1
        Me.reset.Text = "Reset"
        Me.reset.UseVisualStyleBackColor = True
        '
        'captionA
        '
        Me.captionA.AutoSize = True
        Me.captionA.Location = New System.Drawing.Point(266, 125)
        Me.captionA.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.captionA.Name = "captionA"
        Me.captionA.Size = New System.Drawing.Size(99, 24)
        Me.captionA.TabIndex = 2
        Me.captionA.Text = "Value of a:"
        '
        'captionC
        '
        Me.captionC.AutoSize = True
        Me.captionC.Location = New System.Drawing.Point(266, 269)
        Me.captionC.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.captionC.Name = "captionC"
        Me.captionC.Size = New System.Drawing.Size(99, 24)
        Me.captionC.TabIndex = 3
        Me.captionC.Text = "Value of c:"
        '
        'captionB
        '
        Me.captionB.AutoSize = True
        Me.captionB.Location = New System.Drawing.Point(266, 203)
        Me.captionB.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.captionB.Name = "captionB"
        Me.captionB.Size = New System.Drawing.Size(100, 24)
        Me.captionB.TabIndex = 4
        Me.captionB.Text = "Value of b:"
        '
        'valueA
        '
        Me.valueA.Location = New System.Drawing.Point(394, 132)
        Me.valueA.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.valueA.Name = "valueA"
        Me.valueA.Size = New System.Drawing.Size(286, 29)
        Me.valueA.TabIndex = 5
        '
        'valueC
        '
        Me.valueC.Location = New System.Drawing.Point(394, 272)
        Me.valueC.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.valueC.Name = "valueC"
        Me.valueC.Size = New System.Drawing.Size(286, 29)
        Me.valueC.TabIndex = 6
        '
        'valueB
        '
        Me.valueB.Location = New System.Drawing.Point(394, 198)
        Me.valueB.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.valueB.Name = "valueB"
        Me.valueB.Size = New System.Drawing.Size(286, 29)
        Me.valueB.TabIndex = 7
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Franklin Gothic Demi Cond", 25.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(277, 40)
        Me.Label1.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(403, 39)
        Me.Label1.TabIndex = 17
        Me.Label1.Text = "Quadratic Equation Calculator"
        '
        'QuadraticEquation
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 24.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(910, 638)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.valueB)
        Me.Controls.Add(Me.valueC)
        Me.Controls.Add(Me.valueA)
        Me.Controls.Add(Me.captionB)
        Me.Controls.Add(Me.captionC)
        Me.Controls.Add(Me.captionA)
        Me.Controls.Add(Me.reset)
        Me.Controls.Add(Me.calculate)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.Name = "QuadraticEquation"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents calculate As System.Windows.Forms.Button
    Friend WithEvents reset As System.Windows.Forms.Button
    Friend WithEvents captionA As System.Windows.Forms.Label
    Friend WithEvents captionC As System.Windows.Forms.Label
    Friend WithEvents captionB As System.Windows.Forms.Label
    Friend WithEvents valueA As System.Windows.Forms.TextBox
    Friend WithEvents valueC As System.Windows.Forms.TextBox
    Friend WithEvents valueB As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label

End Class
