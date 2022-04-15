Imports System.Data.SqlClient
Imports System.Data
Imports System.Net.Sockets
Public Class Form139
    Dim SqlConnStr As String = "server=10.3.11.61;database=ALANSIS;uid=sa;pwd=term.0907;"
    Dim SqlConn As New System.Data.SqlClient.SqlConnection(SqlConnStr)
    Dim cmd As New SqlCommand()
    Dim cnn As New SqlConnection()
    Dim da As New SqlDataAdapter()
    Dim ds As New DataSet
    Dim i As Integer
    Sub New()
        InitializeComponent()
    End Sub
    Private Sub Form139_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim grupkontrol As String
        grupkontrol = ""
        grupkontrol = Trim(Mid(Form2.BarStaticItem4.Caption, 12, 15))
        If grupkontrol = "MEYVE" Then
            Label3.Text = "Meyve"
            Try
                Dim connectionString As String = "server=10.3.11.61;database=ALANSIS;uid=sa;pwd=term.0907"
                Dim sql As String = "SELECT PARTINO,STOK_KODU,SERI,YERLESIM,GELDIGI_YER,RENK,SERI_BAKIYE,URETIM_ONAY,MEYVE_ONAY,ZIRAI_ONAY FROM EO_ALANSIS_HAMMADDEONAY WHERE PARTINO='" & TextEdit1.Text & "' AND MEYVE_ONAY IS NULL"
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
        End If
        If grupkontrol = "ZIRAI" Then
            Label3.Text = "Zirai"
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
        End If
    End Sub
    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        '        On Error GoTo hata
        '        Dim grupkontrol As String
        '        Dim conn1 As New SqlConnection
        '        Dim cmd1 As New SqlCommand
        '        Dim cmd2 As New SqlCommand
        '        grupkontrol = ""
        '        grupkontrol = Trim(Mid(Form2.BarStaticItem4.Caption, 12, 15))
        '        '------------------------------------------------------------------------------------------------------------------------------
        '        conn1.ConnectionString = "server=10.3.11.61;database=ALANSIS;uid=sa;pwd=term.0907"
        '        '-----------------------------------------------------------------------------------------
        '        If ComboBoxEdit1.Text = "" Or TextEdit1.Text = "" Then
        '            DevExpress.XtraEditors.XtraMessageBox.Show("Onay işlemi verilmemiş.Lütfen Kontrol ediniz...")
        '            Exit Sub
        '        Else
        '            'If grupkontrol = "MEYVE" Then
        '            '    '---------------------------------------------------------------------------------------------------------------
        '            '    conn1.Open()
        '            '    cmd1.Connection = conn1
        '            '    cmd1.CommandText = "UPDATE EO_ALANSIS_HAMMADDEONAY SET MEYVE_ONAY='OK' WHERE PARTINO='" & TextEdit1.Text & "'"
        '            '    cmd1.ExecuteNonQuery()
        '            '    '--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
        '            '    conn1.Close()
        '            '    '---------------------------------------------------------------------------------------------------
        '            '    DevExpress.XtraEditors.XtraMessageBox.Show("Onay İşlemi tamamlanmıştır...")
        '            '    Form131.ComboBoxEdit14.Text = "OK"
        '            '    Form131.Show()
        '            '    Me.Hide()
        '            '    Exit Sub
        '            'End If
        '            '    If grupkontrol = "ZIRAI" Then
        '            '        '---------------------------------------------------------------------------------------------------------------
        '            '        conn1.Open()
        '            '        cmd1.Connection = conn1
        '            '        cmd1.CommandText = "UPDATE EO_ALANSIS_HAMMADDEONAY SET ZIRAI_ONAY='OK' WHERE PARTINO='" & TextEdit1.Text & "'"
        '            '        cmd1.ExecuteNonQuery()
        '            '        '--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
        '            '        conn1.Close()
        '            '        '---------------------------------------------------------------------------------------------------
        '            '        DevExpress.XtraEditors.XtraMessageBox.Show("Onay İşlemi tamamlanmıştır...")
        '            '        Form131.ComboBoxEdit14.Text = "OK"
        '            '        Form131.Show()
        '            '        Me.Hide()
        '            '        Exit Sub
        '            '    End If
        '            'End If
        'hata:
        '        DevExpress.XtraEditors.XtraMessageBox.Show("Hatalı işlem.Lütfen Kontrol ediniz...")
        '        Exit Sub

    End Sub

    Private Sub ComboBoxEdit1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxEdit1.SelectedIndexChanged
        If ComboBoxEdit1.Text = "NOK" Then
            SimpleButton1.Enabled = False
            Form140.Show()
        End If
        If ComboBoxEdit1.Text = "OK" Then
            SimpleButton1.Enabled = True
        End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Dim grupkontrol As String
        grupkontrol = ""
        grupkontrol = Trim(Mid(Form2.BarStaticItem4.Caption, 12, 15))
        If grupkontrol = "MEYVE" Then
            Label3.Text = "Meyve"
            Try
                Dim connectionString As String = "server=10.3.11.61;database=ALANSIS;uid=sa;pwd=term.0907"
                Dim sql As String = "SELECT PARTINO,STOK_KODU,SERI,YERLESIM,GELDIGI_YER,RENK,SERI_BAKIYE,URETIM_ONAY,MEYVE_ONAY,ZIRAI_ONAY FROM EO_ALANSIS_HAMMADDEONAY WHERE PARTINO='" & TextEdit1.Text & "' AND MEYVE_ONAY IS NULL"
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
        End If
        If grupkontrol = "ZIRAI" Then
            Label3.Text = "Zirai"
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
        End If
    End Sub
End Class