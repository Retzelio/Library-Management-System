<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class studentRegistration2
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(studentRegistration2))
        Me.studentReg2BgPanel = New System.Windows.Forms.Panel()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.studentReg2Panel = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.studentUserRegTextBox = New System.Windows.Forms.TextBox()
        Me.studentRegButton = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.studentPassRegTextBox = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.studentReg2BgPanel.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.studentReg2Panel.SuspendLayout()
        Me.SuspendLayout()
        '
        'studentReg2BgPanel
        '
        Me.studentReg2BgPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(56, Byte), Integer))
        Me.studentReg2BgPanel.Controls.Add(Me.PictureBox3)
        Me.studentReg2BgPanel.Controls.Add(Me.PictureBox2)
        Me.studentReg2BgPanel.Controls.Add(Me.PictureBox1)
        Me.studentReg2BgPanel.Location = New System.Drawing.Point(374, 0)
        Me.studentReg2BgPanel.Name = "studentReg2BgPanel"
        Me.studentReg2BgPanel.Size = New System.Drawing.Size(427, 460)
        Me.studentReg2BgPanel.TabIndex = 12
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
        'studentReg2Panel
        '
        Me.studentReg2Panel.BackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(76, Byte), Integer), CType(CType(113, Byte), Integer))
        Me.studentReg2Panel.Controls.Add(Me.Label3)
        Me.studentReg2Panel.Controls.Add(Me.studentUserRegTextBox)
        Me.studentReg2Panel.Controls.Add(Me.studentRegButton)
        Me.studentReg2Panel.Controls.Add(Me.Label4)
        Me.studentReg2Panel.Controls.Add(Me.studentPassRegTextBox)
        Me.studentReg2Panel.Controls.Add(Me.Label2)
        Me.studentReg2Panel.Location = New System.Drawing.Point(48, 40)
        Me.studentReg2Panel.Name = "studentReg2Panel"
        Me.studentReg2Panel.Size = New System.Drawing.Size(259, 355)
        Me.studentReg2Panel.TabIndex = 10
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Goldenrod
        Me.Label3.Location = New System.Drawing.Point(21, 32)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(214, 24)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "STUDENT REGISTER"
        '
        'studentUserRegTextBox
        '
        Me.studentUserRegTextBox.Location = New System.Drawing.Point(36, 126)
        Me.studentUserRegTextBox.Multiline = True
        Me.studentUserRegTextBox.Name = "studentUserRegTextBox"
        Me.studentUserRegTextBox.Size = New System.Drawing.Size(180, 22)
        Me.studentUserRegTextBox.TabIndex = 6
        '
        'studentRegButton
        '
        Me.studentRegButton.BackColor = System.Drawing.Color.Goldenrod
        Me.studentRegButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.studentRegButton.Location = New System.Drawing.Point(36, 250)
        Me.studentRegButton.Name = "studentRegButton"
        Me.studentRegButton.Size = New System.Drawing.Size(180, 29)
        Me.studentRegButton.TabIndex = 1
        Me.studentRegButton.Text = "REGISTER"
        Me.studentRegButton.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(33, 167)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(86, 16)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "PASSWORD"
        '
        'studentPassRegTextBox
        '
        Me.studentPassRegTextBox.Location = New System.Drawing.Point(36, 186)
        Me.studentPassRegTextBox.Multiline = True
        Me.studentPassRegTextBox.Name = "studentPassRegTextBox"
        Me.studentPassRegTextBox.Size = New System.Drawing.Size(180, 22)
        Me.studentPassRegTextBox.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(33, 107)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(84, 16)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "USERNAME"
        '
        'studentRegistration2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.studentReg2Panel)
        Me.Controls.Add(Me.studentReg2BgPanel)
        Me.Name = "studentRegistration2"
        Me.Text = "Student Registration 2"
        Me.studentReg2BgPanel.ResumeLayout(False)
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.studentReg2Panel.ResumeLayout(False)
        Me.studentReg2Panel.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents studentReg2BgPanel As Panel
    Friend WithEvents studentReg2Panel As Panel
    Friend WithEvents studentUserRegTextBox As TextBox
    Friend WithEvents studentRegButton As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents studentPassRegTextBox As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
End Class
