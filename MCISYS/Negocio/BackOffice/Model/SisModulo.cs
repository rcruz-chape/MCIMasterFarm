using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MCISYS.Negocio.BackOffice.Model
{
    public class SisModulo
    {
        public int ID_MOD { set; get; }
        public string NM_MOD { set; get; }
        public string DS_MOD { set; get; }
        public DateTime DT_INCLUSAO { set; get; }
        public DateTime DT_ALTERACAO { set; get; }
        public int ID_SIS { set; get; }
        public string ID_USU_ALT { set; get; }
        public string ID_USU_INCL { set; get; }
        public string DS_SIGLA_MOD { set; get; }

    }
}
