Public Class ctrl

    Dim main As MainWindow = TryCast(Application.Current.MainWindow, MainWindow)


    Private Sub Window_Loaded(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Closed


        main.WindowState = Windows.WindowState.Normal

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.Windows.RoutedEventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub can_Click(ByVal sender As System.Object, ByVal e As System.Windows.RoutedEventArgs) Handles can.Click


        If music.IsChecked = False Then

            main.m_img.IsEnabled = False
            main.m_img.Opacity = 0.4
            My.Settings.opt_music = False

        Else
            main.m_img.IsEnabled = True
            main.m_img.Opacity = 0.7
            My.Settings.opt_music = True
        End If


        If fixit.IsChecked = False Then

            main.fixit_img.IsEnabled = False
            main.fixit_img.Opacity = 0.4
            My.Settings.opt_fixit = False

        Else
            main.fixit_img.IsEnabled = True
            main.fixit_img.Opacity = 0.7
            My.Settings.opt_fixit = True
        End If

        If sc.IsChecked = False Then

            main.sc_img.IsEnabled = False
            main.sc_img.Opacity = 0.4
            My.Settings.opt_sc = False

        Else
            main.sc_img.IsEnabled = True
            main.sc_img.Opacity = 0.7
            My.Settings.opt_sc = True
        End If

        If math.IsChecked = False Then

            main.math_img.IsEnabled = False
            main.math_img.Opacity = 0.4
            My.Settings.opt_math = False

        Else
            main.math_img.IsEnabled = True
            main.math_img.Opacity = 0.7
            My.Settings.opt_math = True
        End If

        If xplr.IsChecked = False Then

            main.xplore_img.IsEnabled = False
            main.xplore_img.Opacity = 0.4
            My.Settings.opt_xplr = False

        Else
            main.xplore_img.IsEnabled = True
            main.xplore_img.Opacity = 0.7
            My.Settings.opt_xplr = True
        End If

        If books.IsChecked = False Then

            main.book_img.IsEnabled = False
            main.book_img.Opacity = 0.4
            My.Settings.opt_books = False

        Else
            main.book_img.IsEnabled = True
            main.book_img.Opacity = 0.7
            My.Settings.opt_books = True
        End If



        If mt.IsChecked = False Then

            main.mt_img.IsEnabled = False
            main.mt_img.Opacity = 0.4
            My.Settings.opt_mt = False

        Else
            main.mt_img.IsEnabled = True
            main.mt_img.Opacity = 0.7
            My.Settings.opt_mt = True
        End If

        If dm.IsChecked = False Then

            main.dm_img.IsEnabled = False
            main.dm_img.Opacity = 0.4
            My.Settings.opt_dm = False

        Else
            main.dm_img.IsEnabled = True
            main.dm_img.Opacity = 0.7
            My.Settings.opt_dm = True
        End If

        If dload.IsChecked = False Then

            main.dload_img.IsEnabled = False
            main.dload_img.Opacity = 0.4
            My.Settings.opt_dload = False

        Else
            main.dload_img.IsEnabled = True
            main.dload_img.Opacity = 0.7
            My.Settings.opt_dload = True
        End If

        If wall.IsChecked = False Then

            main.i1.IsEnabled = False
            main.i1.Opacity = 0
            My.Settings.opt_wall = False

        Else
            main.i1.IsEnabled = True
            main.i1.Opacity = 1
            My.Settings.opt_wall = True
        End If

        My.Settings.Save()
    End Sub

    Private Sub Window_Loaded_1(ByVal sender As System.Object, ByVal e As System.Windows.RoutedEventArgs) Handles MyBase.Loaded


        If My.Settings.opt_music = True Then
            music.IsChecked = True
        Else
            music.IsChecked = False
        End If

        If My.Settings.opt_fixit = True Then
            fixit.IsChecked = True
        Else
            fixit.IsChecked = False
        End If

        If My.Settings.opt_sc = True Then
            sc.IsChecked = True
        Else
            sc.IsChecked = False
        End If

        If My.Settings.opt_math = True Then
            math.IsChecked = True
        Else
            math.IsChecked = False
        End If

        If My.Settings.opt_xplr = True Then
            xplr.IsChecked = True
        Else
            xplr.IsChecked = False
        End If


        If My.Settings.opt_books = True Then
            books.IsChecked = True
        Else
            books.IsChecked = False
        End If

        If My.Settings.opt_mt = True Then
            mt.IsChecked = True
        Else
            mt.IsChecked = False
        End If

        If My.Settings.opt_dload = True Then
            dload.IsChecked = True
        Else
            dload.IsChecked = False
        End If

        If My.Settings.opt_dm = True Then
            dm.IsChecked = True
        Else
            dm.IsChecked = False
        End If


        If My.Settings.opt_wall = True Then
            wall.IsChecked = True
        Else
            wall.IsChecked = False
        End If

        My.Settings.Save()


    End Sub

    Private Sub reset_Click(ByVal sender As System.Object, ByVal e As System.Windows.RoutedEventArgs) Handles Reset.Click
        Me.Opacity = 0.4
        If MessageBox.Show("Are you sure you want to restore all the settings to their defaults?", "Restore defaults?", MessageBoxButton.YesNo, MessageBoxImage.Question) = vbYes Then

            My.Settings.Reset()
            My.Settings.Save()
            My.Settings.Reload()
            MessageBox.Show("Restart Vifarnet for the changes to take effect...", "Changes applied", MessageBoxButton.OK, MessageBoxImage.Information)
           
        Else

        End If
        Me.Opacity = 1
    End Sub
End Class
