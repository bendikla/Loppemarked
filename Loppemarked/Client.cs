﻿using Loppemarked.Market.Controller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Loppemarked.Market;
using Loppemarked.Market.ProductFactory;

namespace Loppemarked
{
<<<<<<< HEAD
    class Client
    {
        private ThreadHandler _threadHandler = new ThreadHandler(6, 6);
        public void startMarked()
        {
            Console.WriteLine("----------------------------------");
            Console.WriteLine("Welcome to Lotta's Flea market");
            Console.WriteLine("----------------------------------\n");
            Console.WriteLine("List of items for sale:");

            LivingRoom item = new LivingRoom();
             item.RandomLivingRoomProduct();

            ProductCategory cat = new ProductCategory();


                MarketPlace market = new MarketPlace(cat, 0);
                MarketPlace market2 = new MarketPlace(cat, 1);
                MarketPlace market3 = new MarketPlace(cat, 2);
                MarketPlace market4 = new MarketPlace(cat, 3);
                MarketPlace market5 = new MarketPlace(cat, 4);

            // _threadHandler.startThreads();
            Console.ReadLine();
        }
    }


=======
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
            Console.WriteLine("Press enter to start");

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
>>>>>>> origin/bendik
}
