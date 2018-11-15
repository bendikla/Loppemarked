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

<<<<<<< HEAD
        public MarketPlace(ProductCategory productCategory)
        {
            product = ProductFactory.ProductFactory.CreateProduct(productCategory);
            Console.WriteLine(product.GetName() + ", " + product.GetCondition() + " " + product.GetMaterial());
=======
        public MarketPlace(ProductCategory productCategory, int cases)
        {           
            product = ProductFactory.ProductFactory.CreateProduct(productCategory, cases);

>>>>>>> 5aa0b6ea60388d42464a943ddd191e9e3c165f48
            marketPlaceIsOpen = true;
        }

    }
}
