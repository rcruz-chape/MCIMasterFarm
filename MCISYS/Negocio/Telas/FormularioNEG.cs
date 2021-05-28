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

namespace MCISYS.Negocio.Telas
{
    public class FormularioNEG
    {
        public const string CriaOrg = "CriaOrg";
        
        public Form ChamaForm(string pTag, ref Banco pBanco, int pIdOrg, string pIdPapel, string pIdUSU, string pNmOrg, string pDSPApel)
        {
            Form vnForm = new Form();
            switch(pTag)
            {
                case CriaOrg:
                    vnForm = new Frm_CriaOrg(ref pBanco, pIdOrg, pIdPapel, pIdUSU, pNmOrg, pDSPApel);
                    break;
            }
            return vnForm;
        }

    }
}
