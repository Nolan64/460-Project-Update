Imports System.ComponentModel
Imports System.Data.Entity.Core.Objects
Imports System.Data.Entity
Imports MySql.Data.MySqlClient
Public Class frmmain_menu

    Dim connection As New MySqlConnection("datasource=localhost;port=3306;username=root;password=root;database=mydb")


    Public Property usersName As String



    Private Sub frmmain_menu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        userName.Text = usersName

        'test

        Dim SDA As New MySqlDataAdapter
        Dim dbDataset As New DataTable
        Dim bsource As New BindingSource
        connection.Open()
            Dim Query As String
            Query = "select * from mydb.all_table_vw"
        Dim Command2 As New MySqlCommand(Query, connection)
        SDA.SelectCommand = Command2
        SDA.Fill(dbDataset)
            bsource.DataSource = dbDataset
            DataGridView1.DataSource = bsource
        SDA.Update(dbDataset)
        connection.Close()





    End Sub

    Private Sub addApplicant_Click(sender As Object, e As EventArgs) Handles addApplicant.Click
        DatabaseTestApplication2.frmgeneral.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Refreshbtn.Click
        Try
            Dim SDA As New MySqlDataAdapter
            Dim dbDataset As New DataTable
            Dim bsource As New BindingSource
            connection.Open()
            Dim Query As String
            Query = "select * from mydb.all_table_vw"
            Dim Command2 As New MySqlCommand(Query, connection)
            SDA.SelectCommand = Command2
            SDA.Fill(dbDataset)
            bsource.DataSource = dbDataset
            DataGridView1.DataSource = bsource
            SDA.Update(dbDataset)
            connection.Close()
        Catch
            MessageBox.Show("Error")
        End Try
    End Sub

    Private Sub Reportsbtn_Click(sender As Object, e As EventArgs) Handles Reportsbtn.Click
        frmreport.Show()
    End Sub
End Class

