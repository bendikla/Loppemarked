using System;
using System.Collections.Generic;
using Loppemarked.Market;
using Loppemarked.Market.ProductFactory;

namespace Loppemarked
{
    public class Customer 
    {

        private string _name { get; set; }
        private int _nrOfItems { get; set; }
        public List<IProduct> ItemsPurchased { get; set; }

        public Customer(string name)
        {
            _name = name;
            ItemsPurchased = new List<IProduct>();
            Console.WriteLine("Customer: " + _name);
        }
        
        public void PurchaseItem()
        {
            MarketPlaceFacade.Instance.Transaction(this);
        }

        public string GetName()
        {
            return _name;
        }

        public void AddItems(IProduct product)
        {
            ItemsPurchased.Add(product);
            _nrOfItems++;
        }

        public int GetProductsBought()
        {
            return _nrOfItems;
        }

    }
}
