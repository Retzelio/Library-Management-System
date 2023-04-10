Public Class welcomePage
    Private Sub studentBtn_Click(sender As Object, e As EventArgs) Handles studentBtn.Click
        studentLogin.Show()
    End Sub

    Private Sub librarianBtn_Click(sender As Object, e As EventArgs) Handles librarianBtn.Click
        librarianLogin.Show()
    End Sub
End Class