Imports System.Data.SqlClient
Imports System.Data
Imports System.Net.Sockets
Imports Excel = Microsoft.Office.Interop.Excel
Imports DevExpress.LookAndFeel
Public Class Form2
    Dim SqlConnStr As String = "server=10.3.11.61;database=ALANSIS;uid=sa;pwd=term.0907;"
    Dim SqlConn As New System.Data.SqlClient.SqlConnection(SqlConnStr)
    Public Sub New()
        DevExpress.Skins.SkinManager.EnableFormSkins()
        DevExpress.Skins.SkinManager.EnableMdiFormSkins()
        InitializeComponent()
    End Sub
    Shared Sub Main()
        DevExpress.UserSkins.BonusSkins.Register()
        Application.EnableVisualStyles()
        Application.SetCompatibleTextRenderingDefault(False)
        Application.Run(New Form2)
    End Sub
    Private Sub Form2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim MODUL, yetki, kullanici As String
        kullanici = Trim(Mid(Me.Text, 15, 20))
        UserLookAndFeel.Default.SetSkinStyle("Office 2007 Blue")
        '-------------------------------------------------------------------------------------------------------------------------------
        SqlConn.Open()
        Dim mySelectQuery2 As String = "SELECT* FROM EO_ALANSIS_USER_YETKI WHERE USR='" & kullanici & "';"
        Dim SqlComm2 As New System.Data.SqlClient.SqlCommand(mySelectQuery2, SqlConn)
        Dim reader2 As System.Data.SqlClient.SqlDataReader
        reader2 = SqlComm2.ExecuteReader()
        While reader2.Read()
            MODUL = reader2("YETKI").ToString()
            yetki = reader2("EH").ToString()
            '-----------------------------------------------------------------
            If MODUL = "BarButtonItem1" And yetki = "OK" Then
                BarButtonItem1.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
                'Else
                '   BarButtonItem1.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
            End If
            If MODUL = "BarButtonItem2" And yetki = "OK" Then
                BarButtonItem2.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
                'Else
                '  BarButtonItem2.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
            End If
            If MODUL = "BarButtonItem3" And yetki = "OK" Then
                BarButtonItem3.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
                'Else
                '   BarButtonItem3.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
            End If
            If MODUL = "BarButtonItem4" And yetki = "OK" Then
                BarButtonItem4.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
                'Else
                '   BarButtonItem4.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
            End If
            If MODUL = "BarButtonItem5" And yetki = "OK" Then
                BarButtonItem5.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
                'Else
                '    BarButtonItem5.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
            End If
            If MODUL = "BarButtonItem6" And yetki = "OK" Then
                BarButtonItem6.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
                'Else
                '   BarButtonItem6.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
            End If
            If MODUL = "BarButtonItem7" And yetki = "OK" Then
                BarButtonItem7.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
                'Else
                '   BarButtonItem7.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
            End If
            If MODUL = "BarButtonItem8" And yetki = "OK" Then
                BarButtonItem8.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
                'Else
                '   BarButtonItem8.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
            End If
            If MODUL = "BarButtonItem9" And yetki = "OK" Then
                BarButtonItem9.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
                'Else
                '   BarButtonItem9.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
            End If
            If MODUL = "BarButtonItem10" And yetki = "OK" Then
                BarButtonItem10.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
                'Else
                '   BarButtonItem10.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
            End If
            If MODUL = "BarButtonItem11" And yetki = "OK" Then
                BarButtonItem11.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
                'Else
                '   BarButtonItem11.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
            End If
            If MODUL = "BarButtonItem12" And yetki = "OK" Then
                BarButtonItem12.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
                'Else
                '   BarButtonItem12.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
            End If
            If MODUL = "BarButtonItem13" And yetki = "OK" Then
                BarButtonItem13.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
                'Else
                '    BarButtonItem13.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
            End If
            If MODUL = "BarButtonItem14" And yetki = "OK" Then
                BarButtonItem14.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
                'Else
                '   BarButtonItem14.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
            End If
            If MODUL = "BarButtonItem15" And yetki = "OK" Then
                BarButtonItem15.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
                ' Else
                '    BarButtonItem15.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
            End If
            If MODUL = "BarButtonItem16" And yetki = "OK" Then
                BarButtonItem16.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
                'Else
                '    BarButtonItem16.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
            End If
            If MODUL = "BarButtonItem17" And yetki = "OK" Then
                BarButtonItem17.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
                'Else
                '   BarButtonItem17.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
            End If
            If MODUL = "BarButtonItem18" And yetki = "OK" Then
                BarButtonItem18.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
                'Else
                '    BarButtonItem18.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
            End If
            If MODUL = "BarButtonItem19" And yetki = "OK" Then
                BarButtonItem19.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
                ' Else
                '    BarButtonItem19.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
            End If
            If MODUL = "BarButtonItem20" And yetki = "OK" Then
                BarButtonItem20.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
                'Else
                '    BarButtonItem20.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
            End If
            If MODUL = "BarButtonItem21" And yetki = "OK" Then
                BarButtonItem21.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
                'Else
                '   BarButtonItem21.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
            End If
            If MODUL = "BarButtonItem22" And yetki = "OK" Then
                BarButtonItem22.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
                'Else
                '    BarButtonItem22.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
            End If

            If MODUL = "BarSubItem1" And yetki = "OK" Then
                BarSubItem1.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
                'Else
                '   BarSubItem1.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
            End If
            If MODUL = "BarSubItem5" And yetki = "OK" Then
                BarSubItem5.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
                ' Else
                '    BarSubItem5.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
            End If
            If MODUL = "BarSubItem6" And yetki = "OK" Then
                BarSubItem6.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
                'Else
                '   BarSubItem6.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
            End If
            If MODUL = "BarSubItem7" And yetki = "OK" Then
                BarSubItem7.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
                'Else
                '    BarSubItem7.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
            End If
            If MODUL = "BarSubItem8" And yetki = "OK" Then
                BarSubItem8.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
                'Else
                '    BarSubItem8.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
            End If
            If MODUL = "BarSubItem9" And yetki = "OK" Then
                BarSubItem9.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
                'Else
                '   BarSubItem9.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
            End If
            If MODUL = "BarSubItem10" And yetki = "OK" Then
                BarSubItem10.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
                'Else
                '   BarSubItem10.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
            End If
            If MODUL = "BarSubItem11" And yetki = "OK" Then
                BarSubItem11.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
                'Else
                '   BarSubItem11.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
            End If
            If MODUL = "BarSubItem12" And yetki = "OK" Then
                BarSubItem12.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
                'Else
                '    BarSubItem12.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
            End If
            If MODUL = "BarSubItem13" And yetki = "OK" Then
                BarSubItem13.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
                'Else
                '   BarSubItem13.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
            End If
            If MODUL = "BarSubItem14" And yetki = "OK" Then
                BarSubItem14.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
                'Else
                '   BarSubItem14.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
            End If
            If MODUL = "BarSubItem15" And yetki = "OK" Then
                BarSubItem15.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
                'Else
                '   BarSubItem15.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
            End If
            If MODUL = "BarSubItem16" And yetki = "OK" Then
                BarSubItem16.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
                'Else
                '   BarSubItem16.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
            End If
            If MODUL = "BarSubItem17" And yetki = "OK" Then
                BarSubItem17.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
                'Else
                '   BarSubItem17.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
            End If
            If MODUL = "BarSubItem18" And yetki = "OK" Then
                BarSubItem18.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
                'Else
                '   BarSubItem18.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
            End If
            If MODUL = "BarSubItem19" And yetki = "OK" Then
                BarSubItem19.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
                'Else
                '   BarSubItem19.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
            End If
            If MODUL = "BarSubItem20" And yetki = "OK" Then
                BarSubItem20.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
                'Else
                '   BarSubItem20.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
            End If
            If MODUL = "BarButtonItem91" And yetki = "OK" Then
                BarButtonItem91.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
                'Else
                '   BarButtonItem91.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
            End If
            If MODUL = "BarButtonItem92" And yetki = "OK" Then
                BarButtonItem92.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
                'Else
                '   BarButtonItem92.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
            End If
            If MODUL = "BarButtonItem93" And yetki = "OK" Then
                BarButtonItem93.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
                'Else
                '   BarButtonItem93.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
            End If

            If MODUL = "BarButtonItem94" And yetki = "OK" Then
                BarButtonItem94.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
                'Else
                '   BarButtonItem94.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
            End If
            If MODUL = "BarButtonItem95" And yetki = "OK" Then
                BarButtonItem95.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
                'Else
                '   BarButtonItem95.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
            End If
            If MODUL = "BarButtonItem96" And yetki = "OK" Then
                BarButtonItem96.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
                'Else
                '   BarButtonItem96.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
            End If
            If MODUL = "BarButtonItem97" And yetki = "OK" Then
                BarButtonItem97.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
                'Else
                '   BarButtonItem97.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
            End If
            If MODUL = "BarButtonItem98" And yetki = "OK" Then
                BarButtonItem98.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
                'Else
                '    BarButtonItem98.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
            End If

            If MODUL = "BarButtonItem100" And yetki = "OK" Then
                BarButtonItem100.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
                'Else
                '    BarButtonItem100.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
            End If
            If MODUL = "BarButtonItem101" And yetki = "OK" Then
                BarButtonItem101.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
                'Else
                '   BarButtonItem101.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
            End If
        End While
        reader2.Close()
        SqlConn.Close()
        '-------------------------------------------------------------------------------------------------------------------------------

    End Sub

    Private Sub BoyToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Form4.MdiParent = Me
        'Form2.Dock = DockStyle.Fill
        Form4.Show()
    End Sub

    Private Sub OdaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Form3.MdiParent = Me
        'Form2.Dock = DockStyle.Fill
        Form3.Show()
    End Sub

    Private Sub İslemToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Form5.MdiParent = Me
        'Form2.Dock = DockStyle.Fill
        Form5.Show()
    End Sub

    Private Sub NarİslemToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Form6.MdiParent = Me
        'Form2.Dock = DockStyle.Fill
        Form6.Show()
    End Sub

    Private Sub BölgeToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Form7.MdiParent = Me
        'Form2.Dock = DockStyle.Fill
        Form7.Show()
    End Sub

    Private Sub TümOdalarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Form8.MdiParent = Me
        'Form2.Dock = DockStyle.Fill
        Form8.Show()
    End Sub

    Private Sub TümOdalarToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Form9.MdiParent = Me
        'Form2.Dock = DockStyle.Fill
        Form9.Show()
    End Sub

    Private Sub GünlükÜretimRaporuToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Form10.MdiParent = Me
        'Form2.Dock = DockStyle.Fill
        Form10.Show()
    End Sub

    Private Sub GünlükNarMamulÜretimToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Form11.MdiParent = Me
        'Form2.Dock = DockStyle.Fill
        Form11.Show()
    End Sub

    Private Sub NarÜretimTarihToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Form12.MdiParent = Me
        'Form2.Dock = DockStyle.Fill
        Form12.Show()
    End Sub

    Private Sub ToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Form13.MdiParent = Me
        'Form2.Dock = DockStyle.Fill
        Form13.Show()
    End Sub

    Private Sub ÜretimTipiToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Form14.MdiParent = Me
        'Form2.Dock = DockStyle.Fill
        Form14.Show()
    End Sub

    Private Sub ÇeşitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Form15.MdiParent = Me
        'Form2.Dock = DockStyle.Fill
        Form15.Show()
    End Sub

    Private Sub PaletTipiToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Form16.MdiParent = Me
        'Form2.Dock = DockStyle.Fill
        Form16.Show()
    End Sub

    Private Sub KutuKasaTipiToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Form17.MdiParent = Me
        'Form2.Dock = DockStyle.Fill
        Form17.Show()
    End Sub

    Private Sub KutuEtiketTipiToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Form18.MdiParent = Me
        'Form2.Dock = DockStyle.Fill
        Form18.Show()
    End Sub

    Private Sub EbatEtiketÇeşidiToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Form19.MdiParent = Me
        'Form2.Dock = DockStyle.Fill
        Form19.Show()
    End Sub

    Private Sub YrdMlzTipiToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Form20.MdiParent = Me
        'Form2.Dock = DockStyle.Fill
        Form20.Show()
    End Sub

    Private Sub GünlükNarÜretimDetayToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Form21.MdiParent = Me
        'Form2.Dock = DockStyle.Fill
        Form21.Show()
    End Sub


    Private Sub ÜretimDemirbaşTipiToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Form23.MdiParent = Me
        'Form2.Dock = DockStyle.Fill
        Form23.Show()
    End Sub

    Private Sub ŞifreDeğiştirmeToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Form27.MdiParent = Me
        'Form2.Dock = DockStyle.Fill
        Form27.Show()
    End Sub

    Private Sub YetkiAtamaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Form28.MdiParent = Me
        'Form2.Dock = DockStyle.Fill
        Form28.Show()
    End Sub

    Private Sub DepoMalKabulİzlemeVeRaporToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Form26.MdiParent = Me
        'Form2.Dock = DockStyle.Fill
        Form26.Show()
    End Sub

    Private Sub NarPaketlemeÜretimRaporuMamulToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Form33.MdiParent = Me
        'Form2.Dock = DockStyle.Fill
        Form33.Show()
    End Sub

    Private Sub NarÜretimRaporuYıllıkHaftaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Form31.MdiParent = Me
        'Form2.Dock = DockStyle.Fill
        Form31.Show()
    End Sub

    Private Sub NarPaketlemeRaporuMamulToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Form32.MdiParent = Me
        'Form2.Dock = DockStyle.Fill
        Form32.Show()
    End Sub

    Private Sub DepoSarfStokBakiyeRaporToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Form25.MdiParent = Me
        'Form2.Dock = DockStyle.Fill
        Form25.Show()
    End Sub

    Private Sub ÜretimSarfStokİzlemeVeRaporToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Form22.MdiParent = Me
        'Form2.Dock = DockStyle.Fill
        Form22.Show()
    End Sub

    Private Sub DepoSarfStokİzlemeVeRaporToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Form24.MdiParent = Me
        'Form2.Dock = DockStyle.Fill
        Form24.Show()
    End Sub

    Private Sub NarÜretimSarfRaporToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub NarÜretimRaporToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'Form30.MdiParent = Me
        'Form2.Dock = DockStyle.Fill
        'Form30.Show()
    End Sub

    Private Sub OdaToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Form34.MdiParent = Me
        'Form2.Dock = DockStyle.Fill
        Form34.Show()
    End Sub

    Private Sub BotToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Form35.MdiParent = Me
        'Form2.Dock = DockStyle.Fill
        Form35.Show()
    End Sub

    Private Sub İşlemToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Form36.MdiParent = Me
        'Form2.Dock = DockStyle.Fill
        Form36.Show()
    End Sub

    Private Sub NarİslemToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Form37.MdiParent = Me
        'Form2.Dock = DockStyle.Fill
        Form37.Show()
    End Sub

    Private Sub BölgeToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Form38.MdiParent = Me
        'Form2.Dock = DockStyle.Fill
        Form38.Show()
    End Sub

    Private Sub ÜretimTipiToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Form39.MdiParent = Me
        'Form2.Dock = DockStyle.Fill
        Form39.Show()
    End Sub

    Private Sub ÇeşitToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Form40.MdiParent = Me
        'Form2.Dock = DockStyle.Fill
        Form40.Show()
    End Sub

    Private Sub PaletTipiToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Form41.MdiParent = Me
        'Form2.Dock = DockStyle.Fill
        Form41.Show()
    End Sub

    Private Sub KutuKasaTipşToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Form42.MdiParent = Me
        'Form2.Dock = DockStyle.Fill
        Form42.Show()
    End Sub

    Private Sub KutuEtiketTipiToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Form43.MdiParent = Me
        'Form2.Dock = DockStyle.Fill
        Form43.Show()
    End Sub

    Private Sub EbatEtiketÇeşidiToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Form44.MdiParent = Me
        'Form2.Dock = DockStyle.Fill
        Form44.Show()
    End Sub

    Private Sub YrdMlzTipiToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Form45.MdiParent = Me
        'Form2.Dock = DockStyle.Fill
        Form45.Show()
    End Sub

    Private Sub DepoRaporlarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub LogDetayToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Form46.MdiParent = Me
        'Form2.Dock = DockStyle.Fill
        Form46.Show()
    End Sub

    Private Sub LOGIzlemeToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub KullanıcıAyarlarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub OdaToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Form47.MdiParent = Me
        'Form2.Dock = DockStyle.Fill
        Form47.Show()
    End Sub

    Private Sub BoyToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Form48.MdiParent = Me
        'Form2.Dock = DockStyle.Fill
        Form48.Show()
    End Sub

    Private Sub İşlemToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Form49.MdiParent = Me
        'Form2.Dock = DockStyle.Fill
        Form49.Show()
    End Sub

    Private Sub KirazİşlemToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Form50.MdiParent = Me
        'Form2.Dock = DockStyle.Fill
        Form50.Show()
    End Sub

    Private Sub BölgeToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Form51.MdiParent = Me
        'Form2.Dock = DockStyle.Fill
        Form51.Show()
    End Sub

    Private Sub ÜretimTipiToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Form52.MdiParent = Me
        'Form2.Dock = DockStyle.Fill
        Form52.Show()
    End Sub

    Private Sub ÇeşitToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Form53.MdiParent = Me
        'Form2.Dock = DockStyle.Fill
        Form53.Show()
    End Sub

    Private Sub PaletTipiToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Form54.MdiParent = Me
        'Form2.Dock = DockStyle.Fill
        Form54.Show()
    End Sub

    Private Sub KutuKasaTipiToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Form55.MdiParent = Me
        'Form2.Dock = DockStyle.Fill
        Form55.Show()
    End Sub

    Private Sub KutuEtiketiTipiToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Form56.MdiParent = Me
        'Form2.Dock = DockStyle.Fill
        Form56.Show()
    End Sub

    Private Sub EbatEtiketÇeşidiToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Form57.MdiParent = Me
        'Form2.Dock = DockStyle.Fill
        Form57.Show()
    End Sub

    Private Sub TasarımToolStripMenuItem_Click(sender As Object, e As EventArgs)
        Form30.MdiParent = Me
        'Form2.Dock = DockStyle.Fill
        Form30.Show()
    End Sub

    Private Sub Yayın1ToolStripMenuItem_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub BölgeBazlıÜretimRaporToolStripMenuItem_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub HaftalıkÜretimRaporToolStripMenuItem_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub SatışAnalizRaporToolStripMenuItem_Click(sender As Object, e As EventArgs)
        Form45.MdiParent = Me
        Form45.DashboardViewer1.LoadDashboard("C:\Alansis_Dashboard\rapor5.xml")
        Form45.Show()
    End Sub

    Private Sub SarfTüketimRaporToolStripMenuItem_Click(sender As Object, e As EventArgs)
        Form45.MdiParent = Me
        Form45.DashboardViewer1.LoadDashboard("C:\Alansis_Dashboard\rapor6.xml")
        Form45.Show()
    End Sub

    Private Sub ÜretimSarfTüketimRaporToolStripMenuItem_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub ToolStripMenuItem4_Click(sender As Object, e As EventArgs)
        Form58.MdiParent = Me
        'Form2.Dock = DockStyle.Fill
        Form58.Show()
    End Sub

    Private Sub ToolStripMenuItem7_Click(sender As Object, e As EventArgs)
        Form61.MdiParent = Me
        Form61.Show()
    End Sub

    Private Sub ToolStripMenuItem5_Click(sender As Object, e As EventArgs)
        Form59.MdiParent = Me
        Form59.Show()
    End Sub

    Private Sub ToolStripMenuItem6_Click(sender As Object, e As EventArgs)
        Form60.MdiParent = Me
        Form60.Show()
    End Sub

    Private Sub ToolStripMenuItem8_Click(sender As Object, e As EventArgs)
        Form62.MdiParent = Me
        Form62.Show()
    End Sub

    Private Sub ToolStripMenuItem9_Click(sender As Object, e As EventArgs)
        Form63.MdiParent = Me
        Form63.Show()
    End Sub

    Private Sub ToolStripMenuItem10_Click(sender As Object, e As EventArgs)
        Form64.MdiParent = Me
        Form64.Show()
    End Sub

    Private Sub ToolStripMenuItem11_Click(sender As Object, e As EventArgs)
        Form65.MdiParent = Me
        Form65.Show()
    End Sub

    Private Sub ToolStripMenuItem12_Click(sender As Object, e As EventArgs)
        Form66.MdiParent = Me
        Form66.Show()
    End Sub

    Private Sub ToolStripMenuItem13_Click(sender As Object, e As EventArgs)
        Form67.MdiParent = Me
        Form67.Show()
    End Sub

    Private Sub ToolStripMenuItem14_Click(sender As Object, e As EventArgs)
        Form68.MdiParent = Me
        Form68.Show()
    End Sub

    Private Sub FileTipiToolStripMenuItem_Click(sender As Object, e As EventArgs)
        Form69.MdiParent = Me
        Form69.Show()
    End Sub

    Private Sub ŞaleTipiToolStripMenuItem_Click(sender As Object, e As EventArgs)
        Form70.MdiParent = Me
        Form70.Show()
    End Sub

    Private Sub KlipsTipiToolStripMenuItem_Click(sender As Object, e As EventArgs)
        Form71.MdiParent = Me
        Form71.Show()
    End Sub

    Private Sub ŞapkaTipiToolStripMenuItem_Click(sender As Object, e As EventArgs)
        Form72.MdiParent = Me
        Form72.Show()
    End Sub

    Private Sub EbatToolStripMenuItem_Click(sender As Object, e As EventArgs)
        Form73.MdiParent = Me
        Form73.Show()
    End Sub

    Private Sub ToolStripMenuItem15_Click(sender As Object, e As EventArgs)
        Form74.MdiParent = Me
        Form74.Show()
    End Sub

    Private Sub NemBeziTipiToolStripMenuItem_Click(sender As Object, e As EventArgs)
        Form75.MdiParent = Me
        Form75.Show()
    End Sub

    Private Sub PartiBazlıÜretimRaporToolStripMenuItem_Click(sender As Object, e As EventArgs)
        Form45.MdiParent = Me
        Form45.DashboardViewer1.LoadDashboard("C:\Alansis_Dashboard\rapor1.xml")
        Form45.Show()
    End Sub

    Private Sub BölgeBazlıÜretimRaporToolStripMenuItem1_Click(sender As Object, e As EventArgs)
        Form45.MdiParent = Me
        Form45.DashboardViewer1.LoadDashboard("C:\Alansis_Dashboard\rapor2.xml")
        Form45.Show()
    End Sub

    Private Sub HaftalıkÜretimRaporToolStripMenuItem1_Click(sender As Object, e As EventArgs)
        Form45.MdiParent = Me
        Form45.DashboardViewer1.LoadDashboard("C:\Alansis_Dashboard\rapor4.xml")
        Form45.Show()
    End Sub

    Private Sub ÜretimSarfTüketimRaporToolStripMenuItem1_Click(sender As Object, e As EventArgs)
        Form45.MdiParent = Me
        Form45.DashboardViewer1.LoadDashboard("C:\Alansis_Dashboard\rapor7.xml")
        Form45.Show()
    End Sub

    Private Sub PartiBazlıÜretimRaporToolStripMenuItem1_Click(sender As Object, e As EventArgs)
        Form45.MdiParent = Me
        Form45.DashboardViewer1.LoadDashboard("C:\Alansis_Dashboard\rapor8.xml")
        Form45.Show()
    End Sub

    Private Sub BölgeBazlıÜretimRaporToolStripMenuItem_Click_1(sender As Object, e As EventArgs)
        Form45.MdiParent = Me
        Form45.DashboardViewer1.LoadDashboard("C:\Alansis_Dashboard\rapor9.xml")
        Form45.Show()
    End Sub

    Private Sub KiviDashboardToolStripMenuItem_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub HaftalıkÜretimRaporToolStripMenuItem_Click_1(sender As Object, e As EventArgs)
        Form45.MdiParent = Me
        Form45.DashboardViewer1.LoadDashboard("C:\Alansis_Dashboard\rapor10.xml")
        Form45.Show()
    End Sub

    Private Sub ÜretimSarfTüketimRaporToolStripMenuItem_Click_1(sender As Object, e As EventArgs)
        Form45.MdiParent = Me
        Form45.DashboardViewer1.LoadDashboard("C:\Alansis_Dashboard\rapor11.xml")
        Form45.Show()
    End Sub

    Private Sub ToolStripMenuItem16_Click(sender As Object, e As EventArgs)
        Form76.MdiParent = Me
        Form76.Show()
    End Sub

    Private Sub PoşetTipiToolStripMenuItem_Click(sender As Object, e As EventArgs)
        Form77.MdiParent = Me
        Form77.Show()
    End Sub

    Private Sub ŞeritTipiToolStripMenuItem_Click(sender As Object, e As EventArgs)
        Form78.MdiParent = Me
        Form78.Show()
    End Sub

    Private Sub KIVIParametreToolStripMenuItem_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub SatışGirişModuluToolStripMenuItem_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub KIVIUretimSarfFireGirişToolStripMenuItem1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub KIVIUretimAnlıkİzlemeToolStripMenuItem1_Click(sender As Object, e As EventArgs)
        Form80.MdiParent = Me
        Form80.Show()
    End Sub

    Private Sub KIVISarfİzlemeToolStripMenuItem_Click(sender As Object, e As EventArgs)
        Form81.MdiParent = Me
        Form81.Show()
    End Sub

    Private Sub KIVIFireGirişToolStripMenuItem_Click(sender As Object, e As EventArgs)
        Form82.MdiParent = Me
        Form82.Show()
    End Sub

    Private Sub KIVIPartiAktarımToolStripMenuItem_Click(sender As Object, e As EventArgs)
        Form84.MdiParent = Me
        Form84.Show()
    End Sub

    Private Sub NARÜretimSarfRaporToolStripMenuItem1_Click(sender As Object, e As EventArgs)
        Form29.MdiParent = Me
        Form29.Show()
    End Sub

    Private Sub KIVIUretimSarfRaporToolStripMenuItem_Click(sender As Object, e As EventArgs)
        Form85.MdiParent = Me
        Form85.Show()
    End Sub

    Private Sub KIVIDepoİzlemeVeRaporToolStripMenuItem_Click(sender As Object, e As EventArgs)
        Form86.MdiParent = Me
        Form86.Show()
    End Sub

    Private Sub RaporAçToolStripMenuItem_Click(sender As Object, e As EventArgs)
        If OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            OpenFileDialog1.InitialDirectory = "C:\"
            OpenFileDialog1.Title = "Rapor Dosyası Aç" 'Set the title name of the OpenDialog Box  
            OpenFileDialog1.Filter = "Rapor|*.xml" 'Set the filter to display only image.  
            Form88.MdiParent = Me
            Form88.DashboardViewer1.LoadDashboard(OpenFileDialog1.FileName)
            Form88.Show()

        End If
    End Sub

    Private Sub OpenFileDialog1_FileOk(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles OpenFileDialog1.FileOk

    End Sub

    Private Sub KIVIUretimTarihToolStripMenuItem_Click(sender As Object, e As EventArgs)
        Form89.MdiParent = Me
        Form89.Show()
    End Sub

    Private Sub KIVISarfFireRaporToolStripMenuItem_Click(sender As Object, e As EventArgs)
        Form90.MdiParent = Me
        Form90.Show()
    End Sub

    Private Sub DepoHammaddeMalKabulFireRaporToolStripMenuItem_Click(sender As Object, e As EventArgs)
        Form92.MdiParent = Me
        Form92.Show()
    End Sub

    Private Sub SatışVeriAnalizModuluToolStripMenuItem_Click(sender As Object, e As EventArgs)

    End Sub
    Private Sub SatınalmaRaporToolStripMenuItem_Click(sender As Object, e As EventArgs)
        Form103.MdiParent = Me
        Form103.DashboardViewer1.LoadDashboard("C:\Alansis_Dashboard\satsip_rapor.xml")
        Form103.Show()
    End Sub
    Private Sub ToolStripMenuItem18_Click(sender As Object, e As EventArgs)
        Form104.MdiParent = Me
        Form104.Show()
    End Sub
    Private Sub BarButtonItem1_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem1.ItemClick
        Form104.MdiParent = Me
        Form104.Show()
    End Sub

    Private Sub BarButtonItem8_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem8.ItemClick
        Form131.ComboBoxEdit18.Enabled = True 'SATIS_ONAY
        Form131.ComboBoxEdit16.Enabled = False 'URETIM_ONAY
        Form131.SimpleButton5.Enabled = True
        Form131.SimpleButton4.Enabled = True
        Form131.TextBox1.Text = "1"
        Form131.MdiParent = Me
        Form131.Show()
    End Sub

    Private Sub BarButtonItem9_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem9.ItemClick
        Form97.MdiParent = Me
        Form97.Show()
    End Sub

    Private Sub BarButtonItem10_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem10.ItemClick
        Form98.MdiParent = Me
        Form98.Show()
    End Sub

    Private Sub BarButtonItem11_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem11.ItemClick
        Form95.MdiParent = Me
        Form95.Show()
    End Sub

    Private Sub BarButtonItem2_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem2.ItemClick
        Form108.MdiParent = Me
        Form108.Show()
    End Sub

    Private Sub BarButtonItem3_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem3.ItemClick
        Form109.MdiParent = Me
        Form109.Show()
    End Sub

    Private Sub BarButtonItem4_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem4.ItemClick
        Form110.MdiParent = Me
        Form110.Show()
    End Sub

    Private Sub SatıcıSiparişKayıtToolStripMenuItem_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub BarButtonItem13_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem13.ItemClick
        Form26.MdiParent = Me
        Form26.Show()
    End Sub

    Private Sub BarButtonItem6_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem6.ItemClick
        Form113.MdiParent = Me
        Form113.Show()
    End Sub

    Private Sub BarButtonItem14_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem14.ItemClick
        Form86.MdiParent = Me
        Form86.Show()
    End Sub

    Private Sub BarButtonItem15_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem15.ItemClick
        Form92.MdiParent = Me
        Form92.Show()
    End Sub

    Private Sub BarButtonItem16_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem16.ItemClick
        Form22.MdiParent = Me
        Form22.Show()
    End Sub

    Private Sub BarButtonItem17_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem17.ItemClick
        Form24.MdiParent = Me
        Form24.Show()
    End Sub

    Private Sub BarButtonItem18_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem18.ItemClick
        Form157.MdiParent = Me
        'Form2.Dock = DockStyle.Fill
        Form157.Show()
    End Sub

    Private Sub BarButtonItem19_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem19.ItemClick
        Form85.MdiParent = Me
        Form85.Show()
    End Sub

    Private Sub BarButtonItem20_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem20.ItemClick
        Form90.MdiParent = Me
        Form90.Show()
    End Sub

    Private Sub BarButtonItem21_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem21.ItemClick
        Form29.MdiParent = Me
        Form29.Show()
    End Sub

    Private Sub BarButtonItem25_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem25.ItemClick
        Form13.MdiParent = Me
        Form13.Show()
    End Sub
    Private Sub BarButtonItem26_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem26.ItemClick
        Form8.MdiParent = Me
        Form8.Show()
    End Sub

    Private Sub BarButtonItem27_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem27.ItemClick
        Form10.MdiParent = Me
        Form10.Show()
    End Sub

    Private Sub BarButtonItem28_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem28.ItemClick
        Form9.MdiParent = Me
        Form9.Show()
    End Sub

    Private Sub BarButtonItem29_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem29.ItemClick
        Form11.MdiParent = Me
        'Form2.Dock = DockStyle.Fill
        Form11.Show()
    End Sub

    Private Sub BarButtonItem30_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem30.ItemClick
        Form12.MdiParent = Me
        'Form2.Dock = DockStyle.Fill
        Form12.Show()
    End Sub

    Private Sub BarButtonItem31_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem31.ItemClick
        Form21.MdiParent = Me
        Form21.Show()
    End Sub

    Private Sub BarButtonItem32_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem32.ItemClick
        Form89.MdiParent = Me
        Form89.Show()
    End Sub

    Private Sub BarButtonItem33_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem33.ItemClick
        Form33.MdiParent = Me
        Form33.Show()
    End Sub

    Private Sub BarButtonItem34_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem34.ItemClick
        Form31.MdiParent = Me
        Form31.Show()
    End Sub

    Private Sub BarButtonItem35_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem35.ItemClick
        Form32.MdiParent = Me
        Form32.Show()
    End Sub

    Private Sub BarButtonItem37_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem37.ItemClick
        Form34.MdiParent = Me
        Form34.Show()
    End Sub
    Private Sub BarButtonItem38_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem38.ItemClick
        Form35.MdiParent = Me
        Form35.Show()
    End Sub
    Private Sub BarButtonItem39_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem39.ItemClick
        Form36.MdiParent = Me
        Form36.Show()
    End Sub
    Private Sub BarButtonItem40_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem40.ItemClick
        Form37.MdiParent = Me
        Form37.Show()
    End Sub
    Private Sub BarButtonItem41_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem41.ItemClick
        Form38.MdiParent = Me
        Form38.Show()
    End Sub
    Private Sub BarButtonItem42_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem42.ItemClick
        Form39.MdiParent = Me
        Form39.Show()
    End Sub
    Private Sub BarButtonItem43_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem43.ItemClick
        Form40.MdiParent = Me
        Form40.Show()
    End Sub
    Private Sub BarButtonItem44_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem44.ItemClick
        Form41.MdiParent = Me
        Form41.Show()
    End Sub
    Private Sub BarButtonItem45_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem45.ItemClick
        Form42.MdiParent = Me
        Form42.Show()
    End Sub

    Private Sub BarButtonItem46_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem46.ItemClick
        Form43.MdiParent = Me
        Form43.Show()
    End Sub
    Private Sub BarButtonItem47_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem47.ItemClick
        Form44.MdiParent = Me
        Form44.Show()
    End Sub
    Private Sub BarButtonItem48_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem48.ItemClick
        Form226.MdiParent = Me
        Form226.Show()
    End Sub

    Private Sub BarButtonItem49_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem49.ItemClick
        Form47.MdiParent = Me
        Form47.Show()
    End Sub
    Private Sub BarButtonItem50_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem50.ItemClick
        Form48.MdiParent = Me
        Form48.Show()
    End Sub
    Private Sub BarButtonItem51_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem51.ItemClick
        Form49.MdiParent = Me
        Form49.Show()
    End Sub
    Private Sub BarButtonItem52_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem52.ItemClick
        Form50.MdiParent = Me
        Form50.Show()
    End Sub
    Private Sub BarButtonItem53_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem53.ItemClick
        Form51.MdiParent = Me
        Form51.Show()
    End Sub


    Private Sub BarButtonItem54_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem54.ItemClick
        Form52.MdiParent = Me
        Form52.Show()
    End Sub

    Private Sub BarButtonItem55_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem55.ItemClick
        Form53.MdiParent = Me
        Form53.Show()
    End Sub

    Private Sub BarButtonItem56_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem56.ItemClick
        Form54.MdiParent = Me
        Form54.Show()
    End Sub

    Private Sub BarButtonItem57_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem57.ItemClick
        Form55.MdiParent = Me
        Form55.Show()
    End Sub

    Private Sub BarButtonItem58_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem58.ItemClick
        Form56.MdiParent = Me
        Form56.Show()
    End Sub

    Private Sub BarButtonItem59_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem59.ItemClick
        Form57.MdiParent = Me
        Form57.Show()
    End Sub


    Private Sub BarButtonItem60_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem60.ItemClick
        Form58.MdiParent = Me
        Form58.Show()
    End Sub

    Private Sub BarButtonItem61_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem61.ItemClick
        Form59.MdiParent = Me
        Form59.Show()
    End Sub

    Private Sub BarButtonItem62_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem62.ItemClick
        Form60.MdiParent = Me
        Form60.Show()
    End Sub

    Private Sub BarButtonItem63_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem63.ItemClick
        Form73.MdiParent = Me
        Form73.Show()
    End Sub

    Private Sub BarButtonItem64_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem64.ItemClick
        Form62.MdiParent = Me
        Form62.Show()
    End Sub



    Private Sub BarButtonItem65_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem65.ItemClick
        Form62.MdiParent = Me
        Form62.Show()
    End Sub

    Private Sub BarButtonItem66_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem66.ItemClick
        Form63.MdiParent = Me
        Form63.Show()
    End Sub

    Private Sub BarButtonItem67_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem67.ItemClick
        Form64.MdiParent = Me
        Form64.Show()
    End Sub

    Private Sub BarButtonItem68_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem68.ItemClick
        Form65.MdiParent = Me
        Form65.Show()
    End Sub

    Private Sub BarButtonItem69_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem69.ItemClick
        Form66.MdiParent = Me
        Form66.Show()
    End Sub

    Private Sub BarButtonItem70_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem70.ItemClick
        Form68.MdiParent = Me
        Form68.Show()
    End Sub

    Private Sub BarButtonItem71_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem71.ItemClick
        Form69.MdiParent = Me
        Form69.Show()
    End Sub

    Private Sub BarButtonItem72_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem72.ItemClick
        Form70.MdiParent = Me
        Form70.Show()
    End Sub

    Private Sub BarButtonItem73_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem73.ItemClick
        Form71.MdiParent = Me
        Form71.Show()
    End Sub


    Private Sub BarButtonItem74_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem74.ItemClick

    End Sub

    Private Sub BarButtonItem75_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem75.ItemClick
        Form80.MdiParent = Me
        Form80.Show()
    End Sub

    Private Sub BarButtonItem76_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem76.ItemClick
        Form81.MdiParent = Me
        Form81.Show()
    End Sub

    Private Sub BarButtonItem77_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem77.ItemClick
        Form82.MdiParent = Me
        Form82.Show()
    End Sub

    Private Sub BarButtonItem78_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem78.ItemClick
        Form84.MdiParent = Me
        Form84.Show()
    End Sub




    Private Sub BarButtonItem79_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem79.ItemClick
        Form3.MdiParent = Me
        Form3.Show()
    End Sub

    Private Sub BarButtonItem80_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem80.ItemClick
        Form4.MdiParent = Me
        Form4.Show()
    End Sub

    Private Sub BarButtonItem81_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem81.ItemClick
        Form5.MdiParent = Me
        Form5.Show()
    End Sub

    Private Sub BarButtonItem82_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem82.ItemClick
        Form6.MdiParent = Me
        Form6.Show()
    End Sub

    Private Sub BarButtonItem83_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem83.ItemClick
        Form7.MdiParent = Me
        Form7.Show()
    End Sub

    Private Sub BarButtonItem84_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem84.ItemClick
        Form14.MdiParent = Me
        Form14.Show()
    End Sub

    Private Sub BarButtonItem85_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem85.ItemClick
        Form15.MdiParent = Me
        Form15.Show()
    End Sub

    Private Sub BarButtonItem86_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem86.ItemClick
        Form17.MdiParent = Me
        Form17.Show()
    End Sub

    Private Sub BarButtonItem87_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem87.ItemClick
        Form18.MdiParent = Me
        Form18.Show()
    End Sub

    Private Sub BarButtonItem88_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem88.ItemClick
        Form19.MdiParent = Me
        Form19.Show()
    End Sub

    Private Sub BarButtonItem89_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem89.ItemClick
        Form20.MdiParent = Me
        Form20.Show()
    End Sub

    Private Sub BarButtonItem90_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem90.ItemClick
        Form23.MdiParent = Me
        Form23.Show()
    End Sub

    Private Sub BarButtonItem91_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem91.ItemClick
        Form27.MdiParent = Me
        Form27.Show()
    End Sub

    Private Sub BarButtonItem92_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem92.ItemClick
        Form28.MdiParent = Me
        Form28.Show()
    End Sub

    Private Sub BarButtonItem93_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem93.ItemClick
        Form46.MdiParent = Me
        Form46.Show()
    End Sub

    Private Sub BarButtonItem94_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem94.ItemClick
        Form168.MdiParent = Me
        Form168.Show()
    End Sub

    Private Sub BarButtonItem95_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem95.ItemClick
        If OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            OpenFileDialog1.InitialDirectory = "C:\"
            OpenFileDialog1.Title = "Rapor Dosyası Aç" 'Set the title name of the OpenDialog Box  
            OpenFileDialog1.Filter = "Rapor|*.xml" 'Set the filter to display only image.  
            Form88.MdiParent = Me
            Form88.DashboardViewer1.LoadDashboard(OpenFileDialog1.FileName)
            Form88.Show()

        End If
    End Sub

    Private Sub BarButtonItem96_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem96.ItemClick
        Form45.MdiParent = Me
        Form45.DashboardViewer1.LoadDashboard("C:\Alansis_Dashboard\rapor5.xml")
        Form45.Show()
    End Sub

    Private Sub BarButtonItem97_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem97.ItemClick
        Form45.MdiParent = Me
        Form45.DashboardViewer1.LoadDashboard("C:\Alansis_Dashboard\rapor6.xml")
        Form45.Show()
    End Sub
    Private Sub BarButtonItem98_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem98.ItemClick
        'Form103.MdiParent = Me
        'Form103.DashboardViewer1.LoadDashboard("C:\Alansis_Dashboard\satsip_rapor.xml")
        'Form103.Show()
        Form175.MdiParent = Me
        Form175.Show()
    End Sub

    Private Sub BarButtonItem12_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem12.ItemClick
        Form112.MdiParent = Me
        Form112.Show()
    End Sub

    Private Sub RibbonControl1_Click(sender As Object, e As EventArgs) Handles RibbonControl1.Click

    End Sub

    Private Sub BarButtonItem100_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem100.ItemClick
        Form114.MdiParent = Me
        Form114.Show()
    End Sub

    Private Sub BarButtonItem101_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem101.ItemClick
        Form116.MdiParent = Me
        Form116.Show()
    End Sub

    Private Sub BarButtonItem102_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem102.ItemClick
        Form131.MdiParent = Me
        Form131.Show()
    End Sub

    Private Sub BarButtonItem105_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem105.ItemClick
        Form122.MdiParent = Me
        Form122.Show()
    End Sub

    Private Sub BarButtonItem104_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem104.ItemClick
        Form121.MdiParent = Me
        Form121.Show()
    End Sub

    Private Sub BarButtonItem103_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem103.ItemClick
        Form120.MdiParent = Me
        Form120.Show()
    End Sub

    Private Sub BarButtonItem106_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem106.ItemClick
        Form123.MdiParent = Me
        Form123.Show()
    End Sub

    Private Sub BarButtonItem107_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem107.ItemClick
        Form124.MdiParent = Me
        Form124.Show()
    End Sub

    Private Sub BarButtonItem108_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem108.ItemClick
        Form125.MdiParent = Me
        Form125.Show()
    End Sub

    Private Sub BarButtonItem109_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem109.ItemClick
        Form126.MdiParent = Me
        Form126.Show()
    End Sub

    Private Sub BarButtonItem110_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem110.ItemClick
        Form127.MdiParent = Me
        Form127.Show()
    End Sub

    Private Sub BarButtonItem111_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem111.ItemClick
        Form128.MdiParent = Me
        Form128.Show()
    End Sub
    Private Sub BarButtonItem112_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem112.ItemClick
        Form129.MdiParent = Me
        Form129.Show()
    End Sub
    Private Sub BarButtonItem115_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem115.ItemClick
        Form130.MdiParent = Me
        Form130.Show()
    End Sub

    Private Sub BarButtonItem116_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem116.ItemClick
        Form132.MdiParent = Me
        Form132.Show()
    End Sub

    Private Sub BarButtonItem117_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem117.ItemClick
        Form133.MdiParent = Me
        Form133.Show()
    End Sub

    Private Sub BarButtonItem118_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem118.ItemClick
        Form134.MdiParent = Me
        Form134.Show()
    End Sub

    Private Sub BarButtonItem119_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem119.ItemClick
        Form135.MdiParent = Me
        Form135.Show()
    End Sub

    Private Sub BarButtonItem121_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem121.ItemClick
        Form136.MdiParent = Me
        Form136.Show()
    End Sub

    Private Sub BarButtonItem122_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem122.ItemClick
        Form137.MdiParent = Me
        Form137.Show()
    End Sub
    Private Sub BarButtonItem120_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem120.ItemClick
        Form138.MdiParent = Me
        Form138.Show()
    End Sub

    Private Sub BarButtonItem124_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem124.ItemClick
        Form144.MdiParent = Me
        Form144.Show()
    End Sub

    Private Sub BarButtonItem125_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem125.ItemClick
        Form145.MdiParent = Me
        Form145.Show()
    End Sub

    Private Sub BarButtonItem126_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem126.ItemClick
        Form146.MdiParent = Me
        Form146.Show()
    End Sub

    Private Sub BarButtonItem127_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem127.ItemClick
        Form148.MdiParent = Me
        Form148.Show()
    End Sub

    Private Sub BarButtonItem128_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem128.ItemClick
        Form150.MdiParent = Me
        Form150.Show()
    End Sub
    Private Sub BarButtonItem130_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem130.ItemClick
        Form151.MdiParent = Me
        Form151.Show()
    End Sub
    Private Sub BarButtonItem123_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem123.ItemClick
        Form143.MdiParent = Me
        Form143.Show()
    End Sub
    Private Sub BarButtonItem131_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem131.ItemClick
        Form153.MdiParent = Me
        Form153.Show()
    End Sub
    Private Sub BarButtonItem133_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem133.ItemClick
        Form155.MdiParent = Me
        Form155.Show()
    End Sub
    Private Sub BarButtonItem134_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem134.ItemClick
        Form14.MdiParent = Me
        Form14.Show()
    End Sub

    Private Sub BarButtonItem135_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem135.ItemClick
        Form15.MdiParent = Me
        Form15.Show()
    End Sub
    Private Sub BarButtonItem136_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem136.ItemClick
        Form17.MdiParent = Me
        Form17.Show()
    End Sub
    Private Sub BarButtonItem137_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem137.ItemClick
        Form18.MdiParent = Me
        Form18.Show()
    End Sub
    Private Sub BarButtonItem138_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem138.ItemClick
        Form19.MdiParent = Me
        Form19.Show()
    End Sub

    Private Sub BarButtonItem139_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem139.ItemClick
        Form20.MdiParent = Me
        Form20.Show()
    End Sub
    Private Sub BarButtonItem140_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem140.ItemClick
        Form23.MdiParent = Me
        Form23.Show()
    End Sub
    Private Sub BarButtonItem141_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem141.ItemClick
        Form156.MdiParent = Me
        Form156.Show()
    End Sub
    Private Sub BarButtonItem142_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem142.ItemClick
        Form158.MdiParent = Me
        Form158.Show()
    End Sub
    Private Sub BarButtonItem143_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem143.ItemClick
        Form157.MdiParent = Me
        Form157.Show()
    End Sub
    Private Sub BarButtonItem146_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem146.ItemClick
        Form159.MdiParent = Me
        Form159.Show()
    End Sub
    Private Sub BarButtonItem147_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem147.ItemClick
        Form160.MdiParent = Me
        Form160.Show()
    End Sub
    Private Sub BarButtonItem148_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem148.ItemClick
        Form181.MdiParent = Me
        Form181.Show()
    End Sub
    Private Sub BarButtonItem149_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem149.ItemClick
        Form166.MdiParent = Me
        Form166.Show()
    End Sub

    Private Sub BarButtonItem150_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem150.ItemClick
        Form167.MdiParent = Me
        Form167.Show()
    End Sub

    Private Sub BarButtonItem151_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem151.ItemClick
        Form167.MdiParent = Me
        Form167.Show()
    End Sub

    Private Sub BarButtonItem152_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem152.ItemClick
        Form169.MdiParent = Me
        Form169.Show()
    End Sub

    Private Sub BarButtonItem153_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem153.ItemClick
        'Form170.MdiParent = Me
        'Form170.Show()
        Form179.MdiParent = Me
        Form179.Show()
    End Sub

    Private Sub BarButtonItem154_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem154.ItemClick
        Form177.MdiParent = Me
        Form177.Show()
    End Sub

    Private Sub BarButtonItem155_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem155.ItemClick
        Form172.MdiParent = Me
        Form172.Show()
    End Sub

    Private Sub BarButtonItem156_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem156.ItemClick
        Form173.MdiParent = Me
        Form173.Show()
    End Sub

    Private Sub BarButtonItem158_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem158.ItemClick
        Form174.MdiParent = Me
        Form174.Show()
    End Sub

    Private Sub BarButtonItem159_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem159.ItemClick
        Form176.MdiParent = Me
        Form176.Show()
    End Sub

    Private Sub BarButtonItem160_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem160.ItemClick
        Form178.MdiParent = Me
        Form178.Show()
    End Sub

    Private Sub BarButtonItem161_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem161.ItemClick
        Form180.MdiParent = Me
        Form180.Show()
    End Sub

    Private Sub BarButtonItem164_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem164.ItemClick
        Form182.MdiParent = Me
        Form182.Show()
    End Sub

    Private Sub BarButtonItem165_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem165.ItemClick
        Form179.MdiParent = Me
        Form179.Show()
    End Sub

    Private Sub BarButtonItem166_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem166.ItemClick
        Form183.MdiParent = Me
        Form183.Show()
    End Sub

    Private Sub BarButtonItem167_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem167.ItemClick
        Form184.MdiParent = Me
        Form184.Show()
    End Sub

    Private Sub BarButtonItem168_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem168.ItemClick
        Form185.MdiParent = Me
        Form185.Show()
    End Sub

    Private Sub BarButtonItem169_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem169.ItemClick

    End Sub

    Private Sub BarButtonItem170_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem170.ItemClick
        Form186.MdiParent = Me
        Form186.Show()
    End Sub

    Private Sub BarButtonItem171_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem171.ItemClick
        Form187.MdiParent = Me
        Form187.Show()
    End Sub

    Private Sub BarButtonItem172_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem172.ItemClick
        Form188.MdiParent = Me
        Form188.Show()
    End Sub

    Private Sub BarButtonItem173_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem173.ItemClick
        Form189.MdiParent = Me
        Form189.Show()
    End Sub

    Private Sub BarButtonItem174_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem174.ItemClick
        Form190.MdiParent = Me
        Form190.Show()
    End Sub

    Private Sub BarButtonItem175_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem175.ItemClick
        Form191.MdiParent = Me
        Form191.Show()
    End Sub

    Private Sub BarButtonItem177_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem177.ItemClick
        Form192.MdiParent = Me
        Form192.Show()
    End Sub
    Private Sub BarButtonItem190_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem190.ItemClick
        Form193.MdiParent = Me
        Form193.Show()
    End Sub
    Private Sub BarButtonItem178_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem178.ItemClick
        Form194.MdiParent = Me
        Form194.Show()
    End Sub
    Private Sub BarButtonItem191_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem191.ItemClick
        Form195.MdiParent = Me
        Form195.Show()
    End Sub

    Private Sub BarButtonItem179_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem179.ItemClick
        Form196.MdiParent = Me
        Form196.Show()
    End Sub

    Private Sub BarButtonItem192_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem192.ItemClick
        Form197.MdiParent = Me
        Form197.Show()
    End Sub

    Private Sub BarButtonItem180_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem180.ItemClick
        Form198.MdiParent = Me
        Form198.Show()
    End Sub

    Private Sub BarButtonItem193_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem193.ItemClick
        Form199.MdiParent = Me
        Form199.Show()
    End Sub

    Private Sub BarButtonItem181_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem181.ItemClick
        Form200.MdiParent = Me
        Form200.Show()
    End Sub

    Private Sub BarButtonItem194_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem194.ItemClick
        Form201.MdiParent = Me
        Form201.Show()
    End Sub

    Private Sub BarButtonItem182_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem182.ItemClick
        Form202.MdiParent = Me
        Form202.Show()
    End Sub

    Private Sub BarButtonItem195_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem195.ItemClick
        Form203.MdiParent = Me
        Form203.Show()
    End Sub

    Private Sub BarButtonItem183_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem183.ItemClick
        Form204.MdiParent = Me
        Form204.Show()
    End Sub

    Private Sub BarButtonItem196_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem196.ItemClick
        Form205.MdiParent = Me
        Form205.Show()
    End Sub

    Private Sub BarButtonItem184_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem184.ItemClick
        Form206.MdiParent = Me
        Form206.Show()
    End Sub

    Private Sub BarButtonItem197_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem197.ItemClick
        Form207.MdiParent = Me
        Form207.Show()
    End Sub

    Private Sub BarButtonItem185_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem185.ItemClick
        Form208.MdiParent = Me
        Form208.Show()
    End Sub

    Private Sub BarButtonItem198_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem198.ItemClick
        Form209.MdiParent = Me
        Form209.Show()
    End Sub

    Private Sub BarButtonItem186_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem186.ItemClick
        Form210.MdiParent = Me
        Form210.Show()
    End Sub

    Private Sub BarButtonItem199_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem199.ItemClick
        Form211.MdiParent = Me
        Form211.Show()
    End Sub

    Private Sub BarButtonItem187_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem187.ItemClick
        Form212.MdiParent = Me
        Form212.Show()
    End Sub

    Private Sub BarButtonItem200_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem200.ItemClick
        Form213.MdiParent = Me
        Form213.Show()
    End Sub

    Private Sub BarButtonItem188_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem188.ItemClick
        Form214.MdiParent = Me
        Form214.Show()
    End Sub

    Private Sub BarButtonItem201_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem201.ItemClick
        Form215.MdiParent = Me
        Form215.Show()
    End Sub

    Private Sub BarButtonItem189_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem189.ItemClick
        Form216.MdiParent = Me
        Form216.Show()
    End Sub

    Private Sub BarButtonItem202_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem202.ItemClick
        Form217.MdiParent = Me
        Form217.Show()
    End Sub

    Private Sub BarButtonItem203_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem203.ItemClick
        Form218.MdiParent = Me
        Form218.Show()
    End Sub

    Private Sub BarButtonItem205_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem205.ItemClick
        Form219.MdiParent = Me
        Form219.Show()
    End Sub

    Private Sub BarButtonItem204_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem204.ItemClick
        Form220.MdiParent = Me
        Form220.Show()
    End Sub

    Private Sub BarButtonItem206_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem206.ItemClick
        Form221.MdiParent = Me
        Form221.Show()
    End Sub

    Private Sub BarButtonItem207_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem207.ItemClick
        Form225.MdiParent = Me
        Form225.Show()
    End Sub

    Private Sub BarButtonItem208_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem208.ItemClick

    End Sub

    Private Sub BarButtonItem209_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem209.ItemClick
        Form227.MdiParent = Me
        Form227.Show()
    End Sub

    Private Sub BarButtonItem211_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem211.ItemClick
        Form229.MdiParent = Me
        Form229.Show()
    End Sub

    Private Sub BarButtonItem210_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem210.ItemClick
        Form228.MdiParent = Me
        Form228.Show()
    End Sub

    Private Sub BarButtonItem212_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem212.ItemClick
        Form231.ComboBoxEdit2.Enabled = False
        Form231.MdiParent = Me
        Form231.Show()
    End Sub

    Private Sub BarButtonItem213_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem213.ItemClick
        Form232.MdiParent = Me
        Form232.Show()
    End Sub

    Private Sub BarButtonItem214_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem214.ItemClick
        Form233.MdiParent = Me
        Form233.Show()
    End Sub
End Class