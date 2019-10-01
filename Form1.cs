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
    public partial class Form1 : Form
    {
        
        private Conta[] contas;
        private ContaPoupanca contapoupanca;
        public  ContaCorrente contaCorrente;
        private int numeroDeContas;

        public Form1()
        {
            InitializeComponent();
        }
        public void AdicionaConta(Conta conta)
        {
            this.contas[this.numeroDeContas] = conta;
            this.numeroDeContas++;
            comboContas.Items.Add(conta.Titular.Nome);           
        }

        public void Form1_Load(object sender, EventArgs e)
        {
            contas = new Conta[10];

         //   this.contas[0] = new Conta();
        //    this.contas[0].Titular = new Cliente ("Victor");
        //    this.contas[0].Numero = 1;

        //    this.contas[1] = new ContaPoupanca();
        //    this.contas[1].Titular = new Cliente("Mauricio");
        //    this.contas[1].Numero = 2;

       //     this.contas[2] = new Conta();
       //     this.contas[2].Titular = new Cliente("Erick");
      //      this.contas[2].Numero = 3;
                       

         //   foreach (Conta conta in contas)
        //    {
               //comboContas.Items.Add(conta.Titular.Nome);
        //    }


        }

        private void AdicionaConta(ContaCorrente novaConta)
        {
            throw new NotImplementedException();
        }

        public int Numero { get; set; }
        public double Saldo { get; private set; }
        public string Titular { get; set; }

        private void botaoDeposito_Click(object sender, EventArgs e)
        {

            int indice = comboContas.SelectedIndex;
            Conta selecionada = this.contas[indice];

            if (textoValor.Text == string.Empty)
            {
                MessageBox.Show("Digite o valor do deposito");
            }
            else
            { 
            double valor = Convert.ToDouble(textoValor.Text);
            selecionada.Deposita(valor);
            textoSaldo.Text = Convert.ToString(selecionada.Saldo);
            }
            
                                 
        }

        private void BotaoSaque_Click(object sender, EventArgs e)

        {
            int indice = comboContas.SelectedIndex;
            Conta selecionada = this.contas[indice];
            double valor = Convert.ToDouble(textoValor.Text);
            selecionada.Saca(valor);
            textoSaldo.Text = Convert.ToString(selecionada.Saldo);
        }

        private void Label2_Click(object sender, EventArgs e)
        {
            
        }

        private void BotaoNoperacao_Click(object sender, EventArgs e)
        {
            textoSaldo.Clear();
            textoNumero.Clear();
            textoTitular.Clear();
            textoValor.Clear();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Form4 form4 = new Form4();
            form4.Show();

        }

        public void Button2_Click(object sender, EventArgs e)
        {

            Form3 form3 = new Form3();
            form3.Show();

            
        }

        private void PoupançaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form3 form3 = new Form3();
            form3.Show();
        }

        public void ContaCorrenteToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
        }

        private void SairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Poupanca_Click(object sender, EventArgs e)
        {            
            this.contapoupanca = new ContaPoupanca();
            Conta cp = new Conta();
            string valorDigitado = textoValor.Text;
            double valorOperacao = Convert.ToDouble(valorDigitado);
            this.contapoupanca.Saca(valorOperacao);
          //  textoSaldo.Text = Convert.ToString(this.conta.Saldo);
         //   MessageBox.Show("Saque realizado com Sucesso");
        }

        private void Array_Click(object sender, EventArgs e)
        {
            Form5 form5 = new Form5();
            form5.Show();
        }

        private void Cadastrar_Click(object sender, EventArgs e)
        {
            FormCadastroConta formcadastroconta = new FormCadastroConta(this);
            formcadastroconta.ShowDialog();
        }

       
        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void BotaoBusca_Click(object sender, EventArgs e)
        {
            int indice = Convert.ToInt32(textoIndice.Text);
            Conta selecionada = this.contas[indice];
            textoNumero.Text = Convert.ToString(selecionada.Numero);
            textoTitular.Text = selecionada.Titular.Nome;
            textoSaldo.Text = Convert.ToString(selecionada.Saldo);

        }

        private void ComboContas_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            int indice = comboContas.SelectedIndex;
            Conta selecionada = this.contas[indice];
            textoTitular.Text = selecionada.Titular.Nome;
            textoSaldo.Text = Convert.ToString(selecionada.Saldo);
            textoNumero.Text = Convert.ToString(selecionada.Numero);

        }

        private void TextoTributo_Click(object sender, EventArgs e)
        {
            int indice = comboContas.SelectedIndex;
            Conta selecionada = this.contas[indice];
            double valor = Convert.ToDouble(textoValor.Text);
            selecionada.CalculaTributo();
            textoTr.Text = Convert.ToString(selecionada.Tributo);
        }

        
    }
}
