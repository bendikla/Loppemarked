using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Loppemarked.Market.Customer;
using Loppemarked.Market.ProductFactory;

namespace Loppemarked.Market.Sale
{
    public interface ISellers
    {
        string GetName();
        void AddProduct();
        void Sell(Customer.Customer customer);
        bool ProductAvailable();
        bool ItemSold();
    }
}
