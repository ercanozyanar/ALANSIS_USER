Imports DevExpress.DashboardCommon
Public Class Form103
    Private Sub DashboardViewer1_ConfigureDataConnection(sender As Object, e As DashboardConfigureDataConnectionEventArgs) Handles DashboardViewer1.ConfigureDataConnection
        Dim cp As New DevExpress.DataAccess.ConnectionParameters.MsSqlConnectionParameters
        cp = TryCast(e.ConnectionParameters, DevExpress.DataAccess.ConnectionParameters.MsSqlConnectionParameters)
        If cp Is Nothing Then
            Return
        End If
        cp.ServerName = "ALRNETSIS"
        cp.DatabaseName = "ALANAR2021"
        cp.UserName = "sa"
        cp.Password = "term.0907"
    End Sub
End Class