using System;
using System.Configuration;
using Loppemarked.Market.ProductFactory;
using Loppemarked;

namespace Loppemarked.Market
{

    public class MarketPlace
    {

        public IProduct product;
        public string name { get; set; }


        public bool marketPlaceIsOpen = false;

        public MarketPlace(ProductCategory productCategory, int cases)
        {
            product = ProductFactory.ProductFactory.CreateProduct(productCategory, cases);
            Console.WriteLine(product.GetName() + ", " + product.GetCondition() + " " + product.GetMaterial());
            Console.WriteLine();
        }

        public MarketPlace(ProductCategory productCategory)
        {
            int randomProduct = Client.rnd.Next(4);
            product = ProductFactory.ProductFactory.CreateProduct((int)productCategory);

            marketPlaceIsOpen = true;
        }
    }
}
