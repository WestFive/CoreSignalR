using Microsoft.EntityFrameworkCore;
using MySQL.Data.EntityFrameworkCore.Extensions;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Data.TheDbContext
{
    public class UserContext:DbContext
    {
        public DbSet<User> User { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySQL(@"Server=60.205.200.73;port=3306;database=test;uid=root;pwd=520520");
            
        }
    }

    public class User
    {
        [Key]
        public int ID { get; set; }

        public string NAME { get; set; }

        public string AGE { get; set; }
    }
}
