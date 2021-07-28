using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MCISYS.Negocio.BackOffice.Model
{
    public class CorMercadoria
    {
        public int ID_ORG { set; get; }
        public long COD_MERC { set; get; }
        public string COD_EAN { set; get; }        
        public int COD_GENE_MERC { set; get; }
        public int ID_GRP_MERC { set; get; }
        public int ID_SUBGRP_MERC { set; get; }
        public string IND_TIPO_MERC { set; get; }
        public string IND_TIPO_PROD { set; get; }
        public string NM_MERC { set; get; }
        public string NM_MERC_REDUZIDO { set; get; }
        public string IND_FORA_LINHA { set; get; }
        public string COD_UM { set; get; }
        public Decimal VL_PESO_BRUTO { set; get; }
        public Decimal VL_PESO_LIQUIDO { set; get; }
        public Decimal QTD_ESTOQUE_MINIMO { set; get; }
        public Decimal QTD_ESTOQUE_MAXIMO { set; get; }
        public DateTime DT_DESATIVACAO { set; get; }
        public string ID_USU_DESATIVA { set; get; }
        public DateTime DT_INCLUSAO { set; get; }
        public string ID_USU_INCL { set; get; }
        public DateTime DT_ALTERCAO { set; get; }
        public string ID_USU_ALT { set; get; }


    }
}
