using System;
using System.Collections.Generic;
using System.Configuration;
using System.Net.NetworkInformation;
using System.Security.Cryptography.X509Certificates;
using System.Threading;
using Loppemarked.Market.ProductFactory;
using Loppemarked;
using Loppemarked.Market.Controller;
using Loppemarked.Market.Sale;


namespace Loppemarked.Market
{

    public class MarketPlaceFacade
    {
        private static readonly Object _padLock = new Object();
        private static MarketPlaceFacade _instance { get; set; }
        private bool _marketPlaceIsOpen { get; set; }
        public List<Customer> Customers { get; set; }
        public static List<Seller> Sellers { get; set; }
        public List<Thread> CustomerThreads { get; set; }
        public List<Thread> SellerThreads { get; set; }
        private int _nrOfPeople { get; set; }
        private Names _raNames { get; set; }

        private int _sellerThread { get; set; }
        private int _customerThread { get; set; }
      

        private MarketPlaceFacade()
        {
            Customers = new List<Customer>();
            Sellers = new List<Seller>();
            CustomerThreads = new List<Thread>();
            SellerThreads = new List<Thread>();
            _nrOfPeople = 0;
        }

        public static MarketPlaceFacade Instance
        {
            get
            {
                lock (_padLock)
                {
                    if (_instance == null)
                    {
                        _instance = new MarketPlaceFacade();
                    }

                    return _instance;
                }
            }
        }

        public void Create()
        {
            Array names = Enum.GetValues(typeof(Names));

           // for (var i = 0; i < _nrOfPeople; i++)
           // {
                _raNames = (Names) names.GetValue(Client.rnd.Next(names.Length));
           // }

            IProduct one = ProductFactory.ProductFactory.CreateProduct(2);

          //  ProductCategory str = new ProductCategory();

            AddSeller(_raNames.ToString(), 2, one);
            AddCustomer(_raNames.ToString());
        }


        public void AddSeller(string name, int total, IProduct product)
        {
            Seller seller = new Seller(name, total,product);
            Sellers.Add(seller);
            Thread thread = new Thread(() => seller.AddProduct());
            SellerThreads.Add(thread);
            _nrOfPeople++;
        }

        public void AddCustomer(string name)
        {
            Customer customer = new Customer(name);
            Customers.Add(customer);
            Thread thread = new Thread(() => customer.PurchaseItem());
            CustomerThreads.Add(thread);
            _nrOfPeople++;
        }

        public void Transaction(Customer customer)
        {
            while (_marketPlaceIsOpen)
            {
                lock (_padLock)
                {
                    foreach (var seller in Sellers)
                    {
                        if (seller.ProductAvailable())
                        {
                            seller.Sell(customer);
                        }
                    }
                }
            }
        }

        public void Open()
        {
            Console.WriteLine("__________________________________");
            Console.WriteLine("\nToday's Flea Market sellers: \n");
            _marketPlaceIsOpen = true;
            

            foreach (var thread in SellerThreads)
            {
                thread.Start();
                _sellerThread++;
                Console.WriteLine("Seller thread started. Nr{0}", _sellerThread);
            }

            foreach (var thread in CustomerThreads)
            {
                thread.Start();
                _customerThread++;
                Console.WriteLine("Customer thread started. Nr{0}".PadLeft(Console.WindowWidth), _customerThread);
            }
            CloseMarket();
        }

        public void CloseMarket()
        {
            bool close = false;
            while (!close)
            {
                if (Sellers.Count == 0)
                {
                    Console.WriteLine("There arent any sellers today??");
                    close = true;
                }

                foreach (var thread in SellerThreads)
                {
                    if (thread.IsAlive)
                    {
                        close = false;
                        break;
                    }
                    else
                    {
                        close = true;
                    }
                }

                foreach (var seller in Sellers)
                {
                    if (seller.ProductAvailable())
                    {
                        close = false;
                        break;
                    }
                }

                if (close)
                {
                    Console.WriteLine("Loppa's Flea Market is closed for today!");
                    close = false;
                    break;
                }
            }

            Statistic();
        }

        public void Statistic()
        {
            Console.WriteLine("\n________________________________________________________________");
            Console.WriteLine("\nTransactions Recipte:");
            Console.WriteLine("-----------------------");
            Console.WriteLine("Sellers:");
            foreach (var seller in Sellers)
            {
                Console.WriteLine(seller.GetName());
            }
            Console.WriteLine("-----------------------");
            Console.WriteLine("Customers:");
            foreach (var customer in Customers)
            {
                Console.WriteLine("\n" + customer.GetName() + ": Bought items: " + customer.GetProductsBought());
                for (var i = 0; i < customer.GetProductsBought(); i++)
                {
                    Console.WriteLine(customer.GetItems());

                }
            }
            Console.WriteLine("\n__________________________________________________________________");
        }
    }
}
