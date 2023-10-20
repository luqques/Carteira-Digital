using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carteira.Entity
{
    public class ClienteEntity
    {
        public int Id { get; set; }        
        public string Documento { get; set; }
        public char tipoCliente;
        public string Senha { get; set; }
    }
}
