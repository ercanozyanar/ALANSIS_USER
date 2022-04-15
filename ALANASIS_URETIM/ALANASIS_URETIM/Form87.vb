
Imports System.Data.SqlClient
Imports System.Data
Imports System.Net.Sockets
Imports Excel = Microsoft.Office.Interop.Excel
Imports iTextSharp.text
Imports iTextSharp.text.html
Imports iTextSharp.text.pdf
Imports iTextSharp.text.html.simpleparser
Imports iTextSharp.text.pdf.PdfPTable
Imports System.IO
Imports System.Reflection
Imports Microsoft.Office
Imports System.Runtime.InteropServices
Public Class Form87
    Dim SqlConnStr As String = "server=10.3.11.61;database=ALANSIS;uid=sa;pwd=term.0907;"
    Dim SqlConn As New System.Data.SqlClient.SqlConnection(SqlConnStr)
    Private Sub Form87_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim cmd As New SqlCommand()
        Dim cnn As New SqlConnection()
        Dim da As New SqlDataAdapter()
        Dim ds As New DataSet
        Try
            cnn.ConnectionString = "server=10.3.11.61;database=ALANSIS;uid=sa;pwd=term.0907"
            cnn.Open()
            cmd.Connection = cnn
            cmd.CommandType = CommandType.Text
            cmd.CommandText = "SELECT dbo.EO_SARF_TUKETIM_SERI.SIPARIS,CASE WHEN dbo.EO_ALANSIS_KIVI_SATIS.MUSTERI IS NULL  THEN 'HAMMADDE' ELSE dbo.EO_ALANSIS_KIVI_SATIS.MUSTERI END AS MUSTERI, SUM(dbo.EO_SARF_TUKETIM_SERI.MIKTAR) AS TOPLAM_SARF FROM dbo.EO_SARF_TUKETIM_SERI LEFT OUTER JOIN dbo.EO_ALANSIS_KIVI_SATIS ON dbo.EO_SARF_TUKETIM_SERI.SIPARIS = dbo.EO_ALANSIS_KIVI_SATIS.PARTI WHERE (dbo.EO_SARF_TUKETIM_SERI.STOK_KODU = 'HMD01-10-0001') GROUP BY dbo.EO_ALANSIS_KIVI_SATIS.MUSTERI, dbo.EO_SARF_TUKETIM_SERI.SIPARIS;"
            da.SelectCommand = cmd
            da.Fill(ds)
            DataGridView1.DataSource = ds.Tables(0).DefaultView
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        cnn.Close()
        '---------------------------------------------------------------------------------------------------

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        Form86.Show()
        Form86.CheckBox1.Checked = False
        Me.Hide()
    End Sub
End Class