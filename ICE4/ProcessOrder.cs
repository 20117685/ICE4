using System;
using System.Collections.Generic;
using System.Text;

namespace ICE4
{
    class ProcessOrder
    {

        public delegate void ProcessOrderDelegate(Order o);

        public event ProcessOrderDelegate OrderSubmitted;
   
        public void ProcessTheOrder(Order o)
        {
            Payment pay = new Payment();
            Coffee c = new Coffee();
            Donuteer d = new Donuteer();
            DBService dbs = new DBService();

            this.OrderSubmitted += pay.collectPayment;
            this.OrderSubmitted += d.packDonuts;
            this.OrderSubmitted += c.makeCoffee;
            this.OrderSubmitted += dbs.WriteToDB;

            OnOrderSubmitted(o);
        }

        protected virtual void OnOrderSubmitted(Order o)
        {
            if (OrderSubmitted != null)
            {
                OrderSubmitted(o);
            }
        }
            

        
    }
}
