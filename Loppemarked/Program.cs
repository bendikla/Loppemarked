using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;

namespace Loppemarked
{
    // Main class to run the program
    class Program
    {
        
        static void Main(string[] args)
        {


              Console.WriteLine("Velkommen til Lottas Loppemarked");
            Console.WriteLine("For å se varer for salg trykk 1, for å se kjøpshistorikk trykk 2");

            var sllr = new Seller("Gunnar Tjøme");
            sllr.AddProduct("GT Sykkel", "Nesten ødelagt");

            int input = Console.Read();

            if (input == 1)
            {
                var market = new Market();
                //Console.WriteLine(seller.itemForSale.Count);
               // Console.WriteLine("\nHer ha det ikkje kommi noko enda! Prøv igjen i morgen");
                Console.ReadLine();
            }  /*
            else
            {
                Console.WriteLine("\nSiden vi ikkje har fått varar enda, er det heller ingen historikk!");
                Console.ReadLine();
            } */
            Console.ReadLine();
        }
    }
}
