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
        Me.Button1 = New System.Windows.Forms.Button
        Me.Button2 = New System.Windows.Forms.Button
        Me.PortNumber = New System.Windows.Forms.NumericUpDown
        Me.Button3 = New System.Windows.Forms.Button
        Me.X = New System.Windows.Forms.Label
        Me.Y = New System.Windows.Forms.Label
        Me.L = New System.Windows.Forms.Label
        Me.TextX = New System.Windows.Forms.TextBox
        Me.TextY = New System.Windows.Forms.TextBox
        Me.TextL = New System.Windows.Forms.TextBox
        Me.Hold = New System.Windows.Forms.Button
        CType(Me.PortNumber, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(16, 15)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(100, 43)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Set Port Number"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(161, 65)
        Me.Button2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(141, 44)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "Open K Port"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'PortNumber
        '
        Me.PortNumber.Location = New System.Drawing.Point(161, 26)
        Me.PortNumber.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.PortNumber.Name = "PortNumber"
        Me.PortNumber.Size = New System.Drawing.Size(141, 22)
        Me.PortNumber.TabIndex = 2
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(16, 65)
        Me.Button3.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(99, 96)
        Me.Button3.TabIndex = 3
        Me.Button3.Text = "Get XYL"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'X
        '
        Me.X.AutoSize = True
        Me.X.Location = New System.Drawing.Point(123, 132)
        Me.X.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.X.Name = "X"
        Me.X.Size = New System.Drawing.Size(29, 17)
        Me.X.TabIndex = 4
        Me.X.Text = "X : "
        '
        'Y
        '
        Me.Y.AutoSize = True
        Me.Y.Location = New System.Drawing.Point(123, 169)
        Me.Y.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Y.Name = "Y"
        Me.Y.Size = New System.Drawing.Size(29, 17)
        Me.Y.TabIndex = 5
        Me.Y.Text = "Y : "
        '
        'L
        '
        Me.L.AutoSize = True
        Me.L.Location = New System.Drawing.Point(123, 201)
        Me.L.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.L.Name = "L"
        Me.L.Size = New System.Drawing.Size(28, 17)
        Me.L.TabIndex = 6
        Me.L.Text = "L : "
        '
        'TextX
        '
        Me.TextX.Location = New System.Drawing.Point(161, 128)
        Me.TextX.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TextX.Name = "TextX"
        Me.TextX.Size = New System.Drawing.Size(140, 22)
        Me.TextX.TabIndex = 7
        '
        'TextY
        '
        Me.TextY.Location = New System.Drawing.Point(161, 160)
        Me.TextY.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TextY.Name = "TextY"
        Me.TextY.Size = New System.Drawing.Size(140, 22)
        Me.TextY.TabIndex = 8
        '
        'TextL
        '
        Me.TextL.Location = New System.Drawing.Point(161, 192)
        Me.TextL.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TextL.Name = "TextL"
        Me.TextL.Size = New System.Drawing.Size(140, 22)
        Me.TextL.TabIndex = 9
        '
        'Hold
        '
        Me.Hold.Location = New System.Drawing.Point(16, 169)
        Me.Hold.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Hold.Name = "Hold"
        Me.Hold.Size = New System.Drawing.Size(99, 48)
        Me.Hold.TabIndex = 10
        Me.Hold.Text = "Hold"
        Me.Hold.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(319, 240)
        Me.Controls.Add(Me.Hold)
        Me.Controls.Add(Me.TextL)
        Me.Controls.Add(Me.TextY)
        Me.Controls.Add(Me.TextX)
        Me.Controls.Add(Me.L)
        Me.Controls.Add(Me.Y)
        Me.Controls.Add(Me.X)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.PortNumber)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "Form1"
        Me.Text = "Simple Sample"
        CType(Me.PortNumber, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents PortNumber As System.Windows.Forms.NumericUpDown
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents X As System.Windows.Forms.Label
    Friend WithEvents Y As System.Windows.Forms.Label
    Friend WithEvents L As System.Windows.Forms.Label
    Friend WithEvents TextX As System.Windows.Forms.TextBox
    Friend WithEvents TextY As System.Windows.Forms.TextBox
    Friend WithEvents TextL As System.Windows.Forms.TextBox
    Friend WithEvents Hold As System.Windows.Forms.Button

End Class
