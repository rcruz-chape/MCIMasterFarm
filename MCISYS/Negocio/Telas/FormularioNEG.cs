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
        public const string CriaPap = "CriaPap";
        public const string CriaUsu = "CriaUsu";
        public const string ParCadUnidade = "ParCadUnidade";
        public const string ParCadGrupo = "ParCadGrupo";


        public Form ChamaForm(string pTag, ref Banco pBanco, int pIdOrg, string pIdPapel, string pIdUSU, string pNmOrg, string pDSPApel)
        {
            Form vnForm = new Form();
            switch(pTag)
            {
                case CriaOrg:
                    vnForm = new Frm_CriaOrg(ref pBanco, pIdOrg, pIdPapel, pIdUSU, pNmOrg, pDSPApel);
                    break;
                case CriaPap:
                    vnForm = new Frm_CriaPap(ref pBanco, pIdOrg, pIdPapel, pIdUSU, pNmOrg, pDSPApel);
                    break;
                case CriaUsu:
                    vnForm = new Frm_CriaUsu(ref pBanco, pIdOrg, pIdPapel, pIdUSU, pNmOrg, pDSPApel);
                    break;
                case ParCadUnidade:
                    vnForm = new Frm_ParCadUnidade(ref pBanco, pIdOrg, pIdPapel, pIdUSU, pNmOrg, pDSPApel);
                    break;
                case ParCadGrupo:
                    vnForm = new Frm_ParCadGrupo(ref pBanco, pIdOrg, pIdPapel, pIdUSU, pNmOrg, pDSPApel);
                    break;
            }
            return vnForm;
        }

    }
}
