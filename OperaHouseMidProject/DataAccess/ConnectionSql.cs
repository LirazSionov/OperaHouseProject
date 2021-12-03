using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperaHouseMidProject.DataAccess
{
    public class ConnectionSql
    {
        public static string GetConnectionString()
        {
            return "Server = localhost\\SQLEXPRESS;Database=MyOperaHouse;Trusted_Connection=True;"+
                "MultipleActiveResultSets=true";
        }
    }
}
