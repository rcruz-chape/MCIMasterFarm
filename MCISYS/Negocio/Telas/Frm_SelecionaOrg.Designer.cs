
namespace MCIMasterFarm.Negocio.Telas
{
    partial class Frm_SelecionaOrg
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
            this.grBOrg = new System.Windows.Forms.GroupBox();
            this.cbxOrg = new System.Windows.Forms.ComboBox();
            this.grbPapel = new System.Windows.Forms.GroupBox();
            this.cbxPapel = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.grBOrg.SuspendLayout();
            this.grbPapel.SuspendLayout();
            this.SuspendLayout();
            // 
            // grBOrg
            // 
            this.grBOrg.Controls.Add(this.cbxOrg);
            this.grBOrg.Location = new System.Drawing.Point(6, 0);
            this.grBOrg.Name = "grBOrg";
            this.grBOrg.Size = new System.Drawing.Size(464, 65);
            this.grBOrg.TabIndex = 0;
            this.grBOrg.TabStop = false;
            this.grBOrg.Text = "Organização";
            // 
            // cbxOrg
            // 
            this.cbxOrg.Enabled = false;
            this.cbxOrg.FormattingEnabled = true;
            this.cbxOrg.Location = new System.Drawing.Point(22, 19);
            this.cbxOrg.Name = "cbxOrg";
            this.cbxOrg.Size = new System.Drawing.Size(424, 21);
            this.cbxOrg.TabIndex = 0;
            this.cbxOrg.SelectedValueChanged += new System.EventHandler(this.cbxOrg_SelectedValueChanged);
            // 
            // grbPapel
            // 
            this.grbPapel.Controls.Add(this.cbxPapel);
            this.grbPapel.Location = new System.Drawing.Point(6, 71);
            this.grbPapel.Name = "grbPapel";
            this.grbPapel.Size = new System.Drawing.Size(465, 65);
            this.grbPapel.TabIndex = 1;
            this.grbPapel.TabStop = false;
            this.grbPapel.Text = "Papel";
            // 
            // cbxPapel
            // 
            this.cbxPapel.Enabled = false;
            this.cbxPapel.FormattingEnabled = true;
            this.cbxPapel.Location = new System.Drawing.Point(21, 22);
            this.cbxPapel.Name = "cbxPapel";
            this.cbxPapel.Size = new System.Drawing.Size(424, 21);
            this.cbxPapel.TabIndex = 1;
            this.cbxPapel.SelectedValueChanged += new System.EventHandler(this.cbxPapel_SelectedValueChanged);
            // 
            // button1
            // 
            this.button1.Image = global::MCISYS.Properties.Resources.icons8_botão_continuar_36;
            this.button1.Location = new System.Drawing.Point(397, 142);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(73, 63);
            this.button1.TabIndex = 2;
            this.button1.Text = "Continuar";
            this.button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Frm_SelecionaOrg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(483, 210);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.grbPapel);
            this.Controls.Add(this.grBOrg);
            this.Name = "Frm_SelecionaOrg";
            this.Text = "Organização de Trabalho";
            this.grBOrg.ResumeLayout(false);
            this.grbPapel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grBOrg;
        private System.Windows.Forms.ComboBox cbxOrg;
        private System.Windows.Forms.GroupBox grbPapel;
        private System.Windows.Forms.ComboBox cbxPapel;
        private System.Windows.Forms.Button button1;
    }
}