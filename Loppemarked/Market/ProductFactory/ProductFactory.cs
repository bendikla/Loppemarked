using Loppemarked.Market.Controller;

namespace Loppemarked.Market.ProductFactory
{
    public class ProductFactory
    {
        readonly PrintHandler printer = new PrintHandler();

        private static IProduct product { get; set; }        

        public static IProduct CreateProduct(int numberOfProducts)
        {

            for (var i = 0; i < numberOfProducts; i++){
                 var categoryNumber = Client.rnd.Next(5);

                 switch (categoryNumber)
                 {
                    case 0:
                        product = new Garden();
                        break;
                    case 1:
                        product = new Kitchen();
                        break;

                    case 2:
                        product = new LivingRoom();
                        break;

                    case 3:
                        product = new Miscellaneous();
                        break;

                    case 4:
                        product = new Wearable();
                        break;

                    default:
                        break;
                }
            }
            return product;
        }
    }
}
