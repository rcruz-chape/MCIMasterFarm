using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MCIMasterFarm.Negocio.BackOffice.DAL;
using MCIMasterFarm.Negocio.BackOffice.Model;
using MCIMasterFarm.Negocio.BackOffice.DadosAcesso;
using MCISYS.Negocio.BackOffice.Model;
using MCIMasterFarm.Negocio.Telas;
using MCIMasterFarm.Negocio.Global;

namespace MCISYS.Negocio.BackOffice.Negocio
{
    public class CriaEstruturaSisNEG
    {
        SisSistemaNEG vSisSistemaNEG = new SisSistemaNEG();
        SisModuloNEG vSisModuloNEG = new SisModuloNEG();
        SisFuncaoNEG vSisFuncaoNEG = new SisFuncaoNEG();
        SisFuncaoImplementarNEG vSisFuncaoImplementar = new SisFuncaoImplementarNEG();
        SisPapelFuncaoNEG vSisPapelFuncaoNEG = new SisPapelFuncaoNEG();
        SisModuloFuncaoNEG vSisModuloFuncaoNEG = new SisModuloFuncaoNEG();       

        private Boolean fbAssociaModuloOrg(ref Banco pBanco, SisModuloNEG pSisModuloNEG, int pidOrg)
        {
            Boolean vbAssociada = true;
            var SisModuloOrganizacaoNEG = new SisModuloOrganizacaoNEG();
            var SisModuloReg = pSisModuloNEG.ObtemModulos(ref pBanco);

            List<SisModuloOrganizacao> vListModuloOrganizacao = new List<SisModuloOrganizacao>();

            foreach (var linhaSisModulo in SisModuloReg)
            {
                var RegSisModuloOrg = new SisModuloOrganizacao();
                RegSisModuloOrg.ID_MOD = linhaSisModulo.ID_MOD;
                RegSisModuloOrg.ID_SIS = linhaSisModulo.ID_SIS;
                RegSisModuloOrg.ID_ORG = pidOrg;

                vListModuloOrganizacao.Add(RegSisModuloOrg);

            }
            vbAssociada = SisModuloOrganizacaoNEG.fbAssociaUpdate(ref pBanco, vListModuloOrganizacao);
            
            return vbAssociada;
        }
        private Boolean fbAssociaModuloFuncao(ref Banco pBanco, SisModuloNEG pSisModuloNEG, SisFuncaoNEG pSisFuncaoNEG)
        {
            Boolean vbAssociada = true;
            var SisModuloFuncaoNEG = new SisModuloFuncaoNEG();
            var SisModuloReg = pSisModuloNEG.ObtemModulos(ref pBanco);
            var SisFuncaoReg = pSisFuncaoNEG.GetFuncaoTodos(ref pBanco);

            List<SisModuloFuncao> vListModuloFuncao = new List<SisModuloFuncao>();

            foreach(var linhaSisModulo in SisModuloReg)
            {
                int vidMod = linhaSisModulo.ID_MOD;
                int vidSis = linhaSisModulo.ID_SIS;
                
                foreach(var linhaSisFuncao in SisFuncaoReg)
                {
                    SisModuloFuncao RegModuloFuncao = new SisModuloFuncao();
                    RegModuloFuncao.ID_FUNCAO = linhaSisFuncao.id_funcao;
                    RegModuloFuncao.ID_MOD = vidMod;
                    RegModuloFuncao.ID_SIS = vidSis;
                    vListModuloFuncao.Add(RegModuloFuncao);
                }

                var vbUpdate = pSisModuloNEG.AlteraModulo(ref pBanco, vidSis, vidMod);
                
            }

            vbAssociada = SisModuloFuncaoNEG.fbnAssociaOrg(ref pBanco, vListModuloFuncao);

            return vbAssociada;
        }
        public Boolean CriaEstrutura(ref Banco pBanco, int pidOrg, string pIdPapel)
        {
            Boolean vbCria;
            vbCria = vSisSistemaNEG.CriaSisSistema(ref pBanco);
            if (vbCria == false)
            {
                return vbCria;
            }
            vbCria = vSisModuloNEG.InclueModulo(ref pBanco);
            if (vbCria == false)
            {
                return vbCria;
            }
            vbCria = vSisFuncaoNEG.bImplementaFuncao(ref pBanco);
            if (vbCria == false)
            {
                return vbCria;
            }
            vbCria = fbAssociaModuloFuncao(ref pBanco, vSisModuloNEG, vSisFuncaoNEG);
            if (vbCria == false)
            {
                return vbCria;
            }
            vbCria = fbAssociaModuloOrg(ref pBanco, vSisModuloNEG,pidOrg);
            if (vbCria == false)
            {
                return vbCria;
            }
            vbCria = fbAssociaFuncaoPapel(ref pBanco, pIdPapel);
            return vbCria;
           
        }
        private Boolean fbAssociaFuncaoPapel(ref Banco pBanco, string pIdPapel)
        {
            var vListFuncao = vSisFuncaoImplementar.ObtemFuncoes(ref pBanco);
            var vListPapelFuncao = new List<SisPapelFuncao>();
            Boolean bInsert = true;
            foreach (var RegListFunco in vListFuncao)
            {
                var RegPapelFuncao = new SisPapelFuncao();
                RegPapelFuncao.ID_PAPEL = pIdPapel;
                RegPapelFuncao.ID_FUNCAO = RegListFunco.ID_FUNCAO;
                RegPapelFuncao.ID_MOD = RegListFunco.ID_MOD;
                RegPapelFuncao.ID_SIS = RegListFunco.ID_SIS;
                RegPapelFuncao.ind_cons_reg = RegListFunco.IND_CONS_REG;
                RegPapelFuncao.ind_excl_reg = RegListFunco.IND_EXCL_REG;
                RegPapelFuncao.ind_execute = RegListFunco.IND_EXECUTE;
                RegPapelFuncao.ind_incl_alt = RegListFunco.IND_INCL_ALT;
                RegPapelFuncao.ind_incl_reg = RegListFunco.IND_INCL_REG;
                vListPapelFuncao.Add(RegPapelFuncao);
            }
            bInsert = vSisPapelFuncaoNEG.fbAssociaListaFuncaoPapel(ref pBanco, vListPapelFuncao);
            return bInsert;
        }

    }
}
