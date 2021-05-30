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
        private CorOrganizacaoNEG vCorOrgNEG = new CorOrganizacaoNEG();
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
            listCorOrganizacao = vCorOrgNEG.ObtemListaOrg(ref vBanco, vIdUsu);
            bExecuta = CarregaBarraStatus();
            bExecuta = AlimentaTreeListOrg();
        }
        private Boolean CarregaBarraStatus()
        {
            this.tstlUsuario.Text = "Usuário:  " + vIdUsu;
            this.tstlOrgSelecionadaNumero.Text = "Org:   " + vIdOrg.ToString("000");
            this.tstl_OrgDEscricao.Text = " - " + vNmOrg;
            this.TstlPapel.Text = "Papel:  " + vDsPapel;


            return true;
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
        private Boolean AlimentaTreeListOrg()
        {

            int inDexFilho = 1;
            this.trvOrgs.Nodes.Clear();
            TreeNode rootNodes = trvOrgs.Nodes.Add("Organizações");
            var ApenasOrganizacoesSemMae = listCorOrganizacao.FindAll(linhaOrgAdm => linhaOrgAdm.ID_ORG_MAE != null);
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
    }
}
