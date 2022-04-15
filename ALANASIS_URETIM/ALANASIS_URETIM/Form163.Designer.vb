<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form163
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
        Me.EOALANSISMAMULSTOKBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.ALANSISDataSet21BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ALANSISDataSet21 = New WindowsApplication1.ALANSISDataSet21()
        Me.EOALANSISMAMULSTOKBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TextEdit4 = New DevExpress.XtraEditors.TextEdit()
        Me.TextEdit3 = New DevExpress.XtraEditors.TextEdit()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextEdit2 = New DevExpress.XtraEditors.TextEdit()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextEdit1 = New DevExpress.XtraEditors.TextEdit()
        Me.AlansısDataSet201 = New WindowsApplication1.ALANSISDataSet20()
        Me.EO_ALANSIS_MAMULSTOKTableAdapter = New WindowsApplication1.ALANSISDataSet21TableAdapters.EO_ALANSIS_MAMULSTOKTableAdapter()
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl()
        Me.AlansısDataSet211 = New WindowsApplication1.ALANSISDataSet21()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colTARIH = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSERI = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSTOK_KODU = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSTOK_ADI = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colNET = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colBRUT = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDARA = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colBOLGE = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colRENK = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.EO_ALANSIS_MAMULSTOKTableAdapter1 = New WindowsApplication1.ALANSISDataSet21TableAdapters.EO_ALANSIS_MAMULSTOKTableAdapter()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        CType(Me.EOALANSISMAMULSTOKBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ALANSISDataSet21BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ALANSISDataSet21, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EOALANSISMAMULSTOKBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextEdit4.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextEdit3.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextEdit2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AlansısDataSet201, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AlansısDataSet211, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DefaultLookAndFeel1
        '
        Me.DefaultLookAndFeel1.LookAndFeel.SkinName = "Office 2007 Blue"
        '
        'EOALANSISMAMULSTOKBindingSource1
        '
        Me.EOALANSISMAMULSTOKBindingSource1.DataMember = "EO_ALANSIS_MAMULSTOK"
        Me.EOALANSISMAMULSTOKBindingSource1.DataSource = Me.ALANSISDataSet21BindingSource
        '
        'ALANSISDataSet21BindingSource
        '
        Me.ALANSISDataSet21BindingSource.DataSource = Me.ALANSISDataSet21
        Me.ALANSISDataSet21BindingSource.Position = 0
        '
        'ALANSISDataSet21
        '
        Me.ALANSISDataSet21.DataSetName = "ALANSISDataSet21"
        Me.ALANSISDataSet21.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'EOALANSISMAMULSTOKBindingSource
        '
        Me.EOALANSISMAMULSTOKBindingSource.DataMember = "EO_ALANSIS_MAMULSTOK"
        Me.EOALANSISMAMULSTOKBindingSource.DataSource = Me.ALANSISDataSet21BindingSource
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(409, 15)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(61, 13)
        Me.Label4.TabIndex = 35
        Me.Label4.Text = "Üret.Miktar"
        '
        'TextEdit4
        '
        Me.TextEdit4.EditValue = "0"
        Me.TextEdit4.Enabled = False
        Me.TextEdit4.Location = New System.Drawing.Point(476, 12)
        Me.TextEdit4.Name = "TextEdit4"
        Me.TextEdit4.Size = New System.Drawing.Size(81, 20)
        Me.TextEdit4.TabIndex = 34
        '
        'TextEdit3
        '
        Me.TextEdit3.Enabled = False
        Me.TextEdit3.Location = New System.Drawing.Point(236, 12)
        Me.TextEdit3.Name = "TextEdit3"
        Me.TextEdit3.Size = New System.Drawing.Size(167, 20)
        Me.TextEdit3.TabIndex = 33
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(166, 15)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(64, 13)
        Me.Label3.TabIndex = 32
        Me.Label3.Text = "Mamul Kodu"
        '
        'TextEdit2
        '
        Me.TextEdit2.Enabled = False
        Me.TextEdit2.Location = New System.Drawing.Point(56, 12)
        Me.TextEdit2.Name = "TextEdit2"
        Me.TextEdit2.Size = New System.Drawing.Size(104, 20)
        Me.TextEdit2.TabIndex = 31
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(5, 15)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(45, 13)
        Me.Label2.TabIndex = 30
        Me.Label2.Text = "Parti No"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(590, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(112, 13)
        Me.Label1.TabIndex = 29
        Me.Label1.Text = "Rezerve Mamul Miktar"
        '
        'TextEdit1
        '
        Me.TextEdit1.EditValue = "0"
        Me.TextEdit1.Enabled = False
        Me.TextEdit1.Location = New System.Drawing.Point(708, 12)
        Me.TextEdit1.Name = "TextEdit1"
        Me.TextEdit1.Size = New System.Drawing.Size(81, 20)
        Me.TextEdit1.TabIndex = 28
        '
        'AlansısDataSet201
        '
        Me.AlansısDataSet201.DataSetName = "ALANSISDataSet20"
        Me.AlansısDataSet201.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'EO_ALANSIS_MAMULSTOKTableAdapter
        '
        Me.EO_ALANSIS_MAMULSTOKTableAdapter.ClearBeforeFill = True
        '
        'GridControl1
        '
        Me.GridControl1.DataMember = "EO_ALANSIS_MAMULSTOK"
        Me.GridControl1.DataSource = Me.AlansısDataSet211
        Me.GridControl1.Location = New System.Drawing.Point(4, 38)
        Me.GridControl1.MainView = Me.GridView1
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.Size = New System.Drawing.Size(946, 409)
        Me.GridControl1.TabIndex = 36
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'AlansısDataSet211
        '
        Me.AlansısDataSet211.DataSetName = "ALANSISDataSet21"
        Me.AlansısDataSet211.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colTARIH, Me.colSERI, Me.colSTOK_KODU, Me.colSTOK_ADI, Me.colNET, Me.colBRUT, Me.colDARA, Me.colBOLGE, Me.colRENK})
        Me.GridView1.GridControl = Me.GridControl1
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsView.RowAutoHeight = True
        '
        'colTARIH
        '
        Me.colTARIH.FieldName = "TARIH"
        Me.colTARIH.Name = "colTARIH"
        Me.colTARIH.Visible = True
        Me.colTARIH.VisibleIndex = 0
        '
        'colSERI
        '
        Me.colSERI.FieldName = "SERI"
        Me.colSERI.Name = "colSERI"
        Me.colSERI.Visible = True
        Me.colSERI.VisibleIndex = 1
        '
        'colSTOK_KODU
        '
        Me.colSTOK_KODU.FieldName = "STOK_KODU"
        Me.colSTOK_KODU.Name = "colSTOK_KODU"
        Me.colSTOK_KODU.Visible = True
        Me.colSTOK_KODU.VisibleIndex = 2
        '
        'colSTOK_ADI
        '
        Me.colSTOK_ADI.FieldName = "STOK_ADI"
        Me.colSTOK_ADI.Name = "colSTOK_ADI"
        Me.colSTOK_ADI.Visible = True
        Me.colSTOK_ADI.VisibleIndex = 3
        '
        'colNET
        '
        Me.colNET.FieldName = "NET"
        Me.colNET.Name = "colNET"
        Me.colNET.Visible = True
        Me.colNET.VisibleIndex = 4
        '
        'colBRUT
        '
        Me.colBRUT.FieldName = "BRUT"
        Me.colBRUT.Name = "colBRUT"
        Me.colBRUT.Visible = True
        Me.colBRUT.VisibleIndex = 5
        '
        'colDARA
        '
        Me.colDARA.FieldName = "DARA"
        Me.colDARA.Name = "colDARA"
        Me.colDARA.Visible = True
        Me.colDARA.VisibleIndex = 6
        '
        'colBOLGE
        '
        Me.colBOLGE.FieldName = "BOLGE"
        Me.colBOLGE.Name = "colBOLGE"
        Me.colBOLGE.Visible = True
        Me.colBOLGE.VisibleIndex = 7
        '
        'colRENK
        '
        Me.colRENK.FieldName = "RENK"
        Me.colRENK.Name = "colRENK"
        Me.colRENK.Visible = True
        Me.colRENK.VisibleIndex = 8
        '
        'EO_ALANSIS_MAMULSTOKTableAdapter1
        '
        Me.EO_ALANSIS_MAMULSTOKTableAdapter1.ClearBeforeFill = True
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.Location = New System.Drawing.Point(12, 343)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(120, 95)
        Me.ListBox1.TabIndex = 37
        Me.ListBox1.Visible = False
        '
        'SimpleButton1
        '
        Me.SimpleButton1.Location = New System.Drawing.Point(810, 12)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(130, 22)
        Me.SimpleButton1.TabIndex = 38
        Me.SimpleButton1.Text = "Rezerve İşlem"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(12, 241)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 21)
        Me.TextBox1.TabIndex = 39
        Me.TextBox1.Visible = False
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(12, 277)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(100, 21)
        Me.TextBox2.TabIndex = 40
        Me.TextBox2.Visible = False
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(12, 304)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(100, 21)
        Me.TextBox3.TabIndex = 41
        Me.TextBox3.Visible = False
        '
        'Form163
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(952, 450)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.SimpleButton1)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.GridControl1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TextEdit4)
        Me.Controls.Add(Me.TextEdit3)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TextEdit2)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TextEdit1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "Form163"
        Me.Text = "ALANSIS STOK MAMUL REZERVE"
        CType(Me.EOALANSISMAMULSTOKBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ALANSISDataSet21BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ALANSISDataSet21, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EOALANSISMAMULSTOKBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextEdit4.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextEdit3.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextEdit2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AlansısDataSet201, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AlansısDataSet211, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents FormAssistant1 As DevExpress.XtraBars.FormAssistant
    Friend WithEvents DefaultLookAndFeel1 As DevExpress.LookAndFeel.DefaultLookAndFeel
    Friend WithEvents Label4 As Label
    Friend WithEvents TextEdit4 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents TextEdit3 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label3 As Label
    Friend WithEvents TextEdit2 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents TextEdit1 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents AlansısDataSet201 As ALANSISDataSet20
    Friend WithEvents ALANSISDataSet21BindingSource As BindingSource
    Friend WithEvents ALANSISDataSet21 As ALANSISDataSet21
    Friend WithEvents EOALANSISMAMULSTOKBindingSource As BindingSource
    Friend WithEvents EO_ALANSIS_MAMULSTOKTableAdapter As ALANSISDataSet21TableAdapters.EO_ALANSIS_MAMULSTOKTableAdapter
    Friend WithEvents EOALANSISMAMULSTOKBindingSource1 As BindingSource
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents AlansısDataSet211 As ALANSISDataSet21
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colTARIH As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSERI As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSTOK_KODU As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSTOK_ADI As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNET As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colBRUT As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDARA As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colBOLGE As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colRENK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents EO_ALANSIS_MAMULSTOKTableAdapter1 As ALANSISDataSet21TableAdapters.EO_ALANSIS_MAMULSTOKTableAdapter
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox3 As TextBox
End Class
