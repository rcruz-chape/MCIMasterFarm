using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MCIMasterFarm.Negocio.BackOffice.Model;
using MCIMasterFarm.Negocio.Global;

namespace MCIMasterFarm.Negocio.BackOffice.DAL
{
    public class SIS_PARAMETRO_DAL
    { 

        public SisParametro getParametro(ref Banco pBanco)
        {
            SisParametro vParametro = new SisParametro();
            string vsSql = @"SELECT PAR.DS_CAR_ESPECIAL
                                  , PAR.IND_CAR_MAIUSCULO 
  	                              , PAR.IND_CAR_MINUSCULO 
  	                              , PAR.IND_NUMERO 
                                  , PAR.IND_TOTAL_CAR 
                               FROM SIS_PARAMETRO PAR";
            var cnnParametro = new Connect();
            var regParametro = cnnParametro.ObtemUnico(ref pBanco, vsSql);
            //.ObtemUnico(ref pBanco, vsSql)
            if (regParametro.HasRows)
            { 
                regParametro.Read();
                if (!regParametro.IsDBNull(regParametro.GetOrdinal("DS_CAR_ESPECIAL")))
                {
                    vParametro.ds_car_especial = (string)regParametro.GetValue(regParametro.GetOrdinal("DS_CAR_ESPECIAL"));
                }
                if (!regParametro.IsDBNull(regParametro.GetOrdinal("IND_CAR_MAIUSCULO")))
                {
                    vParametro.ind_car_maisculo  = (int)regParametro.GetValue(regParametro.GetOrdinal("IND_CAR_MAIUSCULO"));
                }
                if (!regParametro.IsDBNull(regParametro.GetOrdinal("IND_CAR_MINUSCULO")))
                {
                    vParametro.ind_car_minisculo = (int)regParametro.GetValue(regParametro.GetOrdinal("IND_CAR_MINUSCULO"));
                }
                if (!regParametro.IsDBNull(regParametro.GetOrdinal("IND_NUMERO")))
                {
                    vParametro.ind_numero  = (int)regParametro.GetValue(regParametro.GetOrdinal("IND_NUMERO"));
                }
                if (!regParametro.IsDBNull(regParametro.GetOrdinal("IND_TOTAL_CAR")))
                {
                    vParametro.ind_total_car  = (int)regParametro.GetValue(regParametro.GetOrdinal("IND_TOTAL_CAR"));
                }
            }
            else
            {
                vParametro = MontaParametro(vParametro);
                Boolean vInsert = insertParametro(ref pBanco, vParametro);
            }
            cnnParametro.FechaConnection(ref cnnParametro.vConnect);
            return vParametro;
        }
        public SisParametro MontaParametro (SisParametro pParametro)
        {
            SisParametro vParametro = pParametro;
            vParametro.ds_car_especial = "S";
            vParametro.ind_car_maisculo = 1;
            vParametro.ind_car_minisculo = 1;
            vParametro.ind_numero = 1;
            vParametro.ind_total_car = 8;

            return vParametro;
        }
        public Boolean insertParametro(ref Banco pBanco, SisParametro pParametro)
        {
            string vsSql = @"INSERT INTO SIS_PARAMETRO
                                  ( DS_CAR_ESPECIAL
                                  , IND_CAR_MAIUSCULO
                                  , IND_CAR_MINUSCULO
                                  , IND_NUMERO
                                  , IND_TOTAL_CAR
                                  )
                             VALUES
                                  ( @DS_CAR_ESPECIAL
                                  , @IND_CAR_MAIUSCULO
                                  , @IND_CAR_MINUSCULO
                                  , @IND_NUMERO
                                  , @IND_TOTAL_CAR
                                  )";
            var parametros = new Dictionary<string, dynamic>()
            {
                { "DS_CAR_ESPECIAL", pParametro.ds_car_especial },
                { "IND_CAR_MAIUSCULO", pParametro.ind_car_maisculo },
                { "IND_CAR_MINUSCULO", pParametro.ind_car_minisculo },
                { "IND_NUMERO", pParametro.ind_numero },
                { "IND_TOTAL_CAR", pParametro.ind_total_car },
            };
            var vConnect = new Connect();
            return vConnect.insert(ref pBanco, vsSql, parametros);
        }
        public Boolean bUpdateParametro(ref Banco pBanco, SisParametro pParametro )
        {
            string vsSql = @"UPDATE SIS_PARAMETRO
                                SET DS_CAR_ESPECIAL = @DS_CAR_ESPECIAL
                                  , IND_CAR_MAIUSCULO = @IND_CAR_MAIUSCULO
                                  , IND_CAR_MINUSCULO = @IND_CAR_MINUSCULO
                                  , IND_NUMERO = @IND_NUMERO
                                  , IND_TOTAL_CAR = IND_TOTAL_CAR";
            var parametros = new Dictionary<string, dynamic>()
            {
                { "DS_CAR_ESPECIAL", pParametro.ds_car_especial },
                { "IND_CAR_MAIUSCULO", pParametro.ind_car_maisculo },
                { "IND_CAR_MINUSCULO", pParametro.ind_car_minisculo },
                { "IND_NUMERO", pParametro.ind_numero },
                { "IND_TOTAL_CAR", pParametro.ind_total_car },
            };
            var vConnect = new Connect();
            return vConnect.update(ref pBanco, vsSql, parametros);
        }
    }
}
