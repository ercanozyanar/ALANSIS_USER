<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form160
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
        Me.Column1 = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ComboBoxEdit1 = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.GridLookUpEdit1View = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.ALANSISDataSet = New WindowsApplication1.ALANSISDataSet()
        Me.ALANSISDataSetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ALANSISDataSet1 = New WindowsApplication1.ALANSISDataSet1()
        Me.EOALANSISSATISBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.EO_ALANSIS_SATISTableAdapter = New WindowsApplication1.ALANSISDataSet1TableAdapters.EO_ALANSIS_SATISTableAdapter()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ComboBoxEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridLookUpEdit1View, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ALANSISDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ALANSISDataSetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ALANSISDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EOALANSISSATISBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DefaultLookAndFeel1
        '
        Me.DefaultLookAndFeel1.LookAndFeel.SkinName = "Office 2007 Blue"
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1})
        Me.DataGridView1.Location = New System.Drawing.Point(0, 36)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(800, 414)
        Me.DataGridView1.TabIndex = 1
        '
        'Column1
        '
        Me.Column1.Frozen = True
        Me.Column1.HeaderText = "ISLEM"
        Me.Column1.Name = "Column1"
        Me.Column1.Text = "SIL"
        Me.Column1.ToolTipText = "SIL"
        Me.Column1.UseColumnTextForButtonValue = True
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(380, 277)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(13, 21)
        Me.TextBox3.TabIndex = 6
        Me.TextBox3.Visible = False
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(393, 183)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(26, 21)
        Me.TextBox2.TabIndex = 5
        Me.TextBox2.Visible = False
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(393, 152)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(27, 21)
        Me.TextBox1.TabIndex = 4
        Me.TextBox1.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(83, 13)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Parti Numarası :"
        '
        'ComboBoxEdit1
        '
        Me.ComboBoxEdit1.Location = New System.Drawing.Point(101, 6)
        Me.ComboBoxEdit1.Name = "ComboBoxEdit1"
        Me.ComboBoxEdit1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.ComboBoxEdit1.Properties.DataSource = Me.EOALANSISSATISBindingSource
        Me.ComboBoxEdit1.Properties.DisplayMember = "PARTI"
        Me.ComboBoxEdit1.Properties.NullText = ""
        Me.ComboBoxEdit1.Properties.PopupSizeable = False
        Me.ComboBoxEdit1.Properties.PopupView = Me.GridLookUpEdit1View
        Me.ComboBoxEdit1.Properties.ValueMember = "PARTI"
        Me.ComboBoxEdit1.Size = New System.Drawing.Size(206, 20)
        Me.ComboBoxEdit1.TabIndex = 7
        '
        'GridLookUpEdit1View
        '
        Me.GridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridLookUpEdit1View.Name = "GridLookUpEdit1View"
        Me.GridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridLookUpEdit1View.OptionsView.ShowGroupPanel = False
        '
        'ALANSISDataSet
        '
        Me.ALANSISDataSet.DataSetName = "ALANSISDataSet"
        Me.ALANSISDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ALANSISDataSetBindingSource
        '
        Me.ALANSISDataSetBindingSource.DataSource = Me.ALANSISDataSet
        Me.ALANSISDataSetBindingSource.Position = 0
        '
        'ALANSISDataSet1
        '
        Me.ALANSISDataSet1.DataSetName = "ALANSISDataSet1"
        Me.ALANSISDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'EOALANSISSATISBindingSource
        '
        Me.EOALANSISSATISBindingSource.DataMember = "EO_ALANSIS_SATIS"
        Me.EOALANSISSATISBindingSource.DataSource = Me.ALANSISDataSet1
        '
        'EO_ALANSIS_SATISTableAdapter
        '
        Me.EO_ALANSIS_SATISTableAdapter.ClearBeforeFill = True
        '
        'Form160
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.ComboBoxEdit1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "Form160"
        Me.Text = "ALANSIS KIRAZ TUKETIM SERI ISLEM"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ComboBoxEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridLookUpEdit1View, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ALANSISDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ALANSISDataSetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ALANSISDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EOALANSISSATISBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents FormAssistant1 As DevExpress.XtraBars.FormAssistant
    Friend WithEvents DefaultLookAndFeel1 As DevExpress.LookAndFeel.DefaultLookAndFeel
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Column1 As DataGridViewButtonColumn
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents ComboBoxEdit1 As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents ALANSISDataSetBindingSource As BindingSource
    Friend WithEvents ALANSISDataSet As ALANSISDataSet
    Friend WithEvents GridLookUpEdit1View As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents ALANSISDataSet1 As ALANSISDataSet1
    Friend WithEvents EOALANSISSATISBindingSource As BindingSource
    Friend WithEvents EO_ALANSIS_SATISTableAdapter As ALANSISDataSet1TableAdapters.EO_ALANSIS_SATISTableAdapter
End Class
