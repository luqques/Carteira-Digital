using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Carteira
{
    public class Empresa:Cliente
    {
        private string Cnpj { get; set; }

        private string RazaoSocial { get; set; }

        public Empresa()
        {
            Console.Clear();
            RazaoSocialEmpresa();
            CnpjEmpresa();
            MostrarEmpresa();
        }

        private void CnpjEmpresa()
        {
            Cnpj = Documento;
        }

        private void RazaoSocialEmpresa()
        {
            Console.Write("Digite a razão social da empresa: ");
            RazaoSocial = Console.ReadLine();
        }

        private void MostrarEmpresa()
        {
            Console.WriteLine("\nDados da Empresa Cliente cadastrada:");
            Console.WriteLine($"Razão Social: {RazaoSocial}");
            Console.WriteLine($"CNPJ: {Cnpj}");

            Console.Clear();
            Menu.MenuPrincipal();
        }
    }
}
