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
        private  string _name { get; set; }
        private string _itemName { get; set; }
        private List<IProduct> _items { get; set; }
        private IProduct product;
        private int _nrItems { get; set; }
        private bool _isSold { get; set; }
        // TODO Make so seller receives products
        private int _count { get; set; }

        public Seller(string name, int total, IProduct product)
        {
            _name = name;
            _nrItems = total;
            _items = new List<IProduct>();
            Console.WriteLine(_name + " have come to the flea market to trade!");
            this.product = product;
            _count = 0;
        }

        public string GetName()
        {
            return _name;
        }

        public  void AddProduct()
        {
            _isSold = true;
            Console.WriteLine(_name + " have come to sell some items!\n");
            for (var i = 0; i < _nrItems; i++)
            {   
                    _items.Add(product);
                    Console.WriteLine(_name + " have " + _items[0].GetName() + " for sale!");
                    Thread.Sleep(500);
            }
            
            Console.WriteLine(_name + " has sold out!");
            _isSold = false;
        }

        public void Sell(Customer customer)
        {
            for (var i = 0; i <= _count; i++)
            {
                string str = customer.GetName() + " bought item# " + _items[i].GetName() + " from " + _name;
                customer.AddItems(_items[i]);
                Console.WriteLine(str.PadLeft(Console.WindowWidth));
                _items.RemoveAt(i);
            }
            _count++;
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
