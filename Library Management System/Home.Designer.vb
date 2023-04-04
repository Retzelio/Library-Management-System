<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Home
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
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.bookInfoGroupBox = New System.Windows.Forms.GroupBox()
        Me.headerLabel = New System.Windows.Forms.Label()
        Me.headerGroupBox = New System.Windows.Forms.GroupBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.headerGroupBox.SuspendLayout()
        Me.SuspendLayout()
        '
        'ListView1
        '
        Me.ListView1.BackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(76, Byte), Integer), CType(CType(113, Byte), Integer))
        Me.ListView1.HideSelection = False
        Me.ListView1.Location = New System.Drawing.Point(10, 157)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(858, 453)
        Me.ListView1.TabIndex = 0
        Me.ListView1.UseCompatibleStateImageBehavior = False
        '
        'bookInfoGroupBox
        '
        Me.bookInfoGroupBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bookInfoGroupBox.Location = New System.Drawing.Point(876, 151)
        Me.bookInfoGroupBox.Name = "bookInfoGroupBox"
        Me.bookInfoGroupBox.Size = New System.Drawing.Size(386, 459)
        Me.bookInfoGroupBox.TabIndex = 1
        Me.bookInfoGroupBox.TabStop = False
        '
        'headerLabel
        '
        Me.headerLabel.AutoSize = True
        Me.headerLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 22.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.headerLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.headerLabel.Location = New System.Drawing.Point(5, 18)
        Me.headerLabel.Name = "headerLabel"
        Me.headerLabel.Size = New System.Drawing.Size(501, 36)
        Me.headerLabel.TabIndex = 2
        Me.headerLabel.Text = "LIBRARY MANAGEMENT SYSTEM"
        '
        'headerGroupBox
        '
        Me.headerGroupBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(56, Byte), Integer))
        Me.headerGroupBox.Controls.Add(Me.Button1)
        Me.headerGroupBox.Controls.Add(Me.headerLabel)
        Me.headerGroupBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.headerGroupBox.Location = New System.Drawing.Point(2, -7)
        Me.headerGroupBox.Name = "headerGroupBox"
        Me.headerGroupBox.Size = New System.Drawing.Size(1265, 84)
        Me.headerGroupBox.TabIndex = 3
        Me.headerGroupBox.TabStop = False
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(1009, 23)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(86, 34)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Home
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1267, 628)
        Me.Controls.Add(Me.headerGroupBox)
        Me.Controls.Add(Me.bookInfoGroupBox)
        Me.Controls.Add(Me.ListView1)
        Me.Name = "Home"
        Me.Text = "Home"
        Me.headerGroupBox.ResumeLayout(False)
        Me.headerGroupBox.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ListView1 As ListView
    Friend WithEvents bookInfoGroupBox As GroupBox
    Friend WithEvents headerLabel As Label
    Friend WithEvents headerGroupBox As GroupBox
    Friend WithEvents Button1 As Button
End Class
