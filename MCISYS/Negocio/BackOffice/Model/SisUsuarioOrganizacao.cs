using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MCISYS.Negocio.BackOffice.Model
{
    public class SisUsuarioOrganizacao
    {
        public int ID_ORG { set; get; }
        public string ID_USU { set; get; }
        public string ID_USU_INCL { set; get; }
        public DateTime DT_INCLUSAO { set; get; }
    }
}
