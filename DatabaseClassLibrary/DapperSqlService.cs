using System.Data;
using Dapper;
using Microsoft.Data.SqlClient;

namespace DatabaseClassLibrary
{
    public class DapperSqlService
    {
        public readonly SqlConnectionStringBuilder connection;
        public DapperSqlService(SqlConnectionStringBuilder connection)
        {
            this.connection = connection;
        }

        public List<T> Query<T>(string query,object parameters = null)
        {
            using IDbConnection queryconnection = new SqlConnection(connection.ConnectionString);
            queryconnection.Open();
            var res = queryconnection.Query<T>(query, parameters).ToList();
            queryconnection.Close();
            return res;  
        }

        public int Execute(string query, object parameter = null)
        {
            using IDbConnection execonnection = new SqlConnection(connection.ConnectionString);
            execonnection.Open();
            int res = execonnection.Execute(query, parameter);
            execonnection.Close();
            return res;
        }
    }
}
