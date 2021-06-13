
namespace PCSUAS
{
    partial class MasterGroupUser
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
            System.Windows.Forms.Label nAMAGROUPUSERLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MasterGroupUser));
            System.Windows.Forms.Label nAMAGROUPUSERLabel1;
            System.Windows.Forms.Label nAMAMENULabel;
            System.Windows.Forms.Label uSERNAMELabel;
            System.Windows.Forms.Label pASSWORDLabel;
            System.Windows.Forms.Label nAMAGROUPUSERLabel2;
            this.dbProjectUasDataSet = new PCSUAS.dbProjectUasDataSet();
            this.m_groupuserBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.m_groupuserTableAdapter = new PCSUAS.dbProjectUasDataSetTableAdapters.m_groupuserTableAdapter();
            this.tableAdapterManager = new PCSUAS.dbProjectUasDataSetTableAdapters.TableAdapterManager();
            this.m_groupuserBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.nAMAGROUPUSERTextBox = new System.Windows.Forms.TextBox();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.m_groupuserBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.m_hakaksesgroupuserBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.m_hakaksesgroupuserTableAdapter = new PCSUAS.dbProjectUasDataSetTableAdapters.m_hakaksesgroupuserTableAdapter();
            this.nAMAGROUPUSERTextBox1 = new System.Windows.Forms.TextBox();
            this.nAMAMENUTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.m_usersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.m_usersTableAdapter = new PCSUAS.dbProjectUasDataSetTableAdapters.m_usersTableAdapter();
            this.uSERNAMETextBox = new System.Windows.Forms.TextBox();
            this.pASSWORDTextBox = new System.Windows.Forms.TextBox();
            this.nAMAGROUPUSERTextBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            nAMAGROUPUSERLabel = new System.Windows.Forms.Label();
            nAMAGROUPUSERLabel1 = new System.Windows.Forms.Label();
            nAMAMENULabel = new System.Windows.Forms.Label();
            uSERNAMELabel = new System.Windows.Forms.Label();
            pASSWORDLabel = new System.Windows.Forms.Label();
            nAMAGROUPUSERLabel2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dbProjectUasDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_groupuserBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_groupuserBindingNavigator)).BeginInit();
            this.m_groupuserBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.m_hakaksesgroupuserBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_usersBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dbProjectUasDataSet
            // 
            this.dbProjectUasDataSet.DataSetName = "dbProjectUasDataSet";
            this.dbProjectUasDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // m_groupuserBindingSource
            // 
            this.m_groupuserBindingSource.DataMember = "m_groupuser";
            this.m_groupuserBindingSource.DataSource = this.dbProjectUasDataSet;
            // 
            // m_groupuserTableAdapter
            // 
            this.m_groupuserTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.m_barangTableAdapter = null;
            this.tableAdapterManager.m_groupuserTableAdapter = this.m_groupuserTableAdapter;
            this.tableAdapterManager.m_hakaksesgroupuserTableAdapter = this.m_hakaksesgroupuserTableAdapter;
            this.tableAdapterManager.m_kotaTableAdapter = null;
            this.tableAdapterManager.m_merkTableAdapter = null;
            this.tableAdapterManager.m_modelTableAdapter = null;
            this.tableAdapterManager.m_pelangganTableAdapter = null;
            this.tableAdapterManager.m_supplierTableAdapter = null;
            this.tableAdapterManager.m_usersTableAdapter = this.m_usersTableAdapter;
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
            // m_groupuserBindingNavigator
            // 
            this.m_groupuserBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.m_groupuserBindingNavigator.BindingSource = this.m_groupuserBindingSource;
            this.m_groupuserBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.m_groupuserBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.m_groupuserBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.m_groupuserBindingNavigatorSaveItem});
            this.m_groupuserBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.m_groupuserBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.m_groupuserBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.m_groupuserBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.m_groupuserBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.m_groupuserBindingNavigator.Name = "m_groupuserBindingNavigator";
            this.m_groupuserBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.m_groupuserBindingNavigator.Size = new System.Drawing.Size(800, 25);
            this.m_groupuserBindingNavigator.TabIndex = 0;
            this.m_groupuserBindingNavigator.Text = "bindingNavigator1";
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
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // nAMAGROUPUSERLabel
            // 
            nAMAGROUPUSERLabel.AutoSize = true;
            nAMAGROUPUSERLabel.Location = new System.Drawing.Point(40, 59);
            nAMAGROUPUSERLabel.Name = "nAMAGROUPUSERLabel";
            nAMAGROUPUSERLabel.Size = new System.Drawing.Size(110, 13);
            nAMAGROUPUSERLabel.TabIndex = 1;
            nAMAGROUPUSERLabel.Text = "NAMAGROUPUSER:";
            // 
            // nAMAGROUPUSERTextBox
            // 
            this.nAMAGROUPUSERTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.m_groupuserBindingSource, "NAMAGROUPUSER", true));
            this.nAMAGROUPUSERTextBox.Location = new System.Drawing.Point(156, 56);
            this.nAMAGROUPUSERTextBox.Name = "nAMAGROUPUSERTextBox";
            this.nAMAGROUPUSERTextBox.Size = new System.Drawing.Size(100, 20);
            this.nAMAGROUPUSERTextBox.TabIndex = 2;
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
            // m_groupuserBindingNavigatorSaveItem
            // 
            this.m_groupuserBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.m_groupuserBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("m_groupuserBindingNavigatorSaveItem.Image")));
            this.m_groupuserBindingNavigatorSaveItem.Name = "m_groupuserBindingNavigatorSaveItem";
            this.m_groupuserBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.m_groupuserBindingNavigatorSaveItem.Text = "Save Data";
            this.m_groupuserBindingNavigatorSaveItem.Click += new System.EventHandler(this.m_groupuserBindingNavigatorSaveItem_Click);
            // 
            // m_hakaksesgroupuserBindingSource
            // 
            this.m_hakaksesgroupuserBindingSource.DataMember = "FK_HAKAKSESGROUPUSER_GROUPUSERS";
            this.m_hakaksesgroupuserBindingSource.DataSource = this.m_groupuserBindingSource;
            // 
            // m_hakaksesgroupuserTableAdapter
            // 
            this.m_hakaksesgroupuserTableAdapter.ClearBeforeFill = true;
            // 
            // nAMAGROUPUSERLabel1
            // 
            nAMAGROUPUSERLabel1.AutoSize = true;
            nAMAGROUPUSERLabel1.Location = new System.Drawing.Point(40, 147);
            nAMAGROUPUSERLabel1.Name = "nAMAGROUPUSERLabel1";
            nAMAGROUPUSERLabel1.Size = new System.Drawing.Size(110, 13);
            nAMAGROUPUSERLabel1.TabIndex = 3;
            nAMAGROUPUSERLabel1.Text = "NAMAGROUPUSER:";
            // 
            // nAMAGROUPUSERTextBox1
            // 
            this.nAMAGROUPUSERTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.m_hakaksesgroupuserBindingSource, "NAMAGROUPUSER", true));
            this.nAMAGROUPUSERTextBox1.Location = new System.Drawing.Point(156, 144);
            this.nAMAGROUPUSERTextBox1.Name = "nAMAGROUPUSERTextBox1";
            this.nAMAGROUPUSERTextBox1.Size = new System.Drawing.Size(100, 20);
            this.nAMAGROUPUSERTextBox1.TabIndex = 4;
            // 
            // nAMAMENULabel
            // 
            nAMAMENULabel.AutoSize = true;
            nAMAMENULabel.Location = new System.Drawing.Point(40, 173);
            nAMAMENULabel.Name = "nAMAMENULabel";
            nAMAMENULabel.Size = new System.Drawing.Size(73, 13);
            nAMAMENULabel.TabIndex = 5;
            nAMAMENULabel.Text = "NAMAMENU:";
            // 
            // nAMAMENUTextBox
            // 
            this.nAMAMENUTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.m_hakaksesgroupuserBindingSource, "NAMAMENU", true));
            this.nAMAMENUTextBox.Location = new System.Drawing.Point(156, 170);
            this.nAMAMENUTextBox.Name = "nAMAMENUTextBox";
            this.nAMAMENUTextBox.Size = new System.Drawing.Size(100, 20);
            this.nAMAMENUTextBox.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 112);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(190, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Dari Database Master Hak Akses User";
            // 
            // m_usersBindingSource
            // 
            this.m_usersBindingSource.DataMember = "FK_USERS_GROUPUSERS";
            this.m_usersBindingSource.DataSource = this.m_groupuserBindingSource;
            // 
            // m_usersTableAdapter
            // 
            this.m_usersTableAdapter.ClearBeforeFill = true;
            // 
            // uSERNAMELabel
            // 
            uSERNAMELabel.AutoSize = true;
            uSERNAMELabel.Location = new System.Drawing.Point(40, 237);
            uSERNAMELabel.Name = "uSERNAMELabel";
            uSERNAMELabel.Size = new System.Drawing.Size(71, 13);
            uSERNAMELabel.TabIndex = 8;
            uSERNAMELabel.Text = "USERNAME:";
            // 
            // uSERNAMETextBox
            // 
            this.uSERNAMETextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.m_usersBindingSource, "USERNAME", true));
            this.uSERNAMETextBox.Location = new System.Drawing.Point(156, 234);
            this.uSERNAMETextBox.Name = "uSERNAMETextBox";
            this.uSERNAMETextBox.Size = new System.Drawing.Size(100, 20);
            this.uSERNAMETextBox.TabIndex = 9;
            // 
            // pASSWORDLabel
            // 
            pASSWORDLabel.AutoSize = true;
            pASSWORDLabel.Location = new System.Drawing.Point(40, 263);
            pASSWORDLabel.Name = "pASSWORDLabel";
            pASSWORDLabel.Size = new System.Drawing.Size(73, 13);
            pASSWORDLabel.TabIndex = 10;
            pASSWORDLabel.Text = "PASSWORD:";
            // 
            // pASSWORDTextBox
            // 
            this.pASSWORDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.m_usersBindingSource, "PASSWORD", true));
            this.pASSWORDTextBox.Location = new System.Drawing.Point(156, 260);
            this.pASSWORDTextBox.Name = "pASSWORDTextBox";
            this.pASSWORDTextBox.Size = new System.Drawing.Size(100, 20);
            this.pASSWORDTextBox.TabIndex = 11;
            // 
            // nAMAGROUPUSERLabel2
            // 
            nAMAGROUPUSERLabel2.AutoSize = true;
            nAMAGROUPUSERLabel2.Location = new System.Drawing.Point(40, 289);
            nAMAGROUPUSERLabel2.Name = "nAMAGROUPUSERLabel2";
            nAMAGROUPUSERLabel2.Size = new System.Drawing.Size(110, 13);
            nAMAGROUPUSERLabel2.TabIndex = 12;
            nAMAGROUPUSERLabel2.Text = "NAMAGROUPUSER:";
            // 
            // nAMAGROUPUSERTextBox2
            // 
            this.nAMAGROUPUSERTextBox2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.m_usersBindingSource, "NAMAGROUPUSER", true));
            this.nAMAGROUPUSERTextBox2.Location = new System.Drawing.Point(156, 286);
            this.nAMAGROUPUSERTextBox2.Name = "nAMAGROUPUSERTextBox2";
            this.nAMAGROUPUSERTextBox2.Size = new System.Drawing.Size(100, 20);
            this.nAMAGROUPUSERTextBox2.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 213);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Dari Database Master User";
            // 
            // MasterGroupUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(uSERNAMELabel);
            this.Controls.Add(this.uSERNAMETextBox);
            this.Controls.Add(pASSWORDLabel);
            this.Controls.Add(this.pASSWORDTextBox);
            this.Controls.Add(nAMAGROUPUSERLabel2);
            this.Controls.Add(this.nAMAGROUPUSERTextBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(nAMAGROUPUSERLabel1);
            this.Controls.Add(this.nAMAGROUPUSERTextBox1);
            this.Controls.Add(nAMAMENULabel);
            this.Controls.Add(this.nAMAMENUTextBox);
            this.Controls.Add(nAMAGROUPUSERLabel);
            this.Controls.Add(this.nAMAGROUPUSERTextBox);
            this.Controls.Add(this.m_groupuserBindingNavigator);
            this.Name = "MasterGroupUser";
            this.Text = "MasterGroupUser";
            this.Load += new System.EventHandler(this.MasterGroupUser_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dbProjectUasDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_groupuserBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_groupuserBindingNavigator)).EndInit();
            this.m_groupuserBindingNavigator.ResumeLayout(false);
            this.m_groupuserBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.m_hakaksesgroupuserBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_usersBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private dbProjectUasDataSet dbProjectUasDataSet;
        private System.Windows.Forms.BindingSource m_groupuserBindingSource;
        private dbProjectUasDataSetTableAdapters.m_groupuserTableAdapter m_groupuserTableAdapter;
        private dbProjectUasDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator m_groupuserBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton m_groupuserBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox nAMAGROUPUSERTextBox;
        private dbProjectUasDataSetTableAdapters.m_hakaksesgroupuserTableAdapter m_hakaksesgroupuserTableAdapter;
        private System.Windows.Forms.BindingSource m_hakaksesgroupuserBindingSource;
        private dbProjectUasDataSetTableAdapters.m_usersTableAdapter m_usersTableAdapter;
        private System.Windows.Forms.TextBox nAMAGROUPUSERTextBox1;
        private System.Windows.Forms.TextBox nAMAMENUTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource m_usersBindingSource;
        private System.Windows.Forms.TextBox uSERNAMETextBox;
        private System.Windows.Forms.TextBox pASSWORDTextBox;
        private System.Windows.Forms.TextBox nAMAGROUPUSERTextBox2;
        private System.Windows.Forms.Label label2;
    }
}