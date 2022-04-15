Imports System.Data.SqlClient
Imports System.Data
Imports System.Net.Sockets
Public Class Form117
    Dim cmd As New SqlCommand()
    Dim cnn As New SqlConnection()
    Dim da As New SqlDataAdapter()
    Dim ds As New DataSet
    Dim SqlConnStr As String = "server=10.3.11.61;database=ALANAR2021;uid=sa;pwd=term.0907;"
    Dim SqlConn As New System.Data.SqlClient.SqlConnection(SqlConnStr)
    Private Sub Form117_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            cnn.ConnectionString = "server=10.3.11.61;database=ALANAR2021;uid=sa;pwd=term.0907;"
            cnn.Open()
            cmd.Connection = cnn
            cmd.CommandType = CommandType.Text
            cmd.CommandText = "SELECT SUBE_KODU,DEPO_KODU,DBO.TRKIS1(DEPO_ISMI) AS DEPO_ISMI FROM TBLSTOKDP WHERE SUBE_KODU='" & TextBox3.Text & "'"
            da.SelectCommand = cmd
            DataGridView1.ClearSelection()
            da.Fill(ds)
            DataGridView1.DataSource = ds.Tables(0).DefaultView
            DataGridView1.Columns(0).Width = 400
            DataGridView1.Columns(1).Width = 100
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        cnn.Close()
        DataGridView1.AutoResizeColumns(DataGridViewAutoSizeColumnMode.AllCells)
        '------------------------------------------------------------------------------
        For i = 0 To DataGridView1.Rows.Count - 1 Step 2
            DataGridView1.Rows(i).DefaultCellStyle.BackColor = Color.LemonChiffon
            '------------------------------------------------------------------------------
        Next
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub DataGridView1_CellContentDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentDoubleClick
        If TextBox1.Text = "1" Then
            Form111.TextBox27.Text = DataGridView1.CurrentRow.Cells(1).Value.ToString
            Me.Hide()
        End If
        If TextBox1.Text = "2" Then
            Form104.TextBox27.Text = DataGridView1.CurrentRow.Cells(1).Value.ToString
            Me.Hide()
        End If
        If TextBox1.Text = "3" Then
            Form113.TextBox5.Text = DataGridView1.CurrentRow.Cells(1).Value.ToString
            Me.Hide()
        End If
    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles TextBox3.TextChanged

    End Sub
End Class