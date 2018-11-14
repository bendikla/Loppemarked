using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting;
using System.Text;

namespace Loppemarked
{
    class Customer 
    {
        public string customerID { get; set; }
        public string customerName { get; set; }
        public List<string> ItemsPurchesed { get; set; }

        public int bankAccount { get; set; }


        public Customer(string id, string name, int bankAccountnr)
        {
            customerID = id;
            customerName = name;
            ItemsPurchesed = new List<string>();
            bankAccount = bankAccountnr;
        }

        public void Purchase_item()
        {
            //while kunden har penger
            // Hent produkt
            // Putt produkt inn i kundens handlekurv?
        }

        public void Get_item()
        {
            //Forhver item i handlekurv
            //print til consol(item)
        }

    }
}
