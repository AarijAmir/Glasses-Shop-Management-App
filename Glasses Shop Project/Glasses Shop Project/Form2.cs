using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Glasses_Shop_Project
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void customerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Customer customer = new Customer();
            customer.MdiParent = this;
            customer.Show();
              
        }

        private void distributorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Distributor distributor = new Distributor();
            distributor.MdiParent = this;
            distributor.Show();

        }

        private void accountToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.MdiParent = this;
            form1.Show();
        }

        private void productToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Product product = new Product();
            product.MdiParent = this;
            product.Show();

        }

        private void purchaseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Purchase purchase = new Purchase();
            purchase.MdiParent = this;
            purchase.Show();
        }

        private void saleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Sale sale = new Sale();
            sale.MdiParent = this;
            sale.Show();
        }
    }
}
