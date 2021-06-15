
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.trvOrgs = new System.Windows.Forms.TreeView();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tbP_AssociaOrgPap = new System.Windows.Forms.TabPage();
            this.btnRetiraAssociacao = new System.Windows.Forms.Button();
            this.btnInclueAssociacao = new System.Windows.Forms.Button();
            this.DtgPapel = new System.Windows.Forms.DataGridView();
            this.ID_Papel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DS_PAPEL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID_USU_INCL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DT_INCLUSAO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tPage_AssociaOrgUsu = new System.Windows.Forms.TabPage();
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
            this.grb = new System.Windows.Forms.GroupBox();
            this.lbLic = new System.Windows.Forms.Label();
            this.lbl_TpOrg = new System.Windows.Forms.Label();
            this.cbx_TpOrg = new System.Windows.Forms.ComboBox();
            this.lbl_OrgMae = new System.Windows.Forms.Label();
            this.cbx_OrgMae = new System.Windows.Forms.ComboBox();
            this.lbl_NmOrgResumido = new System.Windows.Forms.Label();
            this.txb_OrgResumido = new System.Windows.Forms.TextBox();
            this.lbl_DisplayOrg = new System.Windows.Forms.Label();
            this.txBNmOrg = new System.Windows.Forms.TextBox();
            this.lblORG = new System.Windows.Forms.Label();
            this.grpButtons = new System.Windows.Forms.GroupBox();
            this.btnLic = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnGravar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnNovo = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tbP_AssociaOrgPap.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DtgPapel)).BeginInit();
            this.tPage_AssociaOrgUsu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGvUser)).BeginInit();
            this.StStripDados.SuspendLayout();
            this.grb.SuspendLayout();
            this.grpButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.trvOrgs);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(5, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(319, 267);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Organizações";
            // 
            // trvOrgs
            // 
            this.trvOrgs.Location = new System.Drawing.Point(7, 19);
            this.trvOrgs.Name = "trvOrgs";
            this.trvOrgs.Size = new System.Drawing.Size(306, 242);
            this.trvOrgs.TabIndex = 0;
            this.trvOrgs.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.trvOrgs_AfterSelect);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tbP_AssociaOrgPap);
            this.tabControl1.Controls.Add(this.tPage_AssociaOrgUsu);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(7, 276);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(792, 266);
            this.tabControl1.TabIndex = 1;
            // 
            // tbP_AssociaOrgPap
            // 
            this.tbP_AssociaOrgPap.Controls.Add(this.DtgPapel);
            this.tbP_AssociaOrgPap.Controls.Add(this.btnRetiraAssociacao);
            this.tbP_AssociaOrgPap.Controls.Add(this.btnInclueAssociacao);
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
            // DtgPapel
            // 
            this.DtgPapel.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DtgPapel.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DtgPapel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DtgPapel.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID_Papel,
            this.DS_PAPEL,
            this.ID_USU_INCL,
            this.DT_INCLUSAO});
            this.DtgPapel.Location = new System.Drawing.Point(3, 3);
            this.DtgPapel.Name = "DtgPapel";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.Padding = new System.Windows.Forms.Padding(1);
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.Window;
            this.DtgPapel.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.DtgPapel.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DtgPapel.Size = new System.Drawing.Size(743, 234);
            this.DtgPapel.TabIndex = 0;
            // 
            // ID_Papel
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.ID_Papel.DefaultCellStyle = dataGridViewCellStyle2;
            this.ID_Papel.HeaderText = "Papel ID";
            this.ID_Papel.Name = "ID_Papel";
            // 
            // DS_PAPEL
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.DS_PAPEL.DefaultCellStyle = dataGridViewCellStyle3;
            this.DS_PAPEL.HeaderText = "Papel";
            this.DS_PAPEL.Name = "DS_PAPEL";
            this.DS_PAPEL.ReadOnly = true;
            this.DS_PAPEL.Width = 300;
            // 
            // ID_USU_INCL
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.ID_USU_INCL.DefaultCellStyle = dataGridViewCellStyle4;
            this.ID_USU_INCL.HeaderText = "Incluído Por";
            this.ID_USU_INCL.Name = "ID_USU_INCL";
            // 
            // DT_INCLUSAO
            // 
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle5.Format = "g";
            dataGridViewCellStyle5.NullValue = null;
            this.DT_INCLUSAO.DefaultCellStyle = dataGridViewCellStyle5;
            this.DT_INCLUSAO.HeaderText = "Incluído EM";
            this.DT_INCLUSAO.Name = "DT_INCLUSAO";
            this.DT_INCLUSAO.Width = 200;
            // 
            // tPage_AssociaOrgUsu
            // 
            this.tPage_AssociaOrgUsu.Controls.Add(this.btnREtiraAssociaOrgUsu);
            this.tPage_AssociaOrgUsu.Controls.Add(this.btnAssociaUsu);
            this.tPage_AssociaOrgUsu.Controls.Add(this.dGvUser);
            this.tPage_AssociaOrgUsu.Location = new System.Drawing.Point(4, 22);
            this.tPage_AssociaOrgUsu.Name = "tPage_AssociaOrgUsu";
            this.tPage_AssociaOrgUsu.Padding = new System.Windows.Forms.Padding(3);
            this.tPage_AssociaOrgUsu.Size = new System.Drawing.Size(784, 240);
            this.tPage_AssociaOrgUsu.TabIndex = 1;
            this.tPage_AssociaOrgUsu.Tag = "AssociaOrgUsu";
            this.tPage_AssociaOrgUsu.Text = "Usuário Associados";
            this.tPage_AssociaOrgUsu.UseVisualStyleBackColor = true;
            // 
            // btnREtiraAssociaOrgUsu
            // 
            this.btnREtiraAssociaOrgUsu.Enabled = false;
            this.btnREtiraAssociaOrgUsu.Image = ((System.Drawing.Image)(resources.GetObject("btnREtiraAssociaOrgUsu.Image")));
            this.btnREtiraAssociaOrgUsu.Location = new System.Drawing.Point(752, 28);
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
            this.btnAssociaUsu.Location = new System.Drawing.Point(752, 3);
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
            this.dGvUser.Location = new System.Drawing.Point(3, 3);
            this.dGvUser.Name = "dGvUser";
            this.dGvUser.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dGvUser.Size = new System.Drawing.Size(739, 228);
            this.dGvUser.TabIndex = 0;
            // 
            // ID_USU
            // 
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.ID_USU.DefaultCellStyle = dataGridViewCellStyle7;
            this.ID_USU.HeaderText = "Usuário Associado";
            this.ID_USU.Name = "ID_USU";
            this.ID_USU.ReadOnly = true;
            this.ID_USU.Width = 300;
            // 
            // ID_USU_INCL_PAP
            // 
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.ID_USU_INCL_PAP.DefaultCellStyle = dataGridViewCellStyle8;
            this.ID_USU_INCL_PAP.HeaderText = "Incluído Por";
            this.ID_USU_INCL_PAP.Name = "ID_USU_INCL_PAP";
            this.ID_USU_INCL_PAP.ReadOnly = true;
            this.ID_USU_INCL_PAP.Width = 200;
            // 
            // DT_INCLUSAO_PAP
            // 
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.DT_INCLUSAO_PAP.DefaultCellStyle = dataGridViewCellStyle9;
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
            this.StStripDados.TabIndex = 2;
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
            // grb
            // 
            this.grb.Controls.Add(this.lbLic);
            this.grb.Controls.Add(this.lbl_TpOrg);
            this.grb.Controls.Add(this.cbx_TpOrg);
            this.grb.Controls.Add(this.lbl_OrgMae);
            this.grb.Controls.Add(this.cbx_OrgMae);
            this.grb.Controls.Add(this.lbl_NmOrgResumido);
            this.grb.Controls.Add(this.txb_OrgResumido);
            this.grb.Controls.Add(this.lbl_DisplayOrg);
            this.grb.Controls.Add(this.txBNmOrg);
            this.grb.Controls.Add(this.lblORG);
            this.grb.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grb.ForeColor = System.Drawing.SystemColors.ControlText;
            this.grb.Location = new System.Drawing.Point(330, 61);
            this.grb.Name = "grb";
            this.grb.Size = new System.Drawing.Size(458, 209);
            this.grb.TabIndex = 3;
            this.grb.TabStop = false;
            this.grb.Text = "Dados Organizacionais";
            // 
            // lbLic
            // 
            this.lbLic.AutoSize = true;
            this.lbLic.Location = new System.Drawing.Point(202, 21);
            this.lbLic.Name = "lbLic";
            this.lbLic.Size = new System.Drawing.Size(0, 13);
            this.lbLic.TabIndex = 9;
            // 
            // lbl_TpOrg
            // 
            this.lbl_TpOrg.AutoSize = true;
            this.lbl_TpOrg.Location = new System.Drawing.Point(11, 132);
            this.lbl_TpOrg.Name = "lbl_TpOrg";
            this.lbl_TpOrg.Size = new System.Drawing.Size(60, 13);
            this.lbl_TpOrg.TabIndex = 8;
            this.lbl_TpOrg.Text = "Tipo Org:";
            // 
            // cbx_TpOrg
            // 
            this.cbx_TpOrg.Enabled = false;
            this.cbx_TpOrg.FormattingEnabled = true;
            this.cbx_TpOrg.Location = new System.Drawing.Point(11, 149);
            this.cbx_TpOrg.Name = "cbx_TpOrg";
            this.cbx_TpOrg.Size = new System.Drawing.Size(176, 21);
            this.cbx_TpOrg.TabIndex = 7;
            // 
            // lbl_OrgMae
            // 
            this.lbl_OrgMae.AutoSize = true;
            this.lbl_OrgMae.Location = new System.Drawing.Point(192, 89);
            this.lbl_OrgMae.Name = "lbl_OrgMae";
            this.lbl_OrgMae.Size = new System.Drawing.Size(63, 13);
            this.lbl_OrgMae.TabIndex = 6;
            this.lbl_OrgMae.Text = "Org. Mãe:";
            // 
            // cbx_OrgMae
            // 
            this.cbx_OrgMae.Enabled = false;
            this.cbx_OrgMae.FormattingEnabled = true;
            this.cbx_OrgMae.Location = new System.Drawing.Point(193, 106);
            this.cbx_OrgMae.Name = "cbx_OrgMae";
            this.cbx_OrgMae.Size = new System.Drawing.Size(259, 21);
            this.cbx_OrgMae.TabIndex = 5;
            // 
            // lbl_NmOrgResumido
            // 
            this.lbl_NmOrgResumido.AutoSize = true;
            this.lbl_NmOrgResumido.Location = new System.Drawing.Point(11, 90);
            this.lbl_NmOrgResumido.Name = "lbl_NmOrgResumido";
            this.lbl_NmOrgResumido.Size = new System.Drawing.Size(90, 13);
            this.lbl_NmOrgResumido.TabIndex = 4;
            this.lbl_NmOrgResumido.Text = "Org Resumida:";
            // 
            // txb_OrgResumido
            // 
            this.txb_OrgResumido.Enabled = false;
            this.txb_OrgResumido.Location = new System.Drawing.Point(11, 107);
            this.txb_OrgResumido.Name = "txb_OrgResumido";
            this.txb_OrgResumido.Size = new System.Drawing.Size(176, 20);
            this.txb_OrgResumido.TabIndex = 3;
            // 
            // lbl_DisplayOrg
            // 
            this.lbl_DisplayOrg.AutoSize = true;
            this.lbl_DisplayOrg.Location = new System.Drawing.Point(10, 50);
            this.lbl_DisplayOrg.Name = "lbl_DisplayOrg";
            this.lbl_DisplayOrg.Size = new System.Drawing.Size(122, 13);
            this.lbl_DisplayOrg.TabIndex = 2;
            this.lbl_DisplayOrg.Text = "Nome Organização: ";
            // 
            // txBNmOrg
            // 
            this.txBNmOrg.Enabled = false;
            this.txBNmOrg.Location = new System.Drawing.Point(10, 67);
            this.txBNmOrg.Name = "txBNmOrg";
            this.txBNmOrg.Size = new System.Drawing.Size(441, 20);
            this.txBNmOrg.TabIndex = 1;
            // 
            // lblORG
            // 
            this.lblORG.AutoSize = true;
            this.lblORG.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblORG.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblORG.Location = new System.Drawing.Point(12, 21);
            this.lblORG.Name = "lblORG";
            this.lblORG.Size = new System.Drawing.Size(73, 16);
            this.lblORG.TabIndex = 0;
            this.lblORG.Text = "ORG: 000";
            // 
            // grpButtons
            // 
            this.grpButtons.Controls.Add(this.btnLic);
            this.grpButtons.Controls.Add(this.btnSair);
            this.grpButtons.Controls.Add(this.btnGravar);
            this.grpButtons.Controls.Add(this.btnExcluir);
            this.grpButtons.Controls.Add(this.btnEditar);
            this.grpButtons.Controls.Add(this.btnNovo);
            this.grpButtons.Location = new System.Drawing.Point(331, 3);
            this.grpButtons.Name = "grpButtons";
            this.grpButtons.Size = new System.Drawing.Size(457, 58);
            this.grpButtons.TabIndex = 4;
            this.grpButtons.TabStop = false;
            // 
            // btnLic
            // 
            this.btnLic.Enabled = false;
            this.btnLic.Image = global::MCISYS.Properties.Resources.icons8_licença_24;
            this.btnLic.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnLic.Location = new System.Drawing.Point(187, 9);
            this.btnLic.Name = "btnLic";
            this.btnLic.Size = new System.Drawing.Size(59, 44);
            this.btnLic.TabIndex = 5;
            this.btnLic.Text = "Licença";
            this.btnLic.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnLic.UseVisualStyleBackColor = true;
            this.btnLic.Click += new System.EventHandler(this.btnLic_Click);
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
            // Frm_CriaOrg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(799, 569);
            this.Controls.Add(this.grpButtons);
            this.Controls.Add(this.grb);
            this.Controls.Add(this.StStripDados);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Frm_CriaOrg";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Tag = "CriaOrg";
            this.Text = "Cadastro de Organizações";
            this.groupBox1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tbP_AssociaOrgPap.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DtgPapel)).EndInit();
            this.tPage_AssociaOrgUsu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dGvUser)).EndInit();
            this.StStripDados.ResumeLayout(false);
            this.StStripDados.PerformLayout();
            this.grb.ResumeLayout(false);
            this.grb.PerformLayout();
            this.grpButtons.ResumeLayout(false);
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
        private System.Windows.Forms.GroupBox grpButtons;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnGravar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.TreeView trvOrgs;
        private System.Windows.Forms.DataGridView DtgPapel;
        private System.Windows.Forms.Button btnRetiraAssociacao;
        private System.Windows.Forms.Button btnInclueAssociacao;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_Papel;
        private System.Windows.Forms.DataGridViewTextBoxColumn DS_PAPEL;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_USU_INCL;
        private System.Windows.Forms.DataGridViewTextBoxColumn DT_INCLUSAO;
        private System.Windows.Forms.Button btnREtiraAssociaOrgUsu;
        private System.Windows.Forms.Button btnAssociaUsu;
        private System.Windows.Forms.DataGridView dGvUser;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_USU;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_USU_INCL_PAP;
        private System.Windows.Forms.DataGridViewTextBoxColumn DT_INCLUSAO_PAP;
        private System.Windows.Forms.Label lblORG;
        private System.Windows.Forms.TextBox txBNmOrg;
        private System.Windows.Forms.Label lbl_DisplayOrg;
        private System.Windows.Forms.Label lbl_NmOrgResumido;
        private System.Windows.Forms.TextBox txb_OrgResumido;
        private System.Windows.Forms.Label lbl_OrgMae;
        private System.Windows.Forms.ComboBox cbx_OrgMae;
        private System.Windows.Forms.Label lbl_TpOrg;
        private System.Windows.Forms.ComboBox cbx_TpOrg;
        private System.Windows.Forms.Button btnLic;
        private System.Windows.Forms.Label lbLic;
    }
}