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
Public Class Form91
    Dim SqlConnStr As String = "server=10.3.11.61;database=ALANSIS;uid=sa;pwd=term.0907;"
    Dim SqlConn As New System.Data.SqlClient.SqlConnection(SqlConnStr)
    Private Sub Form91_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        Dim cmd As New SqlCommand()
        Dim cnn As New SqlConnection()
        Dim da As New SqlDataAdapter()
        Dim ds As New DataSet
        Try
            cnn.ConnectionString = "server=10.3.11.61;database=ALANSIS;uid=sa;pwd=term.0907"
            cnn.Open()
            cmd.Connection = cnn
            cmd.CommandType = CommandType.Text
            cmd.CommandText = "SELECT[NO],CASE TIP WHEN 'U' THEN 'BITMIS_URUN' WHEN 'UF' THEN 'FIRE' WHEN 'U2' THEN '2.KALITE' WHEN 'US' THEN 'SULUK' WHEN 'UY' THEN 'YARI MAMUL' WHEN 'UYRM' THEN 'YARIM URETIM' WHEN 'UC' THEN 'ÇÖP' END AS TIP ,SARF_ADI,SUM(MIKTAR) AS TOPLAM_SARF FROM EO_ALANSIS_DEPO_SHAR WHERE [NO]='" & TextBox2.Text & "'AND SARF_ADI LIKE '%" & TextBox1.Text & "%'  GROUP BY [NO],SARF_ADI,TIP"
            da.SelectCommand = cmd
            da.Fill(ds)
            DataGridView1.DataSource = ds.Tables(0).DefaultView
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        cnn.Close()
        '---------------------------------------------------------------------------------------------------
        DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
        '-----------------------------------------------------------------------------------------
        '---------------------------------------------------------------------------------------------------
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub
End Class