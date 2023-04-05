Imports System.Data.Common
Imports MySql.Data.MySqlClient
Imports Mysqlx

Public Class Home

    Public dr As MySqlDataReader

    Private Sub ListView1_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub headerLabel_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub headerGroupBox_Enter(sender As Object, e As EventArgs)

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Guna2GradientButton1_Click(sender As Object, e As EventArgs) Handles selfhelpGradientBtn.Click

        Dim con As New MySqlConnection
        con.ConnectionString = "Server=127.0.0.1;Port=3307;Database=librarymanagementsystem;Uid=root;Pwd=;"
        con.Open()
        Try


            sql = "SELECT * FROM books WHERE id = '3'"
            cmd = New MySqlCommand(sql, con)
            da = New MySqlDataAdapter(cmd)
            dr = cmd.ExecuteReader()



            While dr.Read()

                title.Text() = dr.Item(1).ToString
                authorText.Text() = dr.Item(2).ToString
                RichTextBox1.Text() = dr.Item(5).ToString


            End While

            dr.Close()

            con.Close()
        Catch ex As Exception

        End Try
        con.Close()
    End Sub

    Private Sub Guna2GroupBox1_Click(sender As Object, e As EventArgs) Handles Guna2GroupBox1.Click

    End Sub

    Private Sub Guna2GradientButton1_Click_1(sender As Object, e As EventArgs) Handles loginBtn.Click
        studentLogin.Show()
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles author.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Home_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        title.Text = "hatdog"
        title.AutoSize = False
        title.TextAlign = ContentAlignment.MiddleCenter

        title.Dock = DockStyle.Fill

        authorText.Text = "hatdog"
        authorText.AutoSize = False
        authorText.TextAlign = ContentAlignment.MiddleCenter

        authorText.Dock = DockStyle.Fill

    End Sub

    Private Sub authorText_Click(sender As Object, e As EventArgs) Handles authorText.Click

    End Sub

    Private Sub readGradBtn_Click(sender As Object, e As EventArgs) Handles readGradBtn.Click
        Dim con As New MySqlConnection
        con.ConnectionString = "Server=127.0.0.1;Port=3307;Database=librarymanagementsystem;Uid=root;Pwd=;"
        con.Open()
        Try


            sql = "SELECT * FROM books WHERE id = '3'"
            cmd = New MySqlCommand(sql, con)
            da = New MySqlDataAdapter(cmd)
            dr = cmd.ExecuteReader()


            Form1.Show()
            If dr.Read() Then



                Form1.pdfreader.src = dr.Item(5)


            End If





            dr.Close()

            con.Close()
        Catch ex As Exception

        End Try
        con.Close()
    End Sub
End Class