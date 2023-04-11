Imports MySql.Data.MySqlClient

Public Class librarianLogin
    Private Sub Button1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub adminLogButton_Click(sender As Object, e As EventArgs)
        openConnnection()

        Try
            sql = "SELECT * FROM librarian WHERE username = '" & adminUserLogTextBox.Text() & "' AND password = '" & adminPassLogTextBox.Text() & "'"
            cmd = New MySqlCommand(sql, connection)
            da = New MySqlDataAdapter(cmd)
            dt = New DataTable
            da.Fill(dt)

            If dt.Rows.Count > 0 Then
                Dim username = dt.Rows(0).Item(3)
                Dim password = dt.Rows(0).Item(4)

                If username = adminUserLogTextBox.Text() And password = adminPassLogTextBox.Text() Then
                    MessageBox.Show("Login Success!")
                    connection.Close()
                Else
                    MessageBox.Show("Incorrect")
                End If

            End If


        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString())
        End Try
        connection.Close()
    End Sub

    Private Sub createAccLbl_Click(sender As Object, e As EventArgs) Handles librarianCreateAccLbl.Click
        librarianRegistration.Show()
    End Sub
End Class