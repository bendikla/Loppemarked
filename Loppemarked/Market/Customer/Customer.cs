using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting;
using System.Text;
using System.Threading;
using Loppemarked.Market;
using Loppemarked.Market.ProductFactory;
using Loppemarked.Market.Sale;

namespace Loppemarked
{
    public class Customer 
    {

        private string _name { get; set; }
        private int _nrOfItems { get; set; }
        public List<IProduct> itemsPurchased { get; set; }

        private Seller seller = MarketPlaceFacade.Sellers[0];

        public Customer(string name)
        {
            _name = name;
            itemsPurchased = new List<IProduct>();
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
            itemsPurchased.Add(product);
            _nrOfItems++;
        }

        public int GetProductsBought()
        {
            return _nrOfItems;
        }

        public string GetItems()
        {
            return "Name: " + itemsPurchased[0].GetName() + ", Condition: " + itemsPurchased[0].GetCondition() + ", Materials: " + itemsPurchased[0].GetMaterial() +  ", From " + seller.GetName() +".";
        }

    }
}
