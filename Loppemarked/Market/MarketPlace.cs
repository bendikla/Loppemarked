using System;
using System.Configuration;
using Loppemarked.Market.ProductFactory;


namespace Loppemarked.Market
{

    public class MarketPlace
    {

        public IProduct product;
        public string name { get; set; }


        public bool marketPlaceIsOpen = false;

        public MarketPlace(ProductCategory productCategory)
        {
            product = ProductFactory.ProductFactory.CreateProduct(productCategory);
            Console.WriteLine(product.GetName() + ", " + product.GetCondition() + " " + product.GetMaterial());
            marketPlaceIsOpen = true;
        }

    }
}
