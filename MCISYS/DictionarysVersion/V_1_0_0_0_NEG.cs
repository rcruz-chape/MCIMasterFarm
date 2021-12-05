using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MCIMasterFarm.Negocio.BackOffice;
using MCIMasterFarm.Negocio.Global;
using MCISYS.Negocio.BackOffice.Model;
using MCIMasterFarm.Negocio.BackOffice.Model;
using MCIMasterFarm.Negocio.BackOffice.Negocio;
using MCISYS.Negocio.BackOffice.Negocio;

namespace MCISYS.DictionarysVersion
{
    public class V_1_0_0_0_NEG
    {
        public string OK = "OK";
        public string mERRO = "Problemas ao Implementar Objetos de BD do MCISYS";
        public V_1_0_0_0 Versao1_0_0_0 = new V_1_0_0_0();
        public List<tables> vTablesImplementar = new List<tables>();
        public List<columns> vColumnsImplementar = new List<columns>();
        public List<constraint> vConstraintImplementar = new List<constraint>();
        public List<sequence> vSequenceImplementar = new List<sequence>();
        public SisSistema vSisSistema = new SisSistema();
        public List<SisModulo> vSisModulo = new List<SisModulo>();
        public List<SisFuncao> vSisFuncao = new List<SisFuncao>();
        public List<SisModuloFuncao> vSisModuloFuncao = new List<SisModuloFuncao>();
        public CorOrganizacao vCorOrganizacao = new CorOrganizacao();
        public SisModuloOrganizacao vSisModiuloOrganizacao = new SisModuloOrganizacao();
        public SisPapel vSisPapel = new SisPapel();
        public SisOrganizacaoPapel vSisOrgPapel = new SisOrganizacaoPapel();
        public SisOrganizacaoPapelUsuario sisOrganizacaoPapelUsuario = new SisOrganizacaoPapelUsuario();
        public List<SisPapelFuncao> vSisPapelFuncao = new List<SisPapelFuncao>();
        public List<Configuracao> vSisConfiguracao = new List<Configuracao>();
        public List<ConfiguracaoTecla> vConfiguracaoTecla = new List<ConfiguracaoTecla>();
        public SisUsuario vSisUsuario = new SisUsuario();
        public SisPapelUsuario vSisPapelUsuario = new SisPapelUsuario();
        public SisOrganizacaoPapelUsuario vSisOrganizacaoPapelUsuario = new SisOrganizacaoPapelUsuario();

        public string CargaDeDados(ref Banco pBanco)
        {
            string vReturn = string.Empty;

            vReturn = IMPLEMENTA_USERADMIN(ref pBanco);
            if (vReturn == mERRO)
            {
                return vReturn;
            }
            
            vReturn = IMPLEMENTA_SIS(ref pBanco);
            if (vReturn == mERRO)
            {
                return vReturn;
            }

            vReturn = IMPLEMENTA_MODULO(ref pBanco);
            if (vReturn == mERRO)
            {
                return vReturn;
            }

            vReturn = IMPLEMENTA_FUNCAO(ref pBanco);
            if (vReturn == mERRO)
            {
                return vReturn;
            }

            vReturn = IMPLEMENTA_CONFIGURACAO(ref pBanco);
            if (vReturn == mERRO)
            {
                return vReturn;
            }

            vReturn = IMPLEMENTA_FUNCAO_MODULO(ref pBanco);
            if (vReturn == mERRO)
            {
                return vReturn;
            }

            vReturn = IMPLEMENTA_ORGANIZACAO(ref pBanco);
            if (vReturn == mERRO)
            {
                return vReturn;
            }

            vReturn = IMPLEMENTA_ORG_MODULO(ref pBanco);
            if (vReturn == mERRO)
            {
                return vReturn;
            }

            vReturn = IMPLEMENTA_PAPEL(ref pBanco);
            if (vReturn == mERRO)
            {
                return vReturn;
            }

            vReturn = IMPLEMENTA_PAPEL_FUNCAO(ref pBanco);
            if (vReturn == mERRO)
            {
                return vReturn;
            }

            vReturn = IMPLEMENTA_PAPEL_USUARIO(ref pBanco);
            if (vReturn == mERRO)
            {
                return vReturn;
            }

            vReturn = IMPLEMENTA_ORG_PAPEL(ref pBanco);
            if (vReturn == mERRO)
            {
                return vReturn;
            }

            vReturn = IMPLEMENTA_ORG_PAPEL_USUARIO(ref pBanco);
            if (vReturn == mERRO)
            {
                return vReturn;
            }


            return vReturn;

        }
      
