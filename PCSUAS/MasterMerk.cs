using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MasterMerkData;  

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
            List<> merkList;
            try
            {
                merkList = masterMerk
                if (invoiceList.Count > 0)
                {
                    Invoice invoice;
                    for (int i = 0; i < invoiceList.Count; i++)
                    {
                        invoice = invoiceList[i];
                        lvInvoices.Items.Add(invoice.InvoiceNumber);
                        lvInvoices.Items[i].SubItems.Add(invoice.InvoiceDate.ToShortDateString());
                        lvInvoices.Items[i].SubItems.Add(invoice.InvoiceTotal.ToString("c"));
                        lvInvoices.Items[i].SubItems.Add(invoice.PaymentTotal.ToString("c"));
                        lvInvoices.Items[i].SubItems.Add(invoice.CreditTotal.ToString("c"));
                        lvInvoices.Items[i].SubItems.Add(invoice.BalanceDue().ToString("c"));
                        lvInvoices.Items[i].SubItems.Add(invoice.DueDate.ToShortDateString());
                    }
                    decimal totalBalanceDue = InvoiceDB.GetTotalBalanceDue();
                    txtTotalBalanceDue.Text = totalBalanceDue.ToString("c");
                }
                else
                {
                    MessageBox.Show("All invoices are paid in full.",
                        "No Balance Due");
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
                this.Close();
            }
        }
    }
}
