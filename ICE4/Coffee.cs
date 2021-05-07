using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace ICE4
{
    class Coffee
    {
        public void makeCoffee(Order o)
        {
            MessageBox.Show("Making " + o.Coffee + " Coffees");
        }
    }
}
