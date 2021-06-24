
namespace PCSUAS
{
    partial class Pembelian
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
            System.Windows.Forms.Label nO_PNWLabel;
            System.Windows.Forms.Label nO_NOTALabel;
            System.Windows.Forms.Label p_IDLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Pembelian));
            System.Windows.Forms.Label tbTglInvoice;
            this.dbProjectUasDataSet = new PCSUAS.dbProjectUasDataSet();
            this.t_pembelian_headerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.t_pembelian_headerTableAdapter = new PCSUAS.dbProjectUasDataSetTableAdapters.t_pembelian_headerTableAdapter();
            this.tableAdapterManager = new PCSUAS.dbProjectUasDataSetTableAdapters.TableAdapterManager();
            this.m_supplierTableAdapter = new PCSUAS.dbProjectUasDataSetTableAdapters.m_supplierTableAdapter();
            this.t_pembelian_detailTableAdapter = new PCSUAS.dbProjectUasDataSetTableAdapters.t_pembelian_detailTableAdapter();
            this.t_pembelian_headerBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.t_pembelian_headerBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.m_supplierBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.msupplierBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nO_PNWTextBox = new System.Windows.Forms.TextBox();
            this.nO_NOTATextBox = new System.Windows.Forms.TextBox();
            this.tbNamaSupp = new System.Windows.Forms.TextBox();
            this.p_IDTextBox = new System.Windows.Forms.TextBox();
            this.tbNoNpwp = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbAlamat = new System.Windows.Forms.TextBox();
            this.tbKota = new System.Windows.Forms.TextBox();
            this.tbNote = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.t_pembelian_detailBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tGL_PNWTextBox = new System.Windows.Forms.TextBox();
            this.btnTambahItem = new System.Windows.Forms.Button();
            this.btnHapusItem = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tbTotal = new System.Windows.Forms.TextBox();
            this.tbDiscount = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbPPN = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbGrandTotal = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            nO_PNWLabel = new System.Windows.Forms.Label();
            nO_NOTALabel = new System.Windows.Forms.Label();
            p_IDLabel = new System.Windows.Forms.Label();
            tbTglInvoice = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dbProjectUasDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.t_pembelian_headerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.t_pembelian_headerBindingNavigator)).BeginInit();
            this.t_pembelian_headerBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.m_supplierBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.msupplierBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.t_pembelian_detailBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // nO_PNWLabel
            // 
            nO_PNWLabel.AutoSize = true;
            nO_PNWLabel.Location = new System.Drawing.Point(7, 54);
            nO_PNWLabel.Name = "nO_PNWLabel";
            nO_PNWLabel.Size = new System.Drawing.Size(60, 13);
            nO_PNWLabel.TabIndex = 1;
            nO_PNWLabel.Text = "NO URUT:";
            // 
            // nO_NOTALabel
            // 
            nO_NOTALabel.AutoSize = true;
            nO_NOTALabel.Location = new System.Drawing.Point(8, 80);
            nO_NOTALabel.Name = "nO_NOTALabel";
            nO_NOTALabel.Size = new System.Drawing.Size(59, 13);
            nO_NOTALabel.TabIndex = 3;
            nO_NOTALabel.Text = "NO NOTA:";
            // 
            // p_IDLabel
            // 
            p_IDLabel.AutoSize = true;
            p_IDLabel.Location = new System.Drawing.Point(189, 54);
            p_IDLabel.Name = "p_IDLabel";
            p_IDLabel.Size = new System.Drawing.Size(69, 13);
            p_IDLabel.TabIndex = 7;
            p_IDLabel.Text = "SUPPLIER : ";
            // 
            // dbProjectUasDataSet
            // 
            this.dbProjectUasDataSet.DataSetName = "dbProjectUasDataSet";
            this.dbProjectUasDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // t_pembelian_headerBindingSource
            // 
            this.t_pembelian_headerBindingSource.DataMember = "t_pembelian_header";
            this.t_pembelian_headerBindingSource.DataSource = this.dbProjectUasDataSet;
            // 
            // t_pembelian_headerTableAdapter
            // 
            this.t_pembelian_headerTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.m_barangTableAdapter = null;
            this.tableAdapterManager.m_groupuserTableAdapter = null;
            this.tableAdapterManager.m_hakaksesgroupuserTableAdapter = null;
            this.tableAdapterManager.m_kotaTableAdapter = null;
            this.tableAdapterManager.m_merkTableAdapter = null;
            this.tableAdapterManager.m_modelTableAdapter = null;
            this.tableAdapterManager.m_pelangganTableAdapter = null;
            this.tableAdapterManager.m_supplierTableAdapter = this.m_supplierTableAdapter;
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
            this.tableAdapterManager.t_pembelian_detailTableAdapter = this.t_pembelian_detailTableAdapter;
            this.tableAdapterManager.t_pembelian_headerTableAdapter = this.t_pembelian_headerTableAdapter;
            this.tableAdapterManager.t_penawaran_detailTableAdapter = null;
            this.tableAdapterManager.t_penawaran_headerTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = PCSUAS.dbProjectUasDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // m_supplierTableAdapter
            // 
            this.m_supplierTableAdapter.ClearBeforeFill = true;
            // 
            // t_pembelian_detailTableAdapter
            // 
            this.t_pembelian_detailTableAdapter.ClearBeforeFill = true;
            // 
            // t_pembelian_headerBindingNavigator
            // 
            this.t_pembelian_headerBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.t_pembelian_headerBindingNavigator.BindingSource = this.t_pembelian_headerBindingSource;
            this.t_pembelian_headerBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.t_pembelian_headerBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.t_pembelian_headerBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.t_pembelian_headerBindingNavigatorSaveItem});
            this.t_pembelian_headerBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.t_pembelian_headerBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.t_pembelian_headerBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.t_pembelian_headerBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.t_pembelian_headerBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.t_pembelian_headerBindingNavigator.Name = "t_pembelian_headerBindingNavigator";
            this.t_pembelian_headerBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.t_pembelian_headerBindingNavigator.Size = new System.Drawing.Size(744, 25);
            this.t_pembelian_headerBindingNavigator.TabIndex = 0;
            this.t_pembelian_headerBindingNavigator.Text = "bindingNavigator1";
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
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
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
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
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
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
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
            this.bindingNavigatorMoveNextItem.Click += new System.EventHandler(this.bindingNavigatorMoveNextItem_Click);
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
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // t_pembelian_headerBindingNavigatorSaveItem
            // 
            this.t_pembelian_headerBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.t_pembelian_headerBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("t_pembelian_headerBindingNavigatorSaveItem.Image")));
            this.t_pembelian_headerBindingNavigatorSaveItem.Name = "t_pembelian_headerBindingNavigatorSaveItem";
            this.t_pembelian_headerBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.t_pembelian_headerBindingNavigatorSaveItem.Text = "Save Data";
            this.t_pembelian_headerBindingNavigatorSaveItem.Click += new System.EventHandler(this.t_pembelian_headerBindingNavigatorSaveItem_Click);
            // 
            // m_supplierBindingSource
            // 
            this.m_supplierBindingSource.DataMember = "m_supplier";
            this.m_supplierBindingSource.DataSource = this.dbProjectUasDataSet;
            // 
            // msupplierBindingSource
            // 
            this.msupplierBindingSource.DataMember = "m_supplier";
            this.msupplierBindingSource.DataSource = this.dbProjectUasDataSet;
            // 
            // nO_PNWTextBox
            // 
            this.nO_PNWTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.t_pembelian_headerBindingSource, "NO_PNW", true));
            this.nO_PNWTextBox.Enabled = false;
            this.nO_PNWTextBox.Location = new System.Drawing.Point(73, 50);
            this.nO_PNWTextBox.Name = "nO_PNWTextBox";
            this.nO_PNWTextBox.Size = new System.Drawing.Size(100, 20);
            this.nO_PNWTextBox.TabIndex = 2;
            // 
            // nO_NOTATextBox
            // 
            this.nO_NOTATextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.t_pembelian_headerBindingSource, "NO_NOTA", true));
            this.nO_NOTATextBox.Enabled = false;
            this.nO_NOTATextBox.Location = new System.Drawing.Point(73, 76);
            this.nO_NOTATextBox.Name = "nO_NOTATextBox";
            this.nO_NOTATextBox.Size = new System.Drawing.Size(100, 20);
            this.nO_NOTATextBox.TabIndex = 4;
            // 
            // tbNamaSupp
            // 
            this.tbNamaSupp.Enabled = false;
            this.tbNamaSupp.Location = new System.Drawing.Point(376, 50);
            this.tbNamaSupp.Name = "tbNamaSupp";
            this.tbNamaSupp.Size = new System.Drawing.Size(131, 20);
            this.tbNamaSupp.TabIndex = 10;
            // 
            // p_IDTextBox
            // 
            this.p_IDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.t_pembelian_headerBindingSource, "P_ID", true));
            this.p_IDTextBox.Enabled = false;
            this.p_IDTextBox.Location = new System.Drawing.Point(255, 50);
            this.p_IDTextBox.Name = "p_IDTextBox";
            this.p_IDTextBox.Size = new System.Drawing.Size(100, 20);
            this.p_IDTextBox.TabIndex = 11;
            // 
            // tbNoNpwp
            // 
            this.tbNoNpwp.Enabled = false;
            this.tbNoNpwp.Location = new System.Drawing.Point(255, 76);
            this.tbNoNpwp.Name = "tbNoNpwp";
            this.tbNoNpwp.Size = new System.Drawing.Size(100, 20);
            this.tbNoNpwp.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(189, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "NO NPWP:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // tbAlamat
            // 
            this.tbAlamat.Enabled = false;
            this.tbAlamat.Location = new System.Drawing.Point(376, 76);
            this.tbAlamat.Name = "tbAlamat";
            this.tbAlamat.Size = new System.Drawing.Size(131, 20);
            this.tbAlamat.TabIndex = 15;
            // 
            // tbKota
            // 
            this.tbKota.Enabled = false;
            this.tbKota.Location = new System.Drawing.Point(513, 76);
            this.tbKota.Name = "tbKota";
            this.tbKota.Size = new System.Drawing.Size(87, 20);
            this.tbKota.TabIndex = 17;
            // 
            // tbNote
            // 
            this.tbNote.Enabled = false;
            this.tbNote.Location = new System.Drawing.Point(73, 127);
            this.tbNote.Name = "tbNote";
            this.tbNote.Size = new System.Drawing.Size(300, 20);
            this.tbNote.TabIndex = 19;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(27, 130);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 18;
            this.label5.Text = "NOTE:";
            // 
            // t_pembelian_detailBindingSource
            // 
            this.t_pembelian_detailBindingSource.DataMember = "t_pembelian_detail";
            this.t_pembelian_detailBindingSource.DataSource = this.dbProjectUasDataSet;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(10, 153);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(720, 234);
            this.dataGridView1.TabIndex = 20;
            // 
            // tbTglInvoice
            // 
            tbTglInvoice.AutoSize = true;
            tbTglInvoice.Location = new System.Drawing.Point(564, 130);
            tbTglInvoice.Name = "tbTglInvoice";
            tbTglInvoice.Size = new System.Drawing.Size(66, 13);
            tbTglInvoice.TabIndex = 20;
            tbTglInvoice.Text = "Tgl Invoice :";
            // 
            // tGL_PNWTextBox
            // 
            this.tGL_PNWTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.t_pembelian_headerBindingSource, "TGL_PNW", true));
            this.tGL_PNWTextBox.Enabled = false;
            this.tGL_PNWTextBox.Location = new System.Drawing.Point(630, 127);
            this.tGL_PNWTextBox.Name = "tGL_PNWTextBox";
            this.tGL_PNWTextBox.ReadOnly = true;
            this.tGL_PNWTextBox.Size = new System.Drawing.Size(100, 20);
            this.tGL_PNWTextBox.TabIndex = 21;
            // 
            // btnTambahItem
            // 
            this.btnTambahItem.Location = new System.Drawing.Point(173, 433);
            this.btnTambahItem.Name = "btnTambahItem";
            this.btnTambahItem.Size = new System.Drawing.Size(78, 23);
            this.btnTambahItem.TabIndex = 22;
            this.btnTambahItem.Text = "Tambah Item";
            this.btnTambahItem.UseVisualStyleBackColor = true;
            // 
            // btnHapusItem
            // 
            this.btnHapusItem.Location = new System.Drawing.Point(255, 433);
            this.btnHapusItem.Name = "btnHapusItem";
            this.btnHapusItem.Size = new System.Drawing.Size(72, 23);
            this.btnHapusItem.TabIndex = 23;
            this.btnHapusItem.Text = "Hapus Item";
            this.btnHapusItem.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(470, 394);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 13);
            this.label1.TabIndex = 24;
            this.label1.Text = "Total Pembelian Rp. :";
            // 
            // tbTotal
            // 
            this.tbTotal.Enabled = false;
            this.tbTotal.Location = new System.Drawing.Point(606, 391);
            this.tbTotal.Name = "tbTotal";
            this.tbTotal.ReadOnly = true;
            this.tbTotal.Size = new System.Drawing.Size(124, 20);
            this.tbTotal.TabIndex = 25;
            // 
            // tbDiscount
            // 
            this.tbDiscount.Location = new System.Drawing.Point(606, 417);
            this.tbDiscount.Name = "tbDiscount";
            this.tbDiscount.Size = new System.Drawing.Size(124, 20);
            this.tbDiscount.TabIndex = 27;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(535, 420);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 26;
            this.label3.Text = "Discount :";
            // 
            // tbPPN
            // 
            this.tbPPN.Enabled = false;
            this.tbPPN.ForeColor = System.Drawing.Color.Red;
            this.tbPPN.Location = new System.Drawing.Point(606, 443);
            this.tbPPN.Name = "tbPPN";
            this.tbPPN.ReadOnly = true;
            this.tbPPN.Size = new System.Drawing.Size(124, 20);
            this.tbPPN.TabIndex = 29;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(560, 446);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 28;
            this.label4.Text = "PPN :";
            // 
            // tbGrandTotal
            // 
            this.tbGrandTotal.Enabled = false;
            this.tbGrandTotal.Location = new System.Drawing.Point(606, 479);
            this.tbGrandTotal.Name = "tbGrandTotal";
            this.tbGrandTotal.ReadOnly = true;
            this.tbGrandTotal.Size = new System.Drawing.Size(124, 20);
            this.tbGrandTotal.TabIndex = 31;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(493, 483);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(106, 13);
            this.label6.TabIndex = 30;
            this.label6.Text = "Grand Total Rp. :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(566, 459);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(169, 13);
            this.label7.TabIndex = 32;
            this.label7.Text = "___________________________";
            // 
            // Pembelian
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(744, 527);
            this.Controls.Add(this.tbGrandTotal);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tbPPN);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbDiscount);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbTotal);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnHapusItem);
            this.Controls.Add(this.btnTambahItem);
            this.Controls.Add(tbTglInvoice);
            this.Controls.Add(this.tGL_PNWTextBox);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.tbNote);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbKota);
            this.Controls.Add(this.tbAlamat);
            this.Controls.Add(this.tbNoNpwp);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.p_IDTextBox);
            this.Controls.Add(this.tbNamaSupp);
            this.Controls.Add(p_IDLabel);
            this.Controls.Add(nO_NOTALabel);
            this.Controls.Add(this.nO_NOTATextBox);
            this.Controls.Add(nO_PNWLabel);
            this.Controls.Add(this.nO_PNWTextBox);
            this.Controls.Add(this.t_pembelian_headerBindingNavigator);
            this.Controls.Add(this.label7);
            this.Name = "Pembelian";
            this.Text = "Pembelian";
            this.Load += new System.EventHandler(this.Pembelian_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dbProjectUasDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.t_pembelian_headerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.t_pembelian_headerBindingNavigator)).EndInit();
            this.t_pembelian_headerBindingNavigator.ResumeLayout(false);
            this.t_pembelian_headerBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.m_supplierBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.msupplierBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.t_pembelian_detailBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private dbProjectUasDataSet dbProjectUasDataSet;
        private System.Windows.Forms.BindingSource t_pembelian_headerBindingSource;
        private dbProjectUasDataSetTableAdapters.t_pembelian_headerTableAdapter t_pembelian_headerTableAdapter;
        private dbProjectUasDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator t_pembelian_headerBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton t_pembelian_headerBindingNavigatorSaveItem;
        private dbProjectUasDataSetTableAdapters.m_supplierTableAdapter m_supplierTableAdapter;
        private System.Windows.Forms.BindingSource m_supplierBindingSource;
        private System.Windows.Forms.BindingSource msupplierBindingSource;
        private System.Windows.Forms.TextBox nO_PNWTextBox;
        private System.Windows.Forms.TextBox nO_NOTATextBox;
        private System.Windows.Forms.TextBox tbNamaSupp;
        private System.Windows.Forms.TextBox p_IDTextBox;
        private System.Windows.Forms.TextBox tbNoNpwp;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbAlamat;
        private System.Windows.Forms.TextBox tbKota;
        private System.Windows.Forms.TextBox tbNote;
        private System.Windows.Forms.Label label5;
        private dbProjectUasDataSetTableAdapters.t_pembelian_detailTableAdapter t_pembelian_detailTableAdapter;
        private System.Windows.Forms.BindingSource t_pembelian_detailBindingSource;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox tGL_PNWTextBox;
        private System.Windows.Forms.Button btnTambahItem;
        private System.Windows.Forms.Button btnHapusItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbTotal;
        private System.Windows.Forms.TextBox tbDiscount;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbPPN;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbGrandTotal;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}