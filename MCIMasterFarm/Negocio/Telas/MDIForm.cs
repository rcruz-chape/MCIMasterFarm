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

namespace MCIMasterFarm.Negocio.Telas
{
    public partial class MDIForm : Form
    {
        private int childFormNumber = 0;

        public List<Configuracao> vConfiguracao = new List<Configuracao>();
        public ConfigAcao vConfigAcao = new ConfigAcao();
        public ConfiguracaoNEG vConfiguracaoNEG = new ConfiguracaoNEG();
        private Banco vBanco = new Banco();
        private DialogResult vDialog = new DialogResult();
        public string vIdUsu;

        public MDIForm(string pIdUsu,Banco pBanco)
        {
            vIdUsu = pIdUsu;
            vBanco = pBanco;
            InitializeComponent();

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
    }
}
