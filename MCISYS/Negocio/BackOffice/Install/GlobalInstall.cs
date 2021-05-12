using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MCIMasterFarm.Negocio.BackOffice.DadosAcesso;
using MCIMasterFarm.Negocio.Global;
using MCIMasterFarm.Negocio.BackOffice.DAL;

namespace MCIMasterFarm.Negocio.BackOffice.Install
{
    public class GlobalInstall
    {
        public string idUsuAdmin = "admin";
        public string nmUsuAdmin = "Usuário Administrador Da Instância";
        public string DsPWd = "1234";
        public string IndBloqueado = "S";
        public int IndMotBloqueio = 2;
        public DateTime dtInclusao = DateTime.Now;
        public string dsEmail = "renatomics28@gmail.com";
        public int idOrg = 1;
        public string nmOrg = "Organização Administradora da Instância";
        public string nmOrgResumido = "ORG ADM";
        public int tpOrg = 0;
        public int idPapel = 1;
        public string dsPapel = "ADMINISTRADOR";       
    }
    public class Install
    {
        public Boolean seTup(ref Banco pBanco, GlobalInstall pGlobalInstall)
        {
            Boolean vReturn = true;
            vReturn = SetupUsuAdmin(ref pBanco, pGlobalInstall);
            if (!vReturn)
            {
                return vReturn;
            }
            vReturn = SetupOrgAdministradora(ref pBanco, pGlobalInstall);
            if (!vReturn)
            {
                return vReturn;
            }
            vReturn = SetupPapelAdmin(ref pBanco, pGlobalInstall);
            if (!vReturn)
            {
                return vReturn;
            }
            vReturn = setupOrgPapelADM(ref pBanco, pGlobalInstall);
            if (!vReturn)
            {
                return vReturn;
            }
            vReturn = setupOrgUsuarioADM(ref pBanco, pGlobalInstall);
            if (!vReturn)
            {
                return vReturn;
            }
            vReturn = setupOrgPapelUsuarioADM(ref pBanco, pGlobalInstall);
            return vReturn;

        }
        private Boolean setupOrgUsuarioADM(ref Banco pBanco, GlobalInstall pGlobalInstall)
        {
            string vSql = @"insert into sis_usuario_organizacao 
			                (id_org,dt_inclusao,id_usu)
			                values
			                (@id_org,@dt_inclusao,@id_usu)";
            var vGlobalInstall = pGlobalInstall;
            var parametros = new Dictionary<string, dynamic>()
            {
                {"id_org", vGlobalInstall.idOrg },
                {"dt_inclusao", vGlobalInstall.dtInclusao.ToString("dd/MM/yyyy") },
                {"id_usu", vGlobalInstall.idUsuAdmin }
            };
            var vConnect = new Connect();
            return vConnect.insert(ref pBanco, vSql, parametros);
        }
        private Boolean setupOrgPapelUsuarioADM(ref Banco pBanco, GlobalInstall pGlobalInstall)
        {
            string vSql = @"insert into sis_organizacao_papel_usuario 
                			(id_org,id_papel,dt_inclusao,id_usu)
			                values
			                (@id_org,@id_papel,@dt_inclusao,@id_usu)";
            var vGlobalInstall = pGlobalInstall;
            var parametros = new Dictionary<string, dynamic>()
            {
                {"id_org", vGlobalInstall.idOrg },
                {"id_papel", vGlobalInstall.idPapel },
                {"dt_inclusao", vGlobalInstall.dtInclusao.ToString("dd/MM/yyyy") },
                {"id_usu", vGlobalInstall.idUsuAdmin }
            };
            var vConnect = new Connect();
            return vConnect.insert(ref pBanco, vSql, parametros);
        }
        private Boolean setupOrgPapelADM(ref Banco pBanco, GlobalInstall pGlobalInstall)
        {
            string vSql = @"insert into sis_organizacao_papel 
                            (id_org,id_papel,dt_inclusao)
                            values
                           (@id_org,@id_papel,@dt_inclusao)";
            var vGlobalInstall = pGlobalInstall;
            var parametros = new Dictionary<string, dynamic>()
            {
                {"id_org", vGlobalInstall.idOrg },
                {"id_papel", vGlobalInstall.idPapel },
                {"dt_inclusao", vGlobalInstall.dtInclusao.ToString("dd/MM/yyyy") }
            };
            var vConnect = new Connect();
            return vConnect.insert(ref pBanco, vSql, parametros);
        }
        private Boolean SetupUsuAdmin(ref Banco pBanco, GlobalInstall pGlobalInstall)
        {
            string vSql = @"insert into sis_usuario (id_usu, nm_usu, ds_email, ds_pwd, ind_bloqueado, ind_motivo_bloqueio, dt_inclusao)
                            values (@id_usu, @nm_usu, @ds_email, @ds_pwd, @ind_bloqueado, @ind_motivo_bloqueio, @dt_inclusao)";
            var vGlobalInstall = pGlobalInstall;
            var Cripto = new Criptografia();
            var dsPwdCritografados = Cripto.CritografiaDados(vGlobalInstall.DsPWd);
            var parametros = new Dictionary<string, dynamic>()
            {
                { "id_usu", vGlobalInstall.idUsuAdmin },
                { "nm_usu", vGlobalInstall.nmUsuAdmin },
                { "ds_email", vGlobalInstall.dsEmail },
                { "ds_pwd", dsPwdCritografados },
                { "ind_bloqueado", vGlobalInstall.IndBloqueado },
                { "ind_motivo_bloqueio", vGlobalInstall.IndMotBloqueio },
                { "dt_inclusao", vGlobalInstall.dtInclusao.ToString("dd/MM/yyyy") }
            };
            var vConnect = new Connect();
            return vConnect.insert(ref pBanco, vSql,parametros);
        }
        private Boolean SetupPapelAdmin(ref Banco pBanco, GlobalInstall pGlobalInstall)
        {
            var vGlobalInstall = pGlobalInstall;
            string vSql = @"insert into sis_papel 
                            (id_papel,ds_papel,dt_inclusao)
                            values
                            (@id_papel,@ds_papel,@dt_inclusao)";
            var parametros = new Dictionary<string, dynamic>()
            {
                {"id_papel", vGlobalInstall.idPapel },
                {"ds_papel", vGlobalInstall.dsPapel },
                {"dt_inclusao", vGlobalInstall.dtInclusao.ToString("dd/MM/yyyy") }
            };
            var vConnect = new Connect();
            return vConnect.insert(ref pBanco, vSql, parametros);
        }
        private Boolean SetupOrgAdministradora(ref Banco pBanco, GlobalInstall pGlobalInstall)
        {
            var vGlobalInstall = pGlobalInstall;
            string vSql = @"insert into cor_organizacao 
                            (id_org, nm_org,nm_org_resumido,tp_org)
                            values
                            (@id_org, @nm_org,@nm_org_resumido,@tp_org)";
            var parametros = new Dictionary<string, dynamic>()
            {
                {"id_org", vGlobalInstall.idOrg },
                {"nm_org_resumido", vGlobalInstall.nmOrgResumido },
                {"nm_org", vGlobalInstall.nmOrg },
                {"tp_org", vGlobalInstall.tpOrg }
            };
            var vConnect = new Connect();
            return vConnect.insert(ref pBanco, vSql, parametros);
        }
    }
}
