<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class studentRegistration1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(studentRegistration1))
        Me.studentReg1BgPanel = New System.Windows.Forms.Panel()
        Me.studentReg1Panel = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.studentRegIdTextBox = New System.Windows.Forms.TextBox()
        Me.studentRegNameTextBox = New System.Windows.Forms.TextBox()
        Me.studentNextLogButton = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.studentRegYearTextBox = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.studentReg1BgPanel.SuspendLayout()
        Me.studentReg1Panel.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'studentReg1BgPanel
        '
        Me.studentReg1BgPanel.BackColor = System.Drawing.Color.MediumBlue
        Me.studentReg1BgPanel.Controls.Add(Me.PictureBox3)
        Me.studentReg1BgPanel.Controls.Add(Me.PictureBox2)
        Me.studentReg1BgPanel.Controls.Add(Me.PictureBox1)
        Me.studentReg1BgPanel.Location = New System.Drawing.Point(374, 0)
        Me.studentReg1BgPanel.Name = "studentReg1BgPanel"
        Me.studentReg1BgPanel.Size = New System.Drawing.Size(427, 460)
        Me.studentReg1BgPanel.TabIndex = 10
        '
        'studentReg1Panel
        '
        Me.studentReg1Panel.BackColor = System.Drawing.Color.MediumBlue
        Me.studentReg1Panel.Controls.Add(Me.Label3)
        Me.studentReg1Panel.Controls.Add(Me.studentRegIdTextBox)
        Me.studentReg1Panel.Controls.Add(Me.studentRegNameTextBox)
        Me.studentReg1Panel.Controls.Add(Me.studentNextLogButton)
        Me.studentReg1Panel.Controls.Add(Me.Label1)
        Me.studentReg1Panel.Controls.Add(Me.Label4)
        Me.studentReg1Panel.Controls.Add(Me.studentRegYearTextBox)
        Me.studentReg1Panel.Controls.Add(Me.Label2)
        Me.studentReg1Panel.Location = New System.Drawing.Point(48, 40)
        Me.studentReg1Panel.Name = "studentReg1Panel"
        Me.studentReg1Panel.Size = New System.Drawing.Size(259, 355)
        Me.studentReg1Panel.TabIndex = 9
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(33, 199)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(82, 16)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "ID NUMBER"
        '
        'studentRegIdTextBox
        '
        Me.studentRegIdTextBox.Location = New System.Drawing.Point(36, 218)
        Me.studentRegIdTextBox.Multiline = True
        Me.studentRegIdTextBox.Name = "studentRegIdTextBox"
        Me.studentRegIdTextBox.Size = New System.Drawing.Size(180, 22)
        Me.studentRegIdTextBox.TabIndex = 7
        '
        'studentRegNameTextBox
        '
        Me.studentRegNameTextBox.Location = New System.Drawing.Point(36, 96)
        Me.studentRegNameTextBox.Multiline = True
        Me.studentRegNameTextBox.Name = "studentRegNameTextBox"
        Me.studentRegNameTextBox.Size = New System.Drawing.Size(180, 22)
        Me.studentRegNameTextBox.TabIndex = 6
        '
        'studentNextLogButton
        '
        Me.studentNextLogButton.BackColor = System.Drawing.Color.Goldenrod
        Me.studentNextLogButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.studentNextLogButton.Location = New System.Drawing.Point(36, 274)
        Me.studentNextLogButton.Name = "studentNextLogButton"
        Me.studentNextLogButton.Size = New System.Drawing.Size(180, 29)
        Me.studentNextLogButton.TabIndex = 1
        Me.studentNextLogButton.Text = "NEXT"
        Me.studentNextLogButton.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Goldenrod
        Me.Label1.Location = New System.Drawing.Point(21, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(214, 24)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "STUDENT REGISTER"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(33, 137)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(138, 16)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "YEAR AND SECTION"
        '
        'studentRegYearTextBox
        '
        Me.studentRegYearTextBox.Location = New System.Drawing.Point(36, 156)
        Me.studentRegYearTextBox.Multiline = True
        Me.studentRegYearTextBox.Name = "studentRegYearTextBox"
        Me.studentRegYearTextBox.Size = New System.Drawing.Size(180, 22)
        Me.studentRegYearTextBox.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(33, 77)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(46, 16)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "NAME"
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
        'studentRegistration1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.studentReg1BgPanel)
        Me.Controls.Add(Me.studentReg1Panel)
        Me.Name = "studentRegistration1"
        Me.Text = "Student Registration 1"
        Me.studentReg1BgPanel.ResumeLayout(False)
        Me.studentReg1Panel.ResumeLayout(False)
        Me.studentReg1Panel.PerformLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents studentReg1BgPanel As Panel
    Friend WithEvents studentReg1Panel As Panel
    Friend WithEvents studentRegNameTextBox As TextBox
    Friend WithEvents studentNextLogButton As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents studentRegYearTextBox As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents studentRegIdTextBox As TextBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
End Class
