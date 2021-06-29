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
    public partial class Penawaran : Form
    {
        SqlConnection conn;
        public Penawaran()
        {
            InitializeComponent();
            conn = new SqlConnection(@"Data Source=.\SQLExpress;Initial Catalog=dbProjectUas;Integrated Security=True");
        }
        public void enableInserting()
        {
            numericUpDown1.Enabled = true;
            comboBox3.Enabled = true;
            btnTambahItem.Enabled = true;
            tbHargaJual.Enabled = true;

            updateQty.Enabled = false;
            tbEditHargaJual.Enabled = false;
            tbDescEdit.Enabled = false;
            label2.Enabled = false;
            tbHapusKode.Enabled = false;
            btnHapusItem.Enabled = false;
            btnBatal.Enabled = false;
            btnUpdate.Enabled = false;
        }

        public void refresh()
        {
            conn.Open();

            DataSet ds = new DataSet();
            String query = $"SELECT mb.kode as KODE,mb.part_no AS 'PART NO',mb.description AS DESCRIPTION,mb.merk1 AS MERK,td.qty AS QUANTITY ,FORMAT(mb.unit_price,'C') AS 'BUY PRICE',FORMAT(td.unit_pric2,'C') AS 'SELL PRICE',FORMAT((td.qty*td.unit_pric2),'C') as Amount " +
                           $"FROM m_barang mb,t_penawaran_detail td,t_penawaran_header th " +
                           $"where th.no_pnw = td.no_pnw " +
                           $"and mb.kode = td.kode " +
                           $"and th.no_pnw = '{nO_PNWTextBox.Text}' ";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];

            //SUM
            String SUM1 = $"SELECT Sum(td.qty*mb.unit_price) " +
                        $"FROM m_barang mb,t_penawaran_detail td,t_penawaran_header th " +
                        $"WHERE mb.kode = td.kode " +
                         $"and th.no_pnw = td.no_pnw " +
                        $"and th.p_id = '{p_IDComboBox.Text}' " +
                         $"and '{nO_PNWTextBox.Text}' = td.no_pnw ";
            SqlCommand commSum1 = new SqlCommand(SUM1, conn);
            String totalHarga = commSum1.ExecuteScalar().ToString();

            //SUM
            String SUM = $"SELECT FORMAT(Sum(td.qty*mb.unit_price),'C') " +
                        $"FROM m_barang mb,t_penawaran_detail td,t_penawaran_header th " +
                        $"WHERE mb.kode = td.kode " +
                         $"and th.no_pnw = td.no_pnw " +
                        $"and th.p_id = '{p_IDComboBox.Text}' " +
                         $"and '{nO_PNWTextBox.Text}' = td.no_pnw ";
            SqlCommand commSum = new SqlCommand(SUM, conn);
            tbTotal.Text = commSum.ExecuteScalar().ToString();
            conn.Close();

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
            //HARGA BELI
            try
            {
                conn.Open();
                //unit
                String temp4 = $"SELECT unit_price " +
                             $"FROM m_barang " +
                             $"WHERE id = '{comboBox3.SelectedValue}'";
                SqlCommand comm4 = new SqlCommand(temp4, conn);
                tbHargaBeli.Text = comm4.ExecuteScalar().ToString();

                //unit
                String temp = $"SELECT unit_pric2 " +
                             $"FROM t_penawaran_detail " +
                             $"WHERE descriptio = '{comboBox3.Text}' "+
                             $"and no_pnw = '{nO_PNWTextBox.Text}'";
                SqlCommand comm = new SqlCommand(temp, conn);
                tbHargaJual.Text = comm.ExecuteScalar().ToString();
                conn.Close();
            }
            catch(NullReferenceException ex)
            {
                conn.Close();
            }
       
        }

        private void t_penawaran_headerBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.t_penawaran_headerBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.dbProjectUasDataSet);
           

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
                this.Close();
            }
        }

        private void Penawaran_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dbProjectUasDataSet.m_barang' table. You can move, or remove it, as needed.
            this.m_barangTableAdapter.Fill(this.dbProjectUasDataSet.m_barang);
            // TODO: This line of code loads data into the 'dbProjectUasDataSet.m_pelanggan' table. You can move, or remove it, as needed.
            this.m_pelangganTableAdapter.Fill(this.dbProjectUasDataSet.m_pelanggan);
            // TODO: This line of code loads data into the 'dbProjectUasDataSet.m_supplier' table. You can move, or remove it, as needed.
            this.m_supplierTableAdapter.Fill(this.dbProjectUasDataSet.m_supplier);
            // TODO: This line of code loads data into the 'dbProjectUasDataSet.t_penawaran_header' table. You can move, or remove it, as needed.
            this.t_penawaran_headerTableAdapter.Fill(this.dbProjectUasDataSet.t_penawaran_header);

            refresh();
        }

        private void bATALCheckBox_Click(object sender, EventArgs e)
        {

        }

        private void bindingNavigatorMoveNextItem_Click(object sender, EventArgs e)
        {
            refresh();
        }

        private void bindingNavigatorMovePreviousItem_Click(object sender, EventArgs e)
        {
            refresh();
        }

        private void btnTambahItem_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.t_penawaran_headerBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.dbProjectUasDataSet);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
                this.Close();
            }
            conn.Open();

            //AutoInc
            String count = $"SELECT ISNULL(COUNT(*), 0) as Jumlah " +
                            $"FROM t_invoice_header th ";
            SqlCommand commSelect = new SqlCommand(count, conn);
            int jmlh = Convert.ToInt32(commSelect.ExecuteScalar().ToString());

            //CekInvHeader
            String count2 = $"SELECT ISNULL(COUNT(*), 0) as Jumlah " +
                            $"FROM t_invoice_header th " +
                            $"WHERE th.no_pnw = '{nO_PNWTextBox.Text}'";
            SqlCommand commSelect2 = new SqlCommand(count2, conn);
            int jmlh2 = Convert.ToInt32(commSelect2.ExecuteScalar().ToString());

            if (jmlh2 == 0)
            {
                //inserting Invoice Header
                String insertInv = $"Insert into t_invoice_header(no_inv,no_pnw,tgl_inv,p_id) values('{jmlh + 1}','{nO_PNWTextBox.Text}','{tGL_PNWDateTimePicker.Value.ToLongDateString()}','{p_IDComboBox.Text}')";
                SqlCommand commInsert = new SqlCommand(insertInv, conn);
                commInsert.ExecuteNonQuery();
            }

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
            String temp4 = $"SELECT unit_price " +
                         $"FROM m_barang " +
                         $"WHERE id = '{comboBox3.SelectedValue}'";
            SqlCommand comm4 = new SqlCommand(temp4, conn);
            String unit = comm4.ExecuteScalar().ToString();

            //HARGA JUAL
            string unit2 = tbHargaJual.Text;

            //merk
            String temp5 = $"SELECT merk1 " +
                         $"FROM m_barang " +
                         $"WHERE id = '{comboBox3.SelectedValue}'";
            SqlCommand comm5 = new SqlCommand(temp5, conn);
            String merk = comm5.ExecuteScalar().ToString();

            //CEK JUMLAH
            String DataBrg = $"SELECT COUNT(*) FROM t_penawaran_detail WHERE kode = '{kode}' and no_pnw = '{nO_PNWTextBox.Text}'";
            SqlCommand comm6 = new SqlCommand(DataBrg, conn);
            String cekBarang = comm6.ExecuteScalar().ToString();


            //CEK STOK 
            String stok = $"SELECT unit FROM m_barang WHERE kode = '{kode}' ";
            SqlCommand stokComm = new SqlCommand(stok, conn);
            String totalStok = stokComm.ExecuteScalar().ToString();

            int qty = Convert.ToInt32(numericUpDown1.Value);
            if (qty <= 0)
            {
                MessageBox.Show("JUMLAH HARUS LEBIH DARI 0");
                conn.Close();
            }
            else
            {
                if(Convert.ToInt32(totalStok) < qty ){
                    MessageBox.Show("STOK BARANG DIGUDANG KURANG");
                    conn.Close();
                }
                else
                {
                    if (Convert.ToInt32(cekBarang) > 0)
                    {
                        String jmlhBarang = $"SELECT qty FROM t_penawaran_detail WHERE kode = '{kode}' and no_pnw = '{nO_PNWTextBox.Text}'";
                        SqlCommand comm7 = new SqlCommand(jmlhBarang, conn);
                        String qtyAwal = comm7.ExecuteScalar().ToString();
                        int tambahQTY = qty + Convert.ToInt32(qtyAwal);
                        int hargajual = Convert.ToInt32(tbHargaJual.Text);
                        String query = $"UPDATE t_penawaran_detail SET qty = {tambahQTY},unit_pric2 = {hargajual}  where kode = '{kode}' and no_pnw = '{nO_PNWTextBox.Text}'";
                        comm = new SqlCommand(query, conn);
                        comm.ExecuteNonQuery();


                        jmlhBarang = $"SELECT unit FROM m_barang WHERE kode = '{kode}' ";
                        comm7 = new SqlCommand(jmlhBarang, conn);
                        qtyAwal = comm7.ExecuteScalar().ToString();
                        int kurangQTY = Convert.ToInt32(qtyAwal) - qty;
                        query = $"UPDATE m_barang SET unit = {kurangQTY} where kode = '{kode}'";
                        comm = new SqlCommand(query, conn);
                        comm.ExecuteNonQuery();

                        conn.Close();
                        MessageBox.Show("Berhasil ditambahkan");
                        refresh();
                    }
                    else
                    {
                        String query = $"Insert into t_penawaran_detail(no_pnw,kode,part_no,descriptio,unit_price,unit_pric2,qty) values('{nO_PNWTextBox.Text}','{kode}','{part_no}','{description}','{unit}','{unit2}','{qty}')";
                        comm = new SqlCommand(query, conn);
                        comm.ExecuteNonQuery();

                        String selectInv = $"SELECT no_inv FROM t_invoice_header WHERE no_pnw = '{nO_PNWTextBox.Text}'";
                        SqlCommand commSelectNoInv = new SqlCommand(selectInv, conn);
                        String SelectNoInv = commSelectNoInv.ExecuteScalar().ToString();

                        String InsertingInvoice = $"Insert into t_invoice_detail(no_inv,kode,part_no,descriptio,unit_price,unit_pric2,qty) values('{SelectNoInv}','{kode}','{part_no}','{description}','{unit}','{unit2}','{qty}')";
                        comm = new SqlCommand(InsertingInvoice, conn);
                        comm.ExecuteNonQuery();

                        String jmlhBarang = $"SELECT unit FROM m_barang WHERE kode = '{kode}' ";
                        SqlCommand comm7 = new SqlCommand(jmlhBarang, conn);
                        String qtyAwal = comm7.ExecuteScalar().ToString();
                        int kurangQTY = Convert.ToInt32(qtyAwal) - qty;
                        query = $"UPDATE m_barang SET unit = {kurangQTY} where kode = '{kode}'";
                        comm = new SqlCommand(query, conn);
                        comm.ExecuteNonQuery();

                        conn.Close();
                        MessageBox.Show("Berhasil ditambahkan");
                        refresh();
                    }
                }
            }
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            numericUpDown1.Enabled = false;
            comboBox3.Enabled = false;
            btnTambahItem.Enabled = false;
            tbHargaJual.Enabled = false;

            btnUpdate.Enabled = true;
            updateQty.Enabled = true;
            tbEditHargaJual.Enabled = true;
            tbDescEdit.Enabled = true;
            label2.Enabled = true;
            tbHapusKode.Enabled = true;
            btnHapusItem.Enabled = true;
            btnBatal.Enabled = true;
            tbHapusKode.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            tbDescEdit.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            updateQty.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();

            conn.Open();
            //MENGAMBIL HARGA JUAL DARI DATABASE
            String temp4 = $"SELECT unit_pric2 " +
                         $"FROM t_penawaran_detail " +
                         $"where kode like '{tbHapusKode.Text}' " +
                         $" and no_pnw = '{nO_PNWTextBox.Text}'";
            SqlCommand comm4 = new SqlCommand(temp4, conn);
            tbEditHargaJual.Text = comm4.ExecuteScalar().ToString();
            conn.Close();


        }

        private void btnBatal_Click(object sender, EventArgs e)
        {
            enableInserting();
        }

        private void btnHapusItem_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Apakah anda yakin ingin menghapus data ini?", "Warning!!", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information);

            if (dr == DialogResult.Yes)
            {
                conn.Open();
                String jmlhBarang = $"SELECT unit FROM m_barang WHERE kode = '{tbHapusKode.Text}' ";
                SqlCommand comm7 = new SqlCommand(jmlhBarang, conn);
                String qtyAwal = comm7.ExecuteScalar().ToString();
                int TambahQty = Convert.ToInt32(qtyAwal) + Convert.ToInt32(updateQty.Value);

                String query = $"UPDATE m_barang SET unit = {TambahQty} where kode = '{tbHapusKode.Text}'";
               SqlCommand comm = new SqlCommand(query, conn);
                comm.ExecuteNonQuery();

                String kode = tbHapusKode.Text;
                query = $"delete from t_penawaran_detail where kode like '{kode}' and no_pnw = '{nO_PNWTextBox.Text}'";
                comm = new SqlCommand(query, conn);
                comm.ExecuteNonQuery();


                enableInserting();
                MessageBox.Show("Berhasil Menghapus");
                conn.Close();
                refresh();
                
            }
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            this.dataGridView1.DataSource = null;
            this.dataGridView1.Rows.Clear();

        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
         
            this.Validate();
            this.t_penawaran_headerBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dbProjectUasDataSet);

            refresh();
        }

        private void comboBox3_SelectedValueChanged(object sender, EventArgs e)
        {
        }

        private void comboBox3_TextChanged(object sender, EventArgs e)
        {
            refresh();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            conn.Open();

            //CEK STOK 
            String stok = $"SELECT unit FROM m_barang WHERE kode = '{tbHapusKode.Text}' ";
            SqlCommand stokComm = new SqlCommand(stok, conn);
            String totalStok = stokComm.ExecuteScalar().ToString();

            //MENGAMBIL QTY
            String temp4 = $"SELECT qty " +
                         $"FROM t_penawaran_detail " +
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

                    //UNIT YANG DITAWAR SEBELUMNYA
                    String jmlhBarang = $"SELECT QTY FROM t_penawaran_detail WHERE kode = '{tbHapusKode.Text}' and no_pnw = '{nO_PNWTextBox.Text}'";
                    SqlCommand comm7 = new SqlCommand(jmlhBarang, conn);
                    String unitPenawaran = comm7.ExecuteScalar().ToString();

                    int totalPengurangan = Convert.ToInt32(updateQty.Value) - Convert.ToInt32(unitPenawaran);

                    jmlhBarang = $"SELECT unit FROM m_barang WHERE kode = '{tbHapusKode.Text}' ";
                    comm7 = new SqlCommand(jmlhBarang, conn);
                    String qtyAwal = comm7.ExecuteScalar().ToString();
                    int kurangQTY = Convert.ToInt32(qtyAwal) - totalPengurangan;

                    String query = $"UPDATE m_barang SET unit = {kurangQTY} where kode = '{tbHapusKode.Text}'";
                    SqlCommand comm = new SqlCommand(query, conn);
                    comm.ExecuteNonQuery();

                    query = $"update t_penawaran_detail set qty = {updateQty.Value},unit_pric2 = '{tbEditHargaJual.Text}' where kode like '{tbHapusKode.Text}' and no_pnw = '{nO_PNWTextBox.Text}'";
                    SqlCommand comm2 = new SqlCommand(query, conn);
                    comm2.ExecuteNonQuery();
                    enableInserting();
                    conn.Close();
                    refresh();
                    MessageBox.Show("Berhasil Update!");
                }
                else
                {
                    conn.Open();



                    //UNIT YANG DITAWAR SEBELUMNYA
                    String jmlhBarang = $"SELECT QTY FROM t_penawaran_detail WHERE kode = '{tbHapusKode.Text}' and no_pnw = '{nO_PNWTextBox.Text}'";
                    SqlCommand comm7 = new SqlCommand(jmlhBarang, conn);
                    String unitPenawaran = comm7.ExecuteScalar().ToString();

                    int totalPengurangan = Convert.ToInt32(unitPenawaran) - Convert.ToInt32(updateQty.Value);

                    jmlhBarang = $"SELECT unit FROM m_barang WHERE kode = '{tbHapusKode.Text}' ";
                    comm7 = new SqlCommand(jmlhBarang, conn);
                    String qtyAwal = comm7.ExecuteScalar().ToString();
                    int tambahQTY = Convert.ToInt32(qtyAwal) + totalPengurangan;
                    String query2 = $"UPDATE m_barang SET unit = {tambahQTY} where kode = '{tbHapusKode.Text}'";
                    SqlCommand comm = new SqlCommand(query2, conn);
                    comm.ExecuteNonQuery();

                    //UPDATE PENAWARAN DETAIL
                    String query = $"update t_penawaran_detail set qty = {updateQty.Value},unit_pric2 = '{tbEditHargaJual.Text}' where kode like '{tbHapusKode.Text}' and no_pnw = '{nO_PNWTextBox.Text}'";
                    SqlCommand comm2 = new SqlCommand(query, conn);
                    comm2.ExecuteNonQuery();
                    enableInserting();
                    conn.Close();
                    refresh();
                    MessageBox.Show("Berhasil Update!");
                }

            }


        }
    }
}
