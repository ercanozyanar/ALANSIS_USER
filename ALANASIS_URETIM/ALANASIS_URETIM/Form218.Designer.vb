<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form218
    Inherits DevExpress.XtraEditors.XtraForm

    'Form, bileşen listesini temizlemeyi bırakmayı geçersiz kılar.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form218))
        Me.FormAssistant1 = New DevExpress.XtraBars.FormAssistant()
        Me.DefaultLookAndFeel1 = New DevExpress.LookAndFeel.DefaultLookAndFeel(Me.components)
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton()
        Me.EOALANSISINCIRMAMULRAPORBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.ALANSISDataSet51 = New WindowsApplication1.ALANSISDataSet51()
        Me.EOALANSISINCIRMAMULRAPORBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ALANSISDataSet47 = New WindowsApplication1.ALANSISDataSet47()
        Me.EO_ALANSIS_INCIRMAMULRAPORTableAdapter = New WindowsApplication1.ALANSISDataSet47TableAdapters.EO_ALANSIS_INCIRMAMULRAPORTableAdapter()
        Me.EO_ALANSIS_INCIRMAMULRAPORTableAdapter1 = New WindowsApplication1.ALANSISDataSet51TableAdapters.EO_ALANSIS_INCIRMAMULRAPORTableAdapter()
        Me.EOALANSISINCIRMAMULRAPORBindingSource2 = New System.Windows.Forms.BindingSource(Me.components)
        Me.ALANSISDataSet52 = New WindowsApplication1.ALANSISDataSet52()
        Me.EO_ALANSIS_INCIRMAMUL_RAPORTableAdapter = New WindowsApplication1.ALANSISDataSet52TableAdapters.EO_ALANSIS_INCIRMAMUL_RAPORTableAdapter()
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colTARIH = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSTOK_KODU = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSERI = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colMIKTAR = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colBOLGE = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colEBAT = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colISLEM = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colINCIR_ISLEM = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colODA = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colKALINTI = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDARA = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colBRUT = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDEPO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTIP = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPARTINO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colMUSTERI = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colURETIM_TIPI = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTUKETILEN_KARTON_KUTU = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCESIT = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colACIKLAMA = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colRENK = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPASTA_KAGIT = New DevExpress.XtraGrid.Columns.GridColumn()
        CType(Me.EOALANSISINCIRMAMULRAPORBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ALANSISDataSet51, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EOALANSISINCIRMAMULRAPORBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ALANSISDataSet47, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EOALANSISINCIRMAMULRAPORBindingSource2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ALANSISDataSet52, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DefaultLookAndFeel1
        '
        Me.DefaultLookAndFeel1.LookAndFeel.SkinName = "Office 2007 Blue"
        '
        'SimpleButton1
        '
        Me.SimpleButton1.ImageOptions.Image = CType(resources.GetObject("SimpleButton1.ImageOptions.Image"), System.Drawing.Image)
        Me.SimpleButton1.Location = New System.Drawing.Point(2, 3)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(35, 33)
        Me.SimpleButton1.TabIndex = 6
        '
        'EOALANSISINCIRMAMULRAPORBindingSource1
        '
        Me.EOALANSISINCIRMAMULRAPORBindingSource1.DataMember = "EO_ALANSIS_INCIRMAMULRAPOR"
        Me.EOALANSISINCIRMAMULRAPORBindingSource1.DataSource = Me.ALANSISDataSet51
        '
        'ALANSISDataSet51
        '
        Me.ALANSISDataSet51.DataSetName = "ALANSISDataSet51"
        Me.ALANSISDataSet51.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'EOALANSISINCIRMAMULRAPORBindingSource
        '
        Me.EOALANSISINCIRMAMULRAPORBindingSource.DataMember = "EO_ALANSIS_INCIRMAMULRAPOR"
        Me.EOALANSISINCIRMAMULRAPORBindingSource.DataSource = Me.ALANSISDataSet47
        '
        'ALANSISDataSet47
        '
        Me.ALANSISDataSet47.DataSetName = "ALANSISDataSet47"
        Me.ALANSISDataSet47.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'EO_ALANSIS_INCIRMAMULRAPORTableAdapter
        '
        Me.EO_ALANSIS_INCIRMAMULRAPORTableAdapter.ClearBeforeFill = True
        '
        'EO_ALANSIS_INCIRMAMULRAPORTableAdapter1
        '
        Me.EO_ALANSIS_INCIRMAMULRAPORTableAdapter1.ClearBeforeFill = True
        '
        'EOALANSISINCIRMAMULRAPORBindingSource2
        '
        Me.EOALANSISINCIRMAMULRAPORBindingSource2.DataMember = "EO_ALANSIS_INCIRMAMUL_RAPOR"
        Me.EOALANSISINCIRMAMULRAPORBindingSource2.DataSource = Me.ALANSISDataSet52
        '
        'ALANSISDataSet52
        '
        Me.ALANSISDataSet52.DataSetName = "ALANSISDataSet52"
        Me.ALANSISDataSet52.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'EO_ALANSIS_INCIRMAMUL_RAPORTableAdapter
        '
        Me.EO_ALANSIS_INCIRMAMUL_RAPORTableAdapter.ClearBeforeFill = True
        '
        'GridControl1
        '
        Me.GridControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GridControl1.DataSource = Me.EOALANSISINCIRMAMULRAPORBindingSource2
        Me.GridControl1.Location = New System.Drawing.Point(2, 42)
        Me.GridControl1.MainView = Me.GridView1
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.Size = New System.Drawing.Size(1368, 569)
        Me.GridControl1.TabIndex = 7
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colTARIH, Me.colSTOK_KODU, Me.colSERI, Me.colMIKTAR, Me.colBOLGE, Me.colEBAT, Me.colISLEM, Me.colINCIR_ISLEM, Me.colODA, Me.colKALINTI, Me.colDARA, Me.colBRUT, Me.colDEPO, Me.colTIP, Me.colPARTINO, Me.colMUSTERI, Me.colURETIM_TIPI, Me.colTUKETILEN_KARTON_KUTU, Me.colCESIT, Me.colACIKLAMA, Me.colRENK, Me.colPASTA_KAGIT})
        Me.GridView1.GridControl = Me.GridControl1
        Me.GridView1.Name = "GridView1"
        '
        'colTARIH
        '
        Me.colTARIH.FieldName = "TARIH"
        Me.colTARIH.Name = "colTARIH"
        Me.colTARIH.Visible = True
        Me.colTARIH.VisibleIndex = 0
        '
        'colSTOK_KODU
        '
        Me.colSTOK_KODU.FieldName = "STOK_KODU"
        Me.colSTOK_KODU.Name = "colSTOK_KODU"
        Me.colSTOK_KODU.Visible = True
        Me.colSTOK_KODU.VisibleIndex = 1
        '
        'colSERI
        '
        Me.colSERI.FieldName = "SERI"
        Me.colSERI.Name = "colSERI"
        Me.colSERI.Visible = True
        Me.colSERI.VisibleIndex = 2
        '
        'colMIKTAR
        '
        Me.colMIKTAR.FieldName = "MIKTAR"
        Me.colMIKTAR.Name = "colMIKTAR"
        Me.colMIKTAR.Visible = True
        Me.colMIKTAR.VisibleIndex = 3
        '
        'colBOLGE
        '
        Me.colBOLGE.FieldName = "BOLGE"
        Me.colBOLGE.Name = "colBOLGE"
        Me.colBOLGE.Visible = True
        Me.colBOLGE.VisibleIndex = 4
        '
        'colEBAT
        '
        Me.colEBAT.FieldName = "EBAT"
        Me.colEBAT.Name = "colEBAT"
        Me.colEBAT.Visible = True
        Me.colEBAT.VisibleIndex = 5
        '
        'colISLEM
        '
        Me.colISLEM.FieldName = "ISLEM"
        Me.colISLEM.Name = "colISLEM"
        Me.colISLEM.Visible = True
        Me.colISLEM.VisibleIndex = 6
        '
        'colINCIR_ISLEM
        '
        Me.colINCIR_ISLEM.FieldName = "INCIR_ISLEM"
        Me.colINCIR_ISLEM.Name = "colINCIR_ISLEM"
        Me.colINCIR_ISLEM.Visible = True
        Me.colINCIR_ISLEM.VisibleIndex = 7
        '
        'colODA
        '
        Me.colODA.FieldName = "ODA"
        Me.colODA.Name = "colODA"
        Me.colODA.Visible = True
        Me.colODA.VisibleIndex = 8
        '
        'colKALINTI
        '
        Me.colKALINTI.FieldName = "KALINTI"
        Me.colKALINTI.Name = "colKALINTI"
        Me.colKALINTI.Visible = True
        Me.colKALINTI.VisibleIndex = 9
        '
        'colDARA
        '
        Me.colDARA.FieldName = "DARA"
        Me.colDARA.Name = "colDARA"
        Me.colDARA.Visible = True
        Me.colDARA.VisibleIndex = 10
        '
        'colBRUT
        '
        Me.colBRUT.FieldName = "BRUT"
        Me.colBRUT.Name = "colBRUT"
        Me.colBRUT.Visible = True
        Me.colBRUT.VisibleIndex = 11
        '
        'colDEPO
        '
        Me.colDEPO.FieldName = "DEPO"
        Me.colDEPO.Name = "colDEPO"
        Me.colDEPO.Visible = True
        Me.colDEPO.VisibleIndex = 12
        '
        'colTIP
        '
        Me.colTIP.FieldName = "TIP"
        Me.colTIP.Name = "colTIP"
        Me.colTIP.Visible = True
        Me.colTIP.VisibleIndex = 13
        '
        'colPARTINO
        '
        Me.colPARTINO.FieldName = "PARTINO"
        Me.colPARTINO.Name = "colPARTINO"
        Me.colPARTINO.Visible = True
        Me.colPARTINO.VisibleIndex = 14
        '
        'colMUSTERI
        '
        Me.colMUSTERI.FieldName = "MUSTERI"
        Me.colMUSTERI.Name = "colMUSTERI"
        Me.colMUSTERI.Visible = True
        Me.colMUSTERI.VisibleIndex = 15
        '
        'colURETIM_TIPI
        '
        Me.colURETIM_TIPI.FieldName = "URETIM_TIPI"
        Me.colURETIM_TIPI.Name = "colURETIM_TIPI"
        Me.colURETIM_TIPI.Visible = True
        Me.colURETIM_TIPI.VisibleIndex = 16
        '
        'colTUKETILEN_KARTON_KUTU
        '
        Me.colTUKETILEN_KARTON_KUTU.FieldName = "TUKETILEN_KARTON_KUTU"
        Me.colTUKETILEN_KARTON_KUTU.Name = "colTUKETILEN_KARTON_KUTU"
        Me.colTUKETILEN_KARTON_KUTU.Visible = True
        Me.colTUKETILEN_KARTON_KUTU.VisibleIndex = 17
        '
        'colCESIT
        '
        Me.colCESIT.FieldName = "CESIT"
        Me.colCESIT.Name = "colCESIT"
        Me.colCESIT.Visible = True
        Me.colCESIT.VisibleIndex = 18
        '
        'colACIKLAMA
        '
        Me.colACIKLAMA.FieldName = "ACIKLAMA"
        Me.colACIKLAMA.Name = "colACIKLAMA"
        Me.colACIKLAMA.Visible = True
        Me.colACIKLAMA.VisibleIndex = 19
        '
        'colRENK
        '
        Me.colRENK.FieldName = "RENK"
        Me.colRENK.Name = "colRENK"
        Me.colRENK.Visible = True
        Me.colRENK.VisibleIndex = 20
        '
        'colPASTA_KAGIT
        '
        Me.colPASTA_KAGIT.FieldName = "PASTA_KAGIT"
        Me.colPASTA_KAGIT.Name = "colPASTA_KAGIT"
        Me.colPASTA_KAGIT.Visible = True
        Me.colPASTA_KAGIT.VisibleIndex = 21
        '
        'Form218
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1372, 612)
        Me.Controls.Add(Me.GridControl1)
        Me.Controls.Add(Me.SimpleButton1)
        Me.IconOptions.Image = Global.WindowsApplication1.My.Resources.Resources.LOGIN1
        Me.Name = "Form218"
        Me.Text = "Alansis İncir Mamul Çıkış İzleme"
        CType(Me.EOALANSISINCIRMAMULRAPORBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ALANSISDataSet51, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EOALANSISINCIRMAMULRAPORBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ALANSISDataSet47, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EOALANSISINCIRMAMULRAPORBindingSource2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ALANSISDataSet52, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ALANSISDataSet47 As ALANSISDataSet47
    Friend WithEvents EOALANSISINCIRMAMULRAPORBindingSource As BindingSource
    Friend WithEvents EO_ALANSIS_INCIRMAMULRAPORTableAdapter As ALANSISDataSet47TableAdapters.EO_ALANSIS_INCIRMAMULRAPORTableAdapter
    Private WithEvents FormAssistant1 As DevExpress.XtraBars.FormAssistant
    Private WithEvents DefaultLookAndFeel1 As DevExpress.LookAndFeel.DefaultLookAndFeel
    Private WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents ALANSISDataSet51 As ALANSISDataSet51
    Friend WithEvents EOALANSISINCIRMAMULRAPORBindingSource1 As BindingSource
    Friend WithEvents EO_ALANSIS_INCIRMAMULRAPORTableAdapter1 As ALANSISDataSet51TableAdapters.EO_ALANSIS_INCIRMAMULRAPORTableAdapter
    Friend WithEvents ALANSISDataSet52 As ALANSISDataSet52
    Friend WithEvents EOALANSISINCIRMAMULRAPORBindingSource2 As BindingSource
    Friend WithEvents EO_ALANSIS_INCIRMAMUL_RAPORTableAdapter As ALANSISDataSet52TableAdapters.EO_ALANSIS_INCIRMAMUL_RAPORTableAdapter
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colTARIH As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSTOK_KODU As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSERI As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colMIKTAR As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colBOLGE As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colEBAT As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colISLEM As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colINCIR_ISLEM As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colODA As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colKALINTI As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDARA As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colBRUT As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDEPO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTIP As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPARTINO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colMUSTERI As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colURETIM_TIPI As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTUKETILEN_KARTON_KUTU As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCESIT As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colACIKLAMA As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colRENK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPASTA_KAGIT As DevExpress.XtraGrid.Columns.GridColumn
End Class
