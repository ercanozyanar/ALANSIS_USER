Imports System.Data.SqlClient
Imports System.Data
Imports System.Net.Sockets
Public Class Form157
    Dim SqlConnStr As String = "server=10.3.11.61;database=ALANSIS;uid=sa;pwd=term.0907;"
    Dim SqlConn As New System.Data.SqlClient.SqlConnection(SqlConnStr)
    Dim cmd As New SqlCommand()
    Dim cnn As New SqlConnection()
    Dim da As New SqlDataAdapter()
    Dim ds As New DataSet
    Dim i As Integer
    Private Sub RadioButton1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton1.CheckedChanged
        TextBox4.Text = "ALASEHIR"
        ComboBox1.Items.Clear()

        '---------------------------------------------------------------------------------------
        Dim cnn1 As New SqlConnection()
        cnn1.ConnectionString = "server=10.3.11.61;database=ALANSIS;uid=sa;pwd=term.0907"
        cnn1.Open()
        Dim mySelectQuery1 As String = "SELECT SARF_ADI FROM EO_ALANSIS_DEPO_SARFHAR GROUP BY SARF_ADI"
        Dim SqlComm1 As New System.Data.SqlClient.SqlCommand(mySelectQuery1, cnn1)
        Dim reader1 As System.Data.SqlClient.SqlDataReader
        reader1 = SqlComm1.ExecuteReader()
        While reader1.Read()
            ComboBox1.Items.Add(reader1("SARF_ADI"))
        End While
        reader1.Close()
        cnn1.Close()
        '===========================================================================================================================================================================================================
        Dim connectionString As String = "server=10.3.11.61;database=ALANSIS;uid=sa;pwd=term.0907"
        Dim sql As String = "SELECT TARIH,[NO] AS HAREKET_NO,SARF_ADI,(CASE HAREKET_KODU WHEN 'C' THEN 'CIKIS' WHEN 'G' THEN 'GIRIS' END) AS HAREKET_TIPI,MIKTAR,BOLGE,DEPO_KODU FROM EO_ALANSIS_DEPO_SARFHAR WHERE SUBE='" & TextBox4.Text & "' ORDER BY ID ASC"
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
    End Sub

    Private Sub RadioButton2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton2.CheckedChanged
        TextBox4.Text = "BURSA"
        ComboBox1.Items.Clear()
        '---------------------------------------------------------------------------------------
        Dim cnn1 As New SqlConnection()
        cnn1.ConnectionString = "server=10.3.11.61;database=ALANSIS;uid=sa;pwd=term.0907"
        cnn1.Open()
        Dim mySelectQuery1 As String = "SELECT SARF_ADI FROM EO_ALANSIS_DEPO_SARFHAR GROUP BY SARF_ADI"
        Dim SqlComm1 As New System.Data.SqlClient.SqlCommand(mySelectQuery1, cnn1)
        Dim reader1 As System.Data.SqlClient.SqlDataReader
        reader1 = SqlComm1.ExecuteReader()
        While reader1.Read()
            ComboBox1.Items.Add(reader1("sarf_adi"))
        End While
        reader1.Close()
        cnn1.Close()
        '-----------------------------------------------------------------------------------------
        '===========================================================================================================================================================================================================
        Dim connectionString As String = "server=10.3.11.61;database=ALANSIS;uid=sa;pwd=term.0907"
        Dim sql As String = "SELECT TARIH,[NO] AS HAREKET_NO,SARF_ADI,(CASE HAREKET_KODU WHEN 'C' THEN 'CIKIS' WHEN 'G' THEN 'GIRIS' END) AS HAREKET_TIPI,MIKTAR,BOLGE,DEPO_KODU FROM EO_ALANSIS_DEPO_SARFHAR WHERE SUBE='" & TextBox4.Text & "'  ORDER BY ID ASC"
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

    End Sub

    Private Sub RadioButton3_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton3.CheckedChanged
        TextBox4.Text = "ALTAN"
        ComboBox1.Items.Clear()
        '---------------------------------------------------------------------------------------
        Dim cnn1 As New SqlConnection()
        cnn1.ConnectionString = "server=10.3.11.61;database=ALANSIS;uid=sa;pwd=term.0907"
        cnn1.Open()
        Dim mySelectQuery1 As String = "SELECT SARF_ADI FROM EO_ALANSIS_DEPO_SARFHAR GROUP BY SARF_ADI"
        Dim SqlComm1 As New System.Data.SqlClient.SqlCommand(mySelectQuery1, cnn1)
        Dim reader1 As System.Data.SqlClient.SqlDataReader
        reader1 = SqlComm1.ExecuteReader()
        While reader1.Read()
            ComboBox1.Items.Add(reader1("sarf_adi"))
        End While
        reader1.Close()
        cnn1.Close()
        '-----------------------------------------------------------------------------------------
        '===========================================================================================================================================================================================================
        Dim connectionString As String = "server=10.3.11.61;database=ALANSIS;uid=sa;pwd=term.0907"
        Dim sql As String = "SELECT TARIH,[NO] AS HAREKET_NO,SARF_ADI,(CASE HAREKET_KODU WHEN 'C' THEN 'CIKIS' WHEN 'G' THEN 'GIRIS' END) AS HAREKET_TIPI,MIKTAR,BOLGE,DEPO_KODU FROM EO_ALANSIS_DEPO_SARFHAR WHERE SUBE='" & TextBox4.Text & "'  ORDER BY ID ASC"
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

    End Sub

    Private Sub RadioButton4_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton4.CheckedChanged
        TextBox4.Text = "MALATYA"
        ComboBox1.Items.Clear()
        '---------------------------------------------------------------------------------------
        Dim cnn1 As New SqlConnection()
        cnn1.ConnectionString = "server=10.3.11.61;database=ALANSIS;uid=sa;pwd=term.0907"
        cnn1.Open()
        Dim mySelectQuery1 As String = "SELECT SARF_ADI FROM EO_ALANSIS_DEPO_SARFHAR GROUP BY SARF_ADI"
        Dim SqlComm1 As New System.Data.SqlClient.SqlCommand(mySelectQuery1, cnn1)
        Dim reader1 As System.Data.SqlClient.SqlDataReader
        reader1 = SqlComm1.ExecuteReader()
        While reader1.Read()
            ComboBox1.Items.Add(reader1("sarf_adi"))
        End While
        reader1.Close()
        cnn1.Close()
        '-----------------------------------------------------------------------------------------
        '===========================================================================================================================================================================================================
        Dim connectionString As String = "server=10.3.11.61;database=ALANSIS;uid=sa;pwd=term.0907"
        Dim sql As String = "SELECT TARIH,[NO] AS HAREKET_NO,SARF_ADI,(CASE HAREKET_KODU WHEN 'C' THEN 'CIKIS' WHEN 'G' THEN 'GIRIS' END) AS HAREKET_TIPI,MIKTAR,BOLGE,DEPO_KODU FROM EO_ALANSIS_DEPO_SARFHAR WHERE SUBE='" & TextBox4.Text & "' ORDER BY ID ASC"
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

    End Sub

    Private Sub RadioButton5_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton5.CheckedChanged
        TextBox4.Text = "CANAKKALE"
        ComboBox1.Items.Clear()
        '---------------------------------------------------------------------------------------
        Dim cnn1 As New SqlConnection()
        cnn1.ConnectionString = "server=10.3.11.61;database=ALANSIS;uid=sa;pwd=term.0907"
        cnn1.Open()
        Dim mySelectQuery1 As String = "SELECT SARF_ADI FROM EO_ALANSIS_DEPO_SARFHAR GROUP BY SARF_ADI"
        Dim SqlComm1 As New System.Data.SqlClient.SqlCommand(mySelectQuery1, cnn1)
        Dim reader1 As System.Data.SqlClient.SqlDataReader
        reader1 = SqlComm1.ExecuteReader()
        While reader1.Read()
            ComboBox1.Items.Add(reader1("sarf_adi"))
        End While
        reader1.Close()
        cnn1.Close()
        '-----------------------------------------------------------------------------------------
        '===========================================================================================================================================================================================================
        Dim connectionString As String = "server=10.3.11.61;database=ALANSIS;uid=sa;pwd=term.0907"
        Dim sql As String = "SELECT TARIH,[NO] AS HAREKET_NO,SARF_ADI,(CASE HAREKET_KODU WHEN 'C' THEN 'CIKIS' WHEN 'G' THEN 'GIRIS' END) AS HAREKET_TIPI,MIKTAR,BOLGE,DEPO_KODU FROM EO_ALANSIS_DEPO_SARFHAR WHERE SUBE='" & TextBox4.Text & "'  ORDER BY ID ASC"
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

    End Sub
    Private Sub RadioButton6_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton6.CheckedChanged
        TextBox4.Text = "KONYA"
        ComboBox1.Items.Clear()
        '---------------------------------------------------------------------------------------
        Dim cnn1 As New SqlConnection()
        cnn1.ConnectionString = "server=10.3.11.61;database=ALANSIS;uid=sa;pwd=term.0907"
        cnn1.Open()
        Dim mySelectQuery1 As String = "SELECT SARF_ADI FROM EO_ALANSIS_DEPO_SARFHAR GROUP BY SARF_ADI"
        Dim SqlComm1 As New System.Data.SqlClient.SqlCommand(mySelectQuery1, cnn1)
        Dim reader1 As System.Data.SqlClient.SqlDataReader
        reader1 = SqlComm1.ExecuteReader()
        While reader1.Read()
            ComboBox1.Items.Add(reader1("sarf_adi"))
        End While
        reader1.Close()
        cnn1.Close()
        '-----------------------------------------------------------------------------------------
        '===========================================================================================================================================================================================================
        Dim connectionString As String = "server=10.3.11.61;database=ALANSIS;uid=sa;pwd=term.0907"
        Dim sql As String = "SELECT TARIH,[NO] AS HAREKET_NO,SARF_ADI,(CASE HAREKET_KODU WHEN 'C' THEN 'CIKIS' WHEN 'G' THEN 'GIRIS' END) AS HAREKET_TIPI,MIKTAR,BOLGE,DEPO_KODU FROM EO_ALANSIS_DEPO_SARFHAR WHERE SUBE='" & TextBox4.Text & "'  ORDER BY ID ASC"
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

    End Sub
    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        Dim conn1, cnn As New SqlConnection
        Dim cmd1, cmd As New SqlCommand
        Dim da As New SqlDataAdapter()
        ' Dim ds As New DataSet
        Dim result As DialogResult = MessageBox.Show("Sayım Girişi için emin misiniz...?", "Alansis Sayım Girişi", MessageBoxButtons.YesNo)
        Dim hareket_kodu, numara1
        Dim numara As Double
        Dim sayim, bakiye, deger As Integer
        sayim = 0
        bakiye = 0
        deger = 0
        If result = DialogResult.No Then
            Exit Sub
        ElseIf result = DialogResult.Yes Then
            sayim = InputBox("Sayım Girişi")
            bakiye = TextEdit3.Text
            deger = sayim - bakiye
            If deger < 0 Then
                hareket_kodu = "C"
            End If
            If deger > 0 Then
                hareket_kodu = "G"
            End If
            conn1.ConnectionString = "server=10.3.11.61;database=ALANSIS;uid=sa;pwd=term.0907"
            '-----------------------------------------------------------------------------------------
            conn1.Open()
            Dim mySelectQuery1 As String = "SELECT MAX(ID) AS ID FROM EO_ALANSIS_DEPO_SARFHAR;"
            Dim SqlComm1 As New System.Data.SqlClient.SqlCommand(mySelectQuery1, conn1)
            Dim reader1 As System.Data.SqlClient.SqlDataReader
            reader1 = SqlComm1.ExecuteReader()
            While reader1.Read()
                numara = reader1("ID")
            End While
            reader1.Close()
            conn1.Close()
            numara1 = "SAYIM"
            '---------------------------------------------------------------------------------------------------------------
            If hareket_kodu = "C" Then
                deger = deger * -1
            End If
            '---------------------------------------------------------------------------------------------------------------
            conn1.Open()
            cmd1.Connection = conn1
            cmd1.CommandText = "INSERT INTO EO_ALANSIS_DEPO_SARFHAR (TARIH,NO, SARF_ADI, TIP, MIKTAR, HAREKET_KODU,SUBE,DEPO_KODU) VALUES ('" & DateTime.Now & "', '" & numara1 & "','" & ComboBox1.Text & "', 'SAYIM','" & deger & "'  ,'" & hareket_kodu & "','" & TextBox4.Text & "','" & TextBox6.Text & "')"
            cmd1.ExecuteNonQuery()
            '--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
            conn1.Close()
            '===========================================================================================================================================================================================================
            Dim connectionString As String = "server=10.3.11.61;database=ALANSIS;uid=sa;pwd=term.0907"
            Dim sql As String = "SELECT TARIH,[NO] AS HAREKET_NO,SARF_ADI,(CASE HAREKET_KODU WHEN 'C' THEN 'CIKIS' WHEN 'G' THEN 'GIRIS' END) AS HAREKET_TIPI,MIKTAR,BOLGE FROM EO_ALANSIS_DEPO_SARFHAR WHERE SARF_ADI='" & ComboBox1.Text & "' AND SUBE='" & TextBox4.Text & "' ORDER BY ID ASC"
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
            '---------------------------------------------------------------------------------------------------
            'Try
            cnn.ConnectionString = "server=10.3.11.61;database=ALANSIS;uid=sa;pwd=term.0907"
            '    cnn.Open()
            '    cmd.Connection = cnn
            '    cmd.CommandType = CommandType.Text
            '    cmd.CommandText = "SELECT TARIH,[NO] AS HAREKET_NO,SARF_ADI,(CASE HAREKET_KODU WHEN 'C' THEN 'CIKIS' WHEN 'G' THEN 'GIRIS' END) AS HAREKET_TIPI,MIKTAR,BOLGE FROM EO_ALANSIS_DEPO_SARFHAR WHERE SARF_ADI='" & ComboBox1.Text & "' AND SUBE='" & TextBox4.Text & "' ORDER BY ID ASC"
            '    da.SelectCommand = cmd
            '    da.Fill(ds)
            '    DataGridView1.DataSource = ds.Tables(0).DefaultView
            '    DataGridView1.Columns(0).Width = 150
            '    DataGridView1.Columns(1).Width = 100
            '    DataGridView1.Columns(2).Width = 500
            '    DataGridView1.Columns(3).Width = 100
            '    DataGridView1.Columns(4).Width = 100
            '    DataGridView1.Columns(5).Width = 170
            'Catch ex As Exception
            '    MessageBox.Show(ex.Message)
            'End Try
            'cnn.Close()
            ''---------------------------------------------------------------------------------------------------------------
            'cnn.Open()
            'Dim mySelectQuery6 As String = "SELECT* FROM EO_ALANSIS_SARFHAR_TGIR WHERE SARF_ADI= '" & ComboBox1.Text & "' AND SUBE='" & TextBox4.Text & "';"
            'Dim SqlComm6 As New System.Data.SqlClient.SqlCommand(mySelectQuery6, cnn)
            'Dim reader6 = SqlComm6.ExecuteReader()
            'While reader6.Read()
            '    TextEdit1.Text = reader6("TGIRIS").ToString()
            'End While
            'If TextEdit1.Text = "" Then
            '    TextEdit1.Text = "0"
            'End If
            'reader6.Close()
            'cnn.Close()
            ''---------------------------------------------------------------------------------------------------------------
            'cnn.Open()
            'Dim mySelectQuery7 As String = "SELECT* FROM EO_ALANSIS_SARFHAR_TCIK WHERE SARF_ADI= '" & ComboBox1.Text & "' AND SUBE='" & TextBox4.Text & "';"
            'Dim SqlComm7 As New System.Data.SqlClient.SqlCommand(mySelectQuery7, cnn)
            'Dim reader7 = SqlComm7.ExecuteReader()
            'While reader7.Read()
            '    TextEdit2.Text = reader7("TCIKIS").ToString()
            'End While
            'If TextEdit2.Text = "" Then
            '    TextEdit2.Text = "0"
            'End If
            'reader7.Close()
            'cnn.Close()

            '---------------------------------------------------------------------------------------------------------------
            cnn.Open()
            Dim mySelectQuery6 As String = "SELECT* FROM EO_ALANSIS_SARFHAR_TGIR WHERE SARF_ADI= '" & ComboBox1.Text & "' AND SUBE='" & TextBox4.Text & "';"
            Dim SqlComm6 As New System.Data.SqlClient.SqlCommand(mySelectQuery6, cnn)
            Dim reader6 = SqlComm6.ExecuteReader()
            While reader6.Read()
                TextEdit1.Text = reader6("TGIRIS").ToString()
            End While
            If TextEdit1.Text = "" Then
                TextEdit1.Text = "0"
            End If
            reader6.Close()
            cnn.Close()
            '---------------------------------------------------------------------------------------------------------------
            cnn.Open()
            Dim mySelectQuery7 As String = "SELECT* FROM EO_ALANSIS_SARFHAR_TCIK WHERE SARF_ADI= '" & ComboBox1.Text & "' AND SUBE='" & TextBox4.Text & "';"
            Dim SqlComm7 As New System.Data.SqlClient.SqlCommand(mySelectQuery7, cnn)
            Dim reader7 = SqlComm7.ExecuteReader()
            While reader7.Read()
                TextEdit2.Text = reader7("TCIKIS").ToString()
            End While
            If TextEdit2.Text = "" Then
                TextEdit2.Text = "0"
            End If
            reader7.Close()
            cnn.Close()
            '--------------------------------------------------------------------------------------------------------
            TextEdit3.Text = TextEdit1.Text - TextEdit2.Text
            MsgBox("İslem Tamamlandı...")
        End If
    End Sub

    Private Sub SimpleButton2_Click(sender As Object, e As EventArgs) Handles SimpleButton2.Click
        Dim conn1 As New SqlConnection
        Dim cmd1 As New SqlCommand
        Dim cmd As New SqlCommand()
        Dim cnn As New SqlConnection()
        Dim da As New SqlDataAdapter()
        Dim ds As New DataSet
        Dim numara, datnumara
        Dim dat_miktar As Integer
        Dim result As DialogResult = MessageBox.Show("DAT Girişi için emin misiniz...?", "Alansis DAT Girişi", MessageBoxButtons.YesNo)
        numara = ""
        datnumara = ""
        dat_miktar = 0
        If result = DialogResult.No Then
            Exit Sub
        ElseIf result = DialogResult.Yes Then
            dat_miktar = InputBox("DAT Miktar Girişi")
            SqlConn.Open()
            Dim mySelectQuery9 As String = "SELECT MAX(ID) AS ID FROM EO_ALANSIS_DEPO_SARFHAR;"
            Dim SqlComm9 As New System.Data.SqlClient.SqlCommand(mySelectQuery9, SqlConn)
            Dim reader9 As System.Data.SqlClient.SqlDataReader
            reader9 = SqlComm9.ExecuteReader()
            While reader9.Read()
                numara = (reader9("ID"))
            End While
            datnumara = "DAT2022" & numara
            reader9.Close()
            SqlConn.Close()
            '---------------------------------------------------------------------------------------------------------------
            conn1.ConnectionString = "server=10.3.11.61;database=ALANSIS;uid=sa;pwd=term.0907"
            cnn.ConnectionString = "server=10.3.11.61;database=ALANSIS;uid=sa;pwd=term.0907"
            '--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
            conn1.Open()
            cmd1.Connection = conn1
            cmd1.CommandText = "INSERT INTO EO_ALANSIS_DEPO_SARFHAR (TARIH,NO, SARF_ADI, TIP, MIKTAR, HAREKET_KODU,SUBE,DEPO_KODU) VALUES ('" & DateTime.Now & "', '" & datnumara & "','" & ComboBox1.Text & "', 'DAT','" & dat_miktar & "'  ,'C','" & TextBox7.Text & "','" & TextBox5.Text & "')"
            cmd1.ExecuteNonQuery()
            conn1.Close()
            conn1.Open()
            cmd1.Connection = conn1
            cmd1.CommandText = "INSERT INTO EO_ALANSIS_DEPO_SARFHAR (TARIH,NO, SARF_ADI, TIP, MIKTAR, HAREKET_KODU,SUBE,DEPO_KODU) VALUES ('" & DateTime.Now & "', '" & datnumara & "','" & ComboBox1.Text & "', 'DAT','" & dat_miktar & "'  ,'G','" & TextBox8.Text & "','" & TextBox6.Text & "')"
            cmd1.ExecuteNonQuery()
            conn1.Close()
            '---------------------------------------------------------------------------------------------------
            MsgBox("İslem Tamamlandı...")
            ComboBox1.Items.Clear()
            TextEdit1.Text = ""
            TextEdit1.Text = ""
            '---------------------------------------------------------------------------------------------------------------
            numara = ""
            datnumara = ""
            Dim connectionString1 As String = "server=10.3.11.61;database=ALANSIS;uid=sa;pwd=term.0907"
            Dim sql1 As String = "SELECT TARIH,[NO] AS HAREKET_NO,SARF_ADI,(CASE HAREKET_KODU WHEN 'C' THEN 'CIKIS' WHEN 'G' THEN 'GIRIS' END) AS HAREKET_TIPI,MIKTAR,BOLGE FROM EO_ALANSIS_DEPO_SARFHAR WHERE SARF_ADI='" & ComboBox1.Text & "' AND SUBE='" & TextBox4.Text & "' ORDER BY ID ASC"
            Dim connection1 As New SqlConnection(connectionString1)
            Dim dataadapter1 As New SqlDataAdapter(sql1, connection1)
            Dim ds1 As New DataSet()
            connection1.Open()
            dataadapter1.Fill(ds1, "Firma")
            connection1.Close()
            GridControl1.DataSource = ds1
            GridControl1.DataMember = "Firma"
            GridView1.OptionsView.ColumnAutoWidth = False
            GridView1.OptionsView.BestFitMaxRowCount = -1
            GridView1.BestFitColumns()
            '---------------------------------------------------------------------------------------------------------------
            cnn.Open()
            Dim mySelectQuery6 As String = "SELECT* FROM EO_ALANSIS_SARFHAR_TGIR WHERE SARF_ADI= '" & ComboBox1.Text & "' AND SUBE='" & TextBox4.Text & "';"
            Dim SqlComm6 As New System.Data.SqlClient.SqlCommand(mySelectQuery6, cnn)
            Dim reader6 = SqlComm6.ExecuteReader()
            While reader6.Read()
                TextEdit1.Text = reader6("TGIRIS").ToString()
            End While
            If TextEdit1.Text = "" Then
                TextEdit1.Text = "0"
            End If
            reader6.Close()
            cnn.Close()
            '---------------------------------------------------------------------------------------------------------------
            cnn.Open()
            Dim mySelectQuery7 As String = "SELECT* FROM EO_ALANSIS_SARFHAR_TCIK WHERE SARF_ADI= '" & ComboBox1.Text & "' AND SUBE='" & TextBox4.Text & "';"
            Dim SqlComm7 As New System.Data.SqlClient.SqlCommand(mySelectQuery7, cnn)
            Dim reader7 = SqlComm7.ExecuteReader()
            While reader7.Read()
                TextEdit2.Text = reader7("TCIKIS").ToString()
            End While
            If TextEdit2.Text = "" Then
                TextEdit2.Text = "0"
            End If
            reader7.Close()
            cnn.Close()
            '--------------------------------------------------------------------------------------------------------
            '---------------------------------------------------------------------------------------------------------------
            TextEdit3.Text = TextEdit1.Text - TextEdit2.Text
        End If
    End Sub
    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged
        Dim cmd As New SqlCommand()
        Dim cnn As New SqlConnection()
        Dim da As New SqlDataAdapter()
        'Dim ds As New DataSet
        TextEdit1.Text = ""
        TextEdit2.Text = ""
        TextEdit3.Text = ""
        cnn.ConnectionString = "server=10.3.11.61;database=ALANSIS;uid=sa;pwd=term.0907"
        '===========================================================================================================================================================================================================
        Dim connectionString1 As String = "server=10.3.11.61;database=ALANSIS;uid=sa;pwd=term.0907"
        Dim sql1 As String = "SELECT TARIH,[NO] AS HAREKET_NO,SARF_ADI,(CASE HAREKET_KODU WHEN 'C' THEN 'CIKIS' WHEN 'G' THEN 'GIRIS' END) AS HAREKET_TIPI,MIKTAR,BOLGE FROM EO_ALANSIS_DEPO_SARFHAR WHERE SARF_ADI='" & ComboBox1.Text & "' AND SUBE='" & TextBox4.Text & "' ORDER BY ID ASC"
        Dim connection1 As New SqlConnection(connectionString1)
        Dim dataadapter1 As New SqlDataAdapter(sql1, connection1)
        Dim ds1 As New DataSet()
        connection1.Open()
        dataadapter1.Fill(ds1, "Firma")
        connection1.Close()
        GridControl1.DataSource = ds1
        GridControl1.DataMember = "Firma"
        GridView1.OptionsView.ColumnAutoWidth = False
        GridView1.OptionsView.BestFitMaxRowCount = -1
        GridView1.BestFitColumns()
        '---------------------------------------------------------------------------------------------------------------
        cnn.Open()
        Dim mySelectQuery6 As String = "SELECT* FROM EO_ALANSIS_SARFHAR_TGIR WHERE SARF_ADI= '" & ComboBox1.Text & "' AND SUBE='" & TextBox4.Text & "';"
        Dim SqlComm6 As New System.Data.SqlClient.SqlCommand(mySelectQuery6, cnn)
        Dim reader6 = SqlComm6.ExecuteReader()
        While reader6.Read()
            TextEdit1.Text = reader6("TGIRIS").ToString()
        End While
        If TextEdit1.Text = "" Then
            TextEdit1.Text = "0"
        End If
        reader6.Close()
        cnn.Close()
        '---------------------------------------------------------------------------------------------------------------
        cnn.Open()
        Dim mySelectQuery7 As String = "SELECT* FROM EO_ALANSIS_SARFHAR_TCIK WHERE SARF_ADI= '" & ComboBox1.Text & "' AND SUBE='" & TextBox4.Text & "';"
        Dim SqlComm7 As New System.Data.SqlClient.SqlCommand(mySelectQuery7, cnn)
        Dim reader7 = SqlComm7.ExecuteReader()
        While reader7.Read()
            TextEdit2.Text = reader7("TCIKIS").ToString()
        End While
        If TextEdit2.Text = "" Then
            TextEdit2.Text = "0"
        End If
        reader7.Close()
        cnn.Close()
        '--------------------------------------------------------------------------------------------------------
        TextEdit3.Text = TextEdit1.Text - TextEdit2.Text

    End Sub

    Private Sub Form157_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        '===========================================================================================================================================================================================================
        Dim connectionString As String = "server=10.3.11.61;database=ALANSIS;uid=sa;pwd=term.0907"
        Dim sql As String = "SELECT* FROM EO_ALANSIS_SARFHAR_BAK"
        Dim connection As New SqlConnection(connectionString)
        Dim dataadapter As New SqlDataAdapter(sql, connection)
        Dim ds As New DataSet()
        connection.Open()
        dataadapter.Fill(ds, "Firma")
        connection.Close()
        GridControl2.DataSource = ds
        GridControl2.DataMember = "Firma"
        GridView2.OptionsView.ColumnAutoWidth = False
        GridView2.OptionsView.BestFitMaxRowCount = -1
        GridView2.BestFitColumns()
    End Sub

    Private Sub ComboBoxEdit1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxEdit1.SelectedIndexChanged
        TextBox3.Text = Mid(ComboBoxEdit1.Text, 1, 2)
        '===========================================================================================================================================================================================================
        Dim connectionString As String = "server=10.3.11.61;database=ALANSIS;uid=sa;pwd=term.0907"
        Dim sql As String = "SELECT TARIH,[NO] AS HAREKET_NO,SARF_ADI,(CASE HAREKET_KODU WHEN 'C' THEN 'CIKIS' WHEN 'G' THEN 'GIRIS' END) AS HAREKET_TIPI,MIKTAR,BOLGE,DEPO_KODU FROM EO_ALANSIS_DEPO_SARFHAR WHERE SUBE='" & TextBox4.Text & "' ORDER BY ID ASC"
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
    End Sub

    Private Sub ComboBoxEdit2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxEdit2.SelectedIndexChanged
        TextBox5.Text = Mid(ComboBoxEdit2.Text, 1, 2)
    End Sub

    Private Sub ComboBoxEdit3_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub SimpleButton3_Click(sender As Object, e As EventArgs) Handles SimpleButton3.Click
        Dim path As String = "SARF_HARAKET_RAPOR.xlsx"

        ' PivotGridControl2.ExportToXlsx(path)

        GridControl1.ExportToXlsx(path)
        ' Open the created XLSX file with the default application.
        Process.Start(path)
    End Sub

    Private Sub SimpleButton4_Click(sender As Object, e As EventArgs) Handles SimpleButton4.Click
        Dim path As String = "SARF_RAPOR.xlsx"

        ' PivotGridControl2.ExportToXlsx(path)

        GridControl2.ExportToXlsx(path)
        ' Open the created XLSX file with the default application.
        Process.Start(path)
    End Sub

    Private Sub SimpleButton5_Click(sender As Object, e As EventArgs) Handles SimpleButton5.Click
        Dim conn1 As New SqlConnection
        Dim cmd1 As New SqlCommand
        Dim cmd As New SqlCommand()
        Dim cnn As New SqlConnection()
        Dim da As New SqlDataAdapter()
        Dim ds As New DataSet
        Dim numara, datnumara
        Dim dat_miktar As Integer
        Dim result As DialogResult = MessageBox.Show("Fire Girişi için emin misiniz...?", "Alansis FIRE Girişi", MessageBoxButtons.YesNo)
        numara = ""
        datnumara = ""
        dat_miktar = 0
        If result = DialogResult.No Then
            Exit Sub
        ElseIf result = DialogResult.Yes Then
            dat_miktar = InputBox("FIRE Miktar Girişi")
            SqlConn.Open()
            Dim mySelectQuery9 As String = "SELECT MAX(ID) AS ID FROM EO_ALANSIS_DEPO_SARFHAR;"
            Dim SqlComm9 As New System.Data.SqlClient.SqlCommand(mySelectQuery9, SqlConn)
            Dim reader9 As System.Data.SqlClient.SqlDataReader
            reader9 = SqlComm9.ExecuteReader()
            While reader9.Read()
                numara = (reader9("ID"))
            End While
            datnumara = "FIRE2022" & numara
            reader9.Close()
            SqlConn.Close()
            '---------------------------------------------------------------------------------------------------------------
            conn1.ConnectionString = "server=10.3.11.61;database=ALANSIS;uid=sa;pwd=term.0907"
            cnn.ConnectionString = "server=10.3.11.61;database=ALANSIS;uid=sa;pwd=term.0907"
            '--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
            conn1.Open()
            cmd1.Connection = conn1
            cmd1.CommandText = "INSERT INTO EO_ALANSIS_DEPO_SARFHAR (TARIH,NO, SARF_ADI, TIP, MIKTAR, HAREKET_KODU,SUBE,DEPO_KODU) VALUES ('" & DateTime.Now & "', '" & datnumara & "','" & ComboBox1.Text & "', 'FIRE','" & dat_miktar & "'  ,'C','" & TextBox7.Text & "','" & TextBox5.Text & "')"
            cmd1.ExecuteNonQuery()
            conn1.Close()
            '---------------------------------------------------------------------------------------------------
            MsgBox("İslem Tamamlandı...")
            ComboBox1.Items.Clear()
            TextEdit1.Text = ""
            TextEdit1.Text = ""
            '---------------------------------------------------------------------------------------------------------------
            numara = ""
            datnumara = ""
            Dim connectionString1 As String = "server=10.3.11.61;database=ALANSIS;uid=sa;pwd=term.0907"
            Dim sql1 As String = "SELECT TARIH,[NO] AS HAREKET_NO,SARF_ADI,(CASE HAREKET_KODU WHEN 'C' THEN 'CIKIS' WHEN 'G' THEN 'GIRIS' END) AS HAREKET_TIPI,MIKTAR,BOLGE FROM EO_ALANSIS_DEPO_SARFHAR WHERE SARF_ADI='" & ComboBox1.Text & "' AND SUBE='" & TextBox4.Text & "' ORDER BY ID ASC"
            Dim connection1 As New SqlConnection(connectionString1)
            Dim dataadapter1 As New SqlDataAdapter(sql1, connection1)
            Dim ds1 As New DataSet()
            connection1.Open()
            dataadapter1.Fill(ds1, "Firma")
            connection1.Close()
            GridControl1.DataSource = ds1
            GridControl1.DataMember = "Firma"
            GridView1.OptionsView.ColumnAutoWidth = False
            GridView1.OptionsView.BestFitMaxRowCount = -1
            GridView1.BestFitColumns()
            '---------------------------------------------------------------------------------------------------------------
            cnn.Open()
            Dim mySelectQuery6 As String = "SELECT* FROM EO_ALANSIS_SARFHAR_TGIR WHERE SARF_ADI= '" & ComboBox1.Text & "' AND SUBE='" & TextBox4.Text & "';"
            Dim SqlComm6 As New System.Data.SqlClient.SqlCommand(mySelectQuery6, cnn)
            Dim reader6 = SqlComm6.ExecuteReader()
            While reader6.Read()
                TextEdit1.Text = reader6("TGIRIS").ToString()
            End While
            If TextEdit1.Text = "" Then
                TextEdit1.Text = "0"
            End If
            reader6.Close()
            cnn.Close()
            '---------------------------------------------------------------------------------------------------------------
            cnn.Open()
            Dim mySelectQuery7 As String = "SELECT* FROM EO_ALANSIS_SARFHAR_TCIK WHERE SARF_ADI= '" & ComboBox1.Text & "' AND SUBE='" & TextBox4.Text & "';"
            Dim SqlComm7 As New System.Data.SqlClient.SqlCommand(mySelectQuery7, cnn)
            Dim reader7 = SqlComm7.ExecuteReader()
            While reader7.Read()
                TextEdit2.Text = reader7("TCIKIS").ToString()
            End While
            If TextEdit2.Text = "" Then
                TextEdit2.Text = "0"
            End If
            reader7.Close()
            cnn.Close()
            '--------------------------------------------------------------------------------------------------------
            '---------------------------------------------------------------------------------------------------------------
            TextEdit3.Text = TextEdit1.Text - TextEdit2.Text
        End If
    End Sub

    Private Sub TextBox5_TextChanged(sender As Object, e As EventArgs) Handles TextBox5.TextChanged
        If TextBox5.Text = "10" Then
            TextBox7.Text = "BURSA"
        End If
        If TextBox5.Text = "65" Then
            TextBox7.Text = "ALASEHIR"
        End If
        If TextBox5.Text = "75" Then
            TextBox7.Text = "ALTAN"
        End If
        If TextBox5.Text = "30" Then
            TextBox7.Text = "URETIM"
        End If
    End Sub

    Private Sub TextBox6_TextChanged(sender As Object, e As EventArgs) Handles TextBox6.TextChanged
        If TextBox6.Text = "10" Then
            TextBox8.Text = "BURSA"
        End If
        If TextBox6.Text = "65" Then
            TextBox8.Text = "ALASEHIR"
        End If
        If TextBox6.Text = "75" Then
            TextBox8.Text = "ALTAN"
        End If
        If TextBox6.Text = "30" Then
            TextBox8.Text = "URETIM"
        End If
    End Sub

    Private Sub ComboBoxEdit3_SelectedIndexChanged_1(sender As Object, e As EventArgs) Handles ComboBoxEdit3.SelectedIndexChanged
        TextBox6.Text = Mid(ComboBoxEdit3.Text, 1, 2)
    End Sub
End Class