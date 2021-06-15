
namespace PCSUAS
{
    partial class Home
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
            this.dbProjectUasDataSet = new PCSUAS.dbProjectUasDataSet();
            this.btnMasterBarang = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.btnMasterPelanggan = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dbProjectUasDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dbProjectUasDataSet
            // 
            this.dbProjectUasDataSet.DataSetName = "dbProjectUasDataSet";
            this.dbProjectUasDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnMasterBarang
            // 
            this.btnMasterBarang.BackColor = System.Drawing.SystemColors.HighlightText;
            this.btnMasterBarang.Location = new System.Drawing.Point(252, 98);
            this.btnMasterBarang.Name = "btnMasterBarang";
            this.btnMasterBarang.Size = new System.Drawing.Size(131, 34);
            this.btnMasterBarang.TabIndex = 0;
            this.btnMasterBarang.Text = "Master Barang";
            this.btnMasterBarang.UseVisualStyleBackColor = false;
            this.btnMasterBarang.Click += new System.EventHandler(this.btnMasterBarang_Click);
            this.btnMasterBarang.MouseLeave += new System.EventHandler(this.btnMasterBarang_MouseLeave);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.HighlightText;
            this.button2.Location = new System.Drawing.Point(252, 138);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(131, 35);
            this.button2.TabIndex = 1;
            this.button2.Text = "Master Users";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.HighlightText;
            this.button3.Location = new System.Drawing.Point(389, 98);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(131, 34);
            this.button3.TabIndex = 2;
            this.button3.Text = "Master Supplier";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnMasterPelanggan
            // 
            this.btnMasterPelanggan.BackColor = System.Drawing.SystemColors.HighlightText;
            this.btnMasterPelanggan.Location = new System.Drawing.Point(389, 138);
            this.btnMasterPelanggan.Name = "btnMasterPelanggan";
            this.btnMasterPelanggan.Size = new System.Drawing.Size(131, 35);
            this.btnMasterPelanggan.TabIndex = 3;
            this.btnMasterPelanggan.Text = "Master Pelanggan";
            this.btnMasterPelanggan.UseVisualStyleBackColor = false;
            this.btnMasterPelanggan.Click += new System.EventHandler(this.btnMasterPelanggan_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.SystemColors.HighlightText;
            this.button5.Location = new System.Drawing.Point(389, 179);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(131, 31);
            this.button5.TabIndex = 4;
            this.button5.Text = "Master Hak Akses";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.SystemColors.HighlightText;
            this.button6.Location = new System.Drawing.Point(252, 179);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(131, 31);
            this.button6.TabIndex = 5;
            this.button6.Text = "Master Group User";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.SystemColors.HighlightText;
            this.button7.Location = new System.Drawing.Point(389, 216);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(131, 29);
            this.button7.TabIndex = 6;
            this.button7.Text = "Master Model";
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.SystemColors.HighlightText;
            this.button8.Location = new System.Drawing.Point(252, 216);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(131, 29);
            this.button8.TabIndex = 7;
            this.button8.Text = "Master Merk";
            this.button8.UseVisualStyleBackColor = false;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.SystemColors.HighlightText;
            this.button9.Location = new System.Drawing.Point(325, 251);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(131, 32);
            this.button9.TabIndex = 8;
            this.button9.Text = "Master Kota";
            this.button9.UseVisualStyleBackColor = false;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(271, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(239, 40);
            this.label1.TabIndex = 9;
            this.label1.Text = "HOME MENU";
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(806, 415);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.btnMasterPelanggan);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnMasterBarang);
            this.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Home";
            this.Text = " ";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MouseHover += new System.EventHandler(this.Home_MouseHover);
            ((System.ComponentModel.ISupportInitialize)(this.dbProjectUasDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private dbProjectUasDataSet dbProjectUasDataSet;
        private System.Windows.Forms.Button btnMasterBarang;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btnMasterPelanggan;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Label label1;
    }
}

