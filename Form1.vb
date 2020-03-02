Imports MySql.Data.MySqlClient


Public Class Form1
    Dim connection As New MySqlConnection("datasource=localhost;port=3306;username=root;password=root;database=mydb")
    Private Sub Button1_Click(sender As Object, e As EventArgs)
        DatabaseTestApplication2.frmgeneral.Show()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)
        DatabaseTestApplication2.frmtracking.Show()
    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Dim command As New MySqlCommand("SELECT `username`, `password` FROM `user` WHERE `username` = @username AND `password` = @password", connection)

        command.Parameters.Add("@username", MySqlDbType.VarChar).Value = txtUN.Text
        command.Parameters.Add("@password", MySqlDbType.VarChar).Value = txtPW.Text

        'This should pass the value to the main screen
        Dim OBJ As New frmmain_menu
        OBJ.usersName = txtUN.Text
        OBJ.Show()

        Dim adapter As New MySqlDataAdapter(command)
        Dim table As New DataTable()

        adapter.Fill(table)

        If table.Rows.Count = 0 Then

            MessageBox.Show("Invalid Username Or Password")

        Else

            MessageBox.Show("Logged In")
            frmmain_menu.Show()



            Me.Hide()

        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub
End Class
