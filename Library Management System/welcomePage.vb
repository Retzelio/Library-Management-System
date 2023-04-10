Public Class welcomePage
    Private Sub studentBtn_Click(sender As Object, e As EventArgs) Handles studentBtn.Click
        studentLogin.Show()
    End Sub

    Private Sub adminBtn_Click(sender As Object, e As EventArgs) Handles adminBtn.Click
        adminLogin.Show()
    End Sub
End Class