using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MCIMasterFarm.Negocio.BackOffice
{
    public class Error
    {
        public Boolean DisplayErrorGrave(string pOjectNome, string pMsgError, string psTitulo)
        {
            string vMEssagem = pMsgError;
            vMEssagem += Environment.NewLine + "Objeto:  " + pOjectNome;
            var vDialog = MessageBox.Show(vMEssagem,psTitulo, MessageBoxButtons.OK, MessageBoxIcon.Error);

            return true;
        }

    }
}
