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
        public Boolean DisplayErrorModulo(int pidOrg, string pNmOrg)
        {
            string vMEssagem = "Não Existe Módulos Vinculados a Organização: ";
            vMEssagem += Environment.NewLine;
            vMEssagem += pidOrg.ToString("000") + "-" + pNmOrg +".";
            vMEssagem += Environment.NewLine;
            vMEssagem += "Favor providenciar o licenciamento da Respectiva Organização Mãe";
            var vDialog = MessageBox.Show(vMEssagem, "Licenciamento", MessageBoxButtons.OK, MessageBoxIcon.Error);

            return true;
        }
    }
}
