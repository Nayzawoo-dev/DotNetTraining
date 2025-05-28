using Dapper;
using Microsoft.Data.SqlClient;
using System.Data;
using DapperWithConsoleApp;


UserClass use = new UserClass();
Console.WriteLine("Login To Staff Product ");
Console.WriteLine("1.Login Account");
Console.WriteLine("2.Exit");

int option = Convert.ToInt32(Console.ReadLine()!);

switch (option)
{
    case 1: use.Login();use.ViewAllProduct();Console.WriteLine("Choose Option!\n" +
        "1.Update Product\n" +
        "2.Delete Product\n" +
        "3.Insert Product");
        int opt = Convert.ToInt32(Console.ReadLine());
            switch (opt) {
            case 1: use.UpdateProduct();break;
            case 2: use.DeleteProduct();break;
            case 3: use.InsertProduct();break; 
        }
        ;break;
    case 2: break; 
}
