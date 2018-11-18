using System;
using Loppemarked.Market.Sale;

namespace Loppemarked.Market.ProductFactory
{
    public interface IProduct
    {
        bool Is_sold();
        string GetName();
        string GetSellerName();
        string GetMaterial();
        string GetCondition();
<<<<<<< HEAD
=======
        string DisplayProduct();
        int GetNr();
        void SetNr(int nr);
>>>>>>> 5ec652ced8b3522e14c5fce8cad0baf7435b09a5
    }
}
