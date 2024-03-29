﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MCIMasterFarm.Negocio.Global;
using MCIMasterFarm.Negocio.BackOffice.Negocio;
using MCIMasterFarm.Negocio.BackOffice.Model;
using MCIMasterFarm.Negocio.BackOffice.DadosAcesso;
using MCIMasterFarm.Negocio.BackOffice.DAL;
using MCISYS.Negocio.BackOffice.Model;
using MCISYS.Negocio.BackOffice.DAL;
using MCISYS.Negocio.BackOffice.Negocio;
using MCISYS.Negocio.BackOffice;
using MCIMasterFarm.Negocio.BackOffice;

namespace MCISYS.Negocio.Telas
{
    public partial class Frm_CriaPap : Form
    {
        private Banco vBanco = new Banco();

        private int vIdOrg;

        private string vIdPapel;
        private string vIdUsu;
        private string vNmOrg;
        private string vDsPapel;

        private Boolean bExecuta;
        private int Comando;
        private string vIdPapelSelecionada;

        private ConfiguraControleNEG vControleNEG = new ConfiguraControleNEG();
        private List<VwOrgPapel> ListPapel = new List<VwOrgPapel>();
        private List<VwPUsu> ListPapelUsu = new List<VwPUsu>();
        private List<SisOrganizacaoPapel> ListOrgPapel = new List<SisOrganizacaoPapel>();
        private List<SisPapelUsuario> ListPapUsu = new List<SisPapelUsuario>();
        private VwOrgPapelNEG vOrgPapelNEG = new VwOrgPapelNEG();
        private VwPUsuNEG vwPUsuNEG = new VwPUsuNEG();
        private SisOrganizacaoPapelNEG vSisOrganizacaoPapelNEG = new SisOrganizacaoPapelNEG();
        private SisPapelUsuarioNEG vSisPapelUsuarioNEG = new SisPapelUsuarioNEG();
        private List<CorOrganizacao> ListOrg = new List<CorOrganizacao>();
        private List<SisUsuario> ListUsu = new List<SisUsuario>();
        private SisPapel vSisPapel = new SisPapel();
        private SisPapelNEG vPapNeg = new SisPapelNEG();

        public Boolean bModoPreGravacao;

        private Dictionary<int, string> DicTpPapel = new Dictionary<int, string>
        {
            {0,"Administrativo" },
            {1,"Operacional" }
        };

        private MessageBoxIcon Alert = MessageBoxIcon.Question;

        public const string PAPADM = "1";
        public const int iInsert = 1;
        public const int iUpdate = 2;
        public const int iRegNovo = 1;
        public const int iRegAlterar = 2;
        public const int iRegExcluir = 3;
        public const int iRegPesquisar = 4;
        public const int iRegGravar = 5;
        public const string FormatOrg = "000";

        public Frm_CriaPap(ref Banco pBanco, int pIdOrg, string pIdPapel,
                            string pIdUSU, string pNmOrg, string psDSPapel)
        {
            InitializeComponent();
            vBanco = pBanco;
            vIdOrg = pIdOrg;
            vIdPapel = pIdPapel;
            vIdUsu = pIdUSU;
            vNmOrg = pNmOrg;
            vDsPapel = psDSPapel;
            bExecuta = CarregaBarraStatus();
            bExecuta = bConfiguraTituloDbGrid();
            bExecuta = CarregaCBxTpOrg();
            bExecuta = CarregaPapeis();
            bExecuta = LimpaTela();
            bExecuta = LoadReg();

        }
        private Boolean CarregaBarraStatus()
        {
            this.tstlUsuario.Text = "Usuário:  " + vIdUsu;
            this.tstlOrgSelecionadaNumero.Text = "Org:   " + vIdOrg.ToString(FormatOrg);
            this.tstl_OrgDEscricao.Text = " - " + vNmOrg;
            this.TstlPapel.Text = "Papel:  " + vDsPapel;
            return true;
        }

