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
        private List<Conta> contas;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            contas = new List<Conta>();

            contas.Add(new Conta {
                Numero = 1,
                Titular = new Cliente("Gilmar")
            });

            contas[0].Deposita(1500);

            contas.Add(new Conta {
                Numero = 2,
                Titular = new Cliente("Maria")
            });

            contas[1].Deposita(2400);

            foreach (var conta in contas)
            {
                comboContas.Items.Add(conta);
                comboContasDestino.Items.Add(conta);
            }

            comboContas.DisplayMember = "Numero";
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

        public void AdicionaConta(Conta novaConta)
        {
            contas.Add(novaConta);
            comboContas.Items.Add(novaConta.Titular.nome);
        }

        private void botaoSaque_Click(object sender, EventArgs e)
        {
            if (textoTipoConta.Text != string.Empty)
            {
                var contaSelecionada = contas[comboContas.SelectedIndex];
                contaSelecionada.Saca(Convert.ToDouble(textoTipoConta.Text));
                MostrarConta(contaSelecionada);
            }
        }

        private void botaoDeposita_Click(object sender, EventArgs e)
        {
            if (textoTipoConta.Text != string.Empty)
            {
                var valor = Convert.ToDouble(textoTipoConta.Text);
                var contaSelecionada = contas[comboContas.SelectedIndex];
                contaSelecionada.Deposita(valor);
                MostrarConta(contaSelecionada);
            }
        }

        private void botaoTransferir_Click(object sender, EventArgs e)
        {
            if (textoTipoConta.Text != string.Empty && comboContasDestino.SelectedIndex > -1)
            {
                var valor = Convert.ToDouble(textoTipoConta.Text);
                var contaOrigem = contas[comboContas.SelectedIndex];
                var contaDestino = contas[comboContasDestino.SelectedIndex];
                contaOrigem.TranferirPara(contaDestino, valor);
            }
        }

        private void botaoTributavel_Click(object sender, EventArgs e)
        {
            GerenciadorDeImposto gerenciador = new GerenciadorDeImposto();
            ContaPoupanca cp = new ContaPoupanca();
            cp.Deposita(200);
            SeguroDeVida sv = new SeguroDeVida();
            gerenciador.Adiciona(cp);
            gerenciador.Adiciona(sv);
            MessageBox.Show("Total: " + gerenciador.Total);
        }

        private void botaoNovaConta_Click(object sender, EventArgs e)
        {
            var cadastro = new CadastroDeConta(this);
            cadastro.ShowDialog();
        }

        private void botaoRemover_Click(object sender, EventArgs e)
        {
            if (comboContas.SelectedIndex >= 0)
            {
                var conta = (Conta)comboContas.SelectedItem;
                contas.Remove(conta);
                comboContas.Items.Remove(comboContas.SelectedItem);
            }
        }
    }
}