        private string IMPLEMENTA_ORG_PAPEL_USUARIO(ref Banco pBanco)
        {
            vSisOrganizacaoPapelUsuario = Versao1_0_0_0.MontaSisOrgPapelUsu();
            var vSisOrgPapelUsuNEG = new SisOrganizacaoPapelUsuarioNEG();
            var vLisSisOrgPapUsu = new List<SisOrganizacaoPapelUsuario>();
            vLisSisOrgPapUsu.Add(vSisOrganizacaoPapelUsuario);

            var vInclusao = vSisOrgPapelUsuNEG.RealizaAssociacaoUsuario(ref pBanco, vLisSisOrgPapUsu);
            if (vInclusao)
            {
                return OK;
            }
            else
            {
                return mERRO;
            }
        }
        private string IMPLEMENTA_ORG_PAPEL(ref Banco pBanco)
        {
            vSisOrgPapel = Versao1_0_0_0.MontaSisOrgPapel();
            
            var vListSisOrgPapel = new List<SisOrganizacaoPapel>();
            vListSisOrgPapel.Add(vSisOrgPapel);
            var vSisOrgPapelNEG = new SisOrganizacaoPapelNEG();
            var vInclusao = vSisOrgPapelNEG.AssociaPapelOrg(ref pBanco, null, vListSisOrgPapel);
            if (vInclusao)
            {
                return OK;
            }
            else
            {
                return mERRO;
            }
        }
        private string IMPLEMENTA_PAPEL_USUARIO(ref Banco pBanco)
        {
            vSisPapelUsuario = Versao1_0_0_0.CriaPapelUsuario();
            var vListSisPapelUsuario = new List<SisPapelUsuario>();
            vListSisPapelUsuario.Add(vSisPapelUsuario);
            var vSisPapelUsuarioNEG = new SisPapelUsuarioNEG();
            var vInclusao = vSisPapelUsuarioNEG.AssociaPapelUsuario(ref pBanco,null, vListSisPapelUsuario);
            if (vInclusao)
            {
                return OK;
            }
            else
            {
                return mERRO;
            }
        }
        private string IMPLEMENTA_ORG_MODULO(ref Banco pBanco)
        {
            vSisModiuloOrganizacao = Versao1_0_0_0.MontaSisModuloOrganizacao();
            var vListSisModOrg = new List<SisModuloOrganizacao>();
            vListSisModOrg.Add(vSisModiuloOrganizacao);
            var vSisModOrgNEG = new SisModuloOrganizacaoNEG();
            var vInclusao = vSisModOrgNEG.fbAssociaUpdate(ref pBanco, vListSisModOrg);
            if (vInclusao)
            {
                return OK;
            }
            else
            {
                return mERRO;
            }
        }
        private string IMPLEMENTA_PAPEL(ref Banco pBanco)
        {
            vSisPapel = Versao1_0_0_0.MontaSisPapel();
            var vSisPapelNEG = new SisPapelNEG();
            var vInclusao = vSisPapelNEG.CriaPapel(ref pBanco, vSisPapel);
            if (vInclusao)
            {
                return OK;
            }
            else
            {
                return mERRO;
            }
        }
        private string IMPLEMENTA_ORGANIZACAO(ref Banco pBanco)
        {
            vCorOrganizacao = Versao1_0_0_0.MontaCorOrganizacaoAdm();
            var vCorOrgNEG = new CorOrganizacaoNEG();
            var vInclusao = vCorOrgNEG.InsereCorOrganizacao(ref pBanco, vCorOrganizacao);
            if (vInclusao)
            {
                return OK;
            }
            else
            {
                return mERRO;
            }
        }
        private string IMPLEMENTA_FUNCAO_MODULO (ref Banco pBanco)
        {
            vSisModuloFuncao = Versao1_0_0_0.MontaModuloFuncao();
            var vFunModNEG = new SisModuloFuncaoNEG();
            var vInclusao = vFunModNEG.fbnAssociaOrg(ref pBanco, vSisModuloFuncao);
            if (vInclusao)
            {
                return OK;
            }
            else
            {
                return mERRO;
            }
        }
        private string IMPLEMENTA_FUNCAO(ref Banco pBanco)
        {
            vSisFuncao = Versao1_0_0_0.MontaFuncao();
            var vFunNeg = new SisFuncaoNEG();
            var vInclusao = vFunNeg.bInsereListaFuncao(ref pBanco, vSisFuncao);
            if (vInclusao)
            {
                return OK;
            }
            else
            {
                return mERRO;
            }
        }
        private string IMPLEMENTA_MODULO(ref Banco pBanco)
        {
            vSisModulo = Versao1_0_0_0.MontaModulos();
            var vModNeg = new SisModuloNEG();
            var vInclusao = vModNeg.InclueModulo(ref pBanco, vSisModulo);
            if (vInclusao)
            {
                return OK;
            }
            else
            {
                return mERRO;
            }
        }

