using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MCISYS.Negocio.BackOffice.Model
{
    public class SisPapelFuncao
    {
        public string ID_PAPEL { set; get; }
        public int ID_SIS { set; get; }
        public int ID_MOD { set; get; }
        public int ID_FUNCAO { set; get; }
        public string ind_incl_reg { get; set; }
        public string ind_incl_alt { get; set; }
        public string ind_excl_reg { get; set; }
        public string ind_cons_reg { get; set; }
        public string ind_execute { get; set; }

    }
}
