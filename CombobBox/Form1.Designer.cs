namespace CombobBox
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
            this.cmbEscolha = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnEscolha = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.lblMensaagem = new System.Windows.Forms.Label();
            this.textBoxNome = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cmbEscolha
            // 
            this.cmbEscolha.FormattingEnabled = true;
            this.cmbEscolha.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "",
            "",
            "",
            "",
            "",
            "",
            ""});
            this.cmbEscolha.Location = new System.Drawing.Point(232, 87);
            this.cmbEscolha.Name = "cmbEscolha";
            this.cmbEscolha.Size = new System.Drawing.Size(121, 28);
            this.cmbEscolha.TabIndex = 0;
            this.cmbEscolha.SelectedIndexChanged += new System.EventHandler(this.cmbEscolha_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(2, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(224, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Escolha um número de 1 a 12:";
            // 
            // btnEscolha
            // 
            this.btnEscolha.Location = new System.Drawing.Point(12, 132);
            this.btnEscolha.Name = "btnEscolha";
            this.btnEscolha.Size = new System.Drawing.Size(312, 44);
            this.btnEscolha.TabIndex = 2;
            this.btnEscolha.Text = "Escolham numero e clique aqui!";
            this.btnEscolha.UseVisualStyleBackColor = true;
            this.btnEscolha.Click += new System.EventHandler(this.btnEscolha_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(261, 242);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(92, 34);
            this.button2.TabIndex = 3;
            this.button2.Text = "SAIR";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // lblMensaagem
            // 
            this.lblMensaagem.AutoSize = true;
            this.lblMensaagem.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lblMensaagem.Location = new System.Drawing.Point(12, 189);
            this.lblMensaagem.Name = "lblMensaagem";
            this.lblMensaagem.Size = new System.Drawing.Size(89, 36);
            this.lblMensaagem.TabIndex = 4;
            this.lblMensaagem.Text = "Texto";
            this.lblMensaagem.Click += new System.EventHandler(this.label2_Click);
            // 
            // textBoxNome
            // 
            this.textBoxNome.Location = new System.Drawing.Point(188, 44);
            this.textBoxNome.Name = "textBoxNome";
            this.textBoxNome.Size = new System.Drawing.Size(122, 26);
            this.textBoxNome.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(2, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(180, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Coloque seu nome aqui:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(558, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Digite seu Nome:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1035, 355);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxNome);
            this.Controls.Add(this.lblMensaagem);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnEscolha);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbEscolha);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbEscolha;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnEscolha;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label lblMensaagem;
        private System.Windows.Forms.TextBox textBoxNome;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

