Public Class welcomePage
    Private Sub studentBtn_Click(sender As Object, e As EventArgs) Handles studentBtn.Click
        studentLogin.Show()
    End Sub

    Private Sub librarianBtn_Click(sender As Object, e As EventArgs) Handles librarianBtn.Click
        librarianLogin.Show()
    End Sub

    Private Sub welcomeLabel_Click(sender As Object, e As EventArgs) Handles welcomeLabel.Click

    End Sub

    Private Sub welcomePage_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim screenWidth As Integer = Screen.PrimaryScreen.WorkingArea.Width
        Dim screenHeight As Integer = Screen.PrimaryScreen.WorkingArea.Height
        Me.Location = New Point((screenWidth - Me.Width) / 2, (screenHeight - Me.Height) / 2)

    End Sub
End Class