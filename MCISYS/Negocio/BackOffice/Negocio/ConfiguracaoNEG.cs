﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MCIMasterFarm.Negocio.BackOffice.Model;
using MCIMasterFarm.Negocio.BackOffice.DAL;
using MCIMasterFarm.Negocio.Global;

namespace MCIMasterFarm.Negocio.BackOffice.Negocio
{
    public class ConfiguracaoNEG
    {
        ConfiguracaoDAL vConfiguracaoDAL = new ConfiguracaoDAL();
        public List<Configuracao> RecuperaConfiguracao(ref Banco pBanco)
        {
            return vConfiguracaoDAL.ObtemConfig(ref pBanco);
        }
        public ConfigAcao RecuperaConfigAcao()
        {
            return vConfiguracaoDAL.RetornaConfigAcao();
        }
        public Boolean InsertConftECLA(ref Banco pBanco, List<ConfiguracaoTecla> pListConfiguracao)
        {
            Boolean vInsert = true;
            foreach (var RecConf in pListConfiguracao)
            {
                vInsert = vConfiguracaoDAL.InsereCOnfiguracaoTecla(ref pBanco, RecConf);
            }
            return vInsert;
        }
        public Boolean InsertConf(ref Banco pBanco, List<Configuracao> pListConfiguracao)
        {
            Boolean vInsert = true;
            foreach(var RecConf in pListConfiguracao)
            {
                vInsert = vConfiguracaoDAL.InsereCOnfiguracao(ref pBanco, RecConf);
            }
            return vInsert;
        }
    }
}
