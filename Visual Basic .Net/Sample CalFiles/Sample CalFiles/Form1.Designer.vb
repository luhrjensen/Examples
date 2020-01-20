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
        Me.Button4 = New System.Windows.Forms.Button
        Me.SelectID = New System.Windows.Forms.Button
        Me.CalListLabel = New System.Windows.Forms.Label
        Me.CalFileList = New System.Windows.Forms.TextBox
        Me.CalFileID = New System.Windows.Forms.NumericUpDown
        Me.CalFileName = New System.Windows.Forms.TextBox
        CType(Me.PortNumber, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CalFileID, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(12, 12)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 35)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Set Port Number"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(12, 53)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(215, 36)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "Open K Port"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'PortNumber
        '
        Me.PortNumber.Location = New System.Drawing.Point(127, 21)
        Me.PortNumber.Name = "PortNumber"
        Me.PortNumber.Size = New System.Drawing.Size(100, 20)
        Me.PortNumber.TabIndex = 2
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(12, 104)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(74, 78)
        Me.Button3.TabIndex = 3
        Me.Button3.Text = "Get XYL"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'X
        '
        Me.X.AutoSize = True
        Me.X.Location = New System.Drawing.Point(92, 107)
        Me.X.Name = "X"
        Me.X.Size = New System.Drawing.Size(23, 13)
        Me.X.TabIndex = 4
        Me.X.Text = "X : "
        '
        'Y
        '
        Me.Y.AutoSize = True
        Me.Y.Location = New System.Drawing.Point(92, 137)
        Me.Y.Name = "Y"
        Me.Y.Size = New System.Drawing.Size(23, 13)
        Me.Y.TabIndex = 5
        Me.Y.Text = "Y : "
        '
        'L
        '
        Me.L.AutoSize = True
        Me.L.Location = New System.Drawing.Point(92, 163)
        Me.L.Name = "L"
        Me.L.Size = New System.Drawing.Size(22, 13)
        Me.L.TabIndex = 6
        Me.L.Text = "L : "
        '
        'TextX
        '
        Me.TextX.Location = New System.Drawing.Point(127, 104)
        Me.TextX.Name = "TextX"
        Me.TextX.Size = New System.Drawing.Size(100, 20)
        Me.TextX.TabIndex = 7
        '
        'TextY
        '
        Me.TextY.Location = New System.Drawing.Point(127, 130)
        Me.TextY.Name = "TextY"
        Me.TextY.Size = New System.Drawing.Size(100, 20)
        Me.TextY.TabIndex = 8
        '
        'TextL
        '
        Me.TextL.Location = New System.Drawing.Point(127, 156)
        Me.TextL.Name = "TextL"
        Me.TextL.Size = New System.Drawing.Size(100, 20)
        Me.TextL.TabIndex = 9
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(246, 12)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(112, 35)
        Me.Button4.TabIndex = 10
        Me.Button4.Text = "Get the CalFile List"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'SelectID
        '
        Me.SelectID.Location = New System.Drawing.Point(364, 12)
        Me.SelectID.Name = "SelectID"
        Me.SelectID.Size = New System.Drawing.Size(112, 35)
        Me.SelectID.TabIndex = 11
        Me.SelectID.Text = "Select by ID"
        Me.SelectID.UseVisualStyleBackColor = True
        '
        'CalListLabel
        '
        Me.CalListLabel.AutoSize = True
        Me.CalListLabel.Location = New System.Drawing.Point(243, 58)
        Me.CalListLabel.Name = "CalListLabel"
        Me.CalListLabel.Size = New System.Drawing.Size(63, 13)
        Me.CalListLabel.TabIndex = 12
        Me.CalListLabel.Text = "CalFile List: "
        '
        'CalFileList
        '
        Me.CalFileList.Location = New System.Drawing.Point(246, 81)
        Me.CalFileList.Multiline = True
        Me.CalFileList.Name = "CalFileList"
        Me.CalFileList.ReadOnly = True
        Me.CalFileList.Size = New System.Drawing.Size(112, 95)
        Me.CalFileList.TabIndex = 13
        Me.CalFileList.WordWrap = False
        '
        'CalFileID
        '
        Me.CalFileID.Location = New System.Drawing.Point(370, 56)
        Me.CalFileID.Name = "CalFileID"
        Me.CalFileID.Size = New System.Drawing.Size(100, 20)
        Me.CalFileID.TabIndex = 14
        '
        'CalFileName
        '
        Me.CalFileName.Location = New System.Drawing.Point(370, 156)
        Me.CalFileName.Name = "CalFileName"
        Me.CalFileName.Size = New System.Drawing.Size(100, 20)
        Me.CalFileName.TabIndex = 16
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(486, 195)
        Me.Controls.Add(Me.CalFileName)
        Me.Controls.Add(Me.CalFileID)
        Me.Controls.Add(Me.CalFileList)
        Me.Controls.Add(Me.CalListLabel)
        Me.Controls.Add(Me.SelectID)
        Me.Controls.Add(Me.Button4)
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
        Me.Name = "Form1"
        Me.Text = "Sample with CalFiles"
        CType(Me.PortNumber, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CalFileID, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents SelectID As System.Windows.Forms.Button
    Friend WithEvents CalListLabel As System.Windows.Forms.Label
    Friend WithEvents CalFileID As System.Windows.Forms.NumericUpDown
    Friend WithEvents CalFileName As System.Windows.Forms.TextBox
    Friend WithEvents CalFileList As System.Windows.Forms.TextBox

End Class
