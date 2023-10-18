using Carteira.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carteira.Entity
{
    public class ContaEntity
    {
        public string Numero { get; set; }
        public string Agencia { get; set; }
        public string Banco { get; set; }
        public PessoaEntity Pessoa { get; set; }
    }
}
