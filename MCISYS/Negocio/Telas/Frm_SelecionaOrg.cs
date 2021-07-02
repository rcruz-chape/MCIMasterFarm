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
using MCIMasterFarm.Negocio.Global;

namespace MCIMasterFarm.Negocio.Telas
{
    public partial class Frm_SelecionaOrg : Form
    {
        public int vIdOrgSelecionada = 0;
        public string vIdPapelSelecionado = "0";
        private string vIdUSu;
        public string vTpOrg;
        private VwOrgPapelNEG vVOrgPapelNEG = new VwOrgPapelNEG();
        private VwOrgUsuNEG VwOrgUsuNEG = new VwOrgUsuNEG();
        private ConfiguraControleNEG vControleNEG = new ConfiguraControleNEG();
        private Banco vBanco = new Banco();

        public Frm_SelecionaOrg(string pIdUsu, ref Banco pBanco )
        {
            vIdUSu = pIdUsu;
            vBanco = pBanco;
            
            if (!VwOrgUsuNEG.fbReturnVwOrgUsuDal(ref vBanco,vIdUSu))
            {
                var vDialog = MessageBox.Show("Não Existe uma Organização Associada ao usuário." + Environment.NewLine + "Favor contatar o administrador do sistema para providenciar as devidas associações.", "Organização não Localizada!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.Cancel;
                this.Dispose();
            }

            var RegOrgAssociado = VwOrgUsuNEG.GetListaOrg(ref vBanco,vIdUSu);
            InitializeComponent();
            cbxOrg.DataSource = RegOrgAssociado;
            var RegistroORG = new VwOrgUsu();
            var Controle = vControleNEG.SetComboBox(this.cbxOrg, nameof(RegistroORG.NM_ORG_RESUMIDO), nameof(RegistroORG.ID_ORG));
            cbxOrg.Enabled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (vIdOrgSelecionada == 0)
            {
                var vDialog = MessageBox.Show("Organização de Trabalho não selecionada", "Erro ao Continuar!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cbxOrg.Focus();
            }
            else if (vIdPapelSelecionado == "0")
            {
                var vDialog = MessageBox.Show("Papel do usuário não selecionado", "Erro ao Continuar!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cbxPapel.Focus();
            }
            else
            {
                this.DialogResult = DialogResult.OK;
                this.Dispose();
            }
        }
            
        private void cbxPapel_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cbxPapel.Enabled)
            {
                if (this.cbxPapel.SelectedValue != null)
                {
                    vIdPapelSelecionado = this.cbxPapel.SelectedValue.ToString();
                }
                
            }
        }

        private void cbxOrg_SelectedValueChanged(object sender, EventArgs e)
        {
            if (this.cbxOrg.Enabled)
            {
                vIdOrgSelecionada = Convert.ToInt32(this.cbxOrg.SelectedValue);
                var OrgSelecionada = VwOrgUsuNEG.GetOrg(ref vBanco,vIdUSu,vIdOrgSelecionada);
                vTpOrg = OrgSelecionada.TP_ORG;


                Boolean ExistePapelAssociado = vVOrgPapelNEG.fbVerificaPapelAssociado(ref vBanco, vIdUSu, vIdOrgSelecionada);
                if (!ExistePapelAssociado)
                {
                    var vDialog = MessageBox.Show("Não Existe um Papel Associado ao usuário." + Environment.NewLine + "Favor contatar o administrador do sistema para providenciar as devidas associações.", "Papel não Associado!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.DialogResult = DialogResult.Cancel;
                    this.Dispose();
                }
                var PapelAssociado = new VwOrgPapel();
                var ListaPapeisAssociados = vVOrgPapelNEG.ObtemPapelAssociado(ref vBanco, vIdUSu, vIdOrgSelecionada);
                this.cbxPapel.DataSource = ListaPapeisAssociados;
                var Controle = vControleNEG.SetComboBox(cbxPapel, nameof(PapelAssociado.DS_PAPEL), nameof(PapelAssociado.ID_PAPEL));
                this.cbxPapel.Enabled = ExistePapelAssociado;
            }
        }
    }
}
