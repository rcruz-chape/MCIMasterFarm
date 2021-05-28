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
        private Boolean bExecuta;

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
            
        }
        private Boolean CarregaBarraStatus()
        {
            this.tstlUsuario.Text = "Usuário:  " + vIdUsu;
            this.tstlOrgSelecionadaNumero.Text = "Org:   " + vIdOrg.ToString("000");
            this.tstl_OrgDEscricao.Text = " - " + vNmOrg;
            this.TstlPapel.Text = "Papel:  " + vDsPapel;


            return true;
        }
    }
}
