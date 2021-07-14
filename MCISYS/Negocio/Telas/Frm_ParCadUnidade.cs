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

        public CorUnidadeMedidaNEG vCorUnidadeMedidaNEG = new CorUnidadeMedidaNEG();
        private CorUnidadeMedida vCorUnidadeMedida = new CorUnidadeMedida();
        private List<CorUnidadeMedida> vListCorUnidadeMedida = new List<CorUnidadeMedida>();

        public Frm_ParCadUnidade(ref Banco pBanco
                                      ,int pIdOrg
                                   ,string pIdPapel
                                   ,string pIdUSU
                                   ,string pNmOrg
                                   ,string pDSPApel)
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
            vbInsert = DesabilitaCampos();
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
            foreach(var registro in vListCorUnidadeMedida)
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
        private Boolean HabilitaCampos()
        {
            this.txtb_CodUm.Enabled = true;
            this.txtb_DescUm.Enabled = true;
            return true;
        }
        private Boolean DesabilitaCampos()
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



    }
}
