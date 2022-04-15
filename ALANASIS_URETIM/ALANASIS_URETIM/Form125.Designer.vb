<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form125
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
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.AlansısDataSet101 = New WindowsApplication1.ALANSISDataSet10()
        Me.EO_ALANSIS_SEVKIYAT_NAKLIYETableAdapter1 = New WindowsApplication1.ALANSISDataSet10TableAdapters.EO_ALANSIS_SEVKIYAT_NAKLIYETableAdapter()
        Me.colMUSTERI = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPOS_NO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colURUN = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colULKE = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colNAKLIYE = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colNAVLUN = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colEXTRA_NAVLUN = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colLOAD_DATE = New DevExpress.XtraGrid.Columns.GridColumn()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AlansısDataSet101, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DefaultLookAndFeel1
        '
        Me.DefaultLookAndFeel1.LookAndFeel.SkinName = "Office 2007 Blue"
        '
        'GridControl1
        '
        Me.GridControl1.DataMember = "EO_ALANSIS_SEVKIYAT_NAKLIYE"
        Me.GridControl1.DataSource = Me.AlansısDataSet101
        Me.GridControl1.Location = New System.Drawing.Point(1, 3)
        Me.GridControl1.MainView = Me.GridView1
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.Size = New System.Drawing.Size(1035, 571)
        Me.GridControl1.TabIndex = 0
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colMUSTERI, Me.colPOS_NO, Me.colURUN, Me.colULKE, Me.colNAKLIYE, Me.colNAVLUN, Me.colEXTRA_NAVLUN, Me.colLOAD_DATE})
        Me.GridView1.GridControl = Me.GridControl1
        Me.GridView1.Name = "GridView1"
        '
        'AlansısDataSet101
        '
        Me.AlansısDataSet101.DataSetName = "ALANSISDataSet10"
        Me.AlansısDataSet101.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'EO_ALANSIS_SEVKIYAT_NAKLIYETableAdapter1
        '
        Me.EO_ALANSIS_SEVKIYAT_NAKLIYETableAdapter1.ClearBeforeFill = True
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
        'colURUN
        '
        Me.colURUN.FieldName = "URUN"
        Me.colURUN.Name = "colURUN"
        Me.colURUN.Visible = True
        Me.colURUN.VisibleIndex = 2
        '
        'colULKE
        '
        Me.colULKE.FieldName = "ULKE"
        Me.colULKE.Name = "colULKE"
        Me.colULKE.Visible = True
        Me.colULKE.VisibleIndex = 3
        '
        'colNAKLIYE
        '
        Me.colNAKLIYE.FieldName = "NAKLIYE"
        Me.colNAKLIYE.Name = "colNAKLIYE"
        Me.colNAKLIYE.Visible = True
        Me.colNAKLIYE.VisibleIndex = 4
        '
        'colNAVLUN
        '
        Me.colNAVLUN.FieldName = "NAVLUN"
        Me.colNAVLUN.Name = "colNAVLUN"
        Me.colNAVLUN.Visible = True
        Me.colNAVLUN.VisibleIndex = 5
        '
        'colEXTRA_NAVLUN
        '
        Me.colEXTRA_NAVLUN.FieldName = "EXTRA_NAVLUN"
        Me.colEXTRA_NAVLUN.Name = "colEXTRA_NAVLUN"
        Me.colEXTRA_NAVLUN.Visible = True
        Me.colEXTRA_NAVLUN.VisibleIndex = 6
        '
        'colLOAD_DATE
        '
        Me.colLOAD_DATE.FieldName = "LOAD_DATE"
        Me.colLOAD_DATE.Name = "colLOAD_DATE"
        Me.colLOAD_DATE.Visible = True
        Me.colLOAD_DATE.VisibleIndex = 7
        '
        'Form125
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1039, 577)
        Me.Controls.Add(Me.GridControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "Form125"
        Me.Text = "ALANSIS - NAKLIYE DURUM"
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AlansısDataSet101, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents FormAssistant1 As DevExpress.XtraBars.FormAssistant
    Friend WithEvents DefaultLookAndFeel1 As DevExpress.LookAndFeel.DefaultLookAndFeel
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents AlansısDataSet101 As ALANSISDataSet10
    Friend WithEvents colMUSTERI As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPOS_NO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colURUN As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colULKE As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNAKLIYE As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNAVLUN As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colEXTRA_NAVLUN As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colLOAD_DATE As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents EO_ALANSIS_SEVKIYAT_NAKLIYETableAdapter1 As ALANSISDataSet10TableAdapters.EO_ALANSIS_SEVKIYAT_NAKLIYETableAdapter
End Class
