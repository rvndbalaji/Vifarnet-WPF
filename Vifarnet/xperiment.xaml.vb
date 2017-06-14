Imports System.Windows.Media.Animation

Public Class xperiment

    Private Story As Storyboard
    Dim StrtScrn As MainWindow = TryCast(Application.Current.MainWindow, MainWindow)



    Private Sub xper_Loaded(sender As System.Object, e As System.Windows.RoutedEventArgs) Handles MyBase.Loaded
        Story.Begin(Me)
    End Sub
End Class