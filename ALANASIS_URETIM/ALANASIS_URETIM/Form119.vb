Imports System.Data.SqlClient
Imports System.Xml
Imports System.Data
Imports System.Net.Sockets
Imports System.IO
Imports System.Text
Imports System.Threading
Imports System.Net
Imports System.Net.Mail
Public Class Form119
    Dim SqlConnStr1 As String = "server=10.3.11.61;database=ALANSIS;uid=sa;pwd=term.0907;"
    Dim SqlConn1 As New System.Data.SqlClient.SqlConnection(SqlConnStr1)
    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        On Error GoTo hata
        Dim conn1 As New SqlConnection
        Dim cmd1, cmd2 As New SqlCommand
        Dim da As New SqlDataAdapter()
        Dim ds As New DataSet

        conn1.ConnectionString = "server=10.3.11.61;database=ALANSIS;uid=sa;pwd=term.0907;"
        '--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
        conn1.Open()
        cmd1.Connection = conn1
        cmd1.CommandText = "INSERT INTO EO_ALANSIS_SEVKIYAT(DURUM,CUSTOMER,POS_NO,REFERANCE,PRODUCT,DELIVERY_COUNTRY,CARRIER,TRUCK_PLAKA,LOAD_,LOAD_DATE,ETA,CUSTOMS,DELIVERY_ADRESS,CURRENT_LOCATION,EXTRA_KM,FREIGHT,EXTRA_FREIGHT,NET_WEIGHT,DELIVERY_DATE,ARRIVAL_DATE,PLANNED_LOAD_DATE,DIFFERANCE_LOAD,PLANNED_DELIVERY_DATE,DIFFERENCE_DELIVERY,TRANSIT_TIME,GUMRUKLEME_ADRESI,ACIKLAMA) VALUES  ('" & ComboBoxEdit2.Text & "','" & TextEdit1.Text & "','" & ComboBoxEdit1.Text & "','" & TextEdit2.Text & "','" & TextEdit3.Text & "','" & TextEdit4.Text & "','" & TextEdit5.Text & "','" & TextEdit6.Text & "','" & TextEdit7.Text & "','" & DateTimeOffsetEdit1.Text & "','" & DateTimeOffsetEdit2.Text & "','" & TextEdit8.Text & "','" & TextEdit9.Text & "','" & TextEdit10.Text & "','" & Replace(TextEdit11.Text, ",", ".") & "','" & Replace(TextEdit12.Text, ",", ".") & "','" & Replace(TextEdit13.Text, ",", ".") & "','" & Replace(TextEdit14.Text, ",", ".") & "','" & DateTimeOffsetEdit3.Text & "','" & DateTimeOffsetEdit4.Text & "','" & DateTimeOffsetEdit5.Text & "','" & TextEdit18.Text & "','" & DateTimeOffsetEdit6.Text & "','" & TextEdit15.Text & "','" & TextEdit16.Text & "','" & TextEdit17.Text & "','" & TextEdit19.Text & "');"
        cmd1.ExecuteNonQuery()
        conn1.Close()
        '---------------------------------------------------------------------------------------------
        conn1.Open()
        cmd2.Connection = conn1
        cmd2.CommandType = CommandType.Text
        cmd2.CommandText = "SELECT* FROM EO_ALANSIS_SEVKIYAT ORDER BY ID DESC"
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

    Private Sub Form119_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: Bu kod satırı 'ALANSISDataSet1.EO_ALANSIS_SATIS' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
        Me.EO_ALANSIS_SATISTableAdapter.Fill(Me.ALANSISDataSet1.EO_ALANSIS_SATIS)

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
            TextEdit2.Text = reader1("MUSTERI_REFERANS").ToString()
            TextEdit3.Text = reader1("STOK_ADI").ToString()
            TextEdit2.Text = reader1("MUSTERI_REFERANS").ToString()
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
        cmd1.CommandText = "Delete From EO_ALANSIS_SEVKIYAT Where PARTI='" & silid & "'"
        cmd1.ExecuteNonQuery()
        '--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
        conn1.Close()
        '---------------------------------------------------------------------------------------------------
        DevExpress.XtraEditors.XtraMessageBox.Show("Kayıt Silinmiştir...")
        '---------------------------------------------------------------------------------------------------
        conn1.Open()
        cmd2.Connection = conn1
        cmd2.CommandType = CommandType.Text
        cmd2.CommandText = "SELECT* FROM EO_ALANSIS_SEVKIYAT ORDER BY ID DESC"
        da.SelectCommand = cmd2
        da.Fill(ds)
        DataGridView1.DataSource = ds.Tables(0).DefaultView
        conn1.Close()
        Exit Sub
    End Sub

    Private Sub SimpleButton3_Click(sender As Object, e As EventArgs) Handles SimpleButton3.Click
        Form120.Show()
    End Sub

    Private Sub SimpleButton4_Click(sender As Object, e As EventArgs) Handles SimpleButton4.Click
        Form121.Show()
    End Sub

    Private Sub DateTimeOffsetEdit5_EditValueChanged(sender As Object, e As EventArgs) Handles DateTimeOffsetEdit5.EditValueChanged
        On Error Resume Next
        Dim date1, date2 As Date
        Dim days As Long
        date1 = DateTimeOffsetEdit5.Text
        date2 = DateTimeOffsetEdit1.Text
        TextEdit18.Text = DateDiff(DateInterval.Day, date1, date2)
    End Sub

    Private Sub DateTimeOffsetEdit6_EditValueChanged(sender As Object, e As EventArgs) Handles DateTimeOffsetEdit6.EditValueChanged
        On Error Resume Next
        Dim date1, date2 As Date
        Dim days As Long
        date1 = DateTimeOffsetEdit6.Text
        date2 = DateTimeOffsetEdit3.Text
        TextEdit15.Text = DateDiff(DateInterval.Day, date1, date2)
    End Sub

    Private Sub DateTimeOffsetEdit4_EditValueChanged(sender As Object, e As EventArgs) Handles DateTimeOffsetEdit4.EditValueChanged
        On Error Resume Next
        Dim date1, date2 As Date
        Dim days As Long
        date1 = DateTimeOffsetEdit4.Text
        date2 = DateTimeOffsetEdit1.Text
        TextEdit16.Text = DateDiff(DateInterval.Day, date1, date2)
    End Sub

    Private Sub SimpleButton6_Click(sender As Object, e As EventArgs) Handles SimpleButton6.Click
        Form126.Show()
    End Sub
End Class