<<<<<<< HEAD
﻿using System;
using Loppemarked.Market.Controller;
using Loppemarked.Market.Sale;

=======
using System;
using Loppemarked.Market.Controller;
using Loppemarked.Market.Sale;


>>>>>>> origin/bendik
namespace Loppemarked.Market.ProductFactory
{
    public class Garden : IProduct
    {
        private string _name;
        private string _condition;
        private string _material;
        private string _seller;

        // TODO create a selection of random items in garden category
        public Garden(){
            RandomGardenProduct();
        }

        public void RandomGardenProduct()
        {
            var randomProduct = Client.rnd.Next(4);
            switch (randomProduct)
            {
                case 0:
                    SetName("Bosch lawnmower");
                    SetCondition("Well used");
                    SetMaterial("");
                    break;
                case 1:
                    SetName("Gardena water hose");
                    SetCondition("Slightly used");
                    SetMaterial("Plastic");
                    break;
                case 2:
                    SetName("Brown pot");
                    SetCondition("New");
                    SetMaterial("Clay");
                    break;
                case 3:
                    SetName("Garden chair");
                    SetCondition("used");
                    SetMaterial("Plastic");
                    break;
                default:
                    SetName("No product");
                    SetCondition("0");
                    SetMaterial("0");
                    break;
            }
        }

        public string GetCondition(){
<<<<<<< HEAD
           // Console.WriteLine("Inside Garden.condition method");
=======
>>>>>>> origin/bendik
            return _condition;
        }

        public void SetCondition(string condition){
            _condition = condition;
        }

        public string GetName(){
<<<<<<< HEAD
           // Console.WriteLine("Inside Garden.Name method");
=======
>>>>>>> origin/bendik
            return _name;
        }

        public void SetName(string name){
            _name = name;
        }

        public string GetMaterial(){
<<<<<<< HEAD
          //  Console.WriteLine("Inside Garden.Material method");
=======
>>>>>>> origin/bendik
            return _material;
        }

        public void SetMaterial(string material){
            _material = material;
        }

        public bool Is_sold(){
<<<<<<< HEAD
           // Console.WriteLine("Inside Garden.is_sold method");
=======
>>>>>>> origin/bendik
            return true;
        }

        public string GetSeller()
        {
           var random = new Random();

            var nameTypeValues = Enum.GetValues(typeof(Names));
            var names = (Names) nameTypeValues.GetValue(random.Next(45));
            return names.ToString();
        }
    }
}
