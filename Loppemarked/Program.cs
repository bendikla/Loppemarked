using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;

namespace Loppemarked
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Console.WriteLine("Vælkummen te Lottas Loppemarked");
           // Console.WriteLine("For å sjå varar trykj 1, for å sjå kjøpshistorikk trykj 2");

            var seller = new Seller("a01", "Gunnar Tjøme");
            seller.AddProduct("GT Sykkel", "Nesten ødelagt");

           // int input = Console.Read();

          //  if (input == 1)
           // {
                var market = new Market();
                market.showProducts();
                Console.WriteLine(seller.itemForSale.Count);
               // Console.WriteLine("\nHer ha det ikkje kommi noko enda! Prøv igjen i morgen");
                Console.ReadLine();
         /*   } 
            else
            {
                Console.WriteLine("\nSiden vi ikkje har fått varar enda, er det heller ingen historikk!");
                Console.ReadLine();
            } */
            Console.ReadLine();
        }
    }
}
