using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carteira.Entity
{
    internal class ClienteEntity
    {
        public int ID { get; set; }
        public string NOME { get; set; }
        public string DOCUMENTO { get; set; }
        public string TIPO_DOCUMENTO { get; set; }
    }
}
