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
    public class DictionaryConstraintDAL
    {
        private Connect vConnect = new Connect();
        public List<constraint> RecuperaTodosConstraints(ref Banco pBanco, string pUser)
        {
            string vsSql = @"select UPPER(ccu.table_name) as TABLE_NAME,
                                           pgc.conname as constraint_name,
                                           'CK' as CONSTRAINT_TYPE,
                                           replace(replace(replace(replace(replace(replace(replace(pg_get_constraintdef(pgc.oid,true),'::text',''),'= ANY',' IN '),'ARRAY',''),'::character varying',''),'[',''),']',''),'CHECK','') as command_constraint
                                    from pg_catalog.pg_constraint pgc
                                    join pg_catalog.pg_namespace nsp on nsp.oid = pgc.connamespace
                                    join pg_catalog.pg_class  cls on pgc.conrelid = cls.oid
                                    left join information_schema.constraint_column_usage ccu
                                              on pgc.conname = ccu.constraint_name
                                              and nsp.nspname = ccu.constraint_schema
                                    where contype ='c'
                                      and ccu.constraint_schema = @usuario
                                    union all
                                    select upper(tc.table_name) as table_name
                                           , tc.constraint_name 
                                           , case when tc.constraint_type = 'UNIQUE' then 'UQ'
                                           else 
                                             'PK'
                                           end as constraint_type 
                                           ,TC.constraint_type ||' ('||STRING_AGG(ccu.column_name,',' order by ccu.ordinal_position )||')' command_constraint
                                        from information_schema.table_constraints tc 
                                       inner join information_schema.key_column_usage ccu on (tc.constraint_name = ccu.constraint_name and tc.table_name = ccu.table_name) 
                                       where tc.constraint_type in ('UNIQUE','PRIMARY KEY')
                                         and tc.constraint_schema  = @usuario
                                       group by upper(tc.table_name)
                                           , tc.constraint_name
                                           ,case when tc.constraint_type = 'UNIQUE' then 'U'
                                           else 
                                             'P'
                                           end
                                           ,TC.constraint_type
                                    union all
                                    select upper(q1.constraint_table) as table_name
                                         ,q1.constraint_name
	                                     ,'FK' as constraint_type
                                         ,q1.definition  
                                    from      
                                    (
                                    WITH unnested_confkey AS (
                                      SELECT oid, unnest(confkey) as confkey
                                      FROM pg_constraint
                                    ),
                                    unnested_conkey AS (
                                      SELECT oid, unnest(conkey) as conkey
                                      FROM pg_constraint
                                    )
                                    select
                                      c.conname                   AS constraint_name,
                                      c.contype                   AS constraint_type,
                                      tbl.relname                 AS constraint_table,
                                      col.attname                 AS constraint_column,
                                      referenced_tbl.relname      AS referenced_table,
                                      referenced_field.attname    AS referenced_column,
                                      pg_get_constraintdef(c.oid) AS definition
                                    FROM pg_constraint c
                                    LEFT JOIN unnested_conkey con ON c.oid = con.oid
                                    LEFT JOIN pg_class tbl ON tbl.oid = c.conrelid
                                    LEFT JOIN pg_attribute col ON (col.attrelid = tbl.oid AND col.attnum = con.conkey)
                                    LEFT JOIN pg_class referenced_tbl ON c.confrelid = referenced_tbl.oid
                                    LEFT JOIN unnested_confkey conf ON c.oid = conf.oid
                                    LEFT JOIN pg_attribute referenced_field ON (referenced_field.attrelid = c.confrelid AND referenced_field.attnum = conf.confkey)
                                    WHERE c.contype = 'f'
                                    ) q1
                                      ";
            var vParametro = new Dictionary<string, dynamic>()
            {
                {"usuario",pUser }
            };
            return GetConstraints(ref pBanco, vsSql, vParametro);
        }
        private List<constraint> GetConstraints(ref Banco pBanco, string psSql, Dictionary<string, dynamic> Parametro)
        {
            var ListAllConstraints = new List<constraint>();
            var vConnectado = vConnect.GetConnection(ref pBanco);
            var GetResults = vConnect.ObtemLista(psSql, ref vConnectado, Parametro);
            
            if (GetResults.HasRows)
            {
                while (GetResults.Read())
                {
                    constraint RecordConstraint = new constraint();
                    RecordConstraint.table_name = GetResults.GetString(0);
                    RecordConstraint.constraint_Name = GetResults.GetString(1);
                    RecordConstraint.constraint_type = GetResults.GetString(2);
                    RecordConstraint.command_constraint = GetResults.GetString(3);

                    ListAllConstraints.Add(RecordConstraint);
                }
            }

            var bClose = vConnect.FechaConnection(ref vConnectado);
            return ListAllConstraints;
        }
    }
}
