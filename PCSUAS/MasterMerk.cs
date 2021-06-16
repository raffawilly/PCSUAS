using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MasterMerkData2;
namespace PCSUAS
{
    public partial class MasterMerk : Form
    {
        public MasterMerk()
        {
            InitializeComponent();
        }

        private void MasterMerk_Load(object sender, EventArgs e)
        {

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            List<MasterMerk2> merkList;
            try
            {
                merkList = MasterMerkDB2.get();
                if (merkList.Count > 0)
                {
                    MasterMerk2 masterMerk;
                    for (int i = 0; i < merkList.Count; i++)
                    {
                        masterMerk = merkList[i];
                        listView1.Items.Add(masterMerk.Id.ToString());
                        listView1.Items[i].SubItems.Add(masterMerk.Merk_code);
                        listView1.Items[i].SubItems.Add(masterMerk.Merk_desc);
                    }
                }
                else
                {
                    //MessageBox.Show("All invoices are paid in full.",
                    //    "No Balance Due");
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
                this.Close();
            }
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void btnCari_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            List<MasterMerk2> merkList;
            String CODE =tbCode.Text;
            try
            {
                merkList = MasterMerkDB2.getByMerkCode(CODE);
                if (merkList.Count > 0)
                {
                    MasterMerk2 masterMerk;
                    for (int i = 0; i < merkList.Count; i++)
                    {
                        masterMerk = merkList[i];
                        listView1.Items.Add(masterMerk.Id.ToString());
                        listView1.Items[i].SubItems.Add(masterMerk.Merk_code);
                        listView1.Items[i].SubItems.Add(masterMerk.Merk_desc);
                    }
                }
                else
                {
                    MessageBox.Show("Data tidak ditemukan");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
                this.Close();
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            List<MasterMerk2> merkList;
            String desc = tbDesc.Text;
            try
            {
                merkList = MasterMerkDB2.getByMerkDesc(desc);
                if (merkList.Count > 0)
                {
                    MasterMerk2 masterMerk;
                    for (int i = 0; i < merkList.Count; i++)
                    {
                        masterMerk = merkList[i];
                        listView1.Items.Add(masterMerk.Id.ToString());
                        listView1.Items[i].SubItems.Add(masterMerk.Merk_code);
                        listView1.Items[i].SubItems.Add(masterMerk.Merk_desc);
                    }
                }
                else
                {
                    MessageBox.Show("Data tidak ditemukan");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
                this.Close();
            }
        }

        private void tbCode_MouseClick(object sender, MouseEventArgs e)
        {
            tbCode.Clear();
        }

        private void tbDesc_MouseClick(object sender, MouseEventArgs e)
        {
            tbDesc.Clear();
        }
    }
}