        public Boolean bConfiguraTituloDbGrid()
        {
            this.DtgOrg.Columns[0].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            this.DtgOrg.Columns[1].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleLeft;
            this.DtgOrg.Columns[2].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.DtgOrg.Columns[3].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            this.dGvUser.Columns[0].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.dGvUser.Columns[1].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.dGvUser.Columns[2].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;

            return true;
        }
        private Boolean CarregaUsuAssociados(string pIdPapel = "")
        {
            string vsIdPapel = pIdPapel;
            if (pIdPapel == "")
            {
                if (this.dgvPapel.CurrentRow == null)
                {
                    this.dgvPapel.CurrentCell = this.dgvPapel[0, 0];
                }

                vsIdPapel = this.dgvPapel.CurrentRow.Cells[0].Value.ToString();

            }
            this.dGvUser.Rows.Clear();
            ListPapelUsu = vwPUsuNEG.ObtemUsuariosAssociados(ref vBanco, vsIdPapel);
            if (ListPapelUsu.Count > 0)
            {
                foreach (var PapelUsu in ListPapelUsu)
                {
                    var RegSisPapelUsuario = new SisPapelUsuario();
                    RegSisPapelUsuario.ID_PAPEL = PapelUsu.ID_PAPEL;
                    RegSisPapelUsuario.ID_USU = PapelUsu.ID_USU;
                    ListPapUsu.Add(RegSisPapelUsuario);
                    this.dGvUser.Rows.Add(PapelUsu.ID_USU, PapelUsu.ID_USU_INCL, PapelUsu.DT_INCLUSAO);
                }
            }
            return true;
        }
        private Boolean CarregaOrgsAssociados(string pIdPapel = "")
        {
            string vsIdPapel = pIdPapel;
            if (pIdPapel == "")
            {
                if (this.dgvPapel.CurrentRow == null)
                {
                    this.dgvPapel.CurrentCell = this.dgvPapel[0, 0];
                }

                vsIdPapel = this.dgvPapel.CurrentRow.Cells[0].Value.ToString();
            }
            this.DtgOrg.Rows.Clear();
            ListOrgPapel = vSisOrganizacaoPapelNEG.ObtemListaOrgsAssociadosPapeis(ref vBanco, vsIdPapel, vIdUsu);
            if (ListOrgPapel.Count() > 0)
            {
                foreach (var OrgAssociadaPapel in ListOrgPapel)
                {
                    DtgOrg.Rows.Add(OrgAssociadaPapel.ID_ORG, OrgAssociadaPapel.NM_ORG, OrgAssociadaPapel.ID_USU_INCL, OrgAssociadaPapel.DT_INCLUSAO);
                }
            }
            return true;

        }
        private Boolean CarregaPapeis()
        {
            ListPapel = vOrgPapelNEG.ObtemListaPapeis(ref vBanco, vIdUsu, vIdOrg);
            return bAlimentaDbPapeis();
        }
        private Boolean bAlimentaDbPapeis()
        {
            this.dgvPapel.Rows.Clear();
            foreach (var vwPapel in ListPapel)
            {
                this.dgvPapel.Rows.Add(vwPapel.ID_PAPEL, vwPapel.DS_PAPEL);
            }
            return true;
        }



        private void btnNovo_Click(object sender, EventArgs e)
        {
            if (bModoPreGravacao)
            {
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result = MessageBox.Show("Deseja Salvar?", "Sem Salvar", buttons, Alert);
                if (result == DialogResult.Yes)
                {
                    var bSalvar = RegSalvar();
                }
            }
            Comando = iRegNovo;
            Boolean bNovo = RegNovo();
            bModoPreGravacao = true;
            bNovo = HabilitaBotoes(iRegNovo);
        }

        private void btnRetiraAssociacao_Click(object sender, EventArgs e)
        {
            if (this.DtgOrg.CurrentRow != null)
            {
                this.DtgOrg.Rows.RemoveAt(this.DtgOrg.CurrentRow.Index);
            }
        }

        private void btnREtiraAssociaOrgUsu_Click(object sender, EventArgs e)
        {
            if (this.dGvUser.CurrentCell != null)
            {
                this.dGvUser.Rows.RemoveAt(this.dGvUser.CurrentRow.Index);
            }
        }

        private void btnInclueAssociacao_Click(object sender, EventArgs e)
        {   
            Frm_Associa FrmAssocia = new Frm_Associa(ref vBanco, Frm_Associa.AssociaPapelOrg, 0, vIdUsu, this.txt_IDPAPEL.Text,"",Convert.ToInt32(this.cbxTpOrg.SelectedValue),"");
            if (FrmAssocia.ShowDialog() == DialogResult.OK)
            {
                int vIndex = this.DtgOrg.RowCount + 1;
                this.DtgOrg.Rows.Add(FrmAssocia.vSysOrg.ID_ORG, FrmAssocia.vSysOrg.NM_ORG, FrmAssocia.vSysOrg.ID_USU_INCL, FrmAssocia.vSysOrg.DT_INCLUSAO);
            }
            FrmAssocia = null;
        }

