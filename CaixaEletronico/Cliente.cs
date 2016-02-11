using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaixaEletronico
{
    public class Cliente
    {
        public string nome;
        public string cpf;
        public string rg;
        public string endereco;

        public Cliente() { }

        public Cliente(string nome)
        {
            this.nome = nome;
        }
    }
}
