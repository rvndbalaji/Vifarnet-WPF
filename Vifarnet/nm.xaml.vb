Imports System.Windows.Media.Animation
Imports Microsoft.Win32
Imports Microsoft.Windows.Controls



Public Class nm
    Dim wp As String
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
  
    Private Sub okClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ok.Click

        wp = txt.Text

        If wp = Nothing Then
            MessageBox.Show("We're sure that your not nameless!", ":|", MessageBoxButton.OK, MessageBoxImage.Exclamation)

        Else


            If key.Text = "VIFX-RVND-6072-Y9R6" Then


                If key.Text <> My.Settings.key Then

                    My.Settings.key = key.Text
                    My.Settings.UserName = wp

                    Dim StrtScrn As MainWindow = TryCast(Application.Current.MainWindow, MainWindow)
                    StrtScrn.user.Content = My.Settings.UserName


                    My.Settings.Save()

                    MessageBox.Show("Your product has been activated. Thankyou! :D", "Product Activated", MessageBoxButton.OK, MessageBoxImage.Information)


                    StrtScrn.rib.IsEnabled = True

                    StrtScrn.apps.IsEnabled = True
                    StrtScrn.BottomBar.IsEnabled = True
                    StrtScrn.upd.IsEnabled = True
                    StrtScrn.i1.IsEnabled = True
                    Story1.Begin(StrtScrn)


                    Me.Close()

                Else

                    My.Settings.UserName = wp

                    Dim StrtScrn As MainWindow = TryCast(Application.Current.MainWindow, MainWindow)
                    StrtScrn.user.Content = My.Settings.UserName

                    My.Settings.Save()

                    ' StrtScrn.notif.Visibility = Windows.Visibility.Hidden
                    StrtScrn.rib.IsEnabled = True

                    StrtScrn.apps.IsEnabled = True
                    StrtScrn.BottomBar.IsEnabled = True
                    StrtScrn.upd.IsEnabled = True
                    StrtScrn.i1.IsEnabled = True
                    Story1.Begin(StrtScrn)
                    Me.Close()

                End If
            Else
                MessageBox.Show("Wait! Something's Wrong. We're unable to identify you. Make sure you enter the info. correctly!", "Unauthorized Access", MessageBoxButton.OK, MessageBoxImage.Exclamation)
                Dim StrtScrn As MainWindow = TryCast(Application.Current.MainWindow, MainWindow)
                StrtScrn.user.Content = My.Settings.UserName


                StrtScrn.rib.IsEnabled = False

                StrtScrn.apps.IsEnabled = False
                StrtScrn.BottomBar.IsEnabled = False
                StrtScrn.upd.IsEnabled = False
                StrtScrn.i1.IsEnabled = False
                Story.Begin(StrtScrn)

            End If

        End If

    End Sub

    Private Sub StrtScrn_Loaded_1(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Loaded


        Story.Begin(StrtScrn)

        StrtScrn.rib.IsEnabled = False

        StrtScrn.apps.IsEnabled = False
        StrtScrn.BottomBar.IsEnabled = False
        StrtScrn.upd.IsEnabled = False
        StrtScrn.i1.IsEnabled = False



        Dim image As New BitmapImage()
        image.BeginInit()


        Dim photo As String
        photo = My.Settings.pic

        image.UriSource = New Uri(photo, UriKind.RelativeOrAbsolute)
        image.EndInit()

        dp.Source = image


        txt.Text = My.Settings.UserName
        key.Text = My.Settings.key

        If key.Text = Nothing Then
            ok.Content = "Let's Begin!"
        Else
            ok.Content = "Resume Vifarnet"
        End If
        key.Text = "VIFX-RVND-6072-Y9R6"

    End Sub


    Private Sub hlp_Click(ByVal sender As Object, ByVal e As EventArgs) Handles hlp.Click
        Me.Opacity = 0.4
        MessageBox.Show("The product key is a proof that the software you're using is genuine; without which the product will remain deactivated, making it un-usable." & vbNewLine & "But when you enter a valid product key, the software is all yours!", "Product Key Help", MessageBoxButton.OK, MessageBoxImage.Information)
        Me.Opacity = 1
    End Sub

    Private Sub change_Click(ByVal sender As System.Object, ByVal e As System.Windows.RoutedEventArgs) Handles change.Click
      Dim p As New OpenFileDialog()
        Dim tempath As String
        Dim apath As String
        Dim filepath As String
        Dim name As String

        apath = My.Application.Info.DirectoryPath()

        If p.ShowDialog() = False Then


          
        Else

            Try

             
                tempath = p.FileName
                name = p.SafeFileName

                filepath = apath & "\" & name

                If My.Settings.pic = filepath Then


                Else

                    FileCopy(tempath, filepath)



                    My.Settings.pic = filepath


                    Dim image As New BitmapImage()
                    image.BeginInit()
                    image.UriSource = New Uri(My.Settings.pic, UriKind.RelativeOrAbsolute)
                    image.EndInit()

                    dp.Source = image
                    StrtScrn.i2.Source = image


                    My.Settings.Save()

                End If

            Catch u As NotSupportedException
                MessageBox.Show("Only Images are supported!", "Not supported", MessageBoxButton.OK, MessageBoxImage.Exclamation)
            Catch m As IO.IOException

                MessageBox.Show("Temporary Problem:" & vbNewLine & "Your profile picture and wallpaper cannot be the same for now. We'll fix this issue as soon as possible", "Temporary Issue", MessageBoxButton.OK, MessageBoxImage.Exclamation)

                Exit Sub
            End Try
        End If



    End Sub
End Class
