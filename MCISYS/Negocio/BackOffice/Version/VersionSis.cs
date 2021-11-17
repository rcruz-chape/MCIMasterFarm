using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace MCISYS.Negocio.BackOffice.Version
{
    public class VersionSis
    {
        public  string GetVersionString()
        {
            System.Reflection.Assembly vAssembly = System.Reflection.Assembly.GetExecutingAssembly();
            var assemblyFullName = Assembly.GetExecutingAssembly().FullName;
            var version = assemblyFullName.Split(',')[1].Split('=')[1];
            return version;
        }
    }
}
