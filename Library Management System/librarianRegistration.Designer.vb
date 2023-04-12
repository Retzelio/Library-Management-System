<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class librarianRegistration
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(librarianRegistration))
        Me.adminRegPanel = New System.Windows.Forms.Panel()
        Me.adminLnameRegTextBox = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.adminPassRegTextBox = New System.Windows.Forms.TextBox()
        Me.adminFnameRegTextBox = New System.Windows.Forms.TextBox()
        Me.adminRegButton = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.adminUserRegTextBox = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Guna2GroupBox1 = New Guna.UI2.WinForms.Guna2GroupBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Guna2PictureBox2 = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.adminRegPanel.SuspendLayout()
        Me.Guna2GroupBox1.SuspendLayout()
        CType(Me.Guna2PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'adminRegPanel
        '
        Me.adminRegPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(76, Byte), Integer), CType(CType(113, Byte), Integer))
        Me.adminRegPanel.Controls.Add(Me.adminLnameRegTextBox)
        Me.adminRegPanel.Controls.Add(Me.Label5)
        Me.adminRegPanel.Controls.Add(Me.Label3)
        Me.adminRegPanel.Controls.Add(Me.adminPassRegTextBox)
        Me.adminRegPanel.Controls.Add(Me.adminFnameRegTextBox)
        Me.adminRegPanel.Controls.Add(Me.adminRegButton)
        Me.adminRegPanel.Controls.Add(Me.Label1)
        Me.adminRegPanel.Controls.Add(Me.Label4)
        Me.adminRegPanel.Controls.Add(Me.adminUserRegTextBox)
        Me.adminRegPanel.Controls.Add(Me.Label2)
        Me.adminRegPanel.Location = New System.Drawing.Point(48, 40)
        Me.adminRegPanel.Name = "adminRegPanel"
        Me.adminRegPanel.Size = New System.Drawing.Size(259, 355)
        Me.adminRegPanel.TabIndex = 0
        '
        'adminLnameRegTextBox
        '
        Me.adminLnameRegTextBox.Location = New System.Drawing.Point(39, 150)
        Me.adminLnameRegTextBox.Multiline = True
        Me.adminLnameRegTextBox.Name = "adminLnameRegTextBox"
        Me.adminLnameRegTextBox.Size = New System.Drawing.Size(180, 22)
        Me.adminLnameRegTextBox.TabIndex = 2
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(36, 131)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(85, 16)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "FIRSTNAME"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(36, 248)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(86, 16)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "PASSWORD"
        '
        'adminPassRegTextBox
        '
        Me.adminPassRegTextBox.Location = New System.Drawing.Point(39, 267)
        Me.adminPassRegTextBox.Multiline = True
        Me.adminPassRegTextBox.Name = "adminPassRegTextBox"
        Me.adminPassRegTextBox.Size = New System.Drawing.Size(180, 22)
        Me.adminPassRegTextBox.TabIndex = 4
        '
        'adminFnameRegTextBox
        '
        Me.adminFnameRegTextBox.Location = New System.Drawing.Point(36, 96)
        Me.adminFnameRegTextBox.Multiline = True
        Me.adminFnameRegTextBox.Name = "adminFnameRegTextBox"
        Me.adminFnameRegTextBox.Size = New System.Drawing.Size(180, 22)
        Me.adminFnameRegTextBox.TabIndex = 1
        '
        'adminRegButton
        '
        Me.adminRegButton.BackColor = System.Drawing.Color.Goldenrod
        Me.adminRegButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.adminRegButton.Location = New System.Drawing.Point(36, 308)
        Me.adminRegButton.Name = "adminRegButton"
        Me.adminRegButton.Size = New System.Drawing.Size(180, 29)
        Me.adminRegButton.TabIndex = 5
        Me.adminRegButton.Text = "REGISTER"
        Me.adminRegButton.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Goldenrod
        Me.Label1.Location = New System.Drawing.Point(49, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(161, 24)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "REGISTRATION"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(36, 186)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(84, 16)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "USERNAME"
        '
        'adminUserRegTextBox
        '
        Me.adminUserRegTextBox.Location = New System.Drawing.Point(39, 205)
        Me.adminUserRegTextBox.Multiline = True
        Me.adminUserRegTextBox.Name = "adminUserRegTextBox"
        Me.adminUserRegTextBox.Size = New System.Drawing.Size(180, 22)
        Me.adminUserRegTextBox.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(33, 77)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(80, 16)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "LASTNAME"
        '
        'Guna2GroupBox1
        '
        Me.Guna2GroupBox1.BorderRadius = 30
        Me.Guna2GroupBox1.Controls.Add(Me.Label8)
        Me.Guna2GroupBox1.Controls.Add(Me.Guna2PictureBox2)
        Me.Guna2GroupBox1.CustomBorderThickness = New System.Windows.Forms.Padding(0)
        Me.Guna2GroupBox1.FillColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(71, Byte), Integer))
        Me.Guna2GroupBox1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Guna2GroupBox1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.Guna2GroupBox1.Location = New System.Drawing.Point(443, 10)
        Me.Guna2GroupBox1.Name = "Guna2GroupBox1"
        Me.Guna2GroupBox1.Size = New System.Drawing.Size(313, 429)
        Me.Guna2GroupBox1.TabIndex = 6
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Poppins Light", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(186, Byte), Integer), CType(CType(108, Byte), Integer))
        Me.Label8.Location = New System.Drawing.Point(26, 25)
        Me.Label8.MaximumSize = New System.Drawing.Size(300, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(267, 44)
        Me.Label8.TabIndex = 20
        Me.Label8.Text = """Connect to the world's knowledge with our library system."""
        '
        'Guna2PictureBox2
        '
        Me.Guna2PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.Guna2PictureBox2.Image = CType(resources.GetObject("Guna2PictureBox2.Image"), System.Drawing.Image)
        Me.Guna2PictureBox2.ImageRotate = 0!
        Me.Guna2PictureBox2.Location = New System.Drawing.Point(33, 107)
        Me.Guna2PictureBox2.Name = "Guna2PictureBox2"
        Me.Guna2PictureBox2.Size = New System.Drawing.Size(256, 256)
        Me.Guna2PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.Guna2PictureBox2.TabIndex = 22
        Me.Guna2PictureBox2.TabStop = False
        '
        'librarianRegistration
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(905, 474)
        Me.Controls.Add(Me.Guna2GroupBox1)
        Me.Controls.Add(Me.adminRegPanel)
        Me.Name = "librarianRegistration"
        Me.Text = "Admin Registration"
        Me.adminRegPanel.ResumeLayout(False)
        Me.adminRegPanel.PerformLayout()
        Me.Guna2GroupBox1.ResumeLayout(False)
        Me.Guna2GroupBox1.PerformLayout()
        CType(Me.Guna2PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents adminRegPanel As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents adminPassRegTextBox As TextBox
    Friend WithEvents adminFnameRegTextBox As TextBox
    Friend WithEvents adminRegButton As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents adminUserRegTextBox As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents adminLnameRegTextBox As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Guna2GroupBox1 As Guna.UI2.WinForms.Guna2GroupBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Guna2PictureBox2 As Guna.UI2.WinForms.Guna2PictureBox
End Class
