using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carteira
{
    public class Menu
    {
        public static void BoasVindas()
        {
            Console.WriteLine("\nBem vindo à sua Carteira Digital!");
        }
        public static string MenuPrincipal()
        {
            Console.WriteLine("1. Carteira");
            return Console.ReadLine();
        }

        public static string MenuCarteira()
        {
            Console.WriteLine("1. Cadastro");
            Console.WriteLine("2. Saldo");
            Console.WriteLine("3. Investimentos");
            Console.WriteLine("4. Pagamentos");

            return Console.ReadLine();
        }
    }
}
