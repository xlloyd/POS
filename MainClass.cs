using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS
{
    internal class MainClass
    {
        public static readonly string con_string = "";
        public static SqlConnection con = new SqlConnection(con_string);
    }
}
