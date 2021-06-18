
namespace PCSUAS
{
    partial class MasterHakAkses
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
            System.Windows.Forms.Label label5;
            this.label4 = new System.Windows.Forms.Label();
            this.dbProjectUasDataSet = new PCSUAS.dbProjectUasDataSet();
            this.m_hakaksesgroupuserBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.m_hakaksesgroupuserTableAdapter = new PCSUAS.dbProjectUasDataSetTableAdapters.m_hakaksesgroupuserTableAdapter();
            this.tableAdapterManager = new PCSUAS.dbProjectUasDataSetTableAdapters.TableAdapterManager();
            this.CBGroupUser = new System.Windows.Forms.ComboBox();
            this.mgroupuserBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.m_groupuserTableAdapter = new PCSUAS.dbProjectUasDataSetTableAdapters.m_groupuserTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.NmMenuTxt = new System.Windows.Forms.TextBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.NmMenuInstxt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.CBGroupUserIns = new System.Windows.Forms.ComboBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.rbMenu = new System.Windows.Forms.RadioButton();
            this.rbGroupUser = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            nAMAGROUPUSERLabel = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dbProjectUasDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_hakaksesgroupuserBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mgroupuserBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // nAMAGROUPUSERLabel
            // 
            nAMAGROUPUSERLabel.AutoSize = true;
            nAMAGROUPUSERLabel.Location = new System.Drawing.Point(385, 137);
            nAMAGROUPUSERLabel.Name = "nAMAGROUPUSERLabel";
            nAMAGROUPUSERLabel.Size = new System.Drawing.Size(79, 12);
            nAMAGROUPUSERLabel.TabIndex = 4;
            nAMAGROUPUSERLabel.Text = "Nama Menu : ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(385, 257);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(79, 12);
            label5.TabIndex = 40;
            label5.Text = "Nama Menu : ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(351, 115);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 12);
            this.label4.TabIndex = 37;
            this.label4.Text = "Nama Group User :";
            // 
            // dbProjectUasDataSet
            // 
            this.dbProjectUasDataSet.DataSetName = "dbProjectUasDataSet";
            this.dbProjectUasDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // m_hakaksesgroupuserBindingSource
            // 
            this.m_hakaksesgroupuserBindingSource.DataMember = "m_hakaksesgroupuser";
            this.m_hakaksesgroupuserBindingSource.DataSource = this.dbProjectUasDataSet;
            // 
            // m_hakaksesgroupuserTableAdapter
            // 
            this.m_hakaksesgroupuserTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.m_barangTableAdapter = null;
            this.tableAdapterManager.m_groupuserTableAdapter = null;
            this.tableAdapterManager.m_hakaksesgroupuserTableAdapter = this.m_hakaksesgroupuserTableAdapter;
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
            // CBGroupUser
            // 
            this.CBGroupUser.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.m_hakaksesgroupuserBindingSource, "NAMAGROUPUSER", true));
            this.CBGroupUser.FormattingEnabled = true;
            this.CBGroupUser.Location = new System.Drawing.Point(462, 108);
            this.CBGroupUser.Name = "CBGroupUser";
            this.CBGroupUser.Size = new System.Drawing.Size(125, 20);
            this.CBGroupUser.TabIndex = 5;
            // 
            // mgroupuserBindingSource
            // 
            this.mgroupuserBindingSource.DataMember = "m_groupuser";
            this.mgroupuserBindingSource.DataSource = this.dbProjectUasDataSet;
            // 
            // m_groupuserTableAdapter
            // 
            this.m_groupuserTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(128, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(380, 40);
            this.label1.TabIndex = 10;
            this.label1.Text = "MASTER HAK AKSES";
            // 
            // btnSearch
            // 
            this.btnSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearch.Location = new System.Drawing.Point(462, 160);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(125, 25);
            this.btnSearch.TabIndex = 39;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // NmMenuTxt
            // 
            this.NmMenuTxt.Enabled = false;
            this.NmMenuTxt.Location = new System.Drawing.Point(462, 134);
            this.NmMenuTxt.Name = "NmMenuTxt";
            this.NmMenuTxt.Size = new System.Drawing.Size(125, 20);
            this.NmMenuTxt.TabIndex = 38;
            this.NmMenuTxt.TextChanged += new System.EventHandler(this.NmMenuTxt_TextChanged);
            // 
            // btnDelete
            // 
            this.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelete.Enabled = false;
            this.btnDelete.Location = new System.Drawing.Point(481, 288);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(81, 23);
            this.btnDelete.TabIndex = 36;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd.Location = new System.Drawing.Point(382, 288);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(81, 23);
            this.btnAdd.TabIndex = 35;
            this.btnAdd.Text = "Insert";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 115);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(284, 215);
            this.dataGridView1.TabIndex = 31;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentDoubleClick);
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // NmMenuInstxt
            // 
            this.NmMenuInstxt.Location = new System.Drawing.Point(462, 254);
            this.NmMenuInstxt.Name = "NmMenuInstxt";
            this.NmMenuInstxt.Size = new System.Drawing.Size(125, 20);
            this.NmMenuInstxt.TabIndex = 43;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(351, 235);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 12);
            this.label3.TabIndex = 42;
            this.label3.Text = "Nama Group User :";
            // 
            // CBGroupUserIns
            // 
            this.CBGroupUserIns.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.m_hakaksesgroupuserBindingSource, "NAMAGROUPUSER", true));
            this.CBGroupUserIns.FormattingEnabled = true;
            this.CBGroupUserIns.Location = new System.Drawing.Point(462, 228);
            this.CBGroupUserIns.Name = "CBGroupUserIns";
            this.CBGroupUserIns.Size = new System.Drawing.Size(125, 20);
            this.CBGroupUserIns.TabIndex = 41;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(352, 201);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(234, 10);
            this.progressBar1.TabIndex = 44;
            // 
            // rbMenu
            // 
            this.rbMenu.AutoSize = true;
            this.rbMenu.Location = new System.Drawing.Point(331, 139);
            this.rbMenu.Name = "rbMenu";
            this.rbMenu.Size = new System.Drawing.Size(14, 13);
            this.rbMenu.TabIndex = 45;
            this.rbMenu.UseVisualStyleBackColor = true;
            this.rbMenu.MouseClick += new System.Windows.Forms.MouseEventHandler(this.rbMenu_MouseClick);
            // 
            // rbGroupUser
            // 
            this.rbGroupUser.AutoSize = true;
            this.rbGroupUser.Checked = true;
            this.rbGroupUser.Location = new System.Drawing.Point(331, 115);
            this.rbGroupUser.Name = "rbGroupUser";
            this.rbGroupUser.Size = new System.Drawing.Size(14, 13);
            this.rbGroupUser.TabIndex = 46;
            this.rbGroupUser.TabStop = true;
            this.rbGroupUser.UseVisualStyleBackColor = true;
            this.rbGroupUser.MouseClick += new System.Windows.Forms.MouseEventHandler(this.rbGroupUser_MouseClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(331, 115);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(14, 42);
            this.groupBox1.TabIndex = 47;
            this.groupBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Location = new System.Drawing.Point(12, 86);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 48;
            this.button1.Text = "Print";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // MasterHakAkses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(625, 413);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.rbMenu);
            this.Controls.Add(this.rbGroupUser);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.NmMenuInstxt);
            this.Controls.Add(this.label3);
            this.Controls.Add(label5);
            this.Controls.Add(this.CBGroupUserIns);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.NmMenuTxt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Controls.Add(nAMAGROUPUSERLabel);
            this.Controls.Add(this.CBGroupUser);
            this.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "MasterHakAkses";
            this.Text = "MasterHakAkses";
            this.Load += new System.EventHandler(this.MasterHakAkses_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dbProjectUasDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_hakaksesgroupuserBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mgroupuserBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private dbProjectUasDataSet dbProjectUasDataSet;
        private System.Windows.Forms.BindingSource m_hakaksesgroupuserBindingSource;
        private dbProjectUasDataSetTableAdapters.m_hakaksesgroupuserTableAdapter m_hakaksesgroupuserTableAdapter;
        private dbProjectUasDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.ComboBox CBGroupUser;
        private System.Windows.Forms.BindingSource mgroupuserBindingSource;
        private dbProjectUasDataSetTableAdapters.m_groupuserTableAdapter m_groupuserTableAdapter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox NmMenuTxt;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox NmMenuInstxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox CBGroupUserIns;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.RadioButton rbMenu;
        private System.Windows.Forms.RadioButton rbGroupUser;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
    }
}