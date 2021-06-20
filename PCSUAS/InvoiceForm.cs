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
    public partial class InvoiceForm : Form
    {
        SqlConnection conn;
        public InvoiceForm()
        {
            InitializeComponent();
            conn = new SqlConnection(@"Data Source=.\SQLExpress;Initial Catalog=dbProjectUas;Integrated Security=True");
            refreshSupplier();
        }

        public void refreshSupplier()
        {
            conn.Open();

            //NAMA
            String temp = $"SELECT nama " +
                         $"FROM m_supplier " +
                         $"WHERE p_id = '{tbSup.Text}'";
            SqlCommand comm = new SqlCommand(temp, conn);
            tbNamaSup.Text = comm.ExecuteScalar().ToString();

            //ALAMAT
            String alamat = $"SELECT alamat " +
                         $"FROM m_supplier " +
                         $"WHERE p_id = '{tbSup.Text}'";
            SqlCommand commAlamat = new SqlCommand(alamat, conn);
            tbAlamatSup.Text = commAlamat.ExecuteScalar().ToString();
            

            //NPWP
            String npwp = $"SELECT npwp " +
                         $"FROM m_supplier " +
                         $"WHERE p_id = '{tbSup.Text}'";
            SqlCommand commNpwp = new SqlCommand(npwp, conn);
            tbNomorNPWP.Text = commNpwp.ExecuteScalar().ToString();
      

            //NAMANPWP
            String namanpwp = $"SELECT nama_npwp " +
                         $"FROM m_supplier " +
                         $"WHERE p_id = '{tbSup.Text}'";
            SqlCommand commnamaNpwp = new SqlCommand(namanpwp, conn);
            tbNamaNPWP.Text = commnamaNpwp.ExecuteScalar().ToString();

            //KOTA
            String kota = $"SELECT kota " +
                         $"FROM m_supplier " +
                         $"WHERE p_id = '{tbSup.Text}'";
            SqlCommand commKota = new SqlCommand(kota, conn);
            tbKota.Text = commKota.ExecuteScalar().ToString();

            //EMAIL
            String email = $"SELECT EMAIL " +
                        $"FROM m_supplier " +
                        $"WHERE p_id = '{tbSup.Text}'";
            SqlCommand commEmail = new SqlCommand(email, conn);
            tbEmail.Text = commKota.ExecuteScalar().ToString();

            //NOTE
            String note = $"SELECT note " +
                        $"FROM m_supplier " +
                        $"WHERE p_id = '{tbSup.Text}'";
            SqlCommand commNote = new SqlCommand(note, conn);
            tbNote.Text = commNote.ExecuteScalar().ToString();


            DataSet ds = new DataSet();
            String query = $"SELECT mb.kode as KODE,mb.part_no AS 'PART NO',mb.description AS DESCRIPTION,mb.unit AS UNIT ,mb.merk1 AS MERK,td.qty AS QUANTITY ,FORMAT(mb.unit_price,'C') AS PRICE,FORMAT((td.qty*mb.unit_price),'C') as Amount " +
                           $"FROM m_barang mb,t_pembelian_detail td,t_pembelian_header th " +
                           $"where mb.kode = td.kode "+
                           $"and th.p_id = '{tbSup.Text}'";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.Fill(ds);
            dgvBarang.DataSource = ds.Tables[0];

            conn.Close();
        }
        private void t_invoice_headerBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.t_invoice_headerBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dbProjectUasDataSet);

        }

        private void InvoiceForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dbProjectUasDataSet.m_supplier' table. You can move, or remove it, as needed.
            this.m_supplierTableAdapter.Fill(this.dbProjectUasDataSet.m_supplier);
            // TODO: This line of code loads data into the 'dbProjectUasDataSet.t_invoice_header' table. You can move, or remove it, as needed.
            this.t_invoice_headerTableAdapter.Fill(this.dbProjectUasDataSet.t_invoice_header);

        }

        private void tbSup_TextChanged(object sender, EventArgs e)
        {
        }

        private void bindingNavigatorMoveNextItem_Click(object sender, EventArgs e)
        {
            refreshSupplier();
        }

        private void bindingNavigatorMovePreviousItem_Click(object sender, EventArgs e)
        {
            refreshSupplier();
        }
    }
}
