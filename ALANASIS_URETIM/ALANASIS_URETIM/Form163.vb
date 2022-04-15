Imports System.Data.SqlClient
Imports DevExpress.Compatibility
Imports DevExpress.Data
Imports DevExpress.XtraGrid.Columns
Public Class Form163
    Dim SqlConnStr As String = "server=10.3.11.61;database=ALANSIS;uid=sa;pwd=term.0907;"
    Dim SqlConn As New System.Data.SqlClient.SqlConnection(SqlConnStr)
    Dim cmd As New SqlCommand()
    Dim cnn As New SqlConnection()
    Dim da As New SqlDataAdapter()
    Dim ds As New DataSet
    Sub New()
        InitializeComponent()
        'EO_ALANSIS_MAMULSTOKTableAdapter1.Fill(AlansısDataSet211.EO_ALANSIS_MAMULSTOK)
    End Sub
    Private Sub Form163_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Dim connectionString As String = "server=10.3.11.61;database=ALANSIS;uid=sa;pwd=term.0907"
            Dim sql As String = "SELECT TARIH,SERI,STOK_KODU,STOK_ADI,NET,BRUT,DARA,BOLGE,RENK FROM EO_ALANSIS_MAMULSTOK WHERE STOK_KODU='" & TextEdit3.Text & "'"
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
        ListBox1.Items.Clear()
        If (e.KeyCode = Keys.Tab) Then
            Dim toplam As Integer
            toplam = 0
            Dim ret As String = ""
            For Each i As Integer In GridView1.GetSelectedRows()
                Dim row As DataRow = GridView1.GetDataRow(i)
                If ret <> "" Then
                    ret &= ControlChars.CrLf
                End If
                toplam = toplam + Convert.ToInt16(row("NET"))
                '========================================================================================================
                ListBox1.Items.Add(row("SERI"))
            Next i
            TextEdit1.Text = toplam
        End If
    End Sub
    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        On Error GoTo hata
        Dim conn1 As New SqlConnection
        Dim cmd1 As New SqlCommand
        Dim cmd2 As New SqlCommand
        Dim da As New SqlDataAdapter()
        Dim ds As New DataSet
        Dim tarih, seri, stokkodu, stokadi, bolge, renk, serilist, serikontrol As String
        Dim net, brut, dara, partimiktar, a, y, z, x As Decimal
        Dim listmiktar, listkontrol As Integer
        tarih = ""
        seri = ""
        stokkodu = ""
        stokadi = ""
        bolge = ""
        renk = ""
        net = 0
        brut = 0
        dara = 0
        '------------------------
        a = 0
        x = 0
        y = 0
        z = 0
        '------------------------
        listmiktar = 0
        listkontrol = 0
        partimiktar = TextEdit4.Text
        listmiktar = Convert.ToInt16(TextEdit1.Text)
        If listmiktar > partimiktar Then
            DevExpress.XtraEditors.XtraMessageBox.Show("Seçim Miktarı, Parti Üretim Miktarından büyük olamaz...")
            Exit Sub
        End If
        listkontrol = ListBox1.Items.Count
        If listkontrol > 0 Then
            '------------------------------------------------------------------------------------------------------------------------------
            conn1.ConnectionString = "server=10.3.11.61;database=ALANSIS;uid=sa;pwd=term.0907"
            '-----------------------------------------------------------------------------------------
            For i As Integer = 0 To ListBox1.Items.Count - 1
                serilist = ListBox1.Items(i)
                '---------------------------------------------------------------------------------------------------------------
                conn1.Open()
                Dim mySelectQuery1 As String = "SELECT* FROM EO_ALANSIS_MAMULREZERVE WHERE SERI='" & serilist & "' AND PARTINO='" & TextEdit2.Text & "';"
                Dim SqlComm1 As New System.Data.SqlClient.SqlCommand(mySelectQuery1, conn1)
                Dim reader1 As System.Data.SqlClient.SqlDataReader
                reader1 = SqlComm1.ExecuteReader()
                While reader1.Read()
                    serikontrol = reader1("SERI")
                End While
                reader1.Close()
                conn1.Close()
                If serikontrol = "" Then
                    '---------------------------------------------------------------------------------------------------------------
                    conn1.Open()
                    Dim mySelectQuery2 As String = "SELECT* FROM EO_ALANSIS_MAMULSTOK WHERE SERI='" & serilist & "';"
                    Dim SqlComm2 As New System.Data.SqlClient.SqlCommand(mySelectQuery2, conn1)
                    Dim reader2 As System.Data.SqlClient.SqlDataReader
                    reader2 = SqlComm2.ExecuteReader()
                    While reader2.Read()
                        tarih = reader2("TARIH")
                        seri = reader2("SERI")
                        stokkodu = reader2("STOK_KODU")
                        stokadi = reader2("STOK_ADI")
                        net = Convert.ToInt16(reader2("NET"))
                        brut = Convert.ToInt16(reader2("BRUT"))
                        dara = Convert.ToInt16(reader2("DARA"))
                        bolge = reader2("BOLGE")
                        renk = reader2("RENK")
                    End While
                    reader2.Close()
                    conn1.Close()
                    '---------------------------------------------------------------------------------------------------------------
                    conn1.Open()
                    cmd1.Connection = conn1
                    cmd1.CommandText = "INSERT INTO EO_ALANSIS_MAMULREZERVE (TARIH,PARTINO,RENK,STOK_KODU,STOK_ADI,SERI,NET,BRUT,DARA,BOLGE) VALUES ( '" & tarih & "','" & TextEdit2.Text & "','" & renk & "','" & stokkodu & "','" & stokadi & "','" & seri & "','" & Replace(net, ",", ".") & "','" & Replace(brut, ",", ".") & "','" & Replace(dara, ",", ".") & "','" & bolge & "')"
                    cmd1.ExecuteNonQuery()
                    conn1.Close()
                    conn1.Open()
                    cmd1.Connection = conn1
                    cmd1.CommandText = "UPDATE EO_ALANSIS_KIRAZ_MAMULDEPO SET STOK_ISLEM='1' WHERE SERI= '" & seri & "'"
                    cmd1.ExecuteNonQuery()
                    conn1.Close()
                    '---------------------------------------------------------------------------------------------------
                End If
            Next
            a = Convert.ToDecimal(TextEdit1.Text)
            y = Convert.ToDecimal(TextBox1.Text)
            z = Convert.ToDecimal(TextBox2.Text)
            x = a / (y * z)

            DevExpress.XtraEditors.XtraMessageBox.Show("Kayıt İşlemi tamamlanmıştır...")
            Form131.TextEdit8.Text = Math.Round(Convert.ToDecimal(TextEdit4.Text) - a)
            Form131.TextEdit5.Text = Math.Round(Convert.ToDecimal(TextBox3.Text) - x)
            Form131.ComboBoxEdit16.Text = "OK"
            TextEdit1.Text = ""
            TextEdit2.Text = ""
            TextEdit3.Text = ""
            TextEdit4.Text = ""
            Form131.Show()
            Me.Close()
            Exit Sub
        End If
        If listkontrol <= 0 Then
            DevExpress.XtraEditors.XtraMessageBox.Show("Lütfen seri seçim yapınız...")
            Exit Sub
        End If
hata:
        DevExpress.XtraEditors.XtraMessageBox.Show("Kayıt İşleminde hata, kontrol ediniz...")
        Exit Sub
    End Sub

    Private Sub GridControl1_Click(sender As Object, e As EventArgs) Handles GridControl1.Click

    End Sub
End Class