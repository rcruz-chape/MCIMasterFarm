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
        public const int AssociaPapelOrg = 3;
        public const int AssociaPapelUsuario = 4;
        public const int AssociaUsuarioOrg = 5;
        public const int AssociaUsuarioPapel = 6;
        private int vIdOrg = 0;
        private int vTipoAssociacao;
        private string vIdUsu;
        private string vIdUsuSelecionado;
        private string vIdPapel;
        private Banco vBanco = new Banco();
        public SisOrganizacaoPapel vSysOrg = new SisOrganizacaoPapel();
        public SisUsuarioOrganizacao vUorg = new SisUsuarioOrganizacao();
        public VwPUsu vPUsu = new VwPUsu();
        public VwOrgPapel vSisPapel = new VwOrgPapel();
        public CorOrganizacao vOrg = new CorOrganizacao();
        public SisPapel vPapel = new SisPapel();
        public SisUsuario regUsu = new SisUsuario();
        public List<VwOrgPapel> ListPap = new List<VwOrgPapel>();
        public List<SisUsuario> ListUsu = new List<SisUsuario>();
        public List<SisPapel> ListPapel = new List<SisPapel>();
        public List<CorOrganizacao> ListOrg = new List<CorOrganizacao>();
        private ConfiguraControleNEG vControleNEG = new ConfiguraControleNEG();
        private CorOrganizacaoNEG vCorOrgNeg = new CorOrganizacaoNEG();
        private SisPapelNEG vPapNeg = new SisPapelNEG();
        public Frm_Associa(ref Banco pBanco, int pIdTipoAssocia, int pIdOrg = 0, string psIdUsu = "", string psIdPapel = "", string psIdUsuSelecionado = "")
        {
            InitializeComponent();
            vTipoAssociacao = pIdTipoAssocia;
            vIdOrg = pIdOrg;
            vIdUsu = psIdUsu;
            vBanco = pBanco;
            vIdPapel = psIdPapel;
            vIdUsuSelecionado = psIdUsuSelecionado;
            if (vTipoAssociacao == AssociaORGPapel || vTipoAssociacao == AssociaORGUsuario)
            {
                this.lblOrg.Text = "Organização:  " + vIdOrg.ToString("000");
            }
            else if (vTipoAssociacao == AssociaPapelOrg || vTipoAssociacao == AssociaPapelUsuario)
            {
                this.lblOrg.Text = "Papel:   " + vIdPapel;

            }
            else if (vTipoAssociacao == AssociaUsuarioOrg || vTipoAssociacao == AssociaUsuarioPapel)
            {
                this.lblOrg.Text = "Usuário:   " + vIdUsuSelecionado;

            }

            if (vTipoAssociacao == AssociaORGPapel || vTipoAssociacao == AssociaPapelOrg || vTipoAssociacao == AssociaUsuarioPapel)
            {
                Boolean vbAssocia = bCOnfiguraAssociaPapel();
            }
            else if (vTipoAssociacao == AssociaORGUsuario || vTipoAssociacao == AssociaPapelUsuario)
            {
                Boolean vbAssocia = bCOnfiguraAssociaUsuario();
            }

            else if (vTipoAssociacao == AssociaUsuarioOrg)
            {
                Boolean vbAssocia = bCOnfiguraAssociaORg();
            }
        }
        public Boolean bCOnfiguraAssociaORg()
        {
            this.Text = "Associar Org ao Usuário " + vIdUsuSelecionado;
            this.lblCbx.Text = "Org:  ";
            this.grpBox.Text = "Associação de Organizações";
            ListOrg = vCorOrgNeg.ObtemListaOrg(ref vBanco, vIdUsu);
            this.cbxGeneral.DataSource = ListOrg;
            var Controle = vControleNEG.SetComboBox(cbxGeneral, nameof(vOrg.NM_ORG), nameof(vOrg.ID_ORG));

            return true;


        }

        public Boolean bCOnfiguraAssociaUsuario()
        {
            if (vTipoAssociacao == AssociaORGUsuario)
            {
                this.Text = "Associar Usuário a Org: " + vIdOrg.ToString("000");
            }
            else
            {
                this.Text = "Associar Usuário ao Papel: " + vIdPapel; 
            }
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
            
            if (vTipoAssociacao == AssociaORGPapel)
            {
                this.Text = "Associar Papel a Org " + vIdOrg.ToString("00000");
                this.lblCbx.Text = "Papel:   ";
                this.grpBox.Text = "Associação de Papel";
                vOrg = vCorOrgNeg.OrgSelecionada(ref vBanco, vIdOrg);
                var VwOrgPapNEG = new VwOrgPapelNEG();
                

                if (vOrg.TP_ORG == vCorOrgNeg.ADMINISTRATIVA)
                {
                    ListPap = VwOrgPapNEG.ObtemListaPapeis(ref vBanco, vIdUsu, vIdOrg, 0);
                }
                else
                {
                    ListPap = VwOrgPapNEG.ObtemListaPapeis(ref vBanco, vIdUsu, vIdOrg,1);
                }

                this.cbxGeneral.DataSource = ListPap;
                var Controle = vControleNEG.SetComboBox(cbxGeneral, nameof(vSisPapel.DS_PAPEL), nameof(vSisPapel.ID_PAPEL));

            }
            else if (vTipoAssociacao == AssociaPapelOrg)
            {
                this.Text = "Associar Organização ao Papel " + vIdPapel;
                this.lblCbx.Text = "Organização:   ";
                this.grpBox.Text = "Associação de ORGs";
                vPapel = vPapNeg.ObtemPapelSelecionado(ref vBanco, vIdPapel);
                ListOrg = vCorOrgNeg.ObtemListaOrg(ref vBanco, vIdUsu);

                if (vPapel.TP_PAPEL == 0)
                {
                    ListOrg = ListOrg.FindAll(Org => Org.TP_ORG == vCorOrgNeg.ADMINISTRATIVA);
                }
                else if(vPapel.TP_PAPEL == 1)
                {
                    ListOrg = ListOrg.FindAll(Org => Org.TP_ORG == vCorOrgNeg.TOPERACIONAL);
                }

                this.cbxGeneral.DataSource = ListOrg;
                var Controle = vControleNEG.SetComboBox(cbxGeneral, nameof(vOrg.NM_ORG_RESUMIDO), nameof(vOrg.ID_ORG));

            } else
            {
                this.Text = "Associar Papel ao Usuário " + vIdUsuSelecionado;
                this.lblCbx.Text = "Papel:   ";
                this.grpBox.Text = "Associação de Papel";
                var VwPapel = new SisPapelNEG();
                ListPapel = VwPapel.ObtemTodosPapeis(ref vBanco);

                this.cbxGeneral.DataSource = ListPapel;
                var Controle = vControleNEG.SetComboBox(cbxGeneral, nameof(vSisPapel.DS_PAPEL), nameof(vSisPapel.ID_PAPEL));

            }


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
            else if (vTipoAssociacao == AssociaPapelUsuario)
            {
                vPUsu.ID_PAPEL = vIdPapel;
                vPUsu.ID_USU = this.cbxGeneral.SelectedValue.ToString();
                vPUsu.ID_USU_INCL = vIdUsu;
                vPUsu.DT_INCLUSAO = DateTime.Now;
            }
            else if (vTipoAssociacao == AssociaPapelOrg)
            {

                vSysOrg.ID_ORG = Convert.ToInt32(this.cbxGeneral.SelectedValue.ToString());
                vSysOrg.ID_PAPEL = vIdPapel;
                vSysOrg.NM_ORG = ListOrg.Find(linha => linha.ID_ORG == vSysOrg.ID_ORG).NM_ORG_RESUMIDO;
                vSysOrg.ID_USU_INCL = vIdUsu;
                vSysOrg.DT_INCLUSAO = DateTime.Now;
            }

            else if (vTipoAssociacao == AssociaUsuarioOrg)
            {
                vUorg.ID_ORG = Convert.ToInt32(this.cbxGeneral.SelectedValue.ToString());
                vUorg.ID_USU = vIdUsuSelecionado;
                vUorg.ID_USU_INCL = vIdUsu;
                vUorg.DT_INCLUSAO = DateTime.Now;
            }

            else if (vTipoAssociacao == AssociaUsuarioPapel)
            {
                vPUsu.ID_PAPEL = this.cbxGeneral.SelectedValue.ToString();
                vPUsu.ID_USU = vIdUsuSelecionado;
                vPUsu.ID_USU_INCL = vIdUsu;
                vPUsu.DT_INCLUSAO = DateTime.Now;
            }


            this.DialogResult = DialogResult.OK;
            this.Dispose();
        }
    }
}
