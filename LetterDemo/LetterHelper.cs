using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LetterDemo
{
    public class MergePair
    {
        public string tag = "";
        public string value = "";
    }


    class LetterHelper
    {
        private SqlConnectionStringBuilder csBuilder = null;

        public LetterHelper()
        {
            csBuilder = new SqlConnectionStringBuilder();
            csBuilder.DataSource = ".\\SQLEXPRESS";
            csBuilder.InitialCatalog = "Core";
            csBuilder.IntegratedSecurity = true;
        }

        public DataRow ExecuteDataRow(string storedProcName, SqlParameter[] parameters)
        {
            if (csBuilder == null) throw new System.NullReferenceException("connection");
            if (storedProcName == null || storedProcName.Length == 0) throw new System.NullReferenceException("storedProcName");

            // Create a connection
            using (SqlConnection connection = new SqlConnection(csBuilder.ToString()))
            {
                // Create a command
                using (SqlCommand command = new SqlCommand(storedProcName, connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    foreach (SqlParameter parameter in parameters) command.Parameters.Add(parameter);
                    DataSet rtn = new DataSet();
                    DataRow row = null;
                    // Execute a command
                    using (SqlDataAdapter sqlDA = new SqlDataAdapter())
                    {
                        connection.Open();
                        sqlDA.SelectCommand = command;
                        sqlDA.Fill(rtn);
                        if (rtn.Tables[0].Rows.Count > 0) row = rtn.Tables[0].Rows[0];
                        connection.Close();
                        return row;
                    }
                }
            }
        }

    }
}