        private void btnAssociaUsu_Click(object sender, EventArgs e)
        {

            Frm_Associa FrmAssocia = new Frm_Associa(ref vBanco, Frm_Associa.AssociaPapelUsuario, 0, vIdUsu, this.txt_IDPAPEL.Text);
            if (FrmAssocia.ShowDialog() == DialogResult.OK)
            {
                int vIndex = this.dGvUser.RowCount + 1;
                this.dGvUser.Rows.Add(FrmAssocia.vPUsu.ID_USU, FrmAssocia.vPUsu.ID_USU_INCL, FrmAssocia.vPUsu.DT_INCLUSAO);
            }
            FrmAssocia = null;
        }



        private void dgvPapel_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Boolean vbLoad;
            vbLoad = LoadReg(this.dgvPapel.CurrentRow.Cells[0].Value.ToString());
        }
        public Boolean LoadReg(string psIdPapel = null)
        {
            Boolean vbLoad;
            string vidPapel = psIdPapel;
            if (psIdPapel == null)
            {
                if (this.dgvPapel.CurrentRow == null)
                {
                    this.dgvPapel.CurrentCell = this.dgvPapel.Rows[0].Cells[0];
                    //this.dgvPapel.Rows.GetLastRow(DataGridViewElementStates.None);
                }

                vidPapel = this.dgvPapel.CurrentRow.Cells[0].Value.ToString();
            }
            vSisPapel = vPapNeg.ObtemPapelSelecionado(ref vBanco, vidPapel);
            this.txt_IDPAPEL.Text = vSisPapel.ID_PAPEL;
            this.txt_NmPapel.Text = vSisPapel.DS_PAPEL;
            this.lbl_ID_Usu_Incl.Text = vSisPapel.ID_USU_INCL;
            this.lbl_Dt_Inclusao.Text = vSisPapel.DT_INCLUSAO.ToString("dd/MM/yyyy");
            this.lbl_Id_Usu_Alterado.Text = vSisPapel.ID_USU_ALT;
            this.cbxTpOrg.SelectedItem = vSisPapel.TP_PAPEL;
            this.cbxTpOrg.Text = DicTpPapel[vSisPapel.TP_PAPEL];
            //this.cbx_TpOrg.SelectedItem = CorOrg.TP_ORG;
            //this.cbx_TpOrg.Text = TraduzTpOrg(CorOrg.TP_ORG);
            if (vSisPapel.DT_ALTERACAO.HasValue)
            {
                this.lbl_Dt_Alteracao.Text = vSisPapel.DT_ALTERACAO.Value.ToString("dd/MM/yyyy");
            }
            else
            {
                this.lbl_Dt_Alteracao.Text = "";
            }

            vbLoad = CarregaOrgsAssociados(vidPapel);
            vbLoad = CarregaUsuAssociados(vidPapel);
            vbLoad = DesabilitaCamposTela();
            return vbLoad;
        }
        public Boolean LimpaTela()
        {
            this.txt_IDPAPEL.Text = "";
            this.txt_NmPapel.Text = "";
            this.lbl_ID_Usu_Incl.Text = "";
            this.lbl_Dt_Inclusao.Text = "";
            this.lbl_Id_Usu_Alterado.Text = "";
            this.lbl_Dt_Alteracao.Text = "";
            this.dGvUser.Rows.Clear();
            this.DtgOrg.Rows.Clear();
            return true;
        }
        public Boolean HabilitaBotoes(int pCOmando)
        {
            switch (pCOmando)
            {
                case iRegNovo:
                    this.btnNovo.Enabled = false;
                    this.btnEditar.Enabled = false;
                    this.btnExcluir.Enabled = true;
                    this.btnGravar.Enabled = true;
                    this.btnInclueAssociacao.Enabled = true;
                    this.btnRetiraAssociacao.Enabled = true;
                    this.btnAssociaUsu.Enabled = true;
                    this.btnREtiraAssociaOrgUsu.Enabled = true;
                    break;
                case iRegAlterar:
                    this.btnNovo.Enabled = false;
                    this.btnEditar.Enabled = false;
                    this.btnExcluir.Enabled = true;
                    this.btnGravar.Enabled = true;
                    this.btnInclueAssociacao.Enabled = true;
                    this.btnRetiraAssociacao.Enabled = true;
                    this.btnAssociaUsu.Enabled = true;
                    this.btnREtiraAssociaOrgUsu.Enabled = true;
                    break;
                case iRegGravar:
                    this.btnNovo.Enabled = true;
                    this.btnEditar.Enabled = true;
                    this.btnExcluir.Enabled = false;
                    this.btnGravar.Enabled = false;
                    this.btnInclueAssociacao.Enabled = false;
                    this.btnRetiraAssociacao.Enabled = false;
                    this.btnAssociaUsu.Enabled = false;
                    this.btnREtiraAssociaOrgUsu.Enabled = false;
                    break;
                case iRegExcluir:
                    this.btnNovo.Enabled = true;
                    this.btnEditar.Enabled = true;
                    this.btnExcluir.Enabled = false;
                    this.btnGravar.Enabled = false;
                    this.btnInclueAssociacao.Enabled = false;
                    this.btnRetiraAssociacao.Enabled = false;
                    this.btnAssociaUsu.Enabled = false;
                    this.btnREtiraAssociaOrgUsu.Enabled = false;
                    break;


            }
            return true;
        }

