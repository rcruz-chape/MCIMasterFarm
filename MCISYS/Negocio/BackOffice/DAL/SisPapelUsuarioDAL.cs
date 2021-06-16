using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MCIMasterFarm.Negocio.Global;
using MCISYS.Negocio.BackOffice.Model;
using MCIMasterFarm.Negocio.BackOffice.Sequence;
using MCIMasterFarm.Negocio.BackOffice.Model;
using MCIMasterFarm.Negocio.BackOffice.DAL;

namespace MCISYS.Negocio.BackOffice.DAL
{
    public class SisPapelUsuarioDAL
    {
        private Connect vConnect = new Connect();
        public Boolean bInsert(ref Banco pBanco, SisPapelUsuario pSisPapel)
        {
            string vsSql = @"INSERT INTO SIS_PAPEL_USUARIO
                                (ID_PAPEL, ID_USU)
                              VALUES 
                                (@ID_PAPEL, @ID_USU)";
            var Parametro = new Dictionary<string, dynamic>()
            {
                {"ID_PAPEL", pSisPapel.ID_PAPEL },
                {"ID_USU", pSisPapel.ID_USU }
            };
            return vConnect.insert(ref pBanco, vsSql, Parametro);
        }
        public Boolean bExclue(ref Banco pBanco, SisPapelUsuario pSisPapel)
        {
            string vsSql = @"DELETE FROM SIS_PAPEL_USUARIO
                              WHERE ID_PAPEL = @ID_PAPEL
                                AND ID_USU = @ID_USU";
            var Parametro = new Dictionary<string, dynamic>()
            {
                {"ID_PAPEL", pSisPapel.ID_PAPEL },
                {"ID_USU", pSisPapel.ID_USU }
            };
            return vConnect.delete(ref pBanco, vsSql, Parametro);
        }
    }
}
