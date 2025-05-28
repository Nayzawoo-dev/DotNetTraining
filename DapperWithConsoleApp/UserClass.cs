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
            Console.WriteLine("Enter Your Phone Number!");
            long ph_no = Convert.ToInt64(Console.ReadLine());
            Console.WriteLine("Enter Your Password");
            string? pass = Console.ReadLine();
            services = new SqlServices();
            string query = "select * from Tbl_Window where Password = @Password";
            var res =  services.Query<Person>(query, new Person
            {
                Password = pass,
            });

            if(res.Count == 0)
            {
                Console.WriteLine("Incorrect Password Or Phone Number");
                goto Before;
            }

            Console.WriteLine($"Login Successful! {res[0].UserName}");
        }
    }
}
