
namespace MCISYS.Negocio.Telas
{
    partial class Frm_CriaOrg
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_CriaOrg));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tbP_AssociaOrgPap = new System.Windows.Forms.TabPage();
            this.tPage_AssociaOrgUsu = new System.Windows.Forms.TabPage();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(5, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(319, 214);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Organizações";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tbP_AssociaOrgPap);
            this.tabControl1.Controls.Add(this.tPage_AssociaOrgUsu);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(5, 223);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(792, 266);
            this.tabControl1.TabIndex = 1;
            // 
            // tbP_AssociaOrgPap
            // 
            this.tbP_AssociaOrgPap.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbP_AssociaOrgPap.Location = new System.Drawing.Point(4, 22);
            this.tbP_AssociaOrgPap.Name = "tbP_AssociaOrgPap";
            this.tbP_AssociaOrgPap.Padding = new System.Windows.Forms.Padding(3);
            this.tbP_AssociaOrgPap.Size = new System.Drawing.Size(784, 240);
            this.tbP_AssociaOrgPap.TabIndex = 0;
            this.tbP_AssociaOrgPap.Tag = "AssociaOrgPap";
            this.tbP_AssociaOrgPap.Text = "Papeis Associados";
            this.tbP_AssociaOrgPap.UseVisualStyleBackColor = true;
            // 
            // tPage_AssociaOrgUsu
            // 
            this.tPage_AssociaOrgUsu.Location = new System.Drawing.Point(4, 22);
            this.tPage_AssociaOrgUsu.Name = "tPage_AssociaOrgUsu";
            this.tPage_AssociaOrgUsu.Padding = new System.Windows.Forms.Padding(3);
            this.tPage_AssociaOrgUsu.Size = new System.Drawing.Size(784, 240);
            this.tPage_AssociaOrgUsu.TabIndex = 1;
            this.tPage_AssociaOrgUsu.Tag = "AssociaOrgUsu";
            this.tPage_AssociaOrgUsu.Text = "Usuário Associados";
            this.tPage_AssociaOrgUsu.UseVisualStyleBackColor = true;
            // 
            // Frm_CriaOrg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 501);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Frm_CriaOrg";
            this.Tag = "CriaOrg";
            this.Text = "Cadastro de Organizações";
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tbP_AssociaOrgPap;
        private System.Windows.Forms.TabPage tPage_AssociaOrgUsu;
    }
}