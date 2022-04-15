<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form166
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
        Me.FormAssistant1 = New DevExpress.XtraBars.FormAssistant()
        Me.DefaultLookAndFeel1 = New DevExpress.LookAndFeel.DefaultLookAndFeel(Me.components)
        Me.AlansısDataSet221 = New WindowsApplication1.ALANSISDataSet22()
        Me.EO_ALANSIS_HUCREBAKIYEMADTableAdapter1 = New WindowsApplication1.ALANSISDataSet22TableAdapters.EO_ALANSIS_HUCREBAKIYEMADTableAdapter()
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl()
        Me.EOALANSISHUCREBAKIYEMADBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ALANSISDataSet33 = New WindowsApplication1.ALANSISDataSet33()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colSTOK_KODU = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSERI = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colYERLESIM = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colRENK = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSERI_BAKIYE = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTARIH = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colGELDIGI_YER = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colBOLGE = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colURUN_CESIDI = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colURETICI_TC = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colURETICI_ADSOY = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colKANTARNO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colFISNO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colKASA_SAYI = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colNET = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colMADNO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colIRSALIYE = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colMADSERI = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colExpr1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colKASANO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.EO_ALANSIS_HUCREBAKIYEMADTableAdapter = New WindowsApplication1.ALANSISDataSet33TableAdapters.EO_ALANSIS_HUCREBAKIYEMADTableAdapter()
        CType(Me.AlansısDataSet221, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EOALANSISHUCREBAKIYEMADBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ALANSISDataSet33, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DefaultLookAndFeel1
        '
        Me.DefaultLookAndFeel1.LookAndFeel.SkinName = "Office 2007 Blue"
        '
        'AlansısDataSet221
        '
        Me.AlansısDataSet221.DataSetName = "ALANSISDataSet22"
        Me.AlansısDataSet221.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'EO_ALANSIS_HUCREBAKIYEMADTableAdapter1
        '
        Me.EO_ALANSIS_HUCREBAKIYEMADTableAdapter1.ClearBeforeFill = True
        '
        'GridControl1
        '
        Me.GridControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GridControl1.DataSource = Me.EOALANSISHUCREBAKIYEMADBindingSource
        Me.GridControl1.Location = New System.Drawing.Point(2, 2)
        Me.GridControl1.MainView = Me.GridView1
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.Size = New System.Drawing.Size(910, 481)
        Me.GridControl1.TabIndex = 0
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'EOALANSISHUCREBAKIYEMADBindingSource
        '
        Me.EOALANSISHUCREBAKIYEMADBindingSource.DataMember = "EO_ALANSIS_HUCREBAKIYEMAD"
        Me.EOALANSISHUCREBAKIYEMADBindingSource.DataSource = Me.ALANSISDataSet33
        '
        'ALANSISDataSet33
        '
        Me.ALANSISDataSet33.DataSetName = "ALANSISDataSet33"
        Me.ALANSISDataSet33.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colSTOK_KODU, Me.colSERI, Me.colYERLESIM, Me.colRENK, Me.colSERI_BAKIYE, Me.colTARIH, Me.colGELDIGI_YER, Me.colBOLGE, Me.colURUN_CESIDI, Me.colURETICI_TC, Me.colURETICI_ADSOY, Me.colKANTARNO, Me.colFISNO, Me.colKASA_SAYI, Me.colNET, Me.colMADNO, Me.colIRSALIYE, Me.colMADSERI, Me.colExpr1, Me.colKASANO})
        Me.GridView1.GridControl = Me.GridControl1
        Me.GridView1.Name = "GridView1"
        '
        'colSTOK_KODU
        '
        Me.colSTOK_KODU.FieldName = "STOK_KODU"
        Me.colSTOK_KODU.Name = "colSTOK_KODU"
        Me.colSTOK_KODU.Visible = True
        Me.colSTOK_KODU.VisibleIndex = 0
        '
        'colSERI
        '
        Me.colSERI.FieldName = "SERI"
        Me.colSERI.Name = "colSERI"
        Me.colSERI.Visible = True
        Me.colSERI.VisibleIndex = 1
        '
        'colYERLESIM
        '
        Me.colYERLESIM.FieldName = "YERLESIM"
        Me.colYERLESIM.Name = "colYERLESIM"
        Me.colYERLESIM.Visible = True
        Me.colYERLESIM.VisibleIndex = 2
        '
        'colRENK
        '
        Me.colRENK.FieldName = "RENK"
        Me.colRENK.Name = "colRENK"
        Me.colRENK.Visible = True
        Me.colRENK.VisibleIndex = 3
        '
        'colSERI_BAKIYE
        '
        Me.colSERI_BAKIYE.FieldName = "SERI_BAKIYE"
        Me.colSERI_BAKIYE.Name = "colSERI_BAKIYE"
        Me.colSERI_BAKIYE.Visible = True
        Me.colSERI_BAKIYE.VisibleIndex = 4
        '
        'colTARIH
        '
        Me.colTARIH.FieldName = "TARIH"
        Me.colTARIH.Name = "colTARIH"
        Me.colTARIH.Visible = True
        Me.colTARIH.VisibleIndex = 5
        '
        'colGELDIGI_YER
        '
        Me.colGELDIGI_YER.FieldName = "GELDIGI_YER"
        Me.colGELDIGI_YER.Name = "colGELDIGI_YER"
        Me.colGELDIGI_YER.Visible = True
        Me.colGELDIGI_YER.VisibleIndex = 6
        '
        'colBOLGE
        '
        Me.colBOLGE.FieldName = "BOLGE"
        Me.colBOLGE.Name = "colBOLGE"
        Me.colBOLGE.Visible = True
        Me.colBOLGE.VisibleIndex = 7
        '
        'colURUN_CESIDI
        '
        Me.colURUN_CESIDI.FieldName = "URUN_CESIDI"
        Me.colURUN_CESIDI.Name = "colURUN_CESIDI"
        Me.colURUN_CESIDI.Visible = True
        Me.colURUN_CESIDI.VisibleIndex = 8
        '
        'colURETICI_TC
        '
        Me.colURETICI_TC.FieldName = "URETICI_TC"
        Me.colURETICI_TC.Name = "colURETICI_TC"
        Me.colURETICI_TC.Visible = True
        Me.colURETICI_TC.VisibleIndex = 9
        '
        'colURETICI_ADSOY
        '
        Me.colURETICI_ADSOY.FieldName = "URETICI_ADSOY"
        Me.colURETICI_ADSOY.Name = "colURETICI_ADSOY"
        Me.colURETICI_ADSOY.Visible = True
        Me.colURETICI_ADSOY.VisibleIndex = 10
        '
        'colKANTARNO
        '
        Me.colKANTARNO.FieldName = "KANTARNO"
        Me.colKANTARNO.Name = "colKANTARNO"
        Me.colKANTARNO.Visible = True
        Me.colKANTARNO.VisibleIndex = 11
        '
        'colFISNO
        '
        Me.colFISNO.FieldName = "FISNO"
        Me.colFISNO.Name = "colFISNO"
        Me.colFISNO.Visible = True
        Me.colFISNO.VisibleIndex = 12
        '
        'colKASA_SAYI
        '
        Me.colKASA_SAYI.FieldName = "KASA_SAYI"
        Me.colKASA_SAYI.Name = "colKASA_SAYI"
        Me.colKASA_SAYI.Visible = True
        Me.colKASA_SAYI.VisibleIndex = 13
        '
        'colNET
        '
        Me.colNET.FieldName = "NET"
        Me.colNET.Name = "colNET"
        Me.colNET.Visible = True
        Me.colNET.VisibleIndex = 14
        '
        'colMADNO
        '
        Me.colMADNO.FieldName = "MADNO"
        Me.colMADNO.Name = "colMADNO"
        Me.colMADNO.Visible = True
        Me.colMADNO.VisibleIndex = 15
        '
        'colIRSALIYE
        '
        Me.colIRSALIYE.FieldName = "IRSALIYE"
        Me.colIRSALIYE.Name = "colIRSALIYE"
        Me.colIRSALIYE.Visible = True
        Me.colIRSALIYE.VisibleIndex = 16
        '
        'colMADSERI
        '
        Me.colMADSERI.FieldName = "MADSERI"
        Me.colMADSERI.Name = "colMADSERI"
        Me.colMADSERI.Visible = True
        Me.colMADSERI.VisibleIndex = 17
        '
        'colExpr1
        '
        Me.colExpr1.FieldName = "Expr1"
        Me.colExpr1.Name = "colExpr1"
        Me.colExpr1.Visible = True
        Me.colExpr1.VisibleIndex = 18
        '
        'colKASANO
        '
        Me.colKASANO.FieldName = "KASANO"
        Me.colKASANO.Name = "colKASANO"
        Me.colKASANO.Visible = True
        Me.colKASANO.VisibleIndex = 19
        '
        'EO_ALANSIS_HUCREBAKIYEMADTableAdapter
        '
        Me.EO_ALANSIS_HUCREBAKIYEMADTableAdapter.ClearBeforeFill = True
        '
        'Form166
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(913, 484)
        Me.Controls.Add(Me.GridControl1)
        Me.Name = "Form166"
        Me.Text = "ALANSIS HUCRE BAKIYE - MEYVE ALIM IZLEME"
        CType(Me.AlansısDataSet221, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EOALANSISHUCREBAKIYEMADBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ALANSISDataSet33, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents FormAssistant1 As DevExpress.XtraBars.FormAssistant
    Friend WithEvents DefaultLookAndFeel1 As DevExpress.LookAndFeel.DefaultLookAndFeel
    Friend WithEvents AlansısDataSet221 As ALANSISDataSet22
    Friend WithEvents EO_ALANSIS_HUCREBAKIYEMADTableAdapter1 As ALANSISDataSet22TableAdapters.EO_ALANSIS_HUCREBAKIYEMADTableAdapter
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents ALANSISDataSet33 As ALANSISDataSet33
    Friend WithEvents EOALANSISHUCREBAKIYEMADBindingSource As BindingSource
    Friend WithEvents EO_ALANSIS_HUCREBAKIYEMADTableAdapter As ALANSISDataSet33TableAdapters.EO_ALANSIS_HUCREBAKIYEMADTableAdapter
    Friend WithEvents colSTOK_KODU As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSERI As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colYERLESIM As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colRENK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSERI_BAKIYE As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTARIH As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colGELDIGI_YER As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colBOLGE As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colURUN_CESIDI As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colURETICI_TC As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colURETICI_ADSOY As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colKANTARNO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFISNO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colKASA_SAYI As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNET As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colMADNO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colIRSALIYE As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colMADSERI As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colExpr1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colKASANO As DevExpress.XtraGrid.Columns.GridColumn
End Class
