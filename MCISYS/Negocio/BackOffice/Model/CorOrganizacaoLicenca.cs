using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MCISYS.Negocio.BackOffice.Model
{
    public class CorOrganizacaoLicenca
    {
        public int ID_ORG { set; get; }
        public int NR_CNPJ_RAIZ { set; get; }
        public int DS_AMBIENTE { set; get; }
        public string DS_AMBIENTE_DESC { set; get; }
        public string DS_SIGLA { set; get; }
        public DateTime DT_LICENCIAMENTO { set; get; }
    }
}
