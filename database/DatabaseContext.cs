using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using finalPOCService.models;
using Microsoft.EntityFrameworkCore;

namespace finalPOCService.database
{
    public class DatabaseContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=NL10-DF2608\\SQLEXPRESS01;Initial Catalog=userdb;Integrated Security=True;Encrypt=False;");
        }

        public DbSet<User> users {get; set;}
        public DbSet<Employee> employee {get; set;}
        public DbSet<Movie> movies {get; set;}
    }
}