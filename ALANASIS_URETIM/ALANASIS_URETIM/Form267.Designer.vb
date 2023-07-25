<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form267
    Inherits DevExpress.XtraEditors.XtraForm

    'Form, bileşen listesini temizlemeyi bırakmayı geçersiz kılar.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.FormAssistant1 = New DevExpress.XtraBars.FormAssistant()
        Me.DefaultLookAndFeel1 = New DevExpress.LookAndFeel.DefaultLookAndFeel(Me.components)
        Me.ListBox2 = New System.Windows.Forms.ListBox()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton()
        Me.AlansısDataSet691 = New WindowsApplication1.ALANSISDataSet69()
        Me.ALANSISDataSet69 = New WindowsApplication1.ALANSISDataSet69()
        Me.ALANSISDataSet69BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.EO_ALANSIS_SARFHAR_BAKTableAdapter1 = New WindowsApplication1.ALANSISDataSet69TableAdapters.EO_ALANSIS_SARFHAR_BAKTableAdapter()
        Me.EOALANSISSARFHARBAKBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl()
        Me.AlansısDataSet692 = New WindowsApplication1.ALANSISDataSet69()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colSARF_ADI = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colBAKIYE = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSARF = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.EO_ALANSIS_SARFHAR_BAKTableAdapter2 = New WindowsApplication1.ALANSISDataSet67TableAdapters.EO_ALANSIS_SARFHAR_BAKTableAdapter()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AlansısDataSet691, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ALANSISDataSet69, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ALANSISDataSet69BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EOALANSISSARFHARBAKBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AlansısDataSet692, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DefaultLookAndFeel1
        '
        Me.DefaultLookAndFeel1.LookAndFeel.SkinName = "Office 2007 Blue"
        '
        'ListBox2
        '
        Me.ListBox2.FormattingEnabled = True
        Me.ListBox2.ItemHeight = 16
        Me.ListBox2.Location = New System.Drawing.Point(182, 421)
        Me.ListBox2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.ListBox2.Name = "ListBox2"
        Me.ListBox2.Size = New System.Drawing.Size(94, 164)
        Me.ListBox2.TabIndex = 9
        Me.ListBox2.Visible = False
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.ItemHeight = 16
        Me.ListBox1.Location = New System.Drawing.Point(81, 421)
        Me.ListBox1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(94, 164)
        Me.ListBox1.TabIndex = 8
        Me.ListBox1.Visible = False
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(3, 363)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(1066, 295)
        Me.DataGridView1.TabIndex = 10
        '
        'SimpleButton1
        '
        Me.SimpleButton1.Location = New System.Drawing.Point(3, 5)
        Me.SimpleButton1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(131, 24)
        Me.SimpleButton1.TabIndex = 12
        Me.SimpleButton1.Text = "İşlem"
        '
        'AlansısDataSet691
        '
        Me.AlansısDataSet691.DataSetName = "ALANSISDataSet69"
        Me.AlansısDataSet691.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ALANSISDataSet69
        '
        Me.ALANSISDataSet69.DataSetName = "ALANSISDataSet69"
        Me.ALANSISDataSet69.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ALANSISDataSet69BindingSource
        '
        Me.ALANSISDataSet69BindingSource.DataSource = Me.ALANSISDataSet69
        Me.ALANSISDataSet69BindingSource.Position = 0
        '
        'EO_ALANSIS_SARFHAR_BAKTableAdapter1
        '
        Me.EO_ALANSIS_SARFHAR_BAKTableAdapter1.ClearBeforeFill = True
        '
        'EOALANSISSARFHARBAKBindingSource
        '
        Me.EOALANSISSARFHARBAKBindingSource.DataMember = "EO_ALANSIS_SARFHAR_BAK"
        Me.EOALANSISSARFHARBAKBindingSource.DataSource = Me.ALANSISDataSet69BindingSource
        '
        'GridControl1
        '
        Me.GridControl1.DataMember = "EO_ALANSIS_SARFHAR_BAK"
        Me.GridControl1.DataSource = Me.AlansısDataSet692
        Me.GridControl1.EmbeddedNavigator.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GridControl1.Location = New System.Drawing.Point(3, 37)
        Me.GridControl1.MainView = Me.GridView1
        Me.GridControl1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.Size = New System.Drawing.Size(1066, 318)
        Me.GridControl1.TabIndex = 13
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'AlansısDataSet692
        '
        Me.AlansısDataSet692.DataSetName = "ALANSISDataSet69"
        Me.AlansısDataSet692.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colSARF_ADI, Me.colBAKIYE, Me.colSARF})
        Me.GridView1.DetailHeight = 431
        Me.GridView1.GridControl = Me.GridControl1
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsView.ColumnAutoWidth = False
        '
        'colSARF_ADI
        '
        Me.colSARF_ADI.FieldName = "SARF_ADI"
        Me.colSARF_ADI.MinWidth = 23
        Me.colSARF_ADI.Name = "colSARF_ADI"
        Me.colSARF_ADI.Visible = True
        Me.colSARF_ADI.VisibleIndex = 0
        Me.colSARF_ADI.Width = 710
        '
        'colBAKIYE
        '
        Me.colBAKIYE.FieldName = "BAKIYE"
        Me.colBAKIYE.MinWidth = 23
        Me.colBAKIYE.Name = "colBAKIYE"
        Me.colBAKIYE.Visible = True
        Me.colBAKIYE.VisibleIndex = 1
        Me.colBAKIYE.Width = 194
        '
        'colSARF
        '
        Me.colSARF.FieldName = "SARF"
        Me.colSARF.MinWidth = 23
        Me.colSARF.Name = "colSARF"
        Me.colSARF.Visible = True
        Me.colSARF.VisibleIndex = 2
        Me.colSARF.Width = 139
        '
        'EO_ALANSIS_SARFHAR_BAKTableAdapter2
        '
        Me.EO_ALANSIS_SARFHAR_BAKTableAdapter2.ClearBeforeFill = True
        '
        'Form267
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1071, 662)
        Me.Controls.Add(Me.GridControl1)
        Me.Controls.Add(Me.SimpleButton1)
        Me.Controls.Add(Me.ListBox2)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.DataGridView1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "Form267"
        Me.Text = "ALANSIS -  SARF TUKETIM ISLEM"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AlansısDataSet691, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ALANSISDataSet69, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ALANSISDataSet69BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EOALANSISSARFHARBAKBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AlansısDataSet692, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents FormAssistant1 As DevExpress.XtraBars.FormAssistant
    Friend WithEvents DefaultLookAndFeel1 As DevExpress.LookAndFeel.DefaultLookAndFeel
    Friend WithEvents ListBox2 As ListBox
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents AlansısDataSet691 As ALANSISDataSet69
    Friend WithEvents ALANSISDataSet69 As ALANSISDataSet69
    Friend WithEvents ALANSISDataSet69BindingSource As BindingSource
    Friend WithEvents EO_ALANSIS_SARFHAR_BAKTableAdapter1 As ALANSISDataSet69TableAdapters.EO_ALANSIS_SARFHAR_BAKTableAdapter
    Friend WithEvents EOALANSISSARFHARBAKBindingSource As BindingSource
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents AlansısDataSet692 As ALANSISDataSet69
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colSARF_ADI As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colBAKIYE As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSARF As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents EO_ALANSIS_SARFHAR_BAKTableAdapter2 As ALANSISDataSet67TableAdapters.EO_ALANSIS_SARFHAR_BAKTableAdapter
End Class
