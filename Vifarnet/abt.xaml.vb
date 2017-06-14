Public Class abt

    Private Sub abt_Closed(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Closing

        Dim rootWindow As MainWindow = TryCast(Application.Current.MainWindow, MainWindow)
        rootWindow.WindowState = Windows.WindowState.Normal

    End Sub
    Private Sub ab_Closed(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Loaded
        Dim rootWindow As MainWindow = TryCast(Application.Current.MainWindow, MainWindow)
        rootWindow.WindowState = Windows.WindowState.Minimized

    End Sub

End Class
