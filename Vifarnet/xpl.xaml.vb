Imports System.IO
Imports System.Security.AccessControl

Public Class xpl



    Dim cnt As Integer = 0
    Dim process As Integer = 0


    Private Sub Window_Loaded(ByVal sender As System.Object, ByVal e As EventArgs) Handles MyBase.Closed
        Dim rootWindow As MainWindow = TryCast(Application.Current.MainWindow, MainWindow)
        rootWindow.WindowState = Windows.WindowState.Normal

    End Sub

    Private Sub srch_changed(ByVal sender As System.Object, ByVal e As EventArgs) Handles srchbox.TextChanged

        cnt = 0
        process = 0

        If srchbox.Text = Nothing Then


            cnt1.Text = "Results will be displayed as you type..."
            res.Items.Clear()

        Else



            res.Items.Clear()
            cnt = 0
            cnt1.Text = "Results will be displayed as you type..."



            Try


                For Each File In My.Computer.FileSystem.GetFiles("D:\", FileIO.SearchOption.SearchAllSubDirectories)



                    Dim Fn As String = My.Computer.FileSystem.GetFileInfo(File).Name


                    process = process + 1
                    If Fn.Contains(srchbox.Text) Then
                        res.Items.Add(Fn)

                        cnt = cnt + 1
                    End If

                Next File
                cnt1.Text = cnt & " files found!" & vbNewLine & process & " files processed"


            Catch u As UnauthorizedAccessException
                cnt1.Text = "Search cannot proceed without permissions!"

            End Try



        End If
    End Sub
End Class
