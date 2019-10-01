namespace Banco
{
    partial class Form2
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
            this.performanceCounter1 = new System.Diagnostics.PerformanceCounter();
            this.button1 = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.botaoNoperacao = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
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
            this.OperaçãoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contaCorrenteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.poupançaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.performanceCounter1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(25, 132);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 14;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.OperaçãoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(810, 24);
            this.menuStrip1.TabIndex = 15;
            this.menuStrip1.Text = "menuStrip1";
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
            // groupBox1
            // 
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
            this.groupBox1.Location = new System.Drawing.Point(246, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(428, 235);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Formulário de Operação";
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
            // 
            // botaoDeposita
            // 
            this.botaoDeposita.Location = new System.Drawing.Point(17, 185);
            this.botaoDeposita.Name = "botaoDeposita";
            this.botaoDeposita.Size = new System.Drawing.Size(103, 33);
            this.botaoDeposita.TabIndex = 4;
            this.botaoDeposita.Text = "Deposita";
            this.botaoDeposita.UseVisualStyleBackColor = true;
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
            // OperaçãoToolStripMenuItem
            // 
            this.OperaçãoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.contaCorrenteToolStripMenuItem,
            this.poupançaToolStripMenuItem1});
            this.OperaçãoToolStripMenuItem.Name = "OperaçãoToolStripMenuItem";
            this.OperaçãoToolStripMenuItem.Size = new System.Drawing.Size(70, 20);
            this.OperaçãoToolStripMenuItem.Text = "Operação";
            // 
            // contaCorrenteToolStripMenuItem
            // 
            this.contaCorrenteToolStripMenuItem.Name = "contaCorrenteToolStripMenuItem";
            this.contaCorrenteToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.contaCorrenteToolStripMenuItem.Text = "Conta Corrente";
            // 
            // poupançaToolStripMenuItem1
            // 
            this.poupançaToolStripMenuItem1.Name = "poupançaToolStripMenuItem1";
            this.poupançaToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.poupançaToolStripMenuItem1.Text = "Poupança";
            this.poupançaToolStripMenuItem1.Click += new System.EventHandler(this.PoupançaToolStripMenuItem1_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(810, 268);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form2";
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.performanceCounter1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Diagnostics.PerformanceCounter performanceCounter1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Button botaoNoperacao;
        private System.Windows.Forms.GroupBox groupBox1;
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
        private System.Windows.Forms.ToolStripMenuItem OperaçãoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem contaCorrenteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem poupançaToolStripMenuItem1;
    }
}