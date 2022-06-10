<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form173
    Inherits DevExpress.XtraEditors.XtraForm

    'Form, bileşen listesini temizlemeyi bırakmayı geçersiz kılar.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Windows Form Tasarımcısı tarafından gerektirilir
    Private components As System.ComponentModel.IContainer

    'NOT: Aşağıdaki yordam Windows Form Tasarımcısı için gereklidir
    'Windows Form Tasarımcısı kullanılarak değiştirilebilir.  
    'Kod düzenleyicisini kullanarak değiştirmeyin.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form173))
        Me.FormAssistant1 = New DevExpress.XtraBars.FormAssistant()
        Me.DefaultLookAndFeel1 = New DevExpress.LookAndFeel.DefaultLookAndFeel(Me.components)
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton()
        Me.SimpleButton2 = New DevExpress.XtraEditors.SimpleButton()
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.ALANSISDataSet65 = New WindowsApplication1.ALANSISDataSet65()
        Me.EOALANSISKIRAZMAMULDEPOBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.EO_ALANSIS_KIRAZ_MAMULDEPOTableAdapter = New WindowsApplication1.ALANSISDataSet65TableAdapters.EO_ALANSIS_KIRAZ_MAMULDEPOTableAdapter()
        Me.colID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTARIH = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSTOK_KODU = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSERI = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colMIKTAR = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colBOLGE = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colEBAT = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colISLEM = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colKIRAZ_ISLEM = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colODA = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colKALINTI = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDARA = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colBRUT = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDEPO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTIP = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPARTINO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colURETIM_TIPI = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCESIT = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colUSR = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colACIKLAMA = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colRENK = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSTOK_ISLEM = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colAKTARILAN_URETICI = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colAKTARILAN_KUTUSAYI = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colAKTARILAN_KG = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSEVK_ONAY = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSEVK_MIKTAR = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSEVKID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.coltest = New DevExpress.XtraGrid.Columns.GridColumn()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ALANSISDataSet65, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EOALANSISKIRAZMAMULDEPOBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DefaultLookAndFeel1
        '
        Me.DefaultLookAndFeel1.LookAndFeel.SkinName = "Office 2007 Blue"
        '
        'SimpleButton1
        '
        Me.SimpleButton1.ImageOptions.Image = CType(resources.GetObject("SimpleButton1.ImageOptions.Image"), System.Drawing.Image)
        Me.SimpleButton1.Location = New System.Drawing.Point(1, 2)
        Me.SimpleButton1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(41, 41)
        Me.SimpleButton1.TabIndex = 5
        '
        'SimpleButton2
        '
        Me.SimpleButton2.Location = New System.Drawing.Point(61, 2)
        Me.SimpleButton2.Name = "SimpleButton2"
        Me.SimpleButton2.Size = New System.Drawing.Size(195, 41)
        Me.SimpleButton2.TabIndex = 7
        Me.SimpleButton2.Text = "SimpleButton2"
        '
        'GridControl1
        '
        Me.GridControl1.DataSource = Me.EOALANSISKIRAZMAMULDEPOBindingSource
        Me.GridControl1.Location = New System.Drawing.Point(1, 50)
        Me.GridControl1.MainView = Me.GridView1
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.Size = New System.Drawing.Size(1383, 465)
        Me.GridControl1.TabIndex = 8
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colID, Me.colTARIH, Me.colSTOK_KODU, Me.colSERI, Me.colMIKTAR, Me.colBOLGE, Me.colEBAT, Me.colISLEM, Me.colKIRAZ_ISLEM, Me.colODA, Me.colKALINTI, Me.colDARA, Me.colBRUT, Me.colDEPO, Me.colTIP, Me.colPARTINO, Me.colURETIM_TIPI, Me.colCESIT, Me.colUSR, Me.colACIKLAMA, Me.colRENK, Me.colSTOK_ISLEM, Me.colAKTARILAN_URETICI, Me.colAKTARILAN_KUTUSAYI, Me.colAKTARILAN_KG, Me.colSEVK_ONAY, Me.colSEVK_MIKTAR, Me.colSEVKID, Me.coltest})
        Me.GridView1.GridControl = Me.GridControl1
        Me.GridView1.Name = "GridView1"
        '
        'ALANSISDataSet65
        '
        Me.ALANSISDataSet65.DataSetName = "ALANSISDataSet65"
        Me.ALANSISDataSet65.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'EOALANSISKIRAZMAMULDEPOBindingSource
        '
        Me.EOALANSISKIRAZMAMULDEPOBindingSource.DataMember = "EO_ALANSIS_KIRAZ_MAMULDEPO"
        Me.EOALANSISKIRAZMAMULDEPOBindingSource.DataSource = Me.ALANSISDataSet65
        '
        'EO_ALANSIS_KIRAZ_MAMULDEPOTableAdapter
        '
        Me.EO_ALANSIS_KIRAZ_MAMULDEPOTableAdapter.ClearBeforeFill = True
        '
        'colID
        '
        Me.colID.FieldName = "ID"
        Me.colID.MinWidth = 25
        Me.colID.Name = "colID"
        Me.colID.Visible = True
        Me.colID.VisibleIndex = 0
        Me.colID.Width = 94
        '
        'colTARIH
        '
        Me.colTARIH.FieldName = "TARIH"
        Me.colTARIH.MinWidth = 25
        Me.colTARIH.Name = "colTARIH"
        Me.colTARIH.Visible = True
        Me.colTARIH.VisibleIndex = 1
        Me.colTARIH.Width = 94
        '
        'colSTOK_KODU
        '
        Me.colSTOK_KODU.FieldName = "STOK_KODU"
        Me.colSTOK_KODU.MinWidth = 25
        Me.colSTOK_KODU.Name = "colSTOK_KODU"
        Me.colSTOK_KODU.Visible = True
        Me.colSTOK_KODU.VisibleIndex = 2
        Me.colSTOK_KODU.Width = 94
        '
        'colSERI
        '
        Me.colSERI.FieldName = "SERI"
        Me.colSERI.MinWidth = 25
        Me.colSERI.Name = "colSERI"
        Me.colSERI.Visible = True
        Me.colSERI.VisibleIndex = 3
        Me.colSERI.Width = 94
        '
        'colMIKTAR
        '
        Me.colMIKTAR.FieldName = "MIKTAR"
        Me.colMIKTAR.MinWidth = 25
        Me.colMIKTAR.Name = "colMIKTAR"
        Me.colMIKTAR.Visible = True
        Me.colMIKTAR.VisibleIndex = 4
        Me.colMIKTAR.Width = 94
        '
        'colBOLGE
        '
        Me.colBOLGE.FieldName = "BOLGE"
        Me.colBOLGE.MinWidth = 25
        Me.colBOLGE.Name = "colBOLGE"
        Me.colBOLGE.Visible = True
        Me.colBOLGE.VisibleIndex = 5
        Me.colBOLGE.Width = 94
        '
        'colEBAT
        '
        Me.colEBAT.FieldName = "EBAT"
        Me.colEBAT.MinWidth = 25
        Me.colEBAT.Name = "colEBAT"
        Me.colEBAT.Visible = True
        Me.colEBAT.VisibleIndex = 6
        Me.colEBAT.Width = 94
        '
        'colISLEM
        '
        Me.colISLEM.FieldName = "ISLEM"
        Me.colISLEM.MinWidth = 25
        Me.colISLEM.Name = "colISLEM"
        Me.colISLEM.Visible = True
        Me.colISLEM.VisibleIndex = 7
        Me.colISLEM.Width = 94
        '
        'colKIRAZ_ISLEM
        '
        Me.colKIRAZ_ISLEM.FieldName = "KIRAZ_ISLEM"
        Me.colKIRAZ_ISLEM.MinWidth = 25
        Me.colKIRAZ_ISLEM.Name = "colKIRAZ_ISLEM"
        Me.colKIRAZ_ISLEM.Visible = True
        Me.colKIRAZ_ISLEM.VisibleIndex = 8
        Me.colKIRAZ_ISLEM.Width = 94
        '
        'colODA
        '
        Me.colODA.FieldName = "ODA"
        Me.colODA.MinWidth = 25
        Me.colODA.Name = "colODA"
        Me.colODA.Visible = True
        Me.colODA.VisibleIndex = 9
        Me.colODA.Width = 94
        '
        'colKALINTI
        '
        Me.colKALINTI.FieldName = "KALINTI"
        Me.colKALINTI.MinWidth = 25
        Me.colKALINTI.Name = "colKALINTI"
        Me.colKALINTI.Visible = True
        Me.colKALINTI.VisibleIndex = 10
        Me.colKALINTI.Width = 94
        '
        'colDARA
        '
        Me.colDARA.FieldName = "DARA"
        Me.colDARA.MinWidth = 25
        Me.colDARA.Name = "colDARA"
        Me.colDARA.Visible = True
        Me.colDARA.VisibleIndex = 11
        Me.colDARA.Width = 94
        '
        'colBRUT
        '
        Me.colBRUT.FieldName = "BRUT"
        Me.colBRUT.MinWidth = 25
        Me.colBRUT.Name = "colBRUT"
        Me.colBRUT.Visible = True
        Me.colBRUT.VisibleIndex = 12
        Me.colBRUT.Width = 94
        '
        'colDEPO
        '
        Me.colDEPO.FieldName = "DEPO"
        Me.colDEPO.MinWidth = 25
        Me.colDEPO.Name = "colDEPO"
        Me.colDEPO.Visible = True
        Me.colDEPO.VisibleIndex = 13
        Me.colDEPO.Width = 94
        '
        'colTIP
        '
        Me.colTIP.FieldName = "TIP"
        Me.colTIP.MinWidth = 25
        Me.colTIP.Name = "colTIP"
        Me.colTIP.Visible = True
        Me.colTIP.VisibleIndex = 14
        Me.colTIP.Width = 94
        '
        'colPARTINO
        '
        Me.colPARTINO.FieldName = "PARTINO"
        Me.colPARTINO.MinWidth = 25
        Me.colPARTINO.Name = "colPARTINO"
        Me.colPARTINO.Visible = True
        Me.colPARTINO.VisibleIndex = 15
        Me.colPARTINO.Width = 94
        '
        'colURETIM_TIPI
        '
        Me.colURETIM_TIPI.FieldName = "URETIM_TIPI"
        Me.colURETIM_TIPI.MinWidth = 25
        Me.colURETIM_TIPI.Name = "colURETIM_TIPI"
        Me.colURETIM_TIPI.Visible = True
        Me.colURETIM_TIPI.VisibleIndex = 16
        Me.colURETIM_TIPI.Width = 94
        '
        'colCESIT
        '
        Me.colCESIT.FieldName = "CESIT"
        Me.colCESIT.MinWidth = 25
        Me.colCESIT.Name = "colCESIT"
        Me.colCESIT.Visible = True
        Me.colCESIT.VisibleIndex = 17
        Me.colCESIT.Width = 94
        '
        'colUSR
        '
        Me.colUSR.FieldName = "USR"
        Me.colUSR.MinWidth = 25
        Me.colUSR.Name = "colUSR"
        Me.colUSR.Visible = True
        Me.colUSR.VisibleIndex = 18
        Me.colUSR.Width = 94
        '
        'colACIKLAMA
        '
        Me.colACIKLAMA.FieldName = "ACIKLAMA"
        Me.colACIKLAMA.MinWidth = 25
        Me.colACIKLAMA.Name = "colACIKLAMA"
        Me.colACIKLAMA.Visible = True
        Me.colACIKLAMA.VisibleIndex = 19
        Me.colACIKLAMA.Width = 94
        '
        'colRENK
        '
        Me.colRENK.FieldName = "RENK"
        Me.colRENK.MinWidth = 25
        Me.colRENK.Name = "colRENK"
        Me.colRENK.Visible = True
        Me.colRENK.VisibleIndex = 20
        Me.colRENK.Width = 94
        '
        'colSTOK_ISLEM
        '
        Me.colSTOK_ISLEM.FieldName = "STOK_ISLEM"
        Me.colSTOK_ISLEM.MinWidth = 25
        Me.colSTOK_ISLEM.Name = "colSTOK_ISLEM"
        Me.colSTOK_ISLEM.Visible = True
        Me.colSTOK_ISLEM.VisibleIndex = 21
        Me.colSTOK_ISLEM.Width = 94
        '
        'colAKTARILAN_URETICI
        '
        Me.colAKTARILAN_URETICI.FieldName = "AKTARILAN_URETICI"
        Me.colAKTARILAN_URETICI.MinWidth = 25
        Me.colAKTARILAN_URETICI.Name = "colAKTARILAN_URETICI"
        Me.colAKTARILAN_URETICI.Visible = True
        Me.colAKTARILAN_URETICI.VisibleIndex = 22
        Me.colAKTARILAN_URETICI.Width = 94
        '
        'colAKTARILAN_KUTUSAYI
        '
        Me.colAKTARILAN_KUTUSAYI.FieldName = "AKTARILAN_KUTUSAYI"
        Me.colAKTARILAN_KUTUSAYI.MinWidth = 25
        Me.colAKTARILAN_KUTUSAYI.Name = "colAKTARILAN_KUTUSAYI"
        Me.colAKTARILAN_KUTUSAYI.Visible = True
        Me.colAKTARILAN_KUTUSAYI.VisibleIndex = 23
        Me.colAKTARILAN_KUTUSAYI.Width = 94
        '
        'colAKTARILAN_KG
        '
        Me.colAKTARILAN_KG.FieldName = "AKTARILAN_KG"
        Me.colAKTARILAN_KG.MinWidth = 25
        Me.colAKTARILAN_KG.Name = "colAKTARILAN_KG"
        Me.colAKTARILAN_KG.Visible = True
        Me.colAKTARILAN_KG.VisibleIndex = 24
        Me.colAKTARILAN_KG.Width = 94
        '
        'colSEVK_ONAY
        '
        Me.colSEVK_ONAY.FieldName = "SEVK_ONAY"
        Me.colSEVK_ONAY.MinWidth = 25
        Me.colSEVK_ONAY.Name = "colSEVK_ONAY"
        Me.colSEVK_ONAY.Visible = True
        Me.colSEVK_ONAY.VisibleIndex = 25
        Me.colSEVK_ONAY.Width = 94
        '
        'colSEVK_MIKTAR
        '
        Me.colSEVK_MIKTAR.FieldName = "SEVK_MIKTAR"
        Me.colSEVK_MIKTAR.MinWidth = 25
        Me.colSEVK_MIKTAR.Name = "colSEVK_MIKTAR"
        Me.colSEVK_MIKTAR.Visible = True
        Me.colSEVK_MIKTAR.VisibleIndex = 26
        Me.colSEVK_MIKTAR.Width = 94
        '
        'colSEVKID
        '
        Me.colSEVKID.FieldName = "SEVKID"
        Me.colSEVKID.MinWidth = 25
        Me.colSEVKID.Name = "colSEVKID"
        Me.colSEVKID.Visible = True
        Me.colSEVKID.VisibleIndex = 27
        Me.colSEVKID.Width = 94
        '
        'coltest
        '
        Me.coltest.FieldName = "test"
        Me.coltest.MinWidth = 25
        Me.coltest.Name = "coltest"
        Me.coltest.Visible = True
        Me.coltest.VisibleIndex = 28
        Me.coltest.Width = 94
        '
        'Form173
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1388, 626)
        Me.Controls.Add(Me.GridControl1)
        Me.Controls.Add(Me.SimpleButton2)
        Me.Controls.Add(Me.SimpleButton1)
        Me.IconOptions.Image = Global.WindowsApplication1.My.Resources.Resources.LOGIN11
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "Form173"
        Me.Text = "Alansis Kiraz Mamul Çıkış İzleme"
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ALANSISDataSet65, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EOALANSISKIRAZMAMULDEPOBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Private WithEvents FormAssistant1 As DevExpress.XtraBars.FormAssistant
    Private WithEvents DefaultLookAndFeel1 As DevExpress.LookAndFeel.DefaultLookAndFeel
    Private WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SimpleButton2 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents ALANSISDataSet65 As ALANSISDataSet65
    Friend WithEvents EOALANSISKIRAZMAMULDEPOBindingSource As BindingSource
    Friend WithEvents EO_ALANSIS_KIRAZ_MAMULDEPOTableAdapter As ALANSISDataSet65TableAdapters.EO_ALANSIS_KIRAZ_MAMULDEPOTableAdapter
    Friend WithEvents colID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTARIH As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSTOK_KODU As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSERI As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colMIKTAR As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colBOLGE As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colEBAT As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colISLEM As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colKIRAZ_ISLEM As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colODA As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colKALINTI As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDARA As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colBRUT As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDEPO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTIP As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPARTINO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colURETIM_TIPI As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCESIT As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colUSR As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colACIKLAMA As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colRENK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSTOK_ISLEM As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colAKTARILAN_URETICI As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colAKTARILAN_KUTUSAYI As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colAKTARILAN_KG As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSEVK_ONAY As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSEVK_MIKTAR As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSEVKID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents coltest As DevExpress.XtraGrid.Columns.GridColumn
End Class
