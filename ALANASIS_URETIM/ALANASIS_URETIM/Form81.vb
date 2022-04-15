Imports System.Data.SqlClient
Imports System.Data
Imports System.Net.Sockets
Imports System.IO
Imports System.Text
Imports System.Threading
Imports System.Net
Public Class Form81
    Dim SqlConnStr As String = "server=10.3.11.61;database=ALANSIS;uid=sa;pwd=term.0907;"
    Dim SqlConn As New System.Data.SqlClient.SqlConnection(SqlConnStr)
    Private Sub Form81_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Dim cmd1, cmd2, cmd3, cmd4, cmd5, cmd6, cmd7, cmd8, cmd9 As New SqlCommand()
        Dim cnn As New SqlConnection()
        Dim da, da1, da2, da3, da4, da5, da6, da7, da8, da9 As New SqlDataAdapter()
        Dim ds, ds1, ds2, ds3, ds4, ds5, ds6, ds7, ds8, ds9 As New DataSet
        Try
            cnn.ConnectionString = "server=10.3.11.61;database=ALANSIS;uid=sa;pwd=term.0907"
            cnn.Open()
            cmd1.Connection = cnn
            cmd1.CommandType = CommandType.Text
            cmd1.CommandText = "SELECT* FROM EO_ALANSIS_KIVI_PALET_SARF"
            da1.SelectCommand = cmd1
            da1.Fill(ds1)
            DataGridView1.DataSource = ds1.Tables(0).DefaultView
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        cnn.Close()
        '-------------------------------------------------------------------------------------------------------------------------------
        Try
            cnn.ConnectionString = "server=10.3.11.61;database=ALANSIS;uid=sa;pwd=term.0907"
            cnn.Open()
            cmd2.Connection = cnn
            cmd2.CommandType = CommandType.Text
            cmd2.CommandText = "SELECT* FROM EO_ALANSIS_KIVI_FILE_SARF"
            da2.SelectCommand = cmd2
            da2.Fill(ds2)
            DataGridView2.DataSource = ds2.Tables(0).DefaultView
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        cnn.Close()
        Try
            cnn.ConnectionString = "server=10.3.11.61;database=ALANSIS;uid=sa;pwd=term.0907"
            cnn.Open()
            cmd3.Connection = cnn
            cmd3.CommandType = CommandType.Text
            cmd3.CommandText = "SELECT* FROM EO_ALANSIS_KIVI_EBAT_ETIKET_SARF"
            da3.SelectCommand = cmd3
            da3.Fill(ds3)
            DataGridView3.DataSource = ds3.Tables(0).DefaultView
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        cnn.Close()
        Try
            cnn.ConnectionString = "server=10.3.11.61;database=ALANSIS;uid=sa;pwd=term.0907"
            cnn.Open()
            cmd4.Connection = cnn
            cmd4.CommandType = CommandType.Text
            cmd4.CommandText = "SELECT* FROM EO_ALANSIS_KIVI_ETIKET_SARF"
            da4.SelectCommand = cmd4
            da4.Fill(ds4)
            DataGridView4.DataSource = ds4.Tables(0).DefaultView
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        cnn.Close()
        Try
            cnn.ConnectionString = "server=10.3.11.61;database=ALANSIS;uid=sa;pwd=term.0907"
            cnn.Open()
            cmd5.Connection = cnn
            cmd5.CommandType = CommandType.Text
            cmd5.CommandText = "SELECT* FROM EO_ALANSIS_KIVI_KLIPS_SARF"
            da5.SelectCommand = cmd5
            da5.Fill(ds5)
            DataGridView5.DataSource = ds5.Tables(0).DefaultView
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        cnn.Close()
        Try
            cnn.ConnectionString = "server=10.3.11.61;database=ALANSIS;uid=sa;pwd=term.0907"
            cnn.Open()
            cmd6.Connection = cnn
            cmd6.CommandType = CommandType.Text
            cmd6.CommandText = "SELECT* FROM EO_ALANSIS_KIVI_KOSEBENT_SARF"
            da6.SelectCommand = cmd6
            da6.Fill(ds6)
            DataGridView6.DataSource = ds6.Tables(0).DefaultView
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        cnn.Close()
        Try
            cnn.ConnectionString = "server=10.3.11.61;database=ALANSIS;uid=sa;pwd=term.0907"
            cnn.Open()
            cmd7.Connection = cnn
            cmd7.CommandType = CommandType.Text
            cmd7.CommandText = "SELECT* FROM EO_ALANSIS_KIVI_KUTU_SARF"
            da7.SelectCommand = cmd7
            da7.Fill(ds7)
            DataGridView7.DataSource = ds7.Tables(0).DefaultView
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        cnn.Close()
        Try
            cnn.ConnectionString = "server=10.3.11.61;database=ALANSIS;uid=sa;pwd=term.0907"
            cnn.Open()
            cmd8.Connection = cnn
            cmd8.CommandType = CommandType.Text
            cmd8.CommandText = "SELECT* FROM EO_ALANSIS_KIVI_SALE_SARF"
            da8.SelectCommand = cmd8
            da8.Fill(ds8)
            DataGridView8.DataSource = ds8.Tables(0).DefaultView
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        cnn.Close()

        Try
            cnn.ConnectionString = "server=10.3.11.61;database=ALANSIS;uid=sa;pwd=term.0907"
            cnn.Open()
            cmd9.Connection = cnn
            cmd9.CommandType = CommandType.Text
            cmd9.CommandText = "SELECT* FROM EO_ALANSIS_KIVI_SAPKA_SARF"
            da9.SelectCommand = cmd9
            da9.Fill(ds9)
            DataGridView9.DataSource = ds9.Tables(0).DefaultView
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        cnn.Close()
        DataGridView1.Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        DataGridView2.Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        DataGridView3.Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        DataGridView4.Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        DataGridView5.Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        DataGridView6.Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        DataGridView7.Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        DataGridView8.Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        DataGridView9.Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight

    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click

    End Sub
End Class