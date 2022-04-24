<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form182
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form182))
        Me.FormAssistant1 = New DevExpress.XtraBars.FormAssistant()
        Me.DefaultLookAndFeel1 = New DevExpress.LookAndFeel.DefaultLookAndFeel(Me.components)
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl()
        Me.EOPTEST1BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ALANSISDataSet46 = New WindowsApplication1.ALANSISDataSet46()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colSIPARIS = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colYUKEME_TARIHI = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSERI = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSTOK_KODU = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSTOK_ADI = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colIRSALIYE = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colGELDIGI_YER = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colRENK = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colMIKTAR = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colURETICI_TC = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colURETICI_ADSOY = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colORT_KASA_FIYAT = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton()
        Me.EO_PTEST1TableAdapter = New WindowsApplication1.ALANSISDataSet46TableAdapters.EO_PTEST1TableAdapter()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EOPTEST1BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ALANSISDataSet46, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DefaultLookAndFeel1
        '
        Me.DefaultLookAndFeel1.LookAndFeel.SkinName = "Office 2007 Blue"
        '
        'GridControl1
        '
        Me.GridControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GridControl1.DataSource = Me.EOPTEST1BindingSource
        Me.GridControl1.EmbeddedNavigator.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GridControl1.Location = New System.Drawing.Point(3, 68)
        Me.GridControl1.MainView = Me.GridView1
        Me.GridControl1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.Size = New System.Drawing.Size(1237, 624)
        Me.GridControl1.TabIndex = 0
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'EOPTEST1BindingSource
        '
        Me.EOPTEST1BindingSource.DataMember = "EO_PTEST1"
        Me.EOPTEST1BindingSource.DataSource = Me.ALANSISDataSet46
        '
        'ALANSISDataSet46
        '
        Me.ALANSISDataSet46.DataSetName = "ALANSISDataSet46"
        Me.ALANSISDataSet46.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colSIPARIS, Me.colYUKEME_TARIHI, Me.colSERI, Me.colSTOK_KODU, Me.colSTOK_ADI, Me.colIRSALIYE, Me.colGELDIGI_YER, Me.colRENK, Me.colMIKTAR, Me.colURETICI_TC, Me.colURETICI_ADSOY, Me.colORT_KASA_FIYAT})
        Me.GridView1.DetailHeight = 431
        Me.GridView1.GridControl = Me.GridControl1
        Me.GridView1.Name = "GridView1"
        '
        'colSIPARIS
        '
        Me.colSIPARIS.FieldName = "SIPARIS"
        Me.colSIPARIS.MinWidth = 23
        Me.colSIPARIS.Name = "colSIPARIS"
        Me.colSIPARIS.Visible = True
        Me.colSIPARIS.VisibleIndex = 0
        Me.colSIPARIS.Width = 87
        '
        'colYUKEME_TARIHI
        '
        Me.colYUKEME_TARIHI.FieldName = "YUKEME_TARIHI"
        Me.colYUKEME_TARIHI.MinWidth = 23
        Me.colYUKEME_TARIHI.Name = "colYUKEME_TARIHI"
        Me.colYUKEME_TARIHI.Visible = True
        Me.colYUKEME_TARIHI.VisibleIndex = 1
        Me.colYUKEME_TARIHI.Width = 87
        '
        'colSERI
        '
        Me.colSERI.FieldName = "SERI"
        Me.colSERI.MinWidth = 23
        Me.colSERI.Name = "colSERI"
        Me.colSERI.Visible = True
        Me.colSERI.VisibleIndex = 2
        Me.colSERI.Width = 87
        '
        'colSTOK_KODU
        '
        Me.colSTOK_KODU.FieldName = "STOK_KODU"
        Me.colSTOK_KODU.MinWidth = 23
        Me.colSTOK_KODU.Name = "colSTOK_KODU"
        Me.colSTOK_KODU.Visible = True
        Me.colSTOK_KODU.VisibleIndex = 3
        Me.colSTOK_KODU.Width = 87
        '
        'colSTOK_ADI
        '
        Me.colSTOK_ADI.FieldName = "STOK_ADI"
        Me.colSTOK_ADI.MinWidth = 23
        Me.colSTOK_ADI.Name = "colSTOK_ADI"
        Me.colSTOK_ADI.Visible = True
        Me.colSTOK_ADI.VisibleIndex = 4
        Me.colSTOK_ADI.Width = 87
        '
        'colIRSALIYE
        '
        Me.colIRSALIYE.FieldName = "IRSALIYE"
        Me.colIRSALIYE.MinWidth = 23
        Me.colIRSALIYE.Name = "colIRSALIYE"
        Me.colIRSALIYE.Visible = True
        Me.colIRSALIYE.VisibleIndex = 5
        Me.colIRSALIYE.Width = 87
        '
        'colGELDIGI_YER
        '
        Me.colGELDIGI_YER.FieldName = "GELDIGI_YER"
        Me.colGELDIGI_YER.MinWidth = 23
        Me.colGELDIGI_YER.Name = "colGELDIGI_YER"
        Me.colGELDIGI_YER.Visible = True
        Me.colGELDIGI_YER.VisibleIndex = 6
        Me.colGELDIGI_YER.Width = 87
        '
        'colRENK
        '
        Me.colRENK.FieldName = "RENK"
        Me.colRENK.MinWidth = 23
        Me.colRENK.Name = "colRENK"
        Me.colRENK.Visible = True
        Me.colRENK.VisibleIndex = 7
        Me.colRENK.Width = 87
        '
        'colMIKTAR
        '
        Me.colMIKTAR.FieldName = "MIKTAR"
        Me.colMIKTAR.MinWidth = 23
        Me.colMIKTAR.Name = "colMIKTAR"
        Me.colMIKTAR.Visible = True
        Me.colMIKTAR.VisibleIndex = 8
        Me.colMIKTAR.Width = 87
        '
        'colURETICI_TC
        '
        Me.colURETICI_TC.FieldName = "URETICI_TC"
        Me.colURETICI_TC.MinWidth = 23
        Me.colURETICI_TC.Name = "colURETICI_TC"
        Me.colURETICI_TC.Visible = True
        Me.colURETICI_TC.VisibleIndex = 9
        Me.colURETICI_TC.Width = 87
        '
        'colURETICI_ADSOY
        '
        Me.colURETICI_ADSOY.FieldName = "URETICI_ADSOY"
        Me.colURETICI_ADSOY.MinWidth = 23
        Me.colURETICI_ADSOY.Name = "colURETICI_ADSOY"
        Me.colURETICI_ADSOY.Visible = True
        Me.colURETICI_ADSOY.VisibleIndex = 10
        Me.colURETICI_ADSOY.Width = 87
        '
        'colORT_KASA_FIYAT
        '
        Me.colORT_KASA_FIYAT.FieldName = "ORT_KASA_FIYAT"
        Me.colORT_KASA_FIYAT.MinWidth = 23
        Me.colORT_KASA_FIYAT.Name = "colORT_KASA_FIYAT"
        Me.colORT_KASA_FIYAT.Visible = True
        Me.colORT_KASA_FIYAT.VisibleIndex = 11
        Me.colORT_KASA_FIYAT.Width = 87
        '
        'SimpleButton1
        '
        Me.SimpleButton1.ImageOptions.Image = CType(resources.GetObject("SimpleButton1.ImageOptions.Image"), System.Drawing.Image)
        Me.SimpleButton1.Location = New System.Drawing.Point(3, 11)
        Me.SimpleButton1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(43, 49)
        Me.SimpleButton1.TabIndex = 18
        '
        'EO_PTEST1TableAdapter
        '
        Me.EO_PTEST1TableAdapter.ClearBeforeFill = True
        '
        'Form182
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1242, 697)
        Me.Controls.Add(Me.SimpleButton1)
        Me.Controls.Add(Me.GridControl1)
        Me.IconOptions.Image = Global.WindowsApplication1.My.Resources.Resources.LOGIN11
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "Form182"
        Me.Text = "ALANSIS URETIM FIYAT ANALIZ"
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EOPTEST1BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ALANSISDataSet46, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents FormAssistant1 As DevExpress.XtraBars.FormAssistant
    Friend WithEvents DefaultLookAndFeel1 As DevExpress.LookAndFeel.DefaultLookAndFeel
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents ALANSISDataSet46 As ALANSISDataSet46
    Friend WithEvents EOPTEST1BindingSource As BindingSource
    Friend WithEvents EO_PTEST1TableAdapter As ALANSISDataSet46TableAdapters.EO_PTEST1TableAdapter
    Friend WithEvents colSIPARIS As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colYUKEME_TARIHI As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSERI As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSTOK_KODU As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSTOK_ADI As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colIRSALIYE As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colGELDIGI_YER As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colRENK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colMIKTAR As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colURETICI_TC As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colURETICI_ADSOY As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colORT_KASA_FIYAT As DevExpress.XtraGrid.Columns.GridColumn
End Class
