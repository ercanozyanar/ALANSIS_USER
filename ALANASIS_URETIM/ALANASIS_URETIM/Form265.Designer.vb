<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form265
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
        Me.ComboBoxEdit1 = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl()
        Me.CheckEdit5 = New DevExpress.XtraEditors.CheckEdit()
        Me.CheckEdit6 = New DevExpress.XtraEditors.CheckEdit()
        Me.CheckEdit7 = New DevExpress.XtraEditors.CheckEdit()
        Me.CheckEdit8 = New DevExpress.XtraEditors.CheckEdit()
        Me.CheckEdit4 = New DevExpress.XtraEditors.CheckEdit()
        Me.CheckEdit3 = New DevExpress.XtraEditors.CheckEdit()
        Me.CheckEdit2 = New DevExpress.XtraEditors.CheckEdit()
        Me.CheckEdit1 = New DevExpress.XtraEditors.CheckEdit()
        Me.SimpleButton2 = New DevExpress.XtraEditors.SimpleButton()
        CType(Me.ComboBoxEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.CheckEdit5.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CheckEdit6.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CheckEdit7.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CheckEdit8.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CheckEdit4.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CheckEdit3.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CheckEdit2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CheckEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DefaultLookAndFeel1
        '
        Me.DefaultLookAndFeel1.LookAndFeel.SkinName = "Office 2007 Blue"
        '
        'ComboBoxEdit1
        '
        Me.ComboBoxEdit1.Location = New System.Drawing.Point(125, 9)
        Me.ComboBoxEdit1.Name = "ComboBoxEdit1"
        Me.ComboBoxEdit1.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.ComboBoxEdit1.Properties.Appearance.Options.UseFont = True
        Me.ComboBoxEdit1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.ComboBoxEdit1.Properties.Items.AddRange(New Object() {"EKALAN1", "EKALAN2", "EKALAN3", "EKALAN4", "EKALAN5", "EKALAN6", "EKALAN7", "EKALAN8", "EKALAN9", "EKALAN10"})
        Me.ComboBoxEdit1.Size = New System.Drawing.Size(164, 28)
        Me.ComboBoxEdit1.TabIndex = 1
        '
        'LabelControl2
        '
        Me.LabelControl2.Appearance.Font = New System.Drawing.Font("Tahoma", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.LabelControl2.Appearance.Options.UseFont = True
        Me.LabelControl2.Location = New System.Drawing.Point(3, 12)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(117, 22)
        Me.LabelControl2.TabIndex = 3
        Me.LabelControl2.Text = "Eklenecek Alan"
        '
        'GridControl1
        '
        Me.GridControl1.Location = New System.Drawing.Point(3, 166)
        Me.GridControl1.MainView = Me.GridView1
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.Size = New System.Drawing.Size(1044, 472)
        Me.GridControl1.TabIndex = 5
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.GridControl = Me.GridControl1
        Me.GridView1.Name = "GridView1"
        '
        'GroupControl1
        '
        Me.GroupControl1.Controls.Add(Me.CheckEdit5)
        Me.GroupControl1.Controls.Add(Me.CheckEdit6)
        Me.GroupControl1.Controls.Add(Me.CheckEdit7)
        Me.GroupControl1.Controls.Add(Me.CheckEdit8)
        Me.GroupControl1.Controls.Add(Me.CheckEdit4)
        Me.GroupControl1.Controls.Add(Me.CheckEdit3)
        Me.GroupControl1.Controls.Add(Me.CheckEdit2)
        Me.GroupControl1.Controls.Add(Me.CheckEdit1)
        Me.GroupControl1.Location = New System.Drawing.Point(3, 60)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(1044, 100)
        Me.GroupControl1.TabIndex = 6
        Me.GroupControl1.Text = "Yetkilendirme"
        '
        'CheckEdit5
        '
        Me.CheckEdit5.Location = New System.Drawing.Point(716, 51)
        Me.CheckEdit5.Name = "CheckEdit5"
        Me.CheckEdit5.Properties.Caption = "Bahçeler"
        Me.CheckEdit5.Size = New System.Drawing.Size(94, 20)
        Me.CheckEdit5.TabIndex = 7
        '
        'CheckEdit6
        '
        Me.CheckEdit6.Location = New System.Drawing.Point(597, 51)
        Me.CheckEdit6.Name = "CheckEdit6"
        Me.CheckEdit6.Properties.Caption = "Depo"
        Me.CheckEdit6.Size = New System.Drawing.Size(94, 20)
        Me.CheckEdit6.TabIndex = 6
        '
        'CheckEdit7
        '
        Me.CheckEdit7.Location = New System.Drawing.Point(827, 51)
        Me.CheckEdit7.Name = "CheckEdit7"
        Me.CheckEdit7.Properties.Caption = "Müşteri"
        Me.CheckEdit7.Size = New System.Drawing.Size(94, 20)
        Me.CheckEdit7.TabIndex = 5
        '
        'CheckEdit8
        '
        Me.CheckEdit8.Location = New System.Drawing.Point(485, 51)
        Me.CheckEdit8.Name = "CheckEdit8"
        Me.CheckEdit8.Properties.Caption = "Kalite"
        Me.CheckEdit8.Size = New System.Drawing.Size(83, 20)
        Me.CheckEdit8.TabIndex = 4
        '
        'CheckEdit4
        '
        Me.CheckEdit4.Location = New System.Drawing.Point(281, 51)
        Me.CheckEdit4.Name = "CheckEdit4"
        Me.CheckEdit4.Properties.Caption = "Lojistik"
        Me.CheckEdit4.Size = New System.Drawing.Size(94, 20)
        Me.CheckEdit4.TabIndex = 3
        '
        'CheckEdit3
        '
        Me.CheckEdit3.Location = New System.Drawing.Point(165, 51)
        Me.CheckEdit3.Name = "CheckEdit3"
        Me.CheckEdit3.Properties.Caption = "Muhasebe"
        Me.CheckEdit3.Size = New System.Drawing.Size(94, 20)
        Me.CheckEdit3.TabIndex = 2
        '
        'CheckEdit2
        '
        Me.CheckEdit2.Location = New System.Drawing.Point(381, 51)
        Me.CheckEdit2.Name = "CheckEdit2"
        Me.CheckEdit2.Properties.Caption = "Üretim"
        Me.CheckEdit2.Size = New System.Drawing.Size(94, 20)
        Me.CheckEdit2.TabIndex = 1
        '
        'CheckEdit1
        '
        Me.CheckEdit1.Location = New System.Drawing.Point(9, 51)
        Me.CheckEdit1.Name = "CheckEdit1"
        Me.CheckEdit1.Properties.Caption = "Satış - Pazarlama"
        Me.CheckEdit1.Size = New System.Drawing.Size(135, 20)
        Me.CheckEdit1.TabIndex = 0
        '
        'SimpleButton2
        '
        Me.SimpleButton2.Appearance.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.SimpleButton2.Appearance.Options.UseFont = True
        Me.SimpleButton2.Location = New System.Drawing.Point(307, 4)
        Me.SimpleButton2.Name = "SimpleButton2"
        Me.SimpleButton2.Size = New System.Drawing.Size(264, 38)
        Me.SimpleButton2.TabIndex = 4
        Me.SimpleButton2.Text = "İŞLEM"
        '
        'Form265
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1051, 646)
        Me.Controls.Add(Me.SimpleButton2)
        Me.Controls.Add(Me.GroupControl1)
        Me.Controls.Add(Me.GridControl1)
        Me.Controls.Add(Me.LabelControl2)
        Me.Controls.Add(Me.ComboBoxEdit1)
        Me.IconOptions.Image = Global.WindowsApplication1.My.Resources.Resources.LOGIN11
        Me.Name = "Form265"
        Me.Text = "Alansis Tablo Düzenleme (Kiraz)"
        CType(Me.ComboBoxEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        CType(Me.CheckEdit5.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CheckEdit6.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CheckEdit7.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CheckEdit8.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CheckEdit4.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CheckEdit3.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CheckEdit2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CheckEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents FormAssistant1 As DevExpress.XtraBars.FormAssistant
    Private WithEvents DefaultLookAndFeel1 As DevExpress.LookAndFeel.DefaultLookAndFeel
    Friend WithEvents ComboBoxEdit1 As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents CheckEdit4 As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents CheckEdit3 As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents CheckEdit2 As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents CheckEdit1 As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents SimpleButton2 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents CheckEdit5 As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents CheckEdit6 As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents CheckEdit7 As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents CheckEdit8 As DevExpress.XtraEditors.CheckEdit
End Class
