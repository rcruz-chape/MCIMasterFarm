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

namespace MCIMasterFarm.Negocio.Telas
{
    public partial class MDIForm : Form
    {
        private int childFormNumber = 0;

        public List<Configuracao> vConfiguracao = new List<Configuracao>();
        public ConfigAcao vConfigAcao = new ConfigAcao();
        public ConfiguracaoNEG vConfiguracaoNEG = new ConfiguracaoNEG();
        private Banco vBanco = new Banco();
        private int vIDOrgSelecionada = 0;
        public const int cIDOrgAdm = 1;
        private string vIDPapelSelecionado = "0";
        private DialogResult vDialog = new DialogResult();
        private VwOrgPapel vwOrgPapel = new VwOrgPapel();
        private VwOrgUsu vwOrgUsu = new VwOrgUsu();
        private VwOrgPapelNEG vOrgPapelNEG = new VwOrgPapelNEG();
        private VwOrgUsuNEG vOrgUsuNEG = new VwOrgUsuNEG();
        private SisModuloNEG vSisModuloNeg = new SisModuloNEG();
        private List<SisModulo> vModuloAssociado = new List<SisModulo>();
        private Error vErro = new Error();


        public string vIdUsu;

        public MDIForm(string pIdUsu, Banco pBanco, int pIdOrg, string pIdPapel)
        {
            vIdUsu = pIdUsu;
            vBanco = pBanco;

            vIDOrgSelecionada = pIdOrg;
            vIDPapelSelecionado = pIdPapel;
            InitializeComponent();

            var bConfiguraStatus = ConfiguraBarraStatus();
            var bConfiguraModulo = ConfiguraModuloAtivos();
        }
        private Boolean ConfiguraModuloAtivos() 
        {
            Boolean vReturn = false;
            vModuloAssociado = vSisModuloNeg.ObtemModulosHabilitados(ref vBanco, vIDOrgSelecionada, 1);
            if (vModuloAssociado.Count == 0)
            {
                if (cIDOrgAdm != vIDOrgSelecionada)
                {
                    vReturn = vErro.DisplayErrorModulo(vIDOrgSelecionada, vwOrgUsu.NM_ORG);
                }
                else
                {
                    CriaEstruturaSisNEG vImplementaSIS = new CriaEstruturaSisNEG();
                    vReturn = vImplementaSIS.CriaEstrutura(ref vBanco, cIDOrgAdm);
                }
            }
            return vReturn;
        }

        private void ShowNewForm(object sender, EventArgs e)
        {
            Form childForm = new Form();
            childForm.MdiParent = this;
            childForm.Text = "Janela " + childFormNumber++;
            childForm.Show();
        }

        private void OpenFile(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "Arquivos de texto (*.txt)|*.txt|Todos os arquivos (*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = openFileDialog.FileName;
            }
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "Arquivos de texto (*.txt)|*.txt|Todos os arquivos (*.*)|*.*";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = saveFileDialog.FileName;
            }
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private Boolean ConfiguraBarraStatus()
        {
            vwOrgUsu = vOrgUsuNEG.GetOrg(ref vBanco, vIdUsu, vIDOrgSelecionada);
            vwOrgPapel = vOrgPapelNEG.ObtemPapelSelecionado(ref vBanco, vIdUsu, vIDOrgSelecionada, vIDPapelSelecionado);
            this.tstlUsuario.Text = "Usuário:  " + vIdUsu;
            this.tstlOrgSelecionadaNumero.Text = "Org:   " + vIDOrgSelecionada.ToString("000");
            this.tstl_OrgDEscricao.Text = " - " + vwOrgUsu.NM_ORG;
            this.TstlPapel.Text = "Papel:  " + vwOrgPapel.DS_PAPEL;
            return true;


        }

        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            var bLogoff = fbRealizarLogoff(ref vBanco);
            this.Dispose();
        }
        private Boolean fbRealizarLogoff(ref Banco pBanco)
        {
            var vNegUsuarioLog = new SysUsuarioLogNEG();
            var SisUsuarioLog = vNegUsuarioLog.ObtemSisUsuarioLog(ref pBanco, vIdUsu);
            var bLogoff = vNegUsuarioLog.RealizaLogoff(ref pBanco, vIdUsu);
            var vNegUsuarioLogHist = new SisUsuarioLogadoHistNEG();
            bLogoff = vNegUsuarioLogHist.RegistraHistoricoLogonUsuario(SisUsuarioLog, ref pBanco);
            return bLogoff;
        }

        private void trocarOrgEPapelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_SelecionaOrg vFrm_SelecionaOrg = new Frm_SelecionaOrg(vIdUsu,ref vBanco);
            if (vFrm_SelecionaOrg.ShowDialog() == DialogResult.OK)
            {
                vIDOrgSelecionada = vFrm_SelecionaOrg.vIdOrgSelecionada;
                vIDPapelSelecionado = vFrm_SelecionaOrg.vIdPapelSelecionado;
                vFrm_SelecionaOrg = null;
                var bCOnfiguraStatus = ConfiguraBarraStatus();
            }
        }
    }
}
