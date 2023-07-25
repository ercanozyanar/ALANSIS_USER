Imports System.Data.SqlClient
Imports System.Data
Imports System.Net.Sockets
Public Class Form156
    Sub New()
        InitializeComponent()
        EO_ALANSIS_RECETETIKETIM_VWTableAdapter1.Fill(AlansısDataSet191.EO_ALANSIS_RECETETIKETIM_VW)
    End Sub
    Dim SqlConnStr As String = "server=10.3.11.61;database=ALANSIS;uid=sa;pwd=term.0907;"
    Dim SqlConn As New System.Data.SqlClient.SqlConnection(SqlConnStr)
    Dim cmd As New SqlCommand()
    Dim cnn As New SqlConnection()
    Dim da As New SqlDataAdapter()
    Dim ds As New DataSet
    Dim i As Integer
    Private Sub Form156_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        GridView1.OptionsSelection.MultiSelect = True
        GridView1.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect
        '=====================================================================================================
        DataGridView1.DataSource = ds
        ds.Clear()
        ds.Dispose()
        '---------------------------------------------------------------------------------------
        Dim cnn1 As New SqlConnection()
        cnn1.ConnectionString = "server=10.3.11.61;database=ALANSIS;uid=sa;pwd=term.0907"
        cnn1.Open()
        Dim mySelectQuery1 As String = "SELECT PARTI FROM EO_ALANSIS_RECETETUKETIM WHERE ISLEM='0' GROUP BY PARTI;"
        Dim SqlComm1 As New System.Data.SqlClient.SqlCommand(mySelectQuery1, cnn1)
        Dim reader1 As System.Data.SqlClient.SqlDataReader
        reader1 = SqlComm1.ExecuteReader()
        While reader1.Read()
            ComboBox1.Items.Add(reader1("PARTI"))
        End While
        reader1.Close()
        cnn1.Close()
        '-----------------------------------------------------------------------------------------
        Try
            cnn.ConnectionString = "server=10.3.11.61;database=ALANSIS;uid=sa;pwd=term.0907"
            cnn.Open()
            cmd.Connection = cnn
            cmd.CommandType = CommandType.Text
            cmd.CommandText = "SELECT TARIH,PARTI,RECETE,STOK_ADI,MIKTAR FROM EO_ALANSIS_RECETETUKETIM WHERE ISLEM='0'"
            da.SelectCommand = cmd
            DataGridView1.ClearSelection()
            da.Fill(ds)
            DataGridView1.DataSource = ds.Tables(0).DefaultView
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        cnn.Close()
        '------------------------------------------------------------------------------
        DataGridView1.AutoResizeColumns(DataGridViewAutoSizeColumnMode.AllCells)
        For i = 0 To DataGridView1.Rows.Count - 1 Step 2
            DataGridView1.Rows(i).DefaultCellStyle.BackColor = Color.LemonChiffon
        Next
        '------------------------------------------------------------------------------
    End Sub
    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        On Error Resume Next
        Dim conn1, conn2, conn3 As New SqlConnection
        Dim cmd1, cmd2, cmd3, cmd4, cmd5, cmd6, cmd7, cmd8, cmd9 As New SqlCommand
        Dim recetemiktar, recetefire, toptuketim, listkontrol As Decimal
        Dim sonmiktar As Integer
        Dim recetestok, sonstok, SRFSK As String
        '------------------------------------------------------------------------------------------------------------------------------
        conn1.ConnectionString = "server=10.3.11.61;database=ALANSIS;uid=sa;pwd=term.0907"
        conn3.ConnectionString = "server=10.3.11.61;database=ALANSIS;uid=sa;pwd=term.0907"
        '------------------------------------------------------------------------------------------------------------------------------
        ListBox1.Items.Clear()
        ListBox2.Items.Clear()
        Dim ret As String = ""
        For Each i As Integer In GridView1.GetSelectedRows()
            Dim row As DataRow = GridView1.GetDataRow(i)
            If ret <> "" Then
                ret &= ControlChars.CrLf
            End If
            recetemiktar = 0
            recetefire = 0
            toptuketim = 0
            recetestok = row("STOK_ADI")
            recetemiktar = row("MIKTAR")
            recetefire = row("FIRE")
            toptuketim = recetemiktar + recetefire
            ListBox1.Items.Add(row("STOK_ADI"))
            ListBox2.Items.Add(toptuketim)
        Next i
        listkontrol = ListBox1.Items.Count
        If listkontrol > 0 Then
            '-----------------------------------------------------------------------------------------
            For i As Integer = 0 To ListBox1.Items.Count - 1 And ListBox2.Items.Count - 1
                sonstok = ListBox1.Items(i)
                sonmiktar = ListBox2.Items(i)
                SRFSK = "SRFUSK" & Now.Year & Now.Month & Now.Day & Now.Hour & Now.Minute & Now.Second
                conn3.Open()
                cmd1.Connection = conn3
                cmd1.CommandText = "INSERT INTO EO_ALANSIS_DEPO_SARFHAR (TARIH,NO,SARF_ADI,TIP,MIKTAR,HAREKET_KODU,SUBE,DEPO_KODU) VALUES ('" & DateTime.Now & "','" & SRFSK & "', '" & sonstok & "','SARF', '" & Replace(sonmiktar, ",", ".") & "','C','ALASEHIR','30')"
                cmd1.ExecuteNonQuery()
                conn3.Close()
                '-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
            Next
        Else
            DevExpress.XtraEditors.XtraMessageBox.Show("Lütfen seçim yapınız..")
            Exit Sub
        End If
        conn3.Open()
        cmd1.Connection = conn3
        cmd1.CommandText = "UPDATE EO_ALANSIS_RECETETUKETIM SET ISLEM='1' WHERE PARTI='" & ComboBox1.Text & "' AND ISLEM='0' "
        cmd1.ExecuteNonQuery()
        conn3.Close()
        '=====================================================================================================
        DataGridView1.DataSource = ds
        ds.Clear()
        ds.Dispose()
        cnn.ConnectionString = "server=10.3.11.61;database=ALANSIS;uid=sa;pwd=term.0907"
        cnn.Open()
        cmd.Connection = cnn
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "SELECT TARIH,PARTI,RECETE,STOK_ADI,MIKTAR FROM EO_ALANSIS_RECETETUKETIM WHERE ISLEM='0'"
        da.SelectCommand = cmd
        DataGridView1.ClearSelection()
        da.Fill(ds)
        DataGridView1.DataSource = ds.Tables(0).DefaultView
        cnn.Close()
        '------------------------------------------------------------------------------
        DataGridView1.AutoResizeColumns(DataGridViewAutoSizeColumnMode.AllCells)
        For i = 0 To DataGridView1.Rows.Count - 1 Step 2
            DataGridView1.Rows(i).DefaultCellStyle.BackColor = Color.LemonChiffon
        Next
        '============================================================================================================================================================================================================================================================================================
        DevExpress.XtraEditors.XtraMessageBox.Show("İşlem Tamamlanmiştir...")
        Exit Sub
