
namespace MCISYS.Negocio.Telas
{
    partial class Frm_Implementa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Implementa));
            this.grpSit = new System.Windows.Forms.GroupBox();
            this.lbl_StatusMCI = new System.Windows.Forms.Label();
            this.lblStatusUpdate = new System.Windows.Forms.Label();
            this.pgbImplementa = new System.Windows.Forms.ProgressBar();
            this.btSetup = new System.Windows.Forms.Button();
            this.btSair = new System.Windows.Forms.Button();
            this.grpSit.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpSit
            // 
            this.grpSit.Controls.Add(this.pgbImplementa);
            this.grpSit.Controls.Add(this.lblStatusUpdate);
            this.grpSit.Controls.Add(this.lbl_StatusMCI);
            this.grpSit.Location = new System.Drawing.Point(8, 2);
            this.grpSit.Name = "grpSit";
            this.grpSit.Size = new System.Drawing.Size(786, 244);
            this.grpSit.TabIndex = 0;
            this.grpSit.TabStop = false;
            this.grpSit.Text = "groupBox1";
            // 
            // lbl_StatusMCI
            // 
            this.lbl_StatusMCI.AutoSize = true;
            this.lbl_StatusMCI.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_StatusMCI.ForeColor = System.Drawing.Color.Maroon;
            this.lbl_StatusMCI.Location = new System.Drawing.Point(6, 26);
            this.lbl_StatusMCI.Name = "lbl_StatusMCI";
            this.lbl_StatusMCI.Size = new System.Drawing.Size(57, 20);
            this.lbl_StatusMCI.TabIndex = 0;
            this.lbl_StatusMCI.Text = "label1";
            // 
            // lblStatusUpdate
            // 
            this.lblStatusUpdate.AutoSize = true;
            this.lblStatusUpdate.Location = new System.Drawing.Point(7, 186);
            this.lblStatusUpdate.Name = "lblStatusUpdate";
            this.lblStatusUpdate.Size = new System.Drawing.Size(35, 13);
            this.lblStatusUpdate.TabIndex = 1;
            this.lblStatusUpdate.Text = "label1";
            // 
            // pgbImplementa
            // 
            this.pgbImplementa.Location = new System.Drawing.Point(6, 208);
            this.pgbImplementa.Name = "pgbImplementa";
            this.pgbImplementa.Size = new System.Drawing.Size(774, 23);
            this.pgbImplementa.TabIndex = 2;
            // 
            // btSetup
            // 
            this.btSetup.Image = global::MCISYS.Properties.Resources.icons8_instalador_de_software_48;
            this.btSetup.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btSetup.Location = new System.Drawing.Point(656, 252);
            this.btSetup.Name = "btSetup";
            this.btSetup.Size = new System.Drawing.Size(65, 65);
            this.btSetup.TabIndex = 1;
            this.btSetup.Text = "Setup";
            this.btSetup.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btSetup.UseVisualStyleBackColor = true;
            this.btSetup.Click += new System.EventHandler(this.btSetup_Click);
            // 
            // btSair
            // 
            this.btSair.Image = global::MCISYS.Properties.Resources.icons8_sair_48;
            this.btSair.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btSair.Location = new System.Drawing.Point(723, 252);
            this.btSair.Name = "btSair";
            this.btSair.Size = new System.Drawing.Size(65, 65);
            this.btSair.TabIndex = 2;
            this.btSair.Text = "Saída";
            this.btSair.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btSair.UseVisualStyleBackColor = true;
            this.btSair.Click += new System.EventHandler(this.btSair_Click);
            // 
            // Frm_Implementa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 338);
            this.Controls.Add(this.btSair);
            this.Controls.Add(this.btSetup);
            this.Controls.Add(this.grpSit);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Frm_Implementa";
            this.Text = "Frm_Implementa";
            this.Load += new System.EventHandler(this.Frm_Implementa_Load);
            this.grpSit.ResumeLayout(false);
            this.grpSit.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpSit;
        private System.Windows.Forms.Label lbl_StatusMCI;
        private System.Windows.Forms.Label lblStatusUpdate;
        private System.Windows.Forms.ProgressBar pgbImplementa;
        private System.Windows.Forms.Button btSetup;
        private System.Windows.Forms.Button btSair;
    }
}