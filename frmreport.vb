Imports System.ComponentModel
Imports System.Data.Entity.Core.Objects
Imports System.Data.Entity
Imports MySql.Data.MySqlClient

Public Class frmreport

    Dim connection As New MySqlConnection("datasource=localhost;port=3306;username=root;password=root;database=mydb")
    Private Sub frmreport_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            Dim SDA As New MySqlDataAdapter
            Dim dbDataset As New DataTable
            Dim bsource As New BindingSource
            connection.Open()
            Dim Query As String
            Query = "select UID, firstName, lastName, birthdate, TIMESTAMPDIFF(YEAR, birthdate, CURDATE()) AS age FROM general
                    where TIMESTAMPDIFF(YEAR, birthdate, CURDATE()) >= 65"
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
End Class