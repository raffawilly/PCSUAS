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
                           $"and th.no_nota = '{nO_NOTATextBox.Text}' " +
                           $"and th.p_id = '{Combobox2.Text}'";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];

            //SUM
            String SUM1 = $"SELECT Sum(td.qty*mb.unit_price) " +
                        $"FROM m_barang mb,t_pembelian_detail td,t_pembelian_header th " +
                        $"WHERE mb.kode = td.kode " +
                         $"and th.no_nota = td.no_nota " +
                        $"and th.p_id = '{Combobox2.Text}' " +
                         $"and '{nO_NOTATextBox.Text}' = td.no_nota ";
            SqlCommand commSum1 = new SqlCommand(SUM1, conn);
            String totalHarga = commSum1.ExecuteScalar().ToString();

            //SUM
            String SUM = $"SELECT FORMAT(Sum(td.qty*mb.unit_price),'C') " +
                        $"FROM m_barang mb,t_pembelian_detail td,t_pembelian_header th " +
                        $"WHERE mb.kode = td.kode " +
                         $"and th.no_nota = td.no_nota " +
                        $"and th.p_id = '{Combobox2.Text}' " +
                         $"and '{nO_NOTATextBox.Text}' = td.no_nota ";
            SqlCommand commSum = new SqlCommand(SUM, conn);
            tbTotal.Text = commSum.ExecuteScalar().ToString();
            conn.Close();
            tbGrandTotal.Text = "0";
            int discount = Convert.ToInt32(tbDiscount.Text);
            int ppn = Convert.ToInt32(tbPPN.Text);
            if (totalHarga.Equals(""))
            {
                tbTotal.Text = "0";
            }
            else
            {
                int total = Convert.ToInt32(totalHarga);

                tbGrandTotal.Text = "$" + (total - discount + ppn).ToString() + ",00";
            }
        }
        private void t_pembelian_headerBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.t_pembelian_headerBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.dbProjectUasDataSet);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
                this.Close();
            }
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
            tbDescEdit.Enabled = false;
            updateQty.Enabled = false;
            btnUpdate.Enabled = false;
            btnBatal.Enabled = false;
            btnHapusItem.Enabled = false;
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
            this.dataGridView1.DataSource = null;
            this.dataGridView1.Rows.Clear();
            numericUpDown1.Enabled = true;
            comboBox3.Enabled = true;
            btnTambahItem.Enabled = true;

            tbDescEdit.Enabled = false;
            updateQty.Enabled = false;
            btnUpdate.Enabled = false;
            btnBatal.Enabled = false;
            btnHapusItem.Enabled = false;
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
            
            try
            {
                
                this.Validate();
                this.t_pembelian_headerBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.dbProjectUasDataSet);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
                this.Close();
            }
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
            String unit = comm4.ExecuteScalar().ToString();

            //unit_price
            String temp7 = $"SELECT unit_price " +
                         $"FROM m_barang " +
                         $"WHERE id = '{comboBox3.SelectedValue}'";
            SqlCommand comm8 = new SqlCommand(temp7, conn);
            String unit_price = comm8.ExecuteScalar().ToString();

            //merk
            String temp5 = $"SELECT merk1 " +
                         $"FROM m_barang " +
                         $"WHERE id = '{comboBox3.SelectedValue}'";
            SqlCommand comm5 = new SqlCommand(temp5, conn);
            String merk = comm5.ExecuteScalar().ToString();

            //CEK JUMLAH
            String DataBrg = $"SELECT COUNT(*) FROM t_pembelian_detail WHERE kode = '{kode}' and no_pnw = '{nO_PNWTextBox.Text}'";
            SqlCommand comm6 = new SqlCommand(DataBrg, conn);
            String cekBarang = comm6.ExecuteScalar().ToString();

            int qty = Convert.ToInt32(numericUpDown1.Value);
            if (qty <= 0)
            {
                MessageBox.Show("JUMLAH HARUS LEBIH DARI 0");
                conn.Close();
            }
            else
            {
                if (Convert.ToInt32(cekBarang) > 0)
                {
                    String jmlhBarang = $"SELECT qty FROM t_pembelian_detail WHERE kode = '{kode}' and no_pnw = '{nO_PNWTextBox.Text}'";
                    SqlCommand comm7 = new SqlCommand(jmlhBarang, conn);
                    String stokdetail = comm7.ExecuteScalar().ToString();
                    int tambahQTY = qty + Convert.ToInt32(stokdetail);
                    String query = $"UPDATE t_pembelian_detail SET qty = {tambahQTY} where kode = '{kode}' and no_pnw = '{nO_PNWTextBox.Text}'";
                    comm = new SqlCommand(query, conn);
                    comm.ExecuteNonQuery();

                    //MENGURANGI STOK BARANG DI GUDANG
                    String stokBarang = $"SELECT unit FROM m_barang WHERE kode = '{kode}' ";
                    comm7 = new SqlCommand(stokBarang, conn);
                    String qtyStokBarang = comm7.ExecuteScalar().ToString();
                    int totalPenambahan = Convert.ToInt32(numericUpDown1.Value) + Convert.ToInt32(qtyStokBarang);
                    query = $"UPDATE m_barang SET unit = {totalPenambahan} where kode = '{kode}'";
                    comm = new SqlCommand(query, conn);
                    comm.ExecuteNonQuery();


                    conn.Close();

                    MessageBox.Show("Berhasil ditambahkan");
                    refresh();
                }
                else
                {
                    String query = $"Insert into t_pembelian_detail(no_pnw,no_nota,kode,part_no,descriptio,unit,merk,qty,unit_price) values('{nO_PNWTextBox.Text}','{nO_NOTATextBox.Text}','{kode}','{part_no}','{description}','{unit}','{merk}','{qty}',{unit_price})";
                    comm = new SqlCommand(query, conn);
                    comm.ExecuteNonQuery();

                    //MENGURANGI STOK BARANG DI GUDANG
                    String stokBarang = $"SELECT unit FROM m_barang WHERE kode = '{kode}' ";
                    SqlCommand comm7 = new SqlCommand(stokBarang, conn);
                    String qtyStokBarang = comm7.ExecuteScalar().ToString();
                    int totalPenambahan = Convert.ToInt32(numericUpDown1.Value) + Convert.ToInt32(qtyStokBarang);
                    query = $"UPDATE m_barang SET unit = {totalPenambahan} where kode = '{kode}'";
                    comm = new SqlCommand(query, conn);
                    comm.ExecuteNonQuery();

                    conn.Close();
                    MessageBox.Show("Berhasil ditambahkan");
                    refresh();
                }
            }
        }

        private void btnHapusItem_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Apakah anda yakin ingin menghapus data ini?", "Warning!!", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information);

            if (dr == DialogResult.Yes)
            {
                conn.Open();

                String stokBarang = $"SELECT unit FROM m_barang WHERE kode = '{tbHapusKode.Text}' ";
                SqlCommand comm7 = new SqlCommand(stokBarang, conn);
                String qtyStokBarang = comm7.ExecuteScalar().ToString();
                int totalPenambahan =Convert.ToInt32(qtyStokBarang) - Convert.ToInt32(updateQty.Value) ;
                String query = $"UPDATE m_barang SET unit = {totalPenambahan} where kode = '{tbHapusKode.Text}'";
                SqlCommand comm = new SqlCommand(query, conn);
                comm.ExecuteNonQuery();

                String kode = tbHapusKode.Text;
                query = $"delete from t_pembelian_detail where kode like '{kode}' and no_pnw = '{nO_PNWTextBox.Text}'";
                comm = new SqlCommand(query, conn);
                comm.ExecuteNonQuery();
                MessageBox.Show("Berhasil Menghapus");

               

                conn.Close();
                refresh();
                enableInsert();
            }

        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            numericUpDown1.Enabled = false;
            comboBox3.Enabled = false;
            btnTambahItem.Enabled = false;

            tbDescEdit.Enabled = true;
            updateQty.Enabled = true;
            btnUpdate.Enabled = true;
            label2.Enabled = true;
            tbHapusKode.Enabled = true;
            btnHapusItem.Enabled = true;
            btnBatal.Enabled = true;
            tbHapusKode.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            tbDescEdit.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            updateQty.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
        }

        private void enableInsert()
        {
            numericUpDown1.Enabled = true;
            comboBox3.Enabled = true;
            btnTambahItem.Enabled = true;

            tbDescEdit.Enabled = false;
            updateQty.Enabled = false;
            btnUpdate.Enabled = false;
            label2.Enabled = false;
            tbHapusKode.Enabled = false;
            btnHapusItem.Enabled = false;
            btnBatal.Enabled = false;
            tbHapusKode.Text = "";
        }
        private void btnBatal_Click(object sender, EventArgs e)
        {
            enableInsert();
        }

        private void pictPrint_Click(object sender, EventArgs e)
        {
            ReportViewerPembelian rp = new ReportViewerPembelian();
            rp.Show();
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            

            this.Validate();
            this.t_pembelian_headerBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dbProjectUasDataSet);
            refresh();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            conn.Open();
            //MENGAMBIL QTY
            String temp4 = $"SELECT qty " +
                         $"FROM t_pembelian_detail " +
                         $"where kode like '{tbHapusKode.Text}' " +
                         $" and no_pnw = '{nO_PNWTextBox.Text}'";
            SqlCommand comm4 = new SqlCommand(temp4, conn);
            String tempQty = comm4.ExecuteScalar().ToString();
            conn.Close();
            if (updateQty.Value < 1)
            {
                MessageBox.Show("Angka Stok tidak boleh 0 atau dibawah 0");
            }
            else
            {
                if (updateQty.Value > Convert.ToInt32(tempQty))
                {
                    conn.Open();
                    //MENGHITUNG JARAK PERBEDAAN QTY
                    int jarakQty = Convert.ToInt32(updateQty.Value) - Convert.ToInt32(tempQty);

                    //MENGAMBIL QTY
                    temp4 = $"SELECT unit " +
                                 $"FROM m_barang " +
                                 $"where kode like '{tbHapusKode.Text}' ";
                    comm4 = new SqlCommand(temp4, conn);
                    String qtyBarang = comm4.ExecuteScalar().ToString();

                    //MENAMBAH QTY DI BARANG
                    int totalAKhirQty = jarakQty + Convert.ToInt32(qtyBarang);

                    //UPDATE BARANG
                    String query = $"update m_barang set unit = {totalAKhirQty} where kode like '{tbHapusKode.Text}'";
                    SqlCommand comm2 = new SqlCommand(query, conn);
                    comm2.ExecuteNonQuery();


                    //UPDATE PEMBLIAN DETAIL
                    query = $"update t_pembelian_detail set qty = {updateQty.Value} where kode like '{tbHapusKode.Text}' and no_pnw = '{nO_PNWTextBox.Text}'";
                    comm2 = new SqlCommand(query, conn);
                    comm2.ExecuteNonQuery();

                    MessageBox.Show("BERHASIL DI UPDATE");
                    conn.Close();
                    refresh();
                    enableInsert();
                }
                else
                {
                    conn.Open();
                    //MENGHITUNG JARAK PERBEDAAN QTY
                    int jarakQty = Convert.ToInt32(tempQty) - Convert.ToInt32(updateQty.Value);

                    //MENGAMBIL QTY
                    temp4 = $"SELECT unit " +
                                 $"FROM m_barang " +
                                 $"where kode like '{tbHapusKode.Text}' ";
                    comm4 = new SqlCommand(temp4, conn);
                    String qtyBarang = comm4.ExecuteScalar().ToString();

                    //MENAMBAH QTY DI BARANG
                    int totalAKhirQty = Convert.ToInt32(qtyBarang) - jarakQty;

                    //UPDATE BARANG
                    String query = $"update m_barang set unit = {totalAKhirQty} where kode like '{tbHapusKode.Text}'";
                    SqlCommand comm2 = new SqlCommand(query, conn);
                    comm2.ExecuteNonQuery();


                    //UPDATE PEMBLIAN DETAIL
                    query = $"update t_pembelian_detail set qty = {updateQty.Value} where kode like '{tbHapusKode.Text}' and no_pnw = '{nO_PNWTextBox.Text}'";
                    comm2 = new SqlCommand(query, conn);
                    comm2.ExecuteNonQuery();

                    MessageBox.Show("BERHASIL DI UPDATE");
                    conn.Close();
                    enableInsert();
                    refresh();
                }
            }
         
        }
    }
}
