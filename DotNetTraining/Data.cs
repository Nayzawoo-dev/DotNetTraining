using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;

namespace DotNetTraining
{
    internal class Data
    {
        private readonly SqlConnectionStringBuilder _connectionStringBuilder = new SqlConnectionStringBuilder()
        {
            DataSource = "DELL",
            InitialCatalog = "DotNetTraining",
            UserID = "SA",
            Password = "root",
            TrustServerCertificate = true
        };
        private SqlConnection Connection()
        {
            SqlConnection connection = new SqlConnection(_connectionStringBuilder.ConnectionString);
            return connection;
        }

        public DataTable Read(string query,params SqlParameter[] parameters)
        {
            
            Connection().Open();
            SqlCommand cmd = new SqlCommand(query,Connection());
            cmd.Parameters.AddRange(parameters);
            SqlDataAdapter adt = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adt.Fill(dt);
            Connection().Close();
            return dt;
        }
        public int Execute(string query,params SqlParameter[] parameters)
        {
            Connection().Open();
            SqlCommand cmd = new SqlCommand(query, Connection());
            cmd.Parameters.AddRange(parameters);
            int res = cmd.ExecuteNonQuery();
            Connection().Close();
            return res;
        }
    }
}
