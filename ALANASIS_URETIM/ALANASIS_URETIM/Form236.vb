Imports System.Data.SqlClient
Imports System.Data
Imports System.Net.Sockets
Imports System.Net.Mail
Public Class Form236
    Dim SqlConnStr As String = "server=10.3.11.61;database=ALANSIS;uid=sa;pwd=term.0907;"
    Dim SqlConn As New System.Data.SqlClient.SqlConnection(SqlConnStr)
    Dim cmd As New SqlCommand()
    Dim cnn As New SqlConnection()
    Dim da As New SqlDataAdapter()
    Dim ds As New DataSet
    Dim i As Integer
    Dim SMTP As New SmtpClient("smtp.gmail.com")
    Dim Mail As New MailMessage
    Private Sub Form236_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim kontrol, grupkontrol
        grupkontrol = ""
        kontrol = ""
        grupkontrol = Trim(Mid(Form2.BarStaticItem4.Caption, 12, 15))
        DataGridView1.DataSource = ds
        ds.Clear()
        ds.Dispose()
        '=============================================================================================================================================================
        Try
            cnn.ConnectionString = "server=10.3.11.61;database=ALANSIS;uid=sa;pwd=term.0907"
            cnn.Open()
            cmd.Connection = cnn
            cmd.CommandType = CommandType.Text
            cmd.CommandText = "SELECT* FROM EO_ALANSIS_FATONAY WHERE ONAY='NOK'"
            da.SelectCommand = cmd
            DataGridView1.ClearSelection()
            da.Fill(ds)
            DataGridView1.DataSource = ds.Tables(0).DefaultView
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        '=============================================================================================================================================================
        cnn.Close()
        '------------------------------------------------------------------------------
        DataGridView1.AutoResizeColumns(DataGridViewAutoSizeColumnMode.AllCells)
        For i = 0 To DataGridView1.Rows.Count - 1 Step 2
            DataGridView1.Rows(i).DefaultCellStyle.BackColor = Color.LemonChiffon
        Next
        '------------------------------------------------------------------------------
    End Sub
    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        On Error Resume Next
        Dim karar, id, partino, seri, monay, zonay As String
        Dim kontrol, grupkontrol
        grupkontrol = ""
        kontrol = ""
        monay = ""
        zonay = ""
        grupkontrol = Trim(Mid(Form2.BarStaticItem4.Caption, 12, 15))
        Dim conn1 As New SqlConnection
        partino = DataGridView1.CurrentRow.Cells(1).Value.ToString()
        conn1.ConnectionString = "server=10.3.11.61;database=ALANSIS;uid=sa;pwd=term.0907"
        '-----------------------------------------------------------------------------------------
        conn1.Open()
        Dim mySelectQuery1 As String = "SELECT* FROM EO_ALANSIS_FATONAY WHERE ID='" & partino & "';"
        Dim SqlComm1 As New System.Data.SqlClient.SqlCommand(mySelectQuery1, conn1)
        Dim reader1 As System.Data.SqlClient.SqlDataReader
        reader1 = SqlComm1.ExecuteReader()
        While reader1.Read()
            Form234.DateEdit1.Text = reader1("TARIH")
            Form234.TextEdit2.Text = reader1("FATNO")
            Form234.ButtonEdit1.Text = reader1("FATDOSYA")
            Form234.MemoEdit1.Text = reader1("ACIKLAMA")
            'Form234.TextEdit3.Text = reader1("ONAY")
            Form234.ComboBoxEdit1.Visible = True
            Form234.TextEdit3.Visible = False
            Form234.DateEdit2.Text = reader1("ONAY_TARIHI")
        End While
        reader1.Close()
        conn1.Close()
        Form234.DateEdit1.Enabled = False
        Form234.TextEdit2.Enabled = False
        Form234.ButtonEdit1.Enabled = False
        Form234.MemoEdit1.Enabled = False
        Form234.ComboBoxEdit1.Enabled = False
        Form234.TextEdit3.Visible = False
        Form234.DateEdit2.Enabled = False
        Form234.MdiParent = Form2
        Form234.Show()

    End Sub
End Class