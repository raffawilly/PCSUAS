
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
            System.Windows.Forms.Label label4;
            System.Windows.Forms.Label label2;
            this.dbProjectUasDataSet = new PCSUAS.dbProjectUasDataSet();
            this.m_groupuserBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.m_groupuserTableAdapter = new PCSUAS.dbProjectUasDataSetTableAdapters.m_groupuserTableAdapter();
            this.tableAdapterManager = new PCSUAS.dbProjectUasDataSetTableAdapters.TableAdapterManager();
            this.m_hakaksesgroupuserTableAdapter = new PCSUAS.dbProjectUasDataSetTableAdapters.m_hakaksesgroupuserTableAdapter();
            this.m_usersTableAdapter = new PCSUAS.dbProjectUasDataSetTableAdapters.m_usersTableAdapter();
            this.m_hakaksesgroupuserBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.m_usersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.tbCari = new System.Windows.Forms.TextBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.tbNamaGroup = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            label4 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dbProjectUasDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_groupuserBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_hakaksesgroupuserBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_usersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(136, 85);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(101, 12);
            label4.TabIndex = 28;
            label4.Text = "Cari Group User :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(100, 130);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(107, 12);
            label2.TabIndex = 23;
            label2.Text = "Daftar Group User";
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
            // m_hakaksesgroupuserTableAdapter
            // 
            this.m_hakaksesgroupuserTableAdapter.ClearBeforeFill = true;
            // 
            // m_usersTableAdapter
            // 
            this.m_usersTableAdapter.ClearBeforeFill = true;
            // 
            // m_hakaksesgroupuserBindingSource
            // 
            this.m_hakaksesgroupuserBindingSource.DataMember = "FK_HAKAKSESGROUPUSER_GROUPUSERS";
            this.m_hakaksesgroupuserBindingSource.DataSource = this.m_groupuserBindingSource;
            // 
            // m_usersBindingSource
            // 
            this.m_usersBindingSource.DataMember = "FK_USERS_GROUPUSERS";
            this.m_usersBindingSource.DataSource = this.m_groupuserBindingSource;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(65, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(411, 40);
            this.label1.TabIndex = 10;
            this.label1.Text = "MASTER GROUP USER";
            // 
            // btnSearch
            // 
            this.btnSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearch.Location = new System.Drawing.Point(341, 81);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(55, 21);
            this.btnSearch.TabIndex = 30;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // tbCari
            // 
            this.tbCari.Location = new System.Drawing.Point(243, 81);
            this.tbCari.Name = "tbCari";
            this.tbCari.Size = new System.Drawing.Size(92, 20);
            this.tbCari.TabIndex = 29;
            // 
            // btnDelete
            // 
            this.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelete.Enabled = false;
            this.btnDelete.Location = new System.Drawing.Point(395, 171);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(81, 23);
            this.btnDelete.TabIndex = 27;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd.Location = new System.Drawing.Point(296, 171);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(81, 23);
            this.btnAdd.TabIndex = 26;
            this.btnAdd.Text = "Insert";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // tbNamaGroup
            // 
            this.tbNamaGroup.Location = new System.Drawing.Point(376, 145);
            this.tbNamaGroup.Name = "tbNamaGroup";
            this.tbNamaGroup.Size = new System.Drawing.Size(100, 20);
            this.tbNamaGroup.TabIndex = 25;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(252, 148);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 12);
            this.label3.TabIndex = 24;
            this.label3.Text = "Nama Group User:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(40, 145);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(203, 150);
            this.dataGridView1.TabIndex = 22;
            this.dataGridView1.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentDoubleClick);
            // 
            // MasterGroupUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(562, 391);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.tbCari);
            this.Controls.Add(label4);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.tbNamaGroup);
            this.Controls.Add(this.label3);
            this.Controls.Add(label2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "MasterGroupUser";
            this.Text = "MasterGroupUser";
            ((System.ComponentModel.ISupportInitialize)(this.dbProjectUasDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_groupuserBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_hakaksesgroupuserBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_usersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private dbProjectUasDataSet dbProjectUasDataSet;
        private System.Windows.Forms.BindingSource m_groupuserBindingSource;
        private dbProjectUasDataSetTableAdapters.m_groupuserTableAdapter m_groupuserTableAdapter;
        private dbProjectUasDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private dbProjectUasDataSetTableAdapters.m_hakaksesgroupuserTableAdapter m_hakaksesgroupuserTableAdapter;
        private System.Windows.Forms.BindingSource m_hakaksesgroupuserBindingSource;
        private dbProjectUasDataSetTableAdapters.m_usersTableAdapter m_usersTableAdapter;
        private System.Windows.Forms.BindingSource m_usersBindingSource;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox tbCari;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox tbNamaGroup;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}