﻿Imports System.Data.SqlClient
Imports System.Data
Imports System.Net.Sockets
Public Class Form116
    Sub New()

        InitializeComponent()
        ' This line of code is generated by Data Source Configuration Wizard
        EO_ALANSIS_SATIS_DETAYTableAdapter1.Fill(AlansısDataSet1.EO_ALANSIS_SATIS_DETAY)
    End Sub

    Dim SqlConnStr As String = "server=10.3.11.61;database=ALANSIS;uid=sa;pwd=term.0907;"
    Dim SqlConn As New System.Data.SqlClient.SqlConnection(SqlConnStr)
    Private Sub XtraTabPage1_Paint(sender As Object, e As PaintEventArgs) Handles XtraTabPage1.Paint

    End Sub

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        On Error GoTo HATA
        Dim conn1 As New SqlConnection
        Dim cmd1 As New SqlCommand
        Dim cmd2 As New SqlCommand
        Dim da As New SqlDataAdapter()
        Dim ds As New DataSet
        Dim cmd As New SqlCommand()
        Dim cnn As New SqlConnection()
        Dim kapasite, sevk, kalan As Integer
        kapasite = TextBox5.Text
        sevk = TextBox6.Text
        kalan = TextBox7.Text
        TextBox4.Text = Replace(TextBox4.Text, ",", ".")
        TextBox8.Text = Replace(TextBox8.Text, ",", ".")
        '-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
        conn1.ConnectionString = "server=10.3.11.61;database=ALANSIS;uid=sa;pwd=term.0907"
        conn1.Open()
        cmd1.Connection = conn1
        cmd1.CommandText = "INSERT INTO EO_ALANSIS_GGN_CIN (URUN,TN_KODU,GGN,URETICI,ACIKLAMA,KOY,BOLGE,ANALIZ_SONUCU,HEKTAR,KAPASITE,SEVKLER,KALAN,GECILEN,DURUM,GRASP,GGAP,URETICI_KAYIT) VALUES ( '" & ComboBoxEdit1.Text & "','" & TextBox1.Text & "','" & TextBox2.Text & "','" & ComboBoxEdit2.Text & "','" & TextBox26.Text & "','" & ComboBoxEdit3.Text & "','" & ComboBoxEdit4.Text & "','" & TextBox3.Text & "','" & TextBox4.Text & "', '" & kapasite & "','" & sevk & "','" & kalan & "','" & TextBox8.Text & "','" & TextBox9.Text & "','" & MaskedTextBox1.Text & "','" & MaskedTextBox2.Text & "','" & MaskedTextBox3.Text & "')"
        cmd1.ExecuteNonQuery()
        conn1.Close()
        '--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
        DevExpress.XtraEditors.XtraMessageBox.Show("Kayit İşlemi Tamamlanmiştir...")
        ComboBoxEdit1.Text = ""
        TextBox1.Text = ""
        TextBox2.Text = ""
        ComboBoxEdit2.Text = ""
        TextBox26.Text = ""
        ComboBoxEdit3.Text = ""
        ComboBoxEdit4.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""
        TextBox7.Text = ""
        TextBox6.Text = ""
        TextBox5.Text = ""
        TextBox8.Text = ""
        TextBox9.Text = ""
        MaskedTextBox1.Text = ""
        MaskedTextBox2.Text = ""
        MaskedTextBox3.Text = ""

        '===========================================================================================================================
        conn1.Open()
        cmd.Connection = conn1
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "SELECT* FROM EO_ALANSIS_GGN_CIN ORDER BY ID DESC"
        da.SelectCommand = cmd
        DataGridView1.ClearSelection()
        da.Fill(ds)
        DataGridView1.DataSource = ds.Tables(0).DefaultView
        DataGridView1.AutoResizeColumns(DataGridViewAutoSizeColumnMode.AllCells)
        conn1.Close()
        DataGridView1.AutoResizeColumns(DataGridViewAutoSizeColumnMode.AllCells)
        '------------------------------------------------------------------------------
        For i = 0 To DataGridView1.Rows.Count - 1 Step 2
            DataGridView1.Rows(i).DefaultCellStyle.BackColor = Color.LemonChiffon
            '------------------------------------------------------------------------------
        Next
        Exit Sub
