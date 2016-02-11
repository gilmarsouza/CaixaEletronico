using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CaixaEletronico
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var cliente = new Cliente
            {
                nome = "Gilmar",
                cpf = "294.908.678-02",
                rg = "32.085.147-3",
                endereco = "Rua Esmeralda, 705, Jardim Real, Maringá - PR"
            };

            var conta = new Conta
            {
                Numero = 1,
                Titular = cliente
            };

            conta.Deposita(3000);

            MessageBox.Show(string.Format("O Titular {0} possui R$ {1}", conta.Titular.nome, conta.Saldo));
        }
    }
}
