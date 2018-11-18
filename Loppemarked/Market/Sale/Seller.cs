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
        private List<IProduct> _itemcopy { get; set; }
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
            _itemcopy = new List<IProduct>();
            Console.WriteLine(_name + " have come " + "with: " +"#" + total + " " + product.GetName() +" to the flea market to trade!");
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
            Console.WriteLine(_name + " have come to sell some items!");
            
            for (var i = 0; i < _nrItems; i++)
            {
                    _itemCount++;
                    _itemNr++;
                    _items.Add(new ProductSkeleton(product));
                    ItemName = _items[0].GetName();
                    Console.WriteLine(_name + " have a #" + _itemNr + " " + _items[0].DisplayProduct() + " for sale!\n");
                    Thread.Sleep(500);
                    product.SetNr(_itemNr);
            }
            _itemNr = 0;
            Console.WriteLine(_name + " has sold out!");
            _isSold = false;

        }

        public void Sell(Customer.Customer customer)
        {

                customer.AddItems(product);
                string transaction = customer.GetName() + " bought item#" + _itemNr+ " " + customer.GetItemName() + " from " + _name;
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
