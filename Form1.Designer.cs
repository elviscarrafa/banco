namespace Banco
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.textoTitular = new System.Windows.Forms.TextBox();
            this.textoNumero = new System.Windows.Forms.TextBox();
            this.textoSaldo = new System.Windows.Forms.TextBox();
            this.textoValor = new System.Windows.Forms.TextBox();
            this.botaoDeposita = new System.Windows.Forms.Button();
            this.botaoSaque = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textoTributo = new System.Windows.Forms.Button();
            this.poupanca = new System.Windows.Forms.Button();
            this.botaoNoperacao = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.contaCorrenteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.poupançaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.contaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.poupancaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button2 = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.operaçãoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contaCorrenteToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.poupançaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Array = new System.Windows.Forms.Button();
            this.Cadastrar = new System.Windows.Forms.Button();
            this.botaoBusca = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.comboContas = new System.Windows.Forms.ComboBox();
            this.textoIndice = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textoTr = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textoTitular
            // 
            this.textoTitular.Location = new System.Drawing.Point(152, 40);
            this.textoTitular.Name = "textoTitular";
            this.textoTitular.Size = new System.Drawing.Size(92, 20);
            this.textoTitular.TabIndex = 0;
            // 
            // textoNumero
            // 
            this.textoNumero.Location = new System.Drawing.Point(152, 66);
            this.textoNumero.Name = "textoNumero";
            this.textoNumero.Size = new System.Drawing.Size(92, 20);
            this.textoNumero.TabIndex = 1;
            // 
            // textoSaldo
            // 
            this.textoSaldo.Location = new System.Drawing.Point(152, 92);
            this.textoSaldo.Name = "textoSaldo";
            this.textoSaldo.Size = new System.Drawing.Size(92, 20);
            this.textoSaldo.TabIndex = 2;
            // 
            // textoValor
            // 
            this.textoValor.Location = new System.Drawing.Point(152, 14);
            this.textoValor.Name = "textoValor";
            this.textoValor.Size = new System.Drawing.Size(92, 20);
            this.textoValor.TabIndex = 3;
            // 
            // botaoDeposita
            // 
            this.botaoDeposita.Location = new System.Drawing.Point(17, 185);
            this.botaoDeposita.Name = "botaoDeposita";
            this.botaoDeposita.Size = new System.Drawing.Size(103, 33);
            this.botaoDeposita.TabIndex = 4;
            this.botaoDeposita.Text = "Deposita";
            this.botaoDeposita.UseVisualStyleBackColor = true;
            this.botaoDeposita.Click += new System.EventHandler(this.botaoDeposito_Click);
            // 
            // botaoSaque
            // 
            this.botaoSaque.Location = new System.Drawing.Point(190, 188);
            this.botaoSaque.Name = "botaoSaque";
            this.botaoSaque.Size = new System.Drawing.Size(94, 30);
            this.botaoSaque.TabIndex = 5;
            this.botaoSaque.Text = "Sacar";
            this.botaoSaque.UseVisualStyleBackColor = true;
            this.botaoSaque.Click += new System.EventHandler(this.BotaoSaque_Click);
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(61, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Cliente";
            this.label2.Click += new System.EventHandler(this.Label2_Click);
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
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(61, 99);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Saldo Final";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textoTr);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.textoTributo);
            this.groupBox1.Controls.Add(this.poupanca);
            this.groupBox1.Controls.Add(this.botaoNoperacao);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.botaoSaque);
            this.groupBox1.Controls.Add(this.botaoDeposita);
            this.groupBox1.Controls.Add(this.textoValor);
            this.groupBox1.Controls.Add(this.textoSaldo);
            this.groupBox1.Controls.Add(this.textoNumero);
            this.groupBox1.Controls.Add(this.textoTitular);
            this.groupBox1.Location = new System.Drawing.Point(158, 34);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(444, 236);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Formulário de Operação";
            // 
            // textoTributo
            // 
            this.textoTributo.Location = new System.Drawing.Point(311, 92);
            this.textoTributo.Name = "textoTributo";
            this.textoTributo.Size = new System.Drawing.Size(99, 36);
            this.textoTributo.TabIndex = 12;
            this.textoTributo.Text = "Tributo";
            this.textoTributo.UseVisualStyleBackColor = true;
            this.textoTributo.Click += new System.EventHandler(this.TextoTributo_Click);
            // 
            // poupanca
            // 
            this.poupanca.Location = new System.Drawing.Point(311, 135);
            this.poupanca.Name = "poupanca";
            this.poupanca.Size = new System.Drawing.Size(99, 36);
            this.poupanca.TabIndex = 11;
            this.poupanca.Text = "Poupança";
            this.poupanca.UseVisualStyleBackColor = true;
            this.poupanca.Click += new System.EventHandler(this.Poupanca_Click);
            // 
            // botaoNoperacao
            // 
            this.botaoNoperacao.Location = new System.Drawing.Point(307, 188);
            this.botaoNoperacao.Name = "botaoNoperacao";
            this.botaoNoperacao.Size = new System.Drawing.Size(115, 29);
            this.botaoNoperacao.TabIndex = 10;
            this.botaoNoperacao.Text = "Nova Operação";
            this.botaoNoperacao.UseVisualStyleBackColor = true;
            this.botaoNoperacao.Click += new System.EventHandler(this.BotaoNoperacao_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(25, 67);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(97, 23);
            this.button1.TabIndex = 11;
            this.button1.Text = "Novo ";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // contaCorrenteToolStripMenuItem
            // 
            this.contaCorrenteToolStripMenuItem.Name = "contaCorrenteToolStripMenuItem";
            this.contaCorrenteToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
            // 
            // poupançaToolStripMenuItem1
            // 
            this.poupançaToolStripMenuItem1.Name = "poupançaToolStripMenuItem1";
            this.poupançaToolStripMenuItem1.Size = new System.Drawing.Size(32, 19);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(420, 2);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(162, 20);
            this.dateTimePicker1.TabIndex = 12;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.contaToolStripMenuItem,
            this.poupancaToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(128, 48);
            // 
            // contaToolStripMenuItem
            // 
            this.contaToolStripMenuItem.Name = "contaToolStripMenuItem";
            this.contaToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.contaToolStripMenuItem.Text = "Conta";
            // 
            // poupancaToolStripMenuItem
            // 
            this.poupancaToolStripMenuItem.Name = "poupancaToolStripMenuItem";
            this.poupancaToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.poupancaToolStripMenuItem.Text = "Poupanca";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(25, 102);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(97, 23);
            this.button2.TabIndex = 14;
            this.button2.Text = "Poupança";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.operaçãoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(908, 24);
            this.menuStrip1.TabIndex = 15;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // operaçãoToolStripMenuItem
            // 
            this.operaçãoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.contaCorrenteToolStripMenuItem1,
            this.poupançaToolStripMenuItem,
            this.sairToolStripMenuItem});
            this.operaçãoToolStripMenuItem.Name = "operaçãoToolStripMenuItem";
            this.operaçãoToolStripMenuItem.Size = new System.Drawing.Size(70, 20);
            this.operaçãoToolStripMenuItem.Text = "Operação";
            // 
            // contaCorrenteToolStripMenuItem1
            // 
            this.contaCorrenteToolStripMenuItem1.Name = "contaCorrenteToolStripMenuItem1";
            this.contaCorrenteToolStripMenuItem1.Size = new System.Drawing.Size(155, 22);
            this.contaCorrenteToolStripMenuItem1.Text = "Conta Corrente";
            this.contaCorrenteToolStripMenuItem1.Click += new System.EventHandler(this.ContaCorrenteToolStripMenuItem1_Click);
            // 
            // poupançaToolStripMenuItem
            // 
            this.poupançaToolStripMenuItem.Name = "poupançaToolStripMenuItem";
            this.poupançaToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.poupançaToolStripMenuItem.Text = "Poupança";
            this.poupançaToolStripMenuItem.Click += new System.EventHandler(this.PoupançaToolStripMenuItem_Click);
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.sairToolStripMenuItem.Text = "Sair";
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.SairToolStripMenuItem_Click);
            // 
            // Array
            // 
            this.Array.Location = new System.Drawing.Point(25, 144);
            this.Array.Name = "Array";
            this.Array.Size = new System.Drawing.Size(97, 23);
            this.Array.TabIndex = 16;
            this.Array.Text = "Array";
            this.Array.UseVisualStyleBackColor = true;
            this.Array.Click += new System.EventHandler(this.Array_Click);
            // 
            // Cadastrar
            // 
            this.Cadastrar.Location = new System.Drawing.Point(25, 182);
            this.Cadastrar.Name = "Cadastrar";
            this.Cadastrar.Size = new System.Drawing.Size(97, 23);
            this.Cadastrar.TabIndex = 17;
            this.Cadastrar.Text = "Cadastrar Conta";
            this.Cadastrar.UseVisualStyleBackColor = true;
            this.Cadastrar.Click += new System.EventHandler(this.Cadastrar_Click);
            // 
            // botaoBusca
            // 
            this.botaoBusca.Location = new System.Drawing.Point(793, 55);
            this.botaoBusca.Name = "botaoBusca";
            this.botaoBusca.Size = new System.Drawing.Size(94, 38);
            this.botaoBusca.TabIndex = 18;
            this.botaoBusca.Text = "Buscar";
            this.botaoBusca.UseVisualStyleBackColor = true;
            this.botaoBusca.Click += new System.EventHandler(this.BotaoBusca_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(608, 80);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Escolha a Conta";
            // 
            // comboContas
            // 
            this.comboContas.FormattingEnabled = true;
            this.comboContas.Location = new System.Drawing.Point(699, 72);
            this.comboContas.Name = "comboContas";
            this.comboContas.Size = new System.Drawing.Size(88, 21);
            this.comboContas.TabIndex = 19;
            this.comboContas.SelectedIndexChanged += new System.EventHandler(this.ComboContas_SelectedIndexChanged_1);
            // 
            // textoIndice
            // 
            this.textoIndice.Location = new System.Drawing.Point(695, 27);
            this.textoIndice.Name = "textoIndice";
            this.textoIndice.Size = new System.Drawing.Size(92, 20);
            this.textoIndice.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(61, 120);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Tributo";
            // 
            // textoTr
            // 
            this.textoTr.Location = new System.Drawing.Point(152, 113);
            this.textoTr.Name = "textoTr";
            this.textoTr.Size = new System.Drawing.Size(92, 20);
            this.textoTr.TabIndex = 14;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(908, 270);
            this.Controls.Add(this.textoIndice);
            this.Controls.Add(this.comboContas);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.botaoBusca);
            this.Controls.Add(this.Cadastrar);
            this.Controls.Add(this.Array);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textoTitular;
        private System.Windows.Forms.TextBox textoNumero;
        private System.Windows.Forms.TextBox textoSaldo;
        private System.Windows.Forms.TextBox textoValor;
        private System.Windows.Forms.Button botaoDeposita;
        private System.Windows.Forms.Button botaoSaque;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button botaoNoperacao;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ToolStripMenuItem contaCorrenteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem poupançaToolStripMenuItem1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem contaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem poupancaToolStripMenuItem;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem operaçãoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem contaCorrenteToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem poupançaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.Button poupanca;
        private System.Windows.Forms.Button Array;
        private System.Windows.Forms.Button Cadastrar;
        private System.Windows.Forms.Button botaoBusca;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboContas;
        private System.Windows.Forms.TextBox textoIndice;
        private System.Windows.Forms.Button textoTributo;
        private System.Windows.Forms.TextBox textoTr;
        private System.Windows.Forms.Label label6;
    }
}

