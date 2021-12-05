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
using MCISYS.DictionarysVersion;
using MCISYS.Negocio.BackOffice.DAL;

namespace MCISYS.Negocio.BackOffice.Negocio
{
    public class ImplementaDDLNEG
    {
        public ImplementaDDLDAL vImplementaDLL = new ImplementaDDLDAL();
        public DictionaryTablesDAL vTablesDAL = new DictionaryTablesDAL();
        public DictionaryColumnsDAL vColumnDAL = new DictionaryColumnsDAL();
        public DictionaryConstraintDAL vConstraintDAL = new DictionaryConstraintDAL();
        public DictionarySequenceDAL vSequenceDAL = new DictionarySequenceDAL();
        public DictionaryViewDAL vViewDAL = new DictionaryViewDAL();


        public Boolean ImplementaMCI(ref Banco pBanco, List<tables> pTabelas, List<columns>pColumns, List<constraint>pConstraint, List<views> pView, List<sequence> pSequence, schemas pSchema = null, extesion pExtension = null)
        {
            Boolean vReturn = true;

            if (pSchema != null)
            {
                vReturn = CriaSchemaMCISYS(ref pBanco, pSchema);
                if (!vReturn)
                {
                    return vReturn;
                }
            }
            if (pExtension != null)
            {
                vReturn = CriaExtensionMCISYS(ref pBanco, pExtension);
                if (!vReturn)
                {
                    return vReturn;
                }
            }
            var vTablesImplementadas = vTablesDAL.ObtemListaTabelas(ref pBanco);
            var vColumnsImplementadas = vColumnDAL.ObtemTodasColunas(ref pBanco);
            var vConstraintImplementadas = vConstraintDAL.RecuperaTodosConstraints(ref pBanco, "mcisys");
            var vSequencesImplementadas = vSequenceDAL.ObtemSequences(ref pBanco);
            var vViewImplementado = vViewDAL.RecuperaTodasView(ref pBanco);

            vReturn = CriaTabelasMCISys(ref pBanco, vTablesImplementadas, pTabelas, vColumnsImplementadas, pColumns, vConstraintImplementadas, pConstraint);
            vReturn = CriaSequencesMCISYS(ref pBanco, vSequencesImplementadas, pSequence);
            vReturn = CriaViewsMCISYS(ref pBanco, vViewImplementado, pView);
            return vReturn;
        }
        public Boolean CriaExtensionMCISYS(ref Banco pBanco, extesion pExtensio)
        {
            Boolean vReturn = true;
            vReturn = vImplementaDLL.CreateExtesion(pExtensio, ref pBanco);
            return vReturn;
        }
        public Boolean ExclueSchemaMCISYS(ref Banco pBanco, extesion pExtensioN)
        { 
            Boolean vReturn = true;
            vReturn = vImplementaDLL.DropExtesion(pExtensioN, ref pBanco);
            return vReturn;
        }
        public Boolean CriaSchemaMCISYS(ref Banco pBanco, schemas pSchema)
        {
            Boolean vReturn = true;
            vReturn = vImplementaDLL.CreateSchema(pSchema, ref pBanco);
            return vReturn;
        }
        public Boolean ExclueSchemaMCISYS(ref Banco pBanco, schemas pSchema)
        {
            Boolean vReturn = true;
            vReturn = vImplementaDLL.DropSchema(pSchema, ref pBanco);
            return vReturn;
        }
        private Boolean CriaViewsMCISYS(ref Banco pBanco, List<views> pViewsImplementadas, List<views> pViewsImplementar)
        {
            Boolean vReturn = true;
            foreach(var ViewRecord in pViewsImplementar)
            {
                if (pViewsImplementadas.Exists(ViewImpl => ViewImpl.view_name == ViewRecord.view_name))
                {
                    vReturn = vImplementaDLL.DropView(ViewRecord, ref pBanco);
                }
                vReturn = vImplementaDLL.CreateView(ViewRecord, ref pBanco);
            }
            return vReturn;
        }
        private Boolean CriaSequencesMCISYS(ref Banco pBanco,
                                               List<sequence> pSequenceImplementadas,
                                               List<sequence> pSequenceImplementar )
        {
            Boolean vReturn = true;
            foreach(var SequenceRecord in pSequenceImplementar)
            {
                if (pSequenceImplementadas.Exists(SeqImpl => SeqImpl.sequence_name == SequenceRecord.sequence_name))
                {
                    vReturn = vImplementaDLL.DropSequence(SequenceRecord, ref pBanco);
                }
                vReturn = vImplementaDLL.CreateSequence(SequenceRecord, ref pBanco);
            }
            return vReturn;
        }
        private Boolean CriaTabelasMCISys(ref Banco pBanco, 
                                               List<tables> pTabelasImplementadas,
                                               List<tables> pTabelasImplementar, 
                                               List<columns> pColumnsImplementadas,
                                               List<columns> pColumnsImplementar,
                                               List<constraint> pConstraintImplementadas,
                                               List<constraint> pConstraintImplementar)
        {
            Boolean vReturn = true;
            List<tables> vTablesSelecionadas = new List<tables>();
            List<columns> vColumnsImplement = new List<columns>();
            List<constraint> vConstraintImplement = new List<constraint>();
            vTablesSelecionadas = pTabelasImplementar.Except(pTabelasImplementadas).ToList();
            if (vTablesSelecionadas.Count > 0)
            {
                foreach (var recTables in vTablesSelecionadas)
                {
                    vColumnsImplement = pColumnsImplementar.FindAll(recColumn => recColumn.table_name == recTables.table_name);
                    vColumnsImplement = vColumnsImplement.OrderBy(linha => linha.indice_col).ToList();
                    vConstraintImplement = pConstraintImplementar.FindAll(recCons => recCons.table_name == recTables.table_name && recCons.constraint_type != "FK");
                    vReturn = vImplementaDLL.CreateTable(recTables, vColumnsImplement, vConstraintImplement, ref pBanco);
                }
            }
            vTablesSelecionadas = pTabelasImplementar.Intersect(pTabelasImplementadas).ToList();
            if (vTablesSelecionadas.Count > 0)
            {
                foreach (var recTables in vTablesSelecionadas)
                {
                    vColumnsImplement = pColumnsImplementar.FindAll(recColumn => recColumn.table_name == recTables.table_name);
                    vConstraintImplement = pConstraintImplementar.FindAll(recCons => recCons.table_name == recTables.table_name && recCons.constraint_type != "FK");
                }
                foreach(var recColumns in vColumnsImplement)
                {
                    if (pColumnsImplementadas.Exists(linha => linha.table_name == recColumns.table_name && linha.column_name == recColumns.column_name))
                    {
                        vReturn = vImplementaDLL.AlterTableDropColumn(recColumns, ref pBanco);
                    }
                    vReturn = vImplementaDLL.AlterTableAddColumn(recColumns, ref pBanco);
                }
                foreach (var recConst in vConstraintImplement)
                {
                    if (pConstraintImplementadas.Exists(linha => linha.table_name == recConst.table_name && linha.constraint_Name == recConst.constraint_Name))
                    {
                        vReturn = vImplementaDLL.AlterTableDropConstraint(recConst, ref pBanco);
                    }
                    vReturn = vImplementaDLL.AlterTableAddConstraint(recConst, ref pBanco);
                }
            }
            vConstraintImplement = pConstraintImplementar.FindAll(recCons => recCons.constraint_type == "FK");
            vConstraintImplement = vConstraintImplement.Except(pConstraintImplementadas).ToList();
            if (vConstraintImplement.Count > 0)
            {
                foreach (var RecConstraint in vConstraintImplement)
                {
                    vReturn = vImplementaDLL.AlterTableAddConstraint(RecConstraint, ref pBanco);
                }
            }
            return vReturn;
        }
    }
}
