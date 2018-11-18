using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Loppemarked.Market.ProductFactory;

namespace Loppemarked.Market.Customer
{
    public interface ICustomer
    {
        void PurchaseItem();
        string GetName();
        List<IProduct> GetItems();
        string GetItemName();
        void AddItems(IProduct product);
        void AddTotalItems();
        int GetProductsBought();
    }
}
