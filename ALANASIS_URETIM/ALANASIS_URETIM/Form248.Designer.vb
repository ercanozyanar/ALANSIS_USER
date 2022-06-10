<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form248
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form248))
        Me.FormAssistant1 = New DevExpress.XtraBars.FormAssistant()
        Me.DefaultLookAndFeel1 = New DevExpress.LookAndFeel.DefaultLookAndFeel(Me.components)
        Me.EOALANSISEXCELYURTICIRISKBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ALANSISDataSet61BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ALANSISDataSet61 = New WindowsApplication1.ALANSISDataSet61()
        Me.EO_ALANSIS_EXCELYURTICIRISKTableAdapter = New WindowsApplication1.ALANSISDataSet61TableAdapters.EO_ALANSIS_EXCELYURTICIRISKTableAdapter()
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton()
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        CType(Me.EOALANSISEXCELYURTICIRISKBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ALANSISDataSet61BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ALANSISDataSet61, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DefaultLookAndFeel1
        '
        Me.DefaultLookAndFeel1.LookAndFeel.SkinName = "Office 2007 Blue"
        '
        'EOALANSISEXCELYURTICIRISKBindingSource
        '
        Me.EOALANSISEXCELYURTICIRISKBindingSource.DataMember = "EO_ALANSIS_EXCELYURTICIRISK"
        Me.EOALANSISEXCELYURTICIRISKBindingSource.DataSource = Me.ALANSISDataSet61BindingSource
        '
        'ALANSISDataSet61BindingSource
        '
        Me.ALANSISDataSet61BindingSource.DataSource = Me.ALANSISDataSet61
        Me.ALANSISDataSet61BindingSource.Position = 0
        '
        'ALANSISDataSet61
        '
        Me.ALANSISDataSet61.DataSetName = "ALANSISDataSet61"
        Me.ALANSISDataSet61.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'EO_ALANSIS_EXCELYURTICIRISKTableAdapter
        '
        Me.EO_ALANSIS_EXCELYURTICIRISKTableAdapter.ClearBeforeFill = True
        '
        'SimpleButton1
        '
        Me.SimpleButton1.ImageOptions.Image = CType(resources.GetObject("SimpleButton1.ImageOptions.Image"), System.Drawing.Image)
        Me.SimpleButton1.Location = New System.Drawing.Point(2, 12)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(43, 48)
        Me.SimpleButton1.TabIndex = 5
        '
        'GridControl1
        '
        Me.GridControl1.Location = New System.Drawing.Point(2, 66)
        Me.GridControl1.MainView = Me.GridView1
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.Size = New System.Drawing.Size(1159, 654)
        Me.GridControl1.TabIndex = 6
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.GridControl = Me.GridControl1
        Me.GridView1.Name = "GridView1"
        '
        'Form248
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1164, 722)
        Me.Controls.Add(Me.GridControl1)
        Me.Controls.Add(Me.SimpleButton1)
        Me.IconOptions.Image = Global.WindowsApplication1.My.Resources.Resources.LOGIN11
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form248"
        Me.Text = "ALANSIS IHRACAT VE YURTICI SATIS RISK TABLOSU"
        CType(Me.EOALANSISEXCELYURTICIRISKBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ALANSISDataSet61BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ALANSISDataSet61, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents FormAssistant1 As DevExpress.XtraBars.FormAssistant
    Friend WithEvents DefaultLookAndFeel1 As DevExpress.LookAndFeel.DefaultLookAndFeel
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents ALANSISDataSet61BindingSource As BindingSource
    Friend WithEvents ALANSISDataSet61 As ALANSISDataSet61
    Friend WithEvents EOALANSISEXCELYURTICIRISKBindingSource As BindingSource
    Friend WithEvents EO_ALANSIS_EXCELYURTICIRISKTableAdapter As ALANSISDataSet61TableAdapters.EO_ALANSIS_EXCELYURTICIRISKTableAdapter
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
End Class
