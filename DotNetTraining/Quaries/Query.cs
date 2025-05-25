using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace DotNetTraining.Quaries
{
    internal class Query
    {
        public static string UserLogin { get;} = "select * from Tbl_Window where UserName = @Username";
        public static string UserLogin2 { get; } = "select * from Tbl_Window where  Password = @Password";

        //public static string Validate { get; set; } = "select * from Tbl_Window where UserName = @Username and Password = @Password";
        public static string ProductList { get; } = "select * from Tbl_Productlist";

        public static string InsertProduct { get; } = @"INSERT INTO [dbo].[Tbl_Productlist]
           ([ProductName]
           ,[Price]
           ,[Quantity]
           ,[CreatedDateTime]
           ,[CreatedByName]
           ,[CreatedById])
     VALUES
           (@ProductName
           ,@Price
           ,@Quantity
           ,@CreatedDateTime
           ,@CreatedByName
           ,@CreatedById)";
        public static string invalidName { get; set; } = "select * from Tbl_Productlist where ProductName = @ProductName";
        public static string joinQuery { get; } = @"select * from Tbl_Productlist P inner join Tbl_Window W on W.Id = P.CreatedById";

        public static string? WantedQuery { get; set; } = @"select ProductId, ProductCode,ProductName,Price,Quantity,CreatedDateTime,CreatedByName,W.UserName as Account_Name from Tbl_Productlist P inner join Tbl_Window W on W.Id = P.CreatedById";
    }
}
