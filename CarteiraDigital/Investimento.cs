using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carteira
{
    public class Investimento
    {
        private string Tipo { get; set; }
        private double Valor { get; set; }
        private int Meses { get; set; }
        
        public Investimento()
        {
            TipoInvestimento();
            ValorInvestimento();
            MesesInvestimento();
        }

        public void TipoInvestimento()
        {
            Console.WriteLine("Qual o tipo de investimento?");
            Tipo = Console.ReadLine();
        }
        public void ValorInvestimento()
        {
            Console.WriteLine("Qual o valor do investimento?");
            Valor = Convert.ToDouble(Console.ReadLine());
        }
        public void MesesInvestimento()
        {
            Console.WriteLine("Por quantos meses deseja deixar investido?");
            Meses = Convert.ToInt32(Console.ReadLine());
        }
    }
}
