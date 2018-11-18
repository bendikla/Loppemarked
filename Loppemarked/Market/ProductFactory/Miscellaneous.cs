using System;
using Loppemarked.Market.Controller;
using Loppemarked.Market.Sale;

namespace Loppemarked.Market.ProductFactory
{
    public class Miscellaneous : IProduct
    {
        private string _name;
        private string _condition;
        private string _material;
        private string _sellername;
        private int _nr;

        public Miscellaneous(string sellername){
            RandomMiscellaneousProduct(sellername);
        }

        public void RandomMiscellaneousProduct(string sellername)
        {
            var randomProduct = Client.rnd.Next(4);
            SetSellerName(sellername);
            SetNr(_nr);
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
<<<<<<< HEAD
            return seller.GetName();

=======
            return _name + ", Condition: " + _condition + ", Materials: " + _material + " ";
>>>>>>> 5ec652ced8b3522e14c5fce8cad0baf7435b09a5
        }
    }
}
