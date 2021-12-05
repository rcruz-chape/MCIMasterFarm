using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MCIMasterFarm.Negocio.Global;
using MCISYS.Negocio.BackOffice.Model;
using MCIMasterFarm.Negocio.BackOffice.Sequence;
using MCIMasterFarm.Negocio.BackOffice.Model;
using MCIMasterFarm.Negocio.BackOffice.DAL;
using MCISYS.DictionarysVersion;

namespace MCISYS.Negocio.BackOffice.DAL
{
    public class ImplementaDDLDAL
    {
        private Connect vConnect = new Connect();
        public Boolean DropExtesion(extesion pExtension, ref Banco pBanco)
        {
            string vsSql = $@"DROP EXTENSION {pExtension.extension_name}";
            return vConnect.executeDdl(ref pBanco, vsSql);
        }
        public Boolean CreateExtesion(extesion pExtension, ref Banco pBanco)
        {
            string vsSql = $@"CREATE EXTENSION {pExtension.extension_name} SCHEMA {pExtension.extension_schema} VERSION ""{pExtension.version}""";
            return vConnect.executeDdl(ref pBanco, vsSql);
        }
        public Boolean CreateSchema(schemas pSchema, ref Banco pBanco)
        {
            Boolean vExecute = true;
            string vsSql = $@"CREATE SCHEMA {pSchema.schema_name} AUTHORIZATION {pSchema.schema_autorization}";
            vExecute = vConnect.executeDdl(ref pBanco, vsSql);
            if (!vExecute)
            {
                return vExecute;
            }
            vsSql = $@"GRANT ALL ON SCHEMA {pSchema.schema_name} TO PUBLIC";
            vExecute = vConnect.executeDdl(ref pBanco, vsSql);
            if (!vExecute)
            {
                return vExecute;
            }
            vsSql = $@"GRANT ALL ON SCHEMA {pSchema.schema_name} TO {pSchema.schema_autorization}";
            vExecute = vConnect.executeDdl(ref pBanco, vsSql);
            return vExecute;
        }
        public Boolean DropSchema(schemas pSchema, ref Banco pBanco)
        {
            string vsSql = $@"DROP SCHEMA {pSchema.schema_name} CASCADE";
            return vConnect.executeDdl(ref pBanco, vsSql);

        }
        public Boolean DropView(views pView, ref Banco pBanco)
        {
            string vsSql = $@"DROP VIEW {pView.view_name}";
            return vConnect.executeDdl(ref pBanco, vsSql);

        }
        public Boolean CreateView(views pView, ref Banco pBanco)
        {
            string vsSql = $@"CREATE VIEW {pView.view_name} as {pView.view_command}";
            return vConnect.executeDdl(ref pBanco, vsSql);
        }
        public Boolean DropSequence(sequence pSequence, ref Banco pBanco)
        {
            string vsSql = $@"DROP SEQUENCE {pSequence.sequence_name}";
            return vConnect.executeDdl(ref pBanco, vsSql);
        }
        public Boolean CreateSequence(sequence pSequence, ref Banco pBanco)
        {
            string vsSql = pSequence.comand_sequence;
            return vConnect.executeDdl(ref pBanco, vsSql);
        }
        public Boolean AlterTableAddColumn(columns pColumn, ref Banco pBanco)
        {
            string vsSql = $@"ALTER TABLE {pColumn.table_name} ADD COLUMN {pColumn.column_name}";
            if (pColumn.column_type == "VARCHAR")
            {
                vsSql += $@"({pColumn.column_lenght})";
            }
            else if (pColumn.column_type == "NUMERIC")
            {

                vsSql += $@"({pColumn.column_lenght},{pColumn.column_precision})";
            }
            if (pColumn.isNull)
            {
                vsSql += "NOT NULL";
            }
            else
            {
                vsSql += "NULL";
            }
            return vConnect.executeDdl(ref pBanco, vsSql);
        }
        public Boolean AlterTableDropColumn(columns pColumn, ref Banco pBanco)
        {
            string vsSql = $@"ALTER TABLE {pColumn.table_name} DROP COLUMN {pColumn.column_name}";
            return vConnect.executeDdl(ref pBanco, vsSql);

        }
        public Boolean AlterTableDropConstraint(constraint pConstraint, ref Banco pBanco)
        {
            string vsSql = $@"ALTER TABLE {pConstraint.table_name} DROP CONSTRAINT {pConstraint.constraint_Name}";
            return vConnect.executeDdl(ref pBanco, vsSql);
        }
        public Boolean AlterTableAddConstraint(constraint pConstraint, ref Banco pBanco)
        {
            string vsSql = $@"ALTER TABLE {pConstraint.table_name} ADD CONSTRAINT {pConstraint.constraint_Name}";
            if (pConstraint.constraint_type == "CK")
            {
                vsSql += " CHECK ";
            }
            vsSql += $@" {pConstraint.command_constraint}";
            return vConnect.executeDdl(ref pBanco, vsSql);


        }
        public Boolean CreateTable(tables pTable, List<columns> pColumns, List<constraint> pConstraint, ref Banco pBanco)
        {
            int vTotColumns = pColumns.Count();
            int vTotConstraint = pConstraint.Count();
            int vTotLinha = 0;
            string vsSql = $@"CREATE TABLE {pTable.table_name} (";
            
            foreach(var vColumn in pColumns)
            {
                if (vTotColumns > 1 && vTotLinha < vTotColumns && vTotLinha > 0)
                {
                    vsSql += ", ";
                }
                vsSql += Environment.NewLine;

                vsSql += $@"{vColumn.column_name} {vColumn.column_type}";
                if (vColumn.column_type == "VARCHAR")
                {
                    if (vColumn.column_lenght != null)
                    {
                        vsSql += $@"({vColumn.column_lenght})";
                    }
                }
                else if (vColumn.column_type == "NUMERIC")
                {

                    vsSql += $@"({vColumn.column_lenght},{vColumn.column_precision})";
                }
                if (vColumn.isNull)
                {
                    vsSql += " NOT NULL";
                }
                else
                {
                    vsSql += " NULL";
                }
                vTotLinha += 1;
            }
            vTotLinha = 0;
            if (vTotConstraint > 0)
            {
                foreach (var RegConstraint in pConstraint)
                {
                    if ((vTotConstraint > 1 && vTotLinha < vTotConstraint) || (vTotConstraint == 1))
                    {
                        vsSql += ", ";
                    }
                    vsSql += Environment.NewLine;
                    vsSql += $@"CONSTRAINT {RegConstraint.constraint_Name}";
                    if (RegConstraint.constraint_type == "CK")
                    {
                        vsSql += $@" CHECK ";
                    }
                    vsSql += $@" {RegConstraint.command_constraint}";
                    vTotLinha += 1;
                }
            }

            vsSql += ")";
            return vConnect.executeDdl(ref pBanco, vsSql);
        }
    }
}
