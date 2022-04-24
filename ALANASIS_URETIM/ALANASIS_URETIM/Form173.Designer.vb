<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form173
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form173))
        Me.FormAssistant1 = New DevExpress.XtraBars.FormAssistant()
        Me.DefaultLookAndFeel1 = New DevExpress.LookAndFeel.DefaultLookAndFeel(Me.components)
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl()
        Me.EOALANSISMAMULRAPORBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ALANSISDataSet28 = New WindowsApplication1.ALANSISDataSet28()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colTARIH = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSTOK_KODU = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSERI = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colNETKG = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colBOLGE = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colEBAT = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colISLEM = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colKIRAZ_ISLEM = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colKALINTI = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDARA = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colBRUTKG = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTIP = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPARTINO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colURETIM_TIPI = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCESIT = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colACIKLAMA = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colRENK = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton()
        Me.EO_ALANSIS_MAMULRAPORTableAdapter = New WindowsApplication1.ALANSISDataSet28TableAdapters.EO_ALANSIS_MAMULRAPORTableAdapter()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EOALANSISMAMULRAPORBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ALANSISDataSet28, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DefaultLookAndFeel1
        '
        Me.DefaultLookAndFeel1.LookAndFeel.SkinName = "Office 2007 Blue"
        '
        'GridControl1
        '
        Me.GridControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GridControl1.DataSource = Me.EOALANSISMAMULRAPORBindingSource
        Me.GridControl1.EmbeddedNavigator.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GridControl1.Location = New System.Drawing.Point(1, 50)
        Me.GridControl1.MainView = Me.GridView1
        Me.GridControl1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.Size = New System.Drawing.Size(1384, 570)
        Me.GridControl1.TabIndex = 1
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'EOALANSISMAMULRAPORBindingSource
        '
        Me.EOALANSISMAMULRAPORBindingSource.DataMember = "EO_ALANSIS_MAMULRAPOR"
        Me.EOALANSISMAMULRAPORBindingSource.DataSource = Me.ALANSISDataSet28
        '
        'ALANSISDataSet28
        '
        Me.ALANSISDataSet28.DataSetName = "ALANSISDataSet28"
        Me.ALANSISDataSet28.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colTARIH, Me.colSTOK_KODU, Me.colSERI, Me.colNETKG, Me.colBOLGE, Me.colEBAT, Me.colISLEM, Me.colKIRAZ_ISLEM, Me.colKALINTI, Me.colDARA, Me.colBRUTKG, Me.colTIP, Me.colPARTINO, Me.colURETIM_TIPI, Me.colCESIT, Me.colACIKLAMA, Me.colRENK})
        Me.GridView1.DetailHeight = 431
        Me.GridView1.GridControl = Me.GridControl1
        Me.GridView1.Name = "GridView1"
        '
        'colTARIH
        '
        Me.colTARIH.FieldName = "TARIH"
        Me.colTARIH.MinWidth = 23
        Me.colTARIH.Name = "colTARIH"
        Me.colTARIH.Visible = True
        Me.colTARIH.VisibleIndex = 0
        Me.colTARIH.Width = 87
        '
        'colSTOK_KODU
        '
        Me.colSTOK_KODU.FieldName = "STOK_KODU"
        Me.colSTOK_KODU.MinWidth = 23
        Me.colSTOK_KODU.Name = "colSTOK_KODU"
        Me.colSTOK_KODU.Visible = True
        Me.colSTOK_KODU.VisibleIndex = 1
        Me.colSTOK_KODU.Width = 87
        '
        'colSERI
        '
        Me.colSERI.FieldName = "SERI"
        Me.colSERI.MinWidth = 23
        Me.colSERI.Name = "colSERI"
        Me.colSERI.Visible = True
        Me.colSERI.VisibleIndex = 2
        Me.colSERI.Width = 87
        '
        'colNETKG
        '
        Me.colNETKG.FieldName = "NETKG"
        Me.colNETKG.MinWidth = 23
        Me.colNETKG.Name = "colNETKG"
        Me.colNETKG.Visible = True
        Me.colNETKG.VisibleIndex = 3
        Me.colNETKG.Width = 87
        '
        'colBOLGE
        '
        Me.colBOLGE.FieldName = "BOLGE"
        Me.colBOLGE.MinWidth = 23
        Me.colBOLGE.Name = "colBOLGE"
        Me.colBOLGE.Visible = True
        Me.colBOLGE.VisibleIndex = 4
        Me.colBOLGE.Width = 87
        '
        'colEBAT
        '
        Me.colEBAT.FieldName = "EBAT"
        Me.colEBAT.MinWidth = 23
        Me.colEBAT.Name = "colEBAT"
        Me.colEBAT.Visible = True
        Me.colEBAT.VisibleIndex = 5
        Me.colEBAT.Width = 87
        '
        'colISLEM
        '
        Me.colISLEM.FieldName = "ISLEM"
        Me.colISLEM.MinWidth = 23
        Me.colISLEM.Name = "colISLEM"
        Me.colISLEM.Visible = True
        Me.colISLEM.VisibleIndex = 6
        Me.colISLEM.Width = 87
        '
        'colKIRAZ_ISLEM
        '
        Me.colKIRAZ_ISLEM.FieldName = "KIRAZ_ISLEM"
        Me.colKIRAZ_ISLEM.MinWidth = 23
        Me.colKIRAZ_ISLEM.Name = "colKIRAZ_ISLEM"
        Me.colKIRAZ_ISLEM.Visible = True
        Me.colKIRAZ_ISLEM.VisibleIndex = 7
        Me.colKIRAZ_ISLEM.Width = 87
        '
        'colKALINTI
        '
        Me.colKALINTI.FieldName = "KALINTI"
        Me.colKALINTI.MinWidth = 23
        Me.colKALINTI.Name = "colKALINTI"
        Me.colKALINTI.Visible = True
        Me.colKALINTI.VisibleIndex = 8
        Me.colKALINTI.Width = 87
        '
        'colDARA
        '
        Me.colDARA.FieldName = "DARA"
        Me.colDARA.MinWidth = 23
        Me.colDARA.Name = "colDARA"
        Me.colDARA.Visible = True
        Me.colDARA.VisibleIndex = 9
        Me.colDARA.Width = 87
        '
        'colBRUTKG
        '
        Me.colBRUTKG.FieldName = "BRUTKG"
        Me.colBRUTKG.MinWidth = 23
        Me.colBRUTKG.Name = "colBRUTKG"
        Me.colBRUTKG.Visible = True
        Me.colBRUTKG.VisibleIndex = 10
        Me.colBRUTKG.Width = 87
        '
        'colTIP
        '
        Me.colTIP.FieldName = "TIP"
        Me.colTIP.MinWidth = 23
        Me.colTIP.Name = "colTIP"
        Me.colTIP.Visible = True
        Me.colTIP.VisibleIndex = 11
        Me.colTIP.Width = 87
        '
        'colPARTINO
        '
        Me.colPARTINO.FieldName = "PARTINO"
        Me.colPARTINO.MinWidth = 23
        Me.colPARTINO.Name = "colPARTINO"
        Me.colPARTINO.Visible = True
        Me.colPARTINO.VisibleIndex = 12
        Me.colPARTINO.Width = 87
        '
        'colURETIM_TIPI
        '
        Me.colURETIM_TIPI.FieldName = "URETIM_TIPI"
        Me.colURETIM_TIPI.MinWidth = 23
        Me.colURETIM_TIPI.Name = "colURETIM_TIPI"
        Me.colURETIM_TIPI.Visible = True
        Me.colURETIM_TIPI.VisibleIndex = 13
        Me.colURETIM_TIPI.Width = 87
        '
        'colCESIT
        '
        Me.colCESIT.FieldName = "CESIT"
        Me.colCESIT.MinWidth = 23
        Me.colCESIT.Name = "colCESIT"
        Me.colCESIT.Visible = True
        Me.colCESIT.VisibleIndex = 14
        Me.colCESIT.Width = 87
        '
        'colACIKLAMA
        '
        Me.colACIKLAMA.FieldName = "ACIKLAMA"
        Me.colACIKLAMA.MinWidth = 23
        Me.colACIKLAMA.Name = "colACIKLAMA"
        Me.colACIKLAMA.Visible = True
        Me.colACIKLAMA.VisibleIndex = 15
        Me.colACIKLAMA.Width = 87
        '
        'colRENK
        '
        Me.colRENK.FieldName = "RENK"
        Me.colRENK.MinWidth = 23
        Me.colRENK.Name = "colRENK"
        Me.colRENK.Visible = True
        Me.colRENK.VisibleIndex = 16
        Me.colRENK.Width = 87
        '
        'SimpleButton1
        '
        Me.SimpleButton1.ImageOptions.Image = CType(resources.GetObject("SimpleButton1.ImageOptions.Image"), System.Drawing.Image)
        Me.SimpleButton1.Location = New System.Drawing.Point(1, 2)
        Me.SimpleButton1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(41, 41)
        Me.SimpleButton1.TabIndex = 5
        '
        'EO_ALANSIS_MAMULRAPORTableAdapter
        '
        Me.EO_ALANSIS_MAMULRAPORTableAdapter.ClearBeforeFill = True
        '
        'Form173
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1388, 626)
        Me.Controls.Add(Me.SimpleButton1)
        Me.Controls.Add(Me.GridControl1)
        Me.IconOptions.Image = Global.WindowsApplication1.My.Resources.Resources.LOGIN11
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "Form173"
        Me.Text = "Alansis Kiraz Mamul Çıkış İzleme"
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EOALANSISMAMULRAPORBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ALANSISDataSet28, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ALANSISDataSet28 As ALANSISDataSet28
    Friend WithEvents EOALANSISMAMULRAPORBindingSource As BindingSource
    Friend WithEvents EO_ALANSIS_MAMULRAPORTableAdapter As ALANSISDataSet28TableAdapters.EO_ALANSIS_MAMULRAPORTableAdapter
    Private WithEvents FormAssistant1 As DevExpress.XtraBars.FormAssistant
    Private WithEvents DefaultLookAndFeel1 As DevExpress.LookAndFeel.DefaultLookAndFeel
    Private WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Private WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Private WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
    Private WithEvents colTARIH As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents colSTOK_KODU As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents colSERI As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents colNETKG As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents colBOLGE As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents colEBAT As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents colISLEM As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents colKIRAZ_ISLEM As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents colKALINTI As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents colDARA As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents colBRUTKG As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents colTIP As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents colPARTINO As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents colURETIM_TIPI As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents colCESIT As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents colACIKLAMA As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents colRENK As DevExpress.XtraGrid.Columns.GridColumn
End Class
