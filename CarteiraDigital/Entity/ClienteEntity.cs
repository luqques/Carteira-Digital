using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carteira.Entity
{
    internal class ClienteEntity
    {
        private static string documento;
        private static char tipoCliente;

        public static string Documento
        {
            get { return documento; }
            set
            {
                documento = value;
                if (documento.Length == 14)
                {
                    tipoCliente = 'J';
                }
                else if (documento.Length == 11)
                {
                    tipoCliente = 'F';
                }
                else
                {
                    throw new ArgumentException("Documento inválido.");
                }
            }
        }
    }
}
