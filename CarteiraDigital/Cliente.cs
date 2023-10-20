﻿namespace Carteira
{
    public class Cliente
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
        
        public static void DefinirTipoCliente()
        {
            Console.Clear();
            Console.Write("Digite o número identificador do seu documento: ");
            Documento = Console.ReadLine();

            if (tipoCliente == 'J')
            {
                Empresa empresa1 = new Empresa();
            }
            else if (tipoCliente == 'F')
            {
                Pessoa pessoa1 = new Pessoa();
            }
        }
    }
}