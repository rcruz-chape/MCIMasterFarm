using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MCISYS.Negocio.BackOffice.Model
{
    public class CorConjuntoMercadoria
    {
        public int ID_ORG { set; get; }
        public long COD_CONJUNTO { set; get; }
        public long COD_MERC { set; get; }
        public Decimal QTD_MERC { set; get; }
    }
}
