using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting;
using System.Text;
using System.Threading;
using Loppemarked.Market.ProductFactory;

namespace Loppemarked
{
    public class Customer 
    {

        private string _name { get; set; }
        private int _nrOfItems { get; set; }
        public List<IProduct> itemsPurchesed { get; set; }



        public Customer(string name)
        {
            _name = name;
            itemsPurchesed = new List<IProduct>();
            Console.WriteLine("Customer: " + _name);
        }
        
        public void PurchaseItem()
        {
            Market.MarketPlaceFacade.Instance.Transaction(this);
        }

        public string GetName()
        {
            return _name;
        }

        public void AddItems(IProduct product)
        {
            itemsPurchesed.Add(product);
            _nrOfItems++;
        }

        public int GetProductsBought()
        {
            return _nrOfItems;
        }

        public string GetItems()
        {
            return "Name: " + itemsPurchesed[0].GetName() + ", Condition: " + itemsPurchesed[0].GetCondition() + ", Materials: " + itemsPurchesed[0].GetMaterial() + ".";
        }

    }
}
