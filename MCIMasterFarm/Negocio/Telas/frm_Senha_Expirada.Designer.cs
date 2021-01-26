
namespace MCIMasterFarm.Negocio.Telas
{
    partial class frm_Senha_Expirada
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbl_ConfirmaSenha = new System.Windows.Forms.Label();
            this.lbl_NewPwd = new System.Windows.Forms.Label();
            this.lbl_PwdAtual = new System.Windows.Forms.Label();
            this.txtSenhaNova = new System.Windows.Forms.TextBox();
            this.txtSenhaConfirma = new System.Windows.Forms.TextBox();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lbl_Resultado = new System.Windows.Forms.Label();
            this.btnSair = new System.Windows.Forms.Button();
            this.btAlterarSenha = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbl_ConfirmaSenha);
            this.groupBox1.Controls.Add(this.lbl_NewPwd);
            this.groupBox1.Controls.Add(this.lbl_PwdAtual);
            this.groupBox1.Controls.Add(this.txtSenhaNova);
            this.groupBox1.Controls.Add(this.txtSenhaConfirma);
            this.groupBox1.Controls.Add(this.txtSenha);
            this.groupBox1.Location = new System.Drawing.Point(12, 1);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(363, 98);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // lbl_ConfirmaSenha
            // 
            this.lbl_ConfirmaSenha.AutoSize = true;
            this.lbl_ConfirmaSenha.Location = new System.Drawing.Point(6, 64);
            this.lbl_ConfirmaSenha.Name = "lbl_ConfirmaSenha";
            this.lbl_ConfirmaSenha.Size = new System.Drawing.Size(82, 13);
            this.lbl_ConfirmaSenha.TabIndex = 5;
            this.lbl_ConfirmaSenha.Text = "Confirma Senha";
            // 
            // lbl_NewPwd
            // 
            this.lbl_NewPwd.AutoSize = true;
            this.lbl_NewPwd.Location = new System.Drawing.Point(6, 43);
            this.lbl_NewPwd.Name = "lbl_NewPwd";
            this.lbl_NewPwd.Size = new System.Drawing.Size(67, 13);
            this.lbl_NewPwd.TabIndex = 4;
            this.lbl_NewPwd.Text = "Nova Senha";
            // 
            // lbl_PwdAtual
            // 
            this.lbl_PwdAtual.AutoSize = true;
            this.lbl_PwdAtual.Location = new System.Drawing.Point(6, 22);
            this.lbl_PwdAtual.Name = "lbl_PwdAtual";
            this.lbl_PwdAtual.Size = new System.Drawing.Size(65, 13);
            this.lbl_PwdAtual.TabIndex = 3;
            this.lbl_PwdAtual.Text = "Senha Atual";
            // 
            // txtSenhaNova
            // 
            this.txtSenhaNova.Location = new System.Drawing.Point(148, 38);
            this.txtSenhaNova.Name = "txtSenhaNova";
            this.txtSenhaNova.Size = new System.Drawing.Size(204, 20);
            this.txtSenhaNova.TabIndex = 2;
            // 
            // txtSenhaConfirma
            // 
            this.txtSenhaConfirma.Location = new System.Drawing.Point(148, 57);
            this.txtSenhaConfirma.Name = "txtSenhaConfirma";
            this.txtSenhaConfirma.Size = new System.Drawing.Size(204, 20);
            this.txtSenhaConfirma.TabIndex = 1;
            // 
            // txtSenha
            // 
            this.txtSenha.Location = new System.Drawing.Point(148, 19);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.Size = new System.Drawing.Size(204, 20);
            this.txtSenha.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lbl_Resultado);
            this.groupBox2.Location = new System.Drawing.Point(12, 105);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(352, 72);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // lbl_Resultado
            // 
            this.lbl_Resultado.AutoSize = true;
            this.lbl_Resultado.Location = new System.Drawing.Point(124, 16);
            this.lbl_Resultado.Name = "lbl_Resultado";
            this.lbl_Resultado.Size = new System.Drawing.Size(80, 13);
            this.lbl_Resultado.TabIndex = 0;
            this.lbl_Resultado.Text = "Alterar a Senha";
            // 
            // btnSair
            // 
            this.btnSair.Image = global::MCIMasterFarm.Properties.Resources.icons8_sair_24;
            this.btnSair.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSair.Location = new System.Drawing.Point(300, 183);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(64, 34);
            this.btnSair.TabIndex = 3;
            this.btnSair.Text = "Sair";
            this.btnSair.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btAlterarSenha
            // 
            this.btAlterarSenha.Image = global::MCIMasterFarm.Properties.Resources.icons8_alterar_24;
            this.btAlterarSenha.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btAlterarSenha.Location = new System.Drawing.Point(12, 183);
            this.btAlterarSenha.Name = "btAlterarSenha";
            this.btAlterarSenha.Size = new System.Drawing.Size(103, 34);
            this.btAlterarSenha.TabIndex = 2;
            this.btAlterarSenha.Text = "Alterar Senha";
            this.btAlterarSenha.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btAlterarSenha.UseVisualStyleBackColor = true;
            this.btAlterarSenha.Click += new System.EventHandler(this.btAlterarSenha_Click);
            // 
            // frm_Senha_Expirada
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(376, 220);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btAlterarSenha);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frm_Senha_Expirada";
            this.Text = "Usuario Com Senha Expirada";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtSenhaNova;
        private System.Windows.Forms.TextBox txtSenhaConfirma;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.Label lbl_ConfirmaSenha;
        private System.Windows.Forms.Label lbl_NewPwd;
        private System.Windows.Forms.Label lbl_PwdAtual;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lbl_Resultado;
        private System.Windows.Forms.Button btAlterarSenha;
        private System.Windows.Forms.Button btnSair;
    }
}