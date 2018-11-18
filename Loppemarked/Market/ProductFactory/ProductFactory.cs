using System;
using Loppemarked.Market.Controller;

namespace Loppemarked.Market.ProductFactory
{
    public class ProductFactory
    {
        PrintHandler printer = new PrintHandler();

        private static IProduct product { get; set; }
        public ProductFactory(ProductCategory productCategory){
            
        }

        public static IProduct CreateProduct(int numberOfProducts, string sellername)
        {

            for (var i = 0; i < numberOfProducts; i++){
                var categoryNumber = Client.rnd.Next(5);
                //Console.WriteLine("\n------------------------------------------------------\n");

                switch (categoryNumber)
                    {
                    case 0:
<<<<<<< HEAD
                        product = new Garden();
                        
                      //  Console.WriteLine("Category: Garden product");
                      //  Console.WriteLine("Description: " + product.GetName() + " | Condition:" + " " + product.GetCondition()
                                      //    + " | Material:" + " " + product.GetMaterial() + " | Avaliable:" + " " + product.Is_sold() + ".");
                        break;
                    case 1:
                        product = new Kitchen();
                      //  Console.WriteLine("Category: Kitchen product");
                      //  Console.WriteLine("Description: " + product.GetName() + ", Condition:" + " " + product.GetCondition()
                              //            + " | Material:" + " " + product.GetMaterial() + " | Avaliable:" + " " + product.Is_sold() + ".");
                        break;

                    case 2:
                        product = new LivingRoom();
                      //  Console.WriteLine("Category: Living room product");
                      //  Console.WriteLine("Description: " + product.GetName() + " | Condition:" + " " + product.GetCondition()
                                  //        + " | Material:" + " " + product.GetMaterial() + " | Avaliable:" + " " + product.Is_sold() + ".");
                        break;

                    case 3:
                        product = new Miscellaneous();
                       // Console.WriteLine("Category: Miscellaneous product");
                       // Console.WriteLine("Description: " + product.GetName() + " | Condition:" + " " + product.GetCondition()
                                //          + " | Material:" + " " + product.GetMaterial() + " | Avaliable:" + " " + product.Is_sold() + ".");
                        break;

                    case 4:
                        product = new Wearable();
                       // Console.WriteLine("Category: Wearable product");
                       // Console.WriteLine("Description: " + product.GetName() + " | Condition:" + " " + product.GetCondition()
                                     //     + " | Material:" + " " + product.GetMaterial() + " | Avaliable:" + " " + product.Is_sold() + ".");
=======
                        product = new Garden(sellername);
                        break;
                    case 1:
                        product = new Kitchen(sellername);
                        break;

                    case 2:
                        product = new LivingRoom(sellername);
                        break;

                    case 3:
                        product = new Miscellaneous(sellername);
                        break;

                    case 4:
                        product = new Wearable(sellername);
>>>>>>> 5ec652ced8b3522e14c5fce8cad0baf7435b09a5
                        break;

                    default:
                        break;
                }
            }
            return product;
        }
    }

    public class ProductSkeleton : IProduct
    {
        public string Item { get; set; }
        public string Condition { get; set; }
        public string Materials { get; set; }
        public string Seller { get; set; }
        public bool Available { get; set; }
        public int Nr { get; set; }

        public ProductSkeleton(IProduct product)
        {
            Item = product.GetName();
            Condition = product.GetCondition();
            Materials = product.GetMaterial();
            Seller = product.GetSellerName();
            Available = product.Is_sold();
        }

        public void SetNr(int nr)
        {
            Nr = nr;
        }

        public int GetNr()
        {
            return Nr;
        }

        public bool Is_sold()
        {
            return Available;
        }

        public string GetName()
        {
            return Item;
        }

        public string GetSellerName()
        {
            return Seller;
        }

        public string GetMaterial()
        {
            return Materials;
        }

        public string GetCondition()
        {
            return Condition;
        }

        public string DisplayProduct()
        {
            return Item + ", Condition: " + Condition + ", Materials: " + Materials + ", From: " + Seller;
        }
    }
}