        public Boolean RegNovo(Boolean pacao = true)
        {
            Boolean vbNovo;
            Comando = iInsert;
            vbNovo = LimpaTela();
            vbNovo = HabilitaCamposTela();
            return vbNovo;
        }
        public Boolean HabilitaCamposTela()
        {
            this.txt_IDPAPEL.Enabled = true;
            this.txt_NmPapel.Enabled = true;
            this.cbxTpOrg.Enabled = true;
            return true;
        }
        public Boolean DesabilitaCamposTela()
        {
            this.txt_IDPAPEL.Enabled = false;
            this.txt_NmPapel.Enabled = false;
            this.cbxTpOrg.Enabled = false;
            return true;
        }
        public Boolean RegSalvar()
        {
            int vTotLoop = 0;
            var RegPapel = new SisPapel();
            var ListPapelAssociado = new List<SisOrganizacaoPapel>();
            var ListPapelUsuario = new List<SisPapelUsuario>();
            MessageBoxIcon iError = MessageBoxIcon.Error;
            MessageBoxIcon iWarning = MessageBoxIcon.Warning;
            Boolean bAcao;
            if (this.txt_IDPAPEL.Text == "")
            {
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                DialogResult result = MessageBox.Show("Código do Papel Obrigatório.", "Erro de Validação", buttons, iError);
                this.txt_IDPAPEL.Focus();
                return false;
            }
            else
            {
                if (Comando == iRegNovo)
                {
                    bAcao = vPapNeg.ExistePapelInformado(ref vBanco, txt_IDPAPEL.Text);
                    if (bAcao)
                    {
                        MessageBoxButtons buttons = MessageBoxButtons.OK;
                        DialogResult result = MessageBox.Show("Papel Informado já está cadastrado.", "Erro de Validação", buttons, iError);
                        this.txt_IDPAPEL.Focus();
                        return false;
                    }
                }
            }
            if (this.txt_NmPapel.Text == "")
            {
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                DialogResult result = MessageBox.Show("Nome do Papel Obrigatório.", "Erro de Validação", buttons, iError);
                this.txt_NmPapel.Focus();
                return false;
            }
            if (this.DtgOrg.RowCount < 1)
            {
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result = MessageBox.Show("Não Há Orgs Associadas Deseja Continuar?", "Papel Sem Orgs Associadas", buttons, iWarning);
                if (result == DialogResult.No)
                {
                    return false;
                }
            }
            if (this.dGvUser.RowCount < 1)
            {
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result = MessageBox.Show("Não Há Usuários Associados Deseja Continuar?", "Papel Sem Usuários Associados", buttons, iWarning);
                if (result == DialogResult.No)
                {
                    return false;
                }
            }
            switch (Comando)
            {
                case iInsert:
                    RegPapel.ID_PAPEL = this.txt_IDPAPEL.Text;
                    RegPapel.DS_PAPEL = this.txt_NmPapel.Text;
                    RegPapel.ID_USU_INCL = vIdUsu;
                    RegPapel.DT_INCLUSAO = DateTime.Now;
                    RegPapel.TP_PAPEL = Convert.ToInt32(this.cbxTpOrg.SelectedValue);
                    RegPapel.DT_ALTERACAO = null;
                    bAcao = vPapNeg.CriaPapel(ref vBanco, RegPapel);
                    if (this.DtgOrg.RowCount > 0)
                    {
                        vTotLoop = this.DtgOrg.RowCount;
                        for (int linha = 0; linha < vTotLoop; linha++)
                        {
                            var RegPorg = new SisOrganizacaoPapel();
                            RegPorg.ID_PAPEL = this.txt_IDPAPEL.Text;
                            RegPorg.ID_ORG = Convert.ToInt32(DtgOrg.Rows[linha].Cells[0].Value.ToString());
                            RegPorg.ID_USU_INCL = this.DtgOrg.Rows[linha].Cells[2].Value.ToString();
                            RegPorg.DT_INCLUSAO = Convert.ToDateTime(this.DtgOrg.Rows[linha].Cells[3].Value.ToString());
                            ListPapelAssociado.Add(RegPorg);
                        }
                        bAcao = vSisOrganizacaoPapelNEG.AssociaPapelOrg(ref vBanco, new List<SisOrganizacaoPapel>(), ListPapelAssociado);
                    }
                    if (this.dGvUser.RowCount > 0)
                    {
                        vTotLoop = this.dGvUser.RowCount;
                        for (int linha = 0; linha < vTotLoop; linha++)
                        {
                            var RegPusu = new SisPapelUsuario();
                            RegPusu.ID_PAPEL = this.txt_IDPAPEL.Text;
                            RegPusu.ID_USU = this.dGvUser.Rows[linha].Cells[0].Value.ToString();
                            ListPapelUsuario.Add(RegPusu);
                        }
                        bAcao = vSisPapelUsuarioNEG.AssociaPapelUsuario(ref vBanco, new List<SisPapelUsuario>(), ListPapelUsuario);

                    }
                    break;
                case iUpdate:
                    RegPapel.ID_PAPEL = this.txt_IDPAPEL.Text;
                    RegPapel.DS_PAPEL = this.txt_NmPapel.Text;
                    RegPapel.ID_USU_ALT = vIdUsu;
                    RegPapel.TP_PAPEL = Convert.ToInt32(this.cbxTpOrg.SelectedValue);
                    RegPapel.DT_ALTERACAO = DateTime.Now;
                    bAcao = vPapNeg.AlteraPapel(ref vBanco, RegPapel);
                    if (this.DtgOrg.RowCount > 0)
                    {
                        vTotLoop = this.DtgOrg.RowCount;
                        for (int linha = 0; linha < vTotLoop; linha++)
                        {
                            var RegPorg = new SisOrganizacaoPapel();
                            RegPorg.ID_PAPEL = this.txt_IDPAPEL.Text;
                            RegPorg.ID_ORG = Convert.ToInt32(this.DtgOrg.Rows[linha].Cells[0].Value.ToString());
                            RegPorg.ID_USU_INCL = this.DtgOrg.Rows[linha].Cells[2].Value.ToString();
                            RegPorg.DT_INCLUSAO = Convert.ToDateTime(this.DtgOrg.Rows[linha].Cells[3].Value.ToString());
                            ListPapelAssociado.Add(RegPorg);
                        }
                        bAcao = vSisOrganizacaoPapelNEG.AtualizaAssociaPapelOrg(ref vBanco, ListOrgPapel, ListPapelAssociado);
                    }
                    if (this.dGvUser.RowCount > 0)
                    {
                        vTotLoop = this.dGvUser.RowCount;
                        for (int linha = 0; linha < vTotLoop; linha++)
                        {
                            var RegPusu = new SisPapelUsuario();
                            RegPusu.ID_PAPEL = this.txt_IDPAPEL.Text;
                            RegPusu.ID_USU = this.dGvUser.Rows[linha].Cells[0].Value.ToString();
                            ListPapelUsuario.Add(RegPusu);
                        }
                        bAcao = vSisPapelUsuarioNEG.AtualizaPapelUsuario(ref vBanco, ListPapUsu, ListPapelUsuario);

                    }
                    break;
            }
            return CarregaPapeis();
           

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            var bAlterar = RegAlterar();
        }

