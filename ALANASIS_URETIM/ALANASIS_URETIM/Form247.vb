Imports System.Data.SqlClient
Imports DevExpress.Compatibility
Imports DevExpress.Data
Imports DevExpress.XtraGrid.Columns
Imports System.Data
Imports System.Net.Sockets
Imports System.Net.Mail
Imports DevExpress.XtraEditors.Controls
Public Class Form247
    Dim SqlConnStr As String = "server=10.3.11.61;database=ALANSIS;uid=sa;pwd=term.0907;"
    Dim SqlConn As New System.Data.SqlClient.SqlConnection(SqlConnStr)
    Dim cmd As New SqlCommand()
    Dim cnn As New SqlConnection()
    Dim da As New SqlDataAdapter()
    Dim ds As New DataSet
    Dim SMTP As New SmtpClient("smtp.gmail.com")
    Dim Mail As New MailMessage
    Private Sub Form247_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Dim connectionString As String = "server=10.3.11.61;database=ALANSIS;uid=sa;pwd=term.0907"
            Dim sql As String = "SELECT * FROM EO_ALANSIS_KIRAZ2KALITE"
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
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        '=============================================================================================================================================================
        GridView1.OptionsSelection.MultiSelect = True
        GridView1.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect
    End Sub
    Private Sub GridControl1_KeyDown(sender As Object, e As KeyEventArgs) Handles GridControl1.KeyDown
        Dim listkontrol As Integer
        listkontrol = 0
        ListBox1.Items.Clear()
        ListBox2.Items.Clear()
        ListBox3.Items.Clear()
        If (e.KeyCode = Keys.Tab) Then
            Dim ret As String = ""
            For Each i As Integer In GridView1.GetSelectedRows()
                Dim row As DataRow = GridView1.GetDataRow(i)
                If ret <> "" Then
                    ret &= ControlChars.CrLf
                End If
                '========================================================================================================
                ListBox1.Items.Add(row("NET"))
                ListBox2.Items.Add(row("DARA"))
                ListBox3.Items.Add(row("BRUT"))
                ListBox4.Items.Add(row("ID"))
                ListBox5.Items.Add(row("PARTINO"))
            Next i
        End If
        TextEdit4.Text = 0
        TextEdit5.Text = 0
        TextEdit6.Text = 0
        listkontrol = ListBox1.Items.Count
        If listkontrol > 0 Then
            For i As Integer = 0 To ListBox1.Items.Count - 1 And ListBox2.Items.Count - 1 And ListBox3.Items.Count - 1
                TextEdit4.Text = CDec(TextEdit4.Text) + ListBox1.Items(i)
                TextEdit5.Text = CDec(TextEdit5.Text) + ListBox2.Items(i)
                TextEdit6.Text = CDec(TextEdit6.Text) + ListBox3.Items(i)
            Next
        End If
        TextEdit1.Text = TextEdit4.Text
        TextEdit2.Text = TextEdit5.Text
        TextEdit3.Text = TextEdit6.Text
    End Sub

    Private Sub GridControl1_Click(sender As Object, e As EventArgs) Handles GridControl1.Click

    End Sub

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        '        On Error GoTo hata
        '        Dim conn1 As New SqlConnection
        '        Dim cmd1 As New SqlCommand
        '        Dim cmd2, cmd3 As New SqlCommand
        '        Dim sid As String
        '        sid =

        '        Dim listkontrol As Integer

        '        listkontrol = 0
        '        listkontrol = ListBox1.Items.Count
        '        If listkontrol > 0 Then
        '            For i As Integer = 0 To ListBox1.Items.Count - 1 And ListBox2.Items.Count - 1 And ListBox3.Items.Count - 1 And ListBox4.Items.Count - 1 And ListBox5.Items.Count - 1
        '                TextEdit7.Text = ListBox4.Items(i)
        '                TextEdit8.Text = ListBox5.Items(i)
        '                '---------------------------------------------------------------------------------------------------------------
        '                conn1.ConnectionString = "server=10.3.11.61;database=ALANSIS;uid=sa;pwd=term.0907"
        '                conn1.Open()
        '                cmd1.Connection = conn1
        '                cmd1.CommandText = "UPDATE EO_ALANSIS_KIRAZ2KALITE SET SEVK_ONAY='ONAYA_GONDERILDI',SEVKID='' WHERE ID='" & TextEdit1.Text & "'"
        '                cmd1.ExecuteNonQuery()
        '                conn1.Close()
        '                '---------------------------------------------------------------------------------------------------------------
        '            Next

        '            '--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
        '            SMTP.Timeout = 5
        '            SMTP.EnableSsl = True
        '            SMTP.Credentials = New System.Net.NetworkCredential("alansis.bilgi@gmail.com", "alanar.2021")
        '            SMTP.Port = "587"
        '            Mail.Subject = "Parti No: " & TextEdit1.Text & " Satış İptali"
        '            Mail.To.Add("ercanozyanar@gmail.com") ',saadet.atalay@alanar.com.tr,umut.yenmis@alanar.com.tr,ibrahim.erturk@alanar.com.tr,ridvan.akman@alanar.com.tr")
        '            'Mail.To.Add("yigit.gokyigit@alanar.com.tr,tahir.gunsen@alanar.com.tr,tugba.okyay@alanar.com.tr,bakit.akmatov@alanar.com.tr,fatih.bakici@alanar.com.tr,canan.bulut@alanar.com.tr,kalite.saha@alanar.com.tr,uretim.saha@alanar.com.tr,atakan.cetinbilek@alanar.com.tr,beykan.esgicioglu@alanar.com.tr,gulbahar.arikan@alanar.com.tr,esra.kundakci@alanar.com.tr,ercanozyanar@gmail.com,ridvan.akman@alanar.com.tr")
        '            Mail.From = New MailAddress("alansis.bilgi@gmail.com")
        '            Mail.IsBodyHtml = True
        '            Mail.Body = "<p><span>Parti No:" & TextEdit1.Text & " Satış İptal Onay işlemi " & DateTime.Now & " zamanında " & user & " tarafından onaylanmak üzere iletilmiştir.....</span></p><p><strong>Onay Vermek icin lutfen aşağıdaki butonu tıklayınız...</strong></p> <p><strong>&nbsp;<span class= 'redButton' >▼ <a href=http://10.3.11.61/ALANSIS_WB/IPTALOnay/IPTALOnay/" + id & " > ONAYLA</a></span></strong></p>"
        '            SMTP.Send(Mail)
        '            DevExpress.XtraEditors.XtraMessageBox.Show("Onay İptal İşlemi Tamamlanmiştir...")
        '            Me.Hide()
        '            Exit Sub
        '        End If
        '        --------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------





        '                DevExpress.XtraEditors.XtraMessageBox.Show("Kayit İşlemi Tamamlanmiştir...")
        '        Exit Sub
        '        Me.Close()
        '        Else
        '        DevExpress.XtraEditors.XtraMessageBox.Show("Lütfen Kayıt Seçiniz...")
        '        End If
        'hata:
        '        DevExpress.XtraEditors.XtraMessageBox.Show("Kayit İşleminde hata, Lütfen kontrol ediniz......")
        '        Exit Sub
    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub
End Class