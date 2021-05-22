using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MCISYS.Negocio.BackOffice.Model
{
    public class SisFuncaoImplementar
    {
		public int ID_SIS { get; set; }
		public int ID_MOD { get; set; }
		public int ID_FUNCAO { get; set; }
		public string NM_FUNCAO { get; set; }
		public string DS_FUNCAO { get; set; }
		public string IND_INCL_REG { get; set; }
		public string IND_INCL_ALT { get; set; }
		public string IND_EXCL_REG { get; set; }
		public string IND_CONS_REG { get; set; }
		public string IND_EXECUTE { get; set; }

	}
}
