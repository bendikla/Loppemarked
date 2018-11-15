using System;
namespace Loppemarked.Market.ProductFactory
{
    public class ProductFactory
    {
        public ProductFactory(){
        }

        public static IProduct CreateProduct(ProductCategory category)
        {
            IProduct product = null;
                switch (category)
            {
                case ProductCategory.Garden:
                    product = new Garden();
                    Console.WriteLine("Description: " + product.GetName() + " | Condition:" + " " + product.GetCondition()
                                      + " | Material:" + " " + product.GetMaterial() + " | Avaliable:" + " " + product.Is_sold() + ".");
                    break;
                case ProductCategory.Kitchen:
                    product = new Kitchen();
                    Console.WriteLine("Description: " + product.GetName() + ", Condition:" + " " + product.GetCondition()
                                      + " | Material:" + " " + product.GetMaterial() + " | Avaliable:" + " " + product.Is_sold() + ".");
                    break;

                case ProductCategory.LivingRoom:
                    product = new LivingRoom();
                    Console.WriteLine("Description: " + product.GetName() + " | Condition:" + " " + product.GetCondition()
                                      + " | Material:" + " " + product.GetMaterial() + " | Avaliable:" + " " + product.Is_sold() + ".");
                    break;

                case ProductCategory.Miscellaneous:
                    product = new Miscellaneous();
                    Console.WriteLine("Description: " + product.GetName() + " | Condition:" + " " + product.GetCondition()
                                      + " | Material:" + " " + product.GetMaterial() + " | Avaliable:" + " " + product.Is_sold() + ".");
                    break;

                case ProductCategory.Wearable:
                    product = new Wearable();
                    Console.WriteLine("Description: " + product.GetName() + " | Condition:" + " " + product.GetCondition()
                                      + " | Material:" + " " + product.GetMaterial() + " | Avaliable:" + " " + product.Is_sold() + ".");
                    break;

                default:
                    break;
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

        public void printProduct(ProductCategory category){

        }
    }
}
