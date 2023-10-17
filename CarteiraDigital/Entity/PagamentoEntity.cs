using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carteira.Entity
{
    public class PagamentoEntity
    {
        public int Id { get; set; }
        private string Recebedor { get; set; }
        private string NomeMetodoPagamento { get; set; }
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
    }
}
