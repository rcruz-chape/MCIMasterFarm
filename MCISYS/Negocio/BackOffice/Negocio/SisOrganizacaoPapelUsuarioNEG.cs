using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MCIMasterFarm.Negocio.BackOffice.Negocio;
using MCIMasterFarm.Negocio.BackOffice.DAL;
using MCIMasterFarm.Negocio.Global;
using MCIMasterFarm.Negocio.BackOffice.Model;
using MCISYS.Negocio.BackOffice.Model;
using MCISYS.Negocio.BackOffice.DAL;

namespace MCISYS.Negocio.BackOffice.Negocio
{
    public class SisOrganizacaoPapelUsuarioNEG
    {
        private SisOrganizacaoPapelUsuarioDAL vSisOpusuDAL = new SisOrganizacaoPapelUsuarioDAL();
        public Boolean RetiraAssociadoORgPapel(ref Banco pBanco, int pIdOrg = 0, string pIdUsu = null, string pIdPapel = null)
        {
            return vSisOpusuDAL.fbExcluiAssociacao(ref pBanco, pIdUsu, pIdOrg, pIdPapel);
        }

        public Boolean UsuarioAssociadoORgPapel(ref Banco pBanco, int pIdOrg, string pIdUsu, string pIdPapel)
        {
            return vSisOpusuDAL.fbExisteAssociacao(ref pBanco, pIdUsu, pIdOrg, pIdPapel);
        }
        public Boolean RealizaAssociacaoUsuario(ref Banco pBanco, List<SisOrganizacaoPapelUsuario> pListSisOpusu)
        {
            Boolean vbREturn = true;
            foreach(var SisOpUsu in pListSisOpusu)
            {
                vbREturn = vSisOpusuDAL.fbInclueAssocia(ref pBanco, SisOpUsu);
                if (!vbREturn)
                {
                    break;
                }
            }
            return vbREturn;
        }
        public Boolean RetiraAssociacaoUsuario(ref Banco pBanco, List<SisOrganizacaoPapelUsuario> pListSisOpusu)
        {
            Boolean vbREturn = true;
            foreach (var SisOpUsu in pListSisOpusu)
            {
                vbREturn = vSisOpusuDAL.fbExclueAssocia(ref pBanco, SisOpUsu);
                if (!vbREturn)
                {
                    break;
                }
            }
            return vbREturn;
        }
    }
}
