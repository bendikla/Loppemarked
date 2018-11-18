using System;
using System.Collections.Generic;
<<<<<<< HEAD
using System.Linq;
using System.Runtime.Remoting;
using System.Text;
using System.Threading;
using Loppemarked.Market;
=======
>>>>>>> 5ec652ced8b3522e14c5fce8cad0baf7435b09a5
using Loppemarked.Market.ProductFactory;
using Loppemarked.Market.Sale;

namespace Loppemarked.Market.Customer
{
    public class Customer : ICustomer
    {

        private string _name { get; set; }
        private int _nrOfItems { get; set; }
<<<<<<< HEAD
        public List<IProduct> itemsPurchased { get; set; }

        private Seller seller = MarketPlaceFacade.Sellers[0];
=======
        private string _itemName { get; set; }
        private string _sellerName { get; set; }
        public List<IProduct> ItemsPurchased { get; set; }
>>>>>>> 5ec652ced8b3522e14c5fce8cad0baf7435b09a5

        public Customer(string name)
        {
            _name = name;
            itemsPurchased = new List<IProduct>();
            Console.WriteLine("Customer: " + _name);
        }
        
        public void PurchaseItem()
        {
<<<<<<< HEAD
            Market.MarketPlaceFacade.Instance.Transaction(this);
=======
            List<ICustomer> cuz = new List<ICustomer>(MarketPlaceFacade.Customers);

            int random = Client.rnd.Next(cuz.Count);
            
            MarketPlaceFacade.Instance.Transaction(this);
>>>>>>> 5ec652ced8b3522e14c5fce8cad0baf7435b09a5
        }

        public string GetName()
        {
            return _name;
        }

  

        public List<IProduct> GetItems()
        {
            return ItemsPurchased;
        }

        public string GetItemName()
        {
            return _itemName;
        }

        public void AddItems(IProduct product)
        {
<<<<<<< HEAD
            itemsPurchased.Add(product);
            _nrOfItems++;
=======
            ItemsPurchased.Add(product);
            _itemName = product.GetName();
            _sellerName = product.GetSellerName();
>>>>>>> 5ec652ced8b3522e14c5fce8cad0baf7435b09a5
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
        public void AddTotalItems()
        {
            _nrOfItems++;
        }
>>>>>>> 5ec652ced8b3522e14c5fce8cad0baf7435b09a5
    }
}
