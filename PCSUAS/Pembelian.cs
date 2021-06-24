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
    public partial class Pembelian : Form
    {
        SqlConnection conn;
        public Pembelian()
        {
            InitializeComponent();
            conn = new SqlConnection(@"Data Source=.\SQLExpress;Initial Catalog=dbProjectUas;Integrated Security=True");
        }
        public void refresh()
        {
            conn.Open();
            //NAMA
            String temp = $"SELECT nama " +
                         $"FROM m_supplier " +
                         $"WHERE p_id = '{p_IDTextBox.Text}'";
            SqlCommand comm = new SqlCommand(temp, conn);
            tbNamaSupp.Text = comm.ExecuteScalar().ToString();

            //NPWP
            String temp2 = $"SELECT npwp " +
                         $"FROM m_supplier " +
                         $"WHERE p_id = '{p_IDTextBox.Text}'";
            SqlCommand comm2 = new SqlCommand(temp2, conn);
            tbNoNpwp.Text = comm2.ExecuteScalar().ToString();

            //alamat
            String temp3 = $"SELECT alamat " +
                         $"FROM m_supplier " +
                         $"WHERE p_id = '{p_IDTextBox.Text}'";
            SqlCommand comm3 = new SqlCommand(temp3, conn);
            tbAlamat.Text = comm3.ExecuteScalar().ToString();

            //kota
            String temp4 = $"SELECT kota " +
                         $"FROM m_supplier " +
                         $"WHERE p_id = '{p_IDTextBox.Text}'";
            SqlCommand comm4 = new SqlCommand(temp4, conn);
            tbKota.Text = comm4.ExecuteScalar().ToString();

            //note
            String temp5 = $"SELECT note " +
                         $"FROM m_supplier " +
                         $"WHERE p_id = '{p_IDTextBox.Text}'";
            SqlCommand comm5 = new SqlCommand(temp5, conn);
            tbNote.Text = comm5.ExecuteScalar().ToString();


            DataSet ds = new DataSet();
            String query = $"SELECT mb.kode as KODE,mb.part_no AS 'PART NO',mb.description AS DESCRIPTION,mb.unit AS UNIT ,mb.merk1 AS MERK,td.qty AS QUANTITY ,FORMAT(mb.unit_price,'C') AS PRICE,FORMAT((td.qty*mb.unit_price),'C') as Amount " +
                           $"FROM m_barang mb,t_pembelian_detail td,t_pembelian_header th " +
                           $"where th.no_pnw = td.no_pnw " +
                           $"and mb.kode = td.kode " +
                           $"and th.no_nota = td.no_nota " +
                           $"and th.p_id = '{p_IDTextBox.Text}'";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];


            conn.Close();


        }
        private void t_pembelian_headerBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.t_pembelian_headerBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dbProjectUasDataSet);

        }

        private void Pembelian_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dbProjectUasDataSet.t_pembelian_detail' table. You can move, or remove it, as needed.
            this.t_pembelian_detailTableAdapter.Fill(this.dbProjectUasDataSet.t_pembelian_detail);
            // TODO: This line of code loads data into the 'dbProjectUasDataSet.m_supplier' table. You can move, or remove it, as needed.
            this.m_supplierTableAdapter.Fill(this.dbProjectUasDataSet.m_supplier);
            // TODO: This line of code loads data into the 'dbProjectUasDataSet.t_pembelian_header' table. You can move, or remove it, as needed.
            this.t_pembelian_headerTableAdapter.Fill(this.dbProjectUasDataSet.t_pembelian_header);
            refresh();

        }

        private void p_IDLabel_Click(object sender, EventArgs e)
        {
                   }

        private void p_IDComboBox_SelectedValueChanged(object sender, EventArgs e)
        {
            refresh();
        }

        private void bindingNavigatorMoveNextItem_Click(object sender, EventArgs e)
        {
            refresh();
        }

        private void bindingNavigatorMovePreviousItem_Click(object sender, EventArgs e)
        {
            refresh();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
