using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MCIMasterFarm.Negocio.BackOffice.Model
{
    public class SisFuncao
    {
        public int id_funcao { get; set; }
        public string nm_funcao { get; set; }
        public string ind_incl_reg { get; set; }
        public string ind_incl_alt { get; set; }
        public string ind_excl_reg { get; set; }
        public string ind_cons_reg { get; set; }
        public string ind_execute { get; set; }
        public DateTime dt_inclusao { get; set; }
        public DateTime dt_alteracao { get; set; }
        public string id_usu_incl { get; set; }
        public string id_usu_alt { get; set; }
    }
}
