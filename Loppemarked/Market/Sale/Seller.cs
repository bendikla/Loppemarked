using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using Loppemarked.Market.Customer;
using Loppemarked.Market.ProductFactory;

namespace Loppemarked.Market.Sale
{
    public class Seller : ISellers
    {
        private  string _name { get; set; }
        public string ItemName { get; set; }
        public List<IProduct> _items { get; set; }
        public static int _itemCount { get; set; }
        private int _itemNr { get; set; }
        private IProduct product;
        private int _nrItems { get; set; }
        private bool _isSold { get; set; }
        // TODO Make so seller receives products dønn
        public Seller(string name, int total, IProduct product)
        {
            _name = name;
            _nrItems = total;
            _itemCount = 0;
            _itemNr = 0;
            _items = new List<IProduct>();
            Console.WriteLine("{0} has come with {1} items {2} to the flea market to trade!", _name, total, product.GetName());
            this.product = product;
            _isSold = false;
        }

        public string GetName()
        {
            return _name;
        }

        public  void AddProduct()
        {
            _isSold = true;
            Console.WriteLine("{0} has come to sell some items!", _name);
            
            for (var i = 0; i < _nrItems; i++)
            {
                    _itemCount++;
                    _itemNr++;
                    _items.Add(new ProductSkeleton(product));
                    ItemName = _items[0].GetName();
                    Console.WriteLine("{0} has listed a #{1} {2}\n", _name, _itemNr, _items[0].DisplayProduct());
                    Thread.Sleep(500);
<<<<<<< HEAD
                 //   product.SetNr(_itemNr);
=======
>>>>>>> UnitTesting
            }
            _itemNr = 0;
            Console.WriteLine("{0} has sold out!", _name);
            _isSold = false;

        }

        public void Sell(Customer.Customer customer)
        {
            customer.AddItems(product);
            string transaction = customer.GetName() + " bought item #" + _itemNr+ " " + customer.GetItemName() + "\nFrom: " + _name + "\n";
            Console.WriteLine(transaction.PadLeft(Console.WindowWidth));
            customer.AddTotalItems();
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

        public bool ItemSold()
        {
            return _isSold;
        }
    }
}
