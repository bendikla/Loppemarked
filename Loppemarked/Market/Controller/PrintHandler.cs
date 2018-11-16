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
            Console.WriteLine("----------------------------------");
            Console.WriteLine("Welcome to Lotta's Flea market");
            Console.WriteLine("----------------------------------\n");
            Console.WriteLine("List of items for sale:");
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
            Console.WriteLine("----------------------------------");
            Console.WriteLine("All inventory has been sold.");
            Console.WriteLine("----------------------------------");
        }

        public void FailedToOpenMarket(){
            Console.WriteLine("Failed to open market.");
            Console.WriteLine("----------------------------------");
        }
    }
}
