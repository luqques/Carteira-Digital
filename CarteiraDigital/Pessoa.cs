using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace Carteira
{
    public class Pessoa:Cliente
    {
        private char tipoPessoa;
        
        private string Nome { get; set; }

        private string Cpf { get; set; }

        private bool MaiorDeIdade { get; set; }
        
        private int idade;
        
        private int Idade
        {
            get { return this.idade; }
            set
            {
                if (this.idade >= 18)
                {
                    this.MaiorDeIdade = true;
                }
                else
                {
                    this.MaiorDeIdade = false;
                }
                this.idade = value;
            }
        }

        public Pessoa()
        {
            CadastroPessoa();
            MostrarPessoa();
        }

        private void CadastroPessoa()
        {
            Console.Write("Digite seu nome: ");
            this.Nome = Console.ReadLine();

            Console.Write("Digite sua idade: ");
            this.Idade = Convert.ToInt32(Console.ReadLine());

            Console.Write("Digite seu CPF: ");
            this.Cpf = Documento;
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

            Menu.MenuPrincipal();
        }
    }
}
