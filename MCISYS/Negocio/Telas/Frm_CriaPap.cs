using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
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
    public partial class Frm_CriaPap : Form
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

        private List<VwOrgPapel> ListPapel = new List<VwOrgPapel>();
        private List<VwPUsu> ListPapelUsu = new List<VwPUsu>();
        private List<SisOrganizacaoPapel> ListOrgPapel = new List<SisOrganizacaoPapel>();
        private List<SisPapelUsuario> ListPapUsu = new List<SisPapelUsuario>();
        private VwOrgPapelNEG vOrgPapelNEG = new VwOrgPapelNEG();
        private VwPUsuNEG vwPUsuNEG = new VwPUsuNEG();
        private SisOrganizacaoPapelNEG vSisOrganizacaoPapelNEG = new SisOrganizacaoPapelNEG();
        private List<CorOrganizacao> ListOrg = new List<CorOrganizacao>();
        private List<SisUsuario> ListUsu = new List<SisUsuario>();
        private SisPapel vSisPapel = new SisPapel();



        public const string PAPADM = "1";
        public const int iInsert = 1;
        public const int iUpdate = 2;
        public const int iRegNovo = 1;
        public const int iRegAlterar = 2;
        public const int iRegExcluir = 3;
        public const int iRegPesquisar = 4;
        public const int iRegGravar = 5;
        public const string FormatOrg = "000";

        public Frm_CriaPap(ref Banco pBanco, int pIdOrg, string pIdPapel,
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
            bExecuta = CarregaPapeis();
            bExecuta = CarregaOrgsAssociados();
            bExecuta = CarregaUsuAssociados();

        }
        private Boolean CarregaBarraStatus()
        {
            this.tstlUsuario.Text = "Usuário:  " + vIdUsu;
            this.tstlOrgSelecionadaNumero.Text = "Org:   " + vIdOrg.ToString(FormatOrg);
            this.tstl_OrgDEscricao.Text = " - " + vNmOrg;
            this.TstlPapel.Text = "Papel:  " + vDsPapel;
            return true;
        }

        public Boolean bConfiguraTituloDbGrid()
        {
            this.DtgOrg.Columns[0].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            this.DtgOrg.Columns[1].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleLeft;
            this.DtgOrg.Columns[2].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.DtgOrg.Columns[3].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            this.dGvUser.Columns[0].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.dGvUser.Columns[1].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.dGvUser.Columns[2].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;

            return true;
        }
        private Boolean CarregaUsuAssociados(string pIdPapel = "")
        {
            string vsIdPapel = pIdPapel;
            if (pIdPapel == "")
            {
                if (this.dgvPapel.CurrentRow == null)
                {
                    this.dgvPapel.CurrentCell = this.dgvPapel[0, 0];
                }

                vsIdPapel = this.dgvPapel.CurrentRow.Cells[0].Value.ToString();

            }
            this.dGvUser.Rows.Clear();
            ListPapelUsu = vwPUsuNEG.ObtemUsuariosAssociados(ref vBanco, vsIdPapel);
            if (ListPapelUsu.Count > 0)
            {
                foreach (var PapelUsu in ListPapelUsu)
                {
                    this.dGvUser.Rows.Add(PapelUsu.ID_USU, PapelUsu.ID_USU_INCL, PapelUsu.DT_INCLUSAO);
                }
            }
            return true;
        }
        private Boolean CarregaOrgsAssociados(string pIdPapel = "")
        {
            string vsIdPapel = pIdPapel;
            if (pIdPapel == "")
            {
                if (this.dgvPapel.CurrentRow == null)
                {
                    this.dgvPapel.CurrentCell = this.dgvPapel[0, 0];
                }

                vsIdPapel = this.dgvPapel.CurrentRow.Cells[0].Value.ToString();
            }
            this.DtgOrg.Rows.Clear();
            ListOrgPapel = vSisOrganizacaoPapelNEG.ObtemListaOrgsAssociadosPapeis(ref vBanco, vsIdPapel, vIdUsu);
            if (ListOrgPapel.Count() > 0)
            {
                foreach(var OrgAssociadaPapel in ListOrgPapel)
                {
                    DtgOrg.Rows.Add(OrgAssociadaPapel.ID_ORG, OrgAssociadaPapel.NM_ORG, OrgAssociadaPapel.ID_USU_INCL, OrgAssociadaPapel.DT_INCLUSAO);
                }
            }
            return true;

        }
        private Boolean CarregaPapeis()
        {
            ListPapel = vOrgPapelNEG.ObtemListaPapeis(ref vBanco, vIdUsu, vIdOrg);
            return bAlimentaDbPapeis();
        }
        private Boolean bAlimentaDbPapeis()
        {
            this.dgvPapel.Rows.Clear();
            foreach(var vwPapel in ListPapel)
            {
                this.dgvPapel.Rows.Add(vwPapel.ID_PAPEL,vwPapel.DS_PAPEL);
            }
            return true;
        }

        

        private void btnNovo_Click(object sender, EventArgs e)
        {

        }

        private void btnRetiraAssociacao_Click(object sender, EventArgs e)
        {
            if (this.DtgOrg.CurrentRow != null)
            {
                this.DtgOrg.Rows.RemoveAt(this.DtgOrg.CurrentRow.Index);
            }
        }

        private void btnREtiraAssociaOrgUsu_Click(object sender, EventArgs e)
        {
            if (this.dGvUser.CurrentCell != null)
            {
                this.dGvUser.Rows.RemoveAt(this.dGvUser.CurrentRow.Index);
            }
        }

        private void btnInclueAssociacao_Click(object sender, EventArgs e)
        {
            Frm_Associa FrmAssocia = new Frm_Associa(ref vBanco, Frm_Associa.AssociaPapelOrg, 0 , vIdUsu, vIdPapel);
            if (FrmAssocia.ShowDialog() == DialogResult.OK)
            {
                int vIndex = this.DtgOrg.RowCount + 1;
                this.DtgOrg.Rows.Add(FrmAssocia.vSysOrg.ID_ORG, FrmAssocia.vSysOrg.NM_ORG, FrmAssocia.vSysOrg.ID_USU_INCL, FrmAssocia.vSysOrg.DT_INCLUSAO);
            }
            FrmAssocia = null;
        }

        private void btnAssociaUsu_Click(object sender, EventArgs e)
        {
            Frm_Associa FrmAssocia = new Frm_Associa(ref vBanco, Frm_Associa.AssociaPapelOrg, 0, vIdUsu, vIdPapel);
            if (FrmAssocia.ShowDialog() == DialogResult.OK)
            {
                int vIndex = this.dGvUser.RowCount + 1;
                this.dGvUser.Rows.Add(FrmAssocia.vPUsu.ID_USU, FrmAssocia.vPUsu.ID_USU_INCL, FrmAssocia.vPUsu.DT_INCLUSAO);
            }
            FrmAssocia = null;
        }

        

        private void dgvPapel_KeyDown(object sender, KeyEventArgs e)
        {
            int i;
            Boolean vbLoad;
            var tecla = e.KeyCode;

            if (tecla == Keys.Enter || tecla == Keys.Up || tecla == Keys.Down)
            {
                vbLoad = LoadReg();
            }
           
           
        }
        private void dgvPapel_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Boolean vbLoad;
            vbLoad = LoadReg();
        }
        public Boolean LoadReg()
        {
            return true;
        }

    }
}
