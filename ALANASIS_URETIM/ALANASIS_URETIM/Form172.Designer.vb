<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form172
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form172))
        Me.FormAssistant1 = New DevExpress.XtraBars.FormAssistant()
        Me.DefaultLookAndFeel1 = New DevExpress.LookAndFeel.DefaultLookAndFeel(Me.components)
        Me.EOKIRAZPAKETKONTROLBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ALANSISDataSet27 = New WindowsApplication1.ALANSISDataSet27()
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton()
        Me.EO_KIRAZPAKET_KONTROLTableAdapter = New WindowsApplication1.ALANSISDataSet27TableAdapters.EO_KIRAZPAKET_KONTROLTableAdapter()
        Me.ALANSISDataSet29 = New WindowsApplication1.ALANSISDataSet29()
        Me.EOKIRAZPAKETKONTROLBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.EO_KIRAZPAKET_KONTROLTableAdapter1 = New WindowsApplication1.ALANSISDataSet29TableAdapters.EO_KIRAZPAKET_KONTROLTableAdapter()
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colHASAT_TARIH = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPAKETLEME_TARIH = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTESIS = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colURUN_ADI = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colVARDIYA = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colVARDIYA_BASLANGIC = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colUBT_KODU = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colURUN_CINSI = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colETIKET_CESIDI = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colMUSTERI_ADI = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colETIKET_KONTROL = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colIZLEMENO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colAMBALAJTIPI = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colKALIBRE = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colYABANCI_MADDE = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colKUFLENME = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDAL_SURTMESI = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCURUME = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colYUMUSAK = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colICKURD = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colIKIZMEYVE = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colEBAT_ALTI = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colHASAR = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDOLU_ZARAR = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSEKIL_BOZUK = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPORSUME = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTOPLAM_KUSUR = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colBRIX = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colBRUT_AGIRLIK = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colKUTU_AGIRLIK = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPOSET_AGIRLIK = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSALE_AGIRLIK = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colNET_AGIRLIK = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTAT = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colYAPI = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colKOKU = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colKALITE_PERSONEL = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colGIRDI_AMBALAJNO_KOLI = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colGIRDI_AMBALAJNO_POSET = New DevExpress.XtraGrid.Columns.GridColumn()
        CType(Me.EOKIRAZPAKETKONTROLBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ALANSISDataSet27, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ALANSISDataSet29, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EOKIRAZPAKETKONTROLBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DefaultLookAndFeel1
        '
        Me.DefaultLookAndFeel1.LookAndFeel.SkinName = "Office 2007 Blue"
        '
        'EOKIRAZPAKETKONTROLBindingSource
        '
        Me.EOKIRAZPAKETKONTROLBindingSource.DataMember = "EO_KIRAZPAKET_KONTROL"
        Me.EOKIRAZPAKETKONTROLBindingSource.DataSource = Me.ALANSISDataSet27
        '
        'ALANSISDataSet27
        '
        Me.ALANSISDataSet27.DataSetName = "ALANSISDataSet27"
        Me.ALANSISDataSet27.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'SimpleButton1
        '
        Me.SimpleButton1.ImageOptions.Image = CType(resources.GetObject("SimpleButton1.ImageOptions.Image"), System.Drawing.Image)
        Me.SimpleButton1.Location = New System.Drawing.Point(2, 2)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(35, 33)
        Me.SimpleButton1.TabIndex = 5
        '
        'EO_KIRAZPAKET_KONTROLTableAdapter
        '
        Me.EO_KIRAZPAKET_KONTROLTableAdapter.ClearBeforeFill = True
        '
        'ALANSISDataSet29
        '
        Me.ALANSISDataSet29.DataSetName = "ALANSISDataSet29"
        Me.ALANSISDataSet29.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'EOKIRAZPAKETKONTROLBindingSource1
        '
        Me.EOKIRAZPAKETKONTROLBindingSource1.DataMember = "EO_KIRAZPAKET_KONTROL"
        Me.EOKIRAZPAKETKONTROLBindingSource1.DataSource = Me.ALANSISDataSet29
        '
        'EO_KIRAZPAKET_KONTROLTableAdapter1
        '
        Me.EO_KIRAZPAKET_KONTROLTableAdapter1.ClearBeforeFill = True
        '
        'GridControl1
        '
        Me.GridControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GridControl1.DataSource = Me.EOKIRAZPAKETKONTROLBindingSource1
        Me.GridControl1.Location = New System.Drawing.Point(2, 41)
        Me.GridControl1.MainView = Me.GridView1
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.Size = New System.Drawing.Size(1257, 483)
        Me.GridControl1.TabIndex = 6
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colID, Me.colHASAT_TARIH, Me.colPAKETLEME_TARIH, Me.colTESIS, Me.colURUN_ADI, Me.colVARDIYA, Me.colVARDIYA_BASLANGIC, Me.colUBT_KODU, Me.colURUN_CINSI, Me.colETIKET_CESIDI, Me.colMUSTERI_ADI, Me.colETIKET_KONTROL, Me.colIZLEMENO, Me.colAMBALAJTIPI, Me.colKALIBRE, Me.colYABANCI_MADDE, Me.colKUFLENME, Me.colDAL_SURTMESI, Me.colCURUME, Me.colYUMUSAK, Me.colICKURD, Me.colIKIZMEYVE, Me.colEBAT_ALTI, Me.colHASAR, Me.colDOLU_ZARAR, Me.colSEKIL_BOZUK, Me.colPORSUME, Me.colTOPLAM_KUSUR, Me.colBRIX, Me.colBRUT_AGIRLIK, Me.colKUTU_AGIRLIK, Me.colPOSET_AGIRLIK, Me.colSALE_AGIRLIK, Me.colNET_AGIRLIK, Me.colTAT, Me.colYAPI, Me.colKOKU, Me.colKALITE_PERSONEL, Me.colGIRDI_AMBALAJNO_KOLI, Me.colGIRDI_AMBALAJNO_POSET})
        Me.GridView1.GridControl = Me.GridControl1
        Me.GridView1.Name = "GridView1"
        '
        'colID
        '
        Me.colID.FieldName = "ID"
        Me.colID.Name = "colID"
        Me.colID.Visible = True
        Me.colID.VisibleIndex = 0
        '
        'colHASAT_TARIH
        '
        Me.colHASAT_TARIH.FieldName = "HASAT_TARIH"
        Me.colHASAT_TARIH.Name = "colHASAT_TARIH"
        Me.colHASAT_TARIH.Visible = True
        Me.colHASAT_TARIH.VisibleIndex = 1
        '
        'colPAKETLEME_TARIH
        '
        Me.colPAKETLEME_TARIH.FieldName = "PAKETLEME_TARIH"
        Me.colPAKETLEME_TARIH.Name = "colPAKETLEME_TARIH"
        Me.colPAKETLEME_TARIH.Visible = True
        Me.colPAKETLEME_TARIH.VisibleIndex = 2
        '
        'colTESIS
        '
        Me.colTESIS.FieldName = "TESIS"
        Me.colTESIS.Name = "colTESIS"
        Me.colTESIS.Visible = True
        Me.colTESIS.VisibleIndex = 3
        '
        'colURUN_ADI
        '
        Me.colURUN_ADI.FieldName = "URUN_ADI"
        Me.colURUN_ADI.Name = "colURUN_ADI"
        Me.colURUN_ADI.Visible = True
        Me.colURUN_ADI.VisibleIndex = 4
        '
        'colVARDIYA
        '
        Me.colVARDIYA.FieldName = "VARDIYA"
        Me.colVARDIYA.Name = "colVARDIYA"
        Me.colVARDIYA.Visible = True
        Me.colVARDIYA.VisibleIndex = 5
        '
        'colVARDIYA_BASLANGIC
        '
        Me.colVARDIYA_BASLANGIC.FieldName = "VARDIYA_BASLANGIC"
        Me.colVARDIYA_BASLANGIC.Name = "colVARDIYA_BASLANGIC"
        Me.colVARDIYA_BASLANGIC.Visible = True
        Me.colVARDIYA_BASLANGIC.VisibleIndex = 6
        '
        'colUBT_KODU
        '
        Me.colUBT_KODU.FieldName = "UBT_KODU"
        Me.colUBT_KODU.Name = "colUBT_KODU"
        Me.colUBT_KODU.Visible = True
        Me.colUBT_KODU.VisibleIndex = 7
        '
        'colURUN_CINSI
        '
        Me.colURUN_CINSI.FieldName = "URUN_CINSI"
        Me.colURUN_CINSI.Name = "colURUN_CINSI"
        Me.colURUN_CINSI.Visible = True
        Me.colURUN_CINSI.VisibleIndex = 8
        '
        'colETIKET_CESIDI
        '
        Me.colETIKET_CESIDI.FieldName = "ETIKET_CESIDI"
        Me.colETIKET_CESIDI.Name = "colETIKET_CESIDI"
        Me.colETIKET_CESIDI.Visible = True
        Me.colETIKET_CESIDI.VisibleIndex = 9
        '
        'colMUSTERI_ADI
        '
        Me.colMUSTERI_ADI.FieldName = "MUSTERI_ADI"
        Me.colMUSTERI_ADI.Name = "colMUSTERI_ADI"
        Me.colMUSTERI_ADI.Visible = True
        Me.colMUSTERI_ADI.VisibleIndex = 10
        '
        'colETIKET_KONTROL
        '
        Me.colETIKET_KONTROL.FieldName = "ETIKET_KONTROL"
        Me.colETIKET_KONTROL.Name = "colETIKET_KONTROL"
        Me.colETIKET_KONTROL.Visible = True
        Me.colETIKET_KONTROL.VisibleIndex = 11
        '
        'colIZLEMENO
        '
        Me.colIZLEMENO.FieldName = "IZLEMENO"
        Me.colIZLEMENO.Name = "colIZLEMENO"
        Me.colIZLEMENO.Visible = True
        Me.colIZLEMENO.VisibleIndex = 12
        '
        'colAMBALAJTIPI
        '
        Me.colAMBALAJTIPI.FieldName = "AMBALAJTIPI"
        Me.colAMBALAJTIPI.Name = "colAMBALAJTIPI"
        Me.colAMBALAJTIPI.Visible = True
        Me.colAMBALAJTIPI.VisibleIndex = 13
        '
        'colKALIBRE
        '
        Me.colKALIBRE.FieldName = "KALIBRE"
        Me.colKALIBRE.Name = "colKALIBRE"
        Me.colKALIBRE.Visible = True
        Me.colKALIBRE.VisibleIndex = 14
        '
        'colYABANCI_MADDE
        '
        Me.colYABANCI_MADDE.FieldName = "YABANCI_MADDE"
        Me.colYABANCI_MADDE.Name = "colYABANCI_MADDE"
        Me.colYABANCI_MADDE.Visible = True
        Me.colYABANCI_MADDE.VisibleIndex = 15
        '
        'colKUFLENME
        '
        Me.colKUFLENME.FieldName = "KUFLENME"
        Me.colKUFLENME.Name = "colKUFLENME"
        Me.colKUFLENME.Visible = True
        Me.colKUFLENME.VisibleIndex = 16
        '
        'colDAL_SURTMESI
        '
        Me.colDAL_SURTMESI.FieldName = "DAL_SURTMESI"
        Me.colDAL_SURTMESI.Name = "colDAL_SURTMESI"
        Me.colDAL_SURTMESI.Visible = True
        Me.colDAL_SURTMESI.VisibleIndex = 17
        '
        'colCURUME
        '
        Me.colCURUME.FieldName = "CURUME"
        Me.colCURUME.Name = "colCURUME"
        Me.colCURUME.Visible = True
        Me.colCURUME.VisibleIndex = 18
        '
        'colYUMUSAK
        '
        Me.colYUMUSAK.FieldName = "YUMUSAK"
        Me.colYUMUSAK.Name = "colYUMUSAK"
        Me.colYUMUSAK.Visible = True
        Me.colYUMUSAK.VisibleIndex = 19
        '
        'colICKURD
        '
        Me.colICKURD.FieldName = "ICKURD"
        Me.colICKURD.Name = "colICKURD"
        Me.colICKURD.Visible = True
        Me.colICKURD.VisibleIndex = 20
        '
        'colIKIZMEYVE
        '
        Me.colIKIZMEYVE.FieldName = "IKIZMEYVE"
        Me.colIKIZMEYVE.Name = "colIKIZMEYVE"
        Me.colIKIZMEYVE.Visible = True
        Me.colIKIZMEYVE.VisibleIndex = 21
        '
        'colEBAT_ALTI
        '
        Me.colEBAT_ALTI.FieldName = "EBAT_ALTI"
        Me.colEBAT_ALTI.Name = "colEBAT_ALTI"
        Me.colEBAT_ALTI.Visible = True
        Me.colEBAT_ALTI.VisibleIndex = 22
        '
        'colHASAR
        '
        Me.colHASAR.FieldName = "HASAR"
        Me.colHASAR.Name = "colHASAR"
        Me.colHASAR.Visible = True
        Me.colHASAR.VisibleIndex = 23
        '
        'colDOLU_ZARAR
        '
        Me.colDOLU_ZARAR.FieldName = "DOLU_ZARAR"
        Me.colDOLU_ZARAR.Name = "colDOLU_ZARAR"
        Me.colDOLU_ZARAR.Visible = True
        Me.colDOLU_ZARAR.VisibleIndex = 24
        '
        'colSEKIL_BOZUK
        '
        Me.colSEKIL_BOZUK.FieldName = "SEKIL_BOZUK"
        Me.colSEKIL_BOZUK.Name = "colSEKIL_BOZUK"
        Me.colSEKIL_BOZUK.Visible = True
        Me.colSEKIL_BOZUK.VisibleIndex = 25
        '
        'colPORSUME
        '
        Me.colPORSUME.FieldName = "PORSUME"
        Me.colPORSUME.Name = "colPORSUME"
        Me.colPORSUME.Visible = True
        Me.colPORSUME.VisibleIndex = 26
        '
        'colTOPLAM_KUSUR
        '
        Me.colTOPLAM_KUSUR.FieldName = "TOPLAM_KUSUR"
        Me.colTOPLAM_KUSUR.Name = "colTOPLAM_KUSUR"
        Me.colTOPLAM_KUSUR.Visible = True
        Me.colTOPLAM_KUSUR.VisibleIndex = 27
        '
        'colBRIX
        '
        Me.colBRIX.FieldName = "BRIX"
        Me.colBRIX.Name = "colBRIX"
        Me.colBRIX.Visible = True
        Me.colBRIX.VisibleIndex = 28
        '
        'colBRUT_AGIRLIK
        '
        Me.colBRUT_AGIRLIK.FieldName = "BRUT_AGIRLIK"
        Me.colBRUT_AGIRLIK.Name = "colBRUT_AGIRLIK"
        Me.colBRUT_AGIRLIK.Visible = True
        Me.colBRUT_AGIRLIK.VisibleIndex = 29
        '
        'colKUTU_AGIRLIK
        '
        Me.colKUTU_AGIRLIK.FieldName = "KUTU_AGIRLIK"
        Me.colKUTU_AGIRLIK.Name = "colKUTU_AGIRLIK"
        Me.colKUTU_AGIRLIK.Visible = True
        Me.colKUTU_AGIRLIK.VisibleIndex = 30
        '
        'colPOSET_AGIRLIK
        '
        Me.colPOSET_AGIRLIK.FieldName = "POSET_AGIRLIK"
        Me.colPOSET_AGIRLIK.Name = "colPOSET_AGIRLIK"
        Me.colPOSET_AGIRLIK.Visible = True
        Me.colPOSET_AGIRLIK.VisibleIndex = 31
        '
        'colSALE_AGIRLIK
        '
        Me.colSALE_AGIRLIK.FieldName = "SALE_AGIRLIK"
        Me.colSALE_AGIRLIK.Name = "colSALE_AGIRLIK"
        Me.colSALE_AGIRLIK.Visible = True
        Me.colSALE_AGIRLIK.VisibleIndex = 32
        '
        'colNET_AGIRLIK
        '
        Me.colNET_AGIRLIK.FieldName = "NET_AGIRLIK"
        Me.colNET_AGIRLIK.Name = "colNET_AGIRLIK"
        Me.colNET_AGIRLIK.Visible = True
        Me.colNET_AGIRLIK.VisibleIndex = 33
        '
        'colTAT
        '
        Me.colTAT.FieldName = "TAT"
        Me.colTAT.Name = "colTAT"
        Me.colTAT.Visible = True
        Me.colTAT.VisibleIndex = 34
        '
        'colYAPI
        '
        Me.colYAPI.FieldName = "YAPI"
        Me.colYAPI.Name = "colYAPI"
        Me.colYAPI.Visible = True
        Me.colYAPI.VisibleIndex = 35
        '
        'colKOKU
        '
        Me.colKOKU.FieldName = "KOKU"
        Me.colKOKU.Name = "colKOKU"
        Me.colKOKU.Visible = True
        Me.colKOKU.VisibleIndex = 36
        '
        'colKALITE_PERSONEL
        '
        Me.colKALITE_PERSONEL.FieldName = "KALITE_PERSONEL"
        Me.colKALITE_PERSONEL.Name = "colKALITE_PERSONEL"
        Me.colKALITE_PERSONEL.Visible = True
        Me.colKALITE_PERSONEL.VisibleIndex = 37
        '
        'colGIRDI_AMBALAJNO_KOLI
        '
        Me.colGIRDI_AMBALAJNO_KOLI.FieldName = "GIRDI_AMBALAJNO_KOLI"
        Me.colGIRDI_AMBALAJNO_KOLI.Name = "colGIRDI_AMBALAJNO_KOLI"
        Me.colGIRDI_AMBALAJNO_KOLI.Visible = True
        Me.colGIRDI_AMBALAJNO_KOLI.VisibleIndex = 38
        '
        'colGIRDI_AMBALAJNO_POSET
        '
        Me.colGIRDI_AMBALAJNO_POSET.FieldName = "GIRDI_AMBALAJNO_POSET"
        Me.colGIRDI_AMBALAJNO_POSET.Name = "colGIRDI_AMBALAJNO_POSET"
        Me.colGIRDI_AMBALAJNO_POSET.Visible = True
        Me.colGIRDI_AMBALAJNO_POSET.VisibleIndex = 39
        '
        'Form172
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1260, 524)
        Me.Controls.Add(Me.GridControl1)
        Me.Controls.Add(Me.SimpleButton1)
        Me.Name = "Form172"
        Me.Text = "ALANSIS PAKETLEME ANALIZ RAPOR"
        CType(Me.EOKIRAZPAKETKONTROLBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ALANSISDataSet27, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ALANSISDataSet29, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EOKIRAZPAKETKONTROLBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ALANSISDataSet27 As ALANSISDataSet27
    Friend WithEvents EOKIRAZPAKETKONTROLBindingSource As BindingSource
    Friend WithEvents EO_KIRAZPAKET_KONTROLTableAdapter As ALANSISDataSet27TableAdapters.EO_KIRAZPAKET_KONTROLTableAdapter
    Friend WithEvents ALANSISDataSet29 As ALANSISDataSet29
    Friend WithEvents EOKIRAZPAKETKONTROLBindingSource1 As BindingSource
    Friend WithEvents EO_KIRAZPAKET_KONTROLTableAdapter1 As ALANSISDataSet29TableAdapters.EO_KIRAZPAKET_KONTROLTableAdapter
    Private WithEvents FormAssistant1 As DevExpress.XtraBars.FormAssistant
    Private WithEvents DefaultLookAndFeel1 As DevExpress.LookAndFeel.DefaultLookAndFeel
    Private WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
    Private WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Private WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Private WithEvents colID As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents colHASAT_TARIH As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents colPAKETLEME_TARIH As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents colTESIS As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents colURUN_ADI As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents colVARDIYA As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents colVARDIYA_BASLANGIC As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents colUBT_KODU As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents colURUN_CINSI As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents colETIKET_CESIDI As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents colMUSTERI_ADI As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents colETIKET_KONTROL As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents colIZLEMENO As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents colAMBALAJTIPI As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents colKALIBRE As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents colYABANCI_MADDE As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents colKUFLENME As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents colDAL_SURTMESI As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents colCURUME As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents colYUMUSAK As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents colICKURD As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents colIKIZMEYVE As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents colEBAT_ALTI As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents colHASAR As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents colDOLU_ZARAR As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents colSEKIL_BOZUK As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents colPORSUME As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents colTOPLAM_KUSUR As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents colBRIX As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents colBRUT_AGIRLIK As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents colKUTU_AGIRLIK As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents colPOSET_AGIRLIK As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents colSALE_AGIRLIK As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents colNET_AGIRLIK As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents colTAT As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents colYAPI As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents colKOKU As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents colKALITE_PERSONEL As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents colGIRDI_AMBALAJNO_KOLI As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents colGIRDI_AMBALAJNO_POSET As DevExpress.XtraGrid.Columns.GridColumn
End Class
