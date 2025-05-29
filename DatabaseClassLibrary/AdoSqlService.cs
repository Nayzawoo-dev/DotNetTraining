using System.Data;
using Microsoft.Data.SqlClient;

namespace DatabaseClassLibrary
{
    public class AdoSqlService
    {
        SqlConnectionStringBuilder connection;

        public AdoSqlService(SqlConnectionStringBuilder connection)
        {
            this.connection = connection;
        }

        public DataTable Query(string query,params SqlParameter[] parameters)
        {
            SqlConnection queryconnection = new SqlConnection(connection.ConnectionString);
            queryconnection.Open();
            SqlCommand cmd = new SqlCommand(query, queryconnection);
            cmd.Parameters.AddRange(parameters);
            SqlDataAdapter adt = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adt.Fill(dt);
            queryconnection.Close();
            return dt;
        }

        public int Execute(string query,params SqlParameter[] parameters)
        {
            SqlConnection execonnection = new SqlConnection(connection.ConnectionString);
            execonnection.Open();
            SqlCommand cmd = new SqlCommand(query,execonnection);
            cmd.Parameters.AddRange(parameters);
            int res = cmd.ExecuteNonQuery();
            execonnection.Close();
            return res;
        }
    }
}
