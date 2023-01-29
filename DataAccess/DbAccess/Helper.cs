using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.DbAccess
{
    public static class Helper
    {
        public static string SqlCnnVal(string name)//get the sql connection string
        {
            return ConfigurationManager.ConnectionStrings[name].ConnectionString;
        }
        public static string OleCnnVal(string name, string FilePath)//get the ole connection string
        {
            string conStr = string.Format(ConfigurationManager.ConnectionStrings[name].ConnectionString, FilePath);
            return conStr;
        }
    }
}


