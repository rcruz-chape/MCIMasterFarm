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
            public string NomeTabela = "NM_MOD";
            public string NomeColunaWhere = "ID_SIS";
        }
        public class SQFuncao
        {
            public string NomeSequence = "func_sq";
        }

    }
}
