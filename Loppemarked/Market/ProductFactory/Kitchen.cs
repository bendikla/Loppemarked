using System;
namespace Loppemarked.Market.ProductFactory
{
    public class Kitchen : IProduct
    {
        private string _name;
        private string _condition;
        private string _material;

        public Kitchen(){
            RandomKitchenProduct();
        }

        public void RandomKitchenProduct()
        {
            Random rnd = new Random();
            var randomProduct = rnd.Next(4);
            switch (randomProduct)
            {
                case 0:
                    SetName("Mixmaster");
                    SetCondition("Well used");
                    SetMaterial("Plastic and iron");
                    break;
                case 1:
                    SetName("Cutlery set");
                    SetCondition("Used");
                    SetMaterial("Silverware");
                    break;
                case 2:
                    SetName("Stainless steel pan");
                    SetCondition("New");
                    SetMaterial("Steel");
                    break;
                case 3:
                    SetName("Beer glass");
                    SetCondition("Used");
                    SetMaterial("Glass");
                    break;
                default:
                    SetName("No product");
                    SetCondition("0");
                    SetMaterial("0");
                    break;
            }
        }

        public string GetCondition()
        {
           // Console.WriteLine("Inside Kitchen.condition method");
            return _condition;
        }

        public void SetCondition(string condition)
        {
            _condition = condition;
        }

        public string GetName()
        {
           // Console.WriteLine("Inside Kitchen.Name method");
            return _name;
        }

        public void SetName(string name)
        {
            _name = name;
        }

        public string GetMaterial()
        {
           // Console.WriteLine("Inside Kitchen.Material method");
            return _material;
        }

        public void SetMaterial(string material)
        {
            _material = material;
        }

        public bool Is_sold()
        {
          //  Console.WriteLine("Inside Kitchen.is_sold method");
            return true;
        }

        public string GetSeller()
        {
            var random = new Random();

            var nameTypeValues = Enum.GetValues(typeof(Names));
            var names = (Names)nameTypeValues.GetValue(random.Next(45));
            return names.ToString();
        }
    }
}