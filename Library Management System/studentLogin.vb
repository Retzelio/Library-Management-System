
Imports System.Data.Common
Imports MySql.Data.MySqlClient
Imports Mysqlx

Public Class studentLogin
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs)

    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles studentPassLogTextBox.TextChanged

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub PictureBox1_Click_1(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub studentLogButton_Click(sender As Object, e As EventArgs)
        openConnnection()



        Try
            sql = "SELECT * FROM students WHERE username = '" & studentUserLogTextBox.Text() & "' AND password = '" & studentPassLogTextBox.Text() & "'"
            cmd = New MySqlCommand(sql, connection)
            da = New MySqlDataAdapter(cmd)
            dt = New DataTable
            da.Fill(dt)

            If dt.Rows.Count > 0 Then
                Dim username = dt.Rows(0).Item(7)
                Dim password = dt.Rows(0).Item(8)

                If username = studentUserLogTextBox.Text() And password = studentPassLogTextBox.Text() Then
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
End Class
