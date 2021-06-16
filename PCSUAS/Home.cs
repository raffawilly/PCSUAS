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


        private void btnMasterBarang_Click(object sender, EventArgs e)
        {
            MasterBarang mBrg = new MasterBarang();
            mBrg.Show();
        }

        private void btnMasterPelanggan_Click(object sender, EventArgs e)
        {
            MasterPelanggan mPlngn = new MasterPelanggan();
            mPlngn.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MasterSupplier mSplr = new MasterSupplier();
            mSplr.Show();
        }

        private void Home_MouseHover(object sender, EventArgs e)
        {
  
        }

        private void btnMasterBarang_MouseLeave(object sender, EventArgs e)
        {
        }

        private void button6_Click(object sender, EventArgs e)
        {
            MasterGroupUser mGU = new MasterGroupUser();
            mGU.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            MasterHakAkses mHA = new MasterHakAkses();
            mHA.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            MasterModel mMdl = new MasterModel();
            mMdl.Show();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            MasterUsers mUsers = new MasterUsers();
            mUsers.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            MasterKota mKota = new MasterKota();
            mKota.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            MasterMerk mMerk = new MasterMerk();
            mMerk.Show();
        }
    }
}
