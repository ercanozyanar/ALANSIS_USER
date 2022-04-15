Imports System.Data.SqlClient
Imports System.Data
Imports System.Net.Sockets
Public Class Form178
    Dim SqlConnStr As String = "server=10.3.11.61;database=ALANSIS;uid=sa;pwd=term.0907;"
    Dim SqlConn As New System.Data.SqlClient.SqlConnection(SqlConnStr)
    Dim cmd As New SqlCommand()
    Dim cnn As New SqlConnection()
    Dim da As New SqlDataAdapter()
    Dim ds As New DataSet
    Dim i As Integer
    Private Sub Form178_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: Bu kod satırı 'ALANSISDataSet35.EO_ALANSIS_URETICIANALIZSIZ' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
        Me.EO_ALANSIS_URETICIANALIZSIZTableAdapter.Fill(Me.ALANSISDataSet35.EO_ALANSIS_URETICIANALIZSIZ)

    End Sub

    Private Sub ComboBoxEdit1_EditValueChanged(sender As Object, e As EventArgs) Handles ComboBoxEdit1.EditValueChanged
        Dim connectionString As String = "server=10.3.11.61;database=ALANSIS;uid=sa;pwd=term.0907"
        Dim sql As String = "SELECT* FROM EO_ALANSIS_MADHAMKABUL WHERE URETICI_ADSOY='" & ComboBoxEdit1.Text & "' AND RENK='AL'"
        Dim connection As New SqlConnection(connectionString)
        Dim dataadapter As New SqlDataAdapter(sql, connection)
        Dim ds As New DataSet()
        connection.Open()
        dataadapter.Fill(ds, "Firma")
        connection.Close()
        GridControl1.DataSource = ds
        GridControl1.DataMember = "Firma"
        GridView1.OptionsView.ColumnAutoWidth = False
        GridView1.OptionsView.BestFitMaxRowCount = -1
        GridView1.BestFitColumns()
    End Sub

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        Dim conn1 As New SqlConnection
        Dim cmd1 As New SqlCommand
        Dim cmd As New SqlCommand()
        Dim cnn As New SqlConnection()
        Dim da As New SqlDataAdapter()
        Dim ds As New DataSet
        Dim NUMARA
        '---------------------------------------------------------------------------------------------------------------
        SqlConn.Open()
        Dim mySelectQuery9 As String = "SELECT URETICI_TC FROM EO_ALANSIS_MAD WHERE URETICI_ADSOY='" & ComboBoxEdit1.Text & "' GROUP BY URETICI_TC;"
        Dim SqlComm9 As New System.Data.SqlClient.SqlCommand(mySelectQuery9, SqlConn)
        Dim reader9 As System.Data.SqlClient.SqlDataReader
        reader9 = SqlComm9.ExecuteReader()
        While reader9.Read()
            NUMARA = (reader9("URETICI_TC"))
        End While

        reader9.Close()
        SqlConn.Close()
        '---------------------------------------------------------------------------------------------------------------
        conn1.ConnectionString = "server=10.3.11.61;database=ALANSIS;uid=sa;pwd=term.0907"
        '--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
        conn1.Open()
        cmd1.Connection = conn1
        cmd1.CommandText = "INSERT INTO EO_ALANSIS_URETICIRENKREVIZE (URETICI_ID,URETICI_ADSOY,ONCEKI_RENK,SONRAKI_RENK,REVIZE_TARIH) VALUES ('" & NUMARA & "','" & ComboBoxEdit1.Text & "', 'AL','" & TextBox1.Text & "','" & DateTime.Now & "')"
        cmd1.ExecuteNonQuery()
        conn1.Close()
        conn1.Open()
        cmd1.Connection = conn1
        cmd1.CommandText = "UPDATE EO_ALANSIS_MADHAMKABUL SET RENK='" & TextBox1.Text & "' WHERE URETICI_ADSOY='" & ComboBoxEdit1.Text & "'"
        cmd1.ExecuteNonQuery()
        conn1.Close()
        '--------------------------------------------------------------------------------------------------------------------------------------------
        Dim connectionString As String = "server=10.3.11.61;database=ALANSIS;uid=sa;pwd=term.0907"
        Dim sql As String = "SELECT* FROM EO_ALANSIS_MADHAMKABUL WHERE URETICI_ADSOY='" & ComboBoxEdit1.Text & "' AND RENK='AL'"
        Dim connection As New SqlConnection(connectionString)
        Dim dataadapter As New SqlDataAdapter(sql, connection)
        connection.Open()
        dataadapter.Fill(ds, "Firma")
        connection.Close()
        GridControl1.DataSource = ds
        GridControl1.DataMember = "Firma"
        GridView1.OptionsView.ColumnAutoWidth = False
        GridView1.OptionsView.BestFitMaxRowCount = -1
        GridView1.BestFitColumns()
        DevExpress.XtraEditors.XtraMessageBox.Show("İşlem Tamamlanmıştır...")
    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        TextBox1.Text = "YS"
    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged
        TextBox1.Text = "KR"
    End Sub

    Private Sub RadioButton3_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton3.CheckedChanged
        TextBox1.Text = "MV"
    End Sub

    Private Sub RadioButton4_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton4.CheckedChanged
        TextBox1.Text = "SR"
    End Sub
End Class