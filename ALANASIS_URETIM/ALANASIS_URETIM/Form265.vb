Imports System.Data.SqlClient
Imports System.Data
Imports System.Net.Sockets
Public Class Form265
    Private Sub SimpleButton2_Click(sender As Object, e As EventArgs) Handles SimpleButton2.Click
        On Error GoTo hata
        Dim conn1 As New SqlConnection
        Dim cmd1, cmd2 As New SqlCommand
        Dim da As New SqlDataAdapter()
        Dim ds As New DataSet
        Dim ekle, rapor, uretimrapor
        uretimrapor = ""
        ekle = ""
        rapor = ""
        conn1.ConnectionString = "server=10.3.11.61;database=ALANSIS;uid=sa;pwd=term.0907;"
        conn1.Open()
        cmd1.Connection = conn1
        cmd1.CommandText = "ALTER TABLE EO_ALANSIS_KIRAZ_MAMULDEPO ADD " & TextEdit1.Text & " " & ComboBoxEdit1.Text & ""
        cmd1.ExecuteNonQuery()
        conn1.Close()
        ekle = "," + TextEdit1.Text
        '==============================================================================================================================================================================================================
        If CheckEdit1.EditValue = "True" Then
            conn1.Open()
            Dim mySelectQuery1 As String = "SELECT* FROM EO_ALANSIS_RAPORMODUL WHERE BOLUM='SATIS';"
            Dim SqlComm1 As New System.Data.SqlClient.SqlCommand(mySelectQuery1, conn1)
            Dim reader1 As System.Data.SqlClient.SqlDataReader
            reader1 = SqlComm1.ExecuteReader()
            While reader1.Read()
                uretimrapor = reader1("KIRAZ_RAPOR")
            End While
            reader1.Close()
            conn1.Close()
            uretimrapor = uretimrapor + ekle
            conn1.Open()
            cmd1.Connection = conn1
            cmd1.CommandText = "UPDATE EO_ALANSIS_RAPORMODUL SET KIRAZ_RAPOR='" & uretimrapor & "' WHERE BOLUM='SATIS'"
            cmd1.ExecuteNonQuery()
            conn1.Close()
        End If
        '================================================================================================================================
        If CheckEdit2.EditValue = "True" Then
            conn1.Open()
            Dim mySelectQuery1 As String = "SELECT* FROM EO_ALANSIS_RAPORMODUL WHERE BOLUM='URETIM';"
            Dim SqlComm1 As New System.Data.SqlClient.SqlCommand(mySelectQuery1, conn1)
            Dim reader1 As System.Data.SqlClient.SqlDataReader
            reader1 = SqlComm1.ExecuteReader()
            While reader1.Read()
                uretimrapor = reader1("KIRAZ_RAPOR")
            End While
            reader1.Close()
            conn1.Close()
            uretimrapor = uretimrapor + ekle
            conn1.Open()
            cmd1.Connection = conn1
            cmd1.CommandText = "UPDATE EO_ALANSIS_RAPORMODUL SET KIRAZ_RAPOR='" & uretimrapor & "' WHERE BOLUM='URETIM'"
            cmd1.ExecuteNonQuery()
            conn1.Close()
        End If
        '================================================================================================================================
        If CheckEdit3.EditValue = "True" Then
            conn1.Open()
            Dim mySelectQuery1 As String = "SELECT* FROM EO_ALANSIS_RAPORMODUL WHERE BOLUM='MUHASEBE';"
            Dim SqlComm1 As New System.Data.SqlClient.SqlCommand(mySelectQuery1, conn1)
            Dim reader1 As System.Data.SqlClient.SqlDataReader
            reader1 = SqlComm1.ExecuteReader()
            While reader1.Read()
                uretimrapor = reader1("KIRAZ_RAPOR")
            End While
            reader1.Close()
            conn1.Close()
            uretimrapor = uretimrapor + ekle
            conn1.Open()
            cmd1.Connection = conn1
            cmd1.CommandText = "UPDATE EO_ALANSIS_RAPORMODUL SET KIRAZ_RAPOR='" & uretimrapor & "' WHERE BOLUM='MUHASEBE'"
            cmd1.ExecuteNonQuery()
            conn1.Close()
        End If
        '================================================================================================================================
        If CheckEdit4.EditValue = "True" Then
            conn1.Open()
            Dim mySelectQuery1 As String = "SELECT* FROM EO_ALANSIS_RAPORMODUL WHERE BOLUM='LOJISTIK';"
            Dim SqlComm1 As New System.Data.SqlClient.SqlCommand(mySelectQuery1, conn1)
            Dim reader1 As System.Data.SqlClient.SqlDataReader
            reader1 = SqlComm1.ExecuteReader()
            While reader1.Read()
                uretimrapor = reader1("KIRAZ_RAPOR")
            End While
            reader1.Close()
            conn1.Close()
            uretimrapor = uretimrapor + ekle
            conn1.Open()
            cmd1.Connection = conn1
            cmd1.CommandText = "UPDATE EO_ALANSIS_RAPORMODUL SET KIRAZ_RAPOR='" & uretimrapor & "' WHERE BOLUM='LOJISTIK'"
            cmd1.ExecuteNonQuery()
            conn1.Close()
        End If
        '================================================================================================================================
        Dim connectionString As String = "server=10.3.11.61;database=ALANSIS;uid=sa;pwd=term.0907"
        Dim sql As String = uretimrapor + " " + "FROM EO_ALANSIS_KIRAZ_MAMULDEPO"
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
        MsgBox("İşlem Tamamlandı...")
        Exit Sub


        Dim grupkontrol As String
        grupkontrol = ""
        grupkontrol = Trim(Mid(Form2.BarStaticItem4.Caption, 12, 15))


hata:
        MsgBox("Alan Adı Eklemede Hata...")
        Exit Sub
    End Sub
End Class