        public Boolean RegAlterar()
        {
            Comando = iRegAlterar;
            bModoPreGravacao = true;
            var Habilita = HabilitaBotoes(iRegAlterar);
            Habilita = HabilitaCamposTela();
            return true;
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            var bExcluir = RegExcluir();
            bExcluir = HabilitaBotoes(iRegExcluir);
        }
        public Boolean RegExcluir()
        {
            Boolean bExcluir = true;
            switch(Comando)
            {
                case iRegAlterar:
                {
                     MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                     DialogResult result = MessageBox.Show("Deseja Excluir Papel?", "Exclusão", buttons);
                     if (result == DialogResult.Yes)
                     {
                            bExcluir = false;
                            string vMsg;
                            SisPapelUsuario PapUSu = new SisPapelUsuario();
                            PapUSu.ID_PAPEL = this.txt_IDPAPEL.Text;
                            
                            bExcluir = vSisOrganizacaoPapelNEG.ExcluePapeis(ref vBanco, PapUSu.ID_PAPEL);
                            bExcluir = vSisPapelUsuarioNEG.bExcluePapel(ref vBanco, PapUSu.ID_PAPEL);
                            bExcluir = vPapNeg.ExcluiPapel(ref vBanco, PapUSu.ID_PAPEL);

                     }
                     break;
                }
                case iRegNovo:
                {
                    MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                    DialogResult result = MessageBox.Show("Deseja Cancelar a Inclusão de Papel?", "Cancelar", buttons);
                    if (result == DialogResult.Yes)
                    {
                        bModoPreGravacao = false;
                        bExcluir = LimpaTela();
                        bExcluir = DesabilitaCamposTela();
                    }
                    break;
                }
                bExcluir = CarregaPapeis();
            }


            return bExcluir;
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            var Habilita = RegSalvar();
            if (Habilita)
            {
                Habilita = HabilitaBotoes(iRegGravar);
                Habilita = DesabilitaCamposTela();
                bModoPreGravacao = false;
                //Habilita = LimpaTela();
            }
           
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            if (bModoPreGravacao)
            {
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result = MessageBox.Show("Deseja Salvar?", "Sem Salvar", buttons, Alert);
                if (result == DialogResult.Yes)
                {
                    var bSalvar = RegSalvar();
                }

            }
            this.Dispose();

        }

