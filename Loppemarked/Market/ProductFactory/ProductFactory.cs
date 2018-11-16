using System;
namespace Loppemarked.Market.ProductFactory
{
    public class ProductFactory
    {
<<<<<<< HEAD
        PrintHandler printer = new PrintHandler();

        private static IProduct product { get; set; }
=======
>>>>>>> parent of 66bf72f... Klasser og printer
        public ProductFactory(ProductCategory productCategory){
            
        }

        public static IProduct CreateProduct(int numberOfProducts)
        {

            for (var i = 0; i < numberOfProducts; i++){
                var categoryNumber = Client.rnd.Next(5);
<<<<<<< HEAD
                //Console.WriteLine("\n------------------------------------------------------\n");

=======
>>>>>>> parent of 66bf72f... Klasser og printer
                switch (categoryNumber)
                    {
                    case 0:
                        product = new Garden();
<<<<<<< HEAD
                        
                      //  Console.WriteLine("Category: Garden product");
                      //  Console.WriteLine("Description: " + product.GetName() + " | Condition:" + " " + product.GetCondition()
                                      //    + " | Material:" + " " + product.GetMaterial() + " | Avaliable:" + " " + product.Is_sold() + ".");
                        break;
                    case 1:
                        product = new Kitchen();
                      //  Console.WriteLine("Category: Kitchen product");
                      //  Console.WriteLine("Description: " + product.GetName() + ", Condition:" + " " + product.GetCondition()
                              //            + " | Material:" + " " + product.GetMaterial() + " | Avaliable:" + " " + product.Is_sold() + ".");
=======
                        Console.WriteLine("Description: " + product.GetName() + " | Condition:" + " " + product.GetCondition()
                                          + " | Material:" + " " + product.GetMaterial() + " | Avaliable:" + " " + product.Is_sold() + ".");
                        break;
                    case 1:
                        product = new Kitchen();
                        Console.WriteLine("Description: " + product.GetName() + ", Condition:" + " " + product.GetCondition()
                                          + " | Material:" + " " + product.GetMaterial() + " | Avaliable:" + " " + product.Is_sold() + ".");
>>>>>>> parent of 66bf72f... Klasser og printer
                        break;

                    case 2:
                        product = new LivingRoom();
<<<<<<< HEAD
                      //  Console.WriteLine("Category: Living room product");
                      //  Console.WriteLine("Description: " + product.GetName() + " | Condition:" + " " + product.GetCondition()
                                  //        + " | Material:" + " " + product.GetMaterial() + " | Avaliable:" + " " + product.Is_sold() + ".");
=======
                        Console.WriteLine("Description: " + product.GetName() + " | Condition:" + " " + product.GetCondition()
                                          + " | Material:" + " " + product.GetMaterial() + " | Avaliable:" + " " + product.Is_sold() + ".");
>>>>>>> parent of 66bf72f... Klasser og printer
                        break;

                    case 3:
                        product = new Miscellaneous();
<<<<<<< HEAD
                       // Console.WriteLine("Category: Miscellaneous product");
                       // Console.WriteLine("Description: " + product.GetName() + " | Condition:" + " " + product.GetCondition()
                                //          + " | Material:" + " " + product.GetMaterial() + " | Avaliable:" + " " + product.Is_sold() + ".");
=======
                        Console.WriteLine("Description: " + product.GetName() + " | Condition:" + " " + product.GetCondition()
                                          + " | Material:" + " " + product.GetMaterial() + " | Avaliable:" + " " + product.Is_sold() + ".");
>>>>>>> parent of 66bf72f... Klasser og printer
                        break;

                    case 4:
                        product = new Wearable();
<<<<<<< HEAD
                       // Console.WriteLine("Category: Wearable product");
                       // Console.WriteLine("Description: " + product.GetName() + " | Condition:" + " " + product.GetCondition()
                                     //     + " | Material:" + " " + product.GetMaterial() + " | Avaliable:" + " " + product.Is_sold() + ".");
=======
                        Console.WriteLine("Description: " + product.GetName() + " | Condition:" + " " + product.GetCondition()
                                          + " | Material:" + " " + product.GetMaterial() + " | Avaliable:" + " " + product.Is_sold() + ".");
>>>>>>> parent of 66bf72f... Klasser og printer
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
