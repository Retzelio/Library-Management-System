<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class librarianLogin
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(librarianLogin))
        Me.adminLogBgPanel = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.adminLogPanel = New System.Windows.Forms.Panel()
        Me.adminUserLogTextBox = New System.Windows.Forms.TextBox()
        Me.loginLbl = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.adminPassLogTextBox = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.adminLogButton = New Guna.UI2.WinForms.Guna2Button()
        Me.librarianCreateAccLbl = New System.Windows.Forms.Label()
        Me.adminLogBgPanel.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.adminLogPanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'adminLogBgPanel
        '
        Me.adminLogBgPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(56, Byte), Integer))
        Me.adminLogBgPanel.Controls.Add(Me.PictureBox1)
        Me.adminLogBgPanel.Location = New System.Drawing.Point(374, 0)
        Me.adminLogBgPanel.Name = "adminLogBgPanel"
        Me.adminLogBgPanel.Size = New System.Drawing.Size(427, 460)
        Me.adminLogBgPanel.TabIndex = 10
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(427, 460)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox1.TabIndex = 3
        Me.PictureBox1.TabStop = False
        '
        'adminLogPanel
        '
        Me.adminLogPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(71, Byte), Integer))
        Me.adminLogPanel.Controls.Add(Me.librarianCreateAccLbl)
        Me.adminLogPanel.Controls.Add(Me.adminLogButton)
        Me.adminLogPanel.Controls.Add(Me.adminUserLogTextBox)
        Me.adminLogPanel.Controls.Add(Me.loginLbl)
        Me.adminLogPanel.Controls.Add(Me.Label4)
        Me.adminLogPanel.Controls.Add(Me.adminPassLogTextBox)
        Me.adminLogPanel.Controls.Add(Me.Label2)
        Me.adminLogPanel.Location = New System.Drawing.Point(48, 40)
        Me.adminLogPanel.Name = "adminLogPanel"
        Me.adminLogPanel.Size = New System.Drawing.Size(259, 355)
        Me.adminLogPanel.TabIndex = 1
        '
        'adminUserLogTextBox
        '
        Me.adminUserLogTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.adminUserLogTextBox.Location = New System.Drawing.Point(32, 117)
        Me.adminUserLogTextBox.Multiline = True
        Me.adminUserLogTextBox.Name = "adminUserLogTextBox"
        Me.adminUserLogTextBox.Size = New System.Drawing.Size(190, 28)
        Me.adminUserLogTextBox.TabIndex = 0
        '
        'loginLbl
        '
        Me.loginLbl.AutoSize = True
        Me.loginLbl.Font = New System.Drawing.Font("Schibsted Grotesk", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.loginLbl.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(186, Byte), Integer), CType(CType(108, Byte), Integer))
        Me.loginLbl.Location = New System.Drawing.Point(11, 34)
        Me.loginLbl.Name = "loginLbl"
        Me.loginLbl.Size = New System.Drawing.Size(236, 36)
        Me.loginLbl.TabIndex = 2
        Me.loginLbl.Text = "LIBRARIAN LOGIN"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Poppins Medium", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(32, 162)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(111, 28)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "PASSWORD"
        '
        'adminPassLogTextBox
        '
        Me.adminPassLogTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.adminPassLogTextBox.Location = New System.Drawing.Point(32, 195)
        Me.adminPassLogTextBox.Multiline = True
        Me.adminPassLogTextBox.Name = "adminPassLogTextBox"
        Me.adminPassLogTextBox.Size = New System.Drawing.Size(190, 28)
        Me.adminPassLogTextBox.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Poppins Medium", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(32, 90)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(104, 28)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "USERNAME"
        '
        'adminLogButton
        '
        Me.adminLogButton.BackColor = System.Drawing.Color.Transparent
        Me.adminLogButton.BorderColor = System.Drawing.Color.Transparent
        Me.adminLogButton.BorderRadius = 20
        Me.adminLogButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.adminLogButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.adminLogButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.adminLogButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.adminLogButton.FillColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(186, Byte), Integer), CType(CType(108, Byte), Integer))
        Me.adminLogButton.Font = New System.Drawing.Font("Rubik Medium", 12.0!, System.Drawing.FontStyle.Bold)
        Me.adminLogButton.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(71, Byte), Integer))
        Me.adminLogButton.Location = New System.Drawing.Point(53, 249)
        Me.adminLogButton.Name = "adminLogButton"
        Me.adminLogButton.Size = New System.Drawing.Size(146, 40)
        Me.adminLogButton.TabIndex = 11
        Me.adminLogButton.Text = "LOGIN"
        '
        'librarianCreateAccLbl
        '
        Me.librarianCreateAccLbl.AutoSize = True
        Me.librarianCreateAccLbl.Font = New System.Drawing.Font("Poppins", 8.0!)
        Me.librarianCreateAccLbl.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(186, Byte), Integer), CType(CType(108, Byte), Integer))
        Me.librarianCreateAccLbl.Location = New System.Drawing.Point(67, 301)
        Me.librarianCreateAccLbl.Name = "librarianCreateAccLbl"
        Me.librarianCreateAccLbl.Size = New System.Drawing.Size(112, 19)
        Me.librarianCreateAccLbl.TabIndex = 12
        Me.librarianCreateAccLbl.Text = "Create an account"
        '
        'librarianLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.adminLogBgPanel)
        Me.Controls.Add(Me.adminLogPanel)
        Me.Name = "librarianLogin"
        Me.Text = "Admin Login"
        Me.adminLogBgPanel.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.adminLogPanel.ResumeLayout(False)
        Me.adminLogPanel.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents adminLogBgPanel As Panel
    Friend WithEvents adminLogPanel As Panel
    Friend WithEvents adminUserLogTextBox As TextBox
    Friend WithEvents loginLbl As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents adminPassLogTextBox As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents adminLogButton As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents librarianCreateAccLbl As Label
End Class
