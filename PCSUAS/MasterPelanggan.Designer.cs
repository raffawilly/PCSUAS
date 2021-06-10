
namespace PCSUAS
{
    partial class MasterPelanggan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MasterPelanggan));
            System.Windows.Forms.Label p_CODELabel;
            System.Windows.Forms.Label nAMALabel;
            System.Windows.Forms.Label aLAMATLabel;
            System.Windows.Forms.Label kOTALabel;
            System.Windows.Forms.Label tELPLabel;
            System.Windows.Forms.Label nPWPLabel;
            System.Windows.Forms.Label nAMA_NPWPLabel;
            System.Windows.Forms.Label aLAMAT_NPWPLabel;
            System.Windows.Forms.Label nAMA1Label;
            System.Windows.Forms.Label aLAMAT1Label;
            System.Windows.Forms.Label kOTA1Label;
            System.Windows.Forms.Label hPLabel;
            System.Windows.Forms.Label kETERANGANLabel;
            this.dbProjectUasDataSet = new PCSUAS.dbProjectUasDataSet();
            this.m_pelangganBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.m_pelangganTableAdapter = new PCSUAS.dbProjectUasDataSetTableAdapters.m_pelangganTableAdapter();
            this.tableAdapterManager = new PCSUAS.dbProjectUasDataSetTableAdapters.TableAdapterManager();
            this.m_pelangganBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.m_pelangganBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.p_CODETextBox = new System.Windows.Forms.TextBox();
            this.nAMATextBox = new System.Windows.Forms.TextBox();
            this.aLAMATTextBox = new System.Windows.Forms.TextBox();
            this.kOTATextBox = new System.Windows.Forms.TextBox();
            this.tELPTextBox = new System.Windows.Forms.TextBox();
            this.nPWPTextBox = new System.Windows.Forms.TextBox();
            this.nAMA_NPWPTextBox = new System.Windows.Forms.TextBox();
            this.aLAMAT_NPWPTextBox = new System.Windows.Forms.TextBox();
            this.nAMA1TextBox = new System.Windows.Forms.TextBox();
            this.aLAMAT1TextBox = new System.Windows.Forms.TextBox();
            this.kOTA1TextBox = new System.Windows.Forms.TextBox();
            this.hPTextBox = new System.Windows.Forms.TextBox();
            this.kETERANGANTextBox = new System.Windows.Forms.TextBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.progressBar2 = new System.Windows.Forms.ProgressBar();
            this.label1 = new System.Windows.Forms.Label();
            p_CODELabel = new System.Windows.Forms.Label();
            nAMALabel = new System.Windows.Forms.Label();
            aLAMATLabel = new System.Windows.Forms.Label();
            kOTALabel = new System.Windows.Forms.Label();
            tELPLabel = new System.Windows.Forms.Label();
            nPWPLabel = new System.Windows.Forms.Label();
            nAMA_NPWPLabel = new System.Windows.Forms.Label();
            aLAMAT_NPWPLabel = new System.Windows.Forms.Label();
            nAMA1Label = new System.Windows.Forms.Label();
            aLAMAT1Label = new System.Windows.Forms.Label();
            kOTA1Label = new System.Windows.Forms.Label();
            hPLabel = new System.Windows.Forms.Label();
            kETERANGANLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dbProjectUasDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_pelangganBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_pelangganBindingNavigator)).BeginInit();
            this.m_pelangganBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // dbProjectUasDataSet
            // 
            this.dbProjectUasDataSet.DataSetName = "dbProjectUasDataSet";
            this.dbProjectUasDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // m_pelangganBindingSource
            // 
            this.m_pelangganBindingSource.DataMember = "m_pelanggan";
            this.m_pelangganBindingSource.DataSource = this.dbProjectUasDataSet;
            // 
            // m_pelangganTableAdapter
            // 
            this.m_pelangganTableAdapter.ClearBeforeFill = true;
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
            this.tableAdapterManager.m_pelangganTableAdapter = this.m_pelangganTableAdapter;
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
            // m_pelangganBindingNavigator
            // 
            this.m_pelangganBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.m_pelangganBindingNavigator.BindingSource = this.m_pelangganBindingSource;
            this.m_pelangganBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.m_pelangganBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.m_pelangganBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.m_pelangganBindingNavigatorSaveItem});
            this.m_pelangganBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.m_pelangganBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.m_pelangganBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.m_pelangganBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.m_pelangganBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.m_pelangganBindingNavigator.Name = "m_pelangganBindingNavigator";
            this.m_pelangganBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.m_pelangganBindingNavigator.Size = new System.Drawing.Size(800, 25);
            this.m_pelangganBindingNavigator.TabIndex = 0;
            this.m_pelangganBindingNavigator.Text = "bindingNavigator1";
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
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 15);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 6);
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
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // m_pelangganBindingNavigatorSaveItem
            // 
            this.m_pelangganBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.m_pelangganBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("m_pelangganBindingNavigatorSaveItem.Image")));
            this.m_pelangganBindingNavigatorSaveItem.Name = "m_pelangganBindingNavigatorSaveItem";
            this.m_pelangganBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.m_pelangganBindingNavigatorSaveItem.Text = "Save Data";
            this.m_pelangganBindingNavigatorSaveItem.Click += new System.EventHandler(this.m_pelangganBindingNavigatorSaveItem_Click);
            // 
            // p_CODELabel
            // 
            p_CODELabel.AutoSize = true;
            p_CODELabel.Location = new System.Drawing.Point(14, 161);
            p_CODELabel.Name = "p_CODELabel";
            p_CODELabel.Size = new System.Drawing.Size(76, 13);
            p_CODELabel.TabIndex = 3;
            p_CODELabel.Text = "PELANGGAN:";
            // 
            // p_CODETextBox
            // 
            this.p_CODETextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.m_pelangganBindingSource, "P_CODE", true));
            this.p_CODETextBox.Location = new System.Drawing.Point(107, 158);
            this.p_CODETextBox.Name = "p_CODETextBox";
            this.p_CODETextBox.Size = new System.Drawing.Size(100, 20);
            this.p_CODETextBox.TabIndex = 4;
            // 
            // nAMALabel
            // 
            nAMALabel.AutoSize = true;
            nAMALabel.Location = new System.Drawing.Point(49, 193);
            nAMALabel.Name = "nAMALabel";
            nAMALabel.Size = new System.Drawing.Size(41, 13);
            nAMALabel.TabIndex = 5;
            nAMALabel.Text = "NAMA:";
            // 
            // nAMATextBox
            // 
            this.nAMATextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.m_pelangganBindingSource, "NAMA", true));
            this.nAMATextBox.Location = new System.Drawing.Point(107, 193);
            this.nAMATextBox.Name = "nAMATextBox";
            this.nAMATextBox.Size = new System.Drawing.Size(100, 20);
            this.nAMATextBox.TabIndex = 6;
            // 
            // aLAMATLabel
            // 
            aLAMATLabel.AutoSize = true;
            aLAMATLabel.Location = new System.Drawing.Point(37, 224);
            aLAMATLabel.Name = "aLAMATLabel";
            aLAMATLabel.Size = new System.Drawing.Size(53, 13);
            aLAMATLabel.TabIndex = 7;
            aLAMATLabel.Text = "ALAMAT:";
            // 
            // aLAMATTextBox
            // 
            this.aLAMATTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.m_pelangganBindingSource, "ALAMAT", true));
            this.aLAMATTextBox.Location = new System.Drawing.Point(107, 221);
            this.aLAMATTextBox.Name = "aLAMATTextBox";
            this.aLAMATTextBox.Size = new System.Drawing.Size(100, 20);
            this.aLAMATTextBox.TabIndex = 8;
            // 
            // kOTALabel
            // 
            kOTALabel.AutoSize = true;
            kOTALabel.Location = new System.Drawing.Point(249, 224);
            kOTALabel.Name = "kOTALabel";
            kOTALabel.Size = new System.Drawing.Size(39, 13);
            kOTALabel.TabIndex = 9;
            kOTALabel.Text = "KOTA:";
            // 
            // kOTATextBox
            // 
            this.kOTATextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.m_pelangganBindingSource, "KOTA", true));
            this.kOTATextBox.Location = new System.Drawing.Point(306, 221);
            this.kOTATextBox.Name = "kOTATextBox";
            this.kOTATextBox.Size = new System.Drawing.Size(100, 20);
            this.kOTATextBox.TabIndex = 10;
            // 
            // tELPLabel
            // 
            tELPLabel.AutoSize = true;
            tELPLabel.Location = new System.Drawing.Point(225, 197);
            tELPLabel.Name = "tELPLabel";
            tELPLabel.Size = new System.Drawing.Size(63, 13);
            tELPLabel.TabIndex = 11;
            tELPLabel.Text = "TELP / HP:";
            // 
            // tELPTextBox
            // 
            this.tELPTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.m_pelangganBindingSource, "TELP", true));
            this.tELPTextBox.Location = new System.Drawing.Point(306, 193);
            this.tELPTextBox.Name = "tELPTextBox";
            this.tELPTextBox.Size = new System.Drawing.Size(100, 20);
            this.tELPTextBox.TabIndex = 12;
            // 
            // nPWPLabel
            // 
            nPWPLabel.AutoSize = true;
            nPWPLabel.Location = new System.Drawing.Point(244, 401);
            nPWPLabel.Name = "nPWPLabel";
            nPWPLabel.Size = new System.Drawing.Size(43, 13);
            nPWPLabel.TabIndex = 13;
            nPWPLabel.Text = "NPWP:";
            // 
            // nPWPTextBox
            // 
            this.nPWPTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.m_pelangganBindingSource, "NPWP", true));
            this.nPWPTextBox.Location = new System.Drawing.Point(310, 397);
            this.nPWPTextBox.Name = "nPWPTextBox";
            this.nPWPTextBox.Size = new System.Drawing.Size(100, 20);
            this.nPWPTextBox.TabIndex = 14;
            // 
            // nAMA_NPWPLabel
            // 
            nAMA_NPWPLabel.AutoSize = true;
            nAMA_NPWPLabel.Location = new System.Drawing.Point(14, 398);
            nAMA_NPWPLabel.Name = "nAMA_NPWPLabel";
            nAMA_NPWPLabel.Size = new System.Drawing.Size(77, 13);
            nAMA_NPWPLabel.TabIndex = 15;
            nAMA_NPWPLabel.Text = "NAMA NPWP:";
            // 
            // nAMA_NPWPTextBox
            // 
            this.nAMA_NPWPTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.m_pelangganBindingSource, "NAMA_NPWP", true));
            this.nAMA_NPWPTextBox.Location = new System.Drawing.Point(111, 397);
            this.nAMA_NPWPTextBox.Name = "nAMA_NPWPTextBox";
            this.nAMA_NPWPTextBox.Size = new System.Drawing.Size(100, 20);
            this.nAMA_NPWPTextBox.TabIndex = 16;
            // 
            // aLAMAT_NPWPLabel
            // 
            aLAMAT_NPWPLabel.AutoSize = true;
            aLAMAT_NPWPLabel.Location = new System.Drawing.Point(3, 439);
            aLAMAT_NPWPLabel.Name = "aLAMAT_NPWPLabel";
            aLAMAT_NPWPLabel.Size = new System.Drawing.Size(89, 13);
            aLAMAT_NPWPLabel.TabIndex = 17;
            aLAMAT_NPWPLabel.Text = "ALAMAT NPWP:";
            // 
            // aLAMAT_NPWPTextBox
            // 
            this.aLAMAT_NPWPTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.m_pelangganBindingSource, "ALAMAT_NPWP", true));
            this.aLAMAT_NPWPTextBox.Location = new System.Drawing.Point(111, 436);
            this.aLAMAT_NPWPTextBox.Name = "aLAMAT_NPWPTextBox";
            this.aLAMAT_NPWPTextBox.Size = new System.Drawing.Size(299, 20);
            this.aLAMAT_NPWPTextBox.TabIndex = 18;
            // 
            // nAMA1Label
            // 
            nAMA1Label.AutoSize = true;
            nAMA1Label.Location = new System.Drawing.Point(40, 293);
            nAMA1Label.Name = "nAMA1Label";
            nAMA1Label.Size = new System.Drawing.Size(47, 13);
            nAMA1Label.TabIndex = 19;
            nAMA1Label.Text = "Nama 2:";
            // 
            // nAMA1TextBox
            // 
            this.nAMA1TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.m_pelangganBindingSource, "NAMA1", true));
            this.nAMA1TextBox.Location = new System.Drawing.Point(107, 286);
            this.nAMA1TextBox.Name = "nAMA1TextBox";
            this.nAMA1TextBox.Size = new System.Drawing.Size(100, 20);
            this.nAMA1TextBox.TabIndex = 20;
            // 
            // aLAMAT1Label
            // 
            aLAMAT1Label.AutoSize = true;
            aLAMAT1Label.Location = new System.Drawing.Point(36, 321);
            aLAMAT1Label.Name = "aLAMAT1Label";
            aLAMAT1Label.Size = new System.Drawing.Size(51, 13);
            aLAMAT1Label.TabIndex = 21;
            aLAMAT1Label.Text = "Alamat 2:";
            // 
            // aLAMAT1TextBox
            // 
            this.aLAMAT1TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.m_pelangganBindingSource, "ALAMAT1", true));
            this.aLAMAT1TextBox.Location = new System.Drawing.Point(107, 318);
            this.aLAMAT1TextBox.Name = "aLAMAT1TextBox";
            this.aLAMAT1TextBox.Size = new System.Drawing.Size(100, 20);
            this.aLAMAT1TextBox.TabIndex = 22;
            // 
            // kOTA1Label
            // 
            kOTA1Label.AutoSize = true;
            kOTA1Label.Location = new System.Drawing.Point(247, 321);
            kOTA1Label.Name = "kOTA1Label";
            kOTA1Label.Size = new System.Drawing.Size(41, 13);
            kOTA1Label.TabIndex = 23;
            kOTA1Label.Text = "Kota 2:";
            // 
            // kOTA1TextBox
            // 
            this.kOTA1TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.m_pelangganBindingSource, "KOTA1", true));
            this.kOTA1TextBox.Location = new System.Drawing.Point(306, 318);
            this.kOTA1TextBox.Name = "kOTA1TextBox";
            this.kOTA1TextBox.Size = new System.Drawing.Size(100, 20);
            this.kOTA1TextBox.TabIndex = 24;
            // 
            // hPLabel
            // 
            hPLabel.AutoSize = true;
            hPLabel.Location = new System.Drawing.Point(229, 289);
            hPLabel.Name = "hPLabel";
            hPLabel.Size = new System.Drawing.Size(59, 13);
            hPLabel.TabIndex = 25;
            hPLabel.Text = "Nomor HP:";
            // 
            // hPTextBox
            // 
            this.hPTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.m_pelangganBindingSource, "HP", true));
            this.hPTextBox.Location = new System.Drawing.Point(306, 286);
            this.hPTextBox.Name = "hPTextBox";
            this.hPTextBox.Size = new System.Drawing.Size(100, 20);
            this.hPTextBox.TabIndex = 26;
            // 
            // kETERANGANLabel
            // 
            kETERANGANLabel.AutoSize = true;
            kETERANGANLabel.Location = new System.Drawing.Point(10, 476);
            kETERANGANLabel.Name = "kETERANGANLabel";
            kETERANGANLabel.Size = new System.Drawing.Size(84, 13);
            kETERANGANLabel.TabIndex = 27;
            kETERANGANLabel.Text = "KETERANGAN:";
            // 
            // kETERANGANTextBox
            // 
            this.kETERANGANTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.m_pelangganBindingSource, "KETERANGAN", true));
            this.kETERANGANTextBox.Location = new System.Drawing.Point(111, 473);
            this.kETERANGANTextBox.Name = "kETERANGANTextBox";
            this.kETERANGANTextBox.Size = new System.Drawing.Size(299, 20);
            this.kETERANGANTextBox.TabIndex = 28;
            // 
            // progressBar1
            // 
            this.progressBar1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.progressBar1.Cursor = System.Windows.Forms.Cursors.Default;
            this.progressBar1.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.progressBar1.Location = new System.Drawing.Point(3, 259);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(785, 10);
            this.progressBar1.TabIndex = 29;
            // 
            // progressBar2
            // 
            this.progressBar2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.progressBar2.Cursor = System.Windows.Forms.Cursors.Default;
            this.progressBar2.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.progressBar2.Location = new System.Drawing.Point(12, 362);
            this.progressBar2.Name = "progressBar2";
            this.progressBar2.Size = new System.Drawing.Size(785, 10);
            this.progressBar2.TabIndex = 30;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(192, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(400, 40);
            this.label1.TabIndex = 31;
            this.label1.Text = "MASTER PELANGGAN";
            // 
            // MasterPelanggan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 538);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.progressBar2);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(p_CODELabel);
            this.Controls.Add(this.p_CODETextBox);
            this.Controls.Add(nAMALabel);
            this.Controls.Add(this.nAMATextBox);
            this.Controls.Add(aLAMATLabel);
            this.Controls.Add(this.aLAMATTextBox);
            this.Controls.Add(kOTALabel);
            this.Controls.Add(this.kOTATextBox);
            this.Controls.Add(tELPLabel);
            this.Controls.Add(this.tELPTextBox);
            this.Controls.Add(nPWPLabel);
            this.Controls.Add(this.nPWPTextBox);
            this.Controls.Add(nAMA_NPWPLabel);
            this.Controls.Add(this.nAMA_NPWPTextBox);
            this.Controls.Add(aLAMAT_NPWPLabel);
            this.Controls.Add(this.aLAMAT_NPWPTextBox);
            this.Controls.Add(nAMA1Label);
            this.Controls.Add(this.nAMA1TextBox);
            this.Controls.Add(aLAMAT1Label);
            this.Controls.Add(this.aLAMAT1TextBox);
            this.Controls.Add(kOTA1Label);
            this.Controls.Add(this.kOTA1TextBox);
            this.Controls.Add(hPLabel);
            this.Controls.Add(this.hPTextBox);
            this.Controls.Add(kETERANGANLabel);
            this.Controls.Add(this.kETERANGANTextBox);
            this.Controls.Add(this.m_pelangganBindingNavigator);
            this.Name = "MasterPelanggan";
            this.Text = "MasterPelanggan";
            this.Load += new System.EventHandler(this.MasterPelanggan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dbProjectUasDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_pelangganBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_pelangganBindingNavigator)).EndInit();
            this.m_pelangganBindingNavigator.ResumeLayout(false);
            this.m_pelangganBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private dbProjectUasDataSet dbProjectUasDataSet;
        private System.Windows.Forms.BindingSource m_pelangganBindingSource;
        private dbProjectUasDataSetTableAdapters.m_pelangganTableAdapter m_pelangganTableAdapter;
        private dbProjectUasDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator m_pelangganBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton m_pelangganBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox p_CODETextBox;
        private System.Windows.Forms.TextBox nAMATextBox;
        private System.Windows.Forms.TextBox aLAMATTextBox;
        private System.Windows.Forms.TextBox kOTATextBox;
        private System.Windows.Forms.TextBox tELPTextBox;
        private System.Windows.Forms.TextBox nPWPTextBox;
        private System.Windows.Forms.TextBox nAMA_NPWPTextBox;
        private System.Windows.Forms.TextBox aLAMAT_NPWPTextBox;
        private System.Windows.Forms.TextBox nAMA1TextBox;
        private System.Windows.Forms.TextBox aLAMAT1TextBox;
        private System.Windows.Forms.TextBox kOTA1TextBox;
        private System.Windows.Forms.TextBox hPTextBox;
        private System.Windows.Forms.TextBox kETERANGANTextBox;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.ProgressBar progressBar2;
        private System.Windows.Forms.Label label1;
    }
}