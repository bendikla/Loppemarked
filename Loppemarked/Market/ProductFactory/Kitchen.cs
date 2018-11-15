using System;
using Loppemarked.Market.Controller;

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
            var randomProduct = Client.rnd.Next(4);
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
<<<<<<< HEAD
=======
           // Console.WriteLine("Inside Kitchen.condition method");
>>>>>>> 5aa0b6ea60388d42464a943ddd191e9e3c165f48
            return _condition;
        }

        public void SetCondition(string condition)
        {
            _condition = condition;
        }

        public string GetName()
        {
<<<<<<< HEAD
=======
           // Console.WriteLine("Inside Kitchen.Name method");
>>>>>>> 5aa0b6ea60388d42464a943ddd191e9e3c165f48
            return _name;
        }

        public void SetName(string name)
        {
            _name = name;
        }

        public string GetMaterial()
        {
<<<<<<< HEAD
=======
           // Console.WriteLine("Inside Kitchen.Material method");
>>>>>>> 5aa0b6ea60388d42464a943ddd191e9e3c165f48
            return _material;
        }

        public void SetMaterial(string material)
        {
            _material = material;
        }

        public bool Is_sold()
        {
<<<<<<< HEAD
=======
          //  Console.WriteLine("Inside Kitchen.is_sold method");
>>>>>>> 5aa0b6ea60388d42464a943ddd191e9e3c165f48
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