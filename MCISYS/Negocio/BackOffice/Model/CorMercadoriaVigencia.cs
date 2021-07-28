using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MCISYS.Negocio.BackOffice.Model
{
    public class CorMercadoriaVigencia
    {
        public int ID_ORG { set; get; }
        public long COD_MERC { set; get; }
        public DateTime DATA_INI_VIG { set; get; }
        public DateTime DATA_FIM_VIG { set; get; }
        public string COD_NCM { get; set; }
        public int COD_GENE_MERC { set; get; }
        public string COD_UM { set; get; }
        public int ID_GRP_MERC { set; get; }
        public int ID_SUBGRP_MERC { set; get; }
        public string NM_MERC { set; get; }
        public string NM_MERC_REDUZIDO { set; get; }
        public string IND_TIPO_PROD { set; get; }



    }
}
