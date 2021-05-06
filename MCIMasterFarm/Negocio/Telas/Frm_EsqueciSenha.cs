using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MCIMasterFarm.Negocio.BackOffice;
using MCIMasterFarm.Negocio.BackOffice.Negocio;
using MCIMasterFarm.Negocio.Telas;
using MCIMasterFarm.Negocio.Global;
using System.Windows.Forms;

namespace MCIMasterFarm.Negocio.Telas
{
    public partial class Frm_EsqueciSenha : Form
    {
        Banco vBanco = new Banco();
        public Frm_EsqueciSenha(ref Banco pBanco)
        {
            vBanco = pBanco;
            InitializeComponent();
            
            
        }

        private void BtnSaida_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnReinicia_Click(object sender, EventArgs e)
        {
            if (this.txtEmailUsuario.Text == null)
            {
                var vDialog = MessageBox.Show("Usuario e E-Mail não preenchidos", "Erro no Usuario!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.txtEmailUsuario.Focus();
            }
            else
            {
                var SisUSuarioNEG = new SIS_USUARIO_NEG();
                var SisUSuarioREG = SisUSuarioNEG.ObtemUSuarioPorEmailUsuario(txtEmailUsuario.Text, ref vBanco);
                this.txtEmailUsuario.Text = null;
                if (SisUSuarioREG == null)
                {
                    var vDialog = MessageBox.Show("Usuario não Localizado.", "Erro no Usuario!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.txtEmailUsuario.Focus();
                }
                else
                {
                    var SisParametroNEG = new SIS_PARAMETRO_NEG();
                    var SisParametroREG = SisParametroNEG.ObtemParametro(ref vBanco);
                    var SisEmailNEG = new EmailNeg();
                    string vsSenhaAlterada = SisUSuarioNEG.defineSenhaUsuario(ref vBanco, SisParametroREG, ref SisUSuarioREG);
                    string vsMensagem = @" Prezado   " + SisUSuarioREG.nm_usu + @" segue a sua nova senha: 
                        " + vsSenhaAlterada + " A Senha reiniciada já estará expirada e deve ser altarada no primerio login.";
                    Boolean Send = SisEmailNEG.SendEmail("Envio de Nova Senha", vsMensagem, SisUSuarioREG.ds_email, SisUSuarioREG.nm_usu, ref vBanco);

                }
            }

        }
    }
}