HATA:
        DevExpress.XtraEditors.XtraMessageBox.Show("Kayit İşleminde Hata, Lütfen Kontrol Ediniz...")
        Exit Sub

    End Sub

    Private Sub TextBox4_TextChanged(sender As Object, e As EventArgs) Handles TextBox4.TextChanged
        On Error Resume Next
        Dim say1, say2 As Integer
        say1 = TextBox4.Text
        say2 = say1 * 25 * 1000
        TextBox5.Text = say2
    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged
        On Error Resume Next
        '---------------------------------------------------------------------------------------
        SqlConn.Open()
        Dim mySelectQuery1 As String = "SELECT SUM(NET_KG) AS TOPLAM_SEVK FROM EO_ALANSIS_GGN_YUKLEME WHERE GGN='" & TextBox2.Text & "';"
        Dim SqlComm1 As New System.Data.SqlClient.SqlCommand(mySelectQuery1, SqlConn)
        Dim reader1 As System.Data.SqlClient.SqlDataReader
        reader1 = SqlComm1.ExecuteReader()
        While reader1.Read()
            TextBox6.Text = (reader1("TOPLAM_SEVK"))
        End While
        reader1.Close()
        SqlConn.Close()
        If TextBox6.Text = "" Then
            TextBox6.Text = "0"
        End If
        '-----------------------------------------------------------------------------------------
    End Sub

    Private Sub TextBox5_TextChanged(sender As Object, e As EventArgs) Handles TextBox5.TextChanged
        On Error Resume Next
        Dim say1, say2 As Integer
        say1 = TextBox5.Text
        say2 = TextBox6.Text
        TextBox7.Text = say1 - say2
        '=====================================
        'SEVK > KAPASITE DEN BITTI,KULLAN
        If say2 > say1 Then
            TextBox9.Text = "BITTI"
        Else
            TextBox9.Text = "KULLAN"
        End If

        Dim say11, say21 As Integer
        say11 = TextBox6.Text
        say21 = TextBox5.Text
        TextBox8.Text = Format(say11 / say21, "0.00%")
    End Sub

    Private Sub SimpleButton4_Click(sender As Object, e As EventArgs) Handles SimpleButton4.Click
        On Error GoTo HATA
        Dim conn1 As New SqlConnection
        Dim cmd1 As New SqlCommand
        Dim cmd2 As New SqlCommand
        Dim da As New SqlDataAdapter()
        Dim ds As New DataSet
        Dim cmd As New SqlCommand()
        Dim cnn As New SqlConnection()
        TextEdit15.Text = Replace(TextEdit15.Text, ",", ".")
        '-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
        conn1.ConnectionString = "server=10.3.11.61;database=ALANSIS;uid=sa;pwd=term.0907"
        conn1.Open()
        cmd1.Connection = conn1
        cmd1.CommandText = "INSERT INTO EO_ALANSIS_GGN_YUKLEME (TARIH,PALET,PARTINO,MUSTERI,URUN,URETICI,GGN,NET_KG,PLAKA,SAAT) VALUES ( '" & MaskedTextBox4.Text & "','" & TextEdit10.Text & "','" & ComboBoxEdit10.Text & "','" & TextEdit12.Text & "','" & ComboBoxEdit5.Text & "','" & TextEdit13.Text & "','" & TextEdit14.Text & "','" & TextEdit15.Text & "','" & TextEdit16.Text & "', '" & TextEdit17.Text & "')"
        cmd1.ExecuteNonQuery()
        conn1.Close()
        '--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
        DevExpress.XtraEditors.XtraMessageBox.Show("Kayit İşlemi Tamamlanmiştir...")
        MaskedTextBox4.Text = ""
        TextEdit10.Text = ""
        ComboBoxEdit10.Text = ""
        TextEdit12.Text = ""
        ComboBoxEdit5.Text = ""
        TextEdit13.Text = ""
        TextEdit14.Text = ""
        TextEdit15.Text = ""
        TextEdit16.Text = ""
        TextEdit17.Text = ""

        '===========================================================================================================================
        conn1.Open()
        cmd.Connection = conn1
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "SELECT* FROM EO_ALANSIS_GGN_YUKLEME ORDER BY ID DESC"
        da.SelectCommand = cmd
        DataGridView2.ClearSelection()
        da.Fill(ds)
        DataGridView2.DataSource = ds.Tables(0).DefaultView
        DataGridView2.AutoResizeColumns(DataGridViewAutoSizeColumnMode.AllCells)
        conn1.Close()
        '------------------------------------------------------------------------------
        For i = 0 To DataGridView2.Rows.Count - 1 Step 2
            DataGridView2.Rows(i).DefaultCellStyle.BackColor = Color.LemonChiffon
            '------------------------------------------------------------------------------
        Next
        Exit Sub
