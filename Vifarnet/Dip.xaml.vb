Public Class Dip

    Private Sub dipbtn_Click(sender As System.Object, e As System.Windows.RoutedEventArgs) Handles dipbtn.Click

        Me.Opacity = 0.2
        Dim d_calc As New d_calc
        d_calc.ShowDialog()
        Me.Opacity = 1
    End Sub
End Class
