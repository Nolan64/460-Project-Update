Public Class frmmain_menu
    Public Property usersName As String

    Private Sub frmmain_menu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        userName.Text = usersName

        'test
    End Sub
End Class