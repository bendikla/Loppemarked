using System;
using System.Collections.Generic;
using System.Threading;
using Loppemarked.Market.ProductFactory;
using Loppemarked.Market.Controller;
using Loppemarked.Market.Customer;
using Loppemarked.Market.Sale;

namespace Loppemarked.Market
{

    public class MarketPlaceFacade
    {
        private static readonly Object _padLock = new Object();
        private static MarketPlaceFacade _instance { get; set; }
        private bool _marketPlaceIsOpen { get; set; }
        public static List<ICustomer> Customers { get; set; }
        public static List<ISellers> Sellers { get; set; }
        public List<Thread> CustomerThreads { get; set; }
        public List<Thread> SellerThreads { get; set; }
        private int _nrOfPeople { get; set; }
        private Names _raNames { get; set; }
        private IAttendantFactory _attendants { get; set; }

      

        private MarketPlaceFacade()
        {
            Customers = new List<ICustomer>();
            Sellers = new List<ISellers>();
            CustomerThreads = new List<Thread>();
            SellerThreads = new List<Thread>();
            //_nrOfPeople = 0;
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
            _attendants = new AttendantFactory();

            Array names = Enum.GetValues(typeof(Names));

            int sellers = 4;
            int customers = 3;

            for (var i = 0; i < sellers; i++)
            {
                
                _raNames = (Names) names.GetValue(Client.rnd.Next(names.Length));
                IProduct one = ProductFactory.ProductFactory.CreateProduct(1, _raNames.ToString());
                AddSeller(_raNames.ToString(), 8, one);
            }
            Console.WriteLine("");
            for(var i = 0; i < customers; i++)
            {
                _raNames = (Names)names.GetValue(Client.rnd.Next(names.Length));
                AddCustomer(_raNames.ToString());
            }
<<<<<<< HEAD
            
            AddCustomer(_raNames.ToString());
            AddCustomer(_raNames.ToString());
            AddCustomer(_raNames.ToString());
            AddCustomer(_raNames.ToString());
=======
>>>>>>> origin/bendik
        }


        public void AddSeller(string name, int total, IProduct product)
        {
            ISellers seller = _attendants.CreateSeller(name, total, product);
            Sellers.Add(seller);
            Thread thread = new Thread(() => seller.AddProduct());
            SellerThreads.Add(thread);
            _nrOfPeople++;
        }

        public void AddCustomer(string name)
        {
            ICustomer customer = _attendants.CreateCustomer(name);
            Customers.Add(customer);
            Thread thread = new Thread(() => customer.PurchaseItem());
            CustomerThreads.Add(thread);
            _nrOfPeople++;
        }

        public void Transaction(Customer.Customer customer)
        {
            while (_marketPlaceIsOpen)
            {
                lock (_padLock)
                {                    
                        foreach(var seller in Sellers) {

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
            
            //Sellers listen itemes for sale
            foreach (var thread in SellerThreads)
            {
                thread.Start();
            }
            //Customers buy items
            foreach (var thread in CustomerThreads)
            {
                thread.Start();
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
                    Console.WriteLine("\nLoppa's Flea Market is closed for today!");
                    _marketPlaceIsOpen = false;
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
                int count = 0;
                Console.WriteLine("\n" + customer.GetName() + ": Bought items: " + customer.GetProductsBought());

                foreach (var item in customer.GetItems())
                {
                    Console.WriteLine("Name: " + item.DisplayProduct() + ", from: " + item.GetSellerName() + " ");
                }
                    
            
                count++;                
            }            
            Console.WriteLine("\n__________________________________________________________________");
        }
    }
}
