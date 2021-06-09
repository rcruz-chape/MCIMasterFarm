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
    public partial class Frm_Licenca : Form
    {
        Banco vBanco = new Banco();
        int vIdOrg = 0;
        CorOrganizacaoLicenca vOrgLic = new CorOrganizacaoLicenca();
        CorOrganizacaoLicencaNEG vOrgLicNEG = new CorOrganizacaoLicencaNEG();
        List<TpAmbiente> vListTpAmbiente = new List<TpAmbiente>(); 
        private ConfiguraControleNEG vControleNEG = new ConfiguraControleNEG();

        Boolean bLicenciado;

        public class TpAmbiente
        {
            public int TIPO_AMBIENTE { set; get; }
            public string DS_TIPO_AMBIENTE { set; get; }
        }

        public List<TpAmbiente> CarregaTpAmbiente()
        {
            var ListTpAmbiente = new List<TpAmbiente>();

            var TpAmbiente = new TpAmbiente();
            TpAmbiente.TIPO_AMBIENTE = 1;
            TpAmbiente.DS_TIPO_AMBIENTE = "PRODUCAO";
            ListTpAmbiente.Add(TpAmbiente);
            TpAmbiente = new TpAmbiente();
            TpAmbiente.TIPO_AMBIENTE = 2;
            TpAmbiente.DS_TIPO_AMBIENTE = "HOMOLOGACAO";
            TpAmbiente.TIPO_AMBIENTE = 3;
            TpAmbiente.DS_TIPO_AMBIENTE = "ACEITE";
            ListTpAmbiente.Add(TpAmbiente);

            return ListTpAmbiente;
        }

        
        public Frm_Licenca(ref Banco pBanco, int pIdOrg)
        {
            InitializeComponent();
            
            vBanco = pBanco;
            vIdOrg = pIdOrg;
            vListTpAmbiente = CarregaTpAmbiente();
            var Cbx = ConfiguraCbx();
        }
        private Boolean ConfiguraCbx()
        {
            this.cbxAmbiente.DataSource = vListTpAmbiente;
            var vControle = vControleNEG.SetComboBox(cbxAmbiente, nameof(TpAmbiente.DS_TIPO_AMBIENTE), nameof(TpAmbiente.TIPO_AMBIENTE));
            return true;

        }

        private void Frm_Licenca_Load(object sender, EventArgs e)
        {
            Boolean vbTeste;
            vOrgLic = vOrgLicNEG.ObtemLic(ref vBanco, vIdOrg);
            bLicenciado = (vOrgLic != null && vOrgLic.ID_ORG != 0);
            if (vOrgLic == null || vOrgLic.ID_ORG ==0)
            {
                this.cbxAmbiente.Text = "";
                this.txtSigla.Text = "";
                this.dt_Lic.Value = DateTime.Now;
                vbTeste = HabilitaBotoes(false);

            }
            else
            {
                string nrRaiz = vOrgLic.NR_CNPJ_RAIZ.ToString();
                string nrRaizPre = nrRaiz.PadLeft(8, '0');
                this.mTxtRaiz.Text = nrRaizPre;
                this.cbxAmbiente.SelectedItem = vOrgLic.DS_AMBIENTE;
                this.cbxAmbiente.Text = vOrgLic.DS_AMBIENTE_DESC;
                this.txtSigla.Text = vOrgLic.DS_SIGLA;
                this.dt_Lic.Value = vOrgLic.DT_LICENCIAMENTO;
                vbTeste = HabilitaBotoes();
            }
        }
        private Boolean HabilitaBotoes(Boolean pAcao = true)
        {
            this.btnExcluir.Enabled = pAcao;
            this.btnLic.Enabled = !pAcao;
            return pAcao;
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            if (!bLicenciado)
            {
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                string vMsg = "Deseja Licenciar?";
                vMsg += Environment.NewLine;
                vMsg += "Sem Licenciamento não será possível operar o MCISYS";
                DialogResult result = MessageBox.Show(vMsg, "Sem Licenciamento", buttons);
                if (result == DialogResult.Yes)
                {
                    var bSalvar = RegSalvar();
                }
            }
            this.Dispose();
        }
        private Boolean RegExcluir()
        {
            Boolean vbTeste;
            bLicenciado = false;
            vbTeste = vOrgLicNEG.ExclueLicencaOrg(ref vBanco, vIdOrg);
            this.mTxtRaiz.Text = "";
            this.cbxAmbiente.SelectedValue = 0;
            this.cbxAmbiente.Text = "";
            this.txtSigla.Text = "";
            this.dt_Lic.Value = DateTime.Now;
            vbTeste = HabilitaBotoes(false);
            return true;

        }
        private Boolean RegSalvar()
        {
            string vsNrCNPJRaiz;
            MessageBoxButtons buttons = new MessageBoxButtons();
            DialogResult result = new DialogResult();
            string vMsg;

            if (this.mTxtRaiz.Text == "")
            {
                vMsg = "O Campo CNPJ Raiz deve ser preenchido";
                buttons = MessageBoxButtons.OK;
                result = MessageBox.Show(vMsg, "Campo não preenchido", buttons);
                this.mTxtRaiz.Focus();
                return true;
            }

            if (this.cbxAmbiente.Text == "" )
            {
                vMsg = "O Ambiente deve ser selecionado.";
                buttons = MessageBoxButtons.OK;
                result = MessageBox.Show(vMsg, "Campo não preenchido", buttons);
                this.cbxAmbiente.Focus();
                return true;

            }

            if (this.txtSigla.Text == "")
            {
                vMsg = "A Sigla deve ser informada.";
                buttons = MessageBoxButtons.OK;
                result = MessageBox.Show(vMsg, "Campo não preenchido", buttons);
                this.txtSigla.Focus();
                return true;
            }

            vOrgLic.ID_ORG = vIdOrg;
            vsNrCNPJRaiz = this.mTxtRaiz.Text.Replace(",", "");
            vOrgLic.NR_CNPJ_RAIZ = Convert.ToInt32(vsNrCNPJRaiz);
            vOrgLic.DS_AMBIENTE = Convert.ToInt32(this.cbxAmbiente.SelectedValue);
            vOrgLic.DS_SIGLA = this.txtSigla.Text;
            vOrgLic.DT_LICENCIAMENTO = this.dt_Lic.Value;

            var bExecuta = vOrgLicNEG.IncluiLicencaOrg(ref vBanco, vOrgLic);
            bLicenciado = true;
            return bExecuta;
        }

        private void btnLic_Click(object sender, EventArgs e)
        {
            var bLicenciar = RegSalvar();
            bLicenciar = HabilitaBotoes();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            var Exclue = RegExcluir();
        }
    }
}
