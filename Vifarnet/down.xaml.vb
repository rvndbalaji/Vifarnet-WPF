Imports System.Net
Imports Microsoft.Win32
Imports Microsoft.Win32.SaveFileDialog
Imports System.Timers.Timer

Public Class down
    Private WithEvents download As WebClient
    Dim done As Double
    Dim tot As Double
    Dim time As Integer

    Dim starter As Integer
    Dim stoper As Integer

    Dim start_time As Integer
    Dim stop_time As Integer

    Dim elapsed_time As TimeSpan




    Private Sub s_ValueChanged(ByVal sender As Object, ByVal e As RoutedPropertyChangedEventArgs(Of Double)) Handles s.ValueChanged

        Dim qw As Double
        qw = System.Math.Round(s.Value, 2)
        pers.Content = qw & "% Complete"
        cel.IsEnabled = True
        sp.Content = done & " MB out of " & tot & " MB"




        '---------------------------------------------------------
        If s.Value = 100 Then
            pers.Content = "Download Complete!"
            link.IsEnabled = True
            br.IsEnabled = True
            dir.IsEnabled = True
            dload.IsEnabled = True
            cel.IsEnabled = False

        End If






    End Sub


    Private Sub dload_Click(ByVal sender As System.Object, ByVal e As System.Windows.RoutedEventArgs) Handles dload.Click


        Try
            download.CancelAsync()
            download.Dispose()
        Catch ex As Exception

        End Try




        If My.Computer.FileSystem.FileExists(dir.Text) Then

            If MessageBox.Show("A file with the same name already exists in this location. Do you want to overwrite the file?", "Overwrite File?", MessageBoxButton.YesNo, MessageBoxImage.Question) = vbAbort.Yes Then

                Try
                    My.Computer.FileSystem.DeleteFile(dir.Text)

                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                End Try

            Else

                s.Value = 0
                pers.Content = Nothing
                sp.Content = Nothing
                link.IsEnabled = True
                br.IsEnabled = True
                dir.IsEnabled = True
                dload.IsEnabled = True
                cel.IsEnabled = False
                Exit Sub

            End If
        Else

        End If


        Try
            link.IsEnabled = False
            br.IsEnabled = False
            dir.IsEnabled = False
            dload.IsEnabled = False
            cel.IsEnabled = False

            download = New WebClient
            Dim url = link.Text
            Dim path = dir.Text
            s.Value = 0
            s.Maximum = 100

            pers.Content = "Connecting to Server..."


            If dir.Text = "Desktop" Or dir.Text = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) Then
                dir.Text = "Desktop"
                path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) & "\Vifarnet Setup.rar"

            End If

            cel.IsEnabled = False


            download.DownloadFileAsync(New Uri(url), (path))


        Catch ex1 As Exception


            MessageBox.Show(ex1.Message)
            s.Value = 0
            pers.Content = Nothing
            sp.Content = Nothing
            link.IsEnabled = True
            br.IsEnabled = True
            dir.IsEnabled = True
            dload.IsEnabled = True
            cel.IsEnabled = False

        End Try



    End Sub



    Private Sub download_DownloadProgressChanged(ByVal sender As Object, ByVal e As System.Net.DownloadProgressChangedEventArgs) Handles download.DownloadProgressChanged


        done = (e.BytesReceived) / 1048576
        done = System.Math.Round(done, 2)
        tot = (e.TotalBytesToReceive) / 1048576
        tot = System.Math.Round(tot, 2)

        Dim acc As Double
        acc = (done / tot) * 100
        s.Value = acc


    End Sub

    Private Sub br_Click(ByVal sender As System.Object, ByVal e As System.Windows.RoutedEventArgs) Handles br.Click
        Dim dlog As New SaveFileDialog
        dlog.Title = "Select Download Location"
        dlog.ShowDialog()
        dir.Text = dlog.FileName()


    End Sub


    Private Sub cel_Click(ByVal sender As System.Object, ByVal e As System.Windows.RoutedEventArgs) Handles cel.Click

        Me.Opacity = 0.4
        If MessageBox.Show("Are you sure you want to cancel the download?" & vbNewLine & vbNewLine & "NOTE: The file can become unusable", "Cancelling...", MessageBoxButton.YesNo, MessageBoxImage.Question) = MessageBoxResult.Yes Then

            Dim path = dir.Text

            download.CancelAsync()
            s.Value = 0
            pers.Content = Nothing
            sp.Content = Nothing
            link.IsEnabled = True
            br.IsEnabled = True
            dir.IsEnabled = True
            dload.IsEnabled = True
            cel.IsEnabled = False



            Try
                My.Computer.FileSystem.DeleteFile(path)

            Catch ex As Exception
            End Try

        Else


        End If
        Me.Opacity = 1

    End Sub

End Class
