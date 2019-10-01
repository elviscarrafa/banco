using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Banco
{
    public partial class Form4 : Form
    {
        private Conta ContaPoupanca;
        public ContaPoupanca contapoupanca;
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            this.ContaPoupanca = new ContaPoupanca();
            Conta cp = new Conta();
            cp.Numero = 4;
            textoNumero.Text = Convert.ToString(cp.Numero);

        }

        private void Poupanca_Click(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {

        }

        private void BotaoNoperacao_Click(object sender, EventArgs e)
        {

        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void BotaoSaque_Click(object sender, EventArgs e)
        {

        }

        private void botaoDeposito_Click(object sender, EventArgs e)
        {

        }

        private void ContaCorrenteToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void PoupançaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void SairToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void BotaoDeposita_Click(object sender, EventArgs e)
        {
            string valorDigitado = textoValor.Text;
            double valor = Convert.ToDouble(valorDigitado);
            this.ContaPoupanca.Deposita(valor);
            textoSaldo.Text = Convert.ToString(this.ContaPoupanca.Saldo);
            textoTotal.Text = Convert.ToString(this.ContaPoupanca.Saldo);
            MessageBox.Show("Deposito realizado com Sucesso");
           

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Form4 form4 = new Form4();
            form4.Show();
        }

        private void BotaoNoperacao_Click_1(object sender, EventArgs e)
        {
            textoSaldo.Clear();
            textoNumero.Clear();
            textoTitular.Clear();
            textoValor.Clear();
        }

        private void BotaoSaque_Click_1(object sender, EventArgs e)
        {
            string valorDigitado = textoValor.Text;
            double valor = Convert.ToDouble(valorDigitado);
            this.ContaPoupanca.Saca(valor);
            textoSaldo.Text = Convert.ToString(this.ContaPoupanca.Saldo);
            textoTotal.Text = Convert.ToString(this.ContaPoupanca.valorFinal);

            MessageBox.Show("Deposito realizado com Sucesso");
            MessageBox.Show("Descontado valor da tarifa 0,10");
        }
    }
}
