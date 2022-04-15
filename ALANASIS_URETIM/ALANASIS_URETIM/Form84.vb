Imports System.Data.SqlClient
Imports System.Data
Imports System.Net.Sockets
Public Class Form84
    Dim cmd As New SqlCommand()
    Dim cnn As New SqlConnection()
    Dim da As New SqlDataAdapter()
    Dim ds As New DataSet
    Dim SqlConnStr As String = "server=10.3.11.61;database=ALANSIS;uid=sa;pwd=term.0907;;"
    Dim SqlConn As New System.Data.SqlClient.SqlConnection(SqlConnStr)
    Private Sub Form84_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cnn.ConnectionString = "server=10.3.11.61;database=ALANSIS;uid=sa;pwd=term.0907;"
        ComboBox1.Items.Clear()
        ComboBox2.Items.Clear()
        '---------------------------------------------------------------------------------------
        cnn.Open()
        Dim mySelectQuery1 As String = "SELECT PARTINO FROM EO_ALANSIS_KIVI_MAMULDEPO GROUP BY PARTINO;"
        Dim SqlComm1 As New System.Data.SqlClient.SqlCommand(mySelectQuery1, cnn)
        Dim reader1 As System.Data.SqlClient.SqlDataReader
        reader1 = SqlComm1.ExecuteReader()
        While reader1.Read()
            ComboBox1.Items.Add(reader1("PARTINO"))
            ComboBox2.Items.Add(reader1("PARTINO"))
        End While
        reader1.Close()
        cnn.Close()
        '-----------------------------------------------------------------------------------------
    End Sub
    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        DataGridView1.DataSource = ds
        ds.Clear()
        ds.Dispose()
        Dim cnn As New SqlConnection()
        Label2.Text = ""
        cnn.ConnectionString = "server=10.3.11.61;database=ALANSIS;uid=sa;pwd=term.0907"
        cnn.Open()
        Dim mySelectQuery7 As String = "SELECT ('KIVI ' + MUSTERI) AS URUN FROM EO_ALANSIS_KIVI_SATIS WHERE PARTI= '" & ComboBox1.Text & "';"
        Dim SqlComm7 As New System.Data.SqlClient.SqlCommand(mySelectQuery7, cnn)
        Dim reader7 = SqlComm7.ExecuteReader()
        While reader7.Read()
            Label2.Text = reader7("URUN").ToString()
        End While
        reader7.Close()
        cnn.Close()
        '--------------------------------------------------------------------------------------------------------
        Try
            cnn.Open()
            cmd.Connection = cnn
            cmd.CommandType = CommandType.Text
            cmd.CommandText = "SELECT PARTINO,SERI,CESIT,ODA,BOLGE,MIKTAR AS NET,BRUT,DARA FROM EO_ALANSIS_KIVI_MAMULDEPO WHERE TIP='MAMUL' AND PARTINO='" & ComboBox1.Text & "'"
            da.SelectCommand = cmd
            da.Fill(ds)
            DataGridView1.DataSource = ds.Tables(0).DefaultView
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        cnn.Close()
    End Sub
    Private Sub ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox2.SelectedIndexChanged
        Dim cnn As New SqlConnection()
        Label3.Text = ""
        cnn.ConnectionString = "server=10.3.11.61;database=ALANSIS;uid=sa;pwd=term.0907"
        cnn.Open()
        Dim mySelectQuery7 As String = "SELECT ('KIVI ' + MUSTERI) AS URUN FROM EO_ALANSIS_KIVI_SATIS WHERE PARTI= '" & ComboBox2.Text & "';"
        Dim SqlComm7 As New System.Data.SqlClient.SqlCommand(mySelectQuery7, cnn)
        Dim reader7 = SqlComm7.ExecuteReader()
        While reader7.Read()
            Label3.Text = reader7("URUN").ToString()
        End While
        reader7.Close()
        cnn.Close()
        '--------------------------------------------------------------------------------------------------------
    End Sub
    Private Sub DataGridView1_CurrentCellDirtyStateChanged(sender As Object, e As EventArgs) Handles DataGridView1.CurrentCellDirtyStateChanged
        TextBox1.Text = ""
        TextBox2.Text = ""
        If TypeOf DataGridView1.CurrentCell Is DataGridViewCheckBoxCell Then
            DataGridView1.EndEdit()
            Dim kontrol As Integer
            kontrol = DataGridView1.CurrentCell.RowIndex
            Dim Checked As Boolean = CType(DataGridView1.CurrentCell.Value, Boolean)
            If Checked Then
                TextBox1.Text = DataGridView1.CurrentRow.Cells(2).Value.ToString
                DataGridView1.Rows(kontrol).DefaultCellStyle.BackColor = Color.Turquoise
            Else
                TextBox2.Text = DataGridView1.CurrentRow.Cells(2).Value.ToString()
                DataGridView1.Rows(kontrol).DefaultCellStyle.BackColor = Color.White
            End If
        End If
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        ListBox1.SelectedIndex = ListBox1.FindStringExact(TextBox1.Text)
        If ListBox1.SelectedIndex > 0 Then
            Exit Sub
        Else
            If TextBox1.Text <> "" Then
                ListBox1.Items.Add(TextBox1.Text)
                Label6.Text = CInt(Label6.Text) + CInt(DataGridView1.CurrentRow.Cells(6).Value.ToString)
            Else
                Exit Sub
            End If
        End If
    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged
        If TextBox2.Text = "" Then
            Exit Sub
        Else
            ListBox1.Items.Remove(TextBox2.Text)
            Label6.Text = CInt(Label6.Text) - CInt(DataGridView1.CurrentRow.Cells(6).Value.ToString)
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) 

    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        Dim cmd1, cmd2, cmd3 As New SqlCommand
        Dim cnn2 As New SqlConnection()
        Dim var1 As String
        cnn2.ConnectionString = "server=10.3.11.61;database=ALANSIS;uid=sa;pwd=term.0907"
        '-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
        cnn2.Open()
        cmd1.Connection = cnn2
        Try
            For i As Integer = 0 To ListBox1.Items.Count - 1
                var1 = ListBox1.Items.Item(i).ToString
                cmd1.CommandText = ("INSERT INTO EO_ALANSIS_KIVI_PAKTARIM (TARIH,PARTINO,PARTINO_REV,SERI) VALUES('" & DateTime.Now & "','" & ComboBox1.Text & "','" & ComboBox2.Text & "'," + var1 + ")")
                cmd1.ExecuteNonQuery()
            Next
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        cnn2.Close()
        '-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
        cnn2.Open()
        cmd2.Connection = cnn2
        Try
            For i As Integer = 0 To ListBox1.Items.Count - 1
                var1 = ListBox1.Items.Item(i).ToString
                cmd2.CommandText = ("UPDATE EO_ALANSIS_KIVI_MAMULDEPO SET PARTINO= '" & ComboBox2.Text & "' WHERE SERI='" & var1 & "'")
                cmd2.ExecuteNonQuery()
            Next
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        cnn2.Close()
        '-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
        DataGridView1.DataSource = ds
        ds.Clear()
        ds.Dispose()
        Try
            cnn2.Open()
            cmd3.Connection = cnn2
            cmd3.CommandType = CommandType.Text
            cmd3.CommandText = "SELECT PARTINO,SERI,CESIT,ODA,BOLGE,MIKTAR AS NET,BRUT,DARA FROM EO_ALANSIS_KIVI_MAMULDEPO WHERE TIP='MAMUL' AND PARTINO='" & ComboBox1.Text & "'"
            da.SelectCommand = cmd3
            da.Fill(ds)
            DataGridView1.DataSource = ds.Tables(0).DefaultView
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        cnn2.Close()
        '--------------------------------------------------------------------------------------------------------
        Label6.Text = "0"
        ListBox1.Items.Clear()
        MsgBox("AKTARIM ISLEMI TAMAMLANMISTIR...")
    End Sub
End Class