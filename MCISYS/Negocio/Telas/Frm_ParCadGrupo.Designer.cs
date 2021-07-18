
namespace MCISYS.Negocio.Telas
{
    partial class Frm_ParCadGrupo
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_ParCadGrupo));
            this.grpGrpMerc = new System.Windows.Forms.GroupBox();
            this.dgvGrpMerc = new System.Windows.Forms.DataGridView();
            this.ID_GRP_MERC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NM_GRP_MERC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StStripDados = new System.Windows.Forms.StatusStrip();
            this.tstlUsuario = new System.Windows.Forms.ToolStripStatusLabel();
            this.tstlOrgSelecionadaNumero = new System.Windows.Forms.ToolStripStatusLabel();
            this.tstl_OrgDEscricao = new System.Windows.Forms.ToolStripStatusLabel();
            this.TstlPapel = new System.Windows.Forms.ToolStripStatusLabel();
            this.grpButtons = new System.Windows.Forms.GroupBox();
            this.btnGravar = new System.Windows.Forms.Button();
            this.btnDesativar = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnAtivar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnNovo = new System.Windows.Forms.Button();
            this.grp_Dados = new System.Windows.Forms.GroupBox();
            this.lbl_Situacao = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.lbl_Dt_Alteracao = new System.Windows.Forms.Label();
            this.lbl_Id_Usu_Alterado = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lbl_Dt_Inclusao = new System.Windows.Forms.Label();
            this.lbl_ID_Usu_Incl = new System.Windows.Forms.Label();
            this.lbl_InclEm = new System.Windows.Forms.Label();
            this.lbl_IdUsuIncl = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_NmgrpMerc = new System.Windows.Forms.TextBox();
            this.grpMercGrupoID = new System.Windows.Forms.GroupBox();
            this.lbl_ID_GrpMerc = new System.Windows.Forms.Label();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.grpGrpMerc.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGrpMerc)).BeginInit();
            this.StStripDados.SuspendLayout();
            this.grpButtons.SuspendLayout();
            this.grp_Dados.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.grpMercGrupoID.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpGrpMerc
            // 
            this.grpGrpMerc.Controls.Add(this.dgvGrpMerc);
            this.grpGrpMerc.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpGrpMerc.Location = new System.Drawing.Point(1, 0);
            this.grpGrpMerc.Name = "grpGrpMerc";
            this.grpGrpMerc.Size = new System.Drawing.Size(355, 293);
            this.grpGrpMerc.TabIndex = 0;
            this.grpGrpMerc.TabStop = false;
            this.grpGrpMerc.Text = "Lista de Grupo de Mercadoria";
            // 
            // dgvGrpMerc
            // 
            this.dgvGrpMerc.AllowUserToAddRows = false;
            this.dgvGrpMerc.AllowUserToDeleteRows = false;
            this.dgvGrpMerc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGrpMerc.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID_GRP_MERC,
            this.NM_GRP_MERC});
            this.dgvGrpMerc.Location = new System.Drawing.Point(7, 13);
            this.dgvGrpMerc.Name = "dgvGrpMerc";
            this.dgvGrpMerc.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvGrpMerc.Size = new System.Drawing.Size(342, 274);
            this.dgvGrpMerc.TabIndex = 0;
            this.dgvGrpMerc.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvGrpMerc_CellClick);
            this.dgvGrpMerc.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgvGrpMerc_KeyDown);
            // 
            // ID_GRP_MERC
            // 
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ID_GRP_MERC.DefaultCellStyle = dataGridViewCellStyle11;
            this.ID_GRP_MERC.HeaderText = "Código";
            this.ID_GRP_MERC.Name = "ID_GRP_MERC";
            // 
            // NM_GRP_MERC
            // 
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NM_GRP_MERC.DefaultCellStyle = dataGridViewCellStyle12;
            this.NM_GRP_MERC.HeaderText = "Nome";
            this.NM_GRP_MERC.Name = "NM_GRP_MERC";
            this.NM_GRP_MERC.Width = 200;
            // 
            // StStripDados
            // 
            this.StStripDados.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tstlUsuario,
            this.tstlOrgSelecionadaNumero,
            this.tstl_OrgDEscricao,
            this.TstlPapel});
            this.StStripDados.Location = new System.Drawing.Point(0, 296);
            this.StStripDados.Name = "StStripDados";
            this.StStripDados.Size = new System.Drawing.Size(785, 24);
            this.StStripDados.TabIndex = 8;
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
            // grpButtons
            // 
            this.grpButtons.Controls.Add(this.btnExcluir);
            this.grpButtons.Controls.Add(this.btnGravar);
            this.grpButtons.Controls.Add(this.btnDesativar);
            this.grpButtons.Controls.Add(this.btnSair);
            this.grpButtons.Controls.Add(this.btnAtivar);
            this.grpButtons.Controls.Add(this.btnEditar);
            this.grpButtons.Controls.Add(this.btnNovo);
            this.grpButtons.Location = new System.Drawing.Point(362, 0);
            this.grpButtons.Name = "grpButtons";
            this.grpButtons.Size = new System.Drawing.Size(417, 58);
            this.grpButtons.TabIndex = 10;
            this.grpButtons.TabStop = false;
            // 
            // btnGravar
            // 
            this.btnGravar.Enabled = false;
            this.btnGravar.Image = ((System.Drawing.Image)(resources.GetObject("btnGravar.Image")));
            this.btnGravar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnGravar.Location = new System.Drawing.Point(263, 9);
            this.btnGravar.Name = "btnGravar";
            this.btnGravar.Size = new System.Drawing.Size(48, 44);
            this.btnGravar.TabIndex = 6;
            this.btnGravar.Text = "Gravar";
            this.btnGravar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnGravar.UseVisualStyleBackColor = true;
            this.btnGravar.Click += new System.EventHandler(this.btnGravar_Click);
            // 
            // btnDesativar
            // 
            this.btnDesativar.Enabled = false;
            this.btnDesativar.Image = global::MCISYS.Properties.Resources.icons8_interruptor_de_luz_24;
            this.btnDesativar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnDesativar.Location = new System.Drawing.Point(199, 9);
            this.btnDesativar.Name = "btnDesativar";
            this.btnDesativar.Size = new System.Drawing.Size(61, 44);
            this.btnDesativar.TabIndex = 5;
            this.btnDesativar.Text = "Desativar";
            this.btnDesativar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnDesativar.UseVisualStyleBackColor = true;
            this.btnDesativar.Click += new System.EventHandler(this.btnDesativar_Click);
            // 
            // btnSair
            // 
            this.btnSair.Image = ((System.Drawing.Image)(resources.GetObject("btnSair.Image")));
            this.btnSair.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSair.Location = new System.Drawing.Point(361, 9);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(48, 44);
            this.btnSair.TabIndex = 4;
            this.btnSair.Text = "Sair";
            this.btnSair.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnAtivar
            // 
            this.btnAtivar.Enabled = false;
            this.btnAtivar.Image = global::MCISYS.Properties.Resources.icons8_interruptor_de_luz_24_up;
            this.btnAtivar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnAtivar.Location = new System.Drawing.Point(147, 9);
            this.btnAtivar.Name = "btnAtivar";
            this.btnAtivar.Size = new System.Drawing.Size(48, 44);
            this.btnAtivar.TabIndex = 3;
            this.btnAtivar.Text = "Ativar";
            this.btnAtivar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAtivar.UseVisualStyleBackColor = true;
            this.btnAtivar.Click += new System.EventHandler(this.btnAtivar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Image = ((System.Drawing.Image)(resources.GetObject("btnEditar.Image")));
            this.btnEditar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnEditar.Location = new System.Drawing.Point(53, 9);
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
            this.btnNovo.Location = new System.Drawing.Point(11, 9);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(42, 44);
            this.btnNovo.TabIndex = 0;
            this.btnNovo.Text = "Novo";
            this.btnNovo.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnNovo.UseVisualStyleBackColor = true;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // grp_Dados
            // 
            this.grp_Dados.Controls.Add(this.lbl_Situacao);
            this.grp_Dados.Controls.Add(this.groupBox4);
            this.grp_Dados.Controls.Add(this.groupBox3);
            this.grp_Dados.Controls.Add(this.label1);
            this.grp_Dados.Controls.Add(this.txt_NmgrpMerc);
            this.grp_Dados.Controls.Add(this.grpMercGrupoID);
            this.grp_Dados.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grp_Dados.Location = new System.Drawing.Point(363, 59);
            this.grp_Dados.Name = "grp_Dados";
            this.grp_Dados.Size = new System.Drawing.Size(415, 234);
            this.grp_Dados.TabIndex = 11;
            this.grp_Dados.TabStop = false;
            this.grp_Dados.Text = "Dados do Grupo de Mercadoria";
            // 
            // lbl_Situacao
            // 
            this.lbl_Situacao.AutoSize = true;
            this.lbl_Situacao.ForeColor = System.Drawing.Color.Maroon;
            this.lbl_Situacao.Location = new System.Drawing.Point(306, 39);
            this.lbl_Situacao.Name = "lbl_Situacao";
            this.lbl_Situacao.Size = new System.Drawing.Size(57, 13);
            this.lbl_Situacao.TabIndex = 1;
            this.lbl_Situacao.Text = "Situacao";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.lbl_Dt_Alteracao);
            this.groupBox4.Controls.Add(this.lbl_Id_Usu_Alterado);
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Location = new System.Drawing.Point(217, 129);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(199, 85);
            this.groupBox4.TabIndex = 7;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Alterado:";
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Em:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Por:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lbl_Dt_Inclusao);
            this.groupBox3.Controls.Add(this.lbl_ID_Usu_Incl);
            this.groupBox3.Controls.Add(this.lbl_InclEm);
            this.groupBox3.Controls.Add(this.lbl_IdUsuIncl);
            this.groupBox3.Location = new System.Drawing.Point(6, 129);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(199, 85);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Incluído";
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nome de Grupo";
            // 
            // txt_NmgrpMerc
            // 
            this.txt_NmgrpMerc.Location = new System.Drawing.Point(6, 96);
            this.txt_NmgrpMerc.Name = "txt_NmgrpMerc";
            this.txt_NmgrpMerc.Size = new System.Drawing.Size(402, 20);
            this.txt_NmgrpMerc.TabIndex = 2;
            // 
            // grpMercGrupoID
            // 
            this.grpMercGrupoID.Controls.Add(this.lbl_ID_GrpMerc);
            this.grpMercGrupoID.Location = new System.Drawing.Point(6, 19);
            this.grpMercGrupoID.Name = "grpMercGrupoID";
            this.grpMercGrupoID.Size = new System.Drawing.Size(113, 53);
            this.grpMercGrupoID.TabIndex = 1;
            this.grpMercGrupoID.TabStop = false;
            this.grpMercGrupoID.Text = "Código";
            // 
            // lbl_ID_GrpMerc
            // 
            this.lbl_ID_GrpMerc.AutoSize = true;
            this.lbl_ID_GrpMerc.ForeColor = System.Drawing.Color.Maroon;
            this.lbl_ID_GrpMerc.Location = new System.Drawing.Point(9, 20);
            this.lbl_ID_GrpMerc.Name = "lbl_ID_GrpMerc";
            this.lbl_ID_GrpMerc.Size = new System.Drawing.Size(77, 13);
            this.lbl_ID_GrpMerc.TabIndex = 0;
            this.lbl_ID_GrpMerc.Text = "Grupo: 0000";
            // 
            // btnExcluir
            // 
            this.btnExcluir.Enabled = false;
            this.btnExcluir.Image = ((System.Drawing.Image)(resources.GetObject("btnExcluir.Image")));
            this.btnExcluir.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnExcluir.Location = new System.Drawing.Point(96, 9);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(48, 44);
            this.btnExcluir.TabIndex = 7;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // Frm_ParCadGrupo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(785, 320);
            this.Controls.Add(this.grp_Dados);
            this.Controls.Add(this.grpButtons);
            this.Controls.Add(this.StStripDados);
            this.Controls.Add(this.grpGrpMerc);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Frm_ParCadGrupo";
            this.Text = "Cadastro de Grupo de Mercadoria";
            this.grpGrpMerc.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvGrpMerc)).EndInit();
            this.StStripDados.ResumeLayout(false);
            this.StStripDados.PerformLayout();
            this.grpButtons.ResumeLayout(false);
            this.grp_Dados.ResumeLayout(false);
            this.grp_Dados.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.grpMercGrupoID.ResumeLayout(false);
            this.grpMercGrupoID.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpGrpMerc;
        private System.Windows.Forms.StatusStrip StStripDados;
        private System.Windows.Forms.ToolStripStatusLabel tstlUsuario;
        private System.Windows.Forms.ToolStripStatusLabel tstlOrgSelecionadaNumero;
        private System.Windows.Forms.ToolStripStatusLabel tstl_OrgDEscricao;
        private System.Windows.Forms.ToolStripStatusLabel TstlPapel;
        private System.Windows.Forms.DataGridView dgvGrpMerc;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_GRP_MERC;
        private System.Windows.Forms.DataGridViewTextBoxColumn NM_GRP_MERC;
        private System.Windows.Forms.GroupBox grpButtons;
        private System.Windows.Forms.Button btnGravar;
        private System.Windows.Forms.Button btnDesativar;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnAtivar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.GroupBox grp_Dados;
        private System.Windows.Forms.Label lbl_ID_GrpMerc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_NmgrpMerc;
        private System.Windows.Forms.GroupBox grpMercGrupoID;
        private System.Windows.Forms.Label lbl_Situacao;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label lbl_Dt_Alteracao;
        private System.Windows.Forms.Label lbl_Id_Usu_Alterado;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label lbl_Dt_Inclusao;
        private System.Windows.Forms.Label lbl_ID_Usu_Incl;
        private System.Windows.Forms.Label lbl_InclEm;
        private System.Windows.Forms.Label lbl_IdUsuIncl;
        private System.Windows.Forms.Button btnExcluir;
    }
}