<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form169
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form169))
        Me.FormAssistant1 = New DevExpress.XtraBars.FormAssistant()
        Me.DefaultLookAndFeel1 = New DevExpress.LookAndFeel.DefaultLookAndFeel(Me.components)
        Me.EOALANSISKALITEMADIZLEMEBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ALANSISDataSet23 = New WindowsApplication1.ALANSISDataSet23()
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton()
        Me.EO_ALANSIS_KALITEMADIZLEMETableAdapter = New WindowsApplication1.ALANSISDataSet23TableAdapters.EO_ALANSIS_KALITEMADIZLEMETableAdapter()
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colDURUM = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTARIH = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colALANSIS_MADSERI = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colURETICI_ADSOY = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colBOLGE = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colKANTARNO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colKASA_SAYI = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colBRUT = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colNET = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDARA = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colMADNO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colKLTINDEX = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colGIRDIKONTROL = New DevExpress.XtraGrid.Columns.GridColumn()
        CType(Me.EOALANSISKALITEMADIZLEMEBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ALANSISDataSet23, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DefaultLookAndFeel1
        '
        Me.DefaultLookAndFeel1.LookAndFeel.SkinName = "Office 2007 Blue"
        '
        'EOALANSISKALITEMADIZLEMEBindingSource
        '
        Me.EOALANSISKALITEMADIZLEMEBindingSource.DataMember = "EO_ALANSIS_KALITEMADIZLEME"
        Me.EOALANSISKALITEMADIZLEMEBindingSource.DataSource = Me.ALANSISDataSet23
        '
        'ALANSISDataSet23
        '
        Me.ALANSISDataSet23.DataSetName = "ALANSISDataSet23"
        Me.ALANSISDataSet23.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'SimpleButton1
        '
        Me.SimpleButton1.ImageOptions.Image = CType(resources.GetObject("SimpleButton1.ImageOptions.Image"), System.Drawing.Image)
        Me.SimpleButton1.Location = New System.Drawing.Point(1, 407)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(35, 33)
        Me.SimpleButton1.TabIndex = 2
        '
        'EO_ALANSIS_KALITEMADIZLEMETableAdapter
        '
        Me.EO_ALANSIS_KALITEMADIZLEMETableAdapter.ClearBeforeFill = True
        '
        'GridControl1
        '
        Me.GridControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GridControl1.DataSource = Me.EOALANSISKALITEMADIZLEMEBindingSource
        Me.GridControl1.Location = New System.Drawing.Point(1, 1)
        Me.GridControl1.MainView = Me.GridView1
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.Size = New System.Drawing.Size(1046, 400)
        Me.GridControl1.TabIndex = 3
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colDURUM, Me.colTARIH, Me.colALANSIS_MADSERI, Me.colURETICI_ADSOY, Me.colBOLGE, Me.colKANTARNO, Me.colKASA_SAYI, Me.colBRUT, Me.colNET, Me.colDARA, Me.colMADNO, Me.colKLTINDEX, Me.colGIRDIKONTROL})
        Me.GridView1.GridControl = Me.GridControl1
        Me.GridView1.Name = "GridView1"
        '
        'colDURUM
        '
        Me.colDURUM.FieldName = "DURUM"
        Me.colDURUM.Name = "colDURUM"
        Me.colDURUM.Visible = True
        Me.colDURUM.VisibleIndex = 0
        '
        'colTARIH
        '
        Me.colTARIH.FieldName = "TARIH"
        Me.colTARIH.Name = "colTARIH"
        Me.colTARIH.Visible = True
        Me.colTARIH.VisibleIndex = 1
        '
        'colALANSIS_MADSERI
        '
        Me.colALANSIS_MADSERI.FieldName = "ALANSIS_MADSERI"
        Me.colALANSIS_MADSERI.Name = "colALANSIS_MADSERI"
        Me.colALANSIS_MADSERI.Visible = True
        Me.colALANSIS_MADSERI.VisibleIndex = 2
        '
        'colURETICI_ADSOY
        '
        Me.colURETICI_ADSOY.FieldName = "URETICI_ADSOY"
        Me.colURETICI_ADSOY.Name = "colURETICI_ADSOY"
        Me.colURETICI_ADSOY.Visible = True
        Me.colURETICI_ADSOY.VisibleIndex = 3
        '
        'colBOLGE
        '
        Me.colBOLGE.FieldName = "BOLGE"
        Me.colBOLGE.Name = "colBOLGE"
        Me.colBOLGE.Visible = True
        Me.colBOLGE.VisibleIndex = 4
        '
        'colKANTARNO
        '
        Me.colKANTARNO.FieldName = "KANTARNO"
        Me.colKANTARNO.Name = "colKANTARNO"
        Me.colKANTARNO.Visible = True
        Me.colKANTARNO.VisibleIndex = 5
        '
        'colKASA_SAYI
        '
        Me.colKASA_SAYI.FieldName = "KASA_SAYI"
        Me.colKASA_SAYI.Name = "colKASA_SAYI"
        Me.colKASA_SAYI.Visible = True
        Me.colKASA_SAYI.VisibleIndex = 6
        '
        'colBRUT
        '
        Me.colBRUT.FieldName = "BRUT"
        Me.colBRUT.Name = "colBRUT"
        Me.colBRUT.Visible = True
        Me.colBRUT.VisibleIndex = 7
        '
        'colNET
        '
        Me.colNET.FieldName = "NET"
        Me.colNET.Name = "colNET"
        Me.colNET.Visible = True
        Me.colNET.VisibleIndex = 8
        '
        'colDARA
        '
        Me.colDARA.FieldName = "DARA"
        Me.colDARA.Name = "colDARA"
        Me.colDARA.Visible = True
        Me.colDARA.VisibleIndex = 9
        '
        'colMADNO
        '
        Me.colMADNO.FieldName = "MADNO"
        Me.colMADNO.Name = "colMADNO"
        Me.colMADNO.Visible = True
        Me.colMADNO.VisibleIndex = 10
        '
        'colKLTINDEX
        '
        Me.colKLTINDEX.FieldName = "KLTINDEX"
        Me.colKLTINDEX.Name = "colKLTINDEX"
        Me.colKLTINDEX.Visible = True
        Me.colKLTINDEX.VisibleIndex = 11
        '
        'colGIRDIKONTROL
        '
        Me.colGIRDIKONTROL.FieldName = "GIRDIKONTROL"
        Me.colGIRDIKONTROL.Name = "colGIRDIKONTROL"
        Me.colGIRDIKONTROL.Visible = True
        Me.colGIRDIKONTROL.VisibleIndex = 12
        '
        'Form169
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1048, 442)
        Me.Controls.Add(Me.GridControl1)
        Me.Controls.Add(Me.SimpleButton1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "Form169"
        Me.Text = "ALANSIS HUCRE BAKIYE - KALITE MEYVE ALIM IZLEME"
        CType(Me.EOALANSISKALITEMADIZLEMEBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ALANSISDataSet23, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ALANSISDataSet23 As ALANSISDataSet23
    Friend WithEvents EOALANSISKALITEMADIZLEMEBindingSource As BindingSource
    Friend WithEvents EO_ALANSIS_KALITEMADIZLEMETableAdapter As ALANSISDataSet23TableAdapters.EO_ALANSIS_KALITEMADIZLEMETableAdapter
    Private WithEvents FormAssistant1 As DevExpress.XtraBars.FormAssistant
    Private WithEvents DefaultLookAndFeel1 As DevExpress.LookAndFeel.DefaultLookAndFeel
    Private WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
    Private WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Private WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Private WithEvents colDURUM As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents colTARIH As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents colALANSIS_MADSERI As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents colURETICI_ADSOY As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents colBOLGE As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents colKANTARNO As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents colKASA_SAYI As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents colBRUT As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents colNET As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents colDARA As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents colMADNO As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents colKLTINDEX As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents colGIRDIKONTROL As DevExpress.XtraGrid.Columns.GridColumn
End Class
