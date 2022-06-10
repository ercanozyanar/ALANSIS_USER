<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form126
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
        Me.EOALANSISSATISBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ALANSISDataSet1 = New WindowsApplication1.ALANSISDataSet1()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ALANSISDataSet = New WindowsApplication1.ALANSISDataSet()
        Me.EOALANSISSATISDETAYBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.EO_ALANSIS_SATIS_DETAYTableAdapter = New WindowsApplication1.ALANSISDataSetTableAdapters.EO_ALANSIS_SATIS_DETAYTableAdapter()
        Me.EO_ALANSIS_SATISTableAdapter = New WindowsApplication1.ALANSISDataSet1TableAdapters.EO_ALANSIS_SATISTableAdapter()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.CheckEdit3 = New DevExpress.XtraEditors.CheckEdit()
        Me.CheckEdit2 = New DevExpress.XtraEditors.CheckEdit()
        Me.CheckEdit1 = New DevExpress.XtraEditors.CheckEdit()
        Me.ComboBoxEdit1 = New DevExpress.XtraEditors.SearchLookUpEdit()
        Me.SearchLookUpEdit1View = New DevExpress.XtraGrid.Views.Grid.GridView()
        CType(Me.EOALANSISSATISBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ALANSISDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ALANSISDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EOALANSISSATISDETAYBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CheckEdit3.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CheckEdit2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CheckEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ComboBoxEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SearchLookUpEdit1View, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DefaultLookAndFeel1
        '
        Me.DefaultLookAndFeel1.LookAndFeel.SkinName = "Office 2007 Blue"
        '
        'EOALANSISSATISBindingSource
        '
        Me.EOALANSISSATISBindingSource.DataMember = "EO_ALANSIS_SATIS"
        Me.EOALANSISSATISBindingSource.DataSource = Me.ALANSISDataSet1
        '
        'ALANSISDataSet1
        '
        Me.ALANSISDataSet1.DataSetName = "ALANSISDataSet1"
        Me.ALANSISDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(14, 11)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(56, 17)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Parti No"
        '
        'ALANSISDataSet
        '
        Me.ALANSISDataSet.DataSetName = "ALANSISDataSet"
        Me.ALANSISDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'EOALANSISSATISDETAYBindingSource
        '
        Me.EOALANSISSATISDETAYBindingSource.DataMember = "EO_ALANSIS_SATIS_DETAY"
        Me.EOALANSISSATISDETAYBindingSource.DataSource = Me.ALANSISDataSet
        '
        'EO_ALANSIS_SATIS_DETAYTableAdapter
        '
        Me.EO_ALANSIS_SATIS_DETAYTableAdapter.ClearBeforeFill = True
        '
        'EO_ALANSIS_SATISTableAdapter
        '
        Me.EO_ALANSIS_SATISTableAdapter.ClearBeforeFill = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(28, 116)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(45, 17)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Detay"
        '
        'RichTextBox1
        '
        Me.RichTextBox1.Location = New System.Drawing.Point(17, 135)
        Me.RichTextBox1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.Size = New System.Drawing.Size(801, 255)
        Me.RichTextBox1.TabIndex = 3
        Me.RichTextBox1.Text = ""
        '
        'SimpleButton1
        '
        Me.SimpleButton1.Location = New System.Drawing.Point(17, 399)
        Me.SimpleButton1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(110, 39)
        Me.SimpleButton1.TabIndex = 7
        Me.SimpleButton1.Text = "Kaydet"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(230, 30)
        Me.TextBox1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(34, 23)
        Me.TextBox1.TabIndex = 8
        Me.TextBox1.Visible = False
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(272, 30)
        Me.TextBox2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(34, 23)
        Me.TextBox2.TabIndex = 9
        Me.TextBox2.Visible = False
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(314, 30)
        Me.TextBox3.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(34, 23)
        Me.TextBox3.TabIndex = 10
        Me.TextBox3.Visible = False
        '
        'CheckEdit3
        '
        Me.CheckEdit3.Location = New System.Drawing.Point(280, 80)
        Me.CheckEdit3.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.CheckEdit3.Name = "CheckEdit3"
        Me.CheckEdit3.Properties.Caption = "Analiz"
        Me.CheckEdit3.Size = New System.Drawing.Size(87, 20)
        Me.CheckEdit3.TabIndex = 6
        '
        'CheckEdit2
        '
        Me.CheckEdit2.Location = New System.Drawing.Point(146, 80)
        Me.CheckEdit2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.CheckEdit2.Name = "CheckEdit2"
        Me.CheckEdit2.Properties.Caption = "Transfer"
        Me.CheckEdit2.Size = New System.Drawing.Size(87, 20)
        Me.CheckEdit2.TabIndex = 5
        '
        'CheckEdit1
        '
        Me.CheckEdit1.Location = New System.Drawing.Point(17, 80)
        Me.CheckEdit1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.CheckEdit1.Name = "CheckEdit1"
        Me.CheckEdit1.Properties.Caption = "Çift Şöför"
        Me.CheckEdit1.Size = New System.Drawing.Size(87, 20)
        Me.CheckEdit1.TabIndex = 4
        '
        'ComboBoxEdit1
        '
        Me.ComboBoxEdit1.Location = New System.Drawing.Point(17, 31)
        Me.ComboBoxEdit1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.ComboBoxEdit1.Name = "ComboBoxEdit1"
        Me.ComboBoxEdit1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.ComboBoxEdit1.Properties.DataSource = Me.EOALANSISSATISBindingSource
        Me.ComboBoxEdit1.Properties.DisplayMember = "PARTI"
        Me.ComboBoxEdit1.Properties.NullText = ""
        Me.ComboBoxEdit1.Properties.PopupSizeable = False
        Me.ComboBoxEdit1.Properties.PopupView = Me.SearchLookUpEdit1View
        Me.ComboBoxEdit1.Properties.ValueMember = "PARTI"
        Me.ComboBoxEdit1.Size = New System.Drawing.Size(143, 23)
        Me.ComboBoxEdit1.TabIndex = 0
        '
        'SearchLookUpEdit1View
        '
        Me.SearchLookUpEdit1View.DetailHeight = 431
        Me.SearchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.SearchLookUpEdit1View.Name = "SearchLookUpEdit1View"
        Me.SearchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.SearchLookUpEdit1View.OptionsView.ShowGroupPanel = False
        '
        'Form126
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(833, 463)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.SimpleButton1)
        Me.Controls.Add(Me.CheckEdit3)
        Me.Controls.Add(Me.CheckEdit2)
        Me.Controls.Add(Me.CheckEdit1)
        Me.Controls.Add(Me.RichTextBox1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ComboBoxEdit1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "Form126"
        Me.Text = "ALANSIS - PARTINO SEVKIYAT DETAY"
        CType(Me.EOALANSISSATISBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ALANSISDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ALANSISDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EOALANSISSATISDETAYBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CheckEdit3.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CheckEdit2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CheckEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ComboBoxEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SearchLookUpEdit1View, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents FormAssistant1 As DevExpress.XtraBars.FormAssistant
    Friend WithEvents DefaultLookAndFeel1 As DevExpress.LookAndFeel.DefaultLookAndFeel
    Friend WithEvents ComboBoxEdit1 As DevExpress.XtraEditors.SearchLookUpEdit
    Friend WithEvents SearchLookUpEdit1View As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents Label1 As Label
    Friend WithEvents ALANSISDataSet As ALANSISDataSet
    Friend WithEvents EOALANSISSATISDETAYBindingSource As BindingSource
    Friend WithEvents EO_ALANSIS_SATIS_DETAYTableAdapter As ALANSISDataSetTableAdapters.EO_ALANSIS_SATIS_DETAYTableAdapter
    Friend WithEvents ALANSISDataSet1 As ALANSISDataSet1
    Friend WithEvents EOALANSISSATISBindingSource As BindingSource
    Friend WithEvents EO_ALANSIS_SATISTableAdapter As ALANSISDataSet1TableAdapters.EO_ALANSIS_SATISTableAdapter
    Friend WithEvents Label2 As Label
    Friend WithEvents RichTextBox1 As RichTextBox
    Friend WithEvents CheckEdit1 As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents CheckEdit2 As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents CheckEdit3 As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox3 As TextBox
End Class
