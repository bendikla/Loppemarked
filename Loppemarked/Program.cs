﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using Loppemarked.Market.Controller;

namespace Loppemarked
{
    // Main class to run the program
    // Singleton design pattern
    class Program
    {
    static void Main(string[] args)
        {
<<<<<<< HEAD
            Client start = new Client();
            start.startMarked();
=======
           
            Client.StartMarked();

            Client.Exit();


>>>>>>> origin/bendik
        }

        
    }
}
