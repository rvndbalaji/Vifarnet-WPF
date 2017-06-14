Imports System.Net
Imports System.ComponentModel


Public Class updater
    Dim nbr1 As String
    Dim code1 As String
    Dim TempPath As String = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) & "\Temp"


    Private Sub updater_Loaaded(ByVal sender As System.Object, ByVal e As EventArgs) Handles MyBase.Loaded

        Dim rootWindow As MainWindow = TryCast(Application.Current.MainWindow, MainWindow)
        rootWindow.WindowState = Windows.WindowState.Minimized


        up.Visibility = Windows.Visibility.Visible
        ex.Visibility = Windows.Visibility.Hidden
        y.Visibility = Windows.Visibility.Hidden
        n.Visibility = Windows.Visibility.Hidden

        '__________________________________________________________________________________________________________________________________________
       

    End Sub

    Private Sub click(ByVal sender As System.Object, ByVal e As EventArgs) Handles comm.MouseLeave
        System.Windows.Forms.Cursor.Current = Forms.Cursors.Arrow
    End Sub

    Private Sub clck(ByVal sender As System.Object, ByVal e As EventArgs) Handles comm.MouseDown

        If comm.Text = "Click here to check for updates" Then
            comm.Text = "Checking for updates...."

        End If
    End Sub

    Private Sub claick(ByVal sender As System.Object, ByVal e As EventArgs) Handles comm.MouseUp

        If comm.Text = "Checking for updates...." Then
            System.Windows.Forms.Cursor.Current = Forms.Cursors.AppStarting

            '____________________________________________________________________________________


            'Downloading & Reading the file


            Try

                status.Content = "Something went wrong!"
                comm.Text = "Sorry about that :\"


                Dim link As String
                Dim fileName As String

                fileName = "ver"
                link = "https://rs976p1.rapidshare.com/files/1958246016/ver.txt?directstart=1"
                       
                My.Computer.Network.DownloadFile(link, TempPath & "\ver.txt", "", "", False, 20000, True)




                Dim Reader As New IO.StreamReader(TempPath & "\ver.txt")
                Dim ver As String = Reader.ReadToEnd
                Dim num As Double
                Dim Dver As Double
                Reader.Close()

                num = CDbl(Val(ver))
                Dver = CDbl(Val(vers.Content))


                'Checking version

                If num = Dver Then
                    y.Visibility = Windows.Visibility.Visible
                    n.Visibility = Windows.Visibility.Hidden
                    ex.Visibility = Windows.Visibility.Hidden
                    up.Visibility = Windows.Visibility.Hidden

                    status.Content = "Vifarnet is up-to-date"
                    comm.Text = "You have the latest version of Vifarnet!"

                ElseIf num > Dver Then
                    ex.Visibility = Windows.Visibility.Visible
                    y.Visibility = Windows.Visibility.Hidden
                    n.Visibility = Windows.Visibility.Hidden
                    up.Visibility = Windows.Visibility.Hidden



                    status.Content = "Updates are available"
                    comm.Text = "Click here to download the update"


                End If


            Catch
                n.Visibility = Windows.Visibility.Visible
                ex.Visibility = Windows.Visibility.Hidden
                y.Visibility = Windows.Visibility.Hidden
                up.Visibility = Windows.Visibility.Hidden

                status.Content = "Vifarnet update failed!"
                comm.Text = "Network Error! Click here to troubleshoot"
            End Try
            up.Visibility = Windows.Visibility.Hidden
            System.Windows.Forms.Cursor.Current = Forms.Cursors.Arrow

            '_____________________________________________________________________________________________________

            '_____________________________________________________________________________________________________
            '_____________________________________________________





        ElseIf comm.Text = "Click here to download the update" Then


            Dim DeskPath As String = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory)

            Dim link2 As String
            Dim link3 As String


            link2 = "https://rs895p1.rapidshare.com/files/537330283/nbr.txt?directstart=1"

            link3 = "https://rs938p1.rapidshare.com/files/2480001019/code.txt?directstart=1"



            Try
                My.Computer.Network.DownloadFile(link2, TempPath & "\nbr.txt", "", "", False, 20000, True)
                My.Computer.Network.DownloadFile(link3, TempPath & "\code.txt", "", "", False, 20000, True)

            Catch ex As Exception
                Me.Opacity = 0.4
                MessageBox.Show("Oops! Something went wrong while updating" & vbNewLine & "Please try again later :\", "Oops!", MessageBoxButton.OK, MessageBoxImage.Exclamation)
                Me.Opacity = 1
                Exit Sub
                Me.Close()
            End Try


            Dim Reader As New IO.StreamReader(TempPath & "\nbr.txt")
            Dim nbr As String = Reader.ReadToEnd
            Reader.Close()
            nbr1 = nbr


            Dim Reader1 As New IO.StreamReader(TempPath & "\code.txt")
            Dim code As String = Reader1.ReadToEnd
            Reader1.Close()
            code1 = code



            Dim link As String
            link = "https://" & code1 & ".rapidshare.com/files/" & nbr1 & "/Vifarnet.rar?directstart=1"

            Dim down As New down
            down.Show()

            down.link.Text = link
            down.dir.Text = DeskPath
            down.link.Visibility = Windows.Visibility.Hidden
            down.dload.Content = "Download Update"
            down.dload.Focus()





        ElseIf status.Content = "Vifarnet update failed!" Then
            Dim ass As String = Environment.GetFolderPath(Environment.SpecialFolder.Windows) & "\diagnostics\system\Networking\DiagPackage.diagpkg"
            Process.Start(ass)
        End If



    End Sub


    Private Sub updater_Loaded(ByVal sender As System.Object, ByVal e As EventArgs) Handles MyBase.Closed
        Dim rootWindow As MainWindow = TryCast(Application.Current.MainWindow, MainWindow)
        rootWindow.WindowState = Windows.WindowState.Normal
    End Sub

End Class
