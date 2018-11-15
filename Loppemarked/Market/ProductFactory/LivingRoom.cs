using Loppemarked.Market.Controller;
using System;
namespace Loppemarked.Market.ProductFactory
{
    public class LivingRoom : IProduct
    {
        private string _name;
        private string _condition;
        private string _material;

        public LivingRoom(){
            RandomLivingRoomProduct();
        }

        public void RandomLivingRoomProduct()
        {
            Random rnd = new Random();
            var randomProduct = rnd.Next(4);
            switch (randomProduct)
            {
                case 0:
                    SetName("Lamp");
                    SetCondition("Well used");
                    SetMaterial("Clay");
                    break;
                case 1:
                    SetName("Barcalounger");
                    SetCondition("Well used");
                    SetMaterial("Leather");
                    break;
                case 2:
                    SetName("Brown pot");
                    SetCondition("New");
                    SetMaterial("Clay");
                    break;
                case 3:
                    SetName("Table 1.5mx4m");
                    SetCondition("used");
                    SetMaterial("Oak");
                    break;
                default:
                    SetName("No item");
                    SetCondition("0");
                    SetMaterial("0");
                    break;
            }
        }

        public string GetCondition()
        {
           // Console.WriteLine("Inside Livingroom.condition method");
            return _condition;
        }

        public void SetCondition(string condition)
        {
            _condition = condition;
        }

        public string GetName()
        {
           // Console.WriteLine("Inside Livingroom.Name method");
            return _name;
        }

        public void SetName(string name)
        {
            _name = name;
        }

        public string GetMaterial()
        {
           // Console.WriteLine("Inside Livingroom.Material method");
            return _material;
        }

        public void SetMaterial(string material)
        {
            _material = material;
        }

        public bool Is_sold()
        {
           // Console.WriteLine("Inside Livingroom.is_sold method");
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
