<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class welcomePage
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(welcomePage))
        Me.titleLabel = New System.Windows.Forms.Label()
        Me.welcomeLabel = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.studentBtn = New Guna.UI2.WinForms.Guna2Button()
        Me.adminBtn = New Guna.UI2.WinForms.Guna2Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'titleLabel
        '
        Me.titleLabel.AutoSize = True
        Me.titleLabel.Font = New System.Drawing.Font("Gabriola", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.titleLabel.ForeColor = System.Drawing.Color.Goldenrod
        Me.titleLabel.Location = New System.Drawing.Point(81, 5)
        Me.titleLabel.Name = "titleLabel"
        Me.titleLabel.Size = New System.Drawing.Size(247, 39)
        Me.titleLabel.TabIndex = 0
        Me.titleLabel.Text = "LIBRARY MANAGEMENT SYSTEM"
        '
        'welcomeLabel
        '
        Me.welcomeLabel.AutoSize = True
        Me.welcomeLabel.Font = New System.Drawing.Font("Malgun Gothic", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.welcomeLabel.ForeColor = System.Drawing.Color.Goldenrod
        Me.welcomeLabel.Location = New System.Drawing.Point(101, 72)
        Me.welcomeLabel.Name = "welcomeLabel"
        Me.welcomeLabel.Size = New System.Drawing.Size(207, 50)
        Me.welcomeLabel.TabIndex = 1
        Me.welcomeLabel.Text = "WELCOME"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(75, 129)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(259, 217)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'studentBtn
        '
        Me.studentBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.studentBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.studentBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.studentBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.studentBtn.FillColor = System.Drawing.Color.Goldenrod
        Me.studentBtn.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.studentBtn.ForeColor = System.Drawing.Color.Black
        Me.studentBtn.Location = New System.Drawing.Point(119, 392)
        Me.studentBtn.Name = "studentBtn"
        Me.studentBtn.Size = New System.Drawing.Size(180, 45)
        Me.studentBtn.TabIndex = 3
        Me.studentBtn.Text = "STUDENT"
        '
        'adminBtn
        '
        Me.adminBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.adminBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.adminBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.adminBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.adminBtn.FillColor = System.Drawing.Color.Goldenrod
        Me.adminBtn.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.adminBtn.ForeColor = System.Drawing.Color.Black
        Me.adminBtn.Location = New System.Drawing.Point(118, 453)
        Me.adminBtn.Name = "adminBtn"
        Me.adminBtn.Size = New System.Drawing.Size(180, 45)
        Me.adminBtn.TabIndex = 4
        Me.adminBtn.Text = "ADMIN"
        '
        'welcomePage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(76, Byte), Integer), CType(CType(113, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(416, 565)
        Me.Controls.Add(Me.adminBtn)
        Me.Controls.Add(Me.studentBtn)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.welcomeLabel)
        Me.Controls.Add(Me.titleLabel)
        Me.Name = "welcomePage"
        Me.Text = "welcomePage"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents titleLabel As Label
    Friend WithEvents welcomeLabel As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents studentBtn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents adminBtn As Guna.UI2.WinForms.Guna2Button
End Class
