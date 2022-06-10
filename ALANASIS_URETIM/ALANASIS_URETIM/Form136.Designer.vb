<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form136
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
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl()
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextEdit3 = New DevExpress.XtraEditors.TextEdit()
        Me.TextEdit2 = New DevExpress.XtraEditors.TextEdit()
        Me.TextEdit1 = New DevExpress.XtraEditors.TextEdit()
        Me.ComboBoxEdit1 = New DevExpress.XtraEditors.ComboBoxEdit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.TextEdit3.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextEdit2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ComboBoxEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DefaultLookAndFeel1
        '
        Me.DefaultLookAndFeel1.LookAndFeel.SkinName = "Office 2007 Blue"
        '
        'DataGridView1
        '
        Me.DataGridView1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(8, 123)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(1428, 487)
        Me.DataGridView1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 48)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(118, 17)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Hammadde Seçim"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(234, 68)
        Me.TextBox1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(18, 23)
        Me.TextBox1.TabIndex = 6
        Me.TextBox1.Visible = False
        '
        'GroupControl1
        '
        Me.GroupControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupControl1.Controls.Add(Me.SimpleButton1)
        Me.GroupControl1.Controls.Add(Me.Label4)
        Me.GroupControl1.Controls.Add(Me.Label3)
        Me.GroupControl1.Controls.Add(Me.Label2)
        Me.GroupControl1.Controls.Add(Me.Label1)
        Me.GroupControl1.Controls.Add(Me.TextEdit3)
        Me.GroupControl1.Controls.Add(Me.TextEdit2)
        Me.GroupControl1.Controls.Add(Me.TextBox1)
        Me.GroupControl1.Controls.Add(Me.TextEdit1)
        Me.GroupControl1.Controls.Add(Me.ComboBoxEdit1)
        Me.GroupControl1.Location = New System.Drawing.Point(8, 4)
        Me.GroupControl1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(1423, 122)
        Me.GroupControl1.TabIndex = 7
        Me.GroupControl1.Text = "Hammadde Özet Bilgileri"
        '
        'SimpleButton1
        '
        Me.SimpleButton1.Location = New System.Drawing.Point(745, 66)
        Me.SimpleButton1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(118, 30)
        Me.SimpleButton1.TabIndex = 10
        Me.SimpleButton1.Text = "Hücre Kontrol"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(601, 49)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(47, 17)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Bakiye"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(434, 48)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(77, 17)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Çıkış Bakiye"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(268, 49)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(75, 17)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Giriş Bakiye"
        '
        'TextEdit3
        '
        Me.TextEdit3.Location = New System.Drawing.Point(591, 69)
        Me.TextEdit3.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TextEdit3.Name = "TextEdit3"
        Me.TextEdit3.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.TextEdit3.Properties.Appearance.ForeColor = System.Drawing.Color.White
        Me.TextEdit3.Properties.Appearance.Options.UseBackColor = True
        Me.TextEdit3.Properties.Appearance.Options.UseForeColor = True
        Me.TextEdit3.Size = New System.Drawing.Size(147, 23)
        Me.TextEdit3.TabIndex = 3
        '
        'TextEdit2
        '
        Me.TextEdit2.Location = New System.Drawing.Point(426, 69)
        Me.TextEdit2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TextEdit2.Name = "TextEdit2"
        Me.TextEdit2.Properties.Appearance.BackColor = System.Drawing.Color.Brown
        Me.TextEdit2.Properties.Appearance.ForeColor = System.Drawing.Color.White
        Me.TextEdit2.Properties.Appearance.Options.UseBackColor = True
        Me.TextEdit2.Properties.Appearance.Options.UseForeColor = True
        Me.TextEdit2.Size = New System.Drawing.Size(147, 23)
        Me.TextEdit2.TabIndex = 2
        '
        'TextEdit1
        '
        Me.TextEdit1.Location = New System.Drawing.Point(260, 69)
        Me.TextEdit1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TextEdit1.Name = "TextEdit1"
        Me.TextEdit1.Properties.Appearance.BackColor = System.Drawing.Color.Green
        Me.TextEdit1.Properties.Appearance.ForeColor = System.Drawing.Color.White
        Me.TextEdit1.Properties.Appearance.Options.UseBackColor = True
        Me.TextEdit1.Properties.Appearance.Options.UseForeColor = True
        Me.TextEdit1.Size = New System.Drawing.Size(147, 23)
        Me.TextEdit1.TabIndex = 1
        '
        'ComboBoxEdit1
        '
        Me.ComboBoxEdit1.Location = New System.Drawing.Point(9, 68)
        Me.ComboBoxEdit1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.ComboBoxEdit1.Name = "ComboBoxEdit1"
        Me.ComboBoxEdit1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.ComboBoxEdit1.Properties.Items.AddRange(New Object() {"HAMMADDE KIRAZ", "HAMMADDE INCIR", "HAMMADDE KAYISI", "HAMMADDE MALATYA KAYISI", "HAMMADDE NAR", "HAMMADDE ERIK", "HAMMADDE ARMUT"})
        Me.ComboBoxEdit1.Size = New System.Drawing.Size(218, 23)
        Me.ComboBoxEdit1.TabIndex = 4
        '
        'Form136
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1438, 625)
        Me.Controls.Add(Me.GroupControl1)
        Me.Controls.Add(Me.DataGridView1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "Form136"
        Me.Text = "ALANSIS - DEPO STOK HAREKET IZLEME MODULU "
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        Me.GroupControl1.PerformLayout()
        CType(Me.TextEdit3.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextEdit2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ComboBoxEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents FormAssistant1 As DevExpress.XtraBars.FormAssistant
    Friend WithEvents DefaultLookAndFeel1 As DevExpress.LookAndFeel.DefaultLookAndFeel
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents TextEdit1 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents TextEdit2 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents TextEdit3 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents ComboBoxEdit1 As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
End Class
