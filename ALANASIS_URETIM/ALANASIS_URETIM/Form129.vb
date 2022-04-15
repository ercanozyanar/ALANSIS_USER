Imports System.Data.SqlClient
Imports System.Xml
Imports System.Data
Imports System.Net.Sockets
Imports System.IO
Imports System.Text
Imports System.Threading
Imports System.Net
Imports System.Net.Mail
Public Class Form129
    Dim SqlConnStr1 As String = "server=10.3.11.61;database=ALANSIS;uid=sa;pwd=term.0907;"
    Dim SqlConn1 As New System.Data.SqlClient.SqlConnection(SqlConnStr1)
    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        On Error GoTo hata
        Dim conn1 As New SqlConnection
        Dim cmd1, cmd2 As New SqlCommand
        Dim da As New SqlDataAdapter()
        Dim ds As New DataSet
        Dim navlun As Decimal
        Dim t1, t2, t3 As String
        t1 = Mid(DateEdit1.Text, 7, 4) + "-" + Mid(DateEdit1.Text, 4, 2) + "-" + Mid(DateEdit1.Text, 1, 2)
        t2 = Mid(DateEdit2.Text, 7, 4) + "-" + Mid(DateEdit2.Text, 4, 2) + "-" + Mid(DateEdit2.Text, 1, 2)
        t3 = Mid(DateEdit3.Text, 7, 4) + "-" + Mid(DateEdit3.Text, 4, 2) + "-" + Mid(DateEdit3.Text, 1, 2)

        If ComboBoxEdit5.Text = "" Then
            navlun = 0
        Else
            navlun = ComboBoxEdit5.Text
        End If

        conn1.ConnectionString = "server=10.3.11.61;database=ALANSIS;uid=sa;pwd=term.0907;"
        '--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
        conn1.Open()
        cmd1.Connection = conn1
        cmd1.CommandText = "INSERT INTO EO_ALANSIS_SEVKIYATDENIZ(CUSTOMER,PARTY_NO,PRODUCT,LOAD_DATE,ETD,PORT_OF_LOADING,ARRIVEL_PORT,ETA,CARRIER,TESLIM_DURUMU,DOCUMENTS,CONTAINER_NO,SEAL_NO,VESSEL_NAME,SIZE,NUMBER_OF_BOXES,NAVLUN,NETKG,TESLIM_DURUMU2) VALUES  ('" & TextEdit1.Text & "','" & ComboBoxEdit1.Text & "','" & TextEdit2.Text & "','" & t1 & "','" & t2 & "','" & TextEdit3.Text & "','" & TextEdit4.Text & "','" & t3 & "','" & TextEdit5.Text & "','" & ComboBoxEdit2.Text & "','" & ComboBoxEdit3.Text & "','" & TextEdit6.Text & "','" & TextEdit7.Text & "','" & TextEdit8.Text & "','" & TextEdit9.Text & "','" & TextEdit10.Text & "','" & Replace(navlun, ",", ".") & "','" & Replace(TextEdit11.Text, ",", ".") & "','" & ComboBoxEdit4.Text & "');"
        cmd1.ExecuteNonQuery()
        conn1.Close()
        '---------------------------------------------------------------------------------------------
        conn1.Open()
        cmd2.Connection = conn1
        cmd2.CommandType = CommandType.Text
        cmd2.CommandText = "SELECT* FROM EO_ALANSIS_SEVKIYATDENIZ ORDER BY ID DESC"
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

    Private Sub Form129_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        On Error Resume Next
        'TODO: Bu kod satırı 'ALANSISDataSet12.EO_ALANSIS_SEVKIYATDENIZNAVLUN' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
        Me.EO_ALANSIS_SEVKIYATDENIZNAVLUNTableAdapter.Fill(Me.ALANSISDataSet12.EO_ALANSIS_SEVKIYATDENIZNAVLUN)
        'TODO: Bu kod satırı 'ALANSISDataSet1.EO_ALANSIS_SATIS' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
        Me.EO_ALANSIS_SATISTableAdapter.Fill(Me.ALANSISDataSet1.EO_ALANSIS_SATIS)

        Dim conn1 As New SqlConnection
        Dim cmd1, cmd2 As New SqlCommand
        Dim da As New SqlDataAdapter()
        Dim ds As New DataSet
        DateEdit1.Text = Date.Today
        DateEdit2.Text = Date.Today
        DateEdit3.Text = Date.Today
        TextEdit10.Text = 0
        ComboBoxEdit5.Text = 0
        TextEdit11.Text = 0
        conn1.ConnectionString = "server=10.3.11.61;database=ALANSIS;uid=sa;pwd=term.0907;"
        conn1.Open()
        cmd2.Connection = conn1
        cmd2.CommandType = CommandType.Text
        cmd2.CommandText = "SELECT* FROM EO_ALANSIS_SEVKIYATDENIZ ORDER BY ID DESC"
        da.SelectCommand = cmd2
        da.Fill(ds)
        DataGridView1.DataSource = ds.Tables(0).DefaultView
        conn1.Close()
        DataGridView1.AutoResizeColumns(DataGridViewAutoSizeColumnMode.AllCells)
        For i = 0 To DataGridView1.Rows.Count - 1 Step 2
            DataGridView1.Rows(i).DefaultCellStyle.BackColor = Color.LemonChiffon
        Next

    End Sub

    Private Sub SimpleButton3_Click(sender As Object, e As EventArgs) Handles SimpleButton3.Click
        Form130.Show()
    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

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
        cmd1.CommandText = "Delete From EO_ALANSIS_SEVKIYATDENIZ Where ID='" & silid & "'"
        cmd1.ExecuteNonQuery()
        '--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
        conn1.Close()
        '---------------------------------------------------------------------------------------------------
        DevExpress.XtraEditors.XtraMessageBox.Show("Kayıt Silinmiştir...")
        '---------------------------------------------------------------------------------------------------
        conn1.Open()
        cmd2.Connection = conn1
        cmd2.CommandType = CommandType.Text
        cmd2.CommandText = "SELECT* FROM EO_ALANSIS_SEVKIYATDENIZ ORDER BY ID DESC"
        da.SelectCommand = cmd2
        da.Fill(ds)
        DataGridView1.DataSource = ds.Tables(0).DefaultView
        conn1.Close()
        Exit Sub
    End Sub
End Class