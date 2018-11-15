using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting;
using System.Text;
using System.Threading;

namespace Loppemarked
{
    class Customer 
    {
        public string customerID { get; set; }
        public string customerName { get; set; }
        public List<string> itemsPurchased { get; set; }

        public int bankAccount { get; set; }


        public Customer(string name)
        {
            customerName = name; 
        }

        public void PurchaseItem()
        {
            var productBought = "ja"; //Add Produksjon
            if (productBought != null)
            {
                itemsPurchased.Add(productBought);
                Thread.Sleep(1000);
            }
            else
            {
                Thread.CurrentThread.Join();
            }
        }

        public void Get_item()
        {
            //Forhver item i handlekurv
            //print til consol(item)
        }

    }
}
