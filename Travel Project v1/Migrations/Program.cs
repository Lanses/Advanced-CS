using Microsoft.EntityFrameworkCore;
using System;

namespace Migrations
{
    public class Program : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

            optionsBuilder.UseSqlServer("Server=(localdb)\\MSSQLLocalDB;Database=Travel_Project_v1_DB;Trusted_Connection=True;MultipleActiveResultSets=true;");

        }
    }
}   
