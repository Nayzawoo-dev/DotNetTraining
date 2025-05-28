using Dapper;
using Microsoft.Data.SqlClient;
using System.Data;
using DapperWithConsoleApp;


UserClass use = new UserClass();
Console.WriteLine("Login To KBZ Pay");
Console.WriteLine("1.Login Account");
Console.WriteLine("2.Exit");

int option = Convert.ToInt32(Console.ReadLine()!);

switch (option)
{
    case 1: use.Login(); break;
}
