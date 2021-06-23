using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace PCSUAS
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            

        }


        
        private void Home_MouseHover(object sender, EventArgs e)
        {
  
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            MasterBarang mBrg = new MasterBarang();
            mBrg.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            MasterSupplier mSplr = new MasterSupplier();
            mSplr.Show();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            MasterUsers mUsers = new MasterUsers();
            mUsers.Show();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            MasterPelanggan mPlngn = new MasterPelanggan();
            mPlngn.Show();
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            MasterMerk mMerk = new MasterMerk();
            mMerk.Show();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            MasterGroupUser mGU = new MasterGroupUser();
            mGU.Show();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            MasterHakAkses mHA = new MasterHakAkses();
            mHA.Show();
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            MasterKota mKota = new MasterKota();
            mKota.Show();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            MasterModel mMdl = new MasterModel();
            mMdl.Show();
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            InvoiceForm inv = new InvoiceForm();
            inv.Show();
        }
    }
}
