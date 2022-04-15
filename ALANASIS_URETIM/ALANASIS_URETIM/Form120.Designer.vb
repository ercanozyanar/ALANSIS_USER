<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form120
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
        Me.AlansısDataSet51 = New WindowsApplication1.ALANSISDataSet5()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colCUSTOMER = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPOS_NO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colREFERANCE = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPRODUCT = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDELIVERY_COUNTRY = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCARRIER = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTRUCK_PLAKA = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colLOAD_DATE = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colETA = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCUSTOMS = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDELIVERY_ADRESS = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCURRENT_LOCATION = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.EO_ALANSIS_SEVKIYATTableAdapter1 = New WindowsApplication1.ALANSISDataSet5TableAdapters.EO_ALANSIS_SEVKIYATTableAdapter()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AlansısDataSet51, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DefaultLookAndFeel1
        '
        Me.DefaultLookAndFeel1.LookAndFeel.SkinName = "Office 2007 Blue"
        '
        'GridControl1
        '
        Me.GridControl1.DataMember = "EO_ALANSIS_SEVKIYAT"
        Me.GridControl1.DataSource = Me.AlansısDataSet51
        Me.GridControl1.Location = New System.Drawing.Point(-2, 2)
        Me.GridControl1.MainView = Me.GridView1
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.Size = New System.Drawing.Size(1273, 577)
        Me.GridControl1.TabIndex = 0
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'AlansısDataSet51
        '
        Me.AlansısDataSet51.DataSetName = "ALANSISDataSet5"
        Me.AlansısDataSet51.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colCUSTOMER, Me.colPOS_NO, Me.colREFERANCE, Me.colPRODUCT, Me.colDELIVERY_COUNTRY, Me.colCARRIER, Me.colTRUCK_PLAKA, Me.colLOAD_DATE, Me.colETA, Me.colCUSTOMS, Me.colDELIVERY_ADRESS, Me.colCURRENT_LOCATION})
        Me.GridView1.GridControl = Me.GridControl1
        Me.GridView1.Name = "GridView1"
        '
        'colCUSTOMER
        '
        Me.colCUSTOMER.FieldName = "CUSTOMER"
        Me.colCUSTOMER.Name = "colCUSTOMER"
        Me.colCUSTOMER.Visible = True
        Me.colCUSTOMER.VisibleIndex = 0
        '
        'colPOS_NO
        '
        Me.colPOS_NO.FieldName = "POS_NO"
        Me.colPOS_NO.Name = "colPOS_NO"
        Me.colPOS_NO.Visible = True
        Me.colPOS_NO.VisibleIndex = 1
        '
        'colREFERANCE
        '
        Me.colREFERANCE.FieldName = "REFERANCE"
        Me.colREFERANCE.Name = "colREFERANCE"
        Me.colREFERANCE.Visible = True
        Me.colREFERANCE.VisibleIndex = 2
        '
        'colPRODUCT
        '
        Me.colPRODUCT.FieldName = "PRODUCT"
        Me.colPRODUCT.Name = "colPRODUCT"
        Me.colPRODUCT.Visible = True
        Me.colPRODUCT.VisibleIndex = 3
        '
        'colDELIVERY_COUNTRY
        '
        Me.colDELIVERY_COUNTRY.FieldName = "DELIVERY_COUNTRY"
        Me.colDELIVERY_COUNTRY.Name = "colDELIVERY_COUNTRY"
        Me.colDELIVERY_COUNTRY.Visible = True
        Me.colDELIVERY_COUNTRY.VisibleIndex = 4
        '
        'colCARRIER
        '
        Me.colCARRIER.FieldName = "CARRIER"
        Me.colCARRIER.Name = "colCARRIER"
        Me.colCARRIER.Visible = True
        Me.colCARRIER.VisibleIndex = 5
        '
        'colTRUCK_PLAKA
        '
        Me.colTRUCK_PLAKA.FieldName = "TRUCK_PLAKA"
        Me.colTRUCK_PLAKA.Name = "colTRUCK_PLAKA"
        Me.colTRUCK_PLAKA.Visible = True
        Me.colTRUCK_PLAKA.VisibleIndex = 6
        '
        'colLOAD_DATE
        '
        Me.colLOAD_DATE.FieldName = "LOAD_DATE"
        Me.colLOAD_DATE.Name = "colLOAD_DATE"
        Me.colLOAD_DATE.Visible = True
        Me.colLOAD_DATE.VisibleIndex = 7
        '
        'colETA
        '
        Me.colETA.FieldName = "ETA"
        Me.colETA.Name = "colETA"
        Me.colETA.Visible = True
        Me.colETA.VisibleIndex = 8
        '
        'colCUSTOMS
        '
        Me.colCUSTOMS.FieldName = "CUSTOMS"
        Me.colCUSTOMS.Name = "colCUSTOMS"
        Me.colCUSTOMS.Visible = True
        Me.colCUSTOMS.VisibleIndex = 9
        '
        'colDELIVERY_ADRESS
        '
        Me.colDELIVERY_ADRESS.FieldName = "DELIVERY_ADRESS"
        Me.colDELIVERY_ADRESS.Name = "colDELIVERY_ADRESS"
        Me.colDELIVERY_ADRESS.Visible = True
        Me.colDELIVERY_ADRESS.VisibleIndex = 10
        '
        'colCURRENT_LOCATION
        '
        Me.colCURRENT_LOCATION.FieldName = "CURRENT_LOCATION"
        Me.colCURRENT_LOCATION.Name = "colCURRENT_LOCATION"
        Me.colCURRENT_LOCATION.Visible = True
        Me.colCURRENT_LOCATION.VisibleIndex = 11
        '
        'EO_ALANSIS_SEVKIYATTableAdapter1
        '
        Me.EO_ALANSIS_SEVKIYATTableAdapter1.ClearBeforeFill = True
        '
        'Form120
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1269, 581)
        Me.Controls.Add(Me.GridControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "Form120"
        Me.Text = "ALANSIS -LOJISTIK  ÖZET LİSTE"
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AlansısDataSet51, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents FormAssistant1 As DevExpress.XtraBars.FormAssistant
    Friend WithEvents DefaultLookAndFeel1 As DevExpress.LookAndFeel.DefaultLookAndFeel
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents AlansısDataSet51 As ALANSISDataSet5
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colCUSTOMER As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPOS_NO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colREFERANCE As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPRODUCT As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDELIVERY_COUNTRY As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCARRIER As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTRUCK_PLAKA As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colLOAD_DATE As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colETA As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCUSTOMS As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDELIVERY_ADRESS As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCURRENT_LOCATION As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents EO_ALANSIS_SEVKIYATTableAdapter1 As ALANSISDataSet5TableAdapters.EO_ALANSIS_SEVKIYATTableAdapter
End Class
