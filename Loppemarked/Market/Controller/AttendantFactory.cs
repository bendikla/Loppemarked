using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Loppemarked.Market.Customer;
using Loppemarked.Market.ProductFactory;
using Loppemarked.Market.Sale;

namespace Loppemarked.Market.Controller
{
    class AttendantFactory : IAttendantFactory
    {
        public ICustomer CreateCustomer(string name)
        {
            return new Customer.Customer(name);
        }

        public ISellers CreateSeller(string name, int total, IProduct product)
        {
            return new Seller(name,total,product);
        }
    }
}
