Imports System.Data.SqlClient
Imports DevExpress.Compatibility
Imports DevExpress.Data
Imports DevExpress.XtraGrid.Columns
Imports DevExpress.XtraGrid.Views.Base
Imports System.Data
Imports System.Net.Sockets
Imports System.Net.Mail

Public Class Form149
    Dim SqlConnStr As String = "server=10.3.11.61;database=ALANSIS;uid=sa;pwd=term.0907;"
    Dim SqlConn As New System.Data.SqlClient.SqlConnection(SqlConnStr)
    Dim cmd As New SqlCommand()
    Dim cnn As New SqlConnection()
    Dim da As New SqlDataAdapter()
    Dim ds As New DataSet
    Dim SMTP As New SmtpClient("smtp.gmail.com")
    Dim Mail As New MailMessage
    Sub New()
        InitializeComponent()
        EO_ALANSIS_GGNTableAdapter4.Fill(AlansısDataSet181.EO_ALANSIS_GGN)
    End Sub
    Private Sub Form149_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.EO_ALANSIS_GGNTableAdapter1.Fill(Me.ALANSISDataSet14.EO_ALANSIS_GGN)
        Me.EO_ALANSIS_GGNTableAdapter1.Fill(Me.ALANSISDataSet14.EO_ALANSIS_GGN)
        Me.EO_ALANSIS_GGNTableAdapter1.Fill(Me.ALANSISDataSet14.EO_ALANSIS_GGN)
        GridView1.OptionsSelection.MultiSelect = True
        GridView1.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect
    End Sub
    Private Sub GridControl1_KeyDown(sender As Object, e As KeyEventArgs) Handles GridControl1.KeyDown
        On Error Resume Next
        Dim conn1 As New SqlConnection
        Dim partikapasite, plankontrol, tuketimkapasite, ggnkapasite As Decimal
        Dim kontrol
        ListBox1.Items.Clear()
        ListBox2.Items.Clear()
        ''------------------------------------------------------------------------------------------------------------------------------
        conn1.ConnectionString = "server=10.3.11.61;database=ALANSIS;uid=sa;pwd=term.0907"
        ''-----------------------------------------------------------------------------------------
        If (e.KeyCode = Keys.Tab) Then
            Dim toplam As Decimal
            '    toplam = 0
            Dim ret As String = ""
            For Each i As Integer In GridView1.GetSelectedRows()
                Dim row As DataRow = GridView1.GetDataRow(i)
                If ret <> "" Then
                    ret &= ControlChars.CrLf
                End If
                'kontrol = row("GGN_NO")
                'partikapasite = 0
                'tuketimkapasite = 0
                'ggnkapasite = 0
                '---------------------------------------------------------------------------------------------------
                'conn1.Open()
                'Dim mySelectQuery2 As String = "SELECT* FROM EO_ALANSIS_GGN WHERE GGN_NO='" & kontrol & "';"
                'Dim SqlComm2 As New System.Data.SqlClient.SqlCommand(mySelectQuery2, conn1)
                'Dim reader2 As System.Data.SqlClient.SqlDataReader
                'reader2 = SqlComm2.ExecuteReader()
                'While reader2.Read()
                ' ggnkapasite = reader2("KAPASITE")
                ' tuketimkapasite = reader2("TUKETIM_KAPASITE")
                'End While
                'reader2.Close()
                'conn1.Close()
                '---------------------------------------------------------------------------------------------------
                'partikapasite = ggnkapasite - tuketimkapasite
                'plankontrol = 0
                'plankontrol = row("PLAN")
                'If plankontrol > 0 Then
                'If partikapasite >= plankontrol Then
                'toplam = toplam + Convert.ToDecimal(row("PLAN"))
                '========================================================================================================
                ListBox1.Items.Add(row("GGN_NO"))
                ListBox2.Items.Add(row("PARTI_KAPASITE"))
                '            Else
                '                DevExpress.XtraEditors.XtraMessageBox.Show("GGN No: " & kontrol & " Planlanan Miktar: " & row("PLAN") & " GGN Miktarından fazladır")
                '                row("PLAN") = "0"
                '            End If
                '        End If
            Next i
            '    TextEdit1.Text = toplam
        End If
    End Sub
    Private Sub GridControl1_Click_1(sender As Object, e As EventArgs) Handles GridControl1.Click
        'On Error Resume Next
        'Dim GGN
        'GGN = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "GGN_NO").ToString()
        'DataGridView1.DataSource = ds
        'ds.Clear()
        'ds.Dispose()
        ''=============================================================================================================================================================
        'cnn.ConnectionString = "server=10.3.11.61;database=ALANSIS;uid=sa;pwd=term.0907"
        'cnn.Open()
        'cmd.Connection = cnn
        'cmd.CommandType = CommandType.Text
        'cmd.CommandText = "SELECT* FROM EO_ALANSIS_GGNPARTI WHERE GGN_NO='" & GGN & "'"
        'da.SelectCommand = cmd
        'DataGridView1.ClearSelection()
        'da.Fill(ds)
        'DataGridView1.DataSource = ds.Tables(0).DefaultView
        ''=============================================================================================================================================================
        'cnn.Close()
        ''------------------------------------------------------------------------------
        'DataGridView1.AutoResizeColumns(DataGridViewAutoSizeColumnMode.AllCells)
        'For i = 0 To DataGridView1.Rows.Count - 1 Step 2
        '    DataGridView1.Rows(i).DefaultCellStyle.BackColor = Color.LemonChiffon
        'Next
        ''------------------------------------------------------------------------------
    End Sub
    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        '        'On Error GoTo hata
        '        Dim conn1 As New SqlConnection
        '        Dim cmd1 As New SqlCommand
        '        Dim cmd2 As New SqlCommand
        '        Dim da As New SqlDataAdapter()
        '        Dim ds As New DataSet
        '        Dim GGN, stokkodu, yerlesim, geldigi_yer, renk, serikontrol, ggnuretici, ggnbolge, user As String
        '        Dim seribakiye, listkontrol, KALANMIKTAR As Integer
        '        Dim partimiktar, GGNmiktar, GGNPARTIMIKTAR, partikapasite, toppartikapasite, toptuketimkapasite, topkalankapasite, ggnkont, partikont As Decimal
        '        user = Trim(Mid(Form2.Text, 15, 50))
        '        GGN = ""
        '        serikontrol = ""
        '        stokkodu = ""
        '        yerlesim = ""
        '        geldigi_yer = ""
        '        renk = ""
        '        ggnuretici = ""
        '        ggnbolge = ""
        '        seribakiye = 0
        '        listkontrol = 0
        '        GGNPARTIMIKTAR = 0
        '        partikapasite = 0
        '        topkalankapasite = 0
        '        toppartikapasite = 0
        '        toptuketimkapasite = 0
        '        KALANMIKTAR = 0
        '        ggnkont = 0
        '        partikont = 0
        '        partimiktar = TextEdit4.Text
        '        conn1.ConnectionString = "server=10.3.11.61;database=ALANSIS;uid=sa;pwd=term.0907"
        '        '-----------------------------------------------------------------------------------------
        '        '=======================================================================================================================
        '        'conn1.Open()
        '        'Dim mySelectQuery22 As String = "SELECT PARTINO,SUM(GGN_MIKTAR) AS GGNMIKTAR,PARTI_MIKTAR FROM EO_ALANSIS_GGNPARTI WHERE PARTINO='" & TextEdit2.Text & "' GROUP BY PARTINO,PARTI_MIKTAR ;"
        '        'Dim SqlComm22 As New System.Data.SqlClient.SqlCommand(mySelectQuery22, conn1)
        '        'Dim reader22 As System.Data.SqlClient.SqlDataReader
        '        'reader22 = SqlComm22.ExecuteReader()
        '        'While reader22.Read()
        '        '    ggnkont = IIf(reader22("GGNMIKTAR") Is Nothing, 0, reader22("GGNMIKTAR"))
        '        '    partikont = IIf(reader22("PARTI_MIKTAR") Is Nothing, 0, reader22("GGNMIKTAR"))
        '        'End While
        '        'reader22.Close()
        '        'conn1.Close()
        '        ''=======================================================================================================================
        '        'If (ggnkont >= partikont) And (ggnkont > 0 Or partikont > 0) Then
        '        '    DevExpress.XtraEditors.XtraMessageBox.Show("GGN Miktarı ile Parti Miktarı zaten tanımlanmış,Yeni tanımlama yapılamaz")
        '        '    Exit Sub
        '        'End If
        '        'GGNmiktar = Convert.ToDecimal(TextEdit1.Text)
        '        'If GGNmiktar > partimiktar Then
        '        '    DevExpress.XtraEditors.XtraMessageBox.Show("GGN Miktarı, Parti Üretim Miktarından büyük olamaz...")
        '        '    Exit Sub
        '        'End If
        '        listkontrol = ListBox1.Items.Count
        '        If listkontrol > 0 Then
        '            '------------------------------------------------------------------------------------------------------------------------------
        '            For i As Integer = 0 To ListBox1.Items.Count - 1 And ListBox2.Items.Count - 1
        '                GGN = ListBox1.Items(i)
        '                KALANMIKTAR = ListBox2.Items(i)
        '                '---------------------------------------------------------------------------------------------------------------
        '                conn1.Open()
        '                cmd1.Connection = conn1
        '                'cmd1.CommandText = "INSERT INTO EO_ALANSIS_GGNPARTI (TARIH,PARTINO,GGN,GGN_MIKTAR,PARTI_MIKTAR) VALUES ( '" & Date.Today & "','" & TextEdit2.Text & "','" & GGN & "','" & Replace(GGNPARTIMIKTAR, ",", ".") & "','" & Replace(TextEdit4.Text, ",", ".") & "')"
        '                cmd1.CommandText = "INSERT INTO EO_ALANSIS_GGNPARTI (TARIH,PARTINO,GGN,PARTI_MIKTAR) VALUES ( '" & Date.Today & "','" & TextEdit2.Text & "','" & GGN & "','" & KALANMIKTAR & "')"
        '                cmd1.ExecuteNonQuery()
        '                conn1.Close()
        '                '---------------------------------------------------------------------------------------------------
        '                conn1.Open()
        '                Dim mySelectQuery2 As String = "SELECT* FROM EO_ALANSIS_GGN WHERE GGN_NO='" & GGN & "';"
        '                Dim SqlComm2 As New System.Data.SqlClient.SqlCommand(mySelectQuery2, conn1)
        '                Dim reader2 As System.Data.SqlClient.SqlDataReader
        '                reader2 = SqlComm2.ExecuteReader()
        '                While reader2.Read()
        '                    partikapasite = reader2("TUKETIM_KAPASITE")
        '                    toppartikapasite = reader2("KAPASITE")
        '                    ggnuretici = reader2("URETICI_ADSOY")
        '                    ggnbolge = reader2("BOLGE")
        '                End While
        '                reader2.Close()
        '                conn1.Close()
        '                'toptuketimkapasite = partikapasite + GGNPARTIMIKTAR
        '                'topkalankapasite = toppartikapasite - toptuketimkapasite
        '                '---------------------------------------------------------------------------------------------------------------
        '                'conn1.Open()
        '                'cmd1.Connection = conn1
        '                'cmd1.CommandText = "UPDATE EO_ALANSIS_GGN SET PARTI_KAPASITE='" & Replace(topkalankapasite, ",", ".") & "',TUKETIM_KAPASITE='" & Replace(toptuketimkapasite, ",", ".") & "' WHERE GGN_NO='" & GGN & "'"
        '                'cmd1.ExecuteNonQuery()
        '                'conn1.Close()
        '                '--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
        '                SMTP.Timeout = 5
        '                SMTP.EnableSsl = True
        '                SMTP.Credentials = New System.Net.NetworkCredential("alansis.bilgi@gmail.com", "alanar.2021")
        '                SMTP.Port = "587"
        '                Mail.Subject = "Parti No: " & TextEdit2.Text & " için GGN NO : " & GGN & " ONAY"
        '                Mail.To.Add("ercanozyanar@gmail.com,canan.bulut@alanar.com.tr,kalite.saha@alanar.com.tr,ridvan.akman@alanar.com.tr")
        '                Mail.From = New MailAddress("alansis.bilgi@gmail.com")
        '                Mail.Body = "Parti No: " & TextEdit2.Text & " için GGN NO : " & GGN & ", URETICI : " & ggnuretici & " , BOLGE :" & ggnbolge & ", KULLANICI :" & user & " tarafından " & DateTime.Now & " zamanında ONAYLANMISTIR..."
        '                SMTP.Send(Mail)
        '                '---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
        '            Next
        '            TextEdit1.Text = ""
        '            TextEdit2.Text = ""
        '            TextEdit3.Text = ""
        '            TextEdit4.Text = ""
        '            DevExpress.XtraEditors.XtraMessageBox.Show("Kayıt İşlemi tamamlanmıştır...")
        '            Form131.ComboBoxEdit15.Text = "OK"
        '            Me.Hide()
        '            Form131.Show()
        '            Exit Sub

        '            If listkontrol <= 0 Then
        '                DevExpress.XtraEditors.XtraMessageBox.Show("Lütfen seri seçim yapınız...")
        '                Exit Sub
        '            End If
        '        End If
        'hata:   DevExpress.XtraEditors.XtraMessageBox.Show("Kayıt İşleminde hata, kontrol ediniz...")
        '        Exit Sub
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        'TODO: Bu kod satırı 'ALANSISDataSet14.EO_ALANSIS_GGN' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
        Me.EO_ALANSIS_GGNTableAdapter1.Fill(Me.ALANSISDataSet14.EO_ALANSIS_GGN)
        'TODO: Bu kod satırı 'ALANSISDataSet14.EO_ALANSIS_GGN' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
        Me.EO_ALANSIS_GGNTableAdapter1.Fill(Me.ALANSISDataSet14.EO_ALANSIS_GGN)
        Me.EO_ALANSIS_GGNTableAdapter1.Fill(Me.ALANSISDataSet14.EO_ALANSIS_GGN)
        Me.EO_ALANSIS_GGNTableAdapter4.Fill(AlansısDataSet181.EO_ALANSIS_GGN)
        GridView1.OptionsSelection.MultiSelect = True
        GridView1.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect

    End Sub
End Class