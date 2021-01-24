using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MCIMasterFarm.Negocio.BackOffice.Model;

namespace MCIMasterFarm.Negocio.BackOffice.Install
{
    public class InstallSCA
    {
        private GlobalInstall GlobalInstall = new GlobalInstall();
        private class Sistema
        {
            int idSis = 1;
            string nmSis = "MCISYS";
            string dsSis = "MCI SYS - Sistema de Gestão";
            string sgSis = "MCISYS";
        }
        private List<SisFuncao> FuncaoInicial()
        {
            List<SisFuncao> lFuncao = new List<SisFuncao>();
            int sIdFuncao = 1;
            while (sIdFuncao < 8)
            {
                SisFuncao rSisFuncao = new SisFuncao();
                rSisFuncao.id_funcao = sIdFuncao;
                rSisFuncao.id_usu_incl = GlobalInstall.idUsuAdmin;
                rSisFuncao.dt_inclusao = GlobalInstall.dtInclusao;
                switch(sIdFuncao)
                {
                    case 1:
                        rSisFuncao.nm_funcao = "Cadastro de Organizações";
                        rSisFuncao.ind_cons_reg = "S";
                        rSisFuncao.ind_excl_reg = "S";
                        rSisFuncao.ind_incl_alt = "S";
                        rSisFuncao.ind_incl_reg = "S";
                        rSisFuncao.ind_execute = "S";
                        break;
                    case 2:
                        rSisFuncao.nm_funcao = "Cadastro de Papeis";
                        rSisFuncao.ind_cons_reg = "S";
                        rSisFuncao.ind_excl_reg = "S";
                        rSisFuncao.ind_incl_alt = "S";
                        rSisFuncao.ind_incl_reg = "S";
                        rSisFuncao.ind_execute = "S";
                        break;
                    case 3:
                        rSisFuncao.nm_funcao = "Cadastro de Usuario";
                        rSisFuncao.ind_cons_reg = "S";
                        rSisFuncao.ind_excl_reg = "S";
                        rSisFuncao.ind_incl_alt = "S";
                        rSisFuncao.ind_incl_reg = "S";
                        rSisFuncao.ind_execute = "S";
                        break;
                    case 4:
                        rSisFuncao.nm_funcao = "Associação de Organização e Papel";
                        rSisFuncao.ind_cons_reg = "S";
                        rSisFuncao.ind_excl_reg = "N";
                        rSisFuncao.ind_incl_alt = "N";
                        rSisFuncao.ind_incl_reg = "N";
                        rSisFuncao.ind_execute = "S";
                        break;
                    case 5:
                        rSisFuncao.nm_funcao = "Associação de Papel e Usuário";
                        rSisFuncao.ind_cons_reg = "S";
                        rSisFuncao.ind_excl_reg = "N";
                        rSisFuncao.ind_incl_alt = "N";
                        rSisFuncao.ind_incl_reg = "N";
                        rSisFuncao.ind_execute = "S";
                        break;
                    case 6:
                        rSisFuncao.nm_funcao = "Associação de Usuário e Organização";
                        rSisFuncao.ind_cons_reg = "S";
                        rSisFuncao.ind_excl_reg = "N";
                        rSisFuncao.ind_incl_alt = "N";
                        rSisFuncao.ind_incl_reg = "N";
                        rSisFuncao.ind_execute = "S";
                        break;
                    case 7:
                        rSisFuncao.nm_funcao = "Associação de Usuário e Organização";
                        rSisFuncao.ind_cons_reg = "S";
                        rSisFuncao.ind_excl_reg = "N";
                        rSisFuncao.ind_incl_alt = "N";
                        rSisFuncao.ind_incl_reg = "N";
                        rSisFuncao.ind_execute = "S";
                        break;
                }
                lFuncao.Add(rSisFuncao);
                sIdFuncao += 1;
            }
            return lFuncao;
        }
    }
}
