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
    public partial class FormCadastroConta : Form
    {
      
        private Form1 formPrincipal;

        public FormCadastroConta (Form1 formPrincipal)
        {
             this.formPrincipal = formPrincipal;
             InitializeComponent();

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void BotaoCadastro_Click(object sender, EventArgs e)
        {
            Conta novaConta = new Conta();
            novaConta.Titular = new Cliente(textoTitular.Text);
            novaConta.Numero = Convert.ToInt32(textoNumero.Text);

            this.formPrincipal.AdicionaConta(novaConta);
            MessageBox.Show("Cadastro realizado com sucesso");
            Console.WriteLine("ok");


        }

        private void BotaoNovo_Click(object sender, EventArgs e)
        {
            textoNumero.Clear();
            textoTitular.Clear();

        }
    }
}
