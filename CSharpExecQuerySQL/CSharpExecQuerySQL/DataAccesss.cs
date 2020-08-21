using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;

namespace CSharpExecQuerySQL
{
    public class DataAccesss
    {
        public DataSet GetData(string theDate1, string theDate2)
        {
            DataSet myDs = new DataSet();
            DataTable myTable = myDs.Tables.Add("Table1");

            using (System.Data.SqlClient.SqlConnection connection = new System.Data.SqlClient.SqlConnection(Connect.ConnectToDatabase(SettingFile.Default.SettingNameSv, SettingFile.Default.SettingNameDb)))
            {
                System.Data.SqlClient.SqlCommand sqlCommand = new System.Data.SqlClient.SqlCommand("dbo.Invoice_GetByDate", connection);
                sqlCommand.Parameters.AddWithValue("@BasTar", theDate1);
                sqlCommand.Parameters.AddWithValue("@BitTar", theDate2);
                sqlCommand.CommandType = CommandType.StoredProcedure;

                System.Data.SqlClient.SqlDataAdapter dataAdapter = new System.Data.SqlClient.SqlDataAdapter();
                dataAdapter.SelectCommand = sqlCommand;
                dataAdapter.Fill(myDs, "Table1");
                return myDs;
            }
        }
    }
}


