<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class manageStudents
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
        Me.manageStudentsDataGridView = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.manageStudentsCloseButton = New Guna.UI2.WinForms.Guna2Button()
        Me.manageStudentsClearButton = New Guna.UI2.WinForms.Guna2Button()
        Me.manageStudentsDeleteButton = New Guna.UI2.WinForms.Guna2Button()
        Me.manageStudentsUpdateButton = New Guna.UI2.WinForms.Guna2Button()
        Me.manageStudentsLastTextBox = New Guna.UI2.WinForms.Guna2TextBox()
        Me.manageStudentsYearTextBox = New Guna.UI2.WinForms.Guna2TextBox()
        Me.managesStudentsFirstTextBox = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.manageStudentsUsernameTextBox = New Guna.UI2.WinForms.Guna2TextBox()
        Me.manageStudentsPasswordTextBox = New Guna.UI2.WinForms.Guna2TextBox()
        Me.manageStudentsCourseTextBox = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.manageStudentsSectionTextBox = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        CType(Me.manageStudentsDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'manageStudentsDataGridView
        '
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        Me.manageStudentsDataGridView.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.manageStudentsDataGridView.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.manageStudentsDataGridView.ColumnHeadersHeight = 4
        Me.manageStudentsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.manageStudentsDataGridView.DefaultCellStyle = DataGridViewCellStyle3
        Me.manageStudentsDataGridView.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.manageStudentsDataGridView.Location = New System.Drawing.Point(12, 230)
        Me.manageStudentsDataGridView.Name = "manageStudentsDataGridView"
        Me.manageStudentsDataGridView.RowHeadersVisible = False
        Me.manageStudentsDataGridView.Size = New System.Drawing.Size(776, 208)
        Me.manageStudentsDataGridView.TabIndex = 16
        Me.manageStudentsDataGridView.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White
        Me.manageStudentsDataGridView.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.manageStudentsDataGridView.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.manageStudentsDataGridView.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.manageStudentsDataGridView.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.manageStudentsDataGridView.ThemeStyle.BackColor = System.Drawing.Color.White
        Me.manageStudentsDataGridView.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.manageStudentsDataGridView.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.manageStudentsDataGridView.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.manageStudentsDataGridView.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.manageStudentsDataGridView.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.manageStudentsDataGridView.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.manageStudentsDataGridView.ThemeStyle.HeaderStyle.Height = 4
        Me.manageStudentsDataGridView.ThemeStyle.ReadOnly = False
        Me.manageStudentsDataGridView.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White
        Me.manageStudentsDataGridView.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.manageStudentsDataGridView.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.manageStudentsDataGridView.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.manageStudentsDataGridView.ThemeStyle.RowsStyle.Height = 22
        Me.manageStudentsDataGridView.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.manageStudentsDataGridView.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Goldenrod
        Me.Label5.Location = New System.Drawing.Point(12, 9)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(158, 16)
        Me.Label5.TabIndex = 21
        Me.Label5.Text = "MANAGE STUDENTS"
        '
        'manageStudentsCloseButton
        '
        Me.manageStudentsCloseButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.manageStudentsCloseButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.manageStudentsCloseButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.manageStudentsCloseButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.manageStudentsCloseButton.FillColor = System.Drawing.Color.Goldenrod
        Me.manageStudentsCloseButton.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.manageStudentsCloseButton.ForeColor = System.Drawing.Color.Black
        Me.manageStudentsCloseButton.Location = New System.Drawing.Point(665, 184)
        Me.manageStudentsCloseButton.Name = "manageStudentsCloseButton"
        Me.manageStudentsCloseButton.Size = New System.Drawing.Size(123, 31)
        Me.manageStudentsCloseButton.TabIndex = 35
        Me.manageStudentsCloseButton.Text = "CLOSE"
        '
        'manageStudentsClearButton
        '
        Me.manageStudentsClearButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.manageStudentsClearButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.manageStudentsClearButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.manageStudentsClearButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.manageStudentsClearButton.FillColor = System.Drawing.Color.Goldenrod
        Me.manageStudentsClearButton.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.manageStudentsClearButton.ForeColor = System.Drawing.Color.Black
        Me.manageStudentsClearButton.Location = New System.Drawing.Point(665, 135)
        Me.manageStudentsClearButton.Name = "manageStudentsClearButton"
        Me.manageStudentsClearButton.Size = New System.Drawing.Size(123, 31)
        Me.manageStudentsClearButton.TabIndex = 34
        Me.manageStudentsClearButton.Text = "CLEAR"
        '
        'manageStudentsDeleteButton
        '
        Me.manageStudentsDeleteButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.manageStudentsDeleteButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.manageStudentsDeleteButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.manageStudentsDeleteButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.manageStudentsDeleteButton.FillColor = System.Drawing.Color.Goldenrod
        Me.manageStudentsDeleteButton.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.manageStudentsDeleteButton.ForeColor = System.Drawing.Color.Black
        Me.manageStudentsDeleteButton.Location = New System.Drawing.Point(665, 87)
        Me.manageStudentsDeleteButton.Name = "manageStudentsDeleteButton"
        Me.manageStudentsDeleteButton.Size = New System.Drawing.Size(123, 31)
        Me.manageStudentsDeleteButton.TabIndex = 33
        Me.manageStudentsDeleteButton.Text = "DELETE"
        '
        'manageStudentsUpdateButton
        '
        Me.manageStudentsUpdateButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.manageStudentsUpdateButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.manageStudentsUpdateButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.manageStudentsUpdateButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.manageStudentsUpdateButton.FillColor = System.Drawing.Color.Goldenrod
        Me.manageStudentsUpdateButton.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.manageStudentsUpdateButton.ForeColor = System.Drawing.Color.Black
        Me.manageStudentsUpdateButton.Location = New System.Drawing.Point(665, 37)
        Me.manageStudentsUpdateButton.Name = "manageStudentsUpdateButton"
        Me.manageStudentsUpdateButton.Size = New System.Drawing.Size(123, 31)
        Me.manageStudentsUpdateButton.TabIndex = 32
        Me.manageStudentsUpdateButton.Text = "UPDATE"
        '
        'manageStudentsLastTextBox
        '
        Me.manageStudentsLastTextBox.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.manageStudentsLastTextBox.DefaultText = ""
        Me.manageStudentsLastTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.manageStudentsLastTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.manageStudentsLastTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.manageStudentsLastTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.manageStudentsLastTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.manageStudentsLastTextBox.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.manageStudentsLastTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.manageStudentsLastTextBox.Location = New System.Drawing.Point(117, 94)
        Me.manageStudentsLastTextBox.Name = "manageStudentsLastTextBox"
        Me.manageStudentsLastTextBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.manageStudentsLastTextBox.PlaceholderText = ""
        Me.manageStudentsLastTextBox.SelectedText = ""
        Me.manageStudentsLastTextBox.Size = New System.Drawing.Size(200, 23)
        Me.manageStudentsLastTextBox.TabIndex = 30
        '
        'manageStudentsYearTextBox
        '
        Me.manageStudentsYearTextBox.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.manageStudentsYearTextBox.DefaultText = ""
        Me.manageStudentsYearTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.manageStudentsYearTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.manageStudentsYearTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.manageStudentsYearTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.manageStudentsYearTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.manageStudentsYearTextBox.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.manageStudentsYearTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.manageStudentsYearTextBox.Location = New System.Drawing.Point(117, 136)
        Me.manageStudentsYearTextBox.Name = "manageStudentsYearTextBox"
        Me.manageStudentsYearTextBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.manageStudentsYearTextBox.PlaceholderText = ""
        Me.manageStudentsYearTextBox.SelectedText = ""
        Me.manageStudentsYearTextBox.Size = New System.Drawing.Size(200, 23)
        Me.manageStudentsYearTextBox.TabIndex = 29
        '
        'managesStudentsFirstTextBox
        '
        Me.managesStudentsFirstTextBox.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.managesStudentsFirstTextBox.DefaultText = ""
        Me.managesStudentsFirstTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.managesStudentsFirstTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.managesStudentsFirstTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.managesStudentsFirstTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.managesStudentsFirstTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.managesStudentsFirstTextBox.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.managesStudentsFirstTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.managesStudentsFirstTextBox.Location = New System.Drawing.Point(117, 53)
        Me.managesStudentsFirstTextBox.Name = "managesStudentsFirstTextBox"
        Me.managesStudentsFirstTextBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.managesStudentsFirstTextBox.PlaceholderText = ""
        Me.managesStudentsFirstTextBox.SelectedText = ""
        Me.managesStudentsFirstTextBox.Size = New System.Drawing.Size(200, 23)
        Me.managesStudentsFirstTextBox.TabIndex = 28
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Goldenrod
        Me.Label3.Location = New System.Drawing.Point(12, 99)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(83, 16)
        Me.Label3.TabIndex = 26
        Me.Label3.Text = "LAST NAME"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Goldenrod
        Me.Label1.Location = New System.Drawing.Point(12, 141)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(44, 16)
        Me.Label1.TabIndex = 25
        Me.Label1.Text = "YEAR"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Goldenrod
        Me.Label2.Location = New System.Drawing.Point(12, 59)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(88, 16)
        Me.Label2.TabIndex = 24
        Me.Label2.Text = "FIRST NAME"
        '
        'manageStudentsUsernameTextBox
        '
        Me.manageStudentsUsernameTextBox.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.manageStudentsUsernameTextBox.DefaultText = ""
        Me.manageStudentsUsernameTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.manageStudentsUsernameTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.manageStudentsUsernameTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.manageStudentsUsernameTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.manageStudentsUsernameTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.manageStudentsUsernameTextBox.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.manageStudentsUsernameTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.manageStudentsUsernameTextBox.Location = New System.Drawing.Point(447, 94)
        Me.manageStudentsUsernameTextBox.Name = "manageStudentsUsernameTextBox"
        Me.manageStudentsUsernameTextBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.manageStudentsUsernameTextBox.PlaceholderText = ""
        Me.manageStudentsUsernameTextBox.SelectedText = ""
        Me.manageStudentsUsernameTextBox.Size = New System.Drawing.Size(200, 23)
        Me.manageStudentsUsernameTextBox.TabIndex = 41
        '
        'manageStudentsPasswordTextBox
        '
        Me.manageStudentsPasswordTextBox.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.manageStudentsPasswordTextBox.DefaultText = ""
        Me.manageStudentsPasswordTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.manageStudentsPasswordTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.manageStudentsPasswordTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.manageStudentsPasswordTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.manageStudentsPasswordTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.manageStudentsPasswordTextBox.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.manageStudentsPasswordTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.manageStudentsPasswordTextBox.Location = New System.Drawing.Point(447, 136)
        Me.manageStudentsPasswordTextBox.Name = "manageStudentsPasswordTextBox"
        Me.manageStudentsPasswordTextBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.manageStudentsPasswordTextBox.PlaceholderText = ""
        Me.manageStudentsPasswordTextBox.SelectedText = ""
        Me.manageStudentsPasswordTextBox.Size = New System.Drawing.Size(200, 23)
        Me.manageStudentsPasswordTextBox.TabIndex = 40
        '
        'manageStudentsCourseTextBox
        '
        Me.manageStudentsCourseTextBox.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.manageStudentsCourseTextBox.DefaultText = ""
        Me.manageStudentsCourseTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.manageStudentsCourseTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.manageStudentsCourseTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.manageStudentsCourseTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.manageStudentsCourseTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.manageStudentsCourseTextBox.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.manageStudentsCourseTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.manageStudentsCourseTextBox.Location = New System.Drawing.Point(447, 53)
        Me.manageStudentsCourseTextBox.Name = "manageStudentsCourseTextBox"
        Me.manageStudentsCourseTextBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.manageStudentsCourseTextBox.PlaceholderText = ""
        Me.manageStudentsCourseTextBox.SelectedText = ""
        Me.manageStudentsCourseTextBox.Size = New System.Drawing.Size(200, 23)
        Me.manageStudentsCourseTextBox.TabIndex = 39
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Goldenrod
        Me.Label4.Location = New System.Drawing.Point(342, 101)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(84, 16)
        Me.Label4.TabIndex = 38
        Me.Label4.Text = "USERNAME"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Goldenrod
        Me.Label6.Location = New System.Drawing.Point(342, 143)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(86, 16)
        Me.Label6.TabIndex = 37
        Me.Label6.Text = "PASSWORD"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Goldenrod
        Me.Label7.Location = New System.Drawing.Point(342, 61)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(64, 16)
        Me.Label7.TabIndex = 36
        Me.Label7.Text = "COURSE"
        '
        'manageStudentsSectionTextBox
        '
        Me.manageStudentsSectionTextBox.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.manageStudentsSectionTextBox.DefaultText = ""
        Me.manageStudentsSectionTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.manageStudentsSectionTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.manageStudentsSectionTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.manageStudentsSectionTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.manageStudentsSectionTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.manageStudentsSectionTextBox.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.manageStudentsSectionTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.manageStudentsSectionTextBox.Location = New System.Drawing.Point(117, 179)
        Me.manageStudentsSectionTextBox.Name = "manageStudentsSectionTextBox"
        Me.manageStudentsSectionTextBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.manageStudentsSectionTextBox.PlaceholderText = ""
        Me.manageStudentsSectionTextBox.SelectedText = ""
        Me.manageStudentsSectionTextBox.Size = New System.Drawing.Size(200, 23)
        Me.manageStudentsSectionTextBox.TabIndex = 43
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Goldenrod
        Me.Label8.Location = New System.Drawing.Point(12, 186)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(66, 16)
        Me.Label8.TabIndex = 42
        Me.Label8.Text = "SECTION"
        '
        'manageStudents
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(56, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.manageStudentsSectionTextBox)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.manageStudentsUsernameTextBox)
        Me.Controls.Add(Me.manageStudentsPasswordTextBox)
        Me.Controls.Add(Me.manageStudentsCourseTextBox)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.manageStudentsCloseButton)
        Me.Controls.Add(Me.manageStudentsClearButton)
        Me.Controls.Add(Me.manageStudentsDeleteButton)
        Me.Controls.Add(Me.manageStudentsUpdateButton)
        Me.Controls.Add(Me.manageStudentsLastTextBox)
        Me.Controls.Add(Me.manageStudentsYearTextBox)
        Me.Controls.Add(Me.managesStudentsFirstTextBox)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.manageStudentsDataGridView)
        Me.Name = "manageStudents"
        Me.Text = "Manage Students"
        CType(Me.manageStudentsDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents manageStudentsDataGridView As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents Label5 As Label
    Friend WithEvents manageStudentsCloseButton As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents manageStudentsClearButton As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents manageStudentsDeleteButton As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents manageStudentsUpdateButton As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents manageStudentsLastTextBox As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents manageStudentsYearTextBox As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents managesStudentsFirstTextBox As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents manageStudentsUsernameTextBox As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents manageStudentsPasswordTextBox As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents manageStudentsCourseTextBox As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents manageStudentsSectionTextBox As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label8 As Label
End Class
