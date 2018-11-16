﻿using System;
using Loppemarked.Market.Controller;

namespace Loppemarked.Market.ProductFactory
{
    public class Wearable : IProduct
    {
        private string _name;
        private string _condition;
        private string _material;

        public Wearable(){
            RandomWearableProduct();
        }
        public void RandomWearableProduct()
        {
            var randomProduct = Client.rnd.Next(4);
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
<<<<<<< HEAD
           // Console.WriteLine("Inside Wearable.condition method");
=======
>>>>>>> origin/bendik
            return _condition;
        }

        public void SetCondition(string condition)
        {
            _condition = condition;
        }

        public string GetName()
        {
<<<<<<< HEAD
           // Console.WriteLine("Inside Wearable.Name method");
=======
>>>>>>> origin/bendik
            return _name;
        }

        public void SetName(string name)
        {
            _name = name;
        }

        public string GetMaterial()
        {
<<<<<<< HEAD
          //  Console.WriteLine("Inside Wearable.Material method");
=======
>>>>>>> origin/bendik
            return _material;
        }

        public void SetMaterial(string material)
        {
            _material = material;
        }

        public bool Is_sold()
        {
<<<<<<< HEAD
          //  Console.WriteLine("Inside Wearable.is_sold method");
=======
>>>>>>> origin/bendik
            return true;
        }
    }
}
