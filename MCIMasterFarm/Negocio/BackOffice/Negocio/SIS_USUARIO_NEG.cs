using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MCIMasterFarm.Negocio.BackOffice.DAL;
using MCIMasterFarm.Negocio.BackOffice.Model;
using MCIMasterFarm.Negocio.BackOffice.DadosAcesso;
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
        int iMaximoLoginSemSucesso = 3;

        public SisUsuario loginSucesso(SisUsuario psisUsuario, ref Banco pBanco)
        {
            var vSysDal = new SIS_USUARIO_DAL();
            SisUsuario vSisUsuario = psisUsuario;
            vSisUsuario.dt_last_login = DateTime.Now;
            vSisUsuario.qtd_login_sem_sucesso = 0;
           
            Boolean bSucesso = vSysDal.atualizaUsuario(vSisUsuario, ref pBanco);
            vSisUsuario = vSysUsuDal(vSisUsuario.id_usu,ref  pBanco);
            return vSisUsuario;

        }
        
        public Boolean BloqueiaUsuario(SisUsuario pSisUsuario, ref Banco pBanco, int piMotivoBloqueio)
        {
            var vSysUsuDal = new SIS_USUARIO_DAL();
            SisUsuario vsisUsuario = pSisUsuario;
            vsisUsuario.ind_bloqueado = sUsuarioBloqueado;
            vsisUsuario.ind_motivo_bloqueio = piMotivoBloqueio;
            return vSysUsuDal.bloqueiaUsuario(vsisUsuario, ref pBanco);

        }
        
        public Boolean LoginSemSucesso(SisUsuario pSisUsuario, ref Banco pBanco)
        {
            SisUsuario vSisUsuario = new SisUsuario();
            vSisUsuario = pSisUsuario;
            if (vSisUsuario.qtd_login_sem_sucesso == null)
            {
                vSisUsuario.qtd_login_sem_sucesso = 0;
            }
            vSisUsuario.qtd_login_sem_sucesso += 1;
            var vSisUsuDal = new SIS_USUARIO_DAL();
            Boolean vbLoginSemSucesso = true;
            vbLoginSemSucesso = vSisUsuDal.atualizaUsuario(vSisUsuario, ref pBanco);
            if (vSisUsuario.qtd_login_sem_sucesso >= iMaximoLoginSemSucesso)
            {
                vSisUsuario.ind_bloqueado = sUsuarioBloqueado;
                vSisUsuario.ind_motivo_bloqueio = iTentativaExcedida;
                vbLoginSemSucesso = !vSisUsuDal.bloqueiaUsuario(vSisUsuario, ref pBanco);
            }
            return vbLoginSemSucesso;
        }
        
        public Boolean RealizaDesbloqueio(SisUsuario pSisUsuario, ref Banco pBanco)
        { 
            var vSISUSUDAL = new SIS_USUARIO_DAL();
            return vSISUSUDAL.DesbloqueiaUSuario(pSisUsuario, ref pBanco);
        }

        public Boolean ALteraSenhaUsuario(SisUsuario psusUsuario, ref Banco PBanco)
        {
            var vSISUSUDAL = new SIS_USUARIO_DAL();
            return vSISUSUDAL.AtualizaSenha(psusUsuario,ref PBanco);
        }
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
                {
                    bVerificaUsuarioBloqueado = false;
                }
            }
            return bVerificaUsuarioBloqueado;
        }
        public string defineSenhaUsuario(ref Banco pBanco, SisParametro sisParametro,  ref SisUsuario pSisUSuario)
        {
            string caracteresPermitidos = "abcdefghijkmnopqrstuvwxyzABCDEFGHJKLMNOPQRSTUVWXYZ0123456789!@$?_ - ";
            SisUsuario vSisUsuario = pSisUSuario;
            char[] chars = new char[sisParametro.ind_total_car];
            Random sRd = new Random();
            for (int i = 0; i < sisParametro.ind_total_car; i ++)
            {
                chars[i] = caracteresPermitidos[sRd.Next(0, caracteresPermitidos.Length)];
            }
            string senhaAlterada = new string(chars);
            var Criptografia = new Criptografia();

            vSisUsuario.ds_pwd = Criptografia.CritografiaDados(senhaAlterada);
            var vSisUsuDal = new SIS_USUARIO_DAL();
            Boolean vbAlteraSenha = vSisUsuDal.AtualizaSenha(pSisUSuario, ref pBanco);
            pSisUSuario = vSisUsuario;

            return senhaAlterada;
        }
        public Boolean bloqueiaSenhaExpirada(SisUsuario pSisUsuario, ref Banco pBanco)
        {
            var vSISUSUDAL = new SIS_USUARIO_DAL();
            var vSisUsuario = pSisUsuario;
            vSisUsuario.ind_motivo_bloqueio = iSenhaExpirada;
            return vSISUSUDAL.bloqueiaUsuario(vSisUsuario,ref pBanco);
        }
        public SisUsuario ObtemUSuarioPorEmailUsuario(string pIDUSUEmail, ref Banco pBanco)
        {
            string vsIDUSU = "";
            string vsEMail = "";
            if (pIDUSUEmail.Contains("@"))
            { 
                vsEMail = pIDUSUEmail;
            }
            else
            {
                vsIDUSU = pIDUSUEmail;
            }
            var SisUsuarioDAL = new SIS_USUARIO_DAL();
            var vSisUsuario = SisUsuarioDAL.ObtemUsuarioReiniciaSenha(vsIDUSU, vsEMail, ref pBanco);
            var bBLoqueia = bloqueiaSenhaExpirada(vSisUsuario, ref pBanco);
            return vSisUsuario;
        }

    }
}
