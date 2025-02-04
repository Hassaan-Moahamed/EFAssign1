using EFAssign1.Data.Models.Contexts;
using Microsoft.EntityFrameworkCore;

namespace EFAssign1
{
    internal class Program
    {
        //class employee 
        //make models => contexts => company dbcontext
        //overide in OnConfiguring to contact with sqlserver
        //Dbset 
        //Migration (Add-Migration "InitialCreate")
        //Migration (Add-Migration "ChangeName")/Change name of employee
        //update-database
        // using (CompanyDbContext dbcontext = new CompanyDbContext()) dbcontext.Database.Migrate();
        static void Main(string[] args)
        {





            //using CompanyDbContext dbcontext = new CompanyDbContext();
            //var employee = dbcontext.Employees.Where(e => e.age > 10);

            //using (CompanyDbContext dbcontext = new CompanyDbContext()) dbcontext.Database.Migrate();
            
            //using (CompanyDbContext dbcontext = new CompanyDbContext())
            //{
            //}
            
            //CompanyDbContext dbcontext = new CompanyDbContext();
            //try
            //{

            //}
            //finally
            //{
            //    dbcontext.Dispose();
            //}
        }
    }
}
