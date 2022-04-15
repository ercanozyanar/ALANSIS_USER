Imports System.Data.SqlClient
Imports System.Data
Imports System.Net.Sockets
Imports Excel = Microsoft.Office.Interop.Excel
Public Class Form97
    Dim SqlConnStr As String = "server=10.3.11.61;database=ALANSIS;uid=sa;pwd=term.0907;"
    Dim SqlConn As New System.Data.SqlClient.SqlConnection(SqlConnStr)
    Private Sub Form97_Load(sender As Object, e As EventArgs) Handles Me.Load
        '---------------------------------------------------------------------------------------
        SqlConn.Open()
        Dim mySelectQuery1 As String = "SELECT BOLGE FROM EO_ALANSIS_SATIS_DETAYVW GROUP BY BOLGE;"
        Dim SqlComm1 As New System.Data.SqlClient.SqlCommand(mySelectQuery1, SqlConn)
        Dim reader1 As System.Data.SqlClient.SqlDataReader
        reader1 = SqlComm1.ExecuteReader()
        While reader1.Read()
            ComboBox1.Items.Add(reader1("BOLGE"))
        End While
        reader1.Close()
        SqlConn.Close()
        '-----------------------------------------------------------------------------------------
        SqlConn.Open()
        Dim mySelectQuery2 As String = "SELECT URUN FROM EO_ALANSIS_SATIS_DETAYVW GROUP BY URUN;"
        Dim SqlComm2 As New System.Data.SqlClient.SqlCommand(mySelectQuery2, SqlConn)
        Dim reader2 As System.Data.SqlClient.SqlDataReader
        reader2 = SqlComm2.ExecuteReader()
        While reader2.Read()
            ComboBox2.Items.Add(reader2("URUN"))
        End While
        reader2.Close()
        SqlConn.Close()
        '-----------------------------------------------------------------------------------------
        SqlConn.Open()
        Dim mySelectQuery3 As String = "SELECT HAFTA FROM EO_ALANSIS_SATIS_DETAYVW GROUP BY HAFTA;"
        Dim SqlComm3 As New System.Data.SqlClient.SqlCommand(mySelectQuery3, SqlConn)
        Dim reader3 As System.Data.SqlClient.SqlDataReader
        reader3 = SqlComm3.ExecuteReader()
        While reader3.Read()
            ComboBox3.Items.Add(reader3("HAFTA"))
        End While
        reader3.Close()
        SqlConn.Close()
        '-----------------------------------------------------------------------------------------
        SqlConn.Open()
        Dim mySelectQuery4 As String = "SELECT VADE_TARIH FROM EO_ALANSIS_SATIS_DETAYVW1 GROUP BY VADE_TARIH;"
        Dim SqlComm4 As New System.Data.SqlClient.SqlCommand(mySelectQuery4, SqlConn)
        Dim reader4 As System.Data.SqlClient.SqlDataReader
        reader4 = SqlComm4.ExecuteReader()
        While reader4.Read()
            ComboBox4.Items.Add(reader4("VADE_TARIH"))
        End While
        reader4.Close()
        SqlConn.Close()
        '-----------------------------------------------------------------------------------------
        Dim cmd As New SqlCommand()
        Dim cnn As New SqlConnection()
        Dim da As New SqlDataAdapter()
        Dim ds As New DataSet
        Try
            cnn.ConnectionString = "server=10.3.11.61;database=ALANSIS;uid=sa;pwd=term.0907"
            cnn.Open()
            cmd.Connection = cnn
            cmd.CommandType = CommandType.Text
            cmd.CommandText = "SELECT* FROM EO_ALANSIS_SATIS_DETAYVW2"
            da.SelectCommand = cmd
            da.Fill(ds)
            DataGridView3.DataSource = ds.Tables(0).DefaultView
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        cnn.Close()
        '-------------------------------------------------------------------------------------
        For i = 0 To DataGridView3.Rows.Count - 1 Step 2
            DataGridView3.Rows(i).DefaultCellStyle.BackColor = Color.LemonChiffon
        Next
        DataGridView3.AutoResizeColumns(DataGridViewAutoSizeColumnMode.AllCells)
        '---------------------------------------------------------------------------------------
        '--------------

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs)
        Dim cmd As New SqlCommand()
        Dim cnn As New SqlConnection()
        Dim da As New SqlDataAdapter()
        Dim ds As New DataSet
        Try
            cnn.ConnectionString = "server=10.3.11.61;database=ALANSIS;uid=sa;pwd=term.0907"
            cnn.Open()
            cmd.Connection = cnn
            cmd.CommandType = CommandType.Text
            cmd.CommandText = "SELECT HAFTA,BOLGE,URUN,SUM(TOPLAM_NETMIKTAR) AS TOPLAM_NETMIKTAR,SUM(TOPLAM_CIF) AS TOPLAM_CIF,SUM(TOPLAM_FOB) AS TOPLAM_FOB,SUM(TOPLAM_FOBBIRIM) AS TOPLAM_FOBBIRIM FROM EO_ALANSIS_SATIS_DETAYVW WHERE BOLGE='" & ComboBox1.Text & "' GROUP BY BOLGE,URUN,HAFTA"
            da.SelectCommand = cmd
            da.Fill(ds)
            DataGridView1.DataSource = ds.Tables(0).DefaultView
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        cnn.Close()
        '-------------------------------------------------------------------------------------
        For i = 0 To DataGridView1.Rows.Count - 1 Step 2
            DataGridView1.Rows(i).DefaultCellStyle.BackColor = Color.LemonChiffon
        Next
        DataGridView1.AutoResizeColumns(DataGridViewAutoSizeColumnMode.AllCells)
        '---------------------------------------------------------------------------------------
    End Sub
    Private Sub ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs)
        Dim cmd As New SqlCommand()
        Dim cnn As New SqlConnection()
        Dim da As New SqlDataAdapter()
        Dim ds As New DataSet
        Try
            cnn.ConnectionString = "server=10.3.11.61;database=ALANSIS;uid=sa;pwd=term.0907"
            cnn.Open()
            cmd.Connection = cnn
            cmd.CommandType = CommandType.Text
            cmd.CommandText = "SELECT HAFTA,BOLGE,URUN,SUM(TOPLAM_NETMIKTAR) AS TOPLAM_NETMIKTAR,SUM(TOPLAM_CIF) AS TOPLAM_CIF,SUM(TOPLAM_FOB) AS TOPLAM_FOB,SUM(TOPLAM_FOBBIRIM) AS TOPLAM_FOBBIRIM FROM EO_ALANSIS_SATIS_DETAYVW WHERE URUN='" & ComboBox2.Text & "' GROUP BY BOLGE,URUN,HAFTA"
            da.SelectCommand = cmd
            da.Fill(ds)
            DataGridView1.DataSource = ds.Tables(0).DefaultView
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        cnn.Close()
        '-------------------------------------------------------------------------------------
        For i = 0 To DataGridView1.Rows.Count - 1 Step 2
            DataGridView1.Rows(i).DefaultCellStyle.BackColor = Color.LemonChiffon
        Next
        DataGridView1.AutoResizeColumns(DataGridViewAutoSizeColumnMode.AllCells)
        '---------------------------------------------------------------------------------------
        '---------------------------------------------------------------------------------------
    End Sub
    Private Sub ComboBox3_SelectedIndexChanged(sender As Object, e As EventArgs)
        Dim cmd As New SqlCommand()
        Dim cnn As New SqlConnection()
        Dim da As New SqlDataAdapter()
        Dim ds As New DataSet
        Try
            cnn.ConnectionString = "server=10.3.11.61;database=ALANSIS;uid=sa;pwd=term.0907"
            cnn.Open()
            cmd.Connection = cnn
            cmd.CommandType = CommandType.Text
            cmd.CommandText = "SELECT HAFTA,BOLGE,URUN,SUM(TOPLAM_NETMIKTAR) AS TOPLAM_NETMIKTAR,SUM(TOPLAM_CIF) AS TOPLAM_CIF,SUM(TOPLAM_FOB) AS TOPLAM_FOB,SUM(TOPLAM_FOBBIRIM) AS TOPLAM_FOBBIRIM FROM EO_ALANSIS_SATIS_DETAYVW WHERE HAFTA='" & ComboBox3.Text & "' GROUP BY BOLGE,URUN,HAFTA"
            da.SelectCommand = cmd
            da.Fill(ds)
            DataGridView1.DataSource = ds.Tables(0).DefaultView
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        cnn.Close()
        '-------------------------------------------------------------------------------------
        For i = 0 To DataGridView1.Rows.Count - 1 Step 2
            DataGridView1.Rows(i).DefaultCellStyle.BackColor = Color.LemonChiffon
        Next
        DataGridView1.AutoResizeColumns(DataGridViewAutoSizeColumnMode.AllCells)
        '---------------------------------------------------------------------------------------
        '--------------
    End Sub

    Private Sub ComboBox4_SelectedIndexChanged(sender As Object, e As EventArgs)
        Dim cmd As New SqlCommand()
        Dim cnn As New SqlConnection()
        Dim da As New SqlDataAdapter()
        Dim ds As New DataSet
        If ComboBox4.Text = "Tümü" Then
            Try
                cnn.ConnectionString = "server=10.3.11.61;database=ALANSIS;uid=sa;pwd=term.0907"
                cnn.Open()
                cmd.Connection = cnn
                cmd.CommandType = CommandType.Text
                cmd.CommandText = "SELECT DOV_KOD, SUM(ALACAK) AS TOPLAM_ALACAK, SUM(BORC) AS TOPLAM_BORC, SUM(ALACAK - BORC) AS TOPLAM_RISK FROM dbo.EO_ALANSIS_SATIS_DETAY GROUP BY DOV_KOD"
                da.SelectCommand = cmd
                da.Fill(ds)
                DataGridView2.DataSource = ds.Tables(0).DefaultView
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
            cnn.Close()
            '-------------------------------------------------------------------------------------
            For i = 0 To DataGridView2.Rows.Count - 1 Step 2
                DataGridView2.Rows(i).DefaultCellStyle.BackColor = Color.LemonChiffon
            Next
            DataGridView2.AutoResizeColumns(DataGridViewAutoSizeColumnMode.AllCells)
            '---------------------------------------------------------------------------------------
        Else
            Try
                cnn.ConnectionString = "server=10.3.11.61;database=ALANSIS;uid=sa;pwd=term.0907"
                cnn.Open()
                cmd.Connection = cnn
                cmd.CommandType = CommandType.Text
                cmd.CommandText = "SELECT* FROM EO_ALANSIS_SATIS_DETAYVW1 WHERE VADE_TARIH='" & ComboBox4.Text & "'"
                da.SelectCommand = cmd
                da.Fill(ds)
                DataGridView2.DataSource = ds.Tables(0).DefaultView
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
            cnn.Close()
            '-------------------------------------------------------------------------------------
            For i = 0 To DataGridView2.Rows.Count - 1 Step 2
                DataGridView2.Rows(i).DefaultCellStyle.BackColor = Color.LemonChiffon
            Next
            DataGridView2.AutoResizeColumns(DataGridViewAutoSizeColumnMode.AllCells)
            '---------------------------------------------------------------------------------------
        End If
    End Sub

    Private Sub TabPage1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)

    End Sub
End Class