
namespace MCISYS.Negocio.Telas
{
    partial class frm_Email
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Email));
            this.grbPar = new System.Windows.Forms.GroupBox();
            this.txtHostName = new System.Windows.Forms.TextBox();
            this.txtPort = new System.Windows.Forms.TextBox();
            this.chc_enable_ssl = new System.Windows.Forms.CheckBox();
            this.cckUseCredentials = new System.Windows.Forms.CheckBox();
            this.txtPwd = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.btTeste = new System.Windows.Forms.Button();
            this.btConfirmar = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.grbPar.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbPar
            // 
            this.grbPar.Controls.Add(this.label4);
            this.grbPar.Controls.Add(this.txtEmail);
            this.grbPar.Controls.Add(this.label2);
            this.grbPar.Controls.Add(this.label3);
            this.grbPar.Controls.Add(this.txtPwd);
            this.grbPar.Controls.Add(this.cckUseCredentials);
            this.grbPar.Controls.Add(this.label1);
            this.grbPar.Controls.Add(this.chc_enable_ssl);
            this.grbPar.Controls.Add(this.txtPort);
            this.grbPar.Controls.Add(this.txtHostName);
            this.grbPar.Location = new System.Drawing.Point(5, -1);
            this.grbPar.Name = "grbPar";
            this.grbPar.Size = new System.Drawing.Size(561, 118);
            this.grbPar.TabIndex = 0;
            this.grbPar.TabStop = false;
            this.grbPar.Text = "Parametros Gerais";
            // 
            // txtHostName
            // 
            this.txtHostName.Location = new System.Drawing.Point(75, 41);
            this.txtHostName.Name = "txtHostName";
            this.txtHostName.Size = new System.Drawing.Size(346, 20);
            this.txtHostName.TabIndex = 1;
            // 
            // txtPort
            // 
            this.txtPort.Location = new System.Drawing.Point(484, 41);
            this.txtPort.Name = "txtPort";
            this.txtPort.Size = new System.Drawing.Size(71, 20);
            this.txtPort.TabIndex = 2;
            this.txtPort.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // chc_enable_ssl
            // 
            this.chc_enable_ssl.AutoSize = true;
            this.chc_enable_ssl.Location = new System.Drawing.Point(75, 88);
            this.chc_enable_ssl.Name = "chc_enable_ssl";
            this.chc_enable_ssl.Size = new System.Drawing.Size(84, 17);
            this.chc_enable_ssl.TabIndex = 4;
            this.chc_enable_ssl.Text = "Habilita SSL";
            this.chc_enable_ssl.UseVisualStyleBackColor = true;
            // 
            // cckUseCredentials
            // 
            this.cckUseCredentials.AutoSize = true;
            this.cckUseCredentials.Location = new System.Drawing.Point(294, 88);
            this.cckUseCredentials.Name = "cckUseCredentials";
            this.cckUseCredentials.Size = new System.Drawing.Size(143, 17);
            this.cckUseCredentials.TabIndex = 5;
            this.cckUseCredentials.Text = "Usar Credenciais Padrão";
            this.cckUseCredentials.UseVisualStyleBackColor = true;
            // 
            // txtPwd
            // 
            this.txtPwd.Location = new System.Drawing.Point(75, 62);
            this.txtPwd.Name = "txtPwd";
            this.txtPwd.PasswordChar = '*';
            this.txtPwd.Size = new System.Drawing.Size(346, 20);
            this.txtPwd.TabIndex = 3;
            this.txtPwd.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "HostName : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Senha : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(435, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Porta :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(4, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Email : ";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(75, 20);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(346, 20);
            this.txtEmail.TabIndex = 0;
            // 
            // btTeste
            // 
            this.btTeste.Image = global::MCISYS.Properties.Resources.icons8_enviar_e_mail_em_massa_36;
            this.btTeste.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btTeste.Location = new System.Drawing.Point(332, 121);
            this.btTeste.Name = "btTeste";
            this.btTeste.Size = new System.Drawing.Size(75, 67);
            this.btTeste.TabIndex = 7;
            this.btTeste.Text = "Testar";
            this.btTeste.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btTeste.UseVisualStyleBackColor = true;
            this.btTeste.Click += new System.EventHandler(this.btTeste_Click);
            // 
            // btConfirmar
            // 
            this.btConfirmar.Image = global::MCISYS.Properties.Resources.icons8_caixa_de_seleção_marcada_36;
            this.btConfirmar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btConfirmar.Location = new System.Drawing.Point(408, 121);
            this.btConfirmar.Name = "btConfirmar";
            this.btConfirmar.Size = new System.Drawing.Size(75, 67);
            this.btConfirmar.TabIndex = 6;
            this.btConfirmar.Text = "Confirmar";
            this.btConfirmar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btConfirmar.UseVisualStyleBackColor = true;
            this.btConfirmar.Click += new System.EventHandler(this.btConfirmar_Click);
            // 
            // btnExit
            // 
            this.btnExit.Image = global::MCISYS.Properties.Resources.icons8_sair_48;
            this.btnExit.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnExit.Location = new System.Drawing.Point(489, 120);
            this.btnExit.Margin = new System.Windows.Forms.Padding(5);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 67);
            this.btnExit.TabIndex = 8;
            this.btnExit.Text = "Sair";
            this.btnExit.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // frm_Email
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(573, 192);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btTeste);
            this.Controls.Add(this.btConfirmar);
            this.Controls.Add(this.grbPar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_Email";
            this.Text = "Parametrização de Email";
            this.Load += new System.EventHandler(this.frm_Email_Load);
            this.grbPar.ResumeLayout(false);
            this.grbPar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbPar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPwd;
        private System.Windows.Forms.CheckBox cckUseCredentials;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox chc_enable_ssl;
        private System.Windows.Forms.TextBox txtPort;
        private System.Windows.Forms.TextBox txtHostName;
        private System.Windows.Forms.Button btConfirmar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Button btTeste;
        private System.Windows.Forms.Button btnExit;
    }
}