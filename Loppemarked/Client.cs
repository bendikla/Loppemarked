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

        private ThreadHandler _threadHandler = new ThreadHandler(6, 6);
        public void StartMarked()
        {
            printer.PrintWelcomeText();
            cat = new ProductCategory();
            market = new MarketPlaceFacade(cat);

            if(market != null){
                //TODO ta vekk kommentering når liste-printingen er fullført.
                //printer.PrintWelcomeText();
            } else{
                printer.FailedToOpenMarket();
            }

           
            if(market.marketPlaceIsOpen == false){
                printer.PrintMarketClose();
            }
            // _threadHandler.startThreads();
            Console.ReadLine();
        }

    }
}
