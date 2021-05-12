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

namespace MCIMasterFarm
{
    public partial class frn_MCILogin : Form
    {
        public Banco vBanco = new Banco();
        private DialogResult vDialog = new DialogResult();

        public string txtNmUser = "";

        public frn_MCILogin()
        {
            var vREcuperaDadosAcesso = new DadosACessos();
            var vREcupera = vREcuperaDadosAcesso.RecuperarDadosAcesso(ref vBanco);
            var Connect = new Connect();
            var Conn = Connect.GetConnection(ref vBanco);
            var desconectado = Connect.FechaConnection(ref Conn);
            this.DialogResult = DialogResult.None;

            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sNomeUsuario = this.txt_Usuario.Text;
            string sSenha = this.txt_Senha.Text;
            if (this.txt_Usuario.Text != "")
            {
                this.txtNmUser = txt_Usuario.Text;
                this.txt_Usuario.Text = "";
            }
            if (this.txt_Senha.Text != "")
            {
                this.txt_Senha.Text = "";
            }

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
                    var vSisUsuarioLogado = new SysUsuarioLogNEG();
                    if (!SisUsuarioNEG.fbVerificaUsuarioBloqueado(UsuarioLogado, ref vBanco))
                    {
                        if (UsuarioLogado.ind_motivo_bloqueio != SisUsuarioNEG.iSenhaExpirada)
                        {
                            vDialog = MessageBox.Show("Usuário Bloqueado! Favor contatar o usuário administrador e solicitar o desbloqueio.", "Usuário Bloqueado", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            frm_Senha_Expirada FrmSenhaExpirada = new frm_Senha_Expirada(ref UsuarioLogado, ref vBanco);
                            if (FrmSenhaExpirada.ShowDialog() == DialogResult.OK)
                            {
                                UsuarioLogado = SisUsuarioNEG.loginSucesso(UsuarioLogado, ref vBanco);
                                var vNetwork = new Network();
                                var vIP = vNetwork.IP();
                                var vMAC = vNetwork.MAC();
                                var OS = vNetwork.OS();
                                var HostName = vNetwork.HostName();
                                var vTsisUsuarioLogado = MontaUsuarioLogado(vIP, vMAC, OS, HostName, UsuarioLogado.id_usu);
                                var bVerificaUsuarioLogado = vSisUsuarioLogado.fVerificaSeUsuarioLogado(ref vBanco, vTsisUsuarioLogado, UsuarioLogado.id_usu);
                                if (!bVerificaUsuarioLogado)
                                {
                                    vDialog = MessageBox.Show("Usuário Logado Anteriormente ", "Logon Não Realizado", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    this.DialogResult = DialogResult.None;
                                }
                                else
                                {
                                    this.DialogResult = DialogResult.OK;
                                }
                            }
                        }
                        this.Dispose(); 
                    }
                    else
                    {
                        UsuarioLogado = SisUsuarioNEG.loginSucesso(UsuarioLogado, ref vBanco);
                        var vNetwork = new Network();
                        var vIP = vNetwork.IP();
                        var vMAC = vNetwork.MAC();
                        var OS = vNetwork.OS();
                        var HostName = vNetwork.HostName();
                        var vTsisUsuarioLogado = MontaUsuarioLogado(vIP, vMAC, OS, HostName, UsuarioLogado.id_usu);
                        var bVerificaUsuarioLogado = vSisUsuarioLogado.fVerificaSeUsuarioLogado(ref vBanco, vTsisUsuarioLogado, UsuarioLogado.id_usu);
                        if (!bVerificaUsuarioLogado)
                        {
                            vDialog = MessageBox.Show("Usuário Logado Anteriormente ", "Logon Não Realizado", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            this.DialogResult = DialogResult.None;
                        }
                        else
                        {
                            vDialog = MessageBox.Show("Usuário Logado", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.DialogResult = DialogResult.OK;
                        }


                        this.Dispose();
                    }
                 }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Frm_EsqueciSenha FrmEsqueciSenha = new Frm_EsqueciSenha( ref vBanco);
            FrmEsqueciSenha.ShowDialog();
        }

        private SisUsuarioLog MontaUsuarioLogado(string pIp, string pMac, string pOS, string psHostName, string pIDUsu)
        {
            SisUsuarioLog vSisUsuarioLog = new SisUsuarioLog();
            vSisUsuarioLog.ID_USU = pIDUsu;
            vSisUsuarioLog.DT_LOGIN = DateTime.Now;
            vSisUsuarioLog.DS_HOSTNAME = psHostName;
            vSisUsuarioLog.DS_IP_ADDRESS = pIp;
            vSisUsuarioLog.DS_MAC_ADDRESS = pMac;
            vSisUsuarioLog.DS_OS = pOS;
            return vSisUsuarioLog;

        }
    }
}
