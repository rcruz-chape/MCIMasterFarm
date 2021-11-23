using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MCISYS.DictionarysVersion
{
    public class VersionDict
    {
        public string GetVersaoImplementar(string nrVersio)
        {
            string vReturn = "";
            switch(nrVersio)
            {
                case "1.0.0.0":
                    var vVersion = new V_1_0_0_0();
                    break;
            }
            return vReturn;
        }
    }
}
