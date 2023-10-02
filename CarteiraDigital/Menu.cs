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

        public static void MenuCadastro()
        {
            Console.WriteLine("Já possui um cadastro? s/n");
            if (Console.ReadLine().ToLower().Equals("s"))
            {
                PossuiCadastro();
            }
            else if (Console.ReadLine().ToLower().Equals("n"))
            {
                NaoPossuiCadastro();
            }
            else
            {
                throw new Exception("Resposta inválida.");
            }
        }

        private static void NaoPossuiCadastro()
        {
            throw new NotImplementedException();
        }

        private static void PossuiCadastro()
        {
            throw new NotImplementedException();
        }
    }
}
