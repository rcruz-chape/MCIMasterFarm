using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MCIMasterFarm.Negocio.BackOffice.Negocio;
using MCIMasterFarm.Negocio.BackOffice.DAL;
using MCIMasterFarm.Negocio.Global;
using MCIMasterFarm.Negocio.BackOffice.Model;
using MCISYS.Negocio.BackOffice.Model;
using MCISYS.Negocio.BackOffice.DAL;

namespace MCISYS.Negocio.BackOffice.Negocio
{
    public class SisFuncaoNEG
    {
        private SisFuncaoDAL vSisFuncaoDAL = new SisFuncaoDAL();
        public List<SisFuncao> GetFuncaoTodos(ref Banco pBanco)
        {
            return vSisFuncaoDAL.ObtemListaFuncao(ref pBanco);
        }
        public List<SisFuncao> GetFuncaoHabilitada(ref Banco pBanco, int pidPapel, int pidMod, int pidSIS)
        {
            return vSisFuncaoDAL.ObtemListaFuncaoHabilitados(ref pBanco, pidPapel, pidMod, pidSIS);
        }
        public Boolean bInserePapel(ref Banco pBanco, SisFuncao pSisFuncao)
        {
            var vSisFuncao = pSisFuncao;
            if (vSisFuncao.id_funcao == null)
            {
                vSisFuncao.id_funcao = Convert.ToInt32(vSisFuncaoDAL.vSequence.sqMax(vSisFuncaoDAL.vSeq.NomeColuna,
                                                                                     vSisFuncaoDAL.vSeq.NomeTabela, ref pBanco));
                    
            }
            return vSisFuncaoDAL.fbInsereFuncao(ref pBanco, vSisFuncao);

        }
        public Boolean bInsereListaFuncao(ref Banco pBanco, List<SisFuncao> pListFuncao)
        {
            return vSisFuncaoDAL.fbInsereGrupoFuncao(ref pBanco, pListFuncao);
        }
        public Boolean bImplementaFuncao(ref Banco pBanco)
        {
            var vListFuncao = ListFuncaoImplementar();
            return bInsereListaFuncao(ref pBanco, vListFuncao);
        }
        private List<SisFuncao> ListFuncaoImplementar(List<SisFuncao> pListFuncao = null)
        {
            List<SisFuncao> vListaFuncaoImplementar = new List<SisFuncao>();

            if (pListFuncao == null)
            {
                vListaFuncaoImplementar.Add(fsCriaOrg());
                vListaFuncaoImplementar.Add(fsAssociaOrgPapel());
                vListaFuncaoImplementar.Add(fsAssociaOrgUsuario());
                vListaFuncaoImplementar.Add(fsCriaPapel());
                vListaFuncaoImplementar.Add(fsAssociaPapelOrg());
                vListaFuncaoImplementar.Add(fsAssociaPapelUsuario());
                vListaFuncaoImplementar.Add(fsCriaUsuario());
                vListaFuncaoImplementar.Add(fsAssociaOrgPapelUsuario());
            }
            else
            {
                vListaFuncaoImplementar = pListFuncao;
            }
            return vListaFuncaoImplementar;
        }
        private SisFuncao fsAssociaOrgPapelUsuario()
        {
            SisFuncao vsAssociaOrgPapelUsuario = new SisFuncao();
            vsAssociaOrgPapelUsuario.ds_funcao = "Associa Usuário Org Papel";
            vsAssociaOrgPapelUsuario.dt_alteracao = DateTime.Now;
            vsAssociaOrgPapelUsuario.dt_inclusao = DateTime.Now;
            vsAssociaOrgPapelUsuario.id_usu_alt = "admin";
            vsAssociaOrgPapelUsuario.id_usu_incl = "admin";
            vsAssociaOrgPapelUsuario.ind_cons_reg = "N";
            vsAssociaOrgPapelUsuario.ind_excl_reg = "N";
            vsAssociaOrgPapelUsuario.ind_execute = "S";
            vsAssociaOrgPapelUsuario.ind_incl_alt = "N";
            vsAssociaOrgPapelUsuario.ind_incl_reg = "N";
            vsAssociaOrgPapelUsuario.nm_funcao = "AssociaOrgPapUsu";
            return vsAssociaOrgPapelUsuario;
        }
        private SisFuncao fsCriaUsuario()
        {
            SisFuncao vsCriarUsuario = new SisFuncao();
            vsCriarUsuario.ds_funcao = "Cria Usuário";
            vsCriarUsuario.dt_alteracao = DateTime.Now;
            vsCriarUsuario.dt_inclusao = DateTime.Now;
            vsCriarUsuario.id_usu_alt = "admin";
            vsCriarUsuario.id_usu_incl = "admin";
            vsCriarUsuario.ind_cons_reg = "S";
            vsCriarUsuario.ind_excl_reg = "S";
            vsCriarUsuario.ind_execute = "N";
            vsCriarUsuario.ind_incl_alt = "S";
            vsCriarUsuario.ind_incl_reg = "S";
            vsCriarUsuario.nm_funcao = "CriaUsu";
            return vsCriarUsuario;
        }

