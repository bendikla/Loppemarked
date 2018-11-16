using System;
namespace Loppemarked.Market.ProductFactory
{
    public class ProductFactory
    {
        public ProductFactory(ProductCategory productCategory){
            
        }

        public static IProduct CreateProduct(int numberOfProducts)
        {
            IProduct product = null;

            for (var i = 0; i < numberOfProducts; i++){
                var categoryNumber = Client.rnd.Next(5);
                switch (categoryNumber)
                    {
                    case 0:
                        product = new Garden();
                        Console.WriteLine("Description: " + product.GetName() + " | Condition:" + " " + product.GetCondition()
                                          + " | Material:" + " " + product.GetMaterial() + " | Avaliable:" + " " + product.Is_sold() + ".");
                        break;
                    case 1:
                        product = new Kitchen();
                        Console.WriteLine("Description: " + product.GetName() + ", Condition:" + " " + product.GetCondition()
                                          + " | Material:" + " " + product.GetMaterial() + " | Avaliable:" + " " + product.Is_sold() + ".");
                        break;

                    case 2:
                        product = new LivingRoom();
                        Console.WriteLine("Description: " + product.GetName() + " | Condition:" + " " + product.GetCondition()
                                          + " | Material:" + " " + product.GetMaterial() + " | Avaliable:" + " " + product.Is_sold() + ".");
                        break;

                    case 3:
                        product = new Miscellaneous();
                        Console.WriteLine("Description: " + product.GetName() + " | Condition:" + " " + product.GetCondition()
                                          + " | Material:" + " " + product.GetMaterial() + " | Avaliable:" + " " + product.Is_sold() + ".");
                        break;

                    case 4:
                        product = new Wearable();
                        Console.WriteLine("Description: " + product.GetName() + " | Condition:" + " " + product.GetCondition()
                                          + " | Material:" + " " + product.GetMaterial() + " | Avaliable:" + " " + product.Is_sold() + ".");
                        break;

                    default:
                        break;
                }
            }
            return product;
        }


        public static IProduct CreateProduct(ProductCategory category, int cases){
            IProduct product = null;
            //switch (category)
            switch (cases)
            {
                case 0:
                    product = new Garden();
                    Console.WriteLine("Description: " + product.GetName() + " | Condition:" + " " + product.GetCondition()
                                      + " | Material:" + " " + product.GetMaterial() +" | Avaliable:" + " " + product.Is_sold() + ".");
                    break;
                case 1:
                    product = new Kitchen();
                    Console.WriteLine("Description: " + product.GetName() + " | Condition:" + " " + product.GetCondition()
                                      + " | Material:" + " " + product.GetMaterial() + " | Avaliable:" + " " + product.Is_sold() + ".");
                    break;

                case 2:
                    product = new LivingRoom();
                    Console.WriteLine("Description: " + product.GetName() + " | Condition:" + " " + product.GetCondition()
                                      + " | Material:" + " " + product.GetMaterial() + " | Avaliable:" + " " + product.Is_sold() + ".");
                    break;

                case 3:
                    product = new Miscellaneous();
                    Console.WriteLine("Description: " + product.GetName() + " | Condition:" + " " + product.GetCondition()
                                      + " | Material:" + " " + product.GetMaterial() + " | Avaliable:" + " " + product.Is_sold() + ".");
                    break;

                case 4:
                    product = new Wearable();
                    Console.WriteLine("Description: " + product.GetName() + " | Condition:" + " " + product.GetCondition()
                                      + " | Material:" + " " + product.GetMaterial() + " | Avaliable:" + " " + product.Is_sold() + ".");
                    break;

                default:
                    break;
            }
            return product;
        }
    }
}
