<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.CalculateButton = New System.Windows.Forms.Button()
        Me.FormulaLabel = New System.Windows.Forms.Label()
        Me.ResultLabel = New System.Windows.Forms.Label()
        Me.ResultValueLabel = New System.Windows.Forms.Label()
        Me.FormulaTextBox = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'CalculateButton
        '
        Me.CalculateButton.Location = New System.Drawing.Point(246, 60)
        Me.CalculateButton.Name = "CalculateButton"
        Me.CalculateButton.Size = New System.Drawing.Size(75, 23)
        Me.CalculateButton.TabIndex = 0
        Me.CalculateButton.Text = "Rechne"
        Me.CalculateButton.UseVisualStyleBackColor = True
        '
        'FormulaLabel
        '
        Me.FormulaLabel.AutoSize = True
        Me.FormulaLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormulaLabel.Location = New System.Drawing.Point(37, 60)
        Me.FormulaLabel.Name = "FormulaLabel"
        Me.FormulaLabel.Size = New System.Drawing.Size(51, 17)
        Me.FormulaLabel.TabIndex = 1
        Me.FormulaLabel.Text = "Formel"
        '
        'ResultLabel
        '
        Me.ResultLabel.AutoSize = True
        Me.ResultLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ResultLabel.Location = New System.Drawing.Point(24, 98)
        Me.ResultLabel.Name = "ResultLabel"
        Me.ResultLabel.Size = New System.Drawing.Size(64, 17)
        Me.ResultLabel.TabIndex = 2
        Me.ResultLabel.Text = "Ergebnis"
        '
        'ResultValueLabel
        '
        Me.ResultValueLabel.AutoSize = True
        Me.ResultValueLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ResultValueLabel.Location = New System.Drawing.Point(117, 98)
        Me.ResultValueLabel.Name = "ResultValueLabel"
        Me.ResultValueLabel.Size = New System.Drawing.Size(17, 17)
        Me.ResultValueLabel.TabIndex = 3
        Me.ResultValueLabel.Text = "0"
        '
        'FormulaTextBox
        '
        Me.FormulaTextBox.Location = New System.Drawing.Point(120, 60)
        Me.FormulaTextBox.Name = "FormulaTextBox"
        Me.FormulaTextBox.Size = New System.Drawing.Size(100, 20)
        Me.FormulaTextBox.TabIndex = 4
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(333, 141)
        Me.Controls.Add(Me.FormulaTextBox)
        Me.Controls.Add(Me.ResultValueLabel)
        Me.Controls.Add(Me.ResultLabel)
        Me.Controls.Add(Me.FormulaLabel)
        Me.Controls.Add(Me.CalculateButton)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Formel-Interpreter"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents CalculateButton As Button
    Friend WithEvents FormulaLabel As Label
    Friend WithEvents ResultLabel As Label
    Friend WithEvents ResultValueLabel As Label
    Friend WithEvents FormulaTextBox As TextBox
End Class
