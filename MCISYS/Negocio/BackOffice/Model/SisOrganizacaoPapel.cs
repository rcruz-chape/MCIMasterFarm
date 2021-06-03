using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MCISYS.Negocio.BackOffice.Model
{
    public class SisOrganizacaoPapel
    {
        public int ID_ORG { set; get; }
        public string ID_PAPEL { set; get; }
        public string DS_PAPEL { set; get; }
        public string ID_USU_INCL { set; get; }
        public DateTime DT_INCLUSAO { set; get; }
    }
}
