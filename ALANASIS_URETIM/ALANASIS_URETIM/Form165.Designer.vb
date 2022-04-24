<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form165
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
        Me.GGN_ISLEM = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.GORUNTULE = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.GGN_ISLEM, Me.GORUNTULE})
        Me.DataGridView1.Location = New System.Drawing.Point(-1, 0)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(1106, 608)
        Me.DataGridView1.TabIndex = 0
        '
        'GGN_ISLEM
        '
        Me.GGN_ISLEM.HeaderText = "GIRDI KONTROL"
        Me.GGN_ISLEM.Name = "GGN_ISLEM"
        Me.GGN_ISLEM.Text = "Kontrol"
        Me.GGN_ISLEM.ToolTipText = "Kontrol"
        '
        'GORUNTULE
        '
        Me.GORUNTULE.HeaderText = "GORUNTULE"
        Me.GORUNTULE.Name = "GORUNTULE"
        Me.GORUNTULE.Text = "İzle"
        Me.GORUNTULE.ToolTipText = "İzle"
        '
        'Timer1
        '
        Me.Timer1.Interval = 60000
        '
        'Form165
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1106, 607)
        Me.Controls.Add(Me.DataGridView1)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "Form165"
        Me.Text = "ALANSIS MEYVE ALIM KONTROL ISLEM MODULU"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents FormAssistant1 As DevExpress.XtraBars.FormAssistant
    Friend WithEvents DefaultLookAndFeel1 As DevExpress.LookAndFeel.DefaultLookAndFeel
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Timer1 As Timer
    Friend WithEvents GGN_ISLEM As DataGridViewButtonColumn
    Friend WithEvents GORUNTULE As DataGridViewButtonColumn
End Class
