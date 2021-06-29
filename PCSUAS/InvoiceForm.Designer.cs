
namespace PCSUAS
{
    partial class InvoiceForm
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
            System.Windows.Forms.Label nO_INVLabel;
            System.Windows.Forms.Label nO_PNWLabel;
            System.Windows.Forms.Label tGL_INVLabel;
            System.Windows.Forms.Label tGL_TERIMALabel;
            System.Windows.Forms.Label p_IDLabel;
            System.Windows.Forms.Label eMAILLabel;
            System.Windows.Forms.Label nAMA_NPWPLabel;
            System.Windows.Forms.Label nOTELabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InvoiceForm));
            this.dbProjectUasDataSet = new PCSUAS.dbProjectUasDataSet();
            this.t_invoice_headerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.t_invoice_headerTableAdapter = new PCSUAS.dbProjectUasDataSetTableAdapters.t_invoice_headerTableAdapter();
            this.tableAdapterManager = new PCSUAS.dbProjectUasDataSetTableAdapters.TableAdapterManager();
            this.m_supplierTableAdapter = new PCSUAS.dbProjectUasDataSetTableAdapters.m_supplierTableAdapter();
            this.t_invoice_headerBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.t_invoice_headerBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.nO_INVTextBox = new System.Windows.Forms.TextBox();
            this.nO_PNWTextBox = new System.Windows.Forms.TextBox();
            this.tGL_INVDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.tGL_TERIMADateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.msupplierBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dgvBarang = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tbPartPrice = new System.Windows.Forms.TextBox();
            this.tbDiscount = new System.Windows.Forms.TextBox();
            this.tbService = new System.Windows.Forms.TextBox();
            this.tbPPN = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.tbTotal = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.p_IDComboBox = new System.Windows.Forms.ComboBox();
            this.tinvoiceheaderBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nAMATextBox = new System.Windows.Forms.TextBox();
            this.aLAMATTextBox = new System.Windows.Forms.TextBox();
            this.eMAILTextBox = new System.Windows.Forms.TextBox();
            this.kOTATextBox = new System.Windows.Forms.TextBox();
            this.nAMA_NPWPTextBox = new System.Windows.Forms.TextBox();
            this.nPWPTextBox = new System.Windows.Forms.TextBox();
            this.nOTETextBox = new System.Windows.Forms.TextBox();
            this.tbDescEdit = new System.Windows.Forms.TextBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.tbEditHargaJual = new System.Windows.Forms.TextBox();
            this.updateQty = new System.Windows.Forms.NumericUpDown();
            this.label11 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbHargaJual = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbHargaBeli = new System.Windows.Forms.TextBox();
            this.btnBatal = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.tbHapusKode = new System.Windows.Forms.TextBox();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.mbarangBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnHapusItem = new System.Windows.Forms.Button();
            this.btnTambahItem = new System.Windows.Forms.Button();
            this.m_barangTableAdapter = new PCSUAS.dbProjectUasDataSetTableAdapters.m_barangTableAdapter();
            nO_INVLabel = new System.Windows.Forms.Label();
            nO_PNWLabel = new System.Windows.Forms.Label();
            tGL_INVLabel = new System.Windows.Forms.Label();
            tGL_TERIMALabel = new System.Windows.Forms.Label();
            p_IDLabel = new System.Windows.Forms.Label();
            eMAILLabel = new System.Windows.Forms.Label();
            nAMA_NPWPLabel = new System.Windows.Forms.Label();
            nOTELabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dbProjectUasDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.t_invoice_headerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.t_invoice_headerBindingNavigator)).BeginInit();
            this.t_invoice_headerBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.msupplierBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBarang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tinvoiceheaderBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.updateQty)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mbarangBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // nO_INVLabel
            // 
            nO_INVLabel.AutoSize = true;
            nO_INVLabel.Location = new System.Drawing.Point(4, 54);
            nO_INVLabel.Name = "nO_INVLabel";
            nO_INVLabel.Size = new System.Drawing.Size(50, 13);
            nO_INVLabel.TabIndex = 2;
            nO_INVLabel.Text = "INVOICE";
            // 
            // nO_PNWLabel
            // 
            nO_PNWLabel.AutoSize = true;
            nO_PNWLabel.Location = new System.Drawing.Point(167, 54);
            nO_PNWLabel.Name = "nO_PNWLabel";
            nO_PNWLabel.Size = new System.Drawing.Size(67, 13);
            nO_PNWLabel.TabIndex = 3;
            nO_PNWLabel.Text = "Penawaran :";
            // 
            // tGL_INVLabel
            // 
            tGL_INVLabel.AutoSize = true;
            tGL_INVLabel.Location = new System.Drawing.Point(348, 54);
            tGL_INVLabel.Name = "tGL_INVLabel";
            tGL_INVLabel.Size = new System.Drawing.Size(49, 13);
            tGL_INVLabel.TabIndex = 5;
            tGL_INVLabel.Text = "Tgl INV :";
            // 
            // tGL_TERIMALabel
            // 
            tGL_TERIMALabel.AutoSize = true;
            tGL_TERIMALabel.Location = new System.Drawing.Point(538, 54);
            tGL_TERIMALabel.Name = "tGL_TERIMALabel";
            tGL_TERIMALabel.Size = new System.Drawing.Size(63, 13);
            tGL_TERIMALabel.TabIndex = 7;
            tGL_TERIMALabel.Text = "Tgl Terima :";
            // 
            // p_IDLabel
            // 
            p_IDLabel.AutoSize = true;
            p_IDLabel.Location = new System.Drawing.Point(4, 80);
            p_IDLabel.Name = "p_IDLabel";
            p_IDLabel.Size = new System.Drawing.Size(51, 13);
            p_IDLabel.TabIndex = 18;
            p_IDLabel.Text = "Supplier :";
            // 
            // eMAILLabel
            // 
            eMAILLabel.AutoSize = true;
            eMAILLabel.Location = new System.Drawing.Point(754, 54);
            eMAILLabel.Name = "eMAILLabel";
            eMAILLabel.Size = new System.Drawing.Size(42, 13);
            eMAILLabel.TabIndex = 37;
            eMAILLabel.Text = "EMAIL:";
            // 
            // nAMA_NPWPLabel
            // 
            nAMA_NPWPLabel.AutoSize = true;
            nAMA_NPWPLabel.Location = new System.Drawing.Point(4, 110);
            nAMA_NPWPLabel.Name = "nAMA_NPWPLabel";
            nAMA_NPWPLabel.Size = new System.Drawing.Size(43, 13);
            nAMA_NPWPLabel.TabIndex = 39;
            nAMA_NPWPLabel.Text = "NPWP:";
            // 
            // nOTELabel
            // 
            nOTELabel.AutoSize = true;
            nOTELabel.Location = new System.Drawing.Point(7, 137);
            nOTELabel.Name = "nOTELabel";
            nOTELabel.Size = new System.Drawing.Size(40, 13);
            nOTELabel.TabIndex = 41;
            nOTELabel.Text = "NOTE:";
            // 
            // dbProjectUasDataSet
            // 
            this.dbProjectUasDataSet.DataSetName = "dbProjectUasDataSet";
            this.dbProjectUasDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // t_invoice_headerBindingSource
            // 
            this.t_invoice_headerBindingSource.DataMember = "t_invoice_header";
            this.t_invoice_headerBindingSource.DataSource = this.dbProjectUasDataSet;
            // 
            // t_invoice_headerTableAdapter
            // 
            this.t_invoice_headerTableAdapter.ClearBeforeFill = true;
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
            this.tableAdapterManager.t_invoice_headerTableAdapter = this.t_invoice_headerTableAdapter;
            this.tableAdapterManager.t_invoiceppn_detailTableAdapter = null;
            this.tableAdapterManager.t_invoiceppn_headerTableAdapter = null;
            this.tableAdapterManager.t_label_hargaTableAdapter = null;
            this.tableAdapterManager.t_pembelian_detailTableAdapter = null;
            this.tableAdapterManager.t_pembelian_headerTableAdapter = null;
            this.tableAdapterManager.t_penawaran_detailTableAdapter = null;
            this.tableAdapterManager.t_penawaran_headerTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = PCSUAS.dbProjectUasDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // m_supplierTableAdapter
            // 
            this.m_supplierTableAdapter.ClearBeforeFill = true;
            // 
            // t_invoice_headerBindingNavigator
            // 
            this.t_invoice_headerBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.t_invoice_headerBindingNavigator.BindingSource = this.t_invoice_headerBindingSource;
            this.t_invoice_headerBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.t_invoice_headerBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.t_invoice_headerBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.t_invoice_headerBindingNavigatorSaveItem});
            this.t_invoice_headerBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.t_invoice_headerBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.t_invoice_headerBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.t_invoice_headerBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.t_invoice_headerBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.t_invoice_headerBindingNavigator.Name = "t_invoice_headerBindingNavigator";
            this.t_invoice_headerBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.t_invoice_headerBindingNavigator.Size = new System.Drawing.Size(1122, 25);
            this.t_invoice_headerBindingNavigator.TabIndex = 1;
            this.t_invoice_headerBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            this.bindingNavigatorAddNewItem.Click += new System.EventHandler(this.bindingNavigatorAddNewItem_Click);
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
            this.bindingNavigatorDeleteItem.Click += new System.EventHandler(this.bindingNavigatorDeleteItem_Click);
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
            this.bindingNavigatorMoveLastItem.Click += new System.EventHandler(this.bindingNavigatorMoveLastItem_Click);
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // t_invoice_headerBindingNavigatorSaveItem
            // 
            this.t_invoice_headerBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.t_invoice_headerBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("t_invoice_headerBindingNavigatorSaveItem.Image")));
            this.t_invoice_headerBindingNavigatorSaveItem.Name = "t_invoice_headerBindingNavigatorSaveItem";
            this.t_invoice_headerBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.t_invoice_headerBindingNavigatorSaveItem.Text = "Save Data";
            this.t_invoice_headerBindingNavigatorSaveItem.Click += new System.EventHandler(this.t_invoice_headerBindingNavigatorSaveItem_Click);
            // 
            // nO_INVTextBox
            // 
            this.nO_INVTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.t_invoice_headerBindingSource, "NO_INV", true));
            this.nO_INVTextBox.Enabled = false;
            this.nO_INVTextBox.Location = new System.Drawing.Point(57, 50);
            this.nO_INVTextBox.Name = "nO_INVTextBox";
            this.nO_INVTextBox.Size = new System.Drawing.Size(100, 20);
            this.nO_INVTextBox.TabIndex = 3;
            // 
            // nO_PNWTextBox
            // 
            this.nO_PNWTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.t_invoice_headerBindingSource, "NO_PNW", true));
            this.nO_PNWTextBox.Location = new System.Drawing.Point(240, 50);
            this.nO_PNWTextBox.Name = "nO_PNWTextBox";
            this.nO_PNWTextBox.Size = new System.Drawing.Size(100, 20);
            this.nO_PNWTextBox.TabIndex = 4;
            // 
            // tGL_INVDateTimePicker
            // 
            this.tGL_INVDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.t_invoice_headerBindingSource, "TGL_INV", true));
            this.tGL_INVDateTimePicker.Location = new System.Drawing.Point(402, 50);
            this.tGL_INVDateTimePicker.Name = "tGL_INVDateTimePicker";
            this.tGL_INVDateTimePicker.Size = new System.Drawing.Size(130, 20);
            this.tGL_INVDateTimePicker.TabIndex = 6;
            // 
            // tGL_TERIMADateTimePicker
            // 
            this.tGL_TERIMADateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.t_invoice_headerBindingSource, "TGL_TERIMA", true));
            this.tGL_TERIMADateTimePicker.Location = new System.Drawing.Point(607, 50);
            this.tGL_TERIMADateTimePicker.Name = "tGL_TERIMADateTimePicker";
            this.tGL_TERIMADateTimePicker.Size = new System.Drawing.Size(130, 20);
            this.tGL_TERIMADateTimePicker.TabIndex = 8;
            // 
            // msupplierBindingSource
            // 
            this.msupplierBindingSource.DataMember = "m_supplier";
            this.msupplierBindingSource.DataSource = this.dbProjectUasDataSet;
            // 
            // dgvBarang
            // 
            this.dgvBarang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBarang.Location = new System.Drawing.Point(7, 158);
            this.dgvBarang.Name = "dgvBarang";
            this.dgvBarang.Size = new System.Drawing.Size(1095, 326);
            this.dgvBarang.TabIndex = 23;
            this.dgvBarang.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBarang_CellDoubleClick);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(921, 492);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 24;
            this.label5.Text = "Part $";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(907, 516);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 13);
            this.label6.TabIndex = 25;
            this.label6.Text = "Discount";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(904, 538);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 13);
            this.label7.TabIndex = 26;
            this.label7.Text = "Service $";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(927, 564);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(29, 13);
            this.label8.TabIndex = 27;
            this.label8.Text = "PPN";
            // 
            // tbPartPrice
            // 
            this.tbPartPrice.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbPartPrice.Location = new System.Drawing.Point(973, 489);
            this.tbPartPrice.Name = "tbPartPrice";
            this.tbPartPrice.Size = new System.Drawing.Size(124, 20);
            this.tbPartPrice.TabIndex = 28;
            this.tbPartPrice.Text = "0";
            this.tbPartPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tbDiscount
            // 
            this.tbDiscount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbDiscount.ForeColor = System.Drawing.Color.Red;
            this.tbDiscount.Location = new System.Drawing.Point(973, 512);
            this.tbDiscount.Name = "tbDiscount";
            this.tbDiscount.Size = new System.Drawing.Size(124, 20);
            this.tbDiscount.TabIndex = 29;
            this.tbDiscount.Text = "0";
            this.tbDiscount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tbService
            // 
            this.tbService.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbService.Location = new System.Drawing.Point(973, 535);
            this.tbService.Name = "tbService";
            this.tbService.Size = new System.Drawing.Size(124, 20);
            this.tbService.TabIndex = 30;
            this.tbService.Text = "0";
            this.tbService.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tbPPN
            // 
            this.tbPPN.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbPPN.ForeColor = System.Drawing.Color.Red;
            this.tbPPN.Location = new System.Drawing.Point(973, 558);
            this.tbPPN.Name = "tbPPN";
            this.tbPPN.Size = new System.Drawing.Size(124, 20);
            this.tbPPN.TabIndex = 31;
            this.tbPPN.Text = "0";
            this.tbPPN.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(862, 569);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(235, 13);
            this.label9.TabIndex = 32;
            this.label9.Text = "______________________________________";
            // 
            // tbTotal
            // 
            this.tbTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbTotal.Location = new System.Drawing.Point(973, 586);
            this.tbTotal.Name = "tbTotal";
            this.tbTotal.Size = new System.Drawing.Size(124, 20);
            this.tbTotal.TabIndex = 34;
            this.tbTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(916, 589);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(40, 13);
            this.label10.TabIndex = 33;
            this.label10.Text = "Total $";
            // 
            // p_IDComboBox
            // 
            this.p_IDComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.t_invoice_headerBindingSource, "P_ID", true));
            this.p_IDComboBox.DataSource = this.msupplierBindingSource;
            this.p_IDComboBox.DisplayMember = "P_ID";
            this.p_IDComboBox.FormattingEnabled = true;
            this.p_IDComboBox.Location = new System.Drawing.Point(57, 76);
            this.p_IDComboBox.Name = "p_IDComboBox";
            this.p_IDComboBox.Size = new System.Drawing.Size(121, 21);
            this.p_IDComboBox.TabIndex = 35;
            this.p_IDComboBox.ValueMember = "P_ID";
            // 
            // tinvoiceheaderBindingSource
            // 
            this.tinvoiceheaderBindingSource.DataMember = "t_invoice_header";
            this.tinvoiceheaderBindingSource.DataSource = this.dbProjectUasDataSet;
            // 
            // nAMATextBox
            // 
            this.nAMATextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.msupplierBindingSource, "NAMA", true));
            this.nAMATextBox.Location = new System.Drawing.Point(184, 77);
            this.nAMATextBox.Name = "nAMATextBox";
            this.nAMATextBox.Size = new System.Drawing.Size(417, 20);
            this.nAMATextBox.TabIndex = 36;
            // 
            // aLAMATTextBox
            // 
            this.aLAMATTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.msupplierBindingSource, "ALAMAT", true));
            this.aLAMATTextBox.Location = new System.Drawing.Point(607, 77);
            this.aLAMATTextBox.Name = "aLAMATTextBox";
            this.aLAMATTextBox.Size = new System.Drawing.Size(495, 20);
            this.aLAMATTextBox.TabIndex = 37;
            // 
            // eMAILTextBox
            // 
            this.eMAILTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.msupplierBindingSource, "EMAIL", true));
            this.eMAILTextBox.Location = new System.Drawing.Point(802, 51);
            this.eMAILTextBox.Name = "eMAILTextBox";
            this.eMAILTextBox.Size = new System.Drawing.Size(154, 20);
            this.eMAILTextBox.TabIndex = 38;
            // 
            // kOTATextBox
            // 
            this.kOTATextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.msupplierBindingSource, "KOTA", true));
            this.kOTATextBox.Location = new System.Drawing.Point(962, 50);
            this.kOTATextBox.Name = "kOTATextBox";
            this.kOTATextBox.Size = new System.Drawing.Size(140, 20);
            this.kOTATextBox.TabIndex = 39;
            // 
            // nAMA_NPWPTextBox
            // 
            this.nAMA_NPWPTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.msupplierBindingSource, "NAMA_NPWP", true));
            this.nAMA_NPWPTextBox.Location = new System.Drawing.Point(57, 107);
            this.nAMA_NPWPTextBox.Name = "nAMA_NPWPTextBox";
            this.nAMA_NPWPTextBox.Size = new System.Drawing.Size(445, 20);
            this.nAMA_NPWPTextBox.TabIndex = 40;
            // 
            // nPWPTextBox
            // 
            this.nPWPTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.msupplierBindingSource, "NPWP", true));
            this.nPWPTextBox.Location = new System.Drawing.Point(508, 107);
            this.nPWPTextBox.Name = "nPWPTextBox";
            this.nPWPTextBox.Size = new System.Drawing.Size(594, 20);
            this.nPWPTextBox.TabIndex = 41;
            // 
            // nOTETextBox
            // 
            this.nOTETextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.msupplierBindingSource, "NOTE", true));
            this.nOTETextBox.Location = new System.Drawing.Point(57, 134);
            this.nOTETextBox.Name = "nOTETextBox";
            this.nOTETextBox.Size = new System.Drawing.Size(1045, 20);
            this.nOTETextBox.TabIndex = 42;
            // 
            // tbDescEdit
            // 
            this.tbDescEdit.Location = new System.Drawing.Point(387, 536);
            this.tbDescEdit.Name = "tbDescEdit";
            this.tbDescEdit.Size = new System.Drawing.Size(90, 20);
            this.tbDescEdit.TabIndex = 84;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(324, 633);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 83;
            this.btnUpdate.Text = "Update Item";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(265, 610);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(61, 13);
            this.label12.TabIndex = 82;
            this.label12.Text = "Harga Jual:";
            // 
            // tbEditHargaJual
            // 
            this.tbEditHargaJual.Location = new System.Drawing.Point(332, 607);
            this.tbEditHargaJual.Name = "tbEditHargaJual";
            this.tbEditHargaJual.Size = new System.Drawing.Size(145, 20);
            this.tbEditHargaJual.TabIndex = 81;
            // 
            // updateQty
            // 
            this.updateQty.Location = new System.Drawing.Point(332, 570);
            this.updateQty.Name = "updateQty";
            this.updateQty.Size = new System.Drawing.Size(145, 20);
            this.updateQty.TabIndex = 80;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(291, 570);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(35, 13);
            this.label11.TabIndex = 79;
            this.label11.Text = "QTY :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(288, 539);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 78;
            this.label1.Text = "Kode :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(86, 585);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 77;
            this.label2.Text = "Harga Jual:";
            // 
            // tbHargaJual
            // 
            this.tbHargaJual.Location = new System.Drawing.Point(89, 603);
            this.tbHargaJual.Name = "tbHargaJual";
            this.tbHargaJual.Size = new System.Drawing.Size(100, 20);
            this.tbHargaJual.TabIndex = 76;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(86, 539);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 75;
            this.label3.Text = "Harga Beli:";
            // 
            // tbHargaBeli
            // 
            this.tbHargaBeli.Enabled = false;
            this.tbHargaBeli.Location = new System.Drawing.Point(89, 555);
            this.tbHargaBeli.Name = "tbHargaBeli";
            this.tbHargaBeli.Size = new System.Drawing.Size(100, 20);
            this.tbHargaBeli.TabIndex = 74;
            // 
            // btnBatal
            // 
            this.btnBatal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBatal.Enabled = false;
            this.btnBatal.Location = new System.Drawing.Point(324, 661);
            this.btnBatal.Name = "btnBatal";
            this.btnBatal.Size = new System.Drawing.Size(153, 23);
            this.btnBatal.TabIndex = 73;
            this.btnBatal.Text = "Batal";
            this.btnBatal.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.btnBatal.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Enabled = false;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(291, 512);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(147, 13);
            this.label4.TabIndex = 72;
            this.label4.Text = "EDIT / HAPUS BARANG";
            // 
            // tbHapusKode
            // 
            this.tbHapusKode.Enabled = false;
            this.tbHapusKode.Location = new System.Drawing.Point(332, 536);
            this.tbHapusKode.Name = "tbHapusKode";
            this.tbHapusKode.Size = new System.Drawing.Size(49, 20);
            this.tbHapusKode.TabIndex = 71;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(89, 626);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown1.TabIndex = 70;
            // 
            // comboBox3
            // 
            this.comboBox3.DataSource = this.mbarangBindingSource;
            this.comboBox3.DisplayMember = "DESCRIPTION";
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(89, 509);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(121, 21);
            this.comboBox3.TabIndex = 69;
            this.comboBox3.ValueMember = "ID";
            this.comboBox3.TextChanged += new System.EventHandler(this.comboBox3_TextChanged);
            // 
            // mbarangBindingSource
            // 
            this.mbarangBindingSource.DataMember = "m_barang";
            this.mbarangBindingSource.DataSource = this.dbProjectUasDataSet;
            // 
            // btnHapusItem
            // 
            this.btnHapusItem.BackColor = System.Drawing.Color.Red;
            this.btnHapusItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnHapusItem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHapusItem.Enabled = false;
            this.btnHapusItem.ForeColor = System.Drawing.SystemColors.Control;
            this.btnHapusItem.Location = new System.Drawing.Point(405, 633);
            this.btnHapusItem.Name = "btnHapusItem";
            this.btnHapusItem.Size = new System.Drawing.Size(72, 23);
            this.btnHapusItem.TabIndex = 68;
            this.btnHapusItem.Text = "Delete Item";
            this.btnHapusItem.UseVisualStyleBackColor = false;
            this.btnHapusItem.Click += new System.EventHandler(this.btnHapusItem_Click);
            // 
            // btnTambahItem
            // 
            this.btnTambahItem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTambahItem.Location = new System.Drawing.Point(89, 652);
            this.btnTambahItem.Name = "btnTambahItem";
            this.btnTambahItem.Size = new System.Drawing.Size(78, 23);
            this.btnTambahItem.TabIndex = 67;
            this.btnTambahItem.Text = "Tambah Item";
            this.btnTambahItem.UseVisualStyleBackColor = true;
            this.btnTambahItem.Click += new System.EventHandler(this.btnTambahItem_Click);
            // 
            // m_barangTableAdapter
            // 
            this.m_barangTableAdapter.ClearBeforeFill = true;
            // 
            // InvoiceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1122, 729);
            this.Controls.Add(this.tbDescEdit);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.tbEditHargaJual);
            this.Controls.Add(this.updateQty);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbHargaJual);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbHargaBeli);
            this.Controls.Add(this.btnBatal);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbHapusKode);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.btnHapusItem);
            this.Controls.Add(this.btnTambahItem);
            this.Controls.Add(nOTELabel);
            this.Controls.Add(this.nOTETextBox);
            this.Controls.Add(this.nPWPTextBox);
            this.Controls.Add(nAMA_NPWPLabel);
            this.Controls.Add(this.nAMA_NPWPTextBox);
            this.Controls.Add(this.kOTATextBox);
            this.Controls.Add(eMAILLabel);
            this.Controls.Add(this.eMAILTextBox);
            this.Controls.Add(this.aLAMATTextBox);
            this.Controls.Add(this.nAMATextBox);
            this.Controls.Add(this.p_IDComboBox);
            this.Controls.Add(this.tbTotal);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.tbPPN);
            this.Controls.Add(this.tbService);
            this.Controls.Add(this.tbDiscount);
            this.Controls.Add(this.tbPartPrice);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dgvBarang);
            this.Controls.Add(p_IDLabel);
            this.Controls.Add(tGL_TERIMALabel);
            this.Controls.Add(this.tGL_TERIMADateTimePicker);
            this.Controls.Add(tGL_INVLabel);
            this.Controls.Add(this.tGL_INVDateTimePicker);
            this.Controls.Add(nO_PNWLabel);
            this.Controls.Add(this.nO_PNWTextBox);
            this.Controls.Add(nO_INVLabel);
            this.Controls.Add(this.nO_INVTextBox);
            this.Controls.Add(this.t_invoice_headerBindingNavigator);
            this.Controls.Add(this.label9);
            this.Name = "InvoiceForm";
            this.Text = "InvoiceForm";
            this.Load += new System.EventHandler(this.InvoiceForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dbProjectUasDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.t_invoice_headerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.t_invoice_headerBindingNavigator)).EndInit();
            this.t_invoice_headerBindingNavigator.ResumeLayout(false);
            this.t_invoice_headerBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.msupplierBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBarang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tinvoiceheaderBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.updateQty)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mbarangBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private dbProjectUasDataSet dbProjectUasDataSet;
        private System.Windows.Forms.BindingSource t_invoice_headerBindingSource;
        private dbProjectUasDataSetTableAdapters.t_invoice_headerTableAdapter t_invoice_headerTableAdapter;
        private dbProjectUasDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator t_invoice_headerBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton t_invoice_headerBindingNavigatorSaveItem;
        private dbProjectUasDataSetTableAdapters.m_supplierTableAdapter m_supplierTableAdapter;
        private System.Windows.Forms.TextBox nO_INVTextBox;
        private System.Windows.Forms.TextBox nO_PNWTextBox;
        private System.Windows.Forms.DateTimePicker tGL_INVDateTimePicker;
        private System.Windows.Forms.DateTimePicker tGL_TERIMADateTimePicker;
        private System.Windows.Forms.BindingSource msupplierBindingSource;
        private System.Windows.Forms.DataGridView dgvBarang;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbPartPrice;
        private System.Windows.Forms.TextBox tbDiscount;
        private System.Windows.Forms.TextBox tbService;
        private System.Windows.Forms.TextBox tbPPN;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tbTotal;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox p_IDComboBox;
        private System.Windows.Forms.BindingSource tinvoiceheaderBindingSource;
        private System.Windows.Forms.TextBox nAMATextBox;
        private System.Windows.Forms.TextBox aLAMATTextBox;
        private System.Windows.Forms.TextBox eMAILTextBox;
        private System.Windows.Forms.TextBox kOTATextBox;
        private System.Windows.Forms.TextBox nAMA_NPWPTextBox;
        private System.Windows.Forms.TextBox nPWPTextBox;
        private System.Windows.Forms.TextBox nOTETextBox;
        private System.Windows.Forms.TextBox tbDescEdit;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox tbEditHargaJual;
        private System.Windows.Forms.NumericUpDown updateQty;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbHargaJual;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbHargaBeli;
        private System.Windows.Forms.Button btnBatal;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbHapusKode;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.Button btnHapusItem;
        private System.Windows.Forms.Button btnTambahItem;
        private System.Windows.Forms.BindingSource mbarangBindingSource;
        private dbProjectUasDataSetTableAdapters.m_barangTableAdapter m_barangTableAdapter;
    }
}