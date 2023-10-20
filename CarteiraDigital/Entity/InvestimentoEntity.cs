using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carteira.Entity
{
    public class InvestimentoEntity
    {
        public int Id { get; set; }
        private string Tipo { get; set; }
        private double Valor { get; set; }
        private int Meses { get; set; }
    }
}
