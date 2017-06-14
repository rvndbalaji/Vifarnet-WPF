Public Class math

    Private Sub Image1_ImageFailed(ByVal sender As System.Object, ByVal e As EventArgs) Handles calc.MouseUp
        Process.Start("calc.exe")
    End Sub

    Private Sub Windoaw_Loaded(ByVal sender As System.Object, ByVal e As EventArgs) Handles MyBase.Closed
        Dim rootWindow As MainWindow = TryCast(Application.Current.MainWindow, MainWindow)
        rootWindow.WindowState = Windows.WindowState.Normal

    End Sub

    Private Sub dip_btn_Click(sender As System.Object, e As System.Windows.RoutedEventArgs) Handles dip_btn.Click
        Me.Opacity = 0.4
        Dim pass As New pass
        pass.ShowDialog()
        pass.Activate()
        Me.Opacity = 1
    End Sub

End Class
