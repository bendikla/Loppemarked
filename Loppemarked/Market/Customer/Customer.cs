using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting;
using System.Text;
using System.Threading;
using Loppemarked.Market.ProductFactory;

namespace Loppemarked
{
    class Customer 
    {

        private string _name { get; set; }
        private int _nrOfItems { get; set; }
        public List<ProductFactory> itemsPurchesed { get; set; }



        public Customer(string name)
        {
            _name = name;
            itemsPurchesed = new List<ProductFactory>();
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

        public void AddItems(List<ProductFactory> product)
        {
            itemsPurchesed.Add(product[0]);
        }

        public int GetProductsBought()
        {
            return _nrOfItems;
        }

        public void getItems()
        {
            for (var i = 0; i < itemsPurchesed.Count(); i++)
            {
                Console.WriteLine(itemsPurchesed[i]);
            }
        }

    }
}
