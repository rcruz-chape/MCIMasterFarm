using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
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
    public partial class Frm_ParCadGrupo : Form
    {

        private Banco vBanco = new Banco();

        private int vIdOrg;
        private int vIdGrp_Merc;

        private string vIdPapel;
        private string vIdUsu;
        private string vNmOrg;
        private string vDsPapel;

        private Boolean bExecuta;
        private int Comando;
        private string vIdPapelSelecionada;

        public const int iInsert = 1;
        public const int iUpdate = 2;
        public const int iRegNovo = 1;
        public const int iRegAlterar = 2;
        public const int iRegExcluir = 3;
        public const int iRegAtivar = 4;
        public const int iRegDesativar = 5;
        public const int iRegGravar = 6;
        public const string FormatOrg = "000";
        public const string FormatGrp = "0000";
        public Boolean bModoPreGravacao = false;

        private MessageBoxIcon iError = MessageBoxIcon.Error;
        private MessageBoxIcon iWarning = MessageBoxIcon.Warning;

        public CorGrupoMercadoriaNEG vCorGrupoMercadoriaNEG = new CorGrupoMercadoriaNEG();
        public List<CorGrupoMercadoria> vListCorGrupoMercadoria = new List<CorGrupoMercadoria>();
        public CorGrupoMercadoria vCorGrupoMercadoria = new CorGrupoMercadoria();

        private MessageBoxIcon Alert = MessageBoxIcon.Question;

        public Frm_ParCadGrupo(ref Banco pBanco, int pIdOrg, string pIdPapel,
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
            bExecuta = LimpaTela();
            bExecuta = PesquisaReg(true);
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
            this.dgvGrpMerc.Columns[0].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            this.dgvGrpMerc.Columns[1].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleLeft;

            return true;
        }
        public Boolean LimpaTela(Boolean pLimpaLista = false)
        {
            this.txt_NmgrpMerc.Text = "";
            this.lbl_ID_GrpMerc.Text = "Grupo: ---- ";
            this.lbl_Situacao.Text = "";
            this.lbl_ID_Usu_Incl.Text = "";
            this.lbl_Id_Usu_Alterado.Text = "";
            this.lbl_Dt_Inclusao.Text = "";
            this.lbl_Dt_Alteracao.Text = "";
            if (pLimpaLista)
            {
                this.dgvGrpMerc.Rows.Clear();
            }

            return true;
        }
        private Boolean PesquisaReg(Boolean pPesquisaLista = false, int pIdGrpMerc = 0)
        {
            Boolean vbReg = true;
            if (pPesquisaLista)
            {
                vbReg = ListaCorGrupoMercadoria();
            }
            if (vbReg)
            {

                if (pIdGrpMerc == 0)
                {
                    if (this.dgvGrpMerc.CurrentRow == null)
                    {
                        this.dgvGrpMerc.CurrentCell = this.dgvGrpMerc[0, 0];
                    }
                    var vsIDGrp_Merc = this.dgvGrpMerc.CurrentRow.Cells[0].Value.ToString();
                    vIdGrp_Merc = Convert.ToInt16(vsIDGrp_Merc);
                }
                else
                {
                    vIdGrp_Merc = pIdGrpMerc;
                }
                vCorGrupoMercadoria = vCorGrupoMercadoriaNEG.ObtemRegistroGrupoMercadoria(ref vBanco, vIdOrg, vIdGrp_Merc);
                vbReg = LoadReg(vCorGrupoMercadoria);
            }
            return vbReg;
        }
        private Boolean LoadReg(CorGrupoMercadoria pCorGRupoMercadoria)
        {
            this.lbl_ID_GrpMerc.Text = "Grupo: " + pCorGRupoMercadoria.ID_GRP_MERC.ToString(FormatGrp);
            this.lbl_Situacao.Text = vCorGrupoMercadoriaNEG.vIndAtivoGrupoMercadoria[pCorGRupoMercadoria.IND_GRUPO_ATIVO];
            this.lbl_ID_Usu_Incl.Text = pCorGRupoMercadoria.ID_USU_INCL;
            this.lbl_Id_Usu_Alterado.Text = pCorGRupoMercadoria.ID_USU_ALT;
            this.lbl_Dt_Inclusao.Text = pCorGRupoMercadoria.DT_INCLUSAO.ToString("dd/MM/yyyy");
            if (pCorGRupoMercadoria.DT_ALTERACAO.HasValue)
            {
                this.lbl_Dt_Alteracao.Text = pCorGRupoMercadoria.DT_ALTERACAO.Value.ToString("dd/MM/yyyy");
            }
            this.txt_NmgrpMerc.Text = pCorGRupoMercadoria.NM_GRP_MERC;
            return true;
        }
        private Boolean ListaCorGrupoMercadoria()
        {
            Boolean vbReturn;
            vListCorGrupoMercadoria = vCorGrupoMercadoriaNEG.ObtemListaGrupoMercadoria(ref vBanco, vIdOrg);
            vbReturn = vListCorGrupoMercadoria.Count > 0;
            if (vbReturn)
            {
                foreach (var Registro in vListCorGrupoMercadoria)
                {
                    this.dgvGrpMerc.Rows.Add(Registro.ID_GRP_MERC, Registro.NM_GRP_MERC);
                }
            }
            return vbReturn;
        }

        private void btnAtivar_Click(object sender, EventArgs e)
        {
            var Habilita = RegAtivar();
            if (Habilita)
            {
                Habilita = HabilitaBotoes(iRegAtivar);
                Habilita = DesabilitaCamposTela();
                Habilita = LimpaTela(false);
                Habilita = PesquisaReg(false, vIdGrp_Merc);
                bModoPreGravacao = false;
                //Habilita = LimpaTela();
            }
        }
        public Boolean RegDesativar()
        {
            
            MessageBoxButtons buttons1 = MessageBoxButtons.YesNo;
            string vsSMsg = "Deseja Desativar o Grupo de Mercadoria?";
            vsSMsg += Environment.NewLine;
            vsSMsg += "Essa ação deixará desativado todos os subgrupos e todas as mercadorias relacionadas ao Grupo";
            DialogResult result1 = MessageBox.Show(vsSMsg, "Confirmação", buttons1, MessageBoxIcon.Information);
            if (result1 == DialogResult.No)
            {
                return false;
            }
            else
            {
                return vCorGrupoMercadoriaNEG.DesAtivaGrupoMercadoria(ref vBanco, vIdOrg, vIdGrp_Merc);
            }
        }
        public Boolean RegAtivar()
        {
            return vCorGrupoMercadoriaNEG.AtivaGrupoMercadoria(ref vBanco, vIdOrg, vIdGrp_Merc);
        }

        private void btnDesativar_Click(object sender, EventArgs e)
        {
            var Habilita = RegDesativar();
            if (Habilita)
            {
                Habilita = HabilitaBotoes(iRegDesativar);
                Habilita = DesabilitaCamposTela();
                Habilita = LimpaTela(false);
                Habilita = PesquisaReg(false, vIdGrp_Merc);
                bModoPreGravacao = false;
                //Habilita = LimpaTela();
            }
        }
        public Boolean HabilitaBotoes(int pCOmando)
        {
            switch (pCOmando)
            {
                case iRegNovo:
                    this.btnNovo.Enabled = false;
                    this.btnEditar.Enabled = false;
                    this.btnAtivar.Enabled = false;
                    this.btnDesativar.Enabled = false;
                    this.btnGravar.Enabled = true;
                    this.btnExcluir.Enabled = true;
                    break;
                case iRegAlterar:
                    this.btnNovo.Enabled = false;
                    this.btnEditar.Enabled = false;
                    this.btnAtivar.Enabled = vCorGrupoMercadoria.IND_GRUPO_ATIVO == "N";
                    this.btnDesativar.Enabled = vCorGrupoMercadoria.IND_GRUPO_ATIVO == "S";
                    this.btnGravar.Enabled = true;
                    this.btnExcluir.Enabled = true;
                    break;
                case iRegAtivar:
                    this.btnNovo.Enabled = true;
                    this.btnEditar.Enabled = true;
                    this.btnAtivar.Enabled = false;
                    this.btnDesativar.Enabled = false;
                    this.btnGravar.Enabled = false;
                    this.btnExcluir.Enabled = false;
                    break;
                case iRegDesativar:
                    this.btnNovo.Enabled = true;
                    this.btnEditar.Enabled = true;
                    this.btnAtivar.Enabled = false;
                    this.btnDesativar.Enabled = false;
                    this.btnGravar.Enabled = false;
                    this.btnExcluir.Enabled = false;
                    break;

                case iRegGravar:

                    this.btnNovo.Enabled = true;
                    this.btnEditar.Enabled = true;
                    this.btnAtivar.Enabled = false;
                    this.btnDesativar.Enabled = false;
                    this.btnGravar.Enabled = false;
                    this.btnExcluir.Enabled = false;
                    break;

                case iRegExcluir:

                    this.btnNovo.Enabled = true;
                    this.btnEditar.Enabled = true;
                    this.btnAtivar.Enabled = false;
                    this.btnDesativar.Enabled = false;
                    this.btnGravar.Enabled = false;
                    this.btnExcluir.Enabled = false;
                    break;

            }
            return true;
        }
        public Boolean DesabilitaCamposTela()
        {
            this.txt_NmgrpMerc.Enabled = false;
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
            Boolean bNovo = RegNovo();
            bModoPreGravacao = true;
            bNovo = HabilitaBotoes(iRegNovo);
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
            this.txt_NmgrpMerc.Enabled = true;
            return true;
        }
        public Boolean RegSalvar()
        {
            CorGrupoMercadoria RegCorGrupoMercadoria = new CorGrupoMercadoria();
            
            Boolean bAcao;
            if (this.txt_NmgrpMerc.Text == "")
            {
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                DialogResult result = MessageBox.Show("Nome do Grupo Obrigatório.", "Erro de Validação", buttons, iError);
                this.txt_NmgrpMerc.Focus();
                return false;
            }
            switch (Comando)
            {
                case iInsert:
                    RegCorGrupoMercadoria.ID_ORG = vIdOrg;
                    RegCorGrupoMercadoria.NM_GRP_MERC = this.txt_NmgrpMerc.Text;
                    RegCorGrupoMercadoria.ID_USU_INCL = vIdUsu;
                    RegCorGrupoMercadoria.DT_INCLUSAO = DateTime.Now;
                    RegCorGrupoMercadoria.IND_GRUPO_ATIVO = vCorGrupoMercadoriaNEG.ATIVO;
                    bAcao = vCorGrupoMercadoriaNEG.InsereGrupoMercadoria(ref vBanco, RegCorGrupoMercadoria);
                    break;
                case iUpdate:
                    RegCorGrupoMercadoria.ID_ORG = vIdOrg;
                    RegCorGrupoMercadoria.ID_GRP_MERC = vIdGrp_Merc;
                    RegCorGrupoMercadoria.NM_GRP_MERC = this.txt_NmgrpMerc.Text;
                    RegCorGrupoMercadoria.ID_USU_ALT = vIdUsu;
                    RegCorGrupoMercadoria.DT_ALTERACAO = DateTime.Now;
                    bAcao = vCorGrupoMercadoriaNEG.AtualizaGrupoMercadoria(ref vBanco, RegCorGrupoMercadoria);
                    break;

            }
            bAcao = LimpaTela(true);
            return PesquisaReg(true);
        }
        private void btnEditar_Click(object sender, EventArgs e)
        {
            var bAlterar = RegAlterar();
        }
        public Boolean RegAlterar()
        {
            Comando = iUpdate;
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
            switch (Comando)
            {
                case iUpdate:
                    {
                        MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                        DialogResult result = MessageBox.Show("Deseja Excluir o Grupo de Mercadoria?", "Exclusão", buttons);
                        if (result == DialogResult.Yes)
                        {
                            bExcluir = false;
                            string vMsg;
                            bExcluir = vCorGrupoMercadoriaNEG.DeleteGrupoMercadoria(ref vBanco, vIdOrg, vIdGrp_Merc);
                            bExcluir = LimpaTela();
                            bExcluir = HabilitaBotoes(iRegExcluir);
                            bExcluir = DesabilitaCamposTela();
                        }
                        break;
                    }
                case iInsert:
                    {
                        MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                        DialogResult result = MessageBox.Show("Deseja Cancelar a Inclusão do Grupo de Mercadoria?", "Cancelar", buttons);
                        if (result == DialogResult.Yes)
                        {
                            bModoPreGravacao = false;
                            bExcluir = LimpaTela();
                            bExcluir = HabilitaBotoes(iRegExcluir);
                            bExcluir = DesabilitaCamposTela();
                        }
                        break;
                    }
            }

            bExcluir = PesquisaReg(true);

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
        private void dgvGrpMerc_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Boolean vbLoad;
            vIdGrp_Merc = Convert.ToInt32(this.dgvGrpMerc.CurrentRow.Cells[0].Value.ToString());
            vbLoad = PesquisaReg(false, vIdGrp_Merc);
        }

        private void dgvGrpMerc_KeyDown(object sender, KeyEventArgs e)
        {
            Boolean vbLoad;
            var tecla = e.KeyCode;
            int vIndexRow = 0;
            int vIndexRowAtu = 0;
            switch (tecla)
            {
                case Keys.Enter:
                    vIdGrp_Merc = Convert.ToInt32(this.dgvGrpMerc.CurrentRow.Cells[0].Value.ToString());
                    break;
                case Keys.Up:
                    vIndexRowAtu = this.dgvGrpMerc.CurrentRow.Index;
                    vIndexRow = this.dgvGrpMerc.Rows.GetPreviousRow(vIndexRowAtu, DataGridViewElementStates.None);
                    if (vIndexRow > -1)
                    {
                        vIdGrp_Merc = Convert.ToInt32(this.dgvGrpMerc.Rows[vIndexRow].Cells[0].Value.ToString());
                    }
                    else
                    {
                        vIdGrp_Merc = Convert.ToInt32(this.dgvGrpMerc.Rows[vIndexRowAtu].Cells[0].Value.ToString());
                    }
                    break;
                case Keys.Down:
                    vIndexRowAtu = this.dgvGrpMerc.CurrentRow.Index;
                    vIndexRow = this.dgvGrpMerc.Rows.GetNextRow(vIndexRowAtu, DataGridViewElementStates.None);
                    if (vIndexRow > -1)
                    {
                        vIdGrp_Merc = Convert.ToInt32(this.dgvGrpMerc.Rows[vIndexRow].Cells[0].Value.ToString());
                    }
                    else
                    {
                        vIdGrp_Merc = Convert.ToInt32(this.dgvGrpMerc.Rows[vIndexRowAtu].Cells[0].Value.ToString());
                    }
                    break;
            }
            vCorGrupoMercadoria = vCorGrupoMercadoriaNEG.ObtemRegistroGrupoMercadoria(ref vBanco, vIdOrg, vIdGrp_Merc);
            vbLoad = LoadReg(vCorGrupoMercadoria);
        }
    }
}
