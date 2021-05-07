using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace ICE4
{
    class DBService
    {
        public void WriteToDB(Order o)
        {
            MessageBox.Show("Writing to DB " + o.ToString());
        }
    }
}
