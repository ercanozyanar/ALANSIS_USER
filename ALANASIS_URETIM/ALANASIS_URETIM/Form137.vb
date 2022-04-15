Imports System.Data.SqlClient
Imports System.Data
Imports System.Net.Sockets
Public Class Form137
    Dim SqlConnStr As String = "server=10.3.11.61;database=ALANSIS;uid=sa;pwd=term.0907;"
    Dim SqlConn As New System.Data.SqlClient.SqlConnection(SqlConnStr)
    Dim cmd As New SqlCommand()
    Dim cnn As New SqlConnection()
    Dim da As New SqlDataAdapter()
    Dim ds As New DataSet
    Dim i As Integer
    Private Sub Form137_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DataGridView1.DataSource = ds
        ds.Clear()
        ds.Dispose()
        Try
            cnn.ConnectionString = "server=10.3.11.61;database=ALANSIS;uid=sa;pwd=term.0907"
            cnn.Open()
            cmd.Connection = cnn
            cmd.CommandType = CommandType.Text
            cmd.CommandText = "SELECT* FROM EO_ALANSIS_HUCRESERI_BAKIYE"
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

    Private Sub ComboBoxEdit1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxEdit1.SelectedIndexChanged
        If ComboBoxEdit1.Text = "HAMMADDE KIRAZ" Then
            TextBox1.Text = "HMD01-02-0001"
        End If
        If ComboBoxEdit1.Text = "HAMMADDE INCIR" Then
            TextBox1.Text = "HMD01-02-0002"
        End If
        If ComboBoxEdit1.Text = "HAMMADDE KAYISI" Then
            TextBox1.Text = "HMD01-03-0001"
        End If
        If ComboBoxEdit1.Text = "HAMMADDE MALATYA KAYISI" Then
            TextBox1.Text = "HMD01-03-0002"
        End If
        If ComboBoxEdit1.Text = "HAMMADDE NAR" Then
            TextBox1.Text = "HMD01-05-0001"
        End If
        If ComboBoxEdit1.Text = "HAMMADDE ERIK" Then
            TextBox1.Text = "HMD01-08-0001"
        End If
        If ComboBoxEdit1.Text = "HAMMADDE ARMUT" Then
            TextBox1.Text = "HMD01-09-0001"
        End If

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        DataGridView1.DataSource = ds
        ds.Clear()
        ds.Dispose()
        Try
            cnn.ConnectionString = "server=10.3.11.61;database=ALANSIS;uid=sa;pwd=term.0907"
            cnn.Open()
            cmd.Connection = cnn
            cmd.CommandType = CommandType.Text
            cmd.CommandText = "SELECT* FROM EO_ALANSIS_HUCRESERI_BAKIYE WHERE STOK_KODU='" & TextBox1.Text & "'"
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

    End Sub

    Private Sub TextEdit1_EditValueChanged(sender As Object, e As EventArgs) Handles TextEdit1.EditValueChanged
        On Error Resume Next
        DataGridView1.DataSource = ds
        ds.Clear()
        ds.Dispose()

        cnn.ConnectionString = "server=10.3.11.61;database=ALANSIS;uid=sa;pwd=term.0907"
            cnn.Open()
            cmd.Connection = cnn
            cmd.CommandType = CommandType.Text
        cmd.CommandText = "SELECT* FROM EO_ALANSIS_HUCRESERI_BAKIYE WHERE GELDIGI_YER LIKE '%" & TextEdit1.Text & "%' AND STOK_KODU='" & TextBox1.Text & "'"
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
    End Sub
    Private Sub ComboBoxEdit2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxEdit2.SelectedIndexChanged
        On Error Resume Next
        If ComboBoxEdit1.Text = "KIRMIZI" Then
            TextBox2.Text = "KR"
        End If
        If ComboBoxEdit1.Text = "MAVI" Then
            TextBox2.Text = "MV"
        End If
        If ComboBoxEdit1.Text = "SARI" Then
            TextBox2.Text = "SR"
        End If
        If ComboBoxEdit1.Text = "YESIL" Then
            TextBox2.Text = "YSL"
        End If
        '================================================================================================================
        DataGridView1.DataSource = ds
        ds.Clear()
        ds.Dispose()
        cnn.ConnectionString = "server=10.3.11.61;database=ALANSIS;uid=sa;pwd=term.0907"
        cnn.Open()
        cmd.Connection = cnn
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "SELECT* FROM EO_ALANSIS_HUCRESERI_BAKIYE WHERE RENK='" & TextBox2.Text & "' AND STOK_KODU='" & TextBox1.Text & "'"
        da.SelectCommand = cmd
        DataGridView1.ClearSelection()
        da.Fill(ds)
        DataGridView1.DataSource = ds.Tables(0).DefaultView
        cnn.Close()
        '================================================================================================================
        DataGridView1.AutoResizeColumns(DataGridViewAutoSizeColumnMode.AllCells)
        For i = 0 To DataGridView1.Rows.Count - 1 Step 2
            DataGridView1.Rows(i).DefaultCellStyle.BackColor = Color.LemonChiffon
        Next
        '================================================================================================================

    End Sub
    Private Sub DataGridView1_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellDoubleClick


    End Sub
End Class