<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form118
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
        Dim SelectQuery1 As DevExpress.DataAccess.Sql.SelectQuery = New DevExpress.DataAccess.Sql.SelectQuery()
        Dim Column1 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
        Dim ColumnExpression1 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
        Dim Table1 As DevExpress.DataAccess.Sql.Table = New DevExpress.DataAccess.Sql.Table()
        Dim Column2 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
        Dim ColumnExpression2 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form118))
        Me.FormAssistant1 = New DevExpress.XtraBars.FormAssistant()
        Me.DefaultLookAndFeel1 = New DevExpress.LookAndFeel.DefaultLookAndFeel(Me.components)
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl()
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ComboBoxEdit1 = New DevExpress.XtraEditors.SearchLookUpEdit()
        Me.EOALANSISRECETEVWBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ALANSISDataSet2 = New WindowsApplication1.ALANSISDataSet2()
        Me.SearchLookUpEdit21View = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.EOALANSISSATISBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ALANSISDataSet1 = New WindowsApplication1.ALANSISDataSet1()
        Me.TextEdit2 = New DevExpress.XtraEditors.TextEdit()
        Me.EO_ALANSIS_SATISTableAdapter = New WindowsApplication1.ALANSISDataSet1TableAdapters.EO_ALANSIS_SATISTableAdapter()
        Me.GroupControl2 = New DevExpress.XtraEditors.GroupControl()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.ComboBoxEdit12 = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.ComboBoxEdit13 = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.ComboBoxEdit14 = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.TextEdit9 = New DevExpress.XtraEditors.TextEdit()
        Me.TextEdit10 = New DevExpress.XtraEditors.TextEdit()
        Me.ComboBoxEdit15 = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.TextEdit11 = New DevExpress.XtraEditors.TextEdit()
        Me.SearchLookUpEdit11 = New DevExpress.XtraEditors.SearchLookUpEdit()
        Me.EOALANSISKASATIPIBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ALANAR2021DataSet11BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ALANAR2021DataSet11 = New WindowsApplication1.ALANAR2021DataSet1()
        Me.GridView11 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.TextEdit12 = New DevExpress.XtraEditors.TextEdit()
        Me.ComboBoxEdit16 = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.TextEdit13 = New DevExpress.XtraEditors.TextEdit()
        Me.SearchLookUpEdit12 = New DevExpress.XtraEditors.SearchLookUpEdit()
        Me.EOALANSISPOSETTIPIBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GridView12 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.TextEdit14 = New DevExpress.XtraEditors.TextEdit()
        Me.TextEdit15 = New DevExpress.XtraEditors.TextEdit()
        Me.TextEdit16 = New DevExpress.XtraEditors.TextEdit()
        Me.SearchLookUpEdit13 = New DevExpress.XtraEditors.SearchLookUpEdit()
        Me.EOALANSISKUTUTIPIBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GridView13 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.TextEdit17 = New DevExpress.XtraEditors.TextEdit()
        Me.SearchLookUpEdit14 = New DevExpress.XtraEditors.SearchLookUpEdit()
        Me.EOALANSISPALETTIPIBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GridView14 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.TextEdit19 = New DevExpress.XtraEditors.TextEdit()
        Me.ComboBoxEdit17 = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.ComboBoxEdit18 = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.SearchLookUpEdit15 = New DevExpress.XtraEditors.SearchLookUpEdit()
        Me.EOALANSISEBATETIKETTIPIBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GridView15 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.ComboBoxEdit19 = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.SearchLookUpEdit16 = New DevExpress.XtraEditors.SearchLookUpEdit()
        Me.EOALANSISCARYYBAGTIPIBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GridView16 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.ComboBoxEdit20 = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.ComboBoxEdit21 = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SearchLookUpEdit17 = New DevExpress.XtraEditors.SearchLookUpEdit()
        Me.EOALANSISSABKATIPIBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GridView17 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.SearchLookUpEdit18 = New DevExpress.XtraEditors.SearchLookUpEdit()
        Me.EOALANSISKLIPSTIPIBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GridView18 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.SearchLookUpEdit19 = New DevExpress.XtraEditors.SearchLookUpEdit()
        Me.EOALANSISKOSEBENTTIPIBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GridView19 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.SearchLookUpEdit20 = New DevExpress.XtraEditors.SearchLookUpEdit()
        Me.EOALANSISNEMBEZITIPIBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GridView20 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.Label32 = New System.Windows.Forms.Label()
        Me.ComboBoxEdit11 = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.ComboBoxEdit10 = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.ComboBoxEdit9 = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.TextEdit1 = New DevExpress.XtraEditors.TextEdit()
        Me.TextEdit3 = New DevExpress.XtraEditors.TextEdit()
        Me.ComboBoxEdit8 = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.TextEdit20 = New DevExpress.XtraEditors.TextEdit()
        Me.SearchLookUpEdit2 = New DevExpress.XtraEditors.SearchLookUpEdit()
        Me.EOALANSISEBATETIKETTIPIDEPOBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ALANSISDataSet3BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ALANSISDataSet3 = New WindowsApplication1.ALANSISDataSet3()
        Me.GridView2 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.TextEdit4 = New DevExpress.XtraEditors.TextEdit()
        Me.ComboBoxEdit7 = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.TextEdit18 = New DevExpress.XtraEditors.TextEdit()
        Me.SearchLookUpEdit10 = New DevExpress.XtraEditors.SearchLookUpEdit()
        Me.GridView10 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.TextEdit5 = New DevExpress.XtraEditors.TextEdit()
        Me.TextEdit8 = New DevExpress.XtraEditors.TextEdit()
        Me.SearchLookUpEdit3 = New DevExpress.XtraEditors.SearchLookUpEdit()
        Me.GridView3 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.TextEdit6 = New DevExpress.XtraEditors.TextEdit()
        Me.SearchLookUpEdit1 = New DevExpress.XtraEditors.SearchLookUpEdit()
        Me.EOALANSISYARDDEPOBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ALANSISDataSet4 = New WindowsApplication1.ALANSISDataSet4()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.TextEdit7 = New DevExpress.XtraEditors.TextEdit()
        Me.ComboBoxEdit6 = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.ComboBoxEdit5 = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.SearchLookUpEdit4 = New DevExpress.XtraEditors.SearchLookUpEdit()
        Me.GridView4 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.ComboBoxEdit4 = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.SearchLookUpEdit9 = New DevExpress.XtraEditors.SearchLookUpEdit()
        Me.GridView9 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.ComboBoxEdit3 = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.ComboBoxEdit2 = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.SearchLookUpEdit5 = New DevExpress.XtraEditors.SearchLookUpEdit()
        Me.GridView5 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.SearchLookUpEdit8 = New DevExpress.XtraEditors.SearchLookUpEdit()
        Me.GridView8 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.SearchLookUpEdit6 = New DevExpress.XtraEditors.SearchLookUpEdit()
        Me.GridView6 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.SearchLookUpEdit7 = New DevExpress.XtraEditors.SearchLookUpEdit()
        Me.GridView7 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.SimpleButton4 = New DevExpress.XtraEditors.SimpleButton()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.EOALANSISPOSETTIPIDEPOBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.EOALANSISCARYYBAGTIPIDEPOBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ALANAR2021DataSet1 = New WindowsApplication1.ALANAR2021DataSet1()
        Me.EO_ALANSIS_PALETTIPITableAdapter = New WindowsApplication1.ALANAR2021DataSet1TableAdapters.EO_ALANSIS_PALETTIPITableAdapter()
        Me.TableAdapterManager = New WindowsApplication1.ALANAR2021DataSet1TableAdapters.TableAdapterManager()
        Me.SqlDataSource1 = New DevExpress.DataAccess.Sql.SqlDataSource(Me.components)
        Me.eO_ALANSIS_POSETTIPIBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.EO_ALANSIS_KASATIPITableAdapter = New WindowsApplication1.ALANAR2021DataSet1TableAdapters.EO_ALANSIS_KASATIPITableAdapter()
        Me.EO_ALANSIS_KUTUTIPITableAdapter = New WindowsApplication1.ALANAR2021DataSet1TableAdapters.EO_ALANSIS_KUTUTIPITableAdapter()
        Me.EO_ALANSIS_EBATETIKETTIPITableAdapter = New WindowsApplication1.ALANAR2021DataSet1TableAdapters.EO_ALANSIS_EBATETIKETTIPITableAdapter()
        Me.EO_ALANSIS_SABKATIPITableAdapter = New WindowsApplication1.ALANAR2021DataSet1TableAdapters.EO_ALANSIS_SABKATIPITableAdapter()
        Me.EO_ALANSIS_KOSEBENTTIPITableAdapter = New WindowsApplication1.ALANAR2021DataSet1TableAdapters.EO_ALANSIS_KOSEBENTTIPITableAdapter()
        Me.EO_ALANSIS_NEMBEZITIPITableAdapter = New WindowsApplication1.ALANAR2021DataSet1TableAdapters.EO_ALANSIS_NEMBEZITIPITableAdapter()
        Me.EO_ALANSIS_KLIPSTIPITableAdapter = New WindowsApplication1.ALANAR2021DataSet1TableAdapters.EO_ALANSIS_KLIPSTIPITableAdapter()
        Me.EO_ALANSIS_CARYYBAGTIPITableAdapter = New WindowsApplication1.ALANAR2021DataSet1TableAdapters.EO_ALANSIS_CARYYBAGTIPITableAdapter()
        Me.EO_ALANSIS_POSETTIPITableAdapter = New WindowsApplication1.ALANAR2021DataSet1TableAdapters.EO_ALANSIS_POSETTIPITableAdapter()
        Me.TextEdit21 = New DevExpress.XtraEditors.TextEdit()
        Me.TextEdit22 = New DevExpress.XtraEditors.TextEdit()
        Me.TextEdit23 = New DevExpress.XtraEditors.TextEdit()
        Me.GroupControl3 = New DevExpress.XtraEditors.GroupControl()
        Me.TextEdit25 = New DevExpress.XtraEditors.TextEdit()
        Me.Label33 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.EO_ALANSIS_RECETEVWTableAdapter = New WindowsApplication1.ALANSISDataSet2TableAdapters.EO_ALANSIS_RECETEVWTableAdapter()
        Me.XtraTabControl1 = New DevExpress.XtraTab.XtraTabControl()
        Me.XtraTabPage1 = New DevExpress.XtraTab.XtraTabPage()
        Me.XtraTabPage3 = New DevExpress.XtraTab.XtraTabPage()
        Me.GroupControl4 = New DevExpress.XtraEditors.GroupControl()
        Me.TextEdit46 = New DevExpress.XtraEditors.TextEdit()
        Me.TextEdit24 = New DevExpress.XtraEditors.TextEdit()
        Me.SearchLookUpEdit31 = New DevExpress.XtraEditors.SearchLookUpEdit()
        Me.GridView31 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.SearchLookUpEdit32 = New DevExpress.XtraEditors.SearchLookUpEdit()
        Me.GridView32 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.SearchLookUpEdit33 = New DevExpress.XtraEditors.SearchLookUpEdit()
        Me.GridView33 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.SearchLookUpEdit34 = New DevExpress.XtraEditors.SearchLookUpEdit()
        Me.GridView34 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.SearchLookUpEdit35 = New DevExpress.XtraEditors.SearchLookUpEdit()
        Me.GridView35 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.SearchLookUpEdit36 = New DevExpress.XtraEditors.SearchLookUpEdit()
        Me.GridView36 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.SearchLookUpEdit37 = New DevExpress.XtraEditors.SearchLookUpEdit()
        Me.GridView37 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.SearchLookUpEdit38 = New DevExpress.XtraEditors.SearchLookUpEdit()
        Me.GridView38 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.SearchLookUpEdit39 = New DevExpress.XtraEditors.SearchLookUpEdit()
        Me.GridView39 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.SearchLookUpEdit40 = New DevExpress.XtraEditors.SearchLookUpEdit()
        Me.GridView40 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.TextEdit57 = New DevExpress.XtraEditors.TextEdit()
        Me.TextEdit58 = New DevExpress.XtraEditors.TextEdit()
        Me.TextEdit59 = New DevExpress.XtraEditors.TextEdit()
        Me.TextEdit60 = New DevExpress.XtraEditors.TextEdit()
        Me.TextEdit61 = New DevExpress.XtraEditors.TextEdit()
        Me.TextEdit62 = New DevExpress.XtraEditors.TextEdit()
        Me.TextEdit63 = New DevExpress.XtraEditors.TextEdit()
        Me.TextEdit64 = New DevExpress.XtraEditors.TextEdit()
        Me.TextEdit65 = New DevExpress.XtraEditors.TextEdit()
        Me.SearchLookUpEdit21 = New DevExpress.XtraEditors.SearchLookUpEdit()
        Me.GridView21 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.SearchLookUpEdit22 = New DevExpress.XtraEditors.SearchLookUpEdit()
        Me.GridView22 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.SearchLookUpEdit23 = New DevExpress.XtraEditors.SearchLookUpEdit()
        Me.GridView23 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.SearchLookUpEdit24 = New DevExpress.XtraEditors.SearchLookUpEdit()
        Me.GridView24 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.SearchLookUpEdit25 = New DevExpress.XtraEditors.SearchLookUpEdit()
        Me.GridView25 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.SearchLookUpEdit26 = New DevExpress.XtraEditors.SearchLookUpEdit()
        Me.GridView26 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.SearchLookUpEdit27 = New DevExpress.XtraEditors.SearchLookUpEdit()
        Me.GridView27 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.SearchLookUpEdit28 = New DevExpress.XtraEditors.SearchLookUpEdit()
        Me.GridView28 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.SearchLookUpEdit29 = New DevExpress.XtraEditors.SearchLookUpEdit()
        Me.GridView29 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.SearchLookUpEdit30 = New DevExpress.XtraEditors.SearchLookUpEdit()
        Me.GridView30 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.TextEdit47 = New DevExpress.XtraEditors.TextEdit()
        Me.TextEdit48 = New DevExpress.XtraEditors.TextEdit()
        Me.TextEdit49 = New DevExpress.XtraEditors.TextEdit()
        Me.TextEdit50 = New DevExpress.XtraEditors.TextEdit()
        Me.TextEdit51 = New DevExpress.XtraEditors.TextEdit()
        Me.TextEdit52 = New DevExpress.XtraEditors.TextEdit()
        Me.TextEdit53 = New DevExpress.XtraEditors.TextEdit()
        Me.TextEdit54 = New DevExpress.XtraEditors.TextEdit()
        Me.TextEdit55 = New DevExpress.XtraEditors.TextEdit()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.TextEdit26 = New DevExpress.XtraEditors.TextEdit()
        Me.TextEdit27 = New DevExpress.XtraEditors.TextEdit()
        Me.TextEdit28 = New DevExpress.XtraEditors.TextEdit()
        Me.TextEdit29 = New DevExpress.XtraEditors.TextEdit()
        Me.TextEdit30 = New DevExpress.XtraEditors.TextEdit()
        Me.TextEdit31 = New DevExpress.XtraEditors.TextEdit()
        Me.TextEdit32 = New DevExpress.XtraEditors.TextEdit()
        Me.TextEdit33 = New DevExpress.XtraEditors.TextEdit()
        Me.TextEdit34 = New DevExpress.XtraEditors.TextEdit()
        Me.TextEdit35 = New DevExpress.XtraEditors.TextEdit()
        Me.Label34 = New System.Windows.Forms.Label()
        Me.Label35 = New System.Windows.Forms.Label()
        Me.Label36 = New System.Windows.Forms.Label()
        Me.Label37 = New System.Windows.Forms.Label()
        Me.Label38 = New System.Windows.Forms.Label()
        Me.Label39 = New System.Windows.Forms.Label()
        Me.Label40 = New System.Windows.Forms.Label()
        Me.Label41 = New System.Windows.Forms.Label()
        Me.Label42 = New System.Windows.Forms.Label()
        Me.Label43 = New System.Windows.Forms.Label()
        Me.Label44 = New System.Windows.Forms.Label()
        Me.Label45 = New System.Windows.Forms.Label()
        Me.Label46 = New System.Windows.Forms.Label()
        Me.Label47 = New System.Windows.Forms.Label()
        Me.TextEdit36 = New DevExpress.XtraEditors.TextEdit()
        Me.TextEdit37 = New DevExpress.XtraEditors.TextEdit()
        Me.TextEdit38 = New DevExpress.XtraEditors.TextEdit()
        Me.TextEdit39 = New DevExpress.XtraEditors.TextEdit()
        Me.TextEdit40 = New DevExpress.XtraEditors.TextEdit()
        Me.TextEdit41 = New DevExpress.XtraEditors.TextEdit()
        Me.TextEdit42 = New DevExpress.XtraEditors.TextEdit()
        Me.TextEdit43 = New DevExpress.XtraEditors.TextEdit()
        Me.TextEdit44 = New DevExpress.XtraEditors.TextEdit()
        Me.TextEdit45 = New DevExpress.XtraEditors.TextEdit()
        Me.Label48 = New System.Windows.Forms.Label()
        Me.Label49 = New System.Windows.Forms.Label()
        Me.Label50 = New System.Windows.Forms.Label()
        Me.Label51 = New System.Windows.Forms.Label()
        Me.Label52 = New System.Windows.Forms.Label()
        Me.Label53 = New System.Windows.Forms.Label()
        Me.Label54 = New System.Windows.Forms.Label()
        Me.Label55 = New System.Windows.Forms.Label()
        Me.Label56 = New System.Windows.Forms.Label()
        Me.Label57 = New System.Windows.Forms.Label()
        Me.Label58 = New System.Windows.Forms.Label()
        Me.Label59 = New System.Windows.Forms.Label()
        Me.SimpleButton6 = New DevExpress.XtraEditors.SimpleButton()
        Me.Label60 = New System.Windows.Forms.Label()
        Me.Label61 = New System.Windows.Forms.Label()
        Me.EOALANSISYARDIMCIMALZEMEBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ALANAR2021DataSet2 = New WindowsApplication1.ALANAR2021DataSet2()
        Me.EO_ALANSIS_RECETEVWTableAdapter1 = New WindowsApplication1.ALANSISDataSet2TableAdapters.EO_ALANSIS_RECETEVWTableAdapter()
        Me.SqlDataSource2 = New DevExpress.DataAccess.Sql.SqlDataSource(Me.components)
        Me.EO_ALANSIS_YARDIMCIMALZEMETableAdapter = New WindowsApplication1.ALANAR2021DataSet2TableAdapters.EO_ALANSIS_YARDIMCIMALZEMETableAdapter()
        Me.EO_ALANSIS_CARYYBAGTIPIDEPOTableAdapter = New WindowsApplication1.ALANSISDataSet3TableAdapters.EO_ALANSIS_CARYYBAGTIPIDEPOTableAdapter()
        Me.EO_ALANSIS_EBATETIKETTIPIDEPOTableAdapter = New WindowsApplication1.ALANSISDataSet3TableAdapters.EO_ALANSIS_EBATETIKETTIPIDEPOTableAdapter()
        Me.EOALANSISKASATIPIDEPOBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.EO_ALANSIS_KASATIPIDEPOTableAdapter = New WindowsApplication1.ALANSISDataSet3TableAdapters.EO_ALANSIS_KASATIPIDEPOTableAdapter()
        Me.EOALANSISKLIPSTIPIBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.EOALANSISKLIPSTIPIDEPOBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.EO_ALANSIS_KLIPSTIPIDEPOTableAdapter = New WindowsApplication1.ALANSISDataSet3TableAdapters.EO_ALANSIS_KLIPSTIPIDEPOTableAdapter()
        Me.EOALANSISKOSEBENTTIPIDEPOBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.EO_ALANSIS_KOSEBENTTIPIDEPOTableAdapter = New WindowsApplication1.ALANSISDataSet3TableAdapters.EO_ALANSIS_KOSEBENTTIPIDEPOTableAdapter()
        Me.EOALANSISKUTUETIKETTIPIDEPOBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.EO_ALANSIS_KUTUETIKETTIPIDEPOTableAdapter = New WindowsApplication1.ALANSISDataSet3TableAdapters.EO_ALANSIS_KUTUETIKETTIPIDEPOTableAdapter()
        Me.EOALANSISKUTUTIPIDEPOBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.EO_ALANSIS_KUTUTIPIDEPOTableAdapter = New WindowsApplication1.ALANSISDataSet3TableAdapters.EO_ALANSIS_KUTUTIPIDEPOTableAdapter()
        Me.EOALANSISNEMBEZITIPIDEPOBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.EO_ALANSIS_NEMBEZITIPIDEPOTableAdapter = New WindowsApplication1.ALANSISDataSet3TableAdapters.EO_ALANSIS_NEMBEZITIPIDEPOTableAdapter()
        Me.EOALANSISPALETTIPIDEPOBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.EO_ALANSIS_PALETTIPIDEPOTableAdapter = New WindowsApplication1.ALANSISDataSet3TableAdapters.EO_ALANSIS_PALETTIPIDEPOTableAdapter()
        Me.EOALANSISSABKATIPIDEPOBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.EO_ALANSIS_SABKATIPIDEPOTableAdapter = New WindowsApplication1.ALANSISDataSet3TableAdapters.EO_ALANSIS_SABKATIPIDEPOTableAdapter()
        Me.EO_ALANSIS_POSETTIPIDEPOTableAdapter = New WindowsApplication1.ALANSISDataSet3TableAdapters.EO_ALANSIS_POSETTIPIDEPOTableAdapter()
        Me.EO_ALANSIS_YARDDEPOTableAdapter = New WindowsApplication1.ALANSISDataSet4TableAdapters.EO_ALANSIS_YARDDEPOTableAdapter()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.ComboBoxEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EOALANSISRECETEVWBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ALANSISDataSet2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SearchLookUpEdit21View, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EOALANSISSATISBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ALANSISDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextEdit2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl2.SuspendLayout()
        CType(Me.ComboBoxEdit12.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ComboBoxEdit13.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ComboBoxEdit14.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextEdit9.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextEdit10.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ComboBoxEdit15.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextEdit11.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SearchLookUpEdit11.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EOALANSISKASATIPIBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ALANAR2021DataSet11BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ALANAR2021DataSet11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextEdit12.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ComboBoxEdit16.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextEdit13.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SearchLookUpEdit12.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EOALANSISPOSETTIPIBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView12, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextEdit14.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextEdit15.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextEdit16.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SearchLookUpEdit13.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EOALANSISKUTUTIPIBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView13, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextEdit17.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SearchLookUpEdit14.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EOALANSISPALETTIPIBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView14, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextEdit19.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ComboBoxEdit17.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ComboBoxEdit18.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SearchLookUpEdit15.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EOALANSISEBATETIKETTIPIBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView15, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ComboBoxEdit19.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SearchLookUpEdit16.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EOALANSISCARYYBAGTIPIBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView16, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ComboBoxEdit20.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ComboBoxEdit21.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SearchLookUpEdit17.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EOALANSISSABKATIPIBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView17, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SearchLookUpEdit18.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EOALANSISKLIPSTIPIBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView18, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SearchLookUpEdit19.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EOALANSISKOSEBENTTIPIBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView19, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SearchLookUpEdit20.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EOALANSISNEMBEZITIPIBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView20, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ComboBoxEdit11.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ComboBoxEdit10.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ComboBoxEdit9.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextEdit3.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ComboBoxEdit8.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextEdit20.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SearchLookUpEdit2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EOALANSISEBATETIKETTIPIDEPOBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ALANSISDataSet3BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ALANSISDataSet3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextEdit4.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ComboBoxEdit7.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextEdit18.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SearchLookUpEdit10.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextEdit5.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextEdit8.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SearchLookUpEdit3.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextEdit6.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SearchLookUpEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EOALANSISYARDDEPOBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ALANSISDataSet4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextEdit7.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ComboBoxEdit6.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ComboBoxEdit5.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SearchLookUpEdit4.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ComboBoxEdit4.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SearchLookUpEdit9.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ComboBoxEdit3.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ComboBoxEdit2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SearchLookUpEdit5.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SearchLookUpEdit8.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SearchLookUpEdit6.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SearchLookUpEdit7.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EOALANSISPOSETTIPIDEPOBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EOALANSISCARYYBAGTIPIDEPOBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ALANAR2021DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.eO_ALANSIS_POSETTIPIBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextEdit21.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextEdit22.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextEdit23.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl3.SuspendLayout()
        CType(Me.TextEdit25.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabControl1.SuspendLayout()
        Me.XtraTabPage1.SuspendLayout()
        Me.XtraTabPage3.SuspendLayout()
        CType(Me.GroupControl4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl4.SuspendLayout()
        CType(Me.TextEdit46.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextEdit24.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SearchLookUpEdit31.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView31, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SearchLookUpEdit32.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView32, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SearchLookUpEdit33.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView33, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SearchLookUpEdit34.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView34, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SearchLookUpEdit35.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView35, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SearchLookUpEdit36.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView36, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SearchLookUpEdit37.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView37, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SearchLookUpEdit38.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView38, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SearchLookUpEdit39.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView39, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SearchLookUpEdit40.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView40, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextEdit57.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextEdit58.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextEdit59.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextEdit60.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextEdit61.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextEdit62.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextEdit63.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextEdit64.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextEdit65.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SearchLookUpEdit21.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView21, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SearchLookUpEdit22.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView22, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SearchLookUpEdit23.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView23, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SearchLookUpEdit24.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView24, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SearchLookUpEdit25.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView25, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SearchLookUpEdit26.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView26, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SearchLookUpEdit27.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView27, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SearchLookUpEdit28.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView28, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SearchLookUpEdit29.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView29, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SearchLookUpEdit30.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView30, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextEdit47.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextEdit48.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextEdit49.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextEdit50.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextEdit51.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextEdit52.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextEdit53.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextEdit54.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextEdit55.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextEdit26.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextEdit27.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextEdit28.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextEdit29.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextEdit30.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextEdit31.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextEdit32.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextEdit33.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextEdit34.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextEdit35.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextEdit36.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextEdit37.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextEdit38.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextEdit39.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextEdit40.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextEdit41.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextEdit42.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextEdit43.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextEdit44.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextEdit45.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EOALANSISYARDIMCIMALZEMEBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ALANAR2021DataSet2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EOALANSISKASATIPIDEPOBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EOALANSISKLIPSTIPIBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EOALANSISKLIPSTIPIDEPOBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EOALANSISKOSEBENTTIPIDEPOBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EOALANSISKUTUETIKETTIPIDEPOBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EOALANSISKUTUTIPIDEPOBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EOALANSISNEMBEZITIPIDEPOBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EOALANSISPALETTIPIDEPOBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EOALANSISSABKATIPIDEPOBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DefaultLookAndFeel1
        '
        Me.DefaultLookAndFeel1.LookAndFeel.SkinName = "Office 2007 Blue"
        '
        'GroupControl1
        '
        Me.GroupControl1.Controls.Add(Me.SimpleButton1)
        Me.GroupControl1.Controls.Add(Me.Label1)
        Me.GroupControl1.Controls.Add(Me.ComboBoxEdit1)
        Me.GroupControl1.Location = New System.Drawing.Point(796, 4)
        Me.GroupControl1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(580, 95)
        Me.GroupControl1.TabIndex = 3
        Me.GroupControl1.Text = "Reçete Türetim Seçim"
        '
        'SimpleButton1
        '
        Me.SimpleButton1.Location = New System.Drawing.Point(355, 32)
        Me.SimpleButton1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(215, 25)
        Me.SimpleButton1.TabIndex = 4
        Me.SimpleButton1.Text = "Sistemden Reçete Kopyala"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 34)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(56, 17)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Parti No"
        '
        'ComboBoxEdit1
        '
        Me.ComboBoxEdit1.EditValue = "sssAAa"
        Me.ComboBoxEdit1.Location = New System.Drawing.Point(65, 31)
        Me.ComboBoxEdit1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.ComboBoxEdit1.Name = "ComboBoxEdit1"
        Me.ComboBoxEdit1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.ComboBoxEdit1.Properties.DataSource = Me.EOALANSISRECETEVWBindingSource
        Me.ComboBoxEdit1.Properties.DisplayMember = "RECETE_INDEKS"
        Me.ComboBoxEdit1.Properties.NullText = ""
        Me.ComboBoxEdit1.Properties.PopupSizeable = False
        Me.ComboBoxEdit1.Properties.PopupView = Me.SearchLookUpEdit21View
        Me.ComboBoxEdit1.Properties.ValueMember = "RECETE_INDEKS"
        Me.ComboBoxEdit1.Size = New System.Drawing.Size(282, 23)
        Me.ComboBoxEdit1.TabIndex = 6
        '
        'EOALANSISRECETEVWBindingSource
        '
        Me.EOALANSISRECETEVWBindingSource.DataMember = "EO_ALANSIS_RECETEVW"
        Me.EOALANSISRECETEVWBindingSource.DataSource = Me.ALANSISDataSet2
        '
        'ALANSISDataSet2
        '
        Me.ALANSISDataSet2.DataSetName = "ALANSISDataSet2"
        Me.ALANSISDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'SearchLookUpEdit21View
        '
        Me.SearchLookUpEdit21View.DetailHeight = 431
        Me.SearchLookUpEdit21View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.SearchLookUpEdit21View.Name = "SearchLookUpEdit21View"
        Me.SearchLookUpEdit21View.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.SearchLookUpEdit21View.OptionsView.ShowGroupPanel = False
        '
        'EOALANSISSATISBindingSource
        '
        Me.EOALANSISSATISBindingSource.DataMember = "EO_ALANSIS_SATIS"
        Me.EOALANSISSATISBindingSource.DataSource = Me.ALANSISDataSet1
        '
        'ALANSISDataSet1
        '
        Me.ALANSISDataSet1.DataSetName = "ALANSISDataSet1"
        Me.ALANSISDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TextEdit2
        '
        Me.TextEdit2.Location = New System.Drawing.Point(594, 47)
        Me.TextEdit2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TextEdit2.Name = "TextEdit2"
        Me.TextEdit2.Size = New System.Drawing.Size(63, 23)
        Me.TextEdit2.TabIndex = 2
        '
        'EO_ALANSIS_SATISTableAdapter
        '
        Me.EO_ALANSIS_SATISTableAdapter.ClearBeforeFill = True
        '
        'GroupControl2
        '
        Me.GroupControl2.Controls.Add(Me.Panel2)
        Me.GroupControl2.Controls.Add(Me.ComboBoxEdit12)
        Me.GroupControl2.Controls.Add(Me.ComboBoxEdit13)
        Me.GroupControl2.Controls.Add(Me.ComboBoxEdit14)
        Me.GroupControl2.Controls.Add(Me.TextEdit9)
        Me.GroupControl2.Controls.Add(Me.TextEdit10)
        Me.GroupControl2.Controls.Add(Me.ComboBoxEdit15)
        Me.GroupControl2.Controls.Add(Me.TextEdit11)
        Me.GroupControl2.Controls.Add(Me.SearchLookUpEdit11)
        Me.GroupControl2.Controls.Add(Me.TextEdit12)
        Me.GroupControl2.Controls.Add(Me.ComboBoxEdit16)
        Me.GroupControl2.Controls.Add(Me.TextEdit13)
        Me.GroupControl2.Controls.Add(Me.SearchLookUpEdit12)
        Me.GroupControl2.Controls.Add(Me.TextEdit14)
        Me.GroupControl2.Controls.Add(Me.TextEdit15)
        Me.GroupControl2.Controls.Add(Me.TextEdit16)
        Me.GroupControl2.Controls.Add(Me.SearchLookUpEdit13)
        Me.GroupControl2.Controls.Add(Me.TextEdit17)
        Me.GroupControl2.Controls.Add(Me.SearchLookUpEdit14)
        Me.GroupControl2.Controls.Add(Me.TextEdit19)
        Me.GroupControl2.Controls.Add(Me.ComboBoxEdit17)
        Me.GroupControl2.Controls.Add(Me.ComboBoxEdit18)
        Me.GroupControl2.Controls.Add(Me.SearchLookUpEdit15)
        Me.GroupControl2.Controls.Add(Me.ComboBoxEdit19)
        Me.GroupControl2.Controls.Add(Me.SearchLookUpEdit16)
        Me.GroupControl2.Controls.Add(Me.ComboBoxEdit20)
        Me.GroupControl2.Controls.Add(Me.ComboBoxEdit21)
        Me.GroupControl2.Controls.Add(Me.Label2)
        Me.GroupControl2.Controls.Add(Me.SearchLookUpEdit17)
        Me.GroupControl2.Controls.Add(Me.SearchLookUpEdit18)
        Me.GroupControl2.Controls.Add(Me.Label5)
        Me.GroupControl2.Controls.Add(Me.Label6)
        Me.GroupControl2.Controls.Add(Me.Label7)
        Me.GroupControl2.Controls.Add(Me.SearchLookUpEdit19)
        Me.GroupControl2.Controls.Add(Me.Label8)
        Me.GroupControl2.Controls.Add(Me.SearchLookUpEdit20)
        Me.GroupControl2.Controls.Add(Me.Label9)
        Me.GroupControl2.Controls.Add(Me.Label10)
        Me.GroupControl2.Controls.Add(Me.Label11)
        Me.GroupControl2.Controls.Add(Me.Label13)
        Me.GroupControl2.Controls.Add(Me.Label14)
        Me.GroupControl2.Controls.Add(Me.Label26)
        Me.GroupControl2.Controls.Add(Me.Label30)
        Me.GroupControl2.Controls.Add(Me.Label31)
        Me.GroupControl2.Controls.Add(Me.Label32)
        Me.GroupControl2.Controls.Add(Me.ComboBoxEdit11)
        Me.GroupControl2.Controls.Add(Me.ComboBoxEdit10)
        Me.GroupControl2.Controls.Add(Me.ComboBoxEdit9)
        Me.GroupControl2.Controls.Add(Me.TextEdit1)
        Me.GroupControl2.Controls.Add(Me.TextEdit3)
        Me.GroupControl2.Controls.Add(Me.ComboBoxEdit8)
        Me.GroupControl2.Controls.Add(Me.TextEdit20)
        Me.GroupControl2.Controls.Add(Me.SearchLookUpEdit2)
        Me.GroupControl2.Controls.Add(Me.TextEdit4)
        Me.GroupControl2.Controls.Add(Me.ComboBoxEdit7)
        Me.GroupControl2.Controls.Add(Me.TextEdit18)
        Me.GroupControl2.Controls.Add(Me.SearchLookUpEdit10)
        Me.GroupControl2.Controls.Add(Me.TextEdit5)
        Me.GroupControl2.Controls.Add(Me.TextEdit2)
        Me.GroupControl2.Controls.Add(Me.TextEdit8)
        Me.GroupControl2.Controls.Add(Me.SearchLookUpEdit3)
        Me.GroupControl2.Controls.Add(Me.TextEdit6)
        Me.GroupControl2.Controls.Add(Me.SearchLookUpEdit1)
        Me.GroupControl2.Controls.Add(Me.TextEdit7)
        Me.GroupControl2.Controls.Add(Me.ComboBoxEdit6)
        Me.GroupControl2.Controls.Add(Me.ComboBoxEdit5)
        Me.GroupControl2.Controls.Add(Me.SearchLookUpEdit4)
        Me.GroupControl2.Controls.Add(Me.ComboBoxEdit4)
        Me.GroupControl2.Controls.Add(Me.SearchLookUpEdit9)
        Me.GroupControl2.Controls.Add(Me.ComboBoxEdit3)
        Me.GroupControl2.Controls.Add(Me.ComboBoxEdit2)
        Me.GroupControl2.Controls.Add(Me.Label29)
        Me.GroupControl2.Controls.Add(Me.SearchLookUpEdit5)
        Me.GroupControl2.Controls.Add(Me.SearchLookUpEdit8)
        Me.GroupControl2.Controls.Add(Me.Label27)
        Me.GroupControl2.Controls.Add(Me.Label28)
        Me.GroupControl2.Controls.Add(Me.Label22)
        Me.GroupControl2.Controls.Add(Me.SearchLookUpEdit6)
        Me.GroupControl2.Controls.Add(Me.Label23)
        Me.GroupControl2.Controls.Add(Me.SearchLookUpEdit7)
        Me.GroupControl2.Controls.Add(Me.Label24)
        Me.GroupControl2.Controls.Add(Me.Label25)
        Me.GroupControl2.Controls.Add(Me.Label17)
        Me.GroupControl2.Controls.Add(Me.Label19)
        Me.GroupControl2.Controls.Add(Me.Label16)
        Me.GroupControl2.Controls.Add(Me.Label15)
        Me.GroupControl2.Controls.Add(Me.Label12)
        Me.GroupControl2.Controls.Add(Me.SimpleButton4)
        Me.GroupControl2.Controls.Add(Me.Label4)
        Me.GroupControl2.Controls.Add(Me.Label3)
        Me.GroupControl2.Location = New System.Drawing.Point(8, 4)
        Me.GroupControl2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupControl2.Name = "GroupControl2"
        Me.GroupControl2.Size = New System.Drawing.Size(1353, 411)
        Me.GroupControl2.TabIndex = 4
        Me.GroupControl2.Text = "Reçete Oluştur"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.LightSteelBlue
        Me.Panel2.Location = New System.Drawing.Point(668, 50)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(12, 283)
        Me.Panel2.TabIndex = 111
        '
        'ComboBoxEdit12
        '
        Me.ComboBoxEdit12.Location = New System.Drawing.Point(729, 336)
        Me.ComboBoxEdit12.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.ComboBoxEdit12.Name = "ComboBoxEdit12"
        Me.ComboBoxEdit12.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.ComboBoxEdit12.Properties.Items.AddRange(New Object() {"Palet Tipi", "Kutu-Kasa Tipi", "Kutu Etiket Tipi", "Ebat Etiket Tipi", "Şapka Tipi", "Köşebent Tipi", "Nem Bezi Tipi", "Klips Tipi", "CarryBag Tpi", "Poşet Tipi"})
        Me.ComboBoxEdit12.Size = New System.Drawing.Size(143, 23)
        Me.ComboBoxEdit12.TabIndex = 110
        '
        'ComboBoxEdit13
        '
        Me.ComboBoxEdit13.Location = New System.Drawing.Point(729, 304)
        Me.ComboBoxEdit13.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.ComboBoxEdit13.Name = "ComboBoxEdit13"
        Me.ComboBoxEdit13.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.ComboBoxEdit13.Properties.Items.AddRange(New Object() {"Palet Tipi", "Kutu-Kasa Tipi", "Kutu Etiket Tipi", "Ebat Etiket Tipi", "Şapka Tipi", "Köşebent Tipi", "Nem Bezi Tipi", "Klips Tipi", "CarryBag Tpi", "Poşet Tipi"})
        Me.ComboBoxEdit13.Size = New System.Drawing.Size(143, 23)
        Me.ComboBoxEdit13.TabIndex = 109
        '
        'ComboBoxEdit14
        '
        Me.ComboBoxEdit14.Location = New System.Drawing.Point(729, 272)
        Me.ComboBoxEdit14.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.ComboBoxEdit14.Name = "ComboBoxEdit14"
        Me.ComboBoxEdit14.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.ComboBoxEdit14.Properties.Items.AddRange(New Object() {"Palet Tipi", "Kutu-Kasa Tipi", "Kutu Etiket Tipi", "Ebat Etiket Tipi", "Şapka Tipi", "Köşebent Tipi", "Nem Bezi Tipi", "Klips Tipi", "CarryBag Tpi", "Poşet Tipi"})
        Me.ComboBoxEdit14.Size = New System.Drawing.Size(143, 23)
        Me.ComboBoxEdit14.TabIndex = 108
        '
        'TextEdit9
        '
        Me.TextEdit9.Location = New System.Drawing.Point(1279, 79)
        Me.TextEdit9.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TextEdit9.Name = "TextEdit9"
        Me.TextEdit9.Size = New System.Drawing.Size(63, 23)
        Me.TextEdit9.TabIndex = 71
        '
        'TextEdit10
        '
        Me.TextEdit10.Location = New System.Drawing.Point(1279, 111)
        Me.TextEdit10.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TextEdit10.Name = "TextEdit10"
        Me.TextEdit10.Size = New System.Drawing.Size(63, 23)
        Me.TextEdit10.TabIndex = 73
        '
        'ComboBoxEdit15
        '
        Me.ComboBoxEdit15.Location = New System.Drawing.Point(729, 240)
        Me.ComboBoxEdit15.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.ComboBoxEdit15.Name = "ComboBoxEdit15"
        Me.ComboBoxEdit15.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.ComboBoxEdit15.Properties.Items.AddRange(New Object() {"Palet Tipi", "Kutu-Kasa Tipi", "Kutu Etiket Tipi", "Ebat Etiket Tipi", "Şapka Tipi", "Köşebent Tipi", "Nem Bezi Tipi", "Klips Tipi", "CarryBag Tpi", "Poşet Tipi"})
        Me.ComboBoxEdit15.Size = New System.Drawing.Size(143, 23)
        Me.ComboBoxEdit15.TabIndex = 107
        '
        'TextEdit11
        '
        Me.TextEdit11.Location = New System.Drawing.Point(1279, 335)
        Me.TextEdit11.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TextEdit11.Name = "TextEdit11"
        Me.TextEdit11.Size = New System.Drawing.Size(63, 23)
        Me.TextEdit11.TabIndex = 87
        '
        'SearchLookUpEdit11
        '
        Me.SearchLookUpEdit11.Location = New System.Drawing.Point(880, 79)
        Me.SearchLookUpEdit11.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.SearchLookUpEdit11.Name = "SearchLookUpEdit11"
        Me.SearchLookUpEdit11.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.SearchLookUpEdit11.Properties.DataSource = Me.EOALANSISKASATIPIBindingSource
        Me.SearchLookUpEdit11.Properties.DisplayMember = "STOK_ADI"
        Me.SearchLookUpEdit11.Properties.NullText = ""
        Me.SearchLookUpEdit11.Properties.PopupSizeable = False
        Me.SearchLookUpEdit11.Properties.PopupView = Me.GridView11
        Me.SearchLookUpEdit11.Properties.ValueMember = "STOK_ADI"
        Me.SearchLookUpEdit11.Size = New System.Drawing.Size(392, 23)
        Me.SearchLookUpEdit11.TabIndex = 72
        '
        'EOALANSISKASATIPIBindingSource
        '
        Me.EOALANSISKASATIPIBindingSource.DataMember = "EO_ALANSIS_KASATIPI"
        Me.EOALANSISKASATIPIBindingSource.DataSource = Me.ALANAR2021DataSet11BindingSource
        '
        'ALANAR2021DataSet11BindingSource
        '
        Me.ALANAR2021DataSet11BindingSource.DataSource = Me.ALANAR2021DataSet11
        Me.ALANAR2021DataSet11BindingSource.Position = 0
        '
        'ALANAR2021DataSet11
        '
        Me.ALANAR2021DataSet11.DataSetName = "ALANAR2021DataSet1"
        Me.ALANAR2021DataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GridView11
        '
        Me.GridView11.DetailHeight = 431
        Me.GridView11.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView11.Name = "GridView11"
        Me.GridView11.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView11.OptionsView.ShowGroupPanel = False
        '
        'TextEdit12
        '
        Me.TextEdit12.Location = New System.Drawing.Point(1279, 143)
        Me.TextEdit12.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TextEdit12.Name = "TextEdit12"
        Me.TextEdit12.Size = New System.Drawing.Size(63, 23)
        Me.TextEdit12.TabIndex = 75
        '
        'ComboBoxEdit16
        '
        Me.ComboBoxEdit16.Location = New System.Drawing.Point(729, 208)
        Me.ComboBoxEdit16.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.ComboBoxEdit16.Name = "ComboBoxEdit16"
        Me.ComboBoxEdit16.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.ComboBoxEdit16.Properties.Items.AddRange(New Object() {"Palet Tipi", "Kutu-Kasa Tipi", "Kutu Etiket Tipi", "Ebat Etiket Tipi", "Şapka Tipi", "Köşebent Tipi", "Nem Bezi Tipi", "Klips Tipi", "CarryBag Tpi", "Poşet Tipi"})
        Me.ComboBoxEdit16.Size = New System.Drawing.Size(143, 23)
        Me.ComboBoxEdit16.TabIndex = 106
        '
        'TextEdit13
        '
        Me.TextEdit13.Location = New System.Drawing.Point(1279, 303)
        Me.TextEdit13.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TextEdit13.Name = "TextEdit13"
        Me.TextEdit13.Size = New System.Drawing.Size(63, 23)
        Me.TextEdit13.TabIndex = 85
        '
        'SearchLookUpEdit12
        '
        Me.SearchLookUpEdit12.Location = New System.Drawing.Point(880, 335)
        Me.SearchLookUpEdit12.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.SearchLookUpEdit12.Name = "SearchLookUpEdit12"
        Me.SearchLookUpEdit12.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.SearchLookUpEdit12.Properties.DataSource = Me.EOALANSISPOSETTIPIBindingSource
        Me.SearchLookUpEdit12.Properties.DisplayMember = "STOK_ADI"
        Me.SearchLookUpEdit12.Properties.NullText = ""
        Me.SearchLookUpEdit12.Properties.PopupSizeable = False
        Me.SearchLookUpEdit12.Properties.PopupView = Me.GridView12
        Me.SearchLookUpEdit12.Properties.ValueMember = "STOK_ADI"
        Me.SearchLookUpEdit12.Size = New System.Drawing.Size(392, 23)
        Me.SearchLookUpEdit12.TabIndex = 88
        '
        'EOALANSISPOSETTIPIBindingSource
        '
        Me.EOALANSISPOSETTIPIBindingSource.DataMember = "EO_ALANSIS_POSETTIPI"
        Me.EOALANSISPOSETTIPIBindingSource.DataSource = Me.ALANAR2021DataSet11BindingSource
        '
        'GridView12
        '
        Me.GridView12.DetailHeight = 431
        Me.GridView12.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView12.Name = "GridView12"
        Me.GridView12.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView12.OptionsView.ShowGroupPanel = False
        '
        'TextEdit14
        '
        Me.TextEdit14.Location = New System.Drawing.Point(1279, 175)
        Me.TextEdit14.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TextEdit14.Name = "TextEdit14"
        Me.TextEdit14.Size = New System.Drawing.Size(63, 23)
        Me.TextEdit14.TabIndex = 77
        '
        'TextEdit15
        '
        Me.TextEdit15.Location = New System.Drawing.Point(1279, 47)
        Me.TextEdit15.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TextEdit15.Name = "TextEdit15"
        Me.TextEdit15.Size = New System.Drawing.Size(63, 23)
        Me.TextEdit15.TabIndex = 67
        '
        'TextEdit16
        '
        Me.TextEdit16.Location = New System.Drawing.Point(1279, 271)
        Me.TextEdit16.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TextEdit16.Name = "TextEdit16"
        Me.TextEdit16.Size = New System.Drawing.Size(63, 23)
        Me.TextEdit16.TabIndex = 83
        '
        'SearchLookUpEdit13
        '
        Me.SearchLookUpEdit13.Location = New System.Drawing.Point(880, 111)
        Me.SearchLookUpEdit13.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.SearchLookUpEdit13.Name = "SearchLookUpEdit13"
        Me.SearchLookUpEdit13.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.SearchLookUpEdit13.Properties.DataSource = Me.EOALANSISKUTUTIPIBindingSource
        Me.SearchLookUpEdit13.Properties.DisplayMember = "STOK_ADI"
        Me.SearchLookUpEdit13.Properties.NullText = ""
        Me.SearchLookUpEdit13.Properties.PopupSizeable = False
        Me.SearchLookUpEdit13.Properties.PopupView = Me.GridView13
        Me.SearchLookUpEdit13.Properties.ValueMember = "STOK_ADI"
        Me.SearchLookUpEdit13.Size = New System.Drawing.Size(392, 23)
        Me.SearchLookUpEdit13.TabIndex = 74
        '
        'EOALANSISKUTUTIPIBindingSource
        '
        Me.EOALANSISKUTUTIPIBindingSource.DataMember = "EO_ALANSIS_KUTUTIPI"
        Me.EOALANSISKUTUTIPIBindingSource.DataSource = Me.ALANAR2021DataSet11BindingSource
        '
        'GridView13
        '
        Me.GridView13.DetailHeight = 431
        Me.GridView13.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView13.Name = "GridView13"
        Me.GridView13.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView13.OptionsView.ShowGroupPanel = False
        '
        'TextEdit17
        '
        Me.TextEdit17.Location = New System.Drawing.Point(1279, 207)
        Me.TextEdit17.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TextEdit17.Name = "TextEdit17"
        Me.TextEdit17.Size = New System.Drawing.Size(63, 23)
        Me.TextEdit17.TabIndex = 79
        '
        'SearchLookUpEdit14
        '
        Me.SearchLookUpEdit14.Location = New System.Drawing.Point(880, 47)
        Me.SearchLookUpEdit14.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.SearchLookUpEdit14.Name = "SearchLookUpEdit14"
        Me.SearchLookUpEdit14.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.SearchLookUpEdit14.Properties.DataSource = Me.EOALANSISPALETTIPIBindingSource
        Me.SearchLookUpEdit14.Properties.DisplayMember = "STOK_ADI"
        Me.SearchLookUpEdit14.Properties.NullText = ""
        Me.SearchLookUpEdit14.Properties.PopupSizeable = False
        Me.SearchLookUpEdit14.Properties.PopupView = Me.GridView14
        Me.SearchLookUpEdit14.Properties.ValueMember = "STOK_ADI"
        Me.SearchLookUpEdit14.Size = New System.Drawing.Size(392, 23)
        Me.SearchLookUpEdit14.TabIndex = 68
        '
        'EOALANSISPALETTIPIBindingSource
        '
        Me.EOALANSISPALETTIPIBindingSource.DataMember = "EO_ALANSIS_PALETTIPI"
        Me.EOALANSISPALETTIPIBindingSource.DataSource = Me.ALANAR2021DataSet11BindingSource
        '
        'GridView14
        '
        Me.GridView14.DetailHeight = 431
        Me.GridView14.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView14.Name = "GridView14"
        Me.GridView14.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView14.OptionsView.ShowGroupPanel = False
        '
        'TextEdit19
        '
        Me.TextEdit19.Location = New System.Drawing.Point(1279, 239)
        Me.TextEdit19.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TextEdit19.Name = "TextEdit19"
        Me.TextEdit19.Size = New System.Drawing.Size(63, 23)
        Me.TextEdit19.TabIndex = 81
        '
        'ComboBoxEdit17
        '
        Me.ComboBoxEdit17.Location = New System.Drawing.Point(729, 176)
        Me.ComboBoxEdit17.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.ComboBoxEdit17.Name = "ComboBoxEdit17"
        Me.ComboBoxEdit17.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.ComboBoxEdit17.Properties.Items.AddRange(New Object() {"Palet Tipi", "Kutu-Kasa Tipi", "Kutu Etiket Tipi", "Ebat Etiket Tipi", "Şapka Tipi", "Köşebent Tipi", "Nem Bezi Tipi", "Klips Tipi", "CarryBag Tpi", "Poşet Tipi"})
        Me.ComboBoxEdit17.Size = New System.Drawing.Size(143, 23)
        Me.ComboBoxEdit17.TabIndex = 105
        '
        'ComboBoxEdit18
        '
        Me.ComboBoxEdit18.Location = New System.Drawing.Point(729, 144)
        Me.ComboBoxEdit18.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.ComboBoxEdit18.Name = "ComboBoxEdit18"
        Me.ComboBoxEdit18.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.ComboBoxEdit18.Properties.Items.AddRange(New Object() {"Palet Tipi", "Kutu-Kasa Tipi", "Kutu Etiket Tipi", "Ebat Etiket Tipi", "Şapka Tipi", "Köşebent Tipi", "Nem Bezi Tipi", "Klips Tipi", "CarryBag Tpi", "Poşet Tipi"})
        Me.ComboBoxEdit18.Size = New System.Drawing.Size(143, 23)
        Me.ComboBoxEdit18.TabIndex = 104
        '
        'SearchLookUpEdit15
        '
        Me.SearchLookUpEdit15.Location = New System.Drawing.Point(880, 143)
        Me.SearchLookUpEdit15.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.SearchLookUpEdit15.Name = "SearchLookUpEdit15"
        Me.SearchLookUpEdit15.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.SearchLookUpEdit15.Properties.DataSource = Me.EOALANSISEBATETIKETTIPIBindingSource
        Me.SearchLookUpEdit15.Properties.DisplayMember = "STOK_ADI"
        Me.SearchLookUpEdit15.Properties.NullText = ""
        Me.SearchLookUpEdit15.Properties.PopupSizeable = False
        Me.SearchLookUpEdit15.Properties.PopupView = Me.GridView15
        Me.SearchLookUpEdit15.Properties.ValueMember = "STOK_ADI"
        Me.SearchLookUpEdit15.Size = New System.Drawing.Size(392, 23)
        Me.SearchLookUpEdit15.TabIndex = 76
        '
        'EOALANSISEBATETIKETTIPIBindingSource
        '
        Me.EOALANSISEBATETIKETTIPIBindingSource.DataMember = "EO_ALANSIS_EBATETIKETTIPI"
        Me.EOALANSISEBATETIKETTIPIBindingSource.DataSource = Me.ALANAR2021DataSet11BindingSource
        '
        'GridView15
        '
        Me.GridView15.DetailHeight = 431
        Me.GridView15.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView15.Name = "GridView15"
        Me.GridView15.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView15.OptionsView.ShowGroupPanel = False
        '
        'ComboBoxEdit19
        '
        Me.ComboBoxEdit19.Location = New System.Drawing.Point(729, 112)
        Me.ComboBoxEdit19.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.ComboBoxEdit19.Name = "ComboBoxEdit19"
        Me.ComboBoxEdit19.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.ComboBoxEdit19.Properties.Items.AddRange(New Object() {"Palet Tipi", "Kutu-Kasa Tipi", "Kutu Etiket Tipi", "Ebat Etiket Tipi", "Şapka Tipi", "Köşebent Tipi", "Nem Bezi Tipi", "Klips Tipi", "CarryBag Tpi", "Poşet Tipi"})
        Me.ComboBoxEdit19.Size = New System.Drawing.Size(143, 23)
        Me.ComboBoxEdit19.TabIndex = 103
        '
        'SearchLookUpEdit16
        '
        Me.SearchLookUpEdit16.Location = New System.Drawing.Point(880, 303)
        Me.SearchLookUpEdit16.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.SearchLookUpEdit16.Name = "SearchLookUpEdit16"
        Me.SearchLookUpEdit16.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.SearchLookUpEdit16.Properties.DataSource = Me.EOALANSISCARYYBAGTIPIBindingSource
        Me.SearchLookUpEdit16.Properties.DisplayMember = "STOK_ADI"
        Me.SearchLookUpEdit16.Properties.NullText = ""
        Me.SearchLookUpEdit16.Properties.PopupSizeable = False
        Me.SearchLookUpEdit16.Properties.PopupView = Me.GridView16
        Me.SearchLookUpEdit16.Properties.ValueMember = "STOK_ADI"
        Me.SearchLookUpEdit16.Size = New System.Drawing.Size(392, 23)
        Me.SearchLookUpEdit16.TabIndex = 86
        '
        'EOALANSISCARYYBAGTIPIBindingSource
        '
        Me.EOALANSISCARYYBAGTIPIBindingSource.DataMember = "EO_ALANSIS_CARYYBAGTIPI"
        Me.EOALANSISCARYYBAGTIPIBindingSource.DataSource = Me.ALANAR2021DataSet11BindingSource
        '
        'GridView16
        '
        Me.GridView16.DetailHeight = 431
        Me.GridView16.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView16.Name = "GridView16"
        Me.GridView16.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView16.OptionsView.ShowGroupPanel = False
        '
        'ComboBoxEdit20
        '
        Me.ComboBoxEdit20.Location = New System.Drawing.Point(729, 79)
        Me.ComboBoxEdit20.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.ComboBoxEdit20.Name = "ComboBoxEdit20"
        Me.ComboBoxEdit20.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.ComboBoxEdit20.Properties.Items.AddRange(New Object() {"Palet Tipi", "Kutu-Kasa Tipi", "Kutu Etiket Tipi", "Ebat Etiket Tipi", "Şapka Tipi", "Köşebent Tipi", "Nem Bezi Tipi", "Klips Tipi", "CarryBag Tpi", "Poşet Tipi"})
        Me.ComboBoxEdit20.Size = New System.Drawing.Size(143, 23)
        Me.ComboBoxEdit20.TabIndex = 102
        '
        'ComboBoxEdit21
        '
        Me.ComboBoxEdit21.Location = New System.Drawing.Point(729, 47)
        Me.ComboBoxEdit21.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.ComboBoxEdit21.Name = "ComboBoxEdit21"
        Me.ComboBoxEdit21.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.ComboBoxEdit21.Properties.Items.AddRange(New Object() {"Palet Tipi", "Kutu-Kasa Tipi", "Kutu Etiket Tipi", "Ebat Etiket Tipi", "Şapka Tipi", "Köşebent Tipi", "Nem Bezi Tipi", "Klips Tipi", "CarryBag Tpi", "Poşet Tipi"})
        Me.ComboBoxEdit21.Size = New System.Drawing.Size(143, 23)
        Me.ComboBoxEdit21.TabIndex = 101
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(734, 28)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(72, 17)
        Me.Label2.TabIndex = 100
        Me.Label2.Text = "Reçete Tip"
        '
        'SearchLookUpEdit17
        '
        Me.SearchLookUpEdit17.Location = New System.Drawing.Point(880, 175)
        Me.SearchLookUpEdit17.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.SearchLookUpEdit17.Name = "SearchLookUpEdit17"
        Me.SearchLookUpEdit17.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.SearchLookUpEdit17.Properties.DataSource = Me.EOALANSISSABKATIPIBindingSource
        Me.SearchLookUpEdit17.Properties.DisplayMember = "STOK_ADI"
        Me.SearchLookUpEdit17.Properties.NullText = ""
        Me.SearchLookUpEdit17.Properties.PopupSizeable = False
        Me.SearchLookUpEdit17.Properties.PopupView = Me.GridView17
        Me.SearchLookUpEdit17.Properties.ValueMember = "STOK_ADI"
        Me.SearchLookUpEdit17.Size = New System.Drawing.Size(392, 23)
        Me.SearchLookUpEdit17.TabIndex = 78
        '
        'EOALANSISSABKATIPIBindingSource
        '
        Me.EOALANSISSABKATIPIBindingSource.DataMember = "EO_ALANSIS_SABKATIPI"
        Me.EOALANSISSABKATIPIBindingSource.DataSource = Me.ALANAR2021DataSet11BindingSource
        '
        'GridView17
        '
        Me.GridView17.DetailHeight = 431
        Me.GridView17.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView17.Name = "GridView17"
        Me.GridView17.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView17.OptionsView.ShowGroupPanel = False
        '
        'SearchLookUpEdit18
        '
        Me.SearchLookUpEdit18.Location = New System.Drawing.Point(880, 271)
        Me.SearchLookUpEdit18.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.SearchLookUpEdit18.Name = "SearchLookUpEdit18"
        Me.SearchLookUpEdit18.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.SearchLookUpEdit18.Properties.DataSource = Me.EOALANSISKLIPSTIPIBindingSource
        Me.SearchLookUpEdit18.Properties.DisplayMember = "STOK_ADI"
        Me.SearchLookUpEdit18.Properties.NullText = ""
        Me.SearchLookUpEdit18.Properties.PopupSizeable = False
        Me.SearchLookUpEdit18.Properties.PopupView = Me.GridView18
        Me.SearchLookUpEdit18.Properties.ValueMember = "STOK_ADI"
        Me.SearchLookUpEdit18.Size = New System.Drawing.Size(392, 23)
        Me.SearchLookUpEdit18.TabIndex = 84
        '
        'EOALANSISKLIPSTIPIBindingSource
        '
        Me.EOALANSISKLIPSTIPIBindingSource.DataMember = "EO_ALANSIS_KLIPSTIPI"
        Me.EOALANSISKLIPSTIPIBindingSource.DataSource = Me.ALANAR2021DataSet11BindingSource
        '
        'GridView18
        '
        Me.GridView18.DetailHeight = 431
        Me.GridView18.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView18.Name = "GridView18"
        Me.GridView18.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView18.OptionsView.ShowGroupPanel = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(691, 340)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(28, 17)
        Me.Label5.TabIndex = 99
        Me.Label5.Text = "20."
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(691, 308)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(28, 17)
        Me.Label6.TabIndex = 98
        Me.Label6.Text = "19."
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(691, 276)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(28, 17)
        Me.Label7.TabIndex = 97
        Me.Label7.Text = "18."
        '
        'SearchLookUpEdit19
        '
        Me.SearchLookUpEdit19.Location = New System.Drawing.Point(880, 207)
        Me.SearchLookUpEdit19.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.SearchLookUpEdit19.Name = "SearchLookUpEdit19"
        Me.SearchLookUpEdit19.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.SearchLookUpEdit19.Properties.DataSource = Me.EOALANSISKOSEBENTTIPIBindingSource
        Me.SearchLookUpEdit19.Properties.DisplayMember = "STOK_ADI"
        Me.SearchLookUpEdit19.Properties.NullText = ""
        Me.SearchLookUpEdit19.Properties.PopupSizeable = False
        Me.SearchLookUpEdit19.Properties.PopupView = Me.GridView19
        Me.SearchLookUpEdit19.Properties.ValueMember = "STOK_ADI"
        Me.SearchLookUpEdit19.Size = New System.Drawing.Size(392, 23)
        Me.SearchLookUpEdit19.TabIndex = 80
        '
        'EOALANSISKOSEBENTTIPIBindingSource
        '
        Me.EOALANSISKOSEBENTTIPIBindingSource.DataMember = "EO_ALANSIS_KOSEBENTTIPI"
        Me.EOALANSISKOSEBENTTIPIBindingSource.DataSource = Me.ALANAR2021DataSet11BindingSource
        '
        'GridView19
        '
        Me.GridView19.DetailHeight = 431
        Me.GridView19.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView19.Name = "GridView19"
        Me.GridView19.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView19.OptionsView.ShowGroupPanel = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(691, 244)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(28, 17)
        Me.Label8.TabIndex = 96
        Me.Label8.Text = "17."
        '
        'SearchLookUpEdit20
        '
        Me.SearchLookUpEdit20.Location = New System.Drawing.Point(880, 239)
        Me.SearchLookUpEdit20.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.SearchLookUpEdit20.Name = "SearchLookUpEdit20"
        Me.SearchLookUpEdit20.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.SearchLookUpEdit20.Properties.DataSource = Me.EOALANSISNEMBEZITIPIBindingSource
        Me.SearchLookUpEdit20.Properties.DisplayMember = "STOK_ADI"
        Me.SearchLookUpEdit20.Properties.NullText = ""
        Me.SearchLookUpEdit20.Properties.PopupSizeable = False
        Me.SearchLookUpEdit20.Properties.PopupView = Me.GridView20
        Me.SearchLookUpEdit20.Properties.ValueMember = "STOK_ADI"
        Me.SearchLookUpEdit20.Size = New System.Drawing.Size(392, 23)
        Me.SearchLookUpEdit20.TabIndex = 82
        '
        'EOALANSISNEMBEZITIPIBindingSource
        '
        Me.EOALANSISNEMBEZITIPIBindingSource.DataMember = "EO_ALANSIS_NEMBEZITIPI"
        Me.EOALANSISNEMBEZITIPIBindingSource.DataSource = Me.ALANAR2021DataSet11BindingSource
        '
        'GridView20
        '
        Me.GridView20.DetailHeight = 431
        Me.GridView20.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView20.Name = "GridView20"
        Me.GridView20.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView20.OptionsView.ShowGroupPanel = False
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(691, 212)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(28, 17)
        Me.Label9.TabIndex = 95
        Me.Label9.Text = "16."
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(691, 180)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(28, 17)
        Me.Label10.TabIndex = 94
        Me.Label10.Text = "15."
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(691, 148)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(28, 17)
        Me.Label11.TabIndex = 93
        Me.Label11.Text = "14."
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(691, 116)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(28, 17)
        Me.Label13.TabIndex = 92
        Me.Label13.Text = "13."
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(691, 82)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(28, 17)
        Me.Label14.TabIndex = 91
        Me.Label14.Text = "12."
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Location = New System.Drawing.Point(691, 50)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(28, 17)
        Me.Label26.TabIndex = 90
        Me.Label26.Text = "11."
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.Location = New System.Drawing.Point(691, 28)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(29, 17)
        Me.Label30.TabIndex = 89
        Me.Label30.Text = "No."
        '
        'Label31
        '
        Me.Label31.AutoSize = True
        Me.Label31.Location = New System.Drawing.Point(1294, 28)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(44, 17)
        Me.Label31.TabIndex = 70
        Me.Label31.Text = "Miktar"
        '
        'Label32
        '
        Me.Label32.AutoSize = True
        Me.Label32.Location = New System.Drawing.Point(986, 28)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(183, 17)
        Me.Label32.TabIndex = 69
        Me.Label32.Text = "Reçete Tanımlı Hammaddeler"
        '
        'ComboBoxEdit11
        '
        Me.ComboBoxEdit11.Location = New System.Drawing.Point(44, 336)
        Me.ComboBoxEdit11.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.ComboBoxEdit11.Name = "ComboBoxEdit11"
        Me.ComboBoxEdit11.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.ComboBoxEdit11.Properties.Items.AddRange(New Object() {"Palet Tipi", "Kutu-Kasa Tipi", "Kutu Etiket Tipi", "Ebat Etiket Tipi", "Şapka Tipi", "Köşebent Tipi", "Nem Bezi Tipi", "Klips Tipi", "CarryBag Tpi", "Poşet Tipi"})
        Me.ComboBoxEdit11.Size = New System.Drawing.Size(143, 23)
        Me.ComboBoxEdit11.TabIndex = 66
        '
        'ComboBoxEdit10
        '
        Me.ComboBoxEdit10.Location = New System.Drawing.Point(44, 304)
        Me.ComboBoxEdit10.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.ComboBoxEdit10.Name = "ComboBoxEdit10"
        Me.ComboBoxEdit10.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.ComboBoxEdit10.Properties.Items.AddRange(New Object() {"Palet Tipi", "Kutu-Kasa Tipi", "Kutu Etiket Tipi", "Ebat Etiket Tipi", "Şapka Tipi", "Köşebent Tipi", "Nem Bezi Tipi", "Klips Tipi", "CarryBag Tpi", "Poşet Tipi"})
        Me.ComboBoxEdit10.Size = New System.Drawing.Size(143, 23)
        Me.ComboBoxEdit10.TabIndex = 65
        '
        'ComboBoxEdit9
        '
        Me.ComboBoxEdit9.Location = New System.Drawing.Point(44, 272)
        Me.ComboBoxEdit9.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.ComboBoxEdit9.Name = "ComboBoxEdit9"
        Me.ComboBoxEdit9.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.ComboBoxEdit9.Properties.Items.AddRange(New Object() {"Palet Tipi", "Kutu-Kasa Tipi", "Kutu Etiket Tipi", "Ebat Etiket Tipi", "Şapka Tipi", "Köşebent Tipi", "Nem Bezi Tipi", "Klips Tipi", "CarryBag Tpi", "Poşet Tipi"})
        Me.ComboBoxEdit9.Size = New System.Drawing.Size(143, 23)
        Me.ComboBoxEdit9.TabIndex = 64
        '
        'TextEdit1
        '
        Me.TextEdit1.Location = New System.Drawing.Point(594, 79)
        Me.TextEdit1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TextEdit1.Name = "TextEdit1"
        Me.TextEdit1.Size = New System.Drawing.Size(63, 23)
        Me.TextEdit1.TabIndex = 7
        '
        'TextEdit3
        '
        Me.TextEdit3.Location = New System.Drawing.Point(594, 111)
        Me.TextEdit3.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TextEdit3.Name = "TextEdit3"
        Me.TextEdit3.Size = New System.Drawing.Size(63, 23)
        Me.TextEdit3.TabIndex = 10
        '
        'ComboBoxEdit8
        '
        Me.ComboBoxEdit8.Location = New System.Drawing.Point(44, 240)
        Me.ComboBoxEdit8.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.ComboBoxEdit8.Name = "ComboBoxEdit8"
        Me.ComboBoxEdit8.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.ComboBoxEdit8.Properties.Items.AddRange(New Object() {"Palet Tipi", "Kutu-Kasa Tipi", "Kutu Etiket Tipi", "Ebat Etiket Tipi", "Şapka Tipi", "Köşebent Tipi", "Nem Bezi Tipi", "Klips Tipi", "CarryBag Tpi", "Poşet Tipi"})
        Me.ComboBoxEdit8.Size = New System.Drawing.Size(143, 23)
        Me.ComboBoxEdit8.TabIndex = 63
        '
        'TextEdit20
        '
        Me.TextEdit20.Location = New System.Drawing.Point(594, 335)
        Me.TextEdit20.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TextEdit20.Name = "TextEdit20"
        Me.TextEdit20.Size = New System.Drawing.Size(63, 23)
        Me.TextEdit20.TabIndex = 41
        '
        'SearchLookUpEdit2
        '
        Me.SearchLookUpEdit2.Location = New System.Drawing.Point(195, 79)
        Me.SearchLookUpEdit2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.SearchLookUpEdit2.Name = "SearchLookUpEdit2"
        Me.SearchLookUpEdit2.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.SearchLookUpEdit2.Properties.DataSource = Me.EOALANSISEBATETIKETTIPIDEPOBindingSource
        Me.SearchLookUpEdit2.Properties.DisplayMember = "STOK_ADI"
        Me.SearchLookUpEdit2.Properties.NullText = ""
        Me.SearchLookUpEdit2.Properties.PopupSizeable = False
        Me.SearchLookUpEdit2.Properties.PopupView = Me.GridView2
        Me.SearchLookUpEdit2.Properties.ValueMember = "STOK_ADI"
        Me.SearchLookUpEdit2.Size = New System.Drawing.Size(392, 23)
        Me.SearchLookUpEdit2.TabIndex = 8
        '
        'EOALANSISEBATETIKETTIPIDEPOBindingSource
        '
        Me.EOALANSISEBATETIKETTIPIDEPOBindingSource.DataMember = "EO_ALANSIS_EBATETIKETTIPIDEPO"
        Me.EOALANSISEBATETIKETTIPIDEPOBindingSource.DataSource = Me.ALANSISDataSet3BindingSource
        '
        'ALANSISDataSet3BindingSource
        '
        Me.ALANSISDataSet3BindingSource.DataSource = Me.ALANSISDataSet3
        Me.ALANSISDataSet3BindingSource.Position = 0
        '
        'ALANSISDataSet3
        '
        Me.ALANSISDataSet3.DataSetName = "ALANSISDataSet3"
        Me.ALANSISDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GridView2
        '
        Me.GridView2.DetailHeight = 431
        Me.GridView2.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView2.Name = "GridView2"
        Me.GridView2.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView2.OptionsView.ShowGroupPanel = False
        '
        'TextEdit4
        '
        Me.TextEdit4.Location = New System.Drawing.Point(594, 143)
        Me.TextEdit4.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TextEdit4.Name = "TextEdit4"
        Me.TextEdit4.Size = New System.Drawing.Size(63, 23)
        Me.TextEdit4.TabIndex = 13
        '
        'ComboBoxEdit7
        '
        Me.ComboBoxEdit7.Location = New System.Drawing.Point(44, 208)
        Me.ComboBoxEdit7.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.ComboBoxEdit7.Name = "ComboBoxEdit7"
        Me.ComboBoxEdit7.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.ComboBoxEdit7.Properties.Items.AddRange(New Object() {"Palet Tipi", "Kutu-Kasa Tipi", "Kutu Etiket Tipi", "Ebat Etiket Tipi", "Şapka Tipi", "Köşebent Tipi", "Nem Bezi Tipi", "Klips Tipi", "CarryBag Tpi", "Poşet Tipi"})
        Me.ComboBoxEdit7.Size = New System.Drawing.Size(143, 23)
        Me.ComboBoxEdit7.TabIndex = 62
        '
        'TextEdit18
        '
        Me.TextEdit18.Location = New System.Drawing.Point(594, 303)
        Me.TextEdit18.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TextEdit18.Name = "TextEdit18"
        Me.TextEdit18.Size = New System.Drawing.Size(63, 23)
        Me.TextEdit18.TabIndex = 37
        '
        'SearchLookUpEdit10
        '
        Me.SearchLookUpEdit10.Location = New System.Drawing.Point(195, 335)
        Me.SearchLookUpEdit10.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.SearchLookUpEdit10.Name = "SearchLookUpEdit10"
        Me.SearchLookUpEdit10.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.SearchLookUpEdit10.Properties.DataSource = Me.EOALANSISPOSETTIPIBindingSource
        Me.SearchLookUpEdit10.Properties.DisplayMember = "STOK_ADI"
        Me.SearchLookUpEdit10.Properties.NullText = ""
        Me.SearchLookUpEdit10.Properties.PopupSizeable = False
        Me.SearchLookUpEdit10.Properties.PopupView = Me.GridView10
        Me.SearchLookUpEdit10.Properties.ValueMember = "STOK_ADI"
        Me.SearchLookUpEdit10.Size = New System.Drawing.Size(392, 23)
        Me.SearchLookUpEdit10.TabIndex = 42
        '
        'GridView10
        '
        Me.GridView10.DetailHeight = 431
        Me.GridView10.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView10.Name = "GridView10"
        Me.GridView10.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView10.OptionsView.ShowGroupPanel = False
        '
        'TextEdit5
        '
        Me.TextEdit5.Location = New System.Drawing.Point(594, 175)
        Me.TextEdit5.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TextEdit5.Name = "TextEdit5"
        Me.TextEdit5.Size = New System.Drawing.Size(63, 23)
        Me.TextEdit5.TabIndex = 16
        '
        'TextEdit8
        '
        Me.TextEdit8.Location = New System.Drawing.Point(594, 271)
        Me.TextEdit8.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TextEdit8.Name = "TextEdit8"
        Me.TextEdit8.Size = New System.Drawing.Size(63, 23)
        Me.TextEdit8.TabIndex = 25
        '
        'SearchLookUpEdit3
        '
        Me.SearchLookUpEdit3.Location = New System.Drawing.Point(195, 111)
        Me.SearchLookUpEdit3.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.SearchLookUpEdit3.Name = "SearchLookUpEdit3"
        Me.SearchLookUpEdit3.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.SearchLookUpEdit3.Properties.DataSource = Me.EOALANSISKUTUTIPIBindingSource
        Me.SearchLookUpEdit3.Properties.DisplayMember = "STOK_ADI"
        Me.SearchLookUpEdit3.Properties.NullText = ""
        Me.SearchLookUpEdit3.Properties.PopupSizeable = False
        Me.SearchLookUpEdit3.Properties.PopupView = Me.GridView3
        Me.SearchLookUpEdit3.Properties.ValueMember = "STOK_ADI"
        Me.SearchLookUpEdit3.Size = New System.Drawing.Size(392, 23)
        Me.SearchLookUpEdit3.TabIndex = 11
        '
        'GridView3
        '
        Me.GridView3.DetailHeight = 431
        Me.GridView3.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView3.Name = "GridView3"
        Me.GridView3.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView3.OptionsView.ShowGroupPanel = False
        '
        'TextEdit6
        '
        Me.TextEdit6.Location = New System.Drawing.Point(594, 207)
        Me.TextEdit6.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TextEdit6.Name = "TextEdit6"
        Me.TextEdit6.Size = New System.Drawing.Size(63, 23)
        Me.TextEdit6.TabIndex = 19
        '
        'SearchLookUpEdit1
        '
        Me.SearchLookUpEdit1.EditValue = ""
        Me.SearchLookUpEdit1.Location = New System.Drawing.Point(195, 47)
        Me.SearchLookUpEdit1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.SearchLookUpEdit1.Name = "SearchLookUpEdit1"
        Me.SearchLookUpEdit1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.SearchLookUpEdit1.Properties.DataSource = Me.EOALANSISYARDDEPOBindingSource
        Me.SearchLookUpEdit1.Properties.DisplayMember = "STOK_ADI"
        Me.SearchLookUpEdit1.Properties.NullText = ""
        Me.SearchLookUpEdit1.Properties.PopupSizeable = False
        Me.SearchLookUpEdit1.Properties.PopupView = Me.GridView1
        Me.SearchLookUpEdit1.Properties.ValueMember = "STOK_ADI"
        Me.SearchLookUpEdit1.Size = New System.Drawing.Size(392, 23)
        Me.SearchLookUpEdit1.TabIndex = 3
        '
        'EOALANSISYARDDEPOBindingSource
        '
        Me.EOALANSISYARDDEPOBindingSource.DataMember = "EO_ALANSIS_YARDDEPO"
        Me.EOALANSISYARDDEPOBindingSource.DataSource = Me.ALANSISDataSet4
        '
        'ALANSISDataSet4
        '
        Me.ALANSISDataSet4.DataSetName = "ALANSISDataSet4"
        Me.ALANSISDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GridView1
        '
        Me.GridView1.DetailHeight = 431
        Me.GridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView1.OptionsView.ShowGroupPanel = False
        '
        'TextEdit7
        '
        Me.TextEdit7.Location = New System.Drawing.Point(594, 239)
        Me.TextEdit7.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TextEdit7.Name = "TextEdit7"
        Me.TextEdit7.Size = New System.Drawing.Size(63, 23)
        Me.TextEdit7.TabIndex = 22
        '
        'ComboBoxEdit6
        '
        Me.ComboBoxEdit6.Location = New System.Drawing.Point(44, 176)
        Me.ComboBoxEdit6.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.ComboBoxEdit6.Name = "ComboBoxEdit6"
        Me.ComboBoxEdit6.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.ComboBoxEdit6.Properties.Items.AddRange(New Object() {"Palet Tipi", "Kutu-Kasa Tipi", "Kutu Etiket Tipi", "Ebat Etiket Tipi", "Şapka Tipi", "Köşebent Tipi", "Nem Bezi Tipi", "Klips Tipi", "CarryBag Tpi", "Poşet Tipi"})
        Me.ComboBoxEdit6.Size = New System.Drawing.Size(143, 23)
        Me.ComboBoxEdit6.TabIndex = 61
        '
        'ComboBoxEdit5
        '
        Me.ComboBoxEdit5.Location = New System.Drawing.Point(44, 144)
        Me.ComboBoxEdit5.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.ComboBoxEdit5.Name = "ComboBoxEdit5"
        Me.ComboBoxEdit5.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.ComboBoxEdit5.Properties.Items.AddRange(New Object() {"Palet Tipi", "Kutu-Kasa Tipi", "Kutu Etiket Tipi", "Ebat Etiket Tipi", "Şapka Tipi", "Köşebent Tipi", "Nem Bezi Tipi", "Klips Tipi", "CarryBag Tpi", "Poşet Tipi"})
        Me.ComboBoxEdit5.Size = New System.Drawing.Size(143, 23)
        Me.ComboBoxEdit5.TabIndex = 60
        '
        'SearchLookUpEdit4
        '
        Me.SearchLookUpEdit4.Location = New System.Drawing.Point(195, 143)
        Me.SearchLookUpEdit4.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.SearchLookUpEdit4.Name = "SearchLookUpEdit4"
        Me.SearchLookUpEdit4.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.SearchLookUpEdit4.Properties.DataSource = Me.EOALANSISEBATETIKETTIPIBindingSource
        Me.SearchLookUpEdit4.Properties.DisplayMember = "STOK_ADI"
        Me.SearchLookUpEdit4.Properties.NullText = ""
        Me.SearchLookUpEdit4.Properties.PopupSizeable = False
        Me.SearchLookUpEdit4.Properties.PopupView = Me.GridView4
        Me.SearchLookUpEdit4.Properties.ValueMember = "STOK_ADI"
        Me.SearchLookUpEdit4.Size = New System.Drawing.Size(392, 23)
        Me.SearchLookUpEdit4.TabIndex = 14
        '
        'GridView4
        '
        Me.GridView4.DetailHeight = 431
        Me.GridView4.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView4.Name = "GridView4"
        Me.GridView4.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView4.OptionsView.ShowGroupPanel = False
        '
        'ComboBoxEdit4
        '
        Me.ComboBoxEdit4.Location = New System.Drawing.Point(44, 112)
        Me.ComboBoxEdit4.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.ComboBoxEdit4.Name = "ComboBoxEdit4"
        Me.ComboBoxEdit4.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.ComboBoxEdit4.Properties.Items.AddRange(New Object() {"Palet Tipi", "Kutu-Kasa Tipi", "Kutu Etiket Tipi", "Ebat Etiket Tipi", "Şapka Tipi", "Köşebent Tipi", "Nem Bezi Tipi", "Klips Tipi", "CarryBag Tpi", "Poşet Tipi"})
        Me.ComboBoxEdit4.Size = New System.Drawing.Size(143, 23)
        Me.ComboBoxEdit4.TabIndex = 59
        '
        'SearchLookUpEdit9
        '
        Me.SearchLookUpEdit9.Location = New System.Drawing.Point(195, 303)
        Me.SearchLookUpEdit9.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.SearchLookUpEdit9.Name = "SearchLookUpEdit9"
        Me.SearchLookUpEdit9.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.SearchLookUpEdit9.Properties.DataSource = Me.EOALANSISCARYYBAGTIPIBindingSource
        Me.SearchLookUpEdit9.Properties.DisplayMember = "STOK_ADI"
        Me.SearchLookUpEdit9.Properties.NullText = ""
        Me.SearchLookUpEdit9.Properties.PopupSizeable = False
        Me.SearchLookUpEdit9.Properties.PopupView = Me.GridView9
        Me.SearchLookUpEdit9.Properties.ValueMember = "STOK_ADI"
        Me.SearchLookUpEdit9.Size = New System.Drawing.Size(392, 23)
        Me.SearchLookUpEdit9.TabIndex = 38
        '
        'GridView9
        '
        Me.GridView9.DetailHeight = 431
        Me.GridView9.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView9.Name = "GridView9"
        Me.GridView9.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView9.OptionsView.ShowGroupPanel = False
        '
        'ComboBoxEdit3
        '
        Me.ComboBoxEdit3.Location = New System.Drawing.Point(44, 79)
        Me.ComboBoxEdit3.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.ComboBoxEdit3.Name = "ComboBoxEdit3"
        Me.ComboBoxEdit3.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.ComboBoxEdit3.Properties.Items.AddRange(New Object() {"Palet Tipi", "Kutu-Kasa Tipi", "Kutu Etiket Tipi", "Ebat Etiket Tipi", "Şapka Tipi", "Köşebent Tipi", "Nem Bezi Tipi", "Klips Tipi", "CarryBag Tpi", "Poşet Tipi"})
        Me.ComboBoxEdit3.Size = New System.Drawing.Size(143, 23)
        Me.ComboBoxEdit3.TabIndex = 58
        '
        'ComboBoxEdit2
        '
        Me.ComboBoxEdit2.Location = New System.Drawing.Point(44, 47)
        Me.ComboBoxEdit2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.ComboBoxEdit2.Name = "ComboBoxEdit2"
        Me.ComboBoxEdit2.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.ComboBoxEdit2.Properties.Items.AddRange(New Object() {"Palet Tipi", "Kutu-Kasa Tipi", "Kutu Etiket Tipi", "Ebat Etiket Tipi", "Şapka Tipi", "Köşebent Tipi", "Nem Bezi Tipi", "Klips Tipi", "CarryBag Tpi", "Poşet Tipi"})
        Me.ComboBoxEdit2.Size = New System.Drawing.Size(143, 23)
        Me.ComboBoxEdit2.TabIndex = 57
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.Location = New System.Drawing.Point(49, 28)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(72, 17)
        Me.Label29.TabIndex = 56
        Me.Label29.Text = "Reçete Tip"
        '
        'SearchLookUpEdit5
        '
        Me.SearchLookUpEdit5.Location = New System.Drawing.Point(195, 175)
        Me.SearchLookUpEdit5.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.SearchLookUpEdit5.Name = "SearchLookUpEdit5"
        Me.SearchLookUpEdit5.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.SearchLookUpEdit5.Properties.DataSource = Me.EOALANSISSABKATIPIBindingSource
        Me.SearchLookUpEdit5.Properties.DisplayMember = "STOK_ADI"
        Me.SearchLookUpEdit5.Properties.NullText = ""
        Me.SearchLookUpEdit5.Properties.PopupSizeable = False
        Me.SearchLookUpEdit5.Properties.PopupView = Me.GridView5
        Me.SearchLookUpEdit5.Properties.ValueMember = "STOK_ADI"
        Me.SearchLookUpEdit5.Size = New System.Drawing.Size(392, 23)
        Me.SearchLookUpEdit5.TabIndex = 17
        '
        'GridView5
        '
        Me.GridView5.DetailHeight = 431
        Me.GridView5.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView5.Name = "GridView5"
        Me.GridView5.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView5.OptionsView.ShowGroupPanel = False
        '
        'SearchLookUpEdit8
        '
        Me.SearchLookUpEdit8.Location = New System.Drawing.Point(195, 271)
        Me.SearchLookUpEdit8.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.SearchLookUpEdit8.Name = "SearchLookUpEdit8"
        Me.SearchLookUpEdit8.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.SearchLookUpEdit8.Properties.DataSource = Me.EOALANSISKLIPSTIPIBindingSource
        Me.SearchLookUpEdit8.Properties.DisplayMember = "STOK_ADI"
        Me.SearchLookUpEdit8.Properties.NullText = ""
        Me.SearchLookUpEdit8.Properties.PopupSizeable = False
        Me.SearchLookUpEdit8.Properties.PopupView = Me.GridView8
        Me.SearchLookUpEdit8.Properties.ValueMember = "STOK_ADI"
        Me.SearchLookUpEdit8.Size = New System.Drawing.Size(392, 23)
        Me.SearchLookUpEdit8.TabIndex = 26
        '
        'GridView8
        '
        Me.GridView8.DetailHeight = 431
        Me.GridView8.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView8.Name = "GridView8"
        Me.GridView8.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView8.OptionsView.ShowGroupPanel = False
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Location = New System.Drawing.Point(6, 340)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(28, 17)
        Me.Label27.TabIndex = 54
        Me.Label27.Text = "10."
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.Location = New System.Drawing.Point(6, 308)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(20, 17)
        Me.Label28.TabIndex = 53
        Me.Label28.Text = "9."
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(6, 276)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(20, 17)
        Me.Label22.TabIndex = 52
        Me.Label22.Text = "8."
        '
        'SearchLookUpEdit6
        '
        Me.SearchLookUpEdit6.Location = New System.Drawing.Point(195, 207)
        Me.SearchLookUpEdit6.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.SearchLookUpEdit6.Name = "SearchLookUpEdit6"
        Me.SearchLookUpEdit6.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.SearchLookUpEdit6.Properties.DataSource = Me.EOALANSISKOSEBENTTIPIBindingSource
        Me.SearchLookUpEdit6.Properties.DisplayMember = "STOK_ADI"
        Me.SearchLookUpEdit6.Properties.NullText = ""
        Me.SearchLookUpEdit6.Properties.PopupSizeable = False
        Me.SearchLookUpEdit6.Properties.PopupView = Me.GridView6
        Me.SearchLookUpEdit6.Properties.ValueMember = "STOK_ADI"
        Me.SearchLookUpEdit6.Size = New System.Drawing.Size(392, 23)
        Me.SearchLookUpEdit6.TabIndex = 20
        '
        'GridView6
        '
        Me.GridView6.DetailHeight = 431
        Me.GridView6.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView6.Name = "GridView6"
        Me.GridView6.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView6.OptionsView.ShowGroupPanel = False
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Location = New System.Drawing.Point(6, 244)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(20, 17)
        Me.Label23.TabIndex = 51
        Me.Label23.Text = "7."
        '
        'SearchLookUpEdit7
        '
        Me.SearchLookUpEdit7.Location = New System.Drawing.Point(195, 239)
        Me.SearchLookUpEdit7.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.SearchLookUpEdit7.Name = "SearchLookUpEdit7"
        Me.SearchLookUpEdit7.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.SearchLookUpEdit7.Properties.DataSource = Me.EOALANSISNEMBEZITIPIBindingSource
        Me.SearchLookUpEdit7.Properties.DisplayMember = "STOK_ADI"
        Me.SearchLookUpEdit7.Properties.NullText = ""
        Me.SearchLookUpEdit7.Properties.PopupSizeable = False
        Me.SearchLookUpEdit7.Properties.PopupView = Me.GridView7
        Me.SearchLookUpEdit7.Properties.ValueMember = "STOK_ADI"
        Me.SearchLookUpEdit7.Size = New System.Drawing.Size(392, 23)
        Me.SearchLookUpEdit7.TabIndex = 23
        '
        'GridView7
        '
        Me.GridView7.DetailHeight = 431
        Me.GridView7.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView7.Name = "GridView7"
        Me.GridView7.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView7.OptionsView.ShowGroupPanel = False
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Location = New System.Drawing.Point(6, 212)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(20, 17)
        Me.Label24.TabIndex = 50
        Me.Label24.Text = "6."
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Location = New System.Drawing.Point(6, 180)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(20, 17)
        Me.Label25.TabIndex = 49
        Me.Label25.Text = "5."
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(6, 148)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(20, 17)
        Me.Label17.TabIndex = 48
        Me.Label17.Text = "4."
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(6, 116)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(20, 17)
        Me.Label19.TabIndex = 47
        Me.Label19.Text = "3."
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(6, 82)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(20, 17)
        Me.Label16.TabIndex = 46
        Me.Label16.Text = "2."
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(6, 50)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(20, 17)
        Me.Label15.TabIndex = 45
        Me.Label15.Text = "1."
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(6, 28)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(29, 17)
        Me.Label12.TabIndex = 44
        Me.Label12.Text = "No."
        '
        'SimpleButton4
        '
        Me.SimpleButton4.Location = New System.Drawing.Point(1176, 369)
        Me.SimpleButton4.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.SimpleButton4.Name = "SimpleButton4"
        Me.SimpleButton4.Size = New System.Drawing.Size(166, 36)
        Me.SimpleButton4.TabIndex = 7
        Me.SimpleButton4.Text = "Kaydet"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(609, 28)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(44, 17)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Miktar"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(301, 28)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(183, 17)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Reçete Tanımlı Hammaddeler"
        '
        'EOALANSISPOSETTIPIDEPOBindingSource
        '
        Me.EOALANSISPOSETTIPIDEPOBindingSource.DataMember = "EO_ALANSIS_POSETTIPIDEPO"
        Me.EOALANSISPOSETTIPIDEPOBindingSource.DataSource = Me.ALANSISDataSet3BindingSource
        '
        'EOALANSISCARYYBAGTIPIDEPOBindingSource
        '
        Me.EOALANSISCARYYBAGTIPIDEPOBindingSource.DataMember = "EO_ALANSIS_CARYYBAGTIPIDEPO"
        Me.EOALANSISCARYYBAGTIPIDEPOBindingSource.DataSource = Me.ALANSISDataSet3BindingSource
        '
        'ALANAR2021DataSet1
        '
        Me.ALANAR2021DataSet1.DataSetName = "ALANAR2021DataSet1"
        Me.ALANAR2021DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'EO_ALANSIS_PALETTIPITableAdapter
        '
        Me.EO_ALANSIS_PALETTIPITableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.Connection = Nothing
        Me.TableAdapterManager.UpdateOrder = WindowsApplication1.ALANAR2021DataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'SqlDataSource1
        '
        Me.SqlDataSource1.ConnectionName = "ALANAR2021ConnectionString"
        Me.SqlDataSource1.Name = "SqlDataSource1"
        ColumnExpression1.ColumnName = "STOK_KODU"
        Table1.MetaSerializable = "<Meta X=""30"" Y=""30"" Width=""125"" Height=""103"" />"
        Table1.Name = "EO_ALANSIS_POSETTIPI"
        ColumnExpression1.Table = Table1
        Column1.Expression = ColumnExpression1
        ColumnExpression2.ColumnName = "STOK_ADI"
        ColumnExpression2.Table = Table1
        Column2.Expression = ColumnExpression2
        SelectQuery1.Columns.Add(Column1)
        SelectQuery1.Columns.Add(Column2)
        SelectQuery1.Name = "EO_ALANSIS_POSETTIPI"
        SelectQuery1.Tables.Add(Table1)
        Me.SqlDataSource1.Queries.AddRange(New DevExpress.DataAccess.Sql.SqlQuery() {SelectQuery1})
        Me.SqlDataSource1.ResultSchemaSerializable = resources.GetString("SqlDataSource1.ResultSchemaSerializable")
        '
        'eO_ALANSIS_POSETTIPIBindingSource
        '
        Me.eO_ALANSIS_POSETTIPIBindingSource.DataMember = "EO_ALANSIS_POSETTIPI"
        Me.eO_ALANSIS_POSETTIPIBindingSource.DataSource = Me.SqlDataSource1
        '
        'EO_ALANSIS_KASATIPITableAdapter
        '
        Me.EO_ALANSIS_KASATIPITableAdapter.ClearBeforeFill = True
        '
        'EO_ALANSIS_KUTUTIPITableAdapter
        '
        Me.EO_ALANSIS_KUTUTIPITableAdapter.ClearBeforeFill = True
        '
        'EO_ALANSIS_EBATETIKETTIPITableAdapter
        '
        Me.EO_ALANSIS_EBATETIKETTIPITableAdapter.ClearBeforeFill = True
        '
        'EO_ALANSIS_SABKATIPITableAdapter
        '
        Me.EO_ALANSIS_SABKATIPITableAdapter.ClearBeforeFill = True
        '
        'EO_ALANSIS_KOSEBENTTIPITableAdapter
        '
        Me.EO_ALANSIS_KOSEBENTTIPITableAdapter.ClearBeforeFill = True
        '
        'EO_ALANSIS_NEMBEZITIPITableAdapter
        '
        Me.EO_ALANSIS_NEMBEZITIPITableAdapter.ClearBeforeFill = True
        '
        'EO_ALANSIS_KLIPSTIPITableAdapter
        '
        Me.EO_ALANSIS_KLIPSTIPITableAdapter.ClearBeforeFill = True
        '
        'EO_ALANSIS_CARYYBAGTIPITableAdapter
        '
        Me.EO_ALANSIS_CARYYBAGTIPITableAdapter.ClearBeforeFill = True
        '
        'EO_ALANSIS_POSETTIPITableAdapter
        '
        Me.EO_ALANSIS_POSETTIPITableAdapter.ClearBeforeFill = True
        '
        'TextEdit21
        '
        Me.TextEdit21.Location = New System.Drawing.Point(62, 31)
        Me.TextEdit21.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TextEdit21.Name = "TextEdit21"
        Me.TextEdit21.Size = New System.Drawing.Size(135, 23)
        Me.TextEdit21.TabIndex = 8
        '
        'TextEdit22
        '
        Me.TextEdit22.Location = New System.Drawing.Point(286, 31)
        Me.TextEdit22.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TextEdit22.Name = "TextEdit22"
        Me.TextEdit22.Size = New System.Drawing.Size(210, 23)
        Me.TextEdit22.TabIndex = 10
        '
        'TextEdit23
        '
        Me.TextEdit23.Location = New System.Drawing.Point(534, 31)
        Me.TextEdit23.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TextEdit23.Name = "TextEdit23"
        Me.TextEdit23.Size = New System.Drawing.Size(126, 23)
        Me.TextEdit23.TabIndex = 12
        '
        'GroupControl3
        '
        Me.GroupControl3.Controls.Add(Me.TextEdit25)
        Me.GroupControl3.Controls.Add(Me.Label33)
        Me.GroupControl3.Controls.Add(Me.TextBox1)
        Me.GroupControl3.Controls.Add(Me.Panel1)
        Me.GroupControl3.Controls.Add(Me.TextEdit23)
        Me.GroupControl3.Controls.Add(Me.Label18)
        Me.GroupControl3.Controls.Add(Me.Label20)
        Me.GroupControl3.Controls.Add(Me.Label21)
        Me.GroupControl3.Controls.Add(Me.TextEdit22)
        Me.GroupControl3.Controls.Add(Me.TextEdit21)
        Me.GroupControl3.Location = New System.Drawing.Point(8, 4)
        Me.GroupControl3.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupControl3.Name = "GroupControl3"
        Me.GroupControl3.Size = New System.Drawing.Size(727, 95)
        Me.GroupControl3.TabIndex = 7
        Me.GroupControl3.Text = "Reçete Türetim Seçim"
        '
        'TextEdit25
        '
        Me.TextEdit25.Location = New System.Drawing.Point(62, 64)
        Me.TextEdit25.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TextEdit25.Name = "TextEdit25"
        Me.TextEdit25.Size = New System.Drawing.Size(434, 23)
        Me.TextEdit25.TabIndex = 16
        '
        'Label33
        '
        Me.Label33.AutoSize = True
        Me.Label33.Location = New System.Drawing.Point(6, 66)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(45, 17)
        Me.Label33.TabIndex = 15
        Me.Label33.Text = "Tanım"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(678, 63)
        Me.TextBox1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(21, 23)
        Me.TextBox1.TabIndex = 14
        Me.TextBox1.Visible = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Red
        Me.Panel1.Location = New System.Drawing.Point(678, 32)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(34, 22)
        Me.Panel1.TabIndex = 13
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(503, 34)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(26, 17)
        Me.Label18.TabIndex = 11
        Me.Label18.Text = "Tip"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(204, 34)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(83, 17)
        Me.Label20.TabIndex = 9
        Me.Label20.Text = "Mamul Kodu"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(2, 34)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(56, 17)
        Me.Label21.TabIndex = 7
        Me.Label21.Text = "Parti No"
        '
        'EO_ALANSIS_RECETEVWTableAdapter
        '
        Me.EO_ALANSIS_RECETEVWTableAdapter.ClearBeforeFill = True
        '
        'XtraTabControl1
        '
        Me.XtraTabControl1.Location = New System.Drawing.Point(8, 106)
        Me.XtraTabControl1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.XtraTabControl1.Name = "XtraTabControl1"
        Me.XtraTabControl1.SelectedTabPage = Me.XtraTabPage1
        Me.XtraTabControl1.Size = New System.Drawing.Size(1372, 448)
        Me.XtraTabControl1.TabIndex = 9
        Me.XtraTabControl1.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.XtraTabPage1, Me.XtraTabPage3})
        '
        'XtraTabPage1
        '
        Me.XtraTabPage1.Controls.Add(Me.GroupControl2)
        Me.XtraTabPage1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.XtraTabPage1.Name = "XtraTabPage1"
        Me.XtraTabPage1.Size = New System.Drawing.Size(1366, 418)
        Me.XtraTabPage1.Text = "Reçete Tanımlamaları"
        '
        'XtraTabPage3
        '
        Me.XtraTabPage3.Controls.Add(Me.GroupControl4)
        Me.XtraTabPage3.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.XtraTabPage3.Name = "XtraTabPage3"
        Me.XtraTabPage3.Size = New System.Drawing.Size(1366, 418)
        Me.XtraTabPage3.Text = "Reçete Türetim"
        '
        'GroupControl4
        '
        Me.GroupControl4.Controls.Add(Me.TextEdit46)
        Me.GroupControl4.Controls.Add(Me.TextEdit24)
        Me.GroupControl4.Controls.Add(Me.SearchLookUpEdit31)
        Me.GroupControl4.Controls.Add(Me.SearchLookUpEdit32)
        Me.GroupControl4.Controls.Add(Me.SearchLookUpEdit33)
        Me.GroupControl4.Controls.Add(Me.SearchLookUpEdit34)
        Me.GroupControl4.Controls.Add(Me.SearchLookUpEdit35)
        Me.GroupControl4.Controls.Add(Me.SearchLookUpEdit36)
        Me.GroupControl4.Controls.Add(Me.SearchLookUpEdit37)
        Me.GroupControl4.Controls.Add(Me.SearchLookUpEdit38)
        Me.GroupControl4.Controls.Add(Me.SearchLookUpEdit39)
        Me.GroupControl4.Controls.Add(Me.SearchLookUpEdit40)
        Me.GroupControl4.Controls.Add(Me.TextEdit57)
        Me.GroupControl4.Controls.Add(Me.TextEdit58)
        Me.GroupControl4.Controls.Add(Me.TextEdit59)
        Me.GroupControl4.Controls.Add(Me.TextEdit60)
        Me.GroupControl4.Controls.Add(Me.TextEdit61)
        Me.GroupControl4.Controls.Add(Me.TextEdit62)
        Me.GroupControl4.Controls.Add(Me.TextEdit63)
        Me.GroupControl4.Controls.Add(Me.TextEdit64)
        Me.GroupControl4.Controls.Add(Me.TextEdit65)
        Me.GroupControl4.Controls.Add(Me.SearchLookUpEdit21)
        Me.GroupControl4.Controls.Add(Me.SearchLookUpEdit22)
        Me.GroupControl4.Controls.Add(Me.SearchLookUpEdit23)
        Me.GroupControl4.Controls.Add(Me.SearchLookUpEdit24)
        Me.GroupControl4.Controls.Add(Me.SearchLookUpEdit25)
        Me.GroupControl4.Controls.Add(Me.SearchLookUpEdit26)
        Me.GroupControl4.Controls.Add(Me.SearchLookUpEdit27)
        Me.GroupControl4.Controls.Add(Me.SearchLookUpEdit28)
        Me.GroupControl4.Controls.Add(Me.SearchLookUpEdit29)
        Me.GroupControl4.Controls.Add(Me.SearchLookUpEdit30)
        Me.GroupControl4.Controls.Add(Me.TextEdit47)
        Me.GroupControl4.Controls.Add(Me.TextEdit48)
        Me.GroupControl4.Controls.Add(Me.TextEdit49)
        Me.GroupControl4.Controls.Add(Me.TextEdit50)
        Me.GroupControl4.Controls.Add(Me.TextEdit51)
        Me.GroupControl4.Controls.Add(Me.TextEdit52)
        Me.GroupControl4.Controls.Add(Me.TextEdit53)
        Me.GroupControl4.Controls.Add(Me.TextEdit54)
        Me.GroupControl4.Controls.Add(Me.TextEdit55)
        Me.GroupControl4.Controls.Add(Me.Panel3)
        Me.GroupControl4.Controls.Add(Me.TextEdit26)
        Me.GroupControl4.Controls.Add(Me.TextEdit27)
        Me.GroupControl4.Controls.Add(Me.TextEdit28)
        Me.GroupControl4.Controls.Add(Me.TextEdit29)
        Me.GroupControl4.Controls.Add(Me.TextEdit30)
        Me.GroupControl4.Controls.Add(Me.TextEdit31)
        Me.GroupControl4.Controls.Add(Me.TextEdit32)
        Me.GroupControl4.Controls.Add(Me.TextEdit33)
        Me.GroupControl4.Controls.Add(Me.TextEdit34)
        Me.GroupControl4.Controls.Add(Me.TextEdit35)
        Me.GroupControl4.Controls.Add(Me.Label34)
        Me.GroupControl4.Controls.Add(Me.Label35)
        Me.GroupControl4.Controls.Add(Me.Label36)
        Me.GroupControl4.Controls.Add(Me.Label37)
        Me.GroupControl4.Controls.Add(Me.Label38)
        Me.GroupControl4.Controls.Add(Me.Label39)
        Me.GroupControl4.Controls.Add(Me.Label40)
        Me.GroupControl4.Controls.Add(Me.Label41)
        Me.GroupControl4.Controls.Add(Me.Label42)
        Me.GroupControl4.Controls.Add(Me.Label43)
        Me.GroupControl4.Controls.Add(Me.Label44)
        Me.GroupControl4.Controls.Add(Me.Label45)
        Me.GroupControl4.Controls.Add(Me.Label46)
        Me.GroupControl4.Controls.Add(Me.Label47)
        Me.GroupControl4.Controls.Add(Me.TextEdit36)
        Me.GroupControl4.Controls.Add(Me.TextEdit37)
        Me.GroupControl4.Controls.Add(Me.TextEdit38)
        Me.GroupControl4.Controls.Add(Me.TextEdit39)
        Me.GroupControl4.Controls.Add(Me.TextEdit40)
        Me.GroupControl4.Controls.Add(Me.TextEdit41)
        Me.GroupControl4.Controls.Add(Me.TextEdit42)
        Me.GroupControl4.Controls.Add(Me.TextEdit43)
        Me.GroupControl4.Controls.Add(Me.TextEdit44)
        Me.GroupControl4.Controls.Add(Me.TextEdit45)
        Me.GroupControl4.Controls.Add(Me.Label48)
        Me.GroupControl4.Controls.Add(Me.Label49)
        Me.GroupControl4.Controls.Add(Me.Label50)
        Me.GroupControl4.Controls.Add(Me.Label51)
        Me.GroupControl4.Controls.Add(Me.Label52)
        Me.GroupControl4.Controls.Add(Me.Label53)
        Me.GroupControl4.Controls.Add(Me.Label54)
        Me.GroupControl4.Controls.Add(Me.Label55)
        Me.GroupControl4.Controls.Add(Me.Label56)
        Me.GroupControl4.Controls.Add(Me.Label57)
        Me.GroupControl4.Controls.Add(Me.Label58)
        Me.GroupControl4.Controls.Add(Me.Label59)
        Me.GroupControl4.Controls.Add(Me.SimpleButton6)
        Me.GroupControl4.Controls.Add(Me.Label60)
        Me.GroupControl4.Controls.Add(Me.Label61)
        Me.GroupControl4.Location = New System.Drawing.Point(5, 2)
        Me.GroupControl4.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupControl4.Name = "GroupControl4"
        Me.GroupControl4.Size = New System.Drawing.Size(1353, 411)
        Me.GroupControl4.TabIndex = 5
        Me.GroupControl4.Text = "Reçete Oluştur"
        '
        'TextEdit46
        '
        Me.TextEdit46.Location = New System.Drawing.Point(1013, 48)
        Me.TextEdit46.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TextEdit46.Name = "TextEdit46"
        Me.TextEdit46.Size = New System.Drawing.Size(259, 23)
        Me.TextEdit46.TabIndex = 154
        '
        'TextEdit24
        '
        Me.TextEdit24.Location = New System.Drawing.Point(328, 48)
        Me.TextEdit24.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TextEdit24.Name = "TextEdit24"
        Me.TextEdit24.Size = New System.Drawing.Size(259, 23)
        Me.TextEdit24.TabIndex = 153
        '
        'SearchLookUpEdit31
        '
        Me.SearchLookUpEdit31.Location = New System.Drawing.Point(717, 80)
        Me.SearchLookUpEdit31.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.SearchLookUpEdit31.Name = "SearchLookUpEdit31"
        Me.SearchLookUpEdit31.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.SearchLookUpEdit31.Properties.DataSource = Me.EOALANSISYARDDEPOBindingSource
        Me.SearchLookUpEdit31.Properties.DisplayMember = "STOK_ADI"
        Me.SearchLookUpEdit31.Properties.NullText = ""
        Me.SearchLookUpEdit31.Properties.PopupSizeable = False
        Me.SearchLookUpEdit31.Properties.PopupView = Me.GridView31
        Me.SearchLookUpEdit31.Properties.ValueMember = "STOK_ADI"
        Me.SearchLookUpEdit31.Size = New System.Drawing.Size(288, 23)
        Me.SearchLookUpEdit31.TabIndex = 144
        '
        'GridView31
        '
        Me.GridView31.DetailHeight = 431
        Me.GridView31.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView31.Name = "GridView31"
        Me.GridView31.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView31.OptionsView.ShowGroupPanel = False
        '
        'SearchLookUpEdit32
        '
        Me.SearchLookUpEdit32.Location = New System.Drawing.Point(717, 336)
        Me.SearchLookUpEdit32.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.SearchLookUpEdit32.Name = "SearchLookUpEdit32"
        Me.SearchLookUpEdit32.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.SearchLookUpEdit32.Properties.DataSource = Me.EOALANSISYARDDEPOBindingSource
        Me.SearchLookUpEdit32.Properties.DisplayMember = "STOK_ADI"
        Me.SearchLookUpEdit32.Properties.NullText = ""
        Me.SearchLookUpEdit32.Properties.PopupSizeable = False
        Me.SearchLookUpEdit32.Properties.PopupView = Me.GridView32
        Me.SearchLookUpEdit32.Properties.ValueMember = "STOK_ADI"
        Me.SearchLookUpEdit32.Size = New System.Drawing.Size(288, 23)
        Me.SearchLookUpEdit32.TabIndex = 152
        '
        'GridView32
        '
        Me.GridView32.DetailHeight = 431
        Me.GridView32.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView32.Name = "GridView32"
        Me.GridView32.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView32.OptionsView.ShowGroupPanel = False
        '
        'SearchLookUpEdit33
        '
        Me.SearchLookUpEdit33.Location = New System.Drawing.Point(717, 112)
        Me.SearchLookUpEdit33.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.SearchLookUpEdit33.Name = "SearchLookUpEdit33"
        Me.SearchLookUpEdit33.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.SearchLookUpEdit33.Properties.DataSource = Me.EOALANSISYARDDEPOBindingSource
        Me.SearchLookUpEdit33.Properties.DisplayMember = "STOK_ADI"
        Me.SearchLookUpEdit33.Properties.NullText = ""
        Me.SearchLookUpEdit33.Properties.PopupSizeable = False
        Me.SearchLookUpEdit33.Properties.PopupView = Me.GridView33
        Me.SearchLookUpEdit33.Properties.ValueMember = "STOK_ADI"
        Me.SearchLookUpEdit33.Size = New System.Drawing.Size(288, 23)
        Me.SearchLookUpEdit33.TabIndex = 145
        '
        'GridView33
        '
        Me.GridView33.DetailHeight = 431
        Me.GridView33.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView33.Name = "GridView33"
        Me.GridView33.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView33.OptionsView.ShowGroupPanel = False
        '
        'SearchLookUpEdit34
        '
        Me.SearchLookUpEdit34.EditValue = ""
        Me.SearchLookUpEdit34.Location = New System.Drawing.Point(717, 48)
        Me.SearchLookUpEdit34.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.SearchLookUpEdit34.Name = "SearchLookUpEdit34"
        Me.SearchLookUpEdit34.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.SearchLookUpEdit34.Properties.DataSource = Me.EOALANSISYARDDEPOBindingSource
        Me.SearchLookUpEdit34.Properties.DisplayMember = "STOK_ADI"
        Me.SearchLookUpEdit34.Properties.NullText = ""
        Me.SearchLookUpEdit34.Properties.PopupSizeable = False
        Me.SearchLookUpEdit34.Properties.PopupView = Me.GridView34
        Me.SearchLookUpEdit34.Properties.ValueMember = "STOK_ADI"
        Me.SearchLookUpEdit34.Size = New System.Drawing.Size(288, 23)
        Me.SearchLookUpEdit34.TabIndex = 143
        '
        'GridView34
        '
        Me.GridView34.DetailHeight = 431
        Me.GridView34.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView34.Name = "GridView34"
        Me.GridView34.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView34.OptionsView.ShowGroupPanel = False
        '
        'SearchLookUpEdit35
        '
        Me.SearchLookUpEdit35.Location = New System.Drawing.Point(717, 144)
        Me.SearchLookUpEdit35.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.SearchLookUpEdit35.Name = "SearchLookUpEdit35"
        Me.SearchLookUpEdit35.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.SearchLookUpEdit35.Properties.DataSource = Me.EOALANSISYARDDEPOBindingSource
        Me.SearchLookUpEdit35.Properties.DisplayMember = "STOK_ADI"
        Me.SearchLookUpEdit35.Properties.NullText = ""
        Me.SearchLookUpEdit35.Properties.PopupSizeable = False
        Me.SearchLookUpEdit35.Properties.PopupView = Me.GridView35
        Me.SearchLookUpEdit35.Properties.ValueMember = "STOK_ADI"
        Me.SearchLookUpEdit35.Size = New System.Drawing.Size(288, 23)
        Me.SearchLookUpEdit35.TabIndex = 146
        '
        'GridView35
        '
        Me.GridView35.DetailHeight = 431
        Me.GridView35.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView35.Name = "GridView35"
        Me.GridView35.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView35.OptionsView.ShowGroupPanel = False
        '
        'SearchLookUpEdit36
        '
        Me.SearchLookUpEdit36.Location = New System.Drawing.Point(717, 304)
        Me.SearchLookUpEdit36.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.SearchLookUpEdit36.Name = "SearchLookUpEdit36"
        Me.SearchLookUpEdit36.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.SearchLookUpEdit36.Properties.DataSource = Me.EOALANSISYARDDEPOBindingSource
        Me.SearchLookUpEdit36.Properties.DisplayMember = "STOK_ADI"
        Me.SearchLookUpEdit36.Properties.NullText = ""
        Me.SearchLookUpEdit36.Properties.PopupSizeable = False
        Me.SearchLookUpEdit36.Properties.PopupView = Me.GridView36
        Me.SearchLookUpEdit36.Properties.ValueMember = "STOK_ADI"
        Me.SearchLookUpEdit36.Size = New System.Drawing.Size(288, 23)
        Me.SearchLookUpEdit36.TabIndex = 151
        '
        'GridView36
        '
        Me.GridView36.DetailHeight = 431
        Me.GridView36.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView36.Name = "GridView36"
        Me.GridView36.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView36.OptionsView.ShowGroupPanel = False
        '
        'SearchLookUpEdit37
        '
        Me.SearchLookUpEdit37.Location = New System.Drawing.Point(717, 176)
        Me.SearchLookUpEdit37.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.SearchLookUpEdit37.Name = "SearchLookUpEdit37"
        Me.SearchLookUpEdit37.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.SearchLookUpEdit37.Properties.DataSource = Me.EOALANSISYARDDEPOBindingSource
        Me.SearchLookUpEdit37.Properties.DisplayMember = "STOK_ADI"
        Me.SearchLookUpEdit37.Properties.NullText = ""
        Me.SearchLookUpEdit37.Properties.PopupSizeable = False
        Me.SearchLookUpEdit37.Properties.PopupView = Me.GridView37
        Me.SearchLookUpEdit37.Properties.ValueMember = "STOK_ADI"
        Me.SearchLookUpEdit37.Size = New System.Drawing.Size(288, 23)
        Me.SearchLookUpEdit37.TabIndex = 147
        '
        'GridView37
        '
        Me.GridView37.DetailHeight = 431
        Me.GridView37.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView37.Name = "GridView37"
        Me.GridView37.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView37.OptionsView.ShowGroupPanel = False
        '
        'SearchLookUpEdit38
        '
        Me.SearchLookUpEdit38.Location = New System.Drawing.Point(717, 272)
        Me.SearchLookUpEdit38.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.SearchLookUpEdit38.Name = "SearchLookUpEdit38"
        Me.SearchLookUpEdit38.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.SearchLookUpEdit38.Properties.DataSource = Me.EOALANSISYARDDEPOBindingSource
        Me.SearchLookUpEdit38.Properties.DisplayMember = "STOK_ADI"
        Me.SearchLookUpEdit38.Properties.NullText = ""
        Me.SearchLookUpEdit38.Properties.PopupSizeable = False
        Me.SearchLookUpEdit38.Properties.PopupView = Me.GridView38
        Me.SearchLookUpEdit38.Properties.ValueMember = "STOK_ADI"
        Me.SearchLookUpEdit38.Size = New System.Drawing.Size(288, 23)
        Me.SearchLookUpEdit38.TabIndex = 150
        '
        'GridView38
        '
        Me.GridView38.DetailHeight = 431
        Me.GridView38.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView38.Name = "GridView38"
        Me.GridView38.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView38.OptionsView.ShowGroupPanel = False
        '
        'SearchLookUpEdit39
        '
        Me.SearchLookUpEdit39.Location = New System.Drawing.Point(717, 208)
        Me.SearchLookUpEdit39.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.SearchLookUpEdit39.Name = "SearchLookUpEdit39"
        Me.SearchLookUpEdit39.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.SearchLookUpEdit39.Properties.DataSource = Me.EOALANSISYARDDEPOBindingSource
        Me.SearchLookUpEdit39.Properties.DisplayMember = "STOK_ADI"
        Me.SearchLookUpEdit39.Properties.NullText = ""
        Me.SearchLookUpEdit39.Properties.PopupSizeable = False
        Me.SearchLookUpEdit39.Properties.PopupView = Me.GridView39
        Me.SearchLookUpEdit39.Properties.ValueMember = "STOK_ADI"
        Me.SearchLookUpEdit39.Size = New System.Drawing.Size(288, 23)
        Me.SearchLookUpEdit39.TabIndex = 148
        '
        'GridView39
        '
        Me.GridView39.DetailHeight = 431
        Me.GridView39.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView39.Name = "GridView39"
        Me.GridView39.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView39.OptionsView.ShowGroupPanel = False
        '
        'SearchLookUpEdit40
        '
        Me.SearchLookUpEdit40.Location = New System.Drawing.Point(717, 240)
        Me.SearchLookUpEdit40.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.SearchLookUpEdit40.Name = "SearchLookUpEdit40"
        Me.SearchLookUpEdit40.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.SearchLookUpEdit40.Properties.DataSource = Me.EOALANSISYARDDEPOBindingSource
        Me.SearchLookUpEdit40.Properties.DisplayMember = "STOK_ADI"
        Me.SearchLookUpEdit40.Properties.NullText = ""
        Me.SearchLookUpEdit40.Properties.PopupSizeable = False
        Me.SearchLookUpEdit40.Properties.PopupView = Me.GridView40
        Me.SearchLookUpEdit40.Properties.ValueMember = "STOK_ADI"
        Me.SearchLookUpEdit40.Size = New System.Drawing.Size(288, 23)
        Me.SearchLookUpEdit40.TabIndex = 149
        '
        'GridView40
        '
        Me.GridView40.DetailHeight = 431
        Me.GridView40.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView40.Name = "GridView40"
        Me.GridView40.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView40.OptionsView.ShowGroupPanel = False
        '
        'TextEdit57
        '
        Me.TextEdit57.Location = New System.Drawing.Point(1013, 79)
        Me.TextEdit57.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TextEdit57.Name = "TextEdit57"
        Me.TextEdit57.Size = New System.Drawing.Size(259, 23)
        Me.TextEdit57.TabIndex = 134
        '
        'TextEdit58
        '
        Me.TextEdit58.Location = New System.Drawing.Point(1013, 112)
        Me.TextEdit58.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TextEdit58.Name = "TextEdit58"
        Me.TextEdit58.Size = New System.Drawing.Size(259, 23)
        Me.TextEdit58.TabIndex = 141
        '
        'TextEdit59
        '
        Me.TextEdit59.Location = New System.Drawing.Point(1013, 144)
        Me.TextEdit59.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TextEdit59.Name = "TextEdit59"
        Me.TextEdit59.Size = New System.Drawing.Size(259, 23)
        Me.TextEdit59.TabIndex = 135
        '
        'TextEdit60
        '
        Me.TextEdit60.Location = New System.Drawing.Point(1013, 176)
        Me.TextEdit60.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TextEdit60.Name = "TextEdit60"
        Me.TextEdit60.Size = New System.Drawing.Size(259, 23)
        Me.TextEdit60.TabIndex = 140
        '
        'TextEdit61
        '
        Me.TextEdit61.Location = New System.Drawing.Point(1013, 208)
        Me.TextEdit61.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TextEdit61.Name = "TextEdit61"
        Me.TextEdit61.Size = New System.Drawing.Size(259, 23)
        Me.TextEdit61.TabIndex = 136
        '
        'TextEdit62
        '
        Me.TextEdit62.Location = New System.Drawing.Point(1013, 240)
        Me.TextEdit62.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TextEdit62.Name = "TextEdit62"
        Me.TextEdit62.Size = New System.Drawing.Size(259, 23)
        Me.TextEdit62.TabIndex = 133
        '
        'TextEdit63
        '
        Me.TextEdit63.Location = New System.Drawing.Point(1013, 272)
        Me.TextEdit63.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TextEdit63.Name = "TextEdit63"
        Me.TextEdit63.Size = New System.Drawing.Size(259, 23)
        Me.TextEdit63.TabIndex = 139
        '
        'TextEdit64
        '
        Me.TextEdit64.Location = New System.Drawing.Point(1013, 304)
        Me.TextEdit64.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TextEdit64.Name = "TextEdit64"
        Me.TextEdit64.Size = New System.Drawing.Size(259, 23)
        Me.TextEdit64.TabIndex = 137
        '
        'TextEdit65
        '
        Me.TextEdit65.Location = New System.Drawing.Point(1013, 336)
        Me.TextEdit65.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TextEdit65.Name = "TextEdit65"
        Me.TextEdit65.Size = New System.Drawing.Size(259, 23)
        Me.TextEdit65.TabIndex = 138
        '
        'SearchLookUpEdit21
        '
        Me.SearchLookUpEdit21.Location = New System.Drawing.Point(33, 80)
        Me.SearchLookUpEdit21.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.SearchLookUpEdit21.Name = "SearchLookUpEdit21"
        Me.SearchLookUpEdit21.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.SearchLookUpEdit21.Properties.DataSource = Me.EOALANSISYARDDEPOBindingSource
        Me.SearchLookUpEdit21.Properties.DisplayMember = "STOK_ADI"
        Me.SearchLookUpEdit21.Properties.NullText = ""
        Me.SearchLookUpEdit21.Properties.PopupSizeable = False
        Me.SearchLookUpEdit21.Properties.PopupView = Me.GridView21
        Me.SearchLookUpEdit21.Properties.ValueMember = "STOK_ADI"
        Me.SearchLookUpEdit21.Size = New System.Drawing.Size(288, 23)
        Me.SearchLookUpEdit21.TabIndex = 123
        '
        'GridView21
        '
        Me.GridView21.DetailHeight = 431
        Me.GridView21.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView21.Name = "GridView21"
        Me.GridView21.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView21.OptionsView.ShowGroupPanel = False
        '
        'SearchLookUpEdit22
        '
        Me.SearchLookUpEdit22.Location = New System.Drawing.Point(33, 336)
        Me.SearchLookUpEdit22.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.SearchLookUpEdit22.Name = "SearchLookUpEdit22"
        Me.SearchLookUpEdit22.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.SearchLookUpEdit22.Properties.DataSource = Me.EOALANSISYARDDEPOBindingSource
        Me.SearchLookUpEdit22.Properties.DisplayMember = "STOK_ADI"
        Me.SearchLookUpEdit22.Properties.NullText = ""
        Me.SearchLookUpEdit22.Properties.PopupSizeable = False
        Me.SearchLookUpEdit22.Properties.PopupView = Me.GridView22
        Me.SearchLookUpEdit22.Properties.ValueMember = "STOK_ADI"
        Me.SearchLookUpEdit22.Size = New System.Drawing.Size(288, 23)
        Me.SearchLookUpEdit22.TabIndex = 131
        '
        'GridView22
        '
        Me.GridView22.DetailHeight = 431
        Me.GridView22.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView22.Name = "GridView22"
        Me.GridView22.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView22.OptionsView.ShowGroupPanel = False
        '
        'SearchLookUpEdit23
        '
        Me.SearchLookUpEdit23.Location = New System.Drawing.Point(33, 112)
        Me.SearchLookUpEdit23.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.SearchLookUpEdit23.Name = "SearchLookUpEdit23"
        Me.SearchLookUpEdit23.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.SearchLookUpEdit23.Properties.DataSource = Me.EOALANSISYARDDEPOBindingSource
        Me.SearchLookUpEdit23.Properties.DisplayMember = "STOK_ADI"
        Me.SearchLookUpEdit23.Properties.NullText = ""
        Me.SearchLookUpEdit23.Properties.PopupSizeable = False
        Me.SearchLookUpEdit23.Properties.PopupView = Me.GridView23
        Me.SearchLookUpEdit23.Properties.ValueMember = "STOK_ADI"
        Me.SearchLookUpEdit23.Size = New System.Drawing.Size(288, 23)
        Me.SearchLookUpEdit23.TabIndex = 124
        '
        'GridView23
        '
        Me.GridView23.DetailHeight = 431
        Me.GridView23.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView23.Name = "GridView23"
        Me.GridView23.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView23.OptionsView.ShowGroupPanel = False
        '
        'SearchLookUpEdit24
        '
        Me.SearchLookUpEdit24.EditValue = ""
        Me.SearchLookUpEdit24.Location = New System.Drawing.Point(33, 48)
        Me.SearchLookUpEdit24.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.SearchLookUpEdit24.Name = "SearchLookUpEdit24"
        Me.SearchLookUpEdit24.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.SearchLookUpEdit24.Properties.DataSource = Me.EOALANSISYARDDEPOBindingSource
        Me.SearchLookUpEdit24.Properties.DisplayMember = "STOK_ADI"
        Me.SearchLookUpEdit24.Properties.NullText = ""
        Me.SearchLookUpEdit24.Properties.PopupSizeable = False
        Me.SearchLookUpEdit24.Properties.PopupView = Me.GridView24
        Me.SearchLookUpEdit24.Properties.ValueMember = "STOK_ADI"
        Me.SearchLookUpEdit24.Size = New System.Drawing.Size(288, 23)
        Me.SearchLookUpEdit24.TabIndex = 122
        '
        'GridView24
        '
        Me.GridView24.DetailHeight = 431
        Me.GridView24.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView24.Name = "GridView24"
        Me.GridView24.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView24.OptionsView.ShowGroupPanel = False
        '
        'SearchLookUpEdit25
        '
        Me.SearchLookUpEdit25.Location = New System.Drawing.Point(33, 144)
        Me.SearchLookUpEdit25.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.SearchLookUpEdit25.Name = "SearchLookUpEdit25"
        Me.SearchLookUpEdit25.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.SearchLookUpEdit25.Properties.DataSource = Me.EOALANSISYARDDEPOBindingSource
        Me.SearchLookUpEdit25.Properties.DisplayMember = "STOK_ADI"
        Me.SearchLookUpEdit25.Properties.NullText = ""
        Me.SearchLookUpEdit25.Properties.PopupSizeable = False
        Me.SearchLookUpEdit25.Properties.PopupView = Me.GridView25
        Me.SearchLookUpEdit25.Properties.ValueMember = "STOK_ADI"
        Me.SearchLookUpEdit25.Size = New System.Drawing.Size(288, 23)
        Me.SearchLookUpEdit25.TabIndex = 125
        '
        'GridView25
        '
        Me.GridView25.DetailHeight = 431
        Me.GridView25.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView25.Name = "GridView25"
        Me.GridView25.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView25.OptionsView.ShowGroupPanel = False
        '
        'SearchLookUpEdit26
        '
        Me.SearchLookUpEdit26.Location = New System.Drawing.Point(33, 304)
        Me.SearchLookUpEdit26.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.SearchLookUpEdit26.Name = "SearchLookUpEdit26"
        Me.SearchLookUpEdit26.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.SearchLookUpEdit26.Properties.DataSource = Me.EOALANSISYARDDEPOBindingSource
        Me.SearchLookUpEdit26.Properties.DisplayMember = "STOK_ADI"
        Me.SearchLookUpEdit26.Properties.NullText = ""
        Me.SearchLookUpEdit26.Properties.PopupSizeable = False
        Me.SearchLookUpEdit26.Properties.PopupView = Me.GridView26
        Me.SearchLookUpEdit26.Properties.ValueMember = "STOK_ADI"
        Me.SearchLookUpEdit26.Size = New System.Drawing.Size(288, 23)
        Me.SearchLookUpEdit26.TabIndex = 130
        '
        'GridView26
        '
        Me.GridView26.DetailHeight = 431
        Me.GridView26.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView26.Name = "GridView26"
        Me.GridView26.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView26.OptionsView.ShowGroupPanel = False
        '
        'SearchLookUpEdit27
        '
        Me.SearchLookUpEdit27.Location = New System.Drawing.Point(33, 176)
        Me.SearchLookUpEdit27.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.SearchLookUpEdit27.Name = "SearchLookUpEdit27"
        Me.SearchLookUpEdit27.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.SearchLookUpEdit27.Properties.DataSource = Me.EOALANSISYARDDEPOBindingSource
        Me.SearchLookUpEdit27.Properties.DisplayMember = "STOK_ADI"
        Me.SearchLookUpEdit27.Properties.NullText = ""
        Me.SearchLookUpEdit27.Properties.PopupSizeable = False
        Me.SearchLookUpEdit27.Properties.PopupView = Me.GridView27
        Me.SearchLookUpEdit27.Properties.ValueMember = "STOK_ADI"
        Me.SearchLookUpEdit27.Size = New System.Drawing.Size(288, 23)
        Me.SearchLookUpEdit27.TabIndex = 126
        '
        'GridView27
        '
        Me.GridView27.DetailHeight = 431
        Me.GridView27.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView27.Name = "GridView27"
        Me.GridView27.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView27.OptionsView.ShowGroupPanel = False
        '
        'SearchLookUpEdit28
        '
        Me.SearchLookUpEdit28.Location = New System.Drawing.Point(33, 272)
        Me.SearchLookUpEdit28.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.SearchLookUpEdit28.Name = "SearchLookUpEdit28"
        Me.SearchLookUpEdit28.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.SearchLookUpEdit28.Properties.DataSource = Me.EOALANSISYARDDEPOBindingSource
        Me.SearchLookUpEdit28.Properties.DisplayMember = "STOK_ADI"
        Me.SearchLookUpEdit28.Properties.NullText = ""
        Me.SearchLookUpEdit28.Properties.PopupSizeable = False
        Me.SearchLookUpEdit28.Properties.PopupView = Me.GridView28
        Me.SearchLookUpEdit28.Properties.ValueMember = "STOK_ADI"
        Me.SearchLookUpEdit28.Size = New System.Drawing.Size(288, 23)
        Me.SearchLookUpEdit28.TabIndex = 129
        '
        'GridView28
        '
        Me.GridView28.DetailHeight = 431
        Me.GridView28.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView28.Name = "GridView28"
        Me.GridView28.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView28.OptionsView.ShowGroupPanel = False
        '
        'SearchLookUpEdit29
        '
        Me.SearchLookUpEdit29.Location = New System.Drawing.Point(33, 208)
        Me.SearchLookUpEdit29.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.SearchLookUpEdit29.Name = "SearchLookUpEdit29"
        Me.SearchLookUpEdit29.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.SearchLookUpEdit29.Properties.DataSource = Me.EOALANSISYARDDEPOBindingSource
        Me.SearchLookUpEdit29.Properties.DisplayMember = "STOK_ADI"
        Me.SearchLookUpEdit29.Properties.NullText = ""
        Me.SearchLookUpEdit29.Properties.PopupSizeable = False
        Me.SearchLookUpEdit29.Properties.PopupView = Me.GridView29
        Me.SearchLookUpEdit29.Properties.ValueMember = "STOK_ADI"
        Me.SearchLookUpEdit29.Size = New System.Drawing.Size(288, 23)
        Me.SearchLookUpEdit29.TabIndex = 127
        '
        'GridView29
        '
        Me.GridView29.DetailHeight = 431
        Me.GridView29.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView29.Name = "GridView29"
        Me.GridView29.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView29.OptionsView.ShowGroupPanel = False
        '
        'SearchLookUpEdit30
        '
        Me.SearchLookUpEdit30.Location = New System.Drawing.Point(33, 240)
        Me.SearchLookUpEdit30.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.SearchLookUpEdit30.Name = "SearchLookUpEdit30"
        Me.SearchLookUpEdit30.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.SearchLookUpEdit30.Properties.DataSource = Me.EOALANSISYARDDEPOBindingSource
        Me.SearchLookUpEdit30.Properties.DisplayMember = "STOK_ADI"
        Me.SearchLookUpEdit30.Properties.NullText = ""
        Me.SearchLookUpEdit30.Properties.PopupSizeable = False
        Me.SearchLookUpEdit30.Properties.PopupView = Me.GridView30
        Me.SearchLookUpEdit30.Properties.ValueMember = "STOK_ADI"
        Me.SearchLookUpEdit30.Size = New System.Drawing.Size(288, 23)
        Me.SearchLookUpEdit30.TabIndex = 128
        '
        'GridView30
        '
        Me.GridView30.DetailHeight = 431
        Me.GridView30.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView30.Name = "GridView30"
        Me.GridView30.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView30.OptionsView.ShowGroupPanel = False
        '
        'TextEdit47
        '
        Me.TextEdit47.Location = New System.Drawing.Point(328, 80)
        Me.TextEdit47.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TextEdit47.Name = "TextEdit47"
        Me.TextEdit47.Size = New System.Drawing.Size(259, 23)
        Me.TextEdit47.TabIndex = 114
        '
        'TextEdit48
        '
        Me.TextEdit48.Location = New System.Drawing.Point(328, 113)
        Me.TextEdit48.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TextEdit48.Name = "TextEdit48"
        Me.TextEdit48.Size = New System.Drawing.Size(259, 23)
        Me.TextEdit48.TabIndex = 121
        '
        'TextEdit49
        '
        Me.TextEdit49.Location = New System.Drawing.Point(328, 145)
        Me.TextEdit49.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TextEdit49.Name = "TextEdit49"
        Me.TextEdit49.Size = New System.Drawing.Size(259, 23)
        Me.TextEdit49.TabIndex = 115
        '
        'TextEdit50
        '
        Me.TextEdit50.Location = New System.Drawing.Point(328, 177)
        Me.TextEdit50.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TextEdit50.Name = "TextEdit50"
        Me.TextEdit50.Size = New System.Drawing.Size(259, 23)
        Me.TextEdit50.TabIndex = 120
        '
        'TextEdit51
        '
        Me.TextEdit51.Location = New System.Drawing.Point(328, 209)
        Me.TextEdit51.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TextEdit51.Name = "TextEdit51"
        Me.TextEdit51.Size = New System.Drawing.Size(259, 23)
        Me.TextEdit51.TabIndex = 116
        '
        'TextEdit52
        '
        Me.TextEdit52.Location = New System.Drawing.Point(328, 241)
        Me.TextEdit52.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TextEdit52.Name = "TextEdit52"
        Me.TextEdit52.Size = New System.Drawing.Size(259, 23)
        Me.TextEdit52.TabIndex = 112
        '
        'TextEdit53
        '
        Me.TextEdit53.Location = New System.Drawing.Point(328, 273)
        Me.TextEdit53.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TextEdit53.Name = "TextEdit53"
        Me.TextEdit53.Size = New System.Drawing.Size(259, 23)
        Me.TextEdit53.TabIndex = 119
        '
        'TextEdit54
        '
        Me.TextEdit54.Location = New System.Drawing.Point(328, 305)
        Me.TextEdit54.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TextEdit54.Name = "TextEdit54"
        Me.TextEdit54.Size = New System.Drawing.Size(259, 23)
        Me.TextEdit54.TabIndex = 117
        '
        'TextEdit55
        '
        Me.TextEdit55.Location = New System.Drawing.Point(328, 337)
        Me.TextEdit55.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TextEdit55.Name = "TextEdit55"
        Me.TextEdit55.Size = New System.Drawing.Size(259, 23)
        Me.TextEdit55.TabIndex = 118
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.Azure
        Me.Panel3.Location = New System.Drawing.Point(664, 52)
        Me.Panel3.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(20, 304)
        Me.Panel3.TabIndex = 111
        '
        'TextEdit26
        '
        Me.TextEdit26.Location = New System.Drawing.Point(1279, 79)
        Me.TextEdit26.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TextEdit26.Name = "TextEdit26"
        Me.TextEdit26.Size = New System.Drawing.Size(63, 23)
        Me.TextEdit26.TabIndex = 71
        '
        'TextEdit27
        '
        Me.TextEdit27.Location = New System.Drawing.Point(1279, 111)
        Me.TextEdit27.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TextEdit27.Name = "TextEdit27"
        Me.TextEdit27.Size = New System.Drawing.Size(63, 23)
        Me.TextEdit27.TabIndex = 73
        '
        'TextEdit28
        '
        Me.TextEdit28.Location = New System.Drawing.Point(1279, 335)
        Me.TextEdit28.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TextEdit28.Name = "TextEdit28"
        Me.TextEdit28.Size = New System.Drawing.Size(63, 23)
        Me.TextEdit28.TabIndex = 87
        '
        'TextEdit29
        '
        Me.TextEdit29.Location = New System.Drawing.Point(1279, 143)
        Me.TextEdit29.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TextEdit29.Name = "TextEdit29"
        Me.TextEdit29.Size = New System.Drawing.Size(63, 23)
        Me.TextEdit29.TabIndex = 75
        '
        'TextEdit30
        '
        Me.TextEdit30.Location = New System.Drawing.Point(1279, 303)
        Me.TextEdit30.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TextEdit30.Name = "TextEdit30"
        Me.TextEdit30.Size = New System.Drawing.Size(63, 23)
        Me.TextEdit30.TabIndex = 85
        '
        'TextEdit31
        '
        Me.TextEdit31.Location = New System.Drawing.Point(1279, 175)
        Me.TextEdit31.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TextEdit31.Name = "TextEdit31"
        Me.TextEdit31.Size = New System.Drawing.Size(63, 23)
        Me.TextEdit31.TabIndex = 77
        '
        'TextEdit32
        '
        Me.TextEdit32.Location = New System.Drawing.Point(1279, 47)
        Me.TextEdit32.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TextEdit32.Name = "TextEdit32"
        Me.TextEdit32.Size = New System.Drawing.Size(63, 23)
        Me.TextEdit32.TabIndex = 67
        '
        'TextEdit33
        '
        Me.TextEdit33.Location = New System.Drawing.Point(1279, 271)
        Me.TextEdit33.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TextEdit33.Name = "TextEdit33"
        Me.TextEdit33.Size = New System.Drawing.Size(63, 23)
        Me.TextEdit33.TabIndex = 83
        '
        'TextEdit34
        '
        Me.TextEdit34.Location = New System.Drawing.Point(1279, 207)
        Me.TextEdit34.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TextEdit34.Name = "TextEdit34"
        Me.TextEdit34.Size = New System.Drawing.Size(63, 23)
        Me.TextEdit34.TabIndex = 79
        '
        'TextEdit35
        '
        Me.TextEdit35.Location = New System.Drawing.Point(1279, 239)
        Me.TextEdit35.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TextEdit35.Name = "TextEdit35"
        Me.TextEdit35.Size = New System.Drawing.Size(63, 23)
        Me.TextEdit35.TabIndex = 81
        '
        'Label34
        '
        Me.Label34.AutoSize = True
        Me.Label34.Location = New System.Drawing.Point(734, 28)
        Me.Label34.Name = "Label34"
        Me.Label34.Size = New System.Drawing.Size(72, 17)
        Me.Label34.TabIndex = 100
        Me.Label34.Text = "Reçete Tip"
        '
        'Label35
        '
        Me.Label35.AutoSize = True
        Me.Label35.Location = New System.Drawing.Point(691, 340)
        Me.Label35.Name = "Label35"
        Me.Label35.Size = New System.Drawing.Size(28, 17)
        Me.Label35.TabIndex = 99
        Me.Label35.Text = "20."
        '
        'Label36
        '
        Me.Label36.AutoSize = True
        Me.Label36.Location = New System.Drawing.Point(691, 308)
        Me.Label36.Name = "Label36"
        Me.Label36.Size = New System.Drawing.Size(28, 17)
        Me.Label36.TabIndex = 98
        Me.Label36.Text = "19."
        '
        'Label37
        '
        Me.Label37.AutoSize = True
        Me.Label37.Location = New System.Drawing.Point(691, 276)
        Me.Label37.Name = "Label37"
        Me.Label37.Size = New System.Drawing.Size(28, 17)
        Me.Label37.TabIndex = 97
        Me.Label37.Text = "18."
        '
        'Label38
        '
        Me.Label38.AutoSize = True
        Me.Label38.Location = New System.Drawing.Point(691, 244)
        Me.Label38.Name = "Label38"
        Me.Label38.Size = New System.Drawing.Size(28, 17)
        Me.Label38.TabIndex = 96
        Me.Label38.Text = "17."
        '
        'Label39
        '
        Me.Label39.AutoSize = True
        Me.Label39.Location = New System.Drawing.Point(691, 212)
        Me.Label39.Name = "Label39"
        Me.Label39.Size = New System.Drawing.Size(28, 17)
        Me.Label39.TabIndex = 95
        Me.Label39.Text = "16."
        '
        'Label40
        '
        Me.Label40.AutoSize = True
        Me.Label40.Location = New System.Drawing.Point(691, 180)
        Me.Label40.Name = "Label40"
        Me.Label40.Size = New System.Drawing.Size(28, 17)
        Me.Label40.TabIndex = 94
        Me.Label40.Text = "15."
        '
        'Label41
        '
        Me.Label41.AutoSize = True
        Me.Label41.Location = New System.Drawing.Point(691, 148)
        Me.Label41.Name = "Label41"
        Me.Label41.Size = New System.Drawing.Size(28, 17)
        Me.Label41.TabIndex = 93
        Me.Label41.Text = "14."
        '
        'Label42
        '
        Me.Label42.AutoSize = True
        Me.Label42.Location = New System.Drawing.Point(691, 116)
        Me.Label42.Name = "Label42"
        Me.Label42.Size = New System.Drawing.Size(28, 17)
        Me.Label42.TabIndex = 92
        Me.Label42.Text = "13."
        '
        'Label43
        '
        Me.Label43.AutoSize = True
        Me.Label43.Location = New System.Drawing.Point(691, 82)
        Me.Label43.Name = "Label43"
        Me.Label43.Size = New System.Drawing.Size(28, 17)
        Me.Label43.TabIndex = 91
        Me.Label43.Text = "12."
        '
        'Label44
        '
        Me.Label44.AutoSize = True
        Me.Label44.Location = New System.Drawing.Point(691, 50)
        Me.Label44.Name = "Label44"
        Me.Label44.Size = New System.Drawing.Size(28, 17)
        Me.Label44.TabIndex = 90
        Me.Label44.Text = "11."
        '
        'Label45
        '
        Me.Label45.AutoSize = True
        Me.Label45.Location = New System.Drawing.Point(691, 28)
        Me.Label45.Name = "Label45"
        Me.Label45.Size = New System.Drawing.Size(29, 17)
        Me.Label45.TabIndex = 89
        Me.Label45.Text = "No."
        '
        'Label46
        '
        Me.Label46.AutoSize = True
        Me.Label46.Location = New System.Drawing.Point(1294, 28)
        Me.Label46.Name = "Label46"
        Me.Label46.Size = New System.Drawing.Size(44, 17)
        Me.Label46.TabIndex = 70
        Me.Label46.Text = "Miktar"
        '
        'Label47
        '
        Me.Label47.AutoSize = True
        Me.Label47.Location = New System.Drawing.Point(1055, 28)
        Me.Label47.Name = "Label47"
        Me.Label47.Size = New System.Drawing.Size(183, 17)
        Me.Label47.TabIndex = 69
        Me.Label47.Text = "Reçete Tanımlı Hammaddeler"
        '
        'TextEdit36
        '
        Me.TextEdit36.Location = New System.Drawing.Point(594, 80)
        Me.TextEdit36.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TextEdit36.Name = "TextEdit36"
        Me.TextEdit36.Size = New System.Drawing.Size(63, 23)
        Me.TextEdit36.TabIndex = 7
        '
        'TextEdit37
        '
        Me.TextEdit37.Location = New System.Drawing.Point(594, 112)
        Me.TextEdit37.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TextEdit37.Name = "TextEdit37"
        Me.TextEdit37.Size = New System.Drawing.Size(63, 23)
        Me.TextEdit37.TabIndex = 10
        '
        'TextEdit38
        '
        Me.TextEdit38.Location = New System.Drawing.Point(594, 336)
        Me.TextEdit38.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TextEdit38.Name = "TextEdit38"
        Me.TextEdit38.Size = New System.Drawing.Size(63, 23)
        Me.TextEdit38.TabIndex = 41
        '
        'TextEdit39
        '
        Me.TextEdit39.Location = New System.Drawing.Point(594, 144)
        Me.TextEdit39.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TextEdit39.Name = "TextEdit39"
        Me.TextEdit39.Size = New System.Drawing.Size(63, 23)
        Me.TextEdit39.TabIndex = 13
        '
        'TextEdit40
        '
        Me.TextEdit40.Location = New System.Drawing.Point(594, 304)
        Me.TextEdit40.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TextEdit40.Name = "TextEdit40"
        Me.TextEdit40.Size = New System.Drawing.Size(63, 23)
        Me.TextEdit40.TabIndex = 37
        '
        'TextEdit41
        '
        Me.TextEdit41.Location = New System.Drawing.Point(594, 176)
        Me.TextEdit41.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TextEdit41.Name = "TextEdit41"
        Me.TextEdit41.Size = New System.Drawing.Size(63, 23)
        Me.TextEdit41.TabIndex = 16
        '
        'TextEdit42
        '
        Me.TextEdit42.Location = New System.Drawing.Point(594, 48)
        Me.TextEdit42.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TextEdit42.Name = "TextEdit42"
        Me.TextEdit42.Size = New System.Drawing.Size(63, 23)
        Me.TextEdit42.TabIndex = 2
        '
        'TextEdit43
        '
        Me.TextEdit43.Location = New System.Drawing.Point(594, 272)
        Me.TextEdit43.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TextEdit43.Name = "TextEdit43"
        Me.TextEdit43.Size = New System.Drawing.Size(63, 23)
        Me.TextEdit43.TabIndex = 25
        '
        'TextEdit44
        '
        Me.TextEdit44.Location = New System.Drawing.Point(594, 208)
        Me.TextEdit44.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TextEdit44.Name = "TextEdit44"
        Me.TextEdit44.Size = New System.Drawing.Size(63, 23)
        Me.TextEdit44.TabIndex = 19
        '
        'TextEdit45
        '
        Me.TextEdit45.Location = New System.Drawing.Point(594, 240)
        Me.TextEdit45.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TextEdit45.Name = "TextEdit45"
        Me.TextEdit45.Size = New System.Drawing.Size(63, 23)
        Me.TextEdit45.TabIndex = 22
        '
        'Label48
        '
        Me.Label48.AutoSize = True
        Me.Label48.Location = New System.Drawing.Point(49, 28)
        Me.Label48.Name = "Label48"
        Me.Label48.Size = New System.Drawing.Size(72, 17)
        Me.Label48.TabIndex = 56
        Me.Label48.Text = "Reçete Tip"
        '
        'Label49
        '
        Me.Label49.AutoSize = True
        Me.Label49.Location = New System.Drawing.Point(6, 340)
        Me.Label49.Name = "Label49"
        Me.Label49.Size = New System.Drawing.Size(28, 17)
        Me.Label49.TabIndex = 54
        Me.Label49.Text = "10."
        '
        'Label50
        '
        Me.Label50.AutoSize = True
        Me.Label50.Location = New System.Drawing.Point(6, 308)
        Me.Label50.Name = "Label50"
        Me.Label50.Size = New System.Drawing.Size(20, 17)
        Me.Label50.TabIndex = 53
        Me.Label50.Text = "9."
        '
        'Label51
        '
        Me.Label51.AutoSize = True
        Me.Label51.Location = New System.Drawing.Point(6, 276)
        Me.Label51.Name = "Label51"
        Me.Label51.Size = New System.Drawing.Size(20, 17)
        Me.Label51.TabIndex = 52
        Me.Label51.Text = "8."
        '
        'Label52
        '
        Me.Label52.AutoSize = True
        Me.Label52.Location = New System.Drawing.Point(6, 244)
        Me.Label52.Name = "Label52"
        Me.Label52.Size = New System.Drawing.Size(20, 17)
        Me.Label52.TabIndex = 51
        Me.Label52.Text = "7."
        '
        'Label53
        '
        Me.Label53.AutoSize = True
        Me.Label53.Location = New System.Drawing.Point(6, 212)
        Me.Label53.Name = "Label53"
        Me.Label53.Size = New System.Drawing.Size(20, 17)
        Me.Label53.TabIndex = 50
        Me.Label53.Text = "6."
        '
        'Label54
        '
        Me.Label54.AutoSize = True
        Me.Label54.Location = New System.Drawing.Point(6, 180)
        Me.Label54.Name = "Label54"
        Me.Label54.Size = New System.Drawing.Size(20, 17)
        Me.Label54.TabIndex = 49
        Me.Label54.Text = "5."
        '
        'Label55
        '
        Me.Label55.AutoSize = True
        Me.Label55.Location = New System.Drawing.Point(6, 148)
        Me.Label55.Name = "Label55"
        Me.Label55.Size = New System.Drawing.Size(20, 17)
        Me.Label55.TabIndex = 48
        Me.Label55.Text = "4."
        '
        'Label56
        '
        Me.Label56.AutoSize = True
        Me.Label56.Location = New System.Drawing.Point(6, 116)
        Me.Label56.Name = "Label56"
        Me.Label56.Size = New System.Drawing.Size(20, 17)
        Me.Label56.TabIndex = 47
        Me.Label56.Text = "3."
        '
        'Label57
        '
        Me.Label57.AutoSize = True
        Me.Label57.Location = New System.Drawing.Point(6, 82)
        Me.Label57.Name = "Label57"
        Me.Label57.Size = New System.Drawing.Size(20, 17)
        Me.Label57.TabIndex = 46
        Me.Label57.Text = "2."
        '
        'Label58
        '
        Me.Label58.AutoSize = True
        Me.Label58.Location = New System.Drawing.Point(6, 50)
        Me.Label58.Name = "Label58"
        Me.Label58.Size = New System.Drawing.Size(20, 17)
        Me.Label58.TabIndex = 45
        Me.Label58.Text = "1."
        '
        'Label59
        '
        Me.Label59.AutoSize = True
        Me.Label59.Location = New System.Drawing.Point(6, 28)
        Me.Label59.Name = "Label59"
        Me.Label59.Size = New System.Drawing.Size(29, 17)
        Me.Label59.TabIndex = 44
        Me.Label59.Text = "No."
        '
        'SimpleButton6
        '
        Me.SimpleButton6.Location = New System.Drawing.Point(1176, 369)
        Me.SimpleButton6.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.SimpleButton6.Name = "SimpleButton6"
        Me.SimpleButton6.Size = New System.Drawing.Size(166, 36)
        Me.SimpleButton6.TabIndex = 7
        Me.SimpleButton6.Text = "Kaydet"
        '
        'Label60
        '
        Me.Label60.AutoSize = True
        Me.Label60.Location = New System.Drawing.Point(609, 28)
        Me.Label60.Name = "Label60"
        Me.Label60.Size = New System.Drawing.Size(44, 17)
        Me.Label60.TabIndex = 6
        Me.Label60.Text = "Miktar"
        '
        'Label61
        '
        Me.Label61.AutoSize = True
        Me.Label61.Location = New System.Drawing.Point(383, 28)
        Me.Label61.Name = "Label61"
        Me.Label61.Size = New System.Drawing.Size(183, 17)
        Me.Label61.TabIndex = 5
        Me.Label61.Text = "Reçete Tanımlı Hammaddeler"
        '
        'EOALANSISYARDIMCIMALZEMEBindingSource
        '
        Me.EOALANSISYARDIMCIMALZEMEBindingSource.DataMember = "EO_ALANSIS_YARDIMCIMALZEME"
        Me.EOALANSISYARDIMCIMALZEMEBindingSource.DataSource = Me.ALANAR2021DataSet2
        '
        'ALANAR2021DataSet2
        '
        Me.ALANAR2021DataSet2.DataSetName = "ALANAR2021DataSet2"
        Me.ALANAR2021DataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'EO_ALANSIS_RECETEVWTableAdapter1
        '
        Me.EO_ALANSIS_RECETEVWTableAdapter1.ClearBeforeFill = True
        '
        'SqlDataSource2
        '
        Me.SqlDataSource2.Name = "SqlDataSource2"
        '
        'EO_ALANSIS_YARDIMCIMALZEMETableAdapter
        '
        Me.EO_ALANSIS_YARDIMCIMALZEMETableAdapter.ClearBeforeFill = True
        '
        'EO_ALANSIS_CARYYBAGTIPIDEPOTableAdapter
        '
        Me.EO_ALANSIS_CARYYBAGTIPIDEPOTableAdapter.ClearBeforeFill = True
        '
        'EO_ALANSIS_EBATETIKETTIPIDEPOTableAdapter
        '
        Me.EO_ALANSIS_EBATETIKETTIPIDEPOTableAdapter.ClearBeforeFill = True
        '
        'EOALANSISKASATIPIDEPOBindingSource
        '
        Me.EOALANSISKASATIPIDEPOBindingSource.DataMember = "EO_ALANSIS_KASATIPIDEPO"
        Me.EOALANSISKASATIPIDEPOBindingSource.DataSource = Me.ALANSISDataSet3BindingSource
        '
        'EO_ALANSIS_KASATIPIDEPOTableAdapter
        '
        Me.EO_ALANSIS_KASATIPIDEPOTableAdapter.ClearBeforeFill = True
        '
        'EOALANSISKLIPSTIPIBindingSource1
        '
        Me.EOALANSISKLIPSTIPIBindingSource1.DataMember = "EO_ALANSIS_KLIPSTIPI"
        Me.EOALANSISKLIPSTIPIBindingSource1.DataSource = Me.ALANAR2021DataSet11BindingSource
        '
        'EOALANSISKLIPSTIPIDEPOBindingSource
        '
        Me.EOALANSISKLIPSTIPIDEPOBindingSource.DataMember = "EO_ALANSIS_KLIPSTIPIDEPO"
        Me.EOALANSISKLIPSTIPIDEPOBindingSource.DataSource = Me.ALANSISDataSet3BindingSource
        '
        'EO_ALANSIS_KLIPSTIPIDEPOTableAdapter
        '
        Me.EO_ALANSIS_KLIPSTIPIDEPOTableAdapter.ClearBeforeFill = True
        '
        'EOALANSISKOSEBENTTIPIDEPOBindingSource
        '
        Me.EOALANSISKOSEBENTTIPIDEPOBindingSource.DataMember = "EO_ALANSIS_KOSEBENTTIPIDEPO"
        Me.EOALANSISKOSEBENTTIPIDEPOBindingSource.DataSource = Me.ALANSISDataSet3BindingSource
        '
        'EO_ALANSIS_KOSEBENTTIPIDEPOTableAdapter
        '
        Me.EO_ALANSIS_KOSEBENTTIPIDEPOTableAdapter.ClearBeforeFill = True
        '
        'EOALANSISKUTUETIKETTIPIDEPOBindingSource
        '
        Me.EOALANSISKUTUETIKETTIPIDEPOBindingSource.DataMember = "EO_ALANSIS_KUTUETIKETTIPIDEPO"
        Me.EOALANSISKUTUETIKETTIPIDEPOBindingSource.DataSource = Me.ALANSISDataSet3BindingSource
        '
        'EO_ALANSIS_KUTUETIKETTIPIDEPOTableAdapter
        '
        Me.EO_ALANSIS_KUTUETIKETTIPIDEPOTableAdapter.ClearBeforeFill = True
        '
        'EOALANSISKUTUTIPIDEPOBindingSource
        '
        Me.EOALANSISKUTUTIPIDEPOBindingSource.DataMember = "EO_ALANSIS_KUTUTIPIDEPO"
        Me.EOALANSISKUTUTIPIDEPOBindingSource.DataSource = Me.ALANSISDataSet3BindingSource
        '
        'EO_ALANSIS_KUTUTIPIDEPOTableAdapter
        '
        Me.EO_ALANSIS_KUTUTIPIDEPOTableAdapter.ClearBeforeFill = True
        '
        'EOALANSISNEMBEZITIPIDEPOBindingSource
        '
        Me.EOALANSISNEMBEZITIPIDEPOBindingSource.DataMember = "EO_ALANSIS_NEMBEZITIPIDEPO"
        Me.EOALANSISNEMBEZITIPIDEPOBindingSource.DataSource = Me.ALANSISDataSet3BindingSource
        '
        'EO_ALANSIS_NEMBEZITIPIDEPOTableAdapter
        '
        Me.EO_ALANSIS_NEMBEZITIPIDEPOTableAdapter.ClearBeforeFill = True
        '
        'EOALANSISPALETTIPIDEPOBindingSource
        '
        Me.EOALANSISPALETTIPIDEPOBindingSource.DataMember = "EO_ALANSIS_PALETTIPIDEPO"
        Me.EOALANSISPALETTIPIDEPOBindingSource.DataSource = Me.ALANSISDataSet3BindingSource
        '
        'EO_ALANSIS_PALETTIPIDEPOTableAdapter
        '
        Me.EO_ALANSIS_PALETTIPIDEPOTableAdapter.ClearBeforeFill = True
        '
        'EOALANSISSABKATIPIDEPOBindingSource
        '
        Me.EOALANSISSABKATIPIDEPOBindingSource.DataMember = "EO_ALANSIS_SABKATIPIDEPO"
        Me.EOALANSISSABKATIPIDEPOBindingSource.DataSource = Me.ALANSISDataSet3BindingSource
        '
        'EO_ALANSIS_SABKATIPIDEPOTableAdapter
        '
        Me.EO_ALANSIS_SABKATIPIDEPOTableAdapter.ClearBeforeFill = True
        '
        'EO_ALANSIS_POSETTIPIDEPOTableAdapter
        '
        Me.EO_ALANSIS_POSETTIPIDEPOTableAdapter.ClearBeforeFill = True
        '
        'EO_ALANSIS_YARDDEPOTableAdapter
        '
        Me.EO_ALANSIS_YARDDEPOTableAdapter.ClearBeforeFill = True
        '
        'Form118
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1382, 562)
        Me.Controls.Add(Me.XtraTabControl1)
        Me.Controls.Add(Me.GroupControl3)
        Me.Controls.Add(Me.GroupControl1)
        Me.FormBorderEffect = DevExpress.XtraEditors.FormBorderEffect.Glow
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "Form118"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ALANSIS - RECETE TANIMLAMA"
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        Me.GroupControl1.PerformLayout()
        CType(Me.ComboBoxEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EOALANSISRECETEVWBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ALANSISDataSet2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SearchLookUpEdit21View, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EOALANSISSATISBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ALANSISDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextEdit2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl2.ResumeLayout(False)
        Me.GroupControl2.PerformLayout()
        CType(Me.ComboBoxEdit12.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ComboBoxEdit13.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ComboBoxEdit14.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextEdit9.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextEdit10.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ComboBoxEdit15.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextEdit11.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SearchLookUpEdit11.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EOALANSISKASATIPIBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ALANAR2021DataSet11BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ALANAR2021DataSet11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextEdit12.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ComboBoxEdit16.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextEdit13.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SearchLookUpEdit12.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EOALANSISPOSETTIPIBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView12, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextEdit14.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextEdit15.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextEdit16.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SearchLookUpEdit13.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EOALANSISKUTUTIPIBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView13, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextEdit17.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SearchLookUpEdit14.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EOALANSISPALETTIPIBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView14, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextEdit19.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ComboBoxEdit17.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ComboBoxEdit18.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SearchLookUpEdit15.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EOALANSISEBATETIKETTIPIBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView15, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ComboBoxEdit19.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SearchLookUpEdit16.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EOALANSISCARYYBAGTIPIBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView16, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ComboBoxEdit20.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ComboBoxEdit21.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SearchLookUpEdit17.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EOALANSISSABKATIPIBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView17, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SearchLookUpEdit18.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EOALANSISKLIPSTIPIBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView18, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SearchLookUpEdit19.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EOALANSISKOSEBENTTIPIBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView19, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SearchLookUpEdit20.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EOALANSISNEMBEZITIPIBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView20, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ComboBoxEdit11.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ComboBoxEdit10.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ComboBoxEdit9.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextEdit3.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ComboBoxEdit8.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextEdit20.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SearchLookUpEdit2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EOALANSISEBATETIKETTIPIDEPOBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ALANSISDataSet3BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ALANSISDataSet3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextEdit4.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ComboBoxEdit7.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextEdit18.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SearchLookUpEdit10.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextEdit5.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextEdit8.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SearchLookUpEdit3.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextEdit6.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SearchLookUpEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EOALANSISYARDDEPOBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ALANSISDataSet4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextEdit7.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ComboBoxEdit6.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ComboBoxEdit5.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SearchLookUpEdit4.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ComboBoxEdit4.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SearchLookUpEdit9.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ComboBoxEdit3.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ComboBoxEdit2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SearchLookUpEdit5.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SearchLookUpEdit8.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SearchLookUpEdit6.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SearchLookUpEdit7.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EOALANSISPOSETTIPIDEPOBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EOALANSISCARYYBAGTIPIDEPOBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ALANAR2021DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.eO_ALANSIS_POSETTIPIBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextEdit21.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextEdit22.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextEdit23.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl3.ResumeLayout(False)
        Me.GroupControl3.PerformLayout()
        CType(Me.TextEdit25.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabControl1.ResumeLayout(False)
        Me.XtraTabPage1.ResumeLayout(False)
        Me.XtraTabPage3.ResumeLayout(False)
        CType(Me.GroupControl4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl4.ResumeLayout(False)
        Me.GroupControl4.PerformLayout()
        CType(Me.TextEdit46.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextEdit24.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SearchLookUpEdit31.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView31, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SearchLookUpEdit32.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView32, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SearchLookUpEdit33.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView33, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SearchLookUpEdit34.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView34, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SearchLookUpEdit35.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView35, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SearchLookUpEdit36.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView36, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SearchLookUpEdit37.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView37, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SearchLookUpEdit38.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView38, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SearchLookUpEdit39.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView39, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SearchLookUpEdit40.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView40, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextEdit57.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextEdit58.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextEdit59.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextEdit60.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextEdit61.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextEdit62.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextEdit63.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextEdit64.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextEdit65.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SearchLookUpEdit21.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView21, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SearchLookUpEdit22.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView22, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SearchLookUpEdit23.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView23, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SearchLookUpEdit24.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView24, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SearchLookUpEdit25.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView25, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SearchLookUpEdit26.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView26, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SearchLookUpEdit27.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView27, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SearchLookUpEdit28.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView28, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SearchLookUpEdit29.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView29, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SearchLookUpEdit30.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView30, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextEdit47.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextEdit48.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextEdit49.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextEdit50.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextEdit51.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextEdit52.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextEdit53.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextEdit54.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextEdit55.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextEdit26.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextEdit27.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextEdit28.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextEdit29.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextEdit30.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextEdit31.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextEdit32.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextEdit33.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextEdit34.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextEdit35.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextEdit36.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextEdit37.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextEdit38.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextEdit39.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextEdit40.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextEdit41.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextEdit42.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextEdit43.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextEdit44.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextEdit45.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EOALANSISYARDIMCIMALZEMEBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ALANAR2021DataSet2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EOALANSISKASATIPIDEPOBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EOALANSISKLIPSTIPIBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EOALANSISKLIPSTIPIDEPOBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EOALANSISKOSEBENTTIPIDEPOBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EOALANSISKUTUETIKETTIPIDEPOBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EOALANSISKUTUTIPIDEPOBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EOALANSISNEMBEZITIPIDEPOBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EOALANSISPALETTIPIDEPOBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EOALANSISSABKATIPIDEPOBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents FormAssistant1 As DevExpress.XtraBars.FormAssistant
    Friend WithEvents DefaultLookAndFeel1 As DevExpress.LookAndFeel.DefaultLookAndFeel
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents TextEdit2 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label1 As Label
    Friend WithEvents ALANSISDataSet1 As ALANSISDataSet1
    Friend WithEvents EOALANSISSATISBindingSource As BindingSource
    Friend WithEvents EO_ALANSIS_SATISTableAdapter As ALANSISDataSet1TableAdapters.EO_ALANSIS_SATISTableAdapter
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents GroupControl2 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents SearchLookUpEdit1 As DevExpress.XtraEditors.SearchLookUpEdit
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents SearchLookUpEdit8 As DevExpress.XtraEditors.SearchLookUpEdit
    Friend WithEvents GridView8 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents TextEdit8 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents SearchLookUpEdit7 As DevExpress.XtraEditors.SearchLookUpEdit
    Friend WithEvents GridView7 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents TextEdit7 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents SearchLookUpEdit6 As DevExpress.XtraEditors.SearchLookUpEdit
    Friend WithEvents GridView6 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents TextEdit6 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents SearchLookUpEdit5 As DevExpress.XtraEditors.SearchLookUpEdit
    Friend WithEvents GridView5 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents TextEdit5 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents SearchLookUpEdit4 As DevExpress.XtraEditors.SearchLookUpEdit
    Friend WithEvents GridView4 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents TextEdit4 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents SearchLookUpEdit3 As DevExpress.XtraEditors.SearchLookUpEdit
    Friend WithEvents GridView3 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents TextEdit3 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents SearchLookUpEdit2 As DevExpress.XtraEditors.SearchLookUpEdit
    Friend WithEvents GridView2 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents TextEdit1 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents SimpleButton4 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SearchLookUpEdit10 As DevExpress.XtraEditors.SearchLookUpEdit
    Friend WithEvents GridView10 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents TextEdit20 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents SearchLookUpEdit9 As DevExpress.XtraEditors.SearchLookUpEdit
    Friend WithEvents GridView9 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents TextEdit18 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents ALANAR2021DataSet1 As ALANAR2021DataSet1
    Friend WithEvents EO_ALANSIS_PALETTIPITableAdapter As ALANAR2021DataSet1TableAdapters.EO_ALANSIS_PALETTIPITableAdapter
    Friend WithEvents TableAdapterManager As ALANAR2021DataSet1TableAdapters.TableAdapterManager
    Friend WithEvents eO_ALANSIS_POSETTIPIBindingSource As BindingSource
    Friend WithEvents SqlDataSource1 As DevExpress.DataAccess.Sql.SqlDataSource
    Friend WithEvents ALANAR2021DataSet11BindingSource As BindingSource
    Friend WithEvents ALANAR2021DataSet11 As ALANAR2021DataSet1
    Friend WithEvents EOALANSISPALETTIPIBindingSource As BindingSource
    Friend WithEvents EOALANSISKASATIPIBindingSource As BindingSource
    Friend WithEvents EO_ALANSIS_KASATIPITableAdapter As ALANAR2021DataSet1TableAdapters.EO_ALANSIS_KASATIPITableAdapter
    Friend WithEvents EOALANSISKUTUTIPIBindingSource As BindingSource
    Friend WithEvents EO_ALANSIS_KUTUTIPITableAdapter As ALANAR2021DataSet1TableAdapters.EO_ALANSIS_KUTUTIPITableAdapter
    Friend WithEvents EOALANSISEBATETIKETTIPIBindingSource As BindingSource
    Friend WithEvents EO_ALANSIS_EBATETIKETTIPITableAdapter As ALANAR2021DataSet1TableAdapters.EO_ALANSIS_EBATETIKETTIPITableAdapter
    Friend WithEvents EOALANSISSABKATIPIBindingSource As BindingSource
    Friend WithEvents EO_ALANSIS_SABKATIPITableAdapter As ALANAR2021DataSet1TableAdapters.EO_ALANSIS_SABKATIPITableAdapter
    Friend WithEvents EOALANSISKOSEBENTTIPIBindingSource As BindingSource
    Friend WithEvents EO_ALANSIS_KOSEBENTTIPITableAdapter As ALANAR2021DataSet1TableAdapters.EO_ALANSIS_KOSEBENTTIPITableAdapter
    Friend WithEvents EOALANSISNEMBEZITIPIBindingSource As BindingSource
    Friend WithEvents EO_ALANSIS_NEMBEZITIPITableAdapter As ALANAR2021DataSet1TableAdapters.EO_ALANSIS_NEMBEZITIPITableAdapter
    Friend WithEvents EOALANSISKLIPSTIPIBindingSource As BindingSource
    Friend WithEvents EO_ALANSIS_KLIPSTIPITableAdapter As ALANAR2021DataSet1TableAdapters.EO_ALANSIS_KLIPSTIPITableAdapter
    Friend WithEvents EOALANSISCARYYBAGTIPIBindingSource As BindingSource
    Friend WithEvents EO_ALANSIS_CARYYBAGTIPITableAdapter As ALANAR2021DataSet1TableAdapters.EO_ALANSIS_CARYYBAGTIPITableAdapter
    Friend WithEvents EOALANSISPOSETTIPIBindingSource As BindingSource
    Friend WithEvents EO_ALANSIS_POSETTIPITableAdapter As ALANAR2021DataSet1TableAdapters.EO_ALANSIS_POSETTIPITableAdapter
    Friend WithEvents TextEdit21 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents TextEdit22 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents TextEdit23 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents GroupControl3 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents Label18 As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents Label21 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents ALANSISDataSet2 As ALANSISDataSet2
    Friend WithEvents EOALANSISRECETEVWBindingSource As BindingSource
    Friend WithEvents EO_ALANSIS_RECETEVWTableAdapter As ALANSISDataSet2TableAdapters.EO_ALANSIS_RECETEVWTableAdapter
    Friend WithEvents ComboBoxEdit11 As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents ComboBoxEdit10 As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents ComboBoxEdit9 As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents ComboBoxEdit8 As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents ComboBoxEdit7 As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents ComboBoxEdit6 As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents ComboBoxEdit5 As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents ComboBoxEdit4 As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents ComboBoxEdit3 As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents ComboBoxEdit2 As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents Label29 As Label
    Friend WithEvents Label27 As Label
    Friend WithEvents Label28 As Label
    Friend WithEvents Label22 As Label
    Friend WithEvents Label23 As Label
    Friend WithEvents Label24 As Label
    Friend WithEvents Label25 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents XtraTabControl1 As DevExpress.XtraTab.XtraTabControl
    Friend WithEvents XtraTabPage1 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents ComboBoxEdit12 As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents ComboBoxEdit13 As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents ComboBoxEdit14 As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents TextEdit9 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents TextEdit10 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents ComboBoxEdit15 As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents TextEdit11 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents SearchLookUpEdit11 As DevExpress.XtraEditors.SearchLookUpEdit
    Friend WithEvents GridView11 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents TextEdit12 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents ComboBoxEdit16 As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents TextEdit13 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents SearchLookUpEdit12 As DevExpress.XtraEditors.SearchLookUpEdit
    Friend WithEvents GridView12 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents TextEdit14 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents TextEdit15 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents TextEdit16 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents SearchLookUpEdit13 As DevExpress.XtraEditors.SearchLookUpEdit
    Friend WithEvents GridView13 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents TextEdit17 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents SearchLookUpEdit14 As DevExpress.XtraEditors.SearchLookUpEdit
    Friend WithEvents GridView14 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents TextEdit19 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents ComboBoxEdit17 As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents ComboBoxEdit18 As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents SearchLookUpEdit15 As DevExpress.XtraEditors.SearchLookUpEdit
    Friend WithEvents GridView15 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents ComboBoxEdit19 As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents SearchLookUpEdit16 As DevExpress.XtraEditors.SearchLookUpEdit
    Friend WithEvents GridView16 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents ComboBoxEdit20 As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents ComboBoxEdit21 As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents Label2 As Label
    Friend WithEvents SearchLookUpEdit17 As DevExpress.XtraEditors.SearchLookUpEdit
    Friend WithEvents GridView17 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents SearchLookUpEdit18 As DevExpress.XtraEditors.SearchLookUpEdit
    Friend WithEvents GridView18 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents SearchLookUpEdit19 As DevExpress.XtraEditors.SearchLookUpEdit
    Friend WithEvents GridView19 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents Label8 As Label
    Friend WithEvents SearchLookUpEdit20 As DevExpress.XtraEditors.SearchLookUpEdit
    Friend WithEvents GridView20 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label26 As Label
    Friend WithEvents Label30 As Label
    Friend WithEvents Label31 As Label
    Friend WithEvents Label32 As Label
    Friend WithEvents TextEdit25 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label33 As Label
    Friend WithEvents EO_ALANSIS_RECETEVWTableAdapter1 As ALANSISDataSet2TableAdapters.EO_ALANSIS_RECETEVWTableAdapter
    Friend WithEvents ComboBoxEdit1 As DevExpress.XtraEditors.SearchLookUpEdit
    Friend WithEvents SearchLookUpEdit21View As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents XtraTabPage3 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents GroupControl4 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents TextEdit47 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents TextEdit48 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents TextEdit49 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents TextEdit50 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents TextEdit51 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents TextEdit52 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents TextEdit53 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents TextEdit54 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents TextEdit55 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Panel3 As Panel
    Friend WithEvents TextEdit26 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents TextEdit27 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents TextEdit28 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents TextEdit29 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents TextEdit30 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents TextEdit31 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents TextEdit32 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents TextEdit33 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents TextEdit34 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents TextEdit35 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label34 As Label
    Friend WithEvents Label35 As Label
    Friend WithEvents Label36 As Label
    Friend WithEvents Label37 As Label
    Friend WithEvents Label38 As Label
    Friend WithEvents Label39 As Label
    Friend WithEvents Label40 As Label
    Friend WithEvents Label41 As Label
    Friend WithEvents Label42 As Label
    Friend WithEvents Label43 As Label
    Friend WithEvents Label44 As Label
    Friend WithEvents Label45 As Label
    Friend WithEvents Label46 As Label
    Friend WithEvents Label47 As Label
    Friend WithEvents TextEdit36 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents TextEdit37 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents TextEdit38 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents TextEdit39 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents TextEdit40 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents TextEdit41 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents TextEdit42 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents TextEdit43 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents TextEdit44 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents TextEdit45 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label48 As Label
    Friend WithEvents Label49 As Label
    Friend WithEvents Label50 As Label
    Friend WithEvents Label51 As Label
    Friend WithEvents Label52 As Label
    Friend WithEvents Label53 As Label
    Friend WithEvents Label54 As Label
    Friend WithEvents Label55 As Label
    Friend WithEvents Label56 As Label
    Friend WithEvents Label57 As Label
    Friend WithEvents Label58 As Label
    Friend WithEvents Label59 As Label
    Friend WithEvents SimpleButton6 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Label60 As Label
    Friend WithEvents Label61 As Label
    Friend WithEvents SqlDataSource2 As DevExpress.DataAccess.Sql.SqlDataSource
    Friend WithEvents SearchLookUpEdit21 As DevExpress.XtraEditors.SearchLookUpEdit
    Friend WithEvents GridView21 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents SearchLookUpEdit22 As DevExpress.XtraEditors.SearchLookUpEdit
    Friend WithEvents GridView22 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents SearchLookUpEdit23 As DevExpress.XtraEditors.SearchLookUpEdit
    Friend WithEvents GridView23 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents SearchLookUpEdit24 As DevExpress.XtraEditors.SearchLookUpEdit
    Friend WithEvents GridView24 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents SearchLookUpEdit25 As DevExpress.XtraEditors.SearchLookUpEdit
    Friend WithEvents GridView25 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents SearchLookUpEdit26 As DevExpress.XtraEditors.SearchLookUpEdit
    Friend WithEvents GridView26 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents SearchLookUpEdit27 As DevExpress.XtraEditors.SearchLookUpEdit
    Friend WithEvents GridView27 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents SearchLookUpEdit28 As DevExpress.XtraEditors.SearchLookUpEdit
    Friend WithEvents GridView28 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents SearchLookUpEdit29 As DevExpress.XtraEditors.SearchLookUpEdit
    Friend WithEvents GridView29 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents SearchLookUpEdit30 As DevExpress.XtraEditors.SearchLookUpEdit
    Friend WithEvents GridView30 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents TextEdit57 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents TextEdit58 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents TextEdit59 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents TextEdit60 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents TextEdit61 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents TextEdit62 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents TextEdit63 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents TextEdit64 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents TextEdit65 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents SearchLookUpEdit31 As DevExpress.XtraEditors.SearchLookUpEdit
    Friend WithEvents GridView31 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents SearchLookUpEdit32 As DevExpress.XtraEditors.SearchLookUpEdit
    Friend WithEvents GridView32 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents SearchLookUpEdit33 As DevExpress.XtraEditors.SearchLookUpEdit
    Friend WithEvents GridView33 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents SearchLookUpEdit34 As DevExpress.XtraEditors.SearchLookUpEdit
    Friend WithEvents GridView34 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents SearchLookUpEdit35 As DevExpress.XtraEditors.SearchLookUpEdit
    Friend WithEvents GridView35 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents SearchLookUpEdit36 As DevExpress.XtraEditors.SearchLookUpEdit
    Friend WithEvents GridView36 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents SearchLookUpEdit37 As DevExpress.XtraEditors.SearchLookUpEdit
    Friend WithEvents GridView37 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents SearchLookUpEdit38 As DevExpress.XtraEditors.SearchLookUpEdit
    Friend WithEvents GridView38 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents SearchLookUpEdit39 As DevExpress.XtraEditors.SearchLookUpEdit
    Friend WithEvents GridView39 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents SearchLookUpEdit40 As DevExpress.XtraEditors.SearchLookUpEdit
    Friend WithEvents GridView40 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents ALANAR2021DataSet2 As ALANAR2021DataSet2
    Friend WithEvents EOALANSISYARDIMCIMALZEMEBindingSource As BindingSource
    Friend WithEvents EO_ALANSIS_YARDIMCIMALZEMETableAdapter As ALANAR2021DataSet2TableAdapters.EO_ALANSIS_YARDIMCIMALZEMETableAdapter
    Friend WithEvents ALANSISDataSet3BindingSource As BindingSource
    Friend WithEvents ALANSISDataSet3 As ALANSISDataSet3
    Friend WithEvents EOALANSISCARYYBAGTIPIDEPOBindingSource As BindingSource
    Friend WithEvents EO_ALANSIS_CARYYBAGTIPIDEPOTableAdapter As ALANSISDataSet3TableAdapters.EO_ALANSIS_CARYYBAGTIPIDEPOTableAdapter
    Friend WithEvents EOALANSISEBATETIKETTIPIDEPOBindingSource As BindingSource
    Friend WithEvents EO_ALANSIS_EBATETIKETTIPIDEPOTableAdapter As ALANSISDataSet3TableAdapters.EO_ALANSIS_EBATETIKETTIPIDEPOTableAdapter
    Friend WithEvents EOALANSISKASATIPIDEPOBindingSource As BindingSource
    Friend WithEvents EO_ALANSIS_KASATIPIDEPOTableAdapter As ALANSISDataSet3TableAdapters.EO_ALANSIS_KASATIPIDEPOTableAdapter
    Friend WithEvents EOALANSISKLIPSTIPIBindingSource1 As BindingSource
    Friend WithEvents EOALANSISKLIPSTIPIDEPOBindingSource As BindingSource
    Friend WithEvents EO_ALANSIS_KLIPSTIPIDEPOTableAdapter As ALANSISDataSet3TableAdapters.EO_ALANSIS_KLIPSTIPIDEPOTableAdapter
    Friend WithEvents EOALANSISKOSEBENTTIPIDEPOBindingSource As BindingSource
    Friend WithEvents EO_ALANSIS_KOSEBENTTIPIDEPOTableAdapter As ALANSISDataSet3TableAdapters.EO_ALANSIS_KOSEBENTTIPIDEPOTableAdapter
    Friend WithEvents EOALANSISKUTUETIKETTIPIDEPOBindingSource As BindingSource
    Friend WithEvents EO_ALANSIS_KUTUETIKETTIPIDEPOTableAdapter As ALANSISDataSet3TableAdapters.EO_ALANSIS_KUTUETIKETTIPIDEPOTableAdapter
    Friend WithEvents EOALANSISKUTUTIPIDEPOBindingSource As BindingSource
    Friend WithEvents EO_ALANSIS_KUTUTIPIDEPOTableAdapter As ALANSISDataSet3TableAdapters.EO_ALANSIS_KUTUTIPIDEPOTableAdapter
    Friend WithEvents EOALANSISNEMBEZITIPIDEPOBindingSource As BindingSource
    Friend WithEvents EO_ALANSIS_NEMBEZITIPIDEPOTableAdapter As ALANSISDataSet3TableAdapters.EO_ALANSIS_NEMBEZITIPIDEPOTableAdapter
    Friend WithEvents EOALANSISPALETTIPIDEPOBindingSource As BindingSource
    Friend WithEvents EO_ALANSIS_PALETTIPIDEPOTableAdapter As ALANSISDataSet3TableAdapters.EO_ALANSIS_PALETTIPIDEPOTableAdapter
    Friend WithEvents EOALANSISSABKATIPIDEPOBindingSource As BindingSource
    Friend WithEvents EO_ALANSIS_SABKATIPIDEPOTableAdapter As ALANSISDataSet3TableAdapters.EO_ALANSIS_SABKATIPIDEPOTableAdapter
    Friend WithEvents EOALANSISPOSETTIPIDEPOBindingSource As BindingSource
    Friend WithEvents EO_ALANSIS_POSETTIPIDEPOTableAdapter As ALANSISDataSet3TableAdapters.EO_ALANSIS_POSETTIPIDEPOTableAdapter
    Friend WithEvents ALANSISDataSet4 As ALANSISDataSet4
    Friend WithEvents EOALANSISYARDDEPOBindingSource As BindingSource
    Friend WithEvents EO_ALANSIS_YARDDEPOTableAdapter As ALANSISDataSet4TableAdapters.EO_ALANSIS_YARDDEPOTableAdapter
    Friend WithEvents TextEdit24 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents TextEdit46 As DevExpress.XtraEditors.TextEdit
End Class
