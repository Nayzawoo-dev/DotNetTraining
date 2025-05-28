using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Identity.Client.Extensibility;

namespace DapperWithConsoleApp
{
    internal class UserClass
    {
       private SqlServices? services;
        public void Login()
        {
        Before:
            Console.Write("Enter Your User Name : ");
            string? username = Console.ReadLine();
            Console.Write("Enter Your Password : ");
            string? pass = Console.ReadLine();
            services = new SqlServices();
            string query = "select * from Tbl_Window where UserName = @UserName and Password = @Password";
            var res =  services.Query<Person>(query, new Person
            {
                UserName = username,
                Password = pass,
            });

            if(res.Count == 0)
            {
                Console.WriteLine("Incorrect Password Or Phone Number (Exit(1) Or Try again(2)");
                int ques = Convert.ToInt32(Console.ReadLine());
                if(ques == 1)
                {
                    return;
                }
                else
                {
                    goto Before;
                }
            }

            Console.WriteLine($"Login Successful! {res[0].UserName}");
            Appsetting.CurrentUserName = username;
        }

        public void ViewAllProduct()
        {
            string query = "select * from Tbl_Productlist";
            var res = services.Query<Product>(query);
            foreach (var item in res)
            {
                Console.WriteLine($"{item.ProductCode} {item.ProductName} {item.Price} {item.Quantity} {item.CreatedByName}");
            }
        }

        public void UpdateProduct()
        {
            Console.WriteLine("You Can not Change Product Name And Code(Only Change Price And Quantity)");
        code:
            Console.Write("Enter Your Product Code : ");
            string code = Console.ReadLine()!;
            var res = services.Query<Product>("select * from Tbl_Productlist where ProductCode = @ProductCode",new Product
            {
                ProductCode = code
            });
            if(res.Count == 0)
            {
                Console.WriteLine("Product Not Found!");
                goto code;
            }
            Console.Write("Edit Price : ");
            decimal price = Convert.ToDecimal(Console.ReadLine());
            Console.Write("Edit Quantity : ");
            int quantity = Convert.ToInt32(Console.ReadLine());
            string query = @"UPDATE [dbo].[Tbl_Productlist]
   SET
       [Price] = @Price
      ,[Quantity] = @Quantity
      ,[CreatedDateTime] = @CreatedDateTime
      ,[CreatedByName] = @CreatedByName
 WHERE ProductCode = @ProductCode";

           int res2 = services.Execute(query, new Product
            {
                Price = price,
                Quantity = quantity,
                CreatedDateTime = DateTime.Now,
                CreatedByName = Appsetting.CurrentUserName,
                ProductCode = code
            });

            if(res2 > 0)
            {
                Console.WriteLine("Update Successful");
                var res3 = services.Query<Product>("select * from Tbl_Productlist where ProductCode = @ProductCode", new Product
                {
                    ProductCode = code
                });
                if (res3.Count > 0)
                {
                    Console.WriteLine($"{res3[0].ProductName} {res3[0].Price} {res3[0].Quantity} {res3[0].CreatedByName}");
                }
            }


        }

        public void DeleteProduct()
        {
            string query = @"DELETE FROM [dbo].[Tbl_Productlist]
      WHERE ProductCode = @ProductCode";
            Console.WriteLine("Enter Your Product Code!");
            string code = Console.ReadLine()!;
           Console.WriteLine("Are You Sure Want To Delete (y/n)");
            string con = Console.ReadLine()!;
            if (con.ToUpper() == "Y")
            {
                services.Execute(query,new Product
                {
                    ProductCode = code
                });
                Console.WriteLine("Delete Successful!");
            }
            else if(con.ToUpper() == "N")
            {
                return;
            }
        }

        public void InsertProduct()
        {
            string query = @"INSERT INTO [dbo].[Tbl_Productlist]
           ([ProductName]
           ,[Price]
           ,[Quantity]
           ,[CreatedDateTime]
           ,[CreatedByName])
     VALUES
           (@ProductName
           ,@Price
           ,@Quantity
           ,@CreatedDateTime
           ,@CreatedByName
           )";

            Console.Write("Enter Your Product Name : ");
            string name = Console.ReadLine()!;
            Console.Write("Enter Your Product Price : ");
            decimal price = Convert.ToDecimal(Console.ReadLine()!);
            Console.Write("Enter Your Quantity : ");
            int quantity = Convert.ToInt32(Console.ReadLine()!);    

            services.Execute(query, new Product
            {
                ProductName = name,
                Price = price,
                Quantity = quantity,
                CreatedDateTime = DateTime.Now,
                CreatedByName = Appsetting.CurrentUserName

            });
            Console.WriteLine("Update Successful");
            ViewAllProduct();
        }
        
       
    }
}
