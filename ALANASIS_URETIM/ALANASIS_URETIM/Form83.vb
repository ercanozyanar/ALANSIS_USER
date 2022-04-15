Imports System.Data.SqlClient
Imports System.Data
Imports System.Net.Sockets
Imports System.IO
Imports System.Text
Imports System.Threading
Imports System.Net
Public Class Form83
    Dim cmd, cmd1 As New SqlCommand()
    Dim cnn, cnn1 As New SqlConnection()
    Dim da, da1 As New SqlDataAdapter()
    Dim ds, ds1 As New DataSet

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        DataGridView2.DataSource = ds1
        ds1.Clear()
        ds1.Dispose()
        '-----------------------------------------------------------------------------------------------------------------------
        Try
            cnn1.ConnectionString = "server=10.3.11.61;database=ALANSIS;uid=sa;pwd=term.0907"
            cnn1.Open()
            cmd1.Connection = cnn1
            cmd1.CommandType = CommandType.Text
            cmd1.CommandText = "SELECT* FROM EO_ALANSIS_GUNLUKH_SARF"
            da1.SelectCommand = cmd1
            da1.Fill(ds1)
            DataGridView2.DataSource = ds1.Tables(0).DefaultView
            DataGridView2.AutoResizeColumns(DataGridViewAutoSizeColumnMode.AllCells)

            For i = 0 To DataGridView2.Rows.Count - 1
                Dim r As DataGridViewRow = DataGridView2.Rows(i)
                r.Height = 20
            Next

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        cnn1.Close()
        '-----------------------------------------------------------------------------------------------------------------------

    End Sub

    Dim i As Integer

    Private Sub Form83_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        DataGridView1.DataSource = ds
        ds.Clear()
        ds.Dispose()

        '---------------------------------------------------------------------------------------------------------------
        Try
            cnn.ConnectionString = "server=10.3.11.61;database=ALANSIS;uid=sa;pwd=term.0907"
            cnn.Open()
            cmd.Connection = cnn
            cmd.CommandType = CommandType.Text
            cmd.CommandText = "SELECT* FROM EO_ALANSIS_GUNLUKM_SARF"
            da.SelectCommand = cmd
            da.Fill(ds)
            DataGridView1.DataSource = ds.Tables(0).DefaultView
            DataGridView1.AutoResizeColumns(DataGridViewAutoSizeColumnMode.AllCells)

            For i = 0 To DataGridView1.Rows.Count - 1
                Dim r As DataGridViewRow = DataGridView1.Rows(i)
                r.Height = 20
            Next

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        cnn.Close()

    End Sub
End Class