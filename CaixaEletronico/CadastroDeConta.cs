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
    public partial class CadastroDeConta : Form
    {
        private Form1 aplicacaoPrincipal;

        public CadastroDeConta(Form1 formPrincipal)
        {
            aplicacaoPrincipal = formPrincipal;

            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (tiposContaCombo.SelectedIndex >= 0)
            {
                Conta novaConta;

                if (tiposContaCombo.SelectedIndex == 0)
                    novaConta = new ContaCorrente();
                else
                    novaConta = new ContaPoupanca();

                novaConta.Titular = new Cliente(titularConta.Text);
                novaConta.Numero = Convert.ToInt32(numeroConta.Text);
                aplicacaoPrincipal.AdicionaConta(novaConta);

                this.Close();
            }
        }

        private void CadastroDeConta_Load(object sender, EventArgs e)
        {
            tiposContaCombo.Items.Add("Conta Corrente");
            tiposContaCombo.Items.Add("Conta Poupança");
        }
    }
}
