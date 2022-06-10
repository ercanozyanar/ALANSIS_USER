Imports System.Data.SqlClient
Imports DevExpress.Compatibility
Imports DevExpress.Data
Imports DevExpress.XtraGrid.Columns
Imports System.Data
Imports System.Net.Sockets
Imports System.Net.Mail
Imports DevExpress.XtraEditors.Controls
Public Class Form252
    Dim SqlConnStr As String = "server=10.3.11.61;database=ALANSIS;uid=sa;pwd=term.0907;"
    Dim SqlConn As New System.Data.SqlClient.SqlConnection(SqlConnStr)
    Dim cmd As New SqlCommand()
    Dim cnn As New SqlConnection()
    Dim da As New SqlDataAdapter()
    Dim ds As New DataSet
    Dim SMTP As New SmtpClient("smtp.gmail.com")
    Dim Mail As New MailMessage
    Private Sub Form252_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Dim connectionString As String = "server=10.3.11.61;database=ALANSIS;uid=sa;pwd=term.0907"
            Dim sql As String = "SELECT* FROM EO_ALANSIS_SATIS_TALEP WHERE ONAY='NOK'"
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

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        Dim path As String = "ALANSIS_SATIS_TALEP_NOK.XLSX"
        GridControl1.ExportToXlsx(path)
        ' Open the created XLSX file with the default application.
        Process.Start(path)
    End Sub
End Class