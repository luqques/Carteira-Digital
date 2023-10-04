using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carteira
{
    public class Conta
    {
        private string Numero { get; set; }
        public string Agencia { get; set; }
        public string Banco { get; set; }
        
        private Carteira.Cliente cliente;

        

        public static void CadastroConta()
        {
            Console.WriteLine("Cadastre sua conta:");

            Console.Write("Digite o número da conta: ");            
        }
    }
}
