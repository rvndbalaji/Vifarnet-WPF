Imports System.Windows.Media

Public Class rim

    Private Sub rim_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Dim tone As String
        tone = "\Windows\Media\notify.wav"

        Dim play As New MediaPlayer
        play.Open(New Uri(tone, UriKind.Relative))
        play.Play()



    End Sub

    Private Sub rim_Load_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        usr.Text = My.Settings.UserName & "! you have something to do, remember? "

        des.Text = My.Settings.r1.Item(0)
        title.Text = My.Settings.r1.Item(1)
        dte.Text = My.Settings.r1.Item(2)


    End Sub

    Private Sub rest_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rest.Click
        Me.Close()
    End Sub

End Class