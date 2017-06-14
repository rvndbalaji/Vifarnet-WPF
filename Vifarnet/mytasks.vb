Public Class mytasks

    Private Sub Vifmt_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        My.Settings.list.Insert(0, "Booked Tasks List")


        dt.Value = System.DateTime.Now
        nfi.Visible = False


        Dim rootWindow As MainWindow = TryCast(Application.Current.MainWindow, MainWindow)
        user.Text = rootWindow.user.Content

        user.Text = My.Settings.UserName
        My.Settings.Save()
        My.Settings.Reload()


    End Sub


    Private Sub about_asfClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.FormClosed
        Dim rootWindow As MainWindow = TryCast(Application.Current.MainWindow, MainWindow)
        rootWindow.WindowState = Windows.WindowState.Normal
    End Sub

    Private Sub Button1_Click_2(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mt_abt.Click

        MessageBox.Show("                         Vifarnet MyTasks" & vbNewLine & " " & vbNewLine & "Programmed & designed by Aravind Balaji" & vbNewLine & "©2013 Vifarnet Corporation. All Rights Reserved.", "About", MessageBoxButton.OK, MessageBoxImage.Information)

    End Sub

    Private Sub Busstton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mt_abt.MouseEnter

        mt_abt.Text = "About "
        mt_abt.Size = New System.Drawing.Size(110, 47)
        mt_abt.Location = New System.Drawing.Point(697, 402)

    End Sub

    Private Sub Busattoan2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mt_abt.MouseLeave

        mt_abt.Text = ""
        mt_abt.Size = New System.Drawing.Size(69, 47)
        mt_abt.Location = New System.Drawing.Point(738, 402)

    End Sub

    Private Sub book_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles book.Click

        If dt.Text <= FormatDateTime(TimeOfDay) Then
            MessageBox.Show("The time of the task has already passed by. Please enter a future time.", "Past is Past!", MessageBoxButton.OK, MessageBoxImage.Exclamation)

        Else

            If title.Text = Nothing Or
                title.Text = "Title/Subject" Or
                des.Text = Nothing Or
                des.Text = "Description" Then

                MessageBox.Show("The Title or the Decription field cannot be left blank or default.", "Invalid Input", MessageBoxButton.OK, MessageBoxImage.Exclamation)
            End If



        End If


        m.Enabled = True
        m.Start()



        My.Settings.r1.Insert(0, Me.des.Text)
        My.Settings.r1.Insert(1, Me.title.Text)
        My.Settings.r1.Insert(2, Me.dt.Text)

        'lstbk.list.Items.Add(Me.title.Text)




        My.Settings.Save()

    End Sub

    Private Sub m_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles m.Tick
        If dt.Text = FormatDateTime(TimeOfDay) Then

            Dim rim As New rim
            rim.ShowDialog()

            m.Stop()
            m.Enabled = False
        End If

    End Sub


    Private Sub ExitMyTasksToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Xit.Click
        If MessageBox.Show("If you quit now, your tasks will be cancelled. " & vbNewLine & "(It is recommended that you minimize 'My tasks' to the taskbar)" & vbNewLine & " Are you sure you want to quit?", "Quit confirmation", MessageBoxButton.YesNo, MessageBoxImage.Question) = vbYes Then

            Me.Close()
        End If
    End Sub

    Private Sub about_Click(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        '...................

        nfi.Visible = False
        My.Settings.UserName = user.Text
        My.Settings.Save()

    End Sub

    Private Sub Show_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles showMTasks.Click
        nfi.Visible = False
        Me.Visible = True

    End Sub


    Private Sub nfi_MouseDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles nfi.MouseDoubleClick
        showMTasks.PerformClick()
    End Sub

    Private Sub minsf_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles min.Click
        My.Settings.UserName = user.Text
        My.Settings.Save()
        '________________________________

        Dim rootWindow As MainWindow = TryCast(Application.Current.MainWindow, MainWindow)
        rootWindow.WindowState = Windows.WindowState.Minimized
        Me.Visible = False
        nfi.Visible = True
    End Sub

    'Private Sub PictureBox2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles xitmt.Click
    'If MessageBox.Show("If you quit now, your tasks will be cancelled. " & vbNewLine & "(It is recommended that you minimize 'My tasks' to the taskbar)" & vbNewLine & "Are you sure you want to quit?", "Quit confirmation", MessageBoxButton.YesNo, MessageBoxImage.Question) = vbYes Then

    'Me.Close()
    '  End If
    'End Sub

    Private Sub min_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles min.MouseEnter
        min.BackColor = System.Drawing.Color.Moccasin
    End Sub
    Private Sub min_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles min.MouseLeave
        min.BackColor = System.Drawing.Color.Transparent
    End Sub

End Class
