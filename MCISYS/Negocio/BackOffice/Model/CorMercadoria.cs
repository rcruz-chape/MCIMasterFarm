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
        public Decimal QTD_ESTOQUE_REAL { set; get; }
        public Decimal QTD_ESTOQUE_CONTABIL { set; get; }
        public Decimal QTD_ESTOQUE_MINIMO { set; get; }
        public Decimal QTD_ESTOQUE_MAXIMO { set; get; }
        public Decimal VL_ALI_IPI { set; get; }
        public Decimal VL_ALI_ISS { set; get; }
        public Decimal VL_ALI_ICMS_UF { set; get; }
        public Decimal VL_NR_ALTURA { get; set; }
        public Decimal VL_NR_LARGURA { get; set; }
        public Decimal VL_NR_COMPRIMENTO { get; set; }
        public Decimal VL_NR_ESPESSURA { get; set; }
        public Decimal VL_NR_PROFUNDIDADE { get; set; }
        public Decimal VL_NR_DIAMETRO { get; set; }
        public Decimal VL_CUSTO_REPOSICAO { get; set; }
        public Decimal VL_BASE_VENDA { get; set; }
        public Decimal VL_MINIMO_VENDA { get; set; }
        public Decimal VL_EMDOLAR { get; set; }
        public Decimal VL_PROMOCAO { get; set; }
        public Decimal VL_PROMOCAO_CONTRIBUINTE { get; set; }
        public DateTime DT_DESATIVACAO { set; get; }
        public string ID_USU_DESATIVA { set; get; }
        public DateTime DT_INCLUSAO { set; get; }
        public string ID_USU_INCL { set; get; }
        public DateTime DT_ALTERCAO { set; get; }
        public string ID_USU_ALT { set; get; }


    }
}
