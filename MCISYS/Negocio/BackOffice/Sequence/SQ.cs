using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MCIMasterFarm.Negocio.BackOffice.Sequence
{
    public class SQ
    {
        public class SQModulo
        {
            public string NomeColuna = "ID_MOD";
            public string NomeTabela = "SIS_MODULO";
            public string NomeColunaWhere = "ID_SIS";
        }
        public class SQFuncao
        {
            public string NomeColuna = "ID_FUNCAO";
            public string NomeTabela = "SIS_FUNCAO";
        }
        public class SQOrg
        {
            public string NomeColuna = "ID_ORG";
            public string NomeTabela = "COR_ORGANIZACAO";
        }

    }
}
