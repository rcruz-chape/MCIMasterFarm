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
using MCIMasterFarm.Negocio.Telas;
using MCIMasterFarm.Negocio.BackOffice;
using MCIMasterFarm.Negocio.BackOffice.DAL;
using MCIMasterFarm.Negocio.BackOffice.Negocio;
using MCIMasterFarm.Negocio.BackOffice.DadosAcesso;
using MCIMasterFarm.Negocio.BackOffice.Install;
using MCIMasterFarm.Negocio.BackOffice.Model;
using MCISYS.DictionarysVersion;

namespace MCISYS.Negocio.Telas
{
    public partial class frm_Email : Form
    {
        private Banco vBanco;
        private Boolean vExecutePesquisa;
        public frm_Email(ref Banco pBanco,Boolean pExecutePesquisa = false)
        {
            vBanco = pBanco;
            vExecutePesquisa = pExecutePesquisa;
            InitializeComponent();
        }


        public SisConfiguracaoEmail vsisConfiguracaoEmail = new SisConfiguracaoEmail();
        public EmailNeg vEmailNeg = new EmailNeg();
        private Boolean RegGravar(Boolean vbGrava = true)
        {
            Boolean bEnvia;
            MessageBoxIcon iError = MessageBoxIcon.Error;
            MessageBoxIcon iWarning = MessageBoxIcon.Warning;
            if (this.txtEmail.Text == string.Empty)
            {

                MessageBoxButtons buttons = MessageBoxButtons.OK;
                DialogResult result = MessageBox.Show("E-Mail Obrigatório.", "Erro de Validação", buttons, iError);
                this.txtEmail.Focus();
                return false;
            }
            if (this.txtHostName.Text == string.Empty)
            {
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                DialogResult result = MessageBox.Show("Host Obrigatório.", "Erro de Validação", buttons, iError);
                this.txtHostName.Focus();
                return false;
            }

            if (this.txtPort.Text == string.Empty)
            {
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                DialogResult result = MessageBox.Show("Port Host Obrigatório.", "Erro de Validação", buttons, iError);
                this.txtPort.Focus();
                return false;
            }

            if (this.txtPwd.Text == string.Empty)
            {
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                DialogResult result = MessageBox.Show("Senha Obrigatória.", "Erro de Validação", buttons, iError);
                this.txtPwd.Focus();
                return false;
            }
            vsisConfiguracaoEmail.DS_HOST = this.txtHostName.Text;
            vsisConfiguracaoEmail.DS_EMAIL = this.txtEmail.Text;
            vsisConfiguracaoEmail.DS_SENHA = this.txtPwd.Text;
            vsisConfiguracaoEmail.BO_ENABLE_SSL = (this.chc_enable_ssl.Checked == true);
            vsisConfiguracaoEmail.BO_USE_DEFAULT_CREDENTIALS = (this.cckUseCredentials.Checked == true);

            bEnvia = RegTestaEnvioEmail();
            if (bEnvia && vbGrava)
            {
                bEnvia = vEmailNeg.NegInsereMail(ref vBanco, vsisConfiguracaoEmail); 
            }


            return bEnvia;
        }

        public Boolean RegPesquisa()
        {
            vsisConfiguracaoEmail = vEmailNeg.MontaConfiguracaoEmail(ref vBanco);
            this.txtEmail.Text = vsisConfiguracaoEmail.DS_EMAIL;
            this.txtHostName.Text = vsisConfiguracaoEmail.DS_HOST;
            this.txtPwd.Text = vsisConfiguracaoEmail.DS_SENHA;
            this.txtPort.Text = vsisConfiguracaoEmail.NR_PORT.ToString();
            this.chc_enable_ssl.Checked = (vsisConfiguracaoEmail.BO_ENABLE_SSL == true);
            this.cckUseCredentials.Checked = (vsisConfiguracaoEmail.BO_USE_DEFAULT_CREDENTIALS == true);
            return true;
        }
        private Boolean RegTestaEnvioEmail()
        {
            Boolean vbEnvia = vEmailNeg.SendEmailTeste(vsisConfiguracaoEmail);
            if (!vbEnvia)
            {
                MessageBoxIcon iError = MessageBoxIcon.Error;
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                DialogResult result = MessageBox.Show($@"Dados de E-mail Incorretos.{Environment.NewLine}E-Mail de Teste não foi possível ser realizado.", "Erro de Teste de Envio de E-mail", buttons, iError);

            }
            return vbEnvia;
        }

        private void btConfirmar_Click(object sender, EventArgs e)
        {
            var bRegSalvar = RegGravar();
            if (!bRegSalvar)
            {
                MessageBoxIcon iError = MessageBoxIcon.Error;
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                DialogResult result = MessageBox.Show($@"Não Foi Possível gravar dados de E-Mail", "Erro de Configuração de Email", buttons, iError);

            }
            else
            {
                this.Dispose();
            }
        }

        private void btTeste_Click(object sender, EventArgs e)
        {
            var bTeste = RegGravar(false);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void frm_Email_Load(object sender, EventArgs e)
        {
            Boolean bPesquisa;
            if (vExecutePesquisa)
            {
                bPesquisa = RegPesquisa();
            }
        }
    }
}
