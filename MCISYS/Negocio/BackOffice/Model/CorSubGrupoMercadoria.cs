using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MCISYS.Negocio.BackOffice.Model
{
    public class CorSubGrupoMercadoria
    {
        public int ID_ORG { set; get; }
        public int ID_GRP_MERC { set; get; }
        public int ID_SUBGRP_MERC { set; get; }
        public string NM_SUBGRP_MERC { set; get; }
        public string IND_SUBGRUPO_ATIVO { set; get; }
        public string ID_USU_INCL { set; get; }
        public DateTime DT_INCLUSAO { set; get; }
        public string ID_USU_ALT { set; get; }
        public DateTime? DT_ALTERACAO {set;get;}
    }
}
