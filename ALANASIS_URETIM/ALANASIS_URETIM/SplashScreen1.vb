Public Class SplashScreen1
    Sub New
        InitializeComponent()
        Me.labelCopyright.Text = "Alansis Copyright © 2020-" & DateTime.Now.Year.ToString()
    End Sub

    Public Overrides Sub ProcessCommand(ByVal cmd As System.Enum, ByVal arg As Object)
        MyBase.ProcessCommand(cmd, arg)
    End Sub

    Public Enum SplashScreenCommand
        SomeCommandId
    End Enum

    Private Sub SplashScreen1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub peImage_EditValueChanged(sender As Object, e As EventArgs) Handles peImage.EditValueChanged

    End Sub
End Class
