using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MCISYS.Negocio.BackOffice.Model
{
    public class SisSistema
    {
        public int ID_SIS { set; get; }
        public string NM_SIS { set; get; }
        public string DS_SIS { set; get; }
        public string SG_SIS { set; get; }
        public string NR_VERSAO { set; get; }
        public DateTime DT_INCLUSAO { set; get; }
        public DateTime DT_ALTERACAO { set; get; }
        public string ID_USU_ALT { set; get; }
        public string ID_USU_INCL { set; get; }

    }
}
