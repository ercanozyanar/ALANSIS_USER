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
        Dim SelectQuery2 As DevExpress.DataAccess.Sql.SelectQuery = New DevExpress.DataAccess.Sql.SelectQuery()
        Dim AllColumns2 As DevExpress.DataAccess.Sql.AllColumns = New DevExpress.DataAccess.Sql.AllColumns()
        Dim Table2 As DevExpress.DataAccess.Sql.Table = New DevExpress.DataAccess.Sql.Table()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form223))
        Dim DataSourceColumnBinding16 As DevExpress.XtraPivotGrid.DataSourceColumnBinding = New DevExpress.XtraPivotGrid.DataSourceColumnBinding()
        Dim DataSourceColumnBinding17 As DevExpress.XtraPivotGrid.DataSourceColumnBinding = New DevExpress.XtraPivotGrid.DataSourceColumnBinding()
        Dim DataSourceColumnBinding18 As DevExpress.XtraPivotGrid.DataSourceColumnBinding = New DevExpress.XtraPivotGrid.DataSourceColumnBinding()
        Dim DataSourceColumnBinding19 As DevExpress.XtraPivotGrid.DataSourceColumnBinding = New DevExpress.XtraPivotGrid.DataSourceColumnBinding()
        Dim DataSourceColumnBinding20 As DevExpress.XtraPivotGrid.DataSourceColumnBinding = New DevExpress.XtraPivotGrid.DataSourceColumnBinding()
        Dim DataSourceColumnBinding21 As DevExpress.XtraPivotGrid.DataSourceColumnBinding = New DevExpress.XtraPivotGrid.DataSourceColumnBinding()
        Dim DataSourceColumnBinding22 As DevExpress.XtraPivotGrid.DataSourceColumnBinding = New DevExpress.XtraPivotGrid.DataSourceColumnBinding()
        Dim DataSourceColumnBinding23 As DevExpress.XtraPivotGrid.DataSourceColumnBinding = New DevExpress.XtraPivotGrid.DataSourceColumnBinding()
        Dim DataSourceColumnBinding24 As DevExpress.XtraPivotGrid.DataSourceColumnBinding = New DevExpress.XtraPivotGrid.DataSourceColumnBinding()
        Dim DataSourceColumnBinding25 As DevExpress.XtraPivotGrid.DataSourceColumnBinding = New DevExpress.XtraPivotGrid.DataSourceColumnBinding()
        Dim DataSourceColumnBinding26 As DevExpress.XtraPivotGrid.DataSourceColumnBinding = New DevExpress.XtraPivotGrid.DataSourceColumnBinding()
        Dim DataSourceColumnBinding27 As DevExpress.XtraPivotGrid.DataSourceColumnBinding = New DevExpress.XtraPivotGrid.DataSourceColumnBinding()
        Dim DataSourceColumnBinding28 As DevExpress.XtraPivotGrid.DataSourceColumnBinding = New DevExpress.XtraPivotGrid.DataSourceColumnBinding()
        Dim DataSourceColumnBinding29 As DevExpress.XtraPivotGrid.DataSourceColumnBinding = New DevExpress.XtraPivotGrid.DataSourceColumnBinding()
        Dim DataSourceColumnBinding30 As DevExpress.XtraPivotGrid.DataSourceColumnBinding = New DevExpress.XtraPivotGrid.DataSourceColumnBinding()
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
        Me.PivotGridControl2.Location = New System.Drawing.Point(0, 45)
        Me.PivotGridControl2.Name = "PivotGridControl2"
        Me.PivotGridControl2.OptionsData.DataProcessingEngine = DevExpress.XtraPivotGrid.PivotDataProcessingEngine.Optimized
        Me.PivotGridControl2.Size = New System.Drawing.Size(1313, 541)
        Me.PivotGridControl2.TabIndex = 0
        '
        'SqlDataSource1
        '
        Me.SqlDataSource1.ConnectionName = "WindowsApplication1.My.MySettings.ALANSISConnectionString"
        Me.SqlDataSource1.Name = "SqlDataSource1"
        Table2.MetaSerializable = "<Meta X=""30"" Y=""30"" Width=""125"" Height=""363"" />"
        Table2.Name = "EO_PTEST4"
        AllColumns2.Table = Table2
        SelectQuery2.Columns.Add(AllColumns2)
        SelectQuery2.Name = "EO_PTEST4"
        SelectQuery2.Tables.Add(Table2)
        Me.SqlDataSource1.Queries.AddRange(New DevExpress.DataAccess.Sql.SqlQuery() {SelectQuery2})
        Me.SqlDataSource1.ResultSchemaSerializable = resources.GetString("SqlDataSource1.ResultSchemaSerializable")
        '
        'fieldMEYVEALIMTARIH
        '
        Me.fieldMEYVEALIMTARIH.AreaIndex = 0
        Me.fieldMEYVEALIMTARIH.Caption = "MEYVE_ALIM_TARIH"
        DataSourceColumnBinding16.ColumnName = "MEYVE_ALIM_TARIH"
        Me.fieldMEYVEALIMTARIH.DataBinding = DataSourceColumnBinding16
        Me.fieldMEYVEALIMTARIH.Name = "fieldMEYVEALIMTARIH"
        '
        'fieldBOLGE
        '
        Me.fieldBOLGE.AreaIndex = 1
        Me.fieldBOLGE.Caption = "BOLGE"
        DataSourceColumnBinding17.ColumnName = "BOLGE"
        Me.fieldBOLGE.DataBinding = DataSourceColumnBinding17
        Me.fieldBOLGE.Name = "fieldBOLGE"
        '
        'fieldURUNCESIDI
        '
        Me.fieldURUNCESIDI.AreaIndex = 2
        Me.fieldURUNCESIDI.Caption = "URUN_CESIDI"
        DataSourceColumnBinding18.ColumnName = "URUN_CESIDI"
        Me.fieldURUNCESIDI.DataBinding = DataSourceColumnBinding18
        Me.fieldURUNCESIDI.Name = "fieldURUNCESIDI"
        '
        'fieldURETICITC
        '
        Me.fieldURETICITC.AreaIndex = 3
        Me.fieldURETICITC.Caption = "URETICI_TC"
        DataSourceColumnBinding19.ColumnName = "URETICI_TC"
        Me.fieldURETICITC.DataBinding = DataSourceColumnBinding19
        Me.fieldURETICITC.Name = "fieldURETICITC"
        '
        'fieldURETICIADSOY
        '
        Me.fieldURETICIADSOY.AreaIndex = 4
        Me.fieldURETICIADSOY.Caption = "URETICI_ADSOY"
        DataSourceColumnBinding20.ColumnName = "URETICI_ADSOY"
        Me.fieldURETICIADSOY.DataBinding = DataSourceColumnBinding20
        Me.fieldURETICIADSOY.Name = "fieldURETICIADSOY"
        '
        'fieldKASASAYI
        '
        Me.fieldKASASAYI.AreaIndex = 5
        Me.fieldKASASAYI.Caption = "KASA_SAYI"
        DataSourceColumnBinding21.ColumnName = "KASA_SAYI"
        Me.fieldKASASAYI.DataBinding = DataSourceColumnBinding21
        Me.fieldKASASAYI.Name = "fieldKASASAYI"
        '
        'fieldKASABRUT
        '
        Me.fieldKASABRUT.AreaIndex = 6
        Me.fieldKASABRUT.Caption = "KASA_BRUT"
        DataSourceColumnBinding22.ColumnName = "KASA_BRUT"
        Me.fieldKASABRUT.DataBinding = DataSourceColumnBinding22
        Me.fieldKASABRUT.Name = "fieldKASABRUT"
        '
        'fieldKASANET
        '
        Me.fieldKASANET.AreaIndex = 7
        Me.fieldKASANET.Caption = "KASA_NET"
        DataSourceColumnBinding23.ColumnName = "KASA_NET"
        Me.fieldKASANET.DataBinding = DataSourceColumnBinding23
        Me.fieldKASANET.Name = "fieldKASANET"
        '
        'fieldFIYAT
        '
        Me.fieldFIYAT.AreaIndex = 8
        Me.fieldFIYAT.Caption = "FIYAT"
        DataSourceColumnBinding24.ColumnName = "FIYAT"
        Me.fieldFIYAT.DataBinding = DataSourceColumnBinding24
        Me.fieldFIYAT.Name = "fieldFIYAT"
        '
        'fieldHAMMADDEKABULTARIH
        '
        Me.fieldHAMMADDEKABULTARIH.AreaIndex = 9
        Me.fieldHAMMADDEKABULTARIH.Caption = "HAMMADDE_KABUL_TARIH"
        DataSourceColumnBinding25.ColumnName = "HAMMADDE_KABUL_TARIH"
        Me.fieldHAMMADDEKABULTARIH.DataBinding = DataSourceColumnBinding25
        Me.fieldHAMMADDEKABULTARIH.Name = "fieldHAMMADDEKABULTARIH"
        '
        'fieldYUKLENENPARTI
        '
        Me.fieldYUKLENENPARTI.AreaIndex = 10
        Me.fieldYUKLENENPARTI.Caption = "YUKLENEN_PARTI"
        DataSourceColumnBinding26.ColumnName = "YUKLENEN_PARTI"
        Me.fieldYUKLENENPARTI.DataBinding = DataSourceColumnBinding26
        Me.fieldYUKLENENPARTI.Name = "fieldYUKLENENPARTI"
        '
        'fieldYUKLEMETARIH
        '
        Me.fieldYUKLEMETARIH.AreaIndex = 11
        Me.fieldYUKLEMETARIH.Caption = "YUKLEME_TARIH"
        DataSourceColumnBinding27.ColumnName = "YUKLEME_TARIH"
        Me.fieldYUKLEMETARIH.DataBinding = DataSourceColumnBinding27
        Me.fieldYUKLEMETARIH.Name = "fieldYUKLEMETARIH"
        '
        'fieldPALETBRUT
        '
        Me.fieldPALETBRUT.AreaIndex = 12
        Me.fieldPALETBRUT.Caption = "PALET_BRUT"
        DataSourceColumnBinding28.ColumnName = "PALET_BRUT"
        Me.fieldPALETBRUT.DataBinding = DataSourceColumnBinding28
        Me.fieldPALETBRUT.Name = "fieldPALETBRUT"
        '
        'fieldPALETNET
        '
        Me.fieldPALETNET.AreaIndex = 13
        Me.fieldPALETNET.Caption = "PALET_NET"
        DataSourceColumnBinding29.ColumnName = "PALET_NET"
        Me.fieldPALETNET.DataBinding = DataSourceColumnBinding29
        Me.fieldPALETNET.Name = "fieldPALETNET"
        '
        'fieldRENK
        '
        Me.fieldRENK.AreaIndex = 14
        Me.fieldRENK.Caption = "RENK"
        DataSourceColumnBinding30.ColumnName = "RENK"
        Me.fieldRENK.DataBinding = DataSourceColumnBinding30
        Me.fieldRENK.Name = "fieldRENK"
        '
        'SimpleButton2
        '
        Me.SimpleButton2.ImageOptions.Image = CType(resources.GetObject("SimpleButton2.ImageOptions.Image"), System.Drawing.Image)
        Me.SimpleButton2.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.SimpleButton2.Location = New System.Drawing.Point(0, 7)
        Me.SimpleButton2.Name = "SimpleButton2"
        Me.SimpleButton2.Size = New System.Drawing.Size(37, 32)
        Me.SimpleButton2.TabIndex = 20
        '
        'Form223
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1337, 586)
        Me.Controls.Add(Me.SimpleButton2)
        Me.Controls.Add(Me.PivotGridControl2)
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
