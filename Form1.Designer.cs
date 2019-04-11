namespace Socket_Cliente
{
    partial class Frm_Cliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Cliente));
            this.Txt_Cliente = new System.Windows.Forms.TextBox();
            this.Btn_Cliente = new System.Windows.Forms.Button();
            this.Lbl_Cliente = new System.Windows.Forms.Label();
            this.Lbl_Servidor = new System.Windows.Forms.Label();
            this.Lbl_Resposta = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Txt_Cliente
            // 
            this.Txt_Cliente.Location = new System.Drawing.Point(15, 49);
            this.Txt_Cliente.Name = "Txt_Cliente";
            this.Txt_Cliente.Size = new System.Drawing.Size(137, 20);
            this.Txt_Cliente.TabIndex = 0;
            // 
            // Btn_Cliente
            // 
            this.Btn_Cliente.Location = new System.Drawing.Point(15, 87);
            this.Btn_Cliente.Name = "Btn_Cliente";
            this.Btn_Cliente.Size = new System.Drawing.Size(137, 23);
            this.Btn_Cliente.TabIndex = 1;
            this.Btn_Cliente.Text = "Enviar";
            this.Btn_Cliente.UseVisualStyleBackColor = true;
            this.Btn_Cliente.Click += new System.EventHandler(this.Btn_Cliente_Click);
            // 
            // Lbl_Cliente
            // 
            this.Lbl_Cliente.AutoSize = true;
            this.Lbl_Cliente.Location = new System.Drawing.Point(12, 24);
            this.Lbl_Cliente.Name = "Lbl_Cliente";
            this.Lbl_Cliente.Size = new System.Drawing.Size(140, 13);
            this.Lbl_Cliente.TabIndex = 2;
            this.Lbl_Cliente.Text = "Informe o Token de acesso:";
            // 
            // Lbl_Servidor
            // 
            this.Lbl_Servidor.AutoSize = true;
            this.Lbl_Servidor.Location = new System.Drawing.Point(168, 24);
            this.Lbl_Servidor.Name = "Lbl_Servidor";
            this.Lbl_Servidor.Size = new System.Drawing.Size(115, 13);
            this.Lbl_Servidor.TabIndex = 3;
            this.Lbl_Servidor.Text = "Resposta do Servidor :";
            // 
            // Lbl_Resposta
            // 
            this.Lbl_Resposta.AutoSize = true;
            this.Lbl_Resposta.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Resposta.ForeColor = System.Drawing.Color.Black;
            this.Lbl_Resposta.Location = new System.Drawing.Point(282, 24);
            this.Lbl_Resposta.Name = "Lbl_Resposta";
            this.Lbl_Resposta.Size = new System.Drawing.Size(60, 13);
            this.Lbl_Resposta.TabIndex = 4;
            this.Lbl_Resposta.Text = "Resposta";
            this.Lbl_Resposta.Visible = false;
            // 
            // Frm_Cliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(356, 120);
            this.Controls.Add(this.Lbl_Resposta);
            this.Controls.Add(this.Lbl_Servidor);
            this.Controls.Add(this.Lbl_Cliente);
            this.Controls.Add(this.Btn_Cliente);
            this.Controls.Add(this.Txt_Cliente);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Frm_Cliente";
            this.Text = "TCPClient";
            this.Load += new System.EventHandler(this.Frm_Cliente_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Txt_Cliente;
        private System.Windows.Forms.Button Btn_Cliente;
        private System.Windows.Forms.Label Lbl_Cliente;
        private System.Windows.Forms.Label Lbl_Servidor;
        private System.Windows.Forms.Label Lbl_Resposta;
    }
}

