<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form170
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form170))
        Me.FormAssistant1 = New DevExpress.XtraBars.FormAssistant()
        Me.DefaultLookAndFeel1 = New DevExpress.LookAndFeel.DefaultLookAndFeel(Me.components)
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl()
        Me.EOALANSISSARFRAPOR1BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ALANSISDataSet25 = New WindowsApplication1.ALANSISDataSet25()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colPARTI = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSTOK_ADI = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTOPLAM_SARF = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colEBAT = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colKIRAZ_ISLEM = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colNETKG = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colBRUTKG = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPALET_SAYISI = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton()
        Me.EO_ALANSIS_SARF_RAPOR1TableAdapter = New WindowsApplication1.ALANSISDataSet25TableAdapters.EO_ALANSIS_SARF_RAPOR1TableAdapter()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EOALANSISSARFRAPOR1BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ALANSISDataSet25, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DefaultLookAndFeel1
        '
        Me.DefaultLookAndFeel1.LookAndFeel.SkinName = "Office 2007 Blue"
        '
        'GridControl1
        '
        Me.GridControl1.DataSource = Me.EOALANSISSARFRAPOR1BindingSource
        Me.GridControl1.Location = New System.Drawing.Point(0, 3)
        Me.GridControl1.MainView = Me.GridView1
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.Size = New System.Drawing.Size(893, 408)
        Me.GridControl1.TabIndex = 0
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'EOALANSISSARFRAPOR1BindingSource
        '
        Me.EOALANSISSARFRAPOR1BindingSource.DataMember = "EO_ALANSIS_SARF_RAPOR1"
        Me.EOALANSISSARFRAPOR1BindingSource.DataSource = Me.ALANSISDataSet25
        '
        'ALANSISDataSet25
        '
        Me.ALANSISDataSet25.DataSetName = "ALANSISDataSet25"
        Me.ALANSISDataSet25.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colPARTI, Me.colSTOK_ADI, Me.colTOPLAM_SARF, Me.colEBAT, Me.colKIRAZ_ISLEM, Me.colNETKG, Me.colBRUTKG, Me.colPALET_SAYISI})
        Me.GridView1.GridControl = Me.GridControl1
        Me.GridView1.Name = "GridView1"
        '
        'colPARTI
        '
        Me.colPARTI.FieldName = "PARTI"
        Me.colPARTI.Name = "colPARTI"
        Me.colPARTI.Visible = True
        Me.colPARTI.VisibleIndex = 0
        '
        'colSTOK_ADI
        '
        Me.colSTOK_ADI.FieldName = "STOK_ADI"
        Me.colSTOK_ADI.Name = "colSTOK_ADI"
        Me.colSTOK_ADI.Visible = True
        Me.colSTOK_ADI.VisibleIndex = 1
        '
        'colTOPLAM_SARF
        '
        Me.colTOPLAM_SARF.FieldName = "TOPLAM_SARF"
        Me.colTOPLAM_SARF.Name = "colTOPLAM_SARF"
        Me.colTOPLAM_SARF.Visible = True
        Me.colTOPLAM_SARF.VisibleIndex = 2
        '
        'colEBAT
        '
        Me.colEBAT.FieldName = "EBAT"
        Me.colEBAT.Name = "colEBAT"
        Me.colEBAT.Visible = True
        Me.colEBAT.VisibleIndex = 3
        '
        'colKIRAZ_ISLEM
        '
        Me.colKIRAZ_ISLEM.FieldName = "KIRAZ_ISLEM"
        Me.colKIRAZ_ISLEM.Name = "colKIRAZ_ISLEM"
        Me.colKIRAZ_ISLEM.Visible = True
        Me.colKIRAZ_ISLEM.VisibleIndex = 4
        '
        'colNETKG
        '
        Me.colNETKG.FieldName = "NETKG"
        Me.colNETKG.Name = "colNETKG"
        Me.colNETKG.Visible = True
        Me.colNETKG.VisibleIndex = 5
        '
        'colBRUTKG
        '
        Me.colBRUTKG.FieldName = "BRUTKG"
        Me.colBRUTKG.Name = "colBRUTKG"
        Me.colBRUTKG.Visible = True
        Me.colBRUTKG.VisibleIndex = 6
        '
        'colPALET_SAYISI
        '
        Me.colPALET_SAYISI.FieldName = "PALET_SAYISI"
        Me.colPALET_SAYISI.Name = "colPALET_SAYISI"
        Me.colPALET_SAYISI.Visible = True
        Me.colPALET_SAYISI.VisibleIndex = 7
        '
        'SimpleButton1
        '
        Me.SimpleButton1.ImageOptions.Image = CType(resources.GetObject("SimpleButton1.ImageOptions.Image"), System.Drawing.Image)
        Me.SimpleButton1.Location = New System.Drawing.Point(0, 417)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(35, 33)
        Me.SimpleButton1.TabIndex = 3
        '
        'EO_ALANSIS_SARF_RAPOR1TableAdapter
        '
        Me.EO_ALANSIS_SARF_RAPOR1TableAdapter.ClearBeforeFill = True
        '
        'Form170
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(897, 450)
        Me.Controls.Add(Me.SimpleButton1)
        Me.Controls.Add(Me.GridControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "Form170"
        Me.Text = "ALANSIS SARF RAPORU"
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EOALANSISSARFRAPOR1BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ALANSISDataSet25, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents FormAssistant1 As DevExpress.XtraBars.FormAssistant
    Friend WithEvents DefaultLookAndFeel1 As DevExpress.LookAndFeel.DefaultLookAndFeel
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents ALANSISDataSet25 As ALANSISDataSet25
    Friend WithEvents EOALANSISSARFRAPOR1BindingSource As BindingSource
    Friend WithEvents EO_ALANSIS_SARF_RAPOR1TableAdapter As ALANSISDataSet25TableAdapters.EO_ALANSIS_SARF_RAPOR1TableAdapter
    Friend WithEvents colPARTI As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSTOK_ADI As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTOPLAM_SARF As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colEBAT As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colKIRAZ_ISLEM As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNETKG As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colBRUTKG As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPALET_SAYISI As DevExpress.XtraGrid.Columns.GridColumn
End Class
