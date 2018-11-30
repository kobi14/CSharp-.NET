using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using Testing.Models;

namespace Testing
{
    public class MainDbContext : DbContext
    {

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {

            //  Database.SetInitializer(new DropCreateDatabaseAlways<MainDbContext>());
        }

        public DbSet<Student> Students { get; set; }
    }
}