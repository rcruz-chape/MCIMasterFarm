using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MCIMasterFarm.Negocio.BackOffice.Negocio;
using MCIMasterFarm.Negocio.BackOffice.Model;
using MCIMasterFarm.Negocio.BackOffice.DadosAcesso;
using MCIMasterFarm.Negocio.BackOffice.DAL;
using MCIMasterFarm.Negocio.Global;
using MCISYS.Negocio.BackOffice.Model;
using MCISYS.Negocio.BackOffice.DAL;
using MCISYS.Negocio.BackOffice.Negocio;
using MCISYS.Negocio.BackOffice;
using MCIMasterFarm.Negocio.BackOffice;


namespace MCISYS.Negocio.Telas
{
    public partial class Frm_Associa : Form
    {
        public const int AssociaORGPapel = 1;
        public const int AssociaORGUsuario = 2;
        private int vIdOrg = 0;
        private int vTipoAssociacao;
        private string vIdUsu;
        private string vIdPapel;
        private Banco vBanco = new Banco();
        public SisOrganizacaoPapel vSysOrg = new SisOrganizacaoPapel();
        public SisUsuarioOrganizacao vUorg = new SisUsuarioOrganizacao();
        public VwOrgPapel vSisPapel = new VwOrgPapel();
        public SisUsuario regUsu = new SisUsuario();
        public List<VwOrgPapel> ListPap = new List<VwOrgPapel>();
        public List<SisUsuario> ListUsu = new List<SisUsuario>();
        private ConfiguraControleNEG vControleNEG = new ConfiguraControleNEG();

        public Frm_Associa(ref Banco pBanco, int pIdTipoAssocia, int pIdOrg, string psIdUsu)
        {
            InitializeComponent();
            vTipoAssociacao = pIdTipoAssocia;
            vIdOrg = pIdOrg;
            vIdUsu = psIdUsu;
            vBanco = pBanco;
            this.lblOrg.Text = "Organização:  " + vIdOrg.ToString("000");
            if (vTipoAssociacao == AssociaORGPapel)
            {
                Boolean vbAssocia = bCOnfiguraAssociaPapel();
            }
            else if (vTipoAssociacao == AssociaORGUsuario)
            {
                Boolean vbAssocia = bCOnfiguraAssociaUsuario();
            }

        }

        public Boolean bCOnfiguraAssociaUsuario()
        {
            this.Text = "Associar Usuário a Org " + vIdOrg.ToString("000");
            this.lblCbx.Text = "Usuário:  ";
            this.grpBox.Text = "Associação de Usuário";
            var vSisUsuarioNEG = new SIS_USUARIO_NEG();
            ListUsu = vSisUsuarioNEG.ObtemListaUsuario(ref vBanco, vIdOrg, vIdUsu);
            this.cbxGeneral.DataSource = ListUsu;
            var Controle = vControleNEG.SetComboBox(cbxGeneral, nameof(regUsu.id_usu), nameof(regUsu.id_usu));

            return true;
        }
        public Boolean bCOnfiguraAssociaPapel()
        {
            this.Text = "Associar Papel a Org " + vIdOrg.ToString("00000");
            this.lblCbx.Text = "Papel:   ";
            this.grpBox.Text = "Associação de Papel";
            var VwOrgPapNEG = new VwOrgPapelNEG();
            ListPap = VwOrgPapNEG.ObtemListaPapeis(ref vBanco, vIdUsu, vIdOrg);

            this.cbxGeneral.DataSource = ListPap;
            var Controle = vControleNEG.SetComboBox(cbxGeneral, nameof(vSisPapel.DS_PAPEL), nameof(vSisPapel.ID_PAPEL));

            return true;
        }

        private void btnAssocia_Click(object sender, EventArgs e)
        {
            if (vTipoAssociacao == AssociaORGPapel)
            {
                vSysOrg.ID_ORG = vIdOrg;
                vSysOrg.ID_PAPEL = this.cbxGeneral.SelectedValue.ToString();
                vSysOrg.DS_PAPEL = ListPap.Find(linha => linha.ID_PAPEL == vSysOrg.ID_PAPEL).DS_PAPEL;
                vSysOrg.ID_USU_INCL = vIdUsu;
                vSysOrg.DT_INCLUSAO = DateTime.Now;
            }
            else if (vTipoAssociacao == AssociaORGUsuario)
            {
                vUorg.ID_ORG = vIdOrg;
                vUorg.ID_USU = this.cbxGeneral.SelectedValue.ToString();
                vUorg.ID_USU_INCL = vIdUsu;
                vUorg.DT_INCLUSAO = DateTime.Now;
            }
            this.DialogResult = DialogResult.OK;
            this.Dispose();
        }
    }
}
