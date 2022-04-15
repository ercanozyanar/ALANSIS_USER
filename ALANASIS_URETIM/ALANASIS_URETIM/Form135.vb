Imports System.Data.SqlClient
Imports System.Data
Imports System.Net.Sockets
Public Class Form135
    Private Sub Form135_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim conn1 As New SqlConnection
        Dim cmd1 As New SqlCommand
        Dim cmd2 As New SqlCommand
        Dim da As New SqlDataAdapter()
        Dim ds As New DataSet
        '------------------------------------------------------------------------------------------------------------------------------
        conn1.ConnectionString = "server=10.3.11.61;database=ALANSIS;uid=sa;pwd=term.0907"
        '-----------------------------------------------------------------------------------------
        conn1.Open()
        cmd2.Connection = conn1
            cmd2.CommandType = CommandType.Text
            cmd2.CommandText = "SELECT USR,PASSWORD,GRUP FROM EO_ALANSIS_USER"
            da.SelectCommand = cmd2
            da.Fill(ds)
            DataGridView1.DataSource = ds.Tables(0).DefaultView
            conn1.Close()

    End Sub

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        Dim conn1 As New SqlConnection
        Dim cmd1 As New SqlCommand
        Dim cmd2 As New SqlCommand
        Dim da As New SqlDataAdapter()
        Dim ds As New DataSet
        Dim yetki, kontrol
        kontrol = ""
        '------------------------------------------------------------------------------------------------------------------------------
        conn1.ConnectionString = "server=10.3.11.61;database=ALANSIS;uid=sa;pwd=term.0907"
        '-----------------------------------------------------------------------------------------
        conn1.Open()
        Dim mySelectQuery2 As String = "SELECT USR FROM EO_ALANSIS_USER_YETKI WHERE USR='" & TextEdit1.Text & "';"
        Dim SqlComm2 As New System.Data.SqlClient.SqlCommand(mySelectQuery2, conn1)
        Dim reader2 As System.Data.SqlClient.SqlDataReader
        reader2 = SqlComm2.ExecuteReader()
        While reader2.Read()
            kontrol = reader2("USR")
        End While
        reader2.Close()
        conn1.Close()
        If kontrol = "" Then
            '---------------------------------------------------------------------------------------------------------------
            conn1.Open()
            cmd1.Connection = conn1
            cmd1.CommandText = "INSERT INTO EO_ALANSIS_USER (USR,PASSWORD,GRUP) VALUES ( '" & TextEdit1.Text & "','" & TextEdit2.Text & "','" & ComboBoxEdit1.Text & "')"
            cmd1.ExecuteNonQuery()
            '--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
            conn1.Close()
            '---------------------------------------------------------------------------------------------------
            conn1.Open()
            cmd2.Connection = conn1
            cmd2.CommandType = CommandType.Text
            cmd2.CommandText = "SELECT USR,PASSWORD,GRUP FROM EO_ALANSIS_USER"
            da.SelectCommand = cmd2
            da.Fill(ds)
            DataGridView1.DataSource = ds.Tables(0).DefaultView
            conn1.Close()
            Exit Sub
        Else
            DevExpress.XtraEditors.XtraMessageBox.Show("Kullanıcı Daha önce tanımlanmış...")

        End If
    End Sub

    Private Sub SimpleButton2_Click(sender As Object, e As EventArgs) Handles SimpleButton2.Click
        On Error Resume Next
        Dim conn1 As New SqlConnection
        Dim cmd1 As New SqlCommand
        Dim cmd2 As New SqlCommand
        Dim da As New SqlDataAdapter()
        Dim ds As New DataSet
        Dim silid
        silid = ""
        silid = DataGridView1.CurrentRow.Cells(4).Value.ToString
        '---------------------------------------------------------------------------------------------------------------
        conn1.ConnectionString = "server=10.3.11.61;database=ALANSIS;uid=sa;pwd=term.0907"
        conn1.Open()
        cmd1.Connection = conn1
        cmd1.CommandText = "Delete From EO_ALANSIS_USER Where ID='" & silid & "'"
        cmd1.ExecuteNonQuery()
        '--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
        conn1.Close()
        '---------------------------------------------------------------------------------------------------
        MsgBox("Kayit Silinmiştir...")
        '---------------------------------------------------------------------------------------------------
        conn1.Open()
        cmd2.Connection = conn1
        cmd2.CommandType = CommandType.Text
        cmd2.CommandText = "SELECT USR,PASSWORD,GRUP FROM EO_ALANSIS_USER"
        da.SelectCommand = cmd2
        da.Fill(ds)
        DataGridView1.DataSource = ds.Tables(0).DefaultView
        conn1.Close()
        '______________________________________________________________________________________________________________________________
        Exit Sub
    End Sub
End Class