Imports System.ComponentModel
Imports System.Data.Entity.Core.Objects
Imports System.Data.Entity
Imports System.IO
Imports System.Data
Imports MySql.Data.MySqlClient

Public Class frmreport

    Public Property filename As String

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

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles ExportCSV.Click
        'create empty string
        Dim thecsvfile As String = String.Empty
        'get the column headers
        For Each column As DataGridViewColumn In DataGridView1.Columns
            thecsvfile = thecsvfile & column.HeaderText & ","
        Next
        'trim the last comma
        thecsvfile = thecsvfile.TrimEnd(",")
        'Add the line to the output
        thecsvfile = thecsvfile & vbCr & vbLf
        'get the rows
        For Each row As DataGridViewRow In DataGridView1.Rows
            'get the cells
            For Each cell As DataGridViewCell In row.Cells
                thecsvfile = thecsvfile & cell.FormattedValue.replace(",", "") & ","
            Next
            'trim the last comma
            thecsvfile = thecsvfile.TrimEnd(",")
            'Add the line to the output
            thecsvfile = thecsvfile & vbCr & vbLf
        Next
        'write the file
        'CHANGE ON FINAL RELEASE
        My.Computer.FileSystem.WriteAllText("C:\Users\NGarr\Desktop\export.csv", thecsvfile, False)
    End Sub

    Private Sub Button3_Click_1(sender As Object, e As EventArgs) Handles Button3.Click
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

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim filename As String = InputBox("Enter a Filename", "Export to CSV", "export")

        'create empty string
        Dim thecsvfile As String = String.Empty
            'get the column headers
            For Each column As DataGridViewColumn In DataGridView1.Columns
                thecsvfile = thecsvfile & column.HeaderText & ","
            Next
            'trim the last comma
            thecsvfile = thecsvfile.TrimEnd(",")
            'Add the line to the output
            thecsvfile = thecsvfile & vbCr & vbLf
            'get the rows
            For Each row As DataGridViewRow In DataGridView1.Rows
                'get the cells
                For Each cell As DataGridViewCell In row.Cells
                    thecsvfile = thecsvfile & cell.FormattedValue.replace(",", "") & ","
                Next
                'trim the last comma
                thecsvfile = thecsvfile.TrimEnd(",")
                'Add the line to the output
                thecsvfile = thecsvfile & vbCr & vbLf
            Next
        'write the file
        'CHANGE ON FINAL RELEASE
        My.Computer.FileSystem.WriteAllText("C:\Users\NGarr\Desktop\" + filename + ".csv", thecsvfile, False)
    End Sub
End Class