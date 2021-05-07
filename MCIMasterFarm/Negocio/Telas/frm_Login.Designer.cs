
namespace MCIMasterFarm
{
    partial class frn_MCILogin
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
            this.txt_Usuario = new System.Windows.Forms.TextBox();
            this.txt_Senha = new System.Windows.Forms.TextBox();
            this.frame_Acesso = new System.Windows.Forms.GroupBox();
            this.btn_Acessar = new System.Windows.Forms.Button();
            this.btn_Esquecer = new System.Windows.Forms.Button();
            this.lbl_Senha = new System.Windows.Forms.Label();
            this.lbl_Usuario = new System.Windows.Forms.Label();
            this.frame_Acesso.SuspendLayout();
            this.SuspendLayout();
            // 
            // txt_Usuario
            // 
            this.txt_Usuario.Location = new System.Drawing.Point(117, 35);
            this.txt_Usuario.Name = "txt_Usuario";
            this.txt_Usuario.Size = new System.Drawing.Size(235, 20);
            this.txt_Usuario.TabIndex = 0;
            // 
            // txt_Senha
            // 
            this.txt_Senha.Location = new System.Drawing.Point(109, 55);
            this.txt_Senha.Name = "txt_Senha";
            this.txt_Senha.PasswordChar = '*';
            this.txt_Senha.Size = new System.Drawing.Size(235, 20);
            this.txt_Senha.TabIndex = 1;
            // 
            // frame_Acesso
            // 
            this.frame_Acesso.Controls.Add(this.btn_Acessar);
            this.frame_Acesso.Controls.Add(this.btn_Esquecer);
            this.frame_Acesso.Controls.Add(this.lbl_Senha);
            this.frame_Acesso.Controls.Add(this.lbl_Usuario);
            this.frame_Acesso.Controls.Add(this.txt_Senha);
            this.frame_Acesso.Location = new System.Drawing.Point(8, 1);
            this.frame_Acesso.Name = "frame_Acesso";
            this.frame_Acesso.Size = new System.Drawing.Size(417, 122);
            this.frame_Acesso.TabIndex = 4;
            this.frame_Acesso.TabStop = false;
            this.frame_Acesso.Text = "Login";
            // 
            // btn_Acessar
            // 
            this.btn_Acessar.Image = global::MCIMasterFarm.Properties.Resources.icons8_entrar_24;
            this.btn_Acessar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Acessar.Location = new System.Drawing.Point(109, 78);
            this.btn_Acessar.Name = "btn_Acessar";
            this.btn_Acessar.Size = new System.Drawing.Size(103, 29);
            this.btn_Acessar.TabIndex = 2;
            this.btn_Acessar.Text = "Acessar";
            this.btn_Acessar.UseVisualStyleBackColor = true;
            this.btn_Acessar.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_Esquecer
            // 
            this.btn_Esquecer.Image = global::MCIMasterFarm.Properties.Resources.icons8_esqueci_a_senha_24;
            this.btn_Esquecer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Esquecer.Location = new System.Drawing.Point(218, 78);
            this.btn_Esquecer.Name = "btn_Esquecer";
            this.btn_Esquecer.Size = new System.Drawing.Size(126, 29);
            this.btn_Esquecer.TabIndex = 3;
            this.btn_Esquecer.Text = "Esqueci a Senha";
            this.btn_Esquecer.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Esquecer.UseVisualStyleBackColor = true;
            this.btn_Esquecer.Click += new System.EventHandler(this.button2_Click);
            // 
            // lbl_Senha
            // 
            this.lbl_Senha.AutoSize = true;
            this.lbl_Senha.Location = new System.Drawing.Point(30, 60);
            this.lbl_Senha.Name = "lbl_Senha";
            this.lbl_Senha.Size = new System.Drawing.Size(38, 13);
            this.lbl_Senha.TabIndex = 1;
            this.lbl_Senha.Text = "Senha";
            // 
            // lbl_Usuario
            // 
            this.lbl_Usuario.AutoSize = true;
            this.lbl_Usuario.Location = new System.Drawing.Point(30, 34);
            this.lbl_Usuario.Name = "lbl_Usuario";
            this.lbl_Usuario.Size = new System.Drawing.Size(43, 13);
            this.lbl_Usuario.TabIndex = 0;
            this.lbl_Usuario.Text = "Usuário";
            // 
            // frn_MCILogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(426, 127);
            this.Controls.Add(this.txt_Usuario);
            this.Controls.Add(this.frame_Acesso);
            this.Name = "frn_MCILogin";
            this.Text = "MCI Acesso";
            this.frame_Acesso.ResumeLayout(false);
            this.frame_Acesso.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txt_Senha;
        private System.Windows.Forms.Button btn_Acessar;
        private System.Windows.Forms.Button btn_Esquecer;
        private System.Windows.Forms.GroupBox frame_Acesso;
        private System.Windows.Forms.Label lbl_Usuario;
        private System.Windows.Forms.Label lbl_Senha;
        private System.Windows.Forms.TextBox txt_Usuario;
    }
}

