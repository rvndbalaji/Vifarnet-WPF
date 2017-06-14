Public Class mytasks

    Private Sub book_Click(sender As System.Object, e As System.Windows.RoutedEventArgs) Handles book.Click
        If dt.Text <= TimeOfDay Then
            MessageBox.Show("The time of the task has already passed by. Please enter a future time.", "Past is Past!", MessageBoxButton.OK, MessageBoxImage.Exclamation)


        Else

            If title.Text = Nothing Or
                title.Text = "Remind me to..." Or
                des.Text = Nothing Or
                des.Text = "What's it all about..." Then
                MessageBox.Show("The Title or the Decription field cannot contain default statements nor should it be left blank", "Invalid Input", MessageBoxButton.OK, MessageBoxImage.Exclamation)

            End If


            Dim m As System.Timers.Timer
            'm.Start()

            If dt.Text = TimeOfDay Then
                'rim.ShowDialog()
                MessageBox.Show("Reminder")
                m.Stop()
                m.Enabled = False
            End If


            My.Settings.r1.Insert(0, Me.des.Text)
            My.Settings.r1.Insert(1, Me.title.Text)
            My.Settings.r1.Insert(2, Me.dt.Text)

            'lstbk.list.Items.Add(Me.title.Text)




            My.Settings.Save()


            End If
    End Sub

End Class
