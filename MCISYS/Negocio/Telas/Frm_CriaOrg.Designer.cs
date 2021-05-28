
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
            this.StStripDados = new System.Windows.Forms.StatusStrip();
            this.tstlOrgSelecionadaNumero = new System.Windows.Forms.ToolStripStatusLabel();
            this.TstlPapel = new System.Windows.Forms.ToolStripStatusLabel();
            this.grb = new System.Windows.Forms.GroupBox();
            this.tstlUsuario = new System.Windows.Forms.ToolStripStatusLabel();
            this.tstl_OrgDEscricao = new System.Windows.Forms.ToolStripStatusLabel();
            this.tabControl1.SuspendLayout();
            this.StStripDados.SuspendLayout();
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
            // StStripDados
            // 
            this.StStripDados.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tstlUsuario,
            this.tstlOrgSelecionadaNumero,
            this.tstl_OrgDEscricao,
            this.TstlPapel});
            this.StStripDados.Location = new System.Drawing.Point(0, 490);
            this.StStripDados.Name = "StStripDados";
            this.StStripDados.Size = new System.Drawing.Size(799, 24);
            this.StStripDados.TabIndex = 2;
            this.StStripDados.Text = "statusStrip1";
            // 
            // tstlOrgSelecionadaNumero
            // 
            this.tstlOrgSelecionadaNumero.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)(((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.tstlOrgSelecionadaNumero.Name = "tstlOrgSelecionadaNumero";
            this.tstlOrgSelecionadaNumero.Size = new System.Drawing.Size(154, 19);
            this.tstlOrgSelecionadaNumero.Text = "tstlOrgSelecionadaNumero";
            // 
            // TstlPapel
            // 
            this.TstlPapel.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.TstlPapel.Name = "TstlPapel";
            this.TstlPapel.Size = new System.Drawing.Size(57, 19);
            this.TstlPapel.Text = "TstlPapel";
            // 
            // grb
            // 
            this.grb.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grb.Location = new System.Drawing.Point(330, 61);
            this.grb.Name = "grb";
            this.grb.Size = new System.Drawing.Size(458, 154);
            this.grb.TabIndex = 3;
            this.grb.TabStop = false;
            this.grb.Text = "Dados Organizacionais";
            // 
            // tstlUsuario
            // 
            this.tstlUsuario.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.tstlUsuario.Name = "tstlUsuario";
            this.tstlUsuario.Size = new System.Drawing.Size(67, 19);
            this.tstlUsuario.Text = "tstlUsuario";
            // 
            // tstl_OrgDEscricao
            // 
            this.tstl_OrgDEscricao.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)(((System.Windows.Forms.ToolStripStatusLabelBorderSides.Top | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.tstl_OrgDEscricao.Name = "tstl_OrgDEscricao";
            this.tstl_OrgDEscricao.Size = new System.Drawing.Size(103, 19);
            this.tstl_OrgDEscricao.Text = "tstl_OrgDEscricao";
            // 
            // Frm_CriaOrg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(799, 514);
            this.Controls.Add(this.grb);
            this.Controls.Add(this.StStripDados);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Frm_CriaOrg";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Tag = "CriaOrg";
            this.Text = "Cadastro de Organizações";
            this.tabControl1.ResumeLayout(false);
            this.StStripDados.ResumeLayout(false);
            this.StStripDados.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tbP_AssociaOrgPap;
        private System.Windows.Forms.TabPage tPage_AssociaOrgUsu;
        private System.Windows.Forms.StatusStrip StStripDados;
        private System.Windows.Forms.GroupBox grb;
        private System.Windows.Forms.ToolStripStatusLabel tstlOrgSelecionadaNumero;
        private System.Windows.Forms.ToolStripStatusLabel TstlPapel;
        private System.Windows.Forms.ToolStripStatusLabel tstlUsuario;
        private System.Windows.Forms.ToolStripStatusLabel tstl_OrgDEscricao;
    }
}