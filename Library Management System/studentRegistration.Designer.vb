<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class studentRegistration
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(studentRegistration))
        Me.studentReg1Panel = New System.Windows.Forms.Panel()
        Me.studentRegLNameTextBox = New System.Windows.Forms.TextBox()
        Me.lastNameLbl = New System.Windows.Forms.Label()
        Me.courseLbl = New System.Windows.Forms.Label()
        Me.studentRegYearSecTextBox = New System.Windows.Forms.TextBox()
        Me.studentRegCourseTxtBox = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.studentUserRegTextBox = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.studentPassRegTextBox = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.studentRegIdTextBox = New System.Windows.Forms.TextBox()
        Me.studentRegFNameTextBox = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Guna2GroupBox1 = New Guna.UI2.WinForms.Guna2GroupBox()
        Me.Guna2Elipse1 = New Guna.UI2.WinForms.Guna2Elipse(Me.components)
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.midNameLBl = New System.Windows.Forms.Label()
        Me.studentRegLogButton = New Guna.UI2.WinForms.Guna2Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Guna2PictureBox2 = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.studentReg1Panel.SuspendLayout()
        Me.Guna2GroupBox1.SuspendLayout()
        CType(Me.Guna2PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'studentReg1Panel
        '
        Me.studentReg1Panel.BackColor = System.Drawing.Color.White
        Me.studentReg1Panel.Controls.Add(Me.Label7)
        Me.studentReg1Panel.Controls.Add(Me.studentRegLogButton)
        Me.studentReg1Panel.Controls.Add(Me.TextBox1)
        Me.studentReg1Panel.Controls.Add(Me.midNameLBl)
        Me.studentReg1Panel.Controls.Add(Me.studentRegLNameTextBox)
        Me.studentReg1Panel.Controls.Add(Me.lastNameLbl)
        Me.studentReg1Panel.Controls.Add(Me.courseLbl)
        Me.studentReg1Panel.Controls.Add(Me.studentRegYearSecTextBox)
        Me.studentReg1Panel.Controls.Add(Me.studentRegCourseTxtBox)
        Me.studentReg1Panel.Controls.Add(Me.Label4)
        Me.studentReg1Panel.Controls.Add(Me.studentUserRegTextBox)
        Me.studentReg1Panel.Controls.Add(Me.Label5)
        Me.studentReg1Panel.Controls.Add(Me.studentPassRegTextBox)
        Me.studentReg1Panel.Controls.Add(Me.Label6)
        Me.studentReg1Panel.Controls.Add(Me.Label3)
        Me.studentReg1Panel.Controls.Add(Me.studentRegIdTextBox)
        Me.studentReg1Panel.Controls.Add(Me.studentRegFNameTextBox)
        Me.studentReg1Panel.Controls.Add(Me.Label1)
        Me.studentReg1Panel.Controls.Add(Me.Label2)
        Me.studentReg1Panel.Location = New System.Drawing.Point(40, 40)
        Me.studentReg1Panel.Name = "studentReg1Panel"
        Me.studentReg1Panel.Size = New System.Drawing.Size(510, 468)
        Me.studentReg1Panel.TabIndex = 0
        '
        'studentRegLNameTextBox
        '
        Me.studentRegLNameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.studentRegLNameTextBox.Font = New System.Drawing.Font("Poppins Light", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.studentRegLNameTextBox.Location = New System.Drawing.Point(34, 206)
        Me.studentRegLNameTextBox.Multiline = True
        Me.studentRegLNameTextBox.Name = "studentRegLNameTextBox"
        Me.studentRegLNameTextBox.Size = New System.Drawing.Size(190, 28)
        Me.studentRegLNameTextBox.TabIndex = 2
        '
        'lastNameLbl
        '
        Me.lastNameLbl.AutoSize = True
        Me.lastNameLbl.Font = New System.Drawing.Font("Schibsted Grotesk Medium", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lastNameLbl.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(71, Byte), Integer))
        Me.lastNameLbl.Location = New System.Drawing.Point(31, 187)
        Me.lastNameLbl.Name = "lastNameLbl"
        Me.lastNameLbl.Size = New System.Drawing.Size(81, 20)
        Me.lastNameLbl.TabIndex = 3
        Me.lastNameLbl.Text = "LASTNAME"
        '
        'courseLbl
        '
        Me.courseLbl.AutoSize = True
        Me.courseLbl.Font = New System.Drawing.Font("Schibsted Grotesk Medium", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.courseLbl.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(71, Byte), Integer))
        Me.courseLbl.Location = New System.Drawing.Point(32, 298)
        Me.courseLbl.Name = "courseLbl"
        Me.courseLbl.Size = New System.Drawing.Size(61, 20)
        Me.courseLbl.TabIndex = 14
        Me.courseLbl.Text = "COURSE"
        '
        'studentRegYearSecTextBox
        '
        Me.studentRegYearSecTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.studentRegYearSecTextBox.Font = New System.Drawing.Font("Poppins Light", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.studentRegYearSecTextBox.Location = New System.Drawing.Point(275, 151)
        Me.studentRegYearSecTextBox.Multiline = True
        Me.studentRegYearSecTextBox.Name = "studentRegYearSecTextBox"
        Me.studentRegYearSecTextBox.Size = New System.Drawing.Size(190, 28)
        Me.studentRegYearSecTextBox.TabIndex = 5
        '
        'studentRegCourseTxtBox
        '
        Me.studentRegCourseTxtBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.studentRegCourseTxtBox.Font = New System.Drawing.Font("Poppins Light", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.studentRegCourseTxtBox.Location = New System.Drawing.Point(35, 319)
        Me.studentRegCourseTxtBox.Multiline = True
        Me.studentRegCourseTxtBox.Name = "studentRegCourseTxtBox"
        Me.studentRegCourseTxtBox.Size = New System.Drawing.Size(190, 28)
        Me.studentRegCourseTxtBox.TabIndex = 4
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Schibsted Grotesk Medium", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(71, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(272, 132)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(135, 20)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "YEAR AND SECTION"
        '
        'studentUserRegTextBox
        '
        Me.studentUserRegTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.studentUserRegTextBox.Font = New System.Drawing.Font("Poppins Light", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.studentUserRegTextBox.Location = New System.Drawing.Point(277, 262)
        Me.studentUserRegTextBox.Multiline = True
        Me.studentUserRegTextBox.Name = "studentUserRegTextBox"
        Me.studentUserRegTextBox.Size = New System.Drawing.Size(190, 28)
        Me.studentUserRegTextBox.TabIndex = 7
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Schibsted Grotesk Medium", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(71, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(275, 299)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(80, 20)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "PASSWORD"
        '
        'studentPassRegTextBox
        '
        Me.studentPassRegTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.studentPassRegTextBox.Font = New System.Drawing.Font("Poppins Light", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.studentPassRegTextBox.Location = New System.Drawing.Point(278, 319)
        Me.studentPassRegTextBox.Multiline = True
        Me.studentPassRegTextBox.Name = "studentPassRegTextBox"
        Me.studentPassRegTextBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.studentPassRegTextBox.Size = New System.Drawing.Size(190, 28)
        Me.studentPassRegTextBox.TabIndex = 8
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Schibsted Grotesk Medium", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(71, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(274, 243)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(81, 20)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "USERNAME"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Schibsted Grotesk Medium", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(71, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(273, 187)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(81, 20)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "ID NUMBER"
        '
        'studentRegIdTextBox
        '
        Me.studentRegIdTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.studentRegIdTextBox.Font = New System.Drawing.Font("Poppins Light", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.studentRegIdTextBox.Location = New System.Drawing.Point(275, 208)
        Me.studentRegIdTextBox.Multiline = True
        Me.studentRegIdTextBox.Name = "studentRegIdTextBox"
        Me.studentRegIdTextBox.Size = New System.Drawing.Size(190, 28)
        Me.studentRegIdTextBox.TabIndex = 6
        '
        'studentRegFNameTextBox
        '
        Me.studentRegFNameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.studentRegFNameTextBox.Font = New System.Drawing.Font("Poppins Light", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.studentRegFNameTextBox.Location = New System.Drawing.Point(34, 151)
        Me.studentRegFNameTextBox.Multiline = True
        Me.studentRegFNameTextBox.Name = "studentRegFNameTextBox"
        Me.studentRegFNameTextBox.Size = New System.Drawing.Size(190, 28)
        Me.studentRegFNameTextBox.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Schibsted Grotesk ExtraBold", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(20, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(294, 40)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "STUDENT REGISTER"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Schibsted Grotesk Medium", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(71, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(31, 132)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(85, 20)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "FIRSTNAME"
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
        Me.Guna2GroupBox1.Location = New System.Drawing.Point(602, 6)
        Me.Guna2GroupBox1.Name = "Guna2GroupBox1"
        Me.Guna2GroupBox1.Size = New System.Drawing.Size(423, 533)
        Me.Guna2GroupBox1.TabIndex = 2
        '
        'TextBox1
        '
        Me.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox1.Font = New System.Drawing.Font("Poppins Light", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(34, 262)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(190, 28)
        Me.TextBox1.TabIndex = 3
        '
        'midNameLBl
        '
        Me.midNameLBl.AutoSize = True
        Me.midNameLBl.Font = New System.Drawing.Font("Schibsted Grotesk Medium", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.midNameLBl.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(71, Byte), Integer))
        Me.midNameLBl.Location = New System.Drawing.Point(31, 243)
        Me.midNameLBl.Name = "midNameLBl"
        Me.midNameLBl.Size = New System.Drawing.Size(98, 20)
        Me.midNameLBl.TabIndex = 16
        Me.midNameLBl.Text = "MIDDLENAME"
        '
        'studentRegLogButton
        '
        Me.studentRegLogButton.BorderRadius = 20
        Me.studentRegLogButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.studentRegLogButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.studentRegLogButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.studentRegLogButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.studentRegLogButton.FillColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(186, Byte), Integer), CType(CType(108, Byte), Integer))
        Me.studentRegLogButton.Font = New System.Drawing.Font("Rubik SemiBold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.studentRegLogButton.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(7, Byte), Integer))
        Me.studentRegLogButton.Location = New System.Drawing.Point(282, 377)
        Me.studentRegLogButton.Name = "studentRegLogButton"
        Me.studentRegLogButton.Size = New System.Drawing.Size(185, 38)
        Me.studentRegLogButton.TabIndex = 9
        Me.studentRegLogButton.Text = "REGISTER"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Poppins", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(27, 58)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(207, 19)
        Me.Label7.TabIndex = 19
        Me.Label7.Text = "Please enter your information below"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Poppins Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(186, Byte), Integer), CType(CType(108, Byte), Integer))
        Me.Label8.Location = New System.Drawing.Point(37, 74)
        Me.Label8.MaximumSize = New System.Drawing.Size(400, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(354, 56)
        Me.Label8.TabIndex = 20
        Me.Label8.Text = """Connect to the world's knowledge with our library system."""
        '
        'Guna2PictureBox2
        '
        Me.Guna2PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.Guna2PictureBox2.Image = CType(resources.GetObject("Guna2PictureBox2.Image"), System.Drawing.Image)
        Me.Guna2PictureBox2.ImageRotate = 0!
        Me.Guna2PictureBox2.Location = New System.Drawing.Point(89, 172)
        Me.Guna2PictureBox2.Name = "Guna2PictureBox2"
        Me.Guna2PictureBox2.Size = New System.Drawing.Size(256, 256)
        Me.Guna2PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.Guna2PictureBox2.TabIndex = 22
        Me.Guna2PictureBox2.TabStop = False
        '
        'studentRegistration
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1039, 548)
        Me.Controls.Add(Me.Guna2GroupBox1)
        Me.Controls.Add(Me.studentReg1Panel)
        Me.Name = "studentRegistration"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Student Registration 1"
        Me.studentReg1Panel.ResumeLayout(False)
        Me.studentReg1Panel.PerformLayout()
        Me.Guna2GroupBox1.ResumeLayout(False)
        Me.Guna2GroupBox1.PerformLayout()
        CType(Me.Guna2PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents studentReg1Panel As Panel
    Friend WithEvents studentRegFNameTextBox As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents studentRegYearSecTextBox As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents studentRegIdTextBox As TextBox
    Friend WithEvents studentUserRegTextBox As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents studentPassRegTextBox As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents courseLbl As Label
    Friend WithEvents studentRegCourseTxtBox As TextBox
    Friend WithEvents studentRegLNameTextBox As TextBox
    Friend WithEvents lastNameLbl As Label
    Friend WithEvents Guna2GroupBox1 As Guna.UI2.WinForms.Guna2GroupBox
    Friend WithEvents Guna2Elipse1 As Guna.UI2.WinForms.Guna2Elipse
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents midNameLBl As Label
    Friend WithEvents studentRegLogButton As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Guna2PictureBox2 As Guna.UI2.WinForms.Guna2PictureBox
End Class