        private string IMPLEMENTA_SIS(ref Banco pBanco)
        {
            vSisSistema = Versao1_0_0_0.MontaSistema();
            var vSisNeg = new SisSistemaNEG();
            var vInclusao = vSisNeg.CriaSisSistema(ref pBanco, vSisSistema);
            if (vInclusao)
            {
                return OK;
            }
            else
            {
                return mERRO;
            }
        }
        private string IMPLEMENTA_USERADMIN(ref Banco pBanco)
        {
            vSisUsuario = Versao1_0_0_0.CriaUsuarioAdmin();
            var vSisUsuNEG = new SIS_USUARIO_NEG();
            var vInclusao = vSisUsuNEG.CriaUsuario(vSisUsuario, ref pBanco, true);
            if (vInclusao)
            {
                return OK;
            }
            else
            {
                return mERRO;
            }
        }
        private string IMPLEMENTA_PAPEL_FUNCAO(ref Banco pBanco)
        {
            vSisPapelFuncao = Versao1_0_0_0.MontaSisPapelFuncao();
            var vSisPFuncNEG = new SisPapelFuncaoNEG();
            var vInclusao = vSisPFuncNEG.fbAssociaListaFuncaoPapel(ref pBanco, vSisPapelFuncao);
            if (vInclusao)
            {
                return OK;
            }
            else
            {
                return mERRO;
            }
        }


        
        private string IMPLEMENTA_CONFIGURACAO(ref Banco pBanco)
        {
            vSisConfiguracao = Versao1_0_0_0.MontaConfiguracao();
            var vSisConf = new ConfiguracaoNEG();
            var vInclusao = vSisConf.InsertConf(ref pBanco, vSisConfiguracao);
            if (vInclusao)
            {
                return OK;
            }
            else
            {
                return mERRO;
            }
        }


        public string ImplementaDDL(ref Banco pbanco)
        {
            var vImplementaDDL = new ImplementaDDLNEG();
            var vTabelas = Versao1_0_0_0.MontaTables();
            var vColunas = Versao1_0_0_0.MontaColunas();
            var vConstraints = Versao1_0_0_0.MontaConstraint();
            var vSequences = Versao1_0_0_0.MontaSequences();
            var vViews = Versao1_0_0_0.MontaViews();
            var vSchema = Versao1_0_0_0.MontaSchema();
            var vExtension = Versao1_0_0_0.MontaExtension();

            var bImplementa = vImplementaDDL.ImplementaMCI(ref pbanco, vTabelas, vColunas, vConstraints, vViews, vSequences,vSchema,vExtension);
            if (!bImplementa)
            {
                return mERRO;
            }
            else
            {
                return OK;
            }
        }
    }
}
