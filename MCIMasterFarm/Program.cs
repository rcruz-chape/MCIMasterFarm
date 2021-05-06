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
                Application.Run(new MDIForm());
            }
        }
    }
}
