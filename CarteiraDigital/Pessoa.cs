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
            get { return idade; }
            set
            {
                if (idade >= 18)
                {
                    MaiorDeIdade = true;
                }
                else
                {
                    MaiorDeIdade = false;
                }
                idade = value;
            }
        }

        public Pessoa()
        {
            Console.Clear();
            CadastroPessoa();
            MostrarPessoa();
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
    }
}
