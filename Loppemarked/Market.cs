using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Loppemarked
{
    class Market
    {     
        Seller slrr = new Seller();
        public Market()
        {
            slrr.showProducts();
        }
    }
}
