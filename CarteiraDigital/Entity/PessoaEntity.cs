using Carteira.Helpers;
using Carteira.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carteira.Entity
{
    public class PessoaEntity : ClienteEntity, ICrud
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
        private void CadastroPessoa()
        {
            Console.Write("Digite seu nome: ");
            Nome = Console.ReadLine();

            Console.Write("Digite sua idade: ");
            Idade = Convert.ToInt32(Console.ReadLine());

            Cpf = Documento;
        }

        public void MostrarPessoa()
        {
            Console.Clear();
            Console.WriteLine("Dados da Pessoa");
            Console.WriteLine($"Nome: {Nome}");
            Console.WriteLine($"Idade: {Idade}");
            Console.WriteLine($"CPF: {Cpf}");

            Console.WriteLine("Aperte qualquer tecla para prosseguir.");
            Console.ReadKey();

            Console.Clear();
            Menu.MenuPrincipal();
        }

        public void Create()
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

        public void Delete()
        {
            throw new NotImplementedException();
        }
    }
}
