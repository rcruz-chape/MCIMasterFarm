using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MCIMasterFarm.Negocio.BackOffice.Model
{
    public class Configuracao
    {   
        public string DS_ACAO { set; get; }
        public long NR_KEYCODE { set; get; }
        public string NM_FUNCAO { set; get; }
    }
    public class ConfigAcao
    {
        public string DS_TECLA_SALVAR { set; get; }
        public string DS_TECLA_EXCLUIR { set; get; }
        public string DS_TECLA_NOVO { set; get; }
        public string DS_TECLA_CAMPOPESQ { set; get; }
        public string DS_PESQ_REGISTRO { set; get; }
        public string DS_PESQ_PROXIMO { set; get; }
        public string DS_PESQ_ANTERIOR { set; get; }

    }
}
