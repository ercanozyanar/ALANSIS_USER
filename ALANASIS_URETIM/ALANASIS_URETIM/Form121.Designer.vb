<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form121
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
        Dim GridLevelNode1 As DevExpress.XtraGrid.GridLevelNode = New DevExpress.XtraGrid.GridLevelNode()
        Me.FormAssistant1 = New DevExpress.XtraBars.FormAssistant()
        Me.DefaultLookAndFeel1 = New DevExpress.LookAndFeel.DefaultLookAndFeel(Me.components)
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl()
        Me.AlansısDataSet61 = New WindowsApplication1.ALANSISDataSet6()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colMUSTERI = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPOS_NO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTESLIM_ULKE = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colNAKLIYECI = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPLANLANAN_YUKLEME_TARIHI = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colYUKLEME_TARIHI = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colGERCEKLESEN_TESLIM_TARIHI = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTESLIM_GECIKME_DURUMU = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTESLIM_ADRESINE_VARIS_TARIHI = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTRANSIT_SURE_GUN = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.EO_ALANSIS_SEVKIYAT_GUNCELDURUMTableAdapter1 = New WindowsApplication1.ALANSISDataSet6TableAdapters.EO_ALANSIS_SEVKIYAT_GUNCELDURUMTableAdapter()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AlansısDataSet61, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DefaultLookAndFeel1
        '
        Me.DefaultLookAndFeel1.LookAndFeel.SkinName = "Office 2007 Blue"
        '
        'GridControl1
        '
        Me.GridControl1.DataMember = "EO_ALANSIS_SEVKIYAT_GUNCELDURUM"
        Me.GridControl1.DataSource = Me.AlansısDataSet61
        GridLevelNode1.RelationName = "Level1"
        Me.GridControl1.LevelTree.Nodes.AddRange(New DevExpress.XtraGrid.GridLevelNode() {GridLevelNode1})
        Me.GridControl1.Location = New System.Drawing.Point(2, 1)
        Me.GridControl1.MainView = Me.GridView1
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.Size = New System.Drawing.Size(1036, 567)
        Me.GridControl1.TabIndex = 0
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'AlansısDataSet61
        '
        Me.AlansısDataSet61.DataSetName = "ALANSISDataSet6"
        Me.AlansısDataSet61.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colMUSTERI, Me.colPOS_NO, Me.colTESLIM_ULKE, Me.colNAKLIYECI, Me.colPLANLANAN_YUKLEME_TARIHI, Me.colYUKLEME_TARIHI, Me.colGERCEKLESEN_TESLIM_TARIHI, Me.colTESLIM_GECIKME_DURUMU, Me.colTESLIM_ADRESINE_VARIS_TARIHI, Me.colTRANSIT_SURE_GUN})
        Me.GridView1.GridControl = Me.GridControl1
        Me.GridView1.Name = "GridView1"
        '
        'colMUSTERI
        '
        Me.colMUSTERI.FieldName = "MUSTERI"
        Me.colMUSTERI.Name = "colMUSTERI"
        Me.colMUSTERI.Visible = True
        Me.colMUSTERI.VisibleIndex = 0
        '
        'colPOS_NO
        '
        Me.colPOS_NO.FieldName = "POS_NO"
        Me.colPOS_NO.Name = "colPOS_NO"
        Me.colPOS_NO.Visible = True
        Me.colPOS_NO.VisibleIndex = 1
        '
        'colTESLIM_ULKE
        '
        Me.colTESLIM_ULKE.FieldName = "TESLIM_ULKE"
        Me.colTESLIM_ULKE.Name = "colTESLIM_ULKE"
        Me.colTESLIM_ULKE.Visible = True
        Me.colTESLIM_ULKE.VisibleIndex = 2
        '
        'colNAKLIYECI
        '
        Me.colNAKLIYECI.FieldName = "NAKLIYECI"
        Me.colNAKLIYECI.Name = "colNAKLIYECI"
        Me.colNAKLIYECI.Visible = True
        Me.colNAKLIYECI.VisibleIndex = 3
        '
        'colPLANLANAN_YUKLEME_TARIHI
        '
        Me.colPLANLANAN_YUKLEME_TARIHI.FieldName = "PLANLANAN_YUKLEME_TARIHI"
        Me.colPLANLANAN_YUKLEME_TARIHI.Name = "colPLANLANAN_YUKLEME_TARIHI"
        Me.colPLANLANAN_YUKLEME_TARIHI.Visible = True
        Me.colPLANLANAN_YUKLEME_TARIHI.VisibleIndex = 4
        '
        'colYUKLEME_TARIHI
        '
        Me.colYUKLEME_TARIHI.FieldName = "YUKLEME_TARIHI"
        Me.colYUKLEME_TARIHI.Name = "colYUKLEME_TARIHI"
        Me.colYUKLEME_TARIHI.Visible = True
        Me.colYUKLEME_TARIHI.VisibleIndex = 5
        '
        'colGERCEKLESEN_TESLIM_TARIHI
        '
        Me.colGERCEKLESEN_TESLIM_TARIHI.FieldName = "GERCEKLESEN_TESLIM_TARIHI"
        Me.colGERCEKLESEN_TESLIM_TARIHI.Name = "colGERCEKLESEN_TESLIM_TARIHI"
        Me.colGERCEKLESEN_TESLIM_TARIHI.Visible = True
        Me.colGERCEKLESEN_TESLIM_TARIHI.VisibleIndex = 6
        '
        'colTESLIM_GECIKME_DURUMU
        '
        Me.colTESLIM_GECIKME_DURUMU.FieldName = "TESLIM_GECIKME_DURUMU"
        Me.colTESLIM_GECIKME_DURUMU.Name = "colTESLIM_GECIKME_DURUMU"
        Me.colTESLIM_GECIKME_DURUMU.Visible = True
        Me.colTESLIM_GECIKME_DURUMU.VisibleIndex = 7
        '
        'colTESLIM_ADRESINE_VARIS_TARIHI
        '
        Me.colTESLIM_ADRESINE_VARIS_TARIHI.FieldName = "TESLIM_ADRESINE_VARIS_TARIHI"
        Me.colTESLIM_ADRESINE_VARIS_TARIHI.Name = "colTESLIM_ADRESINE_VARIS_TARIHI"
        Me.colTESLIM_ADRESINE_VARIS_TARIHI.Visible = True
        Me.colTESLIM_ADRESINE_VARIS_TARIHI.VisibleIndex = 8
        '
        'colTRANSIT_SURE_GUN
        '
        Me.colTRANSIT_SURE_GUN.FieldName = "TRANSIT_SURE_GUN"
        Me.colTRANSIT_SURE_GUN.Name = "colTRANSIT_SURE_GUN"
        Me.colTRANSIT_SURE_GUN.Visible = True
        Me.colTRANSIT_SURE_GUN.VisibleIndex = 9
        '
        'EO_ALANSIS_SEVKIYAT_GUNCELDURUMTableAdapter1
        '
        Me.EO_ALANSIS_SEVKIYAT_GUNCELDURUMTableAdapter1.ClearBeforeFill = True
        '
        'Form121
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1041, 572)
        Me.Controls.Add(Me.GridControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "Form121"
        Me.Text = "ALANSIS - LOJISTIK  GUNCEL DURUM"
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AlansısDataSet61, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents FormAssistant1 As DevExpress.XtraBars.FormAssistant
    Friend WithEvents DefaultLookAndFeel1 As DevExpress.LookAndFeel.DefaultLookAndFeel
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents AlansısDataSet61 As ALANSISDataSet6
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colMUSTERI As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPOS_NO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTESLIM_ULKE As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNAKLIYECI As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPLANLANAN_YUKLEME_TARIHI As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colYUKLEME_TARIHI As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colGERCEKLESEN_TESLIM_TARIHI As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTESLIM_GECIKME_DURUMU As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTESLIM_ADRESINE_VARIS_TARIHI As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTRANSIT_SURE_GUN As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents EO_ALANSIS_SEVKIYAT_GUNCELDURUMTableAdapter1 As ALANSISDataSet6TableAdapters.EO_ALANSIS_SEVKIYAT_GUNCELDURUMTableAdapter
End Class
