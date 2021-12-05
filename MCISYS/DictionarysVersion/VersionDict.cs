using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MCIMasterFarm.Negocio.Global;
using MCISYS.Negocio.BackOffice.Model;
using MCIMasterFarm.Negocio.BackOffice.Model;
using MCIMasterFarm.Negocio.BackOffice.Negocio;
using MCISYS.Negocio.BackOffice.Negocio;

namespace MCISYS.DictionarysVersion
{
    public class VersionDict
    {
        public string ImplementaBanco(ref Banco pBanco, string nrVersio)
        {
            string vReturn = "NOK";

            switch (nrVersio)
            {
                case "1.0.0.0":
                    var vVersionNEg = new V_1_0_0_0_NEG();
                    vReturn = vVersionNEg.ImplementaDDL(ref pBanco);
                    break;
            }
            return vReturn;
        }
        public string CargaDado(ref Banco pBanco, string nrVersio)
        {

            string vReturn = "NOK";

            switch (nrVersio)
            {
                case "1.0.0.0":
                    var vVersionNEg = new V_1_0_0_0_NEG();
                    vReturn = vVersionNEg.CargaDeDados(ref pBanco);
                    break;
            }
            return vReturn;
        
        }
    }
}
