using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using Loppemarked.Market.Controller;

namespace Loppemarked
{
    // Main class to run the program
    class Program
    {
    static void Main(string[] args)
        {
            Client start = new Client();
            start.startMarked();
        }

        
    }
}
