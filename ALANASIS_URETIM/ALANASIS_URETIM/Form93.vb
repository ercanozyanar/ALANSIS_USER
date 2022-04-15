Imports System.Data.SqlClient
Imports System.Data
Imports System.Net.Sockets
Public Class Form93
    Dim cmd As New SqlCommand()
    Dim cnn As New SqlConnection()
    Dim da As New SqlDataAdapter()
    Dim ds As New DataSet
    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        TextBox2.Text = "ALASEHIR"
        DataGridView1.DataSource = ds
        ds.Clear()
        ds.Dispose()

        Try
            cnn.ConnectionString = "server=10.3.11.61;database=ALANSIS;uid=sa;pwd=term.0907"
            cnn.Open()
            cmd.Connection = cnn
            cmd.CommandType = CommandType.Text
            cmd.CommandText = "SELECT SARF_ADI,BAKIYE FROM EO_ALANSIS_SARFHAR_BAK WHERE SUBE='ALASEHIR'"
            da.SelectCommand = cmd
            DataGridView1.ClearSelection()
            da.Fill(ds)
            DataGridView1.DataSource = ds.Tables(0).DefaultView
            DataGridView1.Columns(0).Width = 300
            DataGridView1.Columns(1).Width = 50
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

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged
        TextBox2.Text = "BURSA"
        DataGridView1.DataSource = ds
        ds.Clear()
        ds.Dispose()
        Try
            cnn.ConnectionString = "server=10.3.11.61;database=ALANSIS;uid=sa;pwd=term.0907"
            cnn.Open()
            cmd.Connection = cnn
            cmd.CommandType = CommandType.Text
            cmd.CommandText = "SELECT SARF_ADI,BAKIYE FROM EO_ALANSIS_SARFHAR_BAK WHERE SUBE='BURSA'"
            da.SelectCommand = cmd
            da.Fill(ds)
            DataGridView1.DataSource = ds.Tables(0).DefaultView
            DataGridView1.Columns(0).Width = 300
            DataGridView1.Columns(1).Width = 50
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

    Private Sub RadioButton3_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton3.CheckedChanged
        TextBox2.Text = "ADANA"
        DataGridView1.DataSource = ds
        ds.Clear()
        ds.Dispose()
        Try
            cnn.ConnectionString = "server=10.3.11.61;database=ALANSIS;uid=sa;pwd=term.0907"
            cnn.Open()
            cmd.Connection = cnn
            cmd.CommandType = CommandType.Text
            cmd.CommandText = "SELECT SARF_ADI,BAKIYE FROM EO_ALANSIS_SARFHAR_BAK WHERE SUBE='ADANA'"
            da.SelectCommand = cmd
            da.Fill(ds)
            DataGridView1.DataSource = ds.Tables(0).DefaultView
            DataGridView1.Columns(0).Width = 300
            DataGridView1.Columns(1).Width = 50
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

    Private Sub RadioButton4_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton4.CheckedChanged
        TextBox2.Text = "MALATYA"
        DataGridView1.DataSource = ds
        ds.Clear()
        ds.Dispose()
        Try
            cnn.ConnectionString = "server=10.3.11.61;database=ALANSIS;uid=sa;pwd=term.0907"
            cnn.Open()
            cmd.Connection = cnn
            cmd.CommandType = CommandType.Text
            cmd.CommandText = "SELECT SARF_ADI,BAKIYE FROM EO_ALANSIS_SARFHAR_BAK WHERE SUBE='MALATYA'"
            da.SelectCommand = cmd
            da.Fill(ds)
            DataGridView1.DataSource = ds.Tables(0).DefaultView
            DataGridView1.Columns(0).Width = 300
            DataGridView1.Columns(1).Width = 50
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

    Private Sub RadioButton5_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton5.CheckedChanged
        TextBox2.Text = "CANAKKALE"
        DataGridView1.DataSource = ds
        ds.Clear()
        ds.Dispose()
        Try
            cnn.ConnectionString = "server=10.3.11.61;database=ALANSIS;uid=sa;pwd=term.0907"
            cnn.Open()
            cmd.Connection = cnn
            cmd.CommandType = CommandType.Text
            cmd.CommandText = "SELECT SARF_ADI,BAKIYE FROM EO_ALANSIS_SARFHAR_BAK WHERE SUBE='CANAKKALE'"
            da.SelectCommand = cmd
            da.Fill(ds)
            DataGridView1.DataSource = ds.Tables(0).DefaultView
            DataGridView1.Columns(0).Width = 300
            DataGridView1.Columns(1).Width = 50
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

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        Dim cmd As New SqlCommand()
        Dim cnn As New SqlConnection()
        Dim da As New SqlDataAdapter()
        Dim ds As New DataSet

        Try
            cnn.ConnectionString = "server=10.3.11.61;database=ALANSIS;uid=sa;pwd=term.0907"
            cnn.Open()
            cmd.Connection = cnn
            cmd.CommandType = CommandType.Text
            cmd.CommandText = "SELECT SARF_ADI,BAKIYE FROM EO_ALANSIS_SARFHAR_BAK WHERE SUBE='" & TextBox2.Text & "' AND SARF_ADI LIKE '%" & TextBox1.Text & "%'"
            da.SelectCommand = cmd
            da.Fill(ds)
            DataGridView1.DataSource = ds.Tables(0).DefaultView
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
    Private Sub DataGridView1_CellContentDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentDoubleClick
        If TextBox3.Text = "1" Then
            Form79.TextBox2.Text = ""
            Form79.TextBox2.Text = DataGridView1.CurrentRow.Cells(0).Value
            Form79.Show()
            Me.Hide()
        End If
        If TextBox3.Text = "2" Then
            Form79.TextBox3.Text = ""
            Form79.TextBox3.Text = DataGridView1.CurrentRow.Cells(0).Value
            Form79.Show()
            Me.Hide()
        End If
        If TextBox3.Text = "3" Then
            Form79.TextBox4.Text = ""
            Form79.TextBox4.Text = DataGridView1.CurrentRow.Cells(0).Value
            Form79.Show()
            Me.Hide()
        End If
        If TextBox3.Text = "4" Then
            Form79.TextBox22.Text = ""
            Form79.TextBox22.Text = DataGridView1.CurrentRow.Cells(0).Value
            Form79.Show()
            Me.Hide()
        End If
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub
End Class