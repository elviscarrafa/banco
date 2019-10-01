namespace Banco
{
    partial class Form3
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.botaoNoperacao = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.botaoSaque = new System.Windows.Forms.Button();
            this.botaoDeposita = new System.Windows.Forms.Button();
            this.textoValor = new System.Windows.Forms.TextBox();
            this.textoSaldo = new System.Windows.Forms.TextBox();
            this.textoNumero = new System.Windows.Forms.TextBox();
            this.textoTitular = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.operaçãoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contaCorrenteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.poupançaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.poupanca = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.Deposita = new System.Windows.Forms.Button();
            this.textoValor1 = new System.Windows.Forms.TextBox();
            this.textoSaldo2 = new System.Windows.Forms.TextBox();
            this.textoNumero3 = new System.Windows.Forms.TextBox();
            this.textoTitular4 = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // botaoNoperacao
            // 
            this.botaoNoperacao.Location = new System.Drawing.Point(307, 188);
            this.botaoNoperacao.Name = "botaoNoperacao";
            this.botaoNoperacao.Size = new System.Drawing.Size(115, 29);
            this.botaoNoperacao.TabIndex = 10;
            this.botaoNoperacao.Text = "Nova Operação";
            this.botaoNoperacao.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(61, 99);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Saldo Final";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(61, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Conta";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(61, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Cliente";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(61, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Valor";
            // 
            // botaoSaque
            // 
            this.botaoSaque.Location = new System.Drawing.Point(190, 188);
            this.botaoSaque.Name = "botaoSaque";
            this.botaoSaque.Size = new System.Drawing.Size(94, 30);
            this.botaoSaque.TabIndex = 5;
            this.botaoSaque.Text = "Sacar";
            this.botaoSaque.UseVisualStyleBackColor = true;
            this.botaoSaque.Click += new System.EventHandler(this.BotaoSaque_Click_1);
            // 
            // botaoDeposita
            // 
            this.botaoDeposita.Location = new System.Drawing.Point(17, 185);
            this.botaoDeposita.Name = "botaoDeposita";
            this.botaoDeposita.Size = new System.Drawing.Size(103, 33);
            this.botaoDeposita.TabIndex = 4;
            this.botaoDeposita.Text = "Deposita";
            this.botaoDeposita.UseVisualStyleBackColor = true;
            this.botaoDeposita.Click += new System.EventHandler(this.BotaoDeposita_Click);
            // 
            // textoValor
            // 
            this.textoValor.Location = new System.Drawing.Point(152, 14);
            this.textoValor.Name = "textoValor";
            this.textoValor.Size = new System.Drawing.Size(92, 20);
            this.textoValor.TabIndex = 3;
            // 
            // textoSaldo
            // 
            this.textoSaldo.Location = new System.Drawing.Point(152, 92);
            this.textoSaldo.Name = "textoSaldo";
            this.textoSaldo.Size = new System.Drawing.Size(92, 20);
            this.textoSaldo.TabIndex = 2;
            // 
            // textoNumero
            // 
            this.textoNumero.Location = new System.Drawing.Point(152, 66);
            this.textoNumero.Name = "textoNumero";
            this.textoNumero.Size = new System.Drawing.Size(92, 20);
            this.textoNumero.TabIndex = 1;
            // 
            // textoTitular
            // 
            this.textoTitular.Location = new System.Drawing.Point(152, 40);
            this.textoTitular.Name = "textoTitular";
            this.textoTitular.Size = new System.Drawing.Size(92, 20);
            this.textoTitular.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.operaçãoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(808, 24);
            this.menuStrip1.TabIndex = 17;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // operaçãoToolStripMenuItem
            // 
            this.operaçãoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.contaCorrenteToolStripMenuItem,
            this.poupançaToolStripMenuItem});
            this.operaçãoToolStripMenuItem.Name = "operaçãoToolStripMenuItem";
            this.operaçãoToolStripMenuItem.Size = new System.Drawing.Size(70, 20);
            this.operaçãoToolStripMenuItem.Text = "Operação";
            // 
            // contaCorrenteToolStripMenuItem
            // 
            this.contaCorrenteToolStripMenuItem.Name = "contaCorrenteToolStripMenuItem";
            this.contaCorrenteToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.contaCorrenteToolStripMenuItem.Text = "Conta Corrente";
            this.contaCorrenteToolStripMenuItem.Click += new System.EventHandler(this.ContaCorrenteToolStripMenuItem_Click);
            // 
            // poupançaToolStripMenuItem
            // 
            this.poupançaToolStripMenuItem.Name = "poupançaToolStripMenuItem";
            this.poupançaToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.poupançaToolStripMenuItem.Text = "Poupança";
            this.poupançaToolStripMenuItem.Click += new System.EventHandler(this.PoupançaToolStripMenuItem_Click_1);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(25, 127);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 19;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(25, 68);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 18;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.poupanca);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.button4);
            this.groupBox1.Controls.Add(this.Deposita);
            this.groupBox1.Controls.Add(this.textoValor1);
            this.groupBox1.Controls.Add(this.textoSaldo2);
            this.groupBox1.Controls.Add(this.textoNumero3);
            this.groupBox1.Controls.Add(this.textoTitular4);
            this.groupBox1.Location = new System.Drawing.Point(182, 14);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(444, 236);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Formulário de Operação";
            // 
            // poupanca
            // 
            this.poupanca.Location = new System.Drawing.Point(311, 135);
            this.poupanca.Name = "poupanca";
            this.poupanca.Size = new System.Drawing.Size(99, 36);
            this.poupanca.TabIndex = 11;
            this.poupanca.Text = "Poupança";
            this.poupanca.UseVisualStyleBackColor = true;
            this.poupanca.Click += new System.EventHandler(this.Poupanca_Click_1);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(307, 188);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(115, 29);
            this.button3.TabIndex = 10;
            this.button3.Text = "Nova Operação";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.Button3_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(61, 99);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Saldo Final";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(61, 73);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Conta";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(61, 43);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(39, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "Cliente";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(61, 21);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(31, 13);
            this.label8.TabIndex = 6;
            this.label8.Text = "Valor";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(190, 188);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(94, 30);
            this.button4.TabIndex = 5;
            this.button4.Text = "Sacar";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.Button4_Click);
            // 
            // Deposita
            // 
            this.Deposita.Location = new System.Drawing.Point(17, 185);
            this.Deposita.Name = "Deposita";
            this.Deposita.Size = new System.Drawing.Size(103, 33);
            this.Deposita.TabIndex = 4;
            this.Deposita.Text = "Deposita";
            this.Deposita.UseVisualStyleBackColor = true;
            this.Deposita.Click += new System.EventHandler(this.Button5_Click);
            // 
            // textoValor1
            // 
            this.textoValor1.Location = new System.Drawing.Point(152, 14);
            this.textoValor1.Name = "textoValor1";
            this.textoValor1.Size = new System.Drawing.Size(92, 20);
            this.textoValor1.TabIndex = 3;
            // 
            // textoSaldo2
            // 
            this.textoSaldo2.Location = new System.Drawing.Point(152, 92);
            this.textoSaldo2.Name = "textoSaldo2";
            this.textoSaldo2.Size = new System.Drawing.Size(92, 20);
            this.textoSaldo2.TabIndex = 2;
            // 
            // textoNumero3
            // 
            this.textoNumero3.Location = new System.Drawing.Point(152, 66);
            this.textoNumero3.Name = "textoNumero3";
            this.textoNumero3.Size = new System.Drawing.Size(92, 20);
            this.textoNumero3.TabIndex = 1;
            // 
            // textoTitular4
            // 
            this.textoTitular4.Location = new System.Drawing.Point(152, 40);
            this.textoTitular4.Name = "textoTitular4";
            this.textoTitular4.Size = new System.Drawing.Size(92, 20);
            this.textoTitular4.TabIndex = 0;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(808, 265);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button botaoNoperacao;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button botaoSaque;
        private System.Windows.Forms.Button botaoDeposita;
        private System.Windows.Forms.TextBox textoValor;
        private System.Windows.Forms.TextBox textoSaldo;
        private System.Windows.Forms.TextBox textoNumero;
        private System.Windows.Forms.TextBox textoTitular;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem operaçãoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem contaCorrenteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem poupançaToolStripMenuItem;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button poupanca;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button Deposita;
        private System.Windows.Forms.TextBox textoValor1;
        private System.Windows.Forms.TextBox textoSaldo2;
        private System.Windows.Forms.TextBox textoNumero3;
        private System.Windows.Forms.TextBox textoTitular4;
    }
}