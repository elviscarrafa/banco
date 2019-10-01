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
    public partial class Form5 : Form
    {
        private Conta[] contas;

        public Form5()
        {
            InitializeComponent();
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

        private void Form5_Load(object sender, EventArgs e)
        {
            contas = new Conta[3];

            this.contas[0] = new Conta();
            this.contas[0].Titular = new Cliente("Victor");
            this.contas[0].Numero = 1;

            this.contas[1] = new Conta();
            this.contas[1].Titular = new Cliente("Mauricio");
            this.contas[1].Numero = 2;

            this.contas[2] = new Conta();
            this.contas[2].Titular = new Cliente("Erick");
            this.contas[2].Numero = 3;

            foreach (Conta conta in contas)
            {
                comboContas.Items.Add(conta.Titular.Nome);
            }
                      
        }

        private void BotaoBusca_Click(object sender, EventArgs e)
        {
        
           foreach(Conta conta in contas)
            {
                comboContas.Items.Add(conta.Titular.Nome);
            }
        }

        private void BotaoDeposita_Click(object sender, EventArgs e)
        {
            int indice = comboContas.SelectedIndex;
            Conta selecionada = this.contas[indice];
            double valor = Convert.ToDouble(textoValor.Text);
            selecionada.Deposita(valor);
            textoSaldo.Text = Convert.ToString(selecionada.Saldo);
                       
        }

        private void BotaoSaque_Click(object sender, EventArgs e)
        {

            int indice = comboContas.SelectedIndex;
            Conta selecionada = this.contas[indice];
            double valor = Convert.ToDouble(textoValor.Text);
            selecionada.Saca(valor);
            textoSaldo.Text = Convert.ToString(selecionada.Saldo);
                      
        }

        private void BotaoNoperacao_Click(object sender, EventArgs e)
        {
            
            textoSaldo.Clear();
            textoNumero.Clear();
            textoTitular.Clear();
            textoValor.Clear();
        }

        private void ComboContas_SelectedIndexChanged(object sender, EventArgs e)
        {
            int indice = comboContas.SelectedIndex;
            Conta selecionada = contas[indice];
            textoTitular.Text = selecionada.Titular.Nome;
            textoSaldo.Text = Convert.ToString(selecionada.Saldo);
            textoNumero.Text = Convert.ToString(selecionada.Numero);

        }
    }
}
