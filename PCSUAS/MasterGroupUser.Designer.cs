
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MasterGroupUser));
            this.dbProjectUasDataSet = new PCSUAS.dbProjectUasDataSet();
            this.m_groupuserBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.m_groupuserTableAdapter = new PCSUAS.dbProjectUasDataSetTableAdapters.m_groupuserTableAdapter();
            this.tableAdapterManager = new PCSUAS.dbProjectUasDataSetTableAdapters.TableAdapterManager();
            this.m_hakaksesgroupuserTableAdapter = new PCSUAS.dbProjectUasDataSetTableAdapters.m_hakaksesgroupuserTableAdapter();
            this.m_usersTableAdapter = new PCSUAS.dbProjectUasDataSetTableAdapters.m_usersTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.tbCari = new System.Windows.Forms.TextBox();
            this.tbNamaGroup = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.m_hakaksesgroupuserBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.m_usersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dbProjectUasDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_groupuserBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_hakaksesgroupuserBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_usersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(40, 123);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(51, 12);
            label4.TabIndex = 28;
            label4.Text = "Search :";
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
            // tbCari
            // 
            this.tbCari.Location = new System.Drawing.Point(97, 119);
            this.tbCari.Name = "tbCari";
            this.tbCari.Size = new System.Drawing.Size(92, 20);
            this.tbCari.TabIndex = 29;
            this.tbCari.TextChanged += new System.EventHandler(this.tbCari_TextChanged);
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
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(40, 145);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(203, 150);
            this.dataGridView1.TabIndex = 22;
            this.dataGridView1.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentDoubleClick);
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
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
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(311, 171);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(74, 36);
            this.pictureBox1.TabIndex = 32;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(391, 171);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(85, 36);
            this.pictureBox2.TabIndex = 33;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(43, 78);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(39, 34);
            this.pictureBox3.TabIndex = 34;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // MasterGroupUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(562, 391);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.tbCari);
            this.Controls.Add(label4);
            this.Controls.Add(this.tbNamaGroup);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "MasterGroupUser";
            this.Text = "MasterGroupUser";
            ((System.ComponentModel.ISupportInitialize)(this.dbProjectUasDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_groupuserBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_hakaksesgroupuserBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_usersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
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
        private System.Windows.Forms.TextBox tbCari;
        private System.Windows.Forms.TextBox tbNamaGroup;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}