Imports System.Data.SqlClient
Imports System.Data
Imports System.Net.Sockets
Public Class Form147
    Dim SqlConnStr As String = "server=10.3.11.61;database=ALANSIS;uid=sa;pwd=term.0907;"
    Dim SqlConn As New System.Data.SqlClient.SqlConnection(SqlConnStr)
    Dim cmd As New SqlCommand()
    Dim cnn As New SqlConnection()
    Dim da As New SqlDataAdapter()
    Dim ds As New DataSet
    Dim i As Integer


    Private Sub DataGridView1_CellContentDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentDoubleClick
        Dim id
        Dim conn1 As New SqlConnection
        Dim cmd1 As New SqlCommand
        id = ""
        DevExpress.XtraEditors.XtraMessageBox.AllowCustomLookAndFeel = True
        DevExpress.XtraEditors.XtraMessageBox.Show("Kayıt silinecektir, emin misiniz...?", "Alansis", MessageBoxButtons.YesNo)
        If DialogResult.Yes Then
            If TextBox1.Text = "1" Then
                id = DataGridView1.CurrentRow.Cells(0).Value.ToString
                '---------------------------------------------------------------------------------------------------------------
                conn1.ConnectionString = "server=10.3.11.61;database=ALANSIS;uid=sa;pwd=term.0907"
                conn1.Open()
                cmd1.Connection = conn1
                cmd1.CommandText = "DELETE FROM EO_KIRAZFUMIGASYON_KONTROL WHERE ID='" & id & "'"
                cmd1.ExecuteNonQuery()
                conn1.Close()
                '--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
                '=====================================================================================================
                DataGridView1.DataSource = ds
                ds.Clear()
                ds.Dispose()
                Try
                    cnn.ConnectionString = "server=10.3.11.61;database=ALANSIS;uid=sa;pwd=term.0907"
                    cnn.Open()
                    cmd.Connection = cnn
                    cmd.CommandType = CommandType.Text
                    cmd.CommandText = "SELECT* FROM EO_KIRAZFUMIGASYON_KONTROL ORDER BY ID DESC"
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

            End If
            If TextBox1.Text = "2" Then
                id = DataGridView1.CurrentRow.Cells(0).Value.ToString
                '---------------------------------------------------------------------------------------------------------------
                conn1.ConnectionString = "server=10.3.11.61;database=ALANSIS;uid=sa;pwd=term.0907"
                conn1.Open()
                cmd1.Connection = conn1
                cmd1.CommandText = "DELETE FROM EO_KIRAZPAKET_KONTROL WHERE ID='" & id & "'"
                cmd1.ExecuteNonQuery()
                conn1.Close()
                '--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
                '=====================================================================================================
                DataGridView1.DataSource = ds
                ds.Clear()
                ds.Dispose()
                Try
                    cnn.ConnectionString = "server=10.3.11.61;database=ALANSIS;uid=sa;pwd=term.0907"
                    cnn.Open()
                    cmd.Connection = cnn
                    cmd.CommandType = CommandType.Text
                    cmd.CommandText = "SELECT* FROM EO_KIRAZPAKET_KONTROL ORDER BY ID DESC"
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

            End If
            If TextBox1.Text = "3" Then
                id = DataGridView1.CurrentRow.Cells(0).Value.ToString
                '---------------------------------------------------------------------------------------------------------------
                conn1.ConnectionString = "server=10.3.11.61;database=ALANSIS;uid=sa;pwd=term.0907"
                conn1.Open()
                cmd1.Connection = conn1
                cmd1.CommandText = "DELETE FROM EO_KIRAZGIRDI_KONTROL WHERE ID='" & id & "'"
                cmd1.ExecuteNonQuery()
                conn1.Close()
                '--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
                '=====================================================================================================
                DataGridView1.DataSource = ds
                ds.Clear()
                ds.Dispose()
                Try
                    cnn.ConnectionString = "server=10.3.11.61;database=ALANSIS;uid=sa;pwd=term.0907"
                    cnn.Open()
                    cmd.Connection = cnn
                    cmd.CommandType = CommandType.Text
                    cmd.CommandText = "SELECT* FROM EO_KIRAZGIRDI_KONTROL ORDER BY ID DESC"
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
            End If
            DevExpress.XtraEditors.XtraMessageBox.Show("Silme İşlemi Tamamlanmiştir...")
        Else
            Exit Sub

        End If
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

        If TextBox1.Text = "1" Then
            '=====================================================================================================
            DataGridView1.DataSource = ds
            ds.Clear()
            ds.Dispose()
            Try
                cnn.ConnectionString = "server=10.3.11.61;database=ALANSIS;uid=sa;pwd=term.0907"
                cnn.Open()
                cmd.Connection = cnn
                cmd.CommandType = CommandType.Text
                cmd.CommandText = "SELECT* FROM EO_KIRAZFUMIGASYON_KONTROL ORDER BY ID DESC"
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

        End If
        If TextBox1.Text = "2" Then
            '=====================================================================================================
            DataGridView1.DataSource = ds
            ds.Clear()
            ds.Dispose()
            Try
                cnn.ConnectionString = "server=10.3.11.61;database=ALANSIS;uid=sa;pwd=term.0907"
                cnn.Open()
                cmd.Connection = cnn
                cmd.CommandType = CommandType.Text
                cmd.CommandText = "SELECT* FROM EO_KIRAZPAKET_KONTROL ORDER BY ID DESC"
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

        End If
        If TextBox1.Text = "3" Then
            '=====================================================================================================
            DataGridView1.DataSource = ds
            ds.Clear()
            ds.Dispose()
            Try
                cnn.ConnectionString = "server=10.3.11.61;database=ALANSIS;uid=sa;pwd=term.0907"
                cnn.Open()
                cmd.Connection = cnn
                cmd.CommandType = CommandType.Text
                cmd.CommandText = "SELECT* FROM EO_KIRAZGIRDI_KONTROL ORDER BY ID DESC"
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

        End If
    End Sub
End Class