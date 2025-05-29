using System.ComponentModel;
using System.Data;
using AdoDapperTest;
using DatabaseClassLibrary;
using Microsoft.Data.SqlClient;

Console.WriteLine("Hello, World!");

AdoSqlService ado = new AdoSqlService(new SqlConnectionStringBuilder
{
    DataSource = "DELL",
    InitialCatalog = "DotNetTraining",
    UserID = "SA",
    Password = "root",
    TrustServerCertificate = true
});

DapperSqlService dapper = new DapperSqlService(new SqlConnectionStringBuilder
{
    DataSource = "DELL",
    InitialCatalog = "DotNetTraining",
    UserID = "SA",
    Password = "root",
    TrustServerCertificate = true
});

dapper.Execute(@"DELETE FROM [dbo].[Tbl_Window]
      WHERE Id = @Id",new Person
{
     Id = 7
});
var lst = dapper.Query<Person>("select * from Tbl_Window");

foreach (Person item in lst)
{
    Console.Write(item.UserName + "");
    Console.WriteLine(item.Password);
}

