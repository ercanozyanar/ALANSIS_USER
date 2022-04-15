Imports System.Data.SqlClient
Imports System.Data
Imports System.Net.Sockets
Imports System.IO
Imports System.Text
Imports System.Threading
Imports System.Net
Public Class Form80
    Dim cmd As New SqlCommand()
    Dim cnn As New SqlConnection()
    Dim da As New SqlDataAdapter()
    Dim ds As New DataSet
    Dim i As Integer
    Dim kontrol As String
    Private Sub Form80_Load(sender As Object, e As EventArgs) Handles MyBase.Load


    End Sub


    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        DataGridView1.DataSource = ds
        ds.Clear()
        ds.Dispose()
        Try
            cnn.ConnectionString = "server=10.3.11.61;database=ALANSIS;uid=sa;pwd=term.0907"
            cnn.Open()
            cmd.Connection = cnn
            cmd.CommandType = CommandType.Text
            cmd.CommandText = "SELECT* FROM EO_ALANSIS_KIVI_PANEL1"
            da.SelectCommand = cmd
            da.Fill(ds)
            DataGridView1.DataSource = ds.Tables(0).DefaultView
            DataGridView1.AutoResizeColumns(DataGridViewAutoSizeColumnMode.AllCells)

            DataGridView1.Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            DataGridView1.Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            For i = 0 To DataGridView1.Rows.Count - 1
                Dim r As DataGridViewRow = DataGridView1.Rows(i)
                r.Height = 50
            Next
            For i = 0 To DataGridView1.Rows.Count - 1
                kontrol = DataGridView1.Rows(i).Cells(1).Value
                If kontrol = "2KALITE_MAMUL" Then
                    DataGridView1.Rows(i).DefaultCellStyle.BackColor = Color.LemonChiffon
                End If
                If kontrol = "MAMUL" Then
                    DataGridView1.Rows(i).DefaultCellStyle.BackColor = Color.LightBlue
                End If
                If kontrol = "YARIMAMUL_MAMUL" Then
                    DataGridView1.Rows(i).DefaultCellStyle.BackColor = Color.Aquamarine
                End If
                If kontrol = "COP" Then
                    DataGridView1.Rows(i).DefaultCellStyle.BackColor = Color.Red
                End If
                If kontrol = "SULUK" Then
                    DataGridView1.Rows(i).DefaultCellStyle.BackColor = Color.LightYellow
                End If
                kontrol = ""
            Next
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        cnn.Close()
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub
End Class