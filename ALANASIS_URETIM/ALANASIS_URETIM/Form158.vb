Imports System.Data.SqlClient
Imports System.Data
Imports System.Net.Sockets
Public Class Form158
    Dim SqlConnStr As String = "server=10.3.11.61;database=ALANSIS;uid=sa;pwd=term.0907;"
    Dim SqlConn As New System.Data.SqlClient.SqlConnection(SqlConnStr)
    Dim cmd As New SqlCommand()
    Dim cnn As New SqlConnection()
    Dim da As New SqlDataAdapter()
    Dim ds As New DataSet
    Dim i As Integer
    Private Sub Form158_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ComboBox1.Items.Clear()
        '---------------------------------------------------------------------------------------
        Dim cnn1 As New SqlConnection()
        cnn1.ConnectionString = "server=10.3.11.61;database=ALANSIS;uid=sa;pwd=term.0907"
        cnn1.Open()
        Dim mySelectQuery1 As String = "SELECT sarf_adi FROM EO_ALANSIS_SARFHAR_BAK WHERE DEPO_KODU= '30' group by sarf_adi;"
        Dim SqlComm1 As New System.Data.SqlClient.SqlCommand(mySelectQuery1, cnn1)
        Dim reader1 As System.Data.SqlClient.SqlDataReader
        reader1 = SqlComm1.ExecuteReader()
        While reader1.Read()
            ComboBox1.Items.Add(reader1("sarf_adi"))
        End While
        reader1.Close()
        cnn1.Close()
        '-----------------------------------------------------------------------------------------

    End Sub
    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged
        Dim cmd As New SqlCommand()
        Dim cnn As New SqlConnection()
        Dim da As New SqlDataAdapter()
        Dim ds As New DataSet
        TextEdit1.Text = ""
        TextEdit2.Text = ""
        TextEdit3.Text = ""
        Try
            cnn.ConnectionString = "server=10.3.11.61;database=ALANSIS;uid=sa;pwd=term.0907"
            cnn.Open()
            cmd.Connection = cnn
            cmd.CommandType = CommandType.Text
            cmd.CommandText = "SELECT TARIH,[NO] AS HAREKET_NO,SARF_ADI,(CASE HAREKET_KODU WHEN 'C' THEN 'CIKIS' WHEN 'G' THEN 'GIRIS' END) AS HAREKET_TIPI,MIKTAR,BOLGE FROM EO_ALANSIS_DEPO_SARFHAR WHERE SARF_ADI='" & ComboBox1.Text & "' AND SUBE='ALASEHIR' AND DEPO_KODU='30' ORDER BY ID ASC"
            da.SelectCommand = cmd
            da.Fill(ds)
            DataGridView1.DataSource = ds.Tables(0).DefaultView
            DataGridView1.Columns(0).Width = 150
            DataGridView1.Columns(1).Width = 100
            DataGridView1.Columns(2).Width = 500
            DataGridView1.Columns(3).Width = 100
            DataGridView1.Columns(4).Width = 100
            DataGridView1.Columns(5).Width = 170
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        cnn.Close()
        '---------------------------------------------------------------------------------------------------------------
        cnn.Open()
        Dim mySelectQuery6 As String = "SELECT* FROM EO_ALANSIS_SARFHAR_TGIR WHERE SARF_ADI= '" & ComboBox1.Text & "' AND SUBE='ALASEHIR' AND DEPO_KODU='30';"
        Dim SqlComm6 As New System.Data.SqlClient.SqlCommand(mySelectQuery6, cnn)
        Dim reader6 = SqlComm6.ExecuteReader()
        While reader6.Read()
            TextEdit1.Text = reader6("TGIRIS").ToString()
        End While
        If TextEdit1.Text = "" Then
            TextEdit1.Text = "0"
        End If
        reader6.Close()
        cnn.Close()
        '---------------------------------------------------------------------------------------------------------------
        cnn.Open()
        Dim mySelectQuery7 As String = "SELECT* FROM EO_ALANSIS_SARFHAR_TCIK WHERE SARF_ADI= '" & ComboBox1.Text & "' AND SUBE='ALASEHIR' AND DEPO_KODU='30';"
        Dim SqlComm7 As New System.Data.SqlClient.SqlCommand(mySelectQuery7, cnn)
        Dim reader7 = SqlComm7.ExecuteReader()
        While reader7.Read()
            TextEdit2.Text = reader7("TCIKIS").ToString()
        End While
        If TextEdit2.Text = "" Then
            TextEdit2.Text = "0"
        End If
        reader7.Close()
        cnn.Close()
        '--------------------------------------------------------------------------------------------------------
        '---------------------------------------------------------------------------------------------------------------
        TextEdit3.Text = TextEdit1.Text - TextEdit2.Text
    End Sub

    Private Sub GroupControl1_Paint(sender As Object, e As PaintEventArgs) Handles GroupControl1.Paint

    End Sub
End Class