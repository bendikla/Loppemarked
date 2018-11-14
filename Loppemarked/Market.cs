using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Loppemarked
{
    class Market
    {     
        public Market()
        {
        }

        public  void showProducts()
        {
            Seller seller = new Seller();
            foreach (var item in seller.itemForSale)
            {
                Console.WriteLine("For sale: {0}, condition: {1}, sold from {2}", item.itemName, item.itemCondition, item.sellerName);
            }
        }
    }
}