HATA:
        DevExpress.XtraEditors.XtraMessageBox.Show("Kayit İşleminde Hata, Lütfen Kontrol Ediniz...")
        Exit Sub

    End Sub

    Private Sub SimpleButton6_Click(sender As Object, e As EventArgs) Handles SimpleButton6.Click
        On Error GoTo HATA
        Dim conn1 As New SqlConnection
        Dim cmd1 As New SqlCommand
        Dim cmd2 As New SqlCommand
        Dim da As New SqlDataAdapter()
        Dim ds As New DataSet
        Dim cmd As New SqlCommand()
        Dim cnn As New SqlConnection()
        Dim kapasite, sevk, kalan As Integer
        kapasite = TextEdit5.Text
        sevk = TextEdit6.Text
        kalan = TextEdit7.Text
        TextEdit4.Text = Replace(TextEdit4.Text, ",", ".")
        TextEdit6.Text = Replace(TextEdit6.Text, ",", ".")
        '-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
        conn1.ConnectionString = "server=10.3.11.61;database=ALANSIS;uid=sa;pwd=term.0907"
        conn1.Open()
        cmd1.Connection = conn1
        cmd1.CommandText = "INSERT INTO EO_ALANSIS_GGN_KAPASITE (URUN,TN_KODU,GGN,URETICI,ACIKLAMA,KOY,BOLGE,ANALIZ_SONUCU,HEKTAR,KAPASITE,SEVKLER,KALAN,GECILEN,DURUM,GRASP,GGAP,URETICI_KAYIT) VALUES ( '" & ComboBoxEdit9.Text & "','" & TextEdit1.Text & "','" & TextEdit2.Text & "','" & ComboBoxEdit8.Text & "','" & TextBox17.Text & "','" & ComboBoxEdit7.Text & "','" & ComboBoxEdit6.Text & "','" & TextEdit3.Text & "','" & TextEdit4.Text & "', '" & kapasite & "','" & sevk & "','" & kalan & "','" & TextEdit8.Text & "','" & TextEdit9.Text & "','" & MaskedTextBox8.Text & "','" & MaskedTextBox7.Text & "','" & MaskedTextBox6.Text & "')"
        cmd1.ExecuteNonQuery()
        conn1.Close()
        '--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
        DevExpress.XtraEditors.XtraMessageBox.Show("Kayit İşlemi Tamamlanmiştir...")
        ComboBoxEdit9.Text = ""
        TextEdit1.Text = ""
        TextEdit2.Text = ""
        ComboBoxEdit8.Text = ""
        TextBox17.Text = ""
        ComboBoxEdit7.Text = ""
        ComboBoxEdit6.Text = ""
        TextEdit3.Text = ""
        TextEdit4.Text = ""
        TextEdit5.Text = ""
        TextEdit6.Text = ""
        TextEdit7.Text = ""
        TextEdit8.Text = ""
        TextEdit9.Text = ""
        MaskedTextBox8.Text = ""
        MaskedTextBox7.Text = ""
        MaskedTextBox6.Text = ""

        '===========================================================================================================================
        conn1.Open()
        cmd.Connection = conn1
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "SELECT* FROM EO_ALANSIS_GGN_KAPASITE ORDER BY ID DESC"
        da.SelectCommand = cmd
        DataGridView3.ClearSelection()
        da.Fill(ds)
        DataGridView3.DataSource = ds.Tables(0).DefaultView
        DataGridView3.AutoResizeColumns(DataGridViewAutoSizeColumnMode.AllCells)
        conn1.Close()
        DataGridView3.AutoResizeColumns(DataGridViewAutoSizeColumnMode.AllCells)
        '------------------------------------------------------------------------------
        For i = 0 To DataGridView3.Rows.Count - 1 Step 2
            DataGridView3.Rows(i).DefaultCellStyle.BackColor = Color.LemonChiffon
            '------------------------------------------------------------------------------
        Next
        Exit Sub
