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
    public partial class MasterHakAkses : Form
    {
        SqlConnection conn;
        public MasterHakAkses()
        {
            InitializeComponent();
            conn = new SqlConnection(@"Data Source=.\SQLExpress;Initial Catalog=dbProjectUas;Integrated Security=True");
            conn.Open();
            DataSet ds = new DataSet();
            String query = $"SELECT *" +
                           $"FROM m_hakaksesgroupuser";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            dataGridView1.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            DataSet hakakses = new DataSet();
            String dataHA = $"SELECT * " +
                          $"FROM m_groupuser ";
            SqlCommand cmdHA = new SqlCommand(dataHA, conn);
            SqlDataAdapter adapterHA = new SqlDataAdapter(cmdHA);
            adapterHA.Fill(hakakses);
            CBGroupUser.DataSource = hakakses.Tables[0];
            CBGroupUser.DisplayMember = "namagroupuser";
            CBGroupUser.ValueMember = "namagroupuser";

            CBGroupUserIns.DataSource = hakakses.Tables[0];
            CBGroupUserIns.DisplayMember = "namagroupuser";
            CBGroupUserIns.ValueMember = "namagroupuser";

            conn.Close();

        }

        private bool cekKosong()
        {
            if (NmMenuInstxt.Text.Length == 0)
            {
                MessageBox.Show("Isi Data Dengan Benar!");
                return false;
            }
            return true;
        }
        private void clear()
        {
            NmMenuInstxt.Text = "";
            NmMenuTxt.Text = "";
            CBGroupUser.SelectedIndex = 0;
            CBGroupUserIns.SelectedIndex = 0;
        }

        private void refreshData()
        {
            conn.Open();
            DataSet ds = new DataSet();
            String query = $"SELECT * " +
                           $"FROM m_hakaksesgroupuser";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            dataGridView1.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            conn.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (cekKosong())
            {
               
                conn = new SqlConnection(@"Data Source=.\SQLExpress;Initial Catalog=dbProjectUas;Integrated Security=True");
                conn.Open();
                String count = $"SELECT ISNULL(COUNT(*), 0) as Jumlah " +
                            $"FROM m_hakaksesgroupuser grp " +
                            $"WHERE namamenu = '{NmMenuInstxt.Text}'";
                SqlCommand comm = new SqlCommand(count, conn);
                int jmlh = Convert.ToInt32(comm.ExecuteScalar().ToString());
                if (jmlh == 0)
                {
                    String query = $"Insert into m_hakaksesgroupuser  values('{CBGroupUserIns.SelectedValue}' , '{NmMenuInstxt.Text}')";
                    comm = new SqlCommand(query, conn);
                    comm.ExecuteNonQuery();
                    conn.Close();
                    this.Validate();

                    refreshData();
                    clear();
                }
                else
                {
                    MessageBox.Show("Nama Menu sudah ada di database");
                    conn.Close();
                }

            }
        }

        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            btnDelete.Enabled = true;
            btnAdd.Enabled = false;
            NmMenuInstxt.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Apakah anda yakin ingin menghapus data ini?", "Warning!!", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information);

            if (dr == DialogResult.Yes)
            {
                conn.Open();
                String Menu = NmMenuInstxt.Text;
                String query = $"delete from m_hakaksesgroupuser where namamenu like '{Menu}'";
                SqlCommand comm = new SqlCommand(query, conn);
                comm.ExecuteNonQuery();
                MessageBox.Show("Berhasil Menghapus");
                conn.Close();
                clear();
                btnDelete.Enabled = false;
                btnAdd.Enabled = true;

                //REFRESH DATA
                refreshData();
            }
             
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (rbGroupUser.Checked)
            {
                conn.Open();
                DataSet ds = new DataSet();
                String query = $"SELECT *" +
                              $"FROM m_hakaksesgroupuser " +
                              $"WHERE namagroupuser like '%{CBGroupUser.SelectedValue}%'";
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];
                dataGridView1.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                conn.Close();

            }
            else
            {
                conn.Open();
                DataSet ds = new DataSet();
                String query = $"SELECT *" +
                              $"FROM m_hakaksesgroupuser " +
                              $"WHERE namamenu like '%{NmMenuTxt.Text}%'";
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];
                dataGridView1.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                conn.Close();

            }
        }


        private void rbMenu_MouseClick(object sender, MouseEventArgs e)
        {
            CBGroupUser.Enabled = false;
            CBGroupUser.SelectedIndex = 0;
            NmMenuTxt.Enabled = true;
            
        }

        private void rbGroupUser_MouseClick(object sender, MouseEventArgs e)
        {
            NmMenuTxt.Enabled = false;
            NmMenuTxt.Text = "";
            CBGroupUser.Enabled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ReportViewerMasterHakAkses report = new ReportViewerMasterHakAkses();
            report.Show();
        }

        private void MasterHakAkses_Load(object sender, EventArgs e)
        {

        }
    }
}
