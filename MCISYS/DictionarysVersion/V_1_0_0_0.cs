using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MCISYS.Negocio.BackOffice.Model;
using MCIMasterFarm.Negocio.BackOffice.Model;
using MCISYS.Negocio.BackOffice.Negocio;
using MCIMasterFarm.Negocio.BackOffice.Negocio;
using MCIMasterFarm.Negocio.BackOffice.DadosAcesso;

namespace MCISYS.DictionarysVersion
{  

    public class V_1_0_0_0
    {
		public extesion MontaExtension()
        {
			var vExtension = new extesion();
			vExtension.extension_name = "ltree";
			vExtension.extension_schema = "mcisys";
			vExtension.version = "1.2";
			return vExtension;
        }
		public schemas MontaSchema()
        {
			var vSchema = new schemas();
			vSchema.schema_name = "mcisys";
			vSchema.schema_autorization = "mcisys";
			return vSchema;
        }
		public SisPapelUsuario CriaPapelUsuario()
        {
			SisPapelUsuario vSisPapelUsuario = new SisPapelUsuario();

			vSisPapelUsuario.ID_PAPEL = "1";
			vSisPapelUsuario.ID_USU = "admin";

			return vSisPapelUsuario;
        }
		public SisUsuarioOrganizacao CriaOrgAdmUsu()
        {
			SisUsuarioOrganizacao vSisUsuarioOrganizacao = new SisUsuarioOrganizacao();
			vSisUsuarioOrganizacao.ID_ORG = 1;
			vSisUsuarioOrganizacao.ID_USU = "admin";
			vSisUsuarioOrganizacao.DT_INCLUSAO = DateTime.Now;
			vSisUsuarioOrganizacao.ID_USU_INCL = "admin";

			return vSisUsuarioOrganizacao;
        }
		public SisUsuario CriaUsuarioAdmin()
        {
			SisUsuario vUsuarioAdmin = new SisUsuario();
			var Criptografia = new Criptografia();
			vUsuarioAdmin.id_usu = "admin";
			vUsuarioAdmin.nm_usu = "Usuário Administrador da Instância";
			vUsuarioAdmin.ds_pwd = Criptografia.CritografiaDados("1234");
			vUsuarioAdmin.ds_email = "renatomics28@gmail.com";
			return vUsuarioAdmin;
        }

		public List<ConfiguracaoTecla> MontaConfiguracaoTeclado()
        {
			List<ConfiguracaoTecla> vLisConfigAcao = new List<ConfiguracaoTecla>();
			int viTotConfigAcao = 8;
			int viIndice = 1;
			while (viIndice < viTotConfigAcao)
            {
				ConfiguracaoTecla vConfiAcao = new ConfiguracaoTecla();
				switch(viIndice)
                {
					case 1:
						vConfiAcao.DS_TECLA = "ENTER";
						vConfiAcao.NR_KEYCODE = 13;
						break;
					case 2:
						vConfiAcao.DS_TECLA = "LEFT";
						vConfiAcao.NR_KEYCODE = 37;
						break;
					case 3:
						vConfiAcao.DS_TECLA = "RIGHT";
						vConfiAcao.NR_KEYCODE = 39;
						break;
					case 4:
						vConfiAcao.DS_TECLA = "F2";
						vConfiAcao.NR_KEYCODE = 113;
						break;
					case 5:
						vConfiAcao.DS_TECLA = "F3";
						vConfiAcao.NR_KEYCODE = 114;
						break;
					case 6:
						vConfiAcao.DS_TECLA = "F4";
						vConfiAcao.NR_KEYCODE = 115;
						break;
					case 7:
						vConfiAcao.DS_TECLA = "F5";
						vConfiAcao.NR_KEYCODE = 116;
						break;
					case 8:
						vConfiAcao.DS_TECLA = "F8";
						vConfiAcao.NR_KEYCODE = 119;
						break;
				}
				viIndice += 1;
				vLisConfigAcao.Add(vConfiAcao);
            }
			return vLisConfigAcao;
		}
		public List<Configuracao> MontaConfiguracao()
        {
			List<Configuracao> vListSisCOnfiguracao = new List<Configuracao>();
			int viTotConfiguracao = 9;
			int viIndice = 1;

			 while(viIndice < viTotConfiguracao)
             {
				Configuracao vSisConfiguracao = new Configuracao();

				switch(viIndice)
                {
					case 1:
						vSisConfiguracao.NM_FUNCAO = "DS_PESQ_ANTERIOR";
						vSisConfiguracao.NR_KEYCODE = 37;
						vSisConfiguracao.DS_ACAO = "ANTERIOR";
						break;
					case 2:
						vSisConfiguracao.NM_FUNCAO = "DS_PESQ_PROXIMO";
						vSisConfiguracao.NR_KEYCODE = 39;
						vSisConfiguracao.DS_ACAO = "PROXIMO";
						break;
					case 3:
						vSisConfiguracao.NM_FUNCAO = "DS_PESQ_REGISTRO";
						vSisConfiguracao.NR_KEYCODE = 13;
						vSisConfiguracao.DS_ACAO = "PESQUISA";
						break;
					case 4:
						vSisConfiguracao.NM_FUNCAO = "DS_PESQ_REGISTRO";
						vSisConfiguracao.NR_KEYCODE = 119;
						vSisConfiguracao.DS_ACAO = "PESQUISA";
						break;
					case 5:
						vSisConfiguracao.NM_FUNCAO = "DS_TECLA_CAMPOPESQ";
						vSisConfiguracao.NR_KEYCODE = 116;
						vSisConfiguracao.DS_ACAO = "ABRE_LISTA";
						break;
					case 6:
						vSisConfiguracao.NM_FUNCAO = "DS_TECLA_EXCLUIR";
						vSisConfiguracao.NR_KEYCODE = 113;
						vSisConfiguracao.DS_ACAO = "EXCLUIR";
						break;
					case 7:
						vSisConfiguracao.NM_FUNCAO = "DS_TECLA_NOVO";
						vSisConfiguracao.NR_KEYCODE = 114;
						vSisConfiguracao.DS_ACAO = "NOVO";
						break;
					case 8:
						vSisConfiguracao.NM_FUNCAO = "DS_TECLA_SALVAR";
						vSisConfiguracao.NR_KEYCODE = 115;
						vSisConfiguracao.DS_ACAO = "SALVAR";
						break;
					case 9:
						vSisConfiguracao.NM_FUNCAO = "DS_TECLA_SALVAR";
						vSisConfiguracao.NR_KEYCODE = 13;
						vSisConfiguracao.DS_ACAO = "SALVAR";
						break;
				}

				viIndice += 1;
				vListSisCOnfiguracao.Add(vSisConfiguracao);
            }

			return vListSisCOnfiguracao;
        }
		
