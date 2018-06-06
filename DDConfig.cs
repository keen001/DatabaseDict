using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseDict
{
    public class DDConfig:Keen001.KNF.Core.ConfigModel
    {
        public DDConfig() 
        {
            this.FileName = "dd.config";
            this.listDBConfig = new List<DatabaseConfig>();
        }

        public List<DatabaseConfig> listDBConfig { get; set; }
    }
}
