using System;
using Loppemarked.Market.Controller;
using Loppemarked.Market.Sale;

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
            return _condition;
        }

        public void SetCondition(string condition)
        {
            _condition = condition;
        }

        public string GetName()
        {
            return _name;
        }

        public void SetName(string name)
        {
            _name = name;
        }

        public string GetMaterial()
        {
            return _material;
        }

        public void SetMaterial(string material)
        {
            _material = material;
        }

        public bool Is_sold()
        {
            return true;
        }

        public string GetSeller(Seller seller)
        {
            return seller.GetName();

        }
    }
}