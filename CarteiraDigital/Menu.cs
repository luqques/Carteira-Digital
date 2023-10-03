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
        public static int MenuPrincipal()
        {
            Console.WriteLine("1. Carteira");
            return Convert.ToInt32(Console.ReadLine());
        }

        public static string MenuCarteira(int opcao)
        {
            if (opcao == 1)
            {
                Console.WriteLine("1. Cadastro");
                Console.WriteLine("2. Saldo");
                Console.WriteLine("3. Investimentos");
                Console.WriteLine("4. Pagamentos");

                return Console.ReadLine();
            }
            else
            {
                throw new Exception("Opção inválida.");
            }
        }

        public static bool MenuCadastroConta()
        {
            Console.WriteLine("Já possui um cadastro? s/n");
            bool posssuiCadastro;
            if (Console.ReadLine().ToLower().Equals("s"))
            {
                return posssuiCadastro = true;
            }
            else if (Console.ReadLine().ToLower().Equals("n"))
            {
                return posssuiCadastro = false;
            }
            else
            {
                throw new Exception("Resposta inválida.");
            }
        }
    }
}
