using System;
namespace Loppemarked.Product
{
    public class Wearable
    {
        private string _name;
        private string _condition;
        private string _material;

        public Wearable(){
            RandomWearableProduct();
        }
        public void RandomWearableProduct()
        {
            Random rnd = new Random();
            var randomProduct = rnd.Next(4);
            switch (randomProduct)
            {
                case 0:
                    SetName("Mens jeans");
                    SetCondition("Well worn");
                    SetMaterial("Denim");
                    break;
                case 1:
                    SetName("Brown cardigan");
                    SetCondition("New");
                    SetMaterial("Wool");
                    break;
                case 2:
                    SetName("Polo shirt");
                    SetCondition("Used");
                    SetMaterial("Polyester");
                    break;
                case 3:
                    SetName("American flag boxer shorts");
                    SetCondition("Well worn");
                    SetMaterial("Wool");
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
            Console.WriteLine("Inside Wearable.condition method");
            return _condition;
        }

        public void SetCondition(string condition)
        {
            _condition = condition;
        }

        public string GetName()
        {
            Console.WriteLine("Inside Wearable.Name method");
            return _name;
        }

        public void SetName(string name)
        {
            _name = name;
        }

        public string GetMaterial()
        {
            Console.WriteLine("Inside Wearable.Material method");
            return _material;
        }

        public void SetMaterial(string material)
        {
            _material = material;
        }

        public bool Is_sold()
        {
            Console.WriteLine("Inside Wearable.is_sold method");
            return true;
        }
    }
}
