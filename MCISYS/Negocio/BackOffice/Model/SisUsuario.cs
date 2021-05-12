using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MCIMasterFarm.Negocio.BackOffice.Model
{
    public class SisUsuario
    {
        public string id_usu { get; set; }
        public string nm_usu { get; set; }
        public string ds_email { get; set; }
        public Nullable<DateTime> dt_last_login { get; set; }
        public string ds_pwd { get; set; }
        public string ind_bloqueado { get; set; }
        public int ind_motivo_bloqueio { get; set; }
        public int? qtd_login_sem_sucesso { get; set; }
        public int? id_pessoa_fisica { get; set; }
        public DateTime? dt_inclusao { get; set; }
        public DateTime? dt_alteracao { get; set; }
        public string id_usu_incl { get; set; }
        public string id_usu_alt { get; set; }





    }
}