        private SisFuncao fsAssociaPapelUsuario()
        {
            SisFuncao vsAssociaPapelUsuario = new SisFuncao();
            vsAssociaPapelUsuario.ds_funcao = "Associa Usuário Papel";
            vsAssociaPapelUsuario.dt_alteracao = DateTime.Now;
            vsAssociaPapelUsuario.dt_inclusao = DateTime.Now;
            vsAssociaPapelUsuario.id_usu_alt = "admin";
            vsAssociaPapelUsuario.id_usu_incl = "admin";
            vsAssociaPapelUsuario.ind_cons_reg = "N";
            vsAssociaPapelUsuario.ind_excl_reg = "N";
            vsAssociaPapelUsuario.ind_execute = "S";
            vsAssociaPapelUsuario.ind_incl_alt = "N";
            vsAssociaPapelUsuario.ind_incl_reg = "N";
            vsAssociaPapelUsuario.nm_funcao = "AssociaPapUsu";
            return vsAssociaPapelUsuario;
        }
        private SisFuncao fsAssociaPapelOrg()
        {
            SisFuncao vsAssociaPapelOrg = new SisFuncao();
            vsAssociaPapelOrg.ds_funcao = "Associa Organizações Papel";
            vsAssociaPapelOrg.dt_alteracao = DateTime.Now;
            vsAssociaPapelOrg.dt_inclusao = DateTime.Now;
            vsAssociaPapelOrg.id_usu_alt = "admin";
            vsAssociaPapelOrg.id_usu_incl = "admin";
            vsAssociaPapelOrg.ind_cons_reg = "N";
            vsAssociaPapelOrg.ind_excl_reg = "N";
            vsAssociaPapelOrg.ind_execute = "S";
            vsAssociaPapelOrg.ind_incl_alt = "N";
            vsAssociaPapelOrg.ind_incl_reg = "N";
            vsAssociaPapelOrg.nm_funcao = "AssociaPapOrg";
            return vsAssociaPapelOrg;
        }
        private SisFuncao fsCriaPapel()
        {
            SisFuncao vsCriarPapel = new SisFuncao();
            vsCriarPapel.ds_funcao = "Cria, Associa  Papeis";
            vsCriarPapel.dt_alteracao = DateTime.Now;
            vsCriarPapel.dt_inclusao = DateTime.Now;
            vsCriarPapel.id_usu_alt = "admin";
            vsCriarPapel.id_usu_incl = "admin";
            vsCriarPapel.ind_cons_reg = "S";
            vsCriarPapel.ind_excl_reg = "S";
            vsCriarPapel.ind_execute = "N";
            vsCriarPapel.ind_incl_alt = "S";
            vsCriarPapel.ind_incl_reg = "S";
            vsCriarPapel.nm_funcao = "CriaPap";
            return vsCriarPapel;
        }
        private SisFuncao fsAssociaOrgUsuario()
        {
            SisFuncao vsAssociaOrgUsuario = new SisFuncao();
            vsAssociaOrgUsuario.ds_funcao = "Associa Usuario Organizações";
            vsAssociaOrgUsuario.dt_alteracao = DateTime.Now;
            vsAssociaOrgUsuario.dt_inclusao = DateTime.Now;
            vsAssociaOrgUsuario.id_usu_alt = "admin";
            vsAssociaOrgUsuario.id_usu_incl = "admin";
            vsAssociaOrgUsuario.ind_cons_reg = "N";
            vsAssociaOrgUsuario.ind_excl_reg = "N";
            vsAssociaOrgUsuario.ind_execute = "S";
            vsAssociaOrgUsuario.ind_incl_alt = "N";
            vsAssociaOrgUsuario.ind_incl_reg = "N";
            vsAssociaOrgUsuario.nm_funcao = "AssociaOrgUsu";
            return vsAssociaOrgUsuario;
        }
        private SisFuncao fsAssociaOrgPapel()
        {
            SisFuncao vsAssociaOrgPapel = new SisFuncao();
            vsAssociaOrgPapel.ds_funcao = "Associa Papel Organizações";
            vsAssociaOrgPapel.dt_alteracao = DateTime.Now;
            vsAssociaOrgPapel.dt_inclusao = DateTime.Now;
            vsAssociaOrgPapel.id_usu_alt = "admin";
            vsAssociaOrgPapel.id_usu_incl = "admin";
            vsAssociaOrgPapel.ind_cons_reg = "N";
            vsAssociaOrgPapel.ind_excl_reg = "N";
            vsAssociaOrgPapel.ind_execute = "S";
            vsAssociaOrgPapel.ind_incl_alt = "N";
            vsAssociaOrgPapel.ind_incl_reg = "N";
            vsAssociaOrgPapel.nm_funcao = "AssociaOrgPap";
            return vsAssociaOrgPapel;
        }
        private SisFuncao fsCriaOrg()
        {
            SisFuncao vsCriarOrg = new SisFuncao();
            vsCriarOrg.ds_funcao = "Cria, Associa  Organizações";
            vsCriarOrg.dt_alteracao = DateTime.Now;
            vsCriarOrg.dt_inclusao = DateTime.Now;
            vsCriarOrg.id_usu_alt = "admin";
            vsCriarOrg.id_usu_incl = "admin";
            vsCriarOrg.ind_cons_reg = "S";
            vsCriarOrg.ind_excl_reg = "S";
            vsCriarOrg.ind_execute = "N";
            vsCriarOrg.ind_incl_alt = "S";
            vsCriarOrg.ind_incl_reg = "S";
            vsCriarOrg.nm_funcao = "CriaOrg";
            return vsCriarOrg;
        }
    }
}
