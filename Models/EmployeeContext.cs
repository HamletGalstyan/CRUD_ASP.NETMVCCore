using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Asp.NetMVC_CRUD.Models
{
    public class ApplicationDbContextFactory : Microsoft.EntityFrameworkCore.Design.IDesignTimeDbContextFactory<EmployeeContext>
    {
        public EmployeeContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<EmployeeContext>();
            builder.UseSqlServer("Server=10.0.0.73\\MSSQLSERVER2016;Database=OpPISWebDevelopment;User Id=oppisweb;Password=oppisweb;Max Pool Size=10;Connection Timeout=100000;");

            return new EmployeeContext(builder.Options);
        }
    }
    public class EmployeeContext:DbContext
    {
        public EmployeeContext(DbContextOptions<EmployeeContext> options):base(options)
        {

        }

        public DbSet<Employee> Employees { get; set; }
    }
}
