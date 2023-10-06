using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carteira
{
    public class Pagamento
    {
        private string Recebedor { get; set; }
        private string NomeMetodoPagamento {get; set; }
        private double valor;
        private double Valor
        {
            get { return valor; }
            set
            {
                if (valor > 1000)
                {
                    Console.WriteLine("Valor acima do limite de pagamento desta conta!");
                }
                else
                {
                    valor = value;
                }
            }
        }

        public Pagamento()
        {
            Console.Clear();
            switch (EscolherMetodoPagamento())
            {
                case 1: NomeMetodoPagamento = "Dinheiro"; break;
                case 2: NomeMetodoPagamento = "Débito"; break;
                case 3: NomeMetodoPagamento = "Crédito"; break;
                case 4: NomeMetodoPagamento = "Pix"; break;
                case 5: NomeMetodoPagamento = "Boleto"; break;
                default: NomeMetodoPagamento = "Desconhecido"; break;
            }
            Console.WriteLine($"Método de pagamento escolhido: {NomeMetodoPagamento}");

            ValorPagamento();
            RecebedorPagamento();
        }

        private int EscolherMetodoPagamento()
        {
            Console.WriteLine("Escolha o método de pagamento:");
            List<string> listaMetodosPagamentos = new List<string>() { "1. Dinheiro", "2. Débito", "3. Crédito", "4. Pix", "5. Boleto" };

            foreach (string i in listaMetodosPagamentos) { Console.WriteLine(i); }

            int codigoMetodoPagamento = Convert.ToInt32(Console.ReadLine());
            return codigoMetodoPagamento;
        }

        private void ValorPagamento()
        {
            Console.WriteLine("Qual o valor do pagamento?");
            Valor = Convert.ToDouble(Console.ReadLine());
        }

        private void RecebedorPagamento()
        {
            Console.WriteLine("Qual o nome do recebedor do pagamento?");
            Recebedor = Console.ReadLine();
        }
    }
}
