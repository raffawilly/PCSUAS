
namespace PCSUAS
{
    partial class MasterKota
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MasterKota));
            this.dbProjectUasDataSet = new PCSUAS.dbProjectUasDataSet();
            this.m_kotaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.m_kotaTableAdapter = new PCSUAS.dbProjectUasDataSetTableAdapters.m_kotaTableAdapter();
            this.tableAdapterManager = new PCSUAS.dbProjectUasDataSetTableAdapters.TableAdapterManager();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.tbNamaKota = new System.Windows.Forms.TextBox();
            this.tbCari = new System.Windows.Forms.TextBox();
            this.pictInsert = new System.Windows.Forms.PictureBox();
            this.pictDelete = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dbProjectUasDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_kotaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictInsert)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictDelete)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(10, 119);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(63, 12);
            label4.TabIndex = 18;
            label4.Text = "Cari Kota :";
            // 
            // dbProjectUasDataSet
            // 
            this.dbProjectUasDataSet.DataSetName = "dbProjectUasDataSet";
            this.dbProjectUasDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // m_kotaBindingSource
            // 
            this.m_kotaBindingSource.DataMember = "m_kota";
            this.m_kotaBindingSource.DataSource = this.dbProjectUasDataSet;
            // 
            // m_kotaTableAdapter
            // 
            this.m_kotaTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.m_barangTableAdapter = null;
            this.tableAdapterManager.m_groupuserTableAdapter = null;
            this.tableAdapterManager.m_hakaksesgroupuserTableAdapter = null;
            this.tableAdapterManager.m_kotaTableAdapter = this.m_kotaTableAdapter;
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(59, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(274, 40);
            this.label1.TabIndex = 10;
            this.label1.Text = "MASTER KOTA";
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 142);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(143, 150);
            this.dataGridView1.TabIndex = 11;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(170, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 12);
            this.label3.TabIndex = 13;
            this.label3.Text = "Nama Kota :";
            // 
            // tbNamaKota
            // 
            this.tbNamaKota.Location = new System.Drawing.Point(248, 142);
            this.tbNamaKota.Name = "tbNamaKota";
            this.tbNamaKota.Size = new System.Drawing.Size(100, 20);
            this.tbNamaKota.TabIndex = 14;
            // 
            // tbCari
            // 
            this.tbCari.Location = new System.Drawing.Point(79, 116);
            this.tbCari.Name = "tbCari";
            this.tbCari.Size = new System.Drawing.Size(76, 20);
            this.tbCari.TabIndex = 19;
            this.tbCari.TextChanged += new System.EventHandler(this.tbCari_TextChanged);
            // 
            // pictInsert
            // 
            this.pictInsert.Image = ((System.Drawing.Image)(resources.GetObject("pictInsert.Image")));
            this.pictInsert.Location = new System.Drawing.Point(187, 168);
            this.pictInsert.Name = "pictInsert";
            this.pictInsert.Size = new System.Drawing.Size(79, 27);
            this.pictInsert.TabIndex = 50;
            this.pictInsert.TabStop = false;
            this.pictInsert.Click += new System.EventHandler(this.pictInsert_Click);
            // 
            // pictDelete
            // 
            this.pictDelete.Image = ((System.Drawing.Image)(resources.GetObject("pictDelete.Image")));
            this.pictDelete.Location = new System.Drawing.Point(269, 168);
            this.pictDelete.Name = "pictDelete";
            this.pictDelete.Size = new System.Drawing.Size(81, 27);
            this.pictDelete.TabIndex = 51;
            this.pictDelete.TabStop = false;
            this.pictDelete.Click += new System.EventHandler(this.pictDelete_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 68);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(42, 37);
            this.pictureBox1.TabIndex = 52;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // MasterKota
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(406, 304);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictDelete);
            this.Controls.Add(this.pictInsert);
            this.Controls.Add(this.tbCari);
            this.Controls.Add(label4);
            this.Controls.Add(this.tbNamaKota);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "MasterKota";
            this.Text = "MasterKota";
            this.Load += new System.EventHandler(this.MasterKota_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dbProjectUasDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_kotaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictInsert)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictDelete)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private dbProjectUasDataSet dbProjectUasDataSet;
        private System.Windows.Forms.BindingSource m_kotaBindingSource;
        private dbProjectUasDataSetTableAdapters.m_kotaTableAdapter m_kotaTableAdapter;
        private dbProjectUasDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbNamaKota;
        private System.Windows.Forms.TextBox tbCari;
        private System.Windows.Forms.PictureBox pictInsert;
        private System.Windows.Forms.PictureBox pictDelete;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}