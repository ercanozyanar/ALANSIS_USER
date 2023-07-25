<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form156
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
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl()
        Me.AlansısDataSet191 = New WindowsApplication1.ALANSISDataSet19()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colPARTI = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colRECETE = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSTOK_ADI = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colMIKTAR = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colFIRE = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ALANSISDataSet19 = New WindowsApplication1.ALANSISDataSet19()
        Me.ALANSISDataSet19BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.EO_ALANSIS_RECETETIKETIM_VWTableAdapter1 = New WindowsApplication1.ALANSISDataSet19TableAdapters.EO_ALANSIS_RECETETIKETIM_VWTableAdapter()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.ListBox2 = New System.Windows.Forms.ListBox()
        Me.BehaviorManager1 = New DevExpress.Utils.Behaviors.BehaviorManager(Me.components)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AlansısDataSet191, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ALANSISDataSet19, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ALANSISDataSet19BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BehaviorManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DefaultLookAndFeel1
        '
        Me.DefaultLookAndFeel1.LookAndFeel.SkinName = "Office 2007 Blue"
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(1, 379)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(1066, 295)
        Me.DataGridView1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(-2, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(95, 17)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Parti Numarası"
        '
        'SimpleButton1
        '
        Me.SimpleButton1.Location = New System.Drawing.Point(300, 11)
        Me.SimpleButton1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(131, 32)
        Me.SimpleButton1.TabIndex = 3
        Me.SimpleButton1.Text = "İşlem"
        '
        'ComboBox1
        '
        Me.ComboBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(93, 15)
        Me.ComboBox1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(199, 24)
        Me.ComboBox1.TabIndex = 4
        '
        'GridControl1
        '
        Me.GridControl1.DataMember = "EO_ALANSIS_RECETETIKETIM_VW"
        Me.GridControl1.DataSource = Me.AlansısDataSet191
        Me.GridControl1.EmbeddedNavigator.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GridControl1.Location = New System.Drawing.Point(1, 54)
        Me.GridControl1.MainView = Me.GridView1
        Me.GridControl1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.Size = New System.Drawing.Size(1066, 318)
        Me.GridControl1.TabIndex = 5
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'AlansısDataSet191
        '
        Me.AlansısDataSet191.DataSetName = "ALANSISDataSet19"
        Me.AlansısDataSet191.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colPARTI, Me.colRECETE, Me.colSTOK_ADI, Me.colMIKTAR, Me.colFIRE})
        Me.GridView1.DetailHeight = 431
        Me.GridView1.GridControl = Me.GridControl1
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsView.ColumnAutoWidth = False
        '
        'colPARTI
        '
        Me.colPARTI.FieldName = "PARTI"
        Me.colPARTI.MinWidth = 23
        Me.colPARTI.Name = "colPARTI"
        Me.colPARTI.Visible = True
        Me.colPARTI.VisibleIndex = 0
        Me.colPARTI.Width = 87
        '
        'colRECETE
        '
        Me.colRECETE.FieldName = "RECETE"
        Me.colRECETE.MinWidth = 23
        Me.colRECETE.Name = "colRECETE"
        Me.colRECETE.Visible = True
        Me.colRECETE.VisibleIndex = 1
        Me.colRECETE.Width = 87
        '
        'colSTOK_ADI
        '
        Me.colSTOK_ADI.FieldName = "STOK_ADI"
        Me.colSTOK_ADI.MinWidth = 23
        Me.colSTOK_ADI.Name = "colSTOK_ADI"
        Me.colSTOK_ADI.Visible = True
        Me.colSTOK_ADI.VisibleIndex = 2
        Me.colSTOK_ADI.Width = 87
        '
        'colMIKTAR
        '
        Me.colMIKTAR.FieldName = "MIKTAR"
        Me.colMIKTAR.MinWidth = 23
        Me.colMIKTAR.Name = "colMIKTAR"
        Me.colMIKTAR.Visible = True
        Me.colMIKTAR.VisibleIndex = 3
        Me.colMIKTAR.Width = 87
        '
        'colFIRE
        '
        Me.colFIRE.FieldName = "FIRE"
        Me.colFIRE.MinWidth = 23
        Me.colFIRE.Name = "colFIRE"
        Me.colFIRE.Visible = True
        Me.colFIRE.VisibleIndex = 4
        Me.colFIRE.Width = 87
        '
        'ALANSISDataSet19
        '
        Me.ALANSISDataSet19.DataSetName = "ALANSISDataSet19"
        Me.ALANSISDataSet19.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ALANSISDataSet19BindingSource
        '
        Me.ALANSISDataSet19BindingSource.DataSource = Me.ALANSISDataSet19
        Me.ALANSISDataSet19BindingSource.Position = 0
        '
        'EO_ALANSIS_RECETETIKETIM_VWTableAdapter1
        '
        Me.EO_ALANSIS_RECETETIKETIM_VWTableAdapter1.ClearBeforeFill = True
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.ItemHeight = 16
        Me.ListBox1.Location = New System.Drawing.Point(14, 394)
        Me.ListBox1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(94, 164)
        Me.ListBox1.TabIndex = 6
        '
        'ListBox2
        '
        Me.ListBox2.FormattingEnabled = True
        Me.ListBox2.ItemHeight = 16
        Me.ListBox2.Location = New System.Drawing.Point(115, 394)
        Me.ListBox2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.ListBox2.Name = "ListBox2"
        Me.ListBox2.Size = New System.Drawing.Size(94, 164)
        Me.ListBox2.TabIndex = 7
        '
        'Form156
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1071, 674)
        Me.Controls.Add(Me.ListBox2)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.GridControl1)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.SimpleButton1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DataGridView1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "Form156"
        Me.Text = "ALANSIS - RECETE SARF TUKETIM ISLEM"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AlansısDataSet191, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ALANSISDataSet19, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ALANSISDataSet19BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BehaviorManager1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents FormAssistant1 As DevExpress.XtraBars.FormAssistant
    Friend WithEvents DefaultLookAndFeel1 As DevExpress.LookAndFeel.DefaultLookAndFeel
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents AlansısDataSet191 As ALANSISDataSet19
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colPARTI As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colRECETE As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSTOK_ADI As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colMIKTAR As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFIRE As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ALANSISDataSet19 As ALANSISDataSet19
    Friend WithEvents ALANSISDataSet19BindingSource As BindingSource
    Friend WithEvents EO_ALANSIS_RECETETIKETIM_VWTableAdapter1 As ALANSISDataSet19TableAdapters.EO_ALANSIS_RECETETIKETIM_VWTableAdapter
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents ListBox2 As ListBox
    Friend WithEvents BehaviorManager1 As DevExpress.Utils.Behaviors.BehaviorManager
End Class
