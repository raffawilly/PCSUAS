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
    public partial class MasterModel : Form
    {
        SqlConnection conn;
        public MasterModel()
        {
            InitializeComponent();
            try
            {
                conn = new SqlConnection(@"Data Source=.\SQLExpress;Initial Catalog=dbProjectUas;Integrated Security=True");
                conn.Open();
                DataSet ds = new DataSet();
                String query = $"SELECT MODEL_ID, DESCRIPTION " +
                               $"FROM m_model";
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];
                dataGridView1.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;


                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error {ex.Message}");
                throw;
            }
        }

        private void MasterModel_Load(object sender, EventArgs e)
        {

        }

        private void tbModelDesc_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbModelID_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            conn.Open();
            
            String desc = tbModelDesc.Text;

            String count = $"SELECT ISNULL(COUNT(*), 0) as Jumlah " +
                          $"FROM m_model mdl " +
                          $"WHERE DESCRIPTION = '{desc}'";
            SqlCommand comm = new SqlCommand(count, conn);
            int jmlh = Convert.ToInt32(comm.ExecuteScalar().ToString());
            conn.Close();
            if (jmlh == 0)
            {
                conn.Open();
                String query = $"Insert into m_model (DESCRIPTION) values('{desc}')";
                comm = new SqlCommand(query, conn);
                comm.ExecuteNonQuery();
                conn.Close();


                //CLEAR TEXTBO
                tbModelDesc.Text = "";

                //refresh datagridview
                conn.Open();
                DataSet ds = new DataSet();
                String query2 = $"SELECT MODEL_ID, DESCRIPTION " +
                               $"FROM m_model";
                SqlCommand cmd = new SqlCommand(query2, conn);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];
                dataGridView1.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                conn.Close();
            }
            else
            {
                MessageBox.Show("ID Model atau Description sudah ada di database");
            }
            
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            btnInsert.Enabled = false;
            btnUpdate.Enabled = true;
            btnDelete.Enabled = true;

            tbModelID.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            tbModelDesc.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            conn.Open();

            String desc = tbModelDesc.Text;

            String count = $"SELECT ISNULL(COUNT(*), 0) as Jumlah " +
                          $"FROM m_model mdl " +
                          $"WHERE DESCRIPTION = '{desc}'";
            SqlCommand comm = new SqlCommand(count, conn);
            int jmlh = Convert.ToInt32(comm.ExecuteScalar().ToString());
            conn.Close();
            if (jmlh == 0)
            {
                conn.Open();


                String query = $"update m_model set DESCRIPTION = '{desc}' where MODEL_ID= {tbModelID.Text}";
                SqlCommand comm2 = new SqlCommand(query, conn);
                comm2.ExecuteNonQuery();
                MessageBox.Show("Berhasil Update!");
                conn.Close();

                tbModelID.Text = "";
                tbModelDesc.Text = "";
                btnInsert.Enabled = true;
                btnUpdate.Enabled = false;
                btnDelete.Enabled = false;

                conn.Open();
                DataSet ds = new DataSet();
                String query2 = $"SELECT MODEL_ID, DESCRIPTION " +
                               $"FROM m_model";
                SqlCommand cmd = new SqlCommand(query2, conn);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];
                dataGridView1.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                conn.Close();
            }
            else
            {
                MessageBox.Show("ID Model atau Description sudah ada di database");
            }
           
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            conn.Open();
            int id = Convert.ToInt32(tbModelID.Text);
            String query = $"delete from m_model where MODEL_ID like {id}";
            SqlCommand comm = new SqlCommand(query, conn);
            comm.ExecuteNonQuery();
            MessageBox.Show("Berhasil Menghapus");
            conn.Close();

            tbModelID.Text = "";
            tbModelDesc.Text = "";
            btnInsert.Enabled = true;
            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;

            conn.Open();
            DataSet ds = new DataSet();
            String query2 = $"SELECT MODEL_ID, DESCRIPTION " +
                           $"FROM m_model";
            SqlCommand cmd = new SqlCommand(query2, conn);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            dataGridView1.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            conn.Close();
        }
    }
}
