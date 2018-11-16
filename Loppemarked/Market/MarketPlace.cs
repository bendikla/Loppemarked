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

        public MarketPlace(ProductCategory productCategory, int cases)
        {           
            product = ProductFactory.ProductFactory.CreateProduct(productCategory, cases);

            marketPlaceIsOpen = true;
        }

    }
}
