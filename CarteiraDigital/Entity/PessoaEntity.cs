using Carteira.Helpers;
using Carteira.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carteira.Entity
{
    public class PessoaEntity : ClienteEntity
    {
        public int Id { get; set; }
        private string Nome { get; set; }
        private string Cpf { get; set; }
        private bool maiorDeIdade;
        private int idade;
        private int Idade
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
    }
}
