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
    public partial class Frm_CriaUsu : Form
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

        private List<SisUsuario> ListUsu = new List<SisUsuario>();

        private SisUsuario UsuDetalhe = new SisUsuario();
        private SIS_USUARIO_NEG vSisUsuNeg = new SIS_USUARIO_NEG();
        private List<SisUsuarioOrganizacao> vListUORG = new List<SisUsuarioOrganizacao>();
        private List<SisPapelUsuario> vListPUSU = new List<SisPapelUsuario>();
        private SisPapelUsuarioNEG vPusuNEG = new SisPapelUsuarioNEG();
        private SisUsuarioOrganizacaoNEG vUorgNEG = new SisUsuarioOrganizacaoNEG();
        private CorOrganizacaoNEG vOrgNEG = new CorOrganizacaoNEG();
        private SisPapelNEG vPapNEG = new SisPapelNEG();

        private List<SisOrganizacaoPapelUsuario> vListSisOPusu = new List<SisOrganizacaoPapelUsuario>();

        public Boolean bModoPreGravacao;

        public const string DTLASTLOGIN = "Último Login";
        public const string QTDLOGINSEMSUCESSO = "Qtd. Login Sem Sucesso: ";
        public const string PAPADM = "1";
        public const int iInsert = 1;
        public const int iUpdate = 2;
        public const int iRegNovo = 1;
        public const int iRegAlterar = 2;
        public const int iRegCriar = 3;
        public const int iRegAtivar = 4;
        public const int iRegDesativar = 5;
        public const int iRegGravar = 6;
        public const int iSenha = 7;
        public const string FormatOrg = "000";

        private MessageBoxIcon Alert = MessageBoxIcon.Question;
        private MessageBoxIcon Error = MessageBoxIcon.Error;
        private MessageBoxIcon iWarning = MessageBoxIcon.Warning;

        public Frm_CriaUsu(ref Banco pBanco, int pIdOrg, string pIdPapel,
                            string pIdUSU, string pNmOrg, string psDSPapel)
        {
            InitializeComponent();
            vBanco = pBanco;
            vIdOrg = pIdOrg;
            vIdPapel = pIdPapel;
            vIdUsu = pIdUSU;
            vNmOrg = pNmOrg;
            vDsPapel = psDSPapel;
            bExecuta = LimpaTela();
            bExecuta = CarregaBarraStatus();
            bExecuta = bConfiguraTituloDbGrid();
            bExecuta = LoadGeral(); ;
        }
        private Boolean LoadGeral()
        {
            Boolean bExecuta = CarregaUsuariosCadastrados();
            bExecuta = CarregaDbCridUser();
            return bExecuta;
        }
        private Boolean CarregaBarraStatus()
        {
            this.tstlUsuario.Text = "Usuário:  " + vIdUsu;
            this.tstlOrgSelecionadaNumero.Text = "Org:   " + vIdOrg.ToString(FormatOrg);
            this.tstl_OrgDEscricao.Text = " - " + vNmOrg;
            this.TstlPapel.Text = "Papel:  " + vDsPapel;
            return true;
        }
        public Boolean LimpaTela()
        {
            this.lbl_Status.Text = "";
            this.lbl_Motivo_Bloqueio.Text = "";
            this.lbl_ID_Usu_Incl.Text = "";
            this.lbl_Id_Usu_Alterado.Text = "";
            this.lbl_Dt_Inclusao.Text = "";
            this.lbl_Dt_Alteracao.Text = "";
            this.txt_IDUSER.Clear();
            this.txt_NMUsu.Clear();
            this.txt_Email.Clear();
            this.dtvUserPapel.Rows.Clear();
            this.DtvOrgUsu.Rows.Clear();
            return true;
        }
        public Boolean bConfiguraTituloDbGrid()
        {
            this.DtvOrgUsu.Columns[0].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.DtvOrgUsu.Columns[1].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleLeft;
            this.DtvOrgUsu.Columns[2].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.DtvOrgUsu.Columns[3].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            this.dtvUserPapel.Columns[0].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleLeft;
            this.dtvUserPapel.Columns[1].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleLeft;
            this.dtvUserPapel.Columns[2].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.dtvUserPapel.Columns[3].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            return true;
        }
        public Boolean CarregaUsuariosCadastrados()
        {
            ListUsu = vSisUsuNeg.ObtemListaUsuario(ref vBanco, vIdOrg, vIdUsu);
            return ListUsu.Count > 0;
        }

        public Boolean CarregaDbCridUser()
        {
            foreach (var rUsu in ListUsu)
            {
                dtvUsers.Rows.Add(rUsu.id_usu, rUsu.nm_usu);
            }

            UsuDetalhe = ListUsu.First();

            return LoadReg(UsuDetalhe);
        }
        private Boolean CarregaPapelAssociadoUSu(string pIdUsu)
        {
            this.dtvUserPapel.Rows.Clear();
            var ListP = vPusuNEG.ObtemListaPapelAssociadoUsu(ref vBanco, pIdUsu);
            foreach (var RPusu in ListP)
            {
                var LinhaReg = new SisPapelUsuario();
                var PAPEL = vPapNEG.ObtemPapelSelecionado(ref vBanco, RPusu.ID_PAPEL);
                this.dtvUserPapel.Rows.Add(RPusu.ID_PAPEL, PAPEL.DS_PAPEL, RPusu.ID_USU_INCL, RPusu.DT_INCLUSAO.ToString("dd/MM/yyyy"));
                LinhaReg.ID_PAPEL = RPusu.ID_PAPEL;
                LinhaReg.ID_USU = RPusu.ID_USU;
                vListPUSU.Add(LinhaReg);

            }
            return true;
        }
        private Boolean CarregaOrgsAssociadasUsu(string pIdUsu)
        {
            this.DtvOrgUsu.Rows.Clear();
            vListUORG = vUorgNEG.ObtemOrgsAssociadosUSuario(ref vBanco, pIdUsu);
            foreach (var UORG in vListUORG)
            {
                var ORgSelec = vOrgNEG.OrgSelecionada(ref vBanco, UORG.ID_ORG);

                this.DtvOrgUsu.Rows.Add(UORG.ID_ORG, ORgSelec.NM_ORG, UORG.ID_USU_INCL, UORG.DT_INCLUSAO.ToString("dd/MM/yyyy"));
            }
            return true;
        }
        public Boolean LoadReg(SisUsuario pUsu = null, string pIdUsu = null)
        {
            string sDtLastLogin;
            Boolean vbExecuta;
            var vUsu = pUsu;
            if (pUsu == null)
            {
                UsuDetalhe = vSisUsuNeg.ObtemRegistroUsuario(pIdUsu, ref vBanco);
            }
            this.lbl_Status.Text = vSisUsuNeg.DicStatusUsu[pUsu.ind_bloqueado];
            if (vUsu.ind_bloqueado == vSisUsuNeg.sUsuarioBloqueado)
            {

                this.lbl_Status.ForeColor = Color.Maroon;
                this.lbl_Motivo_Bloqueio.Text = vSisUsuNeg.DicMotivoBloqueado[vUsu.ind_motivo_bloqueio];
                switch (vUsu.ind_motivo_bloqueio)
                {
                    case 0: // inatividade
                        this.lbl_Motivo_Bloqueio.ForeColor = Color.Black;
                        break;
                    case 1: // Tentativa Excedida
                        this.lbl_Motivo_Bloqueio.ForeColor = Color.BlueViolet;
                        break;
                    case 2: // Senha Expirada
                        this.lbl_Motivo_Bloqueio.ForeColor = Color.Maroon;
                        break;
                }

            }
            else
            {
                this.lbl_Status.ForeColor = Color.DarkBlue;
                this.lbl_Motivo_Bloqueio.Text = "";
                this.lbl_Motivo_Bloqueio.ForeColor = Color.Black;
            }
            this.txt_IDUSER.Text = vUsu.id_usu;
            this.txt_NMUsu.Text = vUsu.nm_usu;
            this.txt_Email.Text = vUsu.ds_email;
            if (vUsu.dt_last_login.HasValue)
            {
                this.lbl_DtLastLogin.Text = DTLASTLOGIN + ": " + vUsu.dt_last_login.Value.ToString("dd/MM/yyyy");
            }
            else
            {
                this.lbl_DtLastLogin.Text = "";
            }
            this.lbl_ID_Usu_Incl.Text = vUsu.id_usu_incl;
            if (vUsu.dt_inclusao.HasValue)
            {
                this.lbl_Dt_Inclusao.Text = vUsu.dt_inclusao.Value.ToString("dd/MM/yyyy");
            }
            else
            {
                this.lbl_Dt_Inclusao.Text = "";
            }
            this.lbl_ID_Usu_Incl.Text = vUsu.id_usu_alt;
            if (vUsu.dt_alteracao.HasValue)
            {
                this.lbl_Dt_Alteracao.Text = vUsu.dt_alteracao.Value.ToString("dd/MM/yyyy");
            }
            else
            {
                this.lbl_Dt_Alteracao.Text = "";
            }
            if (vUsu.qtd_login_sem_sucesso.HasValue)
            {
                this.lbl_QTD_LOGIN_SEM_SUCESSO.Text = QTDLOGINSEMSUCESSO + vUsu.qtd_login_sem_sucesso.Value.ToString();
                if (vUsu.qtd_login_sem_sucesso >= 2)
                {
                    this.lbl_QTD_LOGIN_SEM_SUCESSO.ForeColor = Color.Maroon;
                }
                else
                {
                    this.lbl_QTD_LOGIN_SEM_SUCESSO.ForeColor = Color.Black;
                }

            }
            else
            {
                this.lbl_QTD_LOGIN_SEM_SUCESSO.Text = "";
                this.lbl_QTD_LOGIN_SEM_SUCESSO.ForeColor = Color.Black;
            }
            vbExecuta = CarregaOrgsAssociadasUsu(vUsu.id_usu);
            vbExecuta = CarregaPapelAssociadoUSu(vUsu.id_usu);

            return vbExecuta;

        }
        public Boolean HabilitaBotoes(int pCOmando)
        {
            switch (pCOmando)
            {
                case iRegNovo:
                    this.btnNovo.Enabled = false;
                    this.btnEditar.Enabled = false;
                    this.btnCriar.Enabled = true;
                    this.btnAtivar.Enabled = false;
                    this.btnDesativar.Enabled = false;
                    this.btnSenha.Enabled = false;
                    this.btnGravar.Enabled = false;
                    this.btnInclueAssociacao.Enabled = true;
                    this.btnRetiraAssociacao.Enabled = true;
                    this.btnAssociaUsu.Enabled = true;
                    this.btnREtiraAssociaOrgUsu.Enabled = true;
                    break;
                case iRegAlterar:
                    this.btnNovo.Enabled = false;
                    this.btnEditar.Enabled = false;
                    this.btnCriar.Enabled = false;
                    this.btnAtivar.Enabled = StatusUsrBloqueadoInatividadeTentivaExcedida();
                    this.btnDesativar.Enabled = !StatusUsrBloqueadoInatividadeTentivaExcedida();
                    this.btnSenha.Enabled = true;
                    this.btnGravar.Enabled = true;
                    this.btnInclueAssociacao.Enabled = true;
                    this.btnRetiraAssociacao.Enabled = true;
                    this.btnAssociaUsu.Enabled = true;
                    this.btnREtiraAssociaOrgUsu.Enabled = true;
                    break;
                case iRegCriar:
                    this.btnNovo.Enabled = true;
                    this.btnEditar.Enabled = true;
                    this.btnCriar.Enabled = false;
                    this.btnAtivar.Enabled = false;
                    this.btnDesativar.Enabled = false;
                    this.btnSenha.Enabled = false;
                    this.btnGravar.Enabled = false;
                    this.btnInclueAssociacao.Enabled = false;
                    this.btnRetiraAssociacao.Enabled = false;
                    this.btnAssociaUsu.Enabled = false;
                    this.btnREtiraAssociaOrgUsu.Enabled = false;
                    break;
                case iRegAtivar:
                    this.btnNovo.Enabled = true;
                    this.btnEditar.Enabled = true;
                    this.btnCriar.Enabled = false;
                    this.btnAtivar.Enabled = false;
                    this.btnDesativar.Enabled = false;
                    this.btnSenha.Enabled = false;
                    this.btnGravar.Enabled = false;
                    this.btnInclueAssociacao.Enabled = false;
                    this.btnRetiraAssociacao.Enabled = false;
                    this.btnAssociaUsu.Enabled = false;
                    this.btnREtiraAssociaOrgUsu.Enabled = false;
                    break;
                case iRegDesativar:
                    this.btnNovo.Enabled = true;
                    this.btnEditar.Enabled = true;
                    this.btnCriar.Enabled = false;
                    this.btnAtivar.Enabled = false;
                    this.btnDesativar.Enabled = false;
                    this.btnSenha.Enabled = false;
                    this.btnGravar.Enabled = false;
                    this.btnInclueAssociacao.Enabled = false;
                    this.btnRetiraAssociacao.Enabled = false;
                    this.btnAssociaUsu.Enabled = false;
                    this.btnREtiraAssociaOrgUsu.Enabled = false;
                    break;
                case iSenha:

                    this.btnNovo.Enabled = true;
                    this.btnEditar.Enabled = true;
                    this.btnCriar.Enabled = false;
                    this.btnAtivar.Enabled = false;
                    this.btnDesativar.Enabled = false;
                    this.btnSenha.Enabled = false;
                    this.btnGravar.Enabled = false;
                    this.btnInclueAssociacao.Enabled = false;
                    this.btnRetiraAssociacao.Enabled = false;
                    this.btnAssociaUsu.Enabled = false;
                    this.btnREtiraAssociaOrgUsu.Enabled = false;
                    break;

            }
            return true;

        }
        public Boolean StatusUsrBloqueadoInatividadeTentivaExcedida()
        {
            Boolean vbTeste = false;
            vbTeste = (UsuDetalhe.ind_bloqueado == vSisUsuNeg.sUsuarioBloqueado);
            vbTeste = StatusUsuarioExpirado(vbTeste);
            return vbTeste;
        }
        private Boolean StatusUsuarioExpirado(Boolean pbTeste)
        {
            Boolean vbTeste = pbTeste;
            if (UsuDetalhe.ind_motivo_bloqueio == vSisUsuNeg.iSenhaExpirada)
            {
                vbTeste = !pbTeste;
            }
            return vbTeste;
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            if (bModoPreGravacao)
            {
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result = new DialogResult();
                if (Comando == iInsert)
                {
                    result = MessageBox.Show("Deseja Criar Usuário?", "Sem Salvar", buttons, Alert);
                    if (result == DialogResult.Yes)
                    {
                        var bSalvar = RegCriar();
                    }
                }
                else
                {
                    result = MessageBox.Show("Deseja Salvar?", "Sem Salvar", buttons, Alert);
                    if (result == DialogResult.Yes)
                    {
                        var bSalvar = RegSalvar();
                    }
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

        public Boolean ValidaCamposTela()
        {
            Boolean bValida = true;
            MessageBoxButtons buttons = MessageBoxButtons.OK;
            DialogResult result = new DialogResult();

            if (this.txt_IDUSER.Text == null)
            {
                result = MessageBox.Show("User ID Obrigatório", "Erro de Validação", buttons, Error);
                this.txt_IDUSER.Focus();
                return false;
            }
            if (this.txt_NMUsu.Text == null)
            {
                result = MessageBox.Show("Nome do Usuário Obrigatório", "Erro de Validação", buttons, Error);
                this.txt_NMUsu.Focus();
                return false;
            }
            if (this.txt_Email == null)
            {
                result = MessageBox.Show("Email Obrigatório", "Erro de Validação", buttons, Error);
                this.txt_Email.Focus();
                return false;

            }
            else
            {
                bValida = (this.txt_Email.Text.Contains("@"));
                if (!bValida)
                {
                    result = MessageBox.Show("Email Inválido", "Erro de Validação", buttons, Error);
                    this.txt_Email.Focus();
                }
            }
            if (this.DtvOrgUsu.Rows.Count < 1)
            {
                buttons = MessageBoxButtons.YesNo;
                result = MessageBox.Show("Não Há Orgs Associadas Deseja Continuar?", "Papel Sem Orgs Associadas", buttons, iWarning);
                if (result == DialogResult.No)
                {
                    return false;
                }
            }
            if (this.dtvUserPapel.Rows.Count < 1)
            {
                buttons = MessageBoxButtons.YesNo;
                result = MessageBox.Show("Não Há Papeis Associados Deseja Continuar?", "Papel Sem Orgs Associadas", buttons, iWarning);
                if (result == DialogResult.No)
                {
                    return false;
                }
            }
            return bValida;
        }

        public Boolean HabilitaCamposTela()
        {
            this.txt_IDUSER.Enabled = true;
            this.txt_NMUsu.Enabled = true;
            this.txt_Email.Enabled = true;
            return true;
        }

        public Boolean DesabilitaCamposTela()
        {
            this.txt_IDUSER.Enabled = false;
            this.txt_NMUsu.Enabled = false;
            this.txt_Email.Enabled = false;
            return true;
        }

        public Boolean RegCriar()
        {
            Boolean vbValida = ValidaCamposTela();
            if (!vbValida)
            {
                return vbValida;
            }
            UsuDetalhe.id_usu = this.txt_IDUSER.Text;
            vbValida = vSisUsuNeg.VerificaExistenciaUsuario(UsuDetalhe.id_usu, ref vBanco);
            if (vbValida)
            {
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                DialogResult result = new DialogResult();
                result = MessageBox.Show("Usuário " + UsuDetalhe.id_usu + " existente.", "Erro de Validação", buttons, Error);
                this.txt_IDUSER.Focus();
                return false;
            }
            vbValida = true;
            UsuDetalhe.nm_usu = this.txt_NMUsu.Text;
            UsuDetalhe.ds_email = this.txt_Email.Text;
            UsuDetalhe.id_usu_incl = vIdUsu;
            vbValida = vSisUsuNeg.CriaUsuario(UsuDetalhe, ref vBanco);
            vbValida = vUorgNEG.bAssociaUsuarioOrg(ref vBanco, new List<SisUsuarioOrganizacao>(), MontaRegListUsuOrg());
            vbValida = vPusuNEG.AssociaPapelUsuario(ref vBanco, new List<SisPapelUsuario>(), MontaListaRegListUSuPapel());
            vbValida = AtualizaAssociacaoOrgPapel();
            vbValida = LoadGeral();

            return vbValida;

        }
        public Boolean AtualizaAssociacaoOrgPapel()
        {
            int vTotRowCount;
            int VtotRC;
            SisOrganizacaoPapelUsuarioNEG vsOrgPapUsuNEG = new SisOrganizacaoPapelUsuarioNEG();
            Boolean vbExiste = true;
            List<SisOrganizacaoPapelUsuario> lOPusu = new List<SisOrganizacaoPapelUsuario>();
            if (this.DtvOrgUsu.Rows.Count > 0)
            {
                vTotRowCount = this.DtvOrgUsu.Rows.Count;
                for (int linha = 0; linha < vTotRowCount; linha++)
                {
                    int iIdOrg = Convert.ToInt32(this.DtvOrgUsu.Rows[linha].Cells[0].Value);
                    if (this.dtvUserPapel.Rows.Count > 0)
                    {
                        VtotRC = this.dtvUserPapel.Rows.Count;
                        for (int reg = 0; reg < VtotRC; linha++)
                        {
                            string vsPapel = this.dtvUserPapel.Rows[reg].Cells[0].Value.ToString();
                            vbExiste = vsOrgPapUsuNEG.UsuarioAssociadoORgPapel(ref vBanco, iIdOrg, this.txt_IDUSER.Text, vsPapel);
                            if (!vbExiste)
                            {
                                var vSisOrganizacaoPapelUsuario = new SisOrganizacaoPapelUsuario();
                                vSisOrganizacaoPapelUsuario.ID_ORG = iIdOrg;
                                vSisOrganizacaoPapelUsuario.ID_PAPEL = vsPapel;
                                vSisOrganizacaoPapelUsuario.ID_USU = this.txt_IDUSER.Text;
                                vSisOrganizacaoPapelUsuario.ID_USU_INCL = vIdUsu;
                                vSisOrganizacaoPapelUsuario.DT_INCLUSAO = DateTime.Now;
                                lOPusu.Add(vSisOrganizacaoPapelUsuario);
                            }
                        }
                    }
                }
                if (lOPusu.Count > 0)
                {
                    vbExiste = vsOrgPapUsuNEG.RealizaAssociacaoUsuario(ref vBanco, lOPusu);
                }
            }
            return vbExiste;
        }
        public Boolean AtualizaListaOrg(List<SisUsuarioOrganizacao> Pusu)
        {
            var vbReturn = true;
            if (vListUORG.Count > Pusu.Count)
            {
                vbReturn = vUorgNEG.bDesassociaUsuarioOrg(ref vBanco, vListUORG, Pusu);
            }
            else if (vListUORG.Count < Pusu.Count)
            {
                vbReturn = vUorgNEG.bAssociaUsuarioOrg(ref vBanco, vListUORG, Pusu);
            }
            return vbReturn;
        }

        public Boolean RegSalvar()
        {
            Boolean vbValida = ValidaCamposTela();
            var LocalListUorg = MontaRegListUsuOrg();
            var LocalListUPap = MontaListaRegListUSuPapel();

            UsuDetalhe.nm_usu = this.txt_NMUsu.Text;
            UsuDetalhe.ds_email = this.txt_Email.Text;
            UsuDetalhe.dt_alteracao = DateTime.Now;
            UsuDetalhe.id_usu_alt = vIdUsu;

            vbValida = vSisUsuNeg.AlteraDadosUsuario(UsuDetalhe, ref vBanco);
            vbValida = AtualizaListaOrg(LocalListUorg);
            vbValida = LoadGeral();


            return true;
        }
        public Boolean AtualizaListaPapel(List<SisPapelUsuario> PUorg)
        {
            var vbReturn = true;
            if (vListPUSU.Count < PUorg.Count)
            {
                vbReturn = vPusuNEG.AssociaPapelUsuario(ref vBanco, vListPUSU, PUorg);
            }
            else if (vListPUSU.Count > PUorg.Count)
            {
                vbReturn = vPusuNEG.DesassociaPapelUsuario(ref vBanco, vListPUSU, PUorg);
            }
            return vbReturn;
        }
        public List<SisPapelUsuario> MontaListaRegListUSuPapel()
        {
            List<SisPapelUsuario> vListSisPapelUsuario = new List<SisPapelUsuario>();
            int vTotCountRow = 0;
            if (this.dtvUserPapel.Rows.Count > 0)
            {
                vTotCountRow = this.dtvUserPapel.Rows.Count;
                for (int linha = 0; linha < vTotCountRow; linha++)
                {
                    var vSisPUSU = new SisPapelUsuario();
                    vSisPUSU.ID_PAPEL = this.dtvUserPapel.Rows[linha].Cells[0].Value.ToString();
                    vSisPUSU.ID_USU = this.txt_IDUSER.Text;
                    vListSisPapelUsuario.Add(vSisPUSU);
                }
            }
            return vListSisPapelUsuario;
        }
        public List<SisUsuarioOrganizacao> MontaRegListUsuOrg()
        {
            List<SisUsuarioOrganizacao> vListSisUsuarioOrganizacoes = new List<SisUsuarioOrganizacao>();
            int vTotCountRow = 0;

            if (this.DtvOrgUsu.Rows.Count > 0)
            {
                vTotCountRow = this.DtvOrgUsu.Rows.Count;
                for (int linha = 0; linha < vTotCountRow; linha++)
                {
                    var vSisUORG = new SisUsuarioOrganizacao();
                    vSisUORG.ID_ORG = Convert.ToInt32(this.DtvOrgUsu.Rows[linha].Cells[0].Value);
                    vSisUORG.ID_USU = this.txt_IDUSER.Text;
                    vSisUORG.ID_USU_INCL = vIdUsu;
                    vListSisUsuarioOrganizacoes.Add(vSisUORG);
                }
            }

            return vListSisUsuarioOrganizacoes;
        }

        private void dtvUsers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Boolean vbLoad;

            vbLoad = LoadReg(null, this.dtvUsers.CurrentRow.Cells[0].Value.ToString());
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

        private void btnCriar_Click(object sender, EventArgs e)
        {
            var Habilita = RegCriar();
            if (Habilita)
            {
                Habilita = HabilitaBotoes(iRegCriar);
                Habilita = DesabilitaCamposTela();
                bModoPreGravacao = false;
                //Habilita = LimpaTela();
            }
        }


        private void btnAtivar_Click(object sender, EventArgs e)
        {
            var Habilita = RegAtivar();
            if (Habilita)
            {
                Habilita = HabilitaBotoes(iRegAtivar);
                Habilita = DesabilitaCamposTela();
                Habilita = LoadReg(null, this.txt_IDUSER.Text);
                bModoPreGravacao = false;
                //Habilita = LimpaTela();
            }
        }
        public Boolean RegAtivar()
        {
            var vSisUsuario = new SisUsuario();

            vSisUsuario.id_usu = this.txt_IDUSER.Text;
            return vSisUsuNeg.RealizaDesbloqueio(vSisUsuario, ref vBanco);
        }

        private void btnDesativar_Click(object sender, EventArgs e)
        {
            var Habilita = RegDesativar();
            if (Habilita)
            {
                Habilita = HabilitaBotoes(iRegDesativar);
                Habilita = DesabilitaCamposTela();
                Habilita = LoadReg(null, this.txt_IDUSER.Text);
                bModoPreGravacao = false;
                //Habilita = LimpaTela();
            }
        }

        public Boolean RegDesativar()
        {
            var vSisUsuario = new SisUsuario();
            vSisUsuario.id_usu = this.txt_IDUSER.Text;
            return vSisUsuNeg.BloqueiaUsuario(vSisUsuario, ref vBanco, vSisUsuNeg.iInatividade);
        }

        private void btnSenha_Click(object sender, EventArgs e)
        {
            var Habilita = RegNovaSenha();
            if (Habilita)
            {
                Habilita = HabilitaBotoes(iSenha);
                Habilita = DesabilitaCamposTela();
                Habilita = LoadReg(null, this.txt_IDUSER.Text);
                bModoPreGravacao = false;
                //Habilita = LimpaTela();
            }
        }

        public Boolean RegNovaSenha()
        {
            var vSisUsuario = new SisUsuario();
            vSisUsuario.id_usu = this.txt_IDUSER.Text;
            return vSisUsuNeg.GeraNovaSenha(vSisUsuario, ref vBanco);
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
                DialogResult result = new DialogResult();
                if (Comando == iInsert)
                {
                    result = MessageBox.Show("Deseja Criar Usuário?", "Sem Salvar", buttons, Alert);
                    if (result == DialogResult.Yes)
                    {
                        var bSalvar = RegCriar();
                    }
                }
                else
                {
                    result = MessageBox.Show("Deseja Salvar?", "Sem Salvar", buttons, Alert);
                    if (result == DialogResult.Yes)
                    {
                        var bSalvar = RegSalvar();
                    }
                }

            }
            this.Dispose();
        }
    }
}
