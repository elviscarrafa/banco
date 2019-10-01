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
    public partial class Form3 : Form
    {

       public  Conta conta;
       public  ContaPoupanca contapoupanca;
        public Form3()
        {
            InitializeComponent();
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

             
        private void PoupançaToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.Show();
        }

        private void ContaCorrenteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1 form1 = new Form1();
            form1.Show();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1 form1 = new Form1();
            form1.Show();
                                
        }

        private void GroupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void BotaoDeposita_Click(object sender, EventArgs e)
        {

        }

        public void Form3_Load(object sender, EventArgs e)
        {
            this.contapoupanca = new ContaPoupanca();
            Conta cp = new Conta();
            cp.Numero = 3;
            Cliente cliente = new Cliente("Victor");
            cp.Titular = cliente;
            textoTitular4.Text = cp.Titular.Nome;
            textoNumero3.Text = Convert.ToString(cp.Numero);
            textoSaldo2.Text = Convert.ToString(cp.Saldo);
        }
        public void BotaoSaque_Click_1(object sender, EventArgs e)
        {
            string valorDigitado = textoValor.Text;
            double valorOperacao = Convert.ToDouble(valorDigitado);
            this.contapoupanca.Saca(valorOperacao);
            textoSaldo.Text = Convert.ToString(this.contapoupanca.Saldo);
            MessageBox.Show("Saque realizado com Sucesso");
        }
       
        public void Poupanca_Click_1(object sender, EventArgs e)
        {
            this.contapoupanca = new ContaPoupanca();
            Conta cp = new Conta();
            string valorDigitado = textoValor.Text;
            double valorOperacao = Convert.ToDouble(valorDigitado);
            this.contapoupanca.Saca(valorOperacao);
            textoSaldo2.Text = Convert.ToString(this.contapoupanca.Saldo);
            MessageBox.Show("Saque realizado com Sucesso");
        }

        public void Button5_Click(object sender, EventArgs e)
        {
            string valorDigitado = textoValor1.Text;
            double valor = Convert.ToDouble(valorDigitado);
            this.contapoupanca.Deposita(valor);
            textoSaldo2.Text = Convert.ToString(this.contapoupanca.Saldo);
            MessageBox.Show("Deposito realizado com Sucesso");
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            string valorDigitado = textoValor1.Text;
            double valorOperacao = Convert.ToDouble(valorDigitado);
            this.contapoupanca.Saca(valorOperacao);
            textoSaldo2.Text = Convert.ToString(this.contapoupanca.Saldo);
            MessageBox.Show("Saque realizado com Sucesso");
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            textoSaldo2.Clear();
            textoNumero3.Clear();
            textoTitular4.Clear();
            textoValor1.Clear();
        }
    }
}
