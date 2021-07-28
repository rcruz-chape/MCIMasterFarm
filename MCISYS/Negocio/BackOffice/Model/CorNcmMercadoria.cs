using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MCISYS.Negocio.BackOffice.Model
{
    public class CorNcmMercadoria
    {
        public string COD_NCM { set; get; }
        public int COD_GENE_MERC { set; get; }
        public string DS_NCM { set; get; }
        public DateTime DATA_INICIO_VIG { set; get; }
        public DateTime DATA_FINAL_VIG { set; get; }
    }
}
