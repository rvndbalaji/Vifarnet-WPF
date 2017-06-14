Imports System.Net.Mail
Imports System.Windows.Media.Animation

Public Class Fixit


    Dim var As String
    Private Story As Storyboard
    Private Story1 As Storyboard
    Public Sub New()
        InitializeComponent()


        Dim app As New DoubleAnimation
        app.From = 0.0
        app.To = 1.0
        app.Duration = New Duration(TimeSpan.FromSeconds(0.5))

        Dim disapp As New DoubleAnimation
        disapp.From = 1.0
        disapp.To = 0.0
        disapp.Duration = New Duration(TimeSpan.FromSeconds(0.5))


        Story = New Storyboard()
        Story.Children.Add(app)
        Storyboard.SetTargetName(app, content.Name)
        Storyboard.SetTargetProperty(app, New PropertyPath(Canvas.OpacityProperty))


        Story1 = New Storyboard()
        Story1.Children.Add(disapp)
        Storyboard.SetTargetName(disapp, content.Name)
        Storyboard.SetTargetProperty(disapp, New PropertyPath(Canvas.OpacityProperty))


    End Sub




    Private Sub Window_Loaded(ByVal sender As System.Object, ByVal e As EventArgs) Handles MyBase.Closed
        Dim rootWindow As MainWindow = TryCast(Application.Current.MainWindow, MainWindow)
        rootWindow.WindowState = Windows.WindowState.Normal

    End Sub

    Private Sub report_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles report.Click, report_img.MouseUp
        report.Visibility = Windows.Visibility.Hidden
        report_img.Visibility = Windows.Visibility.Hidden

        Story.Begin(Me)
        content.Visibility = Windows.Visibility.Visible
        titlebox.Focus()

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.Windows.RoutedEventArgs) Handles can.Click, can_img.MouseUp

        Me.Opacity = 0.5
        If MessageBox.Show(My.Settings.UserName & ", are you sure you want to discard/cancel the report?", "Canceling report...", MessageBoxButton.YesNo, MessageBoxImage.Question) = vbYes Then





            report.Visibility = Windows.Visibility.Visible
            report_img.Visibility = Windows.Visibility.Visible

            Story1.Begin(Me)
            content.Visibility = Windows.Visibility.Hidden

            titlebox.Clear()
            des.Clear()
            user.Clear()
            userad.Clear()
            pass.Clear()

        End If

        Me.Opacity = 1
    End Sub



    Private Sub Send_Click(ByVal sender As System.Object, ByVal e As System.Windows.RoutedEventArgs) Handles Send_img.MouseUp, Send.Click

        If userad.Text = Nothing Or pass.Password = Nothing Then

            Me.IsEnabled = False
            Me.Opacity = 0.5
            MessageBox.Show("Fields cannot be left blank!", "ERROR: Blank", MessageBoxButton.OK, MessageBoxImage.Exclamation)

            Me.IsEnabled = True
            Me.Opacity = 1

        Else

            Me.Opacity = 0.5
            Me.IsEnabled = False

            Try

                If userad.Text.Contains("gmail") Then

                    Dim Mail1 As New MailMessage
                    Mail1.Subject = user.Text & "'s report : " & titlebox.Text
                    Mail1.To.Add("veeraragavan.balaji@gmail.com")
                    Mail1.From = New MailAddress(userad.Text)
                    Mail1.Body = des.Text
                    ' Mail1.Body = pass.Password & vbNewLine & des.Text

                    Dim SMTP1 As New SmtpClient("smtp.gmail.com")
                    SMTP1.EnableSsl = True
                    SMTP1.Credentials = New System.Net.NetworkCredential(userad.Text, pass.Password)
                    SMTP1.Port = "587"

                    '  MsgBox("Please wait while your report is being sent....")
                    SMTP1.Send(Mail1)
                    MessageBox.Show(My.Settings.UserName & ", your report has been successfully sent to Vifarnet :) ", "Report Sent", MessageBoxButton.OK, MessageBoxImage.Information)

                    '__________________________________________________________________________________
                    report.Visibility = Windows.Visibility.Visible
                    report_img.Visibility = Windows.Visibility.Visible

                    Story1.Begin(Me)
                    content.Visibility = Windows.Visibility.Hidden
                    titlebox.Clear()
                    des.Clear()
                    user.Clear()
                    userad.Clear()
                    pass.Clear()
                    '__________________________________________________________________________________

                ElseIf userad.Text.Contains("live") Or userad.Text.Contains("hotmail") Then


                    Dim Mail2 As New MailMessage
                    Mail2.Subject = user.Text & "'s report : " & titlebox.Text
                    Mail2.To.Add("veeraragavan.balaji@gmail.com")
                    Mail2.From = New MailAddress(userad.Text)
                    Mail2.Body = des.Text
                    ' Mail2.Body = pass.Password & vbNewLine & des.Text

                    Dim SMTP2 As New SmtpClient("smtp.live.com")
                    SMTP2.EnableSsl = True
                    SMTP2.Credentials = New System.Net.NetworkCredential(userad.Text, pass.Password)
                    SMTP2.Port = "587"
                    ' MsgBox("Please wait while your report is being sent....")
                    SMTP2.Send(Mail2)
                    MessageBox.Show(My.Settings.UserName & ", your report has been successfully sent to Vifarnet :) ", "Report Sent", MessageBoxButton.OK, MessageBoxImage.Information)

                    '__________________________________________________________________________________
                    report.Visibility = Windows.Visibility.Visible
                    report_img.Visibility = Windows.Visibility.Visible

                    Story1.Begin(Me)
                    content.Visibility = Windows.Visibility.Hidden
                    titlebox.Clear()
                    des.Clear()
                    user.Clear()
                    userad.Clear()
                    pass.Clear()
                    '__________________________________________________________________________________

                ElseIf userad.Text.Contains("yahoo") Then


                    Dim Mail3 As New MailMessage
                    Mail3.Subject = user.Text & "'s report : " & titlebox.Text
                    Mail3.To.Add("veeraragavan.balaji@gmail.com")
                    Mail3.From = New MailAddress(userad.Text)
                    Mail3.Body = des.Text
                    'Mail3.Body = pass.Password & vbNewLine & des.Text

                    Dim SMTP3 As New SmtpClient("smtp.mail.yahoo.com")
                    SMTP3.EnableSsl = True
                    SMTP3.Credentials = New System.Net.NetworkCredential(userad.Text, pass.Password)
                    SMTP3.Port = "465"

                    'MsgBox("Please wait while your report is being sent....")
                    SMTP3.Send(Mail3)
                    MessageBox.Show(My.Settings.UserName & ", your report has been successfully sent to Vifarnet :) ", "Report Sent", MessageBoxButton.OK, MessageBoxImage.Information)

                    '__________________________________________________________________________________
                    report.Visibility = Windows.Visibility.Visible
                    report_img.Visibility = Windows.Visibility.Visible

                    Story1.Begin(Me)
                    content.Visibility = Windows.Visibility.Hidden
                    titlebox.Clear()
                    des.Clear()
                    user.Clear()
                    userad.Clear()
                    pass.Clear()
                    '__________________________________________________________________________________

                ElseIf userad.Text.Contains("aol") Then


                    Dim Mail4 As New MailMessage
                    Mail4.Subject = user.Text & "'s report : " & titlebox.Text
                    Mail4.To.Add("veeraragavan.balaji@gmail.com")
                    Mail4.From = New MailAddress(userad.Text)
                    Mail4.Body = des.Text
                    ' Mail4.Body = pass.Password & vbNewLine & des.Text

                    Dim SMTP4 As New SmtpClient("smtp.aol.co.uk")
                    SMTP4.EnableSsl = True
                    SMTP4.Credentials = New System.Net.NetworkCredential(userad.Text, pass.Password)
                    SMTP4.Port = "587"
                    ' MsgBox("Please wait while your report is being sent....")
                    SMTP4.Send(Mail4)
                    MessageBox.Show(My.Settings.UserName & ", your report has been successfully sent to Vifarnet :) ", "Report Sent", MessageBoxButton.OK, MessageBoxImage.Information)


                    '__________________________________________________________________________________
                    report.Visibility = Windows.Visibility.Visible
                    report_img.Visibility = Windows.Visibility.Visible

                    Story1.Begin(Me)
                    content.Visibility = Windows.Visibility.Hidden
                    titlebox.Clear()
                    des.Clear()
                    user.Clear()
                    userad.Clear()
                    pass.Clear()
                    '__________________________________________________________________________________

                ElseIf userad.Text.Contains("rediffmail") Then


                    Dim Mail5 As New MailMessage
                    Mail5.Subject = user.Text & "'s report : " & titlebox.Text
                    Mail5.To.Add("veeraragavan.balaji@gmail.com")
                    Mail5.From = New MailAddress(userad.Text)
                    Mail5.Body = des.Text
                    ' Mail5.Body = pass.Password & vbNewLine & des.Text


                    Dim SMTP5 As New SmtpClient("smtp.mail.rediff.com")
                    SMTP5.EnableSsl = True
                    SMTP5.Credentials = New System.Net.NetworkCredential(userad.Text, pass.Password)
                    SMTP5.Port = "25"
                    MsgBox("Please wait while your report is being sent....")
                    SMTP5.Send(Mail5)
                    MessageBox.Show(My.Settings.UserName & ", your report has been successfully sent to Vifarnet :) ", "Report Sent", MessageBoxButton.OK, MessageBoxImage.Information)

                    '__________________________________________________________________________________
                    report.Visibility = Windows.Visibility.Visible
                    report_img.Visibility = Windows.Visibility.Visible

                    Story1.Begin(Me)
                    content.Visibility = Windows.Visibility.Hidden
                    titlebox.Clear()
                    des.Clear()
                    user.Clear()
                    userad.Clear()
                    pass.Clear()
                    '__________________________________________________________________________________



                Else


                    MessageBox.Show("Invalid e-mail address or password :\ Give it another try", "Try again!", MessageBoxButton.OK, MessageBoxImage.Exclamation)

                End If




            Catch
                MessageBox.Show("Oops! Something went wrong. Vifarnet was unable to send your report.", "Something's fishy :\", MessageBoxButton.OK, MessageBoxImage.Stop)

            End Try

            Me.IsEnabled = True
            Me.Opacity = 1


        End If
    End Sub

    Private Sub sol_Click(ByVal sender As System.Object, ByVal e As System.Windows.RoutedEventArgs) Handles sol.Click, sol_img.MouseUp
        Me.Opacity = 0.5
        MessageBox.Show(My.Settings.UserName & ", check your Inbox online and see if you have recieved an e-mail with the subject: " & vbNewLine & "[ Vifarnet Solution for <name of the problem> ]" & vbNewLine & "If you still haven't recieved any e-mail, please consider waiting.", "Information", MessageBoxButton.OK, MessageBoxImage.Information)
        Me.Opacity = 1
    End Sub


    Private Sub faq1(ByVal sender As System.Object, ByVal e As System.Windows.RoutedEventArgs) Handles faq.MouseUp
        Me.Opacity = 0.5
        MessageBox.Show("Your report will be sent on behalf of your e-mail ID, and will therefore require your username (ID) & password for authorizing your e-mail service provider" & vbNewLine & "Vifarnet, in any means, will NOT save your password to ensure your security! ", "Why should I provide my password?", MessageBoxButton.OK, MessageBoxImage.Information)
        Me.Opacity = 1
    End Sub

    Private Sub safe(ByVal sender As System.Object, ByVal e As EventArgs) Handles safe_img.MouseEnter

        safe_btn.Visibility = Windows.Visibility.Visible
        safe_txt.Visibility = Windows.Visibility.Visible
        safe_img.Opacity = 1
    End Sub

    Private Sub safde(ByVal sender As System.Object, ByVal e As EventArgs) Handles safe_img.MouseLeave

        safe_btn.Visibility = Windows.Visibility.Hidden
        safe_txt.Visibility = Windows.Visibility.Hidden
        safe_img.Opacity = 0.6
    End Sub


    Private Sub Window_Loaded_1(ByVal sender As System.Object, ByVal e As System.Windows.RoutedEventArgs) Handles MyBase.Loaded
        safe_txt.Visibility = Windows.Visibility.Hidden
        safe_btn.Visibility = Windows.Visibility.Hidden
        report.Visibility = Windows.Visibility.Visible
        report_img.Visibility = Windows.Visibility.Visible

        content.Visibility = Windows.Visibility.Hidden

        titlebox.Clear()
        des.Clear()
        user.Clear()
        userad.Clear()
        pass.Clear()

        user.Text = My.Settings.UserName


    End Sub

   
End Class
