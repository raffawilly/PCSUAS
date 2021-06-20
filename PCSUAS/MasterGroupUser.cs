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
    public partial class MasterGroupUser : Form
    {
        SqlConnection conn;
        public MasterGroupUser()
        {
            InitializeComponent();
            conn = new SqlConnection(@"Data Source=.\SQLExpress;Initial Catalog=dbProjectUas;Integrated Security=True");
            conn.Open();
            DataSet ds = new DataSet();
            String query = $"SELECT *" +
                           $"FROM m_groupuser";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            dataGridView1.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            conn.Close();
        }

        private bool cekKosong()
        {
            if (tbNamaGroup.Text.Length == 0)
            {
                MessageBox.Show("Isi Data Dengan Benar!");
                return false;
            }
            return true;
        }
        private void clear()
        {
            tbNamaGroup.Text = "";
        }

        private void refreshData()
        {
            conn.Open();
            DataSet ds = new DataSet();
            String query = $"SELECT * " +
                           $"FROM m_groupuser";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            dataGridView1.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            conn.Close();
        }


        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ReportViewerMasterGroupUser report = new ReportViewerMasterGroupUser();
            report.Show();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            pictureBox2.Enabled = true;
            pictureBox1.Enabled = false;
            tbNamaGroup.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
        }

        private void tbCari_TextChanged(object sender, EventArgs e)
        {
            conn.Open();
            DataSet ds = new DataSet();
            String query = $"SELECT *" +
                          $"FROM m_groupuser " +
                          $"WHERE namagroupuser like '%{tbCari.Text}%'";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            dataGridView1.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            conn.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (cekKosong())
            {


                conn = new SqlConnection(@"Data Source=.\SQLExpress;Initial Catalog=dbProjectUas;Integrated Security=True");
                conn.Open();
                String count = $"SELECT ISNULL(COUNT(*), 0) as Jumlah " +
                              $"FROM m_groupuser grp " +
                              $"WHERE namagroupuser = '{tbNamaGroup.Text}'";
                SqlCommand comm = new SqlCommand(count, conn);
                int jmlh = Convert.ToInt32(comm.ExecuteScalar().ToString());
                if (jmlh == 0)
                {
                    String query = $"Insert into m_groupuser  values('{tbNamaGroup.Text}')";
                    comm = new SqlCommand(query, conn);
                    comm.ExecuteNonQuery();
                    conn.Close();
                    this.Validate();

                    refreshData();
                    clear();
                }
                else
                {
                    MessageBox.Show("Nama Group sudah ada di database");
                    conn.Close();
                }
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Apakah anda yakin ingin menghapus data ini?", "Warning!!", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information);

            if (dr == DialogResult.Yes)
            {
                conn.Open();
                String group = tbNamaGroup.Text;
                String query = $"delete from m_groupuser where namagroupuser like '{group}'";
                SqlCommand comm = new SqlCommand(query, conn);
                comm.ExecuteNonQuery();
                MessageBox.Show("Berhasil Menghapus");
                conn.Close();
                clear();
                pictureBox2.Enabled = false;
                pictureBox1.Enabled = true;

                //REFRESH DATA
                refreshData();
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            ReportViewerMasterGroupUser report = new ReportViewerMasterGroupUser();
            report.Show();
        }

        private void MasterGroupUser_Load(object sender, EventArgs e)
        {

        }
    }
}
