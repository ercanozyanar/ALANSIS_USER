<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form229
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
        Me.DefaultLookAndFeel1 = New DevExpress.LookAndFeel.DefaultLookAndFeel(Me.components)
        Me.FormAssistant1 = New DevExpress.XtraBars.FormAssistant()
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.ALANSISDataSet54 = New WindowsApplication1.ALANSISDataSet54()
        Me.EOALANSISHAMMADDERAPORBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.EO_ALANSIS_HAMMADDE_RAPORTableAdapter = New WindowsApplication1.ALANSISDataSet54TableAdapters.EO_ALANSIS_HAMMADDE_RAPORTableAdapter()
        Me.colBOLGE_ADI = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colURUN = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDEPOLAMA_TARIHI = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPAKETLEME_BESLEME_TARIHI = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colNET_KG = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colKASA_TIPI = New DevExpress.XtraGrid.Columns.GridColumn()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ALANSISDataSet54, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EOALANSISHAMMADDERAPORBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DefaultLookAndFeel1
        '
        Me.DefaultLookAndFeel1.LookAndFeel.SkinName = "Office 2007 Blue"
        '
        'GridControl1
        '
        Me.GridControl1.DataSource = Me.EOALANSISHAMMADDERAPORBindingSource
        Me.GridControl1.Location = New System.Drawing.Point(1, 1)
        Me.GridControl1.MainView = Me.GridView1
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.Size = New System.Drawing.Size(979, 547)
        Me.GridControl1.TabIndex = 0
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colBOLGE_ADI, Me.colURUN, Me.colDEPOLAMA_TARIHI, Me.colPAKETLEME_BESLEME_TARIHI, Me.colNET_KG, Me.colKASA_TIPI})
        Me.GridView1.GridControl = Me.GridControl1
        Me.GridView1.Name = "GridView1"
        '
        'ALANSISDataSet54
        '
        Me.ALANSISDataSet54.DataSetName = "ALANSISDataSet54"
        Me.ALANSISDataSet54.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'EOALANSISHAMMADDERAPORBindingSource
        '
        Me.EOALANSISHAMMADDERAPORBindingSource.DataMember = "EO_ALANSIS_HAMMADDE_RAPOR"
        Me.EOALANSISHAMMADDERAPORBindingSource.DataSource = Me.ALANSISDataSet54
        '
        'EO_ALANSIS_HAMMADDE_RAPORTableAdapter
        '
        Me.EO_ALANSIS_HAMMADDE_RAPORTableAdapter.ClearBeforeFill = True
        '
        'colBOLGE_ADI
        '
        Me.colBOLGE_ADI.FieldName = "BOLGE_ADI"
        Me.colBOLGE_ADI.Name = "colBOLGE_ADI"
        Me.colBOLGE_ADI.Visible = True
        Me.colBOLGE_ADI.VisibleIndex = 0
        '
        'colURUN
        '
        Me.colURUN.FieldName = "URUN"
        Me.colURUN.Name = "colURUN"
        Me.colURUN.Visible = True
        Me.colURUN.VisibleIndex = 1
        '
        'colDEPOLAMA_TARIHI
        '
        Me.colDEPOLAMA_TARIHI.FieldName = "DEPOLAMA_TARIHI"
        Me.colDEPOLAMA_TARIHI.Name = "colDEPOLAMA_TARIHI"
        Me.colDEPOLAMA_TARIHI.Visible = True
        Me.colDEPOLAMA_TARIHI.VisibleIndex = 2
        '
        'colPAKETLEME_BESLEME_TARIHI
        '
        Me.colPAKETLEME_BESLEME_TARIHI.FieldName = "PAKETLEME_BESLEME_TARIHI"
        Me.colPAKETLEME_BESLEME_TARIHI.Name = "colPAKETLEME_BESLEME_TARIHI"
        Me.colPAKETLEME_BESLEME_TARIHI.Visible = True
        Me.colPAKETLEME_BESLEME_TARIHI.VisibleIndex = 3
        '
        'colNET_KG
        '
        Me.colNET_KG.FieldName = "NET_KG"
        Me.colNET_KG.Name = "colNET_KG"
        Me.colNET_KG.Visible = True
        Me.colNET_KG.VisibleIndex = 4
        '
        'colKASA_TIPI
        '
        Me.colKASA_TIPI.FieldName = "KASA_TIPI"
        Me.colKASA_TIPI.Name = "colKASA_TIPI"
        Me.colKASA_TIPI.Visible = True
        Me.colKASA_TIPI.VisibleIndex = 5
        '
        'Form229
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(981, 547)
        Me.Controls.Add(Me.GridControl1)
        Me.IconOptions.Image = Global.WindowsApplication1.My.Resources.Resources.LOGIN11
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form229"
        Me.Text = "Üretim Paketleme Rapor"
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ALANSISDataSet54, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EOALANSISHAMMADDERAPORBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DefaultLookAndFeel1 As DevExpress.LookAndFeel.DefaultLookAndFeel
    Friend WithEvents FormAssistant1 As DevExpress.XtraBars.FormAssistant
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents ALANSISDataSet54 As ALANSISDataSet54
    Friend WithEvents EOALANSISHAMMADDERAPORBindingSource As BindingSource
    Friend WithEvents EO_ALANSIS_HAMMADDE_RAPORTableAdapter As ALANSISDataSet54TableAdapters.EO_ALANSIS_HAMMADDE_RAPORTableAdapter
    Friend WithEvents colBOLGE_ADI As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colURUN As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDEPOLAMA_TARIHI As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPAKETLEME_BESLEME_TARIHI As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNET_KG As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colKASA_TIPI As DevExpress.XtraGrid.Columns.GridColumn
End Class
