using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Loppemarked
{
    class Seller
    {
        public string sellerID { get;  private set; }
        public static string sellerName { get; private set; }

        public List<Item> itemForSale = new List<Item>();

        public Seller(string id, string name)
        {
            sellerID = id;
            sellerName = name;
        }

        public Seller()
        {

        }

        public  void AddProduct(string productName, string condition)
        {
            itemForSale.Add(new Item(productName, condition, sellerName));
            //Console.WriteLine(item.itemName);
        }
    }
}
