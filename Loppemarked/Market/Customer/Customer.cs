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
<<<<<<< HEAD
        public List<IProduct> itemsPurchased { get; set; }

        private Seller seller = MarketPlaceFacade.Sellers[0];
=======
        public List<IProduct> ItemsPurchased { get; set; }
>>>>>>> 17bd88e4567fa3956f996a5a1de1594e3351d027

        public Customer(string name)
        {
            _name = name;
<<<<<<< HEAD
            itemsPurchased = new List<IProduct>();
            Console.WriteLine("Customer: {0}", _name);
=======
            ItemsPurchased = new List<IProduct>();
            Console.WriteLine("Customer: " + _name);
>>>>>>> 17bd88e4567fa3956f996a5a1de1594e3351d027
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
<<<<<<< HEAD
            itemsPurchased.Add(product);
=======
            ItemsPurchased.Add(product);
>>>>>>> 17bd88e4567fa3956f996a5a1de1594e3351d027
            _nrOfItems++;
        }

        public int GetProductsBought()
        {
            return _nrOfItems;
        }

<<<<<<< HEAD
        public string GetItems()
        {
            return "Name: " + itemsPurchased[0].GetName() + ", Condition: " + itemsPurchased[0].GetCondition() + ", Materials: " + itemsPurchased[0].GetMaterial() +  ", From " + seller.GetName() +".";
        }

=======
>>>>>>> 17bd88e4567fa3956f996a5a1de1594e3351d027
    }
}
