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
            Console.WriteLine("{0} has come to the flea market to trade!", _name);
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
            Console.WriteLine("{0} has come to sell some items!\n", _name);
            for (var i = 0; i < _nrItems; i++)
            {   
                    _items.Add(product);
                Console.WriteLine("{0} has {1} for sale!", _name, _items[0].GetName());
                    Thread.Sleep(500);
            }
            
            Console.WriteLine("{0} has sold out!", _name);
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
