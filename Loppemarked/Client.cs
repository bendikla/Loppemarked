using Loppemarked.Market.Controller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Loppemarked.Market;
using Loppemarked.Market.ProductFactory;

namespace Loppemarked
{
    class Client
    {
        public static readonly Random rnd = new Random();

        private ThreadHandler _threadHandler = new ThreadHandler(6, 6);
        public void StartMarked()
        {
            Console.WriteLine("----------------------------------");
            Console.WriteLine("Welcome to Lotta's Flea market");
            Console.WriteLine("----------------------------------\n");
            Console.WriteLine("List of items for sale:");

            /*
            LivingRoom item = new LivingRoom();
            item.RandomLivingRoomProduct();*/

            ProductCategory cat = new ProductCategory();

            // TODO - Skal vi har ett marked med flere kunder som får tilegnet produkter?

            MarketPlace market = new MarketPlace(cat);

            /*MarketPlace market = new MarketPlace(cat, 0);
            MarketPlace market2 = new MarketPlace(cat, 1);
            MarketPlace market3 = new MarketPlace(cat, 2);
            MarketPlace market4 = new MarketPlace(cat, 3);
            MarketPlace market5 = new MarketPlace(cat, 4);*/

            // _threadHandler.startThreads();
            Console.ReadLine();
        }

        public void CloseMarket(){
            // TODO 
            // Close the market if all items has been listed and sold. 
            // Go through the seller and customer list for to check if the market is empty. 

        }
    }
}
