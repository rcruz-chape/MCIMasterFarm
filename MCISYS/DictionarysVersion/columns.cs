using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MCISYS.DictionarysVersion
{
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
}
