<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form223
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
        Dim SelectQuery4 As DevExpress.DataAccess.Sql.SelectQuery = New DevExpress.DataAccess.Sql.SelectQuery()
        Dim AllColumns4 As DevExpress.DataAccess.Sql.AllColumns = New DevExpress.DataAccess.Sql.AllColumns()
        Dim Table4 As DevExpress.DataAccess.Sql.Table = New DevExpress.DataAccess.Sql.Table()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form223))
        Dim DataSourceColumnBinding46 As DevExpress.XtraPivotGrid.DataSourceColumnBinding = New DevExpress.XtraPivotGrid.DataSourceColumnBinding()
        Dim DataSourceColumnBinding47 As DevExpress.XtraPivotGrid.DataSourceColumnBinding = New DevExpress.XtraPivotGrid.DataSourceColumnBinding()
        Dim DataSourceColumnBinding48 As DevExpress.XtraPivotGrid.DataSourceColumnBinding = New DevExpress.XtraPivotGrid.DataSourceColumnBinding()
        Dim DataSourceColumnBinding49 As DevExpress.XtraPivotGrid.DataSourceColumnBinding = New DevExpress.XtraPivotGrid.DataSourceColumnBinding()
        Dim DataSourceColumnBinding50 As DevExpress.XtraPivotGrid.DataSourceColumnBinding = New DevExpress.XtraPivotGrid.DataSourceColumnBinding()
        Dim DataSourceColumnBinding51 As DevExpress.XtraPivotGrid.DataSourceColumnBinding = New DevExpress.XtraPivotGrid.DataSourceColumnBinding()
        Dim DataSourceColumnBinding52 As DevExpress.XtraPivotGrid.DataSourceColumnBinding = New DevExpress.XtraPivotGrid.DataSourceColumnBinding()
        Dim DataSourceColumnBinding53 As DevExpress.XtraPivotGrid.DataSourceColumnBinding = New DevExpress.XtraPivotGrid.DataSourceColumnBinding()
        Dim DataSourceColumnBinding54 As DevExpress.XtraPivotGrid.DataSourceColumnBinding = New DevExpress.XtraPivotGrid.DataSourceColumnBinding()
        Dim DataSourceColumnBinding55 As DevExpress.XtraPivotGrid.DataSourceColumnBinding = New DevExpress.XtraPivotGrid.DataSourceColumnBinding()
        Dim DataSourceColumnBinding56 As DevExpress.XtraPivotGrid.DataSourceColumnBinding = New DevExpress.XtraPivotGrid.DataSourceColumnBinding()
        Dim DataSourceColumnBinding57 As DevExpress.XtraPivotGrid.DataSourceColumnBinding = New DevExpress.XtraPivotGrid.DataSourceColumnBinding()
        Dim DataSourceColumnBinding58 As DevExpress.XtraPivotGrid.DataSourceColumnBinding = New DevExpress.XtraPivotGrid.DataSourceColumnBinding()
        Dim DataSourceColumnBinding59 As DevExpress.XtraPivotGrid.DataSourceColumnBinding = New DevExpress.XtraPivotGrid.DataSourceColumnBinding()
        Dim DataSourceColumnBinding60 As DevExpress.XtraPivotGrid.DataSourceColumnBinding = New DevExpress.XtraPivotGrid.DataSourceColumnBinding()
        Me.PivotGridControl1 = New DevExpress.XtraPivotGrid.PivotGridControl()
        Me.FormAssistant1 = New DevExpress.XtraBars.FormAssistant()
        Me.DefaultLookAndFeel1 = New DevExpress.LookAndFeel.DefaultLookAndFeel(Me.components)
        Me.PivotGridControl2 = New DevExpress.XtraPivotGrid.PivotGridControl()
        Me.SqlDataSource1 = New DevExpress.DataAccess.Sql.SqlDataSource(Me.components)
        Me.fieldMEYVEALIMTARIH = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldBOLGE = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldURUNCESIDI = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldURETICITC = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldURETICIADSOY = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldKASASAYI = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldKASABRUT = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldKASANET = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldFIYAT = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldHAMMADDEKABULTARIH = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldYUKLENENPARTI = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldYUKLEMETARIH = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldPALETBRUT = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldPALETNET = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldRENK = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.SimpleButton2 = New DevExpress.XtraEditors.SimpleButton()
        CType(Me.PivotGridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PivotGridControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PivotGridControl1
        '
        Me.PivotGridControl1.DataMember = "EO_PTEST1"
        Me.PivotGridControl1.Location = New System.Drawing.Point(1, 2)
        Me.PivotGridControl1.Name = "PivotGridControl1"
        Me.PivotGridControl1.OptionsData.DataProcessingEngine = DevExpress.XtraPivotGrid.PivotDataProcessingEngine.Optimized
        Me.PivotGridControl1.Size = New System.Drawing.Size(1169, 595)
        Me.PivotGridControl1.TabIndex = 0
        '
        'DefaultLookAndFeel1
        '
        Me.DefaultLookAndFeel1.LookAndFeel.SkinName = "Office 2007 Blue"
        '
        'PivotGridControl2
        '
        Me.PivotGridControl2.DataMember = "EO_PTEST4"
        Me.PivotGridControl2.DataSource = Me.SqlDataSource1
        Me.PivotGridControl2.Fields.AddRange(New DevExpress.XtraPivotGrid.PivotGridField() {Me.fieldMEYVEALIMTARIH, Me.fieldBOLGE, Me.fieldURUNCESIDI, Me.fieldURETICITC, Me.fieldURETICIADSOY, Me.fieldKASASAYI, Me.fieldKASABRUT, Me.fieldKASANET, Me.fieldFIYAT, Me.fieldHAMMADDEKABULTARIH, Me.fieldYUKLENENPARTI, Me.fieldYUKLEMETARIH, Me.fieldPALETBRUT, Me.fieldPALETNET, Me.fieldRENK})
        Me.PivotGridControl2.Location = New System.Drawing.Point(0, 55)
        Me.PivotGridControl2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.PivotGridControl2.Name = "PivotGridControl2"
        Me.PivotGridControl2.OptionsData.DataProcessingEngine = DevExpress.XtraPivotGrid.PivotDataProcessingEngine.Optimized
        Me.PivotGridControl2.OptionsDataField.RowHeaderWidth = 117
        Me.PivotGridControl2.OptionsView.RowTreeOffset = 24
        Me.PivotGridControl2.OptionsView.RowTreeWidth = 117
        Me.PivotGridControl2.Size = New System.Drawing.Size(1532, 666)
        Me.PivotGridControl2.TabIndex = 0
        '
        'SqlDataSource1
        '
        Me.SqlDataSource1.ConnectionName = "WindowsApplication1.My.MySettings.ALANSISConnectionString"
        Me.SqlDataSource1.Name = "SqlDataSource1"
        Table4.MetaSerializable = "<Meta X=""30"" Y=""30"" Width=""125"" Height=""363"" />"
        Table4.Name = "EO_PTEST4"
        AllColumns4.Table = Table4
        SelectQuery4.Columns.Add(AllColumns4)
        SelectQuery4.Name = "EO_PTEST4"
        SelectQuery4.Tables.Add(Table4)
        Me.SqlDataSource1.Queries.AddRange(New DevExpress.DataAccess.Sql.SqlQuery() {SelectQuery4})
        Me.SqlDataSource1.ResultSchemaSerializable = resources.GetString("SqlDataSource1.ResultSchemaSerializable")
        '
        'fieldMEYVEALIMTARIH
        '
        Me.fieldMEYVEALIMTARIH.AreaIndex = 0
        Me.fieldMEYVEALIMTARIH.Caption = "MEYVE_ALIM_TARIH"
        DataSourceColumnBinding46.ColumnName = "MEYVE_ALIM_TARIH"
        Me.fieldMEYVEALIMTARIH.DataBinding = DataSourceColumnBinding46
        Me.fieldMEYVEALIMTARIH.MinWidth = 23
        Me.fieldMEYVEALIMTARIH.Name = "fieldMEYVEALIMTARIH"
        Me.fieldMEYVEALIMTARIH.Width = 117
        '
        'fieldBOLGE
        '
        Me.fieldBOLGE.AreaIndex = 1
        Me.fieldBOLGE.Caption = "BOLGE"
        DataSourceColumnBinding47.ColumnName = "BOLGE"
        Me.fieldBOLGE.DataBinding = DataSourceColumnBinding47
        Me.fieldBOLGE.MinWidth = 23
        Me.fieldBOLGE.Name = "fieldBOLGE"
        Me.fieldBOLGE.Width = 117
        '
        'fieldURUNCESIDI
        '
        Me.fieldURUNCESIDI.AreaIndex = 2
        Me.fieldURUNCESIDI.Caption = "URUN_CESIDI"
        DataSourceColumnBinding48.ColumnName = "URUN_CESIDI"
        Me.fieldURUNCESIDI.DataBinding = DataSourceColumnBinding48
        Me.fieldURUNCESIDI.MinWidth = 23
        Me.fieldURUNCESIDI.Name = "fieldURUNCESIDI"
        Me.fieldURUNCESIDI.Width = 117
        '
        'fieldURETICITC
        '
        Me.fieldURETICITC.AreaIndex = 3
        Me.fieldURETICITC.Caption = "URETICI_TC"
        DataSourceColumnBinding49.ColumnName = "URETICI_TC"
        Me.fieldURETICITC.DataBinding = DataSourceColumnBinding49
        Me.fieldURETICITC.MinWidth = 23
        Me.fieldURETICITC.Name = "fieldURETICITC"
        Me.fieldURETICITC.Width = 117
        '
        'fieldURETICIADSOY
        '
        Me.fieldURETICIADSOY.AreaIndex = 4
        Me.fieldURETICIADSOY.Caption = "URETICI_ADSOY"
        DataSourceColumnBinding50.ColumnName = "URETICI_ADSOY"
        Me.fieldURETICIADSOY.DataBinding = DataSourceColumnBinding50
        Me.fieldURETICIADSOY.MinWidth = 23
        Me.fieldURETICIADSOY.Name = "fieldURETICIADSOY"
        Me.fieldURETICIADSOY.Width = 117
        '
        'fieldKASASAYI
        '
        Me.fieldKASASAYI.AreaIndex = 5
        Me.fieldKASASAYI.Caption = "KASA_SAYI"
        DataSourceColumnBinding51.ColumnName = "KASA_SAYI"
        Me.fieldKASASAYI.DataBinding = DataSourceColumnBinding51
        Me.fieldKASASAYI.MinWidth = 23
        Me.fieldKASASAYI.Name = "fieldKASASAYI"
        Me.fieldKASASAYI.Width = 117
        '
        'fieldKASABRUT
        '
        Me.fieldKASABRUT.AreaIndex = 6
        Me.fieldKASABRUT.Caption = "KASA_BRUT"
        DataSourceColumnBinding52.ColumnName = "KASA_BRUT"
        Me.fieldKASABRUT.DataBinding = DataSourceColumnBinding52
        Me.fieldKASABRUT.MinWidth = 23
        Me.fieldKASABRUT.Name = "fieldKASABRUT"
        Me.fieldKASABRUT.Width = 117
        '
        'fieldKASANET
        '
        Me.fieldKASANET.AreaIndex = 7
        Me.fieldKASANET.Caption = "KASA_NET"
        DataSourceColumnBinding53.ColumnName = "KASA_NET"
        Me.fieldKASANET.DataBinding = DataSourceColumnBinding53
        Me.fieldKASANET.MinWidth = 23
        Me.fieldKASANET.Name = "fieldKASANET"
        Me.fieldKASANET.Width = 117
        '
        'fieldFIYAT
        '
        Me.fieldFIYAT.AreaIndex = 8
        Me.fieldFIYAT.Caption = "FIYAT"
        DataSourceColumnBinding54.ColumnName = "FIYAT"
        Me.fieldFIYAT.DataBinding = DataSourceColumnBinding54
        Me.fieldFIYAT.MinWidth = 23
        Me.fieldFIYAT.Name = "fieldFIYAT"
        Me.fieldFIYAT.Width = 117
        '
        'fieldHAMMADDEKABULTARIH
        '
        Me.fieldHAMMADDEKABULTARIH.AreaIndex = 9
        Me.fieldHAMMADDEKABULTARIH.Caption = "HAMMADDE_KABUL_TARIH"
        DataSourceColumnBinding55.ColumnName = "HAMMADDE_KABUL_TARIH"
        Me.fieldHAMMADDEKABULTARIH.DataBinding = DataSourceColumnBinding55
        Me.fieldHAMMADDEKABULTARIH.MinWidth = 23
        Me.fieldHAMMADDEKABULTARIH.Name = "fieldHAMMADDEKABULTARIH"
        Me.fieldHAMMADDEKABULTARIH.Width = 117
        '
        'fieldYUKLENENPARTI
        '
        Me.fieldYUKLENENPARTI.AreaIndex = 10
        Me.fieldYUKLENENPARTI.Caption = "YUKLENEN_PARTI"
        DataSourceColumnBinding56.ColumnName = "YUKLENEN_PARTI"
        Me.fieldYUKLENENPARTI.DataBinding = DataSourceColumnBinding56
        Me.fieldYUKLENENPARTI.MinWidth = 23
        Me.fieldYUKLENENPARTI.Name = "fieldYUKLENENPARTI"
        Me.fieldYUKLENENPARTI.Width = 117
        '
        'fieldYUKLEMETARIH
        '
        Me.fieldYUKLEMETARIH.AreaIndex = 11
        Me.fieldYUKLEMETARIH.Caption = "YUKLEME_TARIH"
        DataSourceColumnBinding57.ColumnName = "YUKLEME_TARIH"
        Me.fieldYUKLEMETARIH.DataBinding = DataSourceColumnBinding57
        Me.fieldYUKLEMETARIH.MinWidth = 23
        Me.fieldYUKLEMETARIH.Name = "fieldYUKLEMETARIH"
        Me.fieldYUKLEMETARIH.Width = 117
        '
        'fieldPALETBRUT
        '
        Me.fieldPALETBRUT.AreaIndex = 12
        Me.fieldPALETBRUT.Caption = "PALET_BRUT"
        DataSourceColumnBinding58.ColumnName = "PALET_BRUT"
        Me.fieldPALETBRUT.DataBinding = DataSourceColumnBinding58
        Me.fieldPALETBRUT.MinWidth = 23
        Me.fieldPALETBRUT.Name = "fieldPALETBRUT"
        Me.fieldPALETBRUT.Width = 117
        '
        'fieldPALETNET
        '
        Me.fieldPALETNET.AreaIndex = 13
        Me.fieldPALETNET.Caption = "PALET_NET"
        DataSourceColumnBinding59.ColumnName = "PALET_NET"
        Me.fieldPALETNET.DataBinding = DataSourceColumnBinding59
        Me.fieldPALETNET.MinWidth = 23
        Me.fieldPALETNET.Name = "fieldPALETNET"
        Me.fieldPALETNET.Width = 117
        '
        'fieldRENK
        '
        Me.fieldRENK.AreaIndex = 14
        Me.fieldRENK.Caption = "RENK"
        DataSourceColumnBinding60.ColumnName = "RENK"
        Me.fieldRENK.DataBinding = DataSourceColumnBinding60
        Me.fieldRENK.MinWidth = 23
        Me.fieldRENK.Name = "fieldRENK"
        Me.fieldRENK.Width = 117
        '
        'SimpleButton2
        '
        Me.SimpleButton2.ImageOptions.Image = CType(resources.GetObject("SimpleButton2.ImageOptions.Image"), System.Drawing.Image)
        Me.SimpleButton2.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.SimpleButton2.Location = New System.Drawing.Point(0, 9)
        Me.SimpleButton2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.SimpleButton2.Name = "SimpleButton2"
        Me.SimpleButton2.Size = New System.Drawing.Size(43, 39)
        Me.SimpleButton2.TabIndex = 20
        '
        'Form223
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1560, 721)
        Me.Controls.Add(Me.SimpleButton2)
        Me.Controls.Add(Me.PivotGridControl2)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "Form223"
        Me.Text = "Form223"
        CType(Me.PivotGridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PivotGridControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Private WithEvents PivotGridControl1 As DevExpress.XtraPivotGrid.PivotGridControl
    Private WithEvents FormAssistant1 As DevExpress.XtraBars.FormAssistant
    Private WithEvents DefaultLookAndFeel1 As DevExpress.LookAndFeel.DefaultLookAndFeel
    Friend WithEvents PivotGridControl2 As DevExpress.XtraPivotGrid.PivotGridControl
    Friend WithEvents SqlDataSource1 As DevExpress.DataAccess.Sql.SqlDataSource
    Friend WithEvents fieldMEYVEALIMTARIH As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldBOLGE As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldURUNCESIDI As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldURETICITC As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldURETICIADSOY As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldKASASAYI As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldKASABRUT As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldKASANET As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldFIYAT As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldHAMMADDEKABULTARIH As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldYUKLENENPARTI As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldYUKLEMETARIH As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldPALETBRUT As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldPALETNET As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldRENK As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents SimpleButton2 As DevExpress.XtraEditors.SimpleButton
End Class
