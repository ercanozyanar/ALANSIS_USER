﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form221
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form221))
        Me.DefaultLookAndFeel1 = New DevExpress.LookAndFeel.DefaultLookAndFeel(Me.components)
        Me.FormAssistant1 = New DevExpress.XtraBars.FormAssistant()
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl()
        Me.EOALANSISERIKURETIMRAPORBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ALANSISDataSet50 = New WindowsApplication1.ALANSISDataSet50()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colSERI = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colBOLGE = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTARIH = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPARTINO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colBRUT = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDARA = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colMIKTAR = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colEBAT = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colISLEM = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSTOK_KODU = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colERIK_ISLEM = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colKALINTI = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTIP = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colURETIM_TIPI = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colACIKLAMA = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colETIKET_TIPI = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colETIKET_MIKTAR = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colNEMBEZI_TIPI = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colNEMBEZI_MIKTAR = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colKARTONKUTU_TIPI = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colKARTONKUTU_MIKTAR = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colKOSEBENT_TIPI = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colKOSEBENT_MIKTAR = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPOSET_TIPI = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPOSET_MIKTAR = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPALET_TIPI = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPALET_MIKTAR = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSAPKA_TIPI = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSAPKA_MIKTAR = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.EO_ALANSIS_ERIKURETIMRAPORTableAdapter = New WindowsApplication1.ALANSISDataSet50TableAdapters.EO_ALANSIS_ERIKURETIMRAPORTableAdapter()
        Me.SimpleButton2 = New DevExpress.XtraEditors.SimpleButton()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EOALANSISERIKURETIMRAPORBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ALANSISDataSet50, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DefaultLookAndFeel1
        '
        Me.DefaultLookAndFeel1.LookAndFeel.SkinName = "Office 2007 Blue"
        '
        'GridControl1
        '
        Me.GridControl1.DataSource = Me.EOALANSISERIKURETIMRAPORBindingSource
        Me.GridControl1.Location = New System.Drawing.Point(3, 41)
        Me.GridControl1.MainView = Me.GridView1
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.Size = New System.Drawing.Size(794, 408)
        Me.GridControl1.TabIndex = 20
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'EOALANSISERIKURETIMRAPORBindingSource
        '
        Me.EOALANSISERIKURETIMRAPORBindingSource.DataMember = "EO_ALANSIS_ERIKURETIMRAPOR"
        Me.EOALANSISERIKURETIMRAPORBindingSource.DataSource = Me.ALANSISDataSet50
        '
        'ALANSISDataSet50
        '
        Me.ALANSISDataSet50.DataSetName = "ALANSISDataSet50"
        Me.ALANSISDataSet50.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colSERI, Me.colBOLGE, Me.colTARIH, Me.colPARTINO, Me.colBRUT, Me.colDARA, Me.colMIKTAR, Me.colEBAT, Me.colISLEM, Me.colSTOK_KODU, Me.colERIK_ISLEM, Me.colKALINTI, Me.colTIP, Me.colURETIM_TIPI, Me.colACIKLAMA, Me.colETIKET_TIPI, Me.colETIKET_MIKTAR, Me.colNEMBEZI_TIPI, Me.colNEMBEZI_MIKTAR, Me.colKARTONKUTU_TIPI, Me.colKARTONKUTU_MIKTAR, Me.colKOSEBENT_TIPI, Me.colKOSEBENT_MIKTAR, Me.colPOSET_TIPI, Me.colPOSET_MIKTAR, Me.colPALET_TIPI, Me.colPALET_MIKTAR, Me.colSAPKA_TIPI, Me.colSAPKA_MIKTAR})
        Me.GridView1.GridControl = Me.GridControl1
        Me.GridView1.Name = "GridView1"
        '
        'colSERI
        '
        Me.colSERI.FieldName = "SERI"
        Me.colSERI.Name = "colSERI"
        Me.colSERI.Visible = True
        Me.colSERI.VisibleIndex = 0
        '
        'colBOLGE
        '
        Me.colBOLGE.FieldName = "BOLGE"
        Me.colBOLGE.Name = "colBOLGE"
        Me.colBOLGE.Visible = True
        Me.colBOLGE.VisibleIndex = 1
        '
        'colTARIH
        '
        Me.colTARIH.FieldName = "TARIH"
        Me.colTARIH.Name = "colTARIH"
        Me.colTARIH.Visible = True
        Me.colTARIH.VisibleIndex = 2
        '
        'colPARTINO
        '
        Me.colPARTINO.FieldName = "PARTINO"
        Me.colPARTINO.Name = "colPARTINO"
        Me.colPARTINO.Visible = True
        Me.colPARTINO.VisibleIndex = 3
        '
        'colBRUT
        '
        Me.colBRUT.FieldName = "BRUT"
        Me.colBRUT.Name = "colBRUT"
        Me.colBRUT.Visible = True
        Me.colBRUT.VisibleIndex = 4
        '
        'colDARA
        '
        Me.colDARA.FieldName = "DARA"
        Me.colDARA.Name = "colDARA"
        Me.colDARA.Visible = True
        Me.colDARA.VisibleIndex = 5
        '
        'colMIKTAR
        '
        Me.colMIKTAR.FieldName = "MIKTAR"
        Me.colMIKTAR.Name = "colMIKTAR"
        Me.colMIKTAR.Visible = True
        Me.colMIKTAR.VisibleIndex = 6
        '
        'colEBAT
        '
        Me.colEBAT.FieldName = "EBAT"
        Me.colEBAT.Name = "colEBAT"
        Me.colEBAT.Visible = True
        Me.colEBAT.VisibleIndex = 7
        '
        'colISLEM
        '
        Me.colISLEM.FieldName = "ISLEM"
        Me.colISLEM.Name = "colISLEM"
        Me.colISLEM.Visible = True
        Me.colISLEM.VisibleIndex = 8
        '
        'colSTOK_KODU
        '
        Me.colSTOK_KODU.FieldName = "STOK_KODU"
        Me.colSTOK_KODU.Name = "colSTOK_KODU"
        Me.colSTOK_KODU.Visible = True
        Me.colSTOK_KODU.VisibleIndex = 9
        '
        'colERIK_ISLEM
        '
        Me.colERIK_ISLEM.FieldName = "ERIK_ISLEM"
        Me.colERIK_ISLEM.Name = "colERIK_ISLEM"
        Me.colERIK_ISLEM.Visible = True
        Me.colERIK_ISLEM.VisibleIndex = 10
        '
        'colKALINTI
        '
        Me.colKALINTI.FieldName = "KALINTI"
        Me.colKALINTI.Name = "colKALINTI"
        Me.colKALINTI.Visible = True
        Me.colKALINTI.VisibleIndex = 11
        '
        'colTIP
        '
        Me.colTIP.FieldName = "TIP"
        Me.colTIP.Name = "colTIP"
        Me.colTIP.Visible = True
        Me.colTIP.VisibleIndex = 12
        '
        'colURETIM_TIPI
        '
        Me.colURETIM_TIPI.FieldName = "URETIM_TIPI"
        Me.colURETIM_TIPI.Name = "colURETIM_TIPI"
        Me.colURETIM_TIPI.Visible = True
        Me.colURETIM_TIPI.VisibleIndex = 13
        '
        'colACIKLAMA
        '
        Me.colACIKLAMA.FieldName = "ACIKLAMA"
        Me.colACIKLAMA.Name = "colACIKLAMA"
        Me.colACIKLAMA.Visible = True
        Me.colACIKLAMA.VisibleIndex = 14
        '
        'colETIKET_TIPI
        '
        Me.colETIKET_TIPI.FieldName = "ETIKET_TIPI"
        Me.colETIKET_TIPI.Name = "colETIKET_TIPI"
        Me.colETIKET_TIPI.Visible = True
        Me.colETIKET_TIPI.VisibleIndex = 15
        '
        'colETIKET_MIKTAR
        '
        Me.colETIKET_MIKTAR.FieldName = "ETIKET_MIKTAR"
        Me.colETIKET_MIKTAR.Name = "colETIKET_MIKTAR"
        Me.colETIKET_MIKTAR.Visible = True
        Me.colETIKET_MIKTAR.VisibleIndex = 16
        '
        'colNEMBEZI_TIPI
        '
        Me.colNEMBEZI_TIPI.FieldName = "NEMBEZI_TIPI"
        Me.colNEMBEZI_TIPI.Name = "colNEMBEZI_TIPI"
        Me.colNEMBEZI_TIPI.Visible = True
        Me.colNEMBEZI_TIPI.VisibleIndex = 17
        '
        'colNEMBEZI_MIKTAR
        '
        Me.colNEMBEZI_MIKTAR.FieldName = "NEMBEZI_MIKTAR"
        Me.colNEMBEZI_MIKTAR.Name = "colNEMBEZI_MIKTAR"
        Me.colNEMBEZI_MIKTAR.Visible = True
        Me.colNEMBEZI_MIKTAR.VisibleIndex = 18
        '
        'colKARTONKUTU_TIPI
        '
        Me.colKARTONKUTU_TIPI.FieldName = "KARTONKUTU_TIPI"
        Me.colKARTONKUTU_TIPI.Name = "colKARTONKUTU_TIPI"
        Me.colKARTONKUTU_TIPI.Visible = True
        Me.colKARTONKUTU_TIPI.VisibleIndex = 19
        '
        'colKARTONKUTU_MIKTAR
        '
        Me.colKARTONKUTU_MIKTAR.FieldName = "KARTONKUTU_MIKTAR"
        Me.colKARTONKUTU_MIKTAR.Name = "colKARTONKUTU_MIKTAR"
        Me.colKARTONKUTU_MIKTAR.Visible = True
        Me.colKARTONKUTU_MIKTAR.VisibleIndex = 20
        '
        'colKOSEBENT_TIPI
        '
        Me.colKOSEBENT_TIPI.FieldName = "KOSEBENT_TIPI"
        Me.colKOSEBENT_TIPI.Name = "colKOSEBENT_TIPI"
        Me.colKOSEBENT_TIPI.Visible = True
        Me.colKOSEBENT_TIPI.VisibleIndex = 21
        '
        'colKOSEBENT_MIKTAR
        '
        Me.colKOSEBENT_MIKTAR.FieldName = "KOSEBENT_MIKTAR"
        Me.colKOSEBENT_MIKTAR.Name = "colKOSEBENT_MIKTAR"
        Me.colKOSEBENT_MIKTAR.Visible = True
        Me.colKOSEBENT_MIKTAR.VisibleIndex = 22
        '
        'colPOSET_TIPI
        '
        Me.colPOSET_TIPI.FieldName = "POSET_TIPI"
        Me.colPOSET_TIPI.Name = "colPOSET_TIPI"
        Me.colPOSET_TIPI.Visible = True
        Me.colPOSET_TIPI.VisibleIndex = 23
        '
        'colPOSET_MIKTAR
        '
        Me.colPOSET_MIKTAR.FieldName = "POSET_MIKTAR"
        Me.colPOSET_MIKTAR.Name = "colPOSET_MIKTAR"
        Me.colPOSET_MIKTAR.Visible = True
        Me.colPOSET_MIKTAR.VisibleIndex = 24
        '
        'colPALET_TIPI
        '
        Me.colPALET_TIPI.FieldName = "PALET_TIPI"
        Me.colPALET_TIPI.Name = "colPALET_TIPI"
        Me.colPALET_TIPI.Visible = True
        Me.colPALET_TIPI.VisibleIndex = 25
        '
        'colPALET_MIKTAR
        '
        Me.colPALET_MIKTAR.FieldName = "PALET_MIKTAR"
        Me.colPALET_MIKTAR.Name = "colPALET_MIKTAR"
        Me.colPALET_MIKTAR.Visible = True
        Me.colPALET_MIKTAR.VisibleIndex = 26
        '
        'colSAPKA_TIPI
        '
        Me.colSAPKA_TIPI.FieldName = "SAPKA_TIPI"
        Me.colSAPKA_TIPI.Name = "colSAPKA_TIPI"
        Me.colSAPKA_TIPI.Visible = True
        Me.colSAPKA_TIPI.VisibleIndex = 27
        '
        'colSAPKA_MIKTAR
        '
        Me.colSAPKA_MIKTAR.FieldName = "SAPKA_MIKTAR"
        Me.colSAPKA_MIKTAR.Name = "colSAPKA_MIKTAR"
        Me.colSAPKA_MIKTAR.Visible = True
        Me.colSAPKA_MIKTAR.VisibleIndex = 28
        '
        'EO_ALANSIS_ERIKURETIMRAPORTableAdapter
        '
        Me.EO_ALANSIS_ERIKURETIMRAPORTableAdapter.ClearBeforeFill = True
        '
        'SimpleButton2
        '
        Me.SimpleButton2.ImageOptions.Image = CType(resources.GetObject("SimpleButton2.ImageOptions.Image"), System.Drawing.Image)
        Me.SimpleButton2.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.SimpleButton2.Location = New System.Drawing.Point(3, 3)
        Me.SimpleButton2.Name = "SimpleButton2"
        Me.SimpleButton2.Size = New System.Drawing.Size(37, 32)
        Me.SimpleButton2.TabIndex = 19
        '
        'Form221
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.GridControl1)
        Me.Controls.Add(Me.SimpleButton2)
        Me.IconOptions.Image = Global.WindowsApplication1.My.Resources.Resources.LOGIN1
        Me.Name = "Form221"
        Me.Text = "ALANSIS ERIK URETIM RAPOR MODULU"
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EOALANSISERIKURETIMRAPORBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ALANSISDataSet50, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DefaultLookAndFeel1 As DevExpress.LookAndFeel.DefaultLookAndFeel
    Friend WithEvents FormAssistant1 As DevExpress.XtraBars.FormAssistant
    Friend WithEvents SimpleButton2 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents ALANSISDataSet50 As ALANSISDataSet50
    Friend WithEvents EOALANSISERIKURETIMRAPORBindingSource As BindingSource
    Friend WithEvents EO_ALANSIS_ERIKURETIMRAPORTableAdapter As ALANSISDataSet50TableAdapters.EO_ALANSIS_ERIKURETIMRAPORTableAdapter
    Friend WithEvents colSERI As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colBOLGE As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTARIH As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPARTINO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colBRUT As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDARA As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colMIKTAR As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colEBAT As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colISLEM As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSTOK_KODU As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colERIK_ISLEM As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colKALINTI As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTIP As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colURETIM_TIPI As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colACIKLAMA As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colETIKET_TIPI As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colETIKET_MIKTAR As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNEMBEZI_TIPI As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNEMBEZI_MIKTAR As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colKARTONKUTU_TIPI As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colKARTONKUTU_MIKTAR As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colKOSEBENT_TIPI As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colKOSEBENT_MIKTAR As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPOSET_TIPI As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPOSET_MIKTAR As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPALET_TIPI As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPALET_MIKTAR As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSAPKA_TIPI As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSAPKA_MIKTAR As DevExpress.XtraGrid.Columns.GridColumn
End Class
