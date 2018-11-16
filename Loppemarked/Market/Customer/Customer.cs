using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting;
using System.Text;
using System.Threading;
using Loppemarked.Market.ProductFactory;

namespace Loppemarked
{
    class Customer 
    {

        public string customerName { get; set; }
        public List<string> itemsPurchesed { get; set; }



        public Customer(string name)
        {
            customerName = name;
            itemsPurchesed = new List<string>();
        }
        /*
        public void PurchaseItem()
        {
            var productBought = ProductFactory.CreateProduct(ProductCategory.LivingRoom);
            if (productBought != null)
            {
                itemsPurchesed.Add(productBought.ToString());
                Thread.Sleep(1000);
            }
            else
            {
                Thread.CurrentThread.Join();
            }
        } */

        public void Get_items()
        {
            foreach (var item in itemsPurchesed)
            {
                Console.WriteLine(item);
            }
        }

    }
}
