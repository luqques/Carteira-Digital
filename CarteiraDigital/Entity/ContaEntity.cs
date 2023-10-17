using Carteira.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carteira.Entity
{
    public class ContaEntity : ICrud
    {
        public string Numero { get; set; }
        public string Agencia { get; set; }
        public string Banco { get; set; }
        public PessoaEntity Pessoa { get; set; }

        public void Create()
        {
            throw new NotImplementedException();
        }

        public void Delete()
        {
            throw new NotImplementedException();
        }

        public void Read()
        {
            throw new NotImplementedException();
        }

        public void Update()
        {
            throw new NotImplementedException();
        }
    }
}
