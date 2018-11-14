using System;
namespace Loppemarked.Product
{
    public interface IProduct
    {
        bool Is_sold();
        string GetName();
        string GetMaterial();
        string GetCondition();
    }
}
