using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MCISYS.Negocio.BackOffice.Negocio
{
    public class DefaultNEG
    {
        public object NVL(object ParametroNull, object ParametroREtorno)
        {
            if (ParametroNull == null)
            {
                return ParametroREtorno;
            }
            else
            {
                return ParametroNull;
            }
        }
    }
}
