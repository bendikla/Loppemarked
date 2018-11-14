using System;
namespace Loppemarked.Product
{
    public class Miscellaneous
    {
        private string _name;
        private string _condition;
        private string _material;

        public string GetCondition()
        {
            Console.WriteLine("Inside Miscellaneous.condition method");
            return _condition;
        }

        public void SetCondition(string condition)
        {
            _condition = condition;
        }

        public string GetName()
        {
            Console.WriteLine("Inside Miscellaneous.Name method");
            return _name;
        }

        public void SetName(string name)
        {
            _name = name;
        }

        public string GetMaterial()
        {
            Console.WriteLine("Inside Miscellaneous.Material method");
            return _material;
        }

        public void SetMaterial(string material)
        {
            _material = material;
        }

        public bool Is_sold()
        {
            Console.WriteLine("Inside Miscellaneous.is_sold method");
            return true;
        }
    }
}
