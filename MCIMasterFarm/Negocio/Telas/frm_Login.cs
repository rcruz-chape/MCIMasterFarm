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
using MCIMasterFarm.Negocio.BackOffice;
using MCIMasterFarm.Negocio.BackOffice.DAL;
using MCIMasterFarm.Negocio.BackOffice.Negocio;
using MCIMasterFarm.Negocio.BackOffice.DadosAcesso;
using MCIMasterFarm.Negocio.BackOffice.Install;

namespace MCIMasterFarm
{
    public partial class frn_MCILogin : Form
    {
        private Banco vBanco = new Banco();
        private DialogResult vDialog = new DialogResult();

        public frn_MCILogin()
        {
            var vREcuperaDadosAcesso = new DadosACessos();
            var vREcupera = vREcuperaDadosAcesso.RecuperarDadosAcesso(ref vBanco);
            var Connect = new Connect();
            var Conn = Connect.GetConnection(ref vBanco);
            var desconectado = Connect.FechaConnection(ref Conn);
            

            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sNomeUsuario = this.txt_Usuario.Text;
            string sSenha = this.txt_Senha.Text;
            Boolean vConfereSenha = false;
            var SisUsuarioNEG = new SIS_USUARIO_NEG();
            var UsuarioLogado = SisUsuarioNEG.vSysUsuDal(sNomeUsuario, ref vBanco);
            if (UsuarioLogado.id_usu == null)
            {
                Boolean bExisteUsuarioAdmin = SisUsuarioNEG.vSysUsuAdmin(ref vBanco);
                var vGlobalInstall = new GlobalInstall();
                if (!bExisteUsuarioAdmin)
                {
                    var Setup = new Install();
                    var SetupUser = Setup.seTup(ref vBanco, vGlobalInstall);
                }
                else
                {
                    vDialog = MessageBox.Show("Usuário Não Localizado!", "Erro no Login!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                var vCriptografia = new Criptografia();
                vConfereSenha = vCriptografia.VerifcaConteudo(sSenha, UsuarioLogado.ds_pwd);
                if (!vConfereSenha)
                {

                    txt_Usuario.Text = "";
                    txt_Senha.Text = "";
                    Boolean vbUsuarioNaoLogado = SisUsuarioNEG.LoginSemSucesso(UsuarioLogado, ref vBanco);
                    vDialog = MessageBox.Show("Usuário ou Senha não confere!","Erro no Login!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (!SisUsuarioNEG.fbVerificaUsuarioBloqueado(UsuarioLogado, ref vBanco))
                    {
                        if (UsuarioLogado.ind_motivo_bloqueio != SisUsuarioNEG.iSenhaExpirada)
                        {
                            vDialog = MessageBox.Show("Usuário Bloqueado! Favor contatar o usuário administrador e solicitar o desbloqueio.", "Usuário Bloqueado", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        UsuarioLogado = SisUsuarioNEG.loginSucesso(UsuarioLogado, ref vBanco);
                        var vNetwork = new Network();
                        var vIP = vNetwork.IP();
                        var vMAC = vNetwork.MAC();
                        var OS = vNetwork.OS();
                        var HostName = vNetwork.HostName();
                        vDialog = MessageBox.Show("Usuário Logado", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                 }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
