Imports System.Data.SqlClient
Imports DevExpress.Compatibility
Imports DevExpress.Data
Imports DevExpress.XtraGrid.Columns
Imports System.Data
Imports System.Net.Sockets
Imports System.Net.Mail
Imports DevExpress.XtraEditors.Controls
Public Class Form251
    Dim SqlConnStr As String = "server=10.3.11.61;database=ALANSIS;uid=sa;pwd=term.0907;"
    Dim SqlConn As New System.Data.SqlClient.SqlConnection(SqlConnStr)
    Dim cmd As New SqlCommand()
    Dim cnn As New SqlConnection()
    Dim da As New SqlDataAdapter()
    Dim ds As New DataSet
    Dim SMTP As New SmtpClient("smtp.gmail.com")
    Dim Mail As New MailMessage
    Private Sub Form251_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Dim connectionString As String = "server=10.3.11.61;database=ALANSIS;uid=sa;pwd=term.0907"
            Dim sql As String = "SELECT* FROM EO_ALANSIS_SATIS_TALEP WHERE ONAY='BEKLEMEDE'"
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
        TextBox2.Text = Date.Now
        SimpleButton1.Enabled = False
        SimpleButton2.Enabled = False
        '=============================================================================================================================================================
        GridView1.OptionsSelection.MultiSelect = True
        GridView1.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect
    End Sub
    Private Sub GridControl1_KeyDown(sender As Object, e As KeyEventArgs) Handles GridControl1.KeyDown
        Dim listkontrol As Integer
        listkontrol = 0
        listkontrol = ListBox1.Items.Count
        ListBox1.Items.Clear()
        If (e.KeyCode = Keys.Tab) Then
            Dim ret As String = ""
            For Each i As Integer In GridView1.GetSelectedRows()
                Dim row As DataRow = GridView1.GetDataRow(i)
                If ret <> "" Then
                    ret &= ControlChars.CrLf
                End If
                ListBox1.Items.Add(row("ID"))
            Next i
        End If
        If listkontrol > 0 Then
            SimpleButton1.Enabled = True
            SimpleButton2.Enabled = True
        End If
        If listkontrol = 0 Then
            SimpleButton1.Enabled = False
            SimpleButton2.Enabled = False
        End If
    End Sub

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        On Error GoTo hata
        Dim conn1 As New SqlConnection
        Dim cmd1 As New SqlCommand
        Dim cmd2, cmd3 As New SqlCommand
        Dim listkontrol As Integer
        listkontrol = 0
        listkontrol = ListBox1.Items.Count
        If listkontrol > 0 Then
            For i As Integer = 0 To ListBox1.Items.Count - 1
                TextBox1.Text = ListBox1.Items(i)
                '---------------------------------------------------------------------------------------------------------------
                conn1.ConnectionString = "server=10.3.11.61;database=ALANSIS;uid=sa;pwd=term.0907"
                conn1.Open()
                cmd1.Connection = conn1
                cmd1.CommandText = "UPDATE EO_ALANSIS_SATIS_TALEP SET ONAY='OK',ACIKLAMA='" & MemoEdit1.Text & "',ONAY_TARIH='" & TextBox2.Text & "' WHERE ID='" & TextBox1.Text & "'"
                cmd1.ExecuteNonQuery()
                conn1.Close()
                '---------------------------------------------------------------------------------------------------------------
            Next
            DevExpress.XtraEditors.XtraMessageBox.Show("Seçili Talepler Onaylanmıştır...")
            SimpleButton1.Enabled = False
            SimpleButton2.Enabled = False
            '--------------------------------------------------------------------------------------------------------------------
            Dim connectionString As String = "server=10.3.11.61;database=ALANSIS;uid=sa;pwd=term.0907"
            Dim sql As String = "SELECT* FROM EO_ALANSIS_SATIS_TALEP WHERE ONAY='BEKLEMEDE'"
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
            '--------------------------------------------------------------------------------------------------------------------

            Exit Sub
        Else
            DevExpress.XtraEditors.XtraMessageBox.Show("Lütfen Kayıt Seçiniz...")
        End If
hata:
            DevExpress.XtraEditors.XtraMessageBox.Show("Kayit İşleminde hata, Lütfen kontrol ediniz......")
        Exit Sub
    End Sub
    Private Sub SimpleButton2_Click(sender As Object, e As EventArgs) Handles SimpleButton2.Click
        On Error GoTo hata
        Dim conn1 As New SqlConnection
        Dim cmd1 As New SqlCommand
        Dim cmd2, cmd3 As New SqlCommand
        Dim listkontrol As Integer
        listkontrol = 0
        listkontrol = ListBox1.Items.Count
        If listkontrol > 0 Then
            For i As Integer = 0 To ListBox1.Items.Count - 1
                TextBox1.Text = ListBox1.Items(i)
                '---------------------------------------------------------------------------------------------------------------
                conn1.ConnectionString = "server=10.3.11.61;database=ALANSIS;uid=sa;pwd=term.0907"
                conn1.Open()
                cmd1.Connection = conn1
                cmd1.CommandText = "UPDATE EO_ALANSIS_SATIS_TALEP SET ONAY='NOK',ACIKLAMA='" & MemoEdit1.Text & "',ONAY_TARIH='" & TextBox2.Text & "' WHERE ID='" & TextBox1.Text & "'"
                cmd1.ExecuteNonQuery()
                conn1.Close()
                '---------------------------------------------------------------------------------------------------------------
            Next
            DevExpress.XtraEditors.XtraMessageBox.Show("Seçili Talepler Onaylanmıştır...")
            SimpleButton1.Enabled = False
            SimpleButton2.Enabled = False
            '--------------------------------------------------------------------------------------------------------------------
            Dim connectionString As String = "server=10.3.11.61;database=ALANSIS;uid=sa;pwd=term.0907"
            Dim sql As String = "SELECT* FROM EO_ALANSIS_SATIS_TALEP WHERE ONAY='BEKLEMEDE'"
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
            '--------------------------------------------------------------------------------------------------------------------
            Exit Sub
        Else
            DevExpress.XtraEditors.XtraMessageBox.Show("Lütfen Kayıt Seçiniz...")
        End If
hata:
        DevExpress.XtraEditors.XtraMessageBox.Show("Kayit İşleminde hata, Lütfen kontrol ediniz......")
        Exit Sub
    End Sub

    Private Sub GridControl1_Click(sender As Object, e As EventArgs) Handles GridControl1.Click

    End Sub

    Private Sub TextEdit1_EditValueChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub TextEdit2_EditValueChanged(sender As Object, e As EventArgs) Handles TextEdit2.EditValueChanged
        Try
            Dim connectionString As String = "server=10.3.11.61;database=ALANSIS;uid=sa;pwd=term.0907"
            Dim sql As String = "SELECT* FROM EO_ALANSIS_SATIS_TALEP WHERE MUSTERI LIKE '%" & TextEdit2.Text & "%'"
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
    End Sub
End Class