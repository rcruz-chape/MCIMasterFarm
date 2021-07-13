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
        public const int iInsert = 1;
        public const int iUpdate = 2;
        public const int iRegNovo = 1;
        public const int iRegAlterar = 2;
        public const int iRegExcluir = 3;
        public const int iRegPesquisar = 4;
        public const int iRegGravar = 5;
        public const string FormatOrg = "000";
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
        }

        private Boolean CarregaBarraStatus()
        {
            this.tstlUsuario.Text = vIdUsu;
            this.tstlOrgSelecionadaNumero.Text = vIdOrg.ToString(FormatOrg);
            this.tstl_OrgDEscricao.Text = vNmOrg;
            this.TstlPapel.Text = vDsPapel;
            return true;
        }
    }
}
