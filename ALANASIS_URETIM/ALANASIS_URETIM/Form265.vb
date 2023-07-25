Imports System.Data.SqlClient
Imports System.Data
Imports System.Net.Sockets
Public Class Form265

    Private Sub SimpleButton2_Click(sender As Object, e As EventArgs) Handles SimpleButton2.Click
        'On Error GoTo hata
        Dim conn1 As New SqlConnection
        Dim cmd1, cmd2 As New SqlCommand
        Dim da As New SqlDataAdapter()
        Dim ds As New DataSet
        Dim ekle, rapor, uretimrapor
        conn1.ConnectionString = "server=10.3.11.61;database=ALANSIS;uid=sa;pwd=term.0907"
        '==============================================================================================================================================================================================================
        If CheckEdit1.EditValue = "True" Then 'SATIŞ
            conn1.Open()
            cmd1.Connection = conn1
            cmd1.CommandText = "UPDATE EO_ALANSIS_RAPORMODUL SET SATIS='E' WHERE KISIM='KIRAZ' AND SAHA='" & ComboBoxEdit1.Text & "'"
            cmd1.ExecuteNonQuery()
            conn1.Close()
        End If
        If CheckEdit1.EditValue = "FALSE" Then 'SATIŞ
            conn1.Open()
            cmd1.Connection = conn1
            cmd1.CommandText = "UPDATE EO_ALANSIS_RAPORMODUL SET SATIS='H' WHERE KISIM='KIRAZ' AND SAHA='" & ComboBoxEdit1.Text & "'"
            cmd1.ExecuteNonQuery()
            conn1.Close()
        End If
        '================================================================================================================================
        If CheckEdit2.EditValue = "True" Then 'URETIM
            conn1.Open()
            cmd1.Connection = conn1
            cmd1.CommandText = "UPDATE EO_ALANSIS_RAPORMODUL SET URETIM='E' WHERE KISIM='KIRAZ' AND SAHA='" & ComboBoxEdit1.Text & "'"
            cmd1.ExecuteNonQuery()
            conn1.Close()
        End If
        If CheckEdit2.EditValue = "FALSE" Then 'SATIŞ
            conn1.Open()
            cmd1.Connection = conn1
            cmd1.CommandText = "UPDATE EO_ALANSIS_RAPORMODUL SET URETIM='H' WHERE KISIM='KIRAZ' AND SAHA='" & ComboBoxEdit1.Text & "'"
            cmd1.ExecuteNonQuery()
            conn1.Close()
        End If
        '================================================================================================================================
        If CheckEdit3.EditValue = "True" Then 'MUHASEBE
            conn1.Open()
            cmd1.Connection = conn1
            cmd1.CommandText = "UPDATE EO_ALANSIS_RAPORMODUL SET MUHASEBE='E' WHERE KISIM='KIRAZ' AND SAHA='" & ComboBoxEdit1.Text & "'"
            cmd1.ExecuteNonQuery()
            conn1.Close()
        End If
        If CheckEdit3.EditValue = "FALSE" Then 'MUHASEBE
            conn1.Open()
            cmd1.Connection = conn1
            cmd1.CommandText = "UPDATE EO_ALANSIS_RAPORMODUL SET MUHASEBE='H' WHERE KISIM='KIRAZ' AND SAHA='" & ComboBoxEdit1.Text & "'"
            cmd1.ExecuteNonQuery()
            conn1.Close()
        End If
        '================================================================================================================================
        If CheckEdit4.EditValue = "True" Then 'LOJISTIK
            conn1.Open()
            cmd1.Connection = conn1
            cmd1.CommandText = "UPDATE EO_ALANSIS_RAPORMODUL SET LOJISTIK='E' WHERE KISIM='KIRAZ' AND SAHA='" & ComboBoxEdit1.Text & "'"
            cmd1.ExecuteNonQuery()
            conn1.Close()
        End If
        If CheckEdit4.EditValue = "FALSE" Then 'LOJISTIK
            conn1.Open()
            cmd1.Connection = conn1
            cmd1.CommandText = "UPDATE EO_ALANSIS_RAPORMODUL SET LOJISTIK='H' WHERE KISIM='KIRAZ' AND SAHA='" & ComboBoxEdit1.Text & "'"
            cmd1.ExecuteNonQuery()
            conn1.Close()
        End If
        '================================================================================================================================
        If CheckEdit8.EditValue = "True" Then 'KALITE
            conn1.Open()
            cmd1.Connection = conn1
            cmd1.CommandText = "UPDATE EO_ALANSIS_RAPORMODUL SET KALITE='E' WHERE KISIM='KIRAZ' AND SAHA='" & ComboBoxEdit1.Text & "'"
            cmd1.ExecuteNonQuery()
            conn1.Close()
        End If
        If CheckEdit8.EditValue = "FALSE" Then 'KALITE
            conn1.Open()
            cmd1.Connection = conn1
            cmd1.CommandText = "UPDATE EO_ALANSIS_RAPORMODUL SET KALITE='H' WHERE KISIM='KIRAZ' AND SAHA='" & ComboBoxEdit1.Text & "'"
            cmd1.ExecuteNonQuery()
            conn1.Close()
        End If
        '================================================================================================================================
        If CheckEdit6.EditValue = "True" Then 'DEPO
            conn1.Open()
            cmd1.Connection = conn1
            cmd1.CommandText = "UPDATE EO_ALANSIS_RAPORMODUL SET DEPO='E' WHERE KISIM='KIRAZ' AND SAHA='" & ComboBoxEdit1.Text & "'"
            cmd1.ExecuteNonQuery()
            conn1.Close()
        End If
        If CheckEdit6.EditValue = "FALSE" Then 'DEPO
            conn1.Open()
            cmd1.Connection = conn1
            cmd1.CommandText = "UPDATE EO_ALANSIS_RAPORMODUL SET DEPO='H' WHERE KISIM='KIRAZ' AND SAHA='" & ComboBoxEdit1.Text & "'"
            cmd1.ExecuteNonQuery()
            conn1.Close()
        End If
        '================================================================================================================================
        If CheckEdit5.EditValue = "True" Then 'BAHCELER
            conn1.Open()
            cmd1.Connection = conn1
            cmd1.CommandText = "UPDATE EO_ALANSIS_RAPORMODUL SET BAHCELER='E' WHERE KISIM='KIRAZ' AND SAHA='" & ComboBoxEdit1.Text & "'"
            cmd1.ExecuteNonQuery()
            conn1.Close()
        End If
        If CheckEdit5.EditValue = "FALSE" Then 'BAHCELER
            conn1.Open()
            cmd1.Connection = conn1
            cmd1.CommandText = "UPDATE EO_ALANSIS_RAPORMODUL SET BAHCELER='H' WHERE KISIM='KIRAZ' AND SAHA='" & ComboBoxEdit1.Text & "'"
            cmd1.ExecuteNonQuery()
            conn1.Close()
        End If
        '================================================================================================================================
        If CheckEdit7.EditValue = "True" Then 'MUSTERI
            conn1.Open()
            cmd1.Connection = conn1
            cmd1.CommandText = "UPDATE EO_ALANSIS_RAPORMODUL SET MUSTERI='E' WHERE KISIM='KIRAZ' AND SAHA='" & ComboBoxEdit1.Text & "'"
            cmd1.ExecuteNonQuery()
            conn1.Close()
        End If
        If CheckEdit7.EditValue = "FALSE" Then 'MUSTERI
            conn1.Open()
            cmd1.Connection = conn1
            cmd1.CommandText = "UPDATE EO_ALANSIS_RAPORMODUL SET MUSTERI='H' WHERE KISIM='KIRAZ' AND SAHA='" & ComboBoxEdit1.Text & "'"
            cmd1.ExecuteNonQuery()
            conn1.Close()
        End If


        Dim connectionString As String = "server=10.3.11.61;database=ALANSIS;uid=sa;pwd=term.0907"
        Dim sql As String = "SELECT* FROM EO_ALANSIS_RAPORMODUL"
        Dim connection As New SqlConnection(connectionString)
        Dim dataadapter As New SqlDataAdapter(sql, connection)
        connection.Open()
        dataadapter.Fill(ds, "Firma")
        connection.Close()
        GridControl1.DataSource = ds
        GridControl1.DataMember = "Firma"
        GridView1.OptionsView.ColumnAutoWidth = False
        GridView1.OptionsView.BestFitMaxRowCount = -1
        GridView1.BestFitColumns()
        MsgBox("Yetkilendirmede Tamamlanmıştır...")
        Exit Sub



        'hata:
        '       MsgBox("Yetkilendirmede Hata...")
        '       Exit Sub
    End Sub

    Private Sub Form265_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class