
namespace MCISYS.Negocio.Telas
{
    partial class Frm_Associa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Associa));
            this.grpBox = new System.Windows.Forms.GroupBox();
            this.lblCbx = new System.Windows.Forms.Label();
            this.lblOrg = new System.Windows.Forms.Label();
            this.cbxGeneral = new System.Windows.Forms.ComboBox();
            this.btnAssocia = new System.Windows.Forms.Button();
            this.grpBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpBox
            // 
            this.grpBox.Controls.Add(this.lblCbx);
            this.grpBox.Controls.Add(this.lblOrg);
            this.grpBox.Controls.Add(this.cbxGeneral);
            this.grpBox.Location = new System.Drawing.Point(3, 3);
            this.grpBox.Name = "grpBox";
            this.grpBox.Size = new System.Drawing.Size(493, 68);
            this.grpBox.TabIndex = 0;
            this.grpBox.TabStop = false;
            this.grpBox.Text = "groupBox1";
            // 
            // lblCbx
            // 
            this.lblCbx.AutoSize = true;
            this.lblCbx.Location = new System.Drawing.Point(162, 30);
            this.lblCbx.Name = "lblCbx";
            this.lblCbx.Size = new System.Drawing.Size(35, 13);
            this.lblCbx.TabIndex = 3;
            this.lblCbx.Text = "label2";
            // 
            // lblOrg
            // 
            this.lblOrg.AutoSize = true;
            this.lblOrg.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrg.Location = new System.Drawing.Point(19, 27);
            this.lblOrg.Name = "lblOrg";
            this.lblOrg.Size = new System.Drawing.Size(60, 16);
            this.lblOrg.TabIndex = 2;
            this.lblOrg.Text = "ID. Org.";
            // 
            // cbxGeneral
            // 
            this.cbxGeneral.FormattingEnabled = true;
            this.cbxGeneral.Location = new System.Drawing.Point(245, 28);
            this.cbxGeneral.Name = "cbxGeneral";
            this.cbxGeneral.Size = new System.Drawing.Size(239, 21);
            this.cbxGeneral.TabIndex = 1;
            // 
            // btnAssocia
            // 
            this.btnAssocia.Image = global::MCISYS.Properties.Resources.icons8_sair_48;
            this.btnAssocia.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnAssocia.Location = new System.Drawing.Point(411, 77);
            this.btnAssocia.Name = "btnAssocia";
            this.btnAssocia.Size = new System.Drawing.Size(75, 66);
            this.btnAssocia.TabIndex = 0;
            this.btnAssocia.Text = "Associa";
            this.btnAssocia.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAssocia.UseVisualStyleBackColor = true;
            this.btnAssocia.Click += new System.EventHandler(this.btnAssocia_Click);
            // 
            // Frm_Associa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(499, 148);
            this.Controls.Add(this.btnAssocia);
            this.Controls.Add(this.grpBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Frm_Associa";
            this.Text = "Form1";
            this.grpBox.ResumeLayout(false);
            this.grpBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpBox;
        private System.Windows.Forms.Button btnAssocia;
        private System.Windows.Forms.ComboBox cbxGeneral;
        private System.Windows.Forms.Label lblCbx;
        private System.Windows.Forms.Label lblOrg;
    }
}