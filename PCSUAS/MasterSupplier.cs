﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PCSUAS
{
    public partial class MasterSupplier : Form
    {
        public MasterSupplier()
        {
            InitializeComponent();
        }

        private void m_supplierBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.m_supplierBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.dbProjectUasDataSet);
            }
            catch (ConstraintException)
            {
                MessageBox.Show("Supplier ID has been used ");
            }
            catch (DBConcurrencyException)
            {
                MessageBox.Show("You Can't change the data for a while");
            }
            catch (NoNullAllowedException ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
                this.m_supplierBindingSource.CancelEdit();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Sql Server Error " + ex);
            }

        }

        private void MasterSupplier_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dbProjectUasDataSet.m_kota' table. You can move, or remove it, as needed.
            this.m_kotaTableAdapter.Fill(this.dbProjectUasDataSet.m_kota);
            // TODO: This line of code loads data into the 'dbProjectUasDataSet.m_supplier' table. You can move, or remove it, as needed.
            this.m_supplierTableAdapter.Fill(this.dbProjectUasDataSet.m_supplier);

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void p_IDLabel_Click(object sender, EventArgs e)
        {

        }

        private void bindingNavigatorMoveNextItem_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.m_supplierBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.dbProjectUasDataSet);
            }
            catch (ConstraintException)
            {
                MessageBox.Show("Supplier ID has been used ");
            }
            catch (DBConcurrencyException)
            {
                MessageBox.Show("You Can't change the data for a while");
            }
            catch (NoNullAllowedException ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
                this.m_supplierBindingSource.CancelEdit();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Sql Server Error " + ex);
            }
        }

        private void bindingNavigatorMoveLastItem_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.m_supplierBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.dbProjectUasDataSet);
            }
            catch (ConstraintException)
            {
                MessageBox.Show("Supplier ID has been used ");
            }
            catch (DBConcurrencyException)
            {
                MessageBox.Show("You Can't change the data for a while");
            }
            catch (NoNullAllowedException ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
                this.m_supplierBindingSource.CancelEdit();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Sql Server Error " + ex);
            }
        }

        private void bindingNavigatorMovePreviousItem_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.m_supplierBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.dbProjectUasDataSet);
            }
            catch (ConstraintException)
            {
                MessageBox.Show("Supplier ID has been used ");
            }
            catch (DBConcurrencyException)
            {
                MessageBox.Show("You Can't change the data for a while");
            }
            catch (NoNullAllowedException ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
                this.m_supplierBindingSource.CancelEdit();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Sql Server Error " + ex);
            }
        }

        private void bindingNavigatorMoveFirstItem_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.m_supplierBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.dbProjectUasDataSet);
            }
            catch (ConstraintException)
            {
                MessageBox.Show("Supplier ID has been used ");
            }
            catch (DBConcurrencyException)
            {
                MessageBox.Show("You Can't change the data for a while");
            }
            catch (NoNullAllowedException ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
                this.m_supplierBindingSource.CancelEdit();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Sql Server Error " + ex);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ReportViewerMasterSupplier report = new ReportViewerMasterSupplier();
            report.Show();
        }
    }
}
