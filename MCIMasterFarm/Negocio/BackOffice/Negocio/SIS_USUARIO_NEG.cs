using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MCIMasterFarm.Negocio.BackOffice.DAL;
using MCIMasterFarm.Negocio.BackOffice.Model;
using MCIMasterFarm.Negocio.Telas;
using MCIMasterFarm.Negocio.Global;

namespace MCIMasterFarm.Negocio.BackOffice.Negocio
{
    public class SIS_USUARIO_NEG
    {
        string sUsuarioBloqueado = "S";
        string sUsuarioDesBloqueado = "N";
        int iInatividade = 0;
        int iTentativaExcedida = 1;
        public int iSenhaExpirada = 2;
        

        public SisUsuario vSysUsuDal(string pIDUSu, ref Banco pBanco)
        {
            var vSISUSUDal = new SIS_USUARIO_DAL();
            return vSISUSUDal.obtemUsuario(pIDUSu, ref pBanco);
        }
        public Boolean vSysUsuAdmin(ref Banco pBanco)
        {
            var vSISUSUDal = new SIS_USUARIO_DAL();
            var sisUsu = vSISUSUDal.obtemUsuario("admin", ref pBanco);
            return sisUsu.id_usu != null;

        }
        public Boolean fbVerificaUsuarioBloqueado(SisUsuario pRegSisUsuario,ref Banco pBanco)
        {
            Boolean bVerificaUsuarioBloqueado = true;
            if (pRegSisUsuario.ind_bloqueado == sUsuarioBloqueado)
            {
                if (pRegSisUsuario.ind_motivo_bloqueio == iSenhaExpirada)
                {
                    frm_Senha_Expirada FrmSenhaExpirada = new frm_Senha_Expirada(pRegSisUsuario, ref pBanco);
                    FrmSenhaExpirada.Show();
                    bVerificaUsuarioBloqueado = false;
                }
                else
                {
                    bVerificaUsuarioBloqueado = false;
                }
            }
            return bVerificaUsuarioBloqueado;
        }

    }
}
