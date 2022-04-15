<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form123
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
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl()
        Me.AlansısDataSet81 = New WindowsApplication1.ALANSISDataSet8()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colMUSTERI = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPOS_NO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTESLIM_ULKE = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colNAKLIYECI = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPLANLANAN_YUKLEME_TARIHI = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colGERCEKLESEN__YUKLEME_TARIHI = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colYUKLEME_FARK_GUN = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colYUKLEME_DURUMU = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPLANNED_DELIVERY_DATE = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colGERCEKLESEN_TESLIM = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTESLIM_FARK_GUN = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTESLIM_DURUMU = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.EO_ALANSIS_SEVKIYAT_TESLIMFARKTableAdapter1 = New WindowsApplication1.ALANSISDataSet8TableAdapters.EO_ALANSIS_SEVKIYAT_TESLIMFARKTableAdapter()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AlansısDataSet81, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DefaultLookAndFeel1
        '
        Me.DefaultLookAndFeel1.LookAndFeel.SkinName = "Office 2007 Blue"
        '
        'GridControl1
        '
        Me.GridControl1.DataMember = "EO_ALANSIS_SEVKIYAT_TESLIMFARK"
        Me.GridControl1.DataSource = Me.AlansısDataSet81
        Me.GridControl1.Location = New System.Drawing.Point(4, 4)
        Me.GridControl1.MainView = Me.GridView1
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.Size = New System.Drawing.Size(1034, 565)
        Me.GridControl1.TabIndex = 0
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'AlansısDataSet81
        '
        Me.AlansısDataSet81.DataSetName = "ALANSISDataSet8"
        Me.AlansısDataSet81.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colMUSTERI, Me.colPOS_NO, Me.colTESLIM_ULKE, Me.colNAKLIYECI, Me.colPLANLANAN_YUKLEME_TARIHI, Me.colGERCEKLESEN__YUKLEME_TARIHI, Me.colYUKLEME_FARK_GUN, Me.colYUKLEME_DURUMU, Me.colPLANNED_DELIVERY_DATE, Me.colGERCEKLESEN_TESLIM, Me.colTESLIM_FARK_GUN, Me.colTESLIM_DURUMU})
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
        'colGERCEKLESEN__YUKLEME_TARIHI
        '
        Me.colGERCEKLESEN__YUKLEME_TARIHI.FieldName = "GERCEKLESEN__YUKLEME_TARIHI"
        Me.colGERCEKLESEN__YUKLEME_TARIHI.Name = "colGERCEKLESEN__YUKLEME_TARIHI"
        Me.colGERCEKLESEN__YUKLEME_TARIHI.Visible = True
        Me.colGERCEKLESEN__YUKLEME_TARIHI.VisibleIndex = 5
        '
        'colYUKLEME_FARK_GUN
        '
        Me.colYUKLEME_FARK_GUN.FieldName = "YUKLEME_FARK_GUN"
        Me.colYUKLEME_FARK_GUN.Name = "colYUKLEME_FARK_GUN"
        Me.colYUKLEME_FARK_GUN.Visible = True
        Me.colYUKLEME_FARK_GUN.VisibleIndex = 6
        '
        'colYUKLEME_DURUMU
        '
        Me.colYUKLEME_DURUMU.FieldName = "YUKLEME_DURUMU"
        Me.colYUKLEME_DURUMU.Name = "colYUKLEME_DURUMU"
        Me.colYUKLEME_DURUMU.Visible = True
        Me.colYUKLEME_DURUMU.VisibleIndex = 7
        '
        'colPLANNED_DELIVERY_DATE
        '
        Me.colPLANNED_DELIVERY_DATE.FieldName = "PLANNED_DELIVERY_DATE"
        Me.colPLANNED_DELIVERY_DATE.Name = "colPLANNED_DELIVERY_DATE"
        Me.colPLANNED_DELIVERY_DATE.Visible = True
        Me.colPLANNED_DELIVERY_DATE.VisibleIndex = 8
        '
        'colGERCEKLESEN_TESLIM
        '
        Me.colGERCEKLESEN_TESLIM.FieldName = "GERCEKLESEN_TESLIM"
        Me.colGERCEKLESEN_TESLIM.Name = "colGERCEKLESEN_TESLIM"
        Me.colGERCEKLESEN_TESLIM.Visible = True
        Me.colGERCEKLESEN_TESLIM.VisibleIndex = 9
        '
        'colTESLIM_FARK_GUN
        '
        Me.colTESLIM_FARK_GUN.FieldName = "TESLIM_FARK_GUN"
        Me.colTESLIM_FARK_GUN.Name = "colTESLIM_FARK_GUN"
        Me.colTESLIM_FARK_GUN.Visible = True
        Me.colTESLIM_FARK_GUN.VisibleIndex = 10
        '
        'colTESLIM_DURUMU
        '
        Me.colTESLIM_DURUMU.FieldName = "TESLIM_DURUMU"
        Me.colTESLIM_DURUMU.Name = "colTESLIM_DURUMU"
        Me.colTESLIM_DURUMU.Visible = True
        Me.colTESLIM_DURUMU.VisibleIndex = 11
        '
        'EO_ALANSIS_SEVKIYAT_TESLIMFARKTableAdapter1
        '
        Me.EO_ALANSIS_SEVKIYAT_TESLIMFARKTableAdapter1.ClearBeforeFill = True
        '
        'Form123
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1041, 572)
        Me.Controls.Add(Me.GridControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "Form123"
        Me.Text = "ALANSIS - TESLIM / FARK"
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AlansısDataSet81, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents FormAssistant1 As DevExpress.XtraBars.FormAssistant
    Friend WithEvents DefaultLookAndFeel1 As DevExpress.LookAndFeel.DefaultLookAndFeel
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents AlansısDataSet81 As ALANSISDataSet8
    Friend WithEvents colMUSTERI As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPOS_NO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTESLIM_ULKE As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNAKLIYECI As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPLANLANAN_YUKLEME_TARIHI As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colGERCEKLESEN__YUKLEME_TARIHI As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colYUKLEME_FARK_GUN As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colYUKLEME_DURUMU As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPLANNED_DELIVERY_DATE As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colGERCEKLESEN_TESLIM As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTESLIM_FARK_GUN As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTESLIM_DURUMU As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents EO_ALANSIS_SEVKIYAT_TESLIMFARKTableAdapter1 As ALANSISDataSet8TableAdapters.EO_ALANSIS_SEVKIYAT_TESLIMFARKTableAdapter
End Class
