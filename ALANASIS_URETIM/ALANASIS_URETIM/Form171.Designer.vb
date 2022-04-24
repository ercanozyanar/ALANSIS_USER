<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form171
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form171))
        Me.FormAssistant1 = New DevExpress.XtraBars.FormAssistant()
        Me.DefaultLookAndFeel1 = New DevExpress.LookAndFeel.DefaultLookAndFeel(Me.components)
        Me.EOALANSISPAKETBESRAPORBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ALANSISDataSet26 = New WindowsApplication1.ALANSISDataSet26()
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton()
        Me.EO_ALANSIS_PAKETBESRAPORTableAdapter = New WindowsApplication1.ALANSISDataSet26TableAdapters.EO_ALANSIS_PAKETBESRAPORTableAdapter()
        Me.EOALANSISPAKETBESRAPORBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.ALANSISDataSet30 = New WindowsApplication1.ALANSISDataSet30()
        Me.EO_ALANSIS_PAKETBESRAPORTableAdapter1 = New WindowsApplication1.ALANSISDataSet30TableAdapters.EO_ALANSIS_PAKETBESRAPORTableAdapter()
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl()
        Me.EOALANSISPAKETBESRAPORBindingSource2 = New System.Windows.Forms.BindingSource(Me.components)
        Me.ALANSISDataSet31 = New WindowsApplication1.ALANSISDataSet31()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colURETICI = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colURUN = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colHASAT_TARIHI = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPAKETLEMEYE_BESLEME_TARIHI = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colKASA_CESIDI = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colNETKG = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colURETICI_ADSOY = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPARTI = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.EO_ALANSIS_PAKETBESRAPORTableAdapter2 = New WindowsApplication1.ALANSISDataSet31TableAdapters.EO_ALANSIS_PAKETBESRAPORTableAdapter()
        CType(Me.EOALANSISPAKETBESRAPORBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ALANSISDataSet26, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EOALANSISPAKETBESRAPORBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ALANSISDataSet30, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EOALANSISPAKETBESRAPORBindingSource2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ALANSISDataSet31, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DefaultLookAndFeel1
        '
        Me.DefaultLookAndFeel1.LookAndFeel.SkinName = "Office 2007 Blue"
        '
        'EOALANSISPAKETBESRAPORBindingSource
        '
        Me.EOALANSISPAKETBESRAPORBindingSource.DataMember = "EO_ALANSIS_PAKETBESRAPOR"
        Me.EOALANSISPAKETBESRAPORBindingSource.DataSource = Me.ALANSISDataSet26
        '
        'ALANSISDataSet26
        '
        Me.ALANSISDataSet26.DataSetName = "ALANSISDataSet26"
        Me.ALANSISDataSet26.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'SimpleButton1
        '
        Me.SimpleButton1.ImageOptions.Image = CType(resources.GetObject("SimpleButton1.ImageOptions.Image"), System.Drawing.Image)
        Me.SimpleButton1.Location = New System.Drawing.Point(2, 4)
        Me.SimpleButton1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(41, 41)
        Me.SimpleButton1.TabIndex = 4
        '
        'EO_ALANSIS_PAKETBESRAPORTableAdapter
        '
        Me.EO_ALANSIS_PAKETBESRAPORTableAdapter.ClearBeforeFill = True
        '
        'EOALANSISPAKETBESRAPORBindingSource1
        '
        Me.EOALANSISPAKETBESRAPORBindingSource1.DataMember = "EO_ALANSIS_PAKETBESRAPOR"
        Me.EOALANSISPAKETBESRAPORBindingSource1.DataSource = Me.ALANSISDataSet30
        '
        'ALANSISDataSet30
        '
        Me.ALANSISDataSet30.DataSetName = "ALANSISDataSet30"
        Me.ALANSISDataSet30.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'EO_ALANSIS_PAKETBESRAPORTableAdapter1
        '
        Me.EO_ALANSIS_PAKETBESRAPORTableAdapter1.ClearBeforeFill = True
        '
        'GridControl1
        '
        Me.GridControl1.DataSource = Me.EOALANSISPAKETBESRAPORBindingSource2
        Me.GridControl1.EmbeddedNavigator.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GridControl1.Location = New System.Drawing.Point(2, 52)
        Me.GridControl1.MainView = Me.GridView1
        Me.GridControl1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.Size = New System.Drawing.Size(1179, 512)
        Me.GridControl1.TabIndex = 5
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'EOALANSISPAKETBESRAPORBindingSource2
        '
        Me.EOALANSISPAKETBESRAPORBindingSource2.DataMember = "EO_ALANSIS_PAKETBESRAPOR"
        Me.EOALANSISPAKETBESRAPORBindingSource2.DataSource = Me.ALANSISDataSet31
        '
        'ALANSISDataSet31
        '
        Me.ALANSISDataSet31.DataSetName = "ALANSISDataSet31"
        Me.ALANSISDataSet31.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colURETICI, Me.colURUN, Me.colHASAT_TARIHI, Me.colPAKETLEMEYE_BESLEME_TARIHI, Me.colKASA_CESIDI, Me.colNETKG, Me.colURETICI_ADSOY, Me.colPARTI})
        Me.GridView1.DetailHeight = 431
        Me.GridView1.GridControl = Me.GridControl1
        Me.GridView1.Name = "GridView1"
        '
        'colURETICI
        '
        Me.colURETICI.FieldName = "URETICI"
        Me.colURETICI.MinWidth = 23
        Me.colURETICI.Name = "colURETICI"
        Me.colURETICI.Visible = True
        Me.colURETICI.VisibleIndex = 0
        Me.colURETICI.Width = 87
        '
        'colURUN
        '
        Me.colURUN.FieldName = "URUN"
        Me.colURUN.MinWidth = 23
        Me.colURUN.Name = "colURUN"
        Me.colURUN.Visible = True
        Me.colURUN.VisibleIndex = 1
        Me.colURUN.Width = 87
        '
        'colHASAT_TARIHI
        '
        Me.colHASAT_TARIHI.FieldName = "HASAT_TARIHI"
        Me.colHASAT_TARIHI.MinWidth = 23
        Me.colHASAT_TARIHI.Name = "colHASAT_TARIHI"
        Me.colHASAT_TARIHI.Visible = True
        Me.colHASAT_TARIHI.VisibleIndex = 2
        Me.colHASAT_TARIHI.Width = 87
        '
        'colPAKETLEMEYE_BESLEME_TARIHI
        '
        Me.colPAKETLEMEYE_BESLEME_TARIHI.FieldName = "PAKETLEMEYE_BESLEME_TARIHI"
        Me.colPAKETLEMEYE_BESLEME_TARIHI.MinWidth = 23
        Me.colPAKETLEMEYE_BESLEME_TARIHI.Name = "colPAKETLEMEYE_BESLEME_TARIHI"
        Me.colPAKETLEMEYE_BESLEME_TARIHI.Visible = True
        Me.colPAKETLEMEYE_BESLEME_TARIHI.VisibleIndex = 3
        Me.colPAKETLEMEYE_BESLEME_TARIHI.Width = 87
        '
        'colKASA_CESIDI
        '
        Me.colKASA_CESIDI.FieldName = "KASA_CESIDI"
        Me.colKASA_CESIDI.MinWidth = 23
        Me.colKASA_CESIDI.Name = "colKASA_CESIDI"
        Me.colKASA_CESIDI.Visible = True
        Me.colKASA_CESIDI.VisibleIndex = 4
        Me.colKASA_CESIDI.Width = 87
        '
        'colNETKG
        '
        Me.colNETKG.FieldName = "NETKG"
        Me.colNETKG.MinWidth = 23
        Me.colNETKG.Name = "colNETKG"
        Me.colNETKG.Visible = True
        Me.colNETKG.VisibleIndex = 5
        Me.colNETKG.Width = 87
        '
        'colURETICI_ADSOY
        '
        Me.colURETICI_ADSOY.FieldName = "URETICI_ADSOY"
        Me.colURETICI_ADSOY.MinWidth = 23
        Me.colURETICI_ADSOY.Name = "colURETICI_ADSOY"
        Me.colURETICI_ADSOY.Visible = True
        Me.colURETICI_ADSOY.VisibleIndex = 6
        Me.colURETICI_ADSOY.Width = 87
        '
        'colPARTI
        '
        Me.colPARTI.FieldName = "PARTI"
        Me.colPARTI.MinWidth = 23
        Me.colPARTI.Name = "colPARTI"
        Me.colPARTI.Visible = True
        Me.colPARTI.VisibleIndex = 7
        Me.colPARTI.Width = 87
        '
        'EO_ALANSIS_PAKETBESRAPORTableAdapter2
        '
        Me.EO_ALANSIS_PAKETBESRAPORTableAdapter2.ClearBeforeFill = True
        '
        'Form171
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1183, 566)
        Me.Controls.Add(Me.GridControl1)
        Me.Controls.Add(Me.SimpleButton1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "Form171"
        Me.Text = "ALANSIS PAKETLEME BESLEME RAPORU"
        CType(Me.EOALANSISPAKETBESRAPORBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ALANSISDataSet26, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EOALANSISPAKETBESRAPORBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ALANSISDataSet30, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EOALANSISPAKETBESRAPORBindingSource2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ALANSISDataSet31, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents FormAssistant1 As DevExpress.XtraBars.FormAssistant
    Friend WithEvents DefaultLookAndFeel1 As DevExpress.LookAndFeel.DefaultLookAndFeel
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents ALANSISDataSet26 As ALANSISDataSet26
    Friend WithEvents EOALANSISPAKETBESRAPORBindingSource As BindingSource
    Friend WithEvents EO_ALANSIS_PAKETBESRAPORTableAdapter As ALANSISDataSet26TableAdapters.EO_ALANSIS_PAKETBESRAPORTableAdapter
    Friend WithEvents ALANSISDataSet30 As ALANSISDataSet30
    Friend WithEvents EOALANSISPAKETBESRAPORBindingSource1 As BindingSource
    Friend WithEvents EO_ALANSIS_PAKETBESRAPORTableAdapter1 As ALANSISDataSet30TableAdapters.EO_ALANSIS_PAKETBESRAPORTableAdapter
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents ALANSISDataSet31 As ALANSISDataSet31
    Friend WithEvents EOALANSISPAKETBESRAPORBindingSource2 As BindingSource
    Friend WithEvents EO_ALANSIS_PAKETBESRAPORTableAdapter2 As ALANSISDataSet31TableAdapters.EO_ALANSIS_PAKETBESRAPORTableAdapter
    Friend WithEvents colURETICI As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colURUN As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colHASAT_TARIHI As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPAKETLEMEYE_BESLEME_TARIHI As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colKASA_CESIDI As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNETKG As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colURETICI_ADSOY As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPARTI As DevExpress.XtraGrid.Columns.GridColumn
End Class
