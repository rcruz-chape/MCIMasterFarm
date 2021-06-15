
namespace MCISYS.Negocio.Telas
{
    partial class Frm_CriaPap
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_CriaPap));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvPapel = new System.Windows.Forms.DataGridView();
            this.ID_PAPEL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NM_PAPEL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grpButtons = new System.Windows.Forms.GroupBox();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnGravar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnNovo = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tbP_AssociaPapOrg = new System.Windows.Forms.TabPage();
            this.btnRetiraAssociacao = new System.Windows.Forms.Button();
            this.btnInclueAssociacao = new System.Windows.Forms.Button();
            this.DtgOrg = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NM_ORG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID_USU_INCL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DT_INCLUSAO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tPage_AssociaPapUsu = new System.Windows.Forms.TabPage();
            this.btnREtiraAssociaOrgUsu = new System.Windows.Forms.Button();
            this.btnAssociaUsu = new System.Windows.Forms.Button();
            this.dGvUser = new System.Windows.Forms.DataGridView();
            this.ID_USU = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID_USU_INCL_PAP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DT_INCLUSAO_PAP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StStripDados = new System.Windows.Forms.StatusStrip();
            this.tstlUsuario = new System.Windows.Forms.ToolStripStatusLabel();
            this.tstlOrgSelecionadaNumero = new System.Windows.Forms.ToolStripStatusLabel();
            this.tstl_OrgDEscricao = new System.Windows.Forms.ToolStripStatusLabel();
            this.TstlPapel = new System.Windows.Forms.ToolStripStatusLabel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txt_IDPAPEL = new System.Windows.Forms.TextBox();
            this.lblID_Papel = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lbl_NmPapel = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPapel)).BeginInit();
            this.grpButtons.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tbP_AssociaPapOrg.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DtgOrg)).BeginInit();
            this.tPage_AssociaPapUsu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGvUser)).BeginInit();
            this.StStripDados.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvPapel);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(319, 267);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Papeis";
            // 
            // dgvPapel
            // 
            this.dgvPapel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPapel.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID_PAPEL,
            this.NM_PAPEL});
            this.dgvPapel.Location = new System.Drawing.Point(7, 20);
            this.dgvPapel.Name = "dgvPapel";
            this.dgvPapel.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPapel.Size = new System.Drawing.Size(312, 241);
            this.dgvPapel.TabIndex = 0;
            this.dgvPapel.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPapel_CellContentClick);
            this.dgvPapel.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgvPapel_KeyDown);
            // 
            // ID_PAPEL
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.ID_PAPEL.DefaultCellStyle = dataGridViewCellStyle1;
            this.ID_PAPEL.HeaderText = "Papel";
            this.ID_PAPEL.Name = "ID_PAPEL";
            this.ID_PAPEL.ReadOnly = true;
            // 
            // NM_PAPEL
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.NM_PAPEL.DefaultCellStyle = dataGridViewCellStyle2;
            this.NM_PAPEL.HeaderText = "Nome do Papel";
            this.NM_PAPEL.Name = "NM_PAPEL";
            this.NM_PAPEL.ReadOnly = true;
            this.NM_PAPEL.Width = 200;
            // 
            // grpButtons
            // 
            this.grpButtons.Controls.Add(this.btnSair);
            this.grpButtons.Controls.Add(this.btnGravar);
            this.grpButtons.Controls.Add(this.btnExcluir);
            this.grpButtons.Controls.Add(this.btnEditar);
            this.grpButtons.Controls.Add(this.btnNovo);
            this.grpButtons.Location = new System.Drawing.Point(328, 2);
            this.grpButtons.Name = "grpButtons";
            this.grpButtons.Size = new System.Drawing.Size(457, 58);
            this.grpButtons.TabIndex = 5;
            this.grpButtons.TabStop = false;
            // 
            // btnSair
            // 
            this.btnSair.Image = ((System.Drawing.Image)(resources.GetObject("btnSair.Image")));
            this.btnSair.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSair.Location = new System.Drawing.Point(403, 10);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(48, 44);
            this.btnSair.TabIndex = 4;
            this.btnSair.Text = "Sair";
            this.btnSair.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSair.UseVisualStyleBackColor = true;
            // 
            // btnGravar
            // 
            this.btnGravar.Enabled = false;
            this.btnGravar.Image = ((System.Drawing.Image)(resources.GetObject("btnGravar.Image")));
            this.btnGravar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnGravar.Location = new System.Drawing.Point(136, 9);
            this.btnGravar.Name = "btnGravar";
            this.btnGravar.Size = new System.Drawing.Size(48, 44);
            this.btnGravar.TabIndex = 3;
            this.btnGravar.Text = "Gravar";
            this.btnGravar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnGravar.UseVisualStyleBackColor = true;
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
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tbP_AssociaPapOrg);
            this.tabControl1.Controls.Add(this.tPage_AssociaPapUsu);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(3, 275);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(792, 266);
            this.tabControl1.TabIndex = 6;
            // 
            // tbP_AssociaPapOrg
            // 
            this.tbP_AssociaPapOrg.Controls.Add(this.btnRetiraAssociacao);
            this.tbP_AssociaPapOrg.Controls.Add(this.btnInclueAssociacao);
            this.tbP_AssociaPapOrg.Controls.Add(this.DtgOrg);
            this.tbP_AssociaPapOrg.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbP_AssociaPapOrg.Location = new System.Drawing.Point(4, 22);
            this.tbP_AssociaPapOrg.Name = "tbP_AssociaPapOrg";
            this.tbP_AssociaPapOrg.Padding = new System.Windows.Forms.Padding(3);
            this.tbP_AssociaPapOrg.Size = new System.Drawing.Size(784, 240);
            this.tbP_AssociaPapOrg.TabIndex = 0;
            this.tbP_AssociaPapOrg.Tag = "AssociaPapOrg";
            this.tbP_AssociaPapOrg.Text = "Orgs Associados";
            this.tbP_AssociaPapOrg.UseVisualStyleBackColor = true;
            // 
            // btnRetiraAssociacao
            // 
            this.btnRetiraAssociacao.Enabled = false;
            this.btnRetiraAssociacao.Image = ((System.Drawing.Image)(resources.GetObject("btnRetiraAssociacao.Image")));
            this.btnRetiraAssociacao.Location = new System.Drawing.Point(752, 28);
            this.btnRetiraAssociacao.Name = "btnRetiraAssociacao";
            this.btnRetiraAssociacao.Size = new System.Drawing.Size(24, 26);
            this.btnRetiraAssociacao.TabIndex = 26;
            this.btnRetiraAssociacao.UseVisualStyleBackColor = true;
            this.btnRetiraAssociacao.Click += new System.EventHandler(this.btnRetiraAssociacao_Click);
            // 
            // btnInclueAssociacao
            // 
            this.btnInclueAssociacao.Enabled = false;
            this.btnInclueAssociacao.Image = ((System.Drawing.Image)(resources.GetObject("btnInclueAssociacao.Image")));
            this.btnInclueAssociacao.Location = new System.Drawing.Point(752, 3);
            this.btnInclueAssociacao.Name = "btnInclueAssociacao";
            this.btnInclueAssociacao.Size = new System.Drawing.Size(24, 26);
            this.btnInclueAssociacao.TabIndex = 27;
            this.btnInclueAssociacao.UseVisualStyleBackColor = true;
            this.btnInclueAssociacao.Click += new System.EventHandler(this.btnInclueAssociacao_Click);
            // 
            // DtgOrg
            // 
            this.DtgOrg.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DtgOrg.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.DtgOrg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DtgOrg.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.NM_ORG,
            this.ID_USU_INCL,
            this.DT_INCLUSAO});
            this.DtgOrg.Location = new System.Drawing.Point(3, 3);
            this.DtgOrg.Name = "DtgOrg";
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.Padding = new System.Windows.Forms.Padding(1);
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.Window;
            this.DtgOrg.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.DtgOrg.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DtgOrg.Size = new System.Drawing.Size(743, 234);
            this.DtgOrg.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.dataGridViewTextBoxColumn1.DefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridViewTextBoxColumn1.HeaderText = "Org ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // NM_ORG
            // 
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.NM_ORG.DefaultCellStyle = dataGridViewCellStyle5;
            this.NM_ORG.HeaderText = "Org";
            this.NM_ORG.Name = "NM_ORG";
            this.NM_ORG.ReadOnly = true;
            this.NM_ORG.Width = 300;
            // 
            // ID_USU_INCL
            // 
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.ID_USU_INCL.DefaultCellStyle = dataGridViewCellStyle6;
            this.ID_USU_INCL.HeaderText = "Incluído Por";
            this.ID_USU_INCL.Name = "ID_USU_INCL";
            // 
            // DT_INCLUSAO
            // 
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle7.Format = "g";
            dataGridViewCellStyle7.NullValue = null;
            this.DT_INCLUSAO.DefaultCellStyle = dataGridViewCellStyle7;
            this.DT_INCLUSAO.HeaderText = "Incluído EM";
            this.DT_INCLUSAO.Name = "DT_INCLUSAO";
            this.DT_INCLUSAO.Width = 200;
            // 
            // tPage_AssociaPapUsu
            // 
            this.tPage_AssociaPapUsu.Controls.Add(this.btnREtiraAssociaOrgUsu);
            this.tPage_AssociaPapUsu.Controls.Add(this.btnAssociaUsu);
            this.tPage_AssociaPapUsu.Controls.Add(this.dGvUser);
            this.tPage_AssociaPapUsu.Location = new System.Drawing.Point(4, 22);
            this.tPage_AssociaPapUsu.Name = "tPage_AssociaPapUsu";
            this.tPage_AssociaPapUsu.Padding = new System.Windows.Forms.Padding(3);
            this.tPage_AssociaPapUsu.Size = new System.Drawing.Size(784, 240);
            this.tPage_AssociaPapUsu.TabIndex = 1;
            this.tPage_AssociaPapUsu.Tag = "AssociaPapUsu";
            this.tPage_AssociaPapUsu.Text = "Usuário Associados";
            this.tPage_AssociaPapUsu.UseVisualStyleBackColor = true;
            // 
            // btnREtiraAssociaOrgUsu
            // 
            this.btnREtiraAssociaOrgUsu.Enabled = false;
            this.btnREtiraAssociaOrgUsu.Image = ((System.Drawing.Image)(resources.GetObject("btnREtiraAssociaOrgUsu.Image")));
            this.btnREtiraAssociaOrgUsu.Location = new System.Drawing.Point(748, 31);
            this.btnREtiraAssociaOrgUsu.Name = "btnREtiraAssociaOrgUsu";
            this.btnREtiraAssociaOrgUsu.Size = new System.Drawing.Size(24, 26);
            this.btnREtiraAssociaOrgUsu.TabIndex = 28;
            this.btnREtiraAssociaOrgUsu.UseVisualStyleBackColor = true;
            this.btnREtiraAssociaOrgUsu.Click += new System.EventHandler(this.btnREtiraAssociaOrgUsu_Click);
            // 
            // btnAssociaUsu
            // 
            this.btnAssociaUsu.Enabled = false;
            this.btnAssociaUsu.Image = ((System.Drawing.Image)(resources.GetObject("btnAssociaUsu.Image")));
            this.btnAssociaUsu.Location = new System.Drawing.Point(748, 6);
            this.btnAssociaUsu.Name = "btnAssociaUsu";
            this.btnAssociaUsu.Size = new System.Drawing.Size(24, 26);
            this.btnAssociaUsu.TabIndex = 29;
            this.btnAssociaUsu.UseVisualStyleBackColor = true;
            this.btnAssociaUsu.Click += new System.EventHandler(this.btnAssociaUsu_Click);
            // 
            // dGvUser
            // 
            this.dGvUser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGvUser.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID_USU,
            this.ID_USU_INCL_PAP,
            this.DT_INCLUSAO_PAP});
            this.dGvUser.Location = new System.Drawing.Point(3, 6);
            this.dGvUser.Name = "dGvUser";
            this.dGvUser.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dGvUser.Size = new System.Drawing.Size(739, 228);
            this.dGvUser.TabIndex = 0;
            // 
            // ID_USU
            // 
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.ID_USU.DefaultCellStyle = dataGridViewCellStyle9;
            this.ID_USU.HeaderText = "Usuário Associado";
            this.ID_USU.Name = "ID_USU";
            this.ID_USU.ReadOnly = true;
            this.ID_USU.Width = 300;
            // 
            // ID_USU_INCL_PAP
            // 
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.ID_USU_INCL_PAP.DefaultCellStyle = dataGridViewCellStyle10;
            this.ID_USU_INCL_PAP.HeaderText = "Incluído Por";
            this.ID_USU_INCL_PAP.Name = "ID_USU_INCL_PAP";
            this.ID_USU_INCL_PAP.ReadOnly = true;
            this.ID_USU_INCL_PAP.Width = 200;
            // 
            // DT_INCLUSAO_PAP
            // 
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.DT_INCLUSAO_PAP.DefaultCellStyle = dataGridViewCellStyle11;
            this.DT_INCLUSAO_PAP.HeaderText = "Incluído Em:";
            this.DT_INCLUSAO_PAP.Name = "DT_INCLUSAO_PAP";
            this.DT_INCLUSAO_PAP.ReadOnly = true;
            this.DT_INCLUSAO_PAP.Width = 200;
            // 
            // StStripDados
            // 
            this.StStripDados.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tstlUsuario,
            this.tstlOrgSelecionadaNumero,
            this.tstl_OrgDEscricao,
            this.TstlPapel});
            this.StStripDados.Location = new System.Drawing.Point(0, 545);
            this.StStripDados.Name = "StStripDados";
            this.StStripDados.Size = new System.Drawing.Size(799, 24);
            this.StStripDados.TabIndex = 7;
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
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.groupBox4);
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Controls.Add(this.lbl_NmPapel);
            this.groupBox2.Controls.Add(this.textBox1);
            this.groupBox2.Controls.Add(this.lblID_Papel);
            this.groupBox2.Controls.Add(this.txt_IDPAPEL);
            this.groupBox2.Enabled = false;
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(328, 61);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(457, 208);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Papel Selecionado";
            // 
            // txt_IDPAPEL
            // 
            this.txt_IDPAPEL.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.txt_IDPAPEL.Location = new System.Drawing.Point(79, 27);
            this.txt_IDPAPEL.Name = "txt_IDPAPEL";
            this.txt_IDPAPEL.Size = new System.Drawing.Size(177, 20);
            this.txt_IDPAPEL.TabIndex = 0;
            // 
            // lblID_Papel
            // 
            this.lblID_Papel.AutoSize = true;
            this.lblID_Papel.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblID_Papel.Location = new System.Drawing.Point(9, 29);
            this.lblID_Papel.Name = "lblID_Papel";
            this.lblID_Papel.Size = new System.Drawing.Size(58, 13);
            this.lblID_Papel.TabIndex = 1;
            this.lblID_Papel.Text = "Id Papel:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(79, 46);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(372, 20);
            this.textBox1.TabIndex = 2;
            // 
            // lbl_NmPapel
            // 
            this.lbl_NmPapel.AutoSize = true;
            this.lbl_NmPapel.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lbl_NmPapel.Location = new System.Drawing.Point(9, 50);
            this.lbl_NmPapel.Name = "lbl_NmPapel";
            this.lbl_NmPapel.Size = new System.Drawing.Size(62, 13);
            this.lbl_NmPapel.TabIndex = 3;
            this.lbl_NmPapel.Text = "Ds Papel:";
            // 
            // groupBox3
            // 
            this.groupBox3.Location = new System.Drawing.Point(6, 72);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(199, 85);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Incluído";
            // 
            // groupBox4
            // 
            this.groupBox4.Location = new System.Drawing.Point(250, 72);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(199, 85);
            this.groupBox4.TabIndex = 5;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Alterado:";
            // 
            // Frm_CriaPap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(799, 569);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.StStripDados);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.grpButtons);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Frm_CriaPap";
            this.Tag = "CriaPap";
            this.Text = "Papeis de Usuário";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPapel)).EndInit();
            this.grpButtons.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tbP_AssociaPapOrg.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DtgOrg)).EndInit();
            this.tPage_AssociaPapUsu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dGvUser)).EndInit();
            this.StStripDados.ResumeLayout(false);
            this.StStripDados.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvPapel;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_PAPEL;
        private System.Windows.Forms.DataGridViewTextBoxColumn NM_PAPEL;
        private System.Windows.Forms.GroupBox grpButtons;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnGravar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tbP_AssociaPapOrg;
        private System.Windows.Forms.Button btnRetiraAssociacao;
        private System.Windows.Forms.Button btnInclueAssociacao;
        private System.Windows.Forms.DataGridView DtgOrg;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn NM_ORG;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_USU_INCL;
        private System.Windows.Forms.DataGridViewTextBoxColumn DT_INCLUSAO;
        private System.Windows.Forms.TabPage tPage_AssociaPapUsu;
        private System.Windows.Forms.Button btnREtiraAssociaOrgUsu;
        private System.Windows.Forms.Button btnAssociaUsu;
        private System.Windows.Forms.DataGridView dGvUser;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_USU;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_USU_INCL_PAP;
        private System.Windows.Forms.DataGridViewTextBoxColumn DT_INCLUSAO_PAP;
        private System.Windows.Forms.StatusStrip StStripDados;
        private System.Windows.Forms.ToolStripStatusLabel tstlUsuario;
        private System.Windows.Forms.ToolStripStatusLabel tstlOrgSelecionadaNumero;
        private System.Windows.Forms.ToolStripStatusLabel tstl_OrgDEscricao;
        private System.Windows.Forms.ToolStripStatusLabel TstlPapel;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label lbl_NmPapel;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblID_Papel;
        private System.Windows.Forms.TextBox txt_IDPAPEL;
    }
}