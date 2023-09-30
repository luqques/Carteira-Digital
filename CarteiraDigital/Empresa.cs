using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carteira
{
    internal class Empresa:Cliente
    {
        private string cnpj;
        private string razaoSocial;

        public Empresa()
        {
            this.razaoSocial = Nome;
            this.cnpj = Documento;
        }
    }
}
