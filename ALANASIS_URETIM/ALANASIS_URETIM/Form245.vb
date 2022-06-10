Imports System.Data.SqlClient
Imports System.Data
Imports System.Net.Sockets
Imports System.Net.Mail
Public Class Form245
    Dim SqlConnStr As String = "server=10.3.11.61;database=ALANSIS;uid=sa;pwd=term.0907;"
    Dim SqlConn As New System.Data.SqlClient.SqlConnection(SqlConnStr)
    Dim cmd As New SqlCommand()
    Dim cnn As New SqlConnection()
    Dim da As New SqlDataAdapter()
    Dim ds As New DataSet
    Dim i As Integer
    Dim SMTP As New SmtpClient("smtp.gmail.com")
    Dim Mail As New MailMessage
    Private Sub Form245_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ''TODO: Bu kod satırı 'ALANSISDataSet59.EO_ALANSIS_ISGUCU_PLANLAMA_ISLER' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
        'Me.EO_ALANSIS_ISGUCU_PLANLAMA_ISLERTableAdapter.Fill(Me.ALANSISDataSet59.EO_ALANSIS_ISGUCU_PLANLAMA_ISLER)

        On Error Resume Next
        Dim conn1 As New SqlConnection
        Dim cmd1 As New SqlCommand
        Dim cmd2 As New SqlCommand
        Dim da As New SqlDataAdapter()
        Dim ds As New DataSet
        Dim id As String
        id = ""
        '---------------------------------------------------------------------------------------------------------------
        conn1.ConnectionString = "server=10.3.11.61;database=ALANSIS;uid=sa;pwd=term.0907"
        conn1.Open()
        cmd2.Connection = conn1
        cmd2.CommandType = CommandType.Text
        cmd2.CommandText = "SELECT ID,TARIH,BOLUM,VARDIYA,VARDIYA_AMIRI,VARDIYA_AMIR_YARDIMCISI,ETIKET_SEVKIYAT_SORUMLUSU,KISIM,YAPILACAK_IS,DAIMI_KADRO,KADIN,ERKEK FROM EO_ALANSIS_ISGUCU_PLANLAMA WHERE TARIH=convert(varchar, getdate(), 104) ORDER BY ID DESC"
        da.SelectCommand = cmd2
        da.Fill(ds)
        GridControl1.DataSource = ds.Tables(0).DefaultView
        conn1.Close()

    End Sub

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        Dim conn1 As New SqlConnection
        Dim cmd1 As New SqlCommand
        Dim cmd2 As New SqlCommand
        Dim da As New SqlDataAdapter()
        Dim ds As New DataSet
        Dim id As String
        id = ""
        '---------------------------------------------------------------------------------------------------------------
        conn1.ConnectionString = "server=10.3.11.61;database=ALANSIS;uid=sa;pwd=term.0907"
        conn1.Open()
        cmd1.Connection = conn1
        cmd1.CommandText = "INSERT INTO EO_ALANSIS_ISGUCU_PLANLAMA (TARIH,BOLUM,VARDIYA,VARDIYA_AMIRI,VARDIYA_AMIR_YARDIMCISI,ETIKET_SEVKIYAT_SORUMLUSU,KISIM,YAPILACAK_IS,DAIMI_KADRO,KADIN,ERKEK) VALUES ('" & DateEdit1.Text & "','" & ComboBoxEdit1.Text & "','" & ComboBoxEdit2.Text & "','" & TextEdit1.Text & "','" & TextEdit2.Text & "','" & TextEdit3.Text & "','" & ComboBoxEdit3.Text & "','" & ComboBoxEdit4.Text & "','" & TextEdit4.Text & "','" & TextEdit5.Text & "','" & TextEdit6.Text & "')"
        cmd1.ExecuteNonQuery()
        conn1.Close()
        '---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
        'Me.Hide()
        DevExpress.XtraEditors.XtraMessageBox.Show("Kayit İşlemi Tamamlanmiştir...")
        '--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
        SqlConn.Open()
        Dim mySelectQuery11 As String = "SELECT SUM(DAIMI_KADRO) AS TDAIMI,SUM(KADIN) AS TKADIN,SUM(ERKEK) AS TERKEK FROM EO_ALANSIS_ISGUCU_PLANLAMA WHERE TARIH=convert(varchar, getdate(), 104)"
        Dim SqlComm11 As New System.Data.SqlClient.SqlCommand(mySelectQuery11, SqlConn)
        Dim reader11 As System.Data.SqlClient.SqlDataReader
        reader11 = SqlComm11.ExecuteReader()
        While reader11.Read()
            TextEdit9.Text = reader11("TDAIMI")

            TextEdit8.Text = reader11("TERKEK")
            TextEdit7.Text = reader11("TKADIN")
        End While
        reader11.Close()
        SqlConn.Close()
        '==========================================================================================================================================
        conn1.Open()
        cmd2.Connection = conn1
        cmd2.CommandType = CommandType.Text
        cmd2.CommandText = "SELECT ID,TARIH,BOLUM,VARDIYA,VARDIYA_AMIRI,VARDIYA_AMIR_YARDIMCISI,ETIKET_SEVKIYAT_SORUMLUSU,KISIM,YAPILACAK_IS,DAIMI_KADRO,KADIN,ERKEK FROM EO_ALANSIS_ISGUCU_PLANLAMA WHERE TARIH=convert(varchar, getdate(), 104) ORDER BY ID DESC"
        da.SelectCommand = cmd2
        da.Fill(ds)
        GridControl1.DataSource = ds.Tables(0).DefaultView
        conn1.Close()

    End Sub
    Private Sub GridControl1_Click(sender As Object, e As EventArgs) Handles GridControl1.Click
        TextEdit10.Text = GridView1.GetFocusedRowCellValue("ID").ToString()
    End Sub

    Private Sub SimpleButton2_Click(sender As Object, e As EventArgs) Handles SimpleButton2.Click
        On Error Resume Next
        Dim conn1 As New SqlConnection
        Dim cmd1 As New SqlCommand
        Dim cmd2 As New SqlCommand
        Dim da As New SqlDataAdapter()
        Dim ds As New DataSet
        Dim id As String
        id = ""
        '---------------------------------------------------------------------------------------------------------------
        conn1.ConnectionString = "server=10.3.11.61;database=ALANSIS;uid=sa;pwd=term.0907"
        conn1.Open()
        cmd1.Connection = conn1
        cmd1.CommandText = "DELETE FROM EO_ALANSIS_ISGUCU_PLANLAMA WHERE ID='" & TextEdit10.Text & "'"
        cmd1.ExecuteNonQuery()
        conn1.Close()
        '---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
        'Me.Hide()
        DevExpress.XtraEditors.XtraMessageBox.Show("Silme İşlemi Tamamlanmiştir...")
        '--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
        SqlConn.Open()
        Dim mySelectQuery11 As String = "SELECT SUM(DAIMI_KADRO) AS TDAIMI,SUM(KADIN) AS TKADIN,SUM(ERKEK) AS TERKEK FROM EO_ALANSIS_ISGUCU_PLANLAMA WHERE TARIH=convert(varchar, getdate(), 104)"
        Dim SqlComm11 As New System.Data.SqlClient.SqlCommand(mySelectQuery11, SqlConn)
        Dim reader11 As System.Data.SqlClient.SqlDataReader
        reader11 = SqlComm11.ExecuteReader()
        While reader11.Read()
            TextEdit9.Text = reader11("TDAIMI")

            TextEdit8.Text = reader11("TERKEK")
            TextEdit7.Text = reader11("TKADIN")
        End While
        reader11.Close()
        SqlConn.Close()
        '==========================================================================================================================================
        conn1.Open()
        cmd2.Connection = conn1
        cmd2.CommandType = CommandType.Text
        cmd2.CommandText = "SELECT ID,TARIH,BOLUM,VARDIYA,VARDIYA_AMIRI,VARDIYA_AMIR_YARDIMCISI,ETIKET_SEVKIYAT_SORUMLUSU,KISIM,YAPILACAK_IS,DAIMI_KADRO,KADIN,ERKEK FROM EO_ALANSIS_ISGUCU_PLANLAMA WHERE TARIH=convert(varchar, getdate(), 104) ORDER BY ID DESC"
        da.SelectCommand = cmd2
        da.Fill(ds)
        GridControl1.DataSource = ds.Tables(0).DefaultView
        conn1.Close()

    End Sub

    Private Sub GroupControl1_Paint(sender As Object, e As PaintEventArgs) Handles GroupControl1.Paint

    End Sub
End Class