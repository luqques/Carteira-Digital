﻿using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Carteira.Interfaces;

namespace Carteira.Model
{
    public class InvestimentoModel : ICrud
    {
        public void TipoInvestimento()
        {
            Console.WriteLine("Qual o tipo de investimento?");
        }
        public void ValorInvestimento()
        {
            Console.WriteLine("Qual o valor do investimento?");
        }
        public void MesesInvestimento()
        {
            Console.WriteLine("Por quantos meses deseja deixar investido?");
        }

        public void Create()
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

        public void Delete()
        {
            throw new NotImplementedException();
        }
    }
}
