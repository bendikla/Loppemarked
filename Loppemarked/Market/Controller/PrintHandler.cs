using System;
using Loppemarked.Market.ProductFactory;
using Loppemarked.Market.Sale;
using Loppemarked;

namespace Loppemarked.Market.Controller
{
    public class PrintHandler
    {
        
        public PrintHandler()
        {
        }

        public void PrintWelcomeText(){
            PrintSpacing();
            Console.WriteLine("Welcome to Lotta's Flea market");
            PrintSpacing();
            // Console.WriteLine("List of items for sale:");
        }

        public void PrintProduct(IProduct product){
            Console.WriteLine("Testes da Description: " + product.GetName() + " | Condition:" + " " + product.GetCondition()
                                          + " | Material:" + " " + product.GetMaterial() + " | Avaliable:" + " " + product.Is_sold() + ".");
        }

        //TODO write method for seller print
        public void PrintSellerList(){

        }

        // TODO write method for purchase print
        public void PrintCustomerList(){

        }

        public void PrintMarketClose(){
            PrintSpacing();
            Console.WriteLine("All inventory has been sold.");
            PrintSpacing();
        }

        public void ClosingMessage(){
            Console.WriteLine("Loppa's Flea Market is closing for the day!");
        }

        public void PrintSellerNamesHeader(){
            PrintSpacing();
            Console.WriteLine("\nToday's Flea Market sellers: \n");
        }

        public void FailedToOpenMarket(){
            Console.WriteLine("Failed to open market.");
            PrintSpacing();
        }

        public void PrintSpacing(){
            Console.WriteLine("----------------------------------");
        }
    }
}
