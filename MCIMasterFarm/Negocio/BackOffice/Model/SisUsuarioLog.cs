using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MCIMasterFarm.Negocio.BackOffice.Model
{
    public class SisUsuarioLog
    {
        public string ID_USU { set; get; }
        public DateTime DT_LOGIN { set; get; }
        public string DS_HOSTNAME { set; get; }
        public string DS_OS { set; get; }
        public string DS_MAC_ADDRESS { set; get; }
        public string DS_IP_ADDRESS { set; get; }
    }
}
