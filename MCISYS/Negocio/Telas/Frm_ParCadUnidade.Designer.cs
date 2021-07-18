
namespace MCISYS.Negocio.Telas
{
    partial class Frm_ParCadUnidade
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_ParCadUnidade));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.grpCadUnidade = new System.Windows.Forms.GroupBox();
            this.grpDados = new System.Windows.Forms.GroupBox();
            this.lbl_DescUm = new System.Windows.Forms.Label();
            this.lbl_CodUM = new System.Windows.Forms.Label();
            this.txtb_DescUm = new System.Windows.Forms.TextBox();
            this.txtb_CodUm = new System.Windows.Forms.TextBox();
            this.grpAlterado = new System.Windows.Forms.GroupBox();
            this.lbl_Dt_Alteracao = new System.Windows.Forms.Label();
            this.lbl_Id_Usu_Alterado = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.grpIncluido = new System.Windows.Forms.GroupBox();
            this.lbl_Dt_Inclusao = new System.Windows.Forms.Label();
            this.lbl_ID_Usu_Incl = new System.Windows.Forms.Label();
            this.lbl_InclEm = new System.Windows.Forms.Label();
            this.lbl_IdUsuIncl = new System.Windows.Forms.Label();
            this.grpButtons = new System.Windows.Forms.GroupBox();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnGravar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnNovo = new System.Windows.Forms.Button();
            this.dGv_Um = new System.Windows.Forms.DataGridView();
            this.COD_UM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DESC_UM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StStripDados = new System.Windows.Forms.StatusStrip();
            this.tstlUsuario = new System.Windows.Forms.ToolStripStatusLabel();
            this.tstlOrgSelecionadaNumero = new System.Windows.Forms.ToolStripStatusLabel();
            this.tstl_OrgDEscricao = new System.Windows.Forms.ToolStripStatusLabel();
            this.TstlPapel = new System.Windows.Forms.ToolStripStatusLabel();
            this.grpCadUnidade.SuspendLayout();
            this.grpDados.SuspendLayout();
            this.grpAlterado.SuspendLayout();
            this.grpIncluido.SuspendLayout();
            this.grpButtons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGv_Um)).BeginInit();
            this.StStripDados.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpCadUnidade
            // 
            this.grpCadUnidade.Controls.Add(this.grpDados);
            this.grpCadUnidade.Controls.Add(this.grpButtons);
            this.grpCadUnidade.Controls.Add(this.dGv_Um);
            this.grpCadUnidade.Controls.Add(this.StStripDados);
            this.grpCadUnidade.Location = new System.Drawing.Point(2, 2);
            this.grpCadUnidade.Name = "grpCadUnidade";
            this.grpCadUnidade.Size = new System.Drawing.Size(728, 297);
            this.grpCadUnidade.TabIndex = 0;
            this.grpCadUnidade.TabStop = false;
            this.grpCadUnidade.Text = "Unidades de Medida";
            // 
            // grpDados
            // 
            this.grpDados.Controls.Add(this.lbl_DescUm);
            this.grpDados.Controls.Add(this.lbl_CodUM);
            this.grpDados.Controls.Add(this.txtb_DescUm);
            this.grpDados.Controls.Add(this.txtb_CodUm);
            this.grpDados.Controls.Add(this.grpAlterado);
            this.grpDados.Controls.Add(this.grpIncluido);
            this.grpDados.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpDados.Location = new System.Drawing.Point(316, 71);
            this.grpDados.Name = "grpDados";
            this.grpDados.Size = new System.Drawing.Size(403, 195);
            this.grpDados.TabIndex = 6;
            this.grpDados.TabStop = false;
            this.grpDados.Text = "Unidade de Medida";
            // 
            // lbl_DescUm
            // 
            this.lbl_DescUm.AutoSize = true;
            this.lbl_DescUm.Location = new System.Drawing.Point(12, 63);
            this.lbl_DescUm.Name = "lbl_DescUm";
            this.lbl_DescUm.Size = new System.Drawing.Size(68, 13);
            this.lbl_DescUm.TabIndex = 11;
            this.lbl_DescUm.Text = "Descrição:";
            // 
            // lbl_CodUM
            // 
            this.lbl_CodUM.AutoSize = true;
            this.lbl_CodUM.Location = new System.Drawing.Point(12, 44);
            this.lbl_CodUM.Name = "lbl_CodUM";
            this.lbl_CodUM.Size = new System.Drawing.Size(50, 13);
            this.lbl_CodUM.TabIndex = 10;
            this.lbl_CodUM.Text = "Código:";
            // 
            // txtb_DescUm
            // 
            this.txtb_DescUm.Enabled = false;
            this.txtb_DescUm.Location = new System.Drawing.Point(101, 62);
            this.txtb_DescUm.Name = "txtb_DescUm";
            this.txtb_DescUm.Size = new System.Drawing.Size(254, 20);
            this.txtb_DescUm.TabIndex = 9;
            // 
            // txtb_CodUm
            // 
            this.txtb_CodUm.Enabled = false;
            this.txtb_CodUm.Location = new System.Drawing.Point(101, 41);
            this.txtb_CodUm.Name = "txtb_CodUm";
            this.txtb_CodUm.Size = new System.Drawing.Size(100, 20);
            this.txtb_CodUm.TabIndex = 8;
            this.txtb_CodUm.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // grpAlterado
            // 
            this.grpAlterado.Controls.Add(this.lbl_Dt_Alteracao);
            this.grpAlterado.Controls.Add(this.lbl_Id_Usu_Alterado);
            this.grpAlterado.Controls.Add(this.label1);
            this.grpAlterado.Controls.Add(this.label2);
            this.grpAlterado.Location = new System.Drawing.Point(220, 104);
            this.grpAlterado.Name = "grpAlterado";
            this.grpAlterado.Size = new System.Drawing.Size(176, 85);
            this.grpAlterado.TabIndex = 7;
            this.grpAlterado.TabStop = false;
            this.grpAlterado.Text = "Alterado:";
            // 
            // lbl_Dt_Alteracao
            // 
            this.lbl_Dt_Alteracao.AutoSize = true;
            this.lbl_Dt_Alteracao.ForeColor = System.Drawing.Color.Maroon;
            this.lbl_Dt_Alteracao.Location = new System.Drawing.Point(52, 54);
            this.lbl_Dt_Alteracao.Name = "lbl_Dt_Alteracao";
            this.lbl_Dt_Alteracao.Size = new System.Drawing.Size(104, 13);
            this.lbl_Dt_Alteracao.TabIndex = 4;
            this.lbl_Dt_Alteracao.Text = "DT_ALTERACAO";
            // 
            // lbl_Id_Usu_Alterado
            // 
            this.lbl_Id_Usu_Alterado.AutoSize = true;
            this.lbl_Id_Usu_Alterado.ForeColor = System.Drawing.Color.Maroon;
            this.lbl_Id_Usu_Alterado.Location = new System.Drawing.Point(52, 28);
            this.lbl_Id_Usu_Alterado.Name = "lbl_Id_Usu_Alterado";
            this.lbl_Id_Usu_Alterado.Size = new System.Drawing.Size(83, 13);
            this.lbl_Id_Usu_Alterado.TabIndex = 5;
            this.lbl_Id_Usu_Alterado.Text = "ID_USU_ALT";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Em:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Por:";
            // 
            // grpIncluido
            // 
            this.grpIncluido.Controls.Add(this.lbl_Dt_Inclusao);
            this.grpIncluido.Controls.Add(this.lbl_ID_Usu_Incl);
            this.grpIncluido.Controls.Add(this.lbl_InclEm);
            this.grpIncluido.Controls.Add(this.lbl_IdUsuIncl);
            this.grpIncluido.Location = new System.Drawing.Point(2, 104);
            this.grpIncluido.Name = "grpIncluido";
            this.grpIncluido.Size = new System.Drawing.Size(182, 85);
            this.grpIncluido.TabIndex = 6;
            this.grpIncluido.TabStop = false;
            this.grpIncluido.Text = "Incluído";
            // 
            // lbl_Dt_Inclusao
            // 
            this.lbl_Dt_Inclusao.AutoSize = true;
            this.lbl_Dt_Inclusao.ForeColor = System.Drawing.Color.Maroon;
            this.lbl_Dt_Inclusao.Location = new System.Drawing.Point(45, 53);
            this.lbl_Dt_Inclusao.Name = "lbl_Dt_Inclusao";
            this.lbl_Dt_Inclusao.Size = new System.Drawing.Size(93, 13);
            this.lbl_Dt_Inclusao.TabIndex = 3;
            this.lbl_Dt_Inclusao.Text = "DT_INCLUSAO";
            // 
            // lbl_ID_Usu_Incl
            // 
            this.lbl_ID_Usu_Incl.AutoSize = true;
            this.lbl_ID_Usu_Incl.ForeColor = System.Drawing.Color.Maroon;
            this.lbl_ID_Usu_Incl.Location = new System.Drawing.Point(44, 29);
            this.lbl_ID_Usu_Incl.Name = "lbl_ID_Usu_Incl";
            this.lbl_ID_Usu_Incl.Size = new System.Drawing.Size(88, 13);
            this.lbl_ID_Usu_Incl.TabIndex = 2;
            this.lbl_ID_Usu_Incl.Text = "ID_USU_INCL";
            // 
            // lbl_InclEm
            // 
            this.lbl_InclEm.AutoSize = true;
            this.lbl_InclEm.Location = new System.Drawing.Point(8, 53);
            this.lbl_InclEm.Name = "lbl_InclEm";
            this.lbl_InclEm.Size = new System.Drawing.Size(28, 13);
            this.lbl_InclEm.TabIndex = 1;
            this.lbl_InclEm.Text = "Em:";
            // 
            // lbl_IdUsuIncl
            // 
            this.lbl_IdUsuIncl.AutoSize = true;
            this.lbl_IdUsuIncl.Location = new System.Drawing.Point(8, 28);
            this.lbl_IdUsuIncl.Name = "lbl_IdUsuIncl";
            this.lbl_IdUsuIncl.Size = new System.Drawing.Size(30, 13);
            this.lbl_IdUsuIncl.TabIndex = 0;
            this.lbl_IdUsuIncl.Text = "Por:";
            // 
            // grpButtons
            // 
            this.grpButtons.Controls.Add(this.btnSair);
            this.grpButtons.Controls.Add(this.btnGravar);
            this.grpButtons.Controls.Add(this.btnExcluir);
            this.grpButtons.Controls.Add(this.btnEditar);
            this.grpButtons.Controls.Add(this.btnNovo);
            this.grpButtons.Location = new System.Drawing.Point(314, 10);
            this.grpButtons.Name = "grpButtons";
            this.grpButtons.Size = new System.Drawing.Size(405, 58);
            this.grpButtons.TabIndex = 5;
            this.grpButtons.TabStop = false;
            // 
            // btnSair
            // 
            this.btnSair.Image = ((System.Drawing.Image)(resources.GetObject("btnSair.Image")));
            this.btnSair.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSair.Location = new System.Drawing.Point(349, 10);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(48, 44);
            this.btnSair.TabIndex = 4;
            this.btnSair.Text = "Sair";
            this.btnSair.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnGravar
            // 
            this.btnGravar.Enabled = false;
            this.btnGravar.Image = ((System.Drawing.Image)(resources.GetObject("btnGravar.Image")));
            this.btnGravar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnGravar.Location = new System.Drawing.Point(138, 9);
            this.btnGravar.Name = "btnGravar";
            this.btnGravar.Size = new System.Drawing.Size(48, 44);
            this.btnGravar.TabIndex = 3;
            this.btnGravar.Text = "Gravar";
            this.btnGravar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnGravar.UseVisualStyleBackColor = true;
            this.btnGravar.Click += new System.EventHandler(this.btnGravar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Enabled = false;
            this.btnExcluir.Image = ((System.Drawing.Image)(resources.GetObject("btnExcluir.Image")));
            this.btnExcluir.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnExcluir.Location = new System.Drawing.Point(90, 9);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(48, 44);
            this.btnExcluir.TabIndex = 2;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Image = ((System.Drawing.Image)(resources.GetObject("btnEditar.Image")));
            this.btnEditar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnEditar.Location = new System.Drawing.Point(48, 9);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(42, 44);
            this.btnEditar.TabIndex = 1;
            this.btnEditar.Text = "Editar";
            this.btnEditar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnNovo
            // 
            this.btnNovo.Image = ((System.Drawing.Image)(resources.GetObject("btnNovo.Image")));
            this.btnNovo.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnNovo.Location = new System.Drawing.Point(6, 9);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(42, 44);
            this.btnNovo.TabIndex = 0;
            this.btnNovo.Text = "Novo";
            this.btnNovo.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnNovo.UseVisualStyleBackColor = true;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // dGv_Um
            // 
            this.dGv_Um.AllowUserToAddRows = false;
            this.dGv_Um.AllowUserToDeleteRows = false;
            this.dGv_Um.AllowUserToOrderColumns = true;
            this.dGv_Um.AllowUserToResizeColumns = false;
            this.dGv_Um.AllowUserToResizeRows = false;
            this.dGv_Um.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGv_Um.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.COD_UM,
            this.DESC_UM});
            this.dGv_Um.Location = new System.Drawing.Point(7, 20);
            this.dGv_Um.Name = "dGv_Um";
            this.dGv_Um.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dGv_Um.Size = new System.Drawing.Size(301, 247);
            this.dGv_Um.TabIndex = 4;
            this.dGv_Um.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dGv_Um_CellClick);
            this.dGv_Um.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dGv_Um_KeyDown);
            // 
            // COD_UM
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.COD_UM.DefaultCellStyle = dataGridViewCellStyle3;
            this.COD_UM.HeaderText = "SIGLA";
            this.COD_UM.Name = "COD_UM";
            // 
            // DESC_UM
            // 
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DESC_UM.DefaultCellStyle = dataGridViewCellStyle4;
            this.DESC_UM.HeaderText = "Unidade de Medida";
            this.DESC_UM.Name = "DESC_UM";
            this.DESC_UM.Width = 150;
            // 
            // StStripDados
            // 
            this.StStripDados.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tstlUsuario,
            this.tstlOrgSelecionadaNumero,
            this.tstl_OrgDEscricao,
            this.TstlPapel});
            this.StStripDados.Location = new System.Drawing.Point(3, 270);
            this.StStripDados.Name = "StStripDados";
            this.StStripDados.Size = new System.Drawing.Size(722, 24);
            this.StStripDados.TabIndex = 3;
            this.StStripDados.Text = "statusStrip1";
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
            // tstlOrgSelecionadaNumero
            // 
            this.tstlOrgSelecionadaNumero.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)(((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.tstlOrgSelecionadaNumero.Name = "tstlOrgSelecionadaNumero";
            this.tstlOrgSelecionadaNumero.Size = new System.Drawing.Size(154, 19);
            this.tstlOrgSelecionadaNumero.Text = "tstlOrgSelecionadaNumero";
            // 
            // tstl_OrgDEscricao
            // 
            this.tstl_OrgDEscricao.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)(((System.Windows.Forms.ToolStripStatusLabelBorderSides.Top | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.tstl_OrgDEscricao.Name = "tstl_OrgDEscricao";
            this.tstl_OrgDEscricao.Size = new System.Drawing.Size(103, 19);
            this.tstl_OrgDEscricao.Text = "tstl_OrgDEscricao";
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
            // Frm_ParCadUnidade
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(738, 301);
            this.Controls.Add(this.grpCadUnidade);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Frm_ParCadUnidade";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Cadastro de Unidades de Medida";
            this.grpCadUnidade.ResumeLayout(false);
            this.grpCadUnidade.PerformLayout();
            this.grpDados.ResumeLayout(false);
            this.grpDados.PerformLayout();
            this.grpAlterado.ResumeLayout(false);
            this.grpAlterado.PerformLayout();
            this.grpIncluido.ResumeLayout(false);
            this.grpIncluido.PerformLayout();
            this.grpButtons.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dGv_Um)).EndInit();
            this.StStripDados.ResumeLayout(false);
            this.StStripDados.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpCadUnidade;
        private System.Windows.Forms.StatusStrip StStripDados;
        private System.Windows.Forms.ToolStripStatusLabel tstlUsuario;
        private System.Windows.Forms.ToolStripStatusLabel tstlOrgSelecionadaNumero;
        private System.Windows.Forms.ToolStripStatusLabel tstl_OrgDEscricao;
        private System.Windows.Forms.ToolStripStatusLabel TstlPapel;
        private System.Windows.Forms.DataGridView dGv_Um;
        private System.Windows.Forms.GroupBox grpButtons;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnGravar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.GroupBox grpDados;
        private System.Windows.Forms.GroupBox grpAlterado;
        private System.Windows.Forms.Label lbl_Dt_Alteracao;
        private System.Windows.Forms.Label lbl_Id_Usu_Alterado;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox grpIncluido;
        private System.Windows.Forms.Label lbl_Dt_Inclusao;
        private System.Windows.Forms.Label lbl_ID_Usu_Incl;
        private System.Windows.Forms.Label lbl_InclEm;
        private System.Windows.Forms.Label lbl_IdUsuIncl;
        private System.Windows.Forms.Label lbl_DescUm;
        private System.Windows.Forms.Label lbl_CodUM;
        private System.Windows.Forms.TextBox txtb_DescUm;
        private System.Windows.Forms.TextBox txtb_CodUm;
        private System.Windows.Forms.DataGridViewTextBoxColumn COD_UM;
        private System.Windows.Forms.DataGridViewTextBoxColumn DESC_UM;
    }
}