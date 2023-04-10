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
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.adminLogPanel = New System.Windows.Forms.Panel()
        Me.adminUserLogTextBox = New System.Windows.Forms.TextBox()
        Me.adminLogButton = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.adminPassLogTextBox = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.adminLogBgPanel.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.adminLogPanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'adminLogBgPanel
        '
        Me.adminLogBgPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(56, Byte), Integer))
        Me.adminLogBgPanel.Controls.Add(Me.PictureBox3)
        Me.adminLogBgPanel.Controls.Add(Me.PictureBox2)
        Me.adminLogBgPanel.Controls.Add(Me.PictureBox1)
        Me.adminLogBgPanel.Location = New System.Drawing.Point(374, 0)
        Me.adminLogBgPanel.Name = "adminLogBgPanel"
        Me.adminLogBgPanel.Size = New System.Drawing.Size(427, 460)
        Me.adminLogBgPanel.TabIndex = 10
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
        'adminLogPanel
        '
        Me.adminLogPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(76, Byte), Integer), CType(CType(113, Byte), Integer))
        Me.adminLogPanel.Controls.Add(Me.adminUserLogTextBox)
        Me.adminLogPanel.Controls.Add(Me.adminLogButton)
        Me.adminLogPanel.Controls.Add(Me.Label1)
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
        Me.adminUserLogTextBox.Location = New System.Drawing.Point(36, 126)
        Me.adminUserLogTextBox.Multiline = True
        Me.adminUserLogTextBox.Name = "adminUserLogTextBox"
        Me.adminUserLogTextBox.Size = New System.Drawing.Size(180, 22)
        Me.adminUserLogTextBox.TabIndex = 0
        '
        'adminLogButton
        '
        Me.adminLogButton.BackColor = System.Drawing.Color.Goldenrod
        Me.adminLogButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.adminLogButton.Location = New System.Drawing.Point(36, 250)
        Me.adminLogButton.Name = "adminLogButton"
        Me.adminLogButton.Size = New System.Drawing.Size(180, 29)
        Me.adminLogButton.TabIndex = 2
        Me.adminLogButton.Text = "LOGIN"
        Me.adminLogButton.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(77, 33)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(92, 29)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "LOGIN"
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
        'adminPassLogTextBox
        '
        Me.adminPassLogTextBox.Location = New System.Drawing.Point(36, 186)
        Me.adminPassLogTextBox.Multiline = True
        Me.adminPassLogTextBox.Name = "adminPassLogTextBox"
        Me.adminPassLogTextBox.Size = New System.Drawing.Size(180, 22)
        Me.adminPassLogTextBox.TabIndex = 1
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
        'adminLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.adminLogBgPanel)
        Me.Controls.Add(Me.adminLogPanel)
        Me.Name = "adminLogin"
        Me.Text = "Admin Login"
        Me.adminLogBgPanel.ResumeLayout(False)
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.adminLogPanel.ResumeLayout(False)
        Me.adminLogPanel.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents adminLogBgPanel As Panel
    Friend WithEvents adminLogPanel As Panel
    Friend WithEvents adminUserLogTextBox As TextBox
    Friend WithEvents adminLogButton As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents adminPassLogTextBox As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
End Class
