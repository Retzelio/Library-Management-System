Imports MySql.Data.MySqlClient

Public Class librarianRegistration
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub adminRegButton_Click(sender As Object, e As EventArgs) Handles adminRegButton.Click
        openConnnection()

        Try
            sql = "INSERT INTO librarian(lName, fName, username, password) VALUES ('" & adminLnameRegTextBox.Text & "', '" & adminFnameRegTextBox.Text & "','" & adminUserRegTextBox.Text & "' , '" & adminPassRegTextBox.Text & "')"
            cmd = New MySqlCommand(sql, connection)
            da = New MySqlDataAdapter(cmd)
            cmd.ExecuteNonQuery()

            MessageBox.Show("Success!")

        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString())
        End Try

        connection.Close()
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub librarianRegistration_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim screenWidth As Integer = Screen.PrimaryScreen.WorkingArea.Width
        Dim screenHeight As Integer = Screen.PrimaryScreen.WorkingArea.Height
        Me.Location = New Point((screenWidth - Me.Width) / 2, (screenHeight - Me.Height) / 2)


    End Sub
End Class