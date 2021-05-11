using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using MCIMasterFarm.Negocio.Telas;

namespace MCIMasterFarm
{
    static class Program
    {
        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            frn_MCILogin frmLogin = new frn_MCILogin();
            if (frmLogin.ShowDialog() == DialogResult.OK)
            {
                var vvBanco = frmLogin.vBanco;
                string vsIdUsu = frmLogin.txtNmUser;
                frmLogin = null;
                Frm_SelecionaOrg Frm_Seleciona_Org = new Frm_SelecionaOrg(vsIdUsu,ref vvBanco);
                if (Frm_Seleciona_Org.ShowDialog() == DialogResult.OK)
                {
                    int vIDOrg = Frm_Seleciona_Org.vIdOrgSelecionada;
                    string vIDPapel = Frm_Seleciona_Org.vIdPapelSelecionado;
                    Frm_Seleciona_Org = null;

                    Application.Run(new MDIForm(vsIdUsu, vvBanco, vIDOrg, vIDPapel));
                }
             }
        }
    }
}
