﻿
Imports System.Data.SqlClient
Imports System.Data
Imports System.Net.Sockets
Public Class Form77
    Private Sub Form77_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim cmd As New SqlCommand()
        Dim cnn As New SqlConnection()
        Dim da As New SqlDataAdapter()
        Dim ds As New DataSet

        Try
            cnn.ConnectionString = "server=10.3.11.61;database=ALANSIS;uid=sa;pwd=term.0907"
            cnn.Open()
            cmd.Connection = cnn
            cmd.CommandType = CommandType.Text
            cmd.CommandText = "SELECT POSET FROM EO_ALANSIS_KIVIPOSET"
            da.SelectCommand = cmd
            da.Fill(ds)
            DataGridView1.DataSource = ds.Tables(0).DefaultView
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        cnn.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim conn1 As New SqlConnection
        Dim cmd1 As New SqlCommand
        Dim cmd2 As New SqlCommand
        Dim da As New SqlDataAdapter()
        Dim ds As New DataSet
        '---------------------------------------------------------------------------------------------------------------
        conn1.ConnectionString = "server=10.3.11.61;database=ALANSIS;uid=sa;pwd=term.0907"
        conn1.Open()
        cmd1.Connection = conn1
        cmd1.CommandText = "INSERT INTO EO_ALANSIS_KIVIPOSET (POSET) VALUES ( '" & TextBox1.Text & "')"
        cmd1.ExecuteNonQuery()
        '--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
        conn1.Close()
        '---------------------------------------------------------------------------------------------------
        conn1.Open()
        cmd2.Connection = conn1
        cmd2.CommandType = CommandType.Text
        cmd2.CommandText = "SELECT POSET FROM EO_ALANSIS_KIVIPOSET"
        da.SelectCommand = cmd2
        da.Fill(ds)
        DataGridView1.DataSource = ds.Tables(0).DefaultView
        conn1.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim conn1 As New SqlConnection
        Dim cmd1 As New SqlCommand
        Dim cmd2 As New SqlCommand
        Dim da As New SqlDataAdapter()
        Dim ds As New DataSet
        Dim silid
        silid = ""
        silid = DataGridView1.CurrentRow.Cells(0).Value.ToString
        '---------------------------------------------------------------------------------------------------------------
        conn1.ConnectionString = "server=10.3.11.61;database=ALANSIS;uid=sa;pwd=term.0907"
        conn1.Open()
        cmd1.Connection = conn1
        cmd1.CommandText = "Delete From EO_ALANSIS_KIVIPOSET Where POSET='" & silid & "'"
        cmd1.ExecuteNonQuery()
        '--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
        conn1.Close()
        '---------------------------------------------------------------------------------------------------
        '---------------------------------------------------------------------------------------------------
        conn1.Open()
        cmd2.Connection = conn1
        cmd2.CommandType = CommandType.Text
        cmd2.CommandText = "SELECT POSET FROM EO_ALANSIS_KIVIPOSET"
        da.SelectCommand = cmd2
        da.Fill(ds)
        DataGridView1.DataSource = ds.Tables(0).DefaultView
        conn1.Close()
        '____________________
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Form100.TextBox4.Text = "3"
        Form100.Show()
    End Sub
End Class