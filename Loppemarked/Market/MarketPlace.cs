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
            for (int i = 0; i < 10; i++){
            product = ProductFactory.ProductFactory.CreateProduct(productCategory);
            }

            marketPlaceIsOpen = true;
        }

    }
}
