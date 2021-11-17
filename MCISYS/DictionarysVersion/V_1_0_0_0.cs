using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MCISYS.DictionarysVersion
{
    
    public class tables
    {
        public int idTable { get; set; }
        public string table_name { get; set; }
    }
    public class constraint
    {
        public string table_name { get; set; }
        public string constraint_Name { set; get; }
        public string constraint_type { set; get; }
        public string command_constraint { set; get; }
    }
    public class columns
    {
        public string table_name { get; set; }
        public int indice_col { set; get; }
        public string column_name { get; set; }
        public string column_type { get; set; }
        public Boolean isNull { get; set; }
        public int? column_lenght { set; get; }
        public int? column_precision { set; get; }

    }

    public class sequence
    {
        public string sequence_name { get; set; }
        public string comand_sequence { get; set; }
    }

    public class views
    {
        public string view_name { get; set; }
        public string view_command { get; set; }
    }
    public class V_1_0_0_0
    {
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
            int tot_colunas = 280;
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
						column.column_type = "NUMERIC";
						column.isNull = true;
						column.column_lenght = 2;
						column.column_precision = 10;
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
						column.column_type = "INT4";
						column.isNull = true;
						column.column_lenght = 32;
						column.column_precision = 2;
						break;

					case 7:
						column.table_name = "COR_GRUPO_MERCADORIA";
						column.indice_col = 2;
						column.column_name = "ID_GRP_MERC";
						column.column_type = "INT4";
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
						column.column_type = "INT4";
						column.isNull = true;
						column.column_lenght = 32;
						column.column_precision = 2;
						break;

					case 15:
						column.table_name = "COR_MERCADORIA";
						column.indice_col = 2;
						column.column_name = "COD_MERC";
						column.column_type = "NUMERIC";
						column.isNull = true;
						column.column_lenght = 7;
						column.column_precision = 10;
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
						column.column_type = "INT4";
						column.isNull = true;
						column.column_lenght = 32;
						column.column_precision = 2;
						break;

					case 18:
						column.table_name = "COR_MERCADORIA";
						column.indice_col = 5;
						column.column_name = "ID_GRP_MERC";
						column.column_type = "INT4";
						column.isNull = true;
						column.column_lenght = 32;
						column.column_precision = 2;
						break;

					case 19:
						column.table_name = "COR_MERCADORIA";
						column.indice_col = 6;
						column.column_name = "ID_SUBGRP_MERC";
						column.column_type = "INT4";
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
						column.column_precision = 10;
						break;

					case 29:
						column.table_name = "COR_MERCADORIA";
						column.indice_col = 16;
						column.column_name = "VL_PESO_LIQUIDO";
						column.column_type = "NUMERIC";
						column.isNull = false;
						column.column_lenght = 9;
						column.column_precision = 10;
						break;

					case 30:
						column.table_name = "COR_MERCADORIA";
						column.indice_col = 17;
						column.column_name = "QTD_ESTOQUE_REAL";
						column.column_type = "NUMERIC";
						column.isNull = false;
						column.column_lenght = 9;
						column.column_precision = 10;
						break;

					case 31:
						column.table_name = "COR_MERCADORIA";
						column.indice_col = 18;
						column.column_name = "QTD_ESTOQUE_DISPONIVEL";
						column.column_type = "NUMERIC";
						column.isNull = false;
						column.column_lenght = 9;
						column.column_precision = 10;
						break;

					case 32:
						column.table_name = "COR_MERCADORIA";
						column.indice_col = 19;
						column.column_name = "QTD_ESTOQUE_MINIMO";
						column.column_type = "NUMERIC";
						column.isNull = false;
						column.column_lenght = 9;
						column.column_precision = 10;
						break;

					case 33:
						column.table_name = "COR_MERCADORIA";
						column.indice_col = 20;
						column.column_name = "QTD_ESTOQUE_MAX";
						column.column_type = "NUMERIC";
						column.isNull = false;
						column.column_lenght = 9;
						column.column_precision = 10;
						break;

					case 34:
						column.table_name = "COR_MERCADORIA";
						column.indice_col = 21;
						column.column_name = "VL_ALI_IPI";
						column.column_type = "NUMERIC";
						column.isNull = false;
						column.column_lenght = 5;
						column.column_precision = 10;
						break;

					case 35:
						column.table_name = "COR_MERCADORIA";
						column.indice_col = 22;
						column.column_name = "VL_ALI_ISS";
						column.column_type = "NUMERIC";
						column.isNull = false;
						column.column_lenght = 5;
						column.column_precision = 10;
						break;

					case 36:
						column.table_name = "COR_MERCADORIA";
						column.indice_col = 23;
						column.column_name = "VL_ALI_ICMS_DUF";
						column.column_type = "NUMERIC";
						column.isNull = false;
						column.column_lenght = 5;
						column.column_precision = 10;
						break;

					case 37:
						column.table_name = "COR_MERCADORIA";
						column.indice_col = 24;
						column.column_name = "VL_NR_ALTURA";
						column.column_type = "NUMERIC";
						column.isNull = false;
						column.column_lenght = 5;
						column.column_precision = 10;
						break;

					case 38:
						column.table_name = "COR_MERCADORIA";
						column.indice_col = 25;
						column.column_name = "VL_NR_LARGURA";
						column.column_type = "NUMERIC";
						column.isNull = false;
						column.column_lenght = 5;
						column.column_precision = 10;
						break;

					case 39:
						column.table_name = "COR_MERCADORIA";
						column.indice_col = 26;
						column.column_name = "VL_NR_COMPRIMENTO";
						column.column_type = "NUMERIC";
						column.isNull = false;
						column.column_lenght = 5;
						column.column_precision = 10;
						break;

					case 40:
						column.table_name = "COR_MERCADORIA";
						column.indice_col = 27;
						column.column_name = "VL_NR_ESPESSURA";
						column.column_type = "NUMERIC";
						column.isNull = false;
						column.column_lenght = 5;
						column.column_precision = 10;
						break;

					case 41:
						column.table_name = "COR_MERCADORIA";
						column.indice_col = 28;
						column.column_name = "VL_NR_PROFUNDIDADE";
						column.column_type = "NUMERIC";
						column.isNull = false;
						column.column_lenght = 5;
						column.column_precision = 10;
						break;

					case 42:
						column.table_name = "COR_MERCADORIA";
						column.indice_col = 29;
						column.column_name = "VL_NR_DIAMETRO";
						column.column_type = "NUMERIC";
						column.isNull = false;
						column.column_lenght = 5;
						column.column_precision = 10;
						break;

					case 43:
						column.table_name = "COR_MERCADORIA";
						column.indice_col = 30;
						column.column_name = "VL_CUSTO_REPOSICAO";
						column.column_type = "NUMERIC";
						column.isNull = false;
						column.column_lenght = 9;
						column.column_precision = 10;
						break;

					case 44:
						column.table_name = "COR_MERCADORIA";
						column.indice_col = 31;
						column.column_name = "VL_BASE_VENDA";
						column.column_type = "NUMERIC";
						column.isNull = false;
						column.column_lenght = 9;
						column.column_precision = 10;
						break;

					case 45:
						column.table_name = "COR_MERCADORIA";
						column.indice_col = 32;
						column.column_name = "VL_MINIMO_VENDA";
						column.column_type = "NUMERIC";
						column.isNull = false;
						column.column_lenght = 9;
						column.column_precision = 10;
						break;

					case 46:
						column.table_name = "COR_MERCADORIA";
						column.indice_col = 33;
						column.column_name = "VL_EMDOLAR";
						column.column_type = "NUMERIC";
						column.isNull = false;
						column.column_lenght = 9;
						column.column_precision = 10;
						break;

					case 47:
						column.table_name = "COR_MERCADORIA";
						column.indice_col = 34;
						column.column_name = "VL_PROMOCAO";
						column.column_type = "NUMERIC";
						column.isNull = false;
						column.column_lenght = 9;
						column.column_precision = 10;
						break;

					case 48:
						column.table_name = "COR_MERCADORIA";
						column.indice_col = 35;
						column.column_name = "VL_PROMOCAO_CONTRIBUINTE";
						column.column_type = "NUMERIC";
						column.isNull = false;
						column.column_lenght = 9;
						column.column_precision = 10;
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
						column.column_type = "INT4";
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
						column.column_precision = 10;
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
						column.column_type = "NUMERIC";
						column.isNull = true;
						column.column_lenght = 2;
						column.column_precision = 10;
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
						column.column_type = "INT4";
						column.isNull = true;
						column.column_lenght = 32;
						column.column_precision = 2;
						break;

					case 63:
						column.table_name = "COR_MERCADORIA_VIGENCIA";
						column.indice_col = 9;
						column.column_name = "ID_SUBGRP_MERC";
						column.column_type = "INT4";
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
						column.column_type = "NUMERIC";
						column.isNull = true;
						column.column_lenght = 2;
						column.column_precision = 10;
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
						column.column_type = "INT4";
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
						column.column_type = "INT4";
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
						column.column_type = "INT4";
						column.isNull = true;
						column.column_lenght = 32;
						column.column_precision = 2;
						break;

					case 79:
						column.table_name = "COR_ORGANIZACAO_LICENCA";
						column.indice_col = 2;
						column.column_name = "NR_CNPJ_RAIZ";
						column.column_type = "INT4";
						column.isNull = true;
						column.column_lenght = 32;
						column.column_precision = 2;
						break;

					case 80:
						column.table_name = "COR_ORGANIZACAO_LICENCA";
						column.indice_col = 3;
						column.column_name = "DS_AMBIENTE";
						column.column_type = "INT4";
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
						column.column_type = "INT4";
						column.isNull = true;
						column.column_lenght = 32;
						column.column_precision = 2;
						break;

					case 84:
						column.table_name = "COR_SUB_GRUPO_MERCADORIA";
						column.indice_col = 2;
						column.column_name = "ID_GRP_MERC";
						column.column_type = "INT4";
						column.isNull = true;
						column.column_lenght = 32;
						column.column_precision = 2;
						break;

					case 85:
						column.table_name = "COR_SUB_GRUPO_MERCADORIA";
						column.indice_col = 3;
						column.column_name = "ID_SUBGRP_MERC";
						column.column_type = "INT4";
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
						column.column_type = "INT4";
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
						column.column_type = "INT4";
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
						column.column_type = "INT4";
						column.isNull = true;
						column.column_lenght = 32;
						column.column_precision = 2;
						break;

					case 104:
						column.table_name = "SIS_CONFIGURACAO_EMAIL";
						column.indice_col = 3;
						column.column_name = "BO_ENABLE_SSL";
						column.column_type = "BOOL";
						column.isNull = true;
						break;

					case 105:
						column.table_name = "SIS_CONFIGURACAO_EMAIL";
						column.indice_col = 4;
						column.column_name = "BO_USE_DEFAULT_CREDENTIALS";
						column.column_type = "BOOL";
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
						column.column_type = "INT4";
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
						column.column_type = "INT4";
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
						column.column_type = "INT4";
						column.isNull = true;
						column.column_lenght = 32;
						column.column_precision = 2;
						break;

					case 127:
						column.table_name = "SIS_MODULO";
						column.indice_col = 1;
						column.column_name = "ID_MOD";
						column.column_type = "INT4";
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
						column.column_type = "INT4";
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
						column.column_type = "INT4";
						column.isNull = true;
						column.column_lenght = 32;
						column.column_precision = 2;
						break;

					case 139:
						column.table_name = "SIS_MODULO_FUNCAO";
						column.indice_col = 2;
						column.column_name = "ID_MOD";
						column.column_type = "INT4";
						column.isNull = true;
						column.column_lenght = 32;
						column.column_precision = 2;
						break;

					case 140:
						column.table_name = "SIS_MODULO_FUNCAO";
						column.indice_col = 3;
						column.column_name = "ID_FUNCAO";
						column.column_type = "INT4";
						column.isNull = true;
						column.column_lenght = 32;
						column.column_precision = 2;
						break;

					case 141:
						column.table_name = "SIS_MODULO_ORGANIZACAO";
						column.indice_col = 1;
						column.column_name = "ID_ORG";
						column.column_type = "INT4";
						column.isNull = true;
						column.column_lenght = 32;
						column.column_precision = 2;
						break;

					case 142:
						column.table_name = "SIS_MODULO_ORGANIZACAO";
						column.indice_col = 2;
						column.column_name = "ID_SIS";
						column.column_type = "INT4";
						column.isNull = true;
						column.column_lenght = 32;
						column.column_precision = 2;
						break;

					case 143:
						column.table_name = "SIS_MODULO_ORGANIZACAO";
						column.indice_col = 3;
						column.column_name = "ID_MOD";
						column.column_type = "INT4";
						column.isNull = true;
						column.column_lenght = 32;
						column.column_precision = 2;
						break;

					case 144:
						column.table_name = "SIS_ORGANIZACAO_PAPEL";
						column.indice_col = 1;
						column.column_name = "ID_ORG";
						column.column_type = "INT4";
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
						column.column_type = "INT4";
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
						column.column_type = "INT4";
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
						column.column_type = "INT4";
						column.isNull = true;
						column.column_lenght = 32;
						column.column_precision = 2;
						break;

					case 162:
						column.table_name = "SIS_PAPEL_FUNCAO";
						column.indice_col = 3;
						column.column_name = "ID_MOD";
						column.column_type = "INT4";
						column.isNull = true;
						column.column_lenght = 32;
						column.column_precision = 2;
						break;

					case 163:
						column.table_name = "SIS_PAPEL_FUNCAO";
						column.indice_col = 4;
						column.column_name = "ID_FUNCAO";
						column.column_type = "INT4";
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
						column.column_type = "INT4";
						column.isNull = false;
						column.column_lenght = 32;
						column.column_precision = 2;
						break;

					case 173:
						column.table_name = "SIS_PARAMETRO";
						column.indice_col = 3;
						column.column_name = "IND_CAR_MINUSCULO";
						column.column_type = "INT4";
						column.isNull = false;
						column.column_lenght = 32;
						column.column_precision = 2;
						break;

					case 174:
						column.table_name = "SIS_PARAMETRO";
						column.indice_col = 4;
						column.column_name = "IND_NUMERO";
						column.column_type = "INT4";
						column.isNull = false;
						column.column_lenght = 32;
						column.column_precision = 2;
						break;

					case 175:
						column.table_name = "SIS_PARAMETRO";
						column.indice_col = 5;
						column.column_name = "IND_TOTAL_CAR";
						column.column_type = "INT4";
						column.isNull = false;
						column.column_lenght = 32;
						column.column_precision = 2;
						break;

					case 176:
						column.table_name = "SIS_SISTEMA";
						column.indice_col = 1;
						column.column_name = "ID_SIS";
						column.column_type = "INT4";
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
						column.indice_col = 5;
						column.column_name = "DT_INCLUSAO";
						column.column_type = "DATE";
						column.isNull = true;
						break;

					case 181:
						column.table_name = "SIS_SISTEMA";
						column.indice_col = 6;
						column.column_name = "DT_ALTERACAO";
						column.column_type = "DATE";
						column.isNull = false;
						break;

					case 182:
						column.table_name = "SIS_SISTEMA";
						column.indice_col = 7;
						column.column_name = "ID_USU_ALT";
						column.column_type = "VARCHAR";
						column.isNull = false;
						column.column_lenght = 50;
						break;

					case 183:
						column.table_name = "SIS_SISTEMA";
						column.indice_col = 8;
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
						column.column_type = "INT4";
						column.isNull = false;
						column.column_lenght = 32;
						column.column_precision = 2;
						break;

					case 191:
						column.table_name = "SIS_USUARIO";
						column.indice_col = 8;
						column.column_name = "QTD_LOGIN_SEM_SUCESSO";
						column.column_type = "INT4";
						column.isNull = false;
						column.column_lenght = 32;
						column.column_precision = 2;
						break;

					case 192:
						column.table_name = "SIS_USUARIO";
						column.indice_col = 9;
						column.column_name = "ID_PESSOA_FISICA";
						column.column_type = "INT4";
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
						column.column_type = "INT4";
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
						column.column_type = "INT4";
						column.isNull = false;
						column.column_lenght = 32;
						column.column_precision = 2;
						break;

					case 215:
						column.table_name = "VW_FUNCAO_HABILITADA_PAPEL";
						column.indice_col = 3;
						column.column_name = "ID_MOD";
						column.column_type = "INT4";
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
						column.column_type = "INT4";
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
						column.column_type = "INT4";
						column.isNull = false;
						column.column_lenght = 32;
						column.column_precision = 2;
						break;

					case 234:
						column.table_name = "VW_MODULO_FUNCAO";
						column.indice_col = 3;
						column.column_name = "ID_MOD";
						column.column_type = "INT4";
						column.isNull = false;
						column.column_lenght = 32;
						column.column_precision = 2;
						break;

					case 235:
						column.table_name = "VW_MODULO_FUNCAO";
						column.indice_col = 4;
						column.column_name = "ID_FUNCAO";
						column.column_type = "INT4";
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
						column.column_type = "INT4";
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
						column.column_type = "INT4";
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
						column.column_type = "INT4";
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
						column.column_type = "INT4";
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
						column.column_type = "INT4";
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
						column.column_type = "INT4";
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
						column.column_type = "INT4";
						column.isNull = false;
						column.column_lenght = 32;
						column.column_precision = 2;
						break;

					case 259:
						column.table_name = "VW_PAP_USUARIO";
						column.indice_col = 4;
						column.column_name = "ID_ORG";
						column.column_type = "INT4";
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
						column.column_type = "INT4";
						column.isNull = false;
						column.column_lenght = 32;
						column.column_precision = 2;
						break;

					case 262:
						column.table_name = "VW_SIS_FUNCAO_IMPLEMENTAR";
						column.indice_col = 2;
						column.column_name = "ID_MOD";
						column.column_type = "INT4";
						column.isNull = false;
						column.column_lenght = 32;
						column.column_precision = 2;
						break;

					case 263:
						column.table_name = "VW_SIS_FUNCAO_IMPLEMENTAR";
						column.indice_col = 3;
						column.column_name = "ID_FUNCAO";
						column.column_type = "INT4";
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
						column.column_type = "INT4";
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

				}


				indice += 1;
            }

            return ListColumns;
        }
        public List<tables> MontaTables()
        {
            int tot_Tables = 28;
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
                        tablename.table_name = "COR_SUBGRUPO_MERCADORIA";
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
                }

                ListTable.Add(tablename);
                indice += 1;
            }
            return ListTable;

        }
    }
}
