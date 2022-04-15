<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form228
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
        Me.ALANSISDataSet53 = New WindowsApplication1.ALANSISDataSet53()
        Me.EOALANSISURETPAKETRAPORBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.EO_ALANSIS_URETPAKET_RAPORTableAdapter = New WindowsApplication1.ALANSISDataSet53TableAdapters.EO_ALANSIS_URETPAKET_RAPORTableAdapter()
        Me.colBOLGE_ADI = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colURUN = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDEPOLAMA_TARIHI = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colMUSTERI = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPARTINO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colNET_KG = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colBRUT_KG = New DevExpress.XtraGrid.Columns.GridColumn()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ALANSISDataSet53, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EOALANSISURETPAKETRAPORBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DefaultLookAndFeel1
        '
        Me.DefaultLookAndFeel1.LookAndFeel.SkinName = "Office 2007 Blue"
        '
        'GridControl1
        '
        Me.GridControl1.DataSource = Me.EOALANSISURETPAKETRAPORBindingSource
        Me.GridControl1.Location = New System.Drawing.Point(0, 1)
        Me.GridControl1.MainView = Me.GridView1
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.Size = New System.Drawing.Size(980, 543)
        Me.GridControl1.TabIndex = 0
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colBOLGE_ADI, Me.colURUN, Me.colDEPOLAMA_TARIHI, Me.colMUSTERI, Me.colPARTINO, Me.colNET_KG, Me.colBRUT_KG})
        Me.GridView1.GridControl = Me.GridControl1
        Me.GridView1.Name = "GridView1"
        '
        'ALANSISDataSet53
        '
        Me.ALANSISDataSet53.DataSetName = "ALANSISDataSet53"
        Me.ALANSISDataSet53.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'EOALANSISURETPAKETRAPORBindingSource
        '
        Me.EOALANSISURETPAKETRAPORBindingSource.DataMember = "EO_ALANSIS_URETPAKET_RAPOR"
        Me.EOALANSISURETPAKETRAPORBindingSource.DataSource = Me.ALANSISDataSet53
        '
        'EO_ALANSIS_URETPAKET_RAPORTableAdapter
        '
        Me.EO_ALANSIS_URETPAKET_RAPORTableAdapter.ClearBeforeFill = True
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
        'colMUSTERI
        '
        Me.colMUSTERI.FieldName = "MUSTERI"
        Me.colMUSTERI.Name = "colMUSTERI"
        Me.colMUSTERI.Visible = True
        Me.colMUSTERI.VisibleIndex = 3
        '
        'colPARTINO
        '
        Me.colPARTINO.FieldName = "PARTINO"
        Me.colPARTINO.Name = "colPARTINO"
        Me.colPARTINO.Visible = True
        Me.colPARTINO.VisibleIndex = 4
        '
        'colNET_KG
        '
        Me.colNET_KG.FieldName = "NET_KG"
        Me.colNET_KG.Name = "colNET_KG"
        Me.colNET_KG.Visible = True
        Me.colNET_KG.VisibleIndex = 5
        '
        'colBRUT_KG
        '
        Me.colBRUT_KG.FieldName = "BRUT_KG"
        Me.colBRUT_KG.Name = "colBRUT_KG"
        Me.colBRUT_KG.Visible = True
        Me.colBRUT_KG.VisibleIndex = 6
        '
        'Form228
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(981, 547)
        Me.Controls.Add(Me.GridControl1)
        Me.IconOptions.Image = Global.WindowsApplication1.My.Resources.Resources.LOGIN11
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form228"
        Me.Text = "Üretim Paketleme Rapor"
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ALANSISDataSet53, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EOALANSISURETPAKETRAPORBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DefaultLookAndFeel1 As DevExpress.LookAndFeel.DefaultLookAndFeel
    Friend WithEvents FormAssistant1 As DevExpress.XtraBars.FormAssistant
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents ALANSISDataSet53 As ALANSISDataSet53
    Friend WithEvents EOALANSISURETPAKETRAPORBindingSource As BindingSource
    Friend WithEvents EO_ALANSIS_URETPAKET_RAPORTableAdapter As ALANSISDataSet53TableAdapters.EO_ALANSIS_URETPAKET_RAPORTableAdapter
    Friend WithEvents colBOLGE_ADI As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colURUN As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDEPOLAMA_TARIHI As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colMUSTERI As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPARTINO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNET_KG As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colBRUT_KG As DevExpress.XtraGrid.Columns.GridColumn
End Class
