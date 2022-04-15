Imports System.Data.SqlClient
Imports System.Data
Imports System.Net.Sockets
Public Class Form142
    Dim SqlConnStr As String = "server=10.3.11.61;database=ALANSIS;uid=sa;pwd=term.0907;"
    Dim SqlConn As New System.Data.SqlClient.SqlConnection(SqlConnStr)
    Dim cmd As New SqlCommand()
    Dim cnn As New SqlConnection()
    Dim da As New SqlDataAdapter()
    Dim ds As New DataSet
    Dim i As Integer
    Private Sub Form142_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Dim connectionString As String = "server=10.3.11.61;database=ALANSIS;uid=sa;pwd=term.0907"
            Dim sql As String = "SELECT PARTINO,STOK_KODU,SERI,YERLESIM,GELDIGI_YER,RENK,SERI_BAKIYE,URETIM_ONAY,MEYVE_ONAY,ZIRAI_ONAY FROM EO_ALANSIS_HAMMADDEONAY WHERE PARTINO='" & TextEdit1.Text & "' AND MEYVE_ONAY='OK' AND ZIRAI_ONAY IS NULL"
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

    End Sub
    Sub New()

        InitializeComponent()

    End Sub

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        '        On Error GoTo hata
        '        Dim conn1 As New SqlConnection
        '        Dim cmd1 As New SqlCommand
        '        Dim cmd2 As New SqlCommand
        '        '------------------------------------------------------------------------------------------------------------------------------
        '        conn1.ConnectionString = "server=10.3.11.61;database=ALANSIS;uid=sa;pwd=term.0907"
        '        '-----------------------------------------------------------------------------------------
        '        If ComboBoxEdit1.Text = "" Or TextEdit1.Text = "" Then
        '            DevExpress.XtraEditors.XtraMessageBox.Show("Onay işlemi verilmemiş.Lütfen Kontrol ediniz...")
        '            Exit Sub
        '        Else
        '            '---------------------------------------------------------------------------------------------------------------
        '            conn1.Open()
        '            cmd1.Connection = conn1
        '            cmd1.CommandText = "UPDATE EO_ALANSIS_HAMMADDEONAY SET ZIRAI_ONAY='OK' WHERE PARTINO='" & TextEdit1.Text & "'"
        '            cmd1.ExecuteNonQuery()
        '            '--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
        '            conn1.Close()
        '            '---------------------------------------------------------------------------------------------------
        '            DevExpress.XtraEditors.XtraMessageBox.Show("Onay İşlemi tamamlanmıştır...")
        '            Form131.ComboBoxEdit14.Text = "OK"
        '            Form131.Show()
        '            Me.Hide()
        '            Exit Sub

        '        End If
        'hata:
        '        DevExpress.XtraEditors.XtraMessageBox.Show("Hatalı işlem.Lütfen Kontrol ediniz...")
        '        Exit Sub
    End Sub
End Class