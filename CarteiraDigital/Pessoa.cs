using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace Carteira
{
    public class Pessoa:Cliente
    {       
        private string Cpf { get; set; }
        private bool MaiorDeIdade { get; set; }

        private int Idade
        {
            get { return this.Idade; }
            set
            {
                if (Idade >= 18)
                {
                    this.MaiorDeIdade = true;
                }
                else
                {
                    this.MaiorDeIdade = false;
                }
                this.Idade = value;
            }
        }

        public Pessoa()
        {
            CadastroPessoa();
            this.Cpf = Documento;
        }

        private void CadastroPessoa()
        {
            Console.Write("Digite seu nome: ");
            this.Nome = Console.ReadLine();

            Console.Write("Digite sua idade: ");
            this.Idade = Convert.ToInt32(Console.ReadLine());

            Console.Write("Digite seu CPF: ");
            this.Cpf = Console.ReadLine();
        }
    }
}
