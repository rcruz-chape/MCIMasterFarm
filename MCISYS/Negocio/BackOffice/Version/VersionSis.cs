using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using MCIMasterFarm.Negocio.BackOffice.Negocio;
using MCIMasterFarm.Negocio.BackOffice.DAL;
using MCIMasterFarm.Negocio.Global;
using MCIMasterFarm.Negocio.BackOffice.Model;
using MCISYS.Negocio.BackOffice.Model;
using MCISYS.Negocio.BackOffice.DAL;

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
        public string GetVersionBD(ref Banco pBanco)
        {
            DictionaryDAL vDic = new DictionaryDAL();
            return vDic.NrSisVersao(ref pBanco);
        }
        public Boolean VersaoEquivalente(string vnrVersaoExe, string vnrVErsaoBD)
        {
            return (vnrVErsaoBD == vnrVersaoExe);
        }
    }
}
