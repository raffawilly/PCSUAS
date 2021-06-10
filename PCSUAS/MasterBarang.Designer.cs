
namespace PCSUAS
{
    partial class MasterBarang
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MasterBarang));
            System.Windows.Forms.Label kODELabel;
            System.Windows.Forms.Label pART_NOLabel;
            System.Windows.Forms.Label uNIT_PRICELabel;
            System.Windows.Forms.Label uNITLabel;
            System.Windows.Forms.Label sTAMPINGLabel;
            System.Windows.Forms.Label dATA_FISIKLabel;
            System.Windows.Forms.Label pERSAMAANLabel;
            System.Windows.Forms.Label pN1Label;
            System.Windows.Forms.Label mERK1Label;
            System.Windows.Forms.Label mERK2Label;
            System.Windows.Forms.Label mERK3Label;
            System.Windows.Forms.Label kETERANGANLabel;
            System.Windows.Forms.Label dESCRIPTIONLabel;
            System.Windows.Forms.Label iDLabel;
            this.dbProjectUasDataSet = new PCSUAS.dbProjectUasDataSet();
            this.m_barangBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.m_barangTableAdapter = new PCSUAS.dbProjectUasDataSetTableAdapters.m_barangTableAdapter();
            this.tableAdapterManager = new PCSUAS.dbProjectUasDataSetTableAdapters.TableAdapterManager();
            this.m_barangBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.m_barangBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.kODETextBox = new System.Windows.Forms.TextBox();
            this.pART_NOTextBox = new System.Windows.Forms.TextBox();
            this.uNIT_PRICETextBox = new System.Windows.Forms.TextBox();
            this.uNITTextBox = new System.Windows.Forms.TextBox();
            this.sTAMPINGTextBox = new System.Windows.Forms.TextBox();
            this.dATA_FISIKTextBox = new System.Windows.Forms.TextBox();
            this.pERSAMAANTextBox = new System.Windows.Forms.TextBox();
            this.pN1TextBox = new System.Windows.Forms.TextBox();
            this.mERK1TextBox = new System.Windows.Forms.TextBox();
            this.mERK2TextBox = new System.Windows.Forms.TextBox();
            this.mERK3TextBox = new System.Windows.Forms.TextBox();
            this.kETERANGANTextBox = new System.Windows.Forms.TextBox();
            this.dESCRIPTIONTextBox = new System.Windows.Forms.TextBox();
            this.iDTextBox = new System.Windows.Forms.TextBox();
            this.btnPrev = new System.Windows.Forms.Button();
            this.btnTop = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnBottom = new System.Windows.Forms.Button();
            this.btnFind = new System.Windows.Forms.Button();
            this.btnPrint = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            kODELabel = new System.Windows.Forms.Label();
            pART_NOLabel = new System.Windows.Forms.Label();
            uNIT_PRICELabel = new System.Windows.Forms.Label();
            uNITLabel = new System.Windows.Forms.Label();
            sTAMPINGLabel = new System.Windows.Forms.Label();
            dATA_FISIKLabel = new System.Windows.Forms.Label();
            pERSAMAANLabel = new System.Windows.Forms.Label();
            pN1Label = new System.Windows.Forms.Label();
            mERK1Label = new System.Windows.Forms.Label();
            mERK2Label = new System.Windows.Forms.Label();
            mERK3Label = new System.Windows.Forms.Label();
            kETERANGANLabel = new System.Windows.Forms.Label();
            dESCRIPTIONLabel = new System.Windows.Forms.Label();
            iDLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dbProjectUasDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_barangBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_barangBindingNavigator)).BeginInit();
            this.m_barangBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // dbProjectUasDataSet
            // 
            this.dbProjectUasDataSet.DataSetName = "dbProjectUasDataSet";
            this.dbProjectUasDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // m_barangBindingSource
            // 
            this.m_barangBindingSource.DataMember = "m_barang";
            this.m_barangBindingSource.DataSource = this.dbProjectUasDataSet;
            // 
            // m_barangTableAdapter
            // 
            this.m_barangTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.m_barangTableAdapter = this.m_barangTableAdapter;
            this.tableAdapterManager.m_groupuserTableAdapter = null;
            this.tableAdapterManager.m_hakaksesgroupuserTableAdapter = null;
            this.tableAdapterManager.m_kotaTableAdapter = null;
            this.tableAdapterManager.m_merkTableAdapter = null;
            this.tableAdapterManager.m_modelTableAdapter = null;
            this.tableAdapterManager.m_pelangganTableAdapter = null;
            this.tableAdapterManager.m_supplierTableAdapter = null;
            this.tableAdapterManager.m_usersTableAdapter = null;
            this.tableAdapterManager.rework_detailTableAdapter = null;
            this.tableAdapterManager.reworkTableAdapter = null;
            this.tableAdapterManager.stock_historyTableAdapter = null;
            this.tableAdapterManager.stockTableAdapter = null;
            this.tableAdapterManager.t_invoice_detailTableAdapter = null;
            this.tableAdapterManager.t_invoice_headerTableAdapter = null;
            this.tableAdapterManager.t_invoiceppn_detailTableAdapter = null;
            this.tableAdapterManager.t_invoiceppn_headerTableAdapter = null;
            this.tableAdapterManager.t_label_hargaTableAdapter = null;
            this.tableAdapterManager.t_pembelian_detailTableAdapter = null;
            this.tableAdapterManager.t_pembelian_headerTableAdapter = null;
            this.tableAdapterManager.t_penawaran_detailTableAdapter = null;
            this.tableAdapterManager.t_penawaran_headerTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = PCSUAS.dbProjectUasDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // m_barangBindingNavigator
            // 
            this.m_barangBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.m_barangBindingNavigator.BindingSource = this.m_barangBindingSource;
            this.m_barangBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.m_barangBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.m_barangBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.m_barangBindingNavigatorSaveItem});
            this.m_barangBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.m_barangBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.m_barangBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.m_barangBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.m_barangBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.m_barangBindingNavigator.Name = "m_barangBindingNavigator";
            this.m_barangBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.m_barangBindingNavigator.Size = new System.Drawing.Size(1025, 25);
            this.m_barangBindingNavigator.TabIndex = 0;
            this.m_barangBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            this.bindingNavigatorMoveFirstItem.Click += new System.EventHandler(this.bindingNavigatorMoveFirstItem_Click);
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            this.bindingNavigatorMovePreviousItem.Click += new System.EventHandler(this.bindingNavigatorMovePreviousItem_Click);
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // m_barangBindingNavigatorSaveItem
            // 
            this.m_barangBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.m_barangBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("m_barangBindingNavigatorSaveItem.Image")));
            this.m_barangBindingNavigatorSaveItem.Name = "m_barangBindingNavigatorSaveItem";
            this.m_barangBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.m_barangBindingNavigatorSaveItem.Text = "Save Data";
            this.m_barangBindingNavigatorSaveItem.Click += new System.EventHandler(this.m_barangBindingNavigatorSaveItem_Click);
            // 
            // kODELabel
            // 
            kODELabel.AutoSize = true;
            kODELabel.Location = new System.Drawing.Point(12, 94);
            kODELabel.Name = "kODELabel";
            kODELabel.Size = new System.Drawing.Size(75, 13);
            kODELabel.TabIndex = 3;
            kODELabel.Text = "Kode Barang :";
            // 
            // kODETextBox
            // 
            this.kODETextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.m_barangBindingSource, "KODE", true));
            this.kODETextBox.Location = new System.Drawing.Point(102, 90);
            this.kODETextBox.Name = "kODETextBox";
            this.kODETextBox.Size = new System.Drawing.Size(143, 20);
            this.kODETextBox.TabIndex = 4;
            // 
            // pART_NOLabel
            // 
            pART_NOLabel.AutoSize = true;
            pART_NOLabel.Location = new System.Drawing.Point(260, 93);
            pART_NOLabel.Name = "pART_NOLabel";
            pART_NOLabel.Size = new System.Drawing.Size(72, 13);
            pART_NOLabel.TabIndex = 5;
            pART_NOLabel.Text = "Part Number :";
            // 
            // pART_NOTextBox
            // 
            this.pART_NOTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.m_barangBindingSource, "PART_NO", true));
            this.pART_NOTextBox.Location = new System.Drawing.Point(338, 89);
            this.pART_NOTextBox.Name = "pART_NOTextBox";
            this.pART_NOTextBox.Size = new System.Drawing.Size(175, 20);
            this.pART_NOTextBox.TabIndex = 6;
            // 
            // uNIT_PRICELabel
            // 
            uNIT_PRICELabel.AutoSize = true;
            uNIT_PRICELabel.Location = new System.Drawing.Point(12, 123);
            uNIT_PRICELabel.Name = "uNIT_PRICELabel";
            uNIT_PRICELabel.Size = new System.Drawing.Size(79, 13);
            uNIT_PRICELabel.TabIndex = 9;
            uNIT_PRICELabel.Text = "Harga Satuan :";
            // 
            // uNIT_PRICETextBox
            // 
            this.uNIT_PRICETextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.m_barangBindingSource, "UNIT_PRICE", true));
            this.uNIT_PRICETextBox.Location = new System.Drawing.Point(102, 119);
            this.uNIT_PRICETextBox.Name = "uNIT_PRICETextBox";
            this.uNIT_PRICETextBox.Size = new System.Drawing.Size(143, 20);
            this.uNIT_PRICETextBox.TabIndex = 10;
            // 
            // uNITLabel
            // 
            uNITLabel.AutoSize = true;
            uNITLabel.Location = new System.Drawing.Point(300, 123);
            uNITLabel.Name = "uNITLabel";
            uNITLabel.Size = new System.Drawing.Size(32, 13);
            uNITLabel.TabIndex = 11;
            uNITLabel.Text = "Unit :";
            // 
            // uNITTextBox
            // 
            this.uNITTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.m_barangBindingSource, "UNIT", true));
            this.uNITTextBox.Location = new System.Drawing.Point(338, 119);
            this.uNITTextBox.Name = "uNITTextBox";
            this.uNITTextBox.Size = new System.Drawing.Size(100, 20);
            this.uNITTextBox.TabIndex = 12;
            // 
            // sTAMPINGLabel
            // 
            sTAMPINGLabel.AutoSize = true;
            sTAMPINGLabel.Location = new System.Drawing.Point(12, 175);
            sTAMPINGLabel.Name = "sTAMPINGLabel";
            sTAMPINGLabel.Size = new System.Drawing.Size(57, 13);
            sTAMPINGLabel.TabIndex = 13;
            sTAMPINGLabel.Text = "Stamping :";
            // 
            // sTAMPINGTextBox
            // 
            this.sTAMPINGTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.m_barangBindingSource, "STAMPING", true));
            this.sTAMPINGTextBox.Location = new System.Drawing.Point(102, 171);
            this.sTAMPINGTextBox.Name = "sTAMPINGTextBox";
            this.sTAMPINGTextBox.Size = new System.Drawing.Size(100, 20);
            this.sTAMPINGTextBox.TabIndex = 14;
            // 
            // dATA_FISIKLabel
            // 
            dATA_FISIKLabel.AutoSize = true;
            dATA_FISIKLabel.Location = new System.Drawing.Point(237, 175);
            dATA_FISIKLabel.Name = "dATA_FISIKLabel";
            dATA_FISIKLabel.Size = new System.Drawing.Size(60, 13);
            dATA_FISIKLabel.TabIndex = 15;
            dATA_FISIKLabel.Text = "Data Fisik :";
            // 
            // dATA_FISIKTextBox
            // 
            this.dATA_FISIKTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.m_barangBindingSource, "DATA_FISIK", true));
            this.dATA_FISIKTextBox.Location = new System.Drawing.Point(303, 171);
            this.dATA_FISIKTextBox.Name = "dATA_FISIKTextBox";
            this.dATA_FISIKTextBox.Size = new System.Drawing.Size(100, 20);
            this.dATA_FISIKTextBox.TabIndex = 16;
            // 
            // pERSAMAANLabel
            // 
            pERSAMAANLabel.AutoSize = true;
            pERSAMAANLabel.Location = new System.Drawing.Point(414, 175);
            pERSAMAANLabel.Name = "pERSAMAANLabel";
            pERSAMAANLabel.Size = new System.Drawing.Size(66, 13);
            pERSAMAANLabel.TabIndex = 17;
            pERSAMAANLabel.Text = "Persamaan :";
            pERSAMAANLabel.Click += new System.EventHandler(this.pERSAMAANLabel_Click);
            // 
            // pERSAMAANTextBox
            // 
            this.pERSAMAANTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.m_barangBindingSource, "PERSAMAAN", true));
            this.pERSAMAANTextBox.Location = new System.Drawing.Point(486, 171);
            this.pERSAMAANTextBox.Name = "pERSAMAANTextBox";
            this.pERSAMAANTextBox.Size = new System.Drawing.Size(100, 20);
            this.pERSAMAANTextBox.TabIndex = 18;
            // 
            // pN1Label
            // 
            pN1Label.AutoSize = true;
            pN1Label.Location = new System.Drawing.Point(532, 93);
            pN1Label.Name = "pN1Label";
            pN1Label.Size = new System.Drawing.Size(48, 13);
            pN1Label.TabIndex = 19;
            pN1Label.Text = "P / N 1 :";
            // 
            // pN1TextBox
            // 
            this.pN1TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.m_barangBindingSource, "PN1", true));
            this.pN1TextBox.Location = new System.Drawing.Point(581, 89);
            this.pN1TextBox.Name = "pN1TextBox";
            this.pN1TextBox.Size = new System.Drawing.Size(165, 20);
            this.pN1TextBox.TabIndex = 20;
            // 
            // mERK1Label
            // 
            mERK1Label.AutoSize = true;
            mERK1Label.Location = new System.Drawing.Point(12, 200);
            mERK1Label.Name = "mERK1Label";
            mERK1Label.Size = new System.Drawing.Size(46, 13);
            mERK1Label.TabIndex = 21;
            mERK1Label.Text = "Merk 1 :";
            // 
            // mERK1TextBox
            // 
            this.mERK1TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.m_barangBindingSource, "MERK1", true));
            this.mERK1TextBox.Location = new System.Drawing.Point(102, 196);
            this.mERK1TextBox.Name = "mERK1TextBox";
            this.mERK1TextBox.Size = new System.Drawing.Size(100, 20);
            this.mERK1TextBox.TabIndex = 22;
            // 
            // mERK2Label
            // 
            mERK2Label.AutoSize = true;
            mERK2Label.Location = new System.Drawing.Point(250, 200);
            mERK2Label.Name = "mERK2Label";
            mERK2Label.Size = new System.Drawing.Size(46, 13);
            mERK2Label.TabIndex = 23;
            mERK2Label.Text = "Merk 2 :";
            // 
            // mERK2TextBox
            // 
            this.mERK2TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.m_barangBindingSource, "MERK2", true));
            this.mERK2TextBox.Location = new System.Drawing.Point(303, 196);
            this.mERK2TextBox.Name = "mERK2TextBox";
            this.mERK2TextBox.Size = new System.Drawing.Size(100, 20);
            this.mERK2TextBox.TabIndex = 24;
            // 
            // mERK3Label
            // 
            mERK3Label.AutoSize = true;
            mERK3Label.Location = new System.Drawing.Point(433, 200);
            mERK3Label.Name = "mERK3Label";
            mERK3Label.Size = new System.Drawing.Size(46, 13);
            mERK3Label.TabIndex = 25;
            mERK3Label.Text = "Merk 3 :";
            // 
            // mERK3TextBox
            // 
            this.mERK3TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.m_barangBindingSource, "MERK3", true));
            this.mERK3TextBox.Location = new System.Drawing.Point(486, 196);
            this.mERK3TextBox.Name = "mERK3TextBox";
            this.mERK3TextBox.Size = new System.Drawing.Size(100, 20);
            this.mERK3TextBox.TabIndex = 26;
            // 
            // kETERANGANLabel
            // 
            kETERANGANLabel.AutoSize = true;
            kETERANGANLabel.Location = new System.Drawing.Point(12, 245);
            kETERANGANLabel.Name = "kETERANGANLabel";
            kETERANGANLabel.Size = new System.Drawing.Size(36, 13);
            kETERANGANLabel.TabIndex = 27;
            kETERANGANLabel.Text = "Note :";
            // 
            // kETERANGANTextBox
            // 
            this.kETERANGANTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.m_barangBindingSource, "KETERANGAN", true));
            this.kETERANGANTextBox.Location = new System.Drawing.Point(102, 242);
            this.kETERANGANTextBox.Name = "kETERANGANTextBox";
            this.kETERANGANTextBox.Size = new System.Drawing.Size(301, 20);
            this.kETERANGANTextBox.TabIndex = 28;
            // 
            // dESCRIPTIONTextBox
            // 
            this.dESCRIPTIONTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.m_barangBindingSource, "DESCRIPTION", true));
            this.dESCRIPTIONTextBox.Location = new System.Drawing.Point(102, 63);
            this.dESCRIPTIONTextBox.Name = "dESCRIPTIONTextBox";
            this.dESCRIPTIONTextBox.Size = new System.Drawing.Size(112, 20);
            this.dESCRIPTIONTextBox.TabIndex = 8;
            this.dESCRIPTIONTextBox.Visible = false;
            // 
            // dESCRIPTIONLabel
            // 
            dESCRIPTIONLabel.AutoSize = true;
            dESCRIPTIONLabel.Location = new System.Drawing.Point(12, 66);
            dESCRIPTIONLabel.Name = "dESCRIPTIONLabel";
            dESCRIPTIONLabel.Size = new System.Drawing.Size(78, 13);
            dESCRIPTIONLabel.TabIndex = 7;
            dESCRIPTIONLabel.Text = "Nama Barang :";
            dESCRIPTIONLabel.Visible = false;
            // 
            // iDTextBox
            // 
            this.iDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.m_barangBindingSource, "ID", true));
            this.iDTextBox.Location = new System.Drawing.Point(102, 36);
            this.iDTextBox.Name = "iDTextBox";
            this.iDTextBox.Size = new System.Drawing.Size(100, 20);
            this.iDTextBox.TabIndex = 2;
            this.iDTextBox.Visible = false;
            // 
            // iDLabel
            // 
            iDLabel.AutoSize = true;
            iDLabel.Location = new System.Drawing.Point(12, 39);
            iDLabel.Name = "iDLabel";
            iDLabel.Size = new System.Drawing.Size(21, 13);
            iDLabel.TabIndex = 1;
            iDLabel.Text = "ID:";
            iDLabel.Visible = false;
            // 
            // btnPrev
            // 
            this.btnPrev.Location = new System.Drawing.Point(265, 317);
            this.btnPrev.Name = "btnPrev";
            this.btnPrev.Size = new System.Drawing.Size(41, 23);
            this.btnPrev.TabIndex = 29;
            this.btnPrev.Text = "Prev";
            this.btnPrev.UseVisualStyleBackColor = true;
            // 
            // btnTop
            // 
            this.btnTop.Location = new System.Drawing.Point(218, 317);
            this.btnTop.Name = "btnTop";
            this.btnTop.Size = new System.Drawing.Size(41, 23);
            this.btnTop.TabIndex = 30;
            this.btnTop.Text = "Top";
            this.btnTop.UseVisualStyleBackColor = true;
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(312, 317);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(41, 23);
            this.btnNext.TabIndex = 31;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = true;
            // 
            // btnBottom
            // 
            this.btnBottom.Location = new System.Drawing.Point(359, 317);
            this.btnBottom.Name = "btnBottom";
            this.btnBottom.Size = new System.Drawing.Size(53, 23);
            this.btnBottom.TabIndex = 32;
            this.btnBottom.Text = "Bottom";
            this.btnBottom.UseVisualStyleBackColor = true;
            // 
            // btnFind
            // 
            this.btnFind.Location = new System.Drawing.Point(418, 317);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(53, 23);
            this.btnFind.TabIndex = 33;
            this.btnFind.Text = "Find";
            this.btnFind.UseVisualStyleBackColor = true;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(477, 317);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(53, 23);
            this.btnPrint.TabIndex = 34;
            this.btnPrint.Text = "Print";
            this.btnPrint.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(536, 317);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(53, 23);
            this.btnAdd.TabIndex = 35;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(595, 317);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(53, 23);
            this.btnEdit.TabIndex = 36;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(654, 317);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(53, 23);
            this.btnDelete.TabIndex = 37;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(713, 317);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(53, 23);
            this.btnExit.TabIndex = 38;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            // 
            // MasterBarang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1025, 486);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.btnFind);
            this.Controls.Add(this.btnBottom);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnTop);
            this.Controls.Add(this.btnPrev);
            this.Controls.Add(iDLabel);
            this.Controls.Add(this.iDTextBox);
            this.Controls.Add(kODELabel);
            this.Controls.Add(this.kODETextBox);
            this.Controls.Add(pART_NOLabel);
            this.Controls.Add(this.pART_NOTextBox);
            this.Controls.Add(dESCRIPTIONLabel);
            this.Controls.Add(this.dESCRIPTIONTextBox);
            this.Controls.Add(uNIT_PRICELabel);
            this.Controls.Add(this.uNIT_PRICETextBox);
            this.Controls.Add(uNITLabel);
            this.Controls.Add(this.uNITTextBox);
            this.Controls.Add(sTAMPINGLabel);
            this.Controls.Add(this.sTAMPINGTextBox);
            this.Controls.Add(dATA_FISIKLabel);
            this.Controls.Add(this.dATA_FISIKTextBox);
            this.Controls.Add(pERSAMAANLabel);
            this.Controls.Add(this.pERSAMAANTextBox);
            this.Controls.Add(pN1Label);
            this.Controls.Add(this.pN1TextBox);
            this.Controls.Add(mERK1Label);
            this.Controls.Add(this.mERK1TextBox);
            this.Controls.Add(mERK2Label);
            this.Controls.Add(this.mERK2TextBox);
            this.Controls.Add(mERK3Label);
            this.Controls.Add(this.mERK3TextBox);
            this.Controls.Add(kETERANGANLabel);
            this.Controls.Add(this.kETERANGANTextBox);
            this.Controls.Add(this.m_barangBindingNavigator);
            this.Name = "MasterBarang";
            this.Text = "Master Barang";
            this.Load += new System.EventHandler(this.MasterBarang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dbProjectUasDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_barangBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_barangBindingNavigator)).EndInit();
            this.m_barangBindingNavigator.ResumeLayout(false);
            this.m_barangBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private dbProjectUasDataSet dbProjectUasDataSet;
        private System.Windows.Forms.BindingSource m_barangBindingSource;
        private dbProjectUasDataSetTableAdapters.m_barangTableAdapter m_barangTableAdapter;
        private dbProjectUasDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator m_barangBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton m_barangBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox kODETextBox;
        private System.Windows.Forms.TextBox pART_NOTextBox;
        private System.Windows.Forms.TextBox uNIT_PRICETextBox;
        private System.Windows.Forms.TextBox uNITTextBox;
        private System.Windows.Forms.TextBox sTAMPINGTextBox;
        private System.Windows.Forms.TextBox dATA_FISIKTextBox;
        private System.Windows.Forms.TextBox pERSAMAANTextBox;
        private System.Windows.Forms.TextBox pN1TextBox;
        private System.Windows.Forms.TextBox mERK1TextBox;
        private System.Windows.Forms.TextBox mERK2TextBox;
        private System.Windows.Forms.TextBox mERK3TextBox;
        private System.Windows.Forms.TextBox kETERANGANTextBox;
        private System.Windows.Forms.TextBox dESCRIPTIONTextBox;
        private System.Windows.Forms.TextBox iDTextBox;
        private System.Windows.Forms.Button btnPrev;
        private System.Windows.Forms.Button btnTop;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnBottom;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnExit;
    }
}