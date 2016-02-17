using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaixaEletronico
{
    public class GerenciadorDeImposto
    {
        public double Total { get; private set; }

        public void Adiciona(ITributavel tributavel)
        {
            Total += tributavel.CalculaTributos();
        }
    }
}
