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
        public Boolean CriaEstrutura(ref Banco pBanco, int pidOrg)
        {
            var vSisSistemaNEG = new SisSistemaNEG();
            var vSisModuloNEG = new SisModuloNEG();
            var vSisFuncaoNEG = new SisFuncaoNEG();
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
            return vbCria;
            vbCria = fbAssociaModuloFuncao(ref pBanco, vSisModuloNEG, vSisFuncaoNEG);
            if (vbCria == false)
            {
                return vbCria;
            }
            vbCria = fbAssociaModuloOrg(ref pBanco, vSisModuloNEG,pidOrg);
            return vbCria;
        }

    }
}
