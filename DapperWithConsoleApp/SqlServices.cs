using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using Microsoft.Data.SqlClient;

namespace DapperWithConsoleApp
{
    internal class SqlServices
    {
        private readonly SqlConnectionStringBuilder _SqlStringBuilder = new SqlConnectionStringBuilder()
        {
            DataSource = "DELL",
            InitialCatalog = "DotNetTraining",
            UserID = "SA",
            Password = "root",
            TrustServerCertificate = true

        };
        public List<T> Query<T>(string query,object parameters = null)
        {
            using IDbConnection connection = new SqlConnection(_SqlStringBuilder.ConnectionString);
            connection.Open();
            var res = connection.Query<T>(query, parameters).ToList();
            connection.Close();
            return res;
        }

        public int Execute(string query,object parameters = null) {
            using IDbConnection connection = new SqlConnection(_SqlStringBuilder.ConnectionString);
            connection.Open();
            int res =  connection.Execute(query, parameters);
            connection.Close();
            return res;
            
        }
    }
}