		public List<SisPapelFuncao> MontaSisPapelFuncao()
        {
			List<SisPapelFuncao> vListSisPapelFuncao = new List<SisPapelFuncao>();
			int viTotPapelFuncao = 8;
			int viIndice = 1;
			while (viIndice <= viTotPapelFuncao)
            {
				SisPapelFuncao vSisPapelFuncao = new SisPapelFuncao();

				switch (viIndice)
                {
					case 1:
						vSisPapelFuncao.ID_PAPEL = "1";
						vSisPapelFuncao.ID_SIS = 1;
						vSisPapelFuncao.ID_MOD = 1;
						vSisPapelFuncao.ID_FUNCAO = 1;
						vSisPapelFuncao.ind_incl_reg = "S";
						vSisPapelFuncao.ind_incl_alt = "S";
						vSisPapelFuncao.ind_excl_reg = "S";
						vSisPapelFuncao.ind_cons_reg = "S";
						vSisPapelFuncao.ind_execute = "N";
						break;
					case 2:
						vSisPapelFuncao.ID_PAPEL = "1";
						vSisPapelFuncao.ID_SIS = 1;
						vSisPapelFuncao.ID_MOD = 1;
						vSisPapelFuncao.ID_FUNCAO = 2;
						vSisPapelFuncao.ind_incl_reg = "N";
						vSisPapelFuncao.ind_incl_alt = "N";
						vSisPapelFuncao.ind_excl_reg = "N";
						vSisPapelFuncao.ind_cons_reg = "N";
						vSisPapelFuncao.ind_execute = "S";
						break;
					case 3:
						vSisPapelFuncao.ID_PAPEL = "1";
						vSisPapelFuncao.ID_SIS = 1;
						vSisPapelFuncao.ID_MOD = 1;
						vSisPapelFuncao.ID_FUNCAO = 3;
						vSisPapelFuncao.ind_incl_reg = "N";
						vSisPapelFuncao.ind_incl_alt = "N";
						vSisPapelFuncao.ind_excl_reg = "N";
						vSisPapelFuncao.ind_cons_reg = "N";
						vSisPapelFuncao.ind_execute = "S";
						break;
					case 4:
						vSisPapelFuncao.ID_PAPEL = "1";
						vSisPapelFuncao.ID_SIS = 1;
						vSisPapelFuncao.ID_MOD = 1;
						vSisPapelFuncao.ID_FUNCAO = 4;
						vSisPapelFuncao.ind_incl_reg = "S";
						vSisPapelFuncao.ind_incl_alt = "S";
						vSisPapelFuncao.ind_excl_reg = "S";
						vSisPapelFuncao.ind_cons_reg = "S";
						vSisPapelFuncao.ind_execute = "N";
						break;
					case 5:
						vSisPapelFuncao.ID_PAPEL = "1";
						vSisPapelFuncao.ID_SIS = 1;
						vSisPapelFuncao.ID_MOD = 1;
						vSisPapelFuncao.ID_FUNCAO = 5;
						vSisPapelFuncao.ind_incl_reg = "N";
						vSisPapelFuncao.ind_incl_alt = "N";
						vSisPapelFuncao.ind_excl_reg = "N";
						vSisPapelFuncao.ind_cons_reg = "N";
						vSisPapelFuncao.ind_execute = "S";
						break;
					case 6:
						vSisPapelFuncao.ID_PAPEL = "1";
						vSisPapelFuncao.ID_SIS = 1;
						vSisPapelFuncao.ID_MOD = 1;
						vSisPapelFuncao.ID_FUNCAO = 6;
						vSisPapelFuncao.ind_incl_reg = "N";
						vSisPapelFuncao.ind_incl_alt = "N";
						vSisPapelFuncao.ind_excl_reg = "N";
						vSisPapelFuncao.ind_cons_reg = "N";
						vSisPapelFuncao.ind_execute = "S";
						break;
					case 7:
						vSisPapelFuncao.ID_PAPEL = "1";
						vSisPapelFuncao.ID_SIS = 1;
						vSisPapelFuncao.ID_MOD = 1;
						vSisPapelFuncao.ID_FUNCAO = 7;
						vSisPapelFuncao.ind_incl_reg = "S";
						vSisPapelFuncao.ind_incl_alt = "S";
						vSisPapelFuncao.ind_excl_reg = "S";
						vSisPapelFuncao.ind_cons_reg = "S";
						vSisPapelFuncao.ind_execute = "N";
						break;
					case 8:
						vSisPapelFuncao.ID_PAPEL = "1";
						vSisPapelFuncao.ID_SIS = 1;
						vSisPapelFuncao.ID_MOD = 1;
						vSisPapelFuncao.ID_FUNCAO = 8;
						vSisPapelFuncao.ind_incl_reg = "N";
						vSisPapelFuncao.ind_incl_alt = "N";
						vSisPapelFuncao.ind_excl_reg = "N";
						vSisPapelFuncao.ind_cons_reg = "N";
						vSisPapelFuncao.ind_execute = "S";
						break;
				}

				viIndice += 1;
				vListSisPapelFuncao.Add(vSisPapelFuncao);
			}
			return vListSisPapelFuncao;

		}
		public SisOrganizacaoPapelUsuario MontaSisOrgPapelUsu()
        {
			SisOrganizacaoPapelUsuario vSisOrgPapelUsu = new SisOrganizacaoPapelUsuario();
			vSisOrgPapelUsu.ID_ORG = 1;
			vSisOrgPapelUsu.ID_PAPEL = "1";
			vSisOrgPapelUsu.ID_USU = "admin";
			vSisOrgPapelUsu.ID_USU_INCL = "admin";
			vSisOrgPapelUsu.DT_INCLUSAO = DateTime.Now;

			return vSisOrgPapelUsu;
        }
		public SisOrganizacaoPapel MontaSisOrgPapel()
        {
			SisOrganizacaoPapel vSisOrgPapel = new SisOrganizacaoPapel();
			vSisOrgPapel.ID_ORG = 1;
			vSisOrgPapel.ID_PAPEL = "1";
			vSisOrgPapel.ID_USU_INCL = "admin";
			vSisOrgPapel.DT_INCLUSAO = DateTime.Now;


			return vSisOrgPapel;
        }
		public SisPapel MontaSisPapel()
        {
			SisPapel vSisPapel = new SisPapel();
			vSisPapel.ID_PAPEL = "1";
			vSisPapel.DS_PAPEL = "ADMINISTRADOR";
			vSisPapel.TP_PAPEL = 0;
			vSisPapel.ID_USU_INCL = "admin";
			vSisPapel.DT_INCLUSAO = DateTime.Now;
			vSisPapel.ID_USU_ALT = "admin";

			return vSisPapel;
        }
		public SisModuloOrganizacao MontaSisModuloOrganizacao()
        {
			SisModuloOrganizacao vSisModuloOrganizacao = new SisModuloOrganizacao();
			vSisModuloOrganizacao.ID_ORG = 1;
			vSisModuloOrganizacao.ID_SIS = 1;
			vSisModuloOrganizacao.ID_MOD = 1;
			return vSisModuloOrganizacao;

		}
		public CorOrganizacao MontaCorOrganizacaoAdm()
        {
			CorOrganizacao vSisCorOrganizacao = new CorOrganizacao();

			vSisCorOrganizacao.ID_ORG = 1;
			vSisCorOrganizacao.NM_ORG = "Organização Administradora da Instância";
			vSisCorOrganizacao.NM_ORG_RESUMIDO = "ORG ADM";
			vSisCorOrganizacao.TP_ORG = "A";

			return vSisCorOrganizacao;
	    }
		public List<SisModuloFuncao> MontaModuloFuncao()
        {
			List<SisModuloFuncao> vListSisModuloFuncao = new List<SisModuloFuncao>();
			int viTotModuloFuncao = 19;
			int viIndice = 1;
			while (viIndice <= viTotModuloFuncao)
			{
				SisModuloFuncao vSisModuloFuncao = new SisModuloFuncao();
				/*
				 */
				switch(viIndice)
                {
					case 1:
						vSisModuloFuncao.ID_SIS = 1;
						vSisModuloFuncao.ID_MOD = 1;
						vSisModuloFuncao.ID_FUNCAO = 1;
						break;
					case 2:
						vSisModuloFuncao.ID_SIS = 1;
						vSisModuloFuncao.ID_MOD = 1;
						vSisModuloFuncao.ID_FUNCAO = 2;
						break;
					case 3:
						vSisModuloFuncao.ID_SIS = 1;
						vSisModuloFuncao.ID_MOD = 1;
						vSisModuloFuncao.ID_FUNCAO = 3;
						break;
					case 4:
						vSisModuloFuncao.ID_SIS = 1;
						vSisModuloFuncao.ID_MOD = 1;
						vSisModuloFuncao.ID_FUNCAO = 4;
						break;
					case 5:
						vSisModuloFuncao.ID_SIS = 1;
						vSisModuloFuncao.ID_MOD = 1;
						vSisModuloFuncao.ID_FUNCAO = 5;
						break;
					case 6:
						vSisModuloFuncao.ID_SIS = 1;
						vSisModuloFuncao.ID_MOD = 1;
						vSisModuloFuncao.ID_FUNCAO = 6;
						break;
					case 7:
						vSisModuloFuncao.ID_SIS = 1;
						vSisModuloFuncao.ID_MOD = 1;
						vSisModuloFuncao.ID_FUNCAO = 7;
						break;
					case 8:
						vSisModuloFuncao.ID_SIS = 1;
						vSisModuloFuncao.ID_MOD = 1;
						vSisModuloFuncao.ID_FUNCAO = 8;
						break;
					case 9:
						vSisModuloFuncao.ID_SIS = 1;
						vSisModuloFuncao.ID_MOD = 2;
						vSisModuloFuncao.ID_FUNCAO = 9;
						break;
					case 10:
						vSisModuloFuncao.ID_SIS = 1;
						vSisModuloFuncao.ID_MOD = 2;
						vSisModuloFuncao.ID_FUNCAO = 10;
						break;
					case 11:
						vSisModuloFuncao.ID_SIS = 1;
						vSisModuloFuncao.ID_MOD = 2;
						vSisModuloFuncao.ID_FUNCAO = 11;
						break;
					case 12:
						vSisModuloFuncao.ID_SIS = 1;
						vSisModuloFuncao.ID_MOD = 2;
						vSisModuloFuncao.ID_FUNCAO = 12;
						break;
					case 13:
						vSisModuloFuncao.ID_SIS = 1;
						vSisModuloFuncao.ID_MOD = 3;
						vSisModuloFuncao.ID_FUNCAO = 15;
						break;
					case 14:
						vSisModuloFuncao.ID_SIS = 1;
						vSisModuloFuncao.ID_MOD = 3;
						vSisModuloFuncao.ID_FUNCAO = 17;
						break;
					case 15:
						vSisModuloFuncao.ID_SIS = 1;
						vSisModuloFuncao.ID_MOD = 3;
						vSisModuloFuncao.ID_FUNCAO = 13;
						break;
					case 16:
						vSisModuloFuncao.ID_SIS = 1;
						vSisModuloFuncao.ID_MOD = 3;
						vSisModuloFuncao.ID_FUNCAO = 14;
						break;
					case 17:
						vSisModuloFuncao.ID_SIS = 1;
						vSisModuloFuncao.ID_MOD = 4;
						vSisModuloFuncao.ID_FUNCAO = 18;
						break;
					case 18:
						vSisModuloFuncao.ID_SIS = 1;
						vSisModuloFuncao.ID_MOD = 4;
						vSisModuloFuncao.ID_FUNCAO = 19;
						break;
					case 19:
						vSisModuloFuncao.ID_SIS = 1;
						vSisModuloFuncao.ID_MOD = 4;
						vSisModuloFuncao.ID_FUNCAO = 16;
						break;
				}
				viIndice += 1;
				vListSisModuloFuncao.Add(vSisModuloFuncao);
			}
			return vListSisModuloFuncao;


		}
			public List<SisModulo> MontaModulos()
        {
			List<SisModulo> vListModulos = new List<SisModulo>();
			int viTotModulo = 4;
			int viIndice = 1;

			while (viIndice <= viTotModulo)
            {
				SisModulo vSisModulo = new SisModulo();
				vSisModulo.ID_SIS = 1;
				switch(viIndice)
                {
					case 1:
						vSisModulo.ID_MOD = 1;
						vSisModulo.NM_MOD = "MCISYS Acesso";
						vSisModulo.DS_MOD = "Módulo de Controle de Acesso";
						vSisModulo.DT_INCLUSAO = DateTime.Now;
						vSisModulo.DT_ALTERACAO = DateTime.Now;
						vSisModulo.ID_USU_INCL = "admin";
						vSisModulo.ID_USU_ALT = "admin";
						vSisModulo.DS_SIGLA_MOD = "MCA";
						vSisModulo.NM_IMAGEM_ICONE = "GrupoNegocio_SML";
						vSisModulo.TP_MOD_ORG = "A";
						break;
					case 2:
						vSisModulo.ID_MOD = 2;
						vSisModulo.NM_MOD = "MCISYS Cadastro";
						vSisModulo.DS_MOD = "Módulo de Cadastro";
						vSisModulo.DT_INCLUSAO = DateTime.Now;
						vSisModulo.DT_ALTERACAO = DateTime.Now;
						vSisModulo.ID_USU_INCL = "admin";
						vSisModulo.ID_USU_ALT = "admin";
						vSisModulo.DS_SIGLA_MOD = "MCad";
						vSisModulo.NM_IMAGEM_ICONE = "Mci_Cad";
						vSisModulo.TP_MOD_ORG = "O";
						break;
					case 3:
						vSisModulo.ID_MOD = 3;
						vSisModulo.NM_MOD = "MCISYS Merc";
						vSisModulo.DS_MOD = "Módulo de Estoque";
						vSisModulo.DT_INCLUSAO = DateTime.Now;
						vSisModulo.DT_ALTERACAO = DateTime.Now;
						vSisModulo.ID_USU_INCL = "admin";
						vSisModulo.ID_USU_ALT = "admin";
						vSisModulo.DS_SIGLA_MOD = "MMerc";
						vSisModulo.NM_IMAGEM_ICONE = "Mci_Merc";
						vSisModulo.TP_MOD_ORG = "O";
						break;
					case 4:
						vSisModulo.ID_MOD = 4;
						vSisModulo.NM_MOD = "MCISYS Par";
						vSisModulo.DS_MOD = "Módulo de Parametros";
						vSisModulo.DT_INCLUSAO = DateTime.Now;
						vSisModulo.DT_ALTERACAO = DateTime.Now;
						vSisModulo.ID_USU_INCL = "admin";
						vSisModulo.ID_USU_ALT = "admin";
						vSisModulo.DS_SIGLA_MOD = "MPar";
						vSisModulo.NM_IMAGEM_ICONE = "Mci_Par";
						vSisModulo.TP_MOD_ORG = "O";
						break;
				}


				viIndice += 1;
				vListModulos.Add(vSisModulo);
            }

			return vListModulos;
			
        }
		public SisSistema MontaSistema()
        {
			SisSistema vSisSistema = new SisSistema();
			vSisSistema.ID_SIS = 1;
			vSisSistema.DS_SIS = "Sistema de Gestão Empresarial MCISYS";
			vSisSistema.SG_SIS = "MCISYS";
			vSisSistema.NM_SIS = "MCISYS Gestor";
			vSisSistema.DT_INCLUSAO = DateTime.Now;
			vSisSistema.DT_ALTERACAO = DateTime.Now;
			vSisSistema.ID_USU_ALT = "admin";
			vSisSistema.ID_USU_INCL = "admin";
			vSisSistema.NR_VERSAO = "1.0.0.0";
			return vSisSistema;
		}
		public List<SisFuncao> MontaFuncao()
        {
			int iTot_funcao = 19;
			int iIndice = 1;
			List<SisFuncao> vListFuncao = new List<SisFuncao>();

			while (iIndice <= iTot_funcao)
            {
				SisFuncao rSisFuncao = new SisFuncao();

				switch(iIndice)
                {
					case 1:
						rSisFuncao.id_funcao = 1;
						rSisFuncao.nm_funcao = "CriaOrg";
						rSisFuncao.ds_funcao = "Cria, Associa  Organizações";
						rSisFuncao.ind_cons_reg = "S";
						rSisFuncao.ind_excl_reg = "S";
						rSisFuncao.ind_incl_alt = "S";
						rSisFuncao.ind_incl_reg = "S";
						rSisFuncao.ind_execute = "N";
						rSisFuncao.dt_inclusao = DateTime.Now;
						rSisFuncao.dt_alteracao = DateTime.Now;
						rSisFuncao.id_usu_alt = "admin";
						rSisFuncao.id_usu_incl = "admin";
						rSisFuncao.ind_tipo_funcao = "T";
						rSisFuncao.NM_IMAGEM_ICONE = "icons8-organization-chart-people-48";
						rSisFuncao.NM_FUNCAO_RESUMIDo = "Cadastro de Organizações";
						break;
					case 2:
						rSisFuncao.id_funcao = 2;
						rSisFuncao.nm_funcao = "AssociaOrgPap";
						rSisFuncao.ds_funcao = "Associa Papel Organizações";
						rSisFuncao.ind_cons_reg = "N";
						rSisFuncao.ind_excl_reg = "N";
						rSisFuncao.ind_incl_alt = "N";
						rSisFuncao.ind_incl_reg = "N";
						rSisFuncao.ind_execute = "S";
						rSisFuncao.dt_inclusao = DateTime.Now;
						rSisFuncao.dt_alteracao = DateTime.Now;
						rSisFuncao.id_usu_alt = "admin";
						rSisFuncao.id_usu_incl = "admin";
						rSisFuncao.ind_tipo_funcao = "I";
						break;
					case 3:
						rSisFuncao.id_funcao = 3;
						rSisFuncao.nm_funcao = "AssociaOrgUsu";
						rSisFuncao.ds_funcao = "Associa Usuario Organizações";
						rSisFuncao.ind_cons_reg = "N";
						rSisFuncao.ind_excl_reg = "N";
						rSisFuncao.ind_incl_alt = "N";
						rSisFuncao.ind_incl_reg = "N";
						rSisFuncao.ind_execute = "S";
						rSisFuncao.dt_inclusao = DateTime.Now;
						rSisFuncao.dt_alteracao = DateTime.Now;
						rSisFuncao.id_usu_alt = "admin";
						rSisFuncao.id_usu_incl = "admin";
						rSisFuncao.ind_tipo_funcao = "I";
						break;
					case 4:
						rSisFuncao.id_funcao = 4;
						rSisFuncao.nm_funcao = "CriaPap";
						rSisFuncao.ds_funcao = "Cria, Associa  Papeis";
						rSisFuncao.ind_cons_reg = "S";
						rSisFuncao.ind_excl_reg = "S";
						rSisFuncao.ind_incl_alt = "S";
						rSisFuncao.ind_incl_reg = "S";
						rSisFuncao.ind_execute = "N";
						rSisFuncao.dt_inclusao = DateTime.Now;
						rSisFuncao.dt_alteracao = DateTime.Now;
						rSisFuncao.id_usu_alt = "admin";
						rSisFuncao.id_usu_incl = "admin";
						rSisFuncao.ind_tipo_funcao = "T";
						rSisFuncao.NM_IMAGEM_ICONE = "icons8-user-group-48";
						rSisFuncao.NM_FUNCAO_RESUMIDo = "Cadastro de Papeis";
						break;
					case 5:
						rSisFuncao.id_funcao = 5;
						rSisFuncao.nm_funcao = "AssociaPapOrg";
						rSisFuncao.ds_funcao = "Associa Organizações Papel";
						rSisFuncao.ind_cons_reg = "N";
						rSisFuncao.ind_excl_reg = "N";
						rSisFuncao.ind_incl_alt = "N";
						rSisFuncao.ind_incl_reg = "N";
						rSisFuncao.ind_execute = "S";
						rSisFuncao.dt_inclusao = DateTime.Now;
						rSisFuncao.dt_alteracao = DateTime.Now;
						rSisFuncao.id_usu_alt = "admin";
						rSisFuncao.id_usu_incl = "admin";
						rSisFuncao.ind_tipo_funcao = "I";
						break;
					case 6:
						rSisFuncao.id_funcao = 6;
						rSisFuncao.nm_funcao = "AssociaPapUsu";
						rSisFuncao.ds_funcao = "Associa Usuário Papel";
						rSisFuncao.ind_cons_reg = "N";
						rSisFuncao.ind_excl_reg = "N";
						rSisFuncao.ind_incl_alt = "N";
						rSisFuncao.ind_incl_reg = "N";
						rSisFuncao.ind_execute = "S";
						rSisFuncao.dt_inclusao = DateTime.Now;
						rSisFuncao.dt_alteracao = DateTime.Now;
						rSisFuncao.id_usu_alt = "admin";
						rSisFuncao.id_usu_incl = "admin";
						rSisFuncao.ind_tipo_funcao = "I";
						break;
					case 7:
						rSisFuncao.id_funcao = 7;
						rSisFuncao.nm_funcao = "CriaUsu";
						rSisFuncao.ds_funcao = "Cria Usuário";
						rSisFuncao.ind_cons_reg = "S";
						rSisFuncao.ind_excl_reg = "S";
						rSisFuncao.ind_incl_alt = "S";
						rSisFuncao.ind_incl_reg = "S";
						rSisFuncao.ind_execute = "N";
						rSisFuncao.dt_inclusao = DateTime.Now;
						rSisFuncao.dt_alteracao = DateTime.Now;
						rSisFuncao.id_usu_alt = "admin";
						rSisFuncao.id_usu_incl = "admin";
						rSisFuncao.ind_tipo_funcao = "T";
						rSisFuncao.NM_IMAGEM_ICONE = "icons8-user-folder-48";
						rSisFuncao.NM_FUNCAO_RESUMIDo = "Cadastro de Usuários";
						break;
					case 8:
						rSisFuncao.id_funcao = 8;
						rSisFuncao.nm_funcao = "AssociaOrgPapUsu";
						rSisFuncao.ds_funcao = "Associa Usuário Org Papel";
						rSisFuncao.ind_cons_reg = "N";
						rSisFuncao.ind_excl_reg = "N";
						rSisFuncao.ind_incl_alt = "N";
						rSisFuncao.ind_incl_reg = "N";
						rSisFuncao.ind_execute = "S";
						rSisFuncao.dt_inclusao = DateTime.Now;
						rSisFuncao.dt_alteracao = DateTime.Now;
						rSisFuncao.id_usu_alt = "admin";
						rSisFuncao.id_usu_incl = "admin";
						rSisFuncao.ind_tipo_funcao = "I";
						break;
					case 9:
						rSisFuncao.id_funcao = 9;
						rSisFuncao.nm_funcao = "CadEmpresa";
						rSisFuncao.ds_funcao = "Cadastro de Empresa";
						rSisFuncao.ind_cons_reg = "S";
						rSisFuncao.ind_excl_reg = "S";
						rSisFuncao.ind_incl_alt = "S";
						rSisFuncao.ind_incl_reg = "S";
						rSisFuncao.ind_execute = "S";
						rSisFuncao.dt_inclusao = DateTime.Now;
						rSisFuncao.dt_alteracao = DateTime.Now;
						rSisFuncao.id_usu_alt = "admin";
						rSisFuncao.id_usu_incl = "admin";
						rSisFuncao.ind_tipo_funcao = "T";
						rSisFuncao.NM_IMAGEM_ICONE = "CadEmpresa";
						rSisFuncao.NM_FUNCAO_RESUMIDo = "Cadastro de Empresas";
						break;
					case 10:
						rSisFuncao.id_funcao = 10;
						rSisFuncao.nm_funcao = "CadEstabelecimento";
						rSisFuncao.ds_funcao = "Cadastro de Estabelecimento";
						rSisFuncao.ind_cons_reg = "S";
						rSisFuncao.ind_excl_reg = "S";
						rSisFuncao.ind_incl_alt = "S";
						rSisFuncao.ind_incl_reg = "S";
						rSisFuncao.ind_execute = "S";
						rSisFuncao.dt_inclusao = DateTime.Now;
						rSisFuncao.dt_alteracao = DateTime.Now;
						rSisFuncao.id_usu_alt = "admin";
						rSisFuncao.id_usu_incl = "admin";
						rSisFuncao.ind_tipo_funcao = "T";
						rSisFuncao.NM_IMAGEM_ICONE = "CadEstabelecimento";
						rSisFuncao.NM_FUNCAO_RESUMIDo = "Cadastro de Estabelecimento";
						break;
					case 11:
						rSisFuncao.id_funcao = 11;
						rSisFuncao.nm_funcao = "CadPessoa";
						rSisFuncao.ds_funcao = "Cadastro de Pessoas";
						rSisFuncao.ind_cons_reg = "S";
						rSisFuncao.ind_excl_reg = "S";
						rSisFuncao.ind_incl_alt = "S";
						rSisFuncao.ind_incl_reg = "S";
						rSisFuncao.ind_execute = "S";
						rSisFuncao.dt_inclusao = DateTime.Now;
						rSisFuncao.dt_alteracao = DateTime.Now;
						rSisFuncao.id_usu_alt = "admin";
						rSisFuncao.id_usu_incl = "admin";
						rSisFuncao.ind_tipo_funcao = "T";
						rSisFuncao.NM_IMAGEM_ICONE = "CadPessoa";
						rSisFuncao.NM_FUNCAO_RESUMIDo = "Cadastro de Pessoas";
						break;
					case 12:
						rSisFuncao.id_funcao = 12;
						rSisFuncao.nm_funcao = "CadMercadoria";
						rSisFuncao.ds_funcao = "Cadastro de Mercadoria";
						rSisFuncao.ind_cons_reg = "S";
						rSisFuncao.ind_excl_reg = "S";
						rSisFuncao.ind_incl_alt = "S";
						rSisFuncao.ind_incl_reg = "S";
						rSisFuncao.ind_execute = "S";
						rSisFuncao.dt_inclusao = DateTime.Now;
						rSisFuncao.dt_alteracao = DateTime.Now;
						rSisFuncao.id_usu_alt = "admin";
						rSisFuncao.id_usu_incl = "admin";
						rSisFuncao.ind_tipo_funcao = "T";
						rSisFuncao.NM_IMAGEM_ICONE = "CadMercadoria";
						rSisFuncao.NM_FUNCAO_RESUMIDo = "Cadastro de Mercadoria";
						break;
					case 15:
						rSisFuncao.id_funcao = 15;
						rSisFuncao.nm_funcao = "EstMovCaixa";
						rSisFuncao.ds_funcao = "Fluxo de Entrada e Saida";
						rSisFuncao.ind_cons_reg = "S";
						rSisFuncao.ind_excl_reg = "S";
						rSisFuncao.ind_incl_alt = "S";
						rSisFuncao.ind_incl_reg = "S";
						rSisFuncao.ind_execute = "S";
						rSisFuncao.dt_inclusao = DateTime.Now;
						rSisFuncao.dt_alteracao = DateTime.Now;
						rSisFuncao.id_usu_alt = "admin";
						rSisFuncao.id_usu_incl = "admin";
						rSisFuncao.ind_tipo_funcao = "R";
						rSisFuncao.NM_IMAGEM_ICONE = "EstMovCaixa";
						rSisFuncao.NM_FUNCAO_RESUMIDo = "Fluxo de Entrada e Saida";
						break;
					case 17:
						rSisFuncao.id_funcao = 17;
						rSisFuncao.nm_funcao = "EstDashboard";
						rSisFuncao.ds_funcao = "Dashboard Estoque";
						rSisFuncao.ind_cons_reg = "S";
						rSisFuncao.ind_excl_reg = "S";
						rSisFuncao.ind_incl_alt = "S";
						rSisFuncao.ind_incl_reg = "S";
						rSisFuncao.ind_execute = "S";
						rSisFuncao.dt_inclusao = DateTime.Now;
						rSisFuncao.dt_alteracao = DateTime.Now;
						rSisFuncao.id_usu_alt = "admin";
						rSisFuncao.id_usu_incl = "admin";
						rSisFuncao.ind_tipo_funcao = "T";
						rSisFuncao.NM_IMAGEM_ICONE = "EstDashboard";
						rSisFuncao.NM_FUNCAO_RESUMIDo = "Dashboard Estoque";
						break;
					case 13:
						rSisFuncao.id_funcao = 13;
						rSisFuncao.nm_funcao = "EstEntMercadoria";
						rSisFuncao.ds_funcao = "Entrada de Mercadoria";
						rSisFuncao.ind_cons_reg = "S";
						rSisFuncao.ind_excl_reg = "S";
						rSisFuncao.ind_incl_alt = "S";
						rSisFuncao.ind_incl_reg = "S";
						rSisFuncao.ind_execute = "S";
						rSisFuncao.dt_inclusao = DateTime.Now;
						rSisFuncao.dt_alteracao = DateTime.Now;
						rSisFuncao.id_usu_alt = "admin";
						rSisFuncao.id_usu_incl = "admin";
						rSisFuncao.ind_tipo_funcao = "T";
						rSisFuncao.NM_IMAGEM_ICONE = "EntMercadoria";
						rSisFuncao.NM_FUNCAO_RESUMIDo = "Entrada de Mercadoria";
						break;
					case 14:
						rSisFuncao.id_funcao = 14;
						rSisFuncao.nm_funcao = "EstSaiMercadoria";
						rSisFuncao.ds_funcao = "Saída de Mercadoria";
						rSisFuncao.ind_cons_reg = "S";
						rSisFuncao.ind_excl_reg = "S";
						rSisFuncao.ind_incl_alt = "S";
						rSisFuncao.ind_incl_reg = "S";
						rSisFuncao.ind_execute = "S";
						rSisFuncao.dt_inclusao = DateTime.Now;
						rSisFuncao.dt_alteracao = DateTime.Now;
						rSisFuncao.id_usu_alt = "admin";
						rSisFuncao.id_usu_incl = "admin";
						rSisFuncao.ind_tipo_funcao = "T";
						rSisFuncao.NM_IMAGEM_ICONE = "SaiMercadoria";
						rSisFuncao.NM_FUNCAO_RESUMIDo = "Saída de Mercadoria";
						break;
					case 18:
						rSisFuncao.id_funcao = 18;
						rSisFuncao.nm_funcao = "ParSubGrupoMerc";
						rSisFuncao.ds_funcao = "SubGrupo de Mercadoria";
						rSisFuncao.ind_cons_reg = "S";
						rSisFuncao.ind_excl_reg = "S";
						rSisFuncao.ind_incl_alt = "S";
						rSisFuncao.ind_incl_reg = "S";
						rSisFuncao.ind_execute = "S";
						rSisFuncao.dt_inclusao = DateTime.Now;
						rSisFuncao.dt_alteracao = DateTime.Now;
						rSisFuncao.id_usu_alt = "admin";
						rSisFuncao.id_usu_incl = "admin";
						rSisFuncao.ind_tipo_funcao = "T";
						rSisFuncao.NM_IMAGEM_ICONE = "ParSubGrupoMercadoria";
						rSisFuncao.NM_FUNCAO_RESUMIDo = "SbGrp Mercadoria";
						break;
					case 19:
						rSisFuncao.id_funcao = 19;
						rSisFuncao.nm_funcao = "ParCadUnidade";
						rSisFuncao.ds_funcao = "Unidade de Medida";
						rSisFuncao.ind_cons_reg = "S";
						rSisFuncao.ind_excl_reg = "S";
						rSisFuncao.ind_incl_alt = "S";
						rSisFuncao.ind_incl_reg = "S";
						rSisFuncao.ind_execute = "S";
						rSisFuncao.dt_inclusao = DateTime.Now;
						rSisFuncao.dt_alteracao = DateTime.Now;
						rSisFuncao.id_usu_alt = "admin";
						rSisFuncao.id_usu_incl = "admin";
						rSisFuncao.ind_tipo_funcao = "T";
						rSisFuncao.NM_IMAGEM_ICONE = "CadUnidadeMedida";
						rSisFuncao.NM_FUNCAO_RESUMIDo = "Cad Unidade de Medida";
						break;
					case 16:
						rSisFuncao.id_funcao = 16;
						rSisFuncao.nm_funcao = "ParCadGrupo";
						rSisFuncao.ds_funcao = "Cadastro de Grupo";
						rSisFuncao.ind_cons_reg = "S";
						rSisFuncao.ind_excl_reg = "S";
						rSisFuncao.ind_incl_alt = "S";
						rSisFuncao.ind_incl_reg = "S";
						rSisFuncao.ind_execute = "S";
						rSisFuncao.dt_inclusao = DateTime.Now;
						rSisFuncao.dt_alteracao = DateTime.Now;
						rSisFuncao.id_usu_alt = "admin";
						rSisFuncao.id_usu_incl = "admin";
						rSisFuncao.ind_tipo_funcao = "T";
						rSisFuncao.NM_IMAGEM_ICONE = "ParGrupoMercadoria";
						rSisFuncao.NM_FUNCAO_RESUMIDo = "Cad Grupo";
						break;
				}

				iIndice += 1;
				vListFuncao.Add(rSisFuncao);

            }

			return vListFuncao;
        }
		public List<views> MontaViews()
        {
			int tot_view = 9;
			int indice = 1;
			List<views> ListViews = new List<views>();
			while(indice <= tot_view)
            {
				views view = new views();
				switch(indice)
                {
					case 1:
						view.view_name = "vw_funcao_habilitada_papel";
						view.view_command = @" SELECT pap_func.id_papel,
												mod_func.id_sis,
												mod_func.id_mod,
												modu.ds_sigla_mod,
												func.id_funcao,
												func.ind_tipo_funcao,
												func.nm_funcao,
												func.ds_funcao,
												func.ind_incl_reg,
												func.ind_incl_alt,
												func.ind_excl_reg,
												func.ind_cons_reg,
												func.ind_execute,
												func.dt_inclusao,
												func.dt_alteracao,
												func.id_usu_alt,
												func.id_usu_incl,
												func.nm_imagem_icone,
												func.nm_funcao_resumido
											   FROM (((sis_papel_funcao pap_func
												 JOIN sis_modulo_funcao mod_func ON (((pap_func.id_funcao = mod_func.id_funcao) AND (pap_func.id_mod = mod_func.id_mod) AND (pap_func.id_sis = mod_func.id_sis))))
												 JOIN sis_modulo modu ON (((modu.id_mod = mod_func.id_mod) AND (modu.id_sis = mod_func.id_sis))))
												 JOIN sis_funcao func ON ((func.id_funcao = mod_func.id_funcao)));";
						break;
					case 2:
						view.view_name = "vw_modulo_funcao";
						view.view_command = @" SELECT pfun.id_papel,
											mod.id_sis,
											mod.id_mod,
											0 AS id_funcao,
											mod.ds_sigla_mod AS nome,
											mod.nm_imagem_icone
										   FROM (sis_modulo mod
											 JOIN sis_papel_funcao pfun ON (((pfun.id_mod = mod.id_mod) AND (pfun.id_sis = mod.id_sis))))
										UNION
										 SELECT pfun.id_papel,
											mod_func.id_sis,
											mod_func.id_mod,
											mod_func.id_funcao,
											func.nm_funcao AS nome,
											func.nm_imagem_icone
										   FROM ((sis_funcao func
											 JOIN sis_modulo_funcao mod_func ON ((mod_func.id_funcao = func.id_funcao)))
											 JOIN sis_papel_funcao pfun ON (((pfun.id_sis = mod_func.id_sis) AND (pfun.id_mod = mod_func.id_mod) AND (pfun.id_funcao = mod_func.id_funcao))))
										  WHERE ((func.ind_tipo_funcao)::text <> 'I'::text)
										  ORDER BY 2, 3, 4;";
						break;
					case 3:
						view.view_name = "vw_modulo_sistema_habilitado";
						view.view_command = @" SELECT mod_org.id_org,
														org.nm_org,
														mod_org.id_sis,
														(((sis.sg_sis)::text || ' - '::text) || (sis.nm_sis)::text) AS sistema,
														mod_org.id_mod,
														(((modu.ds_sigla_mod)::text || ' - '::text) || (modu.nm_mod)::text) AS modulo
													   FROM (((sis_modulo_organizacao mod_org
														 JOIN sis_modulo modu ON (((modu.id_mod = mod_org.id_mod) AND (modu.id_sis = mod_org.id_sis))))
														 JOIN sis_sistema sis ON ((sis.id_sis = modu.id_sis)))
														 JOIN cor_organizacao org ON ((org.id_org = mod_org.id_org)));";
						break;
					case 4:
						view.view_name = "vw_org_cadastradas";
						view.view_command = @" WITH RECURSIVE orgs_cadastradas AS (
											 SELECT org.id_org,
												org.nm_org,
												org.nm_org_resumido,
												org.tp_org,
												org.nm_org_path,
												org.id_org_mae,
												(org.nm_org_resumido)::text AS desci
											   FROM cor_organizacao org
											  WHERE ((org.id_org_mae IS NULL) AND ((org.tp_org)::text = 'A'::text))
											UNION ALL
											 SELECT org_filho.id_org,
												org_filho.nm_org,
												org_filho.nm_org_resumido,
												org_filho.tp_org,
												org_filho.nm_org_path,
												org_filho.id_org_mae,
												((orgs_cadastradas_1.desci || '>'::text) || (org_filho.nm_org_resumido)::text) AS desci
											   FROM (cor_organizacao org_filho
												 JOIN orgs_cadastradas orgs_cadastradas_1 ON ((orgs_cadastradas_1.id_org = org_filho.id_org_mae)))
											)
									 SELECT orgs_cadastradas.id_org,
										orgs_cadastradas.nm_org,
										orgs_cadastradas.nm_org_resumido,
										orgs_cadastradas.tp_org,
										orgs_cadastradas.nm_org_path,
										orgs_cadastradas.id_org_mae,
										orgs_cadastradas.desci
									   FROM orgs_cadastradas
									  ORDER BY orgs_cadastradas.desci;";
						break;
					case 5:
						view.view_name = "vw_org_usuario";
						view.view_command = @" SELECT org.id_org,
													org.nm_org_resumido,
													org.nm_org,
													org.tp_org,
													usu_org.id_usu
												   FROM (cor_organizacao org
													 JOIN sis_usuario_organizacao usu_org ON ((usu_org.id_org = org.id_org)));";
						break;
					case 6:
						view.view_name = "vw_pap_usuario";
						view.view_command = @" SELECT DISTINCT pap.id_papel,
												 pap.ds_papel,
												pap.tp_papel,
												COALESCE(org_pap_usu.id_org, opap.id_org) AS id_org,
												COALESCE(org_pap_usu.id_usu, pusu.id_usu) AS id_usu
											   FROM (((sis_papel pap
												 LEFT JOIN sis_organizacao_papel_usuario org_pap_usu ON (((org_pap_usu.id_papel)::text = (pap.id_papel)::text)))
												 LEFT JOIN sis_organizacao_papel opap ON (((opap.id_papel)::text = (org_pap_usu.id_papel)::text)))
												 LEFT JOIN sis_papel_usuario pusu ON (((pusu.id_papel)::text = (org_pap_usu.id_papel)::text)));";
						break;
					case 7:
						view.view_name = "vw_sis_funcao_implementar";
						view.view_command = @" SELECT modu_func.id_sis,
														modu_func.id_mod,
														func.id_funcao,
														func.nm_funcao,
														func.ds_funcao,
														func.ind_incl_reg,
														func.ind_incl_alt,
														func.ind_excl_reg,
														func.ind_cons_reg,
														func.ind_execute
													   FROM ((sis_funcao func
														 JOIN sis_modulo_funcao modu_func ON ((modu_func.id_funcao = func.id_funcao)))
														 LEFT JOIN sis_papel_funcao pap_func ON (((func.id_funcao = pap_func.id_funcao) AND (pap_func.id_mod = modu_func.id_mod) AND (pap_func.id_sis = modu_func.id_sis))))
													  WHERE (pap_func.id_funcao IS NULL);";
						break;
					case 8:
						view.view_name = "vw_sis_organizacao";
						view.view_command = @" SELECT opap.id_org,
														opap.id_papel,
														pap.ds_papel,
														opap.id_usu_incl,
														opap.dt_inclusao,
														org.nm_org
													   FROM ((sis_organizacao_papel opap
														 JOIN sis_papel pap ON (((pap.id_papel)::text = (opap.id_papel)::text)))
														 JOIN cor_organizacao org ON ((org.id_org = opap.id_org)));";
						break;
					case 9:
						view.view_name = "vw_sis_pap_usu";
						view.view_command = @" SELECT pusu.id_papel,
												pusu.id_usu,
												usu.id_usu_incl,
												usu.dt_inclusao
											   FROM (sis_papel_usuario pusu
												 JOIN sis_usuario usu ON (((pusu.id_usu)::text = (usu.id_usu)::text)));";
						break;
				}
				indice += 1;
				ListViews.Add(view);
            }
			return ListViews;
        }
		public List<constraint> MontaConstraint()
        {
			int tot_constraint = 95;
			int indice = 1;
			List<constraint> ListConstraint = new List<constraint>();
			while(indice <= tot_constraint)
            {
				constraint constraint = new constraint();
				switch(indice)
				{
					case 1:
						constraint.table_name = "sis_funcao".ToUpper();
						constraint.constraint_Name = "func_ind_tipo_func";
						constraint.constraint_type = "CK";
						constraint.command_constraint = "(ind_tipo_funcao in ('T','R','I','D'))";
						break;

					case 2:
						constraint.table_name = "cor_organizacao".ToUpper();
						constraint.constraint_Name = "org_tp_org_ck";
						constraint.constraint_type = "CK";
						constraint.command_constraint = "(tp_org in ('A','O'))";
						break;

					case 3:
						constraint.table_name = "cor_organizacao_licenca".ToUpper();
						constraint.constraint_Name = "org_lic_ds_ambiente_ck";
						constraint.constraint_type = "CK";
						constraint.command_constraint = "(ds_ambiente in (1,2,3))";
						break;

					case 4:
						constraint.table_name = "sis_modulo".ToUpper();
						constraint.constraint_Name = "mod_tp_mod_org_ck";
						constraint.constraint_type = "CK";
						constraint.command_constraint = "(tp_mod_org in ('A','O'))";
						break;

					case 5:
						constraint.table_name = "cor_grupo_mercadoria".ToUpper();
						constraint.constraint_Name = "ind_grupo_ativo_ck_gmerc";
						constraint.constraint_type = "CK";
						constraint.command_constraint = "(ind_grupo_ativo in ('S','N'))";
						break;

					case 6:
						constraint.table_name = "cor_sub_grupo_mercadoria".ToUpper();
						constraint.constraint_Name = "sgmerc_ind_sub_grupo_ativo";
						constraint.constraint_type = "CK";
						constraint.command_constraint = "(ind_subgrupo_ativo in ('S','N'))";
						break;

					case 7:
						constraint.table_name = "sis_funcao".ToUpper();
						constraint.constraint_Name = "func_ind_cons_reg";
						constraint.constraint_type = "CK";
						constraint.command_constraint = "(ind_cons_reg in ('S','N'))";
						break;

					case 8:
						constraint.table_name = "sis_funcao".ToUpper();
						constraint.constraint_Name = "func_ind_excl_reg";
						constraint.constraint_type = "CK";
						constraint.command_constraint = "(ind_excl_reg in ('S','N'))";
						break;

					case 9:
						constraint.table_name = "sis_funcao".ToUpper();
						constraint.constraint_Name = "func_ind_execute";
						constraint.constraint_type = "CK";
						constraint.command_constraint = "(ind_execute in ('S','N'))";
						break;

					case 10:
						constraint.table_name = "sis_funcao".ToUpper();
						constraint.constraint_Name = "func_ind_incl_alt";
						constraint.constraint_type = "CK";
						constraint.command_constraint = "(ind_incl_alt in ('S','N'))";
						break;

					case 11:
						constraint.table_name = "sis_funcao".ToUpper();
						constraint.constraint_Name = "func_ind_incl_reg";
						constraint.constraint_type = "CK";
						constraint.command_constraint = "(ind_incl_reg in ('S','N'))";
						break;

					case 12:
						constraint.table_name = "sis_papel_funcao".ToUpper();
						constraint.constraint_Name = "papel_func_ind_cons_reg";
						constraint.constraint_type = "CK";
						constraint.command_constraint = "(ind_cons_reg in ('S','N'))";
						break;

					case 13:
						constraint.table_name = "sis_papel_funcao".ToUpper();
						constraint.constraint_Name = "papel_func_ind_excl_reg";
						constraint.constraint_type = "CK";
						constraint.command_constraint = "(ind_excl_reg in ('S','N'))";
						break;

					case 14:
						constraint.table_name = "sis_papel_funcao".ToUpper();
						constraint.constraint_Name = "papel_func_ind_execute";
						constraint.constraint_type = "CK";
						constraint.command_constraint = "(ind_execute in ('S','N'))";
						break;

					case 15:
						constraint.table_name = "sis_papel_funcao".ToUpper();
						constraint.constraint_Name = "papel_func_ind_incl_alt";
						constraint.constraint_type = "CK";
						constraint.command_constraint = "(ind_incl_alt in ('S','N'))";
						break;

					case 16:
						constraint.table_name = "sis_papel_funcao".ToUpper();
						constraint.constraint_Name = "papel_func_ind_incl_reg";
						constraint.constraint_type = "CK";
						constraint.command_constraint = "(ind_incl_reg in ('S','N'))";
						break;

					case 17:
						constraint.table_name = "sis_usuario".ToUpper();
						constraint.constraint_Name = "usu_ind_bloqueado";
						constraint.constraint_type = "CK";
						constraint.command_constraint = "(ind_bloqueado in ('S','N'))";
						break;

					case 18:
						constraint.table_name = "sis_usuario".ToUpper();
						constraint.constraint_Name = "usu_ind_motivo_bloqueio_ck";
						constraint.constraint_type = "CK";
						constraint.command_constraint = "(ind_motivo_bloqueio in (0,1,2,3))";
						break;

					case 19:
						constraint.table_name = "cor_mercadoria".ToUpper();
						constraint.constraint_Name = "ind_conj_merc_ck";
						constraint.constraint_type = "CK";
						constraint.command_constraint = "(ind_conj_merc in ('S','N'))";
						break;

					case 20:
						constraint.table_name = "cor_mercadoria".ToUpper();
						constraint.constraint_Name = "ind_fora_linha_ck";
						constraint.constraint_type = "CK";
						constraint.command_constraint = "(ind_fora_linha in ('S','N'))";
						break;

					case 21:
						constraint.table_name = "cor_mercadoria".ToUpper();
						constraint.constraint_Name = "ind_tipo_merc_ck";
						constraint.constraint_type = "CK";
						constraint.command_constraint = "(ind_tipo_merc in ('S','M','O'))";
						break;

					case 22:
						constraint.table_name = "cor_mercadoria".ToUpper();
						constraint.constraint_Name = "ind_tipo_prod_ck";
						constraint.constraint_type = "CK";
						constraint.command_constraint = "(ind_tipo_prod in ('00','01','02','03','04','05','06','07','08','09','10','99'))";
							break;
					case 23:
						constraint.table_name = "COR_MERCADORIA";
						constraint.constraint_Name = "ean_uk";
						constraint.constraint_type = "UQ";
						constraint.command_constraint = "UNIQUE (cod_ean)";
						break;

					case 24:
						constraint.table_name = "COR_GRUPO_MERCADORIA";
						constraint.constraint_Name = "gmerc_pk";
						constraint.constraint_type = "PK";
						constraint.command_constraint = "PRIMARY KEY (id_org, id_grp_merc)";
						break;

					case 25:
						constraint.table_name = "COR_MERCADORIA_VIGENCIA";
						constraint.constraint_Name = "merc_vigencia_pk";
						constraint.constraint_type = "PK";
						constraint.command_constraint = "PRIMARY KEY (data_ini_vig, cod_merc, id_org, data_fim_vig)";
						break;

					case 26:
						constraint.table_name = "COR_MERCADORIA";
						constraint.constraint_Name = "mercadoria_pk";
						constraint.constraint_type = "PK";
						constraint.command_constraint = "PRIMARY KEY (id_org, cod_merc)";
						break;

					case 27:
						constraint.table_name = "COR_ORGANIZACAO_LICENCA";
						constraint.constraint_Name = "org_lic_pk";
						constraint.constraint_type = "PK";
						constraint.command_constraint = "PRIMARY KEY (id_org)";
						break;

					case 28:
						constraint.table_name = "SIS_ORGANIZACAO_PAPEL";
						constraint.constraint_Name = "org_pap_pk";
						constraint.constraint_type = "PK";
						constraint.command_constraint = "PRIMARY KEY (id_org, id_papel)";
						break;

					case 29:
						constraint.table_name = "COR_ORGANIZACAO";
						constraint.constraint_Name = "org_pk";
						constraint.constraint_type = "PK";
						constraint.command_constraint = "PRIMARY KEY (id_org)";
						break;

					case 30:
						constraint.table_name = "COR_GENERO_MERCADORIA";
						constraint.constraint_Name = "pk_cor_genero_mercadoria";
						constraint.constraint_type = "PK";
						constraint.command_constraint = "PRIMARY KEY (cod_gene_merc)";
						break;

					case 31:
						constraint.table_name = "SIS_FUNCAO";
						constraint.constraint_Name = "pk_func";
						constraint.constraint_type = "PK";
						constraint.command_constraint = "PRIMARY KEY (id_funcao)";
						break;

					case 32:
						constraint.table_name = "SIS_FUNCAO_IMPLEMENTADA";
						constraint.constraint_Name = "pk_func_impl";
						constraint.constraint_type = "PK";
						constraint.command_constraint = "PRIMARY KEY (id_funcao)";
						break;

					case 33:
						constraint.table_name = "SIS_MODULO";
						constraint.constraint_Name = "pk_mod";
						constraint.constraint_type = "PK";
						constraint.command_constraint = "PRIMARY KEY (id_mod, id_sis)";
						break;

					case 34:
						constraint.table_name = "SIS_MODULO_FUNCAO";
						constraint.constraint_Name = "pk_mod_func";
						constraint.constraint_type = "PK";
						constraint.command_constraint = "PRIMARY KEY (id_mod, id_funcao, id_sis)";
						break;

					case 35:
						constraint.table_name = "SIS_MODULO_ORGANIZACAO";
						constraint.constraint_Name = "pk_mod_org";
						constraint.constraint_type = "PK";
						constraint.command_constraint = "PRIMARY KEY (id_org, id_sis, id_mod)";
						break;

					case 36:
						constraint.table_name = "COR_NCM_MERCADORIA";
						constraint.constraint_Name = "pk_ncm";
						constraint.constraint_type = "PK";
						constraint.command_constraint = "PRIMARY KEY (cod_ncm)";
						break;

					case 37:
						constraint.table_name = "SIS_ORGANIZACAO_PAPEL_USUARIO";
						constraint.constraint_Name = "pk_org_pap_usu";
						constraint.constraint_type = "PK";
						constraint.command_constraint = "PRIMARY KEY (id_org, id_papel, id_usu)";
						break;

					case 38:
						constraint.table_name = "SIS_PAPEL_FUNCAO";
						constraint.constraint_Name = "pk_pap_funcao";
						constraint.constraint_type = "PK";
						constraint.command_constraint = "PRIMARY KEY (id_papel, id_sis, id_funcao, id_mod)";
						break;

					case 39:
						constraint.table_name = "SIS_PAPEL";
						constraint.constraint_Name = "pk_papel";
						constraint.constraint_type = "PK";
						constraint.command_constraint = "PRIMARY KEY (id_papel)";
						break;

					case 40:
						constraint.table_name = "SIS_PAPEL_USUARIO";
						constraint.constraint_Name = "pk_papel_usu";
						constraint.constraint_type = "PK";
						constraint.command_constraint = "PRIMARY KEY (id_usu, id_papel)";
						break;

					case 41:
						constraint.table_name = "SIS_SISTEMA";
						constraint.constraint_Name = "pk_sis";
						constraint.constraint_type = "PK";
						constraint.command_constraint = "PRIMARY KEY (id_sis)";
						break;

					case 42:
						constraint.table_name = "SIS_USUARIO_HIST";
						constraint.constraint_Name = "pk_uhist";
						constraint.constraint_type = "PK";
						constraint.command_constraint = "PRIMARY KEY (dt_login, ds_mac_address, id_usu)";
						break;

					case 43:
						constraint.table_name = "SIS_USUARIO_LOG";
						constraint.constraint_Name = "pk_ulog";
						constraint.constraint_type = "PK";
						constraint.command_constraint = "PRIMARY KEY (id_usu)";
						break;

					case 44:
						constraint.table_name = "SIS_USUARIO_ORGANIZACAO";
						constraint.constraint_Name = "pk_usu_org";
						constraint.constraint_type = "PK";
						constraint.command_constraint = "PRIMARY KEY (id_usu, id_org)";
						break;

					case 45:
						constraint.table_name = "SIS_USUARIO";
						constraint.constraint_Name = "sis_usuario_pkey";
						constraint.constraint_type = "PK";
						constraint.command_constraint = "PRIMARY KEY (id_usu)";
						break;

					case 46:
						constraint.table_name = "COR_SUB_GRUPO_MERCADORIA";
						constraint.constraint_Name = "sub_gmerc_pk";
						constraint.constraint_type = "PK";
						constraint.command_constraint = "PRIMARY KEY (id_grp_merc, id_org, id_subgrp_merc)";
						break;

					case 47:
						constraint.table_name = "COR_UNIDADE_MEDIDA";
						constraint.constraint_Name = "um_pk";
						constraint.constraint_type = "PK";
						constraint.command_constraint = "PRIMARY KEY (id_org, cod_um)";
						break;

					case 48:
						constraint.table_name = "COR_GENERO_MERCADORIA";
						constraint.constraint_Name = "uq_cor_genero_mercadoria";
						constraint.constraint_type = "UQ";
						constraint.command_constraint = "UNIQUE (ds_cod_gene_merc)";
						break;

					case 49:
						constraint.table_name = "COR_GRUPO_MERCADORIA";
						constraint.constraint_Name = "org_fk_gmerc";
						constraint.constraint_type = "FK";
						constraint.command_constraint = "FOREIGN KEY (id_org) REFERENCES cor_organizacao(id_org)";
						break;

					case 50:
						constraint.table_name = "COR_GRUPO_MERCADORIA";
						constraint.constraint_Name = "usu_alt_fk_gmerc";
						constraint.constraint_type = "FK";
						constraint.command_constraint = "FOREIGN KEY (id_usu_alt) REFERENCES sis_usuario(id_usu)";
						break;

					case 51:
						constraint.table_name = "COR_GRUPO_MERCADORIA";
						constraint.constraint_Name = "usu_incl_fk_gmerc";
						constraint.constraint_type = "FK";
						constraint.command_constraint = "FOREIGN KEY (id_usu_incl) REFERENCES sis_usuario(id_usu)";
						break;

					case 52:
						constraint.table_name = "COR_MERCADORIA";
						constraint.constraint_Name = "mercadoria_fk_ncm";
						constraint.constraint_type = "FK";
						constraint.command_constraint = "FOREIGN KEY (cod_ncm) REFERENCES cor_ncm_mercadoria(cod_ncm)";
						break;

					case 53:
						constraint.table_name = "COR_MERCADORIA";
						constraint.constraint_Name = "mercadoria_genero_fk";
						constraint.constraint_type = "FK";
						constraint.command_constraint = "FOREIGN KEY (cod_gene_merc) REFERENCES cor_genero_mercadoria(cod_gene_merc)";
						break;

					case 54:
						constraint.table_name = "COR_MERCADORIA";
						constraint.constraint_Name = "mercadoria_usuario_altera_fk";
						constraint.constraint_type = "FK";
						constraint.command_constraint = "FOREIGN KEY (id_usu_alt) REFERENCES sis_usuario(id_usu)";
						break;

					case 55:
						constraint.table_name = "COR_MERCADORIA";
						constraint.constraint_Name = "mercadoria_usuario_desativa_fk";
						constraint.constraint_type = "FK";
						constraint.command_constraint = "FOREIGN KEY (id_usu_desativa) REFERENCES sis_usuario(id_usu)";
						break;

					case 56:
						constraint.table_name = "COR_MERCADORIA";
						constraint.constraint_Name = "mercadoria_usuario_inclui_fk";
						constraint.constraint_type = "FK";
						constraint.command_constraint = "FOREIGN KEY (id_usu_incl) REFERENCES sis_usuario(id_usu)";
						break;

					case 57:
						constraint.table_name = "COR_MERCADORIA";
						constraint.constraint_Name = "subgrupo_fk_mercadoria";
						constraint.constraint_type = "FK";
						constraint.command_constraint = "FOREIGN KEY (id_grp_merc, id_org, id_subgrp_merc) REFERENCES cor_sub_grupo_mercadoria(id_grp_merc, id_org, id_subgrp_merc)";
						break;

					case 58:
						constraint.table_name = "COR_MERCADORIA";
						constraint.constraint_Name = "unidade_fk_mercadoria";
						constraint.constraint_type = "FK";
						constraint.command_constraint = "FOREIGN KEY (cod_um, id_org) REFERENCES cor_unidade_medida(cod_um, id_org)";
						break;

					case 59:
						constraint.table_name = "COR_NCM_MERCADORIA";
						constraint.constraint_Name = "fk_gmerc_ncm";
						constraint.constraint_type = "FK";
						constraint.command_constraint = "FOREIGN KEY (cod_gene_merc) REFERENCES cor_genero_mercadoria(cod_gene_merc)";
						break;

					case 60:
						constraint.table_name = "COR_ORGANIZACAO";
						constraint.constraint_Name = "org_adm_fk_org";
						constraint.constraint_type = "FK";
						constraint.command_constraint = "FOREIGN KEY (id_org_mae) REFERENCES cor_organizacao(id_org) ON DELETE CASCADE DEFERRABLE INITIALLY DEFERRED";
						break;

					case 61:
						constraint.table_name = "COR_ORGANIZACAO_LICENCA";
						constraint.constraint_Name = "orglic_fk_org";
						constraint.constraint_type = "FK";
						constraint.command_constraint = "FOREIGN KEY (id_org) REFERENCES cor_organizacao(id_org) ON DELETE CASCADE";
						break;

					case 62:
						constraint.table_name = "COR_SUB_GRUPO_MERCADORIA";
						constraint.constraint_Name = "gmerc_fk_sub_gmerc";
						constraint.constraint_type = "FK";
						constraint.command_constraint = "FOREIGN KEY (id_org, id_grp_merc) REFERENCES cor_grupo_mercadoria(id_org, id_grp_merc)";
						break;

					case 63:
						constraint.table_name = "COR_UNIDADE_MEDIDA";
						constraint.constraint_Name = "org_fk_um";
						constraint.constraint_type = "FK";
						constraint.command_constraint = "FOREIGN KEY (id_org) REFERENCES cor_organizacao(id_org)";
						break;

					case 64:
						constraint.table_name = "COR_UNIDADE_MEDIDA";
						constraint.constraint_Name = "usu_alt_fk_um";
						constraint.constraint_type = "FK";
						constraint.command_constraint = "FOREIGN KEY (id_usu_alt) REFERENCES sis_usuario(id_usu)";
						break;

					case 65:
						constraint.table_name = "COR_UNIDADE_MEDIDA";
						constraint.constraint_Name = "usu_incl_fk_um";
						constraint.constraint_type = "FK";
						constraint.command_constraint = "FOREIGN KEY (id_usu_incl) REFERENCES sis_usuario(id_usu)";
						break;

					case 66:
						constraint.table_name = "SIS_FUNCAO";
						constraint.constraint_Name = "func_alt_fk_usu";
						constraint.constraint_type = "FK";
						constraint.command_constraint = "FOREIGN KEY (id_usu_alt) REFERENCES sis_usuario(id_usu) DEFERRABLE INITIALLY DEFERRED";
						break;

					case 67:
						constraint.table_name = "SIS_FUNCAO";
						constraint.constraint_Name = "func_incl_fk_usu";
						constraint.constraint_type = "FK";
						constraint.command_constraint = "FOREIGN KEY (id_usu_incl) REFERENCES sis_usuario(id_usu) DEFERRABLE INITIALLY DEFERRED";
						break;

					case 68:
						constraint.table_name = "SIS_FUNCAO_IMPLEMENTADA";
						constraint.constraint_Name = "func_fk_impl";
						constraint.constraint_type = "FK";
						constraint.command_constraint = "FOREIGN KEY (id_funcao) REFERENCES sis_funcao(id_funcao)";
						break;

					case 69:
						constraint.table_name = "SIS_MODULO";
						constraint.constraint_Name = "mod_alt_fk_usu";
						constraint.constraint_type = "FK";
						constraint.command_constraint = "FOREIGN KEY (id_usu_alt) REFERENCES sis_usuario(id_usu) DEFERRABLE INITIALLY DEFERRED";
						break;

					case 70:
						constraint.table_name = "SIS_MODULO";
						constraint.constraint_Name = "mod_fk_sis";
						constraint.constraint_type = "FK";
						constraint.command_constraint = "FOREIGN KEY (id_sis) REFERENCES sis_sistema(id_sis) DEFERRABLE INITIALLY DEFERRED";
						break;

					case 71:
						constraint.table_name = "SIS_MODULO";
						constraint.constraint_Name = "mod_incl_fk_usu";
						constraint.constraint_type = "FK";
						constraint.command_constraint = "FOREIGN KEY (id_usu_incl) REFERENCES sis_usuario(id_usu) DEFERRABLE INITIALLY DEFERRED";
						break;

					case 72:
						constraint.table_name = "SIS_MODULO_FUNCAO";
						constraint.constraint_Name = "funcao_fk_mod_func";
						constraint.constraint_type = "FK";
						constraint.command_constraint = "FOREIGN KEY (id_funcao) REFERENCES sis_funcao(id_funcao)";
						break;

					case 73:
						constraint.table_name = "SIS_MODULO_FUNCAO";
						constraint.constraint_Name = "mod_fk_mod_func";
						constraint.constraint_type = "FK";
						constraint.command_constraint = "FOREIGN KEY (id_sis, id_mod) REFERENCES sis_modulo(id_sis, id_mod)";
						break;

					case 74:
						constraint.table_name = "SIS_MODULO_ORGANIZACAO";
						constraint.constraint_Name = "mod_fk_mod_org";
						constraint.constraint_type = "FK";
						constraint.command_constraint = "FOREIGN KEY (id_sis, id_mod) REFERENCES sis_modulo(id_sis, id_mod)";
						break;

					case 75:
						constraint.table_name = "SIS_ORGANIZACAO_PAPEL";
						constraint.constraint_Name = "org_fk_org_pap";
						constraint.constraint_type = "FK";
						constraint.command_constraint = "FOREIGN KEY (id_org) REFERENCES cor_organizacao(id_org) ON DELETE CASCADE";
						break;

					case 76:
						constraint.table_name = "SIS_ORGANIZACAO_PAPEL";
						constraint.constraint_Name = "pap_fk_org_pap";
						constraint.constraint_type = "FK";
						constraint.command_constraint = "FOREIGN KEY (id_papel) REFERENCES sis_papel(id_papel) DEFERRABLE INITIALLY DEFERRED";
						break;

					case 77:
						constraint.table_name = "SIS_ORGANIZACAO_PAPEL";
						constraint.constraint_Name = "usu_incl_fk_org_pap";
						constraint.constraint_type = "FK";
						constraint.command_constraint = "FOREIGN KEY (id_usu_incl) REFERENCES sis_usuario(id_usu) DEFERRABLE INITIALLY DEFERRED";
						break;

					case 78:
						constraint.table_name = "SIS_ORGANIZACAO_PAPEL_USUARIO";
						constraint.constraint_Name = "org_fk_org_pap_usu";
						constraint.constraint_type = "FK";
						constraint.command_constraint = "FOREIGN KEY (id_org) REFERENCES cor_organizacao(id_org) ON DELETE CASCADE";
						break;

					case 79:
						constraint.table_name = "SIS_ORGANIZACAO_PAPEL_USUARIO";
						constraint.constraint_Name = "pap_fk_org_pap_usu";
						constraint.constraint_type = "FK";
						constraint.command_constraint = "FOREIGN KEY (id_papel) REFERENCES sis_papel(id_papel) DEFERRABLE INITIALLY DEFERRED";
						break;

					case 80:
						constraint.table_name = "SIS_ORGANIZACAO_PAPEL_USUARIO";
						constraint.constraint_Name = "sis_fk_org_pap_usu";
						constraint.constraint_type = "FK";
						constraint.command_constraint = "FOREIGN KEY (id_usu) REFERENCES sis_usuario(id_usu) DEFERRABLE INITIALLY DEFERRED";
						break;

					case 81:
						constraint.table_name = "SIS_ORGANIZACAO_PAPEL_USUARIO";
						constraint.constraint_Name = "usu_incl_fk_org_pap_usu";
						constraint.constraint_type = "FK";
						constraint.command_constraint = "FOREIGN KEY (id_usu_incl) REFERENCES sis_usuario(id_usu) DEFERRABLE INITIALLY DEFERRED";
						break;

					case 82:
						constraint.table_name = "SIS_PAPEL";
						constraint.constraint_Name = "pap_alt_fk_usu";
						constraint.constraint_type = "FK";
						constraint.command_constraint = "FOREIGN KEY (id_usu_incl) REFERENCES sis_usuario(id_usu) DEFERRABLE INITIALLY DEFERRED";
						break;

					case 83:
						constraint.table_name = "SIS_PAPEL";
						constraint.constraint_Name = "pap_incl_fk_usu";
						constraint.constraint_type = "FK";
						constraint.command_constraint = "FOREIGN KEY (id_usu_alt) REFERENCES sis_usuario(id_usu) DEFERRABLE INITIALLY DEFERRED";
						break;

					case 84:
						constraint.table_name = "SIS_PAPEL_FUNCAO";
						constraint.constraint_Name = "pap_funcao_fk_funcao";
						constraint.constraint_type = "FK";
						constraint.command_constraint = "FOREIGN KEY (id_funcao) REFERENCES sis_funcao(id_funcao)";
						break;

					case 85:
						constraint.table_name = "SIS_PAPEL_FUNCAO";
						constraint.constraint_Name = "pap_funcao_fk_modulo";
						constraint.constraint_type = "FK";
						constraint.command_constraint = "FOREIGN KEY (id_mod, id_sis) REFERENCES sis_modulo(id_mod, id_sis)";
						break;

					case 86:
						constraint.table_name = "SIS_PAPEL_FUNCAO";
						constraint.constraint_Name = "pap_funcao_fk_papel";
						constraint.constraint_type = "FK";
						constraint.command_constraint = "FOREIGN KEY (id_papel) REFERENCES sis_papel(id_papel)";
						break;

					case 87:
						constraint.table_name = "SIS_PAPEL_USUARIO";
						constraint.constraint_Name = "papel_usu_fk_papel";
						constraint.constraint_type = "FK";
						constraint.command_constraint = "FOREIGN KEY (id_papel) REFERENCES sis_papel(id_papel) DEFERRABLE INITIALLY DEFERRED";
						break;

					case 88:
						constraint.table_name = "SIS_PAPEL_USUARIO";
						constraint.constraint_Name = "papel_usu_fk_usu";
						constraint.constraint_type = "FK";
						constraint.command_constraint = "FOREIGN KEY (id_usu) REFERENCES sis_usuario(id_usu) DEFERRABLE INITIALLY DEFERRED";
						break;

					case 89:
						constraint.table_name = "SIS_SISTEMA";
						constraint.constraint_Name = "sis_fk_usu_alt";
						constraint.constraint_type = "FK";
						constraint.command_constraint = "FOREIGN KEY (id_usu_alt) REFERENCES sis_usuario(id_usu) DEFERRABLE INITIALLY DEFERRED";
						break;

					case 90:
						constraint.table_name = "SIS_SISTEMA";
						constraint.constraint_Name = "sis_fk_usu_incl";
						constraint.constraint_type = "FK";
						constraint.command_constraint = "FOREIGN KEY (id_usu_incl) REFERENCES sis_usuario(id_usu) DEFERRABLE INITIALLY DEFERRED";
						break;

					case 91:
						constraint.table_name = "SIS_USUARIO_HIST";
						constraint.constraint_Name = "usu_fk_uhist";
						constraint.constraint_type = "FK";
						constraint.command_constraint = "FOREIGN KEY (id_usu) REFERENCES sis_usuario(id_usu) DEFERRABLE INITIALLY DEFERRED";
						break;

					case 92:
						constraint.table_name = "SIS_USUARIO_LOG";
						constraint.constraint_Name = "usu_fk_ulog";
						constraint.constraint_type = "FK";
						constraint.command_constraint = "FOREIGN KEY (id_usu) REFERENCES sis_usuario(id_usu) DEFERRABLE INITIALLY DEFERRED";
						break;

					case 93:
						constraint.table_name = "SIS_USUARIO_ORGANIZACAO";
						constraint.constraint_Name = "org_fk_usu_org";
						constraint.constraint_type = "FK";
						constraint.command_constraint = "FOREIGN KEY (id_org) REFERENCES cor_organizacao(id_org) ON DELETE CASCADE";
						break;

					case 94:
						constraint.table_name = "SIS_USUARIO_ORGANIZACAO";
						constraint.constraint_Name = "usu_fk_usu_org";
						constraint.constraint_type = "FK";
						constraint.command_constraint = "FOREIGN KEY (id_usu) REFERENCES sis_usuario(id_usu) DEFERRABLE INITIALLY DEFERRED";
						break;

					case 95:
						constraint.table_name = "SIS_USUARIO_ORGANIZACAO";
						constraint.constraint_Name = "usu_incl_fk_usu_org";
						constraint.constraint_type = "FK";
						constraint.command_constraint = "FOREIGN KEY (id_usu_incl) REFERENCES sis_usuario(id_usu) DEFERRABLE INITIALLY DEFERRED";
						break;



				}
				indice += 1;
				ListConstraint.Add(constraint);
			}
			return ListConstraint;
        }
		public List<sequence> MontaSequences()
        {
			int tot_sequences = 3;
			int indice = 1;
			List<sequence> ListSequences = new List<sequence>();
			while (indice <= tot_sequences)
            {
				sequence sequence = new sequence();
				switch(indice)
                {
					case 1:
						sequence.sequence_name = "func_sq";
						sequence.comand_sequence = "create sequence func_sq start with 1";
						break;
					case 2:
						sequence.sequence_name = "org_sq";
						sequence.comand_sequence = "create sequence org_sq start with 1";
						break;
					case 3:
						sequence.sequence_name = "sis_sq";
						sequence.comand_sequence = "create sequence sis_sq start with 1";
						break;
				}

				indice += 1;
				ListSequences.Add(sequence);
            }
			return ListSequences;
        }
        public List<columns> MontaColunas()
        {
            int tot_colunas = 283;
            int indice = 1;
            List<columns> ListColumns = new List<columns>();

            while(indice <= tot_colunas)
            {
                columns column = new columns();
                switch(indice)
                {
					case 1:
						column.table_name = "COR_GENERO_MERCADORIA";
						column.indice_col = 1;
						column.column_name = "COD_GENE_MERC";
						column.column_type = "INT";
						column.isNull = true;
						break;

					case 2:
						column.table_name = "COR_GENERO_MERCADORIA";
						column.indice_col = 2;
						column.column_name = "DS_COD_GENE_MERC";
						column.column_type = "VARCHAR";
						column.isNull = true;
						column.column_lenght = 2;
						break;

					case 3:
						column.table_name = "COR_GENERO_MERCADORIA";
						column.indice_col = 3;
						column.column_name = "DS_GENE_MERC";
						column.column_type = "VARCHAR";
						column.isNull = false;
						column.column_lenght = 200;
						break;

					case 4:
						column.table_name = "COR_GENERO_MERCADORIA";
						column.indice_col = 4;
						column.column_name = "DATA_INI_VIG";
						column.column_type = "DATE";
						column.isNull = false;
						break;

					case 5:
						column.table_name = "COR_GENERO_MERCADORIA";
						column.indice_col = 5;
						column.column_name = "DATA_FIM_VIG";
						column.column_type = "DATE";
						column.isNull = false;
						break;

					case 6:
						column.table_name = "COR_GRUPO_MERCADORIA";
						column.indice_col = 1;
						column.column_name = "ID_ORG";
						column.column_type = "INT";
						column.isNull = true;
						column.column_lenght = 32;
						column.column_precision = 2;
						break;

					case 7:
						column.table_name = "COR_GRUPO_MERCADORIA";
						column.indice_col = 2;
						column.column_name = "ID_GRP_MERC";
						column.column_type = "INT";
						column.isNull = true;
						column.column_lenght = 32;
						column.column_precision = 2;
						break;

					case 8:
						column.table_name = "COR_GRUPO_MERCADORIA";
						column.indice_col = 3;
						column.column_name = "NM_GRP_MERC";
						column.column_type = "VARCHAR";
						column.isNull = true;
						column.column_lenght = 45;
						break;

					case 9:
						column.table_name = "COR_GRUPO_MERCADORIA";
						column.indice_col = 4;
						column.column_name = "IND_GRUPO_ATIVO";
						column.column_type = "VARCHAR";
						column.isNull = true;
						column.column_lenght = 1;
						break;

					case 10:
						column.table_name = "COR_GRUPO_MERCADORIA";
						column.indice_col = 5;
						column.column_name = "ID_USU_INCL";
						column.column_type = "VARCHAR";
						column.isNull = true;
						column.column_lenght = 20;
						break;

					case 11:
						column.table_name = "COR_GRUPO_MERCADORIA";
						column.indice_col = 6;
						column.column_name = "DT_INCLUSAO";
						column.column_type = "DATE";
						column.isNull = true;
						break;

					case 12:
						column.table_name = "COR_GRUPO_MERCADORIA";
						column.indice_col = 7;
						column.column_name = "ID_USU_ALT";
						column.column_type = "VARCHAR";
						column.isNull = false;
						column.column_lenght = 20;
						break;

					case 13:
						column.table_name = "COR_GRUPO_MERCADORIA";
						column.indice_col = 8;
						column.column_name = "DT_ALTERACAO";
						column.column_type = "DATE";
						column.isNull = false;
						break;

					case 14:
						column.table_name = "COR_MERCADORIA";
						column.indice_col = 1;
						column.column_name = "ID_ORG";
						column.column_type = "INT";
						column.isNull = true;
						column.column_lenght = 32;
						column.column_precision = 2;
						break;

					case 15:
						column.table_name = "COR_MERCADORIA";
						column.indice_col = 2;
						column.column_name = "COD_MERC";
						column.column_type = "INT";
						column.isNull = true;
						column.column_lenght = 7;
						column.column_precision = 4;
						break;

					case 16:
						column.table_name = "COR_MERCADORIA";
						column.indice_col = 3;
						column.column_name = "COD_EAN";
						column.column_type = "VARCHAR";
						column.isNull = false;
						column.column_lenght = 13;
						break;

					case 17:
						column.table_name = "COR_MERCADORIA";
						column.indice_col = 4;
						column.column_name = "COD_GENE_MERC";
						column.column_type = "INT";
						column.isNull = true;
						column.column_lenght = 32;
						column.column_precision = 2;
						break;

					case 18:
						column.table_name = "COR_MERCADORIA";
						column.indice_col = 5;
						column.column_name = "ID_GRP_MERC";
						column.column_type = "INT";
						column.isNull = true;
						column.column_lenght = 32;
						column.column_precision = 2;
						break;

					case 19:
						column.table_name = "COR_MERCADORIA";
						column.indice_col = 6;
						column.column_name = "ID_SUBGRP_MERC";
						column.column_type = "INT";
						column.isNull = true;
						column.column_lenght = 32;
						column.column_precision = 2;
						break;

					case 20:
						column.table_name = "COR_MERCADORIA";
						column.indice_col = 7;
						column.column_name = "IND_TIPO_MERC";
						column.column_type = "VARCHAR";
						column.isNull = true;
						column.column_lenght = 1;
						break;

					case 21:
						column.table_name = "COR_MERCADORIA";
						column.indice_col = 8;
						column.column_name = "IND_TIPO_PROD";
						column.column_type = "VARCHAR";
						column.isNull = true;
						column.column_lenght = 2;
						break;

					case 22:
						column.table_name = "COR_MERCADORIA";
						column.indice_col = 9;
						column.column_name = "NM_MERC";
						column.column_type = "VARCHAR";
						column.isNull = true;
						column.column_lenght = 200;
						break;

					case 23:
						column.table_name = "COR_MERCADORIA";
						column.indice_col = 10;
						column.column_name = "NM_MERC_REDUZIDO";
						column.column_type = "VARCHAR";
						column.isNull = true;
						column.column_lenght = 50;
						break;

					case 24:
						column.table_name = "COR_MERCADORIA";
						column.indice_col = 11;
						column.column_name = "IND_CONJ_MERC";
						column.column_type = "VARCHAR";
						column.isNull = false;
						column.column_lenght = 1;
						break;

					case 25:
						column.table_name = "COR_MERCADORIA";
						column.indice_col = 12;
						column.column_name = "COD_UM";
						column.column_type = "VARCHAR";
						column.isNull = true;
						column.column_lenght = 3;
						break;

					case 26:
						column.table_name = "COR_MERCADORIA";
						column.indice_col = 13;
						column.column_name = "COD_NCM";
						column.column_type = "VARCHAR";
						column.isNull = true;
						column.column_lenght = 11;
						break;

					case 27:
						column.table_name = "COR_MERCADORIA";
						column.indice_col = 14;
						column.column_name = "IND_FORA_LINHA";
						column.column_type = "VARCHAR";
						column.isNull = false;
						column.column_lenght = 1;
						break;

					case 28:
						column.table_name = "COR_MERCADORIA";
						column.indice_col = 15;
						column.column_name = "VL_PESO_BRUTO";
						column.column_type = "NUMERIC";
						column.isNull = false;
						column.column_lenght = 9;
						column.column_precision = 4;
						break;

					case 29:
						column.table_name = "COR_MERCADORIA";
						column.indice_col = 16;
						column.column_name = "VL_PESO_LIQUIDO";
						column.column_type = "NUMERIC";
						column.isNull = false;
						column.column_lenght = 9;
						column.column_precision = 4;
						break;

					case 30:
						column.table_name = "COR_MERCADORIA";
						column.indice_col = 17;
						column.column_name = "QTD_ESTOQUE_REAL";
						column.column_type = "NUMERIC";
						column.isNull = false;
						column.column_lenght = 9;
						column.column_precision = 4;
						break;

					case 31:
						column.table_name = "COR_MERCADORIA";
						column.indice_col = 18;
						column.column_name = "QTD_ESTOQUE_DISPONIVEL";
						column.column_type = "NUMERIC";
						column.isNull = false;
						column.column_lenght = 9;
						column.column_precision = 4;
						break;

					case 32:
						column.table_name = "COR_MERCADORIA";
						column.indice_col = 19;
						column.column_name = "QTD_ESTOQUE_MINIMO";
						column.column_type = "NUMERIC";
						column.isNull = false;
						column.column_lenght = 9;
						column.column_precision = 4;
						break;

					case 33:
						column.table_name = "COR_MERCADORIA";
						column.indice_col = 20;
						column.column_name = "QTD_ESTOQUE_MAX";
						column.column_type = "NUMERIC";
						column.isNull = false;
						column.column_lenght = 9;
						column.column_precision = 4;
						break;

					case 34:
						column.table_name = "COR_MERCADORIA";
						column.indice_col = 21;
						column.column_name = "VL_ALI_IPI";
						column.column_type = "NUMERIC";
						column.isNull = false;
						column.column_lenght = 5;
						column.column_precision = 4;
						break;

					case 35:
						column.table_name = "COR_MERCADORIA";
						column.indice_col = 22;	
						column.column_name = "VL_ALI_ISS";
						column.column_type = "NUMERIC";
						column.isNull = false;
						column.column_lenght = 5;
						column.column_precision = 4;
						break;

					case 36:
						column.table_name = "COR_MERCADORIA";
						column.indice_col = 23;
						column.column_name = "VL_ALI_ICMS_DUF";
						column.column_type = "NUMERIC";
						column.isNull = false;
						column.column_lenght = 5;
						column.column_precision = 4;
						break;

					case 37:
						column.table_name = "COR_MERCADORIA";
						column.indice_col = 24;
						column.column_name = "VL_NR_ALTURA";
						column.column_type = "NUMERIC";
						column.isNull = false;
						column.column_lenght = 5;
						column.column_precision = 4;
						break;

					case 38:
						column.table_name = "COR_MERCADORIA";
						column.indice_col = 25;
						column.column_name = "VL_NR_LARGURA";
						column.column_type = "NUMERIC";
						column.isNull = false;
						column.column_lenght = 5;
						column.column_precision = 4;
						break;

					case 39:
						column.table_name = "COR_MERCADORIA";
						column.indice_col = 26;
						column.column_name = "VL_NR_COMPRIMENTO";
						column.column_type = "NUMERIC";
						column.isNull = false;
						column.column_lenght = 5;
						column.column_precision = 4;
						break;

					case 40:
						column.table_name = "COR_MERCADORIA";
						column.indice_col = 27;
						column.column_name = "VL_NR_ESPESSURA";
						column.column_type = "NUMERIC";
						column.isNull = false;
						column.column_lenght = 5;
						column.column_precision = 4;
						break;

					case 41:
						column.table_name = "COR_MERCADORIA";
						column.indice_col = 28;
						column.column_name = "VL_NR_PROFUNDIDADE";
						column.column_type = "NUMERIC";
						column.isNull = false;
						column.column_lenght = 5;
						column.column_precision = 4;
						break;

					case 42:
						column.table_name = "COR_MERCADORIA";
						column.indice_col = 29;
						column.column_name = "VL_NR_DIAMETRO";
						column.column_type = "NUMERIC";
						column.isNull = false;
						column.column_lenght = 5;
						column.column_precision = 4;
						break;

					case 43:
						column.table_name = "COR_MERCADORIA";
						column.indice_col = 30;
						column.column_name = "VL_CUSTO_REPOSICAO";
						column.column_type = "NUMERIC";
						column.isNull = false;
						column.column_lenght = 9;
						column.column_precision = 4;
						break;

					case 44:
						column.table_name = "COR_MERCADORIA";
						column.indice_col = 31;
						column.column_name = "VL_BASE_VENDA";
						column.column_type = "NUMERIC";
						column.isNull = false;
						column.column_lenght = 9;
						column.column_precision = 4;
						break;

					case 45:
						column.table_name = "COR_MERCADORIA";
						column.indice_col = 32;
						column.column_name = "VL_MINIMO_VENDA";
						column.column_type = "NUMERIC";
						column.isNull = false;
						column.column_lenght = 9;
						column.column_precision = 4;
						break;

					case 46:
						column.table_name = "COR_MERCADORIA";
						column.indice_col = 33;
						column.column_name = "VL_EMDOLAR";
						column.column_type = "NUMERIC";
						column.isNull = false;
						column.column_lenght = 9;
						column.column_precision = 4;
						break;

					case 47:
						column.table_name = "COR_MERCADORIA";
						column.indice_col = 34;
						column.column_name = "VL_PROMOCAO";
						column.column_type = "NUMERIC";
						column.isNull = false;
						column.column_lenght = 9;
						column.column_precision = 4;
						break;

					case 48:
						column.table_name = "COR_MERCADORIA";
						column.indice_col = 35;
						column.column_name = "VL_PROMOCAO_CONTRIBUINTE";
						column.column_type = "NUMERIC";
						column.isNull = false;
						column.column_lenght = 9;
						column.column_precision = 4;
						break;

					case 49:
						column.table_name = "COR_MERCADORIA";
						column.indice_col = 36;
						column.column_name = "DT_DESATIVACAO";
						column.column_type = "DATE";
						column.isNull = false;
						break;

					case 50:
						column.table_name = "COR_MERCADORIA";
						column.indice_col = 37;
						column.column_name = "ID_USU_DESATIVA";
						column.column_type = "VARCHAR";
						column.isNull = false;
						break;

					case 51:
						column.table_name = "COR_MERCADORIA";
						column.indice_col = 38;
						column.column_name = "DT_INCLUSAO";
						column.column_type = "DATE";
						column.isNull = true;
						break;

					case 52:
						column.table_name = "COR_MERCADORIA";
						column.indice_col = 39;
						column.column_name = "ID_USU_INCL";
						column.column_type = "VARCHAR";
						column.isNull = false;
						break;

					case 53:
						column.table_name = "COR_MERCADORIA";
						column.indice_col = 40;
						column.column_name = "DT_ALTERACAO";
						column.column_type = "DATE";
						column.isNull = true;
						break;

					case 54:
						column.table_name = "COR_MERCADORIA";
						column.indice_col = 41;
						column.column_name = "ID_USU_ALT";
						column.column_type = "VARCHAR";
						column.isNull = false;
						break;

					case 55:
						column.table_name = "COR_MERCADORIA_VIGENCIA";
						column.indice_col = 1;
						column.column_name = "ID_ORG";
						column.column_type = "INT";
						column.isNull = true;
						column.column_lenght = 32;
						column.column_precision = 2;
						break;

					case 56:
						column.table_name = "COR_MERCADORIA_VIGENCIA";
						column.indice_col = 2;
						column.column_name = "COD_MERC";
						column.column_type = "NUMERIC";
						column.isNull = true;
						column.column_lenght = 7;
						column.column_precision = 4;
						break;

					case 57:
						column.table_name = "COR_MERCADORIA_VIGENCIA";
						column.indice_col = 3;
						column.column_name = "DATA_INI_VIG";
						column.column_type = "DATE";
						column.isNull = true;
						break;

					case 58:
						column.table_name = "COR_MERCADORIA_VIGENCIA";
						column.indice_col = 4;
						column.column_name = "DATA_FIM_VIG";
						column.column_type = "DATE";
						column.isNull = true;
						break;

					case 59:
						column.table_name = "COR_MERCADORIA_VIGENCIA";
						column.indice_col = 5;
						column.column_name = "COD_NCM";
						column.column_type = "VARCHAR";
						column.isNull = true;
						column.column_lenght = 11;
						break;

					case 60:
						column.table_name = "COR_MERCADORIA_VIGENCIA";
						column.indice_col = 6;
						column.column_name = "COD_GENE_MERC";
						column.column_type = "INT";
						column.isNull = true;
						break;

					case 61:
						column.table_name = "COR_MERCADORIA_VIGENCIA";
						column.indice_col = 7;
						column.column_name = "COD_UM";
						column.column_type = "VARCHAR";
						column.isNull = true;
						column.column_lenght = 3;
						break;

					case 62:
						column.table_name = "COR_MERCADORIA_VIGENCIA";
						column.indice_col = 8;
						column.column_name = "ID_GRP_MERC";
						column.column_type = "INT";
						column.isNull = true;
						column.column_lenght = 32;
						column.column_precision = 2;
						break;

					case 63:
						column.table_name = "COR_MERCADORIA_VIGENCIA";
						column.indice_col = 9;
						column.column_name = "ID_SUBGRP_MERC";
						column.column_type = "INT";
						column.isNull = true;
						column.column_lenght = 32;
						column.column_precision = 2;
						break;

					case 64:
						column.table_name = "COR_MERCADORIA_VIGENCIA";
						column.indice_col = 10;
						column.column_name = "NM_MERC";
						column.column_type = "VARCHAR";
						column.isNull = true;
						column.column_lenght = 200;
						break;

					case 65:
						column.table_name = "COR_MERCADORIA_VIGENCIA";
						column.indice_col = 11;
						column.column_name = "NM_MERC_REDUZIDO";
						column.column_type = "VARCHAR";
						column.isNull = true;
						column.column_lenght = 50;
						break;

					case 66:
						column.table_name = "COR_MERCADORIA_VIGENCIA";
						column.indice_col = 12;
						column.column_name = "IND_TIPO_PROD";
						column.column_type = "VARCHAR";
						column.isNull = true;
						column.column_lenght = 2;
						break;

					case 67:
						column.table_name = "COR_NCM_MERCADORIA";
						column.indice_col = 1;
						column.column_name = "COD_NCM";
						column.column_type = "VARCHAR";
						column.isNull = true;
						column.column_lenght = 15;
						break;

					case 68:
						column.table_name = "COR_NCM_MERCADORIA";
						column.indice_col = 2;
						column.column_name = "COD_GENE_MERC";
						column.column_type = "INT";
						column.isNull = true;
						break;

					case 69:
						column.table_name = "COR_NCM_MERCADORIA";
						column.indice_col = 3;
						column.column_name = "DS_NCM";
						column.column_type = "VARCHAR";
						column.isNull = true;
						column.column_lenght = 2000;
						break;

					case 70:
						column.table_name = "COR_NCM_MERCADORIA";
						column.indice_col = 4;
						column.column_name = "DATA_INICIO_VIG";
						column.column_type = "DATE";
						column.isNull = true;
						break;

					case 71:
						column.table_name = "COR_NCM_MERCADORIA";
						column.indice_col = 5;
						column.column_name = "DATA_FIM_VIG";
						column.column_type = "DATE";
						column.isNull = false;
						break;

					case 72:
						column.table_name = "COR_ORGANIZACAO";
						column.indice_col = 1;
						column.column_name = "ID_ORG";
						column.column_type = "INT";
						column.isNull = true;
						column.column_lenght = 32;
						column.column_precision = 2;
						break;

					case 73:
						column.table_name = "COR_ORGANIZACAO";
						column.indice_col = 2;
						column.column_name = "NM_ORG";
						column.column_type = "VARCHAR";
						column.isNull = true;
						column.column_lenght = 50;
						break;

					case 74:
						column.table_name = "COR_ORGANIZACAO";
						column.indice_col = 3;
						column.column_name = "NM_ORG_RESUMIDO";
						column.column_type = "VARCHAR";
						column.isNull = false;
						column.column_lenght = 20;
						break;

					case 75:
						column.table_name = "COR_ORGANIZACAO";
						column.indice_col = 4;
						column.column_name = "ID_ORG_MAE";
						column.column_type = "INT";
						column.isNull = false;
						column.column_lenght = 32;
						column.column_precision = 2;
						break;

					case 76:
						column.table_name = "COR_ORGANIZACAO";
						column.indice_col = 5;
						column.column_name = "TP_ORG";
						column.column_type = "VARCHAR";
						column.isNull = true;
						column.column_lenght = 1;
						break;

					case 77:
						column.table_name = "COR_ORGANIZACAO";
						column.indice_col = 6;
						column.column_name = "NM_ORG_PATH";
						column.column_type = "LTREE";
						column.isNull = false;
						break;

					case 78:
						column.table_name = "COR_ORGANIZACAO_LICENCA";
						column.indice_col = 1;
						column.column_name = "ID_ORG";
						column.column_type = "INT";
						column.isNull = true;
						column.column_lenght = 32;
						column.column_precision = 2;
						break;

					case 79:
						column.table_name = "COR_ORGANIZACAO_LICENCA";
						column.indice_col = 2;
						column.column_name = "NR_CNPJ_RAIZ";
						column.column_type = "INT";
						column.isNull = true;
						column.column_lenght = 32;
						column.column_precision = 2;
						break;

					case 80:
						column.table_name = "COR_ORGANIZACAO_LICENCA";
						column.indice_col = 3;
						column.column_name = "DS_AMBIENTE";
						column.column_type = "INT";
						column.isNull = true;
						column.column_lenght = 32;
						column.column_precision = 2;
						break;

					case 81:
						column.table_name = "COR_ORGANIZACAO_LICENCA";
						column.indice_col = 4;
						column.column_name = "DS_SIGLA";
						column.column_type = "VARCHAR";
						column.isNull = true;
						break;

					case 82:
						column.table_name = "COR_ORGANIZACAO_LICENCA";
						column.indice_col = 5;
						column.column_name = "DT_LICENCIAMENTO";
						column.column_type = "DATE";
						column.isNull = true;
						break;

					case 83:
						column.table_name = "COR_SUB_GRUPO_MERCADORIA";
						column.indice_col = 1;
						column.column_name = "ID_ORG";
						column.column_type = "INT";
						column.isNull = true;
						column.column_lenght = 32;
						column.column_precision = 2;
						break;

					case 84:
						column.table_name = "COR_SUB_GRUPO_MERCADORIA";
						column.indice_col = 2;
						column.column_name = "ID_GRP_MERC";
						column.column_type = "INT";
						column.isNull = true;
						column.column_lenght = 32;
						column.column_precision = 2;
						break;

					case 85:
						column.table_name = "COR_SUB_GRUPO_MERCADORIA";
						column.indice_col = 3;
						column.column_name = "ID_SUBGRP_MERC";
						column.column_type = "INT";
						column.isNull = true;
						column.column_lenght = 32;
						column.column_precision = 2;
						break;

					case 86:
						column.table_name = "COR_SUB_GRUPO_MERCADORIA";
						column.indice_col = 4;
						column.column_name = "NM_SUBGRP_MERC";
						column.column_type = "VARCHAR";
						column.isNull = true;
						column.column_lenght = 100;
						break;

					case 87:
						column.table_name = "COR_SUB_GRUPO_MERCADORIA";
						column.indice_col = 5;
						column.column_name = "IND_SUBGRUPO_ATIVO";
						column.column_type = "VARCHAR";
						column.isNull = true;
						column.column_lenght = 1;
						break;

					case 88:
						column.table_name = "COR_SUB_GRUPO_MERCADORIA";
						column.indice_col = 6;
						column.column_name = "ID_USU_INCL";
						column.column_type = "VARCHAR";
						column.isNull = true;
						break;

					case 89:
						column.table_name = "COR_SUB_GRUPO_MERCADORIA";
						column.indice_col = 7;
						column.column_name = "DT_INCLUSAO";
						column.column_type = "DATE";
						column.isNull = true;
						break;

					case 90:
						column.table_name = "COR_SUB_GRUPO_MERCADORIA";
						column.indice_col = 8;
						column.column_name = "ID_USU_ALT";
						column.column_type = "VARCHAR";
						column.isNull = false;
						break;

					case 91:
						column.table_name = "COR_SUB_GRUPO_MERCADORIA";
						column.indice_col = 9;
						column.column_name = "DT_ALTERACAO";
						column.column_type = "DATE";
						column.isNull = false;
						break;

					case 92:
						column.table_name = "COR_UNIDADE_MEDIDA";
						column.indice_col = 1;
						column.column_name = "ID_ORG";
						column.column_type = "INT";
						column.isNull = true;
						column.column_lenght = 32;
						column.column_precision = 2;
						break;

					case 93:
						column.table_name = "COR_UNIDADE_MEDIDA";
						column.indice_col = 2;
						column.column_name = "COD_UM";
						column.column_type = "VARCHAR";
						column.isNull = true;
						column.column_lenght = 3;
						break;

					case 94:
						column.table_name = "COR_UNIDADE_MEDIDA";
						column.indice_col = 3;
						column.column_name = "DESC_UM";
						column.column_type = "VARCHAR";
						column.isNull = true;
						column.column_lenght = 50;
						break;

					case 95:
						column.table_name = "COR_UNIDADE_MEDIDA";
						column.indice_col = 4;
						column.column_name = "ID_USU_INCL";
						column.column_type = "VARCHAR";
						column.isNull = true;
						break;

					case 96:
						column.table_name = "COR_UNIDADE_MEDIDA";
						column.indice_col = 5;
						column.column_name = "DT_INCLUSAO";
						column.column_type = "TIMESTAMPTZ";
						column.isNull = true;
						break;

					case 97:
						column.table_name = "COR_UNIDADE_MEDIDA";
						column.indice_col = 6;
						column.column_name = "ID_USU_ALT";
						column.column_type = "VARCHAR";
						column.isNull = false;
						break;

					case 98:
						column.table_name = "COR_UNIDADE_MEDIDA";
						column.indice_col = 7;
						column.column_name = "DT_ALTERACAO";
						column.column_type = "TIMESTAMPTZ";
						column.isNull = false;
						break;

					case 99:
						column.table_name = "SIS_CONFIGURACAO";
						column.indice_col = 1;
						column.column_name = "NM_FUNCAO";
						column.column_type = "VARCHAR";
						column.isNull = false;
						column.column_lenght = 50;
						break;

					case 100:
						column.table_name = "SIS_CONFIGURACAO";
						column.indice_col = 2;
						column.column_name = "NR_KEYCODE";
						column.column_type = "INT";
						column.isNull = true;
						column.column_lenght = 32;
						column.column_precision = 2;
						break;

					case 101:
						column.table_name = "SIS_CONFIGURACAO";
						column.indice_col = 3;
						column.column_name = "DS_ACAO";
						column.column_type = "VARCHAR";
						column.isNull = false;
						column.column_lenght = 50;
						break;

					case 102:
						column.table_name = "SIS_CONFIGURACAO_EMAIL";
						column.indice_col = 1;
						column.column_name = "DS_HOST";
						column.column_type = "VARCHAR";
						column.isNull = true;
						column.column_lenght = 100;
						break;

					case 103:
						column.table_name = "SIS_CONFIGURACAO_EMAIL";
						column.indice_col = 2;
						column.column_name = "NR_PORT";
						column.column_type = "INT";
						column.isNull = true;
						column.column_lenght = 32;
						column.column_precision = 2;
						break;

					case 104:
						column.table_name = "SIS_CONFIGURACAO_EMAIL";
						column.indice_col = 3;
						column.column_name = "BO_ENABLE_SSL";
						column.column_type = "BOOLEAN";
						column.isNull = true;
						break;

					case 105:
						column.table_name = "SIS_CONFIGURACAO_EMAIL";
						column.indice_col = 4;
						column.column_name = "BO_USE_DEFAULT_CREDENTIALS";
						column.column_type = "BOOLEAN";
						column.isNull = true;
						break;

					case 106:
						column.table_name = "SIS_CONFIGURACAO_EMAIL";
						column.indice_col = 5;
						column.column_name = "DS_EMAIL";
						column.column_type = "VARCHAR";
						column.isNull = true;
						column.column_lenght = 100;
						break;

					case 107:
						column.table_name = "SIS_CONFIGURACAO_EMAIL";
						column.indice_col = 6;
						column.column_name = "DS_SENHA";
						column.column_type = "VARCHAR";
						column.isNull = true;
						column.column_lenght = 100;
						break;

					case 108:
						column.table_name = "SIS_CONFIGURACAO_TECLA";
						column.indice_col = 1;
						column.column_name = "NR_KEYCODE";
						column.column_type = "INT";
						column.isNull = true;
						column.column_lenght = 32;
						column.column_precision = 2;
						break;

					case 109:
						column.table_name = "SIS_CONFIGURACAO_TECLA";
						column.indice_col = 2;
						column.column_name = "DS_TECLA";
						column.column_type = "VARCHAR";
						column.isNull = false;
						column.column_lenght = 50;
						break;

					case 110:
						column.table_name = "SIS_FUNCAO";
						column.indice_col = 1;
						column.column_name = "ID_FUNCAO";
						column.column_type = "INT";
						column.isNull = true;
						column.column_lenght = 32;
						column.column_precision = 2;
						break;

					case 111:
						column.table_name = "SIS_FUNCAO";
						column.indice_col = 2;
						column.column_name = "NM_FUNCAO";
						column.column_type = "VARCHAR";
						column.isNull = true;
						column.column_lenght = 20;
						break;

					case 112:
						column.table_name = "SIS_FUNCAO";
						column.indice_col = 3;
						column.column_name = "DS_FUNCAO";
						column.column_type = "VARCHAR";
						column.isNull = true;
						column.column_lenght = 255;
						break;

					case 113:
						column.table_name = "SIS_FUNCAO";
						column.indice_col = 4;
						column.column_name = "IND_INCL_REG";
						column.column_type = "VARCHAR";
						column.isNull = true;
						column.column_lenght = 1;
						break;

					case 114:
						column.table_name = "SIS_FUNCAO";
						column.indice_col = 5;
						column.column_name = "IND_INCL_ALT";
						column.column_type = "VARCHAR";
						column.isNull = true;
						column.column_lenght = 1;
						break;

					case 115:
						column.table_name = "SIS_FUNCAO";
						column.indice_col = 6;
						column.column_name = "IND_EXCL_REG";
						column.column_type = "VARCHAR";
						column.isNull = true;
						column.column_lenght = 1;
						break;

					case 116:
						column.table_name = "SIS_FUNCAO";
						column.indice_col = 7;
						column.column_name = "IND_CONS_REG";
						column.column_type = "VARCHAR";
						column.isNull = true;
						column.column_lenght = 1;
						break;

					case 117:
						column.table_name = "SIS_FUNCAO";
						column.indice_col = 8;
						column.column_name = "IND_EXECUTE";
						column.column_type = "VARCHAR";
						column.isNull = true;
						column.column_lenght = 1;
						break;

					case 118:
						column.table_name = "SIS_FUNCAO";
						column.indice_col = 9;
						column.column_name = "DT_INCLUSAO";
						column.column_type = "DATE";
						column.isNull = false;
						break;

					case 119:
						column.table_name = "SIS_FUNCAO";
						column.indice_col = 10;
						column.column_name = "DT_ALTERACAO";
						column.column_type = "DATE";
						column.isNull = false;
						break;

					case 120:
						column.table_name = "SIS_FUNCAO";
						column.indice_col = 11;
						column.column_name = "ID_USU_ALT";
						column.column_type = "VARCHAR";
						column.isNull = false;
						column.column_lenght = 50;
						break;

					case 121:
						column.table_name = "SIS_FUNCAO";
						column.indice_col = 12;
						column.column_name = "ID_USU_INCL";
						column.column_type = "VARCHAR";
						column.isNull = false;
						column.column_lenght = 50;
						break;

					case 122:
						column.table_name = "SIS_FUNCAO";
						column.indice_col = 13;
						column.column_name = "NM_ORG_PAGE";
						column.column_type = "VARCHAR";
						column.isNull = false;
						column.column_lenght = 20;
						break;

					case 123:
						column.table_name = "SIS_FUNCAO";
						column.indice_col = 14;
						column.column_name = "IND_TIPO_FUNCAO";
						column.column_type = "VARCHAR";
						column.isNull = true;
						column.column_lenght = 1;
						break;

					case 124:
						column.table_name = "SIS_FUNCAO";
						column.indice_col = 15;
						column.column_name = "NM_IMAGEM_ICONE";
						column.column_type = "VARCHAR";
						column.isNull = false;
						column.column_lenght = 100;
						break;

					case 125:
						column.table_name = "SIS_FUNCAO";
						column.indice_col = 16;
						column.column_name = "NM_FUNCAO_RESUMIDO";
						column.column_type = "VARCHAR";
						column.isNull = false;
						break;

					case 126:
						column.table_name = "SIS_FUNCAO_IMPLEMENTADA";
						column.indice_col = 1;
						column.column_name = "ID_FUNCAO";
						column.column_type = "INT";
						column.isNull = true;
						column.column_lenght = 32;
						column.column_precision = 2;
						break;

					case 127:
						column.table_name = "SIS_MODULO";
						column.indice_col = 1;
						column.column_name = "ID_MOD";
						column.column_type = "INT";
						column.isNull = true;
						column.column_lenght = 32;
						column.column_precision = 2;
						break;

					case 128:
						column.table_name = "SIS_MODULO";
						column.indice_col = 2;
						column.column_name = "NM_MOD";
						column.column_type = "VARCHAR";
						column.isNull = true;
						column.column_lenght = 20;
						break;

					case 129:
						column.table_name = "SIS_MODULO";
						column.indice_col = 3;
						column.column_name = "DS_MOD";
						column.column_type = "VARCHAR";
						column.isNull = true;
						column.column_lenght = 255;
						break;

					case 130:
						column.table_name = "SIS_MODULO";
						column.indice_col = 4;
						column.column_name = "DT_INCLUSAO";
						column.column_type = "DATE";
						column.isNull = false;
						break;

					case 131:
						column.table_name = "SIS_MODULO";
						column.indice_col = 5;
						column.column_name = "DT_ALTERACAO";
						column.column_type = "DATE";
						column.isNull = false;
						break;

					case 132:
						column.table_name = "SIS_MODULO";
						column.indice_col = 6;
						column.column_name = "ID_SIS";
						column.column_type = "INT";
						column.isNull = true;
						column.column_lenght = 32;
						column.column_precision = 2;
						break;

					case 133:
						column.table_name = "SIS_MODULO";
						column.indice_col = 7;
						column.column_name = "ID_USU_ALT";
						column.column_type = "VARCHAR";
						column.isNull = false;
						column.column_lenght = 50;
						break;

					case 134:
						column.table_name = "SIS_MODULO";
						column.indice_col = 8;
						column.column_name = "ID_USU_INCL";
						column.column_type = "VARCHAR";
						column.isNull = false;
						column.column_lenght = 50;
						break;

					case 135:
						column.table_name = "SIS_MODULO";
						column.indice_col = 9;
						column.column_name = "DS_SIGLA_MOD";
						column.column_type = "VARCHAR";
						column.isNull = false;
						column.column_lenght = 10;
						break;

					case 136:
						column.table_name = "SIS_MODULO";
						column.indice_col = 10;
						column.column_name = "NM_IMAGEM_ICONE";
						column.column_type = "VARCHAR";
						column.isNull = false;
						column.column_lenght = 100;
						break;

					case 137:
						column.table_name = "SIS_MODULO";
						column.indice_col = 11;
						column.column_name = "TP_MOD_ORG";
						column.column_type = "VARCHAR";
						column.isNull = false;
						column.column_lenght = 1;
						break;

					case 138:
						column.table_name = "SIS_MODULO_FUNCAO";
						column.indice_col = 1;
						column.column_name = "ID_SIS";
						column.column_type = "INT";
						column.isNull = true;
						column.column_lenght = 32;
						column.column_precision = 2;
						break;

					case 139:
						column.table_name = "SIS_MODULO_FUNCAO";
						column.indice_col = 2;
						column.column_name = "ID_MOD";
						column.column_type = "INT";
						column.isNull = true;
						column.column_lenght = 32;
						column.column_precision = 2;
						break;

					case 140:
						column.table_name = "SIS_MODULO_FUNCAO";
						column.indice_col = 3;
						column.column_name = "ID_FUNCAO";
						column.column_type = "INT";
						column.isNull = true;
						column.column_lenght = 32;
						column.column_precision = 2;
						break;

					case 141:
						column.table_name = "SIS_MODULO_ORGANIZACAO";
						column.indice_col = 1;
						column.column_name = "ID_ORG";
						column.column_type = "INT";
						column.isNull = true;
						column.column_lenght = 32;
						column.column_precision = 2;
						break;

					case 142:
						column.table_name = "SIS_MODULO_ORGANIZACAO";
						column.indice_col = 2;
						column.column_name = "ID_SIS";
						column.column_type = "INT";
						column.isNull = true;
						column.column_lenght = 32;
						column.column_precision = 2;
						break;

					case 143:
						column.table_name = "SIS_MODULO_ORGANIZACAO";
						column.indice_col = 3;
						column.column_name = "ID_MOD";
						column.column_type = "INT";
						column.isNull = true;
						column.column_lenght = 32;
						column.column_precision = 2;
						break;

					case 144:
						column.table_name = "SIS_ORGANIZACAO_PAPEL";
						column.indice_col = 1;
						column.column_name = "ID_ORG";
						column.column_type = "INT";
						column.isNull = true;
						column.column_lenght = 32;
						column.column_precision = 2;
						break;

					case 145:
						column.table_name = "SIS_ORGANIZACAO_PAPEL";
						column.indice_col = 2;
						column.column_name = "ID_PAPEL";
						column.column_type = "VARCHAR";
						column.isNull = true;
						column.column_lenght = 20;
						break;

					case 146:
						column.table_name = "SIS_ORGANIZACAO_PAPEL";
						column.indice_col = 3;
						column.column_name = "ID_USU_INCL";
						column.column_type = "VARCHAR";
						column.isNull = false;
						column.column_lenght = 50;
						break;

					case 147:
						column.table_name = "SIS_ORGANIZACAO_PAPEL";
						column.indice_col = 4;
						column.column_name = "DT_INCLUSAO";
						column.column_type = "DATE";
						column.isNull = false;
						break;

					case 148:
						column.table_name = "SIS_ORGANIZACAO_PAPEL_USUARIO";
						column.indice_col = 1;
						column.column_name = "ID_ORG";
						column.column_type = "INT";
						column.isNull = true;
						column.column_lenght = 32;
						column.column_precision = 2;
						break;

					case 149:
						column.table_name = "SIS_ORGANIZACAO_PAPEL_USUARIO";
						column.indice_col = 2;
						column.column_name = "ID_PAPEL";
						column.column_type = "VARCHAR";
						column.isNull = true;
						column.column_lenght = 20;
						break;

					case 150:
						column.table_name = "SIS_ORGANIZACAO_PAPEL_USUARIO";
						column.indice_col = 3;
						column.column_name = "ID_USU";
						column.column_type = "VARCHAR";
						column.isNull = true;
						column.column_lenght = 50;
						break;

					case 151:
						column.table_name = "SIS_ORGANIZACAO_PAPEL_USUARIO";
						column.indice_col = 4;
						column.column_name = "ID_USU_INCL";
						column.column_type = "VARCHAR";
						column.isNull = false;
						column.column_lenght = 50;
						break;

					case 152:
						column.table_name = "SIS_ORGANIZACAO_PAPEL_USUARIO";
						column.indice_col = 5;
						column.column_name = "DT_INCLUSAO";
						column.column_type = "DATE";
						column.isNull = false;
						break;

					case 153:
						column.table_name = "SIS_PAPEL";
						column.indice_col = 1;
						column.column_name = "DT_INCLUSAO";
						column.column_type = "DATE";
						column.isNull = false;
						break;

					case 154:
						column.table_name = "SIS_PAPEL";
						column.indice_col = 2;
						column.column_name = "DT_ALTERACAO";
						column.column_type = "DATE";
						column.isNull = false;
						break;

					case 155:
						column.table_name = "SIS_PAPEL";
						column.indice_col = 3;
						column.column_name = "ID_PAPEL";
						column.column_type = "VARCHAR";
						column.isNull = true;
						column.column_lenght = 20;
						break;

					case 156:
						column.table_name = "SIS_PAPEL";
						column.indice_col = 4;
						column.column_name = "DS_PAPEL";
						column.column_type = "VARCHAR";
						column.isNull = true;
						column.column_lenght = 255;
						break;

					case 157:
						column.table_name = "SIS_PAPEL";
						column.indice_col = 5;
						column.column_name = "ID_USU_ALT";
						column.column_type = "VARCHAR";
						column.isNull = false;
						column.column_lenght = 50;
						break;

					case 158:
						column.table_name = "SIS_PAPEL";
						column.indice_col = 6;
						column.column_name = "ID_USU_INCL";
						column.column_type = "VARCHAR";
						column.isNull = false;
						column.column_lenght = 50;
						break;

					case 159:
						column.table_name = "SIS_PAPEL";
						column.indice_col = 7;
						column.column_name = "TP_PAPEL";
						column.column_type = "INT";
						column.isNull = true;
						column.column_lenght = 32;
						column.column_precision = 2;
						break;

					case 160:
						column.table_name = "SIS_PAPEL_FUNCAO";
						column.indice_col = 1;
						column.column_name = "ID_PAPEL";
						column.column_type = "VARCHAR";
						column.isNull = true;
						column.column_lenght = 20;
						break;

					case 161:
						column.table_name = "SIS_PAPEL_FUNCAO";
						column.indice_col = 2;
						column.column_name = "ID_SIS";
						column.column_type = "INT";
						column.isNull = true;
						column.column_lenght = 32;
						column.column_precision = 2;
						break;

					case 162:
						column.table_name = "SIS_PAPEL_FUNCAO";
						column.indice_col = 3;
						column.column_name = "ID_MOD";
						column.column_type = "INT";
						column.isNull = true;
						column.column_lenght = 32;
						column.column_precision = 2;
						break;

					case 163:
						column.table_name = "SIS_PAPEL_FUNCAO";
						column.indice_col = 4;
						column.column_name = "ID_FUNCAO";
						column.column_type = "INT";
						column.isNull = true;
						column.column_lenght = 32;
						column.column_precision = 2;
						break;

					case 164:
						column.table_name = "SIS_PAPEL_FUNCAO";
						column.indice_col = 5;
						column.column_name = "IND_INCL_REG";
						column.column_type = "VARCHAR";
						column.isNull = true;
						column.column_lenght = 1;
						break;

					case 165:
						column.table_name = "SIS_PAPEL_FUNCAO";
						column.indice_col = 6;
						column.column_name = "IND_INCL_ALT";
						column.column_type = "VARCHAR";
						column.isNull = true;
						column.column_lenght = 1;
						break;

					case 166:
						column.table_name = "SIS_PAPEL_FUNCAO";
						column.indice_col = 7;
						column.column_name = "IND_EXCL_REG";
						column.column_type = "VARCHAR";
						column.isNull = true;
						column.column_lenght = 1;
						break;

					case 167:
						column.table_name = "SIS_PAPEL_FUNCAO";
						column.indice_col = 8;
						column.column_name = "IND_CONS_REG";
						column.column_type = "VARCHAR";
						column.isNull = true;
						column.column_lenght = 1;
						break;

					case 168:
						column.table_name = "SIS_PAPEL_FUNCAO";
						column.indice_col = 9;
						column.column_name = "IND_EXECUTE";
						column.column_type = "VARCHAR";
						column.isNull = true;
						column.column_lenght = 1;
						break;

					case 169:
						column.table_name = "SIS_PAPEL_USUARIO";
						column.indice_col = 1;
						column.column_name = "ID_PAPEL";
						column.column_type = "VARCHAR";
						column.isNull = true;
						column.column_lenght = 20;
						break;

					case 170:
						column.table_name = "SIS_PAPEL_USUARIO";
						column.indice_col = 2;
						column.column_name = "ID_USU";
						column.column_type = "VARCHAR";
						column.isNull = true;
						column.column_lenght = 50;
						break;

					case 171:
						column.table_name = "SIS_PARAMETRO";
						column.indice_col = 1;
						column.column_name = "DS_CAR_ESPECIAL";
						column.column_type = "VARCHAR";
						column.isNull = false;
						break;

					case 172:
						column.table_name = "SIS_PARAMETRO";
						column.indice_col = 2;
						column.column_name = "IND_CAR_MAIUSCULO";
						column.column_type = "INT";
						column.isNull = false;
						column.column_lenght = 32;
						column.column_precision = 2;
						break;

					case 173:
						column.table_name = "SIS_PARAMETRO";
						column.indice_col = 3;
						column.column_name = "IND_CAR_MINUSCULO";
						column.column_type = "INT";
						column.isNull = false;
						column.column_lenght = 32;
						column.column_precision = 2;
						break;

					case 174:
						column.table_name = "SIS_PARAMETRO";
						column.indice_col = 4;
						column.column_name = "IND_NUMERO";
						column.column_type = "INT";
						column.isNull = false;
						column.column_lenght = 32;
						column.column_precision = 2;
						break;

					case 175:
						column.table_name = "SIS_PARAMETRO";
						column.indice_col = 5;
						column.column_name = "IND_TOTAL_CAR";
						column.column_type = "INT";
						column.isNull = false;
						column.column_lenght = 32;
						column.column_precision = 2;
						break;

					case 176:
						column.table_name = "SIS_SISTEMA";
						column.indice_col = 1;
						column.column_name = "ID_SIS";
						column.column_type = "INT";
						column.isNull = true;
						column.column_lenght = 32;
						column.column_precision = 2;
						break;

					case 177:
						column.table_name = "SIS_SISTEMA";
						column.indice_col = 2;
						column.column_name = "NM_SIS";
						column.column_type = "VARCHAR";
						column.isNull = true;
						column.column_lenght = 20;
						break;

					case 178:
						column.table_name = "SIS_SISTEMA";
						column.indice_col = 3;
						column.column_name = "DS_SIS";
						column.column_type = "VARCHAR";
						column.isNull = false;
						column.column_lenght = 100;
						break;

					case 179:
						column.table_name = "SIS_SISTEMA";
						column.indice_col = 4;
						column.column_name = "SG_SIS";
						column.column_type = "VARCHAR";
						column.isNull = false;
						column.column_lenght = 10;
						break;

					case 180:
						column.table_name = "SIS_SISTEMA";
						column.indice_col = 6;
						column.column_name = "DT_INCLUSAO";
						column.column_type = "DATE";
						column.isNull = true;
						break;

					case 181:
						column.table_name = "SIS_SISTEMA";
						column.indice_col = 7;
						column.column_name = "DT_ALTERACAO";
						column.column_type = "DATE";
						column.isNull = false;
						break;

					case 182:
						column.table_name = "SIS_SISTEMA";
						column.indice_col = 8;
						column.column_name = "ID_USU_ALT";
						column.column_type = "VARCHAR";
						column.isNull = false;
						column.column_lenght = 50;
						break;

					case 183:
						column.table_name = "SIS_SISTEMA";
						column.indice_col = 9;
						column.column_name = "ID_USU_INCL";
						column.column_type = "VARCHAR";
						column.isNull = true;
						column.column_lenght = 50;
						break;

					case 184:
						column.table_name = "SIS_USUARIO";
						column.indice_col = 1;
						column.column_name = "ID_USU";
						column.column_type = "VARCHAR";
						column.isNull = true;
						column.column_lenght = 50;
						break;

					case 185:
						column.table_name = "SIS_USUARIO";
						column.indice_col = 2;
						column.column_name = "NM_USU";
						column.column_type = "VARCHAR";
						column.isNull = true;
						column.column_lenght = 255;
						break;

					case 186:
						column.table_name = "SIS_USUARIO";
						column.indice_col = 3;
						column.column_name = "DS_EMAIL";
						column.column_type = "VARCHAR";
						column.isNull = false;
						column.column_lenght = 50;
						break;

					case 187:
						column.table_name = "SIS_USUARIO";
						column.indice_col = 4;
						column.column_name = "DT_LAST_LOGIN";
						column.column_type = "TIMESTAMPTZ";
						column.isNull = false;
						break;

					case 188:
						column.table_name = "SIS_USUARIO";
						column.indice_col = 5;
						column.column_name = "DS_PWD";
						column.column_type = "VARCHAR";
						column.isNull = true;
						column.column_lenght = 255;
						break;

					case 189:
						column.table_name = "SIS_USUARIO";
						column.indice_col = 6;
						column.column_name = "IND_BLOQUEADO";
						column.column_type = "VARCHAR";
						column.isNull = true;
						column.column_lenght = 1;
						break;

					case 190:
						column.table_name = "SIS_USUARIO";
						column.indice_col = 7;
						column.column_name = "IND_MOTIVO_BLOQUEIO";
						column.column_type = "INT";
						column.isNull = false;
						column.column_lenght = 32;
						column.column_precision = 2;
						break;

					case 191:
						column.table_name = "SIS_USUARIO";
						column.indice_col = 8;
						column.column_name = "QTD_LOGIN_SEM_SUCESSO";
						column.column_type = "INT";
						column.isNull = false;
						column.column_lenght = 32;
						column.column_precision = 2;
						break;

					case 192:
						column.table_name = "SIS_USUARIO";
						column.indice_col = 9;
						column.column_name = "ID_PESSOA_FISICA";
						column.column_type = "INT";
						column.isNull = false;
						column.column_lenght = 32;
						column.column_precision = 2;
						break;

					case 193:
						column.table_name = "SIS_USUARIO";
						column.indice_col = 10;
						column.column_name = "DT_INCLUSAO";
						column.column_type = "DATE";
						column.isNull = false;
						break;

					case 194:
						column.table_name = "SIS_USUARIO";
						column.indice_col = 11;
						column.column_name = "DT_ALTERACAO";
						column.column_type = "DATE";
						column.isNull = false;
						break;

					case 195:
						column.table_name = "SIS_USUARIO";
						column.indice_col = 12;
						column.column_name = "ID_USU_ALT";
						column.column_type = "VARCHAR";
						column.isNull = false;
						column.column_lenght = 50;
						break;

					case 196:
						column.table_name = "SIS_USUARIO";
						column.indice_col = 13;
						column.column_name = "ID_USU_INCL";
						column.column_type = "VARCHAR";
						column.isNull = false;
						column.column_lenght = 50;
						break;

					case 197:
						column.table_name = "SIS_USUARIO_HIST";
						column.indice_col = 1;
						column.column_name = "ID_USU";
						column.column_type = "VARCHAR";
						column.isNull = true;
						column.column_lenght = 50;
						break;

					case 198:
						column.table_name = "SIS_USUARIO_HIST";
						column.indice_col = 2;
						column.column_name = "DT_LOGIN";
						column.column_type = "TIMESTAMP";
						column.isNull = true;
						break;

					case 199:
						column.table_name = "SIS_USUARIO_HIST";
						column.indice_col = 3;
						column.column_name = "DS_HOSTNAME";
						column.column_type = "VARCHAR";
						column.isNull = false;
						column.column_lenght = 255;
						break;

					case 200:
						column.table_name = "SIS_USUARIO_HIST";
						column.indice_col = 4;
						column.column_name = "DS_IP_ADDRESS";
						column.column_type = "VARCHAR";
						column.isNull = false;
						column.column_lenght = 50;
						break;

					case 201:
						column.table_name = "SIS_USUARIO_HIST";
						column.indice_col = 5;
						column.column_name = "DS_MAC_ADDRESS";
						column.column_type = "VARCHAR";
						column.isNull = true;
						column.column_lenght = 100;
						break;

					case 202:
						column.table_name = "SIS_USUARIO_HIST";
						column.indice_col = 6;
						column.column_name = "DS_OS";
						column.column_type = "VARCHAR";
						column.isNull = false;
						column.column_lenght = 100;
						break;

					case 203:
						column.table_name = "SIS_USUARIO_LOG";
						column.indice_col = 1;
						column.column_name = "ID_USU";
						column.column_type = "VARCHAR";
						column.isNull = true;
						column.column_lenght = 50;
						break;

					case 204:
						column.table_name = "SIS_USUARIO_LOG";
						column.indice_col = 2;
						column.column_name = "DT_LOGIN";
						column.column_type = "TIMESTAMPTZ";
						column.isNull = true;
						break;

					case 205:
						column.table_name = "SIS_USUARIO_LOG";
						column.indice_col = 3;
						column.column_name = "DS_HOSTNAME";
						column.column_type = "VARCHAR";
						column.isNull = false;
						column.column_lenght = 255;
						break;

					case 206:
						column.table_name = "SIS_USUARIO_LOG";
						column.indice_col = 4;
						column.column_name = "DS_OS";
						column.column_type = "VARCHAR";
						column.isNull = false;
						column.column_lenght = 100;
						break;

					case 207:
						column.table_name = "SIS_USUARIO_LOG";
						column.indice_col = 5;
						column.column_name = "DS_MAC_ADDRESS";
						column.column_type = "VARCHAR";
						column.isNull = false;
						column.column_lenght = 100;
						break;

					case 208:
						column.table_name = "SIS_USUARIO_LOG";
						column.indice_col = 6;
						column.column_name = "DS_IP_ADDRESS";
						column.column_type = "VARCHAR";
						column.isNull = false;
						column.column_lenght = 50;
						break;

					case 209:
						column.table_name = "SIS_USUARIO_ORGANIZACAO";
						column.indice_col = 1;
						column.column_name = "ID_ORG";
						column.column_type = "INT";
						column.isNull = true;
						column.column_lenght = 32;
						column.column_precision = 2;
						break;

					case 210:
						column.table_name = "SIS_USUARIO_ORGANIZACAO";
						column.indice_col = 2;
						column.column_name = "ID_USU";
						column.column_type = "VARCHAR";
						column.isNull = true;
						column.column_lenght = 50;
						break;

					case 211:
						column.table_name = "SIS_USUARIO_ORGANIZACAO";
						column.indice_col = 3;
						column.column_name = "ID_USU_INCL";
						column.column_type = "VARCHAR";
						column.isNull = false;
						column.column_lenght = 50;
						break;

					case 212:
						column.table_name = "SIS_USUARIO_ORGANIZACAO";
						column.indice_col = 4;
						column.column_name = "DT_INCLUSAO";
						column.column_type = "DATE";
						column.isNull = false;
						break;

					case 213:
						column.table_name = "VW_FUNCAO_HABILITADA_PAPEL";
						column.indice_col = 1;
						column.column_name = "ID_PAPEL";
						column.column_type = "VARCHAR";
						column.isNull = false;
						column.column_lenght = 20;
						break;

					case 214:
						column.table_name = "VW_FUNCAO_HABILITADA_PAPEL";
						column.indice_col = 2;
						column.column_name = "ID_SIS";
						column.column_type = "INT";
						column.isNull = false;
						column.column_lenght = 32;
						column.column_precision = 2;
						break;

					case 215:
						column.table_name = "VW_FUNCAO_HABILITADA_PAPEL";
						column.indice_col = 3;
						column.column_name = "ID_MOD";
						column.column_type = "INT";
						column.isNull = false;
						column.column_lenght = 32;
						column.column_precision = 2;
						break;

					case 216:
						column.table_name = "VW_FUNCAO_HABILITADA_PAPEL";
						column.indice_col = 4;
						column.column_name = "DS_SIGLA_MOD";
						column.column_type = "VARCHAR";
						column.isNull = false;
						column.column_lenght = 10;
						break;

					case 217:
						column.table_name = "VW_FUNCAO_HABILITADA_PAPEL";
						column.indice_col = 5;
						column.column_name = "ID_FUNCAO";
						column.column_type = "INT";
						column.isNull = false;
						column.column_lenght = 32;
						column.column_precision = 2;
						break;

					case 218:
						column.table_name = "VW_FUNCAO_HABILITADA_PAPEL";
						column.indice_col = 6;
						column.column_name = "IND_TIPO_FUNCAO";
						column.column_type = "VARCHAR";
						column.isNull = false;
						column.column_lenght = 1;
						break;

					case 219:
						column.table_name = "VW_FUNCAO_HABILITADA_PAPEL";
						column.indice_col = 7;
						column.column_name = "NM_FUNCAO";
						column.column_type = "VARCHAR";
						column.isNull = false;
						column.column_lenght = 20;
						break;

					case 220:
						column.table_name = "VW_FUNCAO_HABILITADA_PAPEL";
						column.indice_col = 8;
						column.column_name = "DS_FUNCAO";
						column.column_type = "VARCHAR";
						column.isNull = false;
						column.column_lenght = 255;
						break;

					case 221:
						column.table_name = "VW_FUNCAO_HABILITADA_PAPEL";
						column.indice_col = 9;
						column.column_name = "IND_INCL_REG";
						column.column_type = "VARCHAR";
						column.isNull = false;
						column.column_lenght = 1;
						break;

					case 222:
						column.table_name = "VW_FUNCAO_HABILITADA_PAPEL";
						column.indice_col = 10;
						column.column_name = "IND_INCL_ALT";
						column.column_type = "VARCHAR";
						column.isNull = false;
						column.column_lenght = 1;
						break;

					case 223:
						column.table_name = "VW_FUNCAO_HABILITADA_PAPEL";
						column.indice_col = 11;
						column.column_name = "IND_EXCL_REG";
						column.column_type = "VARCHAR";
						column.isNull = false;
						column.column_lenght = 1;
						break;

					case 224:
						column.table_name = "VW_FUNCAO_HABILITADA_PAPEL";
						column.indice_col = 12;
						column.column_name = "IND_CONS_REG";
						column.column_type = "VARCHAR";
						column.isNull = false;
						column.column_lenght = 1;
						break;

					case 225:
						column.table_name = "VW_FUNCAO_HABILITADA_PAPEL";
						column.indice_col = 13;
						column.column_name = "IND_EXECUTE";
						column.column_type = "VARCHAR";
						column.isNull = false;
						column.column_lenght = 1;
						break;

					case 226:
						column.table_name = "VW_FUNCAO_HABILITADA_PAPEL";
						column.indice_col = 14;
						column.column_name = "DT_INCLUSAO";
						column.column_type = "DATE";
						column.isNull = false;
						break;

					case 227:
						column.table_name = "VW_FUNCAO_HABILITADA_PAPEL";
						column.indice_col = 15;
						column.column_name = "DT_ALTERACAO";
						column.column_type = "DATE";
						column.isNull = false;
						break;

					case 228:
						column.table_name = "VW_FUNCAO_HABILITADA_PAPEL";
						column.indice_col = 16;
						column.column_name = "ID_USU_ALT";
						column.column_type = "VARCHAR";
						column.isNull = false;
						column.column_lenght = 50;
						break;

					case 229:
						column.table_name = "VW_FUNCAO_HABILITADA_PAPEL";
						column.indice_col = 17;
						column.column_name = "ID_USU_INCL";
						column.column_type = "VARCHAR";
						column.isNull = false;
						column.column_lenght = 50;
						break;

					case 230:
						column.table_name = "VW_FUNCAO_HABILITADA_PAPEL";
						column.indice_col = 18;
						column.column_name = "NM_IMAGEM_ICONE";
						column.column_type = "VARCHAR";
						column.isNull = false;
						column.column_lenght = 100;
						break;

					case 231:
						column.table_name = "VW_FUNCAO_HABILITADA_PAPEL";
						column.indice_col = 19;
						column.column_name = "NM_FUNCAO_RESUMIDO";
						column.column_type = "VARCHAR";
						column.isNull = false;
						break;

					case 232:
						column.table_name = "VW_MODULO_FUNCAO";
						column.indice_col = 1;
						column.column_name = "ID_PAPEL";
						column.column_type = "VARCHAR";
						column.isNull = false;
						column.column_lenght = 20;
						break;

					case 233:
						column.table_name = "VW_MODULO_FUNCAO";
						column.indice_col = 2;
						column.column_name = "ID_SIS";
						column.column_type = "INT";
						column.isNull = false;
						column.column_lenght = 32;
						column.column_precision = 2;
						break;

					case 234:
						column.table_name = "VW_MODULO_FUNCAO";
						column.indice_col = 3;
						column.column_name = "ID_MOD";
						column.column_type = "INT";
						column.isNull = false;
						column.column_lenght = 32;
						column.column_precision = 2;
						break;

					case 235:
						column.table_name = "VW_MODULO_FUNCAO";
						column.indice_col = 4;
						column.column_name = "ID_FUNCAO";
						column.column_type = "INT";
						column.isNull = false;
						column.column_lenght = 32;
						column.column_precision = 2;
						break;

					case 236:
						column.table_name = "VW_MODULO_FUNCAO";
						column.indice_col = 5;
						column.column_name = "NOME";
						column.column_type = "VARCHAR";
						column.isNull = false;
						break;

					case 237:
						column.table_name = "VW_MODULO_FUNCAO";
						column.indice_col = 6;
						column.column_name = "NM_IMAGEM_ICONE";
						column.column_type = "VARCHAR";
						column.isNull = false;
						column.column_lenght = 100;
						break;

					case 238:
						column.table_name = "VW_MODULO_SISTEMA_HABILITADO";
						column.indice_col = 1;
						column.column_name = "ID_ORG";
						column.column_type = "INT";
						column.isNull = false;
						column.column_lenght = 32;
						column.column_precision = 2;
						break;

					case 239:
						column.table_name = "VW_MODULO_SISTEMA_HABILITADO";
						column.indice_col = 2;
						column.column_name = "NM_ORG";
						column.column_type = "VARCHAR";
						column.isNull = false;
						column.column_lenght = 50;
						break;

					case 240:
						column.table_name = "VW_MODULO_SISTEMA_HABILITADO";
						column.indice_col = 3;
						column.column_name = "ID_SIS";
						column.column_type = "INT";
						column.isNull = false;
						column.column_lenght = 32;
						column.column_precision = 2;
						break;

					case 241:
						column.table_name = "VW_MODULO_SISTEMA_HABILITADO";
						column.indice_col = 4;
						column.column_name = "SISTEMA";
						column.column_type = "TEXT";
						column.isNull = false;
						break;

					case 242:
						column.table_name = "VW_MODULO_SISTEMA_HABILITADO";
						column.indice_col = 5;
						column.column_name = "ID_MOD";
						column.column_type = "INT";
						column.isNull = false;
						column.column_lenght = 32;
						column.column_precision = 2;
						break;

					case 243:
						column.table_name = "VW_MODULO_SISTEMA_HABILITADO";
						column.indice_col = 6;
						column.column_name = "MODULO";
						column.column_type = "TEXT";
						column.isNull = false;
						break;

					case 244:
						column.table_name = "VW_ORG_CADASTRADAS";
						column.indice_col = 1;
						column.column_name = "ID_ORG";
						column.column_type = "INT";
						column.isNull = false;
						column.column_lenght = 32;
						column.column_precision = 2;
						break;

					case 245:
						column.table_name = "VW_ORG_CADASTRADAS";
						column.indice_col = 2;
						column.column_name = "NM_ORG";
						column.column_type = "VARCHAR";
						column.isNull = false;
						column.column_lenght = 50;
						break;

					case 246:
						column.table_name = "VW_ORG_CADASTRADAS";
						column.indice_col = 3;
						column.column_name = "NM_ORG_RESUMIDO";
						column.column_type = "VARCHAR";
						column.isNull = false;
						column.column_lenght = 20;
						break;

					case 247:
						column.table_name = "VW_ORG_CADASTRADAS";
						column.indice_col = 4;
						column.column_name = "TP_ORG";
						column.column_type = "VARCHAR";
						column.isNull = false;
						column.column_lenght = 1;
						break;

					case 248:
						column.table_name = "VW_ORG_CADASTRADAS";
						column.indice_col = 5;
						column.column_name = "NM_ORG_PATH";
						column.column_type = "LTREE";
						column.isNull = false;
						break;

					case 249:
						column.table_name = "VW_ORG_CADASTRADAS";
						column.indice_col = 6;
						column.column_name = "ID_ORG_MAE";
						column.column_type = "INT";
						column.isNull = false;
						column.column_lenght = 32;
						column.column_precision = 2;
						break;

					case 250:
						column.table_name = "VW_ORG_CADASTRADAS";
						column.indice_col = 7;
						column.column_name = "DESCI";
						column.column_type = "TEXT";
						column.isNull = false;
						break;

					case 251:
						column.table_name = "VW_ORG_USUARIO";
						column.indice_col = 1;
						column.column_name = "ID_ORG";
						column.column_type = "INT";
						column.isNull = false;
						column.column_lenght = 32;
						column.column_precision = 2;
						break;

					case 252:
						column.table_name = "VW_ORG_USUARIO";
						column.indice_col = 2;
						column.column_name = "NM_ORG_RESUMIDO";
						column.column_type = "VARCHAR";
						column.isNull = false;
						column.column_lenght = 20;
						break;

					case 253:
						column.table_name = "VW_ORG_USUARIO";
						column.indice_col = 3;
						column.column_name = "NM_ORG";
						column.column_type = "VARCHAR";
						column.isNull = false;
						column.column_lenght = 50;
						break;

					case 254:
						column.table_name = "VW_ORG_USUARIO";
						column.indice_col = 4;
						column.column_name = "TP_ORG";
						column.column_type = "VARCHAR";
						column.isNull = false;
						column.column_lenght = 1;
						break;

					case 255:
						column.table_name = "VW_ORG_USUARIO";
						column.indice_col = 5;
						column.column_name = "ID_USU";
						column.column_type = "VARCHAR";
						column.isNull = false;
						column.column_lenght = 50;
						break;

					case 256:
						column.table_name = "VW_PAP_USUARIO";
						column.indice_col = 1;
						column.column_name = "ID_PAPEL";
						column.column_type = "VARCHAR";
						column.isNull = false;
						column.column_lenght = 20;
						break;

					case 257:
						column.table_name = "VW_PAP_USUARIO";
						column.indice_col = 2;
						column.column_name = "DS_PAPEL";
						column.column_type = "VARCHAR";
						column.isNull = false;
						column.column_lenght = 255;
						break;

					case 258:
						column.table_name = "VW_PAP_USUARIO";
						column.indice_col = 3;
						column.column_name = "TP_PAPEL";
						column.column_type = "INT";
						column.isNull = false;
						column.column_lenght = 32;
						column.column_precision = 2;
						break;

					case 259:
						column.table_name = "VW_PAP_USUARIO";
						column.indice_col = 4;
						column.column_name = "ID_ORG";
						column.column_type = "INT";
						column.isNull = false;
						column.column_lenght = 32;
						column.column_precision = 2;
						break;

					case 260:
						column.table_name = "VW_PAP_USUARIO";
						column.indice_col = 5;
						column.column_name = "ID_USU";
						column.column_type = "VARCHAR";
						column.isNull = false;
						column.column_lenght = 50;
						break;

					case 261:
						column.table_name = "VW_SIS_FUNCAO_IMPLEMENTAR";
						column.indice_col = 1;
						column.column_name = "ID_SIS";
						column.column_type = "INT";
						column.isNull = false;
						column.column_lenght = 32;
						column.column_precision = 2;
						break;

					case 262:
						column.table_name = "VW_SIS_FUNCAO_IMPLEMENTAR";
						column.indice_col = 2;
						column.column_name = "ID_MOD";
						column.column_type = "INT";
						column.isNull = false;
						column.column_lenght = 32;
						column.column_precision = 2;
						break;

					case 263:
						column.table_name = "VW_SIS_FUNCAO_IMPLEMENTAR";
						column.indice_col = 3;
						column.column_name = "ID_FUNCAO";
						column.column_type = "INT";
						column.isNull = false;
						column.column_lenght = 32;
						column.column_precision = 2;
						break;

					case 264:
						column.table_name = "VW_SIS_FUNCAO_IMPLEMENTAR";
						column.indice_col = 4;
						column.column_name = "NM_FUNCAO";
						column.column_type = "VARCHAR";
						column.isNull = false;
						column.column_lenght = 20;
						break;

					case 265:
						column.table_name = "VW_SIS_FUNCAO_IMPLEMENTAR";
						column.indice_col = 5;
						column.column_name = "DS_FUNCAO";
						column.column_type = "VARCHAR";
						column.isNull = false;
						column.column_lenght = 255;
						break;

					case 266:
						column.table_name = "VW_SIS_FUNCAO_IMPLEMENTAR";
						column.indice_col = 6;
						column.column_name = "IND_INCL_REG";
						column.column_type = "VARCHAR";
						column.isNull = false;
						column.column_lenght = 1;
						break;

					case 267:
						column.table_name = "VW_SIS_FUNCAO_IMPLEMENTAR";
						column.indice_col = 7;
						column.column_name = "IND_INCL_ALT";
						column.column_type = "VARCHAR";
						column.isNull = false;
						column.column_lenght = 1;
						break;

					case 268:
						column.table_name = "VW_SIS_FUNCAO_IMPLEMENTAR";
						column.indice_col = 8;
						column.column_name = "IND_EXCL_REG";
						column.column_type = "VARCHAR";
						column.isNull = false;
						column.column_lenght = 1;
						break;

					case 269:
						column.table_name = "VW_SIS_FUNCAO_IMPLEMENTAR";
						column.indice_col = 9;
						column.column_name = "IND_CONS_REG";
						column.column_type = "VARCHAR";
						column.isNull = false;
						column.column_lenght = 1;
						break;

					case 270:
						column.table_name = "VW_SIS_FUNCAO_IMPLEMENTAR";
						column.indice_col = 10;
						column.column_name = "IND_EXECUTE";
						column.column_type = "VARCHAR";
						column.isNull = false;
						column.column_lenght = 1;
						break;

					case 271:
						column.table_name = "VW_SIS_ORGANIZACAO";
						column.indice_col = 1;
						column.column_name = "ID_ORG";
						column.column_type = "INT";
						column.isNull = false;
						column.column_lenght = 32;
						column.column_precision = 2;
						break;

					case 272:
						column.table_name = "VW_SIS_ORGANIZACAO";
						column.indice_col = 2;
						column.column_name = "ID_PAPEL";
						column.column_type = "VARCHAR";
						column.isNull = false;
						column.column_lenght = 20;
						break;

					case 273:
						column.table_name = "VW_SIS_ORGANIZACAO";
						column.indice_col = 3;
						column.column_name = "DS_PAPEL";
						column.column_type = "VARCHAR";
						column.isNull = false;
						column.column_lenght = 255;
						break;

					case 274:
						column.table_name = "VW_SIS_ORGANIZACAO";
						column.indice_col = 4;
						column.column_name = "ID_USU_INCL";
						column.column_type = "VARCHAR";
						column.isNull = false;
						column.column_lenght = 50;
						break;

					case 275:
						column.table_name = "VW_SIS_ORGANIZACAO";
						column.indice_col = 5;
						column.column_name = "DT_INCLUSAO";
						column.column_type = "DATE";
						column.isNull = false;
						break;

					case 276:
						column.table_name = "VW_SIS_ORGANIZACAO";
						column.indice_col = 6;
						column.column_name = "NM_ORG";
						column.column_type = "VARCHAR";
						column.isNull = false;
						column.column_lenght = 50;
						break;

					case 277:
						column.table_name = "VW_SIS_PAP_USU";
						column.indice_col = 1;
						column.column_name = "ID_PAPEL";
						column.column_type = "VARCHAR";
						column.isNull = false;
						column.column_lenght = 20;
						break;

					case 278:
						column.table_name = "VW_SIS_PAP_USU";
						column.indice_col = 2;
						column.column_name = "ID_USU";
						column.column_type = "VARCHAR";
						column.isNull = false;
						column.column_lenght = 50;
						break;

					case 279:
						column.table_name = "VW_SIS_PAP_USU";
						column.indice_col = 3;
						column.column_name = "ID_USU_INCL";
						column.column_type = "VARCHAR";
						column.isNull = false;
						column.column_lenght = 50;
						break;

					case 280:
						column.table_name = "VW_SIS_PAP_USU";
						column.indice_col = 4;
						column.column_name = "DT_INCLUSAO";
						column.column_type = "DATE";
						column.isNull = false;
						break;
					case 281:
						column.table_name = "SIS_SISTEMA";
						column.indice_col = 5;
						column.column_name = "NR_VERSAO";
						column.column_type = "VARCHAR";
						column.column_lenght = 10;
						column.isNull = true;
						break;
					case 282:
						column.table_name = "SIS_SISTEMA_VERSAO_IMPLEMENTADO";
						column.indice_col = 2;
						column.column_name = "NR_VERSAO";
						column.column_type = "VARCHAR";
						column.column_lenght = 10;
						column.isNull = true;
						break;
					case 284:
						column.table_name = "SIS_SISTEMA_VERSAO_IMPLEMENTADO";
						column.indice_col = 1;
						column.column_name = "ID_SIS";
						column.column_type = "INT";
						column.isNull = true;
						break;



				}

				ListColumns.Add(column);
				indice += 1;
            }

            return ListColumns;
        }
        public List<tables> MontaTables()
        {
            int tot_Tables = 30;
            int indice = 1;
            List<tables> ListTable = new List<tables>();
            
            while (indice <= tot_Tables)
            {
                tables tablename = new tables();
                tablename.idTable = indice;

                switch(indice)
                {
                    case 1:
                        tablename.table_name = "SIS_USUARIO";
                        break;
                    case 2:
                        tablename.table_name = "SIS_SISTEMA";        
                        break;
                    case 3:
                        tablename.table_name = "SIS_MODULO";
                        break;
                    case 4:
                        tablename.table_name = "SIS_FUNCAO";
                        break;
                    case 5:
                        tablename.table_name = "SIS_PAPEL";
                        break;
                    case 6:
                        tablename.table_name = "SIS_PARAMETRO";
                        break;
                    case 7:
                        tablename.table_name = "COR_ORGANIZACAO";
                        break;
                    case 8:
                        tablename.table_name = "SIS_CONFIGURACAO";
                        break;
                    case 9:
                        tablename.table_name = "SIS_CONFIGURACAO_EMAIL";
                        break;
                    case 10:
                        tablename.table_name = "SIS_CONFIGURACAO_TECLA";
                        break;
                    case 11:
                        tablename.table_name = "COR_ORGANIZACAO_LICENCA";
                        break;
                    case 12:
                        tablename.table_name = "SIS_MODULO_FUNCAO";
                        break;
                    case 13:
                        tablename.table_name = "SIS_MODULO_ORGANIZACAO";
                        break;
                    case 14:
                        tablename.table_name = "SIS_ORGANIZACAO_PAPEL";
                        break;
                    case 15:
                        tablename.table_name = "SIS_ORGANIZACAO_PAPEL_USUARIO";
                        break;
                    case 16:
                        tablename.table_name = "SIS_PAPEL_USUARIO";
                        break;
                    case 17:
                        tablename.table_name = "SIS_PAPEL_FUNCAO";
                        break;
                    case 18:
                        tablename.table_name = "SIS_FUNCAO_IMPLEMENTADA";
                        break;
                    case 19:
                        tablename.table_name = "SIS_USUARIO_ORGANIZACAO";
                        break;
                    case 20:
                        tablename.table_name = "SIS_USUARIO_LOG";
                        break;
                    case 21:
                        tablename.table_name = "SIS_USUARIO_HIST";
                        break;
                    case 22:
                        tablename.table_name = "COR_GRUPO_MERCADORIA";
                        break;
                    case 23:
                        tablename.table_name = "COR_SUB_GRUPO_MERCADORIA";
                        break;
                    case 24:
                        tablename.table_name = "COR_UNIDADE_MERCADORIA";
                        break;
                    case 25:
                        tablename.table_name = "COR_GENERO_MERCADORIA";
                        break;
                    case 26:
                        tablename.table_name = "COR_NCM_MERCADORIA";
                        break;
                    case 27:
                        tablename.table_name = "COR_MERCADORIA";
                        break;
                    case 28:
                        tablename.table_name = "COR_MERCADORIA_VIGENCIA";
                        break;
					case 29:
						tablename.table_name = "SIS_SISTEMA_VERSAO_IMPLEMENTADO";
						break;
					case 30:
						tablename.table_name = "COR_UNIDADE_MEDIDA";
						break;
				}

                ListTable.Add(tablename);
                indice += 1;
            }
            return ListTable;

        }
    }
}
