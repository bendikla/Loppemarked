using System;
using System.Collections.Generic;
using System.Threading;
using Loppemarked.Market.ProductFactory;

namespace Loppemarked.Market
{
    public class Market
    {
        public IProduct product;

        public Product(ProductCategory productCategory)
        {
            ProductFactory.ProductFactory.CreateProduct(productCategory);
        }

        /*
         * class Store
        {

            public IShop Shop;
            public Backroom Backroom { get; set; }
            public bool StoreIsOpen { get; private set; }
            public string Name { get; set; }
            public int Quota { get; set; }
            public List<IStatue> ProductsForSale { get; private set; }
            public List<IStatue> ProductsSold { get; private set; }
            private readonly object _syncLock = new object();


            public Store(int quota, ShopType typeOfShop)
            {
                Quota = quota;
                Shop = ShopFactory.ShopFactory.CreateShop(typeOfShop);
                Name = Shop.GetName();
                Backroom = new Backroom();
                ProductsForSale = Backroom.CreateMultipleStatues(5);
                ProductsSold = new List<IStatue>();
                StoreIsOpen = true;
            }


            private void RecieveProductsForSaleFromBackroom(int numberOfDecorations)
            {
                if (ProductsForSale.Count + ProductsSold.Count < Quota)
                {
                    var result = Backroom.CreateProduct(numberOfDecorations);
                    ProductsForSale.Add(result);
                }
            }


            public void CheckIfStoreShouldClose()
            {
                lock (_syncLock)
                {
                    if (StoreIsOpen)
                    {
                        if (ProductsSold.Count == Quota)
                        {
                            StoreIsOpen = false;
                        }
                    }
                }
            }


            public void FillProducts()
            {
                while (StoreIsOpen)
                {
                    CheckIfStoreShouldClose();
                    RecieveProductsForSaleFromBackroom(Client.Rnd.Next(1, 10));
                    Thread.Sleep(1000);
                }
                Thread.CurrentThread.Join();
            }


            public IStatue SellProduct(int socialSecurityNumber, string name)
            {
                var bank = Bank.BankFlyweight.BankFactory.GetBank("DNB");
                lock (ProductsForSale)
                    lock (ProductsSold)
                    {
                        CheckIfStoreShouldClose();
                        if (StoreIsOpen && ProductsForSale.Count > 0)
                        {
                            var product = ProductsForSale[0];
                            var price = product.GetPrice();
                            if (bank.Transaction(price, socialSecurityNumber))
                            {
                                ProductsSold.Add(product);
                                ProductsForSale.Remove(product);
                                CheckIfStoreShouldClose();
                                Console.WriteLine("Following product was sold to {0} for {1} kr from {2}.{3}{4}{5}", name,
                                    price, Name, System.Environment.NewLine, Client.PrintProduct.SortAndRetrieveProductDescription(product),
                                    System.Environment.NewLine);
                                return product;
                            }
                            Console.WriteLine("{0} tried to buy a product at {1} for {2} kr. Withdrawal rejected. Insufficient funds.{3}", name, Name, price, System.Environment.NewLine);
                        }
                    }
                return null;
            }


            public void PrintDailyRevenue()
            {
                var sumOfDay = 0.0;
                var amountOfProducts = 0;
                foreach (var product in ProductsSold)
                {
                    amountOfProducts++;
                    sumOfDay += product.GetPrice();
                }
                Console.WriteLine("Store {0} is now closed. {1} products were sold, quota of the day was {2} and generated {3} kr.", Name, amountOfProducts, Quota, sumOfDay);
            }
        }*/
    }
}
