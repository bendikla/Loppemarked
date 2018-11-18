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
        string DisplayProduct();
        int GetNr();
        void SetNr(int nr);
    }
}
