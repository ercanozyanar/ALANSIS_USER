Imports System.Data.SqlClient
Imports System.Data
Imports System.Net.Sockets
Imports iTextSharp.text
Imports iTextSharp.text.html
Imports iTextSharp.text.pdf
Imports iTextSharp.text.html.simpleparser
Imports iTextSharp.text.pdf.PdfPTable
Imports System.IO
Imports System.Reflection
Imports Excel = Microsoft.Office.Interop.Excel
Public Class Form82
    Dim SqlConnStr As String = "server=10.3.11.61;database=ALANSIS;uid=sa;pwd=term.0907;"
    Dim SqlConn As New System.Data.SqlClient.SqlConnection(SqlConnStr)
    Private Sub Form82_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ComboBox1.Items.Clear()
        '---------------------------------------------------------------------------------------
        Dim cnn1 As New SqlConnection()
        cnn1.ConnectionString = "server=10.3.11.61;database=ALANSIS;uid=sa;pwd=term.0907"
        cnn1.Open()
        Dim mySelectQuery1 As String = "SELECT PARTI FROM EO_ALANSIS_KIVI_SATIS group by PARTI;"
        Dim SqlComm1 As New System.Data.SqlClient.SqlCommand(mySelectQuery1, cnn1)
        Dim reader1 As System.Data.SqlClient.SqlDataReader
        reader1 = SqlComm1.ExecuteReader()
        While reader1.Read()
            ComboBox1.Items.Add(reader1("PARTI"))
        End While
        reader1.Close()
        cnn1.Close()
        '-----------------------------------------------------------------------------------------

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        '---------------------------------------------------------------------------------------------------------------

        Dim cnn As New SqlConnection()
        cnn.ConnectionString = "server=10.3.11.61;database=ALANSIS;uid=sa;pwd=term.0907"
        cnn.Open()
        Dim mySelectQuery7 As String = "SELECT MUSTERI FROM EO_ALANSIS_KIVI_SATIS WHERE PARTI= '" & ComboBox1.Text & "';"
        Dim SqlComm7 As New System.Data.SqlClient.SqlCommand(mySelectQuery7, cnn)
        Dim reader7 = SqlComm7.ExecuteReader()
        While reader7.Read()
            Label2.Text = "KIVI " & reader7("MUSTERI").ToString()
        End While
        reader7.Close()
        cnn.Close()
        '--------------------------------------------------------------------------------------------------------

    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox2.SelectedIndexChanged

        If ComboBox1.Text <> "" Then
            If TextBox2.Text = "PALET_TIPI" Then
                SqlConn.Open()
                Dim mySelectQuery2 As String = "SELECT COUNT(PALET_TIPI) AS MIKTAR FROM EO_ALANSIS_KIVI_MAMULDEPO WHERE PARTINO='" & ComboBox1.Text & "'  AND PALET_TIPI='" & ComboBox2.Text & "' "
                Dim SqlComm2 As New System.Data.SqlClient.SqlCommand(mySelectQuery2, SqlConn)
                Dim reader2 As System.Data.SqlClient.SqlDataReader
                reader2 = SqlComm2.ExecuteReader()
                While reader2.Read()
                    Label5.Text = reader2("MIKTAR").ToString()
                End While
                reader2.Close()
                SqlConn.Close()
            Else
                SqlConn.Open()
                Dim mySelectQuery1 As String = "SELECT SUM(MIKTAR) AS MIKTAR FROM EO_ALANSIS_DEPO_SHAR WHERE [NO]='" & ComboBox1.Text & "'  AND SARF_ADI='" & ComboBox2.Text & "' "
                Dim SqlComm1 As New System.Data.SqlClient.SqlCommand(mySelectQuery1, SqlConn)
                Dim reader1 As System.Data.SqlClient.SqlDataReader
                reader1 = SqlComm1.ExecuteReader()
                While reader1.Read()
                    Label5.Text = reader1("MIKTAR").ToString()
                End While
                reader1.Close()
                SqlConn.Close()
            End If
        End If
        If ComboBox1.Text = "" Then
            If TextBox2.Text = "PALET_TIPI" Then
                SqlConn.Open()
                Dim mySelectQuery3 As String = "SELECT COUNT(PALET_TIPI) AS MIKTAR FROM EO_ALANSIS_KIVI_DEPO WHERE PALET_TIPI='" & ComboBox2.Text & "' "
                Dim SqlComm3 As New System.Data.SqlClient.SqlCommand(mySelectQuery3, SqlConn)
                Dim reader3 As System.Data.SqlClient.SqlDataReader
                reader3 = SqlComm3.ExecuteReader()
                While reader3.Read()
                    Label5.Text = reader3("MIKTAR").ToString()
                End While
                reader3.Close()
                SqlConn.Close()
            Else
                SqlConn.Open()
                Dim mySelectQuery1 As String = "SELECT SUM(MIKTAR) AS MIKTAR FROM EO_ALANSIS_DEPO_SHAR WHERE [NO]='HAMMADDE'  AND SARF_ADI='" & ComboBox2.Text & "' "
                Dim SqlComm1 As New System.Data.SqlClient.SqlCommand(mySelectQuery1, SqlConn)
                Dim reader1 As System.Data.SqlClient.SqlDataReader
                reader1 = SqlComm1.ExecuteReader()
                While reader1.Read()
                    Label5.Text = reader1("MIKTAR").ToString()
                End While
                reader1.Close()
                SqlConn.Close()
            End If
        End If
        'SELECT SUM(EBAT_ADET) FROM EO_ALANSIS_KIVI_MAMULDEPO WHERE PARTINO='2-59-01' AND EBAT_ETIKET='5li parmak etiket'
        '-------------------------------------------------------------------------------------------------------------------------------

    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        ComboBox2.Text = ""
        ComboBox2.Items.Clear()
        '---------------------------------------------------------------------------------------
        Dim cnn1 As New SqlConnection()
        cnn1.ConnectionString = "server=10.3.11.61;database=ALANSIS;uid=sa;pwd=term.0907"
        cnn1.Open()
        Dim mySelectQuery1 As String = "SELECT PALET_TIPI FROM EO_ALANSIS_KIVIPALETTIPI ;"
        Dim SqlComm1 As New System.Data.SqlClient.SqlCommand(mySelectQuery1, cnn1)
        Dim reader1 As System.Data.SqlClient.SqlDataReader
        reader1 = SqlComm1.ExecuteReader()
        While reader1.Read()
            ComboBox2.Items.Add(reader1("PALET_TIPI"))
        End While
        reader1.Close()
        cnn1.Close()
        TextBox2.Text = "PALET_TIPI"

        '-----------------------------------------------------------------------------------------

    End Sub

    Private Sub RadioButton3_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton3.CheckedChanged
        ComboBox2.Text = ""
        ComboBox2.Items.Clear()
        '---------------------------------------------------------------------------------------
        Dim cnn1 As New SqlConnection()
        cnn1.ConnectionString = "server=10.3.11.61;database=ALANSIS;uid=sa;pwd=term.0907"
        cnn1.Open()
        Dim mySelectQuery1 As String = "SELECT KUTU_TIPI FROM EO_ALANSIS_KIVIKUTUTIPI ;"
        Dim SqlComm1 As New System.Data.SqlClient.SqlCommand(mySelectQuery1, cnn1)
        Dim reader1 As System.Data.SqlClient.SqlDataReader
        reader1 = SqlComm1.ExecuteReader()
        While reader1.Read()
            ComboBox2.Items.Add(reader1("KUTU_TIPI"))
        End While
        reader1.Close()
        cnn1.Close()
        TextBox2.Text = "KUTU_TIPI"
        '-----------------------------------------------------------------------------------------

    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged
        ComboBox2.Text = ""
        ComboBox2.Items.Clear()
        '---------------------------------------------------------------------------------------
        Dim cnn1 As New SqlConnection()
        cnn1.ConnectionString = "server=10.3.11.61;database=ALANSIS;uid=sa;pwd=term.0907"
        cnn1.Open()
        Dim mySelectQuery1 As String = "SELECT NEMBEZI FROM EO_ALANSIS_KIVINEMBEZI;"
        Dim SqlComm1 As New System.Data.SqlClient.SqlCommand(mySelectQuery1, cnn1)
        Dim reader1 As System.Data.SqlClient.SqlDataReader
        reader1 = SqlComm1.ExecuteReader()
        While reader1.Read()
            ComboBox2.Items.Add(reader1("NEMBEZI"))
        End While
        reader1.Close()
        cnn1.Close()
        TextBox2.Text = "NEM_BEZI"
        '-----------------------------------------------------------------------------------------

    End Sub

    Private Sub RadioButton4_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton4.CheckedChanged
        ComboBox2.Text = ""
        ComboBox2.Items.Clear()
        '---------------------------------------------------------------------------------------
        Dim cnn1 As New SqlConnection()
        cnn1.ConnectionString = "server=10.3.11.61;database=ALANSIS;uid=sa;pwd=term.0907"
        cnn1.Open()
        Dim mySelectQuery1 As String = "SELECT CARRYBAG FROM EO_ALANSIS_KIVICARRYBAG ;"
        Dim SqlComm1 As New System.Data.SqlClient.SqlCommand(mySelectQuery1, cnn1)
        Dim reader1 As System.Data.SqlClient.SqlDataReader
        reader1 = SqlComm1.ExecuteReader()
        While reader1.Read()
            ComboBox2.Items.Add(reader1("CARRYBAG"))
        End While
        reader1.Close()
        cnn1.Close()
        TextBox2.Text = "CARRY_BAG_TIPI"
        '-----------------------------------------------------------------------------------------

    End Sub

    Private Sub RadioButton5_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton5.CheckedChanged
        ComboBox2.Text = ""
        ComboBox2.Items.Clear()
        '---------------------------------------------------------------------------------------
        Dim cnn1 As New SqlConnection()
        cnn1.ConnectionString = "server=10.3.11.61;database=ALANSIS;uid=sa;pwd=term.0907"
        cnn1.Open()
        Dim mySelectQuery1 As String = "SELECT POSET FROM EO_ALANSIS_KIVIPOSET ;"
        Dim SqlComm1 As New System.Data.SqlClient.SqlCommand(mySelectQuery1, cnn1)
        Dim reader1 As System.Data.SqlClient.SqlDataReader
        reader1 = SqlComm1.ExecuteReader()
        While reader1.Read()
            ComboBox2.Items.Add(reader1("POSET"))
        End While
        reader1.Close()
        cnn1.Close()
        TextBox2.Text = "POSET_TIPI"

        '-----------------------------------------------------------------------------------------

    End Sub

    Private Sub RadioButton6_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton6.CheckedChanged
        ComboBox2.Text = ""
        ComboBox2.Items.Clear()
        '---------------------------------------------------------------------------------------
        Dim cnn1 As New SqlConnection()
        cnn1.ConnectionString = "server=10.3.11.61;database=ALANSIS;uid=sa;pwd=term.0907"
        cnn1.Open()
        Dim mySelectQuery1 As String = "SELECT SALE_TIPI FROM EO_ALANSIS_KIVISALE ;"
        Dim SqlComm1 As New System.Data.SqlClient.SqlCommand(mySelectQuery1, cnn1)
        Dim reader1 As System.Data.SqlClient.SqlDataReader
        reader1 = SqlComm1.ExecuteReader()
        While reader1.Read()
            ComboBox2.Items.Add(reader1("SALE_TIPI"))
        End While
        reader1.Close()
        cnn1.Close()
        TextBox2.Text = "SALE_TIPI"
        '-----------------------------------------------------------------------------------------


    End Sub

    Private Sub RadioButton7_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton7.CheckedChanged
        ComboBox2.Text = ""
        ComboBox2.Items.Clear()
        '---------------------------------------------------------------------------------------
        Dim cnn1 As New SqlConnection()
        cnn1.ConnectionString = "server=10.3.11.61;database=ALANSIS;uid=sa;pwd=term.0907"
        cnn1.Open()
        Dim mySelectQuery1 As String = "SELECT SAPKA_TIPI FROM EO_ALANSIS_KIVISAPKATIPI ;"
        Dim SqlComm1 As New System.Data.SqlClient.SqlCommand(mySelectQuery1, cnn1)
        Dim reader1 As System.Data.SqlClient.SqlDataReader
        reader1 = SqlComm1.ExecuteReader()
        While reader1.Read()
            ComboBox2.Items.Add(reader1("SAPKA_TIPI"))
        End While
        reader1.Close()
        cnn1.Close()
        TextBox2.Text = "SAPKA_TIPI"

        '-----------------------------------------------------------------------------------------


    End Sub

    Private Sub RadioButton8_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton8.CheckedChanged
        ComboBox2.Text = ""
        ComboBox2.Items.Clear()
        '---------------------------------------------------------------------------------------
        Dim cnn1 As New SqlConnection()
        cnn1.ConnectionString = "server=10.3.11.61;database=ALANSIS;uid=sa;pwd=term.0907"
        cnn1.Open()
        Dim mySelectQuery1 As String = "SELECT KOSEBENT_TIPI FROM EO_ALANSIS_KIVIKOSEBENTTIPI ;"
        Dim SqlComm1 As New System.Data.SqlClient.SqlCommand(mySelectQuery1, cnn1)
        Dim reader1 As System.Data.SqlClient.SqlDataReader
        reader1 = SqlComm1.ExecuteReader()
        While reader1.Read()
            ComboBox2.Items.Add(reader1("KOSEBENT_TIPI"))
        End While
        reader1.Close()
        cnn1.Close()
        TextBox2.Text = "KOSEBENT_TIPI"
        '-----------------------------------------------------------------------------------------

    End Sub

    Private Sub RadioButton9_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton9.CheckedChanged
        ComboBox2.Text = ""
        ComboBox2.Items.Clear()
        '---------------------------------------------------------------------------------------
        Dim cnn1 As New SqlConnection()
        cnn1.ConnectionString = "server=10.3.11.61;database=ALANSIS;uid=sa;pwd=term.0907"
        cnn1.Open()
        Dim mySelectQuery1 As String = "SELECT KLIPS_TIPI FROM EO_ALANSIS_KIVIKLIPSTIPI ;"
        Dim SqlComm1 As New System.Data.SqlClient.SqlCommand(mySelectQuery1, cnn1)
        Dim reader1 As System.Data.SqlClient.SqlDataReader
        reader1 = SqlComm1.ExecuteReader()
        While reader1.Read()
            ComboBox2.Items.Add(reader1("KLIPS_TIPI"))
        End While
        reader1.Close()
        cnn1.Close()
        TextBox2.Text = "KLIPS_TIPI"
        '-----------------------------------------------------------------------------------------


    End Sub
    Private Sub RadioButton10_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton10.CheckedChanged
        ComboBox2.Text = ""
        ComboBox2.Items.Clear()
        '---------------------------------------------------------------------------------------
        Dim cnn1 As New SqlConnection()
        cnn1.ConnectionString = "server=10.3.11.61;database=ALANSIS;uid=sa;pwd=term.0907"
        cnn1.Open()
        Dim mySelectQuery1 As String = "SELECT FILE_TIPI FROM EO_ALANSIS_KIVIFILETIPI ;"
        Dim SqlComm1 As New System.Data.SqlClient.SqlCommand(mySelectQuery1, cnn1)
        Dim reader1 As System.Data.SqlClient.SqlDataReader
        reader1 = SqlComm1.ExecuteReader()
        While reader1.Read()
            ComboBox2.Items.Add(reader1("FILE_TIPI"))
        End While
        reader1.Close()
        cnn1.Close()
        TextBox2.Text = "FILE_TIPI"
        '--------------------------------------------------------------
    End Sub
    Private Sub RadioButton11_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton11.CheckedChanged
        ComboBox2.Text = ""
        ComboBox2.Items.Clear()
        '---------------------------------------------------------------------------------------
        Dim cnn1 As New SqlConnection()
        cnn1.ConnectionString = "server=10.3.11.61;database=ALANSIS;uid=sa;pwd=term.0907"
        cnn1.Open()
        Dim mySelectQuery1 As String = "SELECT ETIKET_TIPI FROM EO_ALANSIS_KIVIETIKETTIPI ;"
        Dim SqlComm1 As New System.Data.SqlClient.SqlCommand(mySelectQuery1, cnn1)
        Dim reader1 As System.Data.SqlClient.SqlDataReader
        reader1 = SqlComm1.ExecuteReader()
        While reader1.Read()
            ComboBox2.Items.Add(reader1("ETIKET_TIPI"))
        End While
        reader1.Close()
        cnn1.Close()
        TextBox2.Text = "ETIKET_TIPI"
        '-----------------------------------------------------------------------------------------
    End Sub
    Private Sub RadioButton12_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton12.CheckedChanged
        ComboBox2.Text = ""
        ComboBox2.Items.Clear()
        '---------------------------------------------------------------------------------------
        Dim cnn1 As New SqlConnection()
        cnn1.ConnectionString = "server=10.3.11.61;database=ALANSIS;uid=sa;pwd=term.0907"
        cnn1.Open()
        Dim mySelectQuery1 As String = "SELECT EBAT_ETIKET_TIPI FROM EO_ALANSIS_KIVIEBATETIKET ;"
        Dim SqlComm1 As New System.Data.SqlClient.SqlCommand(mySelectQuery1, cnn1)
        Dim reader1 As System.Data.SqlClient.SqlDataReader
        reader1 = SqlComm1.ExecuteReader()
        While reader1.Read()
            ComboBox2.Items.Add(reader1("EBAT_ETIKET_TIPI"))
        End While
        reader1.Close()
        cnn1.Close()
        TextBox2.Text = "EBAT_ETIKET"
        '-----------------------------------------------------------------------------------------
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        On Error Resume Next
        Dim conn1 As New SqlConnection()
        Dim cmd1 As New SqlCommand
        conn1.ConnectionString = "server=10.3.11.61;database=ALANSIS;uid=sa;pwd=term.0907"
        If ComboBox1.Text <> "" Then
            conn1.Open()
            cmd1.Connection = conn1
            cmd1.CommandText = "INSERT INTO EO_ALANSIS_DEPO_SHAR (TARIH,NO, SARF_ADI, TIP, MIKTAR, HAREKET_KODU, BOLGE,USR) VALUES ('" & DateTime.Now & "','" & ComboBox1.Text & "','" & ComboBox2.Text & "', 'UF','" & TextBox1.Text & "','C','URETIM_FIRE','PANEL')"
            cmd1.ExecuteNonQuery()
            '--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
            conn1.Close()
            '---------------------------------------------------------------------------------------------------
        End If
        If ComboBox1.Text = "" Then
            conn1.Open()
            cmd1.Connection = conn1
            cmd1.CommandText = "INSERT INTO EO_ALANSIS_DEPO_SHAR (TARIH,NO, SARF_ADI, TIP, MIKTAR, HAREKET_KODU, BOLGE,USR) VALUES ('" & DateTime.Now & "','HAMMADDE','" & ComboBox2.Text & "', 'UF','" & TextBox1.Text & "','C','URETIM_FIRE','PANEL')"
            cmd1.ExecuteNonQuery()
            '--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
            conn1.Close()
            '---------------------------------------------------------------------------------------------------
        End If
        MsgBox("FIRE ISLEMI TAMAMLANMIŞTIR...")
    End Sub
End Class