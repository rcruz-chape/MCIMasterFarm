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
    public partial class Frm_ParCadUnidade : Form
    {
        private Banco vBanco = new Banco();
        private int vIdOrg;
        private string vIdPapel;
        private string vIdUsu;
        private string vNmOrg;
        private string vDsPapel;
        private string vCodUm;
        public const int iInsert = 1;
        public const int iUpdate = 2;
        public const int iRegNovo = 1;
        public const int iRegAlterar = 2;
        public const int iRegExcluir = 3;
        public const int iRegPesquisar = 4;
        public const int iRegGravar = 5;
        public const string FormatOrg = "000";
        public Boolean bModoPreGravacao;
        private Boolean bExecuta;
        private int Comando;

        private MessageBoxIcon Alert = MessageBoxIcon.Question;

        public CorUnidadeMedidaNEG vCorUnidadeMedidaNEG = new CorUnidadeMedidaNEG();
        private CorUnidadeMedida vCorUnidadeMedida = new CorUnidadeMedida();
        private List<CorUnidadeMedida> vListCorUnidadeMedida = new List<CorUnidadeMedida>();

        public Frm_ParCadUnidade(ref Banco pBanco
                                      , int pIdOrg
                                   , string pIdPapel
                                   , string pIdUSU
                                   , string pNmOrg
                                   , string pDSPApel)
        {
            InitializeComponent();
            vBanco = pBanco;
            vIdOrg = pIdOrg;
            vIdPapel = pIdPapel;
            vIdUsu = pIdUSU;
            vNmOrg = pNmOrg;
            vDsPapel = pDSPApel;
            Boolean vbInsert = CarregaBarraStatus();
            vbInsert = PesquisaReg(true);
            vbInsert = DesabilitaCamposTela();
        }

        private Boolean CarregaBarraStatus()
        {
            this.tstlUsuario.Text = vIdUsu;
            this.tstlOrgSelecionadaNumero.Text = vIdOrg.ToString(FormatOrg);
            this.tstl_OrgDEscricao.Text = vNmOrg;
            this.TstlPapel.Text = vDsPapel;
            return true;
        }

        private Boolean ListaCorUnidadeMedida()
        {
            vListCorUnidadeMedida = vCorUnidadeMedidaNEG.Obtem_ListaUM(ref vBanco, vIdOrg);
            foreach (var registro in vListCorUnidadeMedida)
            {
                this.dGv_Um.Rows.Add(registro.COD_UM, registro.DESC_UM);
            }
            return (vListCorUnidadeMedida.Count > 0);
        }
        private Boolean PesquisaReg(Boolean pPesquisaLista = false)
        {
            Boolean vbReg = true;
            vbReg = LimpaTela(pPesquisaLista);
            if (pPesquisaLista)
            {
                vbReg = ListaCorUnidadeMedida();
            }
            if (vbReg)
            {
                if (this.dGv_Um.CurrentRow == null)
                {
                    this.dGv_Um.CurrentCell = this.dGv_Um[0, 0];
                }
                vCodUm = this.dGv_Um.CurrentRow.Cells[0].Value.ToString();
                vCorUnidadeMedida = vCorUnidadeMedidaNEG.Obtem_UM(ref vBanco, vIdOrg, vCodUm);
                vbReg = LoadReg(vCorUnidadeMedida);
            }
            return vbReg;
        }

        private Boolean LoadReg(CorUnidadeMedida pCorUnidadeMedida)
        {
            this.txtb_CodUm.Text = pCorUnidadeMedida.COD_UM;
            this.txtb_DescUm.Text = pCorUnidadeMedida.DESC_UM;
            this.lbl_ID_Usu_Incl.Text = pCorUnidadeMedida.ID_USU_INCL;
            this.lbl_Id_Usu_Alterado.Text = pCorUnidadeMedida.ID_USU_ALT;
            this.lbl_Dt_Inclusao.Text = pCorUnidadeMedida.DT_INCLUSAO.ToString("dd/MM/yyyy");
            if (pCorUnidadeMedida.DT_ALTERACAO.HasValue)
            {
                this.lbl_Dt_Alteracao.Text = pCorUnidadeMedida.DT_ALTERACAO.Value.ToString("dd/MM/yyyy");
            }
            return true;
        }
        private Boolean HabilitaCamposTela()
        {
            this.txtb_CodUm.Enabled = true;
            this.txtb_DescUm.Enabled = true;
            return true;
        }
        private Boolean DesabilitaCamposTela()
        {
            this.txtb_CodUm.Enabled = false;
            this.txtb_DescUm.Enabled = false;
            return true;
        }
        private Boolean LimpaTela(Boolean bLimpaTabela = false)
        {
            this.txtb_CodUm.Text = "";
            this.txtb_DescUm.Text = "";
            this.lbl_Dt_Alteracao.Text = "";
            this.lbl_Dt_Inclusao.Text = "";
            this.lbl_Id_Usu_Alterado.Text = "";
            this.lbl_ID_Usu_Incl.Text = "";
            if (bLimpaTabela)
            {
                this.dGv_Um.Rows.Clear();
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

        public Boolean HabilitaBotoes(int pCOmando)
        {
            switch (pCOmando)
            {
                case iRegNovo:
                    this.btnNovo.Enabled = false;
                    this.btnEditar.Enabled = false;
                    this.btnExcluir.Enabled = true;
                    this.btnGravar.Enabled = true;
                    break;
                case iRegAlterar:
                    this.btnNovo.Enabled = false;
                    this.btnEditar.Enabled = false;
                    this.btnExcluir.Enabled = true;
                    this.btnGravar.Enabled = true;
                    break;
                case iRegGravar:
                    this.btnNovo.Enabled = true;
                    this.btnEditar.Enabled = true;
                    this.btnExcluir.Enabled = false;
                    this.btnGravar.Enabled = false;
                    break;
                case iRegExcluir:
                    this.btnNovo.Enabled = true;
                    this.btnEditar.Enabled = true;
                    this.btnExcluir.Enabled = false;
                    this.btnGravar.Enabled = false;
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
        public Boolean RegSalvar()
        {
            CorUnidadeMedida vCorUnidadeMedida = new CorUnidadeMedida();
            MessageBoxIcon iError = MessageBoxIcon.Error;
            MessageBoxIcon iWarning = MessageBoxIcon.Warning;
            Boolean bAcao;
            if (this.txtb_CodUm.Text == "")
            {
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                DialogResult result = MessageBox.Show("Código da Unidade Obrigatória.", "Erro de Validação", buttons, iError);
                this.txtb_CodUm.Focus();
                return false;
            }
            
            if (this.txtb_DescUm.Text == "")
            {
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                DialogResult result = MessageBox.Show("Descrição da Unidade Obrigatória.", "Erro de Validação", buttons, iError);
                this.txtb_DescUm.Focus();
                return false;
            }
            switch(Comando)
            {
                case iInsert:
                    bAcao = vCorUnidadeMedidaNEG.bExisteCorUnidade(ref vBanco, vIdOrg, this.txtb_CodUm.Text);
                    if (bAcao)
                    {
                        MessageBoxButtons buttons = MessageBoxButtons.OK;
                        DialogResult result = MessageBox.Show("Unidade Informada já está cadastrada.", "Erro de Validação", buttons, iError);
                        this.txtb_CodUm.Focus();
                        return false;
                    }
                    vCorUnidadeMedida.ID_ORG = vIdOrg;
                    vCorUnidadeMedida.COD_UM = this.txtb_CodUm.Text;
                    vCorUnidadeMedida.DESC_UM = this.txtb_DescUm.Text;
                    vCorUnidadeMedida.ID_USU_INCL = vIdUsu;
                    vCorUnidadeMedida.DT_INCLUSAO = DateTime.Now;
                    bAcao = vCorUnidadeMedidaNEG.Insere_UM(ref vBanco, vCorUnidadeMedida);
                    break;
                case iUpdate:
                    vCorUnidadeMedida.ID_ORG = vIdOrg;
                    vCorUnidadeMedida.COD_UM = this.txtb_CodUm.Text;
                    vCorUnidadeMedida.DESC_UM = this.txtb_DescUm.Text;
                    vCorUnidadeMedida.ID_USU_ALT = vIdUsu;
                    vCorUnidadeMedida.DT_ALTERACAO = DateTime.Now;
                    bAcao = vCorUnidadeMedidaNEG.Atualiza_UM(ref vBanco, vCorUnidadeMedida);
                    break;
            }
            return PesquisaReg(true);
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
            switch (Comando)
            {
                case iRegAlterar:
                    {
                        MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                        DialogResult result = MessageBox.Show("Deseja Excluir a Unidade de Medida?", "Exclusão", buttons);
                        if (result == DialogResult.Yes)
                        {
                            bExcluir = false;
                            string vMsg;
                            bExcluir = vCorUnidadeMedidaNEG.Exclue_UM(ref vBanco, vIdOrg, this.txtb_CodUm.Text); 
                            bExcluir = LimpaTela();
                            bExcluir = HabilitaBotoes(iRegExcluir);
                            bExcluir = DesabilitaCamposTela();

                        }
                        break;
                    }
                case iRegNovo:
                    {
                        MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                        DialogResult result = MessageBox.Show("Deseja Cancelar a Inclusão da Unidade?", "Cancelar", buttons);
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

        private void dGv_Um_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Boolean vbLoad;
            vCodUm = this.dGv_Um.CurrentRow.Cells[0].Value.ToString();
            vCorUnidadeMedida = vCorUnidadeMedidaNEG.Obtem_UM(ref vBanco, vIdOrg, vCodUm);
            vbLoad = LoadReg(vCorUnidadeMedida);
        }

        private void dGv_Um_KeyDown(object sender, KeyEventArgs e)
        {
            Boolean vbLoad;
            var tecla = e.KeyCode;
            int vIndexRow = 0;
            if (tecla == Keys.Enter)
            {
                vCodUm = this.dGv_Um.CurrentRow.Cells[0].Value.ToString();
            }
            else if (tecla == Keys.Up)
            {
                vIndexRow = this.dGv_Um.CurrentRow.Index;
                vIndexRow = this.dGv_Um.Rows.GetPreviousRow(vIndexRow, DataGridViewElementStates.None);
                if (vIndexRow > -1)
                {
                    vCodUm = this.dGv_Um.Rows[vIndexRow].Cells[0].Value.ToString();
                }
                else
                {
                    vIndexRow = this.dGv_Um.CurrentRow.Index;
                    vCodUm = this.dGv_Um.Rows[vIndexRow].Cells[0].Value.ToString();
                }
            }
            else if (tecla == Keys.Down)
            {
                vIndexRow = this.dGv_Um.CurrentRow.Index;
                vIndexRow = this.dGv_Um.Rows.GetNextRow(vIndexRow, DataGridViewElementStates.None);
                if (vIndexRow > -1)
                {
                    vCodUm = this.dGv_Um.Rows[vIndexRow].Cells[0].Value.ToString();
                }
                else
                {
                    vIndexRow = this.dGv_Um.CurrentRow.Index;
                    vCodUm = this.dGv_Um.Rows[vIndexRow].Cells[0].Value.ToString();
                }
            }


            vCorUnidadeMedida = vCorUnidadeMedidaNEG.Obtem_UM(ref vBanco, vIdOrg, vCodUm);
            vbLoad = LoadReg(vCorUnidadeMedida);
        }
    }
}
