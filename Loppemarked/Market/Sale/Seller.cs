using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using Loppemarked.Market.ProductFactory;

namespace Loppemarked.Market.Sale
{
    public class Seller
    {
        private string _name { get; set; }
        private string _itemName { get; set; }
        private List<IProduct> _items { get; set; }
        private IProduct product;
        private int _nrItems { get; set; }
        private bool _isSold { get; set; }
        // TODO Make so seller receives products
        //public ConcurrentBag<Item> forSale = new ConcurrentBag<Item>();

        public Seller(string name, int total, IProduct product)
        {
            _name = name;
            _nrItems = total;
            _items = new List<IProduct>();
            Console.WriteLine(_name + "Have come to the flea market to trade!");
            this.product = product;
        }

        public string GetName()
        {
            return _name;
        }

        public  void AddProduct()
        {
            _isSold = true;
            Console.WriteLine(_name + " have come to sell: " + _items[0].ToString());
            for (var i = 0; i < _nrItems; i++)
            {
                _items.Add(product);
                Thread.Sleep(500);
            }
            Console.WriteLine(_name + " has sold out!");
            _isSold = false;
        }

        public void Sell(Customer customer)
        {
            string str = customer.GetName() + "bought item#" + _items[0].ToString() + " from " + _name;
            customer.AddItems(_items[0]);
            Console.WriteLine(str.PadLeft(Console.WindowWidth));
            _items.RemoveAt(0);
        }

        

        public bool ProductAvailable()
        {
            if (_items.Count() > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
