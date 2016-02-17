﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaixaEletronico
{
    public class ContaPoupanca: Conta, ITributavel
    {
        public double CalculaTributos()
        {
            return Saldo * 0.02;
        }

        public override void Saca(double valor)
        {
            base.Saca(valor + 0.1);
        }
    }
}
