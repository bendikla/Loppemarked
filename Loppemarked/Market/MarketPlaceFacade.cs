using System;
using System.Configuration;
using Loppemarked.Market.ProductFactory;
using Loppemarked;

namespace Loppemarked.Market
{

    public class MarketPlaceFacade
    {

        public string name { get; set; }


        public bool marketPlaceIsOpen = false;


        public MarketPlaceFacade(ProductCategory productCategory)
        {
            IProduct one = ProductFactory.ProductFactory.CreateProduct(20);

            marketPlaceIsOpen = true;
        }
    }
}
