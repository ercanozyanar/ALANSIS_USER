Imports System.Data.SqlClient
Imports System.Xml
Imports System.Data
Imports System.Net.Sockets
Imports System.IO
Imports System.Text
Imports System.Threading
Imports System.Net
Imports System.Net.Mail
Public Class Form127
    Dim SqlConnStr1 As String = "server=10.3.11.61;database=ALANSIS;uid=sa;pwd=term.0907;"
    Dim SqlConn1 As New System.Data.SqlClient.SqlConnection(SqlConnStr1)
    Private Sub SimpleButton3_Click(sender As Object, e As EventArgs) Handles SimpleButton3.Click
        Form128.Show()
    End Sub
    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        On Error GoTo hata
        Dim conn1 As New SqlConnection
        Dim cmd1, cmd2 As New SqlCommand
        Dim da As New SqlDataAdapter()
        Dim ds As New DataSet
        Dim navlun As Decimal
        If ComboBoxEdit3.Text = "" Then
            navlun = 0
        Else
            navlun = ComboBoxEdit3.Text
        End If

        conn1.ConnectionString = "server=10.3.11.61;database=ALANSIS;uid=sa;pwd=term.0907;"
        '--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
        conn1.Open()
        cmd1.Connection = conn1
        cmd1.CommandText = "INSERT INTO EO_ALANSIS_SEVKIYATHAVA(MUSTERI,PARTINO,URUN,PALET_SAYISI,CIKIS_HAVAALANI,ANTREDEPO,TESIS_CIKIS_TARIHI,CUT_OFF,VARIS_HAVAALANI,VARIS_ULKE,ETD,ETA_LTZ,ETA_TTZ,PICKUP_DATE,FORWARDER,TASIYICI_FIRMA,TESLIM_DURUMU,AWB_NO,NET_KILO,CHARGABLE_WEIGHT,PHYTO_NO,NAVLUN,TOPLAM_MALIYET) VALUES  ('" & TextEdit1.Text & "','" & ComboBoxEdit2.Text & "','" & TextEdit2.Text & "','" & TextEdit3.Text & "','" & TextEdit4.Text & "','" & TextEdit5.Text & "','" & DateEdit1.Text & "','" & DateTimeOffsetEdit1.Text & "','" & TextEdit6.Text & "','" & TextEdit7.Text & "','" & DateTimeOffsetEdit2.Text & "','" & DateTimeOffsetEdit3.Text & "','" & DateTimeOffsetEdit4.Text & "','" & DateEdit2.Text & "','" & TextEdit8.Text & "','" & TextEdit9.Text & "','" & ComboBoxEdit2.Text & "','" & TextEdit10.Text & "','" & Replace(TextEdit11.Text, ",", ".") & "','" & Replace(TextEdit12.Text, ",", ".") & "','" & TextEdit13.Text & "','" & Replace(navlun, ",", ".") & "','" & Replace(TextEdit14.Text, ",", ".") & "');"
        cmd1.ExecuteNonQuery()
        conn1.Close()
        '---------------------------------------------------------------------------------------------
        conn1.Open()
        cmd2.Connection = conn1
        cmd2.CommandType = CommandType.Text
        cmd2.CommandText = "SELECT* FROM EO_ALANSIS_SEVKIYATHAVA ORDER BY ID DESC"
        da.SelectCommand = cmd2
        da.Fill(ds)
        DataGridView1.DataSource = ds.Tables(0).DefaultView
        conn1.Close()
        DataGridView1.AutoResizeColumns(DataGridViewAutoSizeColumnMode.AllCells)
        For i = 0 To DataGridView1.Rows.Count - 1 Step 2
            DataGridView1.Rows(i).DefaultCellStyle.BackColor = Color.LemonChiffon
        Next
        DevExpress.XtraEditors.XtraMessageBox.Show("İşlem Tamam")

        Exit Sub
hata:
        DevExpress.XtraEditors.XtraMessageBox.Show("Kayit İşleminde Hata, Lütfen Kontrol Ediniz...")
        Exit Sub
    End Sub
    Private Sub Form127_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: Bu kod satırı 'ALANSISDataSet11.EO_ALANSIS_SEVKIYATHAVANAVLUN' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
        Me.EO_ALANSIS_SEVKIYATHAVANAVLUNTableAdapter.Fill(Me.ALANSISDataSet11.EO_ALANSIS_SEVKIYATHAVANAVLUN)
        'TODO: Bu kod satırı 'ALANSISDataSet1.EO_ALANSIS_SATIS' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
        Me.EO_ALANSIS_SATISTableAdapter.Fill(Me.ALANSISDataSet1.EO_ALANSIS_SATIS)
        TextEdit3.Text = 0
        TextEdit11.Text = 0
        TextEdit12.Text = 0
        TextEdit14.Text = 0
    End Sub

    Private Sub ComboBoxEdit1_EditValueChanged(sender As Object, e As EventArgs) Handles ComboBoxEdit1.EditValueChanged
        On Error Resume Next
        '---------------------------------------------------------------------------------------------------------------------
        SqlConn1.Open()
        Dim mySelectQuery1 As String = "SELECT* FROM EO_ALANSIS_SATIS WHERE PARTI='" & ComboBoxEdit1.Text & "';"
        Dim SqlComm1 As New System.Data.SqlClient.SqlCommand(mySelectQuery1, SqlConn1)
        Dim reader1 As System.Data.SqlClient.SqlDataReader
        reader1 = SqlComm1.ExecuteReader()
        While reader1.Read()
            TextEdit1.Text = reader1("MUSTERI").ToString()
            TextEdit2.Text = reader1("STOK_ADI").ToString()
        End While
        reader1.Close()
        SqlConn1.Close()
        '========================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================================
    End Sub
    Private Sub SimpleButton2_Click(sender As Object, e As EventArgs) Handles SimpleButton2.Click
        On Error Resume Next
        Dim conn1 As New SqlConnection
        Dim cmd1 As New SqlCommand
        Dim cmd2 As New SqlCommand
        Dim da As New SqlDataAdapter()
        Dim ds As New DataSet
        Dim silid
        silid = ""
        silid = DataGridView1.CurrentRow.Cells(0).Value.ToString
        '---------------------------------------------------------------------------------------------------------------
        conn1.ConnectionString = "server=10.3.11.61;database=ALANSIS;uid=sa;pwd=term.0907"
        conn1.Open()
        cmd1.Connection = conn1
        cmd1.CommandText = "Delete From EO_ALANSIS_SEVKIYATHAVA Where ID='" & silid & "'"
        cmd1.ExecuteNonQuery()
        '--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
        conn1.Close()
        '---------------------------------------------------------------------------------------------------
        DevExpress.XtraEditors.XtraMessageBox.Show("Kayıt Silinmiştir...")
        '---------------------------------------------------------------------------------------------------
        conn1.Open()
        cmd2.Connection = conn1
        cmd2.CommandType = CommandType.Text
        cmd2.CommandText = "SELECT* FROM EO_ALANSIS_SEVKIYATHAVA ORDER BY ID DESC"
        da.SelectCommand = cmd2
        da.Fill(ds)
        DataGridView1.DataSource = ds.Tables(0).DefaultView
        conn1.Close()
        '______________________________________________________________________________________________________________________________
        Exit Sub
    End Sub
End Class