using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Carteira.Interfaces;

namespace Carteira.Model
{
    public class PagamentoModel : ICrud
    {
        private int EscolherMetodoPagamento()
        {
            Console.WriteLine("Escolha o método de pagamento:");
            List<string> listaMetodosPagamentos = new List<string>() { "1. Dinheiro", "2. Débito", "3. Crédito", "4. Pix", "5. Boleto" };

            foreach (string i in listaMetodosPagamentos) { Console.WriteLine(i); }

            int codigoMetodoPagamento = Convert.ToInt32(Console.ReadLine());
            return codigoMetodoPagamento;
        }

        private double ValorPagamento()
        {
            Console.WriteLine("Qual o valor do pagamento?");
            return Convert.ToDouble(Console.ReadLine());
        }

        private string RecebedorPagamento()
        {
            Console.WriteLine("Qual o nome do recebedor do pagamento?");
            return Console.ReadLine();
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
