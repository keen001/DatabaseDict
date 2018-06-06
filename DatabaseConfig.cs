using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseDict
{
    public class DatabaseConfig
    {
        public DatabaseConfig() { }

        public String Name { get; set; }
        public String Type { get; set; }
        public String ConnString { get; set; }
        public String DatabaseName { get; set; }

        public String NameSpace { get; set; }

        public String PrimaryKeyType { get; set; }

    }
}