HATA:
        DevExpress.XtraEditors.XtraMessageBox.Show("Kayit İşleminde Hata, Lütfen Kontrol Ediniz...")
        Exit Sub
    End Sub

    Private Sub TextBox23_TextChanged(sender As Object, e As EventArgs) Handles TextEdit4.TextChanged
        On Error Resume Next
        Dim say1, say2 As Integer
        say1 = TextEdit4.Text
        say2 = say1 * 20 * 1000
        TextEdit5.Text = say2
    End Sub

    Private Sub TextBox22_TextChanged(sender As Object, e As EventArgs) Handles TextEdit5.TextChanged
        On Error Resume Next
        Dim say1, say2 As Integer
        say1 = TextEdit5.Text
        say2 = TextEdit6.Text
        TextEdit7.Text = say1 - say2
        '=====================================
        'SEVK > KAPASITE DEN BITTI,KULLAN
        If say2 > say1 Then
            TextEdit9.Text = "BITTI"
        Else
            TextEdit9.Text = "KULLAN"
        End If

        Dim say11, say21 As Integer
        say11 = TextEdit6.Text
        say21 = TextEdit5.Text
        TextEdit8.Text = Format(say11 / say21, "0.00%")
    End Sub

    Private Sub TextBox6_TextChanged(sender As Object, e As EventArgs) Handles TextBox6.TextChanged

    End Sub

    Private Sub TextBox7_TextChanged(sender As Object, e As EventArgs) Handles TextBox7.TextChanged

    End Sub

    Private Sub TextBox25_TextChanged(sender As Object, e As EventArgs) Handles TextEdit2.TextChanged
        On Error Resume Next
        '---------------------------------------------------------------------------------------
        SqlConn.Open()
        Dim mySelectQuery1 As String = "SELECT SUM(NET_KG) AS TOPLAM_SEVK FROM EO_ALANSIS_GGN_YUKLEME WHERE GGN='" & TextEdit2.Text & "';"
        Dim SqlComm1 As New System.Data.SqlClient.SqlCommand(mySelectQuery1, SqlConn)
        Dim reader1 As System.Data.SqlClient.SqlDataReader
        reader1 = SqlComm1.ExecuteReader()
        While reader1.Read()
            TextEdit6.Text = (reader1("TOPLAM_SEVK"))
        End While
        reader1.Close()
        SqlConn.Close()
        If TextEdit6.Text = "" Then
            TextEdit6.Text = "0"
        End If
        '-----------------------------------------------------------------------------------------

    End Sub

    Private Sub SimpleButton2_Click(sender As Object, e As EventArgs) Handles SimpleButton2.Click
        On Error GoTo HATA
        Dim conn1 As New SqlConnection
        Dim cmd1 As New SqlCommand
        Dim cmd2 As New SqlCommand
        Dim da As New SqlDataAdapter()
        Dim ds As New DataSet
        Dim cmd As New SqlCommand()
        Dim cnn As New SqlConnection()
        '-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
        conn1.ConnectionString = "server=10.3.11.61;database=ALANSIS;uid=sa;pwd=term.0907"
        conn1.Open()
        cmd1.Connection = conn1
        cmd1.CommandText = "DELETE FROM EO_ALANSIS_GGN_CIN WHERE ID= '" & TextBox28.Text & "'"
        cmd1.ExecuteNonQuery()
        conn1.Close()
        '--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
        DevExpress.XtraEditors.XtraMessageBox.Show("Silme İşlemi Tamamlanmiştir...")
        '===========================================================================================================================
        conn1.Open()
        cmd.Connection = conn1
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "SELECT* FROM EO_ALANSIS_GGN_CIN ORDER BY ID DESC"
        da.SelectCommand = cmd
        DataGridView1.ClearSelection()
        da.Fill(ds)
        DataGridView1.DataSource = ds.Tables(0).DefaultView
        DataGridView1.AutoResizeColumns(DataGridViewAutoSizeColumnMode.AllCells)
        conn1.Close()
        DataGridView1.AutoResizeColumns(DataGridViewAutoSizeColumnMode.AllCells)
        '------------------------------------------------------------------------------
        For i = 0 To DataGridView1.Rows.Count - 1 Step 2
            DataGridView1.Rows(i).DefaultCellStyle.BackColor = Color.LemonChiffon
            '------------------------------------------------------------------------------
        Next
        Exit Sub
