﻿Imports MySql.Data.MySqlClient

Public Class studentRegistration1
    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub studentRegNameTextBox_TextChanged(sender As Object, e As EventArgs) Handles studentRegFNameTextBox.TextChanged

    End Sub

    Private Sub studentNextLogButton_Click(sender As Object, e As EventArgs) Handles studentRegLogButton.Click
        openConnnection()

        Try
            sql = "INSERT INTO student(student_firstName, student_lastName, course, year_section, student_id, username, password) VALUES ('" & studentRegFNameTextBox.Text & "', '" & studentRegLNameTextBox.Text & "' , '" & studentRegCourseTxtBox.Text & "', '" & studentRegYearSecTextBox.Text & "', '" & studentRegIdTextBox.Text & "', '" & studentUserRegTextBox.Text & "', '" & studentPassRegTextBox.Text & "')"
            cmd = New MySqlCommand(sql, connection)
            da = New MySqlDataAdapter(cmd)
            cmd.ExecuteNonQuery()

            MessageBox.Show("Success!")

        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString())
        End Try

        connection.Close()
    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Private Sub studentReg1Panel_Paint(sender As Object, e As PaintEventArgs) Handles studentReg1Panel.Paint

    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles courseLbl.Click

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles studentRegCourseTxtBox.TextChanged

    End Sub

    Private Sub studentRegYearTextBox_TextChanged(sender As Object, e As EventArgs) Handles studentRegYearSecTextBox.TextChanged

    End Sub

    Private Sub studentReg1BgPanel_Paint(sender As Object, e As PaintEventArgs) Handles studentReg1BgPanel.Paint

    End Sub
End Class