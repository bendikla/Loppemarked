using System;
using Loppemarked.Market.Controller;
using Loppemarked.Market.Sale;

namespace Loppemarked.Market.ProductFactory
{
    public class Wearable : IProduct
    {
        private string _name;
        private string _condition;
        private string _material;
        private string _sellername;
        private int _nr;

        public Wearable(string sellername){
            RandomWearableProduct(sellername);
        }
        public void RandomWearableProduct(string sellername)
        {
            var randomProduct = Client.rnd.Next(4);
            SetSellerName(sellername);
            SetNr(_nr);
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

        public void SetNr(int nr)
        {
            _nr = nr;
        }

        public int GetNr()
        {
            return _nr;
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

        public void SetSellerName(string name)
        {
            _sellername = name;
        }

        public string GetSellerName()
        {
            return _sellername;
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
