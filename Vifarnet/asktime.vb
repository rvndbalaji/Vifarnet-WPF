Public Class asktime

    Private Sub rest_Click(sender As Object, e As EventArgs) Handles rest.Click

        Dim mytasks As New mytasks
        mytasks.dt.Text = Me.dt.Text
        mytasks.book.PerformClick()
        My.Settings.Save()
        Me.Close()
    End Sub
End Class