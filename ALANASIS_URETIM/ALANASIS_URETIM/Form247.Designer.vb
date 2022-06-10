<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form247
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
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton()
        Me.TextEdit3 = New DevExpress.XtraEditors.TextEdit()
        Me.TextEdit2 = New DevExpress.XtraEditors.TextEdit()
        Me.TextEdit1 = New DevExpress.XtraEditors.TextEdit()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.ListBox2 = New System.Windows.Forms.ListBox()
        Me.ListBox3 = New System.Windows.Forms.ListBox()
        Me.TextEdit4 = New DevExpress.XtraEditors.TextEdit()
        Me.TextEdit5 = New DevExpress.XtraEditors.TextEdit()
        Me.TextEdit6 = New DevExpress.XtraEditors.TextEdit()
        Me.TextEdit7 = New DevExpress.XtraEditors.TextEdit()
        Me.ListBox4 = New System.Windows.Forms.ListBox()
        Me.ListBox5 = New System.Windows.Forms.ListBox()
        Me.TextEdit8 = New DevExpress.XtraEditors.TextEdit()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.TextEdit3.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextEdit2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextEdit4.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextEdit5.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextEdit6.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextEdit7.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextEdit8.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DefaultLookAndFeel1
        '
        Me.DefaultLookAndFeel1.LookAndFeel.SkinName = "Office 2007 Blue"
        '
        'GridControl1
        '
        Me.GridControl1.Location = New System.Drawing.Point(3, 120)
        Me.GridControl1.MainView = Me.GridView1
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.Size = New System.Drawing.Size(1450, 753)
        Me.GridControl1.TabIndex = 0
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.GridControl = Me.GridControl1
        Me.GridView1.Name = "GridView1"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.SimpleButton1)
        Me.GroupBox1.Controls.Add(Me.TextEdit3)
        Me.GroupBox1.Controls.Add(Me.TextEdit2)
        Me.GroupBox1.Controls.Add(Me.TextEdit1)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(3, 2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1450, 112)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        '
        'SimpleButton1
        '
        Me.SimpleButton1.Appearance.Font = New System.Drawing.Font("Arial Narrow", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.SimpleButton1.Appearance.Options.UseFont = True
        Me.SimpleButton1.Location = New System.Drawing.Point(318, 56)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(157, 44)
        Me.SimpleButton1.TabIndex = 6
        Me.SimpleButton1.Text = "Onaya Gönder"
        '
        'TextEdit3
        '
        Me.TextEdit3.Enabled = False
        Me.TextEdit3.Location = New System.Drawing.Point(171, 77)
        Me.TextEdit3.Name = "TextEdit3"
        Me.TextEdit3.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.TextEdit3.Properties.Appearance.Options.UseBackColor = True
        Me.TextEdit3.Size = New System.Drawing.Size(125, 23)
        Me.TextEdit3.TabIndex = 5
        '
        'TextEdit2
        '
        Me.TextEdit2.Enabled = False
        Me.TextEdit2.Location = New System.Drawing.Point(171, 47)
        Me.TextEdit2.Name = "TextEdit2"
        Me.TextEdit2.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.TextEdit2.Properties.Appearance.Options.UseBackColor = True
        Me.TextEdit2.Size = New System.Drawing.Size(125, 23)
        Me.TextEdit2.TabIndex = 4
        '
        'TextEdit1
        '
        Me.TextEdit1.Enabled = False
        Me.TextEdit1.Location = New System.Drawing.Point(171, 16)
        Me.TextEdit1.Name = "TextEdit1"
        Me.TextEdit1.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.TextEdit1.Properties.Appearance.Options.UseBackColor = True
        Me.TextEdit1.Size = New System.Drawing.Size(125, 23)
        Me.TextEdit1.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(9, 80)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(153, 17)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Seçilen Toplam Brut KG."
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(9, 50)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(156, 17)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Seçilen Toplam Dara KG."
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(9, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(148, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Seçilen Toplam Net KG."
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.ItemHeight = 16
        Me.ListBox1.Location = New System.Drawing.Point(48, 765)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(120, 84)
        Me.ListBox1.TabIndex = 2
        Me.ListBox1.Visible = False
        '
        'ListBox2
        '
        Me.ListBox2.FormattingEnabled = True
        Me.ListBox2.ItemHeight = 16
        Me.ListBox2.Location = New System.Drawing.Point(179, 765)
        Me.ListBox2.Name = "ListBox2"
        Me.ListBox2.Size = New System.Drawing.Size(120, 84)
        Me.ListBox2.TabIndex = 3
        Me.ListBox2.Visible = False
        '
        'ListBox3
        '
        Me.ListBox3.FormattingEnabled = True
        Me.ListBox3.ItemHeight = 16
        Me.ListBox3.Location = New System.Drawing.Point(310, 765)
        Me.ListBox3.Name = "ListBox3"
        Me.ListBox3.Size = New System.Drawing.Size(120, 84)
        Me.ListBox3.TabIndex = 4
        Me.ListBox3.Visible = False
        '
        'TextEdit4
        '
        Me.TextEdit4.Location = New System.Drawing.Point(48, 724)
        Me.TextEdit4.Name = "TextEdit4"
        Me.TextEdit4.Size = New System.Drawing.Size(125, 23)
        Me.TextEdit4.TabIndex = 5
        Me.TextEdit4.Visible = False
        '
        'TextEdit5
        '
        Me.TextEdit5.Location = New System.Drawing.Point(179, 724)
        Me.TextEdit5.Name = "TextEdit5"
        Me.TextEdit5.Size = New System.Drawing.Size(125, 23)
        Me.TextEdit5.TabIndex = 6
        Me.TextEdit5.Visible = False
        '
        'TextEdit6
        '
        Me.TextEdit6.Location = New System.Drawing.Point(310, 724)
        Me.TextEdit6.Name = "TextEdit6"
        Me.TextEdit6.Size = New System.Drawing.Size(125, 23)
        Me.TextEdit6.TabIndex = 7
        Me.TextEdit6.Visible = False
        '
        'TextEdit7
        '
        Me.TextEdit7.Location = New System.Drawing.Point(451, 724)
        Me.TextEdit7.Name = "TextEdit7"
        Me.TextEdit7.Size = New System.Drawing.Size(125, 23)
        Me.TextEdit7.TabIndex = 10
        Me.TextEdit7.Visible = False
        '
        'ListBox4
        '
        Me.ListBox4.FormattingEnabled = True
        Me.ListBox4.ItemHeight = 16
        Me.ListBox4.Location = New System.Drawing.Point(451, 765)
        Me.ListBox4.Name = "ListBox4"
        Me.ListBox4.Size = New System.Drawing.Size(120, 84)
        Me.ListBox4.TabIndex = 11
        Me.ListBox4.Visible = False
        '
        'ListBox5
        '
        Me.ListBox5.FormattingEnabled = True
        Me.ListBox5.ItemHeight = 16
        Me.ListBox5.Location = New System.Drawing.Point(596, 765)
        Me.ListBox5.Name = "ListBox5"
        Me.ListBox5.Size = New System.Drawing.Size(120, 84)
        Me.ListBox5.TabIndex = 12
        Me.ListBox5.Visible = False
        '
        'TextEdit8
        '
        Me.TextEdit8.Location = New System.Drawing.Point(596, 724)
        Me.TextEdit8.Name = "TextEdit8"
        Me.TextEdit8.Size = New System.Drawing.Size(125, 23)
        Me.TextEdit8.TabIndex = 13
        Me.TextEdit8.Visible = False
        '
        'Form247
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1457, 874)
        Me.Controls.Add(Me.TextEdit8)
        Me.Controls.Add(Me.ListBox5)
        Me.Controls.Add(Me.ListBox4)
        Me.Controls.Add(Me.TextEdit7)
        Me.Controls.Add(Me.TextEdit6)
        Me.Controls.Add(Me.TextEdit5)
        Me.Controls.Add(Me.TextEdit4)
        Me.Controls.Add(Me.ListBox3)
        Me.Controls.Add(Me.ListBox2)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GridControl1)
        Me.IconOptions.Image = Global.WindowsApplication1.My.Resources.Resources.LOGIN11
        Me.Name = "Form247"
        Me.Text = "ALANSIS 2.KALITE SEVK SECIM"
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.TextEdit3.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextEdit2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextEdit4.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextEdit5.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextEdit6.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextEdit7.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextEdit8.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents FormAssistant1 As DevExpress.XtraBars.FormAssistant
    Friend WithEvents DefaultLookAndFeel1 As DevExpress.LookAndFeel.DefaultLookAndFeel
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents TextEdit3 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents TextEdit2 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents TextEdit1 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents ListBox2 As ListBox
    Friend WithEvents ListBox3 As ListBox
    Friend WithEvents TextEdit4 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents TextEdit5 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents TextEdit6 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents TextEdit7 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents ListBox4 As ListBox
    Friend WithEvents ListBox5 As ListBox
    Friend WithEvents TextEdit8 As DevExpress.XtraEditors.TextEdit
End Class
