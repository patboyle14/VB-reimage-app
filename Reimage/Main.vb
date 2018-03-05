Public Class Main
    Private Sub btnYoga370_Click(sender As Object, e As EventArgs) Handles btnYoga370.Click
        Dim nameReimage As New Name_Reimage
        nameReimage.Show()
    End Sub

    Private Sub btnOther_Click(sender As Object, e As EventArgs) Handles btnOther.Click
        Dim userReimage As New frmMain
        userReimage.Show()
    End Sub

    Private Sub btnDebug_Click(sender As Object, e As EventArgs)
        Dim debugImage As New Debug_Form
        debugImage.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        Dim debug2 As New debugUpdate
        debug2.Show()
    End Sub
End Class