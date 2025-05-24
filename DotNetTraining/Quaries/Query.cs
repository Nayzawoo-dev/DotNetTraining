using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetTraining.Quaries
{
    internal class Query
    {
        public static string UserLogin { get;} = "select * from Tbl_Window where UserName = @Username and Password = @Password";
        public static string ProductList { get; } = "";
    }
}
