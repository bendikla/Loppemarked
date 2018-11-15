using System;
namespace Loppemarked.Market.ProductFactory
{
    public class ProductFactory
    {
        public ProductFactory(){
        }

        public static IProduct CreateProduct(ProductCategory category, int cases){
            IProduct product = null;
//           switch (category)
            switch (cases)
            {
                case 0:
                    product = new Garden();
                    Console.WriteLine("Name: " + product.GetName() + ", Condition:" + " " + product.GetCondition()
                                      + ", Material:" + " " + product.GetMaterial() +", Avaliable:" + " " + product.Is_sold() + ".");
                    break;
                case 1:
                    product = new Kitchen();
                    Console.WriteLine("Name: " + product.GetName() + ", Condition:" + " " + product.GetCondition()
                                      + ", Material:" + " " + product.GetMaterial() + ", Avaliable:" + " " + product.Is_sold() + ".");
                    break;

                case 2:
                    product = new LivingRoom();
                    Console.WriteLine("Name: " + product.GetName() + ", Condition:" + " " + product.GetCondition()
                                      + ", Material:" + " " + product.GetMaterial() + ", Avaliable:" + " " + product.Is_sold() + ".");
                    break;

                case 3:
                    product = new Miscellaneous();
                    Console.WriteLine("Name: " + product.GetName() + ", Condition:" + " " + product.GetCondition()
                                      + ", Material:" + " " + product.GetMaterial() + ", Avaliable:" + " " + product.Is_sold() + ".");
                    break;

                case 4:
                    product = new Wearable();
                    Console.WriteLine("Name: " + product.GetName() + ", Condition:" + " " + product.GetCondition()
                                      + ", Material:" + " " + product.GetMaterial() + ", Avaliable:" + " " + product.Is_sold() + ".");
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
