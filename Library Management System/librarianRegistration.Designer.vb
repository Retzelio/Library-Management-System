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
        Me.adminRegBgPanel = New System.Windows.Forms.Panel()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.adminRegPanel = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.adminPassRegTextBox = New System.Windows.Forms.TextBox()
        Me.adminFnameRegTextBox = New System.Windows.Forms.TextBox()
        Me.adminRegButton = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.adminUserRegTextBox = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.adminLnameRegTextBox = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.adminRegBgPanel.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.adminRegPanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'adminRegBgPanel
        '
        Me.adminRegBgPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(56, Byte), Integer))
        Me.adminRegBgPanel.Controls.Add(Me.PictureBox3)
        Me.adminRegBgPanel.Controls.Add(Me.PictureBox2)
        Me.adminRegBgPanel.Controls.Add(Me.PictureBox1)
        Me.adminRegBgPanel.Location = New System.Drawing.Point(374, 0)
        Me.adminRegBgPanel.Name = "adminRegBgPanel"
        Me.adminRegBgPanel.Size = New System.Drawing.Size(427, 460)
        Me.adminRegBgPanel.TabIndex = 12
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(160, 239)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(100, 90)
        Me.PictureBox3.TabIndex = 5
        Me.PictureBox3.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(212, 132)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(98, 101)
        Me.PictureBox2.TabIndex = 4
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(116, 132)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(90, 101)
        Me.PictureBox1.TabIndex = 3
        Me.PictureBox1.TabStop = False
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
        'adminRegistration
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.adminRegBgPanel)
        Me.Controls.Add(Me.adminRegPanel)
        Me.Name = "adminRegistration"
        Me.Text = "Admin Registration"
        Me.adminRegBgPanel.ResumeLayout(False)
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.adminRegPanel.ResumeLayout(False)
        Me.adminRegPanel.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents adminRegBgPanel As Panel
    Friend WithEvents adminRegPanel As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents adminPassRegTextBox As TextBox
    Friend WithEvents adminFnameRegTextBox As TextBox
    Friend WithEvents adminRegButton As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents adminUserRegTextBox As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents adminLnameRegTextBox As TextBox
    Friend WithEvents Label5 As Label
End Class
