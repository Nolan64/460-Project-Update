Imports MySql.Data.MySqlClient


Public Class Form1
    Dim connection As New MySqlConnection("datasource=localhost;port=3306;username=root;password=kiwifruit;database=mydb")

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Dim command As New MySqlCommand("SELECT `username`, `password` FROM `user` WHERE `username` = @username AND `password` = @password", connection)

        command.Parameters.Add("@username", MySqlDbType.VarChar).Value = txtUN.Text
        command.Parameters.Add("@password", MySqlDbType.VarChar).Value = txtPW.Text

        Dim adapter As New MySqlDataAdapter(command)
        Dim table As New DataTable()

        adapter.Fill(table)

        If table.Rows.Count = 0 Then

            MessageBox.Show("Invalid Username Or Password")

        Else

            MessageBox.Show("Logged In")
            'This should pass the value to the main screen
            Dim OBJ As New frmmain_menu
            OBJ.usersName = txtUN.Text
            OBJ.Show()

            Me.Hide()

        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If My.Settings.username.Equals("") = False Then
            txtUN.Text = My.Settings.username
            txtPW.Text = My.Settings.password
            CheckBox1.Checked = True
        End If
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtUN.Clear()
        txtPW.Clear()
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = True Then
            My.Settings.username = txtUN.Text
            My.Settings.password = txtPW.Text
            My.Settings.Save()
            My.Settings.Reload()
        Else
            My.Settings.username = ""
            My.Settings.password = ""
            My.Settings.Save()
            My.Settings.Reload()
        End If
    End Sub
End Class
