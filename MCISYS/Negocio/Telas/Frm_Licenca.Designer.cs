
namespace MCISYS.Negocio.Telas
{
    partial class Frm_Licenca
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Licenca));
            this.grpLic = new System.Windows.Forms.GroupBox();
            this.mTxtRaiz = new System.Windows.Forms.MaskedTextBox();
            this.lblRaiz = new System.Windows.Forms.Label();
            this.lbl_Amb = new System.Windows.Forms.Label();
            this.cbxAmbiente = new System.Windows.Forms.ComboBox();
            this.txtSigla = new System.Windows.Forms.TextBox();
            this.lblSigla = new System.Windows.Forms.Label();
            this.lbl_DtLic = new System.Windows.Forms.Label();
            this.dt_Lic = new System.Windows.Forms.DateTimePicker();
            this.btnLic = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.grpLic.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpLic
            // 
            this.grpLic.Controls.Add(this.mTxtRaiz);
            this.grpLic.Controls.Add(this.lblRaiz);
            this.grpLic.Controls.Add(this.lbl_Amb);
            this.grpLic.Controls.Add(this.cbxAmbiente);
            this.grpLic.Controls.Add(this.txtSigla);
            this.grpLic.Controls.Add(this.lblSigla);
            this.grpLic.Controls.Add(this.lbl_DtLic);
            this.grpLic.Controls.Add(this.dt_Lic);
            this.grpLic.Controls.Add(this.btnLic);
            this.grpLic.Controls.Add(this.btnSair);
            this.grpLic.Controls.Add(this.btnExcluir);
            this.grpLic.Location = new System.Drawing.Point(3, 0);
            this.grpLic.Name = "grpLic";
            this.grpLic.Size = new System.Drawing.Size(394, 162);
            this.grpLic.TabIndex = 0;
            this.grpLic.TabStop = false;
            this.grpLic.Text = "Licenciamento";
            // 
            // mTxtRaiz
            // 
            this.mTxtRaiz.Location = new System.Drawing.Point(157, 22);
            this.mTxtRaiz.Mask = "00.000.000";
            this.mTxtRaiz.Name = "mTxtRaiz";
            this.mTxtRaiz.Size = new System.Drawing.Size(196, 20);
            this.mTxtRaiz.TabIndex = 0;
            this.mTxtRaiz.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblRaiz
            // 
            this.lblRaiz.AutoSize = true;
            this.lblRaiz.Location = new System.Drawing.Point(6, 25);
            this.lblRaiz.Name = "lblRaiz";
            this.lblRaiz.Size = new System.Drawing.Size(61, 13);
            this.lblRaiz.TabIndex = 15;
            this.lblRaiz.Text = "Raiz CNPJ:";
            // 
            // lbl_Amb
            // 
            this.lbl_Amb.AutoSize = true;
            this.lbl_Amb.Location = new System.Drawing.Point(6, 42);
            this.lbl_Amb.Name = "lbl_Amb";
            this.lbl_Amb.Size = new System.Drawing.Size(54, 13);
            this.lbl_Amb.TabIndex = 14;
            this.lbl_Amb.Text = "Ambiente:";
            // 
            // cbxAmbiente
            // 
            this.cbxAmbiente.FormattingEnabled = true;
            this.cbxAmbiente.Location = new System.Drawing.Point(157, 42);
            this.cbxAmbiente.Name = "cbxAmbiente";
            this.cbxAmbiente.Size = new System.Drawing.Size(196, 21);
            this.cbxAmbiente.TabIndex = 1;
            // 
            // txtSigla
            // 
            this.txtSigla.Location = new System.Drawing.Point(157, 63);
            this.txtSigla.Name = "txtSigla";
            this.txtSigla.Size = new System.Drawing.Size(110, 20);
            this.txtSigla.TabIndex = 2;
            // 
            // lblSigla
            // 
            this.lblSigla.AutoSize = true;
            this.lblSigla.Location = new System.Drawing.Point(6, 64);
            this.lblSigla.Name = "lblSigla";
            this.lblSigla.Size = new System.Drawing.Size(33, 13);
            this.lblSigla.TabIndex = 11;
            this.lblSigla.Text = "Sigla:";
            // 
            // lbl_DtLic
            // 
            this.lbl_DtLic.AutoSize = true;
            this.lbl_DtLic.Location = new System.Drawing.Point(6, 87);
            this.lbl_DtLic.Name = "lbl_DtLic";
            this.lbl_DtLic.Size = new System.Drawing.Size(120, 13);
            this.lbl_DtLic.TabIndex = 10;
            this.lbl_DtLic.Text = "Data de Licenciamento:";
            // 
            // dt_Lic
            // 
            this.dt_Lic.Location = new System.Drawing.Point(157, 85);
            this.dt_Lic.Name = "dt_Lic";
            this.dt_Lic.Size = new System.Drawing.Size(228, 20);
            this.dt_Lic.TabIndex = 4;
            this.dt_Lic.Value = new System.DateTime(2021, 6, 7, 22, 2, 17, 0);
            // 
            // btnLic
            // 
            this.btnLic.Enabled = false;
            this.btnLic.Image = global::MCISYS.Properties.Resources.icons8_licença_24;
            this.btnLic.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnLic.Location = new System.Drawing.Point(214, 109);
            this.btnLic.Name = "btnLic";
            this.btnLic.Size = new System.Drawing.Size(59, 44);
            this.btnLic.TabIndex = 5;
            this.btnLic.Text = "Licenciar";
            this.btnLic.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnLic.UseVisualStyleBackColor = true;
            this.btnLic.Click += new System.EventHandler(this.btnLic_Click);
            // 
            // btnSair
            // 
            this.btnSair.Image = ((System.Drawing.Image)(resources.GetObject("btnSair.Image")));
            this.btnSair.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSair.Location = new System.Drawing.Point(336, 109);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(48, 44);
            this.btnSair.TabIndex = 7;
            this.btnSair.Text = "Sair";
            this.btnSair.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Enabled = false;
            this.btnExcluir.Image = ((System.Drawing.Image)(resources.GetObject("btnExcluir.Image")));
            this.btnExcluir.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnExcluir.Location = new System.Drawing.Point(277, 109);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(58, 44);
            this.btnExcluir.TabIndex = 6;
            this.btnExcluir.Text = "Remover";
            this.btnExcluir.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // Frm_Licenca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(406, 168);
            this.Controls.Add(this.grpLic);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Frm_Licenca";
            this.Text = "Frm_Licenca";
            this.Load += new System.EventHandler(this.Frm_Licenca_Load);
            this.grpLic.ResumeLayout(false);
            this.grpLic.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpLic;
        private System.Windows.Forms.Label lblRaiz;
        private System.Windows.Forms.Label lbl_Amb;
        private System.Windows.Forms.ComboBox cbxAmbiente;
        private System.Windows.Forms.TextBox txtSigla;
        private System.Windows.Forms.Label lblSigla;
        private System.Windows.Forms.Label lbl_DtLic;
        private System.Windows.Forms.DateTimePicker dt_Lic;
        private System.Windows.Forms.Button btnLic;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.MaskedTextBox mTxtRaiz;
    }
}