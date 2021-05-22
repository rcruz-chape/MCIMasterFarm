
namespace MCIMasterFarm.Negocio.Telas
{
    partial class MDIForm
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
            var bLogoff = fbRealizarLogoff(ref vBanco);
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MDIForm));
            this.StatusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripSplitButton1 = new System.Windows.Forms.ToolStripSplitButton();
            this.trocarOrgEPapelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tstlUsuario = new System.Windows.Forms.ToolStripStatusLabel();
            this.tstlOrgSelecionadaNumero = new System.Windows.Forms.ToolStripStatusLabel();
            this.tstl_OrgDEscricao = new System.Windows.Forms.ToolStripStatusLabel();
            this.TstlPapel = new System.Windows.Forms.ToolStripStatusLabel();
            this.btnExit = new System.Windows.Forms.Button();
            this.trv_MCISYS = new System.Windows.Forms.TreeView();
            this.grpModulo = new System.Windows.Forms.GroupBox();
            this.StatusStrip.SuspendLayout();
            this.grpModulo.SuspendLayout();
            this.SuspendLayout();
            // 
            // StatusStrip
            // 
            this.StatusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSplitButton1,
            this.tstlUsuario,
            this.tstlOrgSelecionadaNumero,
            this.tstl_OrgDEscricao,
            this.TstlPapel});
            this.StatusStrip.Location = new System.Drawing.Point(0, 429);
            this.StatusStrip.Name = "StatusStrip";
            this.StatusStrip.Size = new System.Drawing.Size(632, 24);
            this.StatusStrip.TabIndex = 3;
            this.StatusStrip.Text = "statusStrip1";
            // 
            // toolStripSplitButton1
            // 
            this.toolStripSplitButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripSplitButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.trocarOrgEPapelToolStripMenuItem});
            this.toolStripSplitButton1.Image = global::MCISYS.Properties.Resources.icons8_grupo_de_negócios_16;
            this.toolStripSplitButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripSplitButton1.Name = "toolStripSplitButton1";
            this.toolStripSplitButton1.Size = new System.Drawing.Size(32, 22);
            this.toolStripSplitButton1.Text = "toolStripSplitButton1";
            this.toolStripSplitButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // trocarOrgEPapelToolStripMenuItem
            // 
            this.trocarOrgEPapelToolStripMenuItem.Name = "trocarOrgEPapelToolStripMenuItem";
            this.trocarOrgEPapelToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.trocarOrgEPapelToolStripMenuItem.Text = "Trocar Org e Papel";
            this.trocarOrgEPapelToolStripMenuItem.Click += new System.EventHandler(this.trocarOrgEPapelToolStripMenuItem_Click);
            // 
            // tstlUsuario
            // 
            this.tstlUsuario.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.tstlUsuario.Name = "tstlUsuario";
            this.tstlUsuario.Size = new System.Drawing.Size(122, 19);
            this.tstlUsuario.Text = "toolStripStatusLabel1";
            // 
            // tstlOrgSelecionadaNumero
            // 
            this.tstlOrgSelecionadaNumero.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)(((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.tstlOrgSelecionadaNumero.Name = "tstlOrgSelecionadaNumero";
            this.tstlOrgSelecionadaNumero.Size = new System.Drawing.Size(122, 19);
            this.tstlOrgSelecionadaNumero.Text = "toolStripStatusLabel2";
            this.tstlOrgSelecionadaNumero.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tstl_OrgDEscricao
            // 
            this.tstl_OrgDEscricao.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)(((System.Windows.Forms.ToolStripStatusLabelBorderSides.Top | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.tstl_OrgDEscricao.Name = "tstl_OrgDEscricao";
            this.tstl_OrgDEscricao.Size = new System.Drawing.Size(122, 19);
            this.tstl_OrgDEscricao.Text = "toolStripStatusLabel3";
            this.tstl_OrgDEscricao.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // TstlPapel
            // 
            this.TstlPapel.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.TstlPapel.Name = "TstlPapel";
            this.TstlPapel.Size = new System.Drawing.Size(122, 19);
            this.TstlPapel.Text = "toolStripStatusLabel4";
            // 
            // btnExit
            // 
            this.btnExit.Image = global::MCISYS.Properties.Resources.icons8_sair_48;
            this.btnExit.Location = new System.Drawing.Point(518, 349);
            this.btnExit.Margin = new System.Windows.Forms.Padding(5);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(86, 77);
            this.btnExit.TabIndex = 1;
            this.btnExit.Text = "Sair";
            this.btnExit.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // trv_MCISYS
            // 
            this.trv_MCISYS.BackColor = System.Drawing.SystemColors.Control;
            this.trv_MCISYS.CausesValidation = false;
            this.trv_MCISYS.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.trv_MCISYS.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.trv_MCISYS.HotTracking = true;
            this.trv_MCISYS.ItemHeight = 48;
            this.trv_MCISYS.Location = new System.Drawing.Point(3, 18);
            this.trv_MCISYS.Name = "trv_MCISYS";
            this.trv_MCISYS.Size = new System.Drawing.Size(365, 403);
            this.trv_MCISYS.TabIndex = 5;
            this.trv_MCISYS.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.trv_MCISYS_AfterSelect);
            // 
            // grpModulo
            // 
            this.grpModulo.Controls.Add(this.trv_MCISYS);
            this.grpModulo.Location = new System.Drawing.Point(1, 2);
            this.grpModulo.Name = "grpModulo";
            this.grpModulo.Size = new System.Drawing.Size(371, 424);
            this.grpModulo.TabIndex = 7;
            this.grpModulo.TabStop = false;
            this.grpModulo.Text = "Módulos";
            // 
            // MDIForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 453);
            this.Controls.Add(this.grpModulo);
            this.Controls.Add(this.StatusStrip);
            this.Controls.Add(this.btnExit);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Name = "MDIForm";
            this.Text = "MCISys";
            this.StatusStrip.ResumeLayout(false);
            this.StatusStrip.PerformLayout();
            this.grpModulo.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.StatusStrip StatusStrip;
        private System.Windows.Forms.ToolStripStatusLabel tstlUsuario;
        private System.Windows.Forms.ToolStripStatusLabel tstlOrgSelecionadaNumero;
        private System.Windows.Forms.ToolStripStatusLabel tstl_OrgDEscricao;
        private System.Windows.Forms.ToolStripStatusLabel TstlPapel;
        private System.Windows.Forms.ToolStripSplitButton toolStripSplitButton1;
        private System.Windows.Forms.ToolStripMenuItem trocarOrgEPapelToolStripMenuItem;
        private System.Windows.Forms.TreeView trv_MCISYS;
        private System.Windows.Forms.GroupBox grpModulo;
    }
}



