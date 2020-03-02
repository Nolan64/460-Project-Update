Public Class frmmain_menu
    Public Property usersName As String

    Private Sub frmmain_menu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        userName.Text = usersName

        'test
    End Sub

    Private Sub addApplicant_Click(sender As Object, e As EventArgs) Handles addApplicant.Click

    End Sub
End Class