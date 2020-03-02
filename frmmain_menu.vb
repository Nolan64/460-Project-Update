Public Class frmmain_menu
    Public Property usersName As String

    Private Sub frmmain_menu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        userName.Text = usersName

        'test
    End Sub

    Private Sub repairs_Click(sender As Object, e As EventArgs) Handles repairs.Click
        frmrepairs.Show()
        Me.Hide()


    End Sub

    Private Sub tracking_Click(sender As Object, e As EventArgs) Handles tracking.Click
        frmtracking.Show()
        Me.Hide()


    End Sub

    Private Sub editSurvey_Click(sender As Object, e As EventArgs) Handles editSurvey.Click
        frmsurvey.Show()
        Me.Hide()

    End Sub

    Private Sub addApplicant_Click(sender As Object, e As EventArgs) Handles addApplicant.Click
        frmgeneral.Show()
        Me.Hide()


    End Sub
End Class