using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DapperWithConsoleApp
{
    internal class Product
    {
        public int ProductId { get; set; }
        public string ProductCode { get; set; }
        public string ProductName { get; set; }

        public decimal Price { get; set; }
        public int Quantity { get; set; }

        public DateTime CreatedDateTime { get; set; }

        public string CreatedByName { get; set; }

    }

    internal class Person
    {
        public int Id { get; set; }
        public string? UserName { get; set; }
        public string? Password { get; set; }
    }
}
