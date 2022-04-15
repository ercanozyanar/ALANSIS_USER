<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form30
    Inherits System.Windows.Forms.Form

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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form30))
        Me.DashboardDesigner1 = New DevExpress.DashboardWin.DashboardDesigner()
        Me.DashboardBarAndDockingController1 = New DevExpress.DashboardWin.Native.DashboardBarAndDockingController(Me.components)
        Me.DashboardPopupMenu1 = New DevExpress.DashboardWin.DashboardPopupMenu(Me.components)
        Me.DashboardBackstageViewControl1 = New DevExpress.DashboardWin.Bars.DashboardBackstageViewControl()
        Me.BackstageViewClientControl1 = New DevExpress.XtraBars.Ribbon.BackstageViewClientControl()
        Me.RecentDashboardsControl1 = New DevExpress.DashboardWin.Bars.RecentDashboardsControl()
        Me.DashboardBackstageRecentTab1 = New DevExpress.DashboardWin.Bars.DashboardBackstageRecentTab()
        Me.DashboardBarController1 = New DevExpress.DashboardWin.Bars.DashboardBarController(Me.components)
        Me.TextBoxEditorBarController1 = New DevExpress.DashboardWin.Bars.TextBoxEditorBarController(Me.components)
        Me.DashboardBackstageNewButton1 = New DevExpress.DashboardWin.Bars.DashboardBackstageNewButton()
        Me.DashboardBackstageOpenButton1 = New DevExpress.DashboardWin.Bars.DashboardBackstageOpenButton()
        Me.DashboardBackstageSaveButton1 = New DevExpress.DashboardWin.Bars.DashboardBackstageSaveButton()
        Me.DashboardBackstageSaveAsButton1 = New DevExpress.DashboardWin.Bars.DashboardBackstageSaveAsButton()
        CType(Me.DashboardDesigner1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DashboardBarAndDockingController1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DashboardPopupMenu1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DashboardBackstageViewControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.DashboardBackstageViewControl1.SuspendLayout()
        Me.BackstageViewClientControl1.SuspendLayout()
        CType(Me.DashboardBarController1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBoxEditorBarController1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DashboardDesigner1
        '
        Me.DashboardDesigner1.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(227, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DashboardDesigner1.Appearance.Options.UseBackColor = True
        Me.DashboardDesigner1.AsyncMode = True
        Me.DashboardDesigner1.BarAndDockingController = Me.DashboardBarAndDockingController1
        Me.DashboardDesigner1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DashboardDesigner1.Location = New System.Drawing.Point(0, 0)
        Me.DashboardDesigner1.Name = "DashboardDesigner1"
        Me.DashboardDesigner1.PopupMenu = Me.DashboardPopupMenu1
        Me.DashboardDesigner1.Size = New System.Drawing.Size(1369, 753)
        Me.DashboardDesigner1.TabIndex = 0
        '
        'DashboardBarAndDockingController1
        '
        Me.DashboardBarAndDockingController1.PropertiesBar.AllowLinkLighting = False
        '
        'DashboardPopupMenu1
        '
        Me.DashboardPopupMenu1.Name = "DashboardPopupMenu1"
        '
        'DashboardBackstageViewControl1
        '
        Me.DashboardBackstageViewControl1.Controller = Me.DashboardBarAndDockingController1
        Me.DashboardBackstageViewControl1.Controls.Add(Me.BackstageViewClientControl1)
        Me.DashboardBackstageViewControl1.DashboardRecentTab = Me.DashboardBackstageRecentTab1
        Me.DashboardBackstageViewControl1.Items.Add(Me.DashboardBackstageNewButton1)
        Me.DashboardBackstageViewControl1.Items.Add(Me.DashboardBackstageOpenButton1)
        Me.DashboardBackstageViewControl1.Items.Add(Me.DashboardBackstageSaveButton1)
        Me.DashboardBackstageViewControl1.Items.Add(Me.DashboardBackstageSaveAsButton1)
        Me.DashboardBackstageViewControl1.Items.Add(Me.DashboardBackstageRecentTab1)
        Me.DashboardBackstageViewControl1.Location = New System.Drawing.Point(0, 0)
        Me.DashboardBackstageViewControl1.Name = "DashboardBackstageViewControl1"
        Me.DashboardBackstageViewControl1.SelectedTab = Me.DashboardBackstageRecentTab1
        Me.DashboardBackstageViewControl1.SelectedTabIndex = 4
        Me.DashboardBackstageViewControl1.Size = New System.Drawing.Size(240, 150)
        Me.DashboardBackstageViewControl1.TabIndex = 2
        Me.DashboardBackstageViewControl1.VisibleInDesignTime = True
        '
        'BackstageViewClientControl1
        '
        Me.BackstageViewClientControl1.Controls.Add(Me.RecentDashboardsControl1)
        Me.BackstageViewClientControl1.Location = New System.Drawing.Point(0, 0)
        Me.BackstageViewClientControl1.Name = "BackstageViewClientControl1"
        Me.BackstageViewClientControl1.Size = New System.Drawing.Size(0, 0)
        Me.BackstageViewClientControl1.TabIndex = 1
        '
        'RecentDashboardsControl1
        '
        Me.RecentDashboardsControl1.Appearance.ForeColor = System.Drawing.Color.Transparent
        Me.RecentDashboardsControl1.Appearance.Options.UseForeColor = True
        Me.RecentDashboardsControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RecentDashboardsControl1.Location = New System.Drawing.Point(0, 0)
        Me.RecentDashboardsControl1.Name = "RecentDashboardsControl1"
        Me.RecentDashboardsControl1.ServiceProvider = Me.DashboardDesigner1
        Me.RecentDashboardsControl1.Size = New System.Drawing.Size(0, 0)
        Me.RecentDashboardsControl1.TabIndex = 0
        '
        'DashboardBackstageRecentTab1
        '
        Me.DashboardBackstageRecentTab1.ContentControl = Me.BackstageViewClientControl1
        Me.DashboardBackstageRecentTab1.Name = "DashboardBackstageRecentTab1"
        Me.DashboardBackstageRecentTab1.RecentDashboardsControl = Me.RecentDashboardsControl1
        Me.DashboardBackstageRecentTab1.Selected = True
        '
        'DashboardBarController1
        '
        Me.DashboardBarController1.Control = Me.DashboardDesigner1
        '
        'TextBoxEditorBarController1
        '
        Me.TextBoxEditorBarController1.Designer = Me.DashboardDesigner1
        '
        'DashboardBackstageNewButton1
        '
        Me.DashboardBackstageNewButton1.ImageOptions.ItemNormal.Image = CType(resources.GetObject("DashboardBackstageNewButton1.ImageOptions.ItemNormal.Image"), System.Drawing.Image)
        Me.DashboardBackstageNewButton1.ImageOptions.ItemNormal.SvgImage = CType(resources.GetObject("DashboardBackstageNewButton1.ImageOptions.ItemNormal.SvgImage"), DevExpress.Utils.Svg.SvgImage)
        Me.DashboardBackstageNewButton1.ImageOptions.ItemNormal.SvgImageSize = New System.Drawing.Size(16, 16)
        Me.DashboardBackstageNewButton1.Name = "DashboardBackstageNewButton1"
        Me.DashboardBackstageNewButton1.ServiceProvider = Me.DashboardDesigner1
        '
        'DashboardBackstageOpenButton1
        '
        Me.DashboardBackstageOpenButton1.ImageOptions.ItemNormal.Image = CType(resources.GetObject("DashboardBackstageOpenButton1.ImageOptions.ItemNormal.Image"), System.Drawing.Image)
        Me.DashboardBackstageOpenButton1.ImageOptions.ItemNormal.SvgImage = CType(resources.GetObject("DashboardBackstageOpenButton1.ImageOptions.ItemNormal.SvgImage"), DevExpress.Utils.Svg.SvgImage)
        Me.DashboardBackstageOpenButton1.ImageOptions.ItemNormal.SvgImageSize = New System.Drawing.Size(16, 16)
        Me.DashboardBackstageOpenButton1.Name = "DashboardBackstageOpenButton1"
        Me.DashboardBackstageOpenButton1.ServiceProvider = Me.DashboardDesigner1
        '
        'DashboardBackstageSaveButton1
        '
        Me.DashboardBackstageSaveButton1.ImageOptions.ItemNormal.Image = CType(resources.GetObject("DashboardBackstageSaveButton1.ImageOptions.ItemNormal.Image"), System.Drawing.Image)
        Me.DashboardBackstageSaveButton1.ImageOptions.ItemNormal.SvgImage = CType(resources.GetObject("DashboardBackstageSaveButton1.ImageOptions.ItemNormal.SvgImage"), DevExpress.Utils.Svg.SvgImage)
        Me.DashboardBackstageSaveButton1.ImageOptions.ItemNormal.SvgImageSize = New System.Drawing.Size(16, 16)
        Me.DashboardBackstageSaveButton1.Name = "DashboardBackstageSaveButton1"
        Me.DashboardBackstageSaveButton1.ServiceProvider = Me.DashboardDesigner1
        '
        'DashboardBackstageSaveAsButton1
        '
        Me.DashboardBackstageSaveAsButton1.ImageOptions.ItemNormal.Image = CType(resources.GetObject("DashboardBackstageSaveAsButton1.ImageOptions.ItemNormal.Image"), System.Drawing.Image)
        Me.DashboardBackstageSaveAsButton1.ImageOptions.ItemNormal.SvgImage = CType(resources.GetObject("DashboardBackstageSaveAsButton1.ImageOptions.ItemNormal.SvgImage"), DevExpress.Utils.Svg.SvgImage)
        Me.DashboardBackstageSaveAsButton1.ImageOptions.ItemNormal.SvgImageSize = New System.Drawing.Size(16, 16)
        Me.DashboardBackstageSaveAsButton1.Name = "DashboardBackstageSaveAsButton1"
        Me.DashboardBackstageSaveAsButton1.ServiceProvider = Me.DashboardDesigner1
        '
        'Form30
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1369, 753)
        Me.Controls.Add(Me.DashboardDesigner1)
        Me.Controls.Add(Me.DashboardBackstageViewControl1)
        Me.Name = "Form30"
        Me.Text = "Form30"
        CType(Me.DashboardDesigner1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DashboardBarAndDockingController1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DashboardPopupMenu1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DashboardBackstageViewControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.DashboardBackstageViewControl1.ResumeLayout(False)
        Me.BackstageViewClientControl1.ResumeLayout(False)
        CType(Me.DashboardBarController1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBoxEditorBarController1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DashboardDesigner1 As DevExpress.DashboardWin.DashboardDesigner
    Friend WithEvents DashboardBarAndDockingController1 As DevExpress.DashboardWin.Native.DashboardBarAndDockingController
    Friend WithEvents DashboardBackstageViewControl1 As DevExpress.DashboardWin.Bars.DashboardBackstageViewControl
    Friend WithEvents BackstageViewClientControl1 As DevExpress.XtraBars.Ribbon.BackstageViewClientControl
    Friend WithEvents RecentDashboardsControl1 As DevExpress.DashboardWin.Bars.RecentDashboardsControl
    Friend WithEvents DashboardBackstageRecentTab1 As DevExpress.DashboardWin.Bars.DashboardBackstageRecentTab
    Friend WithEvents DashboardBackstageNewButton1 As DevExpress.DashboardWin.Bars.DashboardBackstageNewButton
    Friend WithEvents DashboardBackstageOpenButton1 As DevExpress.DashboardWin.Bars.DashboardBackstageOpenButton
    Friend WithEvents DashboardBackstageSaveButton1 As DevExpress.DashboardWin.Bars.DashboardBackstageSaveButton
    Friend WithEvents DashboardBackstageSaveAsButton1 As DevExpress.DashboardWin.Bars.DashboardBackstageSaveAsButton
    Friend WithEvents DashboardPopupMenu1 As DevExpress.DashboardWin.DashboardPopupMenu
    Friend WithEvents DashboardBarController1 As DevExpress.DashboardWin.Bars.DashboardBarController
    Friend WithEvents TextBoxEditorBarController1 As DevExpress.DashboardWin.Bars.TextBoxEditorBarController
End Class
