Public Class pass

    Private Sub ok_Click(ByVal sender As System.Object, ByVal e As System.Windows.RoutedEventArgs) Handles ok.Click
        If pw.Password = "dip" Then
            Me.Close()
            Dim Dip As New Dip
            Dip.Show()
            Dip.Activate()

        ElseIf pw.Password = "lr" Then
            Me.Close()
            Dim lr As New lr
            lr.Show()
            lr.Activate()

        Else : MessageBox.Show("Oops! Password is incorrect :\", "Access denied", MessageBoxButton.OK, MessageBoxImage.Exclamation)

        End If
    End Sub

    Private Sub Window_Loaded(ByVal sender As System.Object, ByVal e As System.Windows.RoutedEventArgs) Handles MyBase.Loaded
        Me.Activate()
        pw.Focus()
    End Sub
End Class
