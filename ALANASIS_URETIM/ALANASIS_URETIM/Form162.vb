Imports System.Data.SqlClient
Imports System.Data
Imports System.Net.Sockets
Public Class Form162
    Dim cmd As New SqlCommand()
    Dim cnn As New SqlConnection()
    Dim da As New SqlDataAdapter()
    Dim ds As New DataSet
    Dim i As Integer
    Private Sub Form162_Load(sender As Object, e As EventArgs) Handles Me.Load
        Try
            Dim connectionString As String = "server=10.3.11.61;database=ALANSIS;uid=sa;pwd=term.0907"
            Dim sql As String = "SELECT TARIH,PARTINO,RENK,STOK_KODU,STOK_ADI,SERI,NET,BRUT,DARA,BOLGE,TIP FROM EO_ALANSIS_MAMULREZERVE WHERE PARTINO='" & TextBox1.Text & "'"
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