using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ICE4
{
    public partial class frmOrder : Form
    {
        public frmOrder()
        {
            InitializeComponent();
        }


        

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            string name = txtName.Text;
            int donuts = Convert.ToInt32(txtDonuts.Text);
            int coffee = Convert.ToInt32(txtCoffee.Text);

            Order o = new Order(name, donuts, coffee);

            ProcessOrder p = new ProcessOrder();

            p.ProcessTheOrder(o);



        }

       

     

        
    }
}
