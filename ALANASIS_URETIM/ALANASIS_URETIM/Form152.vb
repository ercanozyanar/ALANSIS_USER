Imports System.Data.SqlClient
Imports System.Data
Imports System.Net.Sockets
Imports System.Net.Mail
Public Class Form152
    Dim SqlConnStr As String = "server=10.3.11.61;database=ALANSIS;uid=sa;pwd=term.0907;"
    Dim SqlConn As New System.Data.SqlClient.SqlConnection(SqlConnStr)
    Dim cmd As New SqlCommand()
    Dim cnn As New SqlConnection()
    Dim da As New SqlDataAdapter()
    Dim ds As New DataSet
    Private Sub Form152_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Dim connectionString As String = "server=10.3.11.61;database=ALANSIS;uid=sa;pwd=term.0907"
            Dim sql As String = "SELECT dbo.EO_ALANSIS_GGNPARTI.TARIH, dbo.EO_ALANSIS_GGNPARTI.PARTINO, dbo.EO_ALANSIS_GGN.URETICI_ADSOY, dbo.EO_ALANSIS_GGN.BOLGE, dbo.EO_ALANSIS_GGN.BAHCE, dbo.EO_ALANSIS_GGNPARTI.GGN AS GGN_BILGISI, dbo.EO_ALANSIS_GGNPARTI.GGN_MIKTAR AS TANIMLANAN_MIKTAR, dbo.EO_ALANSIS_GGNPARTI.PARTI_MIKTAR FROM dbo.EO_ALANSIS_GGNPARTI LEFT OUTER JOIN dbo.EO_ALANSIS_GGN ON dbo.EO_ALANSIS_GGNPARTI.GGN = dbo.EO_ALANSIS_GGN.GGN_NO WHERE (dbo.EO_ALANSIS_GGNPARTI.PARTINO = '" & TextBox1.Text & "')"
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

    Private Sub GridControl1_Click(sender As Object, e As EventArgs) Handles GridControl1.Click

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Try
            Dim connectionString As String = "server=10.3.11.61;database=ALANSIS;uid=sa;pwd=term.0907"
            Dim sql As String = "SELECT dbo.EO_ALANSIS_GGNPARTI.TARIH, dbo.EO_ALANSIS_GGNPARTI.PARTINO, dbo.EO_ALANSIS_GGN.URETICI_ADSOY, dbo.EO_ALANSIS_GGN.BOLGE, dbo.EO_ALANSIS_GGN.BAHCE, dbo.EO_ALANSIS_GGNPARTI.GGN AS GGN_BILGISI, dbo.EO_ALANSIS_GGNPARTI.GGN_MIKTAR AS TANIMLANAN_MIKTAR, dbo.EO_ALANSIS_GGNPARTI.PARTI_MIKTAR FROM dbo.EO_ALANSIS_GGNPARTI LEFT OUTER JOIN dbo.EO_ALANSIS_GGN ON dbo.EO_ALANSIS_GGNPARTI.GGN = dbo.EO_ALANSIS_GGN.GGN_NO WHERE (dbo.EO_ALANSIS_GGNPARTI.PARTINO = '" & TextBox1.Text & "')"
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
End Class