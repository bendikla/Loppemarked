using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Loppemarked
{
    class Seller
    {
        public string name { get; private set; }

        public ConcurrentBag<Item> forSale = new ConcurrentBag<Item>();

        public Seller(string name)
        {
            this.name = name;
        }

        public Seller() { }

        public  void AddProduct(string productName, string condition)
        {
            forSale.Add(new Item(productName, condition, name));
        }

        public void showProducts()
        {

            foreach (var item in forSale)
            {
                Console.WriteLine("For sale: {0}, condition: {1}, sold from {2}", item.itemName, item.itemCondition, item.sellerName);
            }
        }
    }
}
