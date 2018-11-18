using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Loppemarked.Market.Customer;
using Loppemarked.Market.ProductFactory;
using Loppemarked.Market.Sale;

namespace Loppemarked.Market.Controller
{
    interface IAttendantFactory
    {
        ICustomer CreateCustomer(string name);

        ISellers CreateSeller(string name, int total, IProduct product);
    }
}
