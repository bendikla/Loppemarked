using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using Loppemarked.Market.ProductFactory;

namespace Loppemarked.Market.Sale
{
    public class Seller
    {
        private  string _name { get; set; }
        public string ItemName { get; set; }
        public List<IProduct> _items { get; set; }

        private IProduct product;
        private int _nrItems { get; set; }
        private bool _isSold { get; set; }
        // TODO Make so seller receives products dønn
        public Seller(string name, int total, IProduct product)
        {
            _name = name;
            _nrItems = total;
            _items = new List<IProduct>();
            Console.WriteLine(_name + " have come to the flea market to trade!");
            this.product = product;
        }

        public string GetName()
        {
            return _name;
        }

        public  void AddProduct()
        {
            _isSold = true;
            Console.WriteLine(_name + " have come to sell some items!");
            for (var i = 0; i < _nrItems; i++)
            {

                    _items.Add(product);
                    ItemName = _items[i].GetName();
                    Console.WriteLine(_name + " have a " + _items[i].DisplayProduct() + " for sale!\n");
                    Thread.Sleep(200);
            }
            
            Console.WriteLine(_name + " has sold out!");
            _isSold = false;
        }

        public void Sell(Customer customer)
        {          
                       for(int i = 0; i < _items.Count; i++)
                       {
                           string str = customer.GetName() + " bought item# " + _items[i].GetName() + " from " + _name;
                           customer.AddItems(_items[i]);
                           Console.WriteLine(str.PadLeft(Console.WindowWidth));
                           _items.RemoveAt(i);
                       }
                        
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
