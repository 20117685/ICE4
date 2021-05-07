using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace ICE4
{
    class Payment
    {
        public void collectPayment(Order o)
        {
            MessageBox.Show("Collecting Payment from : " + o.Name);
        }
    }
}
