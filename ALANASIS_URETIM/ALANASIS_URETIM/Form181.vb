Imports System.Data.SqlClient
Imports DevExpress.Compatibility
Imports DevExpress.Data
Imports DevExpress.XtraGrid.Columns
Public Class Form181
    Dim SqlConnStr As String = "server=10.3.11.61;database=ALANSIS;uid=sa;pwd=term.0907;"
    Dim SqlConn As New System.Data.SqlClient.SqlConnection(SqlConnStr)
    Dim cmd As New SqlCommand()
    Dim cnn As New SqlConnection()
    Dim da As New SqlDataAdapter()
    Dim ds As New DataSet
    Private Sub Form181_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Dim connectionString As String = "server=10.3.11.61;database=ALANSIS;uid=sa;pwd=term.0907"
            Dim sql As String = "SELECT CASE KLTINDEX WHEN '0' THEN 'MEYVE ALIM SAHASINDA' WHEN '1' THEN 'DEPODA MAL KABUL YAPILIYOR' WHEN '2' THEN 'MAL KABUL YAPILDI' WHEN '3' THEN 'KALITE KONTROL OK' END AS DURUM,TARIH,ID AS ALANSIS_MADSERI,URETICI_ADSOY,BOLGE,KANTARNO,KASA_SAYI,BRUT,NET,DARA,MADNO,KLTINDEX,GIRDIKONTROL FROM EO_ALANSIS_MAD"
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

    Private Sub GridControl1_Click(sender As Object, e As EventArgs) Handles GridControl1.Click
        TextBox1.Text = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "GIRDIKONTROL").ToString()
        Label2.Text = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "ALANSIS_MADSERI").ToString()
        Label3.Text = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "URETICI_ADSOY").ToString()
    End Sub

    Private Sub GridControl1_KeyDown(sender As Object, e As KeyEventArgs) Handles GridControl1.KeyDown
        ListBox1.Items.Clear()
        ListBox2.Items.Clear()
        ListBox3.Items.Clear()
        ListBox4.Items.Clear()
        If (e.KeyCode = Keys.Tab) Then
            Dim ret As String = ""
            For Each i As Integer In GridView1.GetSelectedRows()
                Dim row As DataRow = GridView1.GetDataRow(i)
                If ret <> "" Then
                    ret &= ControlChars.CrLf
                End If
                '========================================================================================================
                ListBox1.Items.Add(row("TARIH"))
                ListBox2.Items.Add(row("ALANSIS_MADSERI"))
                ListBox3.Items.Add(row("URETICI_ADSOY"))
                ListBox4.Items.Add(row("NET"))
            Next i
        End If
    End Sub

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        Form144.Show()
        For i As Integer = 0 To ListBox1.Items.Count - 1
            Form144.ListBox1.Items.Add(ListBox1.Items(i))
        Next
        For x As Integer = 0 To ListBox2.Items.Count - 1
            Form144.ListBox2.Items.Add(ListBox2.Items(x))
        Next
        For y As Integer = 0 To ListBox3.Items.Count - 1
            Form144.ListBox3.Items.Add(ListBox3.Items(y))
        Next
        For z As Integer = 0 To ListBox4.Items.Count - 1
            Form144.ListBox4.Items.Add(ListBox4.Items(z))
        Next



    End Sub

    Private Sub SimpleButton2_Click(sender As Object, e As EventArgs) Handles SimpleButton2.Click
        SqlConn.Open()
        Dim mySelectQuery21 As String = "Select* From EO_KIRAZGIRDI_KONTROL Where ID='" & TextBox1.Text & "';"
        Dim SqlComm21 As New System.Data.SqlClient.SqlCommand(mySelectQuery21, SqlConn)
        Dim reader21 As System.Data.SqlClient.SqlDataReader
        reader21 = SqlComm21.ExecuteReader()
        While reader21.Read()
            Form144.TextEdit1.Text = reader21("HASAT_TARIH").ToString()
            Form144.TextEdit30.Text = reader21("ANALIZ_TARIH").ToString()
            Form144.ComboBoxEdit1.Text = reader21("VARDIYA").ToString()
            Form144.TextEdit2.Text = reader21("TESIS").ToString()
            Form144.TextEdit3.Text = reader21("UBT_KODU").ToString()
            Form144.TextEdit4.Text = reader21("ARAC_PLAKA").ToString()
            'Form144.TextEdit5.Text = reader21("CESIT_ADI").ToString()
            'Form144.TextEdit6.Text = reader21("TOPLAM_TONAJ").ToString()
            Form144.TextEdit7.Text = reader21("NUMUNE_MIKTARI").ToString()
            Form144.TextEdit8.Text = reader21("YABANCI_MADDE").ToString()
            Form144.TextEdit9.Text = reader21("KUFLENME").ToString()
            Form144.TextEdit10.Text = reader21("DAL_SURTMESI").ToString()
            Form144.TextEdit11.Text = reader21("CURUME").ToString()
            Form144.TextEdit12.Text = reader21("YUMUSAK").ToString()
            Form144.TextEdit13.Text = reader21("ICKURD").ToString()
            Form144.TextEdit14.Text = reader21("IKIZMEYVE").ToString()
            Form144.TextEdit15.Text = reader21("EBAT_ALTI").ToString()
            Form144.TextEdit16.Text = reader21("HASAR").ToString()
            Form144.TextEdit17.Text = reader21("DOLU_ZARAR").ToString()
            Form144.TextEdit18.Text = reader21("TOPLAM_KUSUR").ToString()
            Form144.TextEdit19.Text = reader21("BRIX").ToString()
            Form144.TextEdit20.Text = reader21("K22").ToString()
            Form144.TextEdit21.Text = reader21("K24").ToString()
            Form144.TextEdit22.Text = reader21("K26").ToString()
            Form144.TextEdit23.Text = reader21("K28").ToString()
            Form144.TextEdit24.Text = reader21("SAPSIZ_MEYVE").ToString()
            Form144.ComboBoxEdit2.Text = reader21("PESTISIT").ToString()
            'Form144.TextEdit28.Text = reader21("TAT").ToString()
            'Form144.TextEdit27.Text = reader21("KOKU").ToString()
            'Form144.TextEdit26.Text = reader21("YAPI").ToString()
            Form144.TextEdit25.Text = reader21("SICAKLIK").ToString()
            Form144.ComboBoxEdit3.Text = reader21("ARAC_KONTROL").ToString()
            'Form144.ComboBoxEdit4.Text = reader21("KONTROL_SONUC").ToString()
            Form144.TextEdit29.Text = reader21("KALITE_PERSONEL").ToString()
            Form144.SimpleButton1.Enabled = False
            Form144.SimpleButton2.Enabled = False
        End While
        reader21.Close()
        SqlConn.Close()
        Form144.MdiParent = Form2
        Form144.Show()
    End Sub
End Class