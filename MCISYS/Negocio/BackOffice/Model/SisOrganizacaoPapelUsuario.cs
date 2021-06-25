using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MCISYS.Negocio.BackOffice.Model
{
    public class SisOrganizacaoPapelUsuario
    {
        public int ID_ORG { get; set; }
        public string ID_PAPEL { get; set; }
        public string ID_USU { get; set; }
        public string ID_USU_INCL { get; set; }
        public DateTime DT_INCLUSAO { get; set; }
    }
}
