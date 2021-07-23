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
    public partial class Frm_CriaOrg : Form
    {

        private Banco vBanco = new Banco();
        private int vIdOrg;
        private string vIdPapel;
        private string vIdUsu;
        private string vNmOrg;
        private string vDsPapel;
        private List<CorOrganizacao> listCorOrganizacao = new List<CorOrganizacao>();
        private List<CorOrganizacao> listOrgMae = new List<CorOrganizacao>();
        private List<SisOrganizacaoPapel> ListPapel = new List<SisOrganizacaoPapel>();
        private List<SisUsuarioOrganizacao> ListUser = new List<SisUsuarioOrganizacao>();
        private CorOrganizacaoNEG vCorOrgNEG = new CorOrganizacaoNEG();
        private SisOrganizacaoPapelNEG vOrgPapelNEG = new SisOrganizacaoPapelNEG();
        private SisUsuarioOrganizacaoNEG vUorgNEG = new SisUsuarioOrganizacaoNEG();
        private ConfiguraControleNEG vControleNEG = new ConfiguraControleNEG();
        private CorOrganizacao CorOrg = new CorOrganizacao();
        private MessageBoxIcon Alert = MessageBoxIcon.Question;
        private Boolean bExecuta;
        private int Comando;
        private int vIdOrgSelecionada;
        public const int CORGADMIN = 1;
        public const string CTPORGADM = "A";
        public const string CTPORGOPE = "O";
        public const int iInsert = 1;
        public const int iUpdate = 2;
        public const int iRegNovo = 1;
        public const int iRegAlterar = 2;
        public const int iRegExcluir = 3;
        public const int iRegPesquisar = 4;
        public const int iRegGravar = 5;
        public const string FormatOrg = "000";
        public CorOrganizacaoLicencaNEG OrgLicNEG = new CorOrganizacaoLicencaNEG();
        public Boolean bModoPreGravacao;
        
        public class TP_ORG
        {
            public string ID_TP_ORG { set; get; }
            public string DS_TP_ORG { set; get; }
        
        }

        public Frm_CriaOrg(ref Banco pBanco, int pIdOrg, string pIdPapel, 
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
            bExecuta = CarregaOrgs();
            bExecuta = CarregaCbxOrgMae();
            bExecuta = CarregaTPOrg();
        }
        private Boolean CarregaTPOrg()
        {
            
            var ListTpOrg = new List<TP_ORG>();
            var TpOrg = new TP_ORG();
            var TpOrgAdm = new TP_ORG();
            TpOrgAdm.ID_TP_ORG = "A";
            TpOrgAdm.DS_TP_ORG = "Administrativo";
            ListTpOrg.Add(TpOrgAdm);

            var TpOrgOper = new TP_ORG();
            TpOrgOper.ID_TP_ORG = "O";
            TpOrgOper.DS_TP_ORG = "Operacional";
            ListTpOrg.Add(TpOrgOper);

            this.cbx_TpOrg.DataSource = ListTpOrg;
            var vControle = vControleNEG.SetComboBox(cbx_TpOrg, nameof(TpOrg.DS_TP_ORG), nameof(TpOrg.ID_TP_ORG));
            return true;
        }
        private Boolean CarregaOrgs()
        {
            listCorOrganizacao = vCorOrgNEG.ObtemListaOrg(ref vBanco, vIdUsu);
            listOrgMae = listCorOrganizacao.FindAll(org => org.TP_ORG == vCorOrgNEG.ADMINISTRATIVA);
            return AlimentaTreeListOrg();
        }
        private Boolean CarregaCbxOrgMae()
        {
            
            this.cbx_OrgMae.DataSource = listOrgMae;
            var vControle = vControleNEG.SetComboBox(cbx_OrgMae, nameof(CorOrg.NM_ORG_RESUMIDO), nameof(CorOrg.ID_ORG)); 
            return true;
        }
        private Boolean CarregaBarraStatus()
        {
            this.tstlUsuario.Text = "Usuário:  " + vIdUsu;
            this.tstlOrgSelecionadaNumero.Text = "Org:   " + vIdOrg.ToString(FormatOrg);
            this.tstl_OrgDEscricao.Text = " - " + vNmOrg;
            this.TstlPapel.Text = "Papel:  " + vDsPapel;
            return true;
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            if (bModoPreGravacao)
            {
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result = MessageBox.Show("Deseja Salvar?", "Sem Salvar", buttons,Alert);
                if (result == DialogResult.Yes)
                {
                    var bSalvar = RegSalvar();
                }

            }
            this.Dispose();
        }
        private Boolean AlimentaTreeListOrg()
        {

            int inDexFilho = 1;
            this.trvOrgs.Nodes.Clear();
            TreeNode rootNodes = trvOrgs.Nodes.Add("Organizações");
            var ApenasOrganizacoesSemMae = listCorOrganizacao.FindAll(linhaOrgAdm => linhaOrgAdm.ID_ORG_MAE == 0);
            TreeNode[] NosFilhos = new TreeNode[ApenasOrganizacoesSemMae.Count];
            foreach(var linhaOrgSemMae in ApenasOrganizacoesSemMae)
            {
                NosFilhos[inDexFilho - 1] = rootNodes.Nodes.Add(linhaOrgSemMae.NM_ORG);
                NosFilhos[inDexFilho - 1].Tag = linhaOrgSemMae.ID_ORG.ToString();
                var OrganizacoesFilho = listCorOrganizacao.FindAll(OrgFilho => OrgFilho.ID_ORG_MAE == linhaOrgSemMae.ID_ORG);
                if (OrganizacoesFilho.Count > 0)
                {
                    int inDexNeto = 1;
                    TreeNode[] NosNetos = new TreeNode[OrganizacoesFilho.Count];
                    foreach (var LinhaOrgFilho in OrganizacoesFilho)
                    {
                        NosNetos[inDexNeto - 1] = NosFilhos[inDexFilho - 1].Nodes.Add(LinhaOrgFilho.NM_ORG);
                        NosNetos[inDexNeto - 1].Tag = LinhaOrgFilho.ID_ORG.ToString();
                        var OrganizacaoNeto = listCorOrganizacao.FindAll(OrgNeto => OrgNeto.ID_ORG_MAE == LinhaOrgFilho.ID_ORG);
                        if (OrganizacaoNeto.Count > 0)
                        {
                            int vIndexNEto = 1;
                            TreeNode[] NosBisNetos = new TreeNode[OrganizacaoNeto.Count];
                            foreach(var linhaOrgNeto in OrganizacaoNeto)
                            {
                                NosBisNetos[vIndexNEto - 1] = NosNetos[inDexNeto - 1].Nodes.Add(linhaOrgNeto.NM_ORG);
                                NosBisNetos[vIndexNEto - 1].Tag = linhaOrgNeto.ID_ORG.ToString();
                                var OrganizacaoNeto1 = listCorOrganizacao.FindAll(OrgBisNeto => OrgBisNeto.ID_ORG_MAE == linhaOrgNeto.ID_ORG); ;
                                if (OrganizacaoNeto1.Count > 0)
                                {
                                    int vIndNEto = 1;
                                    TreeNode[] NosTataraNetos = new TreeNode[OrganizacaoNeto1.Count]; 
                                    foreach(var linhaOrgBisneto in OrganizacaoNeto1)
                                    {
                                        NosTataraNetos[vIndNEto - 1] = NosBisNetos[vIndexNEto - 1].Nodes.Add(linhaOrgBisneto.NM_ORG);
                                        NosTataraNetos[vIndNEto - 1].Tag = linhaOrgBisneto.ID_ORG.ToString();
                                    }
                                }                                
                                vIndexNEto += 1;

                            }
                        }
                        inDexNeto += 1;
                    }
                }
                inDexFilho += 1;
            }
            return true;
        }
        public Boolean RegNovo(Boolean pacao = true)
        {
            Boolean vbNovo;
            Comando = iInsert;
            vbNovo = LimpaTela(pacao);
            vbNovo = HabilitaCamposTela();
            return vbNovo;
        }
        public int ObtemIdOrg()
        {
            int IdOrg = vCorOrgNEG.ObtemIdOrg(ref vBanco);
            return IdOrg;
        }
        public Boolean DesabilitaCamposTela()
        {
            this.txBNmOrg.Enabled = false;
            this.txb_OrgResumido.Enabled = false;
            this.cbx_OrgMae.Enabled = false;
            this.cbx_TpOrg.Enabled = false;
            return true;
        }
        public Boolean HabilitaCamposTela()
        {
            this.txBNmOrg.Enabled = true;
            this.txb_OrgResumido.Enabled = true;
            this.cbx_OrgMae.Enabled = true;
            this.cbx_TpOrg.Enabled = true;
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
        public Boolean HabilitaLic(Boolean pacao = false)
        {
            this.btnLic.Enabled = pacao;
            return pacao;

        }

        public Boolean LimpaTela(Boolean pacao = false)
        {

            bModoPreGravacao = false;
            this.DtgPapel.Rows.Clear();
            this.dGvUser.Rows.Clear();
            if (pacao)
            {
                vIdOrgSelecionada = ObtemIdOrg();
            }
            else
            {
                vIdOrgSelecionada = 0;
            }

            this.lblORG.Text = "ORG: " + vIdOrgSelecionada.ToString(FormatOrg);
            this.txBNmOrg.Text = "";
            this.txb_OrgResumido.Text = "";
            this.cbx_OrgMae.Text = "";
            this.cbx_OrgMae.SelectedItem = "";
            this.cbx_TpOrg.Text = "";
            this.cbx_TpOrg.SelectedItem = "";
            this.lbLic.Text = "";



            return true;

        }

        private void btnNovo_Click(object sender, EventArgs e)
        {

            if (bModoPreGravacao)
            {
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result = MessageBox.Show("Deseja Salvar?", "Sem Salvar", buttons,Alert);
                if (result == DialogResult.Yes)
                {
                    var bSalvar = RegSalvar();
                }

            }
            Comando = iInsert;
            Boolean bNovo = RegNovo();
            bModoPreGravacao = true;
            bNovo = HabilitaBotoes(iRegNovo);
            bNovo = HabilitaLic();
        }
        public Boolean RegSalvar()
        {
            int vTotLoop = 0;
            MessageBoxIcon iError = MessageBoxIcon.Error;
            MessageBoxIcon iWarning = MessageBoxIcon.Warning;
            if (this.txBNmOrg.Text == "")
            {
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                DialogResult result = MessageBox.Show("Nome de Org Obrigatório.", "Erro de Validação", buttons,iError);
                this.txBNmOrg.Focus();
                return false;

            }
            if (this.txb_OrgResumido.Text == "")
            {
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                DialogResult result = MessageBox.Show("Nome Resumido de Org Obrigatório.", "Erro de Validação", buttons, iError);
                this.txBNmOrg.Focus();
                return false;
            }
            if (this.cbx_TpOrg.Text == null)
            {
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                DialogResult result = MessageBox.Show("Deve definir o tipo de ORG.", "Erro de Validação", buttons);
                this.cbx_TpOrg.Focus();
                return false;
            }
            if (this.cbx_TpOrg.SelectedValue == CTPORGOPE && this.cbx_OrgMae.Text == "")
            {
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                DialogResult result = MessageBox.Show("Organizações do tipo Operacional não podem ser orfãs.", "Erro de Validação",buttons, iWarning);
                this.cbx_TpOrg.Focus();
                return false;

            }
            if (this.DtgPapel.RowCount-1 == 0)
            {
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result = MessageBox.Show("Não Há Papeis Associados Deseja Continuar?", "Org Sem Papel Associado", buttons, iWarning);
                if (result == DialogResult.No)
                {
                    return false;
                }
            }
            
            if (this.dGvUser.RowCount-1 == 0)
            {
                MessageBoxButtons buttons1 = MessageBoxButtons.YesNo;
                DialogResult result1 = MessageBox.Show("Não Há Usuários Associados Deseja Continuar?", "Org Sem Usuário Associado", buttons1);
                if (result1 == DialogResult.No)
                {
                    return false;
                }
            }

            switch (Comando)
            {
                case iInsert:
                    var RegInsereOrg = new CorOrganizacao();
                    RegInsereOrg.ID_ORG = vIdOrgSelecionada;
                    RegInsereOrg.NM_ORG = this.txBNmOrg.Text;
                    RegInsereOrg.NM_ORG_RESUMIDO = this.txb_OrgResumido.Text;
                    if (this.cbx_OrgMae.Text != "")
                    {
                        RegInsereOrg.ID_ORG_MAE = Convert.ToInt32(this.cbx_OrgMae.SelectedValue.ToString());
                    }
                    RegInsereOrg.TP_ORG = this.cbx_TpOrg.SelectedValue.ToString();
                    var bInsere = vCorOrgNEG.InsereCorOrganizacao(ref vBanco, RegInsereOrg);
                    if (this.DtgPapel.Rows.Count-1 > 0)
                    {
                        vTotLoop = DtgPapel.Rows.Count - 1;
                        var ListPapelAssociado = new List<SisOrganizacaoPapel>();
                        for (int linha = 0; linha < vTotLoop; linha ++)
                        {
                            var vLinhaOPap = new SisOrganizacaoPapel();
                            vLinhaOPap.ID_ORG = vIdOrgSelecionada;
                            vLinhaOPap.ID_PAPEL = DtgPapel.Rows[linha].Cells[0].Value.ToString();
                            vLinhaOPap.DS_PAPEL = DtgPapel.Rows[linha].Cells[1].Value.ToString();
                            vLinhaOPap.ID_USU_INCL = DtgPapel.Rows[linha].Cells[2].Value.ToString();
                            vLinhaOPap.DT_INCLUSAO = Convert.ToDateTime(DtgPapel.Rows[linha].Cells[3].Value.ToString());
                            ListPapelAssociado.Add(vLinhaOPap);
                        }
                        bInsere = vOrgPapelNEG.AssociaPapelOrg(ref vBanco, new List<SisOrganizacaoPapel>(), ListPapelAssociado);
                    }
                    if (this.dGvUser.Rows.Count-1 > 0)
                    {
                        vTotLoop = this.dGvUser.Rows.Count - 1;
                        var ListUORG = new List<SisUsuarioOrganizacao>();
                        for (int linha = 0; linha < vTotLoop; linha++)
                        {
                            var LinhaUORG = new SisUsuarioOrganizacao();
                            LinhaUORG.ID_ORG = vIdOrgSelecionada;
                            LinhaUORG.ID_USU = dGvUser.Rows[linha].Cells[0].Value.ToString();
                            LinhaUORG.ID_USU_INCL = dGvUser.Rows[linha].Cells[1].Value.ToString();
                            LinhaUORG.DT_INCLUSAO = Convert.ToDateTime(dGvUser.Rows[linha].Cells[2].Value.ToString());
                            ListUORG.Add(LinhaUORG);
                        }
                        bInsere = vUorgNEG.bAssociaUsuarioOrg(ref vBanco, new List<SisUsuarioOrganizacao>(), ListUORG);

                    }
                    if (RegInsereOrg.TP_ORG == "O")
                    {
                        Boolean bLicenca = OrgLicNEG.bTemLic(ref vBanco, RegInsereOrg.ID_ORG);
                    }
                    break;
                case iUpdate:
                    var RegUpdateOrg = new CorOrganizacao();
                    RegUpdateOrg.ID_ORG = vIdOrgSelecionada;
                    RegUpdateOrg.NM_ORG = this.txBNmOrg.Text;
                    RegUpdateOrg.NM_ORG_RESUMIDO = this.txb_OrgResumido.Text;
                    if (this.cbx_OrgMae.Text != "")
                    {
                        RegUpdateOrg.ID_ORG_MAE = Convert.ToInt32(this.cbx_OrgMae.SelectedValue.ToString());
                    }
                    RegUpdateOrg.TP_ORG = this.cbx_TpOrg.SelectedValue.ToString();
                    var bUpdate = vCorOrgNEG.UpdateCorOrganizacao(ref vBanco, RegUpdateOrg);
                    if (this.DtgPapel.Rows.Count-1 > 0)
                    {
                        vTotLoop = DtgPapel.Rows.Count - 1;
                        var ListPapelAssociado = new List<SisOrganizacaoPapel>();
                        for (int linha = 0; linha < vTotLoop; linha++)
                        {
                            var vLinhaOPap = new SisOrganizacaoPapel();
                            vLinhaOPap.ID_ORG = vIdOrgSelecionada;
                            vLinhaOPap.ID_PAPEL = DtgPapel.Rows[linha].Cells[0].Value.ToString();
                            vLinhaOPap.DS_PAPEL = DtgPapel.Rows[linha].Cells[1].Value.ToString();
                            vLinhaOPap.ID_USU_INCL = DtgPapel.Rows[linha].Cells[2].Value.ToString();
                            vLinhaOPap.DT_INCLUSAO = Convert.ToDateTime(DtgPapel.Rows[linha].Cells[3].Value.ToString());
                            ListPapelAssociado.Add(vLinhaOPap);
                        }
                        if (ListPapel.Count > ListPapelAssociado.Count)
                        {
                            bInsere = vOrgPapelNEG.RetiraAssociaPapOrg(ref vBanco, ListPapel,ListPapelAssociado);
                        }
                        else if (ListPapel.Count < ListPapelAssociado.Count)
                        {
                            bInsere = vOrgPapelNEG.AssociaPapelOrg(ref vBanco, ListPapel, ListPapelAssociado);
                        }
                        else
                        {
                            bInsere = true;
                        }
                    }
                    if (this.dGvUser.Rows.Count-1 > 0)
                    {
                        vTotLoop = this.dGvUser.Rows.Count - 1;
                        var ListUORG = new List<SisUsuarioOrganizacao>();
                        for (int linha = 0; linha < vTotLoop; linha++)
                        {
                            var LinhaUORG = new SisUsuarioOrganizacao();
                            LinhaUORG.ID_ORG = vIdOrgSelecionada;
                            LinhaUORG.ID_USU = dGvUser.Rows[linha].Cells[0].Value.ToString();
                            if (dGvUser.Rows[linha].Cells[1].Value != null)
                            {
                                LinhaUORG.ID_USU_INCL = dGvUser.Rows[linha].Cells[1].Value.ToString();
                            }
                            
                            LinhaUORG.DT_INCLUSAO = Convert.ToDateTime(dGvUser.Rows[linha].Cells[2].Value.ToString());
                            ListUORG.Add(LinhaUORG);
                        }
                        if (ListUser.Count > ListUORG.Count)
                        {
                            bInsere = vUorgNEG.bDesassociaUsuarioOrg(ref vBanco, ListUser, ListUORG);

                        }
                        else if (ListUser.Count < ListUORG.Count)
                        {
                            bInsere = vUorgNEG.bAssociaUsuarioOrg(ref vBanco, ListUser, ListUORG);
                        }
                        else
                        {
                            bInsere = true;
                        }
                    }
                    break;    

            }
            return true;
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
            bExcluir = CarregaOrgs();
            bExcluir = CarregaCbxOrgMae();
        }

        public Boolean RegExcluir()
        {
            Boolean bExcluir = true;
            switch (Comando)
            {
                case iRegAlterar:
                {
                        MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                        DialogResult result = MessageBox.Show("Deseja Excluir Org?", "Exclusão", buttons);
                        if (result == DialogResult.Yes)
                        {
                            bExcluir = false;
                            string vMsg;
                            CorOrganizacao vCorOrg = new CorOrganizacao();
                            vCorOrg = listCorOrganizacao.Find(linha => linha.ID_ORG == vIdOrgSelecionada);
                            bExcluir = vUorgNEG.DeleteOrgUsu(ref vBanco, vIdOrgSelecionada, vIdUsu);
                            bExcluir = vOrgPapelNEG.ExclueAssociaPapelOrg(ref vBanco, vIdOrgSelecionada);
                            vMsg = vCorOrgNEG.DeleteCorOrganizacao(ref vBanco, vCorOrg);
                            if (vMsg != "OK")
                            {
                                buttons = MessageBoxButtons.OK;
                                result = MessageBox.Show(vMsg, "Impossível Excluir Organização", buttons);
                                bExcluir = false;
                            }
                            else
                            {
                                bModoPreGravacao = false;
                                bExcluir = LimpaTela();
                                bExcluir = DesabilitaCamposTela(); 
                            }
                        }
                    break;
                }
                case iRegNovo:
                {
                        MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                        DialogResult result = MessageBox.Show("Deseja Cancelar a Inclusão de ORG?", "Cancelar", buttons);
                        if (result == DialogResult.Yes)
                        {
                            bModoPreGravacao = false;
                            bExcluir = LimpaTela();
                            bExcluir = DesabilitaCamposTela();
                        }
                        break;
                }
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
                Habilita = CarregaOrgs();
                Habilita = CarregaCbxOrgMae();
                Habilita = LimpaTela();
                bModoPreGravacao = false;
            }
        }

        private void btnInclueAssociacao_Click(object sender, EventArgs e)
        {
            Frm_Associa FrmAssocia = new Frm_Associa(ref vBanco,Frm_Associa.AssociaORGPapel, vIdOrgSelecionada, vIdUsu,"","",9,this.cbx_TpOrg.SelectedValue.ToString());
            if (FrmAssocia.ShowDialog() == DialogResult.OK)
            {
                int vIndex = this.DtgPapel.RowCount + 1;
                this.DtgPapel.Rows.Add(FrmAssocia.vSysOrg.ID_PAPEL, FrmAssocia.vSysOrg.DS_PAPEL, FrmAssocia.vSysOrg.ID_USU_INCL, FrmAssocia.vSysOrg.DT_INCLUSAO);
            }
        }

        private void trvOrgs_AfterSelect(object sender, TreeViewEventArgs e)
        {
            vIdOrgSelecionada = Convert.ToInt32(this.trvOrgs.SelectedNode.Tag);
            //var OrgSelecionada = vCorOrgNEG.ObtemOrgSelecionada(vIdOrgSelecionada, listCorOrganizacao);
            if (vIdOrgSelecionada != 0)
            {
                CorOrg = vCorOrgNEG.ObtemOrgSelecionada(vIdOrgSelecionada, listCorOrganizacao);
            }
            var vSeleciona = bAlimentaDbGridPapel();
            vSeleciona = bAlimenteDbGridUsuario();
            vSeleciona = LoadReg();
            vSeleciona = HabilitaLic(vIdOrgSelecionada != CORGADMIN && CorOrg.TP_ORG == CTPORGADM);
        }
        private Boolean LoadReg()
        {
            
            this.lblORG.Text = "ORG: " + vIdOrgSelecionada.ToString(FormatOrg);
            if (vIdOrgSelecionada != 0)
            {
                this.txBNmOrg.Text = CorOrg.NM_ORG;
                this.txb_OrgResumido.Text = CorOrg.NM_ORG_RESUMIDO;
                if (CorOrg.ID_ORG_MAE != 0)
                {
                    var OrgMae = listOrgMae.Find(LinhaOrgMae => LinhaOrgMae.ID_ORG == CorOrg.ID_ORG_MAE);
                    this.cbx_OrgMae.SelectedItem = CorOrg.ID_ORG_MAE;
                    this.cbx_OrgMae.Text = OrgMae.NM_ORG_RESUMIDO;

                }
                this.cbx_TpOrg.SelectedItem = CorOrg.TP_ORG;
                this.cbx_TpOrg.Text = TraduzTpOrg(CorOrg.TP_ORG);
                if (vIdOrgSelecionada != CORGADMIN)
                {
                    Boolean vbExistELic;
                    CorOrganizacaoLicencaNEG vOrgLicNEG = new CorOrganizacaoLicencaNEG();
                    int vOrgconsulta = vIdOrgSelecionada;
                    if (CorOrg.TP_ORG == CTPORGADM)
                    {
                        if (CorOrg.ID_ORG_MAE != 0)
                        {
                            vOrgconsulta = CorOrg.ID_ORG_MAE;
                        }
                        vbExistELic = vOrgLicNEG.bTemLic(ref vBanco, vOrgconsulta);
                        if (vbExistELic)
                        {
                            this.lbLic.Text = "LICENCIADA";
                            this.lbLic.ForeColor = Color.RoyalBlue;
                        }
                        else
                        {
                            this.lbLic.Text = "PENDENTE DE LICENCIAMENTO";
                            this.lbLic.ForeColor = Color.DarkRed;
                        }
                    }
                    
                }
                else
                {
                    this.lbLic.Text = "";   
                }
            }
            return true;
        }
        private string TraduzTpOrg(string pTpOrg)
        {
            string vDescricao = "Operacional";

            if (pTpOrg == "A")
            {
                vDescricao = "Administrativo";
            }

            return vDescricao;

        }
        private Boolean bAlimentaDbGridPapel()
        {
            ListPapel = vOrgPapelNEG.ObtemListaPapeisAssociados(ref vBanco, vIdOrgSelecionada, vIdUsu);
            this.DtgPapel.Rows.Clear();
            foreach(var RegPapel in ListPapel)
            {
                this.DtgPapel.Rows.Add(RegPapel.ID_PAPEL, RegPapel.DS_PAPEL, RegPapel.ID_USU_INCL, RegPapel.DT_INCLUSAO);
            }

            return true;
        }
        private Boolean bAlimenteDbGridUsuario()
        {
            ListUser = vUorgNEG.ObtemUsuariosAssociadosOrg(ref vBanco, vIdOrgSelecionada);
            this.dGvUser.Rows.Clear();
            foreach(var RegUorg in ListUser)
            {
                this.dGvUser.Rows.Add(RegUorg.ID_USU, RegUorg.ID_USU_INCL, RegUorg.DT_INCLUSAO);
            }
            return true;
        }
        public Boolean bConfiguraTituloDbGrid()
        {
            this.DtgPapel.Columns[0].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleLeft;
            this.DtgPapel.Columns[1].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleLeft;
            this.DtgPapel.Columns[2].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.DtgPapel.Columns[3].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            this.dGvUser.Columns[0].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.dGvUser.Columns[1].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.dGvUser.Columns[2].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;

            return true;
        }

        private void btnAssociaUsu_Click(object sender, EventArgs e)
        {
            Frm_Associa FrmAssocia = new Frm_Associa(ref vBanco, Frm_Associa.AssociaORGUsuario, vIdOrgSelecionada, vIdUsu);
            if (FrmAssocia.ShowDialog() == DialogResult.OK)
            {
                int vIndex = this.dGvUser.RowCount + 1;
                this.dGvUser.Rows.Add(FrmAssocia.vUorg.ID_USU, FrmAssocia.vUorg.ID_USU_INCL, FrmAssocia.vUorg.DT_INCLUSAO);
            }
        }

        private void btnRetiraAssociacao_Click(object sender, EventArgs e)
        {
            if (this.DtgPapel.CurrentRow != null)
            {
                this.DtgPapel.Rows.RemoveAt(this.DtgPapel.CurrentRow.Index);
            }
        }

        private void btnREtiraAssociaOrgUsu_Click(object sender, EventArgs e)
        {
            if (this.dGvUser.CurrentRow != null)
            {
                this.dGvUser.Rows.RemoveAt(this.dGvUser.CurrentRow.Index);
            }
        }

        private void btnLic_Click(object sender, EventArgs e)
        {
            Frm_Licenca vFrm_Licenca = new Frm_Licenca(ref vBanco, vIdOrgSelecionada);
            vFrm_Licenca.ShowDialog();
            var Habilita = HabilitaBotoes(iRegGravar);
            Habilita = DesabilitaCamposTela();
            Habilita = CarregaOrgs();
            Habilita = CarregaCbxOrgMae();
            Habilita = LimpaTela();
        }
    }
}
