using System;
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
    public partial class Frm_ParSubGrupoMerc : Form
    {
        private int vIdOrg;
        private int vIdGrp_Merc;
        private int vIdSubGrp_Merc;
        private Banco vBanco = new Banco();
        private string vIdPapel;
        private string vIdUsu;
        private string vNmOrg;
        private string vDsPapel;
        private string FormatCod = "000";

        private Boolean bExecuta;
        private Boolean bPesquisa = false;
        private int Comando;

        public const int iInsert = 1;
        public const int iUpdate = 2;
        public const int iRegNovo = 1;
        public const int iRegAlterar = 2;
        public const int iRegExcluir = 3;
        public const int iRegAtivar = 4;
        public const int iRegDesativar = 5;
        public const int iRegGravar = 6;

        private List<CorGrupoMercadoria> vListCorGrupoMercadoria = new List<CorGrupoMercadoria>();
        private List<CorSubGrupoMercadoria> vListCorSubGrupoMercadoria = new List<CorSubGrupoMercadoria>();
        private CorSubGrupoMercadoria vCorSubGrupoMercadoria = new CorSubGrupoMercadoria();
        

        private CorGrupoMercadoriaNEG vCorGrupoMercadoriaNEG = new CorGrupoMercadoriaNEG();
        private CorSubGrupoMercadoriaNEG vCorSubGrupoMercadoriaNEG = new CorSubGrupoMercadoriaNEG();
        private ConfiguraControleNEG vControleNEG = new ConfiguraControleNEG();

        private Boolean bModoPreGravacao;

        private MessageBoxIcon iError = MessageBoxIcon.Error;
        private MessageBoxIcon iWarning = MessageBoxIcon.Warning;
        private MessageBoxIcon Alert = MessageBoxIcon.Question;

        public Frm_ParSubGrupoMerc(ref Banco pBanco, int pIdOrg, string pIdPapel,
                            string pIdUSU, string pNmOrg, string psDSPapel)
        {
            InitializeComponent();
            vBanco = pBanco;
            vIdOrg = pIdOrg;
            vIdPapel = pIdPapel;
            vIdUsu = pIdUSU;
            vNmOrg = pNmOrg;
            vDsPapel = psDSPapel;
            this.cbxGrupoSubGrupo.SelectedIndex = -1;
            bExecuta = CarregaBarraStatus();
            bPesquisa = MontaCBGrupo();
            bExecuta = PesquisaReg(true);


        }
        private Boolean CarregaBarraStatus()
        {
            this.tstlUsuario.Text = "Usuário:  " + vIdUsu;
            this.tstlOrgSelecionadaNumero.Text = "Org:   " + vIdOrg.ToString(FormatCod);
            this.tstl_OrgDEscricao.Text = " - " + vNmOrg;
            this.TstlPapel.Text = "Papel:  " + vDsPapel;
            return true;
        }
        
        private Boolean PesquisaReg(Boolean pLoadreg = false)
        {
            
            bExecuta = LoadListaSubGrpPapel();
            if (pLoadreg)
            {
                bExecuta = LoadReg(vIdGrp_Merc,vIdSubGrp_Merc);
            }
            return bExecuta;
                
        }
        private Boolean MontaCBGrupo()
        {
            vListCorGrupoMercadoria = vCorGrupoMercadoriaNEG.ObtemListaGrupoMercadoria(ref vBanco, vIdOrg);
            this.cbxGrupoSubGrupo.DataSource = vListCorGrupoMercadoria;
            this.cbxGrupo.DataSource = vListCorGrupoMercadoria;
            var vCorGrupoMercadoria = new CorGrupoMercadoria();
            this.cbxGrupoSubGrupo = vControleNEG.SetComboBox(this.cbxGrupoSubGrupo, nameof(vCorGrupoMercadoria.NM_GRP_MERC), nameof(vCorGrupoMercadoria.ID_GRP_MERC));
            this.cbxGrupo = vControleNEG.SetComboBox(this.cbxGrupo, nameof(vCorGrupoMercadoria.NM_GRP_MERC), nameof(vCorGrupoMercadoria.ID_GRP_MERC));
            return true;           
        }
        private Boolean LoadListaSubGrpPapel()
        {
            this.dtgGrpSGrp.Rows.Clear();
            
            if (this.cbxGrupoSubGrupo.SelectedValue == null)
            {
                vListCorSubGrupoMercadoria = vCorSubGrupoMercadoriaNEG.ObtemListaSubGrupoMercadoria(ref vBanco, vIdOrg);
            }
            else
            {
                vIdGrp_Merc = Convert.ToInt32(this.cbxGrupoSubGrupo.SelectedValue.ToString());
                vListCorSubGrupoMercadoria = vCorSubGrupoMercadoriaNEG.ObtemListaSubGrupoMercadoria(ref vBanco, vIdOrg, vIdGrp_Merc);
            }
            if (vListCorSubGrupoMercadoria.Count > 0)
            {
                foreach(var Linha in vListCorSubGrupoMercadoria)
                {
                    var GrupoSelecionado = vCorGrupoMercadoriaNEG.ObtemRegistroGrupoMercadoria(ref vBanco, vIdOrg, vIdGrp_Merc);
                    this.dtgGrpSGrp.Rows.Add(Linha.ID_GRP_MERC, Linha.ID_SUBGRP_MERC, Linha.NM_SUBGRP_MERC);
                }
            }
            else
            {
                vIdSubGrp_Merc = 0;
            }
            return true;
        }
        private void cbxGrupoSubGrupo_SelectedValueChanged(object sender, EventArgs e)
        {
            if (bPesquisa)
            {
                if (this.cbxGrupoSubGrupo.SelectedValue != null)
                {
                    var vScbxSubGrupo = this.cbxGrupoSubGrupo.SelectedValue.ToString();
                    if (vScbxSubGrupo.All(char.IsDigit))
                    {
                        if (Comando != iInsert && Comando != iUpdate)
                        {
                            bExecuta = LimpaTela(true);
                            bExecuta = PesquisaReg(true);
                        }
                    }
                }
            }
        }
        public Boolean LimpaTela(Boolean pLimpaLista = false)
        {
            this.txt_NmSubGrpMerc.Text = "";
            this.lbl_ID_SubGrpMerc.Text = "SubGrupo: ---- ";
            this.lbl_ID_SubGrpMerc.Tag = "";
            this.lbl_Situacao.Text = "";
            this.lbl_ID_Usu_Incl.Text = "";
            this.lbl_Id_Usu_Alterado.Text = "";
            this.lbl_Dt_Inclusao.Text = "";
            this.lbl_Dt_Alteracao.Text = "";
            this.cbxGrupo.Text = "";
            if (pLimpaLista)
            {
                this.dtgGrpSGrp.Rows.Clear();
            }

            return true;
        }
        public Boolean LoadReg(int pIdGrpMerc = 0, int pIdSubGrpMerc = 0)
        {
            int vIdGrpMerc = pIdGrpMerc;
            int vIdSubGrpMerc = pIdSubGrpMerc;
            
            if (vIdGrpMerc == 0 && vListCorGrupoMercadoria.Count > 0)
            {
                vIdGrpMerc = vListCorGrupoMercadoria[0].ID_GRP_MERC;
            }
            if (vIdSubGrpMerc == 0 && vListCorSubGrupoMercadoria.Count > 0)
            {
                vIdSubGrpMerc = vListCorSubGrupoMercadoria.FindAll(linha => linha.ID_GRP_MERC == vIdGrpMerc && linha.ID_ORG == vIdOrg).First().ID_SUBGRP_MERC;
                
            }
            vCorSubGrupoMercadoria = vCorSubGrupoMercadoriaNEG.ObtemDadosSubGrupoMercadoria(ref vBanco, vIdOrg, vIdGrpMerc, vIdSubGrpMerc);
            if (vCorSubGrupoMercadoria.ID_SUBGRP_MERC != 0)
            {
                var vCorGrupoMercadoria = vCorGrupoMercadoriaNEG.ObtemRegistroGrupoMercadoria(ref vBanco, vIdOrg, vCorSubGrupoMercadoria.ID_GRP_MERC);
                this.lbl_ID_SubGrpMerc.Text = "SubGrupo: " + vCorSubGrupoMercadoria.ID_SUBGRP_MERC.ToString(FormatCod);
                this.lbl_ID_SubGrpMerc.Tag = vCorSubGrupoMercadoria.ID_SUBGRP_MERC.ToString();
                this.lbl_Situacao.Text = vCorSubGrupoMercadoriaNEG.vIndAtivoSubGrupoMercadoria[vCorSubGrupoMercadoria.IND_SUBGRUPO_ATIVO];
                this.lbl_ID_Usu_Incl.Text = vCorSubGrupoMercadoria.ID_USU_INCL;
                this.lbl_Dt_Inclusao.Text = vCorSubGrupoMercadoria.DT_INCLUSAO.ToString("dd/MM/yyyy");
                if (vCorSubGrupoMercadoria.DT_ALTERACAO.HasValue)
                {
                    this.lbl_Id_Usu_Alterado.Text = vCorSubGrupoMercadoria.ID_USU_ALT;
                    this.lbl_Dt_Alteracao.Text = vCorSubGrupoMercadoria.DT_ALTERACAO.Value.ToString("dd/MM/yyyy");
                }
                this.txt_NmSubGrpMerc.Text = vCorSubGrupoMercadoria.NM_SUBGRP_MERC;
                this.cbxGrupo.SelectedValue = vCorGrupoMercadoria.ID_GRP_MERC.ToString();
                this.cbxGrupo.Text = vCorGrupoMercadoria.NM_GRP_MERC;
                
                return true;
            }
            else
            {
                bExecuta = LimpaTela();
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
            Boolean bNovo = RegNovo();
            bModoPreGravacao = true;
            bNovo = HabilitaBotoes(iRegNovo);
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
                    this.btnAtivar.Enabled = vCorSubGrupoMercadoria.IND_SUBGRUPO_ATIVO == "N";
                    this.btnDesativar.Enabled = vCorSubGrupoMercadoria.IND_SUBGRUPO_ATIVO == "S";
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
        public Boolean RegNovo(Boolean pacao = true)
        {
            Boolean vbNovo;
            Comando = iInsert;
            vbNovo = LimpaTela();
            if (this.cbxGrupoSubGrupo.SelectedValue != null)
            {
                this.cbxGrupo.SelectedValue = this.cbxGrupoSubGrupo.SelectedValue;
                this.cbxGrupo.Text = this.cbxGrupoSubGrupo.Text;
            }
            vbNovo = HabilitaCamposTela();
            return vbNovo;
        }
        public Boolean HabilitaCamposTela()
        {
            this.cbxGrupo.Enabled = true;
            this.txt_NmSubGrpMerc.Enabled = true;
            return true;
        }
        public Boolean DesabilitaCamposTela()
        {
            this.cbxGrupo.Enabled = false;
            this.txt_NmSubGrpMerc.Enabled = false;
            return true;
        }
        public Boolean RegSalvar()
        {
            var RegCorSubGrupoMercadoria = new CorSubGrupoMercadoria();

            if (this.cbxGrupo.SelectedValue.ToString()== null )
            {
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                DialogResult result = MessageBox.Show("Grupo Obrigatório.", "Erro de Validação", buttons, iError);
                this.cbxGrupo.Focus();
                return false;
            }
            if (this.txt_NmSubGrpMerc.Text == "")
            {
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                DialogResult result = MessageBox.Show("Nome do Sub Grupo Obrigatório.", "Erro de Validação", buttons, iError);
                this.txt_NmSubGrpMerc.Focus();
                return false;
            }
            switch (Comando)
            {
                case iInsert:
                    RegCorSubGrupoMercadoria.ID_ORG = vIdOrg;
                    RegCorSubGrupoMercadoria.ID_GRP_MERC = Convert.ToInt32(this.cbxGrupo.SelectedValue.ToString());
                    RegCorSubGrupoMercadoria.NM_SUBGRP_MERC = this.txt_NmSubGrpMerc.Text;
                    RegCorSubGrupoMercadoria.IND_SUBGRUPO_ATIVO = vCorSubGrupoMercadoriaNEG.SUB_GRUPO_MERCADORIA_ATIVO;
                    RegCorSubGrupoMercadoria.DT_INCLUSAO = DateTime.Now;
                    RegCorSubGrupoMercadoria.ID_USU_INCL = vIdUsu;
                    bExecuta = vCorSubGrupoMercadoriaNEG.bInsereNovaListaSubGrupoMercadoria(ref vBanco, RegCorSubGrupoMercadoria);
                    break;
                case iUpdate:
                    RegCorSubGrupoMercadoria.ID_ORG = vIdOrg;
                    RegCorSubGrupoMercadoria.ID_GRP_MERC = Convert.ToInt32(this.cbxGrupo.SelectedValue.ToString());
                    RegCorSubGrupoMercadoria.ID_SUBGRP_MERC = vIdSubGrp_Merc;
                    RegCorSubGrupoMercadoria.NM_SUBGRP_MERC = this.txt_NmSubGrpMerc.Text;
                    RegCorSubGrupoMercadoria.DT_ALTERACAO = DateTime.Now;
                    RegCorSubGrupoMercadoria.ID_USU_ALT = vIdUsu;
                    bExecuta = vCorSubGrupoMercadoriaNEG.bUpdateSubGrupoMercadoria(ref vBanco, RegCorSubGrupoMercadoria);
                    break;
            }
            Comando = -1;
            this.cbxGrupoSubGrupo.SelectedValue = "";
            this.cbxGrupoSubGrupo.Text = null;
            bExecuta = PesquisaReg();
            bExecuta = LoadReg();
            return true;
        }
       
        private void btnEditar_Click(object sender, EventArgs e)
        {
            var bAlterar = RegAlterar();
        }
        public Boolean RegAlterar()
        {
            Comando = iUpdate;
            bModoPreGravacao = true;
            vIdGrp_Merc = Convert.ToInt32(cbxGrupo.SelectedValue.ToString());
            vIdSubGrp_Merc = Convert.ToInt32(this.lbl_ID_SubGrpMerc.Tag);

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
            int vIdGrpMerc;
            
            switch (Comando)
            {
                case iUpdate:
                    {
                        MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                        DialogResult result = MessageBox.Show("Deseja Excluir o SubGrupo de Mercadoria?", "Exclusão", buttons);
                        if (result == DialogResult.Yes)
                        {
                            bExcluir = false;
                            string vMsg;
                            vIdGrpMerc = Convert.ToInt32(this.cbxGrupo.SelectedValue.ToString());
                            bExcluir = vCorSubGrupoMercadoriaNEG.bDeleteListaGrupoMercadoria(ref vBanco, vIdOrg, vIdGrpMerc, vIdSubGrp_Merc);
                            bExcluir = LimpaTela(true);
                            bExcluir = HabilitaBotoes(iRegExcluir);
                            bExcluir = DesabilitaCamposTela();
                        }
                        break;
                    }
                case iInsert:
                    {
                        MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                        DialogResult result = MessageBox.Show("Deseja Cancelar a Inclusão do SubGrupo de Mercadoria?", "Cancelar", buttons);
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

            bExcluir = LoadReg();

            return bExcluir;
        }

        private void btnAtivar_Click(object sender, EventArgs e)
        {
            var Habilita = RegAtivar();
            if (Habilita)
            {
                Habilita = HabilitaBotoes(iRegAtivar);
                Habilita = DesabilitaCamposTela();
                Habilita = LimpaTela(false);
                Habilita = LoadReg(vIdGrp_Merc,vIdSubGrp_Merc) ;
                bModoPreGravacao = false;
                //Habilita = LimpaTela();
            }
        }
        public Boolean RegAtivar()
        {
            return vCorSubGrupoMercadoriaNEG.bAtivaSubGrupoMercadoria(ref vBanco, vIdOrg, vIdGrp_Merc,vIdSubGrp_Merc);
        }

        private void btnDesativar_Click(object sender, EventArgs e)
        {
            var Habilita = RegDesativar();
            if (Habilita)
            {
                Habilita = HabilitaBotoes(iRegDesativar);
                Habilita = DesabilitaCamposTela();
                Habilita = LimpaTela(false);
                Habilita = LoadReg(vIdGrp_Merc,vIdSubGrp_Merc);
                bModoPreGravacao = false;
                //Habilita = LimpaTela();
            }
        }
        public Boolean RegDesativar()
        {

            MessageBoxButtons buttons1 = MessageBoxButtons.YesNo;
            string vsSMsg = "Deseja Desativar o SubGrupo de Mercadoria?";
            vsSMsg += Environment.NewLine;
            vsSMsg += "Essa ação deixará desativado todas as mercadorias relacionadas ao SubGrupo";
            DialogResult result1 = MessageBox.Show(vsSMsg, "Confirmação", buttons1, MessageBoxIcon.Information);
            if (result1 == DialogResult.No)
            {
                return false;
            }
            else
            {
                return vCorSubGrupoMercadoriaNEG.bDesativaSubGrupoMercadoria(ref vBanco,vIdOrg,vIdGrp_Merc,vIdSubGrp_Merc);
            }
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
        private void dtgGrpSGrp_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Boolean vbLoad;
            vIdGrp_Merc = Convert.ToInt32(this.dtgGrpSGrp.CurrentRow.Cells[0].Value.ToString());
            vIdSubGrp_Merc = Convert.ToInt32(this.dtgGrpSGrp.CurrentRow.Cells[1].Value.ToString());
            vbLoad = LoadReg(vIdGrp_Merc,vIdSubGrp_Merc);
        }

        private void dtgGrpSGrp_KeyDown(object sender, KeyEventArgs e)
        {
            Boolean vbLoad;
            var tecla = e.KeyCode;
            int vIndexRow = 0;
            int vIndexRowAtu = 0;
            switch (tecla)
            {
                case Keys.Enter:
                    vIdGrp_Merc = Convert.ToInt32(this.dtgGrpSGrp.CurrentRow.Cells[0].Value.ToString());
                    vIdSubGrp_Merc = Convert.ToInt32(this.dtgGrpSGrp.CurrentRow.Cells[1].Value.ToString());
                    break;
                case Keys.Up:
                    vIndexRowAtu = this.dtgGrpSGrp.CurrentRow.Index;
                    vIndexRow = this.dtgGrpSGrp.Rows.GetPreviousRow(vIndexRowAtu, DataGridViewElementStates.None);
                    if (vIndexRow > -1)
                    {
                        vIdGrp_Merc = Convert.ToInt32(this.dtgGrpSGrp.Rows[vIndexRow].Cells[0].Value.ToString());
                        vIdSubGrp_Merc = Convert.ToInt32(this.dtgGrpSGrp.Rows[vIndexRow].Cells[1].Value.ToString());
                    }
                    else
                    {
                        vIdGrp_Merc = Convert.ToInt32(this.dtgGrpSGrp.Rows[vIndexRowAtu].Cells[0].Value.ToString());
                        vIdSubGrp_Merc = Convert.ToInt32(this.dtgGrpSGrp.Rows[vIndexRowAtu].Cells[1].Value.ToString());
                    }
                    break;
            }
            vbLoad = LoadReg(vIdGrp_Merc, vIdSubGrp_Merc);
        }
    }
}
