using System;
namespace Loppemarked.Product
{
    public class Wearable
    {
        private string _name;
        private string _condition;
        private string _material;

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
