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
        private Conta [] contas;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            contas = new Conta[2];

            contas[0] = new Conta {
                Numero = 1,
                Titular = new Cliente("Gilmar")
            };
            contas[0].Deposita(1500);

            contas[1] = new Conta {
                Numero = 2,
                Titular = new Cliente("Maria")
            };
            contas[1].Deposita(2400);

            foreach (var conta in contas)
            {
                comboContas.Items.Add(conta.Titular.nome);
                comboContasDestino.Items.Add(conta.Titular.nome);
            }
        }

        private void comboContas_SelectedIndexChanged(object sender, EventArgs e)
        {
            var contaSelecionada = contas[comboContas.SelectedIndex];
            MostrarConta(contaSelecionada);
        }

        private void MostrarConta(Conta conta)
        {
            textoTitular.Text = conta.Titular.nome;
            textoSaldo.Text = conta.Saldo.ToString();
            textoNumero.Text = conta.Numero.ToString();
        }

        private void botaoSaque_Click(object sender, EventArgs e)
        {
            if (textoValor.Text != string.Empty)
            {
                var contaSelecionada = contas[comboContas.SelectedIndex];
                contaSelecionada.Saca(Convert.ToDouble(textoValor.Text));
                MostrarConta(contaSelecionada);
            }
        }

        private void botaoDeposita_Click(object sender, EventArgs e)
        {
            if (textoValor.Text != string.Empty)
            {
                var valor = Convert.ToDouble(textoValor.Text);
                var contaSelecionada = contas[comboContas.SelectedIndex];
                contaSelecionada.Deposita(valor);
                MostrarConta(contaSelecionada);
            }
        }

        private void botaoTransferir_Click(object sender, EventArgs e)
        {
            if (textoValor.Text != string.Empty && comboContasDestino.SelectedIndex > -1)
            {
                var valor = Convert.ToDouble(textoValor.Text);
                var contaOrigem = contas[comboContas.SelectedIndex];
                var contaDestino = contas[comboContasDestino.SelectedIndex];
                contaOrigem.TranferirPara(contaDestino, valor);
            }
        }
    }
}
