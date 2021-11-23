using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MCISYS.DictionarysVersion
{
    public class constraint
    {
        public string table_name { get; set; }
        public string constraint_Name { set; get; }
        public string constraint_type { set; get; }
        public string command_constraint { set; get; }
    }
}
