﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class studentLogin
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(studentLogin))
        Me.studentUserLogTextBox = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.studentPassLogTextBox = New System.Windows.Forms.TextBox()
        Me.studentLoginLbl = New System.Windows.Forms.Label()
        Me.studentLogPanel = New System.Windows.Forms.Panel()
        Me.studentLogBgPanel = New System.Windows.Forms.Panel()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.studentLogButton = New Guna.UI2.WinForms.Guna2Button()
        Me.studentCreateAccLbl = New System.Windows.Forms.Label()
        Me.studentLogPanel.SuspendLayout()
        Me.studentLogBgPanel.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'studentUserLogTextBox
        '
        Me.studentUserLogTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.studentUserLogTextBox.Font = New System.Drawing.Font("Poppins", 12.0!)
        Me.studentUserLogTextBox.Location = New System.Drawing.Point(33, 136)
        Me.studentUserLogTextBox.Multiline = True
        Me.studentUserLogTextBox.Name = "studentUserLogTextBox"
        Me.studentUserLogTextBox.Size = New System.Drawing.Size(190, 28)
        Me.studentUserLogTextBox.TabIndex = 1
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Poppins SemiBold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(31, 171)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(103, 28)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "PASSWORD"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Poppins SemiBold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(29, 104)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(98, 28)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "USERNAME"
        '
        'studentPassLogTextBox
        '
        Me.studentPassLogTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.studentPassLogTextBox.Font = New System.Drawing.Font("Poppins", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.studentPassLogTextBox.Location = New System.Drawing.Point(32, 202)
        Me.studentPassLogTextBox.Multiline = True
        Me.studentPassLogTextBox.Name = "studentPassLogTextBox"
        Me.studentPassLogTextBox.Size = New System.Drawing.Size(190, 28)
        Me.studentPassLogTextBox.TabIndex = 2
        '
        'studentLoginLbl
        '
        Me.studentLoginLbl.AutoSize = True
        Me.studentLoginLbl.Font = New System.Drawing.Font("Schibsted Grotesk ExtraBold", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.studentLoginLbl.ForeColor = System.Drawing.Color.White
        Me.studentLoginLbl.Location = New System.Drawing.Point(7, 27)
        Me.studentLoginLbl.Name = "studentLoginLbl"
        Me.studentLoginLbl.Size = New System.Drawing.Size(246, 40)
        Me.studentLoginLbl.TabIndex = 2
        Me.studentLoginLbl.Text = "STUDENT LOGIN"
        '
        'studentLogPanel
        '
        Me.studentLogPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(71, Byte), Integer))
        Me.studentLogPanel.Controls.Add(Me.studentCreateAccLbl)
        Me.studentLogPanel.Controls.Add(Me.studentLogButton)
        Me.studentLogPanel.Controls.Add(Me.studentUserLogTextBox)
        Me.studentLogPanel.Controls.Add(Me.studentLoginLbl)
        Me.studentLogPanel.Controls.Add(Me.Label4)
        Me.studentLogPanel.Controls.Add(Me.studentPassLogTextBox)
        Me.studentLogPanel.Controls.Add(Me.Label2)
        Me.studentLogPanel.Location = New System.Drawing.Point(48, 49)
        Me.studentLogPanel.Name = "studentLogPanel"
        Me.studentLogPanel.Size = New System.Drawing.Size(259, 355)
        Me.studentLogPanel.TabIndex = 1
        '
        'studentLogBgPanel
        '
        Me.studentLogBgPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(186, Byte), Integer), CType(CType(108, Byte), Integer))
        Me.studentLogBgPanel.Controls.Add(Me.PictureBox3)
        Me.studentLogBgPanel.Controls.Add(Me.PictureBox2)
        Me.studentLogBgPanel.Controls.Add(Me.PictureBox1)
        Me.studentLogBgPanel.Location = New System.Drawing.Point(374, 0)
        Me.studentLogBgPanel.Name = "studentLogBgPanel"
        Me.studentLogBgPanel.Size = New System.Drawing.Size(427, 460)
        Me.studentLogBgPanel.TabIndex = 8
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(160, 239)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(100, 90)
        Me.PictureBox3.TabIndex = 2
        Me.PictureBox3.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(212, 132)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(98, 101)
        Me.PictureBox2.TabIndex = 1
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(116, 132)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(90, 101)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'studentLogButton
        '
        Me.studentLogButton.BackColor = System.Drawing.Color.Transparent
        Me.studentLogButton.BorderColor = System.Drawing.Color.Transparent
        Me.studentLogButton.BorderRadius = 20
        Me.studentLogButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.studentLogButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.studentLogButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.studentLogButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.studentLogButton.FillColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(186, Byte), Integer), CType(CType(108, Byte), Integer))
        Me.studentLogButton.Font = New System.Drawing.Font("Rubik Medium", 12.0!, System.Drawing.FontStyle.Bold)
        Me.studentLogButton.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(71, Byte), Integer))
        Me.studentLogButton.Location = New System.Drawing.Point(52, 254)
        Me.studentLogButton.Name = "studentLogButton"
        Me.studentLogButton.Size = New System.Drawing.Size(146, 40)
        Me.studentLogButton.TabIndex = 6
        Me.studentLogButton.Text = "LOGIN"
        '
        'studentCreateAccLbl
        '
        Me.studentCreateAccLbl.AutoSize = True
        Me.studentCreateAccLbl.Font = New System.Drawing.Font("Poppins", 8.0!)
        Me.studentCreateAccLbl.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(186, Byte), Integer), CType(CType(108, Byte), Integer))
        Me.studentCreateAccLbl.Location = New System.Drawing.Point(70, 305)
        Me.studentCreateAccLbl.Name = "studentCreateAccLbl"
        Me.studentCreateAccLbl.Size = New System.Drawing.Size(112, 19)
        Me.studentCreateAccLbl.TabIndex = 13
        Me.studentCreateAccLbl.Text = "Create an account"
        '
        'studentLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.studentLogBgPanel)
        Me.Controls.Add(Me.studentLogPanel)
        Me.Name = "studentLogin"
        Me.Text = "Student Login"
        Me.studentLogPanel.ResumeLayout(False)
        Me.studentLogPanel.PerformLayout()
        Me.studentLogBgPanel.ResumeLayout(False)
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents studentPassLogTextBox As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents studentLoginLbl As Label
    Friend WithEvents studentUserLogTextBox As TextBox
    Friend WithEvents studentLogPanel As Panel
    Friend WithEvents studentLogBgPanel As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents studentLogButton As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents studentCreateAccLbl As Label
End Class
