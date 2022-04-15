<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form150
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
        Me.AlansısDataSet161 = New WindowsApplication1.ALANSISDataSet16()
        Me.EO_ALANSIS_GGNPARTITableAdapter1 = New WindowsApplication1.ALANSISDataSet16TableAdapters.EO_ALANSIS_GGNPARTITableAdapter()
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl()
        Me.AlansısDataSet162 = New WindowsApplication1.ALANSISDataSet16()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colTARIH = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPARTINO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colGGN = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colGGN_MIKTAR = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPARTI_MIKTAR = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.EO_ALANSIS_GGNPARTITableAdapter2 = New WindowsApplication1.ALANSISDataSet16TableAdapters.EO_ALANSIS_GGNPARTITableAdapter()
        CType(Me.AlansısDataSet161, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AlansısDataSet162, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DefaultLookAndFeel1
        '
        Me.DefaultLookAndFeel1.LookAndFeel.SkinName = "Office 2007 Blue"
        '
        'AlansısDataSet161
        '
        Me.AlansısDataSet161.DataSetName = "ALANSISDataSet16"
        Me.AlansısDataSet161.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'EO_ALANSIS_GGNPARTITableAdapter1
        '
        Me.EO_ALANSIS_GGNPARTITableAdapter1.ClearBeforeFill = True
        '
        'GridControl1
        '
        Me.GridControl1.DataMember = "EO_ALANSIS_GGNPARTI"
        Me.GridControl1.DataSource = Me.AlansısDataSet162
        Me.GridControl1.Location = New System.Drawing.Point(0, 1)
        Me.GridControl1.MainView = Me.GridView1
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.Size = New System.Drawing.Size(798, 449)
        Me.GridControl1.TabIndex = 0
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'AlansısDataSet162
        '
        Me.AlansısDataSet162.DataSetName = "ALANSISDataSet16"
        Me.AlansısDataSet162.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colTARIH, Me.colPARTINO, Me.colGGN, Me.colGGN_MIKTAR, Me.colPARTI_MIKTAR})
        Me.GridView1.GridControl = Me.GridControl1
        Me.GridView1.Name = "GridView1"
        '
        'colTARIH
        '
        Me.colTARIH.FieldName = "TARIH"
        Me.colTARIH.Name = "colTARIH"
        Me.colTARIH.Visible = True
        Me.colTARIH.VisibleIndex = 0
        '
        'colPARTINO
        '
        Me.colPARTINO.FieldName = "PARTINO"
        Me.colPARTINO.Name = "colPARTINO"
        Me.colPARTINO.Visible = True
        Me.colPARTINO.VisibleIndex = 1
        '
        'colGGN
        '
        Me.colGGN.FieldName = "GGN"
        Me.colGGN.Name = "colGGN"
        Me.colGGN.Visible = True
        Me.colGGN.VisibleIndex = 2
        '
        'colGGN_MIKTAR
        '
        Me.colGGN_MIKTAR.FieldName = "GGN_MIKTAR"
        Me.colGGN_MIKTAR.Name = "colGGN_MIKTAR"
        Me.colGGN_MIKTAR.Visible = True
        Me.colGGN_MIKTAR.VisibleIndex = 3
        '
        'colPARTI_MIKTAR
        '
        Me.colPARTI_MIKTAR.FieldName = "PARTI_MIKTAR"
        Me.colPARTI_MIKTAR.Name = "colPARTI_MIKTAR"
        Me.colPARTI_MIKTAR.Visible = True
        Me.colPARTI_MIKTAR.VisibleIndex = 4
        '
        'EO_ALANSIS_GGNPARTITableAdapter2
        '
        Me.EO_ALANSIS_GGNPARTITableAdapter2.ClearBeforeFill = True
        '
        'Form150
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.GridControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "Form150"
        Me.Text = "ALANSIS GGN PARTI IZLEME MODULU"
        CType(Me.AlansısDataSet161, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AlansısDataSet162, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents FormAssistant1 As DevExpress.XtraBars.FormAssistant
    Friend WithEvents DefaultLookAndFeel1 As DevExpress.LookAndFeel.DefaultLookAndFeel
    Friend WithEvents AlansısDataSet161 As ALANSISDataSet16
    Friend WithEvents EO_ALANSIS_GGNPARTITableAdapter1 As ALANSISDataSet16TableAdapters.EO_ALANSIS_GGNPARTITableAdapter
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents AlansısDataSet162 As ALANSISDataSet16
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colTARIH As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPARTINO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colGGN As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colGGN_MIKTAR As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPARTI_MIKTAR As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents EO_ALANSIS_GGNPARTITableAdapter2 As ALANSISDataSet16TableAdapters.EO_ALANSIS_GGNPARTITableAdapter
End Class
