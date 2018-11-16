﻿using System;
using Loppemarked.Market.Controller;

namespace Loppemarked.Market.ProductFactory
{
    public class Miscellaneous : IProduct
    {
        private string _name;
        private string _condition;
        private string _material;

        public Miscellaneous(){
            RandomMiscellaneousProduct();
        }

        public void RandomMiscellaneousProduct()
        {
            var randomProduct = Client.rnd.Next(4);
            switch (randomProduct)
            {
                case 0:
                    SetName("Pocketknife");
                    SetCondition("Well used");
                    SetMaterial("Steel");
                    break;
                case 1:
                    SetName("Fishing rod");
                    SetCondition("Slightly used");
                    SetMaterial("Metall");
                    break;
                case 2:
                    SetName("Skateboard");
                    SetCondition("Used");
                    SetMaterial("Misc");
                    break;
                case 3:
                    SetName("Champions league football");
                    SetCondition("Well kicked");
                    SetMaterial("Rubber");
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
          //  Console.WriteLine("Inside Miscellaneous.condition method");
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
          //  Console.WriteLine("Inside Miscellaneous.Name method");
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
          //  Console.WriteLine("Inside Miscellaneous.Material method");
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
          //  Console.WriteLine("Inside Miscellaneous.is_sold method");
=======
>>>>>>> origin/bendik
            return true;
        }
    }
}
