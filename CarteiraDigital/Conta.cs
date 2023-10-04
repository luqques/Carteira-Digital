using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carteira
{
    public class Conta
    {
        public static void CadastroConta()
        {
            Console.WriteLine("Cadastre sua conta na Carteira Digital:");

            Console.Write("Digite o número da Conta: ");
            string numero = Console.ReadLine();

            Console.Write("Digite o número da Agência: ");
            int agencia = Convert.ToInt32(Console.ReadLine());

            Console.Write("Digite o número do Banco: ");
            int banco = Convert.ToInt32(Console.ReadLine());
        }
    }
}
