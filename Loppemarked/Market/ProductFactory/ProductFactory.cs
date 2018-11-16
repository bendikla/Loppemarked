using System;
using Loppemarked.Market.Controller;

namespace Loppemarked.Market.ProductFactory
{
    public class ProductFactory
    {
        PrintHandler printer = new PrintHandler();
        public ProductFactory(ProductCategory productCategory){
            
        }

        public static IProduct CreateProduct(int numberOfProducts)
        {
            IProduct product = null;

            for (var i = 0; i < numberOfProducts; i++){
                var categoryNumber = Client.rnd.Next(5);
                Console.WriteLine("\n------------------------------------------------------\n");

                switch (categoryNumber)
                    {
                    case 0:
                        product = new Garden();
                        Console.WriteLine("Category: Garden product");
                        Console.WriteLine("Description: " + product.GetName() + " | Condition:" + " " + product.GetCondition()
                                          + " | Material:" + " " + product.GetMaterial() + " | Avaliable:" + " " + product.Is_sold() + ".");
                        break;
                    case 1:
                        product = new Kitchen();
                        Console.WriteLine("Category: Kitchen product");
                        Console.WriteLine("Description: " + product.GetName() + ", Condition:" + " " + product.GetCondition()
                                          + " | Material:" + " " + product.GetMaterial() + " | Avaliable:" + " " + product.Is_sold() + ".");
                        break;

                    case 2:
                        product = new LivingRoom();
                        Console.WriteLine("Category: Living room product");
                        Console.WriteLine("Description: " + product.GetName() + " | Condition:" + " " + product.GetCondition()
                                          + " | Material:" + " " + product.GetMaterial() + " | Avaliable:" + " " + product.Is_sold() + ".");
                        break;

                    case 3:
                        product = new Miscellaneous();
                        Console.WriteLine("Category: Miscellaneous product");
                        Console.WriteLine("Description: " + product.GetName() + " | Condition:" + " " + product.GetCondition()
                                          + " | Material:" + " " + product.GetMaterial() + " | Avaliable:" + " " + product.Is_sold() + ".");
                        break;

                    case 4:
                        product = new Wearable();
                        Console.WriteLine("Category: Wearable product");
                        Console.WriteLine("Description: " + product.GetName() + " | Condition:" + " " + product.GetCondition()
                                          + " | Material:" + " " + product.GetMaterial() + " | Avaliable:" + " " + product.Is_sold() + ".");
                        break;

                    default:
                        break;
                }
            }
            return product;
        }
    }
}
