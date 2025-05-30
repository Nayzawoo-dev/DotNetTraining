using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace AdoDapperTest
{
    [Table("Tbl_Window")]
    public class Person
    {
        [Key]
        public int Id { get; set; } 
        public string UserName { get; set; }
        public string Password { get; set; }    
    }

    public class PersonDbcontext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=DELL; Database=DotNetTraining; User Id=SA; Password=root; TrustServerCertificate=true;");
            }
        }
        public DbSet<Person> PersonDatabase { get; set; }
    }
}
