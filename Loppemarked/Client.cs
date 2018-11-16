using Loppemarked.Market.Controller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Loppemarked.Market;
using Loppemarked.Market.ProductFactory;

namespace Loppemarked
{
     public static class Client
    {
      //  ProductCategory cat;
       // MarketPlaceFacade market;
        public static readonly Random rnd = new Random();
        // private ThreadHandler _threadHandler = new ThreadHandler(6, 6);
        public static void StartMarked()
        {
            PrintHandler printer = new PrintHandler();
            printer.PrintWelcomeText();
            //printer.PrintProduct();
           // market = new MarketPlaceFacade(cat);
            MarketPlaceFacade.Instance.Create();
            Console.WriteLine("\nPress enter to start");

            while(Console.ReadKey().Key != ConsoleKey.Enter) { }
            MarketPlaceFacade.Instance.Open();

/*
            if (market != null){
                //TODO ta vekk kommentering når liste-printingen er fullført.
                //printer.PrintWelcomeText();
            } else{
                printer.FailedToOpenMarket();
            }

           
         //   if(market.marketPlaceIsOpen == false){
         //       printer.PrintMarketClose();
         //   }
            // _threadHandler.startThreads();
            Console.ReadLine(); */
        }
        public static void Exit()
        {
            Console.WriteLine("Press space to exit flea market");
            while (Console.ReadKey().Key != ConsoleKey.Spacebar) { }
            Environment.Exit(0);
        }

    }
}
