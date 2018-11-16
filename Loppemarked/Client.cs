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
        ProductCategory cat;
        MarketPlaceFacade market;
        public static readonly Random rnd = new Random();
        PrintHandler printer = new PrintHandler();

       // private ThreadHandler _threadHandler = new ThreadHandler(6, 6);
        public void StartMarked()
        {
            printer.PrintWelcomeText();

            cat = new ProductCategory();
            market = new MarketPlaceFacade(cat);

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
