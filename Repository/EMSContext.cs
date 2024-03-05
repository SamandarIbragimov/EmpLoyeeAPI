using EmployeeDAL;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpApi.Repository
{
    public class EMSContext : DbContext
    {
        public DbSet<Employee> EmployeeDB { get; set; }
        public DbSet<Department> DepartmentDB { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=ITWW011LAP65176; Database=EmpDB;User=sa;Password=Sam&ar$8; TrustServerCertificate=True");
        }
    }

    //1. Create the domain classes
    //2. Create a context class the domain classes
}
