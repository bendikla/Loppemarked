using System;
using System.Security.Cryptography.X509Certificates;
using Loppemarked.Market.Controller;
using Loppemarked.Market.Sale;


namespace Loppemarked.Market.ProductFactory
{
    public class Garden : IProduct
    {
        private string _name;
        private string _condition;
        private string _material;
<<<<<<< HEAD
        private string _seller;

        // TODO create a selection of random items in garden category
        public Garden(){
            RandomGardenProduct();
=======
        private string _sellername;
        private int _nr;

        // TODO create a selection of random items in garden category D鴑n.
        public Garden(string sellername){
            RandomGardenProduct(sellername);
>>>>>>> 5ec652ced8b3522e14c5fce8cad0baf7435b09a5
        }

        public void RandomGardenProduct(string sellername)
        {
            var randomProduct = Client.rnd.Next(4);
            SetSellerName(sellername);
            SetNr(_nr);
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

        public void SetNr(int nr)
        {
            _nr = nr;
        }

        public int GetNr()
        {
            return _nr;
        }

        public string GetCondition(){
            return _condition;
        }

        public void SetCondition(string condition){
            _condition = condition;
        }

        public string GetName(){
            return _name;
        }

        public void SetSellerName(string name)
        {
            _sellername = name;
        }

        public string GetSellerName()
        {
            return _sellername;
        }

        public void SetName(string name){
            _name = name;
        }

        public string GetMaterial(){
            return _material;
        }

        public void SetMaterial(string material){
            _material = material;
        }

        public bool Is_sold(){
            return true;
        }
    }
}
