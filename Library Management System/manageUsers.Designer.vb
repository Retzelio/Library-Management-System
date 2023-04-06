<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class manageUsers
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(manageUsers))
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.manageUsersNameTextBox = New Guna.UI2.WinForms.Guna2TextBox()
        Me.manageUsersPassTextBox = New Guna.UI2.WinForms.Guna2TextBox()
        Me.manageUsersUsernameTextBox = New Guna.UI2.WinForms.Guna2TextBox()
        Me.manageUsersTypeComboBox = New System.Windows.Forms.ComboBox()
        Me.Guna2DataGridView1 = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.manageUsersUpdateButton = New Guna.UI2.WinForms.Guna2Button()
        Me.manageUsersDeleteButton = New Guna.UI2.WinForms.Guna2Button()
        Me.manageUsersClearButton = New Guna.UI2.WinForms.Guna2Button()
        Me.manageUsersCloseButton = New Guna.UI2.WinForms.Guna2Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Guna2PictureBox1 = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.Guna2PictureBox2 = New Guna.UI2.WinForms.Guna2PictureBox()
        CType(Me.Guna2DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Guna2PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Goldenrod
        Me.Label2.Location = New System.Drawing.Point(18, 62)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(46, 16)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "NAME"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Goldenrod
        Me.Label1.Location = New System.Drawing.Point(18, 148)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(86, 16)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "PASSWORD"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Goldenrod
        Me.Label3.Location = New System.Drawing.Point(20, 105)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(84, 16)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "USERNAME"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Goldenrod
        Me.Label4.Location = New System.Drawing.Point(18, 190)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(43, 16)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "TYPE"
        '
        'manageUsersNameTextBox
        '
        Me.manageUsersNameTextBox.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.manageUsersNameTextBox.DefaultText = ""
        Me.manageUsersNameTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.manageUsersNameTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.manageUsersNameTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.manageUsersNameTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.manageUsersNameTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.manageUsersNameTextBox.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.manageUsersNameTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.manageUsersNameTextBox.Location = New System.Drawing.Point(121, 62)
        Me.manageUsersNameTextBox.Name = "manageUsersNameTextBox"
        Me.manageUsersNameTextBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.manageUsersNameTextBox.PlaceholderText = ""
        Me.manageUsersNameTextBox.SelectedText = ""
        Me.manageUsersNameTextBox.Size = New System.Drawing.Size(200, 23)
        Me.manageUsersNameTextBox.TabIndex = 10
        '
        'manageUsersPassTextBox
        '
        Me.manageUsersPassTextBox.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.manageUsersPassTextBox.DefaultText = ""
        Me.manageUsersPassTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.manageUsersPassTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.manageUsersPassTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.manageUsersPassTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.manageUsersPassTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.manageUsersPassTextBox.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.manageUsersPassTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.manageUsersPassTextBox.Location = New System.Drawing.Point(121, 148)
        Me.manageUsersPassTextBox.Name = "manageUsersPassTextBox"
        Me.manageUsersPassTextBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.manageUsersPassTextBox.PlaceholderText = ""
        Me.manageUsersPassTextBox.SelectedText = ""
        Me.manageUsersPassTextBox.Size = New System.Drawing.Size(200, 23)
        Me.manageUsersPassTextBox.TabIndex = 12
        '
        'manageUsersUsernameTextBox
        '
        Me.manageUsersUsernameTextBox.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.manageUsersUsernameTextBox.DefaultText = ""
        Me.manageUsersUsernameTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.manageUsersUsernameTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.manageUsersUsernameTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.manageUsersUsernameTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.manageUsersUsernameTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.manageUsersUsernameTextBox.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.manageUsersUsernameTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.manageUsersUsernameTextBox.Location = New System.Drawing.Point(121, 105)
        Me.manageUsersUsernameTextBox.Name = "manageUsersUsernameTextBox"
        Me.manageUsersUsernameTextBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.manageUsersUsernameTextBox.PlaceholderText = ""
        Me.manageUsersUsernameTextBox.SelectedText = ""
        Me.manageUsersUsernameTextBox.Size = New System.Drawing.Size(200, 23)
        Me.manageUsersUsernameTextBox.TabIndex = 13
        '
        'manageUsersTypeComboBox
        '
        Me.manageUsersTypeComboBox.FormattingEnabled = True
        Me.manageUsersTypeComboBox.Location = New System.Drawing.Point(121, 185)
        Me.manageUsersTypeComboBox.Name = "manageUsersTypeComboBox"
        Me.manageUsersTypeComboBox.Size = New System.Drawing.Size(200, 21)
        Me.manageUsersTypeComboBox.TabIndex = 14
        '
        'Guna2DataGridView1
        '
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        Me.Guna2DataGridView1.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Guna2DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.Guna2DataGridView1.ColumnHeadersHeight = 4
        Me.Guna2DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Guna2DataGridView1.DefaultCellStyle = DataGridViewCellStyle3
        Me.Guna2DataGridView1.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2DataGridView1.Location = New System.Drawing.Point(21, 269)
        Me.Guna2DataGridView1.Name = "Guna2DataGridView1"
        Me.Guna2DataGridView1.RowHeadersVisible = False
        Me.Guna2DataGridView1.Size = New System.Drawing.Size(554, 208)
        Me.Guna2DataGridView1.TabIndex = 15
        Me.Guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White
        Me.Guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.Guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.Guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.Guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.Guna2DataGridView1.ThemeStyle.BackColor = System.Drawing.Color.White
        Me.Guna2DataGridView1.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2DataGridView1.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2DataGridView1.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.Guna2DataGridView1.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2DataGridView1.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.Guna2DataGridView1.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.Guna2DataGridView1.ThemeStyle.HeaderStyle.Height = 4
        Me.Guna2DataGridView1.ThemeStyle.ReadOnly = False
        Me.Guna2DataGridView1.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White
        Me.Guna2DataGridView1.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.Guna2DataGridView1.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2DataGridView1.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.Guna2DataGridView1.ThemeStyle.RowsStyle.Height = 22
        Me.Guna2DataGridView1.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2DataGridView1.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        '
        'manageUsersUpdateButton
        '
        Me.manageUsersUpdateButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.manageUsersUpdateButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.manageUsersUpdateButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.manageUsersUpdateButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.manageUsersUpdateButton.FillColor = System.Drawing.Color.Goldenrod
        Me.manageUsersUpdateButton.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.manageUsersUpdateButton.ForeColor = System.Drawing.Color.Black
        Me.manageUsersUpdateButton.Location = New System.Drawing.Point(41, 221)
        Me.manageUsersUpdateButton.Name = "manageUsersUpdateButton"
        Me.manageUsersUpdateButton.Size = New System.Drawing.Size(123, 31)
        Me.manageUsersUpdateButton.TabIndex = 16
        Me.manageUsersUpdateButton.Text = "UPDATE"
        '
        'manageUsersDeleteButton
        '
        Me.manageUsersDeleteButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.manageUsersDeleteButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.manageUsersDeleteButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.manageUsersDeleteButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.manageUsersDeleteButton.FillColor = System.Drawing.Color.Goldenrod
        Me.manageUsersDeleteButton.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.manageUsersDeleteButton.ForeColor = System.Drawing.Color.Black
        Me.manageUsersDeleteButton.Location = New System.Drawing.Point(170, 221)
        Me.manageUsersDeleteButton.Name = "manageUsersDeleteButton"
        Me.manageUsersDeleteButton.Size = New System.Drawing.Size(123, 31)
        Me.manageUsersDeleteButton.TabIndex = 17
        Me.manageUsersDeleteButton.Text = "DELETE"
        '
        'manageUsersClearButton
        '
        Me.manageUsersClearButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.manageUsersClearButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.manageUsersClearButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.manageUsersClearButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.manageUsersClearButton.FillColor = System.Drawing.Color.Goldenrod
        Me.manageUsersClearButton.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.manageUsersClearButton.ForeColor = System.Drawing.Color.Black
        Me.manageUsersClearButton.Location = New System.Drawing.Point(299, 221)
        Me.manageUsersClearButton.Name = "manageUsersClearButton"
        Me.manageUsersClearButton.Size = New System.Drawing.Size(123, 31)
        Me.manageUsersClearButton.TabIndex = 18
        Me.manageUsersClearButton.Text = "CLEAR"
        '
        'manageUsersCloseButton
        '
        Me.manageUsersCloseButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.manageUsersCloseButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.manageUsersCloseButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.manageUsersCloseButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.manageUsersCloseButton.FillColor = System.Drawing.Color.Goldenrod
        Me.manageUsersCloseButton.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.manageUsersCloseButton.ForeColor = System.Drawing.Color.Black
        Me.manageUsersCloseButton.Location = New System.Drawing.Point(428, 221)
        Me.manageUsersCloseButton.Name = "manageUsersCloseButton"
        Me.manageUsersCloseButton.Size = New System.Drawing.Size(123, 31)
        Me.manageUsersCloseButton.TabIndex = 19
        Me.manageUsersCloseButton.Text = "CLOSE"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Goldenrod
        Me.Label5.Location = New System.Drawing.Point(15, 9)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(127, 16)
        Me.Label5.TabIndex = 20
        Me.Label5.Text = "MANAGE USERS"
        '
        'Guna2PictureBox1
        '
        Me.Guna2PictureBox1.Image = CType(resources.GetObject("Guna2PictureBox1.Image"), System.Drawing.Image)
        Me.Guna2PictureBox1.ImageRotate = 0!
        Me.Guna2PictureBox1.Location = New System.Drawing.Point(365, 91)
        Me.Guna2PictureBox1.Name = "Guna2PictureBox1"
        Me.Guna2PictureBox1.Size = New System.Drawing.Size(70, 69)
        Me.Guna2PictureBox1.TabIndex = 22
        Me.Guna2PictureBox1.TabStop = False
        '
        'Guna2PictureBox2
        '
        Me.Guna2PictureBox2.Image = CType(resources.GetObject("Guna2PictureBox2.Image"), System.Drawing.Image)
        Me.Guna2PictureBox2.ImageRotate = 0!
        Me.Guna2PictureBox2.Location = New System.Drawing.Point(455, 91)
        Me.Guna2PictureBox2.Name = "Guna2PictureBox2"
        Me.Guna2PictureBox2.Size = New System.Drawing.Size(70, 69)
        Me.Guna2PictureBox2.TabIndex = 23
        Me.Guna2PictureBox2.TabStop = False
        '
        'manageUsers
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(56, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(596, 489)
        Me.Controls.Add(Me.Guna2PictureBox2)
        Me.Controls.Add(Me.Guna2PictureBox1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.manageUsersCloseButton)
        Me.Controls.Add(Me.manageUsersClearButton)
        Me.Controls.Add(Me.manageUsersDeleteButton)
        Me.Controls.Add(Me.manageUsersUpdateButton)
        Me.Controls.Add(Me.Guna2DataGridView1)
        Me.Controls.Add(Me.manageUsersTypeComboBox)
        Me.Controls.Add(Me.manageUsersUsernameTextBox)
        Me.Controls.Add(Me.manageUsersPassTextBox)
        Me.Controls.Add(Me.manageUsersNameTextBox)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label2)
        Me.Name = "manageUsers"
        Me.Text = "Manage Users"
        CType(Me.Guna2DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Guna2PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents manageUsersNameTextBox As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents manageUsersPassTextBox As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents manageUsersUsernameTextBox As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents manageUsersTypeComboBox As ComboBox
    Friend WithEvents Guna2DataGridView1 As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents manageUsersUpdateButton As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents manageUsersDeleteButton As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents manageUsersClearButton As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents manageUsersCloseButton As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Label5 As Label
    Friend WithEvents Guna2PictureBox1 As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents Guna2PictureBox2 As Guna.UI2.WinForms.Guna2PictureBox
End Class