hata:
        DevExpress.XtraEditors.XtraMessageBox.Show("Kayit İşleminde Hata, Lütfen Kontrol Ediniz...")
        Exit Sub
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        GridView1.OptionsSelection.MultiSelect = True
        GridView1.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect
        '=====================================================================================================
        DataGridView1.DataSource = ds
        ds.Clear()
        ds.Dispose()
        '---------------------------------------------------------------------------------------
        Dim cnn1 As New SqlConnection()
        cnn1.ConnectionString = "server=10.3.11.61;database=ALANSIS;uid=sa;pwd=term.0907"
        'cnn1.Open()
        'Dim mySelectQuery1 As String = "SELECT PARTI FROM EO_ALANSIS_RECETETUKETIM WHERE ISLEM='0' GROUP BY PARTI;"
        'Dim SqlComm1 As New System.Data.SqlClient.SqlCommand(mySelectQuery1, cnn1)
        'Dim reader1 As System.Data.SqlClient.SqlDataReader
        'reader1 = SqlComm1.ExecuteReader()
        'While reader1.Read()
        '    ComboBox1.Items.Add(reader1("PARTI"))
        'End While
        'reader1.Close()
        'cnn1.Close()
        '-----------------------------------------------------------------------------------------
        Try
            cnn.ConnectionString = "server=10.3.11.61;database=ALANSIS;uid=sa;pwd=term.0907"
            cnn.Open()
            cmd.Connection = cnn
            cmd.CommandType = CommandType.Text
            cmd.CommandText = "SELECT TARIH,PARTI,RECETE,STOK_ADI,MIKTAR FROM EO_ALANSIS_RECETETUKETIM WHERE ISLEM='0' AND PARTI='" & ComboBox1.Text & "'"
            da.SelectCommand = cmd
            DataGridView1.ClearSelection()
            da.Fill(ds)
            DataGridView1.DataSource = ds.Tables(0).DefaultView
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        cnn.Close()
        '------------------------------------------------------------------------------
        DataGridView1.AutoResizeColumns(DataGridViewAutoSizeColumnMode.AllCells)
        For i = 0 To DataGridView1.Rows.Count - 1 Step 2
            DataGridView1.Rows(i).DefaultCellStyle.BackColor = Color.LemonChiffon
        Next
        '------------------------------------------------------------------------------
    End Sub

    Private Sub GridControl1_Click(sender As Object, e As EventArgs) Handles GridControl1.Click

    End Sub
End Class