
namespace PCSUAS
{
    partial class MasterUsers
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MasterUsers));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbUsername = new System.Windows.Forms.TextBox();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.cbGroupUser = new System.Windows.Forms.ComboBox();
            this.rbNamaGroup = new System.Windows.Forms.RadioButton();
            this.rbUsername = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tbUsernameCari = new System.Windows.Forms.TextBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.cbGroupCari = new System.Windows.Forms.ComboBox();
            this.pictSearch = new System.Windows.Forms.PictureBox();
            this.pictInsert = new System.Windows.Forms.PictureBox();
            this.pictUpdate = new System.Windows.Forms.PictureBox();
            this.pictDelete = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictSearch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictInsert)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictUpdate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictDelete)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(14, 74);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(525, 283);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(390, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(225, 33);
            this.label3.TabIndex = 6;
            this.label3.Text = "MASTER USER";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(606, 209);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 12);
            this.label1.TabIndex = 7;
            this.label1.Text = "Username :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(608, 244);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 8;
            this.label2.Text = "Password :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(563, 274);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 12);
            this.label4.TabIndex = 9;
            this.label4.Text = "Nama Group User :";
            // 
            // tbUsername
            // 
            this.tbUsername.Location = new System.Drawing.Point(704, 209);
            this.tbUsername.Name = "tbUsername";
            this.tbUsername.Size = new System.Drawing.Size(146, 20);
            this.tbUsername.TabIndex = 10;
            // 
            // tbPassword
            // 
            this.tbPassword.Location = new System.Drawing.Point(704, 241);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.Size = new System.Drawing.Size(146, 20);
            this.tbPassword.TabIndex = 11;
            // 
            // cbGroupUser
            // 
            this.cbGroupUser.FormattingEnabled = true;
            this.cbGroupUser.Location = new System.Drawing.Point(704, 271);
            this.cbGroupUser.Name = "cbGroupUser";
            this.cbGroupUser.Size = new System.Drawing.Size(146, 20);
            this.cbGroupUser.TabIndex = 12;
            // 
            // rbNamaGroup
            // 
            this.rbNamaGroup.AutoSize = true;
            this.rbNamaGroup.Location = new System.Drawing.Point(566, 133);
            this.rbNamaGroup.Name = "rbNamaGroup";
            this.rbNamaGroup.Size = new System.Drawing.Size(14, 13);
            this.rbNamaGroup.TabIndex = 18;
            this.rbNamaGroup.UseVisualStyleBackColor = true;
            this.rbNamaGroup.CheckedChanged += new System.EventHandler(this.rbDesc_CheckedChanged);
            // 
            // rbUsername
            // 
            this.rbUsername.AutoSize = true;
            this.rbUsername.Checked = true;
            this.rbUsername.Location = new System.Drawing.Point(565, 110);
            this.rbUsername.Name = "rbUsername";
            this.rbUsername.Size = new System.Drawing.Size(14, 13);
            this.rbUsername.TabIndex = 19;
            this.rbUsername.TabStop = true;
            this.rbUsername.UseVisualStyleBackColor = true;
            this.rbUsername.CheckedChanged += new System.EventHandler(this.rbModel_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(565, 106);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(14, 42);
            this.groupBox1.TabIndex = 26;
            this.groupBox1.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(678, 74);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 18);
            this.label6.TabIndex = 25;
            this.label6.Text = "Cari User";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(585, 133);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(110, 12);
            this.label5.TabIndex = 23;
            this.label5.Text = "Nama Group User :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(627, 111);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 12);
            this.label7.TabIndex = 22;
            this.label7.Text = "Username : ";
            // 
            // tbUsernameCari
            // 
            this.tbUsernameCari.Location = new System.Drawing.Point(704, 108);
            this.tbUsernameCari.Name = "tbUsernameCari";
            this.tbUsernameCari.Size = new System.Drawing.Size(144, 20);
            this.tbUsernameCari.TabIndex = 20;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(566, 187);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(282, 10);
            this.progressBar1.TabIndex = 27;
            // 
            // cbGroupCari
            // 
            this.cbGroupCari.Enabled = false;
            this.cbGroupCari.FormattingEnabled = true;
            this.cbGroupCari.Location = new System.Drawing.Point(703, 130);
            this.cbGroupCari.Name = "cbGroupCari";
            this.cbGroupCari.Size = new System.Drawing.Size(146, 20);
            this.cbGroupCari.TabIndex = 28;
            // 
            // pictSearch
            // 
            this.pictSearch.Image = ((System.Drawing.Image)(resources.GetObject("pictSearch.Image")));
            this.pictSearch.Location = new System.Drawing.Point(778, 155);
            this.pictSearch.Name = "pictSearch";
            this.pictSearch.Size = new System.Drawing.Size(70, 24);
            this.pictSearch.TabIndex = 29;
            this.pictSearch.TabStop = false;
            this.pictSearch.Click += new System.EventHandler(this.pictSearch_Click);
            // 
            // pictInsert
            // 
            this.pictInsert.Image = ((System.Drawing.Image)(resources.GetObject("pictInsert.Image")));
            this.pictInsert.Location = new System.Drawing.Point(684, 297);
            this.pictInsert.Name = "pictInsert";
            this.pictInsert.Size = new System.Drawing.Size(77, 26);
            this.pictInsert.TabIndex = 30;
            this.pictInsert.TabStop = false;
            this.pictInsert.Click += new System.EventHandler(this.pictInsert_Click);
            // 
            // pictUpdate
            // 
            this.pictUpdate.Image = ((System.Drawing.Image)(resources.GetObject("pictUpdate.Image")));
            this.pictUpdate.Location = new System.Drawing.Point(766, 297);
            this.pictUpdate.Name = "pictUpdate";
            this.pictUpdate.Size = new System.Drawing.Size(84, 26);
            this.pictUpdate.TabIndex = 31;
            this.pictUpdate.TabStop = false;
            this.pictUpdate.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictDelete
            // 
            this.pictDelete.Image = ((System.Drawing.Image)(resources.GetObject("pictDelete.Image")));
            this.pictDelete.Location = new System.Drawing.Point(770, 325);
            this.pictDelete.Name = "pictDelete";
            this.pictDelete.Size = new System.Drawing.Size(81, 27);
            this.pictDelete.TabIndex = 32;
            this.pictDelete.TabStop = false;
            this.pictDelete.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // MasterUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(933, 369);
            this.Controls.Add(this.pictDelete);
            this.Controls.Add(this.pictUpdate);
            this.Controls.Add(this.pictInsert);
            this.Controls.Add(this.pictSearch);
            this.Controls.Add(this.cbGroupCari);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.rbNamaGroup);
            this.Controls.Add(this.rbUsername);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tbUsernameCari);
            this.Controls.Add(this.cbGroupUser);
            this.Controls.Add(this.tbPassword);
            this.Controls.Add(this.tbUsername);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dataGridView1);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "MasterUsers";
            this.Text = "MasterUsers";
            this.Load += new System.EventHandler(this.MasterUsers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictSearch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictInsert)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictUpdate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictDelete)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbUsername;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.ComboBox cbGroupUser;
        private System.Windows.Forms.RadioButton rbNamaGroup;
        private System.Windows.Forms.RadioButton rbUsername;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbUsernameCari;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.ComboBox cbGroupCari;
        private System.Windows.Forms.PictureBox pictSearch;
        private System.Windows.Forms.PictureBox pictInsert;
        private System.Windows.Forms.PictureBox pictUpdate;
        private System.Windows.Forms.PictureBox pictDelete;
    }
}