
namespace PCSUAS
{
    partial class MasterModel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MasterModel));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tbModelID = new System.Windows.Forms.TextBox();
            this.tbModelDesc = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbDescCari = new System.Windows.Forms.TextBox();
            this.tbModelIDCari = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dbProjectUasDataSet1 = new PCSUAS.dbProjectUasDataSet();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbDesc = new System.Windows.Forms.RadioButton();
            this.rbModel = new System.Windows.Forms.RadioButton();
            this.pictSearch = new System.Windows.Forms.PictureBox();
            this.pictInsert = new System.Windows.Forms.PictureBox();
            this.pictUpdate = new System.Windows.Forms.PictureBox();
            this.pictDelete = new System.Windows.Forms.PictureBox();
            this.pictPrint = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbProjectUasDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictSearch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictInsert)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictUpdate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictDelete)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictPrint)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(14, 103);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(420, 277);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // tbModelID
            // 
            this.tbModelID.Enabled = false;
            this.tbModelID.Location = new System.Drawing.Point(528, 250);
            this.tbModelID.Name = "tbModelID";
            this.tbModelID.Size = new System.Drawing.Size(144, 20);
            this.tbModelID.TabIndex = 1;
            // 
            // tbModelDesc
            // 
            this.tbModelDesc.Location = new System.Drawing.Point(528, 275);
            this.tbModelDesc.Name = "tbModelDesc";
            this.tbModelDesc.Size = new System.Drawing.Size(144, 20);
            this.tbModelDesc.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(464, 253);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 12);
            this.label1.TabIndex = 3;
            this.label1.Text = "Model ID :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(480, 278);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 12);
            this.label2.TabIndex = 4;
            this.label2.Text = "Desc. :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(233, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(204, 33);
            this.label3.TabIndex = 5;
            this.label3.Text = "Master Model";
            // 
            // progressBar1
            // 
            this.progressBar1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.progressBar1.Enabled = false;
            this.progressBar1.ForeColor = System.Drawing.Color.Honeydew;
            this.progressBar1.Location = new System.Drawing.Point(446, 223);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(226, 10);
            this.progressBar1.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(480, 157);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 12);
            this.label4.TabIndex = 14;
            this.label4.Text = "Desc. :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(464, 132);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 12);
            this.label5.TabIndex = 13;
            this.label5.Text = "Model ID :";
            // 
            // tbDescCari
            // 
            this.tbDescCari.Enabled = false;
            this.tbDescCari.Location = new System.Drawing.Point(528, 154);
            this.tbDescCari.Name = "tbDescCari";
            this.tbDescCari.Size = new System.Drawing.Size(144, 20);
            this.tbDescCari.TabIndex = 12;
            // 
            // tbModelIDCari
            // 
            this.tbModelIDCari.Location = new System.Drawing.Point(528, 129);
            this.tbModelIDCari.Name = "tbModelIDCari";
            this.tbModelIDCari.Size = new System.Drawing.Size(144, 20);
            this.tbModelIDCari.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(525, 103);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 18);
            this.label6.TabIndex = 16;
            this.label6.Text = "Cari Model";
            // 
            // dbProjectUasDataSet1
            // 
            this.dbProjectUasDataSet1.DataSetName = "dbProjectUasDataSet";
            this.dbProjectUasDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(444, 132);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(14, 42);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            // 
            // rbDesc
            // 
            this.rbDesc.AutoSize = true;
            this.rbDesc.Location = new System.Drawing.Point(444, 156);
            this.rbDesc.Name = "rbDesc";
            this.rbDesc.Size = new System.Drawing.Size(14, 13);
            this.rbDesc.TabIndex = 0;
            this.rbDesc.UseVisualStyleBackColor = true;
            this.rbDesc.CheckedChanged += new System.EventHandler(this.rbDesc_CheckedChanged);
            this.rbDesc.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Description_MouseClick);
            // 
            // rbModel
            // 
            this.rbModel.AutoSize = true;
            this.rbModel.Checked = true;
            this.rbModel.Location = new System.Drawing.Point(444, 132);
            this.rbModel.Name = "rbModel";
            this.rbModel.Size = new System.Drawing.Size(14, 13);
            this.rbModel.TabIndex = 1;
            this.rbModel.TabStop = true;
            this.rbModel.UseVisualStyleBackColor = true;
            this.rbModel.CheckedChanged += new System.EventHandler(this.rbModel_CheckedChanged);
            this.rbModel.MouseClick += new System.Windows.Forms.MouseEventHandler(this.rbModel_MouseClick);
            // 
            // pictSearch
            // 
            this.pictSearch.Image = ((System.Drawing.Image)(resources.GetObject("pictSearch.Image")));
            this.pictSearch.Location = new System.Drawing.Point(600, 182);
            this.pictSearch.Name = "pictSearch";
            this.pictSearch.Size = new System.Drawing.Size(72, 25);
            this.pictSearch.TabIndex = 19;
            this.pictSearch.TabStop = false;
            this.pictSearch.Click += new System.EventHandler(this.pictSearch_Click);
            // 
            // pictInsert
            // 
            this.pictInsert.Image = ((System.Drawing.Image)(resources.GetObject("pictInsert.Image")));
            this.pictInsert.Location = new System.Drawing.Point(509, 301);
            this.pictInsert.Name = "pictInsert";
            this.pictInsert.Size = new System.Drawing.Size(77, 26);
            this.pictInsert.TabIndex = 20;
            this.pictInsert.TabStop = false;
            this.pictInsert.Click += new System.EventHandler(this.pictInsert_Click);
            // 
            // pictUpdate
            // 
            this.pictUpdate.Image = ((System.Drawing.Image)(resources.GetObject("pictUpdate.Image")));
            this.pictUpdate.Location = new System.Drawing.Point(588, 301);
            this.pictUpdate.Name = "pictUpdate";
            this.pictUpdate.Size = new System.Drawing.Size(87, 26);
            this.pictUpdate.TabIndex = 21;
            this.pictUpdate.TabStop = false;
            this.pictUpdate.Click += new System.EventHandler(this.pictUpdate_Click);
            // 
            // pictDelete
            // 
            this.pictDelete.Image = ((System.Drawing.Image)(resources.GetObject("pictDelete.Image")));
            this.pictDelete.Location = new System.Drawing.Point(592, 333);
            this.pictDelete.Name = "pictDelete";
            this.pictDelete.Size = new System.Drawing.Size(80, 28);
            this.pictDelete.TabIndex = 22;
            this.pictDelete.TabStop = false;
            this.pictDelete.Click += new System.EventHandler(this.pictDelete_Click);
            // 
            // pictPrint
            // 
            this.pictPrint.Image = ((System.Drawing.Image)(resources.GetObject("pictPrint.Image")));
            this.pictPrint.Location = new System.Drawing.Point(14, 62);
            this.pictPrint.Name = "pictPrint";
            this.pictPrint.Size = new System.Drawing.Size(39, 35);
            this.pictPrint.TabIndex = 23;
            this.pictPrint.TabStop = false;
            this.pictPrint.Click += new System.EventHandler(this.pictPrint_Click);
            // 
            // MasterModel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(684, 388);
            this.Controls.Add(this.pictPrint);
            this.Controls.Add(this.pictDelete);
            this.Controls.Add(this.pictUpdate);
            this.Controls.Add(this.pictInsert);
            this.Controls.Add(this.pictSearch);
            this.Controls.Add(this.rbDesc);
            this.Controls.Add(this.rbModel);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbDescCari);
            this.Controls.Add(this.tbModelIDCari);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbModelDesc);
            this.Controls.Add(this.tbModelID);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "MasterModel";
            this.Text = "MasterModel";
            this.Load += new System.EventHandler(this.MasterModel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbProjectUasDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictSearch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictInsert)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictUpdate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictDelete)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictPrint)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox tbModelID;
        private System.Windows.Forms.TextBox tbModelDesc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbDescCari;
        private System.Windows.Forms.TextBox tbModelIDCari;
        private System.Windows.Forms.Label label6;
        private dbProjectUasDataSet dbProjectUasDataSet1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbModel;
        private System.Windows.Forms.RadioButton rbDesc;
        private System.Windows.Forms.PictureBox pictSearch;
        private System.Windows.Forms.PictureBox pictInsert;
        private System.Windows.Forms.PictureBox pictUpdate;
        private System.Windows.Forms.PictureBox pictDelete;
        private System.Windows.Forms.PictureBox pictPrint;
    }
}