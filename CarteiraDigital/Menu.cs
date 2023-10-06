﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carteira
{
    public class Menu
    {
        public static void BoasVindas()
        {
            Console.WriteLine("\nBem vindo à sua Carteira Digital!");
        }
        public static void MenuPrincipal()
        {
            Console.Clear();
            Console.WriteLine("1. Carteira");
            MenuCarteira(Convert.ToInt32(Console.ReadLine()));
        }

        public static void MenuCarteira(int opcao)
        {
            Console.Clear();
            if (opcao == 1)
            {                
                Console.WriteLine("1. Cadastro");
                Console.WriteLine("2. Saldo");
                Console.WriteLine("3. Investimentos");
                Console.WriteLine("4. Pagamentos");

                switch (Convert.ToInt32(Console.ReadLine()))
                {
                    case 1:
                        Cliente.DefinirTipoCliente();
                        break;
                    case 2:
                        //TODO: chamada de Saldo
                        break;
                    case 3:
                        Investimento investimento1 = new Investimento();
                        break;
                    case 4:
                        Pagamento pagamento1 = new Pagamento();
                        break;
                    default:
                        throw new Exception("Opção inválida.");
                        break;
                }
            }
            else
            {
                throw new Exception("Opção inválida.");
            }
        }
    }
}
