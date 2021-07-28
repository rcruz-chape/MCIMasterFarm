using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MCISYS.Negocio.BackOffice.Model
{
    public class CorGeneroMercadoria
    {
        public int COD_GENE_MERC { get; set; }
        public string DS_COD_GENE_MERC { get; set; }
        public string DS_GENE_MERC { get; set; }
        public DateTime DATA_INI_VIG { get; set; }
        public DateTime? DATA_FIM_VIG { get; set; }
    }
}
