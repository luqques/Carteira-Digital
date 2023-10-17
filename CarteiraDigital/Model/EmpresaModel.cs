using Carteira.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carteira.Model
{
    public class EmpresaModel : ClienteModel, ICrud
    {
        public void Create()
        {
            
        }

        public void Delete()
        {
            
        }

        public void Read()
        {

        }

        public void Update()
        {

        }

        private void CnpjEmpresa(EmpresaEntity empresa, ClienteEntity cliente)
        {
            empresa.Cnpj = cliente.Documento;
        }
        private void RazaoSocialEmpresa(EmpresaEntity empresa)
        {
            Console.Write("Digite a razão social da empresa: ");
            empresa.RazaoSocial = Console.ReadLine();
        }
        private void MostrarEmpresa(EmpresaEntity empresa)
        {            
            Console.WriteLine($"{empresa.RazaoSocial} - CNPJ: {empresa.Cnpj}");

            Console.Clear();
            Menu.MenuPrincipal();
        }
    }
}
