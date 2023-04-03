Public Class studentRegistration1
    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub studentRegNameTextBox_TextChanged(sender As Object, e As EventArgs) Handles studentRegNameTextBox.TextChanged

    End Sub

    Private Sub studentNextLogButton_Click(sender As Object, e As EventArgs) Handles studentRegLogButton.Click
        openConnnection()

        Try
            sql = "INSERT INTO student(student_firstName, studentl_lastName, year_section, course, username, password) VALUES "




        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString())
        End Try
    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Private Sub studentReg1Panel_Paint(sender As Object, e As PaintEventArgs) Handles studentReg1Panel.Paint

    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles courseLbl.Click

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles studentRegCourseTxtBox.TextChanged

    End Sub
End Class