using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace CSharpExecQuerySQL
{
    public static class Connect
    {
        public static string ConnectToDatabase(string SvName, string DbName)
        {
            string myConnStr = $"Server ={SvName};Database={DbName};Trusted_Connection=True;";
            return myConnStr;
        }
    }
}