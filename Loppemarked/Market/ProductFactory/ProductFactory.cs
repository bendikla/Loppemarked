using System;
namespace Loppemarked.Market.ProductFactory
{
    public class ProductFactory
    {
        public ProductFactory(){
        }

        public static IProduct CreateProduct(ProductCategory category){
            IProduct product = null;
            switch (category)
            {
                case ProductCategory.Garden:
                    product = new Garden();
                    Console.WriteLine("Garden product created.");
                    break;
                case ProductCategory.Kitchen:
                    product = new Kitchen();
                    Console.WriteLine("Kitchen product created.");
                    break;
                case ProductCategory.LivingRoom:
                    product = new LivingRoom();
                    Console.WriteLine("Living room product created");
                    break;
                case ProductCategory.Miscellaneous:
                    product = new Miscellaneous();
                    Console.WriteLine("Miscellaneous product created.");
                    break;
                case ProductCategory.Wearable:
                    product = new Wearable();
                    Console.WriteLine("Wearable product created.");
                    break;
            }
            return product;
        }

        public void printProduct(ProductCategory category){

        }
    }
}
