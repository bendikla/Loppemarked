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
            IProduct one = ProductFactory.ProductFactory.CreateProduct(10);
            marketPlaceIsOpen = true;
        }

        public void CheckToCloseMarket(){
            //TODO check if the market should close and call "CloseMarket()" method.
        }
        public void CloseMarket()
        {
            // TODO 
            // Close the market if all items has been listed and sold. 
            // Go through the seller and customer list for to check if the market is empty. 

        }
    }
}
