namespace ProjetoAtleta
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
            this.lbl_nome = new System.Windows.Forms.Label();
            this.txt_nome = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_altura = new System.Windows.Forms.TextBox();
            this.lbl_peso = new System.Windows.Forms.Label();
            this.txt_peso = new System.Windows.Forms.TextBox();
            this.lbl_idade = new System.Windows.Forms.Label();
            this.txt_idade = new System.Windows.Forms.TextBox();
            this.btn_calcular = new System.Windows.Forms.Button();
            this.btn_enviar = new System.Windows.Forms.Button();
            this.txt_IMC = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lbl_nome
            // 
            this.lbl_nome.AutoSize = true;
            this.lbl_nome.Location = new System.Drawing.Point(13, 13);
            this.lbl_nome.Name = "lbl_nome";
            this.lbl_nome.Size = new System.Drawing.Size(84, 13);
            this.lbl_nome.TabIndex = 0;
            this.lbl_nome.Text = "Insira seu nome:";
            // 
            // txt_nome
            // 
            this.txt_nome.Location = new System.Drawing.Point(13, 30);
            this.txt_nome.Name = "txt_nome";
            this.txt_nome.Size = new System.Drawing.Size(100, 20);
            this.txt_nome.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Insira sua altura:";
            // 
            // txt_altura
            // 
            this.txt_altura.Location = new System.Drawing.Point(13, 83);
            this.txt_altura.Name = "txt_altura";
            this.txt_altura.Size = new System.Drawing.Size(100, 20);
            this.txt_altura.TabIndex = 3;
            // 
            // lbl_peso
            // 
            this.lbl_peso.AutoSize = true;
            this.lbl_peso.Location = new System.Drawing.Point(13, 120);
            this.lbl_peso.Name = "lbl_peso";
            this.lbl_peso.Size = new System.Drawing.Size(85, 13);
            this.lbl_peso.TabIndex = 4;
            this.lbl_peso.Text = "Insera seu peso:";
            // 
            // txt_peso
            // 
            this.txt_peso.Location = new System.Drawing.Point(13, 137);
            this.txt_peso.Name = "txt_peso";
            this.txt_peso.Size = new System.Drawing.Size(100, 20);
            this.txt_peso.TabIndex = 5;
            // 
            // lbl_idade
            // 
            this.lbl_idade.AutoSize = true;
            this.lbl_idade.Location = new System.Drawing.Point(13, 173);
            this.lbl_idade.Name = "lbl_idade";
            this.lbl_idade.Size = new System.Drawing.Size(84, 13);
            this.lbl_idade.TabIndex = 6;
            this.lbl_idade.Text = "Insira sua idade:";
            // 
            // txt_idade
            // 
            this.txt_idade.Location = new System.Drawing.Point(13, 190);
            this.txt_idade.Name = "txt_idade";
            this.txt_idade.Size = new System.Drawing.Size(100, 20);
            this.txt_idade.TabIndex = 7;
            // 
            // btn_calcular
            // 
            this.btn_calcular.Location = new System.Drawing.Point(161, 119);
            this.btn_calcular.Name = "btn_calcular";
            this.btn_calcular.Size = new System.Drawing.Size(133, 54);
            this.btn_calcular.TabIndex = 8;
            this.btn_calcular.Text = "Calcular IMC";
            this.btn_calcular.UseVisualStyleBackColor = true;
            this.btn_calcular.Click += new System.EventHandler(this.btn_calcular_Click);
            // 
            // btn_enviar
            // 
            this.btn_enviar.BackColor = System.Drawing.Color.White;
            this.btn_enviar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_enviar.Location = new System.Drawing.Point(161, 30);
            this.btn_enviar.Name = "btn_enviar";
            this.btn_enviar.Size = new System.Drawing.Size(133, 50);
            this.btn_enviar.TabIndex = 9;
            this.btn_enviar.Text = "Enviar";
            this.btn_enviar.UseVisualStyleBackColor = false;
            this.btn_enviar.Click += new System.EventHandler(this.btn_enviar_Click);
            // 
            // txt_IMC
            // 
            this.txt_IMC.Location = new System.Drawing.Point(161, 190);
            this.txt_IMC.Name = "txt_IMC";
            this.txt_IMC.Size = new System.Drawing.Size(100, 20);
            this.txt_IMC.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(306, 220);
            this.Controls.Add(this.txt_IMC);
            this.Controls.Add(this.btn_enviar);
            this.Controls.Add(this.btn_calcular);
            this.Controls.Add(this.txt_idade);
            this.Controls.Add(this.lbl_idade);
            this.Controls.Add(this.txt_peso);
            this.Controls.Add(this.lbl_peso);
            this.Controls.Add(this.txt_altura);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_nome);
            this.Controls.Add(this.lbl_nome);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_nome;
        private System.Windows.Forms.TextBox txt_nome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_altura;
        private System.Windows.Forms.Label lbl_peso;
        private System.Windows.Forms.TextBox txt_peso;
        private System.Windows.Forms.Label lbl_idade;
        private System.Windows.Forms.TextBox txt_idade;
        private System.Windows.Forms.Button btn_calcular;
        private System.Windows.Forms.Button btn_enviar;
        private System.Windows.Forms.TextBox txt_IMC;
    }
}

