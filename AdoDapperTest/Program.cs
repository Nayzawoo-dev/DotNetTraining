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
      WHERE Id = @Id", new Person
{
    Id = 7
});
DataTable lst = ado.Query("select * from Tbl_Window where Id = @Id",
    new SqlParameter("@Id", 4));

foreach (DataRow item in lst.Rows)
{
    Console.WriteLine(item["UserName"]);
}

//=======================================================================================================

//Efe Test
//Read
PersonDbcontext person = new PersonDbcontext();
var list = person.PersonDatabase.ToList();

foreach (var item in list)
{
    Console.WriteLine(item.UserName);
}
//Insert
var per = new Person
{
    UserName = "Ya Na"
};
person.PersonDatabase.Add(per);
person.SaveChanges();
//Update
var list1 = person.PersonDatabase.Where(x => x.Id == 3).FirstOrDefault();
if (list1 != null)
{
    list1.UserName = "Thin Ya Na Lay";
}
person.SaveChanges();

//Delete

person.PersonDatabase.Remove(person.PersonDatabase.Where(x => x.Id == 3).FirstOrDefault()!);
person.SaveChanges();





