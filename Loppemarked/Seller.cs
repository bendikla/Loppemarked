using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Loppemarked
{
    class Seller
    {
        public string sellerID { get; set; }
        public static string sellerName { get; set; }

        public Seller(string id, string name)
        {
            sellerID = id;
            sellerName = name;
        }
    }
}
