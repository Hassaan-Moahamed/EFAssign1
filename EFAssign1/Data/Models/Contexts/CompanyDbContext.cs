using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFAssign1.Data.Models.Contexts
{
    internal class CompanyDbContext:DbContext
    {
        
        //CompanyDbContext() : base()
        //{

        //}
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server= . ; Database= MyCompany ; Trusted_Connection= true ;TrustServerCertificate=True");
        }
        public DbSet<Employee> Employees { get; set; }
    }
}
