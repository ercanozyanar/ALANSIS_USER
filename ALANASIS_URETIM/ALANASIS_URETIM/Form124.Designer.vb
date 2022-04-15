<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form124
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
        Me.AlansısDataSet91 = New WindowsApplication1.ALANSISDataSet9()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colMUSTERI = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPOS_NO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colURUN = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colULKE = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colYUKLEME = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colVARIS = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTRANSIT_SURE = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDURUM = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.EO_ALANSIS_SEVKIYAT_TRANSITSURETableAdapter1 = New WindowsApplication1.ALANSISDataSet9TableAdapters.EO_ALANSIS_SEVKIYAT_TRANSITSURETableAdapter()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AlansısDataSet91, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DefaultLookAndFeel1
        '
        Me.DefaultLookAndFeel1.LookAndFeel.SkinName = "Office 2007 Blue"
        '
        'GridControl1
        '
        Me.GridControl1.DataMember = "EO_ALANSIS_SEVKIYAT_TRANSITSURE"
        Me.GridControl1.DataSource = Me.AlansısDataSet91
        Me.GridControl1.Location = New System.Drawing.Point(2, 3)
        Me.GridControl1.MainView = Me.GridView1
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.Size = New System.Drawing.Size(1034, 562)
        Me.GridControl1.TabIndex = 0
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'AlansısDataSet91
        '
        Me.AlansısDataSet91.DataSetName = "ALANSISDataSet9"
        Me.AlansısDataSet91.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colMUSTERI, Me.colPOS_NO, Me.colURUN, Me.colULKE, Me.colYUKLEME, Me.colVARIS, Me.colTRANSIT_SURE, Me.colDURUM})
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
        'colYUKLEME
        '
        Me.colYUKLEME.FieldName = "YUKLEME"
        Me.colYUKLEME.Name = "colYUKLEME"
        Me.colYUKLEME.Visible = True
        Me.colYUKLEME.VisibleIndex = 4
        '
        'colVARIS
        '
        Me.colVARIS.FieldName = "VARIS"
        Me.colVARIS.Name = "colVARIS"
        Me.colVARIS.Visible = True
        Me.colVARIS.VisibleIndex = 5
        '
        'colTRANSIT_SURE
        '
        Me.colTRANSIT_SURE.FieldName = "TRANSIT_SURE"
        Me.colTRANSIT_SURE.Name = "colTRANSIT_SURE"
        Me.colTRANSIT_SURE.Visible = True
        Me.colTRANSIT_SURE.VisibleIndex = 6
        '
        'colDURUM
        '
        Me.colDURUM.FieldName = "DURUM"
        Me.colDURUM.Name = "colDURUM"
        Me.colDURUM.Visible = True
        Me.colDURUM.VisibleIndex = 7
        '
        'EO_ALANSIS_SEVKIYAT_TRANSITSURETableAdapter1
        '
        Me.EO_ALANSIS_SEVKIYAT_TRANSITSURETableAdapter1.ClearBeforeFill = True
        '
        'Form124
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1039, 569)
        Me.Controls.Add(Me.GridControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "Form124"
        Me.Text = "ALANSIS - TRANSIT SURE"
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AlansısDataSet91, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents FormAssistant1 As DevExpress.XtraBars.FormAssistant
    Friend WithEvents DefaultLookAndFeel1 As DevExpress.LookAndFeel.DefaultLookAndFeel
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents AlansısDataSet91 As ALANSISDataSet9
    Friend WithEvents colMUSTERI As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPOS_NO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colURUN As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colULKE As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colYUKLEME As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colVARIS As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTRANSIT_SURE As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDURUM As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents EO_ALANSIS_SEVKIYAT_TRANSITSURETableAdapter1 As ALANSISDataSet9TableAdapters.EO_ALANSIS_SEVKIYAT_TRANSITSURETableAdapter
End Class
