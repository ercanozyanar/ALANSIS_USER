Imports System.Data.SqlClient
Imports System.Data
Imports System.Net.Sockets
Public Class Form151
    Dim SqlConnStr As String = "server=10.3.11.61;database=ALANSIS;uid=sa;pwd=term.0907;"
    Dim SqlConn As New System.Data.SqlClient.SqlConnection(SqlConnStr)
    Dim cmd As New SqlCommand()
    Dim cnn As New SqlConnection()
    Dim da As New SqlDataAdapter()
    Dim dt As New DataTable
    Private Sub Form151_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: Bu kod satırı 'ALANSISDataSet2.EO_ALANSIS_RECETEVW' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
        Me.EO_ALANSIS_RECETEVWTableAdapter.Fill(Me.ALANSISDataSet2.EO_ALANSIS_RECETEVW)

    End Sub

    Private Sub GroupControl1_Paint(sender As Object, e As PaintEventArgs) Handles GroupControl1.Paint

    End Sub

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        On Error GoTo hata
        Dim conn1, conn2 As New SqlConnection
        Dim cmd1, cmd2, cmd3 As New SqlCommand
        Dim net, gross As Decimal
        net = TextEdit7.Text
        gross = TextEdit13.Text
        Dim recetex
        recetex = ""
        recetex = Date.Now.Year & Date.Now.Month & Date.Now.Day & Date.Now.Minute & Date.Now.Second

        conn2.ConnectionString = "server=10.3.11.61;database=ALANSIS;uid=sa;pwd=term.0907;"
        '========================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================
        conn2.Open()
        cmd2.Connection = conn2
        cmd2.CommandText = "INSERT INTO EO_ALANSIS_IHRACAT_SEVKIYAT(DURUM,HAFTA,SEVK_TARIHI,PARTINO,MUSTERI,ULKE,PRODUCT,NETKG,KUTU,KUTU_ICI,SIZE_OF_FRUIT,OFPALET,OFBOX,GROSSKG,NAKLIYECI,PLAKA,SOFOR,YUKLEME_YERI,PAET_TIPI,YUKLEME_SAATI,IRSALIYE) VALUES ( '" & ComboBoxEdit2.Text & "','" & TextEdit2.Text & "','" & TextEdit3.Text & "','" & ComboBoxEdit1.Text & "','" & TextEdit4.Text & "','" & TextEdit5.Text & "','" & TextEdit6.Text & "','" & Replace(net, ",", ".") & "','" & TextEdit8.Text & "','" & TextEdit9.Text & "','" & TextEdit10.Text & "','" & TextEdit11.Text & "','" & TextEdit12.Text & "','" & Replace(gross, ",", ".") & "','" & TextEdit14.Text & "','" & TextEdit15.Text & "','" & TextEdit16.Text & "','" & TextEdit17.Text & "','" & TextEdit18.Text & "','" & TextEdit19.Text & "','" & TextEdit20.Text & "')"
        cmd2.ExecuteNonQuery()
        conn2.Close()
        '============================================================================================================================================================================================================================================================================================================
        Dim connectionString As String = "server=10.3.11.61;database=ALANSIS;uid=sa;pwd=term.0907"
        Dim sql As String = "SELECT* FROM EO_ALANSIS_IHRACAT_SEVKIYAT ORDER BY ID DESC"
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
        '============================================================================================================================================================================================================================================================================================================

        DevExpress.XtraEditors.XtraMessageBox.Show("Kayit İşlemi Tamamlanmiştir...")
        Exit Sub
        Me.Close()
hata:
                DevExpress.XtraEditors.XtraMessageBox.Show("Kayit İşleminde Hata, Lütfen Kontrol Ediniz...")
        Exit Sub
    End Sub

    Private Sub ComboBoxEdit1_EditValueChanged(sender As Object, e As EventArgs) Handles ComboBoxEdit1.EditValueChanged
        On Error Resume Next
        '------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
        SqlConn.Open()
        Dim mySelectQuery1 As String = "SELECT* FROM EO_ALANSIS_RECETE WHERE PARTINO='" & ComboBoxEdit1.Text & "' AND STOK_ADI LIKE '%KUTU%';"
        Dim SqlComm1 As New System.Data.SqlClient.SqlCommand(mySelectQuery1, SqlConn)
        Dim reader1 As System.Data.SqlClient.SqlDataReader
        reader1 = SqlComm1.ExecuteReader()
        While reader1.Read()
            TextEdit8.Text = (reader1("STOK_ADI"))
        End While
        reader1.Close()
        SqlConn.Close()
        SqlConn.Open()
        Dim mySelectQuery2 As String = "SELECT* FROM EO_ALANSIS_RECETE WHERE PARTINO='" & ComboBoxEdit1.Text & "' AND STOK_ADI LIKE '%PALET%';"
        Dim SqlComm2 As New System.Data.SqlClient.SqlCommand(mySelectQuery2, SqlConn)
        Dim reader2 As System.Data.SqlClient.SqlDataReader
        reader2 = SqlComm2.ExecuteReader()
        While reader2.Read()
            TextEdit18.Text = (reader2("STOK_ADI"))
        End While
        reader2.Close()
        SqlConn.Close()
        SqlConn.Open()
        Dim mySelectQuery3 As String = "SELECT* FROM EO_ALANSIS_SATIS WHERE PARTI='" & ComboBoxEdit1.Text & "';"
        Dim SqlComm3 As New System.Data.SqlClient.SqlCommand(mySelectQuery3, SqlConn)
        Dim reader3 As System.Data.SqlClient.SqlDataReader
        reader3 = SqlComm3.ExecuteReader()
        While reader3.Read()
            TextEdit4.Text = (reader3("MUSTERI"))
            TextEdit6.Text = (reader3("URUN"))
        End While
        reader2.Close()
        SqlConn.Close()
        '--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

    End Sub

    Private Sub TextEdit3_EditValueChanged(sender As Object, e As EventArgs) Handles TextEdit3.EditValueChanged
        On Error Resume Next
        Dim WeekNumber As Integer = DatePart(DateInterval.WeekOfYear, Convert.ToDateTime(TextEdit3.Text), FirstDayOfWeek.Monday, FirstWeekOfYear.System)
        TextEdit2.Text = WeekNumber & ".HAFTA"
    End Sub
End Class