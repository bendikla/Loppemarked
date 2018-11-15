using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Loppemarked.Market;
using Loppemarked.Market.ProductFactory;

namespace Loppemarked
{
    // Main class to run the program
    class Program
    {
       

        static void Main(string[] args)
        {
            ProductCategory cat = new ProductCategory();
            MarketPlace market = new MarketPlace(cat);
        }
    }
}
