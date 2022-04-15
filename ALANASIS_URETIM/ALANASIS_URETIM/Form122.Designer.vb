<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form122
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
        Me.AlansısDataSet71 = New WindowsApplication1.ALANSISDataSet7()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colBUGUN_YUKLENMESI_GEREKENLER = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colYARIN_YUKLENMESI_GEREKENLER = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colIKI_GUN_SONRA_YUKLENMESI_GEREKENLER = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colUC_GUN_SONRA_YUKLENMESI_GEREKENLER = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDORT_GUN_SONRA_YUKLENMESI_GEREKENLER = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colBES_GUN_SONRA_YUKLENMESI_GEREKENLER = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.EO_ALANSIS_SEVKIYATYUKLEMEDURUMTableAdapter1 = New WindowsApplication1.ALANSISDataSet7TableAdapters.EO_ALANSIS_SEVKIYATYUKLEMEDURUMTableAdapter()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AlansısDataSet71, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DefaultLookAndFeel1
        '
        Me.DefaultLookAndFeel1.LookAndFeel.SkinName = "Office 2007 Blue"
        '
        'GridControl1
        '
        Me.GridControl1.DataMember = "EO_ALANSIS_SEVKIYATYUKLEMEDURUM"
        Me.GridControl1.DataSource = Me.AlansısDataSet71
        Me.GridControl1.Location = New System.Drawing.Point(2, 1)
        Me.GridControl1.MainView = Me.GridView1
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.Size = New System.Drawing.Size(996, 451)
        Me.GridControl1.TabIndex = 0
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'AlansısDataSet71
        '
        Me.AlansısDataSet71.DataSetName = "ALANSISDataSet7"
        Me.AlansısDataSet71.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colBUGUN_YUKLENMESI_GEREKENLER, Me.colYARIN_YUKLENMESI_GEREKENLER, Me.colIKI_GUN_SONRA_YUKLENMESI_GEREKENLER, Me.colUC_GUN_SONRA_YUKLENMESI_GEREKENLER, Me.colDORT_GUN_SONRA_YUKLENMESI_GEREKENLER, Me.colBES_GUN_SONRA_YUKLENMESI_GEREKENLER})
        Me.GridView1.GridControl = Me.GridControl1
        Me.GridView1.Name = "GridView1"
        '
        'colBUGUN_YUKLENMESI_GEREKENLER
        '
        Me.colBUGUN_YUKLENMESI_GEREKENLER.FieldName = "BUGUN_YUKLENMESI_GEREKENLER"
        Me.colBUGUN_YUKLENMESI_GEREKENLER.Name = "colBUGUN_YUKLENMESI_GEREKENLER"
        Me.colBUGUN_YUKLENMESI_GEREKENLER.Visible = True
        Me.colBUGUN_YUKLENMESI_GEREKENLER.VisibleIndex = 0
        '
        'colYARIN_YUKLENMESI_GEREKENLER
        '
        Me.colYARIN_YUKLENMESI_GEREKENLER.FieldName = "YARIN_YUKLENMESI_GEREKENLER"
        Me.colYARIN_YUKLENMESI_GEREKENLER.Name = "colYARIN_YUKLENMESI_GEREKENLER"
        Me.colYARIN_YUKLENMESI_GEREKENLER.Visible = True
        Me.colYARIN_YUKLENMESI_GEREKENLER.VisibleIndex = 1
        '
        'colIKI_GUN_SONRA_YUKLENMESI_GEREKENLER
        '
        Me.colIKI_GUN_SONRA_YUKLENMESI_GEREKENLER.FieldName = "IKI_GUN_SONRA_YUKLENMESI_GEREKENLER"
        Me.colIKI_GUN_SONRA_YUKLENMESI_GEREKENLER.Name = "colIKI_GUN_SONRA_YUKLENMESI_GEREKENLER"
        Me.colIKI_GUN_SONRA_YUKLENMESI_GEREKENLER.Visible = True
        Me.colIKI_GUN_SONRA_YUKLENMESI_GEREKENLER.VisibleIndex = 2
        '
        'colUC_GUN_SONRA_YUKLENMESI_GEREKENLER
        '
        Me.colUC_GUN_SONRA_YUKLENMESI_GEREKENLER.FieldName = "UC_GUN_SONRA_YUKLENMESI_GEREKENLER"
        Me.colUC_GUN_SONRA_YUKLENMESI_GEREKENLER.Name = "colUC_GUN_SONRA_YUKLENMESI_GEREKENLER"
        Me.colUC_GUN_SONRA_YUKLENMESI_GEREKENLER.Visible = True
        Me.colUC_GUN_SONRA_YUKLENMESI_GEREKENLER.VisibleIndex = 3
        '
        'colDORT_GUN_SONRA_YUKLENMESI_GEREKENLER
        '
        Me.colDORT_GUN_SONRA_YUKLENMESI_GEREKENLER.FieldName = "DORT_GUN_SONRA_YUKLENMESI_GEREKENLER"
        Me.colDORT_GUN_SONRA_YUKLENMESI_GEREKENLER.Name = "colDORT_GUN_SONRA_YUKLENMESI_GEREKENLER"
        Me.colDORT_GUN_SONRA_YUKLENMESI_GEREKENLER.Visible = True
        Me.colDORT_GUN_SONRA_YUKLENMESI_GEREKENLER.VisibleIndex = 4
        '
        'colBES_GUN_SONRA_YUKLENMESI_GEREKENLER
        '
        Me.colBES_GUN_SONRA_YUKLENMESI_GEREKENLER.FieldName = "BES_GUN_SONRA_YUKLENMESI_GEREKENLER"
        Me.colBES_GUN_SONRA_YUKLENMESI_GEREKENLER.Name = "colBES_GUN_SONRA_YUKLENMESI_GEREKENLER"
        Me.colBES_GUN_SONRA_YUKLENMESI_GEREKENLER.Visible = True
        Me.colBES_GUN_SONRA_YUKLENMESI_GEREKENLER.VisibleIndex = 5
        '
        'EO_ALANSIS_SEVKIYATYUKLEMEDURUMTableAdapter1
        '
        Me.EO_ALANSIS_SEVKIYATYUKLEMEDURUMTableAdapter1.ClearBeforeFill = True
        '
        'Form122
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1001, 453)
        Me.Controls.Add(Me.GridControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "Form122"
        Me.Text = "ALANSIS - LOJISTIK YUKLEME DURUMLARI "
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AlansısDataSet71, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents FormAssistant1 As DevExpress.XtraBars.FormAssistant
    Friend WithEvents DefaultLookAndFeel1 As DevExpress.LookAndFeel.DefaultLookAndFeel
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents AlansısDataSet71 As ALANSISDataSet7
    Friend WithEvents colBUGUN_YUKLENMESI_GEREKENLER As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colYARIN_YUKLENMESI_GEREKENLER As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colIKI_GUN_SONRA_YUKLENMESI_GEREKENLER As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colUC_GUN_SONRA_YUKLENMESI_GEREKENLER As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDORT_GUN_SONRA_YUKLENMESI_GEREKENLER As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colBES_GUN_SONRA_YUKLENMESI_GEREKENLER As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents EO_ALANSIS_SEVKIYATYUKLEMEDURUMTableAdapter1 As ALANSISDataSet7TableAdapters.EO_ALANSIS_SEVKIYATYUKLEMEDURUMTableAdapter
End Class
