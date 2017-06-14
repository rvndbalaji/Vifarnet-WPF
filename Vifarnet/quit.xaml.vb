Imports System.Windows.Media.Animation
Public Class quit

    Dim var As String
    Private Story As Storyboard
    Private Story1 As Storyboard
    Dim StrtScrn As MainWindow = TryCast(Application.Current.MainWindow, MainWindow)

    Public Sub New()
        InitializeComponent()


        Dim app As New DoubleAnimation
        app.From = 1.0
        app.To = 0.4
        app.Duration = New Duration(TimeSpan.FromSeconds(0.5))

        Dim disapp As New DoubleAnimation
        disapp.From = 0.4
        disapp.To = 1.0
        disapp.Duration = New Duration(TimeSpan.FromSeconds(0.5))


        Story = New Storyboard()
        Story.Children.Add(app)
        Storyboard.SetTargetName(app, StrtScrn.Name)
        Storyboard.SetTargetProperty(app, New PropertyPath(Canvas.OpacityProperty))


        Story1 = New Storyboard()
        Story1.Children.Add(disapp)
        Storyboard.SetTargetName(disapp, StrtScrn.Name)
        Storyboard.SetTargetProperty(disapp, New PropertyPath(Window.OpacityProperty))


    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.Windows.RoutedEventArgs) Handles Button1.Click

        Me.Close()
        Story1.Begin(StrtScrn)

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles Button2.Click

        End

    End Sub

    Private Sub Window_Loaded(ByVal sender As System.Object, ByVal e As System.Windows.RoutedEventArgs) Handles MyBase.Loaded
        My.Computer.Audio.Play(My.Resources.notify, AudioPlayMode.Background)
        Dim StrtScrn As MainWindow = TryCast(Application.Current.MainWindow, MainWindow)
        Story.Begin(StrtScrn)
        Dim nm As String
        nm = StrtScrn.user.Content
        nm = nm.ToLower()
        name.Content = nm & "?"
    End Sub
End Class
