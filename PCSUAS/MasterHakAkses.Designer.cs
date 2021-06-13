
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
            System.Windows.Forms.Label nAMAMENULabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MasterHakAkses));
            this.dbProjectUasDataSet = new PCSUAS.dbProjectUasDataSet();
            this.m_hakaksesgroupuserBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.m_hakaksesgroupuserTableAdapter = new PCSUAS.dbProjectUasDataSetTableAdapters.m_hakaksesgroupuserTableAdapter();
            this.tableAdapterManager = new PCSUAS.dbProjectUasDataSetTableAdapters.TableAdapterManager();
            this.m_hakaksesgroupuserBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.nAMAGROUPUSERTextBox = new System.Windows.Forms.TextBox();
            this.nAMAMENUTextBox = new System.Windows.Forms.TextBox();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.m_hakaksesgroupuserBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            nAMAGROUPUSERLabel = new System.Windows.Forms.Label();
            nAMAMENULabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dbProjectUasDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_hakaksesgroupuserBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_hakaksesgroupuserBindingNavigator)).BeginInit();
            this.m_hakaksesgroupuserBindingNavigator.SuspendLayout();
            this.SuspendLayout();
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
            // m_hakaksesgroupuserBindingNavigator
            // 
            this.m_hakaksesgroupuserBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.m_hakaksesgroupuserBindingNavigator.BindingSource = this.m_hakaksesgroupuserBindingSource;
            this.m_hakaksesgroupuserBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.m_hakaksesgroupuserBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.m_hakaksesgroupuserBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.m_hakaksesgroupuserBindingNavigatorSaveItem});
            this.m_hakaksesgroupuserBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.m_hakaksesgroupuserBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.m_hakaksesgroupuserBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.m_hakaksesgroupuserBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.m_hakaksesgroupuserBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.m_hakaksesgroupuserBindingNavigator.Name = "m_hakaksesgroupuserBindingNavigator";
            this.m_hakaksesgroupuserBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.m_hakaksesgroupuserBindingNavigator.Size = new System.Drawing.Size(800, 25);
            this.m_hakaksesgroupuserBindingNavigator.TabIndex = 0;
            this.m_hakaksesgroupuserBindingNavigator.Text = "bindingNavigator1";
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
            nAMAGROUPUSERLabel.Location = new System.Drawing.Point(47, 77);
            nAMAGROUPUSERLabel.Name = "nAMAGROUPUSERLabel";
            nAMAGROUPUSERLabel.Size = new System.Drawing.Size(110, 13);
            nAMAGROUPUSERLabel.TabIndex = 1;
            nAMAGROUPUSERLabel.Text = "NAMAGROUPUSER:";
            // 
            // nAMAGROUPUSERTextBox
            // 
            this.nAMAGROUPUSERTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.m_hakaksesgroupuserBindingSource, "NAMAGROUPUSER", true));
            this.nAMAGROUPUSERTextBox.Location = new System.Drawing.Point(163, 74);
            this.nAMAGROUPUSERTextBox.Name = "nAMAGROUPUSERTextBox";
            this.nAMAGROUPUSERTextBox.Size = new System.Drawing.Size(100, 20);
            this.nAMAGROUPUSERTextBox.TabIndex = 2;
            // 
            // nAMAMENULabel
            // 
            nAMAMENULabel.AutoSize = true;
            nAMAMENULabel.Location = new System.Drawing.Point(47, 103);
            nAMAMENULabel.Name = "nAMAMENULabel";
            nAMAMENULabel.Size = new System.Drawing.Size(73, 13);
            nAMAMENULabel.TabIndex = 3;
            nAMAMENULabel.Text = "NAMAMENU:";
            // 
            // nAMAMENUTextBox
            // 
            this.nAMAMENUTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.m_hakaksesgroupuserBindingSource, "NAMAMENU", true));
            this.nAMAMENUTextBox.Location = new System.Drawing.Point(163, 100);
            this.nAMAMENUTextBox.Name = "nAMAMENUTextBox";
            this.nAMAMENUTextBox.Size = new System.Drawing.Size(100, 20);
            this.nAMAMENUTextBox.TabIndex = 4;
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
            // m_hakaksesgroupuserBindingNavigatorSaveItem
            // 
            this.m_hakaksesgroupuserBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.m_hakaksesgroupuserBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("m_hakaksesgroupuserBindingNavigatorSaveItem.Image")));
            this.m_hakaksesgroupuserBindingNavigatorSaveItem.Name = "m_hakaksesgroupuserBindingNavigatorSaveItem";
            this.m_hakaksesgroupuserBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.m_hakaksesgroupuserBindingNavigatorSaveItem.Text = "Save Data";
            this.m_hakaksesgroupuserBindingNavigatorSaveItem.Click += new System.EventHandler(this.m_hakaksesgroupuserBindingNavigatorSaveItem_Click);
            // 
            // MasterHakAkses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(nAMAGROUPUSERLabel);
            this.Controls.Add(this.nAMAGROUPUSERTextBox);
            this.Controls.Add(nAMAMENULabel);
            this.Controls.Add(this.nAMAMENUTextBox);
            this.Controls.Add(this.m_hakaksesgroupuserBindingNavigator);
            this.Name = "MasterHakAkses";
            this.Text = "MasterHakAkses";
            this.Load += new System.EventHandler(this.MasterHakAkses_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dbProjectUasDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_hakaksesgroupuserBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_hakaksesgroupuserBindingNavigator)).EndInit();
            this.m_hakaksesgroupuserBindingNavigator.ResumeLayout(false);
            this.m_hakaksesgroupuserBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private dbProjectUasDataSet dbProjectUasDataSet;
        private System.Windows.Forms.BindingSource m_hakaksesgroupuserBindingSource;
        private dbProjectUasDataSetTableAdapters.m_hakaksesgroupuserTableAdapter m_hakaksesgroupuserTableAdapter;
        private dbProjectUasDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator m_hakaksesgroupuserBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton m_hakaksesgroupuserBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox nAMAGROUPUSERTextBox;
        private System.Windows.Forms.TextBox nAMAMENUTextBox;
    }
}