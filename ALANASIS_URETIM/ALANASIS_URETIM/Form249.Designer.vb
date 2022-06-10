<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form249
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form249))
        Me.FormAssistant1 = New DevExpress.XtraBars.FormAssistant()
        Me.DefaultLookAndFeel1 = New DevExpress.LookAndFeel.DefaultLookAndFeel(Me.components)
        Me.EO_ALANSIS_EXCELYURTICITableAdapter1 = New WindowsApplication1.ALANSISDataSet60TableAdapters.EO_ALANSIS_EXCELYURTICITableAdapter()
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl()
        Me.EOALANSISEXCELYURTICISATISBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ALANSISDataSet62 = New WindowsApplication1.ALANSISDataSet62()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colHAFTA = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSATIS_TARIHI = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colURUN = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colMUSTERI = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colMUSTERI_KATEGORI = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colNET_MIKTAR = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colBIRIM_FIYAT = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTOPLAM_TUTAR = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTUR = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCIKIS_YERI = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton()
        Me.EO_ALANSIS_EXCELYURTICISATISTableAdapter = New WindowsApplication1.ALANSISDataSet62TableAdapters.EO_ALANSIS_EXCELYURTICISATISTableAdapter()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EOALANSISEXCELYURTICISATISBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ALANSISDataSet62, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DefaultLookAndFeel1
        '
        Me.DefaultLookAndFeel1.LookAndFeel.SkinName = "Office 2007 Blue"
        '
        'EO_ALANSIS_EXCELYURTICITableAdapter1
        '
        Me.EO_ALANSIS_EXCELYURTICITableAdapter1.ClearBeforeFill = True
        '
        'GridControl1
        '
        Me.GridControl1.DataSource = Me.EOALANSISEXCELYURTICISATISBindingSource
        Me.GridControl1.Location = New System.Drawing.Point(3, 56)
        Me.GridControl1.MainView = Me.GridView1
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.Size = New System.Drawing.Size(1185, 622)
        Me.GridControl1.TabIndex = 0
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'EOALANSISEXCELYURTICISATISBindingSource
        '
        Me.EOALANSISEXCELYURTICISATISBindingSource.DataMember = "EO_ALANSIS_EXCELYURTICISATIS"
        Me.EOALANSISEXCELYURTICISATISBindingSource.DataSource = Me.ALANSISDataSet62
        '
        'ALANSISDataSet62
        '
        Me.ALANSISDataSet62.DataSetName = "ALANSISDataSet62"
        Me.ALANSISDataSet62.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colID, Me.colHAFTA, Me.colSATIS_TARIHI, Me.colURUN, Me.colMUSTERI, Me.colMUSTERI_KATEGORI, Me.colNET_MIKTAR, Me.colBIRIM_FIYAT, Me.colTOPLAM_TUTAR, Me.colTUR, Me.colCIKIS_YERI})
        Me.GridView1.GridControl = Me.GridControl1
        Me.GridView1.Name = "GridView1"
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
        'colHAFTA
        '
        Me.colHAFTA.FieldName = "HAFTA"
        Me.colHAFTA.MinWidth = 25
        Me.colHAFTA.Name = "colHAFTA"
        Me.colHAFTA.Visible = True
        Me.colHAFTA.VisibleIndex = 1
        Me.colHAFTA.Width = 94
        '
        'colSATIS_TARIHI
        '
        Me.colSATIS_TARIHI.FieldName = "SATIS_TARIHI"
        Me.colSATIS_TARIHI.MinWidth = 25
        Me.colSATIS_TARIHI.Name = "colSATIS_TARIHI"
        Me.colSATIS_TARIHI.Visible = True
        Me.colSATIS_TARIHI.VisibleIndex = 2
        Me.colSATIS_TARIHI.Width = 94
        '
        'colURUN
        '
        Me.colURUN.FieldName = "URUN"
        Me.colURUN.MinWidth = 25
        Me.colURUN.Name = "colURUN"
        Me.colURUN.Visible = True
        Me.colURUN.VisibleIndex = 3
        Me.colURUN.Width = 94
        '
        'colMUSTERI
        '
        Me.colMUSTERI.FieldName = "MUSTERI"
        Me.colMUSTERI.MinWidth = 25
        Me.colMUSTERI.Name = "colMUSTERI"
        Me.colMUSTERI.Visible = True
        Me.colMUSTERI.VisibleIndex = 4
        Me.colMUSTERI.Width = 94
        '
        'colMUSTERI_KATEGORI
        '
        Me.colMUSTERI_KATEGORI.FieldName = "MUSTERI_KATEGORI"
        Me.colMUSTERI_KATEGORI.MinWidth = 25
        Me.colMUSTERI_KATEGORI.Name = "colMUSTERI_KATEGORI"
        Me.colMUSTERI_KATEGORI.Visible = True
        Me.colMUSTERI_KATEGORI.VisibleIndex = 5
        Me.colMUSTERI_KATEGORI.Width = 94
        '
        'colNET_MIKTAR
        '
        Me.colNET_MIKTAR.FieldName = "NET_MIKTAR"
        Me.colNET_MIKTAR.MinWidth = 25
        Me.colNET_MIKTAR.Name = "colNET_MIKTAR"
        Me.colNET_MIKTAR.Visible = True
        Me.colNET_MIKTAR.VisibleIndex = 6
        Me.colNET_MIKTAR.Width = 94
        '
        'colBIRIM_FIYAT
        '
        Me.colBIRIM_FIYAT.FieldName = "BIRIM_FIYAT"
        Me.colBIRIM_FIYAT.MinWidth = 25
        Me.colBIRIM_FIYAT.Name = "colBIRIM_FIYAT"
        Me.colBIRIM_FIYAT.Visible = True
        Me.colBIRIM_FIYAT.VisibleIndex = 7
        Me.colBIRIM_FIYAT.Width = 94
        '
        'colTOPLAM_TUTAR
        '
        Me.colTOPLAM_TUTAR.FieldName = "TOPLAM_TUTAR"
        Me.colTOPLAM_TUTAR.MinWidth = 25
        Me.colTOPLAM_TUTAR.Name = "colTOPLAM_TUTAR"
        Me.colTOPLAM_TUTAR.Visible = True
        Me.colTOPLAM_TUTAR.VisibleIndex = 8
        Me.colTOPLAM_TUTAR.Width = 94
        '
        'colTUR
        '
        Me.colTUR.FieldName = "TUR"
        Me.colTUR.MinWidth = 25
        Me.colTUR.Name = "colTUR"
        Me.colTUR.Visible = True
        Me.colTUR.VisibleIndex = 9
        Me.colTUR.Width = 94
        '
        'colCIKIS_YERI
        '
        Me.colCIKIS_YERI.FieldName = "CIKIS_YERI"
        Me.colCIKIS_YERI.MinWidth = 25
        Me.colCIKIS_YERI.Name = "colCIKIS_YERI"
        Me.colCIKIS_YERI.Visible = True
        Me.colCIKIS_YERI.VisibleIndex = 10
        Me.colCIKIS_YERI.Width = 94
        '
        'SimpleButton1
        '
        Me.SimpleButton1.ImageOptions.Image = CType(resources.GetObject("SimpleButton1.ImageOptions.Image"), System.Drawing.Image)
        Me.SimpleButton1.Location = New System.Drawing.Point(3, 2)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(43, 48)
        Me.SimpleButton1.TabIndex = 6
        '
        'EO_ALANSIS_EXCELYURTICISATISTableAdapter
        '
        Me.EO_ALANSIS_EXCELYURTICISATISTableAdapter.ClearBeforeFill = True
        '
        'Form249
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1190, 680)
        Me.Controls.Add(Me.SimpleButton1)
        Me.Controls.Add(Me.GridControl1)
        Me.IconOptions.Image = Global.WindowsApplication1.My.Resources.Resources.LOGIN11
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form249"
        Me.Text = "ALANSIS YURTICI SATIS TABLOSU"
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EOALANSISEXCELYURTICISATISBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ALANSISDataSet62, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents FormAssistant1 As DevExpress.XtraBars.FormAssistant
    Friend WithEvents DefaultLookAndFeel1 As DevExpress.LookAndFeel.DefaultLookAndFeel
    Friend WithEvents EO_ALANSIS_EXCELYURTICITableAdapter1 As ALANSISDataSet60TableAdapters.EO_ALANSIS_EXCELYURTICITableAdapter
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents ALANSISDataSet62 As ALANSISDataSet62
    Friend WithEvents EOALANSISEXCELYURTICISATISBindingSource As BindingSource
    Friend WithEvents EO_ALANSIS_EXCELYURTICISATISTableAdapter As ALANSISDataSet62TableAdapters.EO_ALANSIS_EXCELYURTICISATISTableAdapter
    Friend WithEvents colID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colHAFTA As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSATIS_TARIHI As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colURUN As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colMUSTERI As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colMUSTERI_KATEGORI As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNET_MIKTAR As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colBIRIM_FIYAT As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTOPLAM_TUTAR As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTUR As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCIKIS_YERI As DevExpress.XtraGrid.Columns.GridColumn
End Class
