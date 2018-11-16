using System;
using Loppemarked.Market.Sale;

namespace Loppemarked.Market.ProductFactory
{
    public interface IProduct
    {
        bool Is_sold();
        string GetName();
        string GetMaterial();
        string GetCondition();
    }
}
