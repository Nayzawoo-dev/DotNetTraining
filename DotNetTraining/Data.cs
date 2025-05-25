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
       

        public DataTable Read(string query,params SqlParameter[] parameters)
        {

            SqlConnection connection = new SqlConnection(_connectionStringBuilder.ConnectionString);
            connection.Open();
            SqlCommand cmd = new SqlCommand(query,connection);
            cmd.Parameters.AddRange(parameters);
            SqlDataAdapter adt = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adt.Fill(dt);
            connection.Close();
            return dt;
        }
        public int Execute(string query,params SqlParameter[] parameters)
        {

            SqlConnection connection = new SqlConnection(_connectionStringBuilder.ConnectionString);
            connection.Open();
            SqlCommand cmd = new SqlCommand(query,connection);
            cmd.Parameters.AddRange(parameters);
            int res = cmd.ExecuteNonQuery();
            connection.Close();
            return res;
        }
    }
}
