
namespace MCIMasterFarm.Negocio.Telas
{
    partial class Frm_EsqueciSenha
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
            this.grbUserData = new System.Windows.Forms.GroupBox();
            this.BtnSaida = new System.Windows.Forms.Button();
            this.btnReinicia = new System.Windows.Forms.Button();
            this.txtEmailUsuario = new System.Windows.Forms.TextBox();
            this.lblUserEmail = new System.Windows.Forms.Label();
            this.grbUserData.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbUserData
            // 
            this.grbUserData.Controls.Add(this.BtnSaida);
            this.grbUserData.Controls.Add(this.btnReinicia);
            this.grbUserData.Controls.Add(this.txtEmailUsuario);
            this.grbUserData.Controls.Add(this.lblUserEmail);
            this.grbUserData.Location = new System.Drawing.Point(12, 2);
            this.grbUserData.Name = "grbUserData";
            this.grbUserData.Size = new System.Drawing.Size(414, 118);
            this.grbUserData.TabIndex = 0;
            this.grbUserData.TabStop = false;
            this.grbUserData.Text = "Dados do Usuario";
            // 
            // BtnSaida
            // 
            this.BtnSaida.Image = global::MCISYS.Properties.Resources.icons8_sair_24;
            this.BtnSaida.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnSaida.Location = new System.Drawing.Point(192, 58);
            this.BtnSaida.Name = "BtnSaida";
            this.BtnSaida.Size = new System.Drawing.Size(88, 53);
            this.BtnSaida.TabIndex = 3;
            this.BtnSaida.Text = "Saída";
            this.BtnSaida.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnSaida.UseVisualStyleBackColor = true;
            this.BtnSaida.Click += new System.EventHandler(this.BtnSaida_Click);
            // 
            // btnReinicia
            // 
            this.btnReinicia.Image = global::MCISYS.Properties.Resources.icons8_reiniciar_32;
            this.btnReinicia.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnReinicia.Location = new System.Drawing.Point(105, 58);
            this.btnReinicia.Name = "btnReinicia";
            this.btnReinicia.Size = new System.Drawing.Size(88, 53);
            this.btnReinicia.TabIndex = 2;
            this.btnReinicia.Text = "Reiniciar";
            this.btnReinicia.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnReinicia.UseVisualStyleBackColor = true;
            this.btnReinicia.Click += new System.EventHandler(this.btnReinicia_Click);
            // 
            // txtEmailUsuario
            // 
            this.txtEmailUsuario.Location = new System.Drawing.Point(95, 31);
            this.txtEmailUsuario.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.txtEmailUsuario.Name = "txtEmailUsuario";
            this.txtEmailUsuario.Size = new System.Drawing.Size(295, 20);
            this.txtEmailUsuario.TabIndex = 1;
            // 
            // lblUserEmail
            // 
            this.lblUserEmail.AutoSize = true;
            this.lblUserEmail.Location = new System.Drawing.Point(6, 34);
            this.lblUserEmail.Name = "lblUserEmail";
            this.lblUserEmail.Size = new System.Drawing.Size(76, 13);
            this.lblUserEmail.TabIndex = 0;
            this.lblUserEmail.Text = "Usuario/Email:";
            // 
            // Frm_EsqueciSenha
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(432, 125);
            this.Controls.Add(this.grbUserData);
            this.Name = "Frm_EsqueciSenha";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reinicia a Senha";
            this.grbUserData.ResumeLayout(false);
            this.grbUserData.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbUserData;
        private System.Windows.Forms.Label lblUserEmail;
        private System.Windows.Forms.Button BtnSaida;
        private System.Windows.Forms.Button btnReinicia;
        private System.Windows.Forms.TextBox txtEmailUsuario;
    }
}