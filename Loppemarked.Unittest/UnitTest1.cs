using NUnit.Framework;
using Loppeoppemarked.Loppemarked;
using Loppemarked.Market.ProductFactory;


namespace Loppeoppemarked.Loppemarked.Unittest
{
    [TestFixture]
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        

        [Test]
        public void CreateProduct_Garden_CheckNames()
        {
            IProduct product = new Garden();


            bool result = false;

            string name = product.GetName();
            if (name == "Bosh lawnmower" || name == "Gardena water hose" || name == "Brown pot" || name == "Garden chair")
            {
                result = true;
            }
            else
            {
                result = false;
            }

            Assert.IsTrue(result);
        
        }
        [Test]
        public void ProductFactory_CreateProduct_CheckForRightType()
        {
            

            IProduct obj = ProductFactory.CreateProduct(1);

            IProduct garden = new Garden();
            IProduct kitchen = new Kitchen();
            IProduct Wearable = new Wearable();
            IProduct Miscellaneous = new Miscellaneous();
            IProduct LivingRoom = new LivingRoom();

            

            Assert.Multiple(() =>
            {

                Assert.That(obj, Is.TypeOf<Garden>());
                Assert.That(obj, Is.TypeOf<Kitchen>());
                Assert.That(obj, Is.TypeOf<Wearable>());
                Assert.That(obj, Is.TypeOf<Miscellaneous>());
                Assert.That(obj, Is.TypeOf<LivingRoom>());
            });

        }
    }
    
}