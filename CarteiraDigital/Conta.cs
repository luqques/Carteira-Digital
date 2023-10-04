using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carteira
{
    public class Conta
    {
        public string Numero { get; set; }
        public string Agencia { get; set; }
        public string Banco { get; set; }
        public Pessoa Pessoa { get; set; }

        public void CadastroConta(Pessoa pessoa)
        {            
            Console.WriteLine("Cadastre sua conta na Carteira Digital:");

            Console.Write("Digite o número da Conta: ");
            Numero = Console.ReadLine();

            Console.Write("Digite o número da Agência: ");
            Agencia = Console.ReadLine();

            Console.Write("Digite o número do Banco: ");
            Banco = Console.ReadLine();

            Pessoa = pessoa;
        }
    }
}
