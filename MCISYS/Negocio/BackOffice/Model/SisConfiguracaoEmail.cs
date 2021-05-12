using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MCIMasterFarm.Negocio.BackOffice.Model
{
    public class SisConfiguracaoEmail
    {
        public string DS_HOST { set; get; }
        public int NR_PORT { set; get; }
        public Boolean BO_ENABLE_SSL { set; get; }
        public Boolean BO_USE_DEFAULT_CREDENTIALS { set; get; }
        public string DS_EMAIL { set; get; }
        public string DS_SENHA { set; get; }
    }
}
