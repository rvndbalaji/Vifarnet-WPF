Imports System.Windows.Media.Animation
Imports System.IO
Imports Microsoft.Win32
'Imports Microsoft.Windows.Controls



Class MainWindow
    Private Story1 As Storyboard
    Dim anim As New DoubleAnimation
    Dim xper As New xperiment



    Public Sub New()
        InitializeComponent()



        anim.From = 1.0
        anim.To = 0.4
        anim.Duration = New Duration(TimeSpan.FromSeconds(1.5))
        anim.RepeatBehavior = RepeatBehavior.Forever

        Story1 = New Storyboard()
        Story1.Children.Add(anim)
        Storyboard.SetTargetName(anim, upd.Name)
        Storyboard.SetTargetProperty(anim, New PropertyPath(Image.OpacityProperty))


    End Sub

    Private Sub m_img_(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles m_img.MouseEnter
        m_img.Opacity = 1
        m_txt.Visibility = Windows.Visibility.Visible

    End Sub

    Private Sub m_issmg_(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles m_img.MouseLeave

        m_img.Opacity = 0.7
        m_txt.Visibility = Windows.Visibility.Hidden

    End Sub


    Private Sub fixit_img_ImasdsdfrygeFailed(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles fixit_img.MouseEnter
        fixit_img.Opacity = 1
        fixit_txt.Visibility = Windows.Visibility.Visible

    End Sub

    Private Sub m_ismg_hImageFailed(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles fixit_img.MouseLeave
        fixit_img.Opacity = 0.7
        fixit_txt.Visibility = Windows.Visibility.Hidden

    End Sub

    Private Sub math_img_IsmageFailed(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles math_img.MouseEnter
        math_img.Opacity = 1
        math_txt.Visibility = Windows.Visibility.Visible

    End Sub

    Private Sub m_ismgjk_ImageFailed(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles math_img.MouseLeave
        math_img.Opacity = 0.7
        math_txt.Visibility = Windows.Visibility.Hidden

    End Sub


    Private Sub m_imsrug_ImageFailed(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles xplore_img.MouseEnter
        xplore_img.Opacity = 1
        xplr_txt.Visibility = Windows.Visibility.Visible

    End Sub

    Private Sub m_ismg_IsmageFailed(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles xplore_img.MouseLeave
        xplore_img.Opacity = 0.7
        xplr_txt.Visibility = Windows.Visibility.Hidden

    End Sub


    Private Sub mt_img_ImageFailed(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mt_img.MouseEnter
        mt_img.Opacity = 1
        mt_txt.Visibility = Windows.Visibility.Visible

    End Sub

    Private Sub jhf(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mt_img.MouseLeave
        mt_img.Opacity = 0.7
        mt_txt.Visibility = Windows.Visibility.Hidden

    End Sub


    Private Sub dsg(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mt_img.MouseUp


        Me.WindowState = Windows.WindowState.Minimized
        Dim mytasks As New mytasks
        mytasks.Show()
        mytasks.Activate()

    End Sub

    Private Sub updeFailed(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles upd.MouseEnter
        upd.Opacity = 1
        a4.Visibility = Windows.Visibility.Visible

    End Sub

    Private Sub m_g_ImageFailed(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles upd.MouseLeave
        upd.Opacity = 0.8
        a4.Visibility = Windows.Visibility.Hidden

    End Sub
    Private Sub m_g_Iled(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles upd.MouseUp
        Dim updater As New updater
        updater.Show()
        'Me.Opacity = 0.4
        'MessageBox.Show("Updater is currently undergoing some changes. Try again some other time." & vbNewLine & "Sorry about that :\", "Unavailable", MessageBoxButton.OK, MessageBoxImage.Information)
        'Me.Opacity = 1
    End Sub


    Private Sub abt_img_ImageFailed(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles abt_img.MouseEnter
        abt_img.Opacity = 1
        a3.Visibility = Windows.Visibility.Visible
    End Sub

    Private Sub m_smg_ImageFailed(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles abt_img.MouseLeave
        abt_img.Opacity = 0.7
        a3.Visibility = Windows.Visibility.Hidden
    End Sub
    Private Sub m_smeFailed(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles abt_img.MouseUp
        Dim abt As New abt
        abt.Show()
        abt.Activate()
    End Sub



    Private Sub ctrlc_img_ImageFailed(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ctrlc.MouseEnter
        ctrlc.Opacity = 1
        a2.Visibility = Windows.Visibility.Visible
    End Sub

    Private Sub sadgghs(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ctrlc.MouseLeave
        ctrlc.Opacity = 0.7
        a2.Visibility = Windows.Visibility.Hidden
    End Sub


    Private Sub ctrlc_Imageload(ByVal sender As System.Object, ByVal e As MouseButtonEventArgs) Handles ctrlc.MouseUp
        Me.WindowState = Windows.WindowState.Minimized
        Dim ctrl As New ctrl
        ctrl.Show()
        ctrl.Activate()

    End Sub

    Private Sub book_img_ImageFailed(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles book_img.MouseEnter
        book_img.Opacity = 1
        book_txt.Visibility = Windows.Visibility.Visible

    End Sub

    Private Sub egrh(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles book_img.MouseLeave
        book_img.Opacity = 0.7
        book_txt.Visibility = Windows.Visibility.Hidden

    End Sub


    Private Sub ageFxtrjailed(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles sc_img.MouseEnter
        sc_img.Opacity = 1
        sc_txt.Visibility = Windows.Visibility.Visible

    End Sub

    Private Sub _ImgageFailed(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles sc_img.MouseLeave
        sc_img.Opacity = 0.7
        sc_txt.Visibility = Windows.Visibility.Hidden

    End Sub

    'Processing Mouse Actions Starts here..... 


    Private Sub fixit(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles fixit_img.MouseUp

        Me.WindowState = Windows.WindowState.Minimized
        Dim Fixit As New Fixit
        Fixit.Show()
        Fixit.Activate()

    End Sub
    Private Sub xpl(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles xplore_img.MouseUp

        Me.WindowState = Windows.WindowState.Minimized
        Dim xpl As New xpl
        xpl.Show()
        xpl.Activate()

    End Sub

    Private Sub books(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles book_img.MouseUp

        Me.WindowState = Windows.WindowState.Minimized
        Dim books As New books
        books.Show()
        books.Activate()
    End Sub

    Private Sub d(ByVal sender As System.Object, ByVal e As EventArgs) Handles MyBase.Loaded
       
        '-------------------------------------------------------------------------------------------


        'Propic..................................................................................................


        Try

            Dim image As New BitmapImage()
            image.BeginInit()

            Dim path As String
            path = My.Settings.pic


            image.UriSource = New Uri(path, UriKind.RelativeOrAbsolute)
            image.EndInit()

            i2.Source = image

        Catch u As FileNotFoundException

            MessageBox.Show("Something went wrong whilst rendering the profile picture", "Oops!", MessageBoxButton.OK, MessageBoxImage.Exclamation)
        End Try

        user.Content = My.Settings.UserName

        ' Background.............................................................................................

        Try

            Dim myBrush As New ImageBrush()
            myBrush.ImageSource = New BitmapImage(New Uri(My.Settings.Bg, UriKind.Relative))


            If My.Settings.Bg = "My.Resources.bg40" Then

            Else

                Me.Background = myBrush

            End If

        Catch us As FileNotFoundException

            MessageBox.Show("Something went wrong whilst rendering the wallpaper", "Oops!", MessageBoxButton.OK, MessageBoxImage.Exclamation)
        End Try
        '............................................................................................................



        If user.Content = "..." Then

            Me.Opacity = 0.7
            Dim nm As New nm
            nm.ShowDialog()
            nm.Activate()
            Me.Opacity = 1

        Else : user.Content = My.Settings.UserName

        End If


        '-----------------------------------------------------------------------------
        'Control panel Settings- Load and Apply User Settings
        Dim ctrl As New ctrl

        If My.Settings.opt_music = True Then
            ctrl.music.IsChecked = True
        Else
            ctrl.music.IsChecked = False
        End If

        If My.Settings.opt_fixit = True Then
            ctrl.fixit.IsChecked = True
        Else
            ctrl.fixit.IsChecked = False
        End If

        If My.Settings.opt_sc = True Then
            ctrl.sc.IsChecked = True
        Else
            ctrl.sc.IsChecked = False
        End If

        If My.Settings.opt_math = True Then
            ctrl.math.IsChecked = True
        Else
            ctrl.math.IsChecked = False
        End If

        If My.Settings.opt_xplr = True Then
            ctrl.xplr.IsChecked = True
        Else
            ctrl.xplr.IsChecked = False
        End If


        If My.Settings.opt_books = True Then
            ctrl.books.IsChecked = True
        Else
            ctrl.books.IsChecked = False
        End If

        If My.Settings.opt_mt = True Then
            ctrl.mt.IsChecked = True
        Else
            ctrl.mt.IsChecked = False
        End If

        If My.Settings.opt_dload = True Then
            ctrl.dload.IsChecked = True
        Else
            ctrl.dload.IsChecked = False
        End If


        If My.Settings.opt_wall = True Then
            ctrl.wall.IsChecked = True
        Else
            ctrl.wall.IsChecked = False
        End If

        My.Settings.Save()



        ctrl.can.RaiseEvent(New RoutedEventArgs(Primitives.ButtonBase.ClickEvent))

        Me.Activate()
        My.Settings.Save()

    End Sub


    Private Sub Buttson1_Click(ByVal sender As System.Object, ByVal e As System.Windows.RoutedEventArgs) Handles i2.MouseUp

        Me.Opacity = 0.7
        Dim nm As New nm
        nm.ShowDialog()
        nm.Activate()
        Me.Opacity = 1



    End Sub
    Private Sub button1_Click(ByVal sender As System.Object, ByVal e As System.Windows.RoutedEventArgs) Handles i1.MouseUp
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

                If My.Settings.Bg = filepath Then

                Else

                    FileCopy(tempath, filepath)

                    My.Settings.Bg = filepath

                    Dim myBrush As New ImageBrush()

                    myBrush.ImageSource = New BitmapImage(New Uri(My.Settings.Bg, UriKind.RelativeOrAbsolute))



                    Me.Background = myBrush
                    My.Settings.Save()
                End If

            Catch u As NotSupportedException
                MessageBox.Show("Only Images are supported!", "Not supported", MessageBoxButton.OK, MessageBoxImage.Exclamation)
            Catch u1 As IOException

                MessageBox.Show("Temporary Problem:" & vbNewLine & "Your profile picture and wallpaper cannot be the same for now. We'll fix this issue as soon as possible", "Temporary Issue", MessageBoxButton.OK, MessageBoxImage.Exclamation)

                Exit Sub
            End Try


        End If


    End Sub

    Private Sub StrtScrn_Loaded_1(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing


        e.Cancel = False

        Dim quit As New quit
        quit.ShowDialog()

        e.Cancel = True

    End Sub

    Private Sub dm_img_ImageFailed(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dm_img.MouseEnter
        dm_img.Opacity = 1
        dm_txt.Visibility = Windows.Visibility.Visible
    End Sub

    Private Sub mgmageFailed(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dm_img.MouseLeave
        dm_img.Opacity = 0.7
        dm_txt.Visibility = Windows.Visibility.Hidden
    End Sub

    Private Sub dg(ByVal sender As System.Object, ByVal e As MouseButtonEventArgs) Handles math_img.MouseUp
        Me.WindowState = Windows.WindowState.Minimized
        Dim math As New math
        math.Show()
        math.Activate()

    End Sub
    Private Sub sddg(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dload_img.MouseEnter
        dload_img.Opacity = 1
        dload_txt.Visibility = Windows.Visibility.Visible
    End Sub

    Private Sub sdg(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dload_img.MouseLeave
        dload_img.Opacity = 0.7
        dload_txt.Visibility = Windows.Visibility.Hidden
    End Sub


    Private Sub m_img_ImageFailed(ByVal sender As System.Object, ByVal e As EventArgs) Handles m_img.MouseUp
        Me.WindowState = Windows.WindowState.Minimized
        Dim music As New music
        music.Show()
        music.Activate()
    End Sub

    Private Sub m_dimg(ByVal sender As System.Object, ByVal e As EventArgs) Handles dload_img.MouseUp
        Me.WindowState = Windows.WindowState.Minimized
        Dim down As New down
        down.Show()
        down.Activate()

    End Sub


    Private Sub hlpsup_img_img_ImageFailed(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles hlpsup_img.MouseEnter
        hlpsup_img.Opacity = 1
        a6.Visibility = Windows.Visibility.Visible
    End Sub

    Private Sub sadghs(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles hlpsup_img.MouseLeave
        hlpsup_img.Opacity = 0.7
        a6.Visibility = Windows.Visibility.Hidden
    End Sub


    Private Sub hlpsup_img_Imageload(ByVal sender As System.Object, ByVal e As MouseButtonEventArgs) Handles hlpsup_img.MouseUp

        Me.Opacity = 0.7
        MessageBox.Show("Sorry! This component is currently undergoing changes :\", "Unavailable", MessageBoxButton.OK, MessageBoxImage.Stop)
        Me.Opacity = 1

    End Sub

    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.Windows.RoutedEventArgs)
       
    End Sub




End Class
