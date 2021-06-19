using System;
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
    public partial class MasterUsers : Form
    {
        SqlConnection conn;
        public MasterUsers()
        {
            InitializeComponent();
            try
            {
                conn = new SqlConnection(@"Data Source=.\SQLExpress;Initial Catalog=dbProjectUas;Integrated Security=True");
                conn.Open();
                DataSet ds = new DataSet();
                String query = $"SELECT USERNAME, PASSWORD,NAMAGROUPUSER " +
                               $"FROM m_users";
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];
                dataGridView1.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
               

                DataSet role = new DataSet();
                String dataRole = $"SELECT * " +
                              $"FROM m_groupuser";
                SqlCommand cmdRole = new SqlCommand(dataRole, conn);
                SqlDataAdapter adapterRole = new SqlDataAdapter(cmdRole);
                adapterRole.Fill(role);
                cbGroupUser.DataSource = role.Tables[0];
                cbGroupUser.DisplayMember = "namagroupuser";
                cbGroupUser.ValueMember = "namagroupuser";

                cbGroupCari.DataSource = role.Tables[0];
                cbGroupCari.DisplayMember = "namagroupuser";
                cbGroupCari.ValueMember = "namagroupuser";
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error {ex.Message}");
                throw;
            }
        }

        private bool cekKosong()
        {
            if (tbUsername.Text.Length == 0|| tbPassword.Text.Length==0)
            {
                MessageBox.Show("Isi Data Dengan Benar!");
                return false;
            }
            return true;
        }
        private void clear()
        {
            tbUsername.Text = "";
            tbPassword.Text = "";
        }
        private void refreshData()
        {
            conn.Open();
            DataSet ds = new DataSet();
            String query = $"SELECT USERNAME, PASSWORD,NAMAGROUPUSER " +
                           $"FROM m_users";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            dataGridView1.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            conn.Close();
        }
        private void MasterUsers_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            pictInsert.Enabled = false;
            pictUpdate.Enabled = true;
            pictDelete.Enabled = true;
            tbUsername.Enabled = false;
            tbUsername.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            tbPassword.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            cbGroupUser.SelectedValue= dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void rbDesc_CheckedChanged(object sender, EventArgs e)
        {
            tbUsernameCari.Enabled = false;
            cbGroupCari.Enabled = true;
            tbUsernameCari.Text = "";
            refreshData();
        }

        private void rbModel_CheckedChanged(object sender, EventArgs e)
        {
            tbUsernameCari.Enabled = true;
            cbGroupCari.Enabled = false;
            refreshData();
        }

        private void pictInsert_Click(object sender, EventArgs e)
        {
            if (cekKosong())
            {
                conn.Open();
                String username = tbUsername.Text;
                String password = tbPassword.Text;
                String namagroup = cbGroupUser.SelectedValue.ToString();

                String count = $"SELECT ISNULL(COUNT(*), 0) as Jumlah " +
                              $"FROM m_users " +
                              $"WHERE username = '{username}' ";
                SqlCommand comm = new SqlCommand(count, conn);
                int jmlh = Convert.ToInt32(comm.ExecuteScalar().ToString());
                conn.Close();
                if (jmlh == 0)
                {
                    conn.Open();
                    String query = $"Insert into m_users  values('{username}','{password}','{namagroup}')";
                    comm = new SqlCommand(query, conn);
                    comm.ExecuteNonQuery();
                    conn.Close();
                    //CLEAR TEXTBO
                    clear();
                    //REFRESH DATA
                    refreshData();
                }
                else
                {
                    MessageBox.Show("Username sudah ada di database");
                }
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (cekKosong())
            {
                conn.Open();
                String username = tbUsername.Text;
                String password = tbPassword.Text;
                String namagroup = cbGroupUser.SelectedValue.ToString();
                conn.Close();
                conn.Open();
                String query = $"update m_users set username = '{username}',password = '{password} ',namagroupuser='{namagroup}' where username= '{username}'";
                SqlCommand comm2 = new SqlCommand(query, conn);
                comm2.ExecuteNonQuery();
                MessageBox.Show("Berhasil Update!");
                conn.Close();
                clear();
                pictInsert.Enabled = true;
                pictUpdate.Enabled = false;
                pictDelete.Enabled = false;
                tbUsername.Enabled = true;
                //REFRESH DATA
                refreshData();
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Apakah anda yakin ingin menghapus data ini?", "Warning!!", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information);

            if (dr == DialogResult.Yes)
            {
                conn.Open();
                String username = tbUsername.Text;
                String query = $"delete from m_users where username like '{username}'";
                SqlCommand comm = new SqlCommand(query, conn);
                comm.ExecuteNonQuery();
                MessageBox.Show("Berhasil Menghapus");
                conn.Close();
                clear();
                pictInsert.Enabled = true;
                pictUpdate.Enabled = false;
                pictDelete.Enabled = false;
                tbUsername.Enabled = true;

                //REFRESH DATA
                refreshData();
            }
        }

        private void pictSearch_Click(object sender, EventArgs e)
        {
            if (rbNamaGroup.Checked)
            {
                conn.Open();
                DataSet ds = new DataSet();
                String query = $"SELECT *" +
                              $"FROM m_users " +
                              $"WHERE namagroupUser like '%{cbGroupCari.SelectedValue}%'";
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];
                dataGridView1.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                conn.Close();

            }
            else
            {
                conn.Open();
                DataSet ds = new DataSet();
                String query = $"SELECT *" +
                              $"FROM m_users " +
                              $"WHERE username like '%{tbUsernameCari.Text}%'";
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];
                dataGridView1.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                conn.Close();

            }
        }

        private void pictPrint_Click(object sender, EventArgs e)
        {
            
        }
    }
}
