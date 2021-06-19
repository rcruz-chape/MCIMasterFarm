
namespace MCISYS.Negocio.Telas
{
    partial class Frm_CriaUsu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_CriaUsu));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
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
            this.btnCriar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnNovo = new System.Windows.Forms.Button();
            this.grpUsers = new System.Windows.Forms.GroupBox();
            this.dtvUsers = new System.Windows.Forms.DataGridView();
            this.ID_USER = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NM_USUARIO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tBAssociados = new System.Windows.Forms.TabControl();
            this.tbP_AssociaOrgUsu = new System.Windows.Forms.TabPage();
            this.btnRetiraAssociacao = new System.Windows.Forms.Button();
            this.btnInclueAssociacao = new System.Windows.Forms.Button();
            this.DtvOrgUsu = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NM_ORG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID_USU_INCL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DT_INCLUSAO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tPage_AssociaPapUsu = new System.Windows.Forms.TabPage();
            this.btnREtiraAssociaOrgUsu = new System.Windows.Forms.Button();
            this.btnAssociaUsu = new System.Windows.Forms.Button();
            this.dtvUserPapel = new System.Windows.Forms.DataGridView();
            this.ID_PAPEL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NM_PAPEL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID_USU_INCL_PAP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DT_INCLUSAO_PAP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StStripDados.SuspendLayout();
            this.grpButtons.SuspendLayout();
            this.grpUsers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtvUsers)).BeginInit();
            this.tBAssociados.SuspendLayout();
            this.tbP_AssociaOrgUsu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DtvOrgUsu)).BeginInit();
            this.tPage_AssociaPapUsu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtvUserPapel)).BeginInit();
            this.SuspendLayout();
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
            this.StStripDados.Size = new System.Drawing.Size(800, 24);
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
            this.grpButtons.Controls.Add(this.btnGravar);
            this.grpButtons.Controls.Add(this.btnDesativar);
            this.grpButtons.Controls.Add(this.btnSair);
            this.grpButtons.Controls.Add(this.btnAtivar);
            this.grpButtons.Controls.Add(this.btnCriar);
            this.grpButtons.Controls.Add(this.btnEditar);
            this.grpButtons.Controls.Add(this.btnNovo);
            this.grpButtons.Location = new System.Drawing.Point(379, 0);
            this.grpButtons.Name = "grpButtons";
            this.grpButtons.Size = new System.Drawing.Size(417, 58);
            this.grpButtons.TabIndex = 9;
            this.grpButtons.TabStop = false;
            // 
            // btnGravar
            // 
            this.btnGravar.Enabled = false;
            this.btnGravar.Image = ((System.Drawing.Image)(resources.GetObject("btnGravar.Image")));
            this.btnGravar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnGravar.Location = new System.Drawing.Point(253, 9);
            this.btnGravar.Name = "btnGravar";
            this.btnGravar.Size = new System.Drawing.Size(48, 44);
            this.btnGravar.TabIndex = 6;
            this.btnGravar.Text = "Gravar";
            this.btnGravar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnGravar.UseVisualStyleBackColor = true;
            // 
            // btnDesativar
            // 
            this.btnDesativar.Enabled = false;
            this.btnDesativar.Image = global::MCISYS.Properties.Resources.icons8_remover_usuário_masculino_24;
            this.btnDesativar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnDesativar.Location = new System.Drawing.Point(192, 9);
            this.btnDesativar.Name = "btnDesativar";
            this.btnDesativar.Size = new System.Drawing.Size(61, 44);
            this.btnDesativar.TabIndex = 5;
            this.btnDesativar.Text = "Desativar";
            this.btnDesativar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnDesativar.UseVisualStyleBackColor = true;
            // 
            // btnSair
            // 
            this.btnSair.Image = ((System.Drawing.Image)(resources.GetObject("btnSair.Image")));
            this.btnSair.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSair.Location = new System.Drawing.Point(361, 10);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(48, 44);
            this.btnSair.TabIndex = 4;
            this.btnSair.Text = "Sair";
            this.btnSair.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSair.UseVisualStyleBackColor = true;
            // 
            // btnAtivar
            // 
            this.btnAtivar.Enabled = false;
            this.btnAtivar.Image = global::MCISYS.Properties.Resources.icons8_interface_de_usuário_natural_2_24;
            this.btnAtivar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnAtivar.Location = new System.Drawing.Point(143, 9);
            this.btnAtivar.Name = "btnAtivar";
            this.btnAtivar.Size = new System.Drawing.Size(48, 44);
            this.btnAtivar.TabIndex = 3;
            this.btnAtivar.Text = "Ativar";
            this.btnAtivar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAtivar.UseVisualStyleBackColor = true;
            // 
            // btnCriar
            // 
            this.btnCriar.Enabled = false;
            this.btnCriar.Image = global::MCISYS.Properties.Resources.icons8_adicionar_usuário_masculino_24;
            this.btnCriar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCriar.Location = new System.Drawing.Point(95, 9);
            this.btnCriar.Name = "btnCriar";
            this.btnCriar.Size = new System.Drawing.Size(48, 44);
            this.btnCriar.TabIndex = 2;
            this.btnCriar.Text = "Criar";
            this.btnCriar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCriar.UseVisualStyleBackColor = true;
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
            // 
            // grpUsers
            // 
            this.grpUsers.Controls.Add(this.dtvUsers);
            this.grpUsers.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpUsers.Location = new System.Drawing.Point(3, 0);
            this.grpUsers.Name = "grpUsers";
            this.grpUsers.Size = new System.Drawing.Size(370, 267);
            this.grpUsers.TabIndex = 10;
            this.grpUsers.TabStop = false;
            this.grpUsers.Text = "Papeis";
            // 
            // dtvUsers
            // 
            this.dtvUsers.AllowUserToAddRows = false;
            this.dtvUsers.AllowUserToDeleteRows = false;
            this.dtvUsers.AllowUserToOrderColumns = true;
            this.dtvUsers.CausesValidation = false;
            this.dtvUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtvUsers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID_USER,
            this.NM_USUARIO});
            this.dtvUsers.Location = new System.Drawing.Point(7, 20);
            this.dtvUsers.MultiSelect = false;
            this.dtvUsers.Name = "dtvUsers";
            this.dtvUsers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtvUsers.Size = new System.Drawing.Size(357, 241);
            this.dtvUsers.TabIndex = 0;
            // 
            // ID_USER
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.ID_USER.DefaultCellStyle = dataGridViewCellStyle1;
            this.ID_USER.HeaderText = "Usuário";
            this.ID_USER.Name = "ID_USER";
            // 
            // NM_USUARIO
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.NM_USUARIO.DefaultCellStyle = dataGridViewCellStyle2;
            this.NM_USUARIO.HeaderText = "Nome do Usuário";
            this.NM_USUARIO.Name = "NM_USUARIO";
            this.NM_USUARIO.Width = 200;
            // 
            // tBAssociados
            // 
            this.tBAssociados.Controls.Add(this.tbP_AssociaOrgUsu);
            this.tBAssociados.Controls.Add(this.tPage_AssociaPapUsu);
            this.tBAssociados.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBAssociados.Location = new System.Drawing.Point(4, 272);
            this.tBAssociados.Name = "tBAssociados";
            this.tBAssociados.SelectedIndex = 0;
            this.tBAssociados.Size = new System.Drawing.Size(792, 266);
            this.tBAssociados.TabIndex = 11;
            // 
            // tbP_AssociaOrgUsu
            // 
            this.tbP_AssociaOrgUsu.Controls.Add(this.btnRetiraAssociacao);
            this.tbP_AssociaOrgUsu.Controls.Add(this.btnInclueAssociacao);
            this.tbP_AssociaOrgUsu.Controls.Add(this.DtvOrgUsu);
            this.tbP_AssociaOrgUsu.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbP_AssociaOrgUsu.Location = new System.Drawing.Point(4, 22);
            this.tbP_AssociaOrgUsu.Name = "tbP_AssociaOrgUsu";
            this.tbP_AssociaOrgUsu.Padding = new System.Windows.Forms.Padding(3);
            this.tbP_AssociaOrgUsu.Size = new System.Drawing.Size(784, 240);
            this.tbP_AssociaOrgUsu.TabIndex = 0;
            this.tbP_AssociaOrgUsu.Tag = "AssociaOrgUsu";
            this.tbP_AssociaOrgUsu.Text = "Orgs Associados";
            this.tbP_AssociaOrgUsu.UseVisualStyleBackColor = true;
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
            // 
            // DtvOrgUsu
            // 
            this.DtvOrgUsu.AllowUserToAddRows = false;
            this.DtvOrgUsu.AllowUserToDeleteRows = false;
            this.DtvOrgUsu.AllowUserToResizeColumns = false;
            this.DtvOrgUsu.AllowUserToResizeRows = false;
            this.DtvOrgUsu.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DtvOrgUsu.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.DtvOrgUsu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DtvOrgUsu.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.NM_ORG,
            this.ID_USU_INCL,
            this.DT_INCLUSAO});
            this.DtvOrgUsu.Location = new System.Drawing.Point(3, 3);
            this.DtvOrgUsu.Name = "DtvOrgUsu";
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.Padding = new System.Windows.Forms.Padding(1);
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.Window;
            this.DtvOrgUsu.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.DtvOrgUsu.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DtvOrgUsu.Size = new System.Drawing.Size(743, 234);
            this.DtvOrgUsu.TabIndex = 0;
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
            this.tPage_AssociaPapUsu.Controls.Add(this.dtvUserPapel);
            this.tPage_AssociaPapUsu.Location = new System.Drawing.Point(4, 22);
            this.tPage_AssociaPapUsu.Name = "tPage_AssociaPapUsu";
            this.tPage_AssociaPapUsu.Padding = new System.Windows.Forms.Padding(3);
            this.tPage_AssociaPapUsu.Size = new System.Drawing.Size(784, 240);
            this.tPage_AssociaPapUsu.TabIndex = 1;
            this.tPage_AssociaPapUsu.Tag = "AssociaPapUsu";
            this.tPage_AssociaPapUsu.Text = "Papeis Associados";
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
            // 
            // dtvUserPapel
            // 
            this.dtvUserPapel.AllowUserToAddRows = false;
            this.dtvUserPapel.AllowUserToDeleteRows = false;
            this.dtvUserPapel.AllowUserToResizeColumns = false;
            this.dtvUserPapel.AllowUserToResizeRows = false;
            this.dtvUserPapel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtvUserPapel.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID_PAPEL,
            this.NM_PAPEL,
            this.ID_USU_INCL_PAP,
            this.DT_INCLUSAO_PAP});
            this.dtvUserPapel.Location = new System.Drawing.Point(3, 6);
            this.dtvUserPapel.Name = "dtvUserPapel";
            this.dtvUserPapel.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtvUserPapel.Size = new System.Drawing.Size(739, 228);
            this.dtvUserPapel.TabIndex = 0;
            // 
            // ID_PAPEL
            // 
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.ID_PAPEL.DefaultCellStyle = dataGridViewCellStyle9;
            this.ID_PAPEL.HeaderText = "Papel Associado";
            this.ID_PAPEL.Name = "ID_PAPEL";
            this.ID_PAPEL.ReadOnly = true;
            // 
            // NM_PAPEL
            // 
            this.NM_PAPEL.HeaderText = "Nome do Papel";
            this.NM_PAPEL.Name = "NM_PAPEL";
            this.NM_PAPEL.Width = 300;
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
            // Frm_CriaUsu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 569);
            this.Controls.Add(this.tBAssociados);
            this.Controls.Add(this.grpUsers);
            this.Controls.Add(this.grpButtons);
            this.Controls.Add(this.StStripDados);
            this.Name = "Frm_CriaUsu";
            this.Text = "Cadastro de Usuários";
            this.StStripDados.ResumeLayout(false);
            this.StStripDados.PerformLayout();
            this.grpButtons.ResumeLayout(false);
            this.grpUsers.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtvUsers)).EndInit();
            this.tBAssociados.ResumeLayout(false);
            this.tbP_AssociaOrgUsu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DtvOrgUsu)).EndInit();
            this.tPage_AssociaPapUsu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtvUserPapel)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip StStripDados;
        private System.Windows.Forms.ToolStripStatusLabel tstlUsuario;
        private System.Windows.Forms.ToolStripStatusLabel tstlOrgSelecionadaNumero;
        private System.Windows.Forms.ToolStripStatusLabel tstl_OrgDEscricao;
        private System.Windows.Forms.ToolStripStatusLabel TstlPapel;
        private System.Windows.Forms.GroupBox grpButtons;
        private System.Windows.Forms.Button btnDesativar;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnAtivar;
        private System.Windows.Forms.Button btnCriar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.GroupBox grpUsers;
        private System.Windows.Forms.DataGridView dtvUsers;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_USER;
        private System.Windows.Forms.DataGridViewTextBoxColumn NM_USUARIO;
        private System.Windows.Forms.Button btnGravar;
        private System.Windows.Forms.TabControl tBAssociados;
        private System.Windows.Forms.TabPage tbP_AssociaOrgUsu;
        private System.Windows.Forms.Button btnRetiraAssociacao;
        private System.Windows.Forms.Button btnInclueAssociacao;
        private System.Windows.Forms.DataGridView DtvOrgUsu;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn NM_ORG;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_USU_INCL;
        private System.Windows.Forms.DataGridViewTextBoxColumn DT_INCLUSAO;
        private System.Windows.Forms.TabPage tPage_AssociaPapUsu;
        private System.Windows.Forms.Button btnREtiraAssociaOrgUsu;
        private System.Windows.Forms.Button btnAssociaUsu;
        private System.Windows.Forms.DataGridView dtvUserPapel;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_PAPEL;
        private System.Windows.Forms.DataGridViewTextBoxColumn NM_PAPEL;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_USU_INCL_PAP;
        private System.Windows.Forms.DataGridViewTextBoxColumn DT_INCLUSAO_PAP;
    }
}