HATA:
        DevExpress.XtraEditors.XtraMessageBox.Show("Silme İşleminde Hata, Lütfen Kontrol Ediniz...")
        Exit Sub
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        TextBox28.Text = DataGridView1.CurrentRow.Cells(0).Value.ToString
    End Sub

    Private Sub SimpleButton3_Click(sender As Object, e As EventArgs) Handles SimpleButton3.Click
        On Error GoTo HATA
        Dim conn1 As New SqlConnection
        Dim cmd1 As New SqlCommand
        Dim cmd2 As New SqlCommand
        Dim da As New SqlDataAdapter()
        Dim ds As New DataSet
        Dim cmd As New SqlCommand()
        Dim cnn As New SqlConnection()
        '-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
        conn1.ConnectionString = "server=10.3.11.61;database=ALANSIS;uid=sa;pwd=term.0907"
        conn1.Open()
        cmd1.Connection = conn1
        cmd1.CommandText = "DELETE FROM EO_ALANSIS_GGN_YUKLEME WHERE ID= '" & TextBox29.Text & "'"
        cmd1.ExecuteNonQuery()
        conn1.Close()
        '--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
        DevExpress.XtraEditors.XtraMessageBox.Show("Silme İşlemi Tamamlanmiştir...")
        '===========================================================================================================================
        conn1.Open()
        cmd.Connection = conn1
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "SELECT* FROM EO_ALANSIS_GGN_YUKLEME ORDER BY ID DESC"
        da.SelectCommand = cmd
        DataGridView2.ClearSelection()
        da.Fill(ds)
        DataGridView2.DataSource = ds.Tables(0).DefaultView
        DataGridView2.AutoResizeColumns(DataGridViewAutoSizeColumnMode.AllCells)
        conn1.Close()
        DataGridView2.AutoResizeColumns(DataGridViewAutoSizeColumnMode.AllCells)
        '------------------------------------------------------------------------------
        For i = 0 To DataGridView2.Rows.Count - 1 Step 2
            DataGridView2.Rows(i).DefaultCellStyle.BackColor = Color.LemonChiffon
            '------------------------------------------------------------------------------
        Next
        Exit Sub
HATA:
        DevExpress.XtraEditors.XtraMessageBox.Show("Silme İşleminde Hata, Lütfen Kontrol Ediniz...")
        Exit Sub
    End Sub

    Private Sub SimpleButton5_Click(sender As Object, e As EventArgs) Handles SimpleButton5.Click
        On Error GoTo HATA
        Dim conn1 As New SqlConnection
        Dim cmd1 As New SqlCommand
        Dim cmd2 As New SqlCommand
        Dim da As New SqlDataAdapter()
        Dim ds As New DataSet
        Dim cmd As New SqlCommand()
        Dim cnn As New SqlConnection()
        '-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
        conn1.ConnectionString = "server=10.3.11.61;database=ALANSIS;uid=sa;pwd=term.0907"
        conn1.Open()
        cmd1.Connection = conn1
        cmd1.CommandText = "DELETE FROM EO_ALANSIS_GGN_KAPASITE WHERE ID= '" & TextBox30.Text & "'"
        cmd1.ExecuteNonQuery()
        conn1.Close()
        '--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
        DevExpress.XtraEditors.XtraMessageBox.Show("Silme İşlemi Tamamlanmiştir...")
        '===========================================================================================================================
        conn1.Open()
        cmd.Connection = conn1
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "SELECT* FROM EO_ALANSIS_GGN_KAPASITE ORDER BY ID DESC"
        da.SelectCommand = cmd
        DataGridView3.ClearSelection()
        da.Fill(ds)
        DataGridView3.DataSource = ds.Tables(0).DefaultView
        DataGridView3.AutoResizeColumns(DataGridViewAutoSizeColumnMode.AllCells)
        conn1.Close()
        DataGridView3.AutoResizeColumns(DataGridViewAutoSizeColumnMode.AllCells)
        '------------------------------------------------------------------------------
        For i = 0 To DataGridView3.Rows.Count - 1 Step 2
            DataGridView3.Rows(i).DefaultCellStyle.BackColor = Color.LemonChiffon
            '------------------------------------------------------------------------------
        Next
        Exit Sub
HATA:
        DevExpress.XtraEditors.XtraMessageBox.Show("Silme İşleminde Hata, Lütfen Kontrol Ediniz...")
        Exit Sub
    End Sub

    Private Sub DataGridView2_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView2.CellContentClick
        TextBox29.Text = DataGridView2.CurrentRow.Cells(0).Value.ToString
    End Sub

    Private Sub DataGridView3_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView3.CellContentClick
        TextBox30.Text = DataGridView3.CurrentRow.Cells(0).Value.ToString
    End Sub

    Private Sub XtraTabControl1_Click(sender As Object, e As EventArgs) Handles XtraTabControl1.Click

    End Sub

    Private Sub Form116_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: Bu kod satırı 'ALANSISDataSet11.EO_ALANSIS_SATIS' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
        Me.EO_ALANSIS_SATISTableAdapter.Fill(Me.ALANSISDataSet11.EO_ALANSIS_SATIS)

    End Sub

    Private Sub XtraTabPage3_Paint(sender As Object, e As PaintEventArgs) Handles XtraTabPage3.Paint

    End Sub
End Class