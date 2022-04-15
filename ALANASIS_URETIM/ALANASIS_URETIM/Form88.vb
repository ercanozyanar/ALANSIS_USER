Imports DevExpress.DashboardCommon
Public Class Form88

    Private Sub DashboardViewer1_ConfigureDataConnection(sender As Object, e As DashboardConfigureDataConnectionEventArgs) Handles DashboardViewer1.ConfigureDataConnection
        Dim cp As New DevExpress.DataAccess.ConnectionParameters.MsSqlConnectionParameters
        cp = TryCast(e.ConnectionParameters, DevExpress.DataAccess.ConnectionParameters.MsSqlConnectionParameters)
        If cp Is Nothing Then
            Return
        End If
        cp.ServerName = "ALRNETSIS"
        cp.DatabaseName = "ALANSIS"
        cp.UserName = "sa"
        cp.Password = "term.0907"



    End Sub

    Private Sub DashboardViewer1_Load(sender As Object, e As EventArgs) Handles DashboardViewer1.Load

    End Sub
End Class