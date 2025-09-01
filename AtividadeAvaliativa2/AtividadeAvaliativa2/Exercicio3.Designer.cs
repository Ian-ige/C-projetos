namespace AtividadeAvaliativa2
{
    partial class Exercicio3
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
            this.label1 = new System.Windows.Forms.Label();
            this.rbdCorAzul = new System.Windows.Forms.RadioButton();
            this.rbdCorAmarelo = new System.Windows.Forms.RadioButton();
            this.rbdCorVermelho = new System.Windows.Forms.RadioButton();
            this.btnMudaCorDeFundo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(237, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(236, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Selecione uma opçao para trocar a cor de fundo";
            // 
            // rbdCorAzul
            // 
            this.rbdCorAzul.AutoSize = true;
            this.rbdCorAzul.Location = new System.Drawing.Point(105, 155);
            this.rbdCorAzul.Name = "rbdCorAzul";
            this.rbdCorAzul.Size = new System.Drawing.Size(45, 17);
            this.rbdCorAzul.TabIndex = 1;
            this.rbdCorAzul.TabStop = true;
            this.rbdCorAzul.Text = "Azul";
            this.rbdCorAzul.UseVisualStyleBackColor = true;
            // 
            // rbdCorAmarelo
            // 
            this.rbdCorAmarelo.AutoSize = true;
            this.rbdCorAmarelo.Location = new System.Drawing.Point(345, 155);
            this.rbdCorAmarelo.Name = "rbdCorAmarelo";
            this.rbdCorAmarelo.Size = new System.Drawing.Size(63, 17);
            this.rbdCorAmarelo.TabIndex = 2;
            this.rbdCorAmarelo.TabStop = true;
            this.rbdCorAmarelo.Text = "Amarelo";
            this.rbdCorAmarelo.UseVisualStyleBackColor = true;
            // 
            // rbdCorVermelho
            // 
            this.rbdCorVermelho.AutoSize = true;
            this.rbdCorVermelho.Location = new System.Drawing.Point(586, 155);
            this.rbdCorVermelho.Name = "rbdCorVermelho";
            this.rbdCorVermelho.Size = new System.Drawing.Size(69, 17);
            this.rbdCorVermelho.TabIndex = 3;
            this.rbdCorVermelho.TabStop = true;
            this.rbdCorVermelho.Text = "Vermelho";
            this.rbdCorVermelho.UseVisualStyleBackColor = true;
            // 
            // btnMudaCorDeFundo
            // 
            this.btnMudaCorDeFundo.Location = new System.Drawing.Point(217, 283);
            this.btnMudaCorDeFundo.Name = "btnMudaCorDeFundo";
            this.btnMudaCorDeFundo.Size = new System.Drawing.Size(305, 23);
            this.btnMudaCorDeFundo.TabIndex = 4;
            this.btnMudaCorDeFundo.Text = "Mudar cor de fundo";
            this.btnMudaCorDeFundo.UseVisualStyleBackColor = true;
            this.btnMudaCorDeFundo.Click += new System.EventHandler(this.btnMudaCorDeFundo_Click);
            // 
            // Exercicio3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnMudaCorDeFundo);
            this.Controls.Add(this.rbdCorVermelho);
            this.Controls.Add(this.rbdCorAmarelo);
            this.Controls.Add(this.rbdCorAzul);
            this.Controls.Add(this.label1);
            this.Name = "Exercicio3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Exercicio3";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rbdCorAzul;
        private System.Windows.Forms.RadioButton rbdCorAmarelo;
        private System.Windows.Forms.RadioButton rbdCorVermelho;
        private System.Windows.Forms.Button btnMudaCorDeFundo;
    }
}