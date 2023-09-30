using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carteira
{
    internal class Menu
    {
        public static string MenuPrincipal()
        {
            Console.WriteLine("1. Carteira");
            return Console.ReadLine();
        }
    }
}
