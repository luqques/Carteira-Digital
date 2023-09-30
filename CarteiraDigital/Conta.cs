using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carteira
{
    internal class Conta
    {
        public string Numero { get; set; }
        public string Agencia { get; set; }
        public string Banco { get; set; }
        
        private Carteira.Cliente cliente;
    }
}
