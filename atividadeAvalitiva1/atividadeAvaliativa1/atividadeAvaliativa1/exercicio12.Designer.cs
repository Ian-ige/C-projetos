namespace atividadeAvaliativa1
{
    partial class exercicio12
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
            this.label2 = new System.Windows.Forms.Label();
            this.txtAcertos = new System.Windows.Forms.TextBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.lblErros = new System.Windows.Forms.Label();
            this.lblporcentagemAcertos = new System.Windows.Forms.Label();
            this.lblporcentagemErros = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(316, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "10 QUESTOES";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(316, 149);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "NUMERO DE ACERTOS:";
            // 
            // txtAcertos
            // 
            this.txtAcertos.Location = new System.Drawing.Point(329, 189);
            this.txtAcertos.Name = "txtAcertos";
            this.txtAcertos.Size = new System.Drawing.Size(100, 20);
            this.txtAcertos.TabIndex = 2;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(343, 246);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(75, 23);
            this.btnCalcular.TabIndex = 3;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // lblErros
            // 
            this.lblErros.AutoSize = true;
            this.lblErros.Location = new System.Drawing.Point(356, 334);
            this.lblErros.Name = "lblErros";
            this.lblErros.Size = new System.Drawing.Size(10, 13);
            this.lblErros.TabIndex = 4;
            this.lblErros.Text = ".";
            // 
            // lblporcentagemAcertos
            // 
            this.lblporcentagemAcertos.AutoSize = true;
            this.lblporcentagemAcertos.Location = new System.Drawing.Point(356, 347);
            this.lblporcentagemAcertos.Name = "lblporcentagemAcertos";
            this.lblporcentagemAcertos.Size = new System.Drawing.Size(10, 13);
            this.lblporcentagemAcertos.TabIndex = 5;
            this.lblporcentagemAcertos.Text = ".";
            // 
            // lblporcentagemErros
            // 
            this.lblporcentagemErros.AutoSize = true;
            this.lblporcentagemErros.Location = new System.Drawing.Point(356, 369);
            this.lblporcentagemErros.Name = "lblporcentagemErros";
            this.lblporcentagemErros.Size = new System.Drawing.Size(10, 13);
            this.lblporcentagemErros.TabIndex = 6;
            this.lblporcentagemErros.Text = ".";
            // 
            // exercicio12
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblporcentagemErros);
            this.Controls.Add(this.lblporcentagemAcertos);
            this.Controls.Add(this.lblErros);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.txtAcertos);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "exercicio12";
            this.Text = "exercicio12";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtAcertos;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Label lblErros;
        private System.Windows.Forms.Label lblporcentagemAcertos;
        private System.Windows.Forms.Label lblporcentagemErros;
    }
}