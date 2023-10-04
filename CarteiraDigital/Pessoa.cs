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
        private string cpf { get; set; }
        private int idade { get; set; }
        private bool maiorDeIdade { get; set; }

        public Pessoa()
        {
            this.cpf = Documento;
        }

        public int Idade
        {
            get { return idade; }
            set
            {
                if (idade >= 18)
                {
                    maiorDeIdade = true;
                }
                else
                {
                    maiorDeIdade = false;
                }
                idade = value;
            }
        }

        public static void CadastroPessoa()
        {
        }
    }
}
