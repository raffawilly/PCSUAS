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
    public partial class combobox1 : Form
    {
        SqlConnection conn;
        public combobox1()
        {
            InitializeComponent();
            conn = new SqlConnection(@"Data Source=.\SQLExpress;Initial Catalog=dbProjectUas;Integrated Security=True");
        }
        public void refresh()
        {
            conn.Open();

            DataSet ds = new DataSet();
            String query = $"SELECT mb.kode as KODE,mb.part_no AS 'PART NO',mb.description AS DESCRIPTION,mb.unit AS UNIT ,mb.merk1 AS MERK,td.qty AS QUANTITY ,FORMAT(mb.unit_price,'C') AS PRICE,FORMAT((td.qty*mb.unit_price),'C') as Amount " +
                           $"FROM m_barang mb,t_pembelian_detail td,t_pembelian_header th " +
                           $"where th.no_pnw = td.no_pnw " +
                           $"and mb.kode = td.kode " +
                           $"and th.no_nota = td.no_nota " +
                           $"and th.no_nota = '{nO_NOTATextBox.Text}' ";
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
            // TODO: This line of code loads data into the 'dbProjectUasDataSet.m_barang' table. You can move, or remove it, as needed.
            this.m_barangTableAdapter.Fill(this.dbProjectUasDataSet.m_barang);
            // TODO: This line of code loads data into the 'dbProjectUasDataSet.t_pembelian_detail' table. You can move, or remove it, as needed.
            this.t_pembelian_detailTableAdapter.Fill(this.dbProjectUasDataSet.t_pembelian_detail);
            // TODO: This line of code loads data into the 'dbProjectUasDataSet.m_supplier' table. You can move, or remove it, as needed.
            this.m_supplierTableAdapter.Fill(this.dbProjectUasDataSet.m_supplier);
            // TODO: This line of code loads data into the 'dbProjectUasDataSet.t_pembelian_header' table. You can move, or remove it, as needed.
            this.t_pembelian_headerTableAdapter.Fill(this.dbProjectUasDataSet.t_pembelian_header);
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

        private void Combobox2_TextChanged(object sender, EventArgs e)
        {
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {

        }

        private void Combobox2_DropDownClosed(object sender, EventArgs e)
        {
        }

        private void Combobox2_ValueMemberChanged(object sender, EventArgs e)
        {
        }

        private void Combobox2_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void bindingNavigatorMoveLastItem_Click(object sender, EventArgs e)
        {
            refresh();
        }

        private void bindingNavigatorMoveFirstItem_Click(object sender, EventArgs e)
        {
            refresh();
        }

        private void btnTambahItem_Click(object sender, EventArgs e)
        {
            conn.Open();

            //kode
            String temp = $"SELECT kode " +
                         $"FROM m_barang " +
                         $"WHERE id = '{comboBox3.SelectedValue}'";
            SqlCommand comm = new SqlCommand(temp, conn);
           String kode = comm.ExecuteScalar().ToString();

            //part_no
            String temp2 = $"SELECT part_no " +
                         $"FROM m_barang " +
                         $"WHERE id = '{comboBox3.SelectedValue}'";
            SqlCommand comm2 = new SqlCommand(temp2, conn);
            String part_no = comm2.ExecuteScalar().ToString();

            //description
            String temp3 = $"SELECT description " +
                         $"FROM m_barang " +
                         $"WHERE id = '{comboBox3.SelectedValue}'";
            SqlCommand comm3 = new SqlCommand(temp3, conn);
            String description = comm3.ExecuteScalar().ToString();

            //unit
            String temp4 = $"SELECT unit " +
                         $"FROM m_barang " +
                         $"WHERE id = '{comboBox3.SelectedValue}'";
            SqlCommand comm4 = new SqlCommand(temp4, conn);
            String unit = comm3.ExecuteScalar().ToString();

            //merk
            String temp5 = $"SELECT unit " +
                         $"FROM m_barang " +
                         $"WHERE id = '{comboBox3.SelectedValue}'";
            SqlCommand comm5 = new SqlCommand(temp5, conn);
            String merk = comm5.ExecuteScalar().ToString();

            int qty = Convert.ToInt32(numericUpDown1.Value);


            String query = $"Insert into t_pembelian_detail(no_pnw,no_nota,kode,part_no,descriptio,unit,merk,qty) values('{nO_PNWTextBox.Text}','{nO_NOTATextBox.Text}','{kode}','{part_no}','{description}','{unit}','{merk}','{qty}')";
            comm = new SqlCommand(query, conn);
            comm.ExecuteNonQuery();
            conn.Close();
            refresh();

        }
    }
}
