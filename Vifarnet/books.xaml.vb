Public Class books

    Private Sub Windoaw_Loaded(ByVal sender As System.Object, ByVal e As EventArgs) Handles MyBase.Closed
        Dim rootWindow As MainWindow = TryCast(Application.Current.MainWindow, MainWindow)
        rootWindow.WindowState = Windows.WindowState.Normal

    End Sub

End Class
