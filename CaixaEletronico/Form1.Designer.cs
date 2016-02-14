namespace CaixaEletronico
{
    partial class Form1
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
            this.comboContas = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textoTitular = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textoNumero = new System.Windows.Forms.TextBox();
            this.textoSaldo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.botaoSaque = new System.Windows.Forms.Button();
            this.botaoDeposita = new System.Windows.Forms.Button();
            this.textoValor = new System.Windows.Forms.TextBox();
            this.botaoTransferir = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.comboContasDestino = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // comboContas
            // 
            this.comboContas.FormattingEnabled = true;
            this.comboContas.Location = new System.Drawing.Point(70, 99);
            this.comboContas.Name = "comboContas";
            this.comboContas.Size = new System.Drawing.Size(121, 21);
            this.comboContas.TabIndex = 0;
            this.comboContas.SelectedIndexChanged += new System.EventHandler(this.comboContas_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Selecione uma conta de origem:";
            // 
            // textoTitular
            // 
            this.textoTitular.Location = new System.Drawing.Point(91, 156);
            this.textoTitular.Name = "textoTitular";
            this.textoTitular.Size = new System.Drawing.Size(100, 20);
            this.textoTitular.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 156);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Titular";
            // 
            // textoNumero
            // 
            this.textoNumero.Location = new System.Drawing.Point(91, 128);
            this.textoNumero.Name = "textoNumero";
            this.textoNumero.Size = new System.Drawing.Size(100, 20);
            this.textoNumero.TabIndex = 4;
            // 
            // textoSaldo
            // 
            this.textoSaldo.Location = new System.Drawing.Point(91, 182);
            this.textoSaldo.Name = "textoSaldo";
            this.textoSaldo.Size = new System.Drawing.Size(100, 20);
            this.textoSaldo.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Número";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(35, 182);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Saldo";
            // 
            // botaoSaque
            // 
            this.botaoSaque.Location = new System.Drawing.Point(116, 208);
            this.botaoSaque.Name = "botaoSaque";
            this.botaoSaque.Size = new System.Drawing.Size(75, 23);
            this.botaoSaque.TabIndex = 8;
            this.botaoSaque.Text = "Saque";
            this.botaoSaque.UseVisualStyleBackColor = true;
            this.botaoSaque.Click += new System.EventHandler(this.botaoSaque_Click);
            // 
            // botaoDeposita
            // 
            this.botaoDeposita.Location = new System.Drawing.Point(197, 208);
            this.botaoDeposita.Name = "botaoDeposita";
            this.botaoDeposita.Size = new System.Drawing.Size(75, 23);
            this.botaoDeposita.TabIndex = 9;
            this.botaoDeposita.Text = "Deposita";
            this.botaoDeposita.UseVisualStyleBackColor = true;
            this.botaoDeposita.Click += new System.EventHandler(this.botaoDeposita_Click);
            // 
            // textoValor
            // 
            this.textoValor.Location = new System.Drawing.Point(183, 237);
            this.textoValor.Name = "textoValor";
            this.textoValor.Size = new System.Drawing.Size(100, 20);
            this.textoValor.TabIndex = 10;
            // 
            // botaoTransferir
            // 
            this.botaoTransferir.Location = new System.Drawing.Point(278, 208);
            this.botaoTransferir.Name = "botaoTransferir";
            this.botaoTransferir.Size = new System.Drawing.Size(75, 23);
            this.botaoTransferir.TabIndex = 11;
            this.botaoTransferir.Text = "Transferir";
            this.botaoTransferir.UseVisualStyleBackColor = true;
            this.botaoTransferir.Click += new System.EventHandler(this.botaoTransferir_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(200, 83);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(162, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Selecione uma conta de destino:";
            // 
            // comboContasDestino
            // 
            this.comboContasDestino.FormattingEnabled = true;
            this.comboContasDestino.Location = new System.Drawing.Point(235, 99);
            this.comboContasDestino.Name = "comboContasDestino";
            this.comboContasDestino.Size = new System.Drawing.Size(121, 21);
            this.comboContasDestino.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(424, 335);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.comboContasDestino);
            this.Controls.Add(this.botaoTransferir);
            this.Controls.Add(this.textoValor);
            this.Controls.Add(this.botaoDeposita);
            this.Controls.Add(this.botaoSaque);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textoSaldo);
            this.Controls.Add(this.textoNumero);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textoTitular);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboContas);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboContas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textoTitular;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textoNumero;
        private System.Windows.Forms.TextBox textoSaldo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button botaoSaque;
        private System.Windows.Forms.Button botaoDeposita;
        private System.Windows.Forms.TextBox textoValor;
        private System.Windows.Forms.Button botaoTransferir;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboContasDestino;
    }
}

