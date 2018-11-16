using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using Loppemarked.Market.Sale;

namespace Loppemarked.Market.Controller
{
    class ThreadHandler
    {
        public Thread[] storeThreads { get; set; }
        public List<Customer> customers { get; set; }
        public List<Thread> customerThreads { get; set; }
        public List<Seller> sellers { get; set; }
        public List<Thread> SellerThreads { get; set; }

        public int amountOfCustomers { get; set; }
        public int amountOfSellers { get; set; }

        public Random rnd = new Random();

        private readonly List<string> _nameList = new List<string>();

        public ThreadHandler(int amountOfCustomers, int amountOfSellers)
        {
            this.amountOfCustomers = amountOfCustomers;
            this.amountOfSellers = amountOfSellers;
            customers = new List<Customer>();
            sellers   = new List<Seller>();
            storeThreads = new Thread[4]; //why 4?
        }

        public void startThreads()
        {
            CreateCustomers();
            CreateSellers();
          //  CreateCustomerThreads();
        }
        /*
        private void CreateCustomerThreads()
        {
            for (var i = 0; i < amountOfCustomers - 1; i++)
            {
                var customer = customers[i];
                var thread = new Thread(customer.PurchaseItem);
                customerThreads.Add(thread);
            }
        }
        /*
        private void CreateSellerThreads()
        {
            for (var i = 0; i < amountOfSellers - 1; i++)
            {
                var seller = sellers[i];
                var thread = new Thread(seller.AddProduct());
            }
        } */

        private void CreateSellers()
        {
            for (var i = 0; i < amountOfSellers - 1; i++)
            {
                sellers.Add(AddSeller());
            }
        }

        private void CreateCustomers()
        {
            for (var i = 0; i < amountOfCustomers - 1; i++)
            {
                customers.Add(AddCustomer());
            }
        }

        private Customer AddCustomer()
        {
            var values = Enum.GetValues(typeof(Names));
            var names = values.GetValue(rnd.Next(0, values.Length));
            var nameTaken = false;

            while (!nameTaken)
            {
                if (_nameList.Count != 0)
                {
                    foreach (var name in _nameList)
                    {
                        if (name.Equals(names.ToString()))
                        {
                            nameTaken = true;
                        }
                    }
                }

                if (nameTaken)
                {
                    names = values.GetValue(rnd.Next(values.Length));
                    nameTaken = false;
                }
                else
                {
                    _nameList.Add(names.ToString());
                    return new Customer(names.ToString());
                }
            }
            return null;
        }

        private Seller AddSeller()
        {
            var values = Enum.GetValues(typeof(Names));
            var names = values.GetValue(rnd.Next(0, values.Length));
            var nameTaken = false;

            while (!nameTaken)
            {
                if (_nameList.Count != 0)
                {
                    foreach (var name in _nameList)
                    {
                        if (name.Equals(names.ToString()))
                        {
                            nameTaken = true;
                        }
                    }
                }

                if (nameTaken)
                {
                    names = values.GetValue(rnd.Next(values.Length));
                    nameTaken = false;
                }
                else
                {
                    _nameList.Add(names.ToString());
                    return new Seller(names.ToString());
                }
            }
            return null;
        }
    }

}
