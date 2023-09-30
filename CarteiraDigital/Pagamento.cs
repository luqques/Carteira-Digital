using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carteira
{
    internal class Pagamento
    {
        public string Recebedor { get; set; }
        private string nomeMetodoPagamento;        
        public Pagamento()
        {            
            switch (this.EscolherMetodoPagamento())
            {
                case 1: nomeMetodoPagamento = "Dinheiro"; break;
                case 2: nomeMetodoPagamento = "Débito"; break;
                case 3: nomeMetodoPagamento = "Crédito"; break;
                case 4: nomeMetodoPagamento = "Pix"; break;
                case 5: nomeMetodoPagamento = "Boleto"; break;
                default: nomeMetodoPagamento = "Desconhecido"; break;
            }
        }        

        public int EscolherMetodoPagamento()
        {
            Console.WriteLine("Escolha o método de pagamento:");
            List<string> listaMetodosPagamentos = new List<string>() { "1. Dinheiro", "2. Débito", "3. Crédito", "4. Pix", "5. Boleto" };

            foreach (string i in listaMetodosPagamentos) { Console.WriteLine(i); }

            int codigoMetodoPagamento = Convert.ToInt32(Console.ReadLine());
            return codigoMetodoPagamento;
        }

        public void MostrarMetodoPagamento()
        {
            Console.WriteLine(this.nomeMetodoPagamento);
        }
    }
}