        private void dgvPapel_KeyDown(object sender, KeyEventArgs e)
        {
            Boolean vbLoad;
            var tecla = e.KeyCode;
            int vIndexRow = 0;

            if (tecla == Keys.Up)
            {

                vIndexRow = this.dgvPapel.CurrentRow.Index;
                vIndexRow = this.dgvPapel.Rows.GetPreviousRow(vIndexRow, DataGridViewElementStates.None);
                if (vIndexRow > -1)
                {
                    vbLoad = LoadReg(this.dgvPapel.Rows[vIndexRow].Cells[0].Value.ToString());
                }
     
               
                     //dgvPapel.FirstDisplayedScrollingRowIndex.Equals = vIndexRow;

            }
            else if (tecla == Keys.Down)
            {
                vIndexRow = this.dgvPapel.CurrentRow.Index;
                vIndexRow = this.dgvPapel.Rows.GetNextRow(vIndexRow, DataGridViewElementStates.None);


                //dgvPapel.FirstDisplayedScrollingRowIndex = vIndexRow;
                if (vIndexRow > -1)
                {
                    vbLoad = LoadReg(this.dgvPapel.Rows[vIndexRow].Cells[0].Value.ToString());
                }



            }
            else if (tecla == Keys.Enter)
            {
                if (this.dgvPapel.CurrentRow == null)
                {
                    this.dgvPapel.CurrentCell = this.dgvPapel[0, 0];
                }
                vbLoad = LoadReg(this.dgvPapel.CurrentRow.Cells[0].Value.ToString());
            }
        }
        private Boolean CarregaCBxTpOrg()
        {
            var List = DicTpPapel.ToList();
            this.cbxTpOrg.DataSource = List;
            var vControle = vControleNEG.SetComboBox(cbxTpOrg,"Value","Key");
            return true;
        }
    }
}
