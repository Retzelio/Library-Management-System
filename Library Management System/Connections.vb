Imports MySql.Data.MySqlClient 'imports the library of ADO.net that provides classes, objects, functions that will be used to connect to your database and to retrieve and manipulate data
Module Module1

    'this is a declaration of variables that stores the functions we will use to manage our database

    Public connection As New MySqlConnection
    Public cmd As New MySqlCommand
    Public da As New MySqlDataAdapter
    Public ds As New DataSet
    Public dt As New DataTable
    Public sql As String

    'until here




    Sub openConnnection() 'subroutine that doesnt return a value but performs a specific tasks

        connection.ConnectionString = "server=localhost;username=root;password=;database=libraryManagementSystem" ' this called a connections string, it allows us
        'to connect to our database
        connection.Open() ' this opens the connection between the system and the database, without opening it, we cannot access the datas in our table
    End Sub




End Module
