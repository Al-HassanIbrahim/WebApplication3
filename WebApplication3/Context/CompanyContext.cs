using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Update;
using System.Data.Common;
using WebApplication3.Models;

namespace WebApplication3.Context
{
    public class CompanyContext:DbContext
    {
        public DbSet<Department> Departments {  get; set; }
        public DbSet<Employee> Employees { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=.;DataBase=Company241006;Trusted_Connection=true;TrustServerCertificate=true");
            base.OnConfiguring(optionsBuilder);
        }
        
    }
}
