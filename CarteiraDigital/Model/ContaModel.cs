using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Carteira.Helpers;

namespace Carteira.Model
{
    public class ContaModel : ICrud
    {
        public void CadastroConta()
        {
            Console.WriteLine("Cadastre sua conta na Carteira Digital:");

            Console.Write("Digite o número da Conta: ");

            Console.Write("Digite o número da Agência: ");

            Console.Write("Digite o número do Banco: ");
        }

        public void Create()
        {
            throw new NotImplementedException();
        }

        public void Delete()
        {
            throw new NotImplementedException();
        }

        public void Read()
        {
            throw new NotImplementedException();
        }

        public void Update()
        {
            throw new NotImplementedException();
        }
    }
}
