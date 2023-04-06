Imports System.Data.Common
Imports MySql.Data.MySqlClient
Imports Mysqlx
Imports iTextSharp.text.pdf
Imports iTextSharp.text
Imports iTextSharp.text.pdf.parser



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


    Private Sub readGradBtn_Click(sender As Object, e As EventArgs) Handles readGradBtn.Click
        Dim con As New MySqlConnection
        con.ConnectionString = "Server=127.0.0.1;Port=3307;Database=librarymanagementsystem;Uid=root;Pwd=;"
        con.Open()
        Try
            sql = "SELECT * FROM books WHERE id = '3'"
            cmd = New MySqlCommand(sql, con)
            da = New MySqlDataAdapter(cmd)
            dr = cmd.ExecuteReader()


            If dr.Read() Then
                Dim pdfDoc As New iTextSharp.text.Document()
                Dim pdfReader As New iTextSharp.text.pdf.PdfReader(dr.Item(5).ToString())




            End If





            dr.Close()

            con.Close()
        Catch ex As Exception

        End Try
        con.Close()
    End Sub
End